<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inserir_aluno
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_genero = New System.Windows.Forms.ComboBox()
        Me.lbl_morada = New System.Windows.Forms.Label()
        Me.txt_morada = New System.Windows.Forms.TextBox()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.lbl_genero = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbl_ativo = New System.Windows.Forms.Label()
        Me.txt_contato = New System.Windows.Forms.TextBox()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.lbl_contato = New System.Windows.Forms.Label()
        Me.pic_imagem = New System.Windows.Forms.PictureBox()
        Me.btn_inserir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_foto = New System.Windows.Forms.Label()
        CType(Me.pic_imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(198, 35)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(91, 13)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Inserir novo aluno"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Location = New System.Drawing.Point(88, 94)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(35, 13)
        Me.lbl_nome.TabIndex = 1
        Me.lbl_nome.Text = "Nome"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(134, 94)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(362, 20)
        Me.txt_nome.TabIndex = 2
        '
        'txt_genero
        '
        Me.txt_genero.FormattingEnabled = True
        Me.txt_genero.Items.AddRange(New Object() {"masculino", "feminino"})
        Me.txt_genero.Location = New System.Drawing.Point(375, 156)
        Me.txt_genero.Name = "txt_genero"
        Me.txt_genero.Size = New System.Drawing.Size(121, 21)
        Me.txt_genero.TabIndex = 3
        '
        'lbl_morada
        '
        Me.lbl_morada.AutoSize = True
        Me.lbl_morada.Location = New System.Drawing.Point(80, 133)
        Me.lbl_morada.Name = "lbl_morada"
        Me.lbl_morada.Size = New System.Drawing.Size(43, 13)
        Me.lbl_morada.TabIndex = 4
        Me.lbl_morada.Text = "Morada"
        '
        'txt_morada
        '
        Me.txt_morada.Location = New System.Drawing.Point(134, 130)
        Me.txt_morada.Name = "txt_morada"
        Me.txt_morada.Size = New System.Drawing.Size(362, 20)
        Me.txt_morada.TabIndex = 5
        '
        'txt_data
        '
        Me.txt_data.Location = New System.Drawing.Point(192, 157)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(115, 20)
        Me.txt_data.TabIndex = 6
        '
        'lbl_genero
        '
        Me.lbl_genero.AutoSize = True
        Me.lbl_genero.Location = New System.Drawing.Point(329, 160)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(40, 13)
        Me.lbl_genero.TabIndex = 7
        Me.lbl_genero.Text = "genero"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"sim", "nao"})
        Me.ComboBox1.Location = New System.Drawing.Point(375, 192)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'lbl_ativo
        '
        Me.lbl_ativo.AutoSize = True
        Me.lbl_ativo.Location = New System.Drawing.Point(333, 195)
        Me.lbl_ativo.Name = "lbl_ativo"
        Me.lbl_ativo.Size = New System.Drawing.Size(36, 13)
        Me.lbl_ativo.TabIndex = 9
        Me.lbl_ativo.Text = "ativo?"
        '
        'txt_contato
        '
        Me.txt_contato.Location = New System.Drawing.Point(192, 188)
        Me.txt_contato.Name = "txt_contato"
        Me.txt_contato.Size = New System.Drawing.Size(115, 20)
        Me.txt_contato.TabIndex = 10
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Location = New System.Drawing.Point(149, 160)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(28, 13)
        Me.lbl_data.TabIndex = 11
        Me.lbl_data.Text = "data"
        '
        'lbl_contato
        '
        Me.lbl_contato.AutoSize = True
        Me.lbl_contato.Location = New System.Drawing.Point(143, 188)
        Me.lbl_contato.Name = "lbl_contato"
        Me.lbl_contato.Size = New System.Drawing.Size(43, 13)
        Me.lbl_contato.TabIndex = 12
        Me.lbl_contato.Text = "contato"
        '
        'pic_imagem
        '
        Me.pic_imagem.Location = New System.Drawing.Point(551, 94)
        Me.pic_imagem.Name = "pic_imagem"
        Me.pic_imagem.Size = New System.Drawing.Size(140, 119)
        Me.pic_imagem.TabIndex = 13
        Me.pic_imagem.TabStop = False
        '
        'btn_inserir
        '
        Me.btn_inserir.Location = New System.Drawing.Point(134, 269)
        Me.btn_inserir.Name = "btn_inserir"
        Me.btn_inserir.Size = New System.Drawing.Size(155, 45)
        Me.btn_inserir.TabIndex = 14
        Me.btn_inserir.Text = "inserir"
        Me.btn_inserir.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(336, 269)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(160, 45)
        Me.btn_cancelar.TabIndex = 15
        Me.btn_cancelar.Text = "cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_foto
        '
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.Location = New System.Drawing.Point(606, 67)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(25, 13)
        Me.lbl_foto.TabIndex = 16
        Me.lbl_foto.Text = "foto"
        '
        'Inserir_aluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 359)
        Me.Controls.Add(Me.lbl_foto)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_inserir)
        Me.Controls.Add(Me.pic_imagem)
        Me.Controls.Add(Me.lbl_contato)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.txt_contato)
        Me.Controls.Add(Me.lbl_ativo)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbl_genero)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.txt_morada)
        Me.Controls.Add(Me.lbl_morada)
        Me.Controls.Add(Me.txt_genero)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "Inserir_aluno"
        Me.Text = "Inserir_aluno"
        CType(Me.pic_imagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_genero As ComboBox
    Friend WithEvents lbl_morada As Label
    Friend WithEvents txt_morada As TextBox
    Friend WithEvents txt_data As TextBox
    Friend WithEvents lbl_genero As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lbl_ativo As Label
    Friend WithEvents txt_contato As TextBox
    Friend WithEvents lbl_data As Label
    Friend WithEvents lbl_contato As Label
    Friend WithEvents pic_imagem As PictureBox
    Friend WithEvents btn_inserir As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_foto As Label
End Class
