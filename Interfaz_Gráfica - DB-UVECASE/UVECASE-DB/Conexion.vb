
'Módulo para definición comandos a enviar por consultas a SQL
Module Conexion

    '********************************************************************************************************************************************************************************************
    'Conexión con base de datos. Modificar según el servidor donde esté alojada
    Public queryString As String = "Server=UVECASE-Champion;Database=instrucciones"
    Public Conn As New MySql.Data.MySqlClient.MySqlConnection() 'Declaración de objeto de conexión
    Public cmd As New MySql.Data.MySqlClient.MySqlCommand(proc, Conn) 'Declaración de objeto de comando

    '********************************************************************************************************************************************************************************************
    'Definición de comandos para interactuar con base de datos.
    Public proc As String = " "

End Module
