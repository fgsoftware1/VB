<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lbl_num1 = New System.Windows.Forms.Label()
        Me.lbl_num2 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.num_num1 = New System.Windows.Forms.NumericUpDown()
        Me.num_num2 = New System.Windows.Forms.NumericUpDown()
        Me.btn_invocar = New System.Windows.Forms.Button()
        CType(Me.num_num1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_num2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_num1
        '
        Me.lbl_num1.AutoSize = True
        Me.lbl_num1.Location = New System.Drawing.Point(88, 83)
        Me.lbl_num1.Name = "lbl_num1"
        Me.lbl_num1.Size = New System.Drawing.Size(33, 13)
        Me.lbl_num1.TabIndex = 0
        Me.lbl_num1.Text = "num1"
        '
        'lbl_num2
        '
        Me.lbl_num2.AutoSize = True
        Me.lbl_num2.Location = New System.Drawing.Point(91, 115)
        Me.lbl_num2.Name = "lbl_num2"
        Me.lbl_num2.Size = New System.Drawing.Size(33, 13)
        Me.lbl_num2.TabIndex = 1
        Me.lbl_num2.Text = "num2"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(128, 31)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(152, 13)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "invocar um formulario existente"
        '
        'num_num1
        '
        Me.num_num1.Location = New System.Drawing.Point(172, 83)
        Me.num_num1.Name = "num_num1"
        Me.num_num1.Size = New System.Drawing.Size(120, 20)
        Me.num_num1.TabIndex = 3
        '
        'num_num2
        '
        Me.num_num2.Location = New System.Drawing.Point(172, 115)
        Me.num_num2.Name = "num_num2"
        Me.num_num2.Size = New System.Drawing.Size(120, 20)
        Me.num_num2.TabIndex = 4
        '
        'btn_invocar
        '
        Me.btn_invocar.Location = New System.Drawing.Point(172, 159)
        Me.btn_invocar.Name = "btn_invocar"
        Me.btn_invocar.Size = New System.Drawing.Size(120, 25)
        Me.btn_invocar.TabIndex = 5
        Me.btn_invocar.Text = "invocar outro form"
        Me.btn_invocar.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 251)
        Me.Controls.Add(Me.btn_invocar)
        Me.Controls.Add(Me.num_num2)
        Me.Controls.Add(Me.num_num1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_num2)
        Me.Controls.Add(Me.lbl_num1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.num_num1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_num2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_num1 As Label
    Friend WithEvents lbl_num2 As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents num_num1 As NumericUpDown
    Friend WithEvents num_num2 As NumericUpDown
    Friend WithEvents btn_invocar As Button
End Class
