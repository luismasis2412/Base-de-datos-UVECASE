'Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MySql.Data


Public Class Login_form
    'Interfaz para solicitar datos de ingreso a la base de datos
    Private Pwd As New Security.SecureString
    Private Id As String

    'Se detectan cambios en el textbox de contraseña, y cada caractér se anexa 
    Private Sub Pass_box_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Pass_box.KeyPress
        Try
            'Agrega únicamente caracteres no especiales
            If 33 <= Convert.ToInt32(e.KeyChar) <= 126 Then
                Pwd.AppendChar(e.KeyChar)

                'Si se digita el backspace, se borra último caracter del string de contraseña
            ElseIf Convert.ToInt32(e.KeyChar) = 8 Then
                Pwd.RemoveAt(Pwd.Length - 1)

            End If

        Catch ex As Exception
            MessageBox.Show("Programa falló exitosamente. \n Código:" + ex.Message)
        End Try
    End Sub

    'Al darle click a "salir" se cierra la aplicación
    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Application.Exit()
    End Sub

    'Se le da click y se envía información a base de datos para comprobar credenciales
    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles Login_btn.Click

        Try
            'Usuario de textbox correspondiente
            Id = User_box.Text

            'SecureString se debe hacer de solo lectura a la hora de enviarse al objeto SQL de credenciales
            'Pwd.MakeReadOnly()

            'Se abre conexión para probarla
            Conn.ConnectionString = String.Concat(queryString, ";uid=" + Id, ";pwd=Linkin.-1" + ";Persist Security Info=True") '+ System.Net.NetworkCredential(String.Empty, Pwd).Password)
            Conn.Open()

            'Se verifica por medio de estado
            If ConnectionState.Open Then
                Conn.Close()
                Conn.Dispose()
                Main_app.Show()
                Me.Hide()
            End If

            'Se ataja error. Se deben contemplar diferentes casos.
        Catch ex As MySqlClient.MySqlException
            MessageBox.Show("Usuario y/o contraseña incorrecto(s)." + vbCrLf + "Digítelos nuevamente.")
            Conn.Close()
            Conn.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try

    End Sub

    'Si se cierra el formulario, se cierra la aplicación
    Private Sub Login_form_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class