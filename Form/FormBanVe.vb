Imports Microsoft.VisualBasic.Devices

Public Class FormBanVe
    Private toadove As Integer = 0
    Private hc As Double
    Private bc As Double
    Private a As Double
    Private d As Double
    Private dd As Double
    Private sn As Double
    Private s1 As Double
    Private kh As Double
    Private lc As Double
    Private s2 As Double
    Private h11 As Double
    Private vv As Double
    Private aa As Double
    Private uu As Double
    Private b11 As Double
    Private st As Double
    Private Sub FormBanVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To data_chonthep.Rows.Count - 1
            cmbChonCot.Items.Add(data_chonthep.Rows(i)(0))
        Next
        cmbChonCot.SelectedIndex = 0


        banve.ActiveDocument.Open(Application.StartupPath & "\vecad.dxf", 0, 0)
        Me.banve.ActiveDocument.Entities.EraseAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.banve.ActiveDocument.Entities.EraseAll()
        hc = Convert.ToDouble(lblh.Text)
        bc = Convert.ToDouble(lblb.Text)
        a = Convert.ToDouble(lbla.Text)
        d = Convert.ToDouble(lbld.Text)
        dd = Convert.ToDouble(lbldd.Text)
        ''sn
        s1 = Convert.ToDouble(lbls1.Text)
        ''kh
        lc = Convert.ToDouble(lbll.Text)
        s2 = Convert.ToDouble(lbls2.Text)
        h11 = Convert.ToDouble(lblh1.Text)
        vv = Convert.ToDouble(txtv.Text)
        aa = a
        uu = Convert.ToDouble(txtu.Text)
        b11 = Convert.ToDouble(lblb1.Text)
        ''st
        ve()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Save As New SaveFileDialog
        Save.Filter = "dxf|*.dxf"

        If (Save.ShowDialog = DialogResult.OK) Then
            banve.ActiveDocument.SaveAs(Save.FileName, 7)
        End If
    End Sub
    Private Sub cmbChonCot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChonCot.SelectedIndexChanged

        Dim keyword As String = cmbChonCot.SelectedItem

        Dim queryrow = (From row In data_chonthep.AsEnumerable()
                        Where row.Field(Of String)(0).Contains(keyword)
                        Select row).FirstOrDefault()
        lbll.Text = queryrow.Field(Of String)(1)
        lblb.Text = queryrow.Field(Of String)(2)
        lblh.Text = queryrow.Field(Of String)(3)
        lbla.Text = queryrow.Field(Of String)(4)
        lbld.Text = queryrow.Field(Of String)(5)
        lblb1.Text = queryrow.Field(Of String)(6)
        lblh1.Text = queryrow.Field(Of String)(7)
        lbldd.Text = queryrow.Field(Of String)(8)
        lbls1.Text = queryrow.Field(Of String)(9)
        lbls2.Text = queryrow.Field(Of String)(10)
        txtu.Text = queryrow.Field(Of String)(11)
        txtv.Text = queryrow.Field(Of String)(12)
    End Sub
    Public Sub ve()
        Dim dimkt As VDProLib5.vdDimension
        Dim text As VDProLib5.vdText
        Dim poly As VDProLib5.vdPolyline
        Dim circle As VDProLib5.vdCircle
        Dim ds As VDProLib5.vdDimstyle
        ds = banve.ActiveDocument.DimStyles.Add("Standard")

        'Đặt kích thước của các phần thuộc đối tượng dim

        ds.ArrowSize = 60
        ds.ExtLineDist1 = 10
        ds.ExtLineDist2 = 0.1
        'Đặt độ chính xác, thứ tự số thập phân làm tròn sau dấu phẩy
        ds.DecimalPrecision = 0
        'Đặt các thông số cho text dim
        ''Chiều cao text
        ds.TextHeight = 30
        Try

            'toadove += 2500

            If Int(30 * d / 50) = 30 * d / 50 Then
                sn = 30 * d + bc + 100
            Else
                sn = 50 * Int(30 * d / 50) + 50 + bc + 100
            End If

            'VẼ THÉP TRÒN MC
            circle = banve.ActiveDocument.Entities.AddCircle(New Object() {a + d / 2 + toadove, a + d / 2}, d / 2)
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {-100 + toadove, bc / 2}, New Object() {a + d / 2 + toadove, a + d / 2}})
            poly.LayerName = "NetTruc"
            circle = banve.ActiveDocument.Entities.AddCircle(New Object() {hc - a - d / 2 + toadove, a + d / 2}, d / 2)
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {-100 + toadove, bc / 2}, New Object() {hc - a - d / 2 + toadove, a + d / 2}})
            poly.LayerName = "NetTruc"
            circle = banve.ActiveDocument.Entities.AddCircle(New Object() {a + d / 2 + toadove, bc - a - d / 2}, d / 2)
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {-100 + toadove, bc / 2}, New Object() {a + d / 2 + toadove, bc - a - d / 2}})
            poly.LayerName = "NetTruc"
            circle = banve.ActiveDocument.Entities.AddCircle(New Object() {hc - a - d / 2 + toadove, bc - a - d / 2}, d / 2)
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {-100 + toadove, bc / 2}, New Object() {hc - a - d / 2 + toadove, bc - a - d / 2}})
            poly.LayerName = "NetTruc"


            'VẼ MẶT CẮT
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {0 + toadove, 0}, New Object() {hc + toadove, 0}, New Object() {hc + toadove, bc}, New Object() {0 + toadove, bc}, New Object() {0 + toadove, 0}})
            poly.LayerName = "Thep Tren"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + toadove, a}, New Object() {hc - a + toadove, a}, New Object() {hc - a + toadove, bc - a}, New Object() {a + toadove, bc - a}, New Object() {a + toadove, a}})
            'DIM MẶT CẮT
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {hc + toadove, 0}, New Object() {hc + toadove, bc}, New Object() {hc + 250 + toadove, 200})
            dimkt.LayerName = "nettruc"
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {hc + toadove, 0}, New Object() {hc + toadove, a}, New Object() {hc + 150 + toadove, 200})
            dimkt.LayerName = "nettruc"
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {hc + toadove, a}, New Object() {hc + toadove, bc - a}, New Object() {hc + 150 + toadove, 200})
            dimkt.LayerName = "nettruc"
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {hc + toadove, bc - a}, New Object() {hc + toadove, bc}, New Object() {hc + 150 + toadove, 200})
            dimkt.LayerName = "nettruc"
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {0 + toadove, 0}, New Object() {hc + toadove, 0}, New Object() {bc + 150 + toadove, -250})
            dimkt.LayerName = "nettruc"
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {0 + toadove, 0}, New Object() {a + toadove, 0}, New Object() {bc + 100 + toadove, -150})
            dimkt.LayerName = "nettruc"
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {a + toadove, 0}, New Object() {hc - a + toadove, 0}, New Object() {bc + 100 + toadove, -150})
            dimkt.LayerName = "nettruc"
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {hc - a + toadove, 0}, New Object() {hc + toadove, 0}, New Object() {bc + 100 + toadove, -150})
            dimkt.LayerName = "nettruc"
            dimkt.Invalidate()
            'VẼ THÉP ĐAI
            For kc = sn - 600 To sn + 500 * s1 Step s1
                If kc <= sn Then
                    poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + toadove, kc}, New Object() {hc - a + toadove, kc}})
                Else
                    For j = 1 To 500
                        If kc <= lc + bc + 100 Then
                            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + toadove, kc}, New Object() {hc - a + toadove, kc}})
                        End If
                        kc = kc + s2
                    Next
                End If
            Next

            'KÝ HIỆU THÉP
            kh = sn - bc - 150
            kh = s1 * (Int(kh / s1) + 1)
            text = banve.ActiveDocument.Entities.AddText(" d " & dd, New Object() {-250 + toadove, bc + kh + 2.5 * s2 + 170}, 25)
            text.LayerName = "Text"
            text = banve.ActiveDocument.Entities.AddText(" a " & s2, New Object() {-250 + toadove, bc + kh + 2.5 * s2 + 105}, 25)
            text.LayerName = "Text"
            circle = banve.ActiveDocument.Entities.AddCircle(New Object() {-330 + toadove, bc + kh + 2.5 * s2 + 150}, 30)
            circle.LayerName = "NetTruc"
            text = banve.ActiveDocument.Entities.AddText(" D1 ", New Object() {-358 + toadove, bc + kh + 2.5 * s2 + 150 - 18}, 25)
            text.LayerName = "Text"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 + toadove, bc + kh + 2.5 * s2 + 150}, New Object() {-300 + toadove, bc + kh + 2.5 * s2 + 150}})
            poly.LayerName = "NetTruc"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 + toadove, bc + kh + s2 + 200}, New Object() {a + h11 / 2 + toadove, bc + kh + 4 * s2 + 200}})
            poly.LayerName = "NetTruc"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 - 30 + toadove, bc + kh + s2 + 170}, New Object() {a + h11 / 2 + 30 + toadove, bc + kh + s2 + 230}})
            poly.LayerName = "NetTruc"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 - 30 + toadove, bc + kh + 2 * s2 + 170}, New Object() {a + h11 / 2 + 30 + toadove, bc + kh + 2 * s2 + 230}})
            poly.LayerName = "NetTruc"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 - 30 + toadove, bc + kh + 3 * s2 + 170}, New Object() {a + h11 / 2 + 30 + toadove, bc + kh + 3 * s2 + 230}})
            poly.LayerName = "NetTruc"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 - 30 + toadove, bc + kh + 4 * s2 + 170}, New Object() {a + h11 / 2 + 30 + toadove, bc + kh + 4 * s2 + 230}})
            poly.LayerName = "NetTruc"
            kh = bc + 150 + kh + s2 / 2
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {hc - a / 2 + toadove, kh}, New Object() {-300 + toadove, kh}})
            poly.LayerName = "NetTruc"
            circle = banve.ActiveDocument.Entities.AddCircle(New Object() {-330 + toadove, kh}, 30)
            circle.LayerName = "NetTruc"
            text = banve.ActiveDocument.Entities.AddText(" 1 ", New Object() {-348 + toadove, kh - 18}, 25)
            text.LayerName = "Text"
            'VẼ MẶT ĐỨNG
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {0 + toadove, bc + 100}, New Object() {hc + toadove, bc + 100}, New Object() {hc + toadove, bc + 100 + lc}, New Object() {0 + toadove, bc + 100 + lc}, New Object() {0 + toadove, bc + 100}})
            poly.LayerName = "Thep Tren"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 + toadove, bc + 200}, New Object() {a + h11 / 2 + toadove, bc + 3 * s1 + 200}})
            poly.LayerName = "NetTruc"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 - 30 + toadove, bc + 170}, New Object() {a + h11 / 2 + 30 + toadove, bc + 230}})
            poly.LayerName = "NetTruc"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 - 30 + toadove, bc + s1 + 170}, New Object() {a + h11 / 2 + 30 + toadove, bc + s1 + 230}})
            poly.LayerName = "NetTruc"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 - 30 + toadove, bc + 2 * s1 + 170}, New Object() {a + h11 / 2 + 30 + toadove, bc + 2 * s1 + 230}})
            poly.LayerName = "NetTruc"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 - 30 + toadove, bc + 3 * s1 + 170}, New Object() {a + h11 / 2 + 30 + toadove, bc + 3 * s1 + 230}})
            poly.LayerName = "NetTruc"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + h11 / 2 + toadove, bc + s1 + s1 / 2 + 150}, New Object() {-300 + toadove, bc + s1 + s1 / 2 + 150}})
            poly.LayerName = "NetTruc"
            circle = banve.ActiveDocument.Entities.AddCircle(New Object() {-330 + toadove, bc + s1 + s1 / 2 + 150}, 30)
            circle.LayerName = "NetTruc"
            text = banve.ActiveDocument.Entities.AddText(" D1 ", New Object() {-358 + toadove, bc + s1 + s1 / 2 + 150 - 18}, 25)
            text.LayerName = "Text"

            For i = 1 To vv
                If a <= hc Then
                    'vẽ thép dọc
                    poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + toadove, bc + 100}, New Object() {a + toadove, sn + lc}})

                    poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + toadove, sn + lc}, New Object() {a + 20 + toadove, sn + lc - 70}})

                    poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + toadove, bc + 100}, New Object() {a + 20 + toadove, bc + 170}})

                    poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a + toadove, sn}, New Object() {a + 20 + toadove, sn - 70}})

                    poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {a - 30 + toadove, kh - 30}, New Object() {a + 30 + toadove, kh + 30}})

                    poly.LayerName = "NetTruc"
                    If 1 < i And i < vv Then
                        circle = banve.ActiveDocument.Entities.AddCircle(New Object() {a + toadove, aa + d / 2}, d / 2)
                        circle = banve.ActiveDocument.Entities.AddCircle(New Object() {a + toadove, bc - aa - d / 2}, d / 2)
                        poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {-100 + toadove, bc / 2}, New Object() {a + toadove, aa + d / 2}})
                        poly.LayerName = "NetTruc"
                        poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {-100 + toadove, bc / 2}, New Object() {a + toadove, bc - aa - d / 2}})
                        poly.LayerName = "NetTruc"
                    End If
                End If
                a = a + h11
            Next
            a = Val(lbla.Text) * 1000
            For i = 1 To uu
                If a <= bc Then
                    If 1 < i And i < uu Then
                        circle = banve.ActiveDocument.Entities.AddCircle(New Object() {aa + d / 2 + toadove, a}, d / 2)
                        circle = banve.ActiveDocument.Entities.AddCircle(New Object() {hc - aa - d / 2 + toadove, a}, d / 2)
                        poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {-100 + toadove, bc / 2}, New Object() {aa + d / 2 + toadove, a}})
                        poly.LayerName = "NetTruc"
                        poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {-100 + toadove, bc / 2}, New Object() {hc - aa - d / 2 + toadove, a}})
                        poly.LayerName = "NetTruc"
                    End If
                End If
                a = a + b11
            Next
            'DIM MẶT ĐỨNG
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {hc + toadove, bc + 100}, New Object() {hc + toadove, sn}, New Object() {hc + 150 + toadove, 200})
            dimkt.LayerName = "NetTruc"
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {hc + toadove, sn}, New Object() {hc + toadove, bc + 100 + lc}, New Object() {hc + 150 + toadove, 200})
            dimkt.LayerName = "NetTruc"
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {hc + toadove, bc + 100 + lc}, New Object() {hc + toadove, sn + lc}, New Object() {hc + 150 + toadove, 200})
            dimkt.LayerName = "NetTruc"
            dimkt = banve.ActiveDocument.Entities.AddDimAligned(New Object() {hc + toadove, bc + 100}, New Object() {hc + toadove, bc + 100 + lc}, New Object() {hc + 250 + toadove, 200})
            dimkt.LayerName = "NetTruc"

            'CHÈN TEXT
            st = 2 * (uu + vv - 2)
            text = banve.ActiveDocument.Entities.AddText(cmbChonCot.Text, New Object() {hc / 2 - 100 + toadove, -400}, 70)
            text.LayerName = "Text"
            ' text = banve.ActiveDocument.Entities.AddText(cmbTang.Text, New Object() {hc / 2 - 180 + toadove, -600}, 90)
            text.LayerName = "Text"
            text = banve.ActiveDocument.Entities.AddText(st & " d " & d, New Object() {-250 + toadove, kh + 20}, 25)
            text.LayerName = "Text"
            poly = banve.ActiveDocument.Entities.AddPolyLine(New Object() {New Object() {-300 + toadove, bc / 2}, New Object() {-100 + toadove, bc / 2}})
            poly.LayerName = "NetTruc"
            circle = banve.ActiveDocument.Entities.AddCircle(New Object() {-330 + toadove, bc / 2}, 30)
            circle.LayerName = "NetTruc"
            text = banve.ActiveDocument.Entities.AddText(" 1 ", New Object() {-348 + toadove, bc / 2 - 18}, 25)
            text.LayerName = "Text"
            text = banve.ActiveDocument.Entities.AddText(st & " d " & d, New Object() {-250 + toadove, bc / 2 + 20}, 25)
            text.LayerName = "Text"
            text = banve.ActiveDocument.Entities.AddText(" d " & dd, New Object() {-250 + toadove, bc + s1 + s1 / 2 + 170}, 25)
            text.LayerName = "Text"
            text = banve.ActiveDocument.Entities.AddText(" a " & s1, New Object() {-250 + toadove, bc + s1 + s1 / 2 + 105}, 25)
            text.LayerName = "Text"

            banve.CommandAction.Zoom("W", New Object() {-3000, -500}, New Object() {sn + lc + 200 + toadove, sn + lc + 200})
            Me.banve.CommandAction.Zoom("e", "USER", "USER")
            Me.banve.CommandAction.Zoom("S", 1 / 1.1, "USER")
        Catch

        End Try
    End Sub
End Class