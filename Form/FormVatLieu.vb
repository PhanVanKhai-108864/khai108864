Public Class FormVatLieu

    Private Sub BtnTinhToan_Click(sender As Object, e As EventArgs)
        FormTinhToan.Show()
    End Sub
    Private Sub cbthepdoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbthepdoc.SelectedIndexChanged
        If cbthepdoc.Text = "CB240-T" Then
            tbrs.Text = "210"
            tbrsc.Text = "210"
            tbEb.Text = "200000"
        ElseIf cbthepdoc.Text = "CB300-V" Then
            tbrs.Text = "260"
            tbrsc.Text = "260"
            tbEb.Text = "200000"
        ElseIf cbthepdoc.Text = "CB400-V" Then
            tbrs.Text = "350"
            tbrsc.Text = "350"
            tbEb.Text = "200000"
        ElseIf cbthepdoc.Text = "CB500-V" Then
            tbrs.Text = "435"
            tbrsc.Text = "400"
            tbEb.Text = "200000"
        End If




    End Sub

    Private Sub cbcapdoben_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcapdoben.SelectedIndexChanged
        If cbcapdoben.Text = "B12.5" Then
            tbrb.Text = "7.5"
            tbrbt.Text = "0.66"
            tbe.Text = "21000"
        ElseIf cbcapdoben.Text = "B15" Then
            tbrb.Text = "8.5"
            tbrbt.Text = "0.75"
            tbe.Text = "23000"
        ElseIf cbcapdoben.Text = "B20" Then
            tbrb.Text = "11.5"
            tbrbt.Text = "0.9"
            tbe.Text = "27000"
        ElseIf cbcapdoben.Text = "B25" Then
            tbrb.Text = "14.5"
            tbrbt.Text = "1.05"
            tbe.Text = "30000"
        ElseIf cbcapdoben.Text = "B30" Then
            tbrb.Text = "17"
            tbrbt.Text = "1.2"
            tbe.Text = "32500"
        ElseIf cbcapdoben.Text = "B35" Then
            tbrb.Text = "19.5"
            tbrbt.Text = "1.3"
            tbe.Text = "34500"
        ElseIf cbcapdoben.Text = "B40" Then
            tbrb.Text = "22"
            tbrbt.Text = "1.4"
            tbe.Text = "36000"
        End If
        Dim Rb = tbrb.Text
        Dim Rs = tbrsc.Text
        If cbcapdoben.SelectedIndex > -1 And cbthepdoc.SelectedIndex > -1 Then
            tbxir.Text = Math.Round((0.85 - 0.008 * Rb) / (1 + (Rs / 400) * (1 - (0.85 - 0.008 * Rb) / 1.1)), 2)
        End If

    End Sub

    Private Sub btnLuuVatLieu_Click(sender As Object, e As EventArgs) Handles btnLuuVatLieu.Click
        VatLieu = New clsVatLieu
        VatLieu.Rb = tbrb.Text
        VatLieu.Rbt = tbrbt.Text
        VatLieu.E = tbe.Text
        VatLieu.Rs = tbrs.Text
        VatLieu.Rsc = tbrsc.Text
        VatLieu.Eb = tbEb.Text
        VatLieu.Shi_R = tbxir.Text

        MsgBox("Đã lưu vật liệu thành công")
        If Me.cbthepdoc.SelectedIndex = 0 Then
            If cbcapdoben.Text = "B12.5" Then VatLieu.alphaR = 0.449
            If cbcapdoben.Text = "B15" Then VatLieu.alphaR = 0.446
            If cbcapdoben.Text = "B20" Then VatLieu.alphaR = 0.437
            If cbcapdoben.Text = "B25" Then VatLieu.alphaR = 0.427
            If cbcapdoben.Text = "B30" Then VatLieu.alphaR = 0.419
            If cbcapdoben.Text = "B35" Then VatLieu.alphaR = 0.41
            If cbcapdoben.Text = "B40" Then VatLieu.alphaR = 0.4

        ElseIf Me.cbthepdoc.SelectedIndex = 1 Then
            If cbcapdoben.Text = "B12.5" Then VatLieu.alphaR = 0.442
            If cbcapdoben.Text = "B15" Then VatLieu.alphaR = 0.439
            If cbcapdoben.Text = "B20" Then VatLieu.alphaR = 0.429
            If cbcapdoben.Text = "B25" Then VatLieu.alphaR = 0.418
            If cbcapdoben.Text = "B30" Then VatLieu.alphaR = 0.409
            If cbcapdoben.Text = "B35" Then VatLieu.alphaR = 0.399
            If cbcapdoben.Text = "B40" Then VatLieu.alphaR = 0.39

        ElseIf Me.cbthepdoc.SelectedIndex = 2 Then
            If cbcapdoben.Text = "B12.5" Then VatLieu.alphaR = 0.431
            If cbcapdoben.Text = "B15" Then VatLieu.alphaR = 0.427
            If cbcapdoben.Text = "B20" Then VatLieu.alphaR = 0.416
            If cbcapdoben.Text = "B25" Then VatLieu.alphaR = 0.405
            If cbcapdoben.Text = "B30" Then VatLieu.alphaR = 0.395
            If cbcapdoben.Text = "B35" Then VatLieu.alphaR = 0.384
            If cbcapdoben.Text = "B40" Then VatLieu.alphaR = 0.374

        End If

    End Sub

    Private Sub BtnTinhToan_Click_1(sender As Object, e As EventArgs) Handles BtnTinhToan.Click
        Dim form_tinhtoan As New FormTinhToan()
        panel.Controls.Clear()
        form_tinhtoan.TopLevel = False
        form_tinhtoan.Dock = DockStyle.Fill
        'MessageBox.Show(Cot.lo & " " & Cot.dx & " " & Cot.dy & " " & Cot.a & " " & Cot.N & " " & Cot.M_x & " " & Cot.M_y & " " & Cot.Ra & " " & Cot.Rb & " " & Cot.Ea & " " & Cot.Eb & " " & Cot.tencot)

        panel.Controls.Add(form_tinhtoan)
        form_tinhtoan.Show()
    End Sub

    Private Sub FormVatLieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbcapdoben.SelectedIndex = 3
    End Sub
End Class