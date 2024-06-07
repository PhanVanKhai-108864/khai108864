
Public Class FormTietDien

    Private Sub btnThemCot_Click(sender As Object, e As EventArgs) Handles btnThemCot.Click
        Dim formThemcot As New FormThemcot()
        formThemcot.DataGridViewFromOtherForm = dgvdulieucot ' Truyền tham chiếu của DataGridView vào FormThemcot
        formThemcot.Show()

    End Sub

    Private Sub FormTietDien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cài đặt thuộc tính của DataGridView để cho phép chỉnh sửa trực tiếp
        dgvdulieucot.EditMode = DataGridViewEditMode.EditOnEnter
        dgvdulieucot.AllowUserToAddRows = True
        dgvdulieucot.AllowUserToDeleteRows = True


        For Each column As DataGridViewColumn In dgvdulieucot.Columns
            column.ReadOnly = False
        Next
    End Sub

    Private Sub btnXoaCot_Click(sender As Object, e As EventArgs) Handles btnXoaCot.Click
        If dgvdulieucot.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvdulieucot.SelectedRows
                If Not row.IsNewRow Then
                    dgvdulieucot.Rows.Remove(row)
                End If
            Next
        Else
            MessageBox.Show("Hãy chọn ít nhất một hàng để xóa.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Kiểm tra xem DataGridView có dữ liệu hay không
        If dgvdulieucot.Rows.Count = 0 OrElse (dgvdulieucot.Rows.Count = 1 AndAlso dgvdulieucot.Rows(0).IsNewRow) Then
            MessageBox.Show("Vui lòng nhập dữ liệu cột")
        Else
            Dim form_VatLieu As New FormVatLieu()
            panel.Controls.Clear()
            form_VatLieu.TopLevel = False
            form_VatLieu.Dock = DockStyle.Fill
            panel.Controls.Add(form_VatLieu)
            form_VatLieu.Show()
        End If
        data_tinhtoan.Clear()
        If data_tinhtoan.Columns.Count < 1 Then
            For Each column As DataGridViewColumn In dgvdulieucot.Columns
                ' Thêm tên của cột vào bảng dữ liệu (data_tinhtoan)
                data_tinhtoan.Columns.Add(column.Name)
            Next
        End If


        For i As Integer = 0 To dgvdulieucot.Rows.Count - 2
            Dim newRow As DataRow = data_tinhtoan.NewRow()

            ' Duyệt qua từng cột để lấy giá trị từ DataGridView và thêm vào dòng mới
            For Each column As DataGridViewColumn In dgvdulieucot.Columns
                newRow(column.Name) = dgvdulieucot.Rows(i).Cells(column.Name).Value
            Next

            ' Thêm dòng mới vào bảng dữ liệu
            data_tinhtoan.Rows.Add(newRow)
        Next




    End Sub
End Class
