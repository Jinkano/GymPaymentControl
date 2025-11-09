<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPresentation
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
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.LblTitulo2 = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblCopyright = New System.Windows.Forms.Label()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.LblTitulo1 = New System.Windows.Forms.Label()
        Me.BarraProgreso = New System.Windows.Forms.ProgressBar()
        Me.LblBarra = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'LblTitulo2
        '
        Me.LblTitulo2.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo2.Font = New System.Drawing.Font("Ink Free", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo2.Location = New System.Drawing.Point(295, 95)
        Me.LblTitulo2.Margin = New System.Windows.Forms.Padding(0)
        Me.LblTitulo2.Name = "LblTitulo2"
        Me.LblTitulo2.Size = New System.Drawing.Size(400, 36)
        Me.LblTitulo2.TabIndex = 19
        Me.LblTitulo2.Text = "Juan Hinostroza Team"
        Me.LblTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(331, 240)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(211, 16)
        Me.LblDescripcion.TabIndex = 18
        Me.LblDescripcion.Text = "Descripción acerca del programa."
        '
        'LblCopyright
        '
        Me.LblCopyright.AutoSize = True
        Me.LblCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCopyright.Location = New System.Drawing.Point(331, 201)
        Me.LblCopyright.Name = "LblCopyright"
        Me.LblCopyright.Size = New System.Drawing.Size(107, 16)
        Me.LblCopyright.TabIndex = 17
        Me.LblCopyright.Text = "Copyright : Jinkis"
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.Location = New System.Drawing.Point(331, 162)
        Me.LblVersion.Margin = New System.Windows.Forms.Padding(0)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(100, 16)
        Me.LblVersion.TabIndex = 16
        Me.LblVersion.Text = "Versión  1.02.01"
        '
        'LblTitulo1
        '
        Me.LblTitulo1.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo1.Location = New System.Drawing.Point(295, 41)
        Me.LblTitulo1.Margin = New System.Windows.Forms.Padding(0)
        Me.LblTitulo1.Name = "LblTitulo1"
        Me.LblTitulo1.Size = New System.Drawing.Size(400, 33)
        Me.LblTitulo1.TabIndex = 15
        Me.LblTitulo1.Text = "Segundos fuera"
        Me.LblTitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BarraProgreso
        '
        Me.BarraProgreso.Location = New System.Drawing.Point(297, 321)
        Me.BarraProgreso.Margin = New System.Windows.Forms.Padding(6, 0, 32, 0)
        Me.BarraProgreso.Name = "BarraProgreso"
        Me.BarraProgreso.Size = New System.Drawing.Size(400, 20)
        Me.BarraProgreso.Step = 2
        Me.BarraProgreso.TabIndex = 21
        '
        'LblBarra
        '
        Me.LblBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarra.Location = New System.Drawing.Point(295, 297)
        Me.LblBarra.Margin = New System.Windows.Forms.Padding(4, 0, 0, 4)
        Me.LblBarra.Name = "LblBarra"
        Me.LblBarra.Size = New System.Drawing.Size(400, 20)
        Me.LblBarra.TabIndex = 20
        Me.LblBarra.Text = "Conectando con la Base de Datos"
        Me.LblBarra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.GymPaymentControl.My.Resources.Resources.juanhc
        Me.PictureBox.Location = New System.Drawing.Point(41, 41)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(32, 32, 0, 32)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(250, 300)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 14
        Me.PictureBox.TabStop = False
        '
        'FrmPresentation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 382)
        Me.Controls.Add(Me.LblTitulo2)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LblCopyright)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.LblTitulo1)
        Me.Controls.Add(Me.BarraProgreso)
        Me.Controls.Add(Me.LblBarra)
        Me.Controls.Add(Me.PictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPresentation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPresentation"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents LblTitulo2 As Label
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblCopyright As Label
    Friend WithEvents LblVersion As Label
    Friend WithEvents LblTitulo1 As Label
    Friend WithEvents BarraProgreso As ProgressBar
    Friend WithEvents LblBarra As Label
    Friend WithEvents PictureBox As PictureBox
End Class
