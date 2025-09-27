Imports MySql.Data.MySqlClient

Module Functions
    '
    Dim cnxnMySql As New MySqlConnection
    Dim cmdCommand As MySqlCommand
    Dim drDataReader As MySqlDataReader
    Dim nRow, cMes, cReg, idCli As Int16
    Dim sTotal As Decimal
    Dim arrayMeses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    '
    Public Sub ListaClientes(ByVal SqlConsulta As String, CmbBuscar As String, ByVal DgvListaClientes As DataGridView)

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(SqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()

            DgvListaClientes.Rows.Clear()

            If drDataReader.HasRows Then

                While drDataReader.Read()
                    nRow = DgvListaClientes.Rows.Add()
                    DgvListaClientes.Rows(nRow).Cells(0).Value = drDataReader.GetString(1).ToString 'NOMBRE
                    DgvListaClientes.Rows(nRow).Cells(1).Value = drDataReader.GetString(2).ToString 'APELLIDO
                    DgvListaClientes.Rows(nRow).Cells(2).Value = Int(DateDiff("m", drDataReader.GetDateTime(3).ToString("yyyy-MM-dd"), Now) / 12) & " años" 'EDAD
                    DgvListaClientes.Rows(nRow).Cells(3).Value = FechaLarga(drDataReader.GetDateTime(3).ToShortDateString) 'FECHA DE NACIMIENTO
                    DgvListaClientes.Rows(nRow).Cells(4).Value = drDataReader.GetString(4).ToString 'TELEFONO
                    DgvListaClientes.Rows(nRow).Cells(5).Value = drDataReader.GetString(5).ToString 'E-MAIL
                    DgvListaClientes.Rows(nRow).Cells(6).Value = drDataReader.GetString(6).ToString 'DIRECCION
                    DgvListaClientes.Rows(nRow).Cells(7).Value = FechaLarga(drDataReader.GetDateTime(7).ToShortDateString) 'FECHA DE INSCRIPCION
                    DgvListaClientes.Rows(nRow).Cells(8).Value = drDataReader.GetInt16(0).ToString 'ID
                    DgvListaClientes.Rows(nRow).Cells(9).Value = drDataReader.GetString(8).ToString 'ESTADO
                End While

                Select Case CmbBuscar

                    Case "Nombre"
                        DgvListaClientes.CurrentCell = DgvListaClientes.Item(0, 0)

                    Case "Apellido"
                        DgvListaClientes.CurrentCell = DgvListaClientes.Item(1, 0)

                    Case "Teléfono"
                        DgvListaClientes.CurrentCell = DgvListaClientes.Item(4, 0)
                End Select
            End If

            drDataReader.Close()
            cnxnMySql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub ListaMorosos(ByVal SqlConsulta As String, CmbBuscar As String, ByVal DgvMorosos As DataGridView)
        '
        Try
            '
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            '
            cmdCommand = New MySqlCommand(SqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            '
            DgvMorosos.Rows.Clear()
            '
            If drDataReader.HasRows Then
                '
                While drDataReader.Read()
                    '
                    Dim fechaIni As DateTime = drDataReader.GetDateTime(10).ToString
                    Dim dia = fechaIni.Day
                    Dim mes = fechaIni.Month
                    Dim ano = fechaIni.Year
                    Dim nDias = DateTime.DaysInMonth(fechaIni.Year, fechaIni.Month)
                    Dim total = drDataReader.GetDecimal(13).ToString - drDataReader.GetDecimal(14).ToString
                    Dim prcDia = total / nDias
                    nDias = nDias - dia + 1
                    Dim aPagar = prcDia * nDias
                    '
                    If idCli = drDataReader.GetInt16(0).ToString Then
                        '
                        DgvMorosos.Rows.Add()
                        DgvMorosos.Rows(nRow).Cells(3).Value = arrayMeses(mes - 1) & " " & ano 'MES-AÑO
                        DgvMorosos.Rows(nRow).Cells(4).Value = FormatCurrency(drDataReader.GetDecimal(13).ToString) 'PRECIO
                        DgvMorosos.Rows(nRow).Cells(5).Value = FormatCurrency(drDataReader.GetDecimal(14).ToString) 'DESCUENTO
                        DgvMorosos.Rows(nRow).Cells(6).Value = FormatCurrency(total) 'TOTAL
                        DgvMorosos.Rows(nRow).Cells(7).Value = nDias 'NUMERO DE DIAS
                        DgvMorosos.Rows(nRow).Cells(8).Value = FormatCurrency(aPagar) 'A PAGAR
                        DgvMorosos.Rows(nRow).Cells(10).Value = drDataReader.GetInt16(9).ToString 'ID PAGO
                        DgvMorosos.Rows(nRow).Cells(11).Value = drDataReader.GetDateTime(10).ToString 'FECHA INICIO DE MES
                        DgvMorosos.Rows(nRow).Cells(12).Value = drDataReader.GetString(1).ToString & " " & drDataReader.GetString(2).ToString & " - " & Int(DateDiff("m", drDataReader.GetDateTime(3).ToString, Now) / 12) & " años" 'NOMBRE, APELLIDO y EDAD
                        cMes += 1
                        cReg += 1
                        sTotal += aPagar
                        idCli = drDataReader.GetInt16(0).ToString
                        '
                    Else
                        If DgvMorosos.RowCount <> 0 Then
                            '
                            DgvMorosos.Rows.Add()
                            DgvMorosos.Rows(nRow).DefaultCellStyle.BackColor = Color.LightSalmon
                            DgvMorosos.Rows(nRow).DefaultCellStyle.ForeColor = Color.Red
                            DgvMorosos.Rows(nRow).DefaultCellStyle.Font = New Drawing.Font("Arial", 10, FontStyle.Bold)
                            DgvMorosos.Rows(nRow).Cells(6).Value = "DEBE : "
                            DgvMorosos.Rows(nRow).Cells(7).Value = cMes & " MESES"
                            DgvMorosos.Rows(nRow).Cells(8).Value = FormatCurrency(sTotal, 2) 'SUMATORIA
                            DgvMorosos.Rows.Add()
                            nRow += 1
                            '
                        End If
                        '
                        nRow = DgvMorosos.Rows.Add()
                        DgvMorosos.Rows(nRow).Cells(0).Value = drDataReader.GetString(1).ToString 'NOMBRE
                        DgvMorosos.Rows(nRow).Cells(1).Value = drDataReader.GetString(2).ToString 'APELLIDO
                        DgvMorosos.Rows(nRow).Cells(2).Value = Int(DateDiff("m", drDataReader.GetDateTime(3).ToString, Now) / 12) & " años" 'EDAD
                        DgvMorosos.Rows(nRow).Cells(3).Value = arrayMeses(mes - 1) & " " & ano 'MES-AÑO
                        DgvMorosos.Rows(nRow).Cells(4).Value = FormatCurrency(drDataReader.GetDecimal(13).ToString) 'PRECIO
                        DgvMorosos.Rows(nRow).Cells(5).Value = FormatCurrency(drDataReader.GetDecimal(14).ToString) 'DESCUENTO
                        DgvMorosos.Rows(nRow).Cells(6).Value = FormatCurrency(total) 'TOTAL
                        DgvMorosos.Rows(nRow).Cells(7).Value = nDias 'NUMERO DE DIAS
                        DgvMorosos.Rows(nRow).Cells(8).Value = FormatCurrency(aPagar) 'A PAGAR
                        DgvMorosos.Rows(nRow).Cells(10).Value = drDataReader.GetInt16(9).ToString 'ID PAGO
                        DgvMorosos.Rows(nRow).Cells(11).Value = drDataReader.GetDateTime(10).ToString 'FECHA INICIO DE MES
                        DgvMorosos.Rows(nRow).Cells(12).Value = drDataReader.GetString(1).ToString & " " & drDataReader.GetString(2).ToString & " - " & Int(DateDiff("m", drDataReader.GetDateTime(3).ToString, Now) / 12) & " años" 'NOMBRE, APELLIDO y EDAD
                        cMes = 1
                        cReg += 1
                        sTotal = aPagar
                        idCli = drDataReader.GetInt16(0).ToString
                        '
                    End If
                    '
                    nRow += 1
                    '
                End While
                '
                idCli = 0
                '
                DgvMorosos.Rows.Add()
                DgvMorosos.Rows(nRow).DefaultCellStyle.BackColor = Color.LightSalmon
                DgvMorosos.Rows(nRow).DefaultCellStyle.ForeColor = Color.Red
                DgvMorosos.Rows(nRow).DefaultCellStyle.Font = New Drawing.Font("Arial", 10, FontStyle.Bold)
                DgvMorosos.Rows(nRow).Cells(6).Value = "DEBE : "
                DgvMorosos.Rows(nRow).Cells(7).Value = cMes & " MESES"
                DgvMorosos.Rows(nRow).Cells(8).Value = FormatCurrency(sTotal, 2) 'SUMATORIA
                '
                Select Case CmbBuscar
                    '
                    Case "Nombre"
                        '
                        DgvMorosos.CurrentCell = DgvMorosos.Item(0, 0)
                        '
                    Case "Apellido"
                        '
                        DgvMorosos.CurrentCell = DgvMorosos.Item(1, 0)
                        '
                End Select
                '
            End If
            '
            '::::FrmListaMorosos.cReg = cReg
            cReg = 0
            drDataReader.Close()
            cnxnMySql.Close()
            ' 
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        '
    End Sub

    Sub DgvLlenarPagos(ByVal sqlConsulta As String, ByVal DgvListaPagos As DataGridView)
        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader
            DgvListaPagos.Rows.Clear()

            If drDataReader.HasRows Then
                While drDataReader.Read()
                    Dim nRow = DgvListaPagos.Rows.Add()
                    Dim fecha As DateTime = drDataReader.GetDateTime(1).ToShortDateString
                    Dim dia = fecha.Day
                    Dim mes = fecha.Month
                    Dim ano = fecha.Year
                    Dim precio = drDataReader.GetDecimal(4).ToString
                    Dim dscto = drDataReader.GetDecimal(5).ToString
                    Dim total = precio - dscto
                    Dim nDias = DateTime.DaysInMonth(fecha.Year, fecha.Month)
                    Dim prcDia = total / nDias
                    nDias = nDias - dia + 1

                    DgvListaPagos.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString 'ID PAGO
                    DgvListaPagos.Rows(nRow).Cells(1).Value = dia & " de " & arrayMeses(mes - 1) & " de " & ano 'FECHA DE INICIO
                    DgvListaPagos.Rows(nRow).Cells(2).Value = FormatCurrency(precio) 'PRECIO
                    DgvListaPagos.Rows(nRow).Cells(3).Value = FormatCurrency(dscto) 'DESCUENTO
                    DgvListaPagos.Rows(nRow).Cells(4).Value = FormatCurrency(total) 'TOTAL
                    DgvListaPagos.Rows(nRow).Cells(5).Value = nDias 'NUMERO DE DIAS
                    DgvListaPagos.Rows(nRow).Cells(6).Value = FormatCurrency(prcDia * nDias) 'A PAGAR
                    If drDataReader.GetDateTime(2).ToShortDateString = "01/01/0101" Then
                        DgvListaPagos.Rows(nRow).Cells(7).Value = "--/--/----" 'FECHA DE PAGO
                        DgvListaPagos.Rows(nRow).Cells(8).Value = "DEBE" 'FORMA DE PAGO
                        'DgvListaPagos.Rows(nRow).DefaultCellStyle.BackColor = Color.LightSalmon
                        DgvListaPagos.Rows(nRow).DefaultCellStyle.ForeColor = Color.Red
                        DgvListaPagos.Rows(nRow).DefaultCellStyle.Font = New Drawing.Font("Arial", 10, FontStyle.Bold)
                        '
                    Else
                        DgvListaPagos.Rows(nRow).Cells(7).Value = FechaLarga(drDataReader.GetDateTime(2).ToShortDateString) 'FECHA DE PAGO
                        DgvListaPagos.Rows(nRow).Cells(8).Value = drDataReader.GetString(3).ToString 'FORMA DE PAGO
                        DgvListaPagos.Rows(nRow).Cells(9).Value = drDataReader.GetString(7).ToString 'USUARIO
                    End If
                End While
            End If

            drDataReader.Close()
            cnxnMySql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub SoloLetras(ByVal Texto As String, e As KeyPressEventArgs)
        '
        If Texto = "Nº de Registros" Then e.Handled = True : Exit Sub
        If Char.IsControl(e.KeyChar) Then e.Handled = False : Exit Sub
        If Char.IsSeparator(e.KeyChar) Then e.Handled = False : Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then e.Handled = True : Exit Sub
        '
    End Sub

    Public Sub SoloNumeros(ByVal Numero As String, e As KeyPressEventArgs)

        If (e.KeyChar = ".") Then e.Handled = False : Exit Sub
        If Char.IsControl(e.KeyChar) Then e.Handled = False : Exit Sub
        If Not Char.IsNumber(e.KeyChar) Then e.Handled = True : Exit Sub
        'If Char.IsSeparator(e.KeyChar) Then e.Handled = False : Exit Sub
    End Sub

    Public Function FechaLarga(ByVal fecha As Date) As String
        Dim dia = fecha.Day
        Dim mes = fecha.Month
        Dim ano = fecha.Year
        Dim strFecha = dia & " de " & arrayMeses(mes - 1) & " de " & ano
        Return strFecha
    End Function
    '
End Module
