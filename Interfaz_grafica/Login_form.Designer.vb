<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.User_box = New System.Windows.Forms.TextBox()
        Me.Pass_box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Login_btn = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'User_box
        '
        Me.User_box.Font = New System.Drawing.Font("Gabriola", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_box.Location = New System.Drawing.Point(189, 41)
        Me.User_box.Name = "User_box"
        Me.User_box.Size = New System.Drawing.Size(290, 53)
        Me.User_box.TabIndex = 1
        '
        'Pass_box
        '
        Me.Pass_box.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass_box.Location = New System.Drawing.Point(189, 121)
        Me.Pass_box.Multiline = True
        Me.Pass_box.Name = "Pass_box"
        Me.Pass_box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pass_box.Size = New System.Drawing.Size(290, 53)
        Me.Pass_box.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 59)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'Login_btn
        '
        Me.Login_btn.BackColor = System.Drawing.Color.Honeydew
        Me.Login_btn.Font = New System.Drawing.Font("Gabriola", 24.0!)
        Me.Login_btn.Location = New System.Drawing.Point(111, 210)
        Me.Login_btn.Name = "Login_btn"
        Me.Login_btn.Size = New System.Drawing.Size(136, 63)
        Me.Login_btn.TabIndex = 4
        Me.Login_btn.Text = "Ingresar"
        Me.Login_btn.UseVisualStyleBackColor = False
        '
        'Exit_btn
        '
        Me.Exit_btn.BackColor = System.Drawing.Color.Honeydew
        Me.Exit_btn.Font = New System.Drawing.Font("Gabriola", 24.0!)
        Me.Exit_btn.Location = New System.Drawing.Point(292, 210)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(136, 63)
        Me.Exit_btn.TabIndex = 5
        Me.Exit_btn.Text = "Salir"
        Me.Exit_btn.UseVisualStyleBackColor = False
        '
        'Login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(541, 296)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Login_btn)
        Me.Controls.Add(Me.Pass_box)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.User_box)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login_form"
        Me.Text = "Solicitud de credenciales de usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents User_box As TextBox
    Friend WithEvents Pass_box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Login_btn As Button
    Friend WithEvents Exit_btn As Button
End Class
