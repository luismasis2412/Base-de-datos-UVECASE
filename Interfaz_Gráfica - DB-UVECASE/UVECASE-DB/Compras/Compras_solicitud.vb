
Public Class Compras_solicitud
    ' Estos son los datos que se debe cargar al abrir el formulario
    Private Sub Compras_solicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' se carga el formulario
        ' ENCARGADO
        EncTbox.Text = "Luis Emilio Vargas Ramírez" ' el encargado se debe tomar de la base de datos, una vez que este ingrese a al BD. Se define un nombre fijo para visualizar
        ' FECHA
        FecTbox.Text = Date.Now.ToString("dd/MM/yyyy") ' se carga la feha actual
        ' CONSECUTIVO
        ConTbox.Text = "001-UVECASE-2021" ' el consecutivo debe tomarse de la base de datos, cuando se usa un consecutivo este de alguna manera debe quedar como asignado para que no se vuelva a usar
    End Sub
    Private Sub ParCbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ParCbox.SelectedIndexChanged
        ' existen varias partidas
        ' los items fueron aregados en el objeto del formulario
        Dim Parnum As String = ParCbox.SelectedItem.ToString() ' el item seleccionado se almacena en la variable Parnum
        ' PARTIDA APROVADA SEGUN EN Parnum
        ' cuando se seleccione la partida, esta parte del codigo debe buscar dentro de la base de datos la partida aprovada segun el numero
        PartapTbox.Text = "10000" ' este valor será fijo para todo el periodo de contrato
        ' tambien, se debe llevar un control de cuanto de este monto se ha ejecutado, la partida ejecutada se registra de la base de datos
        PartejTbox.Text = "2000" ' este valor será diferente cada vez que el usuario realice una compra nueva con cada partida
        ' la partida disponible es la resta entre la aprobada y la ejecutada
        PartdiTbox.Text = PartapTbox.Text - PartejTbox.Text
    End Sub

    ' al dar click en el boton tramitar, se almacenan todas las variables para ser copiadas al pdf
    Private Sub TramBt_Click(sender As Object, e As EventArgs) Handles TramBt.Click
        ' Elementos de la primer linea (numero de proyecto, encargado, fecha actual, consecutivo)
        Dim Pnum = ProyCbox.Text, Encarg = EncTbox.Text, Fecact = FecTbox.Text, Conse = ConTbox.Text
        ' Elementos de la segunda linea (numero de partida, partida aprovada, partida ejecutada, partida disponible)
        Dim Parnum = ParCbox.SelectedItem.ToString(), Parap = PartapTbox.Text, Parej = PartejTbox.Text, Pardi = PartdiTbox.Text
        ' cuadros arriba a la derecha (descripción de la compra, justificación de la compra)
        Dim Descomp = DescpTbox.Text, Justcomp = JuscpTbox.Text
        ' linea tipo de compra
        Dim Tipocomp As String = vbEmpty
        If OrdcompChkbox.Checked = True Then
            Tipocomp = "Orden de compra"
        ElseIf IntcompChkbox.Checked = True Then
            Tipocomp = "Compra por internet"
        ElseIf CchicompChkbox.Checked = True Then
            Tipocomp = "Compra por caja chica"
        Else
            Tipocomp = "Congreso/pasantía/curso"
        End If
    End Sub

    'Private Sub AgrprovBt_Click(sender As Object, e As EventArgs) Handles AgrprovBt.Click
    '    AgregarProveedor.Show()
    'End Sub

    '%%% ACCIONES EN DETALLES DE LAS COTIZACIONES %%%
    '%%% Al marcar el primer checkbox se agrega el número a la siguiente casilla %%%
    Private Sub ProvChkbox1_CheckedChanged(sender As Object, e As EventArgs) Handles ProvChkbox1.CheckedChanged
        NumTbox1.Text = "1"
    End Sub

    '%%% Manejo de moneda y tipo de cambio %%%
    Private Sub MonCbox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MonCbox1.SelectedIndexChanged
        ' definimos una variable para determinar el tipo de moneda usada
        Dim moneda = MonCbox1.SelectedItem.ToString()
        ' si es en dolares o colones
        If moneda <> "Dólares" Then
            TcTbox1.Text = "620" ' el tipo de cambio se debe tomar de la base de datos, de internet o se puede digitar manualmente
            UsTbox1.Text = PrecTbox1.Text / TcTbox1.Text   ' se divide el precio en colones por el tipo de cambio
            UsTbox1.Text = FormatNumber(UsTbox1.Text, 2) ' para usar solo dos decimales
        Else
            TcTbox1.Text = "N.A." ' si el precio es en dolares el tipo de cambio no aplica
            UsTbox1.Text = PrecTbox1.Text ' precio y us son iguales
        End If
    End Sub
    '%%% Cuando se cierra el form, se carga el principal %%%
    Private Sub Compras_solicitud_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_app.Show()
    End Sub
End Class