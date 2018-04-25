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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Alta = New System.Windows.Forms.Button
        Me.Baja = New System.Windows.Forms.Button
        Me.Modificar = New System.Windows.Forms.Button
        Me.Grabar_xml = New System.Windows.Forms.Button
        Me.Leer_xml = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(20, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 254)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(210, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Alta
        '
        Me.Alta.Location = New System.Drawing.Point(318, 34)
        Me.Alta.Name = "Alta"
        Me.Alta.Size = New System.Drawing.Size(45, 32)
        Me.Alta.TabIndex = 1
        Me.Alta.Text = "Alta"
        Me.Alta.UseVisualStyleBackColor = True
        '
        'Baja
        '
        Me.Baja.Location = New System.Drawing.Point(318, 100)
        Me.Baja.Name = "Baja"
        Me.Baja.Size = New System.Drawing.Size(45, 33)
        Me.Baja.TabIndex = 2
        Me.Baja.Text = "Baja"
        Me.Baja.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(318, 159)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(61, 45)
        Me.Modificar.TabIndex = 3
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Grabar_xml
        '
        Me.Grabar_xml.Location = New System.Drawing.Point(318, 235)
        Me.Grabar_xml.Name = "Grabar_xml"
        Me.Grabar_xml.Size = New System.Drawing.Size(61, 47)
        Me.Grabar_xml.TabIndex = 5
        Me.Grabar_xml.Text = "Grabar_xml"
        Me.Grabar_xml.UseVisualStyleBackColor = True
        '
        'Leer_xml
        '
        Me.Leer_xml.Location = New System.Drawing.Point(418, 235)
        Me.Leer_xml.Name = "Leer_xml"
        Me.Leer_xml.Size = New System.Drawing.Size(62, 47)
        Me.Leer_xml.TabIndex = 6
        Me.Leer_xml.Text = "Leer_xml"
        Me.Leer_xml.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 340)
        Me.Controls.Add(Me.Leer_xml)
        Me.Controls.Add(Me.Grabar_xml)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.Baja)
        Me.Controls.Add(Me.Alta)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Alta As System.Windows.Forms.Button
    Friend WithEvents Baja As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Grabar_xml As System.Windows.Forms.Button
    Friend WithEvents Leer_xml As System.Windows.Forms.Button

End Class
