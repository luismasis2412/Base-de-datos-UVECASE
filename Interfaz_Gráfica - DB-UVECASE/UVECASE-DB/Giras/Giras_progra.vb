Imports System.ComponentModel

Public Class Giras_progra
    '%%%%%% DECLARACIÓN DE VARIABLES Y OBJETOS PARA USO EN ESTE FORM %%%%%%%%

    Private ReadOnly PG_char_lim As Integer = 100               'Tamaño máximo para cuadros de texto editables
    Private ReadOnly PG_elements_week_lim As Integer = 11       'Elementos por día llenados por semana para considerarse día de gira
    Private ReadOnly PG_elements_day_lim As Integer = 6         'Mínimo de elementos semanales llenado para considerarse gira válida
    Private ReadOnly PG_elements_base_lim As Integer = 3        'Definición de elementos base
    Private PG_dates As New List(Of DateTime)                   'Vector de fechas semanales

    Private clsTx_date As TextBox                               'Se asigna objeto genérico para representar los elementos del form por día
    Private clsTx_dest As TextBox
    Private clsBx_hi As ComboBox
    Private clsBx_ho As ComboBox
    Private clsBx_mi As ComboBox
    Private clsBx_mo As ComboBox
    Private clsBx_provs As ComboBox
    Private clsBx_locas As ComboBox
    Private clsLst_insps As ListBox
    Private clsLst_buddy As ListBox
    Private clsLst_car As ListBox

    Private Load_status As Boolean                              'Bandera para indicar estado de carga

    '%%%%%% Comienzo de rutinas y eventos de este Windows Form %%%%

    '%%% Carga de form %%%
    Private Sub Giras_progra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_status = True

        PG_dates.Add(DateTime.Now.Date)                             'Fecha de adelanto muestra fecha actual, y se guarda en vector de fechas
        PG_fecha_adelanto.Text = PG_dates(0).ToShortDateString      'Se convierte de "Date" a string con formato de fecha corto

        'Fechas semanales se toman
        For i = 1 To 6
            PG_dates.Add(PG_dates(i - 1).AddDays(1))
        Next
        D_sorting(PG_dates(0))

        'Se comienza llenando los listboxes y comboboxes
        clock_fill()                                                'Se llama llenado de combos de reloj
        provs_fill()                                                'Se llama a llenado a combos de provincia
        type_fill()                                                 'Se llama a llenado de tipos de inspección
        List_pends(PG_pends)                                        'Se llama a llenado de lista de pendientes
        Proyects_fill(PG_proyecto)                                  'Se llama a llenado de lista de proyectos de la unidad
        Carros_fill()                                               'Se llama a llenado de lista de carros

        Load_status = False                                         'Se termina carga de elementos primarios
    End Sub

    '%%% No marque nada %%%
    Private Sub Giras(sender As Object, e As EventArgs) Handles MyBase.Paint
        PG_fecha_adelanto.SelectionLength = 0
    End Sub

    '%%% Llamado a lista de giras pendientes de aprobar %%%
    Private Sub List_pends(ClsLst As ListBox)
        ClsLst.DataSource = PG_pendientes()         'Fuente de datos
        ClsLst.DisplayMember = "consecutivo"        '¿Qué mostrar?
        ClsLst.ValueMember = "consecutivo"          '¿Cuál es su valor?
        ClsLst.ClearSelected()
    End Sub

    '%%% Reacción a evento de cambio de índice en comboboxes de provincias, para llenado de cajas de localizaciones %%%
    'Cada método dentro de la clase responde a un cambio en el índice (selección), y llama a "Loca_filler"
    Private Class Provs_combos_swtch
        Inherits Giras_progra
        Private Sub PG_Prov_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PG_Prov_1.SelectedIndexChanged
            'Llama a subrutina respectiva, con combobox respectivo como parámetro
            Loca_filler(PG_loca_1, PG_Prov_1)
        End Sub
        Private Sub PG_Prov_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PG_Prov_2.SelectedIndexChanged
            'Llama a subrutina respectiva, con combobox respectivo como parámetro
            Loca_filler(PG_loca_2, PG_Prov_2)
        End Sub
        Private Sub PG_Prov_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PG_Prov_3.SelectedIndexChanged
            'Llama a subrutina respectiva, con combobox respectivo como parámetro
            Loca_filler(PG_loca_3, PG_Prov_3)
        End Sub
        Private Sub PG_Prov_4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PG_Prov_4.SelectedIndexChanged
            'Llama a subrutina respectiva, con combobox respectivo como parámetro
            Loca_filler(PG_loca_4, PG_Prov_4)
        End Sub
        Private Sub PG_Prov_5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PG_Prov_5.SelectedIndexChanged
            'Llama a subrutina respectiva, con combobox respectivo como parámetro
            Loca_filler(PG_loca_5, PG_Prov_5)
        End Sub
        Private Sub PG_Prov_6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PG_Prov_6.SelectedIndexChanged
            'Llama a subrutina respectiva, con combobox respectivo como parámetro
            Loca_filler(PG_loca_6, PG_Prov_6)
        End Sub
    End Class

    '%%% Llamado a creacíón de listas de inspecciones %%%
    Private Sub type_fill()
        For i = 1 To 6
            'Se crea objeto genérico de listbox, y se convierte string defininida a conveniencia a listbox
            Dim clsList As ListBox = DirectCast(Me.Controls.Find("PG_insp_" + i.ToString(), True)(0), ListBox)  'DirectCast convierte a clase basado en str
            clsList.Items.Clear()
            Insp_types(clsList)
        Next
    End Sub

    '%%% Subrutina para llenado de comboboxes de provincias %%%
    Private Sub provs_fill()
        For i = 1 To 6
            'Se crea objeto genérico de combobox, y se convierte string defininida a conveniencia al mismo tipo
            Dim clsCombo As ComboBox = DirectCast(Me.Controls.Find("PG_Prov_" + i.ToString(), True)(0), ComboBox)
            clsCombo.DataSource = Lista_provs()                 'Fuente
            clsCombo.DisplayMember = "provincia"                '¿Qué mostrar?
            clsCombo.ValueMember = "provincia"                  '¿Cuál es su valor?
            clsCombo.SelectionStart = clsCombo.Text.Length
        Next
    End Sub

    '%%% Subrutina para llenado de comboboxes de hora %%%
    Private Sub clock_fill()
        'Llenado de cuadros de tiempos
        'Se crea lista con nombres patrones para los cuadros de hora
        Dim PG_names As New List(Of String)
        PG_names.Add("PG_hour_s")
        PG_names.Add("PG_min_s")
        PG_names.Add("PG_hour_f")
        PG_names.Add("PG_min_f")

        For j = 0 To PG_names.Count - 1 Step 2

            'Se hace cast para convertir string a objeto combobox, y poder recorrer varios elementos de manera automatizada
            For i = 1 To 6
                Dim clsCombo As ComboBox = DirectCast(Me.Controls.Find(PG_names(j) + "_" + i.ToString(), True)(0), ComboBox)
                '     clsCombo.Items.Add(vbEmpty)
                clsCombo.DataSource = Clock_h()
                clsCombo.DisplayMember = "Time_c"
                clsCombo.ValueMember = "Time_c"
                clsCombo.SelectionLength = 0


                clsCombo = DirectCast(Me.Controls.Find(PG_names(j + 1) + "_" + i.ToString(), True)(0), ComboBox)
                '  clsCombo.Items.Add(vbEmpty)
                clsCombo.DataSource = Clock_min()
                clsCombo.DisplayMember = "Time_c"
                clsCombo.ValueMember = "Time_c"
                clsCombo.SelectionLength = 0
            Next
        Next

    End Sub

    '%%% Subrutina que llena los combos de loca de manera automatizada %%%
    '%%% Se usa bandera para no hacer llamados durante carga de elementos %%%
    Private Sub Loca_filler(target As ComboBox, source As ComboBox)
        Try
            Select Case Load_status 'Un if pero más chiva 
                Case False 'Solo ejecute instrucciones si ya terminó el load del form
                    target.DataSource = Lista_locs(source.Text.ToString)
                    target.DisplayMember = "localidad"
                    target.ValueMember = "localidad"
                    '   target.SelectionLength = 0 'Para que no se marque
            End Select

        Catch ex As Exception
            MessageBox.Show("Fallo encontrado: " + ex.Message)
        End Try
    End Sub

    '%%% Llenado de lista de vehículos %%%
    Private Sub Carros_fill()
        Try
            For i = 1 To 6
                'Se crea objeto genérico de combobox, y se convierte string defininida a conveniencia al mismo tipo
                Dim clsList As ListBox = DirectCast(Me.Controls.Find("PG_carros_" + i.ToString(), True)(0), ListBox)

                clsList.DataSource = Lista_carros() 'Fuente
                clsList.DisplayMember = "Placa"  '¿Qué mostrar?
                clsList.ValueMember = "Placa"    '¿Cuál es su valor?
                clsList.ClearSelected()
            Next

        Catch ex As Exception
            MessageBox.Show("Fallo encontrado: " + ex.Message)
        End Try
    End Sub

    '%%% Configuración de eventos relacionados a botón de calendario %%%
    Private Sub PG_month_btn_Click(sender As Object, e As EventArgs) Handles PG_month_btn.Click
        If PG_calendar.Visible = True Then
            PG_calendar.Visible = False
        Else
            PG_calendar.Visible = True
        End If
    End Sub

    '%%% Ventana se cierra si puntero se sale del cuadro de calendario %%%
    Private Sub PG_calendar_MouseLeave(sender As Object, e As EventArgs) Handles PG_calendar.MouseLeave
        PG_calendar.Visible = False
    End Sub

    '%%% O si se clickea en el form (fuera de cualquier control) %%%
    Private Sub Giras_progra_Click(sender As Object, e As EventArgs) Handles Me.Click
        PG_calendar.Visible = False
    End Sub

    '%%% Reacción a escoger fecha de calendario %%%
    '%%% En base a fecha de adelanto, se seleccionan fechas de la siguiente semana para la gira %%%
    Private Sub PG_calendar_DateSelected(sender As Object, e As EventArgs) Handles PG_calendar.DateSelected

        Dim i As Integer = PG_calendar.SelectionRange.Start.DayOfWeek       'Lunes = 1, martes = 2, etc...
        Dim day As Date = PG_calendar.SelectionRange.Start

        PG_calendar.Visible = False
        PG_fecha_adelanto.Text = day.ToShortDateString
        PG_dates(0) = day

        D_sorting(day)                                                      'Se asignan a partir de la siguiente en los campos respectivos
    End Sub

    '%%% Rutina que ayuda a seleccionar fechas apropiadas %%%
    Private Sub D_sorting(ByVal day As Date)
        Dim i As Integer = day.DayOfWeek
        'Si la fecha de programación es lunes, la gira comienza la siguiente semana
        If i = 1 Then
            i += 1
        End If

        'Se busca el siguiente lunes, partiendo de la fecha escogida
        While i <> 1
            day = day.AddDays(1)
            i = day.DayOfWeek
        End While

        For i = 1 To 6
            Dim clsTxt As TextBox = DirectCast(Me.Controls.Find("PG_date_" + i.ToString(), True)(0), TextBox)
            clsTxt.Text = day.ToShortDateString
            PG_dates(i) = day
            day = day.AddDays(1)
        Next
    End Sub

    '%%% Eventos que controlan que cuadros de texto no excedan límite de caracteres %%%
    Private Class Char_lim_routines
        Inherits Giras_progra
        Private Sub PG_dest_1_TextChanged(sender As Object, e As EventArgs) Handles PG_dest_1.TextChanged
            Dim s As String = PG_dest_1.Text        'Se obtiene tamaño de texto
            If s.Length > PG_char_lim Then
                s = s.Substring(0, s.Length - 1)    'Corte el último caractér seleccionado
                PG_dest_1.Text = s
                PG_dest_1.SelectionStart = s.Length 'Coloque puntero al final de la cadena de texto actualizada
            End If
        End Sub
        Private Sub PG_dest_2_TextChanged(sender As Object, e As EventArgs) Handles PG_dest_2.TextChanged
            Dim s As String = PG_dest_2.Text        'Se obtiene tamaño de texto

            If s.Length > PG_char_lim Then
                s = s.Substring(0, s.Length - 1)    'Corte el último caractér seleccionado
                PG_dest_2.Text = s
                PG_dest_2.SelectionStart = s.Length 'Coloque puntero al final de la cadena de texto actualizada
            End If
        End Sub
        Private Sub PG_dest_3_TextChanged(sender As Object, e As EventArgs) Handles PG_dest_3.TextChanged

            Dim s As String = PG_dest_3.Text        'Se obtiene tamaño de texto

            If s.Length > PG_char_lim Then
                s = s.Substring(0, s.Length - 1)    'Corte el último caractér seleccionado
                PG_dest_3.Text = s
                PG_dest_3.SelectionStart = s.Length 'Coloque puntero al final de la cadena de texto actualizada
            End If
        End Sub
        Private Sub PG_dest_4_TextChanged(sender As Object, e As EventArgs) Handles PG_dest_4.TextChanged

            Dim s As String = PG_dest_4.Text        'Se obtiene tamaño de texto

            If s.Length > PG_char_lim Then
                s = s.Substring(0, s.Length - 1)    'Corte el último caractér seleccionado
                PG_dest_4.Text = s
                PG_dest_4.SelectionStart = s.Length 'Coloque puntero al final de la cadena de texto actualizada
            End If
        End Sub
        Private Sub PG_dest_5_TextChanged(sender As Object, e As EventArgs) Handles PG_dest_5.TextChanged

            Dim s As String = PG_dest_5.Text        'Se obtiene tamaño de texto

            If s.Length > PG_char_lim Then
                s = s.Substring(0, s.Length - 1)    'Corte el último caractér seleccionado
                PG_dest_5.Text = s
                PG_dest_5.SelectionStart = s.Length 'Coloque puntero al final de la cadena de texto actualizada
            End If
        End Sub
        Private Sub PG_dest_6_TextChanged(sender As Object, e As EventArgs) Handles PG_dest_6.TextChanged

            Dim s As String = PG_dest_6.Text        'Se obtiene tamaño de texto

            If s.Length > PG_char_lim Then
                s = s.Substring(0, s.Length - 1)    'Corte el último caractér seleccionado
                PG_dest_6.Text = s
                PG_dest_6.SelectionStart = s.Length 'Coloque puntero al final de la cadena de texto actualizada
            End If
        End Sub

    End Class

    '%%% Corre rutina para guardado de elementos de gira %%%
    Private Sub PG_generar_Click(sender As Object, e As EventArgs) Handles PG_generar.Click
        Dim week As New List(Of Integer)                            'Primeramente se verifica cuáles son días de gira
        Dim daily_elements As Integer
        Dim cons As Integer
        Dim base As Integer

        Select Case String.IsNullOrEmpty(PG_Cons.Text)              '¿Ya hay gira asignada en pantalla?
            Case True
                Dim info_gira_dia As New PG_datos                   'Nueva estructura de datos
                info_gira_dia.Fecha = Date_ToSQL(PG_dates(0))       'En la misma se guarda la fecha de programación
                info_gira_dia.Proyecto = PG_proyecto.Text
                cons = PG_cons_new(info_gira_dia.Fecha.guardada)    'Asigna nuevo consecutivo

                'Se verifica que todos los días de giras tengan la información completa (texto, selección, etc...)
                For i = 1 To 6
                    daily_elements = 0
                    clsTx_date = DirectCast(Me.Controls.Find("PG_date_" + i.ToString(), True)(0), TextBox)
                    daily_elements += G_IsTX_empty(clsTx_date)          'Determina si elemento contiene información (revisar método en "Funciones")
                    clsTx_dest = DirectCast(Me.Controls.Find("PG_dest_" + i.ToString(), True)(0), TextBox)
                    daily_elements += G_IsTX_empty(clsTx_dest)          'Determina si elemento contiene información (revisar método en "Funciones")
                    clsBx_provs = DirectCast(Me.Controls.Find("PG_Prov_" + i.ToString(), True)(0), ComboBox)
                    daily_elements += G_IsCB_empty(clsBx_provs)         'Determina si elemento contiene información (revisar método en "Funciones")
                    clsBx_locas = DirectCast(Me.Controls.Find("PG_loca_" + i.ToString(), True)(0), ComboBox)
                    daily_elements += G_IsCB_empty(clsBx_locas)         'Determina si elemento contiene información (revisar método en "Funciones")
                    clsLst_insps = DirectCast(Me.Controls.Find("PG_insp_" + i.ToString(), True)(0), ListBox)
                    daily_elements += G_IsLB_empty(clsLst_insps)        'Determina si elemento contiene información (revisar método en "Funciones")
                    clsLst_buddy = DirectCast(Me.Controls.Find("PG_buddy_" + i.ToString(), True)(0), ListBox)
                    daily_elements += G_IsLB_empty(clsLst_buddy)        'Determina si elemento contiene información (revisar método en "Funciones")
                    clsLst_car = DirectCast(Me.Controls.Find("PG_carros_" + i.ToString(), True)(0), ListBox)
                    daily_elements += G_IsLB_empty(clsLst_car)          'Determina si elemento contiene información (revisar método en "Funciones")

                    If 1 < daily_elements And daily_elements < PG_elements_day_lim Then         'Si no es un día vacío, se toma como gira inconclusa
                        MessageBox.Show("Falta información para completar gira el día " + WeekdayName(i, False, FirstDayOfWeek.Monday) + ". Revise la programación.")
                        Exit Sub
                    End If
                    week.Add(daily_elements)                        'Se guarda número de elementos activos por día (si info está completa)
                Next
                daily_elements = 0
                For i = 0 To 5                                      'Se verifica si existe al menos algún día de la semana en que haya gira
                    daily_elements += week(i)
                Next

                If (String.IsNullOrWhiteSpace(PG_fecha_adelanto.Text) = False) And (String.IsNullOrWhiteSpace(PG_responsable.Text) = False) And (String.IsNullOrWhiteSpace(PG_proyecto.Text) = False) Then
                    base = PG_elements_base_lim                     '¿Fecha de adelanto, responsable y tipo de proyecto están asignados?
                End If

                If daily_elements >= PG_elements_week_lim And base = PG_elements_base_lim Then           'Si existe, entonces siga con la programación
                    info_gira_dia.Consecutivo = cons
                    info_gira_dia.Encargado = PG_responsable.Text

                    PG_crear_control(info_gira_dia.Consecutivo, info_gira_dia.Fecha.guardada, info_gira_dia.Encargado, info_gira_dia.Proyecto) 'Se crea base para gira
                    For i = 0 To 5
                        Select Case week(i)                         'Se identifica cuáles son días de gira, de acuerdo a campos llenados/seleccionados por día
                            Case 0
                                Continue For
                            Case 1
                                Continue For
                            Case 6
                                clsTx_date = DirectCast(Me.Controls.Find("PG_date_" + (i + 1).ToString(), True)(0), TextBox)
                                clsTx_dest = DirectCast(Me.Controls.Find("PG_dest_" + (i + 1).ToString(), True)(0), TextBox)
                                clsBx_hi = DirectCast(Me.Controls.Find("PG_hour_s_" + (i + 1).ToString(), True)(0), ComboBox)
                                clsBx_ho = DirectCast(Me.Controls.Find("PG_hour_f_" + (i + 1).ToString(), True)(0), ComboBox)
                                clsBx_mi = DirectCast(Me.Controls.Find("PG_min_s_" + (i + 1).ToString(), True)(0), ComboBox)
                                clsBx_mo = DirectCast(Me.Controls.Find("PG_min_f_" + (i + 1).ToString(), True)(0), ComboBox)
                                clsBx_provs = DirectCast(Me.Controls.Find("PG_Prov_" + (i + 1).ToString(), True)(0), ComboBox)
                                clsBx_locas = DirectCast(Me.Controls.Find("PG_loca_" + (i + 1).ToString(), True)(0), ComboBox)
                                clsLst_insps = DirectCast(Me.Controls.Find("PG_insp_" + (i + 1).ToString(), True)(0), ListBox)
                                clsLst_buddy = DirectCast(Me.Controls.Find("PG_buddy_" + (i + 1).ToString(), True)(0), ListBox)
                                clsLst_car = DirectCast(Me.Controls.Find("PG_carros_" + (i + 1).ToString(), True)(0), ListBox)

                                'Se procede a pasar información de gira del día
                                Dim aux As Object() = Nothing
                                info_gira_dia.Fecha_gira = Date.Parse(clsTx_date.Text)
                                info_gira_dia.Hora_inicio = TimeSpan.Parse(clsBx_hi.Text + ":" + clsBx_mi.Text + ":00")
                                info_gira_dia.Hora_fin = TimeSpan.Parse(clsBx_ho.Text + ":" + clsBx_mo.Text + ":00")
                                info_gira_dia.Localidad = clsBx_locas.Text
                                info_gira_dia.Provincia = clsBx_provs.Text
                                info_gira_dia.Destinos = clsTx_dest.Text

                                'Guardado de tipos de inspección
                                aux = (From item In clsLst_insps.SelectedItems Select item).ToArray()       'Se extrae selección a array
                                info_gira_dia.Objetivos = String.Join(", ", aux)                            'Dicho array se convierte a string de una sola línea
                                aux = Nothing

                                'Guardado de lista de acompañantes
                                'aux = (From item In clsLst_buddy.SelectedItems Select item).ToArray()       'Se aplica lo mismo de lo anterior acá
                                'info_gira_dia.Participantes = String.Join(", ", aux)
                                info_gira_dia.Participantes = "Turrón"
                                'aux = Nothing

                                'Guardado de lista de carros
                                aux = (From item As DataRowView In clsLst_car.SelectedItems Select item(0)).ToArray()    'Se convierte de array a string
                                info_gira_dia.Vehiculos = String.Join(", ", aux)
                                aux = Nothing

                                Dim status As Boolean = PG_guardar_gira(info_gira_dia)  'Se envía estructura de datos para guardarse en BD
                                Select Case status
                                    Case True
                                        Continue For
                                    Case False
                                        MessageBox.Show("Gira no se pudo terminar de programar.")
                                        Exit Sub
                                End Select
                        End Select
                    Next
                    MessageBox.Show("Gira programada con éxito.")
                    PG_Cons.Text = cons.ToString                                       'Una vez programada, se muestra el consecutivo en pantalla
                    List_pends(PG_pends)
                ElseIf daily_elements >= PG_elements_week_lim And base < PG_elements_base_lim Then
                    MessageBox.Show("Falta información base de la gira.")
                Else
                    MessageBox.Show("No se puede programar una gira vacía.")
                End If
            Case Else
                MessageBox.Show("Ya existe gira con número " + PG_Cons.Text + "." + vbLf + "Por favor actualizar página antes de intentar crear otra.")
        End Select

    End Sub

    '%%% Rutina para limpiar pantalla de form y poder programar nueva gira %%%
    Private Sub PG_nueva_Click(sender As Object, e As EventArgs) Handles PG_nueva.Click
        Clear_form(Me)
        Giras_progra_Load(Me, EventArgs.Empty) 'Se recarga form
    End Sub

    '%%% Cuando se cierra el form, se borra toda su información. %%%
    Private Sub Giras_progra_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Controls.Clear()
        GC.Collect()
    End Sub

    '%%% En base a consecutivo a pantalla, se manda a borrar gira sin aprobar %%%
    Private Sub PG_anular_Click(sender As Object, e As EventArgs) Handles PG_anular.Click
        Dim cons As String = PG_Cons.Text                                  'Se obtiene consecutivo
        If String.IsNullOrEmpty(cons) = False Then                         '¿Es nulo o vacío?
            Select Case PG_eliminar_gira(Convert.ToInt32(PG_Cons.Text))    '¿Se ejecutó el query?
                Case True
                    MessageBox.Show("Gira borrada con éxito.")             'Afirmativo (True)
                Case False
                    MessageBox.Show("No se pudo eliminar.")                'Negativo (False)
            End Select
            Clear_form(Me)                                                 'Se borra contenido y selecciones
            List_pends(PG_pends)                                           'Se actualiza lista de pendientes
        Else
            MessageBox.Show("Seleccione gira de la lista de pendientes.")  'Si se selecciona anular sin consecutivo, muestra esto
        End If
    End Sub

    '%%% Carga en el respectivo cuadro lista de giras pendientes de aprobar %%%
    Private Sub PG_pends_SelectedValueChanged(sender As Object, e As EventArgs) Handles PG_pends.SelectedValueChanged
        If Load_status = False And PG_pends.SelectedItems.Count > 0 Then        'Primero selecciona
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
            Clear_form(Me)                                                      'Limpia pantalla
            row = dt.Rows(0)                                                    'Se carga información del control de giras
            PG_Cons.Text = row.ItemArray(0).ToString                            'Celda 0 es consecutivo
            PG_fecha_adelanto.Text = row.ItemArray(1).ToShortDateString         'Celda 1 es fecha de adelanto
            PG_responsable.Text = row.ItemArray(2).ToString                     'Así sucesivamente...
            PG_proyecto.Text = row.ItemArray(3).ToString

            For Each row In dt.Rows                                             'Se llena información de acuerdo a día de la semana que haya gira
                day = Date.Parse(row.ItemArray(4))
                day_num = day.DayOfWeek

                clsTx_date = DirectCast(Me.Controls.Find("PG_date_" + day_num.ToString(), True)(0), TextBox)
                clsTx_dest = DirectCast(Me.Controls.Find("PG_dest_" + day_num.ToString(), True)(0), TextBox)
                clsBx_hi = DirectCast(Me.Controls.Find("PG_hour_s_" + day_num.ToString(), True)(0), ComboBox)
                clsBx_ho = DirectCast(Me.Controls.Find("PG_hour_f_" + day_num.ToString(), True)(0), ComboBox)
                clsBx_mi = DirectCast(Me.Controls.Find("PG_min_s_" + day_num.ToString(), True)(0), ComboBox)
                clsBx_mo = DirectCast(Me.Controls.Find("PG_min_f_" + day_num.ToString(), True)(0), ComboBox)
                clsBx_provs = DirectCast(Me.Controls.Find("PG_Prov_" + day_num.ToString(), True)(0), ComboBox)
                clsBx_locas = DirectCast(Me.Controls.Find("PG_loca_" + day_num.ToString(), True)(0), ComboBox)
                clsLst_insps = DirectCast(Me.Controls.Find("PG_insp_" + day_num.ToString(), True)(0), ListBox)
                clsLst_buddy = DirectCast(Me.Controls.Find("PG_buddy_" + day_num.ToString(), True)(0), ListBox)
                clsLst_car = DirectCast(Me.Controls.Find("PG_carros_" + day_num.ToString(), True)(0), ListBox)

                clsTx_date.Text = day.ToShortDateString                                                         'Se guarda fecha de gira
                clsTx_dest.Text = row.ItemArray(5).ToString                                                     'Se guarda cadena de destinos
                clsBx_provs.SelectedIndex = clsBx_provs.FindStringExact(row.ItemArray(6).ToString)              'S
                clsBx_locas.SelectedIndex = clsBx_locas.FindStringExact(row.ItemArray(7).ToString)
                straux = row.ItemArray(8).ToString()
                aux = Split(straux, ":")
                clsBx_hi.SelectedIndex = clsBx_hi.FindStringExact(aux(0))
                clsBx_mi.SelectedIndex = clsBx_mi.FindStringExact(aux(1))
                aux = Nothing
                straux = row.ItemArray(9).ToString()
                aux = Split(straux, ":")
                clsBx_ho.Text = aux(0)
                clsBx_mo.Text = aux(1)
                aux = Nothing
                aux = Split(row.ItemArray(10).ToString(), ", ")
                For Each item In aux
                    clsLst_insps.SetSelected(clsLst_insps.FindStringExact(item), True)
                Next
            Next
        End If
        PG_pends.ClearSelected()
    End Sub

    '%%% Llama de vuelta a ventana principal al cerrar la interfaz de giras %%%
    Private Sub Exitform(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main_app.Show()
    End Sub
End Class

'Di no pos un saludo