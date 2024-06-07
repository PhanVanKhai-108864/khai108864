Imports PhanVanKhai_108864_64TH2.DATN

Public Class FormTinhToan
    Private Sub Btntinhtoan_Click(sender As Object, e As EventArgs) Handles Btntinhtoan.Click
        ' Tạo một instance của ClsTinhToan
        dgvtinhtoan.Rows.Clear()

        For Each dong As DataRow In data_tinhtoan.Rows
            Dim calculations As New ClsTinhToan()

            ' Gán giá trị cho các thuộc tính (ví dụ giá trị)

            calculations.Tang = dong(0).ToString
            calculations.TenCot = dong(1).ToString
            Dim nValue As Double

            calculations.N = Convert.ToDouble(dong(5).ToString())
            calculations.My = Convert.ToDouble(dong(7).ToString())
            calculations.Mx = Convert.ToDouble(dong(6).ToString())
            calculations.L = Convert.ToDouble(dong(2).ToString())
            calculations.Cx = Convert.ToDouble(dong(3).ToString())
            calculations.Cy = Convert.ToDouble(dong(4).ToString())
            calculations.Rb = VatLieu.Rb
            calculations.Rs = VatLieu.Rs
            calculations.Eb = VatLieu.Eb
            calculations.Er = VatLieu.Shi_R

            ' Thực hiện tính toán
            calculations.TinhToan()
            calculations.TinhToanmuy()
            calculations.KiemTra()
            dgvtinhtoan.Rows.Add(calculations.Tang, calculations.TenCot, calculations.Ast.ToString(), calculations.muy, calculations.KiemTra, "18", "", "", "", "", "", "8", "", "")
        Next

    End Sub

    Private Sub BtnBotTri_Click(sender As Object, e As EventArgs) Handles BtnBotTri.Click
        data_chonthep = New DataTable
        If data_chonthep.Columns.Count < 1 Then
            data_chonthep.Columns.Add("tencot")
            data_chonthep.Columns.Add("L")
            data_chonthep.Columns.Add("b")
            data_chonthep.Columns.Add("h")
            data_chonthep.Columns.Add("a")
            data_chonthep.Columns.Add("phi")
            data_chonthep.Columns.Add("b1")
            data_chonthep.Columns.Add("h1")
            data_chonthep.Columns.Add("dai")
            data_chonthep.Columns.Add("s1")
            data_chonthep.Columns.Add("s2")
            data_chonthep.Columns.Add("u")
            data_chonthep.Columns.Add("v")
        End If
        data_chonthep.Rows.Clear()
        For i = 0 To dgvtinhtoan.RowCount - 1
            Dim As_tt As Double = Convert.ToDouble(dgvtinhtoan.Rows(i).Cells(2).Value)
            Dim phi As Double = Convert.ToDouble(dgvtinhtoan.Rows(i).Cells(5).Value)
            Dim dientichcotthep As Double = Math.PI * ((phi / 2) / 10) ^ 2
            Dim sothanh As Double = Int(As_tt / dientichcotthep) + 1
            dgvtinhtoan.Rows(i).Cells(6).Value = Convert.ToInt32(sothanh / 2)
            dgvtinhtoan.Rows(i).Cells(7).Value = Convert.ToInt32(sothanh / 2)
            dgvtinhtoan.Rows(i).Cells(8).Value = sothanh * dientichcotthep
            Dim sothanh1 As Integer = dgvtinhtoan.Rows(i).Cells(6).Value
            Dim sothanh2 As Integer = dgvtinhtoan.Rows(i).Cells(7).Value
            'khoảnng b1 
            Dim b1 As Double = (Cot.b - 60) / (sothanh1 - 1)
            Dim h1 As Double = (Cot.h - 60) / (sothanh2 - 1)

            dgvtinhtoan.Rows(i).Cells(9).Value = b1
            dgvtinhtoan.Rows(i).Cells(10).Value = h1
            Dim tentang As String = dgvtinhtoan.Rows(i).Cells(1).Value

            data_chonthep.Rows.Add(tentang, "", "", "", 30, phi, b1, h1, 8, 150, 150, sothanh1, sothanh2)
        Next


        For Each dong As DataRow In data_tinhtoan.Rows
            For i = 0 To data_chonthep.Rows.Count - 1
                If dong(1).ToString = data_chonthep.Rows(i)(0).ToString Then
                    data_chonthep.Rows(i)(1) = dong(2).ToString
                    data_chonthep.Rows(i)(2) = dong(3).ToString
                    data_chonthep.Rows(i)(3) = dong(4).ToString
                End If
            Next
        Next
        Dim a = 1


    End Sub
End Class
