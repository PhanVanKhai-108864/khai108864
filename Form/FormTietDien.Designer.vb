<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTietDien
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnXoaCot = New System.Windows.Forms.Button()
        Me.btnThemCot = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvdulieucot = New System.Windows.Forms.DataGridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clTenCot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clMx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clMy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvdulieucot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tiết diện cột:"
        '
        'btnXoaCot
        '
        Me.btnXoaCot.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnXoaCot.Location = New System.Drawing.Point(715, 12)
        Me.btnXoaCot.Name = "btnXoaCot"
        Me.btnXoaCot.Size = New System.Drawing.Size(136, 30)
        Me.btnXoaCot.TabIndex = 16
        Me.btnXoaCot.Text = "Xóa tiết diện cột"
        Me.btnXoaCot.UseVisualStyleBackColor = True
        '
        'btnThemCot
        '
        Me.btnThemCot.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThemCot.Location = New System.Drawing.Point(546, 12)
        Me.btnThemCot.Name = "btnThemCot"
        Me.btnThemCot.Size = New System.Drawing.Size(145, 30)
        Me.btnThemCot.TabIndex = 17
        Me.btnThemCot.Text = "Thêm tiết diện cột"
        Me.btnThemCot.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PanelControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 463)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvdulieucot)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(941, 404)
        Me.Panel2.TabIndex = 1
        '
        'dgvdulieucot
        '
        Me.dgvdulieucot.AllowUserToAddRows = False
        Me.dgvdulieucot.AllowUserToDeleteRows = False
        Me.dgvdulieucot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdulieucot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvdulieucot.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvdulieucot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdulieucot.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.clTenCot, Me.cll, Me.clb, Me.clh, Me.clN, Me.clMx, Me.clMy})
        Me.dgvdulieucot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvdulieucot.Location = New System.Drawing.Point(0, 0)
        Me.dgvdulieucot.Name = "dgvdulieucot"
        Me.dgvdulieucot.ReadOnly = True
        Me.dgvdulieucot.RowHeadersWidth = 51
        Me.dgvdulieucot.Size = New System.Drawing.Size(941, 404)
        Me.dgvdulieucot.TabIndex = 15
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Button1)
        Me.PanelControl1.Controls.Add(Me.btnThemCot)
        Me.PanelControl1.Controls.Add(Me.btnXoaCot)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(941, 59)
        Me.PanelControl1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button1.Location = New System.Drawing.Point(412, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Vật liệu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tầng"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'clTenCot
        '
        Me.clTenCot.HeaderText = "Tên cột"
        Me.clTenCot.MinimumWidth = 6
        Me.clTenCot.Name = "clTenCot"
        Me.clTenCot.ReadOnly = True
        '
        'cll
        '
        Me.cll.HeaderText = "L (mm)"
        Me.cll.MinimumWidth = 6
        Me.cll.Name = "cll"
        Me.cll.ReadOnly = True
        '
        'clb
        '
        Me.clb.HeaderText = "b (mm)"
        Me.clb.MinimumWidth = 6
        Me.clb.Name = "clb"
        Me.clb.ReadOnly = True
        '
        'clh
        '
        Me.clh.HeaderText = "h (mm)"
        Me.clh.MinimumWidth = 6
        Me.clh.Name = "clh"
        Me.clh.ReadOnly = True
        '
        'clN
        '
        Me.clN.HeaderText = "N (N)"
        Me.clN.MinimumWidth = 6
        Me.clN.Name = "clN"
        Me.clN.ReadOnly = True
        '
        'clMx
        '
        Me.clMx.HeaderText = "Mx (N.mm)"
        Me.clMx.MinimumWidth = 6
        Me.clMx.Name = "clMx"
        Me.clMx.ReadOnly = True
        '
        'clMy
        '
        Me.clMy.HeaderText = "My (N.mm)"
        Me.clMy.MinimumWidth = 6
        Me.clMy.Name = "clMy"
        Me.clMy.ReadOnly = True
        '
        'FormTietDien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 463)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTietDien"
        Me.Text = "FormTietDien"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvdulieucot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnXoaCot As Button
    Friend WithEvents btnThemCot As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvdulieucot As DataGridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents clTenCot As DataGridViewTextBoxColumn
    Friend WithEvents cll As DataGridViewTextBoxColumn
    Friend WithEvents clb As DataGridViewTextBoxColumn
    Friend WithEvents clh As DataGridViewTextBoxColumn
    Friend WithEvents clN As DataGridViewTextBoxColumn
    Friend WithEvents clMx As DataGridViewTextBoxColumn
    Friend WithEvents clMy As DataGridViewTextBoxColumn
End Class
