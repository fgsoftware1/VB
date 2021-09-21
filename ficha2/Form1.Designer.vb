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
        Me.lbl_Nome = New System.Windows.Forms.Label()
        Me.txt_Nome = New System.Windows.Forms.TextBox()
        Me.btn_mostra = New System.Windows.Forms.Button()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Nome
        '
        Me.lbl_Nome.AutoSize = True
        Me.lbl_Nome.Location = New System.Drawing.Point(60, 68)
        Me.lbl_Nome.Name = "lbl_Nome"
        Me.lbl_Nome.Size = New System.Drawing.Size(79, 13)
        Me.lbl_Nome.TabIndex = 0
        Me.lbl_Nome.Text = "Nome do aluno"
        '
        'txt_Nome
        '
        Me.txt_Nome.Location = New System.Drawing.Point(145, 65)
        Me.txt_Nome.Name = "txt_Nome"
        Me.txt_Nome.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nome.TabIndex = 1
        '
        'btn_mostra
        '
        Me.btn_mostra.Location = New System.Drawing.Point(145, 91)
        Me.btn_mostra.Name = "btn_mostra"
        Me.btn_mostra.Size = New System.Drawing.Size(100, 23)
        Me.btn_mostra.TabIndex = 2
        Me.btn_mostra.Text = "mostra mensgaem"
        Me.btn_mostra.UseVisualStyleBackColor = True
        '
        'txt_resultado
        '
        Me.txt_resultado.Location = New System.Drawing.Point(145, 120)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(100, 20)
        Me.txt_resultado.TabIndex = 4
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(89, 120)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(50, 13)
        Me.lbl_resultado.TabIndex = 3
        Me.lbl_resultado.Text = "resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 304)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.btn_mostra)
        Me.Controls.Add(Me.txt_Nome)
        Me.Controls.Add(Me.lbl_Nome)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Nome As Label
    Friend WithEvents txt_Nome As TextBox
    Friend WithEvents btn_mostra As Button
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents lbl_resultado As Label
End Class
