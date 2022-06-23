Public Class Giras_adelanto
    '%%%%%% DECLARACIÓN DE VARIABLES Y OBJETOS PARA USO EN ESTE FORM %%%%%%%%

    Private clsTx_date As TextBox                               'Se asigna objeto genérico para representar los elementos del form por día
    Private clsBx_hi As TextBox
    Private clsBx_ho As TextBox
    Private clsCx_brkfst As CheckBox
    Private clsCx_lnch As CheckBox
    Private clsCx_dnnr As CheckBox
    Private clsBx_provs As ComboBox
    Private clsBx_locas As ComboBox
    Private clsTx_amnt As TextBox

    Private Load_status As Boolean = True

    '%%% Carga de form %%%
    Private Sub Giras_adelanto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AG_Beneficiarios.Items.Add("Ing. Guillermo González")
        AG_Beneficiarios.Items.Add("Tec. Steven García")
        AG_Progras.Items.Add("AG-777")
        List_pends(PG_pends)

        Load_status = False
    End Sub

    '%%% Llama de vuelta a ventana principal al cerrar la interfaz de adelanto de giras %%%
    Private Sub Exitform(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main_app.Show()
    End Sub

    '%%% Llama a lista de pendientes %%%
    Private Sub List_pends(ClsLst As ListBox)
        ClsLst.DataSource = PG_pendientes()         'Fuente
        ClsLst.DisplayMember = "consecutivo"        '¿Qué mostrar?
        ClsLst.ValueMember = "consecutivo"          '¿Cuál es su valor?
        ClsLst.ClearSelected()
    End Sub

    '%%% Carga en el respectivo cuadro lista de giras pendientes de aprobar %%%
    Private Sub PG_pends_SelectedValueChanged(sender As Object, e As EventArgs) Handles PG_pends.SelectedValueChanged
        If Load_status = False And PG_pends.SelectedItems.Count > 0 Then
            Dim row As DataRow
            Dim cons As Integer = Convert.ToInt32(PG_pends.SelectedItem(0))
            Dim dt As DataTable = PG_carga_info(cons)                           'Recibe datatable
            Dim day_num As Integer
            Dim day As Date
            Dim straux As String
            Dim aux() As String

            If dt.Rows.Count <= 0 Then
                Exit Sub
            End If
            Clear_form(PG)                                                      'Se llama a limpiado de form, con tabpage como fuente de controles
            row = dt.Rows(0)                                                    'Se carga información del control de giras, más días de gira
            PG_Cons.Text = row.ItemArray(0).ToString                            'Celda 0 es fecha de adelanto
            PG_fecha_adelanto.Text = row.ItemArray(1).ToShortDateString
            PG_responsable.Text = row.ItemArray(2).ToString
            PG_proyecto.Text = row.ItemArray(3).ToString

            For Each row In dt.Rows                                             'Se llena información de acuerdo a día de la semana que haya gira
                day = Date.Parse(row.ItemArray(4))
                day_num = day.DayOfWeek

                Dim clsTx_date As TextBox = DirectCast(Me.Controls.Find("PG_date_" + day_num.ToString(), True)(0), TextBox)
                Dim clsTx_dest As TextBox = DirectCast(Me.Controls.Find("PG_dest_" + day_num.ToString(), True)(0), TextBox)
                Dim clsTx_hi As TextBox = DirectCast(Me.Controls.Find("PG_hour_s_" + day_num.ToString(), True)(0), TextBox)
                Dim clsTx_ho As TextBox = DirectCast(Me.Controls.Find("PG_hour_f_" + day_num.ToString(), True)(0), TextBox)
                Dim clsTx_provs As TextBox = DirectCast(Me.Controls.Find("PG_Prov_" + day_num.ToString(), True)(0), TextBox)
                Dim clsTx_locas As TextBox = DirectCast(Me.Controls.Find("PG_loca_" + day_num.ToString(), True)(0), TextBox)
                Dim clsTx_insps As TextBox = DirectCast(Me.Controls.Find("PG_insp_" + day_num.ToString(), True)(0), TextBox)
                Dim clsTx_buddy As TextBox = DirectCast(Me.Controls.Find("PG_buddy_" + day_num.ToString(), True)(0), TextBox)
                Dim clsTx_car As TextBox = DirectCast(Me.Controls.Find("PG_carros_" + day_num.ToString(), True)(0), TextBox)

                clsTx_date.Text = day.ToShortDateString                                                         'Se guarda fecha de gira
                clsTx_dest.Text = row.ItemArray(5).ToString                                                     'Se guarda cadena de destinos
                clsTx_provs.Text = row.ItemArray(6).ToString
                clsTx_locas.Text = row.ItemArray(7).ToString
                straux = row.ItemArray(8).ToString()
                aux = Split(straux, ":")
                clsTx_hi.Text = String.Concat(aux(0), ":", aux(1))
                aux = Nothing
                straux = row.ItemArray(9).ToString()
                aux = Split(straux, ":")
                clsTx_ho.Text = String.Concat(aux(0), ":", aux(1))
                clsTx_insps.Text = row.ItemArray(10).ToString()
                clsTx_car.Text = row.ItemArray(11).ToString()
                clsTx_buddy.Text = row.ItemArray(12).ToString()

            Next
        End If
        PG_pends.ClearSelected()
    End Sub

    '%%% Carga información %%%

    '%%% Se aprueba gira %%%
    Private Sub PG_approve_Click(sender As Object, e As EventArgs) Handles PG_approve.Click
        If String.IsNullOrEmpty(PG_Cons.Text) = False Then      'Procede solo si hay número asignado de consecutivo
            Dim status As Boolean = PG_aprobar_gira(Convert.ToInt16(PG_Cons.Text))
            If status = True Then
                MessageBox.Show("Gira con consecutivo " + PG_Cons.Text + " aprobada." + vbLf + "Favor pasar a la asignación de adelantos.")
                Clear_form(PG)
                List_pends(PG_pends)
            Else
            End If
        End If
    End Sub

    '%%% Se extrae matriz de datos con información de la gira, y carga en la lista de "Beneficiarios" a los participantes (encargado y acompañantes)
    Private Sub AG_Beneficiarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AG_Beneficiarios.SelectedIndexChanged

    End Sub

    '%%% Habiendo seleccionado una gira aprobada, se carga lista de participantes con su respectiva participación
    Private Sub AG_Progras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AG_Progras.SelectedIndexChanged

    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click

    End Sub

    Private Sub PG_date_1_TextChanged(sender As Object, e As EventArgs) Handles PG_date_1.TextChanged

    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

    End Sub

    Private Sub PG_pends_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PG_pends.SelectedIndexChanged

    End Sub
End Class