<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lbl_random = New System.Windows.Forms.Label()
        Me.btn_random = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_random
        '
        Me.lbl_random.AutoSize = True
        Me.lbl_random.Location = New System.Drawing.Point(39, 31)
        Me.lbl_random.Name = "lbl_random"
        Me.lbl_random.Size = New System.Drawing.Size(112, 13)
        Me.lbl_random.TabIndex = 0
        Me.lbl_random.Text = "gerar numero aleatorio"
        '
        'btn_random
        '
        Me.btn_random.Location = New System.Drawing.Point(42, 57)
        Me.btn_random.Name = "btn_random"
        Me.btn_random.Size = New System.Drawing.Size(109, 23)
        Me.btn_random.TabIndex = 1
        Me.btn_random.Text = "gerar"
        Me.btn_random.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 295)
        Me.Controls.Add(Me.btn_random)
        Me.Controls.Add(Me.lbl_random)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_random As Label
    Friend WithEvents btn_random As Button
End Class
