﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txt_data
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
        Me.txt_titulo = New System.Windows.Forms.TextBox()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.txt_disciplina = New System.Windows.Forms.TextBox()
        Me.lbl_disciplina = New System.Windows.Forms.Label()
        Me.btn_inserir = New System.Windows.Forms.Button()
        Me.btn_alterar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(447, 280)
        Me.DataGridView1.TabIndex = 0
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(24, 325)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 1
        Me.lbl_id.Text = "ID"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(48, 322)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(140, 20)
        Me.txt_id.TabIndex = 2
        '
        'txt_titulo
        '
        Me.txt_titulo.Location = New System.Drawing.Point(498, 23)
        Me.txt_titulo.Name = "txt_titulo"
        Me.txt_titulo.Size = New System.Drawing.Size(290, 20)
        Me.txt_titulo.TabIndex = 3
        '
        'txt_descricao
        '
        Me.txt_descricao.Location = New System.Drawing.Point(498, 59)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(290, 320)
        Me.txt_descricao.TabIndex = 4
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(48, 359)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(140, 20)
        Me.txt_nome.TabIndex = 6
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Location = New System.Drawing.Point(12, 363)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(33, 13)
        Me.lbl_nome.TabIndex = 5
        Me.lbl_nome.Text = "nome"
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(322, 325)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(149, 20)
        Me.txt_date.TabIndex = 8
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Location = New System.Drawing.Point(288, 328)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(28, 13)
        Me.lbl_data.TabIndex = 7
        Me.lbl_data.Text = "data"
        '
        'txt_disciplina
        '
        Me.txt_disciplina.Location = New System.Drawing.Point(322, 356)
        Me.txt_disciplina.Name = "txt_disciplina"
        Me.txt_disciplina.Size = New System.Drawing.Size(149, 20)
        Me.txt_disciplina.TabIndex = 10
        '
        'lbl_disciplina
        '
        Me.lbl_disciplina.AutoSize = True
        Me.lbl_disciplina.Location = New System.Drawing.Point(266, 359)
        Me.lbl_disciplina.Name = "lbl_disciplina"
        Me.lbl_disciplina.Size = New System.Drawing.Size(50, 13)
        Me.lbl_disciplina.TabIndex = 9
        Me.lbl_disciplina.Text = "disciplina"
        '
        'btn_inserir
        '
        Me.btn_inserir.Location = New System.Drawing.Point(15, 409)
        Me.btn_inserir.Name = "btn_inserir"
        Me.btn_inserir.Size = New System.Drawing.Size(147, 23)
        Me.btn_inserir.TabIndex = 11
        Me.btn_inserir.Text = "inserir"
        Me.btn_inserir.UseVisualStyleBackColor = True
        '
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(180, 409)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(136, 23)
        Me.btn_alterar.TabIndex = 12
        Me.btn_alterar.Text = "alterar"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(346, 409)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(125, 23)
        Me.btn_eliminar.TabIndex = 13
        Me.btn_eliminar.Text = "eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'txt_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_alterar)
        Me.Controls.Add(Me.btn_inserir)
        Me.Controls.Add(Me.txt_disciplina)
        Me.Controls.Add(Me.lbl_disciplina)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.txt_titulo)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "txt_data"
        Me.Text = "Listar_Sumarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_titulo As TextBox
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents lbl_data As Label
    Friend WithEvents txt_disciplina As TextBox
    Friend WithEvents lbl_disciplina As Label
    Friend WithEvents btn_inserir As Button
    Friend WithEvents btn_alterar As Button
    Friend WithEvents btn_eliminar As Button
End Class
