<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiscountTable
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle65 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.DgvTabla = New System.Windows.Forms.DataGridView()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEdadMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEdadMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNumPerson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDscto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColApagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.TxtApagar = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.CmbTipoPago = New System.Windows.Forms.ComboBox()
        Me.TxtDscnto = New System.Windows.Forms.TextBox()
        Me.LblApagar = New System.Windows.Forms.Label()
        Me.LblDscto = New System.Windows.Forms.Label()
        Me.NudEdadMax = New System.Windows.Forms.NumericUpDown()
        Me.LblMax = New System.Windows.Forms.Label()
        Me.LblNumPerson = New System.Windows.Forms.Label()
        Me.NudEdadMin = New System.Windows.Forms.NumericUpDown()
        Me.NudNumPerson = New System.Windows.Forms.NumericUpDown()
        Me.LblMin = New System.Windows.Forms.Label()
        Me.LblNomPago = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        CType(Me.DgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        CType(Me.NudEdadMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudEdadMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudNumPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_modify_28x32
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(749, 89)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.BtnModificar.Size = New System.Drawing.Size(170, 46)
        Me.BtnModificar.TabIndex = 12
        Me.BtnModificar.Text = "&Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'DgvTabla
        '
        Me.DgvTabla.AllowUserToAddRows = False
        Me.DgvTabla.AllowUserToDeleteRows = False
        Me.DgvTabla.AllowUserToResizeColumns = False
        Me.DgvTabla.AllowUserToResizeRows = False
        DataGridViewCellStyle53.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTabla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle53
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle54.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvTabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle54
        Me.DgvTabla.ColumnHeadersHeight = 35
        Me.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.ColTipoPago, Me.ColPrecio, Me.ColEdadMin, Me.ColEdadMax, Me.ColNumPerson, Me.ColTotal, Me.ColDscto, Me.ColApagar})
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle63.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTabla.DefaultCellStyle = DataGridViewCellStyle63
        Me.DgvTabla.Location = New System.Drawing.Point(29, 267)
        Me.DgvTabla.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.DgvTabla.MultiSelect = False
        Me.DgvTabla.Name = "DgvTabla"
        Me.DgvTabla.ReadOnly = True
        DataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvTabla.RowHeadersDefaultCellStyle = DataGridViewCellStyle64
        Me.DgvTabla.RowHeadersWidth = 35
        Me.DgvTabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTabla.RowsDefaultCellStyle = DataGridViewCellStyle65
        Me.DgvTabla.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTabla.RowTemplate.DividerHeight = 2
        Me.DgvTabla.RowTemplate.Height = 30
        Me.DgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTabla.Size = New System.Drawing.Size(906, 246)
        Me.DgvTabla.TabIndex = 18
        '
        'ColId
        '
        Me.ColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColId.HeaderText = "id"
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = True
        Me.ColId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColId.Visible = False
        Me.ColId.Width = 20
        '
        'ColTipoPago
        '
        Me.ColTipoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ColTipoPago.DefaultCellStyle = DataGridViewCellStyle55
        Me.ColTipoPago.HeaderText = "TIPO DE PAGO"
        Me.ColTipoPago.Name = "ColTipoPago"
        Me.ColTipoPago.ReadOnly = True
        Me.ColTipoPago.Width = 130
        '
        'ColPrecio
        '
        Me.ColPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColPrecio.DefaultCellStyle = DataGridViewCellStyle56
        Me.ColPrecio.HeaderText = "PRECIO"
        Me.ColPrecio.Name = "ColPrecio"
        Me.ColPrecio.ReadOnly = True
        Me.ColPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColEdadMin
        '
        Me.ColEdadMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColEdadMin.DefaultCellStyle = DataGridViewCellStyle57
        Me.ColEdadMin.HeaderText = "EDAD MIN"
        Me.ColEdadMin.Name = "ColEdadMin"
        Me.ColEdadMin.ReadOnly = True
        Me.ColEdadMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColEdadMax
        '
        Me.ColEdadMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColEdadMax.DefaultCellStyle = DataGridViewCellStyle58
        Me.ColEdadMax.HeaderText = "EDAD MAX"
        Me.ColEdadMax.Name = "ColEdadMax"
        Me.ColEdadMax.ReadOnly = True
        Me.ColEdadMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColNumPerson
        '
        Me.ColNumPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColNumPerson.DefaultCellStyle = DataGridViewCellStyle59
        Me.ColNumPerson.HeaderText = "Nº PERSONAS"
        Me.ColNumPerson.Name = "ColNumPerson"
        Me.ColNumPerson.ReadOnly = True
        Me.ColNumPerson.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNumPerson.Width = 110
        '
        'ColTotal
        '
        Me.ColTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColTotal.DefaultCellStyle = DataGridViewCellStyle60
        Me.ColTotal.HeaderText = "TOTAL"
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.ReadOnly = True
        Me.ColTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColDscto
        '
        Me.ColDscto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColDscto.DefaultCellStyle = DataGridViewCellStyle61
        Me.ColDscto.HeaderText = "DESCUENTO"
        Me.ColDscto.Name = "ColDscto"
        Me.ColDscto.ReadOnly = True
        Me.ColDscto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColDscto.Width = 110
        '
        'ColApagar
        '
        Me.ColApagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColApagar.DefaultCellStyle = DataGridViewCellStyle62
        Me.ColApagar.HeaderText = "A PAGAR"
        Me.ColApagar.Name = "ColApagar"
        Me.ColApagar.ReadOnly = True
        Me.ColApagar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.SystemColors.Control
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel.Controls.Add(Me.TxtApagar)
        Me.Panel.Controls.Add(Me.LblTotal)
        Me.Panel.Controls.Add(Me.TxtTotal)
        Me.Panel.Controls.Add(Me.LblPrecio)
        Me.Panel.Controls.Add(Me.TxtPrecio)
        Me.Panel.Controls.Add(Me.LblTipo)
        Me.Panel.Controls.Add(Me.CmbTipoPago)
        Me.Panel.Controls.Add(Me.TxtDscnto)
        Me.Panel.Controls.Add(Me.LblApagar)
        Me.Panel.Controls.Add(Me.LblDscto)
        Me.Panel.Controls.Add(Me.NudEdadMax)
        Me.Panel.Controls.Add(Me.LblMax)
        Me.Panel.Controls.Add(Me.LblNumPerson)
        Me.Panel.Controls.Add(Me.NudEdadMin)
        Me.Panel.Controls.Add(Me.NudNumPerson)
        Me.Panel.Controls.Add(Me.LblMin)
        Me.Panel.Controls.Add(Me.LblNomPago)
        Me.Panel.Controls.Add(Me.LblNombre)
        Me.Panel.Location = New System.Drawing.Point(29, 29)
        Me.Panel.Margin = New System.Windows.Forms.Padding(20, 20, 0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(677, 226)
        Me.Panel.TabIndex = 17
        '
        'TxtApagar
        '
        Me.TxtApagar.BackColor = System.Drawing.SystemColors.Window
        Me.TxtApagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtApagar.Enabled = False
        Me.TxtApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApagar.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtApagar.Location = New System.Drawing.Point(140, 174)
        Me.TxtApagar.MaxLength = 10
        Me.TxtApagar.Name = "TxtApagar"
        Me.TxtApagar.Size = New System.Drawing.Size(170, 26)
        Me.TxtApagar.TabIndex = 4
        Me.TxtApagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtApagar.WordWrap = False
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(89, 104)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(43, 16)
        Me.LblTotal.TabIndex = 2
        Me.LblTotal.Text = "Total"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.TxtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtTotal.Location = New System.Drawing.Point(140, 98)
        Me.TxtTotal.MaxLength = 10
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(170, 26)
        Me.TxtTotal.TabIndex = 2
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTotal.WordWrap = False
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.Location = New System.Drawing.Point(80, 66)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(52, 16)
        Me.LblPrecio.TabIndex = 1
        Me.LblPrecio.Text = "Precio"
        Me.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtPrecio.Location = New System.Drawing.Point(140, 60)
        Me.TxtPrecio.MaxLength = 10
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(170, 26)
        Me.TxtPrecio.TabIndex = 1
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPrecio.WordWrap = False
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.Location = New System.Drawing.Point(31, 27)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(101, 16)
        Me.LblTipo.TabIndex = 0
        Me.LblTipo.Text = "Tipo de pago"
        Me.LblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbTipoPago
        '
        Me.CmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoPago.Enabled = False
        Me.CmbTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoPago.ForeColor = System.Drawing.Color.MediumBlue
        Me.CmbTipoPago.FormattingEnabled = True
        Me.CmbTipoPago.IntegralHeight = False
        Me.CmbTipoPago.Items.AddRange(New Object() {"", "CLASES SUELTAS", "DESCUENTO POR EDAD", "GRUPO FAMILIAR", "MENSUALIDAD + IMPLEMENTOS"})
        Me.CmbTipoPago.Location = New System.Drawing.Point(140, 24)
        Me.CmbTipoPago.Name = "CmbTipoPago"
        Me.CmbTipoPago.Size = New System.Drawing.Size(500, 24)
        Me.CmbTipoPago.TabIndex = 0
        '
        'TxtDscnto
        '
        Me.TxtDscnto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDscnto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDscnto.Enabled = False
        Me.TxtDscnto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDscnto.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtDscnto.Location = New System.Drawing.Point(140, 136)
        Me.TxtDscnto.MaxLength = 10
        Me.TxtDscnto.Name = "TxtDscnto"
        Me.TxtDscnto.Size = New System.Drawing.Size(170, 26)
        Me.TxtDscnto.TabIndex = 3
        Me.TxtDscnto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDscnto.WordWrap = False
        '
        'LblApagar
        '
        Me.LblApagar.AutoSize = True
        Me.LblApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApagar.Location = New System.Drawing.Point(70, 180)
        Me.LblApagar.Name = "LblApagar"
        Me.LblApagar.Size = New System.Drawing.Size(62, 16)
        Me.LblApagar.TabIndex = 4
        Me.LblApagar.Text = "A pagar"
        Me.LblApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDscto
        '
        Me.LblDscto.AutoSize = True
        Me.LblDscto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDscto.Location = New System.Drawing.Point(51, 142)
        Me.LblDscto.Name = "LblDscto"
        Me.LblDscto.Size = New System.Drawing.Size(81, 16)
        Me.LblDscto.TabIndex = 3
        Me.LblDscto.Text = "Descuento"
        Me.LblDscto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NudEdadMax
        '
        Me.NudEdadMax.Enabled = False
        Me.NudEdadMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudEdadMax.ForeColor = System.Drawing.Color.MediumBlue
        Me.NudEdadMax.Location = New System.Drawing.Point(470, 175)
        Me.NudEdadMax.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NudEdadMax.Name = "NudEdadMax"
        Me.NudEdadMax.Size = New System.Drawing.Size(170, 26)
        Me.NudEdadMax.TabIndex = 7
        Me.NudEdadMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMax
        '
        Me.LblMax.AutoSize = True
        Me.LblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMax.Location = New System.Drawing.Point(361, 180)
        Me.LblMax.Name = "LblMax"
        Me.LblMax.Size = New System.Drawing.Size(101, 16)
        Me.LblMax.TabIndex = 9
        Me.LblMax.Text = "Edad maxima"
        '
        'LblNumPerson
        '
        Me.LblNumPerson.AutoSize = True
        Me.LblNumPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumPerson.Location = New System.Drawing.Point(355, 104)
        Me.LblNumPerson.Name = "LblNumPerson"
        Me.LblNumPerson.Size = New System.Drawing.Size(107, 16)
        Me.LblNumPerson.TabIndex = 7
        Me.LblNumPerson.Text = "Num personas"
        Me.LblNumPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NudEdadMin
        '
        Me.NudEdadMin.Enabled = False
        Me.NudEdadMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudEdadMin.ForeColor = System.Drawing.Color.MediumBlue
        Me.NudEdadMin.Location = New System.Drawing.Point(470, 137)
        Me.NudEdadMin.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NudEdadMin.Name = "NudEdadMin"
        Me.NudEdadMin.Size = New System.Drawing.Size(170, 26)
        Me.NudEdadMin.TabIndex = 6
        Me.NudEdadMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NudNumPerson
        '
        Me.NudNumPerson.Enabled = False
        Me.NudNumPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudNumPerson.ForeColor = System.Drawing.Color.MediumBlue
        Me.NudNumPerson.Location = New System.Drawing.Point(470, 99)
        Me.NudNumPerson.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NudNumPerson.Name = "NudNumPerson"
        Me.NudNumPerson.Size = New System.Drawing.Size(170, 26)
        Me.NudNumPerson.TabIndex = 5
        Me.NudNumPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMin
        '
        Me.LblMin.AutoSize = True
        Me.LblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMin.Location = New System.Drawing.Point(365, 142)
        Me.LblMin.Name = "LblMin"
        Me.LblMin.Size = New System.Drawing.Size(97, 16)
        Me.LblMin.TabIndex = 8
        Me.LblMin.Text = "Edad minima"
        '
        'LblNomPago
        '
        Me.LblNomPago.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LblNomPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNomPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomPago.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblNomPago.Location = New System.Drawing.Point(470, 60)
        Me.LblNomPago.Name = "LblNomPago"
        Me.LblNomPago.Size = New System.Drawing.Size(170, 26)
        Me.LblNomPago.TabIndex = 6
        Me.LblNomPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(360, 66)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(102, 16)
        Me.LblNombre.TabIndex = 5
        Me.LblNombre.Text = "Nombre pago"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCerrar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_close_22x22
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.Location = New System.Drawing.Point(765, 525)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(0, 12, 20, 20)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(170, 42)
        Me.BtnCerrar.TabIndex = 15
        Me.BtnCerrar.Text = "&Cerrar ventana"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_delete_28x32
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(749, 186)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.BtnEliminar.Size = New System.Drawing.Size(170, 46)
        Me.BtnEliminar.TabIndex = 14
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.GymPaymentControl.My.Resources.Resources.ic_new_24x32
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(749, 28)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(0, 0, 36, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Padding = New System.Windows.Forms.Padding(25, 0, 30, 0)
        Me.BtnNuevo.Size = New System.Drawing.Size(170, 46)
        Me.BtnNuevo.TabIndex = 10
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_save_28x28
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(749, 28)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(25, 0, 25, 0)
        Me.BtnGuardar.Size = New System.Drawing.Size(170, 46)
        Me.BtnGuardar.TabIndex = 16
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        Me.BtnGuardar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_update_28x27
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(749, 28)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.BtnActualizar.Size = New System.Drawing.Size(170, 46)
        Me.BtnActualizar.TabIndex = 11
        Me.BtnActualizar.Text = "&Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_cancel_28x28
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(749, 114)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.BtnCancelar.Size = New System.Drawing.Size(170, 46)
        Me.BtnCancelar.TabIndex = 13
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        Me.BtnCancelar.Visible = False
        '
        'FrmDiscountTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 596)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.DgvTabla)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmDiscountTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TABLA DE PRECIOS Y DESCUENTOS"
        CType(Me.DgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.NudEdadMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudEdadMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudNumPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnModificar As Button
    Friend WithEvents DgvTabla As DataGridView
    Friend WithEvents ColId As DataGridViewTextBoxColumn
    Friend WithEvents ColTipoPago As DataGridViewTextBoxColumn
    Friend WithEvents ColPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ColEdadMin As DataGridViewTextBoxColumn
    Friend WithEvents ColEdadMax As DataGridViewTextBoxColumn
    Friend WithEvents ColNumPerson As DataGridViewTextBoxColumn
    Friend WithEvents ColTotal As DataGridViewTextBoxColumn
    Friend WithEvents ColDscto As DataGridViewTextBoxColumn
    Friend WithEvents ColApagar As DataGridViewTextBoxColumn
    Friend WithEvents Panel As Panel
    Friend WithEvents TxtApagar As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LblPrecio As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents LblTipo As Label
    Friend WithEvents CmbTipoPago As ComboBox
    Friend WithEvents TxtDscnto As TextBox
    Friend WithEvents LblApagar As Label
    Friend WithEvents LblDscto As Label
    Friend WithEvents NudEdadMax As NumericUpDown
    Friend WithEvents LblMax As Label
    Friend WithEvents LblNumPerson As Label
    Friend WithEvents NudEdadMin As NumericUpDown
    Friend WithEvents NudNumPerson As NumericUpDown
    Friend WithEvents LblMin As Label
    Friend WithEvents LblNomPago As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnCancelar As Button
End Class
