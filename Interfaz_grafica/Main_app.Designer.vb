<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_app
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_app))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LV_btn = New System.Windows.Forms.Button()
        Me.Gira_btn = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.AV_btn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Evaluar_btn = New System.Windows.Forms.Button()
        Me.Aprob_compra_btn = New System.Windows.Forms.Button()
        Me.Orden_compra_btn = New System.Windows.Forms.Button()
        Me.Sol_compra_btn = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Btn_VerMovimientos = New System.Windows.Forms.Button()
        Me.Btn_ModificarPartidas = New System.Windows.Forms.Button()
        Me.Btn_DigitarPresupuesto = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Btn_ListaVehiculos = New System.Windows.Forms.Button()
        Me.Btn_ControlKm = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Btn_ListaEquipos = New System.Windows.Forms.Button()
        Me.Btn_Calibraciones = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Btn_ModificarPerfil = New System.Windows.Forms.Button()
        Me.Prof_btn = New System.Windows.Forms.Button()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Btn_VerHistorial = New System.Windows.Forms.Button()
        Me.Btn_GenerarReporte = New System.Windows.Forms.Button()
        Me.Btn_AgregarHotel = New System.Windows.Forms.Button()
        Me.Btn_SubirMediciones = New System.Windows.Forms.Button()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Location = New System.Drawing.Point(13, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(790, 400)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImage = Global.UVECASE_DB.My.Resources.Resources.logo_u
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage1.Controls.Add(Me.LV_btn)
        Me.TabPage1.Controls.Add(Me.Gira_btn)
        Me.TabPage1.Controls.Add(Me.Button12)
        Me.TabPage1.Controls.Add(Me.AV_btn)
        Me.TabPage1.Font = New System.Drawing.Font("Kristen ITC", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(782, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Giras"
        '
        'LV_btn
        '
        Me.LV_btn.BackColor = System.Drawing.Color.White
        Me.LV_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LV_btn.FlatAppearance.BorderSize = 2
        Me.LV_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LV_btn.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LV_btn.Location = New System.Drawing.Point(45, 260)
        Me.LV_btn.Name = "LV_btn"
        Me.LV_btn.Size = New System.Drawing.Size(241, 66)
        Me.LV_btn.TabIndex = 7
        Me.LV_btn.Text = "Liquidaciones"
        Me.LV_btn.UseVisualStyleBackColor = False
        '
        'Gira_btn
        '
        Me.Gira_btn.BackColor = System.Drawing.Color.White
        Me.Gira_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Gira_btn.FlatAppearance.BorderSize = 2
        Me.Gira_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gira_btn.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gira_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Gira_btn.Location = New System.Drawing.Point(45, 60)
        Me.Gira_btn.Name = "Gira_btn"
        Me.Gira_btn.Size = New System.Drawing.Size(241, 66)
        Me.Gira_btn.TabIndex = 6
        Me.Gira_btn.Text = "Programación giras"
        Me.Gira_btn.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button12.FlatAppearance.BorderSize = 2
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button12.Location = New System.Drawing.Point(506, 260)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(241, 66)
        Me.Button12.TabIndex = 5
        Me.Button12.Text = "Revisar expediente"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'AV_btn
        '
        Me.AV_btn.BackColor = System.Drawing.Color.White
        Me.AV_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.AV_btn.FlatAppearance.BorderSize = 2
        Me.AV_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AV_btn.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AV_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AV_btn.Location = New System.Drawing.Point(506, 60)
        Me.AV_btn.Name = "AV_btn"
        Me.AV_btn.Size = New System.Drawing.Size(241, 66)
        Me.AV_btn.TabIndex = 4
        Me.AV_btn.Text = "Adelanto de viáticos"
        Me.AV_btn.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = Global.UVECASE_DB.My.Resources.Resources.logo_u
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage2.Controls.Add(Me.Evaluar_btn)
        Me.TabPage2.Controls.Add(Me.Aprob_compra_btn)
        Me.TabPage2.Controls.Add(Me.Orden_compra_btn)
        Me.TabPage2.Controls.Add(Me.Sol_compra_btn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(782, 374)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Compras"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Evaluar_btn
        '
        Me.Evaluar_btn.BackColor = System.Drawing.Color.White
        Me.Evaluar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Evaluar_btn.FlatAppearance.BorderSize = 2
        Me.Evaluar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Evaluar_btn.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Evaluar_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Evaluar_btn.Location = New System.Drawing.Point(506, 260)
        Me.Evaluar_btn.Name = "Evaluar_btn"
        Me.Evaluar_btn.Size = New System.Drawing.Size(241, 66)
        Me.Evaluar_btn.TabIndex = 8
        Me.Evaluar_btn.Text = "Evaluar proveedor"
        Me.Evaluar_btn.UseVisualStyleBackColor = False
        '
        'Aprob_compra_btn
        '
        Me.Aprob_compra_btn.BackColor = System.Drawing.Color.White
        Me.Aprob_compra_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Aprob_compra_btn.FlatAppearance.BorderSize = 2
        Me.Aprob_compra_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aprob_compra_btn.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aprob_compra_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Aprob_compra_btn.Location = New System.Drawing.Point(506, 60)
        Me.Aprob_compra_btn.Name = "Aprob_compra_btn"
        Me.Aprob_compra_btn.Size = New System.Drawing.Size(241, 66)
        Me.Aprob_compra_btn.TabIndex = 7
        Me.Aprob_compra_btn.Text = "Aprobar compra"
        Me.Aprob_compra_btn.UseVisualStyleBackColor = False
        '
        'Orden_compra_btn
        '
        Me.Orden_compra_btn.BackColor = System.Drawing.Color.White
        Me.Orden_compra_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Orden_compra_btn.FlatAppearance.BorderSize = 2
        Me.Orden_compra_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Orden_compra_btn.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orden_compra_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Orden_compra_btn.Location = New System.Drawing.Point(45, 260)
        Me.Orden_compra_btn.Name = "Orden_compra_btn"
        Me.Orden_compra_btn.Size = New System.Drawing.Size(241, 66)
        Me.Orden_compra_btn.TabIndex = 6
        Me.Orden_compra_btn.Text = "Orden de compra"
        Me.Orden_compra_btn.UseVisualStyleBackColor = False
        '
        'Sol_compra_btn
        '
        Me.Sol_compra_btn.BackColor = System.Drawing.Color.White
        Me.Sol_compra_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Sol_compra_btn.FlatAppearance.BorderSize = 2
        Me.Sol_compra_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sol_compra_btn.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sol_compra_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Sol_compra_btn.Location = New System.Drawing.Point(45, 60)
        Me.Sol_compra_btn.Name = "Sol_compra_btn"
        Me.Sol_compra_btn.Size = New System.Drawing.Size(241, 66)
        Me.Sol_compra_btn.TabIndex = 5
        Me.Sol_compra_btn.Text = "Solicitud de compra"
        Me.Sol_compra_btn.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = Global.UVECASE_DB.My.Resources.Resources.logo_u
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage4.Controls.Add(Me.Button8)
        Me.TabPage4.Controls.Add(Me.Btn_VerMovimientos)
        Me.TabPage4.Controls.Add(Me.Btn_ModificarPartidas)
        Me.TabPage4.Controls.Add(Me.Btn_DigitarPresupuesto)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(782, 374)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Presupuesto"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 2
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button8.Location = New System.Drawing.Point(506, 260)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(241, 66)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "Consulta"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Btn_VerMovimientos
        '
        Me.Btn_VerMovimientos.BackColor = System.Drawing.Color.White
        Me.Btn_VerMovimientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_VerMovimientos.FlatAppearance.BorderSize = 2
        Me.Btn_VerMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_VerMovimientos.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_VerMovimientos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_VerMovimientos.Location = New System.Drawing.Point(506, 60)
        Me.Btn_VerMovimientos.Name = "Btn_VerMovimientos"
        Me.Btn_VerMovimientos.Size = New System.Drawing.Size(241, 66)
        Me.Btn_VerMovimientos.TabIndex = 11
        Me.Btn_VerMovimientos.Text = "Ver movimientos"
        Me.Btn_VerMovimientos.UseVisualStyleBackColor = False
        '
        'Btn_ModificarPartidas
        '
        Me.Btn_ModificarPartidas.BackColor = System.Drawing.Color.White
        Me.Btn_ModificarPartidas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_ModificarPartidas.FlatAppearance.BorderSize = 2
        Me.Btn_ModificarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ModificarPartidas.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ModificarPartidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_ModificarPartidas.Location = New System.Drawing.Point(45, 260)
        Me.Btn_ModificarPartidas.Name = "Btn_ModificarPartidas"
        Me.Btn_ModificarPartidas.Size = New System.Drawing.Size(241, 66)
        Me.Btn_ModificarPartidas.TabIndex = 10
        Me.Btn_ModificarPartidas.Text = "Modificar partidas"
        Me.Btn_ModificarPartidas.UseVisualStyleBackColor = False
        '
        'Btn_DigitarPresupuesto
        '
        Me.Btn_DigitarPresupuesto.BackColor = System.Drawing.Color.White
        Me.Btn_DigitarPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_DigitarPresupuesto.FlatAppearance.BorderSize = 2
        Me.Btn_DigitarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_DigitarPresupuesto.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_DigitarPresupuesto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_DigitarPresupuesto.Location = New System.Drawing.Point(45, 60)
        Me.Btn_DigitarPresupuesto.Name = "Btn_DigitarPresupuesto"
        Me.Btn_DigitarPresupuesto.Size = New System.Drawing.Size(241, 66)
        Me.Btn_DigitarPresupuesto.TabIndex = 9
        Me.Btn_DigitarPresupuesto.Text = "Digitar presupuesto"
        Me.Btn_DigitarPresupuesto.UseVisualStyleBackColor = False
        '
        'TabPage5
        '
        Me.TabPage5.BackgroundImage = Global.UVECASE_DB.My.Resources.Resources.logo_u
        Me.TabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage5.Controls.Add(Me.Button3)
        Me.TabPage5.Controls.Add(Me.Button13)
        Me.TabPage5.Controls.Add(Me.Button14)
        Me.TabPage5.Controls.Add(Me.Button15)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(782, 374)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Calidad"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(506, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(241, 66)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Cosa 2"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button13.FlatAppearance.BorderSize = 2
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button13.Location = New System.Drawing.Point(506, 60)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(241, 66)
        Me.Button13.TabIndex = 11
        Me.Button13.Text = "Lista de proveedores"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button14.FlatAppearance.BorderSize = 2
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button14.Location = New System.Drawing.Point(45, 260)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(241, 66)
        Me.Button14.TabIndex = 10
        Me.Button14.Text = "Ajuste partida"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button15.FlatAppearance.BorderSize = 2
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button15.Location = New System.Drawing.Point(45, 60)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(241, 66)
        Me.Button15.TabIndex = 9
        Me.Button15.Text = "Perfiles funcionarios"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'TabPage6
        '
        Me.TabPage6.BackgroundImage = Global.UVECASE_DB.My.Resources.Resources.logo_u
        Me.TabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage6.Controls.Add(Me.Btn_ListaVehiculos)
        Me.TabPage6.Controls.Add(Me.Btn_ControlKm)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(782, 374)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Vehículos"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Btn_ListaVehiculos
        '
        Me.Btn_ListaVehiculos.BackColor = System.Drawing.Color.White
        Me.Btn_ListaVehiculos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_ListaVehiculos.FlatAppearance.BorderSize = 2
        Me.Btn_ListaVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ListaVehiculos.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ListaVehiculos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_ListaVehiculos.Location = New System.Drawing.Point(505, 160)
        Me.Btn_ListaVehiculos.Name = "Btn_ListaVehiculos"
        Me.Btn_ListaVehiculos.Size = New System.Drawing.Size(241, 66)
        Me.Btn_ListaVehiculos.TabIndex = 11
        Me.Btn_ListaVehiculos.Text = "Lista de vehículos"
        Me.Btn_ListaVehiculos.UseVisualStyleBackColor = False
        '
        'Btn_ControlKm
        '
        Me.Btn_ControlKm.BackColor = System.Drawing.Color.White
        Me.Btn_ControlKm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_ControlKm.FlatAppearance.BorderSize = 2
        Me.Btn_ControlKm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ControlKm.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ControlKm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_ControlKm.Location = New System.Drawing.Point(45, 160)
        Me.Btn_ControlKm.Name = "Btn_ControlKm"
        Me.Btn_ControlKm.Size = New System.Drawing.Size(241, 66)
        Me.Btn_ControlKm.TabIndex = 10
        Me.Btn_ControlKm.Text = "Control kilometraje"
        Me.Btn_ControlKm.UseVisualStyleBackColor = False
        '
        'TabPage7
        '
        Me.TabPage7.BackgroundImage = Global.UVECASE_DB.My.Resources.Resources.logo_u
        Me.TabPage7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage7.Controls.Add(Me.Btn_ListaEquipos)
        Me.TabPage7.Controls.Add(Me.Btn_Calibraciones)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(782, 374)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Equipos"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Btn_ListaEquipos
        '
        Me.Btn_ListaEquipos.BackColor = System.Drawing.Color.White
        Me.Btn_ListaEquipos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_ListaEquipos.FlatAppearance.BorderSize = 2
        Me.Btn_ListaEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ListaEquipos.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ListaEquipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_ListaEquipos.Location = New System.Drawing.Point(505, 160)
        Me.Btn_ListaEquipos.Name = "Btn_ListaEquipos"
        Me.Btn_ListaEquipos.Size = New System.Drawing.Size(241, 66)
        Me.Btn_ListaEquipos.TabIndex = 13
        Me.Btn_ListaEquipos.Text = "Lista de equipos"
        Me.Btn_ListaEquipos.UseVisualStyleBackColor = False
        '
        'Btn_Calibraciones
        '
        Me.Btn_Calibraciones.BackColor = System.Drawing.Color.White
        Me.Btn_Calibraciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_Calibraciones.FlatAppearance.BorderSize = 2
        Me.Btn_Calibraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Calibraciones.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Calibraciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Calibraciones.Location = New System.Drawing.Point(45, 160)
        Me.Btn_Calibraciones.Name = "Btn_Calibraciones"
        Me.Btn_Calibraciones.Size = New System.Drawing.Size(241, 66)
        Me.Btn_Calibraciones.TabIndex = 12
        Me.Btn_Calibraciones.Text = "Calibraciones"
        Me.Btn_Calibraciones.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = Global.UVECASE_DB.My.Resources.Resources.logo_u
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage3.Controls.Add(Me.Btn_ModificarPerfil)
        Me.TabPage3.Controls.Add(Me.Prof_btn)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(782, 374)
        Me.TabPage3.TabIndex = 7
        Me.TabPage3.Text = "Curriculum"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Btn_ModificarPerfil
        '
        Me.Btn_ModificarPerfil.BackColor = System.Drawing.Color.White
        Me.Btn_ModificarPerfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_ModificarPerfil.FlatAppearance.BorderSize = 2
        Me.Btn_ModificarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ModificarPerfil.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ModificarPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_ModificarPerfil.Location = New System.Drawing.Point(505, 160)
        Me.Btn_ModificarPerfil.Name = "Btn_ModificarPerfil"
        Me.Btn_ModificarPerfil.Size = New System.Drawing.Size(241, 66)
        Me.Btn_ModificarPerfil.TabIndex = 15
        Me.Btn_ModificarPerfil.Text = "Modificar perfil"
        Me.Btn_ModificarPerfil.UseVisualStyleBackColor = False
        '
        'Prof_btn
        '
        Me.Prof_btn.BackColor = System.Drawing.Color.White
        Me.Prof_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Prof_btn.FlatAppearance.BorderSize = 2
        Me.Prof_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Prof_btn.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prof_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Prof_btn.Location = New System.Drawing.Point(45, 160)
        Me.Prof_btn.Name = "Prof_btn"
        Me.Prof_btn.Size = New System.Drawing.Size(241, 66)
        Me.Prof_btn.TabIndex = 14
        Me.Prof_btn.Text = "Crear perfil"
        Me.Prof_btn.UseVisualStyleBackColor = False
        '
        'TabPage8
        '
        Me.TabPage8.BackgroundImage = Global.UVECASE_DB.My.Resources.Resources.logo_u
        Me.TabPage8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage8.Controls.Add(Me.Btn_VerHistorial)
        Me.TabPage8.Controls.Add(Me.Btn_GenerarReporte)
        Me.TabPage8.Controls.Add(Me.Btn_AgregarHotel)
        Me.TabPage8.Controls.Add(Me.Btn_SubirMediciones)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(782, 374)
        Me.TabPage8.TabIndex = 8
        Me.TabPage8.Text = "Inspecciones"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Btn_VerHistorial
        '
        Me.Btn_VerHistorial.BackColor = System.Drawing.Color.White
        Me.Btn_VerHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_VerHistorial.FlatAppearance.BorderSize = 2
        Me.Btn_VerHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_VerHistorial.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_VerHistorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_VerHistorial.Location = New System.Drawing.Point(501, 260)
        Me.Btn_VerHistorial.Name = "Btn_VerHistorial"
        Me.Btn_VerHistorial.Size = New System.Drawing.Size(241, 66)
        Me.Btn_VerHistorial.TabIndex = 16
        Me.Btn_VerHistorial.Text = "Ver historial"
        Me.Btn_VerHistorial.UseVisualStyleBackColor = False
        '
        'Btn_GenerarReporte
        '
        Me.Btn_GenerarReporte.BackColor = System.Drawing.Color.White
        Me.Btn_GenerarReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_GenerarReporte.FlatAppearance.BorderSize = 2
        Me.Btn_GenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GenerarReporte.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GenerarReporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_GenerarReporte.Location = New System.Drawing.Point(501, 60)
        Me.Btn_GenerarReporte.Name = "Btn_GenerarReporte"
        Me.Btn_GenerarReporte.Size = New System.Drawing.Size(241, 66)
        Me.Btn_GenerarReporte.TabIndex = 15
        Me.Btn_GenerarReporte.Text = "Generar reporte"
        Me.Btn_GenerarReporte.UseVisualStyleBackColor = False
        '
        'Btn_AgregarHotel
        '
        Me.Btn_AgregarHotel.BackColor = System.Drawing.Color.White
        Me.Btn_AgregarHotel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_AgregarHotel.FlatAppearance.BorderSize = 2
        Me.Btn_AgregarHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AgregarHotel.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AgregarHotel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_AgregarHotel.Location = New System.Drawing.Point(45, 260)
        Me.Btn_AgregarHotel.Name = "Btn_AgregarHotel"
        Me.Btn_AgregarHotel.Size = New System.Drawing.Size(241, 66)
        Me.Btn_AgregarHotel.TabIndex = 14
        Me.Btn_AgregarHotel.Text = "Agregar hotel"
        Me.Btn_AgregarHotel.UseVisualStyleBackColor = False
        '
        'Btn_SubirMediciones
        '
        Me.Btn_SubirMediciones.BackColor = System.Drawing.Color.White
        Me.Btn_SubirMediciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Btn_SubirMediciones.FlatAppearance.BorderSize = 2
        Me.Btn_SubirMediciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SubirMediciones.Font = New System.Drawing.Font("Gabriola", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SubirMediciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_SubirMediciones.Location = New System.Drawing.Point(45, 60)
        Me.Btn_SubirMediciones.Name = "Btn_SubirMediciones"
        Me.Btn_SubirMediciones.Size = New System.Drawing.Size(241, 66)
        Me.Btn_SubirMediciones.TabIndex = 13
        Me.Btn_SubirMediciones.Text = "Subir mediciones"
        Me.Btn_SubirMediciones.UseVisualStyleBackColor = False
        '
        'TabPage9
        '
        Me.TabPage9.BackgroundImage = Global.UVECASE_DB.My.Resources.Resources.logo_u
        Me.TabPage9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(782, 374)
        Me.TabPage9.TabIndex = 9
        Me.TabPage9.Text = "Usuarios"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'Main_app
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(814, 410)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_app"
        Me.Text = "UVECASE"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents AV_btn As Button
    Friend WithEvents Evaluar_btn As Button
    Friend WithEvents Aprob_compra_btn As Button
    Friend WithEvents Orden_compra_btn As Button
    Friend WithEvents Sol_compra_btn As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Btn_VerMovimientos As Button
    Friend WithEvents Btn_ModificarPartidas As Button
    Friend WithEvents Btn_DigitarPresupuesto As Button
    Friend WithEvents Gira_btn As Button
    Friend WithEvents LV_btn As Button
    Friend WithEvents Btn_ListaVehiculos As Button
    Friend WithEvents Btn_ControlKm As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Btn_ListaEquipos As Button
    Friend WithEvents Btn_Calibraciones As Button
    Friend WithEvents Btn_ModificarPerfil As Button
    Friend WithEvents Prof_btn As Button
    Friend WithEvents Btn_VerHistorial As Button
    Friend WithEvents Btn_GenerarReporte As Button
    Friend WithEvents Btn_AgregarHotel As Button
    Friend WithEvents Btn_SubirMediciones As Button
End Class
