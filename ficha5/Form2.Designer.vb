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
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.num_n2 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_n2 = New System.Windows.Forms.Label()
        Me.num_n1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        CType(Me.num_n2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_n1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(168, 201)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_calcular.TabIndex = 11
        Me.btn_calcular.Text = "calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'num_n2
        '
        Me.num_n2.Location = New System.Drawing.Point(168, 146)
        Me.num_n2.Name = "num_n2"
        Me.num_n2.Size = New System.Drawing.Size(120, 20)
        Me.num_n2.TabIndex = 10
        '
        'lbl_n2
        '
        Me.lbl_n2.AutoSize = True
        Me.lbl_n2.Location = New System.Drawing.Point(97, 153)
        Me.lbl_n2.Name = "lbl_n2"
        Me.lbl_n2.Size = New System.Drawing.Size(51, 13)
        Me.lbl_n2.TabIndex = 9
        Me.lbl_n2.Text = "numero 2"
        '
        'num_n1
        '
        Me.num_n1.Location = New System.Drawing.Point(168, 89)
        Me.num_n1.Name = "num_n1"
        Me.num_n1.Size = New System.Drawing.Size(120, 20)
        Me.num_n1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "numero 1"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(38, 38)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(331, 13)
        Me.lbl_titulo.TabIndex = 6
        Me.lbl_titulo.Text = "exemplo de um procedimento com  um instruçao ""on error ... goto ..."""
        '
        'txt_resultado
        '
        Me.txt_resultado.Location = New System.Drawing.Point(168, 243)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(120, 20)
        Me.txt_resultado.TabIndex = 13
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(100, 243)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(50, 13)
        Me.lbl_resultado.TabIndex = 12
        Me.lbl_resultado.Text = "resultado"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 300)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.num_n2)
        Me.Controls.Add(Me.lbl_n2)
        Me.Controls.Add(Me.num_n1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.num_n2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_n1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_calcular As Button
    Friend WithEvents num_n2 As NumericUpDown
    Friend WithEvents lbl_n2 As Label
    Friend WithEvents num_n1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents lbl_resultado As Label
End Class
