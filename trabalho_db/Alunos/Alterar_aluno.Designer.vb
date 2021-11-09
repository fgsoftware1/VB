<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alterar_aluno
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
        Me.lbl_foto = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_alterar = New System.Windows.Forms.Button()
        Me.pic_imagem = New System.Windows.Forms.PictureBox()
        Me.lbl_contato = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.txt_contato = New System.Windows.Forms.TextBox()
        Me.lbl_ativo = New System.Windows.Forms.Label()
        Me.cmb_ativo = New System.Windows.Forms.ComboBox()
        Me.lbl_genero = New System.Windows.Forms.Label()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.txt_morada = New System.Windows.Forms.TextBox()
        Me.lbl_morada = New System.Windows.Forms.Label()
        Me.cmb_genero = New System.Windows.Forms.ComboBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pic_imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_foto
        '
        Me.lbl_foto.AutoSize = True
        Me.lbl_foto.Location = New System.Drawing.Point(618, 109)
        Me.lbl_foto.Name = "lbl_foto"
        Me.lbl_foto.Size = New System.Drawing.Size(25, 13)
        Me.lbl_foto.TabIndex = 33
        Me.lbl_foto.Text = "foto"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(348, 311)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(160, 45)
        Me.btn_cancelar.TabIndex = 32
        Me.btn_cancelar.Text = "cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(146, 311)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(155, 45)
        Me.btn_alterar.TabIndex = 31
        Me.btn_alterar.Text = "alterar"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'pic_imagem
        '
        Me.pic_imagem.Location = New System.Drawing.Point(563, 136)
        Me.pic_imagem.Name = "pic_imagem"
        Me.pic_imagem.Size = New System.Drawing.Size(140, 119)
        Me.pic_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_imagem.TabIndex = 30
        Me.pic_imagem.TabStop = False
        '
        'lbl_contato
        '
        Me.lbl_contato.AutoSize = True
        Me.lbl_contato.Location = New System.Drawing.Point(155, 230)
        Me.lbl_contato.Name = "lbl_contato"
        Me.lbl_contato.Size = New System.Drawing.Size(43, 13)
        Me.lbl_contato.TabIndex = 29
        Me.lbl_contato.Text = "contato"
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Location = New System.Drawing.Point(161, 202)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(28, 13)
        Me.lbl_data.TabIndex = 28
        Me.lbl_data.Text = "data"
        '
        'txt_contato
        '
        Me.txt_contato.Location = New System.Drawing.Point(204, 230)
        Me.txt_contato.Name = "txt_contato"
        Me.txt_contato.Size = New System.Drawing.Size(115, 20)
        Me.txt_contato.TabIndex = 27
        '
        'lbl_ativo
        '
        Me.lbl_ativo.AutoSize = True
        Me.lbl_ativo.Location = New System.Drawing.Point(345, 237)
        Me.lbl_ativo.Name = "lbl_ativo"
        Me.lbl_ativo.Size = New System.Drawing.Size(36, 13)
        Me.lbl_ativo.TabIndex = 26
        Me.lbl_ativo.Text = "ativo?"
        '
        'cmb_ativo
        '
        Me.cmb_ativo.FormattingEnabled = True
        Me.cmb_ativo.Items.AddRange(New Object() {"sim", "nao"})
        Me.cmb_ativo.Location = New System.Drawing.Point(387, 234)
        Me.cmb_ativo.Name = "cmb_ativo"
        Me.cmb_ativo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_ativo.TabIndex = 25
        '
        'lbl_genero
        '
        Me.lbl_genero.AutoSize = True
        Me.lbl_genero.Location = New System.Drawing.Point(341, 202)
        Me.lbl_genero.Name = "lbl_genero"
        Me.lbl_genero.Size = New System.Drawing.Size(40, 13)
        Me.lbl_genero.TabIndex = 24
        Me.lbl_genero.Text = "genero"
        '
        'txt_data
        '
        Me.txt_data.Location = New System.Drawing.Point(204, 199)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(115, 20)
        Me.txt_data.TabIndex = 23
        '
        'txt_morada
        '
        Me.txt_morada.Location = New System.Drawing.Point(146, 172)
        Me.txt_morada.Name = "txt_morada"
        Me.txt_morada.Size = New System.Drawing.Size(362, 20)
        Me.txt_morada.TabIndex = 22
        '
        'lbl_morada
        '
        Me.lbl_morada.AutoSize = True
        Me.lbl_morada.Location = New System.Drawing.Point(92, 175)
        Me.lbl_morada.Name = "lbl_morada"
        Me.lbl_morada.Size = New System.Drawing.Size(43, 13)
        Me.lbl_morada.TabIndex = 21
        Me.lbl_morada.Text = "Morada"
        '
        'cmb_genero
        '
        Me.cmb_genero.FormattingEnabled = True
        Me.cmb_genero.Items.AddRange(New Object() {"masculino", "feminino"})
        Me.cmb_genero.Location = New System.Drawing.Point(387, 198)
        Me.cmb_genero.Name = "cmb_genero"
        Me.cmb_genero.Size = New System.Drawing.Size(121, 21)
        Me.cmb_genero.TabIndex = 20
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(146, 136)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(362, 20)
        Me.txt_nome.TabIndex = 19
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Location = New System.Drawing.Point(100, 136)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(35, 13)
        Me.lbl_nome.TabIndex = 18
        Me.lbl_nome.Text = "Nome"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(210, 77)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(91, 13)
        Me.lbl_title.TabIndex = 17
        Me.lbl_title.Text = "Inserir novo aluno"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(146, 106)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(362, 20)
        Me.txt_id.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "ID"
        '
        'Alterar_aluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_foto)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_alterar)
        Me.Controls.Add(Me.pic_imagem)
        Me.Controls.Add(Me.lbl_contato)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.txt_contato)
        Me.Controls.Add(Me.lbl_ativo)
        Me.Controls.Add(Me.cmb_ativo)
        Me.Controls.Add(Me.lbl_genero)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.txt_morada)
        Me.Controls.Add(Me.lbl_morada)
        Me.Controls.Add(Me.cmb_genero)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "Alterar_aluno"
        Me.Text = "Alterar_aluni"
        CType(Me.pic_imagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_foto As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_alterar As Button
    Friend WithEvents pic_imagem As PictureBox
    Friend WithEvents lbl_contato As Label
    Friend WithEvents lbl_data As Label
    Friend WithEvents txt_contato As TextBox
    Friend WithEvents lbl_ativo As Label
    Friend WithEvents cmb_ativo As ComboBox
    Friend WithEvents lbl_genero As Label
    Friend WithEvents txt_data As TextBox
    Friend WithEvents txt_morada As TextBox
    Friend WithEvents lbl_morada As Label
    Friend WithEvents cmb_genero As ComboBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
End Class
