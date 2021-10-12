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
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_notas = New System.Windows.Forms.Label()
        Me.txt_notas = New System.Windows.Forms.TextBox()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.btn_converter = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(147, 61)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(57, 13)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "conversao"
        '
        'lbl_notas
        '
        Me.lbl_notas.AutoSize = True
        Me.lbl_notas.Location = New System.Drawing.Point(82, 108)
        Me.lbl_notas.Name = "lbl_notas"
        Me.lbl_notas.Size = New System.Drawing.Size(74, 13)
        Me.lbl_notas.TabIndex = 1
        Me.lbl_notas.Text = "insira as notas"
        '
        'txt_notas
        '
        Me.txt_notas.Location = New System.Drawing.Point(171, 108)
        Me.txt_notas.Name = "txt_notas"
        Me.txt_notas.Size = New System.Drawing.Size(100, 20)
        Me.txt_notas.TabIndex = 2
        '
        'txt_resultado
        '
        Me.txt_resultado.Location = New System.Drawing.Point(171, 192)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(100, 20)
        Me.txt_resultado.TabIndex = 4
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(82, 192)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(39, 13)
        Me.lbl_resultado.TabIndex = 3
        Me.lbl_resultado.Text = "Label2"
        '
        'btn_converter
        '
        Me.btn_converter.Location = New System.Drawing.Point(140, 147)
        Me.btn_converter.Name = "btn_converter"
        Me.btn_converter.Size = New System.Drawing.Size(64, 23)
        Me.btn_converter.TabIndex = 5
        Me.btn_converter.Text = "converter"
        Me.btn_converter.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(210, 147)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(64, 23)
        Me.btn_limpar.TabIndex = 6
        Me.btn_limpar.Text = "limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 274)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_converter)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.txt_notas)
        Me.Controls.Add(Me.lbl_notas)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_notas As Label
    Friend WithEvents txt_notas As TextBox
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents lbl_resultado As Label
    Friend WithEvents btn_converter As Button
    Friend WithEvents btn_limpar As Button
End Class
