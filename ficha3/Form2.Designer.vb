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
        Me.lbl_invocar = New System.Windows.Forms.Label()
        Me.btn_invocar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_invocar
        '
        Me.lbl_invocar.AutoSize = True
        Me.lbl_invocar.Location = New System.Drawing.Point(29, 35)
        Me.lbl_invocar.Name = "lbl_invocar"
        Me.lbl_invocar.Size = New System.Drawing.Size(106, 13)
        Me.lbl_invocar.TabIndex = 0
        Me.lbl_invocar.Text = "invocar MessageBox"
        '
        'btn_invocar
        '
        Me.btn_invocar.Location = New System.Drawing.Point(202, 35)
        Me.btn_invocar.Name = "btn_invocar"
        Me.btn_invocar.Size = New System.Drawing.Size(75, 23)
        Me.btn_invocar.TabIndex = 1
        Me.btn_invocar.Text = "invocar"
        Me.btn_invocar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 289)
        Me.Controls.Add(Me.btn_invocar)
        Me.Controls.Add(Me.lbl_invocar)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_invocar As Label
    Friend WithEvents btn_invocar As Button
End Class
