<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFamilyGroup
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblNumIntgrntes = New System.Windows.Forms.Label()
        Me.NudNumIntgrntes = New System.Windows.Forms.NumericUpDown()
        Me.TxtListNomGrupo = New System.Windows.Forms.TextBox()
        Me.LblBuscarIntgrntes = New System.Windows.Forms.Label()
        Me.TxtBscrIntgrntes = New System.Windows.Forms.TextBox()
        Me.DgvBscrIntgrntes = New System.Windows.Forms.DataGridView()
        Me.ColBidCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBnomApeCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIdGrpBscr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlGrpFamiliar = New System.Windows.Forms.Panel()
        Me.Lblidgrp = New System.Windows.Forms.Label()
        Me.ChkGrpVacioNombre = New System.Windows.Forms.CheckBox()
        Me.Lblidcli = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvListIntgrntes = New System.Windows.Forms.DataGridView()
        Me.ColIdCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNomApeCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIdGrp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblNomGrupo = New System.Windows.Forms.Label()
        Me.LblIntegrantes = New System.Windows.Forms.Label()
        Me.DgvListNomGrupo = New System.Windows.Forms.DataGridView()
        Me.ColIdGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNomGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNumIntgrntes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.PicIntgrntes = New System.Windows.Forms.PictureBox()
        Me.BtnQuitarElmnto = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnDeleteGroup = New System.Windows.Forms.Button()
        CType(Me.NudNumIntgrntes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvBscrIntgrntes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGrpFamiliar.SuspendLayout()
        CType(Me.DgvListIntgrntes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListNomGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicIntgrntes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNumIntgrntes
        '
        Me.LblNumIntgrntes.BackColor = System.Drawing.SystemColors.Control
        Me.LblNumIntgrntes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumIntgrntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumIntgrntes.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNumIntgrntes.Location = New System.Drawing.Point(393, 42)
        Me.LblNumIntgrntes.Margin = New System.Windows.Forms.Padding(0)
        Me.LblNumIntgrntes.Name = "LblNumIntgrntes"
        Me.LblNumIntgrntes.Size = New System.Drawing.Size(70, 26)
        Me.LblNumIntgrntes.TabIndex = 0
        Me.LblNumIntgrntes.Text = "0 DE 0"
        Me.LblNumIntgrntes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NudNumIntgrntes
        '
        Me.NudNumIntgrntes.BackColor = System.Drawing.SystemColors.Control
        Me.NudNumIntgrntes.Enabled = False
        Me.NudNumIntgrntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudNumIntgrntes.ForeColor = System.Drawing.SystemColors.Control
        Me.NudNumIntgrntes.Location = New System.Drawing.Point(320, 42)
        Me.NudNumIntgrntes.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.NudNumIntgrntes.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.NudNumIntgrntes.Name = "NudNumIntgrntes"
        Me.NudNumIntgrntes.Size = New System.Drawing.Size(70, 26)
        Me.NudNumIntgrntes.TabIndex = 1
        Me.NudNumIntgrntes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtListNomGrupo
        '
        Me.TxtListNomGrupo.BackColor = System.Drawing.SystemColors.Control
        Me.TxtListNomGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtListNomGrupo.Enabled = False
        Me.TxtListNomGrupo.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtListNomGrupo.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtListNomGrupo.Location = New System.Drawing.Point(23, 42)
        Me.TxtListNomGrupo.Margin = New System.Windows.Forms.Padding(20, 6, 10, 0)
        Me.TxtListNomGrupo.MaxLength = 30
        Me.TxtListNomGrupo.Name = "TxtListNomGrupo"
        Me.TxtListNomGrupo.Size = New System.Drawing.Size(287, 26)
        Me.TxtListNomGrupo.TabIndex = 0
        Me.TxtListNomGrupo.WordWrap = False
        '
        'LblBuscarIntgrntes
        '
        Me.LblBuscarIntgrntes.AutoSize = True
        Me.LblBuscarIntgrntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarIntgrntes.Location = New System.Drawing.Point(20, 121)
        Me.LblBuscarIntgrntes.Margin = New System.Windows.Forms.Padding(0, 16, 0, 0)
        Me.LblBuscarIntgrntes.Name = "LblBuscarIntgrntes"
        Me.LblBuscarIntgrntes.Size = New System.Drawing.Size(171, 16)
        Me.LblBuscarIntgrntes.TabIndex = 3
        Me.LblBuscarIntgrntes.Text = "Buscar integrante del grupo"
        Me.LblBuscarIntgrntes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBscrIntgrntes
        '
        Me.TxtBscrIntgrntes.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBscrIntgrntes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBscrIntgrntes.Enabled = False
        Me.TxtBscrIntgrntes.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBscrIntgrntes.ForeColor = System.Drawing.Color.MediumBlue
        Me.TxtBscrIntgrntes.Location = New System.Drawing.Point(23, 143)
        Me.TxtBscrIntgrntes.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.TxtBscrIntgrntes.MaxLength = 30
        Me.TxtBscrIntgrntes.Name = "TxtBscrIntgrntes"
        Me.TxtBscrIntgrntes.Size = New System.Drawing.Size(440, 26)
        Me.TxtBscrIntgrntes.TabIndex = 4
        Me.TxtBscrIntgrntes.WordWrap = False
        '
        'DgvBscrIntgrntes
        '
        Me.DgvBscrIntgrntes.AllowUserToAddRows = False
        Me.DgvBscrIntgrntes.AllowUserToDeleteRows = False
        Me.DgvBscrIntgrntes.AllowUserToResizeColumns = False
        Me.DgvBscrIntgrntes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvBscrIntgrntes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBscrIntgrntes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvBscrIntgrntes.ColumnHeadersHeight = 4
        Me.DgvBscrIntgrntes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvBscrIntgrntes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColBidCli, Me.ColBnomApeCli, Me.ColIdGrpBscr})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvBscrIntgrntes.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvBscrIntgrntes.Location = New System.Drawing.Point(23, 170)
        Me.DgvBscrIntgrntes.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.DgvBscrIntgrntes.MultiSelect = False
        Me.DgvBscrIntgrntes.Name = "DgvBscrIntgrntes"
        Me.DgvBscrIntgrntes.ReadOnly = True
        Me.DgvBscrIntgrntes.RowHeadersWidth = 4
        Me.DgvBscrIntgrntes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvBscrIntgrntes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvBscrIntgrntes.RowTemplate.DividerHeight = 1
        Me.DgvBscrIntgrntes.RowTemplate.Height = 25
        Me.DgvBscrIntgrntes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvBscrIntgrntes.Size = New System.Drawing.Size(440, 208)
        Me.DgvBscrIntgrntes.TabIndex = 5
        Me.DgvBscrIntgrntes.Visible = False
        '
        'ColBidCli
        '
        Me.ColBidCli.HeaderText = "id_cli"
        Me.ColBidCli.Name = "ColBidCli"
        Me.ColBidCli.ReadOnly = True
        Me.ColBidCli.Visible = False
        '
        'ColBnomApeCli
        '
        Me.ColBnomApeCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColBnomApeCli.HeaderText = ""
        Me.ColBnomApeCli.Name = "ColBnomApeCli"
        Me.ColBnomApeCli.ReadOnly = True
        Me.ColBnomApeCli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColBnomApeCli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColBnomApeCli.Width = 414
        '
        'ColIdGrpBscr
        '
        Me.ColIdGrpBscr.HeaderText = "ColIdGrpBscr"
        Me.ColIdGrpBscr.Name = "ColIdGrpBscr"
        Me.ColIdGrpBscr.ReadOnly = True
        Me.ColIdGrpBscr.Visible = False
        '
        'PnlGrpFamiliar
        '
        Me.PnlGrpFamiliar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlGrpFamiliar.Controls.Add(Me.Lblidgrp)
        Me.PnlGrpFamiliar.Controls.Add(Me.ChkGrpVacioNombre)
        Me.PnlGrpFamiliar.Controls.Add(Me.Lblidcli)
        Me.PnlGrpFamiliar.Controls.Add(Me.PicIntgrntes)
        Me.PnlGrpFamiliar.Controls.Add(Me.BtnQuitarElmnto)
        Me.PnlGrpFamiliar.Controls.Add(Me.Label1)
        Me.PnlGrpFamiliar.Controls.Add(Me.DgvListIntgrntes)
        Me.PnlGrpFamiliar.Controls.Add(Me.LblNomGrupo)
        Me.PnlGrpFamiliar.Controls.Add(Me.LblIntegrantes)
        Me.PnlGrpFamiliar.Controls.Add(Me.LblNumIntgrntes)
        Me.PnlGrpFamiliar.Controls.Add(Me.NudNumIntgrntes)
        Me.PnlGrpFamiliar.Controls.Add(Me.TxtListNomGrupo)
        Me.PnlGrpFamiliar.Controls.Add(Me.LblBuscarIntgrntes)
        Me.PnlGrpFamiliar.Controls.Add(Me.TxtBscrIntgrntes)
        Me.PnlGrpFamiliar.Controls.Add(Me.DgvBscrIntgrntes)
        Me.PnlGrpFamiliar.Controls.Add(Me.DgvListNomGrupo)
        Me.PnlGrpFamiliar.Location = New System.Drawing.Point(29, 29)
        Me.PnlGrpFamiliar.Margin = New System.Windows.Forms.Padding(20, 20, 0, 0)
        Me.PnlGrpFamiliar.Name = "PnlGrpFamiliar"
        Me.PnlGrpFamiliar.Size = New System.Drawing.Size(515, 404)
        Me.PnlGrpFamiliar.TabIndex = 0
        '
        'Lblidgrp
        '
        Me.Lblidgrp.AutoSize = True
        Me.Lblidgrp.Location = New System.Drawing.Point(185, 22)
        Me.Lblidgrp.Name = "Lblidgrp"
        Me.Lblidgrp.Size = New System.Drawing.Size(44, 13)
        Me.Lblidgrp.TabIndex = 8
        Me.Lblidgrp.Text = "Lblidgrp"
        Me.Lblidgrp.Visible = False
        '
        'ChkGrpVacioNombre
        '
        Me.ChkGrpVacioNombre.AutoSize = True
        Me.ChkGrpVacioNombre.Enabled = False
        Me.ChkGrpVacioNombre.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGrpVacioNombre.Location = New System.Drawing.Point(33, 80)
        Me.ChkGrpVacioNombre.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.ChkGrpVacioNombre.Name = "ChkGrpVacioNombre"
        Me.ChkGrpVacioNombre.Size = New System.Drawing.Size(15, 14)
        Me.ChkGrpVacioNombre.TabIndex = 3
        Me.ChkGrpVacioNombre.UseVisualStyleBackColor = True
        '
        'Lblidcli
        '
        Me.Lblidcli.AutoSize = True
        Me.Lblidcli.Location = New System.Drawing.Point(466, 203)
        Me.Lblidcli.Name = "Lblidcli"
        Me.Lblidcli.Size = New System.Drawing.Size(39, 13)
        Me.Lblidcli.TabIndex = 7
        Me.Lblidcli.Text = "Lblidcli"
        Me.Lblidcli.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 181)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lista de los integrantes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DgvListIntgrntes
        '
        Me.DgvListIntgrntes.AllowUserToAddRows = False
        Me.DgvListIntgrntes.AllowUserToDeleteRows = False
        Me.DgvListIntgrntes.AllowUserToResizeColumns = False
        Me.DgvListIntgrntes.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListIntgrntes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvListIntgrntes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvListIntgrntes.ColumnHeadersHeight = 30
        Me.DgvListIntgrntes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListIntgrntes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdCli, Me.ColNomApeCli, Me.ColIdGrp})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvListIntgrntes.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgvListIntgrntes.Enabled = False
        Me.DgvListIntgrntes.Location = New System.Drawing.Point(23, 203)
        Me.DgvListIntgrntes.Margin = New System.Windows.Forms.Padding(0, 6, 0, 20)
        Me.DgvListIntgrntes.MultiSelect = False
        Me.DgvListIntgrntes.Name = "DgvListIntgrntes"
        Me.DgvListIntgrntes.ReadOnly = True
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvListIntgrntes.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvListIntgrntes.RowHeadersWidth = 4
        Me.DgvListIntgrntes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListIntgrntes.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvListIntgrntes.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListIntgrntes.RowTemplate.DividerHeight = 2
        Me.DgvListIntgrntes.RowTemplate.Height = 30
        Me.DgvListIntgrntes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListIntgrntes.Size = New System.Drawing.Size(440, 175)
        Me.DgvListIntgrntes.TabIndex = 6
        '
        'ColIdCli
        '
        Me.ColIdCli.HeaderText = "idCli"
        Me.ColIdCli.Name = "ColIdCli"
        Me.ColIdCli.ReadOnly = True
        Me.ColIdCli.Visible = False
        '
        'ColNomApeCli
        '
        Me.ColNomApeCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColNomApeCli.HeaderText = "Nombre y Apellido"
        Me.ColNomApeCli.Name = "ColNomApeCli"
        Me.ColNomApeCli.ReadOnly = True
        Me.ColNomApeCli.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColNomApeCli.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNomApeCli.Width = 414
        '
        'ColIdGrp
        '
        Me.ColIdGrp.HeaderText = "ColIdGrp"
        Me.ColIdGrp.Name = "ColIdGrp"
        Me.ColIdGrp.ReadOnly = True
        Me.ColIdGrp.Visible = False
        '
        'LblNomGrupo
        '
        Me.LblNomGrupo.AutoSize = True
        Me.LblNomGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomGrupo.Location = New System.Drawing.Point(20, 20)
        Me.LblNomGrupo.Margin = New System.Windows.Forms.Padding(20, 20, 0, 0)
        Me.LblNomGrupo.Name = "LblNomGrupo"
        Me.LblNomGrupo.Size = New System.Drawing.Size(162, 16)
        Me.LblNomGrupo.TabIndex = 1
        Me.LblNomGrupo.Text = "Nombre del grupo familiar"
        '
        'LblIntegrantes
        '
        Me.LblIntegrantes.AutoSize = True
        Me.LblIntegrantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIntegrantes.Location = New System.Drawing.Point(320, 20)
        Me.LblIntegrantes.Margin = New System.Windows.Forms.Padding(0)
        Me.LblIntegrantes.Name = "LblIntegrantes"
        Me.LblIntegrantes.Size = New System.Drawing.Size(143, 16)
        Me.LblIntegrantes.TabIndex = 2
        Me.LblIntegrantes.Text = "Número de integrantes"
        Me.LblIntegrantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DgvListNomGrupo
        '
        Me.DgvListNomGrupo.AllowUserToAddRows = False
        Me.DgvListNomGrupo.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListNomGrupo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListNomGrupo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvListNomGrupo.ColumnHeadersHeight = 4
        Me.DgvListNomGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvListNomGrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColIdGrupo, Me.ColNomGrupo, Me.ColNumIntgrntes})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvListNomGrupo.DefaultCellStyle = DataGridViewCellStyle11
        Me.DgvListNomGrupo.Location = New System.Drawing.Point(23, 69)
        Me.DgvListNomGrupo.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.DgvListNomGrupo.MultiSelect = False
        Me.DgvListNomGrupo.Name = "DgvListNomGrupo"
        Me.DgvListNomGrupo.ReadOnly = True
        Me.DgvListNomGrupo.RowHeadersWidth = 4
        Me.DgvListNomGrupo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvListNomGrupo.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvListNomGrupo.RowTemplate.DividerHeight = 1
        Me.DgvListNomGrupo.RowTemplate.Height = 25
        Me.DgvListNomGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvListNomGrupo.Size = New System.Drawing.Size(440, 309)
        Me.DgvListNomGrupo.TabIndex = 2
        Me.DgvListNomGrupo.Visible = False
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
        Me.ColNomGrupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColNomGrupo.HeaderText = ""
        Me.ColNomGrupo.Name = "ColNomGrupo"
        Me.ColNomGrupo.ReadOnly = True
        Me.ColNomGrupo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColNomGrupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColNomGrupo.Width = 414
        '
        'ColNumIntgrntes
        '
        Me.ColNumIntgrntes.HeaderText = "ColNumIntgrntes"
        Me.ColNumIntgrntes.Name = "ColNumIntgrntes"
        Me.ColNumIntgrntes.ReadOnly = True
        Me.ColNumIntgrntes.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_cancel_28x28
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(564, 114)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(0, 24, 0, 0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Padding = New System.Windows.Forms.Padding(16, 0, 14, 0)
        Me.BtnCancelar.Size = New System.Drawing.Size(150, 45)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        Me.BtnCancelar.Visible = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Brown
        Me.BtnCerrar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_close_22x22
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.Location = New System.Drawing.Point(564, 369)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(0, 0, 20, 20)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.BtnCerrar.Size = New System.Drawing.Size(150, 40)
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.Text = "Cerrar &ventana"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_delete_28x32
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(564, 143)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Padding = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.BtnEliminar.Size = New System.Drawing.Size(150, 45)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'PicIntgrntes
        '
        Me.PicIntgrntes.Location = New System.Drawing.Point(466, 42)
        Me.PicIntgrntes.Name = "PicIntgrntes"
        Me.PicIntgrntes.Size = New System.Drawing.Size(24, 24)
        Me.PicIntgrntes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicIntgrntes.TabIndex = 7
        Me.PicIntgrntes.TabStop = False
        '
        'BtnQuitarElmnto
        '
        Me.BtnQuitarElmnto.Enabled = False
        Me.BtnQuitarElmnto.FlatAppearance.BorderSize = 0
        Me.BtnQuitarElmnto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuitarElmnto.Image = Global.GymPaymentControl.My.Resources.Resources.ic_remove_30x30
        Me.BtnQuitarElmnto.Location = New System.Drawing.Point(466, 235)
        Me.BtnQuitarElmnto.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.BtnQuitarElmnto.Name = "BtnQuitarElmnto"
        Me.BtnQuitarElmnto.Size = New System.Drawing.Size(35, 35)
        Me.BtnQuitarElmnto.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.BtnQuitarElmnto, "QUITAR FAMILIAR DE LA LISTA")
        Me.BtnQuitarElmnto.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_modify_28x32
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(564, 86)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Padding = New System.Windows.Forms.Padding(16, 0, 14, 0)
        Me.BtnModificar.Size = New System.Drawing.Size(150, 45)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "&Modificar"
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.GymPaymentControl.My.Resources.Resources.ic_new_24x32
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(564, 29)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Padding = New System.Windows.Forms.Padding(22, 0, 22, 0)
        Me.BtnNuevo.Size = New System.Drawing.Size(150, 45)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_save_28x28
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(564, 29)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(18, 0, 16, 0)
        Me.BtnGuardar.Size = New System.Drawing.Size(150, 45)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        Me.BtnGuardar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Enabled = False
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Image = Global.GymPaymentControl.My.Resources.Resources.ic_update_28x27
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(564, 29)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Padding = New System.Windows.Forms.Padding(13, 0, 12, 0)
        Me.BtnActualizar.Size = New System.Drawing.Size(150, 45)
        Me.BtnActualizar.TabIndex = 5
        Me.BtnActualizar.Text = "&Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'BtnDeleteGroup
        '
        Me.BtnDeleteGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteGroup.Image = Global.GymPaymentControl.My.Resources.Resources.ic_family_group_53x30
        Me.BtnDeleteGroup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDeleteGroup.Location = New System.Drawing.Point(564, 29)
        Me.BtnDeleteGroup.Margin = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.BtnDeleteGroup.Name = "BtnDeleteGroup"
        Me.BtnDeleteGroup.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnDeleteGroup.Size = New System.Drawing.Size(150, 70)
        Me.BtnDeleteGroup.TabIndex = 6
        Me.BtnDeleteGroup.Text = "&Eliminar grupo"
        Me.BtnDeleteGroup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDeleteGroup.UseVisualStyleBackColor = True
        Me.BtnDeleteGroup.Visible = False
        '
        'FrmFamilyGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 462)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.PnlGrpFamiliar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnDeleteGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmFamilyGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR, MODIFICAR O ELIMINAR UN GRUPO FAMILIAR"
        CType(Me.NudNumIntgrntes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvBscrIntgrntes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGrpFamiliar.ResumeLayout(False)
        Me.PnlGrpFamiliar.PerformLayout()
        CType(Me.DgvListIntgrntes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListNomGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicIntgrntes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblNumIntgrntes As Label
    Friend WithEvents NudNumIntgrntes As NumericUpDown
    Friend WithEvents TxtListNomGrupo As TextBox
    Friend WithEvents LblBuscarIntgrntes As Label
    Friend WithEvents TxtBscrIntgrntes As TextBox
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DgvBscrIntgrntes As DataGridView
    Friend WithEvents ColBidCli As DataGridViewTextBoxColumn
    Friend WithEvents ColBnomApeCli As DataGridViewTextBoxColumn
    Friend WithEvents ColIdGrpBscr As DataGridViewTextBoxColumn
    Friend WithEvents PnlGrpFamiliar As Panel
    Friend WithEvents Lblidgrp As Label
    Friend WithEvents ChkGrpVacioNombre As CheckBox
    Friend WithEvents Lblidcli As Label
    Friend WithEvents PicIntgrntes As PictureBox
    Friend WithEvents BtnQuitarElmnto As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvListIntgrntes As DataGridView
    Friend WithEvents ColIdCli As DataGridViewTextBoxColumn
    Friend WithEvents ColNomApeCli As DataGridViewTextBoxColumn
    Friend WithEvents ColIdGrp As DataGridViewTextBoxColumn
    Friend WithEvents LblNomGrupo As Label
    Friend WithEvents LblIntegrantes As Label
    Friend WithEvents DgvListNomGrupo As DataGridView
    Friend WithEvents ColIdGrupo As DataGridViewTextBoxColumn
    Friend WithEvents ColNomGrupo As DataGridViewTextBoxColumn
    Friend WithEvents ColNumIntgrntes As DataGridViewTextBoxColumn
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnDeleteGroup As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
End Class
