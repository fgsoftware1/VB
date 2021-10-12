<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.num_n1 = New System.Windows.Forms.NumericUpDown()
        Me.num_n2 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_n2 = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        CType(Me.num_n1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_n2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(72, 51)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(331, 13)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "exemplo de um procedimento com  um instruçao ""on error ... goto ..."""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "numero 1"
        '
        'num_n1
        '
        Me.num_n1.Location = New System.Drawing.Point(202, 102)
        Me.num_n1.Name = "num_n1"
        Me.num_n1.Size = New System.Drawing.Size(120, 20)
        Me.num_n1.TabIndex = 2
        '
        'num_n2
        '
        Me.num_n2.Location = New System.Drawing.Point(202, 159)
        Me.num_n2.Name = "num_n2"
        Me.num_n2.Size = New System.Drawing.Size(120, 20)
        Me.num_n2.TabIndex = 4
        '
        'lbl_n2
        '
        Me.lbl_n2.AutoSize = True
        Me.lbl_n2.Location = New System.Drawing.Point(131, 166)
        Me.lbl_n2.Name = "lbl_n2"
        Me.lbl_n2.Size = New System.Drawing.Size(51, 13)
        Me.lbl_n2.TabIndex = 3
        Me.lbl_n2.Text = "numero 2"
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(202, 214)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_calcular.TabIndex = 5
        Me.btn_calcular.Text = "calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 290)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.num_n2)
        Me.Controls.Add(Me.lbl_n2)
        Me.Controls.Add(Me.num_n1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.num_n1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_n2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents num_n1 As NumericUpDown
    Friend WithEvents num_n2 As NumericUpDown
    Friend WithEvents lbl_n2 As Label
    Friend WithEvents btn_calcular As Button
End Class
