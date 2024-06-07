Imports DevExpress.XtraWaitForm

Public Class Formgioithieu
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form_TietDien As New FormTietDien()
        panel.Controls.Clear()
        form_TietDien.TopLevel = False
        form_TietDien.Dock = DockStyle.Fill
        panel.Controls.Add(form_TietDien)
        form_TietDien.Show()

    End Sub
End Class