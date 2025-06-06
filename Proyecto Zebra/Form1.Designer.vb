<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Impimir = New System.Windows.Forms.Button()
        Me.Combo_Etiquetas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Calibrar = New System.Windows.Forms.Button()
        Me.Btn_ver = New System.Windows.Forms.Button()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.Txt_zpl = New System.Windows.Forms.RichTextBox()
        Me.Txt_Puerto = New System.Windows.Forms.TextBox()
        Me.Txt_ip = New System.Windows.Forms.TextBox()
        Me.Txt_Alto = New System.Windows.Forms.TextBox()
        Me.Txt_Ancho = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Impimir
        '
        Me.Btn_Impimir.Location = New System.Drawing.Point(26, 465)
        Me.Btn_Impimir.Name = "Btn_Impimir"
        Me.Btn_Impimir.Size = New System.Drawing.Size(281, 96)
        Me.Btn_Impimir.TabIndex = 0
        Me.Btn_Impimir.Text = "Imprimir"
        Me.Btn_Impimir.UseVisualStyleBackColor = True
        '
        'Combo_Etiquetas
        '
        Me.Combo_Etiquetas.FormattingEnabled = True
        Me.Combo_Etiquetas.Location = New System.Drawing.Point(71, 83)
        Me.Combo_Etiquetas.Name = "Combo_Etiquetas"
        Me.Combo_Etiquetas.Size = New System.Drawing.Size(351, 24)
        Me.Combo_Etiquetas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(599, 51)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione un tipo de etiqueta"
        '
        'Btn_Calibrar
        '
        Me.Btn_Calibrar.Location = New System.Drawing.Point(71, 567)
        Me.Btn_Calibrar.Name = "Btn_Calibrar"
        Me.Btn_Calibrar.Size = New System.Drawing.Size(198, 96)
        Me.Btn_Calibrar.TabIndex = 3
        Me.Btn_Calibrar.Text = "Calibrar"
        Me.Btn_Calibrar.UseVisualStyleBackColor = True
        '
        'Btn_ver
        '
        Me.Btn_ver.Location = New System.Drawing.Point(884, 476)
        Me.Btn_ver.Name = "Btn_ver"
        Me.Btn_ver.Size = New System.Drawing.Size(166, 96)
        Me.Btn_ver.TabIndex = 4
        Me.Btn_ver.Text = "Visualizar"
        Me.Btn_ver.UseVisualStyleBackColor = True
        '
        'Imagen
        '
        Me.Imagen.Location = New System.Drawing.Point(324, 488)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(516, 219)
        Me.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagen.TabIndex = 5
        Me.Imagen.TabStop = False
        Me.Imagen.Visible = False
        '
        'Txt_zpl
        '
        Me.Txt_zpl.Location = New System.Drawing.Point(62, 113)
        Me.Txt_zpl.Name = "Txt_zpl"
        Me.Txt_zpl.Size = New System.Drawing.Size(1038, 276)
        Me.Txt_zpl.TabIndex = 7
        Me.Txt_zpl.Text = ""
        '
        'Txt_Puerto
        '
        Me.Txt_Puerto.Location = New System.Drawing.Point(896, 85)
        Me.Txt_Puerto.Name = "Txt_Puerto"
        Me.Txt_Puerto.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Puerto.TabIndex = 8
        Me.Txt_Puerto.Text = "9100"
        '
        'Txt_ip
        '
        Me.Txt_ip.Location = New System.Drawing.Point(495, 85)
        Me.Txt_ip.Name = "Txt_ip"
        Me.Txt_ip.Size = New System.Drawing.Size(357, 22)
        Me.Txt_ip.TabIndex = 9
        Me.Txt_ip.Text = "192.168.1.178"
        '
        'Txt_Alto
        '
        Me.Txt_Alto.Location = New System.Drawing.Point(392, 450)
        Me.Txt_Alto.Name = "Txt_Alto"
        Me.Txt_Alto.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Alto.TabIndex = 10
        Me.Txt_Alto.Text = "0.0"
        '
        'Txt_Ancho
        '
        Me.Txt_Ancho.Location = New System.Drawing.Point(522, 450)
        Me.Txt_Ancho.Name = "Txt_Ancho"
        Me.Txt_Ancho.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Ancho.TabIndex = 11
        Me.Txt_Ancho.Text = "0.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 431)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Alto_(Pulgadas)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(519, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Ancho_(Pulgadas)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(614, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ip"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(928, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Puerto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 719)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Ancho)
        Me.Controls.Add(Me.Txt_Alto)
        Me.Controls.Add(Me.Txt_ip)
        Me.Controls.Add(Me.Txt_Puerto)
        Me.Controls.Add(Me.Txt_zpl)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.Btn_ver)
        Me.Controls.Add(Me.Btn_Calibrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Combo_Etiquetas)
        Me.Controls.Add(Me.Btn_Impimir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Impimir As Button
    Friend WithEvents Combo_Etiquetas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Calibrar As Button
    Friend WithEvents Btn_ver As Button
    Friend WithEvents Imagen As PictureBox
    Friend WithEvents Txt_zpl As RichTextBox
    Friend WithEvents Txt_Puerto As TextBox
    Friend WithEvents Txt_ip As TextBox
    Friend WithEvents Txt_Alto As TextBox
    Friend WithEvents Txt_Ancho As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
