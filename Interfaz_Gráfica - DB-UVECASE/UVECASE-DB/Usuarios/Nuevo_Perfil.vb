Imports System.ComponentModel

Public Class Curriculum_Vitae
    'indica el nombre del nuevo panel para la sección de puestos en UVECASE 
    Private currentpanelname As String = Nothing
    'indica el numero del nuevo panel para la sección de puestos en UVECASE 
    Private panelsaddedcount As Integer = 0
    'crea un nuevo panel para la sección de puestos en UVECASE
    Public Sub createpanel1()
        Dim panel1 As Panel
        panel1 = New Panel()
        'le proporciona las caracteristicas al panel
        With panel1
            .BackColor = Color.Linen
            .AutoSize = False
            .Size = New Size(1120, 45)
            .Name = “panel” + (panelsaddedcount + 1).ToString
        End With
        'agrega el nuevo panel al flow_layup_panel que contiene las filas de la sección de puestos en UVECASE
        FlowLayoutPanel2.Controls.Add(panel1)
        'actualiza el nombre y el numero del nuevo panel
        currentpanelname = panel1.Name
        panelsaddedcount += 1

    End Sub


    'crea una fila para el nuevo panel 
    Public Sub NuevaLinea1(ByVal panelName As String)
        'Se crea una funcion global para introducir lienas en la seccion de puestos en UVECASE llamada nuevalinea1, esta nueva linea consta de tres text box
        Dim texto1 As TextBox
        texto1 = New TextBox()
        'se Crean los textboxes y se agregan sus propiedades
        With texto1
            .Size = New Size(628, 43)
            .Location = New Point(1, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim texto2 As TextBox
        texto2 = New TextBox()
        With texto2
            .Size = New Size(269, 43)
            .Location = New Point(634, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim texto3 As TextBox
        texto3 = New TextBox()
        With texto3
            .Size = New Size(172, 43)
            .Location = New Point(907, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With
        'Se crea un boton para eliminar el nuevo panel y sus componentes
        Dim delete1 As Button
        delete1 = New Button
        'Se agregan las propiedades del boton
        With delete1
            .AutoSize = False
            .BackColor = Color.LightGray
            .Location = New Point(1080, 1)
            .Size = New Size(20, 43)
            .Text = "-"
            .Name = "buttondelete1" + (panelsaddedcount).ToString
        End With
        'Se introducen los elementos (textboxes y el botón) al nuevo panel
        For Each controlobj As Control In FlowLayoutPanel2.Controls
            If controlobj.Name = panelName Then
                controlobj.Controls.Add(texto1)
                controlobj.Controls.Add(texto2)
                controlobj.Controls.Add(texto3)
                controlobj.Controls.Add(delete1)
            End If
        Next
        ' se crea un handler para el boton que elimina las filas
        AddHandler delete1.Click, AddressOf DynamicButton_click1
    End Sub
    'crea la funcion para el boton que elimina las filas
    Public Sub DynamicButton_click1(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentpanelname As String
        parentpanelname = Nothing
        'elimina el handler del boton que ha sido clickeado
        For Each controlObj1 As Control In FlowLayoutPanel2.Controls
            For Each childcontrolObj1 As Control In controlObj1.Controls
                If childcontrolObj1.Name = sender.name Then
                    RemoveHandler childcontrolObj1.Click, AddressOf DynamicButton_click1
                    parentpanelname = childcontrolObj1.Parent.Name
                End If
            Next
        Next
        'elimina la fila donde esta el boton clickeado
        For Each controlobj1 As Control In FlowLayoutPanel2.Controls
            If controlobj1.Name = parentpanelname Then
                FlowLayoutPanel2.Controls.Remove(controlobj1)
                controlobj1.Dispose()
            End If
        Next

    End Sub

    'indica el nombre del nuevo panel para la sección de Estudios
    Private currentpanelname1 As String = Nothing
    'indica el numero del nuevo panel para la sección de puestos en UVECASE 
    Private panelsaddedcount1 As Integer = 0
    'crea un nuevo panel para la sección de estudios
    Public Sub createpanel2()
        Dim panel2 As Panel
        panel2 = New Panel()
        'le proporciona las caracteristicas al panel
        With panel2
            .BackColor = Color.Linen
            .AutoSize = False
            .Size = New Size(1810, 45)
            .Name = “panelestudios” + (panelsaddedcount1 + 1).ToString
        End With
        'agrega el nuevo panel al flow_layup_panel que contiene las filas de la sección de puestos en UVECASE
        FlowLayoutPanel1.Controls.Add(panel2)
        'actualiza el nombre y el numero del nuevo panel
        currentpanelname1 = panel2.Name
        panelsaddedcount1 += 1

    End Sub


    'crea una fila para el nuevo panel 
    Public Sub NuevaLinea2(ByVal panelName As String)
        'Se crea una funcion global para introducir lienas en la seccion de puestos en UVECASE llamada nuevalinea1, esta nueva linea consta de cinco text box y un boton
        Dim textoestudio1 As TextBox
        textoestudio1 = New TextBox()
        'se Crean los textboxes y se agregan sus propiedades
        With textoestudio1
            .Size = New Size(460, 43)
            .Location = New Point(1, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textoestudio2 As TextBox
        textoestudio2 = New TextBox()
        With textoestudio2
            .Size = New Size(160, 43)
            .Location = New Point(467, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textoestudio3 As TextBox
        textoestudio3 = New TextBox()
        With textoestudio3
            .Size = New Size(160, 43)
            .Location = New Point(633, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With


        Dim textoestudio4 As TextBox
        textoestudio4 = New TextBox()
        With textoestudio4
            .Size = New Size(480, 43)
            .Location = New Point(799, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With


        Dim textoestudio5 As TextBox
        textoestudio5 = New TextBox()
        With textoestudio5
            .Size = New Size(480, 43)
            .Location = New Point(1285, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        'Se crea un boton para eliminar el nuevo panel y sus componentes
        Dim deleteestudios As Button
        deleteestudios = New Button
        'Se agregan las propiedades del boton
        With deleteestudios
            .AutoSize = False
            .BackColor = Color.LightGray
            .Location = New Point(1770, 1)
            .Size = New Size(20, 43)
            .Text = "-"
            .Name = "buttondeleteestudios" + (panelsaddedcount1).ToString
        End With
        'Se introducen los elementos (textboxes y el botón) al nuevo panel
        For Each controlobj As Control In FlowLayoutPanel1.Controls
            If controlobj.Name = panelName Then
                controlobj.Controls.Add(textoestudio1)
                controlobj.Controls.Add(textoestudio2)
                controlobj.Controls.Add(textoestudio3)
                controlobj.Controls.Add(textoestudio4)
                controlobj.Controls.Add(textoestudio5)
                controlobj.Controls.Add(deleteestudios)
            End If
        Next
        ' se crea un handler para el boton que elimina las filas
        AddHandler deleteestudios.Click, AddressOf DynamicButton_click2
    End Sub
    'crea la funcion para el boton que elimina las filas
    Public Sub DynamicButton_click2(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentpanelname1 As String
        parentpanelname1 = Nothing
        'elimina el handler del boton que ha sido clickeado
        For Each controlObj2 As Control In FlowLayoutPanel1.Controls
            For Each childcontrolObj2 As Control In controlObj2.Controls
                If childcontrolObj2.Name = sender.name Then
                    RemoveHandler childcontrolObj2.Click, AddressOf DynamicButton_click2
                    parentpanelname1 = childcontrolObj2.Parent.Name
                End If
            Next
        Next
        'elimina la fila donde esta el boton clickeado
        For Each controlobj2 As Control In FlowLayoutPanel1.Controls
            If controlobj2.Name = parentpanelname1 Then
                FlowLayoutPanel1.Controls.Remove(controlobj2)
                controlobj2.Dispose()
            End If
        Next

    End Sub


    'indica el nombre del nuevo panel para la sección de puestos en UVECASE 
    Private currentpanelname2 As String = Nothing
    'indica el numero del nuevo panel para la sección de puestos en UVECASE 
    Private panelsaddedcount2 As Integer = 0
    'crea un nuevo panel para la sección de IDIOMAS
    Public Sub createpanel3()
        Dim panel3 As Panel
        panel3 = New Panel()
        'le proporciona las caracteristicas al panel
        With panel3
            .BackColor = Color.Linen
            .AutoSize = False
            .Size = New Size(920, 45)
            .Name = “panelidiomas” + (panelsaddedcount2 + 1).ToString
        End With
        'agrega el nuevo panel al flow_layup_panel que contiene las filas de la sección de puestos en UVECASE
        FlowLayoutPanel3.Controls.Add(panel3)
        'actualiza el nombre y el numero del nuevo panel
        currentpanelname2 = panel3.Name
        panelsaddedcount2 += 1

    End Sub


    'crea una fila para el nuevo panel 
    Public Sub NuevaLinea3(ByVal panelName As String)
        'Se crea una funcion global para introducir lineas en la seccion de idiomas llamada nuevalinea3, esta nueva linea consta de un text box, tres list boxes y un boton
        Dim textoidioma1 As TextBox
        textoidioma1 = New TextBox()
        'se Crean los textboxes y se agregan sus propiedades
        With textoidioma1
            .Size = New Size(390, 43)
            .Location = New Point(1, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim lista1 As ListBox
        lista1 = New ListBox()
        With lista1
            .Size = New Size(160, 43)
            .Location = New Point(398, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With
        'Se agregan los items a la lista
        lista1.Items.Add("50%")
        lista1.Items.Add("60%")
        lista1.Items.Add("70%")
        lista1.Items.Add("80%")
        lista1.Items.Add("90%")
        lista1.Items.Add("100%")

        Dim lista2 As ListBox
        lista2 = New ListBox()
        With lista2
            .Size = New Size(160, 43)
            .Location = New Point(564, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With
        'Se agregan los items a la lista
        lista2.Items.Add("50%")
        lista2.Items.Add("60%")
        lista2.Items.Add("70%")
        lista2.Items.Add("80%")
        lista2.Items.Add("90%")
        lista2.Items.Add("100%")

        Dim lista3 As ListBox
        lista3 = New ListBox()
        With lista3
            .Size = New Size(160, 43)
            .Location = New Point(730, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With
        'Se agregan los items a la lista
        lista3.Items.Add("50%")
        lista3.Items.Add("60%")
        lista3.Items.Add("70%")
        lista3.Items.Add("80%")
        lista3.Items.Add("90%")
        lista3.Items.Add("100%")

        'Se crea un boton para eliminar el nuevo panel y sus componentes
        Dim delete3 As Button
        delete3 = New Button
        'Se agregan las propiedades del boton
        With delete3
            .AutoSize = False
            .BackColor = Color.LightGray
            .Location = New Point(900, 1)
            .Size = New Size(20, 43)
            .Text = "-"
            .Name = "buttondeleteidioma" + (panelsaddedcount2).ToString
        End With
        'Se introducen los elementos (textboxes y el botón) al nuevo panel
        For Each controlobj As Control In FlowLayoutPanel3.Controls
            If controlobj.Name = panelName Then
                controlobj.Controls.Add(textoidioma1)
                controlobj.Controls.Add(lista1)
                controlobj.Controls.Add(lista2)
                controlobj.Controls.Add(lista3)
                controlobj.Controls.Add(delete3)
            End If
        Next
        ' se crea un handler para el boton que elimina las filas
        AddHandler delete3.Click, AddressOf DynamicButton_click3
    End Sub
    'crea la funcion para el boton que elimina las filas
    Public Sub DynamicButton_click3(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentpanelname As String
        parentpanelname = Nothing
        'elimina el handler del boton que ha sido clickeado
        For Each controlObj3 As Control In FlowLayoutPanel3.Controls
            For Each childcontrolObj3 As Control In controlObj3.Controls
                If childcontrolObj3.Name = sender.name Then
                    RemoveHandler childcontrolObj3.Click, AddressOf DynamicButton_click3
                    parentpanelname = childcontrolObj3.Parent.Name
                End If
            Next
        Next
        'elimina la fila donde esta el boton clickeado
        For Each controlobj3 As Control In FlowLayoutPanel3.Controls
            If controlobj3.Name = parentpanelname Then
                FlowLayoutPanel3.Controls.Remove(controlobj3)
                controlobj3.Dispose()
            End If
        Next

    End Sub


    'indica el nombre del nuevo panel para la sección de IDIOMAS 
    Private currentpanelname3 As String = Nothing
    'indica el numero del nuevo panel para la sección de IDIOMAS
    Private panelsaddedcount3 As Integer = 0
    'crea un nuevo panel para la sección de EXPERIENCIA LABORAL
    Public Sub createpanel4()
        Dim panel4 As Panel
        panel4 = New Panel()
        'le proporciona las caracteristicas al panel
        With panel4
            .BackColor = Color.Linen
            .AutoSize = False
            .Size = New Size(1785, 45)
            .Name = “panelexperiencia” + (panelsaddedcount3 + 1).ToString
        End With
        'agrega el nuevo panel al flow_layup_panel que contiene las filas de la sección de EXPERIENCIA LABORAL
        FlowLayoutPanel4.Controls.Add(panel4)
        'actualiza el nombre y el numero del nuevo panel
        currentpanelname3 = panel4.Name
        panelsaddedcount3 += 1

    End Sub


    'crea una fila para el nuevo panel 
    Public Sub NuevaLinea4(ByVal panelName As String)
        'Se crea una funcion global para introducir lineas en la seccion de idiomas llamada nuevalinea4, esta nueva linea consta de cinco text boxes y un boton
        Dim textoexperiencia1 As TextBox
        textoexperiencia1 = New TextBox()
        'se Crean los textboxes y se agregan sus propiedades
        With textoexperiencia1
            .Size = New Size(490, 43)
            .Location = New Point(1, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textoexperiencia2 As TextBox
        textoexperiencia2 = New TextBox()
        With textoexperiencia2
            .Size = New Size(490, 43)
            .Location = New Point(497, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textoexperiencia3 As TextBox
        textoexperiencia3 = New TextBox()
        With textoexperiencia3
            .Size = New Size(490, 43)
            .Location = New Point(993, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textoexperiencia4 As TextBox
        textoexperiencia4 = New TextBox()
        With textoexperiencia4
            .Size = New Size(125, 43)
            .Location = New Point(1489, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textoexperiencia5 As TextBox
        textoexperiencia5 = New TextBox()
        With textoexperiencia5
            .Size = New Size(125, 43)
            .Location = New Point(1620, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        'Se crea un boton para eliminar el nuevo panel y sus componentes
        Dim delete4 As Button
        delete4 = New Button
        'Se agregan las propiedades del boton
        With delete4
            .AutoSize = False
            .BackColor = Color.LightGray
            .Location = New Point(1750, 1)
            .Size = New Size(20, 43)
            .Text = "-"
            .Name = "buttondeleteexperiencia" + (panelsaddedcount3).ToString
        End With
        'Se introducen los elementos (textboxes y el botón) al nuevo panel
        For Each controlobj As Control In FlowLayoutPanel4.Controls
            If controlobj.Name = panelName Then
                controlobj.Controls.Add(textoexperiencia1)
                controlobj.Controls.Add(textoexperiencia2)
                controlobj.Controls.Add(textoexperiencia3)
                controlobj.Controls.Add(textoexperiencia4)
                controlobj.Controls.Add(textoexperiencia5)
                controlobj.Controls.Add(delete4)
            End If
        Next
        ' se crea un handler para el boton que elimina las filas
        AddHandler delete4.Click, AddressOf DynamicButton_click4
    End Sub
    'crea la funcion para el boton que elimina las filas
    Public Sub DynamicButton_click4(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentpanelname As String
        parentpanelname = Nothing
        'elimina el handler del boton que ha sido clickeado
        For Each controlObj4 As Control In FlowLayoutPanel4.Controls
            For Each childcontrolObj4 As Control In controlObj4.Controls
                If childcontrolObj4.Name = sender.name Then
                    RemoveHandler childcontrolObj4.Click, AddressOf DynamicButton_click4
                    parentpanelname = childcontrolObj4.Parent.Name
                End If
            Next
        Next
        'elimina la fila donde esta el boton clickeado
        For Each controlobj4 As Control In FlowLayoutPanel4.Controls
            If controlobj4.Name = parentpanelname Then
                FlowLayoutPanel4.Controls.Remove(controlobj4)
                controlobj4.Dispose()
            End If
        Next

    End Sub

    'indica el nombre del nuevo panel para la sección de puestos ANTERIORES UVECASE 
    Private currentpanelname4 As String = Nothing
    'indica el numero del nuevo panel para la sección de puestos ANTERIORES UVECASE 
    Private panelsaddedcount4 As Integer = 0
    'crea un nuevo panel para la sección de puestos ANTERIORES UVECASE
    Public Sub createpanel5()
        Dim panel5 As Panel
        panel5 = New Panel()
        'le proporciona las caracteristicas al panel
        With panel5
            .BackColor = Color.Linen
            .AutoSize = False
            .Size = New Size(1305, 45)
            .Name = “panelpuestosant” + (panelsaddedcount4 + 1).ToString
        End With
        'agrega el nuevo panel al flow_layup_panel que contiene las filas de la sección de puestos ANTERIORES UVECASE
        FlowLayoutPanel5.Controls.Add(panel5)
        'actualiza el nombre y el numero del nuevo panel
        currentpanelname4 = panel5.Name
        panelsaddedcount4 += 1

    End Sub


    'crea una fila para el nuevo panel 
    Public Sub NuevaLinea5(ByVal panelName As String)
        'Se crea una funcion global para introducir lineas en la seccion de idiomas llamada nuevalinea5, esta nueva linea consta de cuatro text boxes y un boton
        Dim textopuestosant1 As TextBox
        textopuestosant1 = New TextBox()
        'se Crean los textboxes y se agregan sus propiedades
        With textopuestosant1
            .Size = New Size(490, 43)
            .Location = New Point(1, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textopuestosant2 As TextBox
        textopuestosant2 = New TextBox()
        With textopuestosant2
            .Size = New Size(490, 43)
            .Location = New Point(497, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textopuestosant3 As TextBox
        textopuestosant3 = New TextBox()
        With textopuestosant3
            .Size = New Size(125, 43)
            .Location = New Point(993, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textopuestosant4 As TextBox
        textopuestosant4 = New TextBox()
        With textopuestosant4
            .Size = New Size(125, 43)
            .Location = New Point(1124, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        'Se crea un boton para eliminar el nuevo panel y sus componentes
        Dim delete5 As Button
        delete5 = New Button
        'Se agregan las propiedades del boton
        With delete5
            .AutoSize = False
            .BackColor = Color.LightGray
            .Location = New Point(1260, 1)
            .Size = New Size(20, 43)
            .Text = "-"
            .Name = "buttondeletepuestosant" + (panelsaddedcount4).ToString
        End With
        'Se introducen los elementos (textboxes y el botón) al nuevo panel
        For Each controlobj As Control In FlowLayoutPanel5.Controls
            If controlobj.Name = panelName Then
                controlobj.Controls.Add(textopuestosant1)
                controlobj.Controls.Add(textopuestosant2)
                controlobj.Controls.Add(textopuestosant3)
                controlobj.Controls.Add(textopuestosant4)
                controlobj.Controls.Add(delete5)
            End If
        Next
        ' se crea un handler para el boton que elimina las filas
        AddHandler delete5.Click, AddressOf DynamicButton_click5
    End Sub
    'crea la funcion para el boton que elimina las filas
    Public Sub DynamicButton_click5(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentpanelname As String
        parentpanelname = Nothing
        'elimina el handler del boton que ha sido clickeado
        For Each controlObj5 As Control In FlowLayoutPanel5.Controls
            For Each childcontrolObj5 As Control In controlObj5.Controls
                If childcontrolObj5.Name = sender.name Then
                    RemoveHandler childcontrolObj5.Click, AddressOf DynamicButton_click5
                    parentpanelname = childcontrolObj5.Parent.Name
                End If
            Next
        Next
        'elimina la fila donde esta el boton clickeado
        For Each controlobj5 As Control In FlowLayoutPanel5.Controls
            If controlobj5.Name = parentpanelname Then
                FlowLayoutPanel5.Controls.Remove(controlobj5)
                controlobj5.Dispose()
            End If
        Next

    End Sub

    'indica el nombre del nuevo panel para la sección de CAPACITACION 
    Private currentpanelname5 As String = Nothing
    'indica el numero del nuevo panel para la sección de CAPACITACION 
    Private panelsaddedcount5 As Integer = 0
    'crea un nuevo panel para la sección de CAPACITACION
    Public Sub createpanel6()
        Dim panel6 As Panel
        panel6 = New Panel()
        'le proporciona las caracteristicas al panel
        With panel6
            .BackColor = Color.Linen
            .AutoSize = False
            .Size = New Size(1305, 45)
            .Name = “panelcapacitacion” + (panelsaddedcount5 + 1).ToString
        End With
        'agrega el nuevo panel al flow_layup_panel que contiene las filas de la sección de puestos en UVECASE
        FlowLayoutPanel6.Controls.Add(panel6)
        'actualiza el nombre y el numero del nuevo panel
        currentpanelname5 = panel6.Name
        panelsaddedcount5 += 1

    End Sub


    'crea una fila para el nuevo panel 
    Public Sub NuevaLinea6(ByVal panelName As String)
        'Se crea una funcion global para introducir lineas en la seccion de idiomas llamada nuevalinea6, esta nueva linea consta de cuatro text boxes y un boton
        Dim textocapacitacion1 As TextBox
        textocapacitacion1 = New TextBox()
        'se Crean los textboxes y se agregan sus propiedades
        With textocapacitacion1
            .Size = New Size(490, 43)
            .Location = New Point(1, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textocapacitacion2 As TextBox
        textocapacitacion2 = New TextBox()
        With textocapacitacion2
            .Size = New Size(490, 43)
            .Location = New Point(497, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textocapacitacion3 As TextBox
        textocapacitacion3 = New TextBox()
        With textocapacitacion3
            .Size = New Size(125, 43)
            .Location = New Point(993, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textocapacitacion4 As TextBox
        textocapacitacion4 = New TextBox()
        With textocapacitacion4
            .Size = New Size(125, 43)
            .Location = New Point(1124, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        'Se crea un boton para eliminar el nuevo panel y sus componentes
        Dim delete6 As Button
        delete6 = New Button
        'Se agregan las propiedades del boton
        With delete6
            .AutoSize = False
            .BackColor = Color.LightGray
            .Location = New Point(1260, 1)
            .Size = New Size(20, 43)
            .Text = "-"
            .Name = "buttondeletecapacitacion" + (panelsaddedcount5).ToString
        End With
        'Se introducen los elementos (textboxes y el botón) al nuevo panel
        For Each controlobj As Control In FlowLayoutPanel6.Controls
            If controlobj.Name = panelName Then
                controlobj.Controls.Add(textocapacitacion1)
                controlobj.Controls.Add(textocapacitacion2)
                controlobj.Controls.Add(textocapacitacion3)
                controlobj.Controls.Add(textocapacitacion4)
                controlobj.Controls.Add(delete6)
            End If
        Next
        ' se crea un handler para el boton que elimina las filas
        AddHandler delete6.Click, AddressOf DynamicButton_click6
    End Sub
    'crea la funcion para el boton que elimina las filas
    Public Sub DynamicButton_click6(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentpanelname As String
        parentpanelname = Nothing
        'elimina el handler del boton que ha sido clickeado
        For Each controlObj6 As Control In FlowLayoutPanel6.Controls
            For Each childcontrolObj6 As Control In controlObj6.Controls
                If childcontrolObj6.Name = sender.name Then
                    RemoveHandler childcontrolObj6.Click, AddressOf DynamicButton_click6
                    parentpanelname = childcontrolObj6.Parent.Name
                End If
            Next
        Next
        'elimina la fila donde esta el boton clickeado
        For Each controlobj6 As Control In FlowLayoutPanel6.Controls
            If controlobj6.Name = parentpanelname Then
                FlowLayoutPanel6.Controls.Remove(controlobj6)
                controlobj6.Dispose()
            End If
        Next

    End Sub

    'indica el nombre del nuevo panel para la sección de DOCUMENTOS 
    Private currentpanelname6 As String = Nothing
    'indica el numero del nuevo panel para la sección de DOCUMENTOS
    Private panelsaddedcount6 As Integer = 0
    'crea un nuevo panel para la sección de DOCUMENTOS
    Public Sub createpanel7()
        Dim panel7 As Panel
        panel7 = New Panel()
        'le proporciona las caracteristicas al panel
        With panel7
            .BackColor = Color.Linen
            .AutoSize = False
            .Size = New Size(850, 45)
            .Name = “panelDOCUMENTO” + (panelsaddedcount6 + 1).ToString
        End With
        'agrega el nuevo panel al flow_layup_panel que contiene las filas de la sección de DOCUMENTOS
        FlowLayoutPanel7.Controls.Add(panel7)
        'actualiza el nombre y el numero del nuevo panel
        currentpanelname6 = panel7.Name
        panelsaddedcount6 += 1

    End Sub


    'crea una fila para el nuevo panel 
    Public Sub NuevaLinea7(ByVal panelName As String)
        'Se crea una funcion global para introducir lineas en la seccion de idiomas llamada nuevalinea6, esta nueva linea consta de cuatro text boxes y un boton
        Dim textodocumento1 As TextBox
        textodocumento1 = New TextBox()
        'se Crean los textboxes y se agregan sus propiedades
        With textodocumento1
            .Size = New Size(600, 43)
            .Location = New Point(1, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        Dim textodocumento2 As TextBox
        textodocumento2 = New TextBox()
        With textodocumento2
            .Size = New Size(188, 43)
            .Location = New Point(607, 1)
            .Font = New Font("Gabriola", 15.75, FontStyle.Bold)
        End With

        'Se crea un boton para eliminar el nuevo panel y sus componentes
        Dim delete7 As Button
        delete7 = New Button
        'Se agregan las propiedades del boton
        With delete7
            .AutoSize = False
            .BackColor = Color.LightGray
            .Location = New Point(802, 1)
            .Size = New Size(20, 43)
            .Text = "-"
            .Name = "buttondeletedocumento" + (panelsaddedcount6).ToString
        End With
        'Se introducen los elementos (textboxes y el botón) al nuevo panel
        For Each controlobj As Control In FlowLayoutPanel7.Controls
            If controlobj.Name = panelName Then
                controlobj.Controls.Add(textodocumento1)
                controlobj.Controls.Add(textodocumento2)
                controlobj.Controls.Add(delete7)
            End If
        Next
        ' se crea un handler para el boton que elimina las filas
        AddHandler delete7.Click, AddressOf DynamicButton_click7
    End Sub
    'crea la funcion para el boton que elimina las filas
    Public Sub DynamicButton_click7(ByVal sender As Object, ByVal e As EventArgs)
        Dim parentpanelname As String
        parentpanelname = Nothing
        'elimina el handler del boton que ha sido clickeado
        For Each controlObj7 As Control In FlowLayoutPanel7.Controls
            For Each childcontrolObj7 As Control In controlObj7.Controls
                If childcontrolObj7.Name = sender.name Then
                    RemoveHandler childcontrolObj7.Click, AddressOf DynamicButton_click7
                    parentpanelname = childcontrolObj7.Parent.Name
                End If
            Next
        Next
        'elimina la fila donde esta el boton clickeado
        For Each controlobj7 As Control In FlowLayoutPanel7.Controls
            If controlobj7.Name = parentpanelname Then
                FlowLayoutPanel7.Controls.Remove(controlobj7)
                controlobj7.Dispose()
            End If
        Next

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TabControl1.SelectedTab = Pagina2
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        createpanel1()
        NuevaLinea1(currentpanelname)

    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabControl1.SelectedTab = Pagina1
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Al presionar el botón permite adjuntar una imagen 
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        createpanel2()
        NuevaLinea2(currentpanelname1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        createpanel3()
        NuevaLinea3(currentpanelname2)
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        createpanel4()
        NuevaLinea4(currentpanelname3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        createpanel5()
        NuevaLinea5(currentpanelname4)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        createpanel6()
        NuevaLinea6(currentpanelname5)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        createpanel7()
        NuevaLinea7(currentpanelname6)
    End Sub

    '%%% Cuando se cierra, se regresa a la pantalla principal %%%
    Private Sub Curriculum_Vitae_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main_app.Show()
    End Sub
End Class