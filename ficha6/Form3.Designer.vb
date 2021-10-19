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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_posicao = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_alterar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_quantidade = New System.Windows.Forms.TextBox()
        Me.txt_indice = New System.Windows.Forms.TextBox()
        Me.txt_posicao = New System.Windows.Forms.TextBox()
        Me.txt_item = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(44, 105)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(110, 95)
        Me.ListBox1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "indice"
        '
        'lbl_posicao
        '
        Me.lbl_posicao.AutoSize = True
        Me.lbl_posicao.Location = New System.Drawing.Point(173, 134)
        Me.lbl_posicao.Name = "lbl_posicao"
        Me.lbl_posicao.Size = New System.Drawing.Size(44, 13)
        Me.lbl_posicao.TabIndex = 6
        Me.lbl_posicao.Text = "posiçao"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(173, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "item"
        '
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(176, 206)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(118, 23)
        Me.btn_alterar.TabIndex = 10
        Me.btn_alterar.Text = "alterar dados"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(176, 248)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(118, 23)
        Me.btn_eliminar.TabIndex = 11
        Me.btn_eliminar.Text = "eliminar dados"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_adicionar
        '
        Me.btn_adicionar.Location = New System.Drawing.Point(44, 248)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(118, 23)
        Me.btn_adicionar.TabIndex = 12
        Me.btn_adicionar.Text = "adicionar dados"
        Me.btn_adicionar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "quantidade"
        '
        'txt_quantidade
        '
        Me.txt_quantidade.Location = New System.Drawing.Point(70, 218)
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(100, 20)
        Me.txt_quantidade.TabIndex = 14
        '
        'txt_indice
        '
        Me.txt_indice.Location = New System.Drawing.Point(226, 105)
        Me.txt_indice.Name = "txt_indice"
        Me.txt_indice.Size = New System.Drawing.Size(100, 20)
        Me.txt_indice.TabIndex = 15
        '
        'txt_posicao
        '
        Me.txt_posicao.Location = New System.Drawing.Point(226, 134)
        Me.txt_posicao.Name = "txt_posicao"
        Me.txt_posicao.Size = New System.Drawing.Size(100, 20)
        Me.txt_posicao.TabIndex = 16
        '
        'txt_item
        '
        Me.txt_item.Location = New System.Drawing.Point(226, 163)
        Me.txt_item.Name = "txt_item"
        Me.txt_item.Size = New System.Drawing.Size(100, 20)
        Me.txt_item.TabIndex = 17
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 321)
        Me.Controls.Add(Me.txt_item)
        Me.Controls.Add(Me.txt_posicao)
        Me.Controls.Add(Me.txt_indice)
        Me.Controls.Add(Me.txt_quantidade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_adicionar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_alterar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_posicao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_posicao As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_alterar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_adicionar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_quantidade As TextBox
    Friend WithEvents txt_indice As TextBox
    Friend WithEvents txt_posicao As TextBox
    Friend WithEvents txt_item As TextBox
End Class
