
Imports System.Xml
Imports System.IO
Public Class Form1

    Private Sub Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alta.Click
        ComboBox1.Focus()
        '"elimina espacios en blanco
        If TextBox1.Text.Trim = "" Then Exit Sub

        TextBox1.Text.TrimStart()




        ComboBox1.Items.Add(TextBox1.Text.Trim)
        '"limpia el cuadro de texto
        TextBox1.Clear()
    End Sub

    Private Sub Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Baja.Click
        TextBox1.Focus()
        '"funciona solo si selecciono un elemento de la lista
        If ComboBox1.SelectedIndex = -1 Then Exit Sub
        '"remueve los items seleccionados
        ComboBox1.Items.RemoveAt(ComboBox1.SelectedIndex)

        'ListBox1.ClearSelected()

        TextBox1.Clear()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.Items.Item(ComboBox1.SelectedIndex)


        TextBox1.Focus()

    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        TextBox1.Focus()
        If ComboBox1.SelectedIndex = -1 Then Exit Sub


        ComboBox1.Items.Item(ComboBox1.SelectedIndex) = TextBox1.Text


        'ListBox1.ClearSelected()
        TextBox1.Clear()
    End Sub

    Private Sub Grabar_xml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grabar_xml.Click
        Dim Ruta As String
        ruta = CurDir.Substring(0, CurDir.Length - 9)
        Dim escritor As New XmlTextWriter(ruta + "Lista.xml", System.Text.Encoding.UTF8)
        escritor.WriteStartDocument(True)

        escritor.Formatting = Formatting.Indented

        escritor.Indentation = 4

        escritor.WriteStartElement("lista")
        Dim x As Integer


        For x = 0 To ComboBox1.Items.Count - 1

            escritor.WriteStartElement("elemento")
            escritor.WriteString(ComboBox1.Items.Item(x).ToString)
            escritor.WriteEndElement()






        Next


        escritor.WriteEndElement()
        escritor.WriteEndDocument()
        escritor.Close()

        MsgBox(" El mensaje ha sido guardado ")
        TextBox1.Focus()





    End Sub



    Private Sub Leer_xml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Leer_xml.Click

        Dim xmld As New XmlDocument
        Dim ListaNodos As XmlNodeList
        Dim nodo As XmlNode
        Dim ruta As String
        ruta = CurDir().Substring(0, CurDir().Length - 9)


        If Not File.Exists(ruta + "lista.xml") Then Exit Sub
        xmld.Load(ruta + "lista.xml")

        ListaNodos = xmld.SelectNodes("lista/elemento")

        For Each nodo In ListaNodos
            ComboBox1.Items.Add(nodo.InnerText)





        Next



        TextBox1.Focus()





    End Sub
End Class
