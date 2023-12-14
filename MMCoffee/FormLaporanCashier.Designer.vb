<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanCashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanCashier))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvLapSat = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReportCashier = New System.Windows.Forms.Button()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCariTgl = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTotalPenjualan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.pnlLeftSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvLapSat)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 194)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(924, 341)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan Satuan"
        '
        'lvLapSat
        '
        Me.lvLapSat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvLapSat.HideSelection = False
        Me.lvLapSat.Location = New System.Drawing.Point(22, 43)
        Me.lvLapSat.Margin = New System.Windows.Forms.Padding(2)
        Me.lvLapSat.Name = "lvLapSat"
        Me.lvLapSat.Size = New System.Drawing.Size(898, 276)
        Me.lvLapSat.TabIndex = 28
        Me.lvLapSat.UseCompatibleStateImageBehavior = False
        Me.lvLapSat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No. Transaksi"
        Me.ColumnHeader1.Width = 213
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Transaksi"
        Me.ColumnHeader2.Width = 155
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah"
        Me.ColumnHeader3.Width = 128
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total Transaksi"
        Me.ColumnHeader4.Width = 340
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(455, 123)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(368, 25)
        Me.DateTimePicker1.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(675, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 29)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "LAPORAN  PENJUALAN"
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.pnlLeftSide.Controls.Add(Me.TextBox2)
        Me.pnlLeftSide.Controls.Add(Me.Panel1)
        Me.pnlLeftSide.Controls.Add(Me.TextBox1)
        Me.pnlLeftSide.Controls.Add(Me.Label1)
        Me.pnlLeftSide.Controls.Add(Me.btnLogout)
        Me.pnlLeftSide.Controls.Add(Me.btnReportCashier)
        Me.pnlLeftSide.Controls.Add(Me.btnTransaksi)
        Me.pnlLeftSide.Controls.Add(Me.btnDashboard)
        Me.pnlLeftSide.Controls.Add(Me.btnBack)
        Me.pnlLeftSide.ForeColor = System.Drawing.Color.White
        Me.pnlLeftSide.Location = New System.Drawing.Point(2, 0)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(303, 1006)
        Me.pnlLeftSide.TabIndex = 55
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(79, 86)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(159, 25)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = "NIP. 21082010116"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(2, 133)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 1)
        Me.Panel1.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(79, 51)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(159, 25)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "Lina Wardani"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Cashier "
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(5, 362)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(218, 68)
        Me.btnLogout.TabIndex = 18
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnReportCashier
        '
        Me.btnReportCashier.BackColor = System.Drawing.Color.Transparent
        Me.btnReportCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportCashier.FlatAppearance.BorderSize = 0
        Me.btnReportCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportCashier.Image = CType(resources.GetObject("btnReportCashier.Image"), System.Drawing.Image)
        Me.btnReportCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportCashier.Location = New System.Drawing.Point(5, 288)
        Me.btnReportCashier.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReportCashier.Name = "btnReportCashier"
        Me.btnReportCashier.Size = New System.Drawing.Size(218, 68)
        Me.btnReportCashier.TabIndex = 15
        Me.btnReportCashier.Text = "Laporan"
        Me.btnReportCashier.UseVisualStyleBackColor = False
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.btnTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.ForeColor = System.Drawing.Color.White
        Me.btnTransaksi.Image = CType(resources.GetObject("btnTransaksi.Image"), System.Drawing.Image)
        Me.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.Location = New System.Drawing.Point(5, 213)
        Me.btnTransaksi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(218, 68)
        Me.btnTransaksi.TabIndex = 14
        Me.btnTransaksi.Text = "Transaksi"
        Me.btnTransaksi.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(5, 139)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(218, 68)
        Me.btnDashboard.TabIndex = 13
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(5, 45)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(57, 68)
        Me.btnBack.TabIndex = 12
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Cari Tanggal"
        '
        'btnCariTgl
        '
        Me.btnCariTgl.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnCariTgl.ForeColor = System.Drawing.Color.White
        Me.btnCariTgl.Location = New System.Drawing.Point(853, 123)
        Me.btnCariTgl.Name = "btnCariTgl"
        Me.btnCariTgl.Size = New System.Drawing.Size(85, 28)
        Me.btnCariTgl.TabIndex = 57
        Me.btnCariTgl.Text = "Cari"
        Me.btnCariTgl.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(956, 123)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(85, 28)
        Me.btnBatal.TabIndex = 58
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(369, 557)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 26)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Total Pendapatan :"
        '
        'tbTotalPenjualan
        '
        Me.tbTotalPenjualan.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.tbTotalPenjualan.Location = New System.Drawing.Point(411, 605)
        Me.tbTotalPenjualan.Name = "tbTotalPenjualan"
        Me.tbTotalPenjualan.ReadOnly = True
        Me.tbTotalPenjualan.Size = New System.Drawing.Size(169, 31)
        Me.tbTotalPenjualan.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(369, 608)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 26)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Rp. "
        '
        'FormLaporanCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbTotalPenjualan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnCariTgl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormLaporanCashier"
        Me.Text = "FormLaporanCashier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlLeftSide.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lvLapSat As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReportCashier As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCariTgl As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTotalPenjualan As TextBox
    Friend WithEvents Label5 As Label
End Class
