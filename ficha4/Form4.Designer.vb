<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btn_limpar
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
        Me.lbl_monitores = New System.Windows.Forms.Label()
        Me.lbl_perifericos = New System.Windows.Forms.Label()
        Me.radio_lcd = New System.Windows.Forms.RadioButton()
        Me.radio_4k = New System.Windows.Forms.RadioButton()
        Me.lbl_preco = New System.Windows.Forms.Label()
        Me.txt_base = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_periferico = New System.Windows.Forms.TextBox()
        Me.lbl_periferico = New System.Windows.Forms.Label()
        Me.txt_monitor = New System.Windows.Forms.TextBox()
        Me.lbl_monitor = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.check_ssd_500gb = New System.Windows.Forms.CheckBox()
        Me.check_rato_razor = New System.Windows.Forms.CheckBox()
        Me.check_impressora = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(221, 37)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(110, 13)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "contas de uma venda"
        '
        'lbl_monitores
        '
        Me.lbl_monitores.AutoSize = True
        Me.lbl_monitores.Location = New System.Drawing.Point(74, 92)
        Me.lbl_monitores.Name = "lbl_monitores"
        Me.lbl_monitores.Size = New System.Drawing.Size(52, 13)
        Me.lbl_monitores.TabIndex = 1
        Me.lbl_monitores.Text = "monitores"
        '
        'lbl_perifericos
        '
        Me.lbl_perifericos.AutoSize = True
        Me.lbl_perifericos.Location = New System.Drawing.Point(77, 200)
        Me.lbl_perifericos.Name = "lbl_perifericos"
        Me.lbl_perifericos.Size = New System.Drawing.Size(55, 13)
        Me.lbl_perifericos.TabIndex = 2
        Me.lbl_perifericos.Text = "perifericos"
        '
        'radio_lcd
        '
        Me.radio_lcd.AutoSize = True
        Me.radio_lcd.Location = New System.Drawing.Point(77, 120)
        Me.radio_lcd.Name = "radio_lcd"
        Me.radio_lcd.Size = New System.Drawing.Size(66, 17)
        Me.radio_lcd.TabIndex = 3
        Me.radio_lcd.TabStop = True
        Me.radio_lcd.Text = "lcd - 100"
        Me.radio_lcd.UseVisualStyleBackColor = True
        '
        'radio_4k
        '
        Me.radio_4k.AutoSize = True
        Me.radio_4k.Location = New System.Drawing.Point(77, 144)
        Me.radio_4k.Name = "radio_4k"
        Me.radio_4k.Size = New System.Drawing.Size(64, 17)
        Me.radio_4k.TabIndex = 4
        Me.radio_4k.TabStop = True
        Me.radio_4k.Text = "4k - 400"
        Me.radio_4k.UseVisualStyleBackColor = True
        '
        'lbl_preco
        '
        Me.lbl_preco.AutoSize = True
        Me.lbl_preco.Location = New System.Drawing.Point(343, 101)
        Me.lbl_preco.Name = "lbl_preco"
        Me.lbl_preco.Size = New System.Drawing.Size(57, 13)
        Me.lbl_preco.TabIndex = 8
        Me.lbl_preco.Text = "peço base"
        '
        'txt_base
        '
        Me.txt_base.Location = New System.Drawing.Point(418, 101)
        Me.txt_base.Name = "txt_base"
        Me.txt_base.Size = New System.Drawing.Size(100, 20)
        Me.txt_base.TabIndex = 9
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(418, 231)
        Me.txt_total.Multiline = True
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 31)
        Me.txt_total.TabIndex = 11
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(343, 234)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(27, 13)
        Me.lbl_total.TabIndex = 10
        Me.lbl_total.Text = "total"
        '
        'txt_periferico
        '
        Me.txt_periferico.Location = New System.Drawing.Point(418, 180)
        Me.txt_periferico.Name = "txt_periferico"
        Me.txt_periferico.Size = New System.Drawing.Size(100, 20)
        Me.txt_periferico.TabIndex = 13
        '
        'lbl_periferico
        '
        Me.lbl_periferico.AutoSize = True
        Me.lbl_periferico.Location = New System.Drawing.Point(343, 187)
        Me.lbl_periferico.Name = "lbl_periferico"
        Me.lbl_periferico.Size = New System.Drawing.Size(50, 13)
        Me.lbl_periferico.TabIndex = 12
        Me.lbl_periferico.Text = "periferico"
        '
        'txt_monitor
        '
        Me.txt_monitor.Location = New System.Drawing.Point(418, 144)
        Me.txt_monitor.Name = "txt_monitor"
        Me.txt_monitor.Size = New System.Drawing.Size(100, 20)
        Me.txt_monitor.TabIndex = 15
        '
        'lbl_monitor
        '
        Me.lbl_monitor.AutoSize = True
        Me.lbl_monitor.Location = New System.Drawing.Point(343, 144)
        Me.lbl_monitor.Name = "lbl_monitor"
        Me.lbl_monitor.Size = New System.Drawing.Size(41, 13)
        Me.lbl_monitor.TabIndex = 14
        Me.lbl_monitor.Text = "monitor"
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(186, 372)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_calcular.TabIndex = 16
        Me.btn_calcular.Text = "calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(295, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "limpar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'check_ssd_500gb
        '
        Me.check_ssd_500gb.AutoSize = True
        Me.check_ssd_500gb.Location = New System.Drawing.Point(77, 276)
        Me.check_ssd_500gb.Name = "check_ssd_500gb"
        Me.check_ssd_500gb.Size = New System.Drawing.Size(108, 17)
        Me.check_ssd_500gb.TabIndex = 7
        Me.check_ssd_500gb.Text = "SSD 500GB  - 50"
        Me.check_ssd_500gb.UseVisualStyleBackColor = True
        '
        'check_rato_razor
        '
        Me.check_rato_razor.AutoSize = True
        Me.check_rato_razor.Location = New System.Drawing.Point(80, 253)
        Me.check_rato_razor.Name = "check_rato_razor"
        Me.check_rato_razor.Size = New System.Drawing.Size(91, 17)
        Me.check_rato_razor.TabIndex = 6
        Me.check_rato_razor.Text = "rato razor - 15"
        Me.check_rato_razor.UseVisualStyleBackColor = True
        '
        'check_impressora
        '
        Me.check_impressora.AutoSize = True
        Me.check_impressora.Location = New System.Drawing.Point(80, 230)
        Me.check_impressora.Name = "check_impressora"
        Me.check_impressora.Size = New System.Drawing.Size(97, 17)
        Me.check_impressora.TabIndex = 5
        Me.check_impressora.Text = "impressora - 99"
        Me.check_impressora.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 415)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_monitor)
        Me.Controls.Add(Me.lbl_monitor)
        Me.Controls.Add(Me.txt_periferico)
        Me.Controls.Add(Me.lbl_periferico)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txt_base)
        Me.Controls.Add(Me.lbl_preco)
        Me.Controls.Add(Me.check_ssd_500gb)
        Me.Controls.Add(Me.check_rato_razor)
        Me.Controls.Add(Me.check_impressora)
        Me.Controls.Add(Me.radio_4k)
        Me.Controls.Add(Me.radio_lcd)
        Me.Controls.Add(Me.lbl_perifericos)
        Me.Controls.Add(Me.lbl_monitores)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "btn_limpar"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_monitores As Label
    Friend WithEvents lbl_perifericos As Label
    Friend WithEvents radio_lcd As RadioButton
    Friend WithEvents radio_4k As RadioButton
    Friend WithEvents lbl_preco As Label
    Friend WithEvents txt_base As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_periferico As TextBox
    Friend WithEvents lbl_periferico As Label
    Friend WithEvents txt_monitor As TextBox
    Friend WithEvents lbl_monitor As Label
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents check_ssd_500gb As CheckBox
    Friend WithEvents check_rato_razor As CheckBox
    Friend WithEvents check_impressora As CheckBox
End Class
