Imports MySql.Data.MySqlClient

Public Class FrmMain

    'DECLARACIÓN DE VARIABLES
    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta As String
    Public idUser, nomUser, cargoUser As String

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'CONECTA Y ABRE LA BASE DE DATOS
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'HACER CONSULTA PARA COMPROBAR SI HAY PRECIO Y DESCUENTO
            sqlConsulta = "SELECT * FROM trfa_dscto"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader

            If drDataReader.HasRows Then
                'CERRAR EL DATAREADER
                drDataReader.Close()

                'OBTENEMOS EL DÍA DEL MES ACTUAL
                Dim strDia As String = DateTime.Now.Day

                'COMPROBAMOS SI ES EL PRIMER DÍA DEL MES
                If strDia = 1 Then
                    'HACEMOS LA CONSULTA PARA OBTENER LOS ID Y LA FECHA DE NACIEMIENTO DE LOS CLIENTES ACTIVOS
                    sqlConsulta = "SELECT id_cli, fdn_cli FROM clientes WHERE std_cli = 'SI'"
                    cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                    drDataReader = cmdCommand.ExecuteReader()

                    'CREAMOS UN DATATABLE PARA ALMACENAR LOS ID Y LA FDN OBTENIDOS EN LA CONSULTA
                    Dim dtPago As New DataTable("Pago")
                    dtPago.Columns.Add("IdCli", GetType(Int16))
                    dtPago.Columns.Add("Descto", GetType(Decimal))
                    If drDataReader.HasRows Then
                        While drDataReader.Read()
                            Dim edad = Int(DateDiff("m", drDataReader.GetDateTime(1).ToString, Now) / 12)
                            dtPago.Rows.Add(drDataReader.GetInt16(0).ToString, edad)
                        End While
                    End If
                    drDataReader.Close()

                    'CREAMOS UN DATATABLE PARA ALMACENAR LOS ID Y LA FDN OBTENIDOS EN LA CONSULTA
                    Dim dtInsertPago As New DataTable("InsertPago")
                    dtInsertPago.Columns.Add("IdCli", GetType(Int16))
                    dtInsertPago.Columns.Add("Descto", GetType(Decimal))
                    For Each iFe As DataRow In dtPago.Rows
                        'COMPROBAR SI HAY ALGUN REGISTRO CON EL PRIMER DÍA DEL MES
                        sqlConsulta = "SELECT fdi_pgs, id_cli FROM pagos WHERE fdi_pgs = '" & DateTime.Now.ToString("yyyy-MM-dd") & "' AND id_cli = '" & iFe("IdCli") & "'"
                        cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                        drDataReader = cmdCommand.ExecuteReader
                        If Not drDataReader.HasRows Then
                            dtInsertPago.Rows.Add(iFe("IdCli"), iFe("Descto"))
                        End If
                        drDataReader.Close()
                    Next

                    'SELECCIONAMOS EL DESCUENTO Y EL PRECIO Y AGREGAMOS EL CAMPO PRECIO
                    dtInsertPago.Columns.Add("Precio", GetType(Decimal))
                    For Each iFe As DataRow In dtInsertPago.Rows
                        sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE emin_trfa <= '" & iFe("Descto") & "' AND emax_trfa >= '" & iFe("Descto") & "'"
                        cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                        drDataReader = cmdCommand.ExecuteReader
                        'COMPROBAMOS SI HAY O NO DESCUENTOS
                        If drDataReader.HasRows Then
                            drDataReader.Read()
                            iFe("Precio") = drDataReader.GetDecimal(0)
                            iFe("Descto") = drDataReader.GetDecimal(1)
                        Else
                            drDataReader.Close()
                            sqlConsulta = "SELECT prcio_trfa FROM dscto_trfa WHERE id_trfa = 1"
                            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                            drDataReader = cmdCommand.ExecuteReader
                            drDataReader.Read()
                            iFe("Precio") = drDataReader.GetDecimal(0)
                            iFe("Descto") = 0
                        End If
                        drDataReader.Close()
                    Next

                    'AGREGAMOS LOS NUEVOS REGISTROS EN LA TABLA PAGOS
                    For Each iFe As DataRow In dtInsertPago.Rows
                        Dim precio = Replace(iFe("Precio"), ",", ".")
                        Dim descto = Replace(iFe("Descto"), ",", ".")
                        sqlConsulta = "INSERT INTO pagos (fdi_pgs, fdp_pgs, frm_pgs, prc_pgs, dsc_pgs, id_cli, usuario)
                                      VALUES ('" & DateTime.Now.ToString("yyyy-MM-dd") & "', '0101-01-01', '',
                                      '" & precio & "', '" & descto & "', '" & iFe("IdCli") & "','')"
                        cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                        drDataReader = cmdCommand.ExecuteReader()
                        drDataReader.Close()
                    Next

                    'BORRAMOS LOS DATATABLE dtPago Y dtInsertPago
                    dtPago = Nothing
                    dtInsertPago = Nothing
                End If

                'EJECUTA EL FORMULARIO LISTA MOROSOS
                'FrmListaMorosos.MdiParent = Me
                'FrmListaMorosos.Show()

                ' COMPROBAR SI NO ES ADMIN PARA DESACTIVAR BUTTON
                If cargoUser <> "ADMINISTRADOR" Then BtnPrecioDsctos.Enabled = False
            Else
                'CERRAR EL DATAREADER
                drDataReader.Close()

                'DESHABILITAR BOTONES
                BtnListaClientes.Enabled = False
                BtnClientesPagos.Enabled = False
                BtnPagoPendiente.Enabled = False

                'EJECUTA EL FORMULARIO TABLA DE DESCUENTOS
                If cargoUser = "ADMINISTRADOR" Then
                    'FrmTablaDescuento.MdiParent = Me
                    'FrmTablaDescuento.Show()
                Else
                    BtnPrecioDsctos.Enabled = False
                End If
            End If

        Catch ex As Exception
            '
            MsgBox(ex.ToString)

        Finally

            'CERRAR BBDD
            cnxnMySql.Close()

        End Try

        'AGREGAR NOMBRE DE USUARIO A LA BARRA DE TITULO
        Me.Text = Me.Text & nomUser & " - " & cargoUser
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'COMPRUEBA SI EL FORMULARIO DE ESTÁ CERRANDO
        Try
            If MsgBox("¿Está seguro que desea CERRAR la aplicación?", vbQuestion + vbYesNo, "Segundos Fuera") = vbNo Then
                e.Cancel = True
            Else
                cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                cnxnMySql.Open()
                sqlConsulta = "UPDATE sesion_user SET fh_salida ='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' ORDER BY id_reg DESC LIMIT 1"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()

                '
                End
            End If

        Catch ex As Exception
            '
            MsgBox(ex.ToString)
        Finally
            '
            drDataReader.Close()
            cnxnMySql.Close()
        End Try
    End Sub

    Private Sub BtnListaClientes_Click(sender As Object, e As EventArgs) Handles BtnListaClientes.Click
        'FrmListaClientes.MdiParent = Me
        'FrmListaClientes.Show()
    End Sub

    Private Sub BtnClientesPagos_Click(sender As Object, e As EventArgs) Handles BtnClientesPagos.Click
        'FrmClientesPagos.MdiParent = Me
        'FrmClientesPagos.Show()
    End Sub

    Private Sub BtnPagoPendiente_Click(sender As Object, e As EventArgs) Handles BtnPagoPendiente.Click
        ''EJECUTA FORMULARIO LISTA MOROSOS
        'FrmListaMorosos.MdiParent = Me
        'FrmListaMorosos.Show()
    End Sub

    Private Sub BtnPrecioDsctos_Click(sender As Object, e As EventArgs) Handles BtnPrecioDsctos.Click
        ''EJECTA FORMULARIO TABLA DE DESCUENTOS
        'FrmTablaDescuento.MdiParent = Me
        'FrmTablaDescuento.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        'CIERRA EL FORMULARIO
        Close()
    End Sub

End Class