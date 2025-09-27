<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.PnlBotonera = New System.Windows.Forms.Panel()
        Me.BtnClientesPagos = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.BtnPrecioDsctos = New System.Windows.Forms.Button()
        Me.BtnPagoPendiente = New System.Windows.Forms.Button()
        Me.BtnListaClientes = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PnlBotonera.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBotonera
        '
        Me.PnlBotonera.AutoSize = True
        Me.PnlBotonera.Controls.Add(Me.BtnClientesPagos)
        Me.PnlBotonera.Controls.Add(Me.BtnSalir)
        Me.PnlBotonera.Controls.Add(Me.Panel)
        Me.PnlBotonera.Controls.Add(Me.BtnPrecioDsctos)
        Me.PnlBotonera.Controls.Add(Me.BtnPagoPendiente)
        Me.PnlBotonera.Controls.Add(Me.BtnListaClientes)
        Me.PnlBotonera.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlBotonera.Location = New System.Drawing.Point(0, 0)
        Me.PnlBotonera.Name = "PnlBotonera"
        Me.PnlBotonera.Size = New System.Drawing.Size(186, 561)
        Me.PnlBotonera.TabIndex = 1
        '
        'BtnClientesPagos
        '
        Me.BtnClientesPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientesPagos.Image = Global.GymPaymentControl.My.Resources.Resources.ic_client_37x35
        Me.BtnClientesPagos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClientesPagos.Location = New System.Drawing.Point(3, 108)
        Me.BtnClientesPagos.Name = "BtnClientesPagos"
        Me.BtnClientesPagos.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnClientesPagos.Size = New System.Drawing.Size(180, 74)
        Me.BtnClientesPagos.TabIndex = 4
        Me.BtnClientesPagos.Text = "Clientes JUNTO"
        Me.BtnClientesPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClientesPagos.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel.Location = New System.Drawing.Point(0, 535)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(186, 26)
        Me.Panel.TabIndex = 1
        '
        'BtnPrecioDsctos
        '
        Me.BtnPrecioDsctos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrecioDsctos.Image = Global.GymPaymentControl.My.Resources.Resources.ic_rate_discount_45x33
        Me.BtnPrecioDsctos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPrecioDsctos.Location = New System.Drawing.Point(3, 369)
        Me.BtnPrecioDsctos.Name = "BtnPrecioDsctos"
        Me.BtnPrecioDsctos.Padding = New System.Windows.Forms.Padding(0, 6, 0, 5)
        Me.BtnPrecioDsctos.Size = New System.Drawing.Size(180, 74)
        Me.BtnPrecioDsctos.TabIndex = 2
        Me.BtnPrecioDsctos.Text = "&Precio y Descuentos"
        Me.BtnPrecioDsctos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrecioDsctos.UseVisualStyleBackColor = True
        '
        'BtnPagoPendiente
        '
        Me.BtnPagoPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagoPendiente.Image = Global.GymPaymentControl.My.Resources.Resources.ic_defaulters_35x35
        Me.BtnPagoPendiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPagoPendiente.Location = New System.Drawing.Point(3, 207)
        Me.BtnPagoPendiente.Name = "BtnPagoPendiente"
        Me.BtnPagoPendiente.Padding = New System.Windows.Forms.Padding(0, 6, 0, 5)
        Me.BtnPagoPendiente.Size = New System.Drawing.Size(180, 74)
        Me.BtnPagoPendiente.TabIndex = 1
        Me.BtnPagoPendiente.Text = "Pagos pendientes"
        Me.BtnPagoPendiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPagoPendiente.UseVisualStyleBackColor = True
        '
        'BtnListaClientes
        '
        Me.BtnListaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListaClientes.Image = Global.GymPaymentControl.My.Resources.Resources.ic_client_37x35
        Me.BtnListaClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnListaClientes.Location = New System.Drawing.Point(3, 12)
        Me.BtnListaClientes.Name = "BtnListaClientes"
        Me.BtnListaClientes.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.BtnListaClientes.Size = New System.Drawing.Size(180, 74)
        Me.BtnListaClientes.TabIndex = 0
        Me.BtnListaClientes.Text = "Clientes SEPARADO"
        Me.BtnListaClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnListaClientes.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.GymPaymentControl.My.Resources.Resources.ic_go_out_34x31
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.Location = New System.Drawing.Point(0, 461)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Padding = New System.Windows.Forms.Padding(0, 6, 0, 2)
        Me.BtnSalir.Size = New System.Drawing.Size(186, 74)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "CERRAR &APP"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.PnlBotonera)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1200, 500)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gimnasio Segundos Fuera   -   USUARIO  : :  "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlBotonera.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlBotonera As Panel
    Friend WithEvents BtnClientesPagos As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Panel As Panel
    Friend WithEvents BtnPrecioDsctos As Button
    Friend WithEvents BtnPagoPendiente As Button
    Friend WithEvents BtnListaClientes As Button
End Class
