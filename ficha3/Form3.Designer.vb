<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lbl_sqrt = New System.Windows.Forms.Label()
        Me.lbl_potencia = New System.Windows.Forms.Label()
        Me.lbl_arredondar_inteiros = New System.Windows.Forms.Label()
        Me.lbl_arredondar_decimal = New System.Windows.Forms.Label()
        Me.txt_sqrt_num1 = New System.Windows.Forms.TextBox()
        Me.txt_potencia_num1 = New System.Windows.Forms.TextBox()
        Me.txt_arredondar_inteiros_num1 = New System.Windows.Forms.TextBox()
        Me.txt_arredondar_decimal_num1 = New System.Windows.Forms.TextBox()
        Me.txt_potencia_num2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_arredondar_decimal_resultado = New System.Windows.Forms.TextBox()
        Me.txt_arredondar_inteiros_resultado = New System.Windows.Forms.TextBox()
        Me.txt_potencia_resultado = New System.Windows.Forms.TextBox()
        Me.txt_sqrt_resultado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_sqrt
        '
        Me.lbl_sqrt.AutoSize = True
        Me.lbl_sqrt.Location = New System.Drawing.Point(34, 80)
        Me.lbl_sqrt.Name = "lbl_sqrt"
        Me.lbl_sqrt.Size = New System.Drawing.Size(71, 13)
        Me.lbl_sqrt.TabIndex = 0
        Me.lbl_sqrt.Text = "raiz quadrada"
        '
        'lbl_potencia
        '
        Me.lbl_potencia.AutoSize = True
        Me.lbl_potencia.Location = New System.Drawing.Point(34, 110)
        Me.lbl_potencia.Name = "lbl_potencia"
        Me.lbl_potencia.Size = New System.Drawing.Size(48, 13)
        Me.lbl_potencia.TabIndex = 1
        Me.lbl_potencia.Text = "potencia"
        '
        'lbl_arredondar_inteiros
        '
        Me.lbl_arredondar_inteiros.AutoSize = True
        Me.lbl_arredondar_inteiros.Location = New System.Drawing.Point(34, 138)
        Me.lbl_arredondar_inteiros.Name = "lbl_arredondar_inteiros"
        Me.lbl_arredondar_inteiros.Size = New System.Drawing.Size(97, 13)
        Me.lbl_arredondar_inteiros.TabIndex = 2
        Me.lbl_arredondar_inteiros.Text = "arredondar(inteiros)"
        '
        'lbl_arredondar_decimal
        '
        Me.lbl_arredondar_decimal.AutoSize = True
        Me.lbl_arredondar_decimal.Location = New System.Drawing.Point(34, 172)
        Me.lbl_arredondar_decimal.Name = "lbl_arredondar_decimal"
        Me.lbl_arredondar_decimal.Size = New System.Drawing.Size(109, 13)
        Me.lbl_arredondar_decimal.TabIndex = 3
        Me.lbl_arredondar_decimal.Text = "arredondar(c/2casas)"
        '
        'txt_sqrt_num1
        '
        Me.txt_sqrt_num1.Location = New System.Drawing.Point(217, 80)
        Me.txt_sqrt_num1.Name = "txt_sqrt_num1"
        Me.txt_sqrt_num1.Size = New System.Drawing.Size(100, 20)
        Me.txt_sqrt_num1.TabIndex = 4
        '
        'txt_potencia_num1
        '
        Me.txt_potencia_num1.Location = New System.Drawing.Point(217, 110)
        Me.txt_potencia_num1.Name = "txt_potencia_num1"
        Me.txt_potencia_num1.Size = New System.Drawing.Size(100, 20)
        Me.txt_potencia_num1.TabIndex = 5
        '
        'txt_arredondar_inteiros_num1
        '
        Me.txt_arredondar_inteiros_num1.Location = New System.Drawing.Point(217, 138)
        Me.txt_arredondar_inteiros_num1.Name = "txt_arredondar_inteiros_num1"
        Me.txt_arredondar_inteiros_num1.Size = New System.Drawing.Size(100, 20)
        Me.txt_arredondar_inteiros_num1.TabIndex = 6
        '
        'txt_arredondar_decimal_num1
        '
        Me.txt_arredondar_decimal_num1.Location = New System.Drawing.Point(217, 169)
        Me.txt_arredondar_decimal_num1.Name = "txt_arredondar_decimal_num1"
        Me.txt_arredondar_decimal_num1.Size = New System.Drawing.Size(100, 20)
        Me.txt_arredondar_decimal_num1.TabIndex = 7
        '
        'txt_potencia_num2
        '
        Me.txt_potencia_num2.Location = New System.Drawing.Point(323, 110)
        Me.txt_potencia_num2.Name = "txt_potencia_num2"
        Me.txt_potencia_num2.Size = New System.Drawing.Size(100, 20)
        Me.txt_potencia_num2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(469, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(469, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(469, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(469, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "="
        '
        'txt_arredondar_decimal_resultado
        '
        Me.txt_arredondar_decimal_resultado.Location = New System.Drawing.Point(503, 169)
        Me.txt_arredondar_decimal_resultado.Name = "txt_arredondar_decimal_resultado"
        Me.txt_arredondar_decimal_resultado.Size = New System.Drawing.Size(100, 20)
        Me.txt_arredondar_decimal_resultado.TabIndex = 16
        '
        'txt_arredondar_inteiros_resultado
        '
        Me.txt_arredondar_inteiros_resultado.Location = New System.Drawing.Point(503, 138)
        Me.txt_arredondar_inteiros_resultado.Name = "txt_arredondar_inteiros_resultado"
        Me.txt_arredondar_inteiros_resultado.Size = New System.Drawing.Size(100, 20)
        Me.txt_arredondar_inteiros_resultado.TabIndex = 15
        '
        'txt_potencia_resultado
        '
        Me.txt_potencia_resultado.Location = New System.Drawing.Point(503, 110)
        Me.txt_potencia_resultado.Name = "txt_potencia_resultado"
        Me.txt_potencia_resultado.Size = New System.Drawing.Size(100, 20)
        Me.txt_potencia_resultado.TabIndex = 14
        '
        'txt_sqrt_resultado
        '
        Me.txt_sqrt_resultado.Location = New System.Drawing.Point(503, 80)
        Me.txt_sqrt_resultado.Name = "txt_sqrt_resultado"
        Me.txt_sqrt_resultado.Size = New System.Drawing.Size(100, 20)
        Me.txt_sqrt_resultado.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(243, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "numero 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "numero 2"
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(217, 225)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(265, 23)
        Me.btn_calcular.TabIndex = 19
        Me.btn_calcular.Text = "calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 266)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_arredondar_decimal_resultado)
        Me.Controls.Add(Me.txt_arredondar_inteiros_resultado)
        Me.Controls.Add(Me.txt_potencia_resultado)
        Me.Controls.Add(Me.txt_sqrt_resultado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_potencia_num2)
        Me.Controls.Add(Me.txt_arredondar_decimal_num1)
        Me.Controls.Add(Me.txt_arredondar_inteiros_num1)
        Me.Controls.Add(Me.txt_potencia_num1)
        Me.Controls.Add(Me.txt_sqrt_num1)
        Me.Controls.Add(Me.lbl_arredondar_decimal)
        Me.Controls.Add(Me.lbl_arredondar_inteiros)
        Me.Controls.Add(Me.lbl_potencia)
        Me.Controls.Add(Me.lbl_sqrt)
        Me.Name = "Form3"
        Me.Text = "arredondar(inteiros)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_sqrt As Label
    Friend WithEvents lbl_potencia As Label
    Friend WithEvents lbl_arredondar_inteiros As Label
    Friend WithEvents lbl_arredondar_decimal As Label
    Friend WithEvents txt_sqrt_num1 As TextBox
    Friend WithEvents txt_potencia_num1 As TextBox
    Friend WithEvents txt_arredondar_inteiros_num1 As TextBox
    Friend WithEvents txt_arredondar_decimal_num1 As TextBox
    Friend WithEvents txt_potencia_num2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_arredondar_decimal_resultado As TextBox
    Friend WithEvents txt_arredondar_inteiros_resultado As TextBox
    Friend WithEvents txt_potencia_resultado As TextBox
    Friend WithEvents txt_sqrt_resultado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_calcular As Button
End Class
