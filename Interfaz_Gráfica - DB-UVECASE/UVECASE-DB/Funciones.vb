Imports MySql.Data.MySqlClient
Module PG_Funciones
    '#### Módulo para interacción con bases de datos, cálculos y rutinas auxiliares de programación. ##### 

    '%%% Función que establece consecutivo a usar para registro %%%
    Public Function PG_cons_new(solicitud As Date) As Integer                'Primeramente se comienza estableciendo el número de consecutivo a usar
        Using Temp_conn As New MySqlConnection(Conn.ConnectionString)
            proc = "PG_ultimo_cons"
            Dim cmd As New MySqlCommand(proc, Temp_conn)                     'Se define comando a enviar, y se cambia de query tradicional a rutina guardada.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fecha", solicitud)                 'Se carga parámetro a comando, con valor
            Try
                Temp_conn.Open()
                Dim DB_output As Object = cmd.ExecuteScalar                  'Objeto genérico para almacenar info de DB
                Dim Cons As Integer = 1                                      'Se asume que es primera gira del año (PG-1)
                If IsDBNull(DB_output) = False Then                          'Consulta puede retonar nulo. Se guarda en "object" para atajar DBnull
                    Cons = CInt(DB_output) + 1                               'Si consulta retorna entero, se devuelve el valor
                End If
                Temp_conn.Close()
                Return Cons
            Catch ex As MySqlException                                       'Se ataja error en comunicación con base de datos
                MessageBox.Show("Error con base de datos: " + ex.Message)
                Temp_conn.Close()
                Return 0
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)                      'Cualquier otro error muestra el mensaje.
                Temp_conn.Close()
                Return 0
            End Try
        End Using
    End Function

    '%%% Borra registros de giras que no se hayan aprobado %%%
    Public Function PG_eliminar_gira(ByVal Cons As Integer) As Boolean
        Using Temp_conn As New MySqlConnection(Conn.ConnectionString)
            proc = "PG_eliminar_gira"
            Dim cmd As New MySqlCommand(proc, Temp_conn)                     'Se define comando a enviar, y se cambia de query tradicional a rutina guardada.
            Dim transaction As MySqlTransaction = Nothing
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@cons", Convert.ToInt16(Cons))      'Se carga parámetro a comando, con valor
            Try
                Temp_conn.Open()                                             'Se comienza proceso de transacción
                transaction = Temp_conn.BeginTransaction
                cmd.Transaction = transaction
                Dim returnValue As String = cmd.ExecuteNonQuery
                transaction.Commit()                                         'Ejecute cambios
                Temp_conn.Close()
                Return True
            Catch ex As MySqlException                                       'Se ataja error en comunicación con base de datos
                MessageBox.Show("Error con base de datos: " + ex.Message)
                transaction.Rollback()                                       'Se revierte cualquier cambio por una transacción fallida
                Temp_conn.Close()
                Return False
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)                      'Cualquier otro error muestra el mensaje.
                transaction.Rollback()                                       'Se revierte cualquier cambio por una transacción fallida
                Temp_conn.Close()
                Return False
            End Try
        End Using
    End Function

    '%%% Rutina que crea estructura para enviar información a base de datos (Involucra escritura) %%%
    Public Function PG_guardar_gira(ByVal Day_info As PG_datos) As Boolean
        Using Temp_conn As New MySqlConnection(Conn.ConnectionString)
            Dim transaction As MySqlTransaction = Nothing                    '
            proc = "PG_crear_gira"
            Dim cmd As New MySqlCommand(proc, Temp_conn)                                    'Se define comando a enviar, y se cambia de query tradicional a rutina guardada.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@con", Convert.ToInt16(Day_info.Consecutivo))      'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@fech_sol", Day_info.Fecha.guardada)               'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@fech", Day_info.Fecha_gira)                       'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@dest", Day_info.Destinos)                         'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@provs", Day_info.Provincia)                       'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@loca", Day_info.Localidad)                        'Se carga parámetro a comando, con valor   
            cmd.Parameters.AddWithValue("@h_ini", Day_info.Hora_inicio)                     'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@h_out", Day_info.Hora_fin)                        'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@insp", Day_info.Objetivos)                        'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@vehic", Day_info.Vehiculos)                       'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@acomps", Day_info.Participantes)                  'Se carga parámetro a comando, con valor
            Try
                Temp_conn.Open()                                                            'Se comienza proceso de transacción
                transaction = Temp_conn.BeginTransaction
                cmd.Transaction = transaction
                Dim returnValue As String = cmd.ExecuteNonQuery
                transaction.Commit()
                Temp_conn.Close()
                Return True
            Catch ex As MySqlException                                       'Se ataja error en comunicación con base de datos
                MessageBox.Show("Error con base de datos: " + ex.Message)
                transaction.Rollback()                                       'Se revierte cualquier cambio por una transacción fallida
                Temp_conn.Close()
                Dim close As Boolean = PG_eliminar_gira(Day_info.Consecutivo) 'Se borra gira en control
                Return False
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)                      'Cualquier otro error muestra el mensaje.
                transaction.Rollback()                                       'Se revierte cualquier cambio por una transacción fallida
                Temp_conn.Close()
                Dim close As Boolean = PG_eliminar_gira(Day_info.Consecutivo) 'Se borra gira en control
                Return False
            End Try
        End Using
    End Function

    '%%% Función que devuelve todos los elementos de una lista en un solo string de una línea, con elementos separados por comas.
    Public Function List_2_String(ByVal Listita As List(Of String)) As String
        Dim conv_str As String = vbEmpty

        For Each item In Listita
            conv_str += String.Concat(item, ", ")
        Next

        Return conv_str
    End Function

    '%%% Rutina que crea el control de gira, base fundamental para las demás etapas de la gira. (Involucra escritura)
    Public Sub PG_crear_control(ByVal con As Integer, ByVal fech As Date, ByVal enc As String, ByVal proy As String)
        Using Temp_conn As New MySqlConnection(Conn.ConnectionString)
            Dim transaction As MySqlTransaction = Nothing
            Dim con_16 As Short = Convert.ToInt16(con)
            proc = "PG_crear_control"
            Dim cmd As New MySqlCommand(proc, Temp_conn)                     'Se define comando a enviar, y se cambia de query tradicional a rutina guardada.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@con", con_16)                      'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@fech", fech)                       'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@enc", enc)                         'Se carga parámetro a comando, con valor
            cmd.Parameters.AddWithValue("@proy", proy)                       'Se carga parámetro a comando, con valor
            Try
                Temp_conn.Open()                                             'Se comienza proceso de transacción
                transaction = Temp_conn.BeginTransaction
                cmd.Transaction = transaction
                Dim returnValue As String = cmd.ExecuteNonQuery
                transaction.Commit()
                Temp_conn.Close()

            Catch ex As MySqlException                                       'Se ataja error en comunicación con base de datos
                MessageBox.Show("Error en comunicación con base de datos")
                transaction.Rollback()                                       'Se revierte cualquier cambio por una transacción fallida
                Temp_conn.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)                      'Cualquier otro error muestra el mensaje.
                transaction.Rollback()                                       'Se revierte cualquier cambio por una transacción fallida
                Temp_conn.Close()
            End Try
        End Using
    End Sub

    '%%% Se carga la información de las giras pendientes, y se pasa de datatable a forms %%%
    Public Function PG_carga_info(ByVal cons As Integer) As DataTable
        Dim dt As New DataTable
        Using Temp_conn As New MySqlConnection(Conn.ConnectionString)
            Try
                proc = "PG_cargar_info"
                Dim cmd As New MySqlCommand(proc, Temp_conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@pgcons", Convert.ToInt16(cons))
                Temp_conn.Open()
                Dim MySQL_DT As New MySqlDataAdapter(cmd)                       'Se ensambla comando y se llena tabla de datos
                Dim MySQL_CMD As New MySqlCommandBuilder(MySQL_DT)
                MySQL_DT.Fill(dt)
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try
        End Using
        Return dt
    End Function

    '%%% Borra texto y elementos seleccionados %%%
    Public Sub Clear_form(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            'Clear_form(ctrl)
            If TypeOf ctrl Is TextBox Then                      'Se borra texto de textboxes.
                CType(ctrl, TextBox).Text = String.Empty

            ElseIf TypeOf ctrl Is ComboBox Then
                If CType(ctrl, ComboBox).Items.Count <> 0 Then
                    CType(ctrl, ComboBox).SelectedIndex = 0     'Se reinicia comboboxes

                End If
            ElseIf TypeOf ctrl Is ListBox Then
                If CType(ctrl, ListBox).Items.Count <> 0 Then
                    CType(ctrl, ListBox).SelectedIndex = 0
                    CType(ctrl, ListBox).ClearSelected()        'Se quitan elementos seleccionados en listbox

                End If
            ElseIf TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False           'Se deseleccionan casillas 
            End If
        Next
    End Sub

    '%%% Convierte fecha de VB a formato leíble por SQL %%%
    Public Function Date_ToSQL(ByVal fecha As Date) As date_data
        Dim struc As New date_data With {
            .guardada = fecha,
            .regresada = "0"
        }

        Return struc
    End Function

    '%%% Función que retorna un 1 si detecta elemento en campo de texto
    Public Function G_IsTX_empty(ByVal clstx As TextBox) As Integer
        If String.IsNullOrWhiteSpace(clstx.Text) = True Then
            Return 0
        Else
            Return 1
        End If

    End Function

    '%%% Función que retorna un 1 si detecta elemento en campo de texto de combobox
    Public Function G_IsCB_empty(ByVal clsbx As ComboBox) As Integer
        If String.IsNullOrWhiteSpace(clsbx.Text) = True Then
            Return 0
        Else
            Return 1
        End If
    End Function

    '%%% Función que regresa 1 si existen elementos seleccionados en el listbox
    Public Function G_IsLB_empty(ByVal clslst As ListBox) As Integer
        If clslst.SelectedItems.Count > 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function


End Module

Module AG_Funciones
    '#### Módulo para interacción con bases de datos, cálculos y rutinas auxiliares de elementos de adelanto ##### 

    '%%% Se envía estado de aprobado a gira, dado consecutivo %%%
    Public Function PG_aprobar_gira(ByVal cons As Int16) As Boolean
        Using Temp_conn As New MySqlConnection(Conn.ConnectionString)
            Dim transaction As MySqlTransaction = Nothing
            proc = "PG_aprobar_gira"
            Dim cmd As New MySqlCommand(proc, Temp_conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@cons", cons)                        'Se carga parámetro a comando, con valor
            Try
                Temp_conn.Open()                                              'Se comienza proceso de transacción
                transaction = Temp_conn.BeginTransaction
                cmd.Transaction = transaction
                Dim returnValue As String = cmd.ExecuteNonQuery
                transaction.Commit()
                Temp_conn.Close()
                Return True
            Catch ex As MySqlException                                        'Se ataja error en comunicación con base de datos
                MessageBox.Show("Error con base de datos: " + ex.Message)
                transaction.Rollback()                                        'Se revierte cualquier cambio por una transacción fallida
                Temp_conn.Close()
                Return False
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)                       'Cualquier otro error muestra el mensaje.
                transaction.Rollback()                                        'Se revierte cualquier cambio por una transacción fallida
                Temp_conn.Close()
                Return False
            End Try
        End Using
    End Function


End Module