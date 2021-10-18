<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btn_calcular
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_soma = New System.Windows.Forms.Label()
        Me.txt_soma = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbl_media = New System.Windows.Forms.Label()
        Me.txt_maximo = New System.Windows.Forms.TextBox()
        Me.lbl_maximo = New System.Windows.Forms.Label()
        Me.txt_minimo = New System.Windows.Forms.TextBox()
        Me.lbl_minimo = New System.Windows.Forms.Label()
        Me.btn_introduzir = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.btn_terminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(110, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(114, 13)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "operaçoes com arrrays"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(49, 46)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(132, 225)
        Me.ListBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(215, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_soma
        '
        Me.lbl_soma.AutoSize = True
        Me.lbl_soma.Location = New System.Drawing.Point(215, 97)
        Me.lbl_soma.Name = "lbl_soma"
        Me.lbl_soma.Size = New System.Drawing.Size(32, 13)
        Me.lbl_soma.TabIndex = 3
        Me.lbl_soma.Text = "soma"
        '
        'txt_soma
        '
        Me.txt_soma.Location = New System.Drawing.Point(260, 97)
        Me.txt_soma.Name = "txt_soma"
        Me.txt_soma.Size = New System.Drawing.Size(199, 20)
        Me.txt_soma.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(260, 141)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(199, 20)
        Me.TextBox2.TabIndex = 6
        '
        'lbl_media
        '
        Me.lbl_media.AutoSize = True
        Me.lbl_media.Location = New System.Drawing.Point(215, 141)
        Me.lbl_media.Name = "lbl_media"
        Me.lbl_media.Size = New System.Drawing.Size(35, 13)
        Me.lbl_media.TabIndex = 5
        Me.lbl_media.Text = "média"
        '
        'txt_maximo
        '
        Me.txt_maximo.Location = New System.Drawing.Point(260, 178)
        Me.txt_maximo.Name = "txt_maximo"
        Me.txt_maximo.Size = New System.Drawing.Size(199, 20)
        Me.txt_maximo.TabIndex = 8
        '
        'lbl_maximo
        '
        Me.lbl_maximo.AutoSize = True
        Me.lbl_maximo.Location = New System.Drawing.Point(216, 179)
        Me.lbl_maximo.Name = "lbl_maximo"
        Me.lbl_maximo.Size = New System.Drawing.Size(42, 13)
        Me.lbl_maximo.TabIndex = 7
        Me.lbl_maximo.Text = "máximo"
        '
        'txt_minimo
        '
        Me.txt_minimo.Location = New System.Drawing.Point(260, 219)
        Me.txt_minimo.Name = "txt_minimo"
        Me.txt_minimo.Size = New System.Drawing.Size(199, 20)
        Me.txt_minimo.TabIndex = 10
        '
        'lbl_minimo
        '
        Me.lbl_minimo.AutoSize = True
        Me.lbl_minimo.Location = New System.Drawing.Point(215, 219)
        Me.lbl_minimo.Name = "lbl_minimo"
        Me.lbl_minimo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_minimo.TabIndex = 9
        Me.lbl_minimo.Text = "minimo"
        '
        'btn_introduzir
        '
        Me.btn_introduzir.Location = New System.Drawing.Point(49, 303)
        Me.btn_introduzir.Name = "btn_introduzir"
        Me.btn_introduzir.Size = New System.Drawing.Size(132, 23)
        Me.btn_introduzir.TabIndex = 11
        Me.btn_introduzir.Text = "introduzir dados"
        Me.btn_introduzir.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(218, 303)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(132, 23)
        Me.btn_limpar.TabIndex = 12
        Me.btn_limpar.Text = "limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'btn_terminar
        '
        Me.btn_terminar.Location = New System.Drawing.Point(122, 348)
        Me.btn_terminar.Name = "btn_terminar"
        Me.btn_terminar.Size = New System.Drawing.Size(132, 23)
        Me.btn_terminar.TabIndex = 13
        Me.btn_terminar.Text = "terminar"
        Me.btn_terminar.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_terminar)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_introduzir)
        Me.Controls.Add(Me.txt_minimo)
        Me.Controls.Add(Me.lbl_minimo)
        Me.Controls.Add(Me.txt_maximo)
        Me.Controls.Add(Me.lbl_maximo)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lbl_media)
        Me.Controls.Add(Me.txt_soma)
        Me.Controls.Add(Me.lbl_soma)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "btn_calcular"
        Me.Text = "limpar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_soma As Label
    Friend WithEvents txt_soma As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbl_media As Label
    Friend WithEvents txt_maximo As TextBox
    Friend WithEvents lbl_maximo As Label
    Friend WithEvents txt_minimo As TextBox
    Friend WithEvents lbl_minimo As Label
    Friend WithEvents btn_introduzir As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_terminar As Button
End Class
