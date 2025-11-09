Imports MySql.Data.MySqlClient

Public Class FrmPresentation
    Private Sub FrmPresentation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ASIRNAR TEXTO A LA ETIQUE VERSIÓN
        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        'LblVersion.Text = System.String.Format(LblVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'ASIRNAR TEXTO A LA ETIQUE CON LA INFORMACIÓN DEL COPYRIGHT 
        'LblCopyright.Text = My.Application.Info.Copyright

        If Check_Connection() = True Then
            Timer.Start() 'INICIAR EL TIMER

        Else
            Me.Show()
            Timer.Stop()
            LblBarra.Text = "No hay CONEXIÓN con la Base de Datos"
            LblBarra.ForeColor = Color.Red

            MsgBox("No se ha podido conectar con la BBDD." & Chr(13) & Chr(13) & "No se puede acceder al programa.", vbCritical, "Error de conexión")
            End
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        BarraProgreso.Increment(4)

        'If BarraProgreso.Value < 40 Then
        '    LblBarra.Text = "Iniciando conexión a la BBDD " & BarraProgreso.Value & ("%")
        '    LblBarra.ForeColor = Color.Red

        'ElseIf BarraProgreso.Value < 70 Then
        '    LblBarra.Text = "Conexión exitosa con la BBDD " & BarraProgreso.Value & ("%")
        '    LblBarra.ForeColor = Color.Blue

        'ElseIf BarraProgreso.Value < 100 Then
        '    LblBarra.Text = "Iniciando el programa ... " & BarraProgreso.Value & ("%")
        '    LblBarra.ForeColor = Color.Black

        'ElseIf BarraProgreso.Value = 1 Then
        Timer.Stop() 'DETENER TIMER
        FrmUserPassword.Show() 'MOSTRAMOS EL FORMULARIO LOGIN
        Me.Hide() 'CERRA EL FORMULARIO -- Close()
        'End If

    End Sub


    Public Function Check_Connection() As Boolean

        Dim cnxnMySql As New MySqlConnection
        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            cnxnMySql.Close()
            Return True
        Catch
            Return False
        End Try

    End Function
End Class