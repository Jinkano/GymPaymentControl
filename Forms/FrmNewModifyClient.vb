
Public Class FrmNewModifyClient

    Dim currentMonth, currentYear As Int16
    Dim sqlConsulta, strEstado, strMtdPgs, strIdGrupo, strToolTipText As String

    Public blnMarker As Boolean
    Public intAddMember As Int16
    Public precio, dscnto As Decimal
    Public strIdClient, strAddMembers As String

    Private Sub FrmNewModifyClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '|--------------------------------------------------------------------------------------
        '| LLENAR VALORES A LAS VARIABLE O A LOS DATETIMEPICKERS
        '|------------------------------------------------------
        '| * Almacenamos en mes actual en la variable 'currentMonth' para hacer consulta a la
        '|   base de batos, comprobar si hay pago pendiente de un grupo familiar.
        '| * Almacenamos el año actual en la variable 'currentYear' para asignar valores mínimos y
        '|   máximos a los DateTimePicker DtpFdn y DtpFdi.
        '|
        '| * Asignamos la fecha mínima y máxima al DtpFdn.
        '|
        '| IF : Si el botón BtnGuardar está activado.
        '|      * Limpiamos el DtpFdn y le damos una nueva fecha con 25 años menos.
        '|      * Limpiamos el TxtEdad.
        '|      * Restamos y sumamos en 1 la variable currentYear que tiene el año actual para el
        '|        valor mínimo y máximo del DtpFdi.
        '|
        '| ELSE : Si el botón BtnActualizar está activado
        '|      * Le pasamos al DtpFdn el formato personalizado de la fecha.

        currentMonth = Month(Date.Now) 'DateTime.Now.Month
        currentYear = Year(Date.Now) 'DateTime.Now.Year

        DtpFdn.MinDate = "01/01/" & currentYear - 90
        DtpFdn.MaxDate = DateTime.Now

        If BtnGuardar.Visible = True Then

            DtpFdn.CustomFormat = " "
            DtpFdn.Value = "01/07/" & currentYear - 25

            TxtEdad.Text = ""

            DtpFdi.MinDate = "01/01/" & currentYear - 2
            DtpFdi.MaxDate = "31/12/" & currentYear + 2
        Else
            DtpFdn.CustomFormat = "' ' dd ' de  ' MMMM ' de  ' yyyy"
        End If

    End Sub
    Private Sub FrmNewModifyClient_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate

        '| ---------------------------------------------------------------------------------------------
        '| CERRAMOS LA VENTANA AL DESACTIVAR EL FORMULARIO 
        '| ------------------------------------------------
        '| * Si se desactiva el Form o se hace clic fuera del Form cerramos el FrmNuevoEditarCliente
        '|   para evitar hacer otras acciones con el form ejecutado (no visible).
        Close()

    End Sub
    '
    '
    '   
    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
    End Sub
    Private Sub TxtNombre_GotFocus(sender As Object, e As EventArgs) Handles TxtNombre.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtNombre.BackColor = Color.Beige

    End Sub
    Private Sub TxtNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtNombre.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la subrutina Sub_TxtLost_Focus() y le pasamos como parámetro el TextBox
        Sub_TxtLost_Focus(TxtNombre)

    End Sub
    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress

        '| -----------------------------------------------------------------------------------
        '| VALIDAR EL INGRESO DE LETRAS Y ESPACIO
        '| ---------------------------------------
        '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
        '| * Almacenamos en la variable strLockKey los caracteres que queremos EXCLUIR.
        '| * Llamamos a la subrutina Fun_Only_Letters y le pasamos las variables como parámetro.

        Dim strAllowKey As String = " "
        Dim strLockKey As String = "ºª"
        Sub_Only_Letters(strAllowKey, strLockKey, e)

    End Sub
    '
    '
    '
    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
    End Sub
    Private Sub TxtApellido_GotFocus(sender As Object, e As EventArgs) Handles TxtApellido.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtApellido.BackColor = Color.Beige

    End Sub
    Private Sub TxtApellido_LostFocus(sender As Object, e As EventArgs) Handles TxtApellido.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la subrutina Sub_TxtLost_Focus() y le pasamos como parámetro el TextBox
        Sub_TxtLost_Focus(TxtApellido)

    End Sub
    Private Sub TxtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellido.KeyPress

        '| -----------------------------------------------------------------------------------
        '| VALIDAR EL INGRESO DE LETRAS Y ESPACIO
        '| ---------------------------------------
        '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
        '| * Almacenamos en la variable strLockKey los caracteres que queremos EXCLUIR.
        '| * Llamamos a la subrutina Fun_Only_Letters y le pasamos las variables como parámetro.

        Dim strAllowKey As String = " "
        Dim strLockKey As String = "ºª"
        Sub_Only_Letters(strAllowKey, strLockKey, e)

    End Sub
    '
    '
    '
    Private Sub DtpFdn_ValueChanged(sender As Object, e As EventArgs) Handles DtpFdn.ValueChanged

        '| ---------------------------------------------------------------------------------------
        '| CALCULAR LA EDAD DEL CLIENTE
        '| ----------------------------
        '| * Almacenamos en la variable dtDateOfBirth la fecha de nacimiento que se obtiene del DtpFdn
        '| * Para calcular los años llamamos a la función Fun_Calculate_Age() y le pasamos la variable _
        '|   _ dtDateOfBirth, está función nos devuelve un valor entero que lo mostramos en el label TxtEdad.  

        Dim dtDateOfBirth As Date = DtpFdn.Value
        TxtEdad.Text = Fun_Calculate_Age(dtDateOfBirth) & " años"

    End Sub
    Private Sub DtpFdn_GotFocus(sender As Object, e As EventArgs) Handles DtpFdn.GotFocus

        '| -------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR Y DAR FORMATO AL DATETIMEPICKER
        '| ------------------------------------------------
        '| * Al recibir el emfoque cambiammos el color del fondo del Textbox y le damos _
        '|   _ formato al DtpFdn con una fecha personalizada.

        TxtEdad.BackColor = Color.Beige
        DtpFdn.CustomFormat = "' ' dd ' de  ' MMMM ' de  ' yyyy"

    End Sub
    Private Sub DtpFdn_LostFocus(sender As Object, e As EventArgs) Handles DtpFdn.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la subrutina Sub_TxtLost_Focus() y le pasamos como el Label (TxtEdad)
        Sub_TxtLost_Focus(TxtEdad)

    End Sub
    '
    '
    '
    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
    End Sub
    Private Sub TxtTelefono_GotFocus(sender As Object, e As EventArgs) Handles TxtTelefono.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtTelefono.BackColor = Color.Beige

    End Sub
    Private Sub TxtTelefono_LostFocus(sender As Object, e As EventArgs) Handles TxtTelefono.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la subrutina Sub_TxtLost_Focus() y le pasamos como parámetro el TextBox
        Sub_TxtLost_Focus(TxtTelefono)

    End Sub
    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress

        '| -----------------------------------------------------------------------------------
        '| VALIDAR EL INGRESO DE NÚMEROS, PARÉNTESIS, GUION Y ESPACIO
        '| ----------------------------------------------------------
        '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
        '| * Llamamos a la subrutina Sub_Only_Numbers y le pasamos la variable como parámetro.

        Dim strAllowKey As String = "(-) "
        Sub_Only_Numbers(strAllowKey, e)

    End Sub
    '
    '
    '
    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged
    End Sub
    Private Sub TxtEmail_GotFocus(sender As Object, e As EventArgs) Handles TxtEmail.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtEmail.BackColor = Color.Beige

    End Sub
    Private Sub TxtEmail_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtEmail.KeyUp

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL SOLTAR LA TECLA PRESIONADA
        '| -------------------------------------------
        '| IF : Comrpobamos si Fun_IsValid_Email no cumple con el formato del E-Mail.
        '|      * Mostrar el error si el formato es incorrecto.
        '|      * Cambiamos el color del fondo.
        '| ELSE : 
        '|      * Limpiamos el error.
        '|      * Cambiamos el color del fondo.

        If Not Fun_IsValid_Email(TxtEmail.Text) Then
            ErrorProvider.SetError(TxtEmail, "Ingresa un formato de E-Mail válido (usuario@dominio.com)")
            TxtEmail.BackColor = Color.MistyRose
        Else
            ErrorProvider.Clear()
            TxtEmail.BackColor = Color.Beige
        End If

    End Sub
    Private Sub TxtEmail_LostFocus(sender As Object, e As EventArgs) Handles TxtEmail.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la subrutina Sub_TxtLost_Focus() y le pasamos como parámetro el TextBox
        '| IF : Comrpobamos si el TxtEmail no está vacio Y si Fun_IsValid_Email no cumple con el formato del E-Mail
        '|      * Mostrar el error si el formato es incorrecto.
        '|      * Cambiamos el color del fondo.

        Sub_TxtLost_Focus(TxtEmail)
        If Not String.IsNullOrWhiteSpace(TxtEmail.Text) And Not Fun_IsValid_Email(TxtEmail.Text) Then
            ErrorProvider.SetError(TxtEmail, "Ingresa un formato de E-Mail válido (usuario@dominio.com)")
            TxtEmail.BackColor = Color.MistyRose
        End If

    End Sub
    '
    '
    '
    Private Sub TxtDireccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDireccion.TextChanged
    End Sub
    Private Sub TxtDireccion_GotFocus(sender As Object, e As EventArgs) Handles TxtDireccion.GotFocus

        '| -----------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtDireccion.BackColor = Color.Beige

    End Sub
    Private Sub TxtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccion.KeyPress

        '| -----------------------------------------------------------------------------------
        '| VALIDAR EL INGRESO DE CARACTERES PARA LA DIRECCIÓN
        '| --------------------------------------------------
        '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
        '| * Llamamos a la subrutina Fun_Only_Letters y le pasamos las variables como parámetro.

        Dim strAllowKey As String = "(&'.-/) "
        Sub_Letters_And_Numbers(strAllowKey, e)

    End Sub
    Private Sub TxtDireccion_LostFocus(sender As Object, e As EventArgs) Handles TxtDireccion.LostFocus

        '| -----------------------------------------------------------------------------------
        '| VALAIDACIONES AL PERDER EL ENFOQUE
        '| ----------------------------------
        '| * Llamamos a la subrutina Sub_TxtLost_Focus() y le pasamos como parámetro el TextBox
        Sub_TxtLost_Focus(TxtDireccion)

    End Sub
    '
    '
    '
    Private Sub RbEstadoActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RbActiveStatus.CheckedChanged

        '| --------------------------------------------------------------------------------------------------
        '| LLENAR LA VARIABLE CON EL ESTADO DEL CLIENTE
        '| --------------------------------------------
        '| IF : Comprobamos que RadioButton está activado.
        '|      * Si RbActiveStatus está activado, la variable strEstado es igual a "ACTIVO".
        '| ELSE :
        '|      * Si RbInactiveStatus está activado, la variable strEstado es igual a "INACTIVO".
        '| ** La variable strEstado se usa para guardar o actualizar los datos del cliente.

        If RbActiveStatus.Checked Then
            strEstado = "ACTIVO"
        Else
            strEstado = "INACTIVO"
        End If

    End Sub
    '
    '
    '
    Private Sub RbDiario_CheckedChanged(sender As Object, e As EventArgs) Handles RbDiario.CheckedChanged

        '| ----------------------------------------------------------------------------------------------
        '| HACER LA CONSULTA Y MOSTRAR DATOS EN LA LISTA
        '| ---------------------------------------------
        '| IF : Comprobamos si el RadioButton RbDiario
        '|      * Guardar en la variable strMtdPgs el valor que se encuentra en TxtListaNom, valor que se _
        '|        _ usará para guardar o actualizar el método de pago en la tabla clientes.
        '|      * Cambiamos el titulo del groupbox "Lista clases sueltas".
        '|      * Activamos el DataGridView DgvListaNombre.
        '|      * Hacemos la consulta para mostrar los pagos diarios el la lista DgvListaNombre y lo _
        '|        _ guardamos en la variable sqlConsulta.
        '|      * Llamamos a la subrutina Sub_Crud_Sql y le pasamos la variable sqlConsulta y el texto _
        '|        _ "SubSearchDailyPrice" que se usa para el select case del módulo SQLqueries.
        '|      * Llenamos la raviable 'strToolTipText' con el texto que se mostrará al pasar el cursor _
        '|        _ por el Datagridview.

        If RbDiario.Checked Then
            strMtdPgs = TxtListaNom.Text
            GbListaGrupoFamiliar.Text = "Lista clases sueltas"
            DgvListaNombre.Enabled = True
            sqlConsulta = "SELECT id_trfa, tipo_trfa FROM trfa_dscto WHERE tipo_trfa LIKE '%DIARIO%'"
            Sub_Crud_Sql(sqlConsulta, "SubSearchDailyPrice")
            strToolTipText = "CLIC PARA SELECCIONAR UN PAGO DIARIO"
        End If

    End Sub
    Private Sub RbDiario_Click(sender As Object, e As EventArgs) Handles RbDiario.Click

        '| ---------------------------------------------------------------------------------
        '| LIMPIAR CUADRO DE TEXTO
        '| -----------------------
        '| * Al hacer click en el RadioButton 'RbDiario' comprobamos el valor de la variable
        '|   'blnMarker', la razón de esta comprobación es porque solo se debe limpiar el
        '|   cuadro de texto si vamos a registrar un nuevo cliente ya que si estamos actualizando
        '|   los datos del cliente no podemos cambiar su método de pago si pertenece a un grupo
        '|   familiar por esa razon en el evento CheckedChanged del RbGrupoFamiliar cambiamos el
        '|   valor de la variable 'blnMarker = True' para no borrar el nombre del grupo al que
        '|   pertenece el cliente en cuestión.

        If blnMarker = False Then TxtListaNom.Text = ""

    End Sub
    '
    '
    '
    Private Sub RbMensual_CheckedChanged(sender As Object, e As EventArgs) Handles RbMensual.CheckedChanged

        '| -------------------------------------------------------------------------------------------------
        '| LLENAR VARIABLE Y LIMPIAR LISTA
        '| -------------------------------
        '| IF : Comprobamos si el RadioButton RbMensual
        '|      * Guardar en la variable strMtdPgs el valor "MENSUAL", valor que se usará para guardar o _
        '|        _ actualizar el método de pago en la tabla clientes.
        '|      * limpiamos el TxtListaNom.
        '|      * Cambiamos el titulo del groupbox "Lista vacia".
        '|      * Desactivamos el DataGridView DgvListaNombre y lo limpiamos.

        If RbMensual.Checked Then
            strMtdPgs = "MENSUAL"
            TxtListaNom.Text = ""
            GbListaGrupoFamiliar.Text = "Lista vacia"
            DgvListaNombre.Enabled = False
            DgvListaNombre.Rows.Clear()
        End If
        '
    End Sub
    '
    '
    '
    Private Sub RbGrupoFamiliar_CheckedChanged(sender As Object, e As EventArgs) Handles RbGrupoFamiliar.CheckedChanged

        '| ------------------------------------------------------------------------------------------------------------
        '| HACER LA CONSULTA Y MOSTRAR LOS DATOS EN LA LISTA
        '| ---------------------------------------------
        '| IF : Comprobamos si el RadioButton 'RbGrupoFamiliar' está seleccionado; si se cumple la condición:
        '|
        '|      * Asigna a la variable strMtdPgs (Método de Pago) el valor "GRUPAL".
        '|      * Limpia el contenido del TextBox 'TxtListaNom'.
        '|      * Limpia el texto de la Label que muestra el número de integrantes.
        '|      * Establece un nuevo título para el GroupBox 'Lista de grupos familiares'.
        '|      * Habilitamos los controles BtnAddGrupo, TxtListaNom y DgvListaNombre para la gestión de los grupos.
        '|      * Enviamos el enfoque al Textbox TxtListaNom.
        '|      * Hacemos la consulta SQL para obtener todos los datos de la tabla 'grp_familiar' y lo guardammos en la
        '|        variable sqlConsulta.
        '|      * Llamamos a la subrutina Sub_Crud_Sql para ejecutar la consulta SQL y le pasamos como parametro la
        '|        variable 'sqlConsulta' y el texto 'SubFillFamilyGroupData' que se usa en el Select Case del módulo SQLqueries.
        '|      * Si la variable 'blnMarker' es igual a True, llenamos el 'TxtListaNom' con el nombre del grupo familiar que
        '|        tenemos almacenada en la variable 'strToolTipText'.
        '|      * Llenamos la raviable 'strToolTipText' con el texto que se mostrará al pasar el cursor por el Datagridview.
        '|
        '| ELSE : Si el RadioButton es deseleccionado:
        '|
        '|      IF : Comprobamos si el button 'BtnActualizar' es visible:
        '|          
        '|          * Mostramos un mensaje para avisar que no se puede cambiar el método de pago.
        '|          * Para no crear otra variable reutilizamos 'strToolTipText', guardamos el nombre del grupo familiar que
        '|            usaremos cuando se vuelva a seleccionar el RadioButton.
        '|          * Ponemos la variable 'blnMarker' a True para volver a llenar el textbox con el nombre del grupo que está
        '|            guardado en la variable 'strToolTipText'.
        '|          * Volvemos a seleccionar el 'RbGrupoFamiliar'
        '|
        '|      ELSE : Si el boton 'BtnGuradr' está visible:
        '|      
        '|          * Deshabilitamos los controles BtnAddGrupo y TxtListaNom.
        '|          * Limpia la Label del número de integrantes.

        If RbGrupoFamiliar.Checked Then

            strMtdPgs = "GRUPAL"
            TxtListaNom.Text = ""
            LblNumIntgrntes.Text = ""
            GbListaGrupoFamiliar.Text = "Lista de grupos familiares"
            BtnAddGrupo.Enabled = True
            TxtListaNom.Enabled = True
            DgvListaNombre.Enabled = True
            TxtListaNom.Focus()
            sqlConsulta = "SELECT * FROM grp_familiar ORDER BY id_grp DESC"
            Sub_Crud_Sql(sqlConsulta, "SubFillFamilyGroupData")
            If blnMarker = True Then TxtListaNom.Text = strToolTipText
            strToolTipText = "DOBLE CLIC PARA SELECCIONAR UN GRUPO"

        Else

            If BtnActualizar.Visible = True Then
                MsgBox("   No se puede cambiar el MÉTODO de pago de un cliente que    pertenece a un grupo familiar." & vbCr & vbCr &
                       "   Si quieres cambiar tienes que eliminar el grupo FAMILIAR.", vbCritical, "Error al cambiar método de pago")
                strToolTipText = TxtListaNom.Text
                blnMarker = True
                RbGrupoFamiliar.Checked = True
            Else
                BtnAddGrupo.Enabled = False
                TxtListaNom.Enabled = False
                LblNumIntgrntes.Text = ""
            End If

        End If
    End Sub
    '
    '
    '
    Private Sub BtnAddGrupo_Click(sender As Object, e As EventArgs) Handles BtnAddGrupo.Click

        '| ----------------------------------------------------------------------------------
        '| MOSTRAR EL FORMULARIO GRUPO FAMILIAR
        '| ------------------------------------
        FrmFamilyGroup.Show()

    End Sub
    '
    '
    '
    Private Sub TxtListaNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtListaNom.TextChanged

        '| -------------------------------------------------------------------------------------------------
        '| HACER LA CONSULTA Y EVALUAR EL VALOR INTRODUCIDO EN EL TEXTBOX
        '| --------------------------------------------------------------
        '| IF : Comprobamos si el RadioButton 'RbGrupoFamiliar' está seleccionado.
        '|      * Hacemos la consulta con el texto ingresado en el TextBox 'TxtListaNom' para buscar un _
        '|        _ grupo familiar y lo guardamos en la variable 'sqlConsulta'.
        '|      * Llamamos a una subrutina genérica Sub_Crud_Sql y le pasamos como parámetro 'sqlConsulta' _
        '|        _ y el texto 'SubFillFamilyGroupData' que se usa en el Select Case del módulo SQLqueries.
        '|        _ que se usa para llenar el DataGridView DgvListaNombre.
        '|      IF : Si el TextBox de búsqueda está vacío o contiene solo espacios en blanco, limpiamos el _
        '|           _ Label que muestra el número de integrantes
        '|      IF : Comprobamos si la DataGridView (DgvListaNombre) contiene al menos una fila o registro.
        '|          IF : Comparamos si el texto actual en el TextBox 'TxtListaNom' coincide con el valor de _
        '|               _ la celda de la fila seleccionada o enfocada en la DataGridView.
        '|              * Si hay coincidencia, llenamos el Label 'LblNumIntgrntes' con el número integrantes,
        '|                aumentamos en uno [intAddMember] y llenamos strAddMembers = "UPDATE_A_FIELD".

        If RbGrupoFamiliar.Checked Then

            sqlConsulta = "SELECT * FROM grp_familiar WHERE nom_grp LIKE '" & TxtListaNom.Text & "%' ORDER BY nom_grp"
            Sub_Crud_Sql(sqlConsulta, "SubFillFamilyGroupData")

            If String.IsNullOrWhiteSpace(TxtListaNom.Text) Then LblNumIntgrntes.Text = ""

            If DgvListaNombre.RowCount > 0 Then
                If TxtListaNom.Text = DgvListaNombre.CurrentRow.Cells(1).Value Then
                    LblNumIntgrntes.Text = DgvListaNombre.CurrentRow.Cells(3).Value & " de " & DgvListaNombre.CurrentRow.Cells(2).Value
                    intAddMember = DgvListaNombre.CurrentRow.Cells(3).Value + 1
                    strAddMembers = "UPDATE_A_FIELD"
                End If
            End If
        End If

    End Sub
    Private Sub TxtListaNombre_GotFocus(sender As Object, e As EventArgs) Handles TxtListaNom.GotFocus

        '| -------------------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL RECIBIR EL ENFOQUE
        '| ------------------------------------------------
        TxtListaNom.BackColor = Color.Beige

    End Sub
    Private Sub TxtListaNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtListaNom.KeyPress

        '| ---------------------------------------------------------------------------------------------------
        '| VALIDAR EL INGRESO DE CARACTERES PARA LA DIRECCIÓN
        '| --------------------------------------------------
        '| * Almacenamos en la variable strAllowKey los caracteres que queremos PERMITIR.
        '| * Llamamos a la subrutina Fun_Only_Letters y le pasamos las variables como parámetro.

        Dim strAllowKey As String = "(-) "
        Sub_Letters_And_Numbers(strAllowKey, e)

    End Sub
    Private Sub TxtListaNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtListaNom.LostFocus

        '| ---------------------------------------------------------------------------------------------
        '| CAMBIAR EL COLOR DEL FONDO AL PERDER EL ENFOQUE
        '| ------------------------------------------------
        TxtListaNom.BackColor = Color.Azure

    End Sub
    '
    '
    '
    Private Sub DgvListaNombre_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaNombre.CellContentClick
    End Sub
    Private Sub DgvListaNombre_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListaNombre.CellClick

        '| ----------------------------------------------------------------------------------------------------------------
        '| CLIC EN UNA CELDA DE LA FILA DEL DATAGRIDVIEW
        '| ----------------------------------------------
        '| * Llenamos la variable 'strMtdPgs' con el nombre de la clase suelta para guardar o actualizar en la tabla.
        '| * Mostramos en el Textbox 'TxtListaNom' en valor de la variable 'strMtdPgs'.

        If RbDiario.Checked Then
            strMtdPgs = DgvListaNombre.CurrentRow.Cells(1).Value
            TxtListaNom.Text = strMtdPgs
        End If

    End Sub
    Private Sub DgvListaNombre_DoubleClick(sender As Object, e As EventArgs) Handles DgvListaNombre.DoubleClick

        '| ----------------------------------------------------------------------------------------------------
        '| DOBLE CLIC EN UNA CELDA DE LA FILA DEL DATAGRIDVIEW
        '| ---------------------------------------------------
        '| IF : Comprobamos si el Radiobutton 'RbGrupoFamiliar' está activado:
        '|
        '|      IF : Comprobar si la cantidad de integrantes es igual a los integrantes registrados:
        '|
        '|          IF : Mostramos un mensaje de confirmación avisando que el grupo esta lleno, preguntamos si
        '|               se quiere agregar un nuevo integrantes al grupo familiar.
        '|              * Si la respuesta es SI aumentamos el valor de la variable 'intAddMember' en uno para
        '|                comprobar si hay una tarifa y actualizar los datos del grupo.
        '|              * Hacemos la consulta para comprobamos si existe una tarifa con el número de integrantes
        '|                y lo guardamos en la variable 'sqlConsulta'.
        '|              * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos como parámetro 'sqlConsulta' y el
        '|                texto 'SubSearchGroupPrice' que se usa en el Select Case del módulo SQLqueries.
        '|              * Asignamos a la variable 'strAddMembers' el valor 'UPDATE_A_FIELD' para saber que hacer
        '|                al momento de guardar o actualizar un registro.
        '|
        '|          ELSE : Si hacemos clic en NO:
        '|              * Limpiamos el Textbox 'TxtListaNom' para no poder guardar ni actualizar sin seleccionar
        '|                un grupo familiar.
        '|
        '|      ELSE : Si la cantidad de integrantes es diferente que los integrantes registrados:
        '|          * Llenamos el Textbox 'TxtListaNom' con el nombre del grupo familiar.
        '|          * El el Label 'LblNumIntgrntes' mostramos la cantidad de integrantes registrados en el grupo.
        '|          * Aumentamos en uno el valor de la variable 'intAddMember' del registro seleccionado.
        '|          * Asignamos a la variable 'strAddMembers' el valor 'UPDATE_A_FIELD' para saber que hacer al
        '|            momento de guardar o actualizar un registro.

        If RbGrupoFamiliar.Checked Then

            If DgvListaNombre.CurrentRow.Cells(2).Value = DgvListaNombre.CurrentRow.Cells(3).Value Then

                If MsgBox("    Nombre del grupo  : " & DgvListaNombre.CurrentRow.Cells(1).Value & vbCr &
                          "    Nº de Integrante     : " & DgvListaNombre.CurrentRow.Cells(2).Value & vbCr & vbCr &
                          "    El grupo seleccionado ya tiene los integrantes completos." & vbCr &
                          "    ___________________________________________________________" & vbCr & vbCr &
                          "                        ¿Seguro que quieres añadir otro integrante?",
                          vbExclamation + vbYesNo + vbDefaultButton2, "Comprobar datos") = vbYes Then
                    intAddMember = DgvListaNombre.CurrentRow.Cells(2).Value + 1
                    sqlConsulta = "SELECT nperson_trfa FROM trfa_dscto WHERE nperson_trfa = '" & intAddMember & "'"
                    Sub_Crud_Sql(sqlConsulta, "SubSearchGroupPrice")
                    strAddMembers = "UPDATE_TWO_FIELDS"
                Else
                    TxtListaNom.Text = ""
                End If

            Else
                TxtListaNom.Text = DgvListaNombre.CurrentRow.Cells(1).Value
                LblNumIntgrntes.Text = DgvListaNombre.CurrentRow.Cells(3).Value & " de " & DgvListaNombre.CurrentRow.Cells(2).Value
                intAddMember = DgvListaNombre.CurrentRow.Cells(3).Value + 1
                strAddMembers = "UPDATE_A_FIELD"
            End If
        End If

    End Sub
    Private Sub DgvListaNombre_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvListaNombre.CellFormatting

        '| ------------------------------------------------------------------------------------------------------------------------------------
        '| MOSTRAR TOOLTIPTEXT EN EL DATAGRIDVIEW
        '| --------------------------------------
        '| IF : Comprobamos si la celda está en la Columna 1 y no es la fila de encabezado asignamos el ToolTipText directamente a la celda.

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 1 Then
            DgvListaNombre.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = strToolTipText
        End If

    End Sub
    '
    '
    '
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        '| ---------------------------------------------------------------------------------------------
        '| COMPROBAMOS SI HAY INFORMACION DEL CLIENTE ANTES DE GUARDAR
        '| -----------------------------------------------------------
        '| * Llamamos a la función FunMsgBox() y le pasamos los parámetros, según sea el caso, para _
        '|   _ verificar que toda la información del cliente sea correcta antes de guardar el registro.

        If FunMsgBox(LblNombre.Text, BtnGuardar.Text, TxtNombre) Then Exit Sub
        If FunMsgBox(LblApellido.Text, BtnGuardar.Text, TxtApellido) Then Exit Sub
        If FunMsgBox(LblFnacimiento.Text, BtnGuardar.Text, TxtEdad, DtpFdn) Then Exit Sub
        If FunMsGbox(BtnGuardar.Text, RbDiario, RbMensual, RbGrupoFamiliar) Then Exit Sub
        If FunMsgBox(RbDiario.Text, BtnGuardar.Text, TxtListaNom, RbDiario) Then Exit Sub
        If FunMsgBox(RbGrupoFamiliar.Text, BtnGuardar.Text, TxtListaNom, RbGrupoFamiliar) Then Exit Sub

        '| ----------------------------------------------------------------------------------------------
        '| GUARDAR UN NUEVO REGISTRO EN LA TABLA CLIENTES
        '| ----------------------------------------------
        '| * Comprobamos el valor de la variable strmpago para hacer la consulta a la BBDD
        '| IF :
        '|      * Si la variable strMtdPgs es igual a "GRUPAL" hacemos una consulta con el _
        '|        _ campo [id_grp] de la tabla Gruppo Familiar.
        '| ELSE :
        '|      * Si la variable strMtdPgs es "MENSUAL" o "DIARIO" hacemos la consulta sin _
        '|        _ el [id_grp] del grupo familiar.
        '| * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos la consulta [sqlConsulta].

        If strMtdPgs = "GRUPAL" Then
            sqlConsulta = "INSERT INTO clientes (nom_cli, ape_cli, fdn_cli, tlf_cli, eml_cli, dir_cli, mpg_cli, fdi_cli, std_cli, id_grp)
                                VALUES ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "',
                                '" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', '" & TxtTelefono.Text & "',
                                '" & TxtEmail.Text & "', '" & TxtDireccion.Text & "',
                                '" & strMtdPgs & "', '" & DtpFdi.Value.ToString("yyyy-MM-dd") & "',
                                '" & strEstado & "', '" & DgvListaNombre.CurrentRow.Cells(0).Value & "')"

        Else
            sqlConsulta = "INSERT INTO clientes (nom_cli, ape_cli, fdn_cli, tlf_cli, eml_cli, dir_cli, mpg_cli, fdi_cli, std_cli)
                                VALUES ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "',
                                '" & DtpFdn.Value.ToString("yyyy-MM-dd") & "', '" & TxtTelefono.Text & "',
                                '" & TxtEmail.Text & "', '" & TxtDireccion.Text & "',
                                '" & strMtdPgs & "', '" & DtpFdi.Value.ToString("yyyy-MM-dd") & "',
                                '" & strEstado & "')"
        End If
        Sub_Crud_Sql(sqlConsulta)

        '| -----------------------------------------------------------------------------------------------
        '| BUSCAR EL ÚLTIMO REGISTRO GUARDADO PARA OBTENER EL ID DEL CLIENTE
        '| -----------------------------------------------------------------
        '| * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos la consulta para obtener el [id_cli] _
        '|   _ del último registro guardado en la tabla [clientes] y lo almacenamos en la variable _
        '|   _ strIdClient que es Public.

        sqlConsulta = "SELECT id_cli FROM clientes ORDER BY id_cli DESC LIMIT 1"
        Sub_Crud_Sql(sqlConsulta, "SubReadIdClient")

        '| -----------------------------------------------------------------------------------------------
        '| CONSULTAMOS A LA BBDD LA TARIFA CORRESPONDIENTE DEL NUEVO CLIENTE O DEL GRUPO
        '| -----------------------------------------------------------------------------
        '| * Seleccionamos el CASE para la consulta según el valor de la variable [strMtdPgs].
        '| * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos por parámetro la consulta _
        '|   _ almacenada en "sqlConsulta", si en está consulta no hay resultado pasamos la variable _
        '|   _ blnMarker a False.
        '|
        '| IF : Si el valor de la variable blnMarker es False
        '|      * Hacemos una nueva consulta para buscar la tarifa única MENSUAL que nos devolverá el _
        '|        _ precio y el descuento registrado en la tabla [trfa_dscto].
        '|      * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos la consulta.

        Select Case strMtdPgs
            Case "MENSUAL"
                sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE emin_trfa <= '" & TxtEdad.Text & "' AND emax_trfa >= '" & TxtEdad.Text & "'"
            Case "GRUPAL"
                sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE nperson_trfa = '" & DgvListaNombre.CurrentRow.Cells(2).Value & "'"
            Case Else 'DIARIO (5,6,7...)
                sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE tipo_trfa = '" & strMtdPgs & "'"
        End Select
        Sub_Crud_Sql(sqlConsulta, "SubSearchDiscountPrice")

        If blnMarker = False Then
            sqlConsulta = "SELECT prcio_trfa, dscto_trfa FROM trfa_dscto WHERE tipo_trfa = 'MENSUAL'"
            Sub_Crud_Sql(sqlConsulta, "SubSearchDiscountPrice")
        End If

        '| -----------------------------------------------------------------------------------------------
        '| AGREGAMOS UN NUEVO REGISTRO EN LA TABLA PAGOS
        '| ---------------------------------------------
        '| IF : Comprobammos si se va a guardar un pago grupal.
        '|      * Hacemos la consulta para comprobar si hay un pago pendiente del grupo familiar, en el caso
        '|        que exista un registro ponemos la variable 'blnmarker' en TRUE para no duplicar ese pago al
        '|        momento de registrar un nuevo cliente.
        '|      * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos como parametro la consulta y el valor_
        '|        "CheckPaymentRegistered" para llamar a la subrutina que se encarga de la variable 'blnmarker'.
        '|
        '|      IF : Si el valor de la variable 'blnmarker' es FALSE
        '|          * Calculammos el precio grupal multiplicando el precio mensual por el número de integrantes.
        '|          * Hacemos la consulta con el código del grupo y lo almacenamos en la variable sqlConsulta.
        '|          * Llamamos al la subrutina Sub_Crud_Sql(), le pasamos como parámetro la consulta.
        '|      
        '| ELSE : Si el pago no es grupal.
        '|      * Hacemos la consulta con el código del cliente y lo almacenamos en la variable sqlConsulta.
        '|      * Llamamos al la subrutina Sub_Crud_Sql() y le pasamos la consulta.

        If strMtdPgs = "GRUPAL" Then

            sqlConsulta = "SELECT * FROM pagos WHERE id_grp = '" & DgvListaNombre.CurrentRow.Cells(0).Value & "'
                            And (MONTH(fdi_pgs) = '" & currentMonth & "' And YEAR(fdi_pgs) = '" & currentYear & "')"
            Sub_Crud_Sql(sqlConsulta, "CheckPaymentRegistered")

            If blnMarker = False Then
                precio = precio * DgvListaNombre.CurrentRow.Cells(2).Value
                sqlConsulta = "INSERT INTO pagos (fdi_pgs, mtd_pgs, prc_pgs, dsc_pgs, id_grp, id_user)
                                VALUES ('" & DateTime.Now.ToString("yyyy-MM-dd") & "',
                                        '" & strMtdPgs & "',
                                        '" & Replace(precio, ",", ".") & "',
                                        '" & Replace(dscnto, ",", ".") & "',
                                        '" & DgvListaNombre.CurrentRow.Cells(0).Value & "',
                                        '" & FrmMain.idUser & "')"
                Sub_Crud_Sql(sqlConsulta)
            End If

        Else
            sqlConsulta = "INSERT INTO pagos (fdi_pgs, mtd_pgs, prc_pgs, dsc_pgs, id_cli, id_user)
                            VALUES ('" & DateTime.Now.ToString("yyyy-MM-dd") & "',
                                    '" & strMtdPgs & "',
                                    '" & Replace(precio, ",", ".") & "',
                                    '" & Replace(dscnto, ",", ".") & "',
                                    '" & strIdClient & "',
                                    '" & FrmMain.idUser & "')"
            Sub_Crud_Sql(sqlConsulta)
        End If

        '| -----------------------------------------------------------------------------------------------
        '| ACTUALIZAR REGISTROS DE LA TABLA GRUPO_FAMILIAR
        '| -----------------------------------------------
        '| * Comprobamos el valor de la variable strAddMembers para hacer la consulta a la BBDD.
        '|
        '| CASE "UPDATE_A_FIELD" :
        '|      * En este caso solo vamos a actualizar el campo [intgrntes_reg_grp] de la tabla [grp_familiar]
        '|      * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos la consulta [sqlConsulta].
        '|
        '| CASE "UPDATE_TWO_FIELDS" :
        '|      * En este caso actualizamos los campos [num_intgrntes_grp y intgrntes_reg_grp] de la tabla [grp_familiar]
        '|      * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos la consulta [sqlConsulta].
        '|
        '| ** El motivo por el cual estamos llamando dos veces a la subrutina Sub_Crud_Sql() es para evitar guardar dos _
        '|    _ registros en la tabla "pagos" al momento de registrar un nuevo cliente. No se porqué se queda la _
        '|    _ consulta después de cerra el DataReader y la BBDD.

        Select Case strAddMembers
            Case "UPDATE_A_FIELD"
                sqlConsulta = "UPDATE grp_familiar SET
                                    intgrntes_reg_grp = '" & intAddMember & "'
                                    WHERE id_grp = '" & DgvListaNombre.CurrentRow.Cells(0).Value & "'"
                Sub_Crud_Sql(sqlConsulta)

            Case "UPDATE_TWO_FIELDS"
                sqlConsulta = "UPDATE grp_familiar SET
                                    num_intgrntes_grp = '" & intAddMember & "',
                                    intgrntes_reg_grp = '" & intAddMember & "'
                                    WHERE id_grp = '" & DgvListaNombre.CurrentRow.Cells(0).Value & "'"
                Sub_Crud_Sql(sqlConsulta)
        End Select

        '| -------------------------------------------------------------------------------------------------------------
        '| * Llenamos la variable strFlag con el valor 'UPDATE_PAYMENT_LIST' para indicar al formulario FrmClientesPagos
        '|   que actualice la lista de pagos al momento de activarse
        '| * Activamos los botones del formulario FrmClientesPagos llamando a la subrutina Sub_Activate_Buttons() de
        '|   dicho formulario.
        '| * Llamamos a la subrutina FillLabelsMessage() para mostrar los datos en el formulario FrmNuevoEditarCliente y
        '|   mostrar el mensaje de confirmación.

        FrmClientsPayments.strFlags = "UPDATE_PAYMENT_LIST"
        FrmClientsPayments.strIdGrpFamily = DgvListaNombre.CurrentRow.Cells(0).Value
        FrmClientsPayments.Sub_Activate_Buttons()
        FillLabelsMessage()

    End Sub
    '
    '
    '
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        '| -----------------------------------------------------------------------------------------------
        '| COMPROBAMOS SI HAY INFORMACION DEL CLIENTE ANTES DE ACTUALIZAR
        '| --------------------------------------------------------------
        '| * Llamamos a la función FunMsgBox() y le pasamos los parámetros, según sea el caso, para _
        '|   _ verificar que toda la información del cliente sea correcta antes de actualizar el registro.

        If FunMsgBox(LblNombre.Text, BtnActualizar.Text, TxtNombre) Then Exit Sub
        If FunMsgBox(LblApellido.Text, BtnActualizar.Text, TxtApellido) Then Exit Sub
        If FunMsgBox(LblFnacimiento.Text, BtnActualizar.Text, TxtEdad, DtpFdn) Then Exit Sub
        If FunMsGbox(BtnActualizar.Text, RbDiario, RbMensual, RbGrupoFamiliar) Then Exit Sub
        If FunMsgBox(RbDiario.Text, BtnActualizar.Text, TxtListaNom, RbDiario) Then Exit Sub
        If FunMsgBox(RbGrupoFamiliar.Text, BtnActualizar.Text, TxtListaNom, RbGrupoFamiliar) Then Exit Sub

        '| -----------------------------------------------------------------------------------------------
        '| ACTUALIZAR EL REGISTRO EN LA TABLA CLIENTES
        '| -------------------------------------------
        '| * Comprobamos el valor de la variable 'strmpago' para hacer la consulta a la BBDD.
        '|
        '| IF :
        '|      * Si la variable 'strMtdPgs' es igual a "GRUPAL" hacemos una consulta con el campo [id_grp]
        '|        de la tabla Gruppo Familiar.
        '|
        '| ELSE :
        '|      * Si la variable strMtdPgs es "MENSUAL" o "DIARIO" hacemos la consulta sin el [id_grp] del
        '|        grupo familiar.
        '|
        '| * Llamamos a la subrutina Sub_Crud_Sql() y le pasamos la consulta [sqlConsulta].
        '|
        '| * Llamamos a la subrutina FillLabelsMessage() para mostrar los datos en el formulario FrmNuevoEditarCliente,
        '|   y mostrar el mensaje de confirmación.

        If strMtdPgs = "GRUPAL" Then

            sqlConsulta = "UPDATE clientes SET
                        nom_cli='" & TxtNombre.Text & "',
                        ape_cli='" & TxtApellido.Text & "',
                        fdn_cli='" & DtpFdn.Value.ToString("yyyy-MM-dd") & "',
                        tlf_cli='" & TxtTelefono.Text & "',
                        eml_cli='" & TxtEmail.Text & "',
                        dir_cli='" & TxtDireccion.Text & "',
                        mpg_cli='" & strMtdPgs & "',
                        fdi_cli='" & DtpFdi.Value.ToString("yyyy-MM-dd") & "',
                        std_cli='" & strEstado & "',
                        id_grp='" & DgvListaNombre.CurrentRow.Cells(0).Value & "'
                        WHERE id_cli='" & strIdClient & "'"
        Else

            sqlConsulta = "UPDATE clientes SET
                        nom_cli='" & TxtNombre.Text & "',
                        ape_cli='" & TxtApellido.Text & "',
                        fdn_cli='" & DtpFdn.Value.ToString("yyyy-MM-dd") & "',
                        tlf_cli='" & TxtTelefono.Text & "',
                        eml_cli='" & TxtEmail.Text & "',
                        dir_cli='" & TxtDireccion.Text & "',
                        mpg_cli='" & strMtdPgs & "',
                        fdi_cli='" & DtpFdi.Value.ToString("yyyy-MM-dd") & "',
                        std_cli='" & strEstado & "'
                        WHERE id_cli='" & strIdClient & "'"
        End If

        Sub_Crud_Sql(sqlConsulta)

        FillLabelsMessage()

    End Sub
    '
    '
    '
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        '| ----------------------------------------------------------------------------------
        '| CERRAMOS EL FORMULARIO
        '| ----------------------
        Me.Close()

    End Sub

    '| ---------------------------------------------------------------- |'
    '| ---------->>>>>>>>>> SUBRUTINAS Y FUNCIONES <<<<<<<<<<---------- |'
    '| ---------------------------------------------------------------- |'

    Sub Sub_TxtLost_Focus(lblLabel As Label)

        '| ------------------------------------------------------------------------
        '| * Limpiamos cualquier error previo.
        '|
        '| IF : Si el label está vacio
        '|      * Activamos el ErrorProvider y cambiamos el color del label que nos
        '|        indica error.
        '| ELSE :
        '|      * Cambiamos el color del label que indica que el valor es correcto.

        ErrorProvider.Clear()

        If String.IsNullOrWhiteSpace(lblLabel.Text) Then
            ErrorProvider.SetError(lblLabel, "El campo no puede estar vacío.")
            lblLabel.BackColor = Color.MistyRose
        Else
            lblLabel.BackColor = Color.Azure
        End If

    End Sub

    Sub Sub_TxtLost_Focus(txtTextBox As TextBox)

        '| --------------------------------------------------------------------------------
        '| * Limpiamos cualquier error previo que se haya establecido en cualquier control.
        '|
        '| IF : Comprueba si el contenido del TextBox es NULO, VACÍO (""), o si solo contiene
        '|      ESPACIOS EN BLANCO (incluyendo tabs o saltos de línea):
        '|      * Si la validación falla activamos el ErrorProvider y cambiamos el color de
        '|        fondo del textbox que nos indica un error y requiere atención.
        '|
        '| ELSE : Si el campo tiene caracteres:
        '|      * Quitamos los espacios en blanco iniciales y finales de la cadena.
        '|
        '|      WHILE : Comienza un ciclo para eliminar múltiples espacios internos. Se ejecuta
        '|              MIENTRAS la cadena contenga la secuencia "  " (dos o más espacios).
        '|              * Reemplaza los DOS espacios consecutivos con UN solo espacio. Esto se
        '|                repite hasta que no queden más espacios dobles, asegurando un solo
        '|                espacio entre palabras.
        '|      ** Para la limpieza de espacios en blanco tambien podemos usar TRIM y luego
        '|         REGEX [Regex.Replace(cleanText, "\s+", " ")]. Para nuestro caso no sirve
        '|         porque borra los saltos de línea y concatena la dirección.**
        '|
        '|      * Cambiamos el color de fondo del TextBox que indica que el valor es correcto.

        ErrorProvider.Clear()

        If String.IsNullOrWhiteSpace(txtTextBox.Text) Then
            ErrorProvider.SetError(txtTextBox, "El campo no puede estar vacío.")
            txtTextBox.BackColor = Color.MistyRose
        Else
            txtTextBox.Text = Trim(txtTextBox.Text)
            While txtTextBox.Text.Contains("  ")
                txtTextBox.Text = txtTextBox.Text.Replace("  ", " ")
            End While
            txtTextBox.BackColor = Color.Azure
        End If

    End Sub
    '
    '
    '
    Overloads Function FunMsgBox(clientData As String, titleMsgbox As String, textBox As TextBox) As Boolean

        '| -------------------------------------------------------------------------------------------------
        '| IF : Comprobamos si el TextBox está vacío.
        '|
        '|      * Convertimos el texto de la variable clientData y titleMsgbox en mayúsculsa y minúsculas _
        '|        _ respectivamente usando UCase() y LCase(), también se puede usar ToUpper() y ToLower().
        '|      * Extraemos el nombre del botón BtnGuardar o BtnActualizar, utilizando Substring() y lo _
        '|        _ convertimos en minúsculas usando LCase, para mostrarlo en el título de mensaje.
        '|      * Mostramos el mensaje con los datos recibidos por parámetro, enviamos el enfoque al _
        '|        _ textbox que corresponda.
        '|      * Return True para salir de la función y no ejecutar el resto del código.
        '|
        '| ELSE : Si el TextBox tiene datos
        '|
        '|      * Return False para seguir ejecutando el resto del código.

        If String.IsNullOrWhiteSpace(textBox.Text) Then
            clientData = UCase(clientData)
            titleMsgbox = LCase(titleMsgbox.Substring(1, titleMsgbox.Length - 1))
            MsgBox(" Verifica la información del cliente" & vbCr & vbCr &
                   " El campo " & clientData & " no puede estar vacío.", vbCritical, "Error al " & titleMsgbox)
            textBox.Focus()
            Return True
        Else
            Return False
        End If

    End Function
    Overloads Function FunMsgBox(clientData As String, titleMsgbox As String, label As Label, dateTimePicker As DateTimePicker) As Boolean

        '| -------------------------------------------------------------------------------------------------------------------------------
        '| IF : Comprobamos si el Label está vacío.
        '|      * Convertimos el texto de la variable clientData y titleMsgbox en mayúsculsa y minúsculas respectivamente usando UCase() _
        '|        _ y LCase(), también se puede usar ToUpper() y ToLower().
        '|      * Extraemos el nombre del botón BtnGuardar o BtnActualizar según sea el caso, utilizando Substring() y lo convertimos en _
        '|        _ minúsculas usando LCase, para mostrarlo en el título de mensaje.
        '|      * Mostramos el mensaje con los datos recibidos por parámetro, enviamos el enfoque al dateTimePicker que corresponda.
        '|      * Return True para salir de la función y no ejecutar el resto del código.
        '| ELSE : Si el TextBox tiene datos
        '|      * Return False para seguir ejecutando el resto del código.

        If String.IsNullOrEmpty(label.Text) Then
            clientData = UCase(clientData)
            titleMsgbox = LCase(titleMsgbox.Substring(1, titleMsgbox.Length - 1))
            MsgBox(" Verifica la información del cliente" & vbCr & vbCr &
                   " El campo " & clientData & " no puede estar vacío.", vbCritical, "Error al " & titleMsgbox)
            dateTimePicker.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    Overloads Function FunMsGbox(titleMsgbox As String, rb1 As RadioButton, rb2 As RadioButton, rb3 As RadioButton) As Boolean

        '| -------------------------------------------------------------------------------------------------------------------
        '| IF : Comprobamos si los RadioButton no están seleccionados.
        '|      * Extraemos el nombre del botón BtnGuardar o BtnActualizar según sea el caso, utilizando Substring() y lo _
        '|        _ convertimos en minúsculas usando LCase, para mostrarlo en el título de mensaje.
        '|      * Mostramos el mensaje con los datos recibidos por parámetro.
        '|      * Return True para salir de la función y no ejecutar el resto del código.
        '| ELSE : Si uno de los RadioButton está seleccionado.
        '|      * Return False para seguir ejecutando el resto del código.

        If Not rb1.Checked And Not rb2.Checked And Not rb3.Checked Then
            titleMsgbox = LCase(titleMsgbox.Substring(1, titleMsgbox.Length - 1))
            MsgBox("Selecciona un MÉTODO de pago.", vbCritical, "Error al " & titleMsgbox)
            Return True
        Else
            Return False
        End If
    End Function
    Overloads Function FunMsgBox(clientData As String, titleMsgbox As String, textBox As TextBox, radioButton As RadioButton) As Boolean

        '| -----------------------------------------------------------------------------------------------------------------------------
        '| IF : Comprobamos si está activado el RadioButton y el TextBox está vacío.
        '|      * Convertimos el texto de la variable clientData y titleMsgbox en mayúsculsa y minúsculas respectivamente usando UCase() _
        '|        _ y LCase(), también se puede usar ToUpper() y ToLower()
        '|      * Comprobamos si la variable clientData = "DIARIO" para agragar el texto "pago ".
        '|      * Extraemos el nombre del botón BtnGuardar o BtnActualizar según sea el caso, utilizando Substring() y lo convertimos en _
        '|        _ minúsculas usando LCase, para mostrarlo en el título de mensaje.
        '|      * Mostramos el mensaje con los datos recibidos por parámetro, enviamos el enfoque al textbox que corresponda.
        '|      * Return True para salir de la función y no ejecutar el resto del código.
        '| ELSE : Si el TextBox tiene datos
        '|      * Return False para seguir ejecutando el resto del código.

        If radioButton.Checked And textBox.Text = "" Then
            clientData = UCase(clientData)
            If clientData = "DIARIO" Then clientData = "pago " & clientData
            titleMsgbox = LCase(titleMsgbox.Substring(1, titleMsgbox.Length - 1))
            MsgBox(" Verifica la información del cliente" & vbCr & vbCr &
                   " Selecciona un " & clientData & " de la lista.", vbCritical, "Error al " & titleMsgbox)
            textBox.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    '
    '
    '
    Sub FillLabelsMessage()

        '| -------------------------------------------------------------------------------------------------------
        '| * Llenamos los campos del formulario FrmClientesPagos con los datos que se han guardado o actualizado.
        '| * Damos formato el codigo del cliente para mostrar en el mensaje de confirmación.
        '| * Cerramos el formulario FrmNuevoEditarCliente.

        With FrmClientsPayments
            .strIdClient = strIdClient
            .LblNomCli.Text = TxtNombre.Text
            .LblApeCli.Text = TxtApellido.Text
            .FnacimientoCorto.Text = DtpFdn.Value
            .LblFdnCli.Text = Fun_Long_Date(DtpFdn.Value)
            .LblEdadCli.Text = TxtEdad.Text
            .LblTlfCli.Text = TxtTelefono.Text
            .LblEmlCli.Text = TxtEmail.Text
            .LblDirCli.Text = TxtDireccion.Text
            If RbDiario.Checked = True Then
                .LblMtdPgoCli.Text = TxtListaNom.Text
            Else
                .LblMtdPgoCli.Text = strMtdPgs
                .LblGrpFamCli.Text = TxtListaNom.Text
            End If
            .FregistroCorto.Text = DtpFdi.Value
            .LblFdiCli.Text = Fun_Long_Date(DtpFdi.Value)
            .LblEstCli.Text = strEstado
        End With

        Dim bodyText As String
        If BtnGuardar.Visible = True Then
            bodyText = "GUARDADOS"
        Else
            bodyText = "ACTUALIZADOS"
        End If

        If strIdClient.Length = 1 Then strIdClient = "CLI - 00" & strIdClient
        If strIdClient.Length = 2 Then strIdClient = "CLI - 0" & strIdClient
        If strIdClient.Length = 3 Then strIdClient = "CLI - " & strIdClient
        MsgBox("DATOS DEL CLIENTE" & vbCr & vbCr &
               "   NOMBRE   :  " & TxtNombre.Text & " " & TxtApellido.Text & vbCr &
               "   CODIGO   :  " & strIdClient & vbCr &
               "   -----------------------------------------------" & vbCr &
               "   Datos " & bodyText & " correctamente.", vbInformation, "Registrado")
        Close()
    End Sub

End Class