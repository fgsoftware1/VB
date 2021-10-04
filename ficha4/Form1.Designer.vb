<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_calculadora = New System.Windows.Forms.Label()
        Me.lbl_num1 = New System.Windows.Forms.Label()
        Me.txt_num1 = New System.Windows.Forms.TextBox()
        Me.txt_num2 = New System.Windows.Forms.TextBox()
        Me.lbl_num2 = New System.Windows.Forms.Label()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.radio_somar = New System.Windows.Forms.RadioButton()
        Me.radio_subtrair = New System.Windows.Forms.RadioButton()
        Me.radio_dividir = New System.Windows.Forms.RadioButton()
        Me.radio_multiplicar = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lbl_calculadora
        '
        Me.lbl_calculadora.AutoSize = True
        Me.lbl_calculadora.Location = New System.Drawing.Point(253, 24)
        Me.lbl_calculadora.Name = "lbl_calculadora"
        Me.lbl_calculadora.Size = New System.Drawing.Size(62, 13)
        Me.lbl_calculadora.TabIndex = 0
        Me.lbl_calculadora.Text = "calculadora"
        '
        'lbl_num1
        '
        Me.lbl_num1.AutoSize = True
        Me.lbl_num1.Location = New System.Drawing.Point(104, 76)
        Me.lbl_num1.Name = "lbl_num1"
        Me.lbl_num1.Size = New System.Drawing.Size(52, 13)
        Me.lbl_num1.TabIndex = 1
        Me.lbl_num1.Text = "1ºnumero"
        '
        'txt_num1
        '
        Me.txt_num1.Location = New System.Drawing.Point(182, 76)
        Me.txt_num1.Name = "txt_num1"
        Me.txt_num1.Size = New System.Drawing.Size(156, 20)
        Me.txt_num1.TabIndex = 2
        '
        'txt_num2
        '
        Me.txt_num2.Location = New System.Drawing.Point(182, 111)
        Me.txt_num2.Name = "txt_num2"
        Me.txt_num2.Size = New System.Drawing.Size(156, 20)
        Me.txt_num2.TabIndex = 4
        '
        'lbl_num2
        '
        Me.lbl_num2.AutoSize = True
        Me.lbl_num2.Location = New System.Drawing.Point(104, 111)
        Me.lbl_num2.Name = "lbl_num2"
        Me.lbl_num2.Size = New System.Drawing.Size(52, 13)
        Me.lbl_num2.TabIndex = 3
        Me.lbl_num2.Text = "2ºnumero"
        '
        'txt_resultado
        '
        Me.txt_resultado.Location = New System.Drawing.Point(182, 185)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(156, 20)
        Me.txt_resultado.TabIndex = 6
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(104, 185)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(50, 13)
        Me.lbl_resultado.TabIndex = 5
        Me.lbl_resultado.Text = "resultado"
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(182, 137)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 42)
        Me.btn_calcular.TabIndex = 7
        Me.btn_calcular.Text = "calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(263, 137)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(75, 42)
        Me.btn_limpar.TabIndex = 8
        Me.btn_limpar.Text = "limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'radio_somar
        '
        Me.radio_somar.AutoSize = True
        Me.radio_somar.Location = New System.Drawing.Point(376, 78)
        Me.radio_somar.Name = "radio_somar"
        Me.radio_somar.Size = New System.Drawing.Size(53, 17)
        Me.radio_somar.TabIndex = 9
        Me.radio_somar.TabStop = True
        Me.radio_somar.Text = "somar"
        Me.radio_somar.UseVisualStyleBackColor = True
        '
        'radio_subtrair
        '
        Me.radio_subtrair.AutoSize = True
        Me.radio_subtrair.Location = New System.Drawing.Point(376, 102)
        Me.radio_subtrair.Name = "radio_subtrair"
        Me.radio_subtrair.Size = New System.Drawing.Size(59, 17)
        Me.radio_subtrair.TabIndex = 10
        Me.radio_subtrair.TabStop = True
        Me.radio_subtrair.Text = "subtrair"
        Me.radio_subtrair.UseVisualStyleBackColor = True
        '
        'radio_dividir
        '
        Me.radio_dividir.AutoSize = True
        Me.radio_dividir.Location = New System.Drawing.Point(376, 149)
        Me.radio_dividir.Name = "radio_dividir"
        Me.radio_dividir.Size = New System.Drawing.Size(52, 17)
        Me.radio_dividir.TabIndex = 12
        Me.radio_dividir.TabStop = True
        Me.radio_dividir.Text = "dividir"
        Me.radio_dividir.UseVisualStyleBackColor = True
        '
        'radio_multiplicar
        '
        Me.radio_multiplicar.AutoSize = True
        Me.radio_multiplicar.Location = New System.Drawing.Point(376, 125)
        Me.radio_multiplicar.Name = "radio_multiplicar"
        Me.radio_multiplicar.Size = New System.Drawing.Size(71, 17)
        Me.radio_multiplicar.TabIndex = 11
        Me.radio_multiplicar.TabStop = True
        Me.radio_multiplicar.Text = "multiplicar"
        Me.radio_multiplicar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 320)
        Me.Controls.Add(Me.radio_dividir)
        Me.Controls.Add(Me.radio_multiplicar)
        Me.Controls.Add(Me.radio_subtrair)
        Me.Controls.Add(Me.radio_somar)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.txt_num2)
        Me.Controls.Add(Me.lbl_num2)
        Me.Controls.Add(Me.txt_num1)
        Me.Controls.Add(Me.lbl_num1)
        Me.Controls.Add(Me.lbl_calculadora)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_calculadora As Label
    Friend WithEvents lbl_num1 As Label
    Friend WithEvents txt_num1 As TextBox
    Friend WithEvents txt_num2 As TextBox
    Friend WithEvents lbl_num2 As Label
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents lbl_resultado As Label
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents radio_somar As RadioButton
    Friend WithEvents radio_subtrair As RadioButton
    Friend WithEvents radio_dividir As RadioButton
    Friend WithEvents radio_multiplicar As RadioButton
End Class
