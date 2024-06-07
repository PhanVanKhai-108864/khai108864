Imports System.ComponentModel
Imports System.Text
Public Class TrangChu


    Private Sub trangchu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form1 As New Formgioithieu()
        form1.TopLevel = False
        form1.Dock = DockStyle.Fill
        Panel_main.Controls.Add(form1)
        form1.Show()
        panel = Panel_main
        ' Thiết lập trạng thái cửa sổ của form thành Maximized
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Panel_main.Controls.Clear()
        Dim form2 As New Formgioithieu()
        form2.TopLevel = False
        form2.Dock = DockStyle.Fill
        Panel_main.Controls.Add(form2)
        form2.Show()
        So_lan_bam_nut_them = 0
    End Sub



    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Panel_main.Controls.Clear()
        Dim form2 As New FormTietDien()
        form2.TopLevel = False
        form2.Dock = DockStyle.Fill
        Panel_main.Controls.Add(form2)
        form2.Show()
    End Sub





    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Panel_main.Controls.Clear()
        Dim form2 As New FormBanVe()
        form2.TopLevel = False
        form2.Dock = DockStyle.Fill
        Panel_main.Controls.Add(form2)
        form2.Show()
    End Sub




    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Panel_main.Controls.Clear()
        Dim form2 As New FormChuThich()
        form2.TopLevel = False
        form2.Dock = DockStyle.Fill
        Panel_main.Controls.Add(form2)
        form2.Show()
    End Sub
End Class