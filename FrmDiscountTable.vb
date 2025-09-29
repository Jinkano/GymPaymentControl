Imports MySql.Data.MySqlClient

Public Class FrmDiscountTable

    Dim cnxnMySql As New MySqlConnection
    Dim drDataReader As MySqlDataReader
    Dim cmdCommand As MySqlCommand
    Dim nRow, idTarifa, intMsgBox, nudMin, nudMax As Int16
    Dim precio, dscnto, apagar, pdMin, pdMax, fijoMes As Decimal
    Dim sqlConsulta, strCadena, strMsgBox, strBandera As String

    Private Sub FrmDiscountTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LlenarDgvTarifas() 'LLENAR GRILLA CON LAS TARIFAS

        BtnGuarActuCancElim() 'LLAMA FUNCIÓN ACTIVAR/DESACTIVAR BOTONES

    End Sub

    Private Sub CmbTipoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoPago.SelectedIndexChanged
    End Sub
    Private Sub CmbTipoPago_TextChanged(sender As Object, e As EventArgs) Handles CmbTipoPago.TextChanged

        LimpiarCuadros() 'LIMPIA LOS CUADROS DE TEXTO

        LimpiarVariables() 'LIMPIA LAS VARIABLES

        DesactivarCuadros() 'DESACTIVA LOS CUADROS DE TEXTO

        Select Case CmbTipoPago.Text

            Case "CLASES SUELTAS"
                '
                NudNumPerson.Value = 1
                TxtPrecio.Enabled = True
                TxtTotal.Clear()
                LblNomPago.Text = "DIARIO"
                TxtPrecio.Focus()

            Case "DESCUENTO POR EDAD"
                '
                TxtPrecio.Text = FormatCurrency(fijoMes)
                TxtTotal.Text = FormatCurrency(fijoMes)
                TxtDscnto.Enabled = True
                TxtApagar.Enabled = True
                NudNumPerson.Value = 1
                NudEdadMin.Enabled = True
                NudEdadMax.Enabled = True
                LblNomPago.Text = "DSCTO EDAD"
                TxtDscnto.Focus()

            Case "GRUPO FAMILIAR"
                '
                TxtPrecio.Text = FormatCurrency(fijoMes)
                TxtDscnto.Enabled = True
                TxtApagar.Enabled = True
                NudNumPerson.Enabled = True
                NudNumPerson.Value = 1
                LblNomPago.Text = "GRUPO FAM"
                NudNumPerson.Focus()

            Case "MENSUALIDAD + IMPLEMENTOS"
                '
                NudNumPerson.Value = 1
                TxtPrecio.Enabled = True
                TxtTotal.Clear()
                LblNomPago.Text = "MES + IMPLE"
                TxtPrecio.Focus()
        End Select
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecio.TextChanged

        'EVALUAMOS LA VARIABLE PARA CALCULAR EL PRECIO APAGAR
        If strBandera = "SELECT REG" Then Exit Sub

        'LLAMAR A LA FUNCIÓN PARA NO PONER LA COMA SIN NÚMEROS Y NO ACEPTAR DOS COMAS
        EnteroDecimal(TxtPrecio, precio)

        'DIVIDIMOS EL TEXTO EN UN ARREGLO DE CADENAS
        Dim strTpago() As String = LblNomPago.Text.Split(" ")

        'ASIGNAR NOMBRE AL TIPO DE PRECIO
        If strTpago(0) = "DIARIO" Then 'CLASES SUELTAS
            pdMin = fijoMes * 0.1
            pdMax = fijoMes * 0.3
            LblNomPago.Text = "DIARIO " & precio
            'TxtTotal.Text = TxtPrecio.Text
            If TxtPrecio.Text = "" Then LblNomPago.Text = "DIARIO"

        ElseIf strTpago(0) = "MES" Then 'MENSUALIDAD + IMPLEMENTOS
            pdMin = fijoMes + (fijoMes / 2)
            pdMax = fijoMes * 3
            LblNomPago.Text = "MES + IMPLE " & precio
            'TxtTotal.Text = TxtPrecio.Text
            If TxtPrecio.Text = "" Then LblNomPago.Text = "MES + IMPLE"

        Else
            pdMin = 0
            pdMax = fijoMes
        End If

        'COMPROBAMOS SI NO HAY TARIFAS
        If DgvTabla.RowCount = 0 Or strTpago(0) = "MENSUAL" Then pdMin = 10 : pdMax = 100

        'LLAMAR A LA FUNCIÓN PARA COMPROBAR SI EL TEXTBOX CUMPLE CON LAS CONDICIONES
        FuenteErrorOk(TxtPrecio, precio, pdMin, pdMax)

    End Sub

    Private Sub TxtPrecio_GotFocus(sender As Object, e As EventArgs) Handles TxtPrecio.GotFocus

        TxtPrecio.SelectAll() 'SELECCIONA TODO EL TEXTO AL RECIBIR EL ENFOQUE
    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress

        SoloNumeros(TxtPrecio.Text, e) 'FUNCIÓN PARA ADMITIR SOLO NÚMEROS
    End Sub

    Private Sub TxtPrecio_LostFocus(sender As Object, e As EventArgs) Handles TxtPrecio.LostFocus

        If TxtPrecio.Text = "" Then TxtPrecio.Text = "0" 'SI EL PRECIO ESTA VACIO LE ASIGNA CERO
    End Sub

    Private Sub TxtDscnto_TextChanged(sender As Object, e As EventArgs) Handles TxtDscnto.TextChanged

        'EVALUAMOS LA VARIABLE PARA CALCULAR EL PRECIO APAGAR
        If strBandera = "APAGAR" Or strBandera = "SELECT REG" Then Exit Sub

        'LLAMAR A LA FUNCIÓN PARA NO PONER LA COMA SIN NÚMEROS Y NO ACEPTAR DOS COMAS
        EnteroDecimal(TxtDscnto, dscnto)

        'DIVIDIMOS EL TEXTO EN UN ARREGLO DE CADENAS
        Dim strTpago() As String = LblNomPago.Text.Split(" ")

        'ASIGNAR NOMBRE AL TIPO DE PRECIO
        If strTpago(0) = "DSCTO" Then 'DESCUENTO POR EDAD
            pdMin = fijoMes * 0.1
            pdMax = fijoMes * 0.4
            TxtApagar.Text = FormatCurrency(fijoMes - dscnto)

        ElseIf strTpago(0) = "GRUPO" Then 'GRUPO FAMILIAR
            pdMin = (fijoMes * NudNumPerson.Value) * 0.05
            pdMax = (fijoMes * NudNumPerson.Value) * 0.25
            TxtApagar.Text = FormatCurrency((fijoMes * NudNumPerson.Value) - dscnto)

        Else
            pdMin = 0
            pdMax = 0
        End If

        'LLAMAR A LA FUNCIÓN PARA COMPROBAR SI EL TEXTBOX CUMPLE CON LAS CONDICIONES
        FuenteErrorOk(TxtDscnto, dscnto, pdMin, pdMax)

        'SI EL DESCUENTO SE QUEDA EN BLANCO SE LIMPIA APAGAAR
        If TxtDscnto.Text = "" Then TxtApagar.Text = ""

    End Sub

    Private Sub TxtDscnto_GotFocus(sender As Object, e As EventArgs) Handles TxtDscnto.GotFocus

        TxtDscnto.SelectAll() 'AL RECIBIR EL ENFOQUE SELECCIONA TODO EL TEXTO

        strBandera = "DESCUENTO" 'LLENAMOS LA VARIABLE PARA PODER CALCULAR EL PRECIO A PAGAR
    End Sub

    Private Sub TxtDscnto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDscnto.KeyPress

        SoloNumeros(TxtDscnto.Text, e) 'FUNCIÓN PARA ADMITIR SOLO NÚMEROS
    End Sub

    Private Sub TxtDscnto_LostFocus(sender As Object, e As EventArgs) Handles TxtDscnto.LostFocus

        'AL PERDER EL ENFOQUE, SI ESTÁ VACIO LE ASIGNA CERO
        If TxtDscnto.Text = "" Then TxtDscnto.Text = "0" : TxtApagar.Text = ""

    End Sub

    Private Sub TxtApagar_TextChanged(sender As Object, e As EventArgs) Handles TxtApagar.TextChanged

        'EVALUAMOS LA VARIABLE PARA CALCULAR EL DESCUENTO
        If strBandera = "DESCUENTO" Or strBandera = "SELECT REG" Then Exit Sub

        'LLAMAR A LA FUNCIÓN PARA NO PONER LA COMA SIN NÚMEROS Y NO ACEPTAR DOS COMAS
        EnteroDecimal(TxtApagar, apagar)

        'DIVIDIMOS EL TEXTO EN UN ARREGLO DE CADENAS
        Dim strTpago() As String = LblNomPago.Text.Split(" ")

        'ASIGNAR NOMBRE AL TIPO DE PRECIO
        If strTpago(0) = "DSCTO" Then 'DESCUENTO POR EDAD
            pdMin = fijoMes - (fijoMes * 0.4)
            pdMax = fijoMes - (fijoMes * 0.1)
            TxtDscnto.Text = FormatCurrency(fijoMes - apagar)

        ElseIf strTpago(0) = "GRUPO" Then 'GRUPO FAMILIAR
            Dim total As Decimal = fijoMes * NudNumPerson.Value
            pdMin = total - (total * 0.25)
            pdMax = total - (total * 0.05)
            TxtDscnto.Text = FormatCurrency(total - apagar)

        Else
            pdMin = 0
            pdMax = 0
        End If

        'LLAMAR A LA FUNCIÓN PARA COMPROBAR SI EL TEXTBOX CUMPLE CON LAS CONDICIONES
        FuenteErrorOk(TxtApagar, apagar, pdMin, pdMax)

        'SI EL DESCUENTO SE QUEDA EN BLANCO SE LIMPIA APAGAR
        If TxtApagar.Text = "" Then TxtDscnto.Text = ""

    End Sub

    Private Sub TxtApagar_GotFocus(sender As Object, e As EventArgs) Handles TxtApagar.GotFocus

        TxtApagar.SelectAll() 'AL RECIBIR EL ENFOQUE SELECCIONA TODO EL TEXTO

        strBandera = "APAGAR" 'LLENAMOS LA VARIABLE PARA PODER CALCULAR EL DESCUENTO
    End Sub

    Private Sub TxtApagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApagar.KeyPress

        SoloNumeros(TxtApagar.Text, e) 'FUNCIÓN PARA ADMITIR SOLO NÚMEROS
    End Sub

    Private Sub TxtApagar_LostFocus(sender As Object, e As EventArgs) Handles TxtApagar.LostFocus

        'AL PERDER EL ENFOQUE, SI ESTÁ VACIO LE ASIGNA CERO
        If TxtApagar.Text = "" Then TxtApagar.Text = "0" : TxtDscnto.Text = ""

    End Sub

    Private Sub NudIntgrnts_ValueChanged(sender As Object, e As EventArgs) Handles NudNumPerson.ValueChanged
    End Sub
    Private Sub NudIntgrnts_GotFocus(sender As Object, e As EventArgs) Handles NudNumPerson.GotFocus

        NudNumPerson.Select(0, 2) 'SELECCIONA TODO EL TEXTO AL RECIBIR EL EMFOQUE
    End Sub

    Private Sub NudIntgrnts_TextChanged(sender As Object, e As EventArgs) Handles NudNumPerson.TextChanged

        If strBandera = "SELECT REG" Then Exit Sub

        LblNomPago.Text = "GRUPO FAM " & NudNumPerson.Value 'LE ASIGNA EL NOMBRE DEL PAGO

        TxtTotal.Text = FormatCurrency(fijoMes * NudNumPerson.Value) 'MULTIPLICA EL PRECIO POR EL Nº DE INTEGRANTES

    End Sub

    Private Sub NudEdadMin_ValueChanged(sender As Object, e As EventArgs) Handles NudEdadMin.ValueChanged
    End Sub
    Private Sub NudEdadMin_GotFocus(sender As Object, e As EventArgs) Handles NudEdadMin.GotFocus

        NudEdadMin.Select(0, 2) 'SELECCIONA TODO EL TEXTO AL RECIBIR EL EMFOQUE
    End Sub

    Private Sub NudEdadMin_TextChanged(sender As Object, e As EventArgs) Handles NudEdadMin.TextChanged

        If strBandera = "SELECT REG" Then Exit Sub

        LblNomPago.Text = "DSCTO EDAD " & NudEdadMin.Value & "-" & NudEdadMax.Value 'LE ASIGNA EL NOMBRE DEL PAGO
    End Sub

    Private Sub NudEdadMax_ValueChanged(sender As Object, e As EventArgs) Handles NudEdadMax.ValueChanged
    End Sub
    Private Sub NudEdadMax_GotFocus(sender As Object, e As EventArgs) Handles NudEdadMax.GotFocus

        NudEdadMax.Select(0, 2) 'SELECCIONA TODO EL TEXTO AL RECIBIR EL EMFOQUE
    End Sub

    Private Sub NudEdadMax_TextChanged(sender As Object, e As EventArgs) Handles NudEdadMax.TextChanged

        If strBandera = "SELECT REG" Then Exit Sub

        LblNomPago.Text = "DSCTO EDAD " & NudEdadMin.Value & "-" & NudEdadMax.Value 'LE ASIGNA EL NOMBRE DEL PAGO
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        LimpiarCuadros() 'LLAMA FUNCION LIMPIAR TEXTOS

        LimpiarVariables() 'LIMPIA LAS VARIABLES

        BtnNuevoModificar() 'LLAMA FUNCIÓN ACTIVAR/DESACTIVAR BOTONES

        'COMPROBAMOS SI LA TABLA NO TIENE REGISTROS PARA FIJAR EL PRECIO PRINCIPAL
        If DgvTabla.RowCount = 0 Then
            CmbTipoPago.Enabled = False
            NudNumPerson.Value = 1
            LblNomPago.Text = "MENSUAL"
            TxtTotal.Clear()
            TxtPrecio.Enabled = True
            TxtPrecio.Focus()
            pdMin = 10
            pdMax = 100
        Else
            CmbTipoPago.Focus()
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        'COMPROBAR SI HAY REGISTRO SELECCIONADO
        If idTarifa = 0 Then MsgBox("Selecciona un registro de la lista para MODIFICAR.", vbCritical, "Verificar") : DgvTabla.Focus() : Exit Sub

        strBandera = "" 'LIMPIAMOS LA VARIBLE

        'DIVIDIMOS EL TEXTO EN UN ARREGLO DE CADENAS
        Dim strTpago() As String = LblNomPago.Text.Split(" ")

        'EVALUAMOS EL NOMBRE TIPO DE PRECIO
        If strTpago(0) = "DIARIO" Or strTpago(0) = "MES" Then 'CLASES SUELTAS Y MENSUALIDAD + IMPLEMENTOS
            TxtPrecio.Enabled = True
            TxtPrecio.Focus()

        ElseIf strTpago(0) = "DSCTO" Then 'DESCUENTO POR EDAD
            TxtDscnto.Enabled = True
            TxtApagar.Enabled = True
            NudEdadMin.Enabled = True
            NudEdadMax.Enabled = True
            TxtDscnto.Focus()
            nudMin = NudEdadMin.Value
            nudMax = NudEdadMax.Value

        ElseIf strTpago(0) = "GRUPO" Then 'GRUPO FAMILIAR
            TxtDscnto.Enabled = True
            TxtApagar.Enabled = True
            NudNumPerson.Enabled = True
            TxtDscnto.Focus()
            nudMax = NudNumPerson.Value

        Else
            intMsgBox = MsgBox("Vas a modificar el PRECIO FIJO." + vbCr +
                               "Se modificarán todas las tarifas con el nuevo precio.." + vbCr + vbCr +
                               "¿Estás seguro de modificar el precio fijo?" _
                               , vbQuestion + vbYesNo + vbDefaultButton2, "Advertencia")

            'COMPROBAMOS LA RESPUESTA DEL USUARIO PARA MODIFICAR O NO HACER NADA
            If intMsgBox = vbYes Then

                TxtPrecio.Enabled = True
                TxtPrecio.Focus()
            Else
                Exit Sub
            End If
        End If

        'LLAMA FUNCIÓN ACTIVAR/DESACTIVAR BOTONES
        BtnNuevoModificar()
        CmbTipoPago.Enabled = False
        BtnGuardar.Visible = False
        BtnActualizar.Visible = True


    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        'SELECCIONAMOS EL CASO SEGUN EL CODIGO DE LA TARIFA
        Select Case idTarifa

            Case 0 'SI NO SE SELECCIONA UN REGISTRO
                MsgBox("Selecciona un registro para ELIMINAR.", vbCritical, "Verificar")
                DgvTabla.Focus()

            Case 1 'SI SE SELECCIONA EL PRECIO FIJO
                MsgBox("No se puede ELIMINAR el precio fijo mensual." + vbCr + vbCr +
                       "Puedes MODIFICAR el valor del precio establecido.", vbInformation, "Advertencia")
                DgvTabla.Focus()

            Case Else 'SI SE SELECCIONA UN REGISTRO DIFERENTE AL PRECIO FIJO

                'DIVIDIMOS EL TEXTO EN UN ARREGLO DE CADENAS
                Dim strTpago() As String = LblNomPago.Text.Split(" ")

                'EVALUAMOS EL NOMBRE DEL TIPO DE PAGO PARA CREAR EL MENSAJE
                If strTpago(0) = "DIARIO" Then 'CLASES SUELTAS

                    strMsgBox = "REGISTRO SELECCIONADO : CLASES SUELTAS" & Chr(13) & Chr(13) &
                                   "Código de registro - " & idTarifa & Chr(13) &
                                   "------------------------------- " & Chr(13) &
                                   "Precio          --->  " & TxtPrecio.Text & Chr(13) &
                                   "Descuento  --->  " & TxtDscnto.Text & Chr(13) & Chr(13) &
                                   "¿Está seguro de ELIMINAR el registro?"

                ElseIf strTpago(0) = "DSCTO" Then 'DESCUENTO POR EDAD

                    strMsgBox = "REGISTRO SELECCIONADO : DESCUENTO POR EDAD" & Chr(13) & Chr(13) &
                                   "Código de registro - " & idTarifa & Chr(13) &
                                   "------------------------------- " & Chr(13) &
                                   "Precio          --->  " & TxtPrecio.Text & Chr(13) &
                                   "Descuento  --->  " & TxtDscnto.Text & Chr(13) &
                                   "EDAD" & Chr(13) &
                                   "   Mínima   --->  " & NudEdadMin.Value & Chr(13) &
                                   "   Máxima   --->  " & NudEdadMax.Value & Chr(13) & Chr(13) &
                                   "¿Está seguro de ELIMINAR el registro?"

                ElseIf strTpago(0) = "GRUPO" Then 'GRUPO FAMILIAR

                    strMsgBox = "REGISTRO SELECCIONADO : GRUPO FAMILIAR" & Chr(13) & Chr(13) &
                                   "Código de registro - " & idTarifa & Chr(13) &
                                   "------------------------------- " & Chr(13) &
                                   "Precio total   --->  " & TxtTotal.Text & Chr(13) &
                                   "Nº Personas  --->  " & NudNumPerson.Value & Chr(13) &
                                   "Descuento    --->  " & TxtDscnto.Text & Chr(13) &
                                   "A pagar         --->  " & TxtApagar.Text & Chr(13) & Chr(13) &
                                   "¿Está seguro de ELIMINAR el registro?"

                ElseIf strTpago(0) = "MES" Then 'MENSUALIDAD + IMPLEMENTOS

                    strMsgBox = "REGISTRO SELECCIONADO : MENSUALIDAD + IMPLEMENTOS" & Chr(13) & Chr(13) &
                                   "Código de registro - " & idTarifa & Chr(13) &
                                   "------------------------------- " & Chr(13) &
                                   "Precio          --->  " & TxtPrecio.Text & Chr(13) &
                                   "Descuento  --->  " & TxtDscnto.Text & Chr(13) & Chr(13) &
                                   "¿Está seguro de ELIMINAR el registro?"
                End If

                'MENSAJE DE CONFIRMACION ANTES DE ELIMINAR
                intMsgBox = MsgBox(strMsgBox, vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar un registro")

                'COMPROBAMOS LA RESPUESTA DEL MENSAJE
                If intMsgBox = vbYes Then

                    'CONSULTAMOS A LA BBDD Y LO PASAMOS A LA FUNCION
                    sqlConsulta = "DELETE FROM trfa_dscto WHERE id_trfa  = '" & idTarifa & "'"
                    Consultas(sqlConsulta)

                    LlenarDgvTarifas() 'LLENAR GRILLA CON LAS TARIFAS

                    BtnGuarActuCancElim() 'LLAMAR FUNCION ACTIVAR/DESACTIVAR BOTONES

                    LimpiarCuadros() 'LLAMA FUNCION LIMPIAR TEXTOS

                    DesactivarCuadros() 'DESACTIVA LOS CUADROS DE TEXTO

                End If
        End Select

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        '
        Select Case CmbTipoPago.Text
            Case "CLASES SUELTAS"
                'COMPROBAR SI SE HA INGRESADO UN PRECIO
                If TxtPrecio.Text = "0 €" Then MsgBox("Corrige el PRECIO de las Clases sueltas.", vbCritical, "Fijar precio") : TxtPrecio.Focus() : Exit Sub

                'SI TODO ESTÁ CORRECTO SE ENVÍA MENSAJE DE CONFIRMACIÓN
                strMsgBox = "La TARIFA fijada es de " & TxtPrecio.Text & " por día." & Chr(13) & Chr(13) &
                            "El precio fijado se usará en los pagos de las Clases Sueltas."

            Case "DESCUENTO POR EDAD"
                'COMPROBAR EL VALOR DEL CUADRO DE TEXTO DESCUENTO
                If TxtDscnto.Text = "0 €" Then MsgBox("Corrige el DESCUENTO.", vbCritical, "Descuento por edad") : TxtDscnto.Focus() : Exit Sub

                'COMPROBAR EL VALOR DE LA EDAD MINIMA
                If NudEdadMin.Value <= 3 Then MsgBox("Verifica la edad MINIMA para el descuento.", vbCritical, "Descuento por edad") : NudEdadMin.Focus() : Exit Sub

                'COMPROBAR EL VALOR DE LA EDAD MAXIMA
                If NudEdadMax.Value <= NudEdadMin.Value Then MsgBox("Verifica la edad MAXIMA para el descuento.", vbCritical, "Descuento por edad") : NudEdadMax.Focus() : Exit Sub

                'SI TODO ESTÁ CORRECTO SE ENVÍA MENSAJE DE CONFIRMACIÓN
                strMsgBox = "Se ha guardado la tarifa correctamente." & Chr(13) & Chr(13) &
                            "El intervalo de edad es de " & NudEdadMin.Value & " a " & NudEdadMax.Value & " años."

            Case "GRUPO FAMILIAR"
                'COMPROBAR SI EL NUMERO DE INTEGRANTES DEL GRUPO ES MAYOR A 3
                If NudNumPerson.Value < 3 Then MsgBox("Para crear una tarifa grupal debe de haber mínimo 3 personas", vbCritical, "Grupo familiar") : NudNumPerson.Focus() : Exit Sub

                'COMPROBAR EL VALOR DEL CUADRO DE TEXTO DESCUENTO
                If TxtDscnto.Text = "" Then MsgBox("Ingresa el DESCUENTO.", vbCritical, "Grupo familiar") : TxtDscnto.Focus() : Exit Sub
                If TxtDscnto.Text = "0 €" Then MsgBox("Corrige el DESCUENTO.", vbCritical, "Grupo familiar") : TxtDscnto.Focus() : Exit Sub

                'SI TODO ESTÁ CORRECTO SE ENVÍA MENSAJE DE CONFIRMACIÓN
                strMsgBox = "El precio de la tarifa familiar es de " & TxtApagar.Text & Chr(13) & Chr(13) &
                            "El descuento aplicado para " & NudNumPerson.Value & " personas es de " & TxtDscnto.Text & Chr(13) & Chr(13) &
                            "Se ha guardado la tarifa correctamente."

            Case "MENSUALIDAD + IMPLEMENTOS"
                'COMPROBAR QUE LA TARIFA SEA MAYOR AL PRECIO MENSUAL.
                If TxtPrecio.Text = "0 €" Then MsgBox("Corrige el PRECIO del bono.", vbCritical, "Mensualidad con implementos") : TxtPrecio.Focus() : Exit Sub

                'SI TODO ESTÁ CORRECTO SE ENVÍA MENSAJE DE CONFIRMACIÓN
                strMsgBox = "El precio del bono se ha establecido en " & TxtPrecio.Text & Chr(13) & Chr(13) &
                            "El bono incluye la mensualidad mas implementos."

            Case Else
                If DgvTabla.RowCount = 0 Then
                    'COMPROBAR SI HAY PRECIO
                    If TxtPrecio.Text = "0 €" Then MsgBox("Corrige el PRECIO del pago mensual.", vbCritical, "Fijar precio") : TxtPrecio.Focus() : Exit Sub
                    strMsgBox = "La TARIFA fijada es de " & TxtPrecio.Text & " mensuales." & Chr(13) & Chr(13) &
                                "El precio se usará en todos los pagos de los clientes."
                Else
                    MsgBox("No se puede guardar ninguna tarifa" & Chr(13) & Chr(13) &
                           "Selecciona un Tipo de Pago de la lista.", vbCritical, "Tabla de precios y descuentos")
                    Exit Sub
                End If
        End Select

        'BUSCAMOS EN EL DATAGRIDVIEW EL NOMBRE DE LA NUEVA TARIFA PARA EVITAR DUPLICIDAD
        Try
            For Each DgvFila As DataGridViewRow In DgvTabla.Rows
                If DgvFila.Cells("ColTipoPago").Value.ToString = LblNomPago.Text Then

                    DgvTabla.CurrentCell = DgvFila.Cells("ColTipoPago")
                    DgvFila.Selected = True
                    MsgBox("No se puede GUARDAR la nueva tarifa." & vbCr & vbCr &
                           "Ya existe un registro con este nombre : " & LblNomPago.Text & vbCr & vbCr &
                           "Puedes ELIMINAR o MODIFICAR los datos del registro.",
                           vbCritical, "Error de registro")
                    TxtPrecio.Focus()
                    TxtDscnto.Focus()
                    NudNumPerson.Focus()
                    NudEdadMin.Focus()
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'HACER CONSULTA A LA BBDD Y PASAR A LA FUNCION Consultas
        sqlConsulta = "INSERT INTO trfa_dscto (tipo_trfa, prcio_trfa, emin_trfa, emax_trfa, nperson_trfa, dscto_trfa) VALUES 
                        ('" & LblNomPago.Text & "', '" & Replace(precio, ",", ".") & "', '" & NudEdadMin.Value & "',
                        '" & NudEdadMax.Value & "', '" & NudNumPerson.Value & "', '" & TxtDscnto.Text & "')"

        Consultas(sqlConsulta)

        LlenarDgvTarifas() 'LLENAR GRILLA CON LAS TARIFAS

        'BUSCAMOS LA NUEVA TARIFA PARA SELECCIONAR EL REGISTRO
        For Each DgvFila As DataGridViewRow In DgvTabla.Rows
            If DgvFila.Cells("ColTipoPago").Value.ToString = LblNomPago.Text Then
                DgvTabla.CurrentCell = DgvFila.Cells("ColTipoPago")
                DgvFila.Selected = True
            End If
        Next

        BtnGuarActuCancElim() 'LLAMAR FUNCION ACTIVAR/DESACTIVAR BOTONES

        CmbTipoPago.Text = "" 'LIMPIA EL COMBOBOX Y LOS CUADROS DE TEXTO

        DesactivarCuadros() 'DESACTIVA LOS CUADROS DE TEXTO

        MsgBox(strMsgBox, vbInformation, "Tabla de precios y descuentos") 'MENSAJE DE INFORMACIÓN

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        'LIMPIAMOS LA VARIABLE, PARA USARLO COMO CONDICIONAL PARA REALIZAR LA CONSULTA A LA BBDD
        strBandera = ""

        'DIVIDIMOS EL TEXTO EN UN ARREGLO DE CADENAS
        Dim strTpago() As String = LblNomPago.Text.Split(" ")

        If strTpago(0) = "DIARIO" Then 'CLASES SUELTAS

            'COMPROBAR EL VALOR DEL CUADRO DE TEXTO PRECIO
            If TxtPrecio.Text = "0 €" Then MsgBox("Corrige el PRECIO de la clase suelta.", vbCritical, "Actualizar clase suelta") : TxtPrecio.Focus() : Exit Sub

        ElseIf strTpago(0) = "DSCTO" Then 'DESCUENTO POR EDAD

            'COMPROBAR EL VALOR DEL CUADRO DE TEXTO DESCUENTO
            If TxtDscnto.Text = "0 €" Then MsgBox("Corrige el valor del DESCUENTO.", vbCritical, "Actualizar descuento por edad") : TxtDscnto.Focus() : Exit Sub

            'COMPROBAR EL VALOR DE LA EDAD MINIMA Y LA EDAD MAXIMA
            If NudEdadMin.Value <= 3 Then MsgBox("Verifica la edad MINIMA para el descuento.", vbCritical, "Actualizar descuento por edad") : NudEdadMin.Focus() : Exit Sub
            If NudEdadMax.Value <= NudEdadMin.Value Then MsgBox("Verifica la edad MAXIMA para el descuento.", vbCritical, "Actualizar descuento por edad") : NudEdadMax.Focus() : Exit Sub

        ElseIf strTpago(0) = "GRUPO" Then 'GRUPO FAMILIAR

            'COMPROBAR SI EL NUMERO DE INTEGRANTES DEL GRUPO ES MAYOR A 3
            If NudNumPerson.Value < 3 Then MsgBox("Para actualizarla tarifa grupal debe de haber mínimo 3 personas.", vbCritical, "Actualizar grupo familiar") : NudNumPerson.Focus() : Exit Sub

            'COMPROBAR EL VALOR DEL CUADRO DE TEXTO DESCUENTO
            If TxtDscnto.Text = "" Then MsgBox("Ingresa el DESCUENTO.", vbCritical, "Actualizar grupo familiar") : TxtDscnto.Focus() : Exit Sub
            If TxtDscnto.Text = "0 €" Then MsgBox("Corrige el valor del DESCUENTO.", vbCritical, "Actualizar grupo familiar") : TxtDscnto.Focus() : Exit Sub

        ElseIf strTpago(0) = "MES" Then 'MENSUALIDAD + IMPLEMENTOS

            'COMPROBAR EL VALOR DEL CUADRO DE TEXTO PRECIO
            If TxtPrecio.Text = "0 €" Then MsgBox("Corrige el PRECIO del bono.", vbCritical, "Actualizar mensualidad con implementos") : TxtPrecio.Focus() : Exit Sub
        Else

            strBandera = "MENSUAL" 'LLENAMOS LA VARIABLE PARA PODER HACER LA CONSULTA A LA BBDD

        End If

        'BUSCAMOS EN EL DATAGRIDVIEW EL NOMBRE DE LA TARIFA PARA EVITAR REGISTROS DUPLICADOS
        If strTpago(0) = "DIARIO" OrElse strTpago(0) = "MES" OrElse (strTpago(0) = "GRUPO" And NudNumPerson.Value <> nudMax) OrElse
            (strTpago(0) = "DSCTO" And (NudEdadMin.Value <> nudMin Or NudEdadMax.Value <> nudMax)) Then
            Try
                For Each DgvFila As DataGridViewRow In DgvTabla.Rows
                    If DgvFila.Cells("ColTipoPago").Value.ToString = LblNomPago.Text Then

                        DgvTabla.CurrentCell = DgvFila.Cells("ColTipoPago")
                        DgvFila.Selected = True
                        MsgBox("No se puede ACTUALIZAR los datos de la tarifa." & vbCr & vbCr &
                               "Ya existe un registro con este nombre : " & LblNomPago.Text & vbCr & vbCr &
                               "Puedes ELIMINAR el registro.",
                               vbCritical, "Error de registro")
                        TxtPrecio.Focus()
                        TxtDscnto.Focus()
                        NudNumPerson.Focus()
                        NudEdadMin.Focus()
                        Exit Sub
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End If

        'LLENAMOS LAS VARIABLES CON LOS VALORES DE LOS TEXTBOX
        precio = TxtPrecio.Text.Substring(0, Len(TxtPrecio.Text) - 2)
        dscnto = TxtDscnto.Text.Substring(0, Len(TxtDscnto.Text) - 2)

        'COMPROBAMOS SI EL REGISTRO QUE SE VA ACTUALIZAR ES LA TARIFA FIJA PARA HACER LA CONSULTA CORRESPONDIENTE
        If strBandera = "MENSUAL" Then

            sqlConsulta = "UPDATE trfa_dscto SET prcio_trfa='" & precio & "' WHERE prcio_trfa='" & fijoMes & "'"

        Else

            sqlConsulta = "UPDATE trfa_dscto SET tipo_trfa='" & LblNomPago.Text & "', prcio_trfa='" & Replace(precio, ",", ".") & "',
                        emin_trfa='" & NudEdadMin.Value & "', emax_trfa='" & NudEdadMax.Value & "', nperson_trfa='" & NudNumPerson.Value & "',
                        dscto_trfa='" & Replace(dscnto, ",", ".") & "' WHERE id_trfa='" & idTarifa & "'"
        End If

        Consultas(sqlConsulta) 'LLAMAMOS A LA FUNCION Y LE PASAMOS LA CONSULTA

        LlenarDgvTarifas() 'LLENAR GRILLA CON LAS TARIFAS

        'BUSCAMOS LA NUEVA TARIFA PARA SELECCIONAR EL REGISTRO
        For Each DgvFila As DataGridViewRow In DgvTabla.Rows
            If DgvFila.Cells("ColTipoPago").Value.ToString = LblNomPago.Text Then
                DgvTabla.CurrentCell = DgvFila.Cells("ColTipoPago")
                DgvFila.Selected = True
            End If
        Next

        BtnGuarActuCancElim() 'LLAMAR FUNCION ACTIVAR/DESACTIVAR BOTONES

        LimpiarCuadros() 'LIMPIA LOS CUADROS DE TEXTO

        LimpiarVariables() 'LIMPIA LAS VARIABLES

        DesactivarCuadros() 'DESACTIVA LOS CUADROS DE TEXTO

        MsgBox("Se ha modificado y ACTUALIZADO la tarifa correctamente.", vbInformation, "Actualizando") 'MENSAJE DE INFORMACIÓN

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        BtnGuarActuCancElim() 'ACTIVAR/DESACTIVAR BOTONES

        DesactivarCuadros() 'DESACTIVA LOS CUADROS DE TEXTO

        CmbTipoPago.Text = "" 'If strBandera = "BTNNUEVO" Then CmbTipoPago.Text = "" 'LIMPIA EL COMBOBOX

        LimpiarCuadros() 'LIMPIA LOS CUADROS DE TEXTO

        LimpiarVariables() 'LIMPIA LAS VARIABLES

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click

        Close() 'CIERRA EL FORMULARIO
    End Sub

    Private Sub DgvTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTabla.CellContentClick
    End Sub
    Private Sub DgvTabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTabla.CellClick

        'LLENAMOS LA VARIABLE PARA EVITAR QUE LOS TEXTBOX HAGAN LOS CÁLCULOS
        strBandera = "SELECT REG"

        'LLENAR INFORMACION
        idTarifa = DgvTabla.CurrentRow.Cells(0).Value 'LLENAR VARIABLE CON ID TARIFA
        LblNomPago.Text = DgvTabla.CurrentRow.Cells(1).Value 'NOMBRE PAGO
        TxtPrecio.Text = DgvTabla.CurrentRow.Cells(2).Value 'PRECIO
        NudEdadMin.Value = DgvTabla.CurrentRow.Cells(3).Value 'EDAD MINIMA
        NudEdadMax.Value = DgvTabla.CurrentRow.Cells(4).Value 'EDAD MAXIMA
        NudNumPerson.Value = DgvTabla.CurrentRow.Cells(5).Value 'Nº DE PERSONAS
        TxtTotal.Text = DgvTabla.CurrentRow.Cells(6).Value 'TOTAL
        TxtDscnto.Text = DgvTabla.CurrentRow.Cells(7).Value 'DESCUENTO
        TxtApagar.Text = DgvTabla.CurrentRow.Cells(8).Value 'APAGAR

    End Sub

    '----->>>>> PROCEDIMIENTOS <<<<<-----'
    Sub BtnNuevoModificar()

        BtnNuevo.Visible = False
        BtnModificar.Visible = False
        BtnEliminar.Visible = False
        BtnGuardar.Visible = True
        BtnCancelar.Visible = True
        CmbTipoPago.Enabled = True
        DgvTabla.Enabled = False

    End Sub

    Sub BtnGuarActuCancElim()

        CmbTipoPago.Enabled = False
        BtnNuevo.Visible = True
        BtnModificar.Visible = True
        BtnEliminar.Visible = True
        BtnGuardar.Visible = False
        BtnActualizar.Visible = False
        BtnCancelar.Visible = False
        DgvTabla.Enabled = True

        If DgvTabla.RowCount = 0 Then
            BtnModificar.Visible = False
            BtnEliminar.Visible = False
            DgvTabla.Enabled = False
        End If

        BtnNuevo.Focus() 'ENVIAMOS EL ENFOQUE AL BOTON

    End Sub

    Sub LimpiarCuadros()

        NudNumPerson.Value = 0
        NudEdadMin.Value = 0
        NudEdadMax.Value = 0
        TxtPrecio.Clear()
        TxtTotal.Clear()
        TxtDscnto.Clear()
        TxtApagar.Clear()
        LblNomPago.Text = ""

    End Sub

    Sub LimpiarVariables()

        strBandera = ""
        idTarifa = 0
        dscnto = 0
        nudMin = 0
        nudMax = 0

    End Sub

    Sub DesactivarCuadros()

        TxtPrecio.Enabled = False
        TxtTotal.Enabled = False
        TxtDscnto.Enabled = False
        TxtApagar.Enabled = False
        NudNumPerson.Enabled = False
        NudEdadMin.Enabled = False
        NudEdadMax.Enabled = False

    End Sub

    Sub LlenarDgvTarifas()

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            sqlConsulta = "SELECT * FROM trfa_dscto ORDER BY tipo_trfa"
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            DgvTabla.Rows.Clear()

            If drDataReader.HasRows Then
                While drDataReader.Read()
                    nRow = DgvTabla.Rows.Add()
                    DgvTabla.Rows(nRow).Cells(0).Value = drDataReader.GetInt16(0).ToString 'ID TARIFA
                    DgvTabla.Rows(nRow).Cells(1).Value = drDataReader.GetString(1).ToString 'TIPO DE PRECIO
                    DgvTabla.Rows(nRow).Cells(2).Value = FormatCurrency(drDataReader.GetDecimal(2).ToString) 'PRECIO
                    DgvTabla.Rows(nRow).Cells(3).Value = drDataReader.GetInt16(3).ToString 'EDAD MINIMA
                    DgvTabla.Rows(nRow).Cells(4).Value = drDataReader.GetInt16(4).ToString 'EDAD MAXIMA
                    DgvTabla.Rows(nRow).Cells(5).Value = drDataReader.GetInt16(5).ToString 'INTEGRANTES
                    Dim total = drDataReader.GetDecimal(2).ToString * drDataReader.GetInt16(5).ToString 'CALCULAR TOTAL
                    DgvTabla.Rows(nRow).Cells(6).Value = FormatCurrency(total) 'TOTAL
                    DgvTabla.Rows(nRow).Cells(7).Value = FormatCurrency(drDataReader.GetDecimal(6).ToString) 'DESCUENTO
                    Dim aPagar = total - drDataReader.GetDecimal(6).ToString 'CALCULAR A PAGAR
                    DgvTabla.Rows(nRow).Cells(8).Value = FormatCurrency(aPagar) 'A PAGAR

                    If drDataReader.GetInt16(0).ToString = 1 Then fijoMes = drDataReader.GetDecimal(2).ToString 'CAPTURANDO EL PRECIO FIJO MES
                End While
            End If

            drDataReader.Close()
            cnxnMySql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub Consultas(ByVal sqlConsulta As String)

        Try
            cnxnMySql.ConnectionString = "server=localhost; user=root; password=MS-x51179m; database=control_pagos"
            cnxnMySql.Open()
            cmdCommand = New MySqlCommand(sqlConsulta, cnxnMySql)
            drDataReader = cmdCommand.ExecuteReader()
            drDataReader.Close()
            cnxnMySql.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub SoloNumeros(ByVal Numero As String, e As KeyPressEventArgs)

        'SI LA TECLA ES DIGIT O CONTROL SE BLOQUEA
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then e.Handled = False : Exit Sub

        'SI YA CONTIENE UNA COMA SE BLOQUEA
        If e.KeyChar = "." AndAlso Not Numero.Contains(",") Then e.Handled = False : Exit Sub

        'SI CUMPLE CON LOS REQUISITOS DESBLOQUEA
        e.Handled = True

    End Sub

    Sub EnteroDecimal(ByVal TxtIntDec As TextBox, ByRef intdec As Decimal)

        Try
            'REEMPLAZAR EL PUNTO POR LA COMA
            TxtIntDec.Text = Replace(TxtIntDec.Text, ".", ",")

            'COMPROBAR EL LARGO DEL TEXTBOX
            If Len(TxtIntDec.Text) = 1 Then TxtIntDec.Text = TxtIntDec.Text & " €" : TxtIntDec.SelectionStart = 1
            If Len(TxtIntDec.Text) = 2 Then TxtIntDec.Clear()
            If Len(TxtIntDec.Text) >= 3 Then
                Dim largo = TxtIntDec.Text.Substring(0, Len(TxtIntDec.Text) - 2)
                TxtIntDec.Text = largo & " €"
                TxtIntDec.SelectionStart = Len(largo)
                If Len(largo) >= 1 Then intdec = largo
            End If

        Catch ex As Exception
            ' SI SE PRODUCE ALGÚN ERROR LO CAPTURAMOS Y LIMPIAMOS EL TEXTBOX
            TxtIntDec.Text = ""
        End Try

    End Sub

    Sub FuenteErrorOk(ByVal TxtFuente As TextBox, ByRef valor As Decimal, ByRef minimo As Decimal, ByRef maximo As Decimal)

        'COMPROBAR SI EL TEXTBOX CONTIENE LA COMA
        If TxtFuente.Text.Contains(",") Then
            Dim intDec() As String = TxtFuente.Text.Split(",")

            If (intDec(1).Length = 2 Or intDec(1).Length > 4) Or (valor < minimo Or valor > maximo) Then
                TxtFuente.ForeColor = Color.Red
                TxtFuente.Font = New System.Drawing.Font(TxtFuente.Font, FontStyle.Bold)
                BtnGuardar.Enabled = False
                BtnActualizar.Enabled = False
            Else
                TxtFuente.ForeColor = Color.Green
                TxtFuente.Font = New System.Drawing.Font(TxtFuente.Font, TxtFuente.Font.Style And Not FontStyle.Bold)
                BtnGuardar.Enabled = True
                BtnActualizar.Enabled = True
            End If

        ElseIf (valor < minimo Or valor > maximo) Then
            TxtFuente.ForeColor = Color.Red
            TxtFuente.Font = New System.Drawing.Font(TxtFuente.Font, FontStyle.Bold)
            BtnGuardar.Enabled = False
            BtnActualizar.Enabled = False
        Else
            TxtFuente.ForeColor = Color.Green
            TxtFuente.Font = New System.Drawing.Font(TxtFuente.Font, TxtFuente.Font.Style And Not FontStyle.Bold)
            BtnGuardar.Enabled = True
            BtnActualizar.Enabled = True
        End If

    End Sub

End Class