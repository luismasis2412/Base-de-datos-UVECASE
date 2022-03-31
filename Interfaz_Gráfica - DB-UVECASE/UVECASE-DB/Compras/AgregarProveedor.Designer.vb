<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProveedor
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
        Me.RazonTbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CedTbox = New System.Windows.Forms.TextBox()
        Me.Tel1Tbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EmailTbox = New System.Windows.Forms.TextBox()
        Me.WebTbox = New System.Windows.Forms.TextBox()
        Me.Tel2Tbox = New System.Windows.Forms.TextBox()
        Me.FaxTbox = New System.Windows.Forms.TextBox()
        Me.AgregaPBt = New System.Windows.Forms.Button()
        Me.OutAgreBt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RazonTbox
        '
        Me.RazonTbox.Font = New System.Drawing.Font("Gabriola", 12.75!)
        Me.RazonTbox.Location = New System.Drawing.Point(183, 36)
        Me.RazonTbox.Margin = New System.Windows.Forms.Padding(4)
        Me.RazonTbox.Name = "RazonTbox"
        Me.RazonTbox.Size = New System.Drawing.Size(260, 44)
        Me.RazonTbox.TabIndex = 8
        Me.RazonTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gabriola", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Razón Social:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(13, 127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Teléfonos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(13, 213)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 40)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Correo electrónico:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gabriola", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(13, 296)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 40)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Página web:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gabriola", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(454, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 40)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Ced:"
        '
        'CedTbox
        '
        Me.CedTbox.Font = New System.Drawing.Font("Gabriola", 12.75!)
        Me.CedTbox.Location = New System.Drawing.Point(514, 33)
        Me.CedTbox.Margin = New System.Windows.Forms.Padding(4)
        Me.CedTbox.Name = "CedTbox"
        Me.CedTbox.Size = New System.Drawing.Size(260, 44)
        Me.CedTbox.TabIndex = 14
        Me.CedTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tel1Tbox
        '
        Me.Tel1Tbox.Font = New System.Drawing.Font("Gabriola", 12.75!)
        Me.Tel1Tbox.Location = New System.Drawing.Point(183, 123)
        Me.Tel1Tbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Tel1Tbox.Name = "Tel1Tbox"
        Me.Tel1Tbox.Size = New System.Drawing.Size(152, 44)
        Me.Tel1Tbox.TabIndex = 15
        Me.Tel1Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gabriola", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(565, 126)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 40)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Fax:"
        '
        'EmailTbox
        '
        Me.EmailTbox.Font = New System.Drawing.Font("Gabriola", 12.75!)
        Me.EmailTbox.Location = New System.Drawing.Point(183, 210)
        Me.EmailTbox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailTbox.Name = "EmailTbox"
        Me.EmailTbox.Size = New System.Drawing.Size(260, 44)
        Me.EmailTbox.TabIndex = 19
        Me.EmailTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WebTbox
        '
        Me.WebTbox.Font = New System.Drawing.Font("Gabriola", 12.75!)
        Me.WebTbox.Location = New System.Drawing.Point(183, 293)
        Me.WebTbox.Margin = New System.Windows.Forms.Padding(4)
        Me.WebTbox.Name = "WebTbox"
        Me.WebTbox.Size = New System.Drawing.Size(260, 44)
        Me.WebTbox.TabIndex = 20
        Me.WebTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tel2Tbox
        '
        Me.Tel2Tbox.Font = New System.Drawing.Font("Gabriola", 12.75!)
        Me.Tel2Tbox.Location = New System.Drawing.Point(379, 124)
        Me.Tel2Tbox.Margin = New System.Windows.Forms.Padding(4)
        Me.Tel2Tbox.Name = "Tel2Tbox"
        Me.Tel2Tbox.Size = New System.Drawing.Size(152, 44)
        Me.Tel2Tbox.TabIndex = 21
        Me.Tel2Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FaxTbox
        '
        Me.FaxTbox.Font = New System.Drawing.Font("Gabriola", 12.75!)
        Me.FaxTbox.Location = New System.Drawing.Point(622, 123)
        Me.FaxTbox.Margin = New System.Windows.Forms.Padding(4)
        Me.FaxTbox.Name = "FaxTbox"
        Me.FaxTbox.Size = New System.Drawing.Size(152, 44)
        Me.FaxTbox.TabIndex = 22
        Me.FaxTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AgregaPBt
        '
        Me.AgregaPBt.Font = New System.Drawing.Font("Gabriola", 12.75!, System.Drawing.FontStyle.Bold)
        Me.AgregaPBt.Location = New System.Drawing.Point(561, 210)
        Me.AgregaPBt.Name = "AgregaPBt"
        Me.AgregaPBt.Size = New System.Drawing.Size(213, 48)
        Me.AgregaPBt.TabIndex = 62
        Me.AgregaPBt.Text = "Agregar"
        Me.AgregaPBt.UseVisualStyleBackColor = True
        '
        'OutAgreBt
        '
        Me.OutAgreBt.Font = New System.Drawing.Font("Gabriola", 12.75!, System.Drawing.FontStyle.Bold)
        Me.OutAgreBt.Location = New System.Drawing.Point(561, 292)
        Me.OutAgreBt.Name = "OutAgreBt"
        Me.OutAgreBt.Size = New System.Drawing.Size(213, 48)
        Me.OutAgreBt.TabIndex = 63
        Me.OutAgreBt.Text = "Salir"
        Me.OutAgreBt.UseVisualStyleBackColor = True
        '
        'AgregarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(800, 373)
        Me.Controls.Add(Me.OutAgreBt)
        Me.Controls.Add(Me.AgregaPBt)
        Me.Controls.Add(Me.FaxTbox)
        Me.Controls.Add(Me.Tel2Tbox)
        Me.Controls.Add(Me.WebTbox)
        Me.Controls.Add(Me.EmailTbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tel1Tbox)
        Me.Controls.Add(Me.CedTbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RazonTbox)
        Me.Name = "AgregarProveedor"
        Me.Text = "Agregar Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RazonTbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CedTbox As TextBox
    Friend WithEvents Tel1Tbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EmailTbox As TextBox
    Friend WithEvents WebTbox As TextBox
    Friend WithEvents Tel2Tbox As TextBox
    Friend WithEvents FaxTbox As TextBox
    Friend WithEvents AgregaPBt As Button
    Friend WithEvents OutAgreBt As Button
End Class
