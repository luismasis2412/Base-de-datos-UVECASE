Public Class AgregarProveedor
    Private Sub AgregarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    ' botón de salir, cieera el formulario
    Private Sub OutAgreBt_Click(sender As Object, e As EventArgs) Handles OutAgreBt.Click
        Me.Hide()
    End Sub
    ' botón de agregar, declaramos las variables para que sean agregadas a la base de datos de proveedores
    Private Sub AgregaPBt_Click(sender As Object, e As EventArgs) Handles AgregaPBt.Click
        ' Razon social, cedula, telefono 1, telefono 2, fax, correo electronico y pagina web
        Dim Razon = RazonTbox.Text, Ced = CedTbox.Text, Tel1 = Tel1Tbox.Text, Tel2 = Tel2Tbox.Text, Fax = FaxTbox.Text, Email = EmailTbox.Text, Web = WebTbox.Text
        ' todas estas variables deben almacenarce en la base de datos una vez que se preciona el botón agregar
    End Sub
End Class