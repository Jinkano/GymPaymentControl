Imports MySql.Data.MySqlClient

Public Class FrmNewModifyClient

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta, strEstado, strMtdPgs, strIdGrupo, strAddMembers As String
    Dim nRow, intAddMember As Int16
    Public Shared strIdCli As String

    Private Sub FrmNewModifyClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '' COMPROBAMOS EL TÍTULO PARA DESACTIVAR UN BOTON
        'If Me.Text = "Registrar nuevo cliente" Then
        '    BtnActualizar.Enabled = False
        'Else
        '    BtnGuardar.Enabled = False
        'End If

        'LIMPIAMOS EL DTPFDN CON UN ESPACIO EN BLANCO
        DtpFdn.CustomFormat = " "

        'VARIABLE PARA ALMACENAR LA FECHA ACTUAL
        Dim ano = Year(Date.Now)

        'ASIGNAR VALORES NIM Y MAX A LOS DATETIMEPICKER
        DtpFdn.MinDate = "01/01/" & ano - 90
        DtpFdn.MaxDate = DateTime.Now
        DtpFdn.Value = "01/07/" & ano - 25
        TxtEdad.Text = ""
        DtpFdi.MinDate = "01/01/" & ano - 1
        DtpFdi.MaxDate = "31/12/" & ano + 1
    End Sub
    '
    '
    '   
    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        'VALIDAR SOLO LETRAS
    End Sub
    Private Sub TxtNombre_GotFocus(sender As Object, e As EventArgs) Handles TxtNombre.GotFocus
        'CAMBIA EL COLOR AL RECIBIR EL ENFOQUE
        TxtNombre.BackColor = Color.Beige
    End Sub
    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        'TxtNombre_KeyPress
    End Sub
    Private Sub TxtNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtNombre.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtNombre)
    End Sub
    '
    '
    '
    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        'VALIDAR SOLO LETRAS
    End Sub
    Private Sub TxtApellido_GotFocus(sender As Object, e As EventArgs) Handles TxtApellido.GotFocus
        'CAMBIA EL COLOR AL RECIBIR EL ENFOQUE
        TxtApellido.BackColor = Color.Beige
    End Sub
    Private Sub TxtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellido.KeyPress
        'TxtApellido_KeyPress
    End Sub
    Private Sub TxtApellido_LostFocus(sender As Object, e As EventArgs) Handles TxtApellido.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtApellido)
    End Sub
    '
    '
    '
    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
        'VALIDAR SOLO LETRAS
    End Sub
    Private Sub TxtTelefono_GotFocus(sender As Object, e As EventArgs) Handles TxtTelefono.GotFocus
        'CAMBIA EL COLOR AL RECIBIR EL ENFOQUE
        TxtTelefono.BackColor = Color.Beige
    End Sub
    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        'TxtTelefono_KeyPress
    End Sub
    Private Sub TxtTelefono_LostFocus(sender As Object, e As EventArgs) Handles TxtTelefono.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtTelefono)
    End Sub
    '
    '
    '
    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged
        'VALIDAR SOLO LETRAS
    End Sub
    Private Sub TxtEmail_GotFocus(sender As Object, e As EventArgs) Handles TxtEmail.GotFocus
        'CAMBIA EL COLOR AL RECIBIR EL ENFOQUE
        TxtEmail.BackColor = Color.Beige
    End Sub
    Private Sub TxtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmail.KeyPress
        'TxtEmail_KeyPress
    End Sub
    Private Sub TxtEmail_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtEmail)
    End Sub
    '
    '
    '
    Private Sub TxtDireccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDireccion.TextChanged
        'VALIDAR SOLO LETRAS
    End Sub
    Private Sub TxtDireccion_GotFocus(sender As Object, e As EventArgs) Handles TxtDireccion.GotFocus
        'CAMBIA EL COLOR AL RECIBIR EL ENFOQUE
        TxtDireccion.BackColor = Color.Beige
    End Sub
    Private Sub TxtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccion.KeyPress
        'TxtDireccion_KeyPress
    End Sub
    Private Sub TxtDireccion_LostFocus(sender As Object, e As EventArgs) Handles TxtDireccion.LostFocus
        'FUNCION PARA BORRAR ESPACIOS EN BLANCO Y CAMBIO DE COLOR
        TxtLostFocus(TxtDireccion)
    End Sub
    '
    '
    '
    Private Sub TxtListaNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtListaNombre.TextChanged
        '-*/
        If RbGrupoFamiliar.Checked Then
            sqlConsulta = "SELECT * FROM grp_familiar WHERE nom_grp LIKE '%" & TxtListaNombre.Text & "%' ORDER BY nom_grp"
            LlenarDgvListaNombre(sqlConsulta)
        End If
        '
    End Sub
    Private Sub TxtListaNombre_GotFocus(sender As Object, e As EventArgs) Handles TxtListaNombre.GotFocus
        'TxtListaNombre_GotFocus
    End Sub
    Private Sub TxtListaNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtListaNombre.KeyPress
        'TxtListaNombre_KeyPress
    End Sub
    Private Sub TxtListaNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtListaNombre.LostFocus
        'TxtListaNombre_LostFocus
    End Sub
    '
    '
    '
    Private Sub DtpFdn_ValueChanged(sender As Object, e As EventArgs) Handles DtpFdn.ValueChanged

        'CALCULAR LA EDAD Y ALMACENAR EN LA VARIBLE
        Dim dtpEdad = Int(DateDiff("m", DtpFdn.Value, Now) / 12)

        TxtEdad.Text = dtpEdad & " años" 'MOSTRAR EDAD
        'COMPROBAR LA EDAD
        'If dtpEdad < 1 Then TxtEdad.Text = "0 años"
        'If dtpEdad > 99 Then TxtEdad.Text = "99 años"
    End Sub
    Private Sub DtpFdn_GotFocus(sender As Object, e As EventArgs) Handles DtpFdn.GotFocus

        TxtEdad.BackColor = Color.Beige 'CAMBIAR COLOR

        DtpFdn.CustomFormat = "' ' dd ' de  ' MMMM ' de  ' yyyy" 'LLENAMOS EL DTPFDN CON UNA FECHA PERSONALIZADA
    End Sub
    Private Sub DtpFdn_LostFocus(sender As Object, e As EventArgs) Handles DtpFdn.LostFocus
        'CAMBIAR COLOR 
        TxtEdad.BackColor = Color.Azure
        If TxtEdad.Text = "" Then TxtEdad.BackColor = Color.MistyRose
    End Sub
    '
    '
    '
    Private Sub DtpFdi_ValueChanged(sender As Object, e As EventArgs) Handles DtpFdi.ValueChanged
        'DtpFdi_ValueChanged
    End Sub
    '
    '
    '
    Private Sub RbEstadoActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RbEstadoActivo.CheckedChanged
        'RbEstadoActivo_CheckedChanged
    End Sub
    Private Sub RbEstadoInactivo_CheckedChanged(sender As Object, e As EventArgs) Handles RbEstadoInactivo.CheckedChanged
        'RbEstadoInactivo_CheckedChanged
    End Sub
    '
    '
    '
    Private Sub RbDiario_CheckedChanged(sender As Object, e As EventArgs) Handles RbDiario.CheckedChanged
        ''Nombre del grupo
        'If RbDiario.Checked Then
        'End If
    End Sub
    Private Sub RbDiario_Click(sender As Object, e As EventArgs) Handles RbDiario.Click

        TxtListaNombre.Text = "" 'LIMPIAMOS EL TEXTBOX
        'LblMetodoPago.BackColor = Color.Azure

        GbListaGrupoFamiliar.Text = "Lista clases sueltas" 'CAMBIAMOS EL TITULO DEL GROUPBOX

        'BtnAddGrupo.Enabled = False 'DESACTIVAMOS EL BUTTON ADDGRUPO

        'TxtListaNombre.Enabled = False 'DESACTIVAMOS EL TEXTBOX

        'LblNumIntgrntes.Text = "" 'LIMPIAMOS EL LABEL

        DgvListaNombre.Enabled = True

        'USAMOS TRY PARA CONTROLAR POSIBLES ERRORES
        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            sqlConsulta = "SELECT id_trfa, tipo_trfa FROM trfa_dscto WHERE tipo_trfa LIKE '%DIARIO%'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            DgvListaNombre.Rows.Clear()
            'COMPROBAMOS SI HAY REGISTROS
            If drDataReader.HasRows Then
                While drDataReader.Read()
                    nRow = DgvListaNombre.Rows.Add()
                    DgvListaNombre.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0) '.ToString 'ID
                    DgvListaNombre.Rows(nRow).Cells(1).Value = drDataReader.GetString(1) 'NOMBRE TIPO TARIFA
                End While
            End If
            'CERRAMOS EL DATA READER
            drDataReader.Close()
        Catch ex As Exception
            '
            MsgBox(ex.Message)
        Finally
            'CERRAMOS LA BASE DE DATOS
            cnxnMySql.Close()
        End Try
        'Else
        'GbListaPrecio.Text = "Lista"
    End Sub
    '
    '
    '
    Private Sub RbMensual_CheckedChanged(sender As Object, e As EventArgs) Handles RbMensual.CheckedChanged
        ''Nombre del grupo
        'If RbMensual.Checked Then
        'End If
    End Sub
    Private Sub RbMensual_Click(sender As Object, e As EventArgs) Handles RbMensual.Click

        'LLENAMOS EL LABEL CON EL NOMBRE DEL METODO DEL PAGO PARA GUARDAR EN LA TABLA
        TxtListaNombre.Text = "" 'LIMPIAMOS EL TEXTBOX
        'LblMetodoPago.Text = "MENSUAL"
        'LblMetodoPago.BackColor = Color.Azure

        'BtnAddGrupo.Enabled = False 'DESACTIVAMOS EL BUTTON ADDGRUPO

        GbListaGrupoFamiliar.Text = "Lista vacia" 'CAMBIAMOS EL NOMBRE DEL GROUPBOX

        'TxtListaNombre.Enabled = False 'DESACTIVAMOS EL TEXTBOX

        'LblNumIntgrntes.Text = ""

        DgvListaNombre.Rows.Clear()
        DgvListaNombre.Enabled = False

    End Sub
    '
    '
    '
    Private Sub RbGrupoFamiliar_CheckedChanged(sender As Object, e As EventArgs) Handles RbGrupoFamiliar.CheckedChanged
        'Nombre del grupo
        If RbGrupoFamiliar.Checked Then

            TxtListaNombre.Text = "" 'LIMPIAMOS EL TEXTBOX
            'LblMetodoPago.BackColor = Color.Azure

            GbListaGrupoFamiliar.Text = "Lista de grupos familiares" 'CAMBIAMOS EL TITULO DEL GROUPBOX

            BtnAddGrupo.Enabled = True 'ACTIVAMOS EL BUTTON ADDGRUPO

            TxtListaNombre.Enabled = True 'ACTIVAMOS EL TEXTBOX

            LblNumIntgrntes.Text = "" 'LIMPIAMOS EL LABEL

            DgvListaNombre.Enabled = True

            'HACEMOS LA CONSULTA Y SE LO PASAMOS A LA FUNCIÓN PARA LLENAR EL DATAGRIDVIEW CON LOS GRUPOS FAMILIARES
            sqlConsulta = "SELECT * FROM grp_familiar ORDER BY id_grp DESC"
            LlenarDgvListaNombre(sqlConsulta)

        Else 'RbGrupoFamiliar.Checked=FALSE
            '
            BtnAddGrupo.Enabled = False  'DESACTIVAMOS EL BUTTON ADDGRUPO

            TxtListaNombre.Enabled = False  'DESACTIVAMOS EL TEXTBOX

            LblNumIntgrntes.Text = "" 'LIMPIAMOS EL LABEL

            'DgvListaNombre.Enabled = False
        End If
    End Sub
    '
    '
    '
    Private Sub BtnAddGrupo_Click(sender As Object, e As EventArgs) Handles BtnAddGrupo.Click
        '::: 987 :::'
        RbGrupoFamiliar.Checked = False
        FrmFamilyGroup.Show()
    End Sub
    '
    '
    '
    Private Sub DgvListaNombre_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaNombre.CellContentClick
    End Sub
    Private Sub DgvListaNombre_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaNombre.CellClick
        If RbDiario.Checked Then
            'LLENAMOS EL TEXTBOX CON EL NOMBRE DE LA CLASE SUELTA PARA GUARDAR EN LA TABLA
            TxtListaNombre.Text = DgvListaNombre.CurrentRow.Cells(1).Value
        End If
    End Sub
    Private Sub DgvListaNombre_DoubleClick(sender As Object, e As EventArgs) Handles DgvListaNombre.DoubleClick

        'COMPROBAR SI EL RADIOBUTTON ESTÁ ACTIVADO
        If RbGrupoFamiliar.Checked Then

            'SI LA CANTIDAD DE INTEGRANTES ES = A LOS INTEGRANTES REGISTRADOS
            If DgvListaNombre.CurrentRow.Cells(2).Value = DgvListaNombre.CurrentRow.Cells(3).Value Then

                'ADVERTENCIA QUE EL GRUPO ESTA LLENO, PREGUNTA SI QUIEREN AGREGAR UN NUEVO INTEGRANTES
                If MsgBox("    Nombre del grupo  : " & DgvListaNombre.CurrentRow.Cells(1).Value & vbCr &
                          "    Nº de Integrante     : " & DgvListaNombre.CurrentRow.Cells(2).Value & vbCr & vbCr &
                          "    El grupo seleccionado ya tiene los integrantes completos." & vbCr &
                          "    ___________________________________________________________" & vbCr & vbCr &
                          "                        ¿Seguro que quieres añadir otro integrante?",
                          vbExclamation + vbYesNo + vbDefaultButton2, "Comprobar datos") = vbYes Then

                    'AUMENTAMOS EN UNO EL NÚMERO DE INTEGRANTES PARA COMPROBAR SI HAY UNA TARIFA Y ACTUALIZAR LOS DATOS DEL GRUPO
                    intAddMember = DgvListaNombre.CurrentRow.Cells(2).Value + 1

                    '::: COMPROBAMOS SI EXISTE UNA TARIFA CON EL NÚMERO DE INTEGRANTES :::'
                    'USAMOS TRY PARA CONTROLAR POSIBLES ERRORES
                    Try
                        'CONECTAR Y ABRIR LA BBDD
                        cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                        cnxnMySql.Open()
                        'HACEMOS LA CONSULTA
                        sqlConsulta = "SELECT nperson_trfa FROM trfa_dscto WHERE nperson_trfa = '" & intAddMember & "'"
                        cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                        drDataReader = cmdCommand.ExecuteReader()
                        'COMPROBAMOS SI NO HAY REGISTROS
                        If Not drDataReader.HasRows Then
                            'PREGUNTAMOS SI QUIERE AGREGAR UNA TARIFA
                            If MsgBox("   No hay una tarifa para " & intAddMember & " integrantes." & vbCr &
                                      "   ______________________________________" & vbCr & vbCr &
                                      "                ¿Quieres agergar una tarifa?",
                                        vbYesNo + vbDefaultButton2 + vbQuestion, "Lista de integrantes") = vbYes Then
                                'PONEMOS LA VARIABLE EN 0 Y MOSTRAMOS EL FORM
                                intAddMember = 0
                                FrmDiscountTable.Show()
                            End If
                        Else 'SI HAY REGISTROS (TARIFA PARA LA CANTIDAD DE INTEGRANTES)
                            'CERRAMOS LA BASE DE DATOS
                            cnxnMySql.Close()
                            'LLENAMOS EL TEXTBOX CON EL NOMBRE DEL GRUPO
                            TxtListaNombre.Text = DgvListaNombre.CurrentRow.Cells(1).Value
                            'LLENAMOS LA VARIABLE PARA ACTUALIZAR LOS CAMPOS num_intgrntes_grp Y intgrntes_reg_grp AL MOMENTO DE GUARDAR
                            strAddMembers = "UPDATE_TWO_FIELDS"
                        End If
                    Catch ex As Exception
                        'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
                        MsgBox(ex.ToString)
                    Finally
                        'CERRAMOS LA BASE DE DATOS
                        cnxnMySql.Close()
                    End Try

                Else 'SI HACEMOS CLICK EN NO

                    TxtListaNombre.Text = "" 'LIMPIAMOS EL TEXTBOX PARA NO PODER GUARDAR SIN SELECCIONASR UN GRUPO
                End If

            Else 'SI LA CANTIDAD DE INTEGRANTES ES DIFERENTE QUE LOS INTEGRANTES REGISTRADOS

                '::: LLENAMOS EL TEXTBOX CON EL NOMBRE DEL GRUPO
                '    PASAMOS LA VARIABLE A FALSE PARA ACTUALIZAR EL CAMPO intgrntes_reg_grp
                '    CON EL VALOR DE LA VARIABLE intAddMember DEL REGISTRO SELECCIONADO,
                '    AL MOMENTO DE GUARDAR LOS DATOS DEL CLIENTE :::'
                TxtListaNombre.Text = DgvListaNombre.CurrentRow.Cells(1).Value
                intAddMember = DgvListaNombre.CurrentRow.Cells(3).Value + 1
                strAddMembers = "UPDATE_A_FIELD"

            End If
        End If
    End Sub
    '
    '
    '
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        '::::: COMPROBAMOS SI HAY INFORMACION DEL CLIENTE :::::'
        If TxtNombre.Text = "" Then
            MsgBox("Ingrese el NOMBRE del cliente.", vbCritical, "Comprobar datos")
            TxtNombre.Focus() : Exit Sub
        End If
        If TxtApellido.Text = "" Then
            MsgBox("Ingrese el APELLIDO del cliente.", vbCritical, "Comprobar datos")
            TxtApellido.Focus() : Exit Sub
        End If
        If TxtEdad.Text = "" Then
            MsgBox("Corrige la fecha de NACIMIENTO del cliente.", vbCritical, "Comprobar datos")
            DtpFdn.Focus() : Exit Sub
        End If
        If Not RbDiario.Checked And Not RbMensual.Checked And Not RbGrupoFamiliar.Checked Then
            MsgBox("Selecciona un MÉTODO de pago.", vbCritical, "Comprobar datos")
            Exit Sub
        End If
        If RbDiario.Checked And TxtListaNombre.Text = "" Then
            MsgBox("Selecciona un PAGO de la lista.", vbCritical, "Comprobar datos")
            DgvListaNombre.Focus() : Exit Sub
        End If
        If RbGrupoFamiliar.Checked And TxtListaNombre.Text = "" Then
            MsgBox("Selecciona un GRUPO de la lista.", vbCritical, "Comprobar datos")
            DgvListaNombre.Focus() : Exit Sub
        End If

        '::: COMPROBAR QUE RADIOBUTTON ESTA ACTIVADO PARA ASIGNAR UN VALOR A LA VARIABLE,
        '    VALOR QUE SE USARÁ PARA GUARDAR EL METODO DE PAGO EN LA TABLA CLIENTES :::'
        If RbDiario.Checked Then strMtdPgs = TxtListaNombre.Text
        If RbMensual.Checked Then strMtdPgs = "MENSUAL"
        If RbGrupoFamiliar.Checked Then strMtdPgs = "GRUPAL"

        '::: COMPROBAR QUE RADIOBUTTON ESTA ACTIVADO PARA GUARDAR EL ESTADO DEL CLIENTE :::'
        If RbEstadoActivo.Checked Then strEstado = "ACTIVO"
        If RbEstadoInactivo.Checked Then strEstado = "INACTIVO"

        '::: USAMOS TRY PARA CONTROLAR POSIBLES ERRORES :::'
        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            '::: COMPROBAMOS EL VALOR DE LA VARIABLE strMpago PARA HACER LA CONSULTA A LA BBSDD :::::'
            If strMtdPgs = "GRUPAL" Then

                'CONSULTA A LA BBDD CON EL ID DEL GRUPO FAMILIAR
                sqlConsulta = "INSERT INTO clientes (nom_cli, ape_cli,
                                fdn_cli, tlf_cli, eml_cli, dir_cli,
                                mpg_cli, fdi_cli, std_cli, id_grp) VALUES
                                ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "',
                                '" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', '" & TxtTelefono.Text & "',
                                '" & TxtEmail.Text & "', '" & TxtDireccion.Text & "',
                                '" & strMtdPgs & "', '" & DtpFdi.Value.Date.ToString("yyyy-MM-dd") & "',
                                '" & strEstado & "', '" & DgvListaNombre.CurrentRow.Cells(0).Value & "')"

            Else 'SI LA VARIABLE strMpago ES MENSUAL O DIARIO

                'CONSULTA A LA BBDD SIN EL ID DEL GRUPO FAMILIAR
                sqlConsulta = "INSERT INTO clientes (nom_cli, ape_cli,
                                fdn_cli, tlf_cli, eml_cli, dir_cli,
                                mpg_cli, fdi_cli, std_cli) VALUES
                                ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "',
                                '" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', '" & TxtTelefono.Text & "',
                                '" & TxtEmail.Text & "', '" & TxtDireccion.Text & "',
                                '" & strMtdPgs & "', '" & DtpFdi.Value.Date.ToString("yyyy-MM-dd") & "',
                                '" & strEstado & "')"
            End If
            'EJECUTAR LA CONSULTA PARA AGREGAR EL NUEVO CLIENTE A LA TABLA
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()

            '::: OBTENEMOS EL ID DEL ÚLTIMO REGISTRO Y LO ALMACENAMOS EN LA VARIABLE strIdCli :::'
            sqlConsulta = "SELECT id_cli FROM clientes ORDER BY id_cli DESC LIMIT 1"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            drDataReader.Read()
            strIdCli = drDataReader.GetInt16(0).ToString
            drDataReader.Close()

            '::: CONSULTAMOS A LA BBDD LA TARIFA CORRESPONDIENTE AL NUEVO CLIENTE
            '    LA CONSULTA DEPENDE DEL VALOR DE LA VARIABLE strMpago :::'
            Select Case strMtdPgs
                Case "DIARIO"
                    sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE tipo_trfa = '" & strMtdPgs & "'"
                Case "MENSUAL"
                    sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE emin_trfa <= '" & TxtEdad.Text & "' AND emax_trfa >= '" & TxtEdad.Text & "'"
                Case "GRUPAL"
                    sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE nperson_trfa = '" & DgvListaNombre.CurrentRow.Cells(2).Value & "'"
            End Select
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            'CREAMOS DOS VARIABLES PARA ALMACENAR EL PRECIO Y EL DSCTO
            Dim precio, dscnto As Decimal
            'COMPROBAMOS SI HAY REGISTROS 
            If drDataReader.HasRows Then
                drDataReader.Read()
                precio = drDataReader.GetDecimal(0) 'Replace(drDataReader.GetDecimal(0).ToString, ",", ".")
                dscnto = drDataReader.GetDecimal(1) 'Replace(drDataReader.GetDecimal(1).ToString, ",", ".")
            Else
                drDataReader.Close()
                sqlConsulta = "SELECT prcio_trfa FROM trfa_dscto WHERE tipo_trfa = 'MENSUAL'" 'id_tarifa = 1
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader
                drDataReader.Read()
                precio = drDataReader.GetDecimal(0) 'Replace(drDataReader.GetDecimal(0).ToString, ",", ".")
                dscnto = 0
            End If
            drDataReader.Close()

            '::: AGREGAMOS UN NUEVO REGISTRO EN LA TABLA PAGOS :::'
            sqlConsulta = "INSERT INTO pagos (fdi_pgs, mtd_pgs, prc_pgs, dsc_pgs, id_cli, id_user)
                           VALUES ('" & DateTime.Now.ToString("yyyy-MM-dd") & "', '" & strMtdPgs & "',
                                '" & Replace(precio, ",", ".") & "', '" & Replace(dscnto, ",", ".") & "',
                                '" & strIdCli & "', '" & FrmMain.idUser & "')"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()

            '::: COMPROBAMOS EL VALOR DE LA VARIABLE strAddMembers PARA HACER LA CONSULTA A LA BBDD :::'
            Select Case strAddMembers
                Case "UPDATE_A_FIELD"
                    'ACTUALIZAR UN CAMPO DEL REGISTRO
                    sqlConsulta = "UPDATE grp_familiar SET
                                    intgrntes_reg_grp = '" & intAddMember & "'
                                    WHERE id_grp = '" & DgvListaNombre.CurrentRow.Cells(0).Value & "'"

                Case "UPDATE_TWO_FIELDS"
                    'ACTUALIZAMOS DOS CAMPOS DEL REGISTRO
                    sqlConsulta = "UPDATE grp_familiar SET
                                    num_intgrntes_grp = '" & intAddMember & "',
                                    intgrntes_reg_grp = '" & intAddMember & "'
                                    WHERE id_grp = '" & DgvListaNombre.CurrentRow.Cells(0).Value & "'"
            End Select
            'EJECUTAMOS LA CAONSULTA Y ACTUALIZAMOS LOS CAMPOS DEL GRUPO FAMILIAR
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()

        Catch ex As Exception
            'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
            MsgBox(ex.ToString)
        Finally
            'CERRAMOS EL DATAREADER Y LA BBDD
            drDataReader.Close()
            cnxnMySql.Close()
        End Try

        '::: DAR FORMATO EL CODIGO DEL CLIENTE PARA EL MENSAJE DE CONFIRMACIÓN :::'
        If strIdCli.Length = 1 Then strIdCli = "CLI - 00" & strIdCli
        If strIdCli.Length = 2 Then strIdCli = "CLI - 0" & strIdCli
        If strIdCli.Length = 3 Then strIdCli = "CLI - " & strIdCli
        'MOSTRAMOS UN MESAJE DE CONFIRMACIÓN
        MsgBox("Datos GUARDADOS satisfactoriamente." & Chr(13) & Chr(13) _
                & "NOMBRE   :  " & TxtNombre.Text & " " & TxtApellido.Text & Chr(13) _
                & "CODIGO   :  " & strIdCli, vbInformation, "Guardar Cliente")


        'FrmListaClientes.TxtBuscarCliente.Text = TxtNombre.Text
        ''''
        ''
        'LLENAR EL OTRO FORMULARIO CON LOS DATOS QUE SE HAN GUARDADO

        '
        ''
        ''''
        'CERRAMOS EL FORM
        Close()
    End Sub
    '
    '
    '
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        'BtnActualizar_Click
    End Sub
    '
    '
    '
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        'CERRAMOS EL FORM
        Close()
    End Sub

    '::: ---------->>>>>>>>>> PROCEDIMIENTOS <<<<<<<<<<---------- :::'
    Sub TxtLostFocus(ByVal TxtCadena As TextBox)
        TxtCadena.Text = Trim(TxtCadena.Text)
        While TxtCadena.Text.Contains("  ")
            TxtCadena.Text = TxtCadena.Text.Replace("  ", " ")
        End While
        TxtCadena.BackColor = Color.Azure
        If TxtCadena.Text = "" Then TxtCadena.BackColor = Color.MistyRose
    End Sub

    Private Sub LlenarDgvListaNombre(sqlConsulta As String)

        'USAMOS TRY PARA CONTROLAR POSIBLES ERRORES
        Try
            'CONECTAR Y ABRIR LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'EJECUTAMOS LA CONSULTA RECIBIDA POR PARAMETRO PARA LLENAR EL DATAGRIDVIEW
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            DgvListaNombre.Rows.Clear()

            'COMPROBAMOS SI HAY REGISTROS
            If drDataReader.HasRows Then
                'MIENTRS LEE EL DATAREADER LLENAMOS EL DATAGRIDVIEW
                While drDataReader.Read()
                    nRow = DgvListaNombre.Rows.Add()
                    DgvListaNombre.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0) 'ID
                    DgvListaNombre.Rows(nRow).Cells(1).Value = drDataReader.GetString(1) 'NOMBRE TIPO TARIFA
                    DgvListaNombre.Rows(nRow).Cells(2).Value = drDataReader.GetInt16(2) 'NUMERO DE INTEGRANTES
                    DgvListaNombre.Rows(nRow).Cells(3).Value = drDataReader.GetInt16(3) 'INTEGRANTES REGISTRADOS
                End While
            End If

        Catch ex As Exception
            'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
            MsgBox(ex.ToString)
        Finally
            'CERRAMOS EL DATAREADER Y LA BASE DE DATOS
            drDataReader.Close()
            cnxnMySql.Close()
        End Try

    End Sub

End Class