<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_data_hora = New System.Windows.Forms.Label()
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.txt_data_hora = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Location = New System.Drawing.Point(39, 131)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(28, 13)
        Me.lbl_data.TabIndex = 0
        Me.lbl_data.Text = "data"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Location = New System.Drawing.Point(39, 180)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(28, 13)
        Me.lbl_hora.TabIndex = 2
        Me.lbl_hora.Text = "hora"
        '
        'lbl_data_hora
        '
        Me.lbl_data_hora.AutoSize = True
        Me.lbl_data_hora.Location = New System.Drawing.Point(24, 217)
        Me.lbl_data_hora.Name = "lbl_data_hora"
        Me.lbl_data_hora.Size = New System.Drawing.Size(61, 13)
        Me.lbl_data_hora.TabIndex = 4
        Me.lbl_data_hora.Text = "data e hora"
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Location = New System.Drawing.Point(42, 62)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(152, 23)
        Me.btn_mostrar.TabIndex = 6
        Me.btn_mostrar.Text = "mostrar"
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "data e hora do sistema"
        '
        'txt_data
        '
        Me.txt_data.Location = New System.Drawing.Point(100, 123)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(100, 20)
        Me.txt_data.TabIndex = 8
        '
        'txt_hora
        '
        Me.txt_hora.Location = New System.Drawing.Point(100, 173)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(100, 20)
        Me.txt_hora.TabIndex = 9
        '
        'txt_data_hora
        '
        Me.txt_data_hora.Location = New System.Drawing.Point(100, 217)
        Me.txt_data_hora.Name = "txt_data_hora"
        Me.txt_data_hora.Size = New System.Drawing.Size(100, 20)
        Me.txt_data_hora.TabIndex = 10
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 270)
        Me.Controls.Add(Me.txt_data_hora)
        Me.Controls.Add(Me.txt_hora)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.lbl_data_hora)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.lbl_data)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents lbl_data_hora As Label
    Friend WithEvents btn_mostrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_data As TextBox
    Friend WithEvents txt_hora As TextBox
    Friend WithEvents txt_data_hora As TextBox
End Class
