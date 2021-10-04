<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_preço = New System.Windows.Forms.TextBox()
        Me.txt_unidades = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.radio_taxa10 = New System.Windows.Forms.RadioButton()
        Me.radio_taxa15 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "preço por unidade"
        '
        'txt_preço
        '
        Me.txt_preço.Location = New System.Drawing.Point(115, 52)
        Me.txt_preço.Name = "txt_preço"
        Me.txt_preço.Size = New System.Drawing.Size(100, 20)
        Me.txt_preço.TabIndex = 1
        '
        'txt_unidades
        '
        Me.txt_unidades.Location = New System.Drawing.Point(115, 90)
        Me.txt_unidades.Name = "txt_unidades"
        Me.txt_unidades.Size = New System.Drawing.Size(100, 20)
        Me.txt_unidades.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "quantas unidades"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(146, 127)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'radio_taxa10
        '
        Me.radio_taxa10.AutoSize = True
        Me.radio_taxa10.Location = New System.Drawing.Point(50, 126)
        Me.radio_taxa10.Name = "radio_taxa10"
        Me.radio_taxa10.Size = New System.Drawing.Size(68, 17)
        Me.radio_taxa10.TabIndex = 5
        Me.radio_taxa10.TabStop = True
        Me.radio_taxa10.Text = "taxa 10%"
        Me.radio_taxa10.UseVisualStyleBackColor = True
        '
        'radio_taxa15
        '
        Me.radio_taxa15.AutoSize = True
        Me.radio_taxa15.Location = New System.Drawing.Point(50, 149)
        Me.radio_taxa15.Name = "radio_taxa15"
        Me.radio_taxa15.Size = New System.Drawing.Size(68, 17)
        Me.radio_taxa15.TabIndex = 6
        Me.radio_taxa15.TabStop = True
        Me.radio_taxa15.Text = "taxa 15%"
        Me.radio_taxa15.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(131, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(88, 247)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(118, 20)
        Me.TextBox3.TabIndex = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 315)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.radio_taxa15)
        Me.Controls.Add(Me.radio_taxa10)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txt_unidades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_preço)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_preço As TextBox
    Friend WithEvents txt_unidades As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents radio_taxa10 As RadioButton
    Friend WithEvents radio_taxa15 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
