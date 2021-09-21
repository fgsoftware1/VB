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
        Me.lbl_perimetro = New System.Windows.Forms.Label()
        Me.lbl_comprimento = New System.Windows.Forms.Label()
        Me.txt_comprimento = New System.Windows.Forms.TextBox()
        Me.txt_largura = New System.Windows.Forms.TextBox()
        Me.lbl_largura = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_perimetro
        '
        Me.lbl_perimetro.AutoSize = True
        Me.lbl_perimetro.Location = New System.Drawing.Point(341, 36)
        Me.lbl_perimetro.Name = "lbl_perimetro"
        Me.lbl_perimetro.Size = New System.Drawing.Size(151, 13)
        Me.lbl_perimetro.TabIndex = 0
        Me.lbl_perimetro.Text = "área de perimetro do retangulo"
        '
        'lbl_comprimento
        '
        Me.lbl_comprimento.AutoSize = True
        Me.lbl_comprimento.Location = New System.Drawing.Point(181, 112)
        Me.lbl_comprimento.Name = "lbl_comprimento"
        Me.lbl_comprimento.Size = New System.Drawing.Size(129, 13)
        Me.lbl_comprimento.TabIndex = 1
        Me.lbl_comprimento.Text = "comprimento do retangulo"
        '
        'txt_comprimento
        '
        Me.txt_comprimento.Location = New System.Drawing.Point(329, 112)
        Me.txt_comprimento.Name = "txt_comprimento"
        Me.txt_comprimento.Size = New System.Drawing.Size(163, 20)
        Me.txt_comprimento.TabIndex = 2
        '
        'txt_largura
        '
        Me.txt_largura.Location = New System.Drawing.Point(329, 154)
        Me.txt_largura.Name = "txt_largura"
        Me.txt_largura.Size = New System.Drawing.Size(163, 20)
        Me.txt_largura.TabIndex = 4
        '
        'lbl_largura
        '
        Me.lbl_largura.AutoSize = True
        Me.lbl_largura.Location = New System.Drawing.Point(181, 154)
        Me.lbl_largura.Name = "lbl_largura"
        Me.lbl_largura.Size = New System.Drawing.Size(101, 13)
        Me.lbl_largura.TabIndex = 3
        Me.lbl_largura.Text = "largura do retangulo"
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(329, 180)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(163, 42)
        Me.btn_calcular.TabIndex = 5
        Me.btn_calcular.Text = "calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'txt_resultado
        '
        Me.txt_resultado.Location = New System.Drawing.Point(329, 228)
        Me.txt_resultado.Multiline = True
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(163, 37)
        Me.txt_resultado.TabIndex = 6
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_largura)
        Me.Controls.Add(Me.lbl_largura)
        Me.Controls.Add(Me.txt_comprimento)
        Me.Controls.Add(Me.lbl_comprimento)
        Me.Controls.Add(Me.lbl_perimetro)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_perimetro As Label
    Friend WithEvents lbl_comprimento As Label
    Friend WithEvents txt_comprimento As TextBox
    Friend WithEvents txt_largura As TextBox
    Friend WithEvents lbl_largura As Label
    Friend WithEvents btn_calcular As Button
    Friend WithEvents txt_resultado As TextBox
End Class
