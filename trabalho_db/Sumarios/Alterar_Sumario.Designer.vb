<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alterar_Sumario
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
        Me.btn_Alterar = New System.Windows.Forms.Button()
        Me.txt_summary = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_disciplina = New System.Windows.Forms.Label()
        Me.lbl_Ativo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_ativo = New System.Windows.Forms.ComboBox()
        Me.cmb_disciplina = New System.Windows.Forms.ComboBox()
        Me.txt_Data = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_Alterar
        '
        Me.btn_Alterar.Location = New System.Drawing.Point(559, 401)
        Me.btn_Alterar.Name = "btn_Alterar"
        Me.btn_Alterar.Size = New System.Drawing.Size(229, 30)
        Me.btn_Alterar.TabIndex = 13
        Me.btn_Alterar.Text = "alterar"
        Me.btn_Alterar.UseVisualStyleBackColor = True
        '
        'txt_summary
        '
        Me.txt_summary.Location = New System.Drawing.Point(12, 35)
        Me.txt_summary.Multiline = True
        Me.txt_summary.Name = "txt_summary"
        Me.txt_summary.Size = New System.Drawing.Size(527, 397)
        Me.txt_summary.TabIndex = 9
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(385, 19)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(75, 13)
        Me.lbl_title.TabIndex = 7
        Me.lbl_title.Text = "alterar sumário"
        '
        'lbl_disciplina
        '
        Me.lbl_disciplina.AutoSize = True
        Me.lbl_disciplina.Location = New System.Drawing.Point(658, 146)
        Me.lbl_disciplina.Name = "lbl_disciplina"
        Me.lbl_disciplina.Size = New System.Drawing.Size(50, 13)
        Me.lbl_disciplina.TabIndex = 19
        Me.lbl_disciplina.Text = "disciplina"
        '
        'lbl_Ativo
        '
        Me.lbl_Ativo.AutoSize = True
        Me.lbl_Ativo.Location = New System.Drawing.Point(658, 100)
        Me.lbl_Ativo.Name = "lbl_Ativo"
        Me.lbl_Ativo.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Ativo.TabIndex = 18
        Me.lbl_Ativo.Text = "ativo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(658, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "data"
        '
        'cmb_ativo
        '
        Me.cmb_ativo.FormattingEnabled = True
        Me.cmb_ativo.Location = New System.Drawing.Point(560, 122)
        Me.cmb_ativo.Name = "cmb_ativo"
        Me.cmb_ativo.Size = New System.Drawing.Size(206, 21)
        Me.cmb_ativo.TabIndex = 16
        '
        'cmb_disciplina
        '
        Me.cmb_disciplina.FormattingEnabled = True
        Me.cmb_disciplina.Location = New System.Drawing.Point(560, 164)
        Me.cmb_disciplina.Name = "cmb_disciplina"
        Me.cmb_disciplina.Size = New System.Drawing.Size(206, 21)
        Me.cmb_disciplina.TabIndex = 15
        '
        'txt_Data
        '
        Me.txt_Data.Location = New System.Drawing.Point(559, 77)
        Me.txt_Data.Name = "txt_Data"
        Me.txt_Data.Size = New System.Drawing.Size(207, 20)
        Me.txt_Data.TabIndex = 14
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(659, 16)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 21
        Me.lbl_id.Text = "ID"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(560, 35)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(207, 20)
        Me.txt_id.TabIndex = 20
        '
        'Alterar_Sumario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_disciplina)
        Me.Controls.Add(Me.lbl_Ativo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_ativo)
        Me.Controls.Add(Me.cmb_disciplina)
        Me.Controls.Add(Me.txt_Data)
        Me.Controls.Add(Me.btn_Alterar)
        Me.Controls.Add(Me.txt_summary)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "Alterar_Sumario"
        Me.Text = "Alterar_Sumario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Alterar As Button
    Friend WithEvents txt_summary As TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_disciplina As Label
    Friend WithEvents lbl_Ativo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_ativo As ComboBox
    Friend WithEvents cmb_disciplina As ComboBox
    Friend WithEvents txt_Data As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
End Class
