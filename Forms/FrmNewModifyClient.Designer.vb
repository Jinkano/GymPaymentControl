<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewModifyClient
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GbOtros = New System.Windows.Forms.GroupBox()
        Me.RbInactiveState = New System.Windows.Forms.RadioButton()
        Me.RbActiveStatus = New System.Windows.Forms.RadioButton()
        Me.LblEstadoCli = New System.Windows.Forms.Label()
        Me.DtpFdi = New System.Windows.Forms.DateTimePicker()
        Me.LblFinscripcion = New System.Windows.Forms.Label()
        Me.GbMetodoPago = New System.Windows.Forms.GroupBox()
        Me.RbDiario = New System.Windows.Forms.RadioButton()
        Me.RbMensual = New System.Windows.Forms.RadioButton()
        Me.RbGrupoFamiliar = New System.Windows.Forms.RadioButton()
        Me.BtnAddGrupo = New System.Windows.Forms.Button()
        Me.GbListaGrupoFamiliar = New System.Windows.Forms.GroupBox()
        Me.LblNumIntgrntes = New System.Windows.Forms.Label()
        Me.TxtListaNom = New System.Windows.Forms.TextBox()
        Me.DgvListaNombre = New System.Windows.Forms.DataGridView()
        Me.ColIdGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNomGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNumIntgrntes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIntgrntesReg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GbContacto = New System.Windows.Forms.GroupBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.DtpFdn = New System.Windows.Forms.DateTimePicker()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.Label()
        Me.LblFnacimiento = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GbOtros.SuspendLayout()
        Me.GbMetodoPago.SuspendLayout()
        Me.GbListaGrupoFamiliar.SuspendLayout()
        CType(Me.DgvListaNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbContacto.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbOtros
        '
        Me.GbOtros.Controls.Add(Me.RbInactiveState)
        Me.GbOtros.Controls.Add(Me.RbActiveStatus)
        Me.GbOtros.Controls.Add(Me.LblEstadoCli)
        Me.GbOtros.Controls.Add(Me.DtpFdi)
        Me.GbOtros.Controls.Add(Me.LblFinscripcion)
        Me.GbOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbOtros.Location = New System.Drawing.Point(439, 25)
        Me.GbOtros.Margin = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.GbOtros.Name = "GbOtros"
        Me.GbOtros.Padding = New System.Windows.Forms.Padding(0)
        Me.GbOtros.Size = New System.Drawing.Size(374, 163)
        Me.GbOtros.TabIndex = 2
        Me.GbOtros.TabStop = False
        Me.GbOtros.Text = "Otros datos :"
        '
        'RbInactiveState
        '
        Me.RbInactiveState.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbInactiveState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbInactiveState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbInactiveState.Location = New System.Drawing.Point(192, 113)
        Me.RbInactiveState.Margin = New System.Windows.Forms.Padding(0)
        Me.RbInactiveState.Name = "RbInactiveState"
        Me.RbInactiveState.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.RbInactiveState.Size = New System.Drawing.Size(160, 26)
        Me.RbInactiveState.TabIndex = 2
        Me.RbInactiveState.Text = "Inactivo"
        Me.RbInactiveState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbInactiveState.UseVisualStyleBackColor = True
        '
        'RbActiveStatus
        '
        Me.RbActiveStatus.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbActiveStatus.Checked = True
        Me.RbActiveStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbActiveStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbActiveStatus.Location = New System.Drawing.Point(24, 113)
        Me.RbActiveStatus.Margin = New System.Windows.Forms.Padding(0, 8, 0, 24)
        Me.RbActiveStatus.Name = "RbActiveStatus"
        Me.RbActiveStatus.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.RbActiveStatus.Size = New System.Drawing.Size(160, 26)
        Me.RbActiveStatus.TabIndex = 1
        Me.RbActiveStatus.TabStop = True
        Me.RbActiveStatus.Text = "Activo"
        Me.RbActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbActiveStatus.UseVisualStyleBackColor = True
        '
        'LblEstadoCli
        '
        Me.LblEstadoCli.AutoSize = True
        Me.LblEstadoCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstadoCli.Location = New System.Drawing.Point(24, 89)
        Me.LblEstadoCli.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblEstadoCli.Name = "LblEstadoCli"
        Me.LblEstadoCli.Size = New System.Drawing.Size(114, 16)
        Me.LblEstadoCli.TabIndex = 4
        Me.LblEstadoCli.Text = "Estado del cliente"
        '
        'DtpFdi
        '
        Me.DtpFdi.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFdi.CustomFormat = "' ' dddd ', ' dd ' de ' MMMM ' de ' yyyy"
        Me.DtpFdi.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.DtpFdi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFdi.Location = New System.Drawing.Point(24, 51)
        Me.DtpFdi.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.DtpFdi.Name = "DtpFdi"
        Me.DtpFdi.Size = New System.Drawing.Size(328, 26)
        Me.DtpFdi.TabIndex = 0
        '
        'LblFinscripcion
        '
        Me.LblFinscripcion.AutoSize = True
        Me.LblFinscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFinscripcion.Location = New System.Drawing.Point(24, 27)
        Me.LblFinscripcion.Margin = New System.Windows.Forms.Padding(24, 12, 0, 0)
        Me.LblFinscripcion.Name = "LblFinscripcion"
        Me.LblFinscripcion.Size = New System.Drawing.Size(131, 16)
        Me.LblFinscripcion.TabIndex = 3
        Me.LblFinscripcion.Text = "Fecha de Inscripción"
        '
        'GbMetodoPago
        '
        Me.GbMetodoPago.Controls.Add(Me.RbDiario)
        Me.GbMetodoPago.Controls.Add(Me.RbMensual)
        Me.GbMetodoPago.Controls.Add(Me.RbGrupoFamiliar)
        Me.GbMetodoPago.Controls.Add(Me.BtnAddGrupo)
        Me.GbMetodoPago.Controls.Add(Me.GbListaGrupoFamiliar)
        Me.GbMetodoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbMetodoPago.Location = New System.Drawing.Point(439, 204)
        Me.GbMetodoPago.Margin = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.GbMetodoPago.Name = "GbMetodoPago"
        Me.GbMetodoPago.Padding = New System.Windows.Forms.Padding(0)
        Me.GbMetodoPago.Size = New System.Drawing.Size(374, 341)
        Me.GbMetodoPago.TabIndex = 3
        Me.GbMetodoPago.TabStop = False
        Me.GbMetodoPago.Text = "Método de pago :"
        '
        'RbDiario
        '
        Me.RbDiario.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDiario.Image = Global.GymPaymentControl.My.Resources.Resources.ic_daily_27x30
        Me.RbDiario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbDiario.Location = New System.Drawing.Point(24, 27)
        Me.RbDiario.Margin = New System.Windows.Forms.Padding(24, 12, 0, 0)
        Me.RbDiario.Name = "RbDiario"
        Me.RbDiario.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.RbDiario.Size = New System.Drawing.Size(160, 40)
        Me.RbDiario.TabIndex = 0
        Me.RbDiario.Text = "Diario"
        Me.RbDiario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbDiario.UseVisualStyleBackColor = True
        '
        'RbMensual
        '
        Me.RbMensual.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbMensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMensual.Image = Global.GymPaymentControl.My.Resources.Resources.ic_monthly_30x30
        Me.RbMensual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbMensual.Location = New System.Drawing.Point(192, 27)
        Me.RbMensual.Margin = New System.Windows.Forms.Padding(8, 0, 24, 0)
        Me.RbMensual.Name = "RbMensual"
        Me.RbMensual.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.RbMensual.Size = New System.Drawing.Size(160, 40)
        Me.RbMensual.TabIndex = 1
        Me.RbMensual.Text = "Mensual"
        Me.RbMensual.UseVisualStyleBackColor = True
        '
        'RbGrupoFamiliar
        '
        Me.RbGrupoFamiliar.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbGrupoFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbGrupoFamiliar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_family_group_53x30
        Me.RbGrupoFamiliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbGrupoFamiliar.Location = New System.Drawing.Point(24, 75)
        Me.RbGrupoFamiliar.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.RbGrupoFamiliar.Name = "RbGrupoFamiliar"
        Me.RbGrupoFamiliar.Padding = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.RbGrupoFamiliar.Size = New System.Drawing.Size(230, 40)
        Me.RbGrupoFamiliar.TabIndex = 2
        Me.RbGrupoFamiliar.Text = "Grupo familiar"
        Me.RbGrupoFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbGrupoFamiliar.UseVisualStyleBackColor = True
        '
        'BtnAddGrupo
        '
        Me.BtnAddGrupo.Enabled = False
        Me.BtnAddGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddGrupo.Image = Global.GymPaymentControl.My.Resources.Resources.ic_add_group_37x30
        Me.BtnAddGrupo.Location = New System.Drawing.Point(262, 75)
        Me.BtnAddGrupo.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BtnAddGrupo.Name = "BtnAddGrupo"
        Me.BtnAddGrupo.Size = New System.Drawing.Size(90, 40)
        Me.BtnAddGrupo.TabIndex = 3
        Me.BtnAddGrupo.UseVisualStyleBackColor = True
        '
        'GbListaGrupoFamiliar
        '
        Me.GbListaGrupoFamiliar.Controls.Add(Me.LblNumIntgrntes)
        Me.GbListaGrupoFamiliar.Controls.Add(Me.TxtListaNom)
        Me.GbListaGrupoFamiliar.Controls.Add(Me.DgvListaNombre)
        Me.GbListaGrupoFamiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbListaGrupoFamiliar.Location = New System.Drawing.Point(24, 131)
        Me.GbListaGrupoFamiliar.Margin = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.GbListaGrupoFamiliar.Name = "GbListaGrupoFamiliar"
        Me.GbListaGrupoFamiliar.Padding = New System.Windows.Forms.Padding(0)
        Me.GbListaGrupoFamiliar.Size = New System.Drawing.Size(328, 186)
        Me.GbListaGrupoFamiliar.TabIndex = 4
        Me.GbListaGrupoFamiliar.TabStop = False
        Me.GbListaGrupoFamiliar.Text = "Lista vacia"
        '
        'LblNumIntgrntes
        '
        Me.LblNumIntgrntes.BackColor = System.Drawing.Color.Azure
        Me.LblNumIntgrntes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumIntgrntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumIntgrntes.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblNumIntgrntes.Location = New System.Drawing.Point(258, 26)
        Me.LblNumIntgrntes.Margin = New System.Windows.Forms.Padding(0)
        Me.LblNumIntgrntes.Name = "LblNumIntgrntes"
        Me.LblNumIntgrntes.Size = New System.Drawing.Size(70, 26)
        Me.LblNumIntgrntes.TabIndex = 2
        Me.LblNumIntgrntes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtListaNom
        '
        Me.TxtListaNom.BackColor = System.Drawing.Color.Azure
        Me.TxtListaNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtListaNom.Enabled = False
        Me.TxtListaNom.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtListaNom.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtListaNom.Location = New System.Drawing.Point(0, 26)
        Me.TxtListaNom.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.TxtListaNom.MaxLength = 30
        Me.TxtListaNom.Name = "TxtListaNom"
        Me.TxtListaNom.Size = New System.Drawing.Size(255, 26)
        Me.TxtListaNom.TabIndex = 0
        Me.TxtListaNom.WordWrap = False
        '
        'DgvListaNombre
        '
        Me.DgvListaNombre.AllowUserToAddRows = False
        Me.DgvListaNombre.AllowUserToDeleteRows = False
        Me.DgvListaNombre.AllowUserToResizeColumns = False
        Me.DgvListaNombre.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvListaNombre.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvListaNombre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvListaNombre.ColumnHeadersHeight = 4
        Me.DgvListaNombre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListaNombre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdGrupo, Me.ColNomGrupo, Me.ColNumIntgrntes, Me.ColIntgrntesReg})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvListaNombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvListaNombre.Enabled = False
        Me.DgvListaNombre.Location = New System.Drawing.Point(0, 56)
        Me.DgvListaNombre.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.DgvListaNombre.MultiSelect = False
        Me.DgvListaNombre.Name = "DgvListaNombre"
        Me.DgvListaNombre.ReadOnly = True
        Me.DgvListaNombre.RowHeadersWidth = 4
        Me.DgvListaNombre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvListaNombre.RowTemplate.DividerHeight = 2
        Me.DgvListaNombre.RowTemplate.Height = 25
        Me.DgvListaNombre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListaNombre.Size = New System.Drawing.Size(328, 130)
        Me.DgvListaNombre.TabIndex = 1
        '
        'ColIdGrupo
        '
        Me.ColIdGrupo.HeaderText = "ColIdGrupo"
        Me.ColIdGrupo.Name = "ColIdGrupo"
        Me.ColIdGrupo.ReadOnly = True
        Me.ColIdGrupo.Visible = False
        '
        'ColNomGrupo
        '
        Me.ColNomGrupo.HeaderText = ""
        Me.ColNomGrupo.Name = "ColNomGrupo"
        Me.ColNomGrupo.ReadOnly = True
        Me.ColNomGrupo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColNomGrupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNomGrupo.Width = 303
        '
        'ColNumIntgrntes
        '
        Me.ColNumIntgrntes.HeaderText = "ColNumIntgrntes"
        Me.ColNumIntgrntes.Name = "ColNumIntgrntes"
        Me.ColNumIntgrntes.ReadOnly = True
        Me.ColNumIntgrntes.Visible = False
        '
        'ColIntgrntesReg
        '
        Me.ColIntgrntesReg.HeaderText = "ColIntgrntesReg"
        Me.ColIntgrntesReg.Name = "ColIntgrntesReg"
        Me.ColIntgrntesReg.ReadOnly = True
        Me.ColIntgrntesReg.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Brown
        Me.BtnCancelar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_cancel_28x28
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(837, 212)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(0, 7, 0, 4)
        Me.BtnCancelar.Size = New System.Drawing.Size(135, 75)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'GbContacto
        '
        Me.GbContacto.Controls.Add(Me.TxtDireccion)
        Me.GbContacto.Controls.Add(Me.TxtEmail)
        Me.GbContacto.Controls.Add(Me.TxtTelefono)
        Me.GbContacto.Controls.Add(Me.LblDireccion)
        Me.GbContacto.Controls.Add(Me.LblEmail)
        Me.GbContacto.Controls.Add(Me.LblTelefono)
        Me.GbContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbContacto.Location = New System.Drawing.Point(25, 266)
        Me.GbContacto.Margin = New System.Windows.Forms.Padding(0, 16, 0, 24)
        Me.GbContacto.Name = "GbContacto"
        Me.GbContacto.Padding = New System.Windows.Forms.Padding(0)
        Me.GbContacto.Size = New System.Drawing.Size(398, 279)
        Me.GbContacto.TabIndex = 1
        Me.GbContacto.TabStop = False
        Me.GbContacto.Text = "Datos de contacto :"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BackColor = System.Drawing.Color.Azure
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtDireccion.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtDireccion.Location = New System.Drawing.Point(24, 175)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(0, 8, 0, 24)
        Me.TxtDireccion.MaxLength = 100
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDireccion.Size = New System.Drawing.Size(350, 80)
        Me.TxtDireccion.TabIndex = 2
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.Azure
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEmail.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtEmail.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtEmail.Location = New System.Drawing.Point(24, 113)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.TxtEmail.MaxLength = 50
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(350, 26)
        Me.TxtEmail.TabIndex = 1
        Me.TxtEmail.WordWrap = False
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.Azure
        Me.TxtTelefono.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtTelefono.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtTelefono.Location = New System.Drawing.Point(24, 51)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.TxtTelefono.MaxLength = 15
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(350, 26)
        Me.TxtTelefono.TabIndex = 0
        Me.TxtTelefono.WordWrap = False
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.Location = New System.Drawing.Point(24, 151)
        Me.LblDireccion.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(64, 16)
        Me.LblDireccion.TabIndex = 5
        Me.LblDireccion.Text = "Dirección"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(21, 89)
        Me.LblEmail.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(45, 16)
        Me.LblEmail.TabIndex = 4
        Me.LblEmail.Text = "E-Mail"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.Location = New System.Drawing.Point(21, 27)
        Me.LblTelefono.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(61, 16)
        Me.LblTelefono.TabIndex = 3
        Me.LblTelefono.Text = "Teléfono"
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.DtpFdn)
        Me.GbDatos.Controls.Add(Me.LblEdad)
        Me.GbDatos.Controls.Add(Me.TxtApellido)
        Me.GbDatos.Controls.Add(Me.TxtNombre)
        Me.GbDatos.Controls.Add(Me.TxtEdad)
        Me.GbDatos.Controls.Add(Me.LblFnacimiento)
        Me.GbDatos.Controls.Add(Me.LblApellido)
        Me.GbDatos.Controls.Add(Me.LblNombre)
        Me.GbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatos.Location = New System.Drawing.Point(25, 25)
        Me.GbDatos.Margin = New System.Windows.Forms.Padding(16, 16, 0, 0)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Padding = New System.Windows.Forms.Padding(0)
        Me.GbDatos.Size = New System.Drawing.Size(398, 225)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos del cliente :"
        '
        'DtpFdn
        '
        Me.DtpFdn.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFdn.CustomFormat = "' ' dd ' de  ' MMMM ' de  ' yyyy"
        Me.DtpFdn.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.DtpFdn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFdn.Location = New System.Drawing.Point(24, 175)
        Me.DtpFdn.Margin = New System.Windows.Forms.Padding(0, 8, 0, 24)
        Me.DtpFdn.Name = "DtpFdn"
        Me.DtpFdn.Size = New System.Drawing.Size(270, 26)
        Me.DtpFdn.TabIndex = 2
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdad.Location = New System.Drawing.Point(301, 151)
        Me.LblEdad.Margin = New System.Windows.Forms.Padding(0)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(40, 16)
        Me.LblEdad.TabIndex = 7
        Me.LblEdad.Text = "Edad"
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.Azure
        Me.TxtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApellido.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtApellido.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtApellido.Location = New System.Drawing.Point(24, 113)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.TxtApellido.MaxLength = 30
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(350, 26)
        Me.TxtApellido.TabIndex = 1
        Me.TxtApellido.WordWrap = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.Azure
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtNombre.Location = New System.Drawing.Point(24, 51)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(24, 8, 24, 0)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(350, 26)
        Me.TxtNombre.TabIndex = 0
        Me.TxtNombre.WordWrap = False
        '
        'TxtEdad
        '
        Me.TxtEdad.BackColor = System.Drawing.Color.Azure
        Me.TxtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEdad.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!)
        Me.TxtEdad.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtEdad.Location = New System.Drawing.Point(304, 175)
        Me.TxtEdad.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(70, 26)
        Me.TxtEdad.TabIndex = 3
        Me.TxtEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFnacimiento
        '
        Me.LblFnacimiento.AutoSize = True
        Me.LblFnacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFnacimiento.Location = New System.Drawing.Point(24, 151)
        Me.LblFnacimiento.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblFnacimiento.Name = "LblFnacimiento"
        Me.LblFnacimiento.Size = New System.Drawing.Size(135, 16)
        Me.LblFnacimiento.TabIndex = 6
        Me.LblFnacimiento.Text = "Fecha de Nacimiento"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.Location = New System.Drawing.Point(24, 89)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(57, 16)
        Me.LblApellido.TabIndex = 5
        Me.LblApellido.Text = "Apellido"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(24, 27)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(24, 12, 0, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(56, 16)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Nombre"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Green
        Me.BtnActualizar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_update_28x27
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(837, 41)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Padding = New System.Windows.Forms.Padding(0, 7, 0, 4)
        Me.BtnActualizar.Size = New System.Drawing.Size(135, 75)
        Me.BtnActualizar.TabIndex = 5
        Me.BtnActualizar.Text = "&Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGuardar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_save_28x28
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(837, 41)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(24, 32, 16, 0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(0, 7, 0, 4)
        Me.BtnGuardar.Size = New System.Drawing.Size(135, 75)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'FrmNewModifyClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 578)
        Me.Controls.Add(Me.GbOtros)
        Me.Controls.Add(Me.GbMetodoPago)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GbContacto)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewModifyClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO Y ACTUALIZACIÓN DE USUARIOS"
        Me.GbOtros.ResumeLayout(False)
        Me.GbOtros.PerformLayout()
        Me.GbMetodoPago.ResumeLayout(False)
        Me.GbListaGrupoFamiliar.ResumeLayout(False)
        Me.GbListaGrupoFamiliar.PerformLayout()
        CType(Me.DgvListaNombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbContacto.ResumeLayout(False)
        Me.GbContacto.PerformLayout()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents GbOtros As GroupBox
    Friend WithEvents RbInactiveState As RadioButton
    Friend WithEvents RbActiveStatus As RadioButton
    Friend WithEvents LblEstadoCli As Label
    Friend WithEvents DtpFdi As DateTimePicker
    Friend WithEvents LblFinscripcion As Label
    Friend WithEvents GbMetodoPago As GroupBox
    Friend WithEvents RbDiario As RadioButton
    Friend WithEvents RbMensual As RadioButton
    Friend WithEvents RbGrupoFamiliar As RadioButton
    Friend WithEvents BtnAddGrupo As Button
    Friend WithEvents GbListaGrupoFamiliar As GroupBox
    Friend WithEvents LblNumIntgrntes As Label
    Friend WithEvents TxtListaNom As TextBox
    Friend WithEvents DgvListaNombre As DataGridView
    Friend WithEvents ColIdGrupo As DataGridViewTextBoxColumn
    Friend WithEvents ColNomGrupo As DataGridViewTextBoxColumn
    Friend WithEvents ColNumIntgrntes As DataGridViewTextBoxColumn
    Friend WithEvents ColIntgrntesReg As DataGridViewTextBoxColumn
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents GbContacto As GroupBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents DtpFdn As DateTimePicker
    Friend WithEvents LblEdad As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtEdad As Label
    Friend WithEvents LblFnacimiento As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
