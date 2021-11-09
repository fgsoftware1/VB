<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listar_Dados
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_morada = New System.Windows.Forms.TextBox()
        Me.lbl_morada = New System.Windows.Forms.Label()
        Me.btn_carregar = New System.Windows.Forms.Button()
        Me.pic_imagem = New System.Windows.Forms.PictureBox()
        Me.btn_alterar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(678, 245)
        Me.DataGridView1.TabIndex = 0
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(55, 304)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 1
        Me.lbl_id.Text = "ID"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(116, 301)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(55, 20)
        Me.txt_id.TabIndex = 2
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(116, 338)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(387, 20)
        Me.txt_nome.TabIndex = 4
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Location = New System.Drawing.Point(55, 338)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(33, 13)
        Me.lbl_nome.TabIndex = 3
        Me.lbl_nome.Text = "nome"
        '
        'txt_morada
        '
        Me.txt_morada.Location = New System.Drawing.Point(116, 380)
        Me.txt_morada.Name = "txt_morada"
        Me.txt_morada.Size = New System.Drawing.Size(387, 20)
        Me.txt_morada.TabIndex = 6
        '
        'lbl_morada
        '
        Me.lbl_morada.AutoSize = True
        Me.lbl_morada.Location = New System.Drawing.Point(55, 380)
        Me.lbl_morada.Name = "lbl_morada"
        Me.lbl_morada.Size = New System.Drawing.Size(42, 13)
        Me.lbl_morada.TabIndex = 5
        Me.lbl_morada.Text = "morada"
        '
        'btn_carregar
        '
        Me.btn_carregar.Location = New System.Drawing.Point(247, 21)
        Me.btn_carregar.Name = "btn_carregar"
        Me.btn_carregar.Size = New System.Drawing.Size(256, 23)
        Me.btn_carregar.TabIndex = 7
        Me.btn_carregar.Text = "carregar dados"
        Me.btn_carregar.UseVisualStyleBackColor = True
        '
        'pic_imagem
        '
        Me.pic_imagem.Location = New System.Drawing.Point(538, 301)
        Me.pic_imagem.Name = "pic_imagem"
        Me.pic_imagem.Size = New System.Drawing.Size(152, 137)
        Me.pic_imagem.TabIndex = 8
        Me.pic_imagem.TabStop = False
        '
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(116, 406)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(169, 23)
        Me.btn_alterar.TabIndex = 9
        Me.btn_alterar.Text = "alterar"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(334, 406)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(169, 23)
        Me.btn_eliminar.TabIndex = 10
        Me.btn_eliminar.Text = "eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_adicionar
        '
        Me.btn_adicionar.Location = New System.Drawing.Point(448, 301)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(75, 23)
        Me.btn_adicionar.TabIndex = 11
        Me.btn_adicionar.Text = "adicionar"
        Me.btn_adicionar.UseVisualStyleBackColor = True
        '
        'Listar_Dados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 450)
        Me.Controls.Add(Me.btn_adicionar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_alterar)
        Me.Controls.Add(Me.pic_imagem)
        Me.Controls.Add(Me.btn_carregar)
        Me.Controls.Add(Me.txt_morada)
        Me.Controls.Add(Me.lbl_morada)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Listar_Dados"
        Me.Text = "Listar_Dados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_imagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_morada As TextBox
    Friend WithEvents lbl_morada As Label
    Friend WithEvents btn_carregar As Button
    Friend WithEvents pic_imagem As PictureBox
    Friend WithEvents btn_alterar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_adicionar As Button
End Class
