<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserPassword
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
        Me.TxtContrasena2 = New System.Windows.Forms.TextBox()
        Me.LblRepite = New System.Windows.Forms.Label()
        Me.TxtContrasena1 = New System.Windows.Forms.TextBox()
        Me.LblUsuario2 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.GbGuardarContrasena = New System.Windows.Forms.GroupBox()
        Me.LblIngresa = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblContrasena = New System.Windows.Forms.Label()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GbUsuarioContrasena = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.GbGuardarContrasena.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GbUsuarioContrasena.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtContrasena2
        '
        Me.TxtContrasena2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena2.Location = New System.Drawing.Point(23, 149)
        Me.TxtContrasena2.Margin = New System.Windows.Forms.Padding(30)
        Me.TxtContrasena2.Name = "TxtContrasena2"
        Me.TxtContrasena2.Size = New System.Drawing.Size(304, 26)
        Me.TxtContrasena2.TabIndex = 1
        Me.TxtContrasena2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblRepite
        '
        Me.LblRepite.AutoSize = True
        Me.LblRepite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRepite.Location = New System.Drawing.Point(20, 123)
        Me.LblRepite.Name = "LblRepite"
        Me.LblRepite.Size = New System.Drawing.Size(148, 18)
        Me.LblRepite.TabIndex = 3
        Me.LblRepite.Text = "&Repite Contraseña"
        '
        'TxtContrasena1
        '
        Me.TxtContrasena1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena1.Location = New System.Drawing.Point(23, 86)
        Me.TxtContrasena1.Margin = New System.Windows.Forms.Padding(30)
        Me.TxtContrasena1.Name = "TxtContrasena1"
        Me.TxtContrasena1.Size = New System.Drawing.Size(304, 26)
        Me.TxtContrasena1.TabIndex = 0
        Me.TxtContrasena1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblUsuario2
        '
        Me.LblUsuario2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblUsuario2.Location = New System.Drawing.Point(3, 25)
        Me.LblUsuario2.Name = "LblUsuario2"
        Me.LblUsuario2.Size = New System.Drawing.Size(344, 18)
        Me.LblUsuario2.TabIndex = 0
        Me.LblUsuario2.Text = "LblUsuario2"
        Me.LblUsuario2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Brown
        Me.BtnCancelar.Location = New System.Drawing.Point(207, 23)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(120, 30)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "C&ancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.Location = New System.Drawing.Point(23, 23)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(170, 30)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "&Guardar contraseña"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Controls.Add(Me.BtnGuardar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel2.Size = New System.Drawing.Size(350, 76)
        Me.Panel2.TabIndex = 7
        '
        'BtnIniciar
        '
        Me.BtnIniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIniciar.Location = New System.Drawing.Point(23, 23)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(130, 30)
        Me.BtnIniciar.TabIndex = 2
        Me.BtnIniciar.Text = "&Iniciar sesión"
        Me.BtnIniciar.UseVisualStyleBackColor = True
        '
        'GbGuardarContrasena
        '
        Me.GbGuardarContrasena.Controls.Add(Me.Panel2)
        Me.GbGuardarContrasena.Controls.Add(Me.TxtContrasena2)
        Me.GbGuardarContrasena.Controls.Add(Me.LblRepite)
        Me.GbGuardarContrasena.Controls.Add(Me.TxtContrasena1)
        Me.GbGuardarContrasena.Controls.Add(Me.LblIngresa)
        Me.GbGuardarContrasena.Controls.Add(Me.LblUsuario2)
        Me.GbGuardarContrasena.Location = New System.Drawing.Point(272, 34)
        Me.GbGuardarContrasena.Margin = New System.Windows.Forms.Padding(16, 32, 32, 32)
        Me.GbGuardarContrasena.Name = "GbGuardarContrasena"
        Me.GbGuardarContrasena.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.GbGuardarContrasena.Size = New System.Drawing.Size(350, 277)
        Me.GbGuardarContrasena.TabIndex = 1
        Me.GbGuardarContrasena.TabStop = False
        Me.GbGuardarContrasena.Visible = False
        '
        'LblIngresa
        '
        Me.LblIngresa.AutoSize = True
        Me.LblIngresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresa.Location = New System.Drawing.Point(20, 60)
        Me.LblIngresa.Name = "LblIngresa"
        Me.LblIngresa.Size = New System.Drawing.Size(152, 18)
        Me.LblIngresa.TabIndex = 1
        Me.LblIngresa.Text = "&Ingresa contraseña"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Brown
        Me.BtnCerrar.Location = New System.Drawing.Point(197, 23)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(130, 30)
        Me.BtnCerrar.TabIndex = 3
        Me.BtnCerrar.Text = "Cerrar &App"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(19, 33)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(152, 18)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "&Nombre de usuario"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(23, 65)
        Me.TxtUsuario.MaxLength = 50
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(304, 26)
        Me.TxtUsuario.TabIndex = 0
        Me.TxtUsuario.Text = "A"
        '
        'LblContrasena
        '
        Me.LblContrasena.AutoSize = True
        Me.LblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContrasena.Location = New System.Drawing.Point(19, 117)
        Me.LblContrasena.Name = "LblContrasena"
        Me.LblContrasena.Size = New System.Drawing.Size(95, 18)
        Me.LblContrasena.TabIndex = 2
        Me.LblContrasena.Text = "&Contraseña"
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(23, 149)
        Me.TxtContrasena.MaxLength = 50
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(172)
        Me.TxtContrasena.Size = New System.Drawing.Size(304, 26)
        Me.TxtContrasena.TabIndex = 1
        Me.TxtContrasena.Text = "a"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnIniciar)
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Location = New System.Drawing.Point(0, 201)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel1.Size = New System.Drawing.Size(350, 76)
        Me.Panel1.TabIndex = 6
        '
        'GbUsuarioContrasena
        '
        Me.GbUsuarioContrasena.Controls.Add(Me.LblUsuario)
        Me.GbUsuarioContrasena.Controls.Add(Me.TxtUsuario)
        Me.GbUsuarioContrasena.Controls.Add(Me.LblContrasena)
        Me.GbUsuarioContrasena.Controls.Add(Me.TxtContrasena)
        Me.GbUsuarioContrasena.Controls.Add(Me.Panel1)
        Me.GbUsuarioContrasena.Location = New System.Drawing.Point(272, 34)
        Me.GbUsuarioContrasena.Margin = New System.Windows.Forms.Padding(16, 32, 32, 32)
        Me.GbUsuarioContrasena.Name = "GbUsuarioContrasena"
        Me.GbUsuarioContrasena.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.GbUsuarioContrasena.Size = New System.Drawing.Size(350, 277)
        Me.GbUsuarioContrasena.TabIndex = 0
        Me.GbUsuarioContrasena.TabStop = False
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.GymPaymentControl.My.Resources.Resources.img_user_password
        Me.PictureBox.Location = New System.Drawing.Point(41, 41)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(32, 32, 0, 32)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(215, 270)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 10
        Me.PictureBox.TabStop = False
        '
        'FrmUserPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 352)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.GbUsuarioContrasena)
        Me.Controls.Add(Me.GbGuardarContrasena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUserPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE ACCESO"
        Me.Panel2.ResumeLayout(False)
        Me.GbGuardarContrasena.ResumeLayout(False)
        Me.GbGuardarContrasena.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GbUsuarioContrasena.ResumeLayout(False)
        Me.GbUsuarioContrasena.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtContrasena2 As TextBox
    Friend WithEvents LblRepite As Label
    Friend WithEvents TxtContrasena1 As TextBox
    Friend WithEvents LblUsuario2 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents GbGuardarContrasena As GroupBox
    Friend WithEvents LblIngresa As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LblUsuario As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents LblContrasena As Label
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GbUsuarioContrasena As GroupBox
    Friend WithEvents PictureBox As PictureBox
End Class
