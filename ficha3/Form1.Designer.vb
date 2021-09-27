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
        Me.lbl_invocar = New System.Windows.Forms.Label()
        Me.btn_invocar = New System.Windows.Forms.Button()
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_invocar
        '
        Me.lbl_invocar.AutoSize = True
        Me.lbl_invocar.Location = New System.Drawing.Point(44, 54)
        Me.lbl_invocar.Name = "lbl_invocar"
        Me.lbl_invocar.Size = New System.Drawing.Size(87, 13)
        Me.lbl_invocar.TabIndex = 0
        Me.lbl_invocar.Text = "invocar InputBox"
        '
        'btn_invocar
        '
        Me.btn_invocar.Location = New System.Drawing.Point(235, 54)
        Me.btn_invocar.Name = "btn_invocar"
        Me.btn_invocar.Size = New System.Drawing.Size(75, 23)
        Me.btn_invocar.TabIndex = 1
        Me.btn_invocar.Text = "invocar"
        Me.btn_invocar.UseVisualStyleBackColor = True
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Location = New System.Drawing.Point(47, 106)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(138, 13)
        Me.lbl_valor.TabIndex = 2
        Me.lbl_valor.Text = "Qual foi o valor introduzido?"
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(235, 106)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 185)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.btn_invocar)
        Me.Controls.Add(Me.lbl_invocar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_invocar As Label
    Friend WithEvents btn_invocar As Button
    Friend WithEvents lbl_valor As Label
    Friend WithEvents txt_numero As TextBox
End Class
