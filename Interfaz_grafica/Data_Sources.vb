Imports MySql.Data.MySqlClient
Module Data_Sources
    '%%% MÓDULO PARA DECLARACIÓN DE ESCTRUCTURAS DE DATOS, Y ORIGINES DE DATOS PROVENIENTES DE BD PARA USO EN VARIAS INTERFACES %%%

    Public lista_agencias As New System.Data.DataTable

    '****ESTRUCTURAS DE DATOS PARA EXPORTAR/IMPORTAR A/DE BASE DE DATOS*******************
    Public Structure date_data          'Innecesario
        Public guardada As DateTime
        Public regresada As String
    End Structure

    Public Class PG_consecutivo    'Base para programación de giras
        Private struc As date_data
        Public Property Fecha As date_data
            Get
                Return struc
            End Get
            Set(ByVal value As date_data)
                struc.guardada = value.guardada
                struc.regresada = value.guardada.ToString("yyyy-MM-dd")   'Innecesario también, pero que pereza quitarlo lmao
                '  struc = value
            End Set
        End Property
        Public Property Consecutivo As Integer
        Public Property Encargado As String
        Public Property Proyecto As String
    End Class

    Public Class G_observaciones    'Lista de observaciones
        Inherits PG_consecutivo
        Public Property PG_observaciones As String          'Como son segmentos largos de texto, se guardan por aparte y de manera opcional.
        Public Property AG_observaciones As String
        Public Property LV_observaciones As String
    End Class

    Public Class PG_datos   'Datos diarios de gira semanal
        Inherits PG_consecutivo 'Se hereda propiedades bases
        Public Property Fecha_gira As Date
        Public Property Destinos As String
        Public Property Provincia As String
        Public Property Localidad As String
        Public Property Hora_inicio As TimeSpan
        Public Property Hora_fin As TimeSpan
        Public Property Objetivos As String
        Public Property Vehiculos As String
        Public Property Participantes As String
    End Class

    '****LLENADO DE ELEMENTOS DE PROPÓSITO GENERAL****************************
    'Clase propia, para fijar hora en formato string
    Public Class Tiempo_c
        Private _count As String
        Public Property Time_c() As String
            Get
                Return _count               'Envía string
            End Get
            Set(ByVal val As String)
                _count = val                'Recibe string
            End Set
        End Property
    End Class

    'Lista de horas
    Public Function Clock_h() As List(Of Tiempo_c)
        Dim horas As New List(Of Tiempo_c)
        For i = 0 To 23
            Dim hora As New Tiempo_c
            If i < 10 Then
                hora.Time_c = "0" + i.ToString 'Se inserta "0" para que horas queden en formato de dos dígitos 
            Else
                hora.Time_c = i.ToString
            End If
            horas.Add(hora)
        Next
        Return horas
    End Function

    'Lista de minutos
    Public Function Clock_min() As List(Of Tiempo_c)
        Dim minutos As New List(Of Tiempo_c)
        For i = 0 To 59
            Dim min As New Tiempo_c
            If i < 10 Then
                min.Time_c = "0" + i.ToString 'Se inserta "0" para que minutos queden en formato de dos dígitos 
            Else
                min.Time_c = i.ToString
            End If
            minutos.Add(min)
        Next

        Return minutos
    End Function

    '****LLENADO DE ELEMENTOS DE GIRAS*****************************************
    'Lista de Provincias
    Public Function Lista_provs() As DataTable
        Dim dt As New DataTable
        Dim emptyRow As DataRow = dt.NewRow 'Fila vacía

        'Nombre de rutina
        proc = "lista_provincias"

        'Se define comando a enviar, y se cambia de query tradicional a rutina guardada.
        Using Temp_conn As New MySqlConnection(Conn.ConnectionString)
            Dim cmd As New MySqlCommand(proc, Temp_conn)
            cmd.CommandType = CommandType.StoredProcedure
            Temp_conn.Open()
            'Se ensambla comando y se llena tabla de datos
            Dim MySQL_DT As New MySqlDataAdapter(cmd)
            Dim MySQL_CMD As New MySqlCommandBuilder(MySQL_DT)
            MySQL_DT.Fill(dt)
            Temp_conn.Close()
        End Using

        'Se inserta como primera fila en la tabla creada
        dt.Rows.InsertAt(emptyRow, 0)
        Return dt
    End Function

    '%%% Carga lista de pendientes
    Public Function PG_pendientes() As DataTable
        Dim dt As New DataTable
        Using Temp_conn As New MySqlConnection(Conn.ConnectionString)
            Try
                proc = "PG_pendientes"
                Dim cmd As New MySqlCommand(proc, Temp_conn)
                cmd.CommandType = CommandType.StoredProcedure
                Temp_conn.Open()
                'Se ensambla comando y se llena tabla de datos
                Dim MySQL_DT As New MySqlDataAdapter(cmd)
                Dim MySQL_CMD As New MySqlCommandBuilder(MySQL_DT)
                MySQL_DT.Fill(dt)
                Temp_conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try
        End Using
        Return dt
    End Function

    '%%% Lista de Localizaciones %%%
    Public Function Lista_locs(ByVal Provincia As String) As DataTable
        Dim dt As New DataTable

        If (Provincia.Length < 12) And (String.IsNullOrEmpty(Provincia) = False) Then
            'Nombre de rutina
            proc = "lista_loca"

            'Se define comando a enviar, y se cambia de query tradicional a rutina guardada.
            Dim cmd As New MySqlCommand(proc, Conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@prov", Provincia) 'Se carga parámetro a comando, con valor

            'Se ensambla comando y se llena tabla de datos
            Dim MySQL_DT As New MySqlDataAdapter(cmd)
            Dim MySQL_CMD As New MySqlCommandBuilder(MySQL_DT)

            MySQL_DT.Fill(dt)
        Else
            dt.Clear()
        End If

        Return dt
    End Function

    '%%% Lista de tipos de inspecciones %%%
    Public Sub Insp_types(job_list As ListBox)

        ' job_list.Items.Add("")
        job_list.Items.Add("Instalación monofásica")
        job_list.Items.Add("Instalación trifásica")
        job_list.Items.Add("Desinstalación monofásica")
        job_list.Items.Add("Desinstalación trifásica")

    End Sub

    '%%% Lista de tipos de personal %%%     '*****SE DEBE ACTUALIZAR****
    Public Sub Partners_list(job_list As ListBox)
        'Cuando esté lista la plataforma de usuarios, se debe hacer la consulta y cargar a un DT.
        ' job_list.Items.Add("")
        job_list.Items.Add("Tec. Tencio ")
        job_list.Items.Add("Ing. Luis Ramírez")

    End Sub

    '%%% Lista de proyectos de UVECASE %%%
    Public Sub Proyects_fill(proyects As ComboBox)

        proyects.Items.Add("")
        proyects.Items.Add("UVECASE")

    End Sub

    '****LLENADO DE ELEMENTOS PARA INVENTARIO**********************************
    '%%% Lista de carros disponibles para UVECASE %%%
    Public Function Lista_carros() As DataTable
        Dim dt As New DataTable
        proc = "lista_carros"

        'Se define comando a enviar, y se cambia de query tradicional a rutina guardada.
        Dim cmd As New MySqlCommand(proc, Conn)
        cmd.CommandType = CommandType.StoredProcedure

        'Se ensambla comando y se llena tabla de datos
        Dim MySQL_DT As New MySqlDataAdapter(cmd)
        Dim MySQL_CMD As New MySqlCommandBuilder(MySQL_DT)

        MySQL_DT.Fill(dt)

        Return dt
    End Function

    'Equipos
End Module
