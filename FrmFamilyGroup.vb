Imports MySql.Data.MySqlClient

Public Class FrmFamilyGroup

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim nRow As Int16
    Dim sqlConsulta, strBandera As String

    Private Sub FrmFamilyGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AL CARGAR DEBEMOS DE COMPROBAR PARA QUE TODO ESTÉ PREPARADO PARA
        'CREAR UN NUEVO GRUPO BtnNuevo_Click
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        '::: PRIMERO DESACTIVAMOS EL CHECKBOX PARA EVITAR QUE AL EJECUTE SU CÓDIGO NO
        '    INFLUYA EN EL RESTO DEL CÓDIGO :::'
        ChkGrpVacioNombre.Checked = False

        'FUNCION PARA ACTIVAR Y DESACTIVAR LOS BOTONES
        BtnNewModify()
        ChkGrpVacioNombre.Enabled = True
        BtnGuardar.Visible = True

        'FUNCION PARA LIMPIAR LOS CONTROLES
        CleanControls()
        PicIntgrntes.Image = Nothing

        'CAMIAMOS EL TEXTO DEL CHECKBOX
        ChkGrpVacioNombre.Text = "Guardar el nuevo grupo sin integrantes."

        'ENVIAMOS EL ENFOQUE AL TEXTBOX
        TxtListNomGrupo.Focus()

        'LLAMAMOS A LA FUNCION PARA CAMBIAR EL COLOR DEL FONDO Y EL COLOR DE LOS TEXTOS
        ChangeColorsNewEdit()

        'LLENAMOS LA VARIABLE PARA PODER HACER LAS CONSULTAS SEGÚN CORRESPONDA SI ES NUEVO O MODIFICAR
        strBandera = "NEW-SAVE"

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        'SI EL NUMERICUPDOWN ES MENOR QUE 3 NO PODEMOS GUARDAR EL NUEVO REGISTRO
        If NudNumIntgrntes.Value < 3 Then
            'MOSTRAMOS MENSAJE DE ERROR
            MsgBox("El número de integrantes no puede ser nemor que tres.", vbCritical, "Nuevo registro")
            'ENVIAMOS EL ENFOQUE AL NUMERICUPDOWN Y SALTAMOS AL FINAL DEL CÓDIGO
            NudNumIntgrntes.Focus() : Exit Sub
        End If

        'HACEMOS COMPROBACINES ANTES DE GUARDAR EL GRUPO Y ACTUALIZAR LOS CLIENTES
        If LblNumIntgrntes.BackColor = Color.MistyRose Then
            'MOSTRAMOS MENSAJE DE ERROR
            MsgBox("Agrega INTEGRANTES a la lista", vbCritical, "Nuevo registro")
            'ENVIAMOS EL ENFOQUE AL NUMERICUPDOWN Y SALTAMOS AL FINAL DEL CÓDIGO
            TxtBscrIntgrntes.Focus() : Exit Sub
        End If

        'PARA CAPTURAR POSIBLES ERRORES
        Try
            'CONECTAMOS CON LA BBDD Y LO ABRIMOS
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'COMPROBAMOS SI EXISTE UNA TARIFA CON EL NÚMERO DE INTEGRANTES
            sqlConsulta = "SELECT nperson_trfa FROM trfa_dscto WHERE nperson_trfa = '" & NudNumIntgrntes.Value & "'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            If Not drDataReader.HasRows Then
                If MsgBox("   No hay una tarifa para " & NudNumIntgrntes.Value & " integrantes." & vbCr &
                          "   ______________________________________" & vbCr & vbCr &
                          "                ¿Quieres agergar una tarifa?",
                            vbYesNo + vbDefaultButton2 + vbExclamation, "Lista de integrantes") = vbYes Then
                    FrmDiscountTable.Show()
                End If
                drDataReader.Close()
                Exit Try
            End If
            drDataReader.Close()

            'HACEMOS LA CONSULTA PARA GUARDAR EL NUEVO GRUPO
            sqlConsulta = "INSERT INTO grp_familiar
                            (nom_grp, num_intgrntes_grp, intgrntes_reg_grp) VALUES
                            ('" & TxtListNomGrupo.Text & "',
                            '" & NudNumIntgrntes.Value & "',
                            '" & DgvListIntgrntes.RowCount & "')"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()

            'COMPROBAR SI EL CHECKBOX ESTA DESACTIVADO
            If ChkGrpVacioNombre.Checked = False Then

                'CONSULTA PARA CAPTURAR EL ID DEL ULTIMO GRUPO REGISTRADO
                sqlConsulta = "SELECT id_grp FROM grp_familiar ORDER BY id_grp DESC LIMIT 1"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader
                drDataReader.Read()
                Lblidgrp.Text = drDataReader.GetInt16(0).ToString
                drDataReader.Close()

                'CONSULTA PARA ACTUALIZAR LOS CLIENTES CON EL ID DEL NUEVO GRUPO
                For Each DgvrId As DataGridViewRow In DgvListIntgrntes.Rows
                    sqlConsulta = "UPDATE clientes SET
                                    mpg_cli = 'GRUPAL', id_grp = '" & Lblidgrp.Text & "'
                                    WHERE id_cli='" & DgvrId.Cells("ColIdCli").Value.ToString & "'"
                    cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                    drDataReader = cmdCommand.ExecuteReader()
                    drDataReader.Close()
                Next

            End If

            'FUNCION QUE ACTIVA Y DESACTIVA LOS BOTONES
            BtnSaveUpdateCancel()

            'DESACTIVA LOS CONTROLES
            CtrlsDeactivate()

            'LIMPIAMOS LOS LABEL PARA LA PROXIMA CONSULTA
            Lblidgrp.Text = ""
            Lblidcli.Text = ""

            'LIMPIAMOS LA VARIABLE BANDERA
            strBandera = ""

            'MOSTRAMOS MENSAJE DE CONFIRMACION
            MsgBox("El nuevo grupo familiar se ha registrado correctamente.", vbInformation, "Nuevo registro")

        Catch ex As Exception
            'MUESTRA UN MENSAJE CON EL ERROR CAPTURADO
            MsgBox(ex.ToString)
        Finally
            'CERRAMOS EL DATAREADER Y LA BBDD
            'drDataReader.Close()
            cnxnMySql.Close()
        End Try

        'PASAMOS EL NOMBRE DEL GRUPO AL FORMULARIO FrmNuevoEditarCliente
        FrmNewModifyClient.RbGrupoFamiliar.Checked = True

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        'FUNCION PARA ACTIVAR Y DESACTIVAR LOS BOTONES
        BtnNewModify()
        BtnActualizar.Visible = True

        'FUNCION PARA LIMPIAR LOS CONTROLES
        CleanControls()
        PicIntgrntes.Image = Nothing
        ChkGrpVacioNombre.Checked = False

        'CAMBIAMOS EL TEXTO DEL CHECKBOX
        ChkGrpVacioNombre.Text = "Modificar el nombre del grupo."

        'ENVIAMOS EL ENFOQUE AL TEXTBOX
        TxtListNomGrupo.Focus()

        'LLAMAMOS A LA FUNCION PARA CAMBIAR EL COLOR DEL FONDO Y EL COLOR DE LOS TEXTOS
        ChangeColorsNewEdit()

        'LLENAMOS LA VARIABLE PARA PODER HACER LAS CONSULTAS SEGÚN CORRESPONDA SI ES NUEVO O MODIFICAR
        strBandera = "MODIFY-UPDATE"

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        'HACEMOS COMPROBACINES ANTES DE ACTUALIZAR EL GRUPO Y LOS CLIENTES
        If LblNumIntgrntes.BackColor = Color.MistyRose Then

            'MOSTRAMOS UN MENSAJE DE ERROR
            MsgBox("Agrega INTEGRANTES a la lista", vbCritical, "Actualizar registro")

            'ENVIAMOS EL ENFOQUE AL TEXTBOX Y SALIMOS DEL CÓDIGO
            TxtBscrIntgrntes.Focus() : Exit Sub
        End If

        'PARA CAPTURAR POSIBLES ERRORES
        Try
            'CONECTAMOS CON LA BBDD Y LO ABRIMOS
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'ACTALIZAR LOS DATOS DEL GRUPO
            sqlConsulta = "UPDATE grp_familiar SET
                            nom_grp = '" & TxtListNomGrupo.Text & "',
                            num_intgrntes_grp = '" & NudNumIntgrntes.Value & "',
                            intgrntes_reg_grp = '" & DgvListIntgrntes.RowCount & "'
                            WHERE id_grp='" & Lblidgrp.Text & "'"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()

            'CONSULTA PARA ACTUALIZAR LOS CLIENTES CON EL ID DEL NUEVO GRUPO
            For Each DgvFila As DataGridViewRow In DgvListIntgrntes.Rows
                If DgvFila.Cells("ColIdGrp").Value = Nothing Then
                    sqlConsulta = "UPDATE clientes SET
                                    mpg_cli = 'GRUPAL', id_grp = '" & Lblidgrp.Text & "'
                                    WHERE id_cli='" & DgvFila.Cells("ColIdCli").Value.ToString & "'"
                    cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                    drDataReader = cmdCommand.ExecuteReader()
                    drDataReader.Close()
                End If
            Next

            'FUNCION QUE ACTIVA Y DESACTIVA LOS BOTONES
            BtnSaveUpdateCancel()

            'DESACTIVA LOS CONTROLES
            CtrlsDeactivate()

            'LIMPIAMOS EL LABEL PARA LA PROXIMA CONSULTA
            Lblidcli.Text = ""
            Lblidgrp.Text = ""

            'LIMPIAMOS LA VARIABLE BANDERA
            strBandera = ""

            'MOSTRAMOS MENSAJE DE CONFIRMACION
            MsgBox("El grupo familiar se ha ACTUALIZADO correctamente.", vbInformation, "Nuevo registro")

        Catch ex As Exception

            'MUESTRA UN MENSAJE CON EL ERROR CAPTURADO
            MsgBox(ex.ToString)
        Finally

            'CERRAMOS LA BBDD
            cnxnMySql.Close()
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        'FUNCION PARA ACTIVAR Y DESACTIVAR LOS BOTONES
        BtnSaveUpdateCancel()

        'FUNCION PARA LIMPIAR LOS CONTROLES
        CleanControls()
        ChkGrpVacioNombre.Checked = False
        ChkGrpVacioNombre.Text = ""

        'FUNCION PARA DESACTIVAR LOS CONTROLES
        CtrlsDeactivate()
        If strBandera = "DELETE" Then DgvListNomGrupo.Visible = False

        'LLAMAR A LA FUNCION QUE CAMBIA EL COLOR DEL FONDO Y EL COLOR DE LA LETRA
        ChangeColorsCancelDelete()

        'LIMPIAMOS LA VARIABLE BANDERA PARA LAS PROXIMAS ACCIONES
        strBandera = ""
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click


        'MENSAJE DE INFORMACIÓN
        MsgBox("   PARA BORRAR UN GRUPO FAMILIAR DE LA BBDD" & vbCr &
               "   _________________________________________________" & vbCr & vbCr &
               "   1.- Selecciona un registro de la lista." & vbCr & vbCr &
               "   2.- Haz click en Eliminar grupo.", vbInformation, "Eliminar grupo")

        'FUNCION PARA LIMPIAR LOS CONTROLES
        CleanControls()

        'DESACTIVAMOS EL TEXTBOX Y LE ENVIAMOS EL ENFOQUE
        TxtListNomGrupo.Enabled = True
        TxtListNomGrupo.Focus()

        'OCULTAMMOS Y MOSTRAMOS LOS BOTONES
        BtnNuevo.Visible = False
        BtnGuardar.Visible = False
        BtnActualizar.Visible = False
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        BtnDeleteGroup.Visible = True
        BtnCancelar.Visible = True

        'HACEMOS LA CONSULTA PARA MOSTRAR TODOS LOS GRUPO EN LA LISTA
        sqlConsulta = "SELECT * FROM grp_familiar ORDER BY nom_grp"
        LlenarDgvListNomGrupo(sqlConsulta)

        'LLENAMOS LA VARIABLE PARA PODER HACER LAS BUSQUEDAS CUANDO ESTAMOS EN ELIMINAR
        strBandera = "DELETE"

    End Sub

    Private Sub BtnDeleteGroup_Click(sender As Object, e As EventArgs) Handles BtnDeleteGroup.Click

        'COMPROBAMOS SI SE HA SELECCIONADO UN GRUPO DE LA LISTA
        If TxtListNomGrupo.Text = "" Or Lblidgrp.Text = "" Then
            'ENVIAMOS UN MENSAJE DE INFORMACIÓN Y SALIMOS DE LA FUNCION
            MsgBox("Selecciona un grupo de la lista.", vbCritical, "Eliminar grupo") : Exit Sub
        End If

        'COMPROBAMOS SI SE HA PULSADO EN SI PARA ELIMINAR EL GRUPO Y ACTUALIZAR LOS DATOS DE LOS CLIENTES
        If MsgBox("   Nombre del grupo  : " & TxtListNomGrupo.Text & vbCr &
                  "   Nº de Integrante     : " & NudNumIntgrntes.Value & vbCr &
                  "   ________________________________________________" & vbCr & vbCr &
                  "        ¿Seguro que quieres ELIMINAR de la BBDD?",
                  vbYesNo + vbDefaultButton2 + vbQuestion, "Eliminar grupo") = vbYes Then

            'USAMOS TRY PARA CAPTURAR POSIBLES ERRORES
            Try
                'CONECTAMOS CON LA BBDD Y LO ABRIMOS
                cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                cnxnMySql.Open()

                'CONSULTA PARA ACTUALIZAR LOS CLIENTES CON EL ID DEL NUEVO GRUPO
                For Each DgvrId As DataGridViewRow In DgvListIntgrntes.Rows
                    sqlConsulta = "UPDATE clientes SET mpg_cli = 'MENSUAL', id_grp = NULL
                                   WHERE id_cli='" & DgvrId.Cells("ColIdCli").Value.ToString & "'"
                    cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                    drDataReader = cmdCommand.ExecuteReader()
                    drDataReader.Close()
                Next

                'ACTALIZAR DATOS DEL CLIENTE
                sqlConsulta = "DELETE FROM grp_familiar 
                                WHERE id_grp = '" & Lblidgrp.Text & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()

            Catch ex As Exception
                'MUESTRA UN MENSAJE CON EL ERROR CAPTURADO
                MsgBox(ex.ToString)

            Finally
                'CERRAMOS EL DATAREADER Y LA BBDD
                drDataReader.Close()
                cnxnMySql.Close()
            End Try

            'FUNCION QUE CAMBIA EL COLOR DEL FONDO Y EL COLOR DE LA LETRA
            ChangeColorsCancelDelete()

            'FUNCION PARA LIMPIAR LOS CONTROLES
            CleanControls()

            'LIMPIAMOS LA VARIABLE BANDERA PARA LAS PROXIMAS ACCIONES
            strBandera = ""

            'DESACTIVA EL TEXTBOX
            TxtListNomGrupo.Enabled = False

            'LLAMAMOS A LA FUNCION PARA OCULTAR Y MOSTRAR BOTONES
            BtnSaveUpdateCancel()

        End If

    End Sub

    Private Sub BtnQuitarElmnto_Click(sender As Object, e As EventArgs) Handles BtnQuitarElmnto.Click

        'SI NO HAY UNA FILA SELECCIONADA MANDAMOS UN MENSAJE DE ALERTA
        If Lblidcli.Text = "" Then MsgBox("Selecciona un registro de la lista.", vbCritical, "Lista de integrantes") : Exit Sub

        'COMPROBAMOS LA RESPUESTA DEL MENSAJE
        If MsgBox("   Grupo         : " & TxtListNomGrupo.Text & vbCr &
                  "   Integrante  : " & DgvListIntgrntes.CurrentRow.Cells(1).Value & vbCr &
                  "   __________________________________________" & vbCr & vbCr &
                  "        ¿Seguro que quieres quitar de la lista?",
                  vbYesNo + vbDefaultButton2 + vbQuestion, "Lista de integrantes") = vbYes Then
            'SI LA RESPUESTA ES SI

            '::: COMPROBAMOS SI ESTAMOS EN ACTUALIZAR :::'
            '    AL QUITAR UN CLIENTE DE LISTA SE ACTUALIZA SUS DATOS
            '    DE LO CONTRARIO SOLO SE QUITA DE LA LISTA
            If strBandera = "MODIFY-UPDATE" Then

                'USAMOS TRY PARA CAPTURAR POSIBLES ERRORES
                Try
                    'CONECTAMOS CON LA BBDD Y LO ABRIMOS
                    cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                    cnxnMySql.Open()

                    'ACTALIZAR DATOS DEL CLIENTE
                    sqlConsulta = "UPDATE clientes SET mpg_cli = 'MENSUAL', id_grp = NULL
                                    WHERE id_cli = '" & Lblidcli.Text & "'"
                    cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                    drDataReader = cmdCommand.ExecuteReader()

                Catch ex As Exception
                    'MUESTRA UN MENSAJE CON EL ERROR CAPTURADO
                    MsgBox(ex.ToString)
                Finally
                    'CERRAMOS EL DATAREADER Y LA BBDD
                    drDataReader.Close()
                    cnxnMySql.Close()
                End Try

            End If 'FIN DE LA CONDICION strBandera = "MODIFY-UPDATE"

            'QUITAMOS EL REGISTRO DEL DGV
            DgvListIntgrntes.Rows.Remove(DgvListIntgrntes.CurrentRow)

            'CAMBIAMOS EL TEXTO DEL LABEL AL CAMBIAR EL VALOR DEL NUMERICUPDOWN
            LblNumIntgrntes.Text = DgvListIntgrntes.RowCount & " de " & NudNumIntgrntes.Value

        End If

        'LIMPIAMOS EL LABEL PARA LA PROXIMA CONSULTA
        Lblidcli.Text = ""
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        'CERRAMOS LA VENTANA
        Close()
    End Sub
    '
    '
    '
    Private Sub TxtListNomGrupo_TextChanged(sender As Object, e As EventArgs) Handles TxtListNomGrupo.TextChanged

        '::COMPROBAMOS EL VALOR DE LA VARIABLE BANDERA::'

        Select Case strBandera

            Case "NEW-SAVE"

                'COMPROBAMOS SI EL TEXTBOX ESTA VACIO O TIENE CARACTERES
                If TxtListNomGrupo.Text = "" Then
                    DgvListNomGrupo.Visible = False
                    NudNumIntgrntes.Enabled = False
                    BtnGuardar.Enabled = False

                Else
                    'ACTIVAMOS EL NUMERICUPDOWN Y EL BUTTON
                    NudNumIntgrntes.Enabled = True
                    BtnGuardar.Enabled = True

                    'HACEMOS UNA CONSULTA Y LE PASAMOS A LA FUNCION PARA COMPROBAR SI YA EXISTE ESE GRUPO
                    sqlConsulta = "SELECT * FROM grp_familiar WHERE
                                    nom_grp = '" & TxtListNomGrupo.Text & "'"
                    LlenarDgvListNomGrupo(sqlConsulta)
                End If

                '::SI LA CONSULTA NOS DEVUELVE UNA COINCIDENCIA PARA EVITAR DOS GRUPOS
                'CON EL MISMO NOMBRE DESACTIVAMOS EL NUMERICUPDOWN Y EL BUTTON::'
                If DgvListNomGrupo.Visible = True Then
                    NudNumIntgrntes.Enabled = False
                    BtnGuardar.Enabled = False
                End If

            Case "MODIFY-UPDATE"

                'COMPROBAMOS SI EL TEXTBOX ESTA VACIO O TIENE CARACTERES
                If TxtListNomGrupo.Text = "" Then

                    'OCULTAMOS EL DATAGRIDVIEW
                    DgvListNomGrupo.Visible = False

                    'DESACTIVAMOS EL NUMERICUPDOWN Y EL BUTTON
                    NudNumIntgrntes.Enabled = False
                    BtnActualizar.Enabled = False

                Else
                    'SI CHECKBOX ESTA ACTIVADO
                    If ChkGrpVacioNombre.Checked Then

                        'ACTIVAMOS EL NUMERICUPDOWN Y EL BUTTON
                        NudNumIntgrntes.Enabled = True
                        BtnActualizar.Enabled = True

                        'HACEMOS UNA CONSULTA Y LE PASAMOS A LA FUNCION PARA COMPROBAR SI YA EXISTE ESE GRUPO
                        sqlConsulta = "SELECT * FROM grp_familiar WHERE
                                        nom_grp = '" & TxtListNomGrupo.Text & "'"
                        LlenarDgvListNomGrupo(sqlConsulta)

                        'SI EL DATAGRIDVIEW ESTA ACTIVADO ES PORQUE HAY UN REGISTRO CON EL MISMO
                        'NOMBRE PARA EVITAR DUPLICIDAD DESACTIVAMOS EL NUMERICUPDOWN Y EL BUTTON
                        If DgvListNomGrupo.Visible = True Then
                            NudNumIntgrntes.Enabled = False
                            BtnActualizar.Enabled = False
                        End If

                    Else
                        'SI CHECKBOX ESTA DESACTIVADO
                        NudNumIntgrntes.Enabled = False
                        ChkGrpVacioNombre.Enabled = False
                        BtnActualizar.Enabled = False

                        'HACEMOS UNA CONSULTA A LA BBDD PARA MOSTRAR TODOS LOS GRUPO
                        'QUE COINCIDEN CON LA BUSQUEDA Y LE PASAMOS A LA FUNCION
                        sqlConsulta = "SELECT * FROM grp_familiar WHERE
                                        nom_grp LIKE '%" & TxtListNomGrupo.Text & "%' ORDER BY nom_grp"
                        LlenarDgvListNomGrupo(sqlConsulta)

                    End If
                End If

            Case "DELETE"

                'HACEMOS UNA CONSULTA A LA BBDD PARA MOSTRAR TODOS LOS GRUPO
                'QUE COINCIDEN CON LA BUSQUEDA Y LE PASAMOS A LA FUNCION
                sqlConsulta = "SELECT * FROM grp_familiar WHERE
                                nom_grp LIKE '%" & TxtListNomGrupo.Text & "%' ORDER BY nom_grp"
                LlenarDgvListNomGrupo(sqlConsulta)

                'COMPROBAMOS SI EL TEXTBOX ESTA VACIO OCULTAMOS EL DATAGRIDVIEW
                If TxtListNomGrupo.Text = "" Then DgvListNomGrupo.Visible = False

        End Select

    End Sub
    Private Sub TxtListNomGrupo_GotFocus(sender As Object, e As EventArgs) Handles TxtListNomGrupo.GotFocus
        'CAMBIAMOS EL COLOR DEL TEXTBOX AL RECIBIR EL ENFOQUE
        TxtListNomGrupo.BackColor = Color.Beige
    End Sub
    Private Sub TxtListNomGrupo_LostFocus(sender As Object, e As EventArgs) Handles TxtListNomGrupo.LostFocus
        'BUSCAR Y CORREGIR ESPACIOS EN BLANCO 
        TxtListNomGrupo.Text = Trim(TxtListNomGrupo.Text)
        While TxtListNomGrupo.Text.Contains("  ")
            TxtListNomGrupo.Text = TxtListNomGrupo.Text.Replace("  ", " ")
        End While
        'COMPROBAR SI EL TEXTBOX Y CAMBIAR DE COLOR
        If TxtListNomGrupo.Text = "" Then
            TxtListNomGrupo.BackColor = Color.MistyRose
        Else
            TxtListNomGrupo.BackColor = Color.Azure
        End If
    End Sub
    Private Sub TxtListNomGrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtListNomGrupo.KeyPress
        'AL PRESIONAR LA TECLA DE RETROCESO CAMBIAMOS DE COLOR EL TEXTBOX
        If e.KeyChar = ControlChars.Back Then
            TxtListNomGrupo.BackColor = Color.Beige
        End If
    End Sub
    '
    '
    '
    Private Sub ChkGrpVacioNombre_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGrpVacioNombre.CheckedChanged

        'COMPROBAMOS EL VALOR DE LA VARIABLE
        If strBandera = "NEW-SAVE" Then

            'SI EL TEXTBOX ESTÁ VACIO SALIMOS DEL CODIGO PARA
            If TxtListNomGrupo.Text = "" Then Exit Sub

            'COMPROBAMOS SI EL CHECKBOX ESTÁ ACTIVADO
            If ChkGrpVacioNombre.Checked Then

                'CAMBIA DE COLOR EL LABEL Y CAMBIA LA IMAGEN
                LblNumIntgrntes.BackColor = Color.Azure
                PicIntgrntes.Image = GymPaymentControl.My.Resources.Resources.ic_okay_28x28

                'DESACTIVAMOS LOS CONTROLES
                TxtBscrIntgrntes.Enabled = False
                DgvListIntgrntes.Enabled = False
                BtnQuitarElmnto.Enabled = False

                'LIMPIAMOS EL DATAGRIDVIEW
                DgvListIntgrntes.Rows.Clear()

                'ENVIAMOS EL ENFOQUE AL TEXTBOX
                TxtListNomGrupo.Focus()

            Else 'SI EL CHECKBOX ESTÁ DESACTIVADO

                'CAMBIA DE COLOR EL LABEL Y CAMBIA LA IMAGEN
                LblNumIntgrntes.BackColor = Color.MistyRose
                PicIntgrntes.Image = GymPaymentControl.My.Resources.Resources.ic_error_28x28

                'ACTIVAMOS LOS CONTROLES
                TxtBscrIntgrntes.Enabled = True
                DgvListIntgrntes.Enabled = True
                BtnQuitarElmnto.Enabled = True

                'ENVIAMOS EL ENFOQUE AL TEXTBOX
                TxtBscrIntgrntes.Focus()

            End If 'FIN DE COMPROBAR SI EL CHECKBOX ESTÁ ACTIVADO

        End If 'FIN DE LA COMPROBACIÓN DEL VALOR DE LA VARIABLE


        'COMPROBAMOS EL VALOR DE LA VARIABLE
        If strBandera = "MODIFY-UPDATE" Then

            'COMPROBAMOS SI EL CHECKBOX ESTÁ ACTIVADO
            If ChkGrpVacioNombre.Checked Then

                'ENVIAMOS EL ENFOQUE AL TEXTBOX
                TxtListNomGrupo.Focus()

            Else 'SI EL CHECKBOX ESTÁ DESACTIVADO

                'ENVIAMOS EL ENFOQUE AL TEXTBOX
                TxtBscrIntgrntes.Focus()

            End If

        End If
    End Sub
    '
    '
    '
    Private Sub NudNumPerson_ValueChanged(sender As Object, e As EventArgs) Handles NudNumIntgrntes.ValueChanged
    End Sub
    Private Sub NudNumPerson_GotFocus(sender As Object, e As EventArgs) Handles NudNumIntgrntes.GotFocus
        'CAMBIAMOS EL COLOR DE FONDO AL RECIBIR EL ENFOQUE
        NudNumIntgrntes.BackColor = Color.Beige
    End Sub
    Private Sub NudNumPerson_LostFocus(sender As Object, e As EventArgs) Handles NudNumIntgrntes.LostFocus
        'CAMBIAMOS EL COLOR DE FONDO AL PERDER EL ENFOQUE
        If NudNumIntgrntes.Value < 3 Then
            'SI EL NUMERICUPDOWN ES MENOR QUE 3
            NudNumIntgrntes.BackColor = Color.MistyRose
        Else
            'SI EL NUMERICUPDOWN ES IGUAL O MAYOR QUE 3
            NudNumIntgrntes.BackColor = Color.Azure
        End If
    End Sub
    Private Sub NudNumIntgrntes_TextChanged(sender As Object, e As EventArgs) Handles NudNumIntgrntes.TextChanged
        'CAMBIAMOS EL TEXTO DEL LABEL AL CAMBIAR EL VALOR DEL NUMERICUPDOWN
        LblNumIntgrntes.Text = DgvListIntgrntes.RowCount & " de " & NudNumIntgrntes.Value
    End Sub
    '
    '
    '
    Private Sub LblNumIntgrntes_Click(sender As Object, e As EventArgs) Handles LblNumIntgrntes.Click
    End Sub
    Private Sub LblNumIntgrntes_TextChanged(sender As Object, e As EventArgs) Handles LblNumIntgrntes.TextChanged

        'COMPROBAMOS EL VALOR DE LA VARIABLE PARA EJECUTAR CODIGO SEGUN EL CASO
        Select Case strBandera
            Case "NEW-SAVE"

                'COMPROBAMOS SI EL CHECKBOX ESTÁ ACTIVADO
                If ChkGrpVacioNombre.Checked Then

                    'COMPROBAR EL VALOR DEL NUMERICUPDOWN
                    If NudNumIntgrntes.Value < 3 Then

                        'CAMBIAR DE COLOR DEL TEXTBOX Y LA IMAGEN
                        LblNumIntgrntes.BackColor = Color.MistyRose
                        PicIntgrntes.Image = GymPaymentControl.My.Resources.Resources.ic_error_28x28

                    Else
                        'CAMBIAR DE COLOR DEL TEXTBOX Y LA IMAGEN
                        LblNumIntgrntes.BackColor = Color.Azure
                        PicIntgrntes.Image = GymPaymentControl.My.Resources.Resources.ic_okay_28x28

                    End If

                Else 'SI EL CHECKBOX ESTÁ DESACTIVADO

                    'COMPROBAR EL VALOR DEL NUMERICUPDOWN
                    If NudNumIntgrntes.Value < 3 Then

                        'CAMBIAR DE COLOR DEL TEXTBOX Y LA IMAGEN
                        LblNumIntgrntes.BackColor = Color.MistyRose
                        PicIntgrntes.Image = GymPaymentControl.My.Resources.Resources.ic_error_28x28

                        'DESACTIVAR CONTROLES
                        TxtBscrIntgrntes.Enabled = False
                        DgvListIntgrntes.Enabled = False
                        BtnQuitarElmnto.Enabled = False

                    Else 'SI NUMERICUPDOWN ES MAYOR QUE 3

                        'COMPROBAMOS SI LOS REGISTROS DEL DGV EL VALOR DEL NUD SON IGUALES
                        If DgvListIntgrntes.RowCount = NudNumIntgrntes.Value Then

                            'CAMBIAR DE COLOR DEL TEXTBOX Y LA IMAGEN
                            LblNumIntgrntes.BackColor = Color.Azure
                            PicIntgrntes.Image = GymPaymentControl.My.Resources.Resources.ic_okay_28x28

                        Else 'SI LOS REGISTROS DEL DGV EL VALOR DEL NUD SON DIFERENTES

                            'CAMBIAR DE COLOR DEL TEXTBOX Y LA IMAGEN
                            LblNumIntgrntes.BackColor = Color.MistyRose
                            PicIntgrntes.Image = GymPaymentControl.My.Resources.Resources.ic_error_28x28

                        End If

                        'ACTIVAMOS LOS CONTROLES
                        TxtBscrIntgrntes.Enabled = True
                        DgvListIntgrntes.Enabled = True
                        BtnQuitarElmnto.Enabled = True

                    End If 'FIN DE COMPROBAR EL VALOR DEL NUMERICUPDOWN

                End If 'FIN COMPROBACIÓN DEL ESTADO DEL CHECKBOX

            Case "MODIFY-UPDATE"

                'COMPROBAMOS SI LOS REGISTROS DEL DGV EL VALOR DEL NUD SON IGUALES
                If DgvListIntgrntes.RowCount = NudNumIntgrntes.Value Then

                    'CAMBIAR DE COLOR DEL TEXTBOX Y LA IMAGEN
                    LblNumIntgrntes.BackColor = Color.Azure
                    PicIntgrntes.Image = GymPaymentControl.My.Resources.Resources.ic_okay_28x28

                Else 'SI LOS REGISTROS DEL DGV EL VALOR DEL NUD SON DIFERENTES

                    'CAMBIAR DE COLOR DEL TEXTBOX Y LA IMAGEN
                    LblNumIntgrntes.BackColor = Color.MistyRose
                    PicIntgrntes.Image = GymPaymentControl.My.Resources.Resources.ic_error_28x28

                End If

                'ACTIVAMOS LOS CONTROLES
                TxtBscrIntgrntes.Enabled = True
                DgvListIntgrntes.Enabled = True
                BtnQuitarElmnto.Enabled = True

        End Select

    End Sub
    '
    '
    '
    Private Sub TxtBscrIntgrntes_TextChanged(sender As Object, e As EventArgs) Handles TxtBscrIntgrntes.TextChanged

        'COMPROBAMOS SI TxtBscrIntgrntes ESTA VACIO O TIENE TEXTO
        If TxtBscrIntgrntes.Text = "" Then
            'OCULTAMOS EL DgvBscrIntgrntes
            DgvBscrIntgrntes.Visible = False

            'COMPROBAR SI EL DgvListIntgrntes ESTA VACIO O NO PARA ACTIVAR/DESACTIVAR EL BtnQuitarElmnto
            If DgvListIntgrntes.RowCount = 0 Then
                BtnQuitarElmnto.Enabled = False
            Else
                BtnQuitarElmnto.Enabled = True
            End If

        Else
            'LLAMAMOS A LA FUNCION PARA LLENAR EL DATAGRIDVIEW Y CONSULTAMOS A LA BBDD
            LlenarDgvBscrIntgrntes()

            'DESACTIVAR EL BtnQuitarElmnto
            BtnQuitarElmnto.Enabled = False
        End If

    End Sub
    Private Sub TxtBscrIntgrntes_GotFocus(sender As Object, e As EventArgs) Handles TxtBscrIntgrntes.GotFocus
        'CAMBIAMOS EL COLOR AL RECIBIR EL ENFOQUE
        TxtBscrIntgrntes.BackColor = Color.Beige
    End Sub
    Private Sub TxtBscrIntgrntes_LostFocus(sender As Object, e As EventArgs) Handles TxtBscrIntgrntes.LostFocus
        'CAMBIAMOS EL COLOR AL RECIBIR EL ENFOQUE
        TxtBscrIntgrntes.BackColor = Color.Azure
    End Sub
    Private Sub TxtBscrIntgrntes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBscrIntgrntes.KeyPress
        'AL PRESIONAR LA TECLA DE RETROCESO CAMBIAMOS DE COLOR EL TEXTBOX
        If e.KeyChar = ControlChars.Back Then
            TxtBscrIntgrntes.BackColor = Color.Beige
        End If
    End Sub
    '
    '
    '
    Private Sub DgvListNomGrupo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListNomGrupo.CellContentClick
    End Sub
    Private Sub DgvListNomGrupo_DoubleClick(sender As Object, e As EventArgs) Handles DgvListNomGrupo.DoubleClick

        'COMPROBAMOS LA VARIABLE PARA HACER LA CONSULTA Y PODER LLENAR LOS CONTROLES CON LOS DATOS CORRESPONDIENTES
        If strBandera = "MODIFY-UPDATE" Or strBandera = "DELETE" Then

            'LLENAMOS EL TEXTBOX CON EL NOMBRE DEL GRUPO
            TxtListNomGrupo.Text = DgvListNomGrupo.CurrentRow.Cells(1).Value

            'CAMBIAMOS EL VALOR DEL NUMERICUPDOWN POR LA CANTIDAD DE INTEGRANTES DEL GRUPO
            NudNumIntgrntes.Value = DgvListNomGrupo.CurrentRow.Cells(2).Value
            NudNumIntgrntes.BackColor = Color.Azure

            'LLENAMOS EL LABEL CON EL ID DEL GRUPO
            Lblidgrp.Text = DgvListNomGrupo.CurrentRow.Cells(0).Value

            'USAMOS TRY PARA CAPTURAR POSIBLES ERRORES
            Try
                'CONECTAMOS CON LA BBDD Y LO ABRIMOS
                cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
                cnxnMySql.Open()

                'HACEMOS LA CONSULTA PARA LLENAR EL DATAGRIDVIEW
                sqlConsulta = "SELECT id_cli, nom_cli, ape_cli, id_grp FROM clientes
                                WHERE id_grp = '" & Lblidgrp.Text & "'"
                cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
                drDataReader = cmdCommand.ExecuteReader()
                DgvListIntgrntes.Rows.Clear()

                'MIENTRAS RECORRE EL DATAREADER LLENAMOS EL DATAGRIDVIEW
                While drDataReader.Read()
                    'AGREGAMOS UNA FILA AL DATAGRIDVIEW
                    nRow = DgvListIntgrntes.Rows.Add()
                    'ID DEL CLIENTE
                    DgvListIntgrntes.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString
                    'CONCATENAMOS NOMBRE Y APELLIDO DEL CLIENTE
                    Dim nomApe = drDataReader.GetString(1) & " " & drDataReader.GetString(2)
                    DgvListIntgrntes.Rows(nRow).Cells(1).Value = nomApe
                    'ID DEL GRUPO
                    DgvListIntgrntes.Rows(nRow).Cells(2).Value = drDataReader.GetInt16(3).ToString
                End While

            Catch ex As Exception

                'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
                MsgBox(ex.ToString)

            Finally

                'CERRAMOS EL DATAREADER Y LA BBDD
                drDataReader.Close()
                cnxnMySql.Close()
            End Try

            'OCULTAMOS EL DATAGRIDVIEW
            DgvListNomGrupo.Visible = False

        End If

        If strBandera = "MODIFY-UPDATE" Then

            'DESACTIVAMOS LOS CONTROLES
            BtnActualizar.Enabled = True
            NudNumIntgrntes.Enabled = True
            ChkGrpVacioNombre.Enabled = True

        End If
    End Sub
    '
    '
    '
    Private Sub DgvBscrIntgrntes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBscrIntgrntes.CellContentClick
    End Sub
    Private Sub DgvBscrIntgrntes_DoubleClick(sender As Object, e As EventArgs) Handles DgvBscrIntgrntes.DoubleClick

        'AGREGAMOS EL CLIENTE A LA LISTA DE LOS INTEGRANTES DEL GRUPO
        DgvListIntgrntes.Rows.Add(DgvBscrIntgrntes.CurrentRow.Cells(0).Value,
                                  DgvBscrIntgrntes.CurrentRow.Cells(1).Value,
                                  DgvBscrIntgrntes.CurrentRow.Cells(2).Value)

        'LIMPIAMOS EL TxtBscrIntgrntes Y LE ENVIAMOS EL ENFOQUE
        TxtBscrIntgrntes.Clear()
        TxtBscrIntgrntes.Focus()
    End Sub
    '
    '
    '
    Private Sub DgvListIntgrntes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListIntgrntes.CellContentClick
    End Sub
    Private Sub DgvListIntgrntes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListIntgrntes.CellClick
        'SI EL DDD ESTA VACIO SALIMOS DEL CODIGO
        If DgvListIntgrntes.RowCount = 0 Then Exit Sub

        'LLENAMOS EL LblQuitarElmnto CON EL ID DEL CLIENTE
        Lblidcli.Text = DgvListIntgrntes.CurrentRow.Cells(0).Value
    End Sub
    Private Sub DgvListIntgrntes_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DgvListIntgrntes.RowsAdded
        'ACTUALIZAMOS EL TEXTO DEL LABEL
        LblNumIntgrntes.Text = DgvListIntgrntes.RowCount & " de " & NudNumIntgrntes.Value
    End Sub
    Private Sub DgvListIntgrntes_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DgvListIntgrntes.RowsRemoved
        'ACTUALIZAMOS EL TEXTO DEL LABEL
        LblNumIntgrntes.Text = DgvListIntgrntes.RowCount & " de " & NudNumIntgrntes.Value
    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::'
    ''---------->>>>>>>>>> PROCEDIMIENTOS <<<<<<<<<<----------''
    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::'
    Sub CtrlsDeactivate()

        'DESACTIVA LOS CONTROLES
        TxtListNomGrupo.Enabled = False
        NudNumIntgrntes.Enabled = False
        ChkGrpVacioNombre.Enabled = False
        TxtBscrIntgrntes.Enabled = False
        DgvListIntgrntes.Enabled = False
        BtnQuitarElmnto.Enabled = False

    End Sub

    Sub CleanControls()

        'LIMPIA LOS CONTROLES
        Lblidgrp.Text = ""
        TxtListNomGrupo.Clear()
        NudNumIntgrntes.Value = 0
        TxtBscrIntgrntes.Clear()
        Lblidcli.Text = ""
        DgvListIntgrntes.Rows.Clear()

    End Sub

    Sub BtnNewModify()

        'OCULTAR BOTONES
        BtnNuevo.Visible = False
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        BtnCancelar.Visible = True

        'DESACTIVAR TEXTBOX
        TxtListNomGrupo.Enabled = True

    End Sub

    Sub BtnSaveUpdateCancel()

        'MOSTRAR Y OCULTAR LOS BOTONES
        BtnNuevo.Visible = True
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnGuardar.Visible = False
        BtnEliminar.Visible = True

        BtnActualizar.Visible = False
        BtnCancelar.Visible = False
        BtnDeleteGroup.Visible = False

    End Sub

    Sub ChangeColorsNewEdit()

        'CAMBIAR COLOR DE FONDO
        NudNumIntgrntes.BackColor = Color.Azure
        LblNumIntgrntes.BackColor = Color.Azure
        TxtBscrIntgrntes.BackColor = Color.Azure

        'CAMBIAR EL COLOR DEL TEXTO
        NudNumIntgrntes.ForeColor = Color.MediumBlue
        LblNumIntgrntes.ForeColor = Color.MediumBlue

    End Sub

    Sub ChangeColorsCancelDelete()

        'CAMBIA EL COLOR DE FONDO
        TxtListNomGrupo.BackColor = Color.FromName("Control")
        NudNumIntgrntes.BackColor = Color.FromName("Control")
        LblNumIntgrntes.BackColor = Color.FromName("Control")
        TxtBscrIntgrntes.BackColor = Color.FromName("Control")

        'CAMBIA EL COLOR DE LA LETRA
        NudNumIntgrntes.ForeColor = Color.FromName("Control")
        LblNumIntgrntes.ForeColor = Color.FromName("Control")

        'QUITA LA IMAGEN
        PicIntgrntes.Image = Nothing

    End Sub

    Sub LlenarDgvListNomGrupo(ByVal strConsulta As String)
        'CAPTURAR POSIBLES ERRORES
        Try
            'CONECTAMOS Y ABRIMOS LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'EJECUTAMOS LA CONSULTA CON EL PARAMETRO RECIBIDO
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            DgvListNomGrupo.Rows.Clear()

            'COMPROBAMOS SI LA CONSULTA DEVUELVE REGISTROS PARA LLENAR EL DATAGRIDVIEW
            If drDataReader.HasRows Then

                'MOSTRAMOS EL DATAGRIDVIEW Y PONEMOS ENCIMA DE LOS DEMAS CONTROLES
                DgvListNomGrupo.Visible = True
                DgvListNomGrupo.BringToFront()

                'MIENTRAS RECORRE EL DATAREADER LLENAMOS EL DATAGRIDVIEW
                While drDataReader.Read()
                    'AGREGAMOS UNA FILA AL DATAGRIDVIEW
                    nRow = DgvListNomGrupo.Rows.Add()
                    'LLENAMOS CON EL ID DEL GRUPO
                    DgvListNomGrupo.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString
                    'NOMBRE DEL GRUPO
                    DgvListNomGrupo.Rows(nRow).Cells(1).Value = drDataReader.GetString(1).ToString
                    'NUMERO DE INTEGRANTES
                    DgvListNomGrupo.Rows(nRow).Cells(2).Value = drDataReader.GetInt16(2).ToString
                End While

            Else
                'SI NO HAY REGISTROS OCULTAMOS EL DATAGRIDVIEW Y ACTIVAMOS EL CHECKBOX
                DgvListNomGrupo.Visible = False

            End If

            'CERRAMOS EL DATAREADER
            drDataReader.Close()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            'ERROR GENERADO POR INGRESAR ESTE CARACTER ' Y OTROS POSIBLES CARACTERES QUE INFLUYAN EN LA CONSULTA A LA BBDD
            TxtListNomGrupo.BackColor = Color.MistyRose
            DgvListNomGrupo.Rows.Clear()
            Exit Try

        Catch ex As Exception
            'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
            MsgBox(ex.ToString)

        Finally
            'CERRAMOS LA BBDD 'CERRAMOS EL DATAREADER drDataReader.Close()
            cnxnMySql.Close()
        End Try
    End Sub

    Sub LlenarDgvBscrIntgrntes()
        'CAPTURAR POSIBLES ERRORES
        Try
            'CONECTAMOS Y ABRIMOS LA BBDD
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()

            'HACEMOS LA CONSULTA PARA LLENAR EL DATAGRIDVIEW
            sqlConsulta = "SELECT id_cli, nom_cli, ape_cli, id_grp FROM clientes WHERE
                            (nom_cli LIKE '" & TxtBscrIntgrntes.Text & "%' OR
                            ape_cli LIKE '" & TxtBscrIntgrntes.Text & "%') 
                            AND id_grp IS NULL ORDER BY nom_cli"
            'mpg_cli, ISNULL(id_grp) 
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            DgvBscrIntgrntes.Rows.Clear()

            'COMPROBAMOS SI LA CONSULTA DEVUELVE REGISTROS
            If drDataReader.HasRows Then

                'MOSTRAMOS EL DATAGRIDVIEW Y PONEMOS ENCIMA DE LOS DEMAS CONTROLES
                DgvBscrIntgrntes.Visible = True
                DgvBscrIntgrntes.BringToFront()

                'MIENTRAS RECORRE EL DATAREADER LLENAMOS EL DATAGRIDVIEW
                While drDataReader.Read()
                    'AGREGAMOS UNA FILA AL DATAGRIDVIEW
                    nRow = DgvBscrIntgrntes.Rows.Add()
                    'ID CLIENTE
                    DgvBscrIntgrntes.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString
                    'CONCATENAMOS EL NOMBRE Y EL APELLIDO
                    Dim strNomApe = drDataReader.GetString(1) & "  " & drDataReader.GetString(2)
                    DgvBscrIntgrntes.Rows(nRow).Cells(1).Value = strNomApe
                    'COMPROBAR SI EL CAMPO "id_grp" ES NULO
                    If Not (drDataReader("id_grp") Is DBNull.Value) Then
                        DgvBscrIntgrntes.Rows(nRow).Cells(2).Value = drDataReader.GetInt16(3).ToString
                    End If
                End While

            Else
                'SI NO HAY REGISTROS OCULTAMOS EL DATAGRIDVIEW
                DgvBscrIntgrntes.Visible = False
            End If

            'CERRAMOS EL DATAREADER
            drDataReader.Close()

        Catch ex As MySql.Data.MySqlClient.MySqlException

            'ERROR GENERADO POR INGRESAR ESTE CARACTER ' Y OTROS POSIBLES CARACTERES QUE INFLUYAN EN LA CONSULTA A LA BBDD
            TxtBscrIntgrntes.BackColor = Color.MistyRose
            DgvListIntgrntes.Rows.Clear()
            Exit Try

        Catch ex As Exception

            'MOSTRAMOS UN MENSAJE CON EL ERROR CAPTURADO
            MsgBox(ex.ToString)

        Finally

            'CERRAMOS LA BBDD 'CERRAMOS EL DATAREADER drDataReader.Close()
            cnxnMySql.Close()
        End Try
    End Sub

End Class