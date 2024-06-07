Module Module1
    Public frmHome As New Formgioithieu
    Public frmVatLieu As New FormVatLieu
    Public frmTinhToan As New FormTinhToan
    Public frmThongSoBanVe As New FormBanVe
    Public frmTietDien As New FormTietDien
    Public panel As Panel
    Public VatLieu As clsVatLieu
    Public Cot As New clsCot
    Public data_tinhtoan As New DataTable
    Public data_chonthep As New DataTable
    Public danhsachCot As New List(Of Clscot)
    Public So_lan_bam_nut_them As Integer = 0
    Public value_cbb As String
    Public Sub showform(frm As Form)

        frm.MdiParent = TrangChu
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        frm.FormBorderStyle = FormBorderStyle.None
        frm.BringToFront()
        frm.Show()
    End Sub

End Module