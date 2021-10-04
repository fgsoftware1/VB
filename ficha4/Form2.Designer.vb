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
        Me.check_desconto5 = New System.Windows.Forms.CheckBox()
        Me.radio_taxa10 = New System.Windows.Forms.RadioButton()
        Me.radio_taxa15 = New System.Windows.Forms.RadioButton()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
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
        'check_desconto5
        '
        Me.check_desconto5.AutoSize = True
        Me.check_desconto5.Location = New System.Drawing.Point(146, 127)
        Me.check_desconto5.Name = "check_desconto5"
        Me.check_desconto5.Size = New System.Drawing.Size(87, 17)
        Me.check_desconto5.TabIndex = 4
        Me.check_desconto5.Text = "desconto 5%"
        Me.check_desconto5.UseVisualStyleBackColor = True
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
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(50, 188)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 32)
        Me.btn_calcular.TabIndex = 7
        Me.btn_calcular.Text = "calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(131, 188)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(75, 32)
        Me.btn_limpar.TabIndex = 8
        Me.btn_limpar.Text = "limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(31, 247)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(50, 13)
        Me.lbl_resultado.TabIndex = 9
        Me.lbl_resultado.Text = "resulatdo"
        '
        'txt_resultado
        '
        Me.txt_resultado.Location = New System.Drawing.Point(88, 247)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(118, 20)
        Me.txt_resultado.TabIndex = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 315)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.radio_taxa15)
        Me.Controls.Add(Me.radio_taxa10)
        Me.Controls.Add(Me.check_desconto5)
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
    Friend WithEvents check_desconto5 As CheckBox
    Friend WithEvents radio_taxa10 As RadioButton
    Friend WithEvents radio_taxa15 As RadioButton
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents lbl_resultado As Label
    Friend WithEvents txt_resultado As TextBox
End Class
