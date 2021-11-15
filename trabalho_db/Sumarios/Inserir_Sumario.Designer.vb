<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inserir_Sumario
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
        Me.txt_summary = New System.Windows.Forms.TextBox()
        Me.txt_Data = New System.Windows.Forms.TextBox()
        Me.cmb_disciplina = New System.Windows.Forms.ComboBox()
        Me.cmb_ativo = New System.Windows.Forms.ComboBox()
        Me.btn_Inserir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Ativo = New System.Windows.Forms.Label()
        Me.lbl_disciplina = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(385, 25)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(73, 13)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "inserir sumário"
        '
        'txt_summary
        '
        Me.txt_summary.Location = New System.Drawing.Point(12, 56)
        Me.txt_summary.Multiline = True
        Me.txt_summary.Name = "txt_summary"
        Me.txt_summary.Size = New System.Drawing.Size(527, 382)
        Me.txt_summary.TabIndex = 2
        '
        'txt_Data
        '
        Me.txt_Data.Location = New System.Drawing.Point(545, 56)
        Me.txt_Data.Name = "txt_Data"
        Me.txt_Data.Size = New System.Drawing.Size(207, 20)
        Me.txt_Data.TabIndex = 3
        '
        'cmb_disciplina
        '
        Me.cmb_disciplina.FormattingEnabled = True
        Me.cmb_disciplina.Location = New System.Drawing.Point(546, 143)
        Me.cmb_disciplina.Name = "cmb_disciplina"
        Me.cmb_disciplina.Size = New System.Drawing.Size(206, 21)
        Me.cmb_disciplina.TabIndex = 4
        '
        'cmb_ativo
        '
        Me.cmb_ativo.FormattingEnabled = True
        Me.cmb_ativo.Location = New System.Drawing.Point(546, 101)
        Me.cmb_ativo.Name = "cmb_ativo"
        Me.cmb_ativo.Size = New System.Drawing.Size(206, 21)
        Me.cmb_ativo.TabIndex = 5
        '
        'btn_Inserir
        '
        Me.btn_Inserir.Location = New System.Drawing.Point(559, 407)
        Me.btn_Inserir.Name = "btn_Inserir"
        Me.btn_Inserir.Size = New System.Drawing.Size(229, 30)
        Me.btn_Inserir.TabIndex = 6
        Me.btn_Inserir.Text = "inserir"
        Me.btn_Inserir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(644, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "data"
        '
        'lbl_Ativo
        '
        Me.lbl_Ativo.AutoSize = True
        Me.lbl_Ativo.Location = New System.Drawing.Point(644, 79)
        Me.lbl_Ativo.Name = "lbl_Ativo"
        Me.lbl_Ativo.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Ativo.TabIndex = 8
        Me.lbl_Ativo.Text = "ativo"
        '
        'lbl_disciplina
        '
        Me.lbl_disciplina.AutoSize = True
        Me.lbl_disciplina.Location = New System.Drawing.Point(644, 125)
        Me.lbl_disciplina.Name = "lbl_disciplina"
        Me.lbl_disciplina.Size = New System.Drawing.Size(50, 13)
        Me.lbl_disciplina.TabIndex = 9
        Me.lbl_disciplina.Text = "disciplina"
        '
        'Inserir_Sumario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_disciplina)
        Me.Controls.Add(Me.lbl_Ativo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Inserir)
        Me.Controls.Add(Me.cmb_ativo)
        Me.Controls.Add(Me.cmb_disciplina)
        Me.Controls.Add(Me.txt_Data)
        Me.Controls.Add(Me.txt_summary)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "Inserir_Sumario"
        Me.Text = "Inserir_Sumario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_summary As TextBox
    Friend WithEvents txt_Data As TextBox
    Friend WithEvents cmb_disciplina As ComboBox
    Friend WithEvents cmb_ativo As ComboBox
    Friend WithEvents btn_Inserir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Ativo As Label
    Friend WithEvents lbl_disciplina As Label
End Class
