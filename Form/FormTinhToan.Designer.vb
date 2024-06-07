<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTinhToan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvtinhtoan = New System.Windows.Forms.DataGridView()
        Me.clTang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clCot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clAstt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clHamLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clKiemTra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clThepDoc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clAs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clb1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clh1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBotTri = New System.Windows.Forms.Button()
        Me.Btntinhtoan = New System.Windows.Forms.Button()
        CType(Me.dgvtinhtoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvtinhtoan
        '
        Me.dgvtinhtoan.AllowUserToAddRows = False
        Me.dgvtinhtoan.AllowUserToDeleteRows = False
        Me.dgvtinhtoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvtinhtoan.BackgroundColor = System.Drawing.Color.White
        Me.dgvtinhtoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtinhtoan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clTang, Me.clCot, Me.clAstt, Me.clHamLuong, Me.clKiemTra, Me.clThepDoc, Me.clu, Me.clv, Me.clAs, Me.clb1, Me.clh1})
        Me.dgvtinhtoan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvtinhtoan.Location = New System.Drawing.Point(0, 59)
        Me.dgvtinhtoan.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvtinhtoan.Name = "dgvtinhtoan"
        Me.dgvtinhtoan.RowHeadersVisible = False
        Me.dgvtinhtoan.RowHeadersWidth = 51
        Me.dgvtinhtoan.Size = New System.Drawing.Size(1420, 576)
        Me.dgvtinhtoan.TabIndex = 8
        '
        'clTang
        '
        Me.clTang.HeaderText = "Tầng"
        Me.clTang.MinimumWidth = 6
        Me.clTang.Name = "clTang"
        '
        'clCot
        '
        Me.clCot.HeaderText = "Tên cột"
        Me.clCot.MinimumWidth = 6
        Me.clCot.Name = "clCot"
        '
        'clAstt
        '
        Me.clAstt.HeaderText = "Astt (cm2)"
        Me.clAstt.MinimumWidth = 6
        Me.clAstt.Name = "clAstt"
        '
        'clHamLuong
        '
        Me.clHamLuong.HeaderText = "Hàm lượng (%)"
        Me.clHamLuong.MinimumWidth = 6
        Me.clHamLuong.Name = "clHamLuong"
        '
        'clKiemTra
        '
        Me.clKiemTra.HeaderText = "Kiểm tra"
        Me.clKiemTra.MinimumWidth = 6
        Me.clKiemTra.Name = "clKiemTra"
        '
        'clThepDoc
        '
        Me.clThepDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clThepDoc.HeaderText = "Thép Dọc (mm)"
        Me.clThepDoc.Items.AddRange(New Object() {"6", "8", "10", "12", "14", "16", "18", "20", "22", "25", "28", "30", "32"})
        Me.clThepDoc.MinimumWidth = 6
        Me.clThepDoc.Name = "clThepDoc"
        Me.clThepDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clThepDoc.Width = 98
        '
        'clu
        '
        Me.clu.HeaderText = "u"
        Me.clu.MinimumWidth = 6
        Me.clu.Name = "clu"
        Me.clu.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clv
        '
        Me.clv.HeaderText = "v"
        Me.clv.MinimumWidth = 6
        Me.clv.Name = "clv"
        Me.clv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clAs
        '
        Me.clAs.HeaderText = "Asbt (cm2)"
        Me.clAs.MinimumWidth = 6
        Me.clAs.Name = "clAs"
        '
        'clb1
        '
        Me.clb1.HeaderText = "b1 (mm)"
        Me.clb1.MinimumWidth = 6
        Me.clb1.Name = "clb1"
        '
        'clh1
        '
        Me.clh1.HeaderText = "h1 (mm)"
        Me.clh1.MinimumWidth = 6
        Me.clh1.Name = "clh1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.BtnBotTri)
        Me.Panel1.Controls.Add(Me.Btntinhtoan)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1420, 59)
        Me.Panel1.TabIndex = 9
        '
        'BtnBotTri
        '
        Me.BtnBotTri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtnBotTri.Location = New System.Drawing.Point(1123, 23)
        Me.BtnBotTri.Name = "BtnBotTri"
        Me.BtnBotTri.Size = New System.Drawing.Size(116, 29)
        Me.BtnBotTri.TabIndex = 1
        Me.BtnBotTri.Text = "Bố trí"
        Me.BtnBotTri.UseVisualStyleBackColor = True
        '
        'Btntinhtoan
        '
        Me.Btntinhtoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Btntinhtoan.Location = New System.Drawing.Point(1263, 23)
        Me.Btntinhtoan.Name = "Btntinhtoan"
        Me.Btntinhtoan.Size = New System.Drawing.Size(116, 29)
        Me.Btntinhtoan.TabIndex = 0
        Me.Btntinhtoan.Text = "Tính toán"
        Me.Btntinhtoan.UseVisualStyleBackColor = True
        '
        'FormTinhToan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1420, 635)
        Me.Controls.Add(Me.dgvtinhtoan)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTinhToan"
        Me.Text = "o"
        CType(Me.dgvtinhtoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvtinhtoan As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnBotTri As Button
    Friend WithEvents Btntinhtoan As Button
    Friend WithEvents clTang As DataGridViewTextBoxColumn
    Friend WithEvents clCot As DataGridViewTextBoxColumn
    Friend WithEvents clAstt As DataGridViewTextBoxColumn
    Friend WithEvents clHamLuong As DataGridViewTextBoxColumn
    Friend WithEvents clKiemTra As DataGridViewTextBoxColumn
    Friend WithEvents clThepDoc As DataGridViewComboBoxColumn
    Friend WithEvents clu As DataGridViewTextBoxColumn
    Friend WithEvents clv As DataGridViewTextBoxColumn
    Friend WithEvents clAs As DataGridViewTextBoxColumn
    Friend WithEvents clb1 As DataGridViewTextBoxColumn
    Friend WithEvents clh1 As DataGridViewTextBoxColumn
End Class
