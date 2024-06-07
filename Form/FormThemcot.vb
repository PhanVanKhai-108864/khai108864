Imports System.Text.RegularExpressions

Public Class FormThemcot
    Private WithEvents dgvdulieucot As DataGridView
    Private capGiaTriCu As New Dictionary(Of String, HashSet(Of String))()

    ' Thuộc tính để lưu tham chiếu của DataGridView từ form khác
    Public Property DataGridViewFromOtherForm As DataGridView
        Get
            Return dgvdulieucot
        End Get
        Set(value As DataGridView)
            dgvdulieucot = value
        End Set
    End Property

    ' Xử lý sự kiện click của nút "Thêm"
    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        If Check_Input() = True Then
            ' Kiểm tra xem DataGridView đã được truyền vào chưa
            If dgvdulieucot IsNot Nothing Then
                ' Kiểm tra tính hợp lệ của các trường nhập liệu
                Dim inputs = New TextBox() {txtTang, txtTenCot, txtL, txtB, txtH, txtN, txtMx, txtMy}
                For Each input As TextBox In inputs
                    If String.IsNullOrEmpty(input.Text) Then
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
                        Return
                    End If
                Next
                So_lan_bam_nut_them = So_lan_bam_nut_them + 1
                ' Lấy giá trị từ các trường nhập liệu
                txtTenCot.Text = "C" & So_lan_bam_nut_them
                Cot.Tang = txtTang.Text
                Cot.TenCot = txtTenCot.Text
                Cot.L = txtL.Text
                Cot.b = txtB.Text
                Cot.h = txtH.Text
                Cot.N = txtN.Text
                Cot.Mx = txtMx.Text
                Cot.My = txtMy.Text




                ' Thêm dòng mới vào DataGridView
                dgvdulieucot.Rows.Add(Cot.Tang, Cot.TenCot, Cot.L, Cot.b, Cot.h, Cot.N, Cot.Mx, Cot.My)

            End If

        End If
    End Sub
    Function Check_Input() As Boolean
        Dim regex As New Regex("^\d+$")

        If regex.IsMatch(txtB.Text) AndAlso regex.IsMatch(txtL.Text) Then
            Return True
        Else
            MsgBox("Kiểm tra lại đầu vào !!!")
            Return False
        End If
    End Function

    Public Shared listtang As New List(Of String)

    ' Xử lý sự kiện click của nút "Thoát"
    Private Sub BtnThoat_Click(sender As Object, e As EventArgs) Handles BtnThoat.Click
        Me.Close()
    End Sub

    Private Sub FormThemcot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class
