<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form4_novo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_num1 = New System.Windows.Forms.Label()
        Me.lbl_num2 = New System.Windows.Forms.Label()
        Me.txt_num1 = New System.Windows.Forms.TextBox()
        Me.txt_num2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "invocou outro formulario"
        '
        'lbl_num1
        '
        Me.lbl_num1.AutoSize = True
        Me.lbl_num1.Location = New System.Drawing.Point(78, 64)
        Me.lbl_num1.Name = "lbl_num1"
        Me.lbl_num1.Size = New System.Drawing.Size(52, 13)
        Me.lbl_num1.TabIndex = 1
        Me.lbl_num1.Text = "1ºnumero"
        '
        'lbl_num2
        '
        Me.lbl_num2.AutoSize = True
        Me.lbl_num2.Location = New System.Drawing.Point(78, 100)
        Me.lbl_num2.Name = "lbl_num2"
        Me.lbl_num2.Size = New System.Drawing.Size(52, 13)
        Me.lbl_num2.TabIndex = 2
        Me.lbl_num2.Text = "2ºnumero"
        '
        'txt_num1
        '
        Me.txt_num1.Location = New System.Drawing.Point(141, 64)
        Me.txt_num1.Name = "txt_num1"
        Me.txt_num1.Size = New System.Drawing.Size(100, 20)
        Me.txt_num1.TabIndex = 3
        '
        'txt_num2
        '
        Me.txt_num2.Location = New System.Drawing.Point(141, 100)
        Me.txt_num2.Name = "txt_num2"
        Me.txt_num2.Size = New System.Drawing.Size(100, 20)
        Me.txt_num2.TabIndex = 4
        '
        'form4_novo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 249)
        Me.Controls.Add(Me.txt_num2)
        Me.Controls.Add(Me.txt_num1)
        Me.Controls.Add(Me.lbl_num2)
        Me.Controls.Add(Me.lbl_num1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form4_novo"
        Me.Text = "form1_novo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_num1 As Label
    Friend WithEvents lbl_num2 As Label
    Friend WithEvents txt_num1 As TextBox
    Friend WithEvents txt_num2 As TextBox
End Class
