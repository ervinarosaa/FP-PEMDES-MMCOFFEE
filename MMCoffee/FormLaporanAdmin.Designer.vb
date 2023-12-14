<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanAdmin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lv_laporanRobusta = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lv_laporanJahe = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnUpdtProduk = New System.Windows.Forms.Button()
        Me.btnUpdtStok = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tsRobusta = New System.Windows.Forms.TextBox()
        Me.jkRobusta = New System.Windows.Forms.TextBox()
        Me.jmRobusta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tsJahe = New System.Windows.Forms.TextBox()
        Me.jkJahe = New System.Windows.Forms.TextBox()
        Me.jmJahe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlLeftSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lv_laporanRobusta)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(353, 66)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(820, 261)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kopi Robusta"
        '
        'lv_laporanRobusta
        '
        Me.lv_laporanRobusta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lv_laporanRobusta.HideSelection = False
        Me.lv_laporanRobusta.Location = New System.Drawing.Point(13, 31)
        Me.lv_laporanRobusta.Margin = New System.Windows.Forms.Padding(2)
        Me.lv_laporanRobusta.Name = "lv_laporanRobusta"
        Me.lv_laporanRobusta.Size = New System.Drawing.Size(782, 220)
        Me.lv_laporanRobusta.TabIndex = 0
        Me.lv_laporanRobusta.UseCompatibleStateImageBehavior = False
        Me.lv_laporanRobusta.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tanggal"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah Masuk"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Jumlah Keluar"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Keterangan"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 80
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lv_laporanJahe)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(353, 398)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(820, 268)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kopi Jahe"
        '
        'lv_laporanJahe
        '
        Me.lv_laporanJahe.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lv_laporanJahe.HideSelection = False
        Me.lv_laporanJahe.Location = New System.Drawing.Point(15, 34)
        Me.lv_laporanJahe.Margin = New System.Windows.Forms.Padding(2)
        Me.lv_laporanJahe.Name = "lv_laporanJahe"
        Me.lv_laporanJahe.Size = New System.Drawing.Size(782, 230)
        Me.lv_laporanJahe.TabIndex = 1
        Me.lv_laporanJahe.UseCompatibleStateImageBehavior = False
        Me.lv_laporanJahe.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No"
        Me.ColumnHeader4.Width = 30
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tanggal"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Jumlah Masuk"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Jumlah Keluar"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 80
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Keterangan"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "LAPORAN STOK MM COFFEE"
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.pnlLeftSide.Controls.Add(Me.btnLogout)
        Me.pnlLeftSide.Controls.Add(Me.btnHome)
        Me.pnlLeftSide.Controls.Add(Me.btnReport)
        Me.pnlLeftSide.Controls.Add(Me.btnUpdtProduk)
        Me.pnlLeftSide.Controls.Add(Me.btnUpdtStok)
        Me.pnlLeftSide.Controls.Add(Me.btnBack)
        Me.pnlLeftSide.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlLeftSide.ForeColor = System.Drawing.Color.White
        Me.pnlLeftSide.Location = New System.Drawing.Point(-1, -1)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(280, 1011)
        Me.pnlLeftSide.TabIndex = 19
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(18, 271)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(201, 47)
        Me.btnLogout.TabIndex = 19
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(18, 220)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(201, 47)
        Me.btnHome.TabIndex = 18
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Transparent
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(18, 168)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(201, 47)
        Me.btnReport.TabIndex = 15
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnUpdtProduk
        '
        Me.btnUpdtProduk.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdtProduk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdtProduk.FlatAppearance.BorderSize = 0
        Me.btnUpdtProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdtProduk.Image = CType(resources.GetObject("btnUpdtProduk.Image"), System.Drawing.Image)
        Me.btnUpdtProduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdtProduk.Location = New System.Drawing.Point(18, 117)
        Me.btnUpdtProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdtProduk.Name = "btnUpdtProduk"
        Me.btnUpdtProduk.Size = New System.Drawing.Size(201, 47)
        Me.btnUpdtProduk.TabIndex = 14
        Me.btnUpdtProduk.Text = "Update Product"
        Me.btnUpdtProduk.UseVisualStyleBackColor = False
        '
        'btnUpdtStok
        '
        Me.btnUpdtStok.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdtStok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdtStok.FlatAppearance.BorderSize = 0
        Me.btnUpdtStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdtStok.Image = Global.MMCoffee.My.Resources.Resources.inventory_24
        Me.btnUpdtStok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdtStok.Location = New System.Drawing.Point(18, 66)
        Me.btnUpdtStok.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdtStok.Name = "btnUpdtStok"
        Me.btnUpdtStok.Size = New System.Drawing.Size(201, 47)
        Me.btnUpdtStok.TabIndex = 13
        Me.btnUpdtStok.Text = "Update Stock"
        Me.btnUpdtStok.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(5, 8)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(53, 47)
        Me.btnBack.TabIndex = 12
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'tsRobusta
        '
        Me.tsRobusta.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.tsRobusta.Location = New System.Drawing.Point(1048, 335)
        Me.tsRobusta.Name = "tsRobusta"
        Me.tsRobusta.ReadOnly = True
        Me.tsRobusta.Size = New System.Drawing.Size(100, 25)
        Me.tsRobusta.TabIndex = 35
        '
        'jkRobusta
        '
        Me.jkRobusta.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.jkRobusta.Location = New System.Drawing.Point(765, 332)
        Me.jkRobusta.Name = "jkRobusta"
        Me.jkRobusta.ReadOnly = True
        Me.jkRobusta.Size = New System.Drawing.Size(100, 25)
        Me.jkRobusta.TabIndex = 34
        '
        'jmRobusta
        '
        Me.jmRobusta.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.jmRobusta.Location = New System.Drawing.Point(488, 332)
        Me.jmRobusta.Name = "jmRobusta"
        Me.jmRobusta.ReadOnly = True
        Me.jmRobusta.Size = New System.Drawing.Size(100, 25)
        Me.jmRobusta.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(643, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Jumlah Keluar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(369, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Jumlah Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(970, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Total Stok"
        '
        'tsJahe
        '
        Me.tsJahe.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.tsJahe.Location = New System.Drawing.Point(1048, 671)
        Me.tsJahe.Name = "tsJahe"
        Me.tsJahe.ReadOnly = True
        Me.tsJahe.Size = New System.Drawing.Size(100, 25)
        Me.tsJahe.TabIndex = 41
        '
        'jkJahe
        '
        Me.jkJahe.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.jkJahe.Location = New System.Drawing.Point(765, 671)
        Me.jkJahe.Name = "jkJahe"
        Me.jkJahe.ReadOnly = True
        Me.jkJahe.Size = New System.Drawing.Size(100, 25)
        Me.jkJahe.TabIndex = 40
        '
        'jmJahe
        '
        Me.jmJahe.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.jmJahe.Location = New System.Drawing.Point(488, 671)
        Me.jmJahe.Name = "jmJahe"
        Me.jmJahe.ReadOnly = True
        Me.jmJahe.Size = New System.Drawing.Size(100, 25)
        Me.jmJahe.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(641, 674)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Jumlah Keluar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(369, 674)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Jumlah Masuk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(970, 674)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Total Stok"
        '
        'FormLaporanAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.tsJahe)
        Me.Controls.Add(Me.jkJahe)
        Me.Controls.Add(Me.jmJahe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tsRobusta)
        Me.Controls.Add(Me.jkRobusta)
        Me.Controls.Add(Me.jmRobusta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormLaporanAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.pnlLeftSide.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lv_laporanRobusta As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lv_laporanJahe As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnUpdtProduk As Button
    Friend WithEvents btnUpdtStok As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents tsRobusta As TextBox
    Friend WithEvents jkRobusta As TextBox
    Friend WithEvents jmRobusta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tsJahe As TextBox
    Friend WithEvents jkJahe As TextBox
    Friend WithEvents jmJahe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
End Class
