Public Class Main_app
    'Apenas carga el main_app form, se muestra el de Login
    Private Sub Main_app_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login_form.Show()
    End Sub

    'Al dar click en "Programación de giras", se cierra la ventana principal y se abre la interfaz de progra de giras
    Private Sub Gira_btn_Click(sender As Object, e As EventArgs) Handles Gira_btn.Click
        Giras_progra.Show()
        Me.Hide()           'Me (Main_app) se esconde
    End Sub

    'Misma dinámica para el resto de forms, siempre asociado a algún botón
    Private Sub AV_btn_Click(sender As Object, e As EventArgs) Handles AV_btn.Click
        Giras_adelanto.Show()
        Me.Hide()
    End Sub

    Private Sub LV_btn_Click(sender As Object, e As EventArgs) Handles LV_btn.Click
        Giras_liquidaciones.Show()
        Me.Hide()
    End Sub

    Private Sub Sol_compra_btn_Click(sender As Object, e As EventArgs) Handles Sol_compra_btn.Click
        Compras_solicitud.Show()
        Me.Hide()
    End Sub

    '%%% Al cargar, se vuelve invisible mientras el formulario de ingreso esté activo %%%
    Private Sub Main_app_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If (Login_form.Visible = True) Then
            Me.Visible = False
        End If
    End Sub

    '%%% Se muestra en pantalla form de usuarios %%%
    Private Sub Prof_btn_Click(sender As Object, e As EventArgs) Handles Prof_btn.Click
        Curriculum_Vitae.Show()
        Me.Hide()
    End Sub
    '%%% Se muestra en pantalla form de calibraciones %%%
    Private Sub Btn_Calibraciones_Click(sender As Object, e As EventArgs) Handles Btn_Calibraciones.Click
        Calibraciones.Show()
        Me.Hide()
    End Sub


End Class
