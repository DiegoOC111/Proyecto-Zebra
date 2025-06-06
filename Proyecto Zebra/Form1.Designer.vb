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
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Impimir
        '
        Me.Btn_Impimir.Location = New System.Drawing.Point(160, 188)
        Me.Btn_Impimir.Name = "Btn_Impimir"
        Me.Btn_Impimir.Size = New System.Drawing.Size(351, 96)
        Me.Btn_Impimir.TabIndex = 0
        Me.Btn_Impimir.Text = "Imprimir"
        Me.Btn_Impimir.UseVisualStyleBackColor = True
        '
        'Combo_Etiquetas
        '
        Me.Combo_Etiquetas.FormattingEnabled = True
        Me.Combo_Etiquetas.Location = New System.Drawing.Point(390, 120)
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
        Me.Btn_Calibrar.Location = New System.Drawing.Point(543, 188)
        Me.Btn_Calibrar.Name = "Btn_Calibrar"
        Me.Btn_Calibrar.Size = New System.Drawing.Size(198, 96)
        Me.Btn_Calibrar.TabIndex = 3
        Me.Btn_Calibrar.Text = "Calibrar"
        Me.Btn_Calibrar.UseVisualStyleBackColor = True
        '
        'Btn_ver
        '
        Me.Btn_ver.Location = New System.Drawing.Point(766, 188)
        Me.Btn_ver.Name = "Btn_ver"
        Me.Btn_ver.Size = New System.Drawing.Size(166, 96)
        Me.Btn_ver.TabIndex = 4
        Me.Btn_ver.Text = "Visualizar"
        Me.Btn_ver.UseVisualStyleBackColor = True
        '
        'Imagen
        '
        Me.Imagen.Location = New System.Drawing.Point(372, 376)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(516, 219)
        Me.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imagen.TabIndex = 5
        Me.Imagen.TabStop = False
        Me.Imagen.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 719)
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
End Class
