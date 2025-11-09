Imports System.Configuration
Imports MySql.Data.MySqlClient

Module SQLqueries

    Dim cnxnMySql As New MySqlConnection
    Dim cmdCommand As MySqlCommand
    Dim drDataReader As MySqlDataReader

    Dim nRow, cMes, cReg, idCli As Int16
    Dim sTotal As Decimal

    Sub Sub_Crud_Sql(sqlConsulta As String, Optional strSubroutine As String = "", Optional strFiltrar As String = "")

        '| * Usamos Try-Catch para controlar posibles errores
        '| TRY :
        '|      * Conectamos y abrimos la base de datos.
        '|      * Ejecutamos la consulta recibida por parametro.
        '|      SELECT CASE :
        '|          * Seleccionamos el CASE para llamar a la subrutina correspondiente al valor de la variable _
        '|            _ strSubroutine, que se recibe por parámetro cuando se hace la llamada a la subrutina _
        '|            _ principal Sub_Crud_Sql.
        '| CATCH :
        '|      * Mostramos un mensaje con el error capturado.
        '| FINALLY :
        '|      * Cerramos el datareader y la base de datos.

        Try
            cnxnMySql.ConnectionString = ConfigurationManager.ConnectionStrings("MyConnectionMySQL").ConnectionString
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()

            Select Case strSubroutine

                Case "SubCheckRecords"
                    SubCheckRecords()

                Case "SubReadIdClient"
                    SubReadIdClient()

                Case "SubSearchFamilyGroup"
                    SubSearchFamilyGroup()

                Case "SubSearchDiscountPrice"
                    SubSearchDiscountPrice()

                Case "SubFillFamilyGroupData"
                    SubFillFamilyGroupData()

                Case "SubSearchGroupPrice"
                    SubSearchGroupPrice()

                Case "SubSearchDailyPrice"
                    SubSearchDailyPrice()

                Case "SubFillClientList"
                    SubFillClientList(strFiltrar)

            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            drDataReader.Close()
            cnxnMySql.Close()
        End Try

    End Sub


    Sub SubCheckRecords()

        '| * IF : Comprobamos si la consulta tiene registros:
        '|        * Activamos el boton BtnFindClient.
        '| * ELSE : Si la consulta no ha encontrado registros:
        '|        * Desactivamos el boton BtnFindClient.

        If drDataReader.HasRows Then
            FrmClientesPagos.BtnFindClient.Enabled = True
        Else
            FrmClientesPagos.BtnFindClient.Enabled = False
        End If

    End Sub


    Sub SubReadIdClient()

        '| * Leemos el drDataReader.
        '| * El resultado lo almacenamos en la variable strIdClient del formulario FrmNuevoEditarCliente.

        drDataReader.Read()
        FrmNuevoEditarCliente.strIdClient = drDataReader.GetInt16(0).ToString
    End Sub


    Sub SubSearchFamilyGroup()

        '| * Leemos el drDataReader.
        '| * Llenamos el label LblGrpFamCli del Form FrmClientesPagos con el nombre del grupo familiar.

        drDataReader.Read()
        FrmClientesPagos.LblGrpFamCli.Text = drDataReader.GetString(1)
    End Sub


    Sub SubFillFamilyGroupData()

        '| WITH :
        '|      * Limpiamos el DataGridView DgvListaNombre
        '|      IF : Comprobammos si hay registros:
        '|          WHILE : Mientras leemos el DataReader
        '|              * Agregamos una nueva fila y lo almacenamos en la variable nRow para llenar los _
        '|                _ campos del DataGridView DgvListaNombre con los datos del Grupo Familiar.

        With FrmNuevoEditarCliente.DgvListaNombre
            .Rows.Clear()
            If drDataReader.HasRows Then
                While drDataReader.Read()
                    nRow = .Rows.Add()
                    .Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0) 'ID
                    .Rows(nRow).Cells(1).Value = drDataReader.GetString(1) 'NOMBRE TIPO TARIFA
                    .Rows(nRow).Cells(2).Value = drDataReader.GetInt16(2) 'NUMERO DE INTEGRANTES
                    .Rows(nRow).Cells(3).Value = drDataReader.GetInt16(3) 'INTEGRANTES REGISTRADOS
                End While
            End If
        End With
    End Sub

    Sub SubSearchDiscountPrice()

        '| WITH :
        '|      IF : Si la consulta devuelve resultados
        '|          * Leemos el drDataReader y el resultado lo almacenamos en las variables -
        '|            - "precio" y "dscnto".
        '|          * Pasamos la variable blnMarker a FALSE para no volver a llamar a esta función.
        '|      ELSE :
        '|          * Pasamos la variable blnMarker a TRUE, para hacer una nueva consulta y volver _
        '|            _ a llamar a esta función.

        With FrmNuevoEditarCliente
            If drDataReader.HasRows Then
                drDataReader.Read()
                .precio = drDataReader.GetDecimal(0)
                .dscnto = drDataReader.GetDecimal(1)
                .blnMarker = False
            Else
                .blnMarker = True
            End If
        End With
    End Sub

    Sub SubSearchDailyPrice()

        '| WITH :
        '|      * Limpiamos el DataGridView DgvListaNombre
        '|      IF : Comprobammos si hay registros:
        '|          WHILE : Mientras leemos el DataReader
        '|              * Agregamos una nueva fila y lo almacenamos en la variable nRow para llenar los _
        '|                _ campos del DataGridView DgvListaNombre con los datos del Precio Diario.

        With FrmNuevoEditarCliente.DgvListaNombre
            .Rows.Clear()
            If drDataReader.HasRows Then
                While drDataReader.Read()
                    nRow = .Rows.Add()
                    .Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0) 'ID
                    .Rows(nRow).Cells(1).Value = drDataReader.GetString(1) 'NOMBRE TIPO TARIFA
                End While
            End If
        End With
    End Sub

    Sub SubSearchGroupPrice()

        '| WITH :
        '|      IF : Si la consulta no devuelve registros:
        '|          IF : Preguntammos si queremos agregar una tarifa
        '|              * Ponemos la variable intAddMember a cero.
        '|              * Mostramos el Form FrmTablaDescuento
        '|      ELSE : Si encuentra la tarifa correspondiente al grupo:
        '|          * Llemanos el TxtListaNom y el LblNumIntgrntes con los datos del grupo.
        '|          * Llenamos la variable strAddMembers = "UPDATE_TWO_FIELDS" para actualizar _
        '|            _ los campos num_intgrntes_grp Y intgrntes_reg_grp al momento de guardar.

        With FrmNuevoEditarCliente
            If Not drDataReader.HasRows Then
                If MsgBox("   No hay una tarifa para " & .intAddMember & " integrantes." & vbCr &
                          "   ______________________________________" & vbCr & vbCr &
                          "                ¿Quieres agergar una tarifa?",
                            vbYesNo + vbDefaultButton2 + vbQuestion, "Lista de integrantes") = vbYes Then
                    .intAddMember = 0
                    FrmTablaDescuento.Show()
                End If
            Else
                .TxtListaNom.Text = .DgvListaNombre.CurrentRow.Cells(1).Value
                .LblNumIntgrntes.Text = .DgvListaNombre.CurrentRow.Cells(3).Value & " de " & .DgvListaNombre.CurrentRow.Cells(2).Value
                .strAddMembers = "UPDATE_TWO_FIELDS"
            End If
        End With
    End Sub

    Sub SubFillClientList(strFiltrar As String)

        '| WITH :
        '|      * Limpiamos el DataGridView DgvListaNombre
        '|      IF : Comprobamos si hay registros:
        '|          WHILE : Mientras leemos el DataReader
        '|              * Agregamos una nueva fila y lo almacenamos en la variable nRow para llenar los _
        '|                _ campos del DataGridView DgvClientes con los datos del cliente.
        '|          SELECT CASE : Evaluamos la variable strFiltrar recibida por parámetro para marcar _
        '|                        _ el campo que se está buscando.
        '|          * FrmClientesPagos.TxtBuscar.BackColor = Color.Snow
        '|      ELSE :
        '|          * FrmClientesPagos.TxtBuscar.BackColor = Color.MistyRose
        '|
        '|      * FrmClientesPagos.LblResult.Text = .RowCount & " - Registro(s) que coincide(n) con su búsqueda."

        With FrmClientesPagos.DgvClientes

            .Rows.Clear()

            If drDataReader.HasRows Then

                While drDataReader.Read()
                    nRow = .Rows.Add()
                    'ID DEL CLIENTE
                    .Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString
                    'NOMBRE DEL CLIENTE
                    .Rows(nRow).Cells(1).Value = drDataReader.GetString(1)
                    'APELLIDO DEL CLIENTE
                    .Rows(nRow).Cells(2).Value = drDataReader.GetString(2)
                    'FECHA DE NACIMIENTO Y EDAD DEL CLIENTE
                    .Rows(nRow).Cells(3).Value = drDataReader.GetDateTime(3).ToShortDateString.ToString
                    .Rows(nRow).Cells(4).Value = Fun_Long_Date(drDataReader.GetDateTime(3).ToShortDateString)
                    .Rows(nRow).Cells(5).Value = Int(DateDiff("m", drDataReader.GetDateTime(3).ToString("yyyy-MM-dd"), Now) / 12) & " años"
                    'TELEFONO DEL CLIENTE
                    .Rows(nRow).Cells(6).Value = drDataReader.GetString(4)
                    'E-MAIL DEL CLIENTE
                    .Rows(nRow).Cells(7).Value = drDataReader.GetString(5)
                    'DIRECCIÓN DEL CLIENTE
                    .Rows(nRow).Cells(8).Value = drDataReader.GetString(6)
                    'MÉTODO DE PAGO DEL CLIENTE
                    .Rows(nRow).Cells(9).Value = drDataReader.GetString(7)
                    'FECHA DE INSCRIPCIÓN
                    .Rows(nRow).Cells(10).Value = drDataReader.GetDateTime(8).ToShortDateString.ToString
                    .Rows(nRow).Cells(11).Value = Fun_Long_Date(drDataReader.GetDateTime(8).ToShortDateString)
                    'ESTADO DEL CLIENTE
                    .Rows(nRow).Cells(12).Value = drDataReader.GetString(9)
                    'ID DEL GRUPO FAMILIAR
                    If Not (drDataReader("id_grp") Is DBNull.Value) Then
                        .Rows(nRow).Cells(13).Value = drDataReader.GetInt16(10).ToString
                    End If
                End While

                Select Case strFiltrar
                    Case "NAME"
                        .CurrentCell = .Item(1, 0)
                    Case "LASTNAME"
                        .CurrentCell = .Item(2, 0)
                    Case "PHONE"
                        .CurrentCell = .Item(6, 0)
                End Select

                FrmClientesPagos.TxtBuscar.BackColor = Color.Snow
            Else
                FrmClientesPagos.TxtBuscar.BackColor = Color.MistyRose
            End If

            FrmClientesPagos.LblResult.Text = .RowCount & " - Registro(s) que coincide(n) con su búsqueda."
        End With
    End Sub
    ''
    ''

    Sub SubFillPayments()

        '|
        With FrmClientesPagos.DgvListaPagos

            .Rows.Clear()

            If drDataReader.HasRows Then

                While drDataReader.Read()
                    Dim nRow = .Rows.Add()
                    '
                    Dim fecha As DateTime = drDataReader.GetDateTime(1).ToShortDateString
                    Dim dia = fecha.Day
                    'Dim mes = fecha.Month
                    'Dim ano = fecha.Year
                    '
                    Dim precio = drDataReader.GetDecimal(4).ToString
                    Dim dscto = drDataReader.GetDecimal(5).ToString
                    Dim total = precio - dscto
                    Dim nDias = DateTime.DaysInMonth(fecha.Year, fecha.Month)
                    Dim prcDia = total / nDias
                    nDias = nDias - dia + 1

                    .Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString 'ID PAGO
                    .Rows(nRow).Cells(1).Value = Fun_Long_Date(drDataReader.GetDateTime(1).ToShortDateString) 'dia & " de " & arrayMeses(mes - 1) & " de " & ano 'FECHA DE INICIO
                    .Rows(nRow).Cells(2).Value = FormatCurrency(precio) 'PRECIO
                    .Rows(nRow).Cells(3).Value = FormatCurrency(dscto) 'DESCUENTO
                    .Rows(nRow).Cells(4).Value = FormatCurrency(total) 'TOTAL
                    .Rows(nRow).Cells(5).Value = nDias 'NUMERO DE DIAS
                    .Rows(nRow).Cells(6).Value = FormatCurrency(prcDia * nDias) 'A PAGAR
                    If drDataReader.GetDateTime(2).ToShortDateString = "00/00/0000" Then
                        .Rows(nRow).Cells(7).Value = "--/--/----" 'FECHA DE PAGO
                        .Rows(nRow).Cells(8).Value = "DEBE" 'FORMA DE PAGO
                        '.Rows(nRow).DefaultCellStyle.BackColor = Color.LightSalmon
                        .Rows(nRow).DefaultCellStyle.ForeColor = Color.Red
                        .Rows(nRow).DefaultCellStyle.Font = New Drawing.Font("Arial", 10, FontStyle.Bold)
                        '
                    Else
                        .Rows(nRow).Cells(7).Value = Fun_Long_Date(drDataReader.GetDateTime(2).ToShortDateString) 'FECHA DE PAGO
                        .Rows(nRow).Cells(8).Value = drDataReader.GetString(3).ToString 'FORMA DE PAGO
                        .Rows(nRow).Cells(9).Value = drDataReader.GetString(7).ToString 'USUARIO
                    End If
                End While
            End If

        End With

    End Sub
End Module