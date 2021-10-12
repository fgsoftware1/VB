Public Class btn_limpar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        radio_lcd.Checked = False
        radio_4k.Checked = False
        radio_impressora.Checked = False
        radio_rato_razor.Checked = False
        radio_ssd_500gb.Checked = False
        txt_base.Text = ""
        txt_monitor.Text = ""
        txt_periferico.Text = ""
        txt_total.Text = ""
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim base As Integer = 0, monitor = 0, periferico = 0

        base = Convert.ToInt32(txt_base.Text)

        If radio_lcd.Checked = True Then
            txt_monitor.Text = 100
        ElseIf radio_4k.Checked = True Then
            txt_monitor.Text = 400
        Else
            txt_monitor.Text = ""
        End If

        If radio_impressora.Checked = True Then
            txt_periferico.Text = 99
        ElseIf radio_rato_razor.Checked = True Then
            txt_periferico.Text = 15
        ElseIf radio_ssd_500gb.Checked = True Then
            txt_periferico.Text = 50
        Else
            txt_periferico.Text = ""
        End If
    End Sub
End Class