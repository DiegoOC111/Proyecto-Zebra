Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text



Public Class Form1
    Private Class Etiqueta
        Public Nombre As String
        Public Etiqueta As String
        Public ancho As String
        Public alto As String
        Public Overrides Function ToString() As String
            Return Nombre
        End Function
    End Class




    Dim ZPACT As Etiqueta
    Dim Prueba As String = "^XA~TA000~JSN^LT0^MNW^MTD^PON^PMN^LH0,0^JMA^PR3,3~SD10^JUS^LRN^CI0^XZ" & vbCrLf &
"^XA" & vbCrLf &
"^MMT" & vbCrLf &
"^PW432" & vbCrLf &
"^LL0240" & vbCrLf &
"^LS0" & vbCrLf &
"^FO96,64^GFA,02688,02688,00028,:Z64:" & vbCrLf &
"eJxjYBgFo2BYApN2k46Lr4SdPRfKrWwvO3o7eX31ilTFjddG5UblRuVG5UaKHMWAnyGAgb8Cu1zExsszOL2wSjFP8ApZwll5AKccXyBWOYaIUyFLOIJwuMXw8gwOD1wuZWnAJTMKBicAAKcXOxo=:96C3" & vbCrLf &
"^FT30,37^A0N,23,24^FH\^FD<Des1>^FS" & vbCrLf &
"^SL0" & vbCrLf &
"^FT313,228^A0N,18,16" & vbCrLf &
"^FC%,{,#" & vbCrLf &
"^FD%d-%m-%Y^FS" & vbCrLf &
"^FT30,64^A0N,23,24^FH\^FD<Des2>^FS" & vbCrLf &
"^PQ1,0,1,Y^XZ"

    Dim Bodega_Supermercado As String = "^XA~TA000~JSN^LT0^MNW^MTD^PON^PMN^LH0,0^JMA^PR3,3~SD10^JUS^LRN^CI0^XZ" & vbCrLf &
"^XA" & vbCrLf &
"^MMT" & vbCrLf &
"^PW432" & vbCrLf &
"^LL0240" & vbCrLf &
"^LS0" & vbCrLf &
"^FO96,64^GFA,02688,02688,00028,:Z64:" & vbCrLf &
"eJxjYBgFo2BYApN2k46Lr4SdPRfKrWwvO3o7eX31ilTFjddG5UblRuVG5UaKHMWAnyGAgb8Cu1zExsszOL2wSjFP8ApZwll5AKccXyBWOYaIUyFLOIJwuMXw8gwOD1wuZWnAJTMKBicAAKcXOxo=:96C3" & vbCrLf &
"^FT30,37^A0N,23,24^FH\^FD<Des1>^FS" & vbCrLf &
"^SL0" & vbCrLf &
"^FT313,228^A0N,18,16" & vbCrLf &
"^FC%,{,#" & vbCrLf &
"^FD%d-%m-%Y^FS" & vbCrLf &
"^FT30,64^A0N,23,24^FH\^FD<Des2>^FS" & vbCrLf &
"^PQ1,0,1,Y^XZ"

    Dim Venta_Agricola As String = "^XA~TA000~JSN^LT0^MNW^MTD^PON^PMN^LH0,0^JMA^PR3,3~SD10^JUS^LRN^CI0^XZ" & vbCrLf &
    "^XA" & vbCrLf &
    "^MMT" & vbCrLf &
    "^PW432" & vbCrLf &
    "^LL0240" & vbCrLf &
    "^LS0" & vbCrLf &
    "^FT17,38^A0N,34,33^FH\^FD<Nom>^FS" & vbCrLf &
    "^FT19,73^A0N,17,16^FH\^FD<Sb>^FS" & vbCrLf &
    "^SL0" & vbCrLf &
    "^FT172,232^A0N,31,31" & vbCrLf &
    "^FC%,{,#" & vbCrLf &
    "^FD%d/%m/%y^FS" & vbCrLf &
    "^FT19,128^A0N,44,45^FH\^FD<Dinero>^FS" & vbCrLf &
    "^FT19,166^A0N,17,14^FH\^FD<Desc>^FS" & vbCrLf &
    "^FT19,197^A0N,17,14^FH\^FD<Cod>^FS" & vbCrLf &
    "^PQ1,0,1,Y^XZ"
    Dim Bodega_Agricola As String = $"^XA~TA000~JSN^LT0^MNW^MTD^PON^PMN^LH0,0^JMA^PR3,3~SD10^JUS^LRN^CI0^XZ
^XA
^MMT
^PW432
^LL0240
^LS0
^BY2,3,48^FT51,100^BCN,,Y,N
^FD>:<Codigo>0^FS
^FT18,29^A0N,18,43^FH\^FD<Titulo>^FS
^FT18,151^A0N,14,14^FH\^FD<Desc1>^FS
^FT18,172^A0N,14,14^FH\^FD<Desc2>^FS
^FT141,219^A0N,18,33^FH\^FD<Fecha>^FS
^PQ1,0,1,Y^XZ
"
    Dim Mixta_Supermercado As String = $"^XA~TA000~JSN^LT0^MNW^MTD^PON^PMN^LH0,0^JMA^PR3,3~SD10^JUS^LRN^CI0^XZ
^XA
^MMT
^PW831
^LL0400
^LS0
^FT55,65^A0N,31,31^FH\^FD<Desc>^FS
^FO410,106^GB0,182,8^FS
^FT55,342^A0N,37,36^FH\^FDHasta <UdXMen>^FS
^FT455,333^A0N,28,28^FH\^FDDesde <UdXMay> Unidades^FS
^BY2,3,50^FT455,84^BCN,,Y,N
^FD>:<Cod>0^FS
^FT455,224^A0N,52,50^FH\^FD<Precio>^FS
^FT455,266^A0N,18,16^FH\^FD<PreXMed> X <Med>^FS
^FT55,224^A0N,52,50^FH\^FD<Precio>^FS
^PQ1,0,1,Y^XZ"



    ' Lista global para mantener las etiquetas
    Private listaEtiquetas As New List(Of Etiqueta)


    ' Tus cadenas ZPL (Prueba, Bodega_Supermercado, etc) quedan igual...

    ' ... aquí van tus variables Prueba, Bodega_Supermercado, Venta_Agricola, etc ...

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Creo las etiquetas
        Dim Etiqueta_A_V As Etiqueta = New Etiqueta With {
            .Nombre = "Etiqueta Venta 3x5 Agricola",
            .Etiqueta = Venta_Agricola,
            .ancho = "2",
            .alto = "1.3"
        }
        Dim Etiqueta_A_B As Etiqueta = New Etiqueta With {
            .Nombre = "Etiqueta Bodega 3x5 Agricola",
            .Etiqueta = Bodega_Agricola,
            .ancho = "2",
            .alto = "1.3"
        }
        Dim Etiqueta_S_B As Etiqueta = New Etiqueta With {
            .Nombre = "Etiqueta Bodega 3x5 Supermercado",
            .Etiqueta = Bodega_Supermercado,
            .ancho = "2",
            .alto = "1.3"
        }
        Dim Etiqueta_S_MIX As Etiqueta = New Etiqueta With {
            .Nombre = "Etiqueta Bodega 5x10 Supermercado",
            .Etiqueta = Mixta_Supermercado,
            .ancho = "4",
            .alto = "2"
        }
        Dim Etiqueta_J As Etiqueta = New Etiqueta With {
            .Nombre = "Etiqueta Jorge",
            .Etiqueta = Prueba
        }
        Dim Etiqueta_v As Etiqueta = New Etiqueta With {
            .Nombre = "Etiqueta Vacia",
            .Etiqueta = ""
        }

        ' Limpio y agrego las etiquetas a la lista global
        listaEtiquetas.Clear()
        listaEtiquetas.Add(Etiqueta_A_V)
        listaEtiquetas.Add(Etiqueta_A_B)
        listaEtiquetas.Add(Etiqueta_S_B)
        listaEtiquetas.Add(Etiqueta_S_MIX)
        listaEtiquetas.Add(Etiqueta_J)
        listaEtiquetas.Add(Etiqueta_v)

        ' Limpio y lleno el ComboBox solo con los nombres
        Combo_Etiquetas.Items.Clear()
        For Each etq As Etiqueta In listaEtiquetas
            Combo_Etiquetas.Items.Add(etq.Nombre)
        Next

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Combo_Etiquetas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Etiquetas.SelectedIndexChanged
        Dim nombreSeleccionado As String = Combo_Etiquetas.SelectedItem.ToString()
        ' Busco la etiqueta en la lista
        ZPACT = listaEtiquetas.Find(Function(x) x.Nombre = nombreSeleccionado)
        If ZPACT IsNot Nothing Then
            Txt_zpl.Text = ZPACT.Etiqueta
            Txt_Alto.Text = ZPACT.alto
            Txt_Ancho.Text = ZPACT.ancho
        End If
    End Sub

    Public Sub EnviarEtiqueta(ZPL As String)
        Dim bmp1 As Bitmap = Nothing
        Dim fechaActual As String = DateTime.Now.ToString("dd/MM/yyyy") ' Formato de fecha como en B4A
        Dim printerIP As String = Txt_ip.Text  ' IP de tu impresora
        Dim printerPort As Integer = Txt_Puerto.Text         ' Puerto típico para Zebra
        Dim cliente As TcpClient = Nothing

        Try
            ' Crear ZPL dinámicamente


            ' Conectar a la impresora
            cliente = New TcpClient()
            cliente.Connect(printerIP, printerPort)

            If cliente.Connected Then
                Using stream As NetworkStream = cliente.GetStream()
                    ' Limpiar memoria de la impresora (opcional)
                    Dim limpiarMemoria As String = "^XA^IDR:*.*^XZ"
                    Dim bytesLimpiar As Byte() = Encoding.UTF8.GetBytes(limpiarMemoria)
                    stream.Write(bytesLimpiar, 0, bytesLimpiar.Length)

                    ' Enviar ZPL
                    Dim bytesZPL As Byte() = Encoding.UTF8.GetBytes(ZPL)
                    stream.Write(bytesZPL, 0, bytesZPL.Length)

                    MessageBox.Show("Se ha impreso la etiqueta correctamente", "Impresión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Else
                MessageBox.Show("No se pudo conectar con la impresora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al imprimir: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar conexión
            If cliente IsNot Nothing AndAlso cliente.Connected Then
                cliente.Close()
            End If
        End Try
    End Sub

    Private Sub Btn_Impimir_Click(sender As Object, e As EventArgs) Handles Btn_Impimir.Click
        EnviarEtiqueta(Txt_zpl.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Calibrar.Click
        Dim ZP = $"^XA
~JC
^XZ"
        EnviarEtiqueta(ZP)
    End Sub

    Private Sub Btn_ver_Click(sender As Object, e As EventArgs) Handles Btn_ver.Click
        Dim zpl As String = Txt_zpl.Text
        Dim url As String

        ' URL con DPI y tamaño de etiqueta pequeña

        url = $"https://api.labelary.com/v1/printers/8dpmm/labels/{Txt_Ancho.Text}x{Txt_Alto.Text}/0/"



        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/x-www-form-urlencoded"
        request.Accept = "image/png"

        Dim zplBytes As Byte() = Encoding.UTF8.GetBytes(zpl)
        request.ContentLength = zplBytes.Length

        Try
            Using stream As Stream = request.GetRequestStream()
                stream.Write(zplBytes, 0, zplBytes.Length)
            End Using

            Using response As WebResponse = request.GetResponse()
                Using responseStream As Stream = response.GetResponseStream()
                    Dim image As Image = Image.FromStream(responseStream)
                    Imagen.Image = image
                    Imagen.SizeMode = PictureBoxSizeMode.Zoom
                End Using
            End Using
        Catch ex As WebException
            MessageBox.Show("Error al generar la etiqueta: " & ex.Message)
        End Try
        Imagen.Visible = True

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txt_zpl.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txt_Puerto.TextChanged

    End Sub
End Class
