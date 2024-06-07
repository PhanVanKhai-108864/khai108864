Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DATN

    Public Class ClsTinhToan
        ' Property declarations
        Public Property TenCot As String
        Public Property Tang As String
        Public Property N As Double
        Public Property My As Double
        Public Property Mx As Double
        Public Property L As Double
        Public Property l0 As Double
        Public Property Cy As Double
        Public Property Cx As Double
        Public Property a As Double
        Public Property eax As Double
        Public Property e1x As Double
        Public Property e0x As Double
        Public Property LambdaX As Double
        Public Property EtaX As Double
        Public Property M_x As Double
        Public Property eay As Double
        Public Property e1y As Double
        Public Property e0y As Double
        Public Property LambdaY As Double
        Public Property EtaY As Double
        Public Property M_y As Double
        Public Property b As Double
        Public Property h As Double
        Public Property x1 As Double
        Public Property m0 As Double
        Public Property M As Double
        Public Property ea As Double
        Public Property e1 As Double
        Public Property e0 As Double
        Public Property e As Double
        Public Property Rb As Double
        Public Property Rs As Double
        Public Property Eb As Double
        Public Property Er As Double
        Public Property MoHinhTinhToan As String
        Public Property Ast As Double
        Public Property muy As Double

        ' Private methods
        Private Function DoManh(l0 As Double, c As Double) As Double
            Return l0 / c
        End Function

        Private Function DoLechTamNgauNhien(L As Double, c As Double) As Double
            Return Math.Max(L / 600, c / 30)
        End Function

        Private Function DoLechTamTinhHoc(M As Double, N As Double) As Double
            Return M / N

        End Function

        Private Function DoLechTamBanDau(e1 As Double, ea As Double) As Double
            Return Math.Max(e1, ea)
        End Function

        Private Function Ncr(Theta As Double, Eb As Double, I As Double, l0 As Double) As Double
            Return 2.5 * Theta * Eb * I / (l0 * l0)
        End Function

        Private Function MoMenQuanTinh(c1 As Double, c2 As Double) As Double
            Return c2 * c1 * c1 * c1 / 12
        End Function

        Private Function HeSoDoLechTam(e0 As Double, c As Double) As Double
            Return (0.2 * e0 + 1.05 * c) / (1.5 * e0 + c)
        End Function

        Private Function MoMenQuyDoi(N As Double, Eta As Double, e0 As Double) As Double
            Return N * Eta * e0
        End Function

        Private Function x_(Er As Double, e0 As Double, h0 As Double) As Double
            Dim esp As Double = e0 / h0
            Return (Er + (1 - Er) / (1 + 50 * esp * esp)) * h0
        End Function

        ' Public method
        Public Sub TinhToan()
            ' Mô hình theo phương x
            e1x = DoLechTamTinhHoc(Mx, N)
            eax = DoLechTamNgauNhien(L, Cx)
            e0x = DoLechTamBanDau(e1x, eax)
            l0 = 0.7 * L
            LambdaX = DoManh(l0, Cx)
            If LambdaX < 8 Then
                EtaX = 1
            Else
                Dim I As Double = MoMenQuanTinh(Cx, Cy)
                Dim Theta As Double = HeSoDoLechTam(e0x, Cx)
                EtaX = 1 / (1 - N / (Ncr(Theta, Eb, I, l0)))
            End If
            M_x = MoMenQuyDoi(Mx, EtaX, e0x)

            ' Mô hình theo phương y
            e1y = DoLechTamTinhHoc(My, N)
            eay = DoLechTamNgauNhien(L, Cy)
            e0y = DoLechTamBanDau(e1y, eay)

            LambdaY = DoManh(l0, Cy)
            If LambdaY < 8 Then
                EtaY = 1
            Else
                Dim I As Double = MoMenQuanTinh(Cy, Cx)
                Dim Theta As Double = HeSoDoLechTam(e0y, Cy)
                EtaY = 1 / (1 - N / (Ncr(Theta, Eb, I, l0)))
            End If
            M_y = MoMenQuyDoi(My, EtaY, e0y)

            ' ---------------------------
            Dim M1 As Double
            Dim M2 As Double
            If M_x / Cx > M_y / Cy Then
                h = Cx
                b = Cy
                M1 = M_x
                M2 = M_y
                ea = eax + 0.2 * eay
                MoHinhTinhToan = "Theo phương X"
            Else
                h = Cy
                b = Cx
                M1 = M_y
                M2 = M_x
                ea = eay + 0.2 * eax
                MoHinhTinhToan = "Theo phương Y"
            End If

            a = 30

            Dim h0 As Double = h - a
            Dim Za As Double = h - 2 * a
            x1 = N / (Rb * b)

            If x1 <= h0 Then
                m0 = 1 - 0.6 * x1 / h0
            Else
                m0 = 0.4
            End If
            ' Tinh momen tuong duong (doi lech tam xien sang lech tam phang)
            M = M1 + m0 * M2 * h / b
            e1 = DoLechTamTinhHoc(M, N)
            e0 = DoLechTamBanDau(e1, ea)
            e = e0 + 0.5 * (h - a)
            Er = TinhHeSo.Er(Rb, Rs)
            Dim x As Double = 0
            If x1 < Er * h0 Then
                x = x1
            ElseIf x1 > Er * h0 Then
                x = x_(Er, e0, h0)
            End If



            Ast = Math.Round(2.5 * (N * e - Rb * b * x * (h0 - x / 2)) / (Rs * Za * 10 * 10 * 10 * 10), 3)
            If Ast < 0 Then Ast = 0.2 * b * h0 / 100
        End Sub
        Public Sub TinhToanmuy()
            Dim h0 = h - a
            muy = Ast * 1000 / (b * h0)

        End Sub
        Public Function KiemTra() As String
            Dim h0 = h - a
            If muy >= VatLieu.muy_min And muy < VatLieu.muy_max Then
                Return "Thỏa mãn"
            Else

                Return "Không thỏa mãn"
                End If

        End Function
    End Class
End Namespace
