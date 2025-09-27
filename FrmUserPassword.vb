Imports MySql.Data.MySqlClient

Public Class FrmUserPassword

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim sqlConsulta, idUser As String

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            If TxtContrasena.Text = "" Then
                sqlConsulta = "SELECT * FROM usuarios WHERE nom_user = '" & TxtUsuario.Text & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()

                If drDataReader.HasRows Then
                    drDataReader.Read()
                    idUser = drDataReader.GetInt16(0).ToString

                    If drDataReader.GetString(2).ToString = "" Then
                        LblUsuario2.Text = "Ingresa una contraseña para : " & TxtUsuario.Text
                        GbUsuarioContrasena.Visible = False
                        GbGuardarContrasena.Visible = True
                        TxtContrasena1.Focus()
                    Else
                        MsgBox("El usuario o la contraseña son incorreco.", vbCritical, "Control de acceso")
                        TxtUsuario.Focus()
                    End If

                Else
                    MsgBox("El usuario no está registrado.", vbCritical, "Control de acceso")
                    TxtUsuario.Focus()
                End If

            Else
                sqlConsulta = "SELECT * FROM usuarios WHERE nom_user = '" & TxtUsuario.Text & "' AND pwd_user = '" & TxtContrasena.Text & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()

                If drDataReader.HasRows Then
                    drDataReader.Read()
                    idUser = drDataReader.GetInt16(0).ToString
                    FrmMain.idUser = idUser
                    FrmMain.nomUser = drDataReader.GetString(1).ToString
                    FrmMain.cargoUser = drDataReader.GetString(3).ToString
                    drDataReader.Close()

                    sqlConsulta = "INSERT INTO sesion_user (fh_entrada, id_user) VALUES
                                ('" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & idUser & "')"
                    cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                    drDataReader = cmdCommand.ExecuteReader()
                    idUser = ""

                    FrmMain.Show()
                    Me.Close() '.Hide()
                Else
                    MsgBox("El usuario o la contraseña son incorreco.", vbCritical, "Control de acceso")
                    TxtUsuario.Focus()
                End If
            End If

        Catch ex As Exception
            'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
            MsgBox(e.ToString)

        Finally
            'CERRAMOS EL DATAREADER Y LA BBDD
            drDataReader.Close()
            cnxnMySql.Close()

        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        End
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If TxtContrasena1.Text = TxtContrasena2.Text Then
            Try
                cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                cnxnMySql.Open()
                sqlConsulta = "UPDATE usuarios SET pwd_user ='" & TxtContrasena1.Text & "' WHERE id_user ='" & idUser & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()

                GbUsuarioContrasena.Visible = True
                GbGuardarContrasena.Visible = False
                TxtContrasena.Focus()
                idUser = ""

            Catch ex As Exception
                'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
                MsgBox(e.ToString)

            Finally
                'CERRAMOS EL DATAREADER Y LA BBDD
                drDataReader.Close()
                cnxnMySql.Close()

            End Try
        Else
            MsgBox("Las contraseñas no coinciden.", vbCritical, "Guardar contraseña")
            TxtContrasena1.Focus()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        GbUsuarioContrasena.Visible = True
        GbGuardarContrasena.Visible = False
        TxtContrasena1.Clear()
        TxtContrasena2.Clear()
        TxtContrasena.Focus()
        idUser = ""
    End Sub

End Class