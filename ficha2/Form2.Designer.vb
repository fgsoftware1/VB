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
        Me.lbl_rotulo = New System.Windows.Forms.Label()
        Me.txt_texto1 = New System.Windows.Forms.TextBox()
        Me.btn_apagar = New System.Windows.Forms.Button()
        Me.btn_corFundo = New System.Windows.Forms.Button()
        Me.btn_corTexto = New System.Windows.Forms.Button()
        Me.btn_repor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_rotulo
        '
        Me.lbl_rotulo.AutoSize = True
        Me.lbl_rotulo.Location = New System.Drawing.Point(13, 13)
        Me.lbl_rotulo.Name = "lbl_rotulo"
        Me.lbl_rotulo.Size = New System.Drawing.Size(67, 13)
        Me.lbl_rotulo.TabIndex = 0
        Me.lbl_rotulo.Text = "Apagar texto"
        '
        'txt_texto1
        '
        Me.txt_texto1.Location = New System.Drawing.Point(80, 10)
        Me.txt_texto1.Name = "txt_texto1"
        Me.txt_texto1.Size = New System.Drawing.Size(115, 20)
        Me.txt_texto1.TabIndex = 1
        Me.txt_texto1.Text = "texto1"
        '
        'btn_apagar
        '
        Me.btn_apagar.Location = New System.Drawing.Point(39, 52)
        Me.btn_apagar.Name = "btn_apagar"
        Me.btn_apagar.Size = New System.Drawing.Size(75, 23)
        Me.btn_apagar.TabIndex = 2
        Me.btn_apagar.Text = "apagar texto"
        Me.btn_apagar.UseVisualStyleBackColor = True
        '
        'btn_corFundo
        '
        Me.btn_corFundo.Location = New System.Drawing.Point(120, 52)
        Me.btn_corFundo.Name = "btn_corFundo"
        Me.btn_corFundo.Size = New System.Drawing.Size(75, 23)
        Me.btn_corFundo.TabIndex = 3
        Me.btn_corFundo.Text = "cor de fundo"
        Me.btn_corFundo.UseVisualStyleBackColor = True
        '
        'btn_corTexto
        '
        Me.btn_corTexto.Location = New System.Drawing.Point(120, 81)
        Me.btn_corTexto.Name = "btn_corTexto"
        Me.btn_corTexto.Size = New System.Drawing.Size(75, 23)
        Me.btn_corTexto.TabIndex = 5
        Me.btn_corTexto.Text = "cor de texto"
        Me.btn_corTexto.UseVisualStyleBackColor = True
        '
        'btn_repor
        '
        Me.btn_repor.Location = New System.Drawing.Point(39, 81)
        Me.btn_repor.Name = "btn_repor"
        Me.btn_repor.Size = New System.Drawing.Size(75, 23)
        Me.btn_repor.TabIndex = 4
        Me.btn_repor.Text = "repor texto"
        Me.btn_repor.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 290)
        Me.Controls.Add(Me.btn_corTexto)
        Me.Controls.Add(Me.btn_repor)
        Me.Controls.Add(Me.btn_corFundo)
        Me.Controls.Add(Me.btn_apagar)
        Me.Controls.Add(Me.txt_texto1)
        Me.Controls.Add(Me.lbl_rotulo)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_rotulo As Label
    Friend WithEvents txt_texto1 As TextBox
    Friend WithEvents btn_apagar As Button
    Friend WithEvents btn_corFundo As Button
    Friend WithEvents btn_corTexto As Button
    Friend WithEvents btn_repor As Button
End Class

