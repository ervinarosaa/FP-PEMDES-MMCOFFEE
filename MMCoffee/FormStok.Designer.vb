<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStok
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnUpdtProduk = New System.Windows.Forms.Button()
        Me.btnUpdtStok = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBrgMasuk = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.btnBrgKeluar = New System.Windows.Forms.Button()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSimpan_bm = New System.Windows.Forms.Button()
        Me.btnBatal_bm = New System.Windows.Forms.Button()
        Me.UpDown_bm = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nmProduk_bm = New System.Windows.Forms.TextBox()
        Me.cb_idProduk_bm = New System.Windows.Forms.ComboBox()
        Me.BRGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New MMCoffee.DataSet1()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlBrgMasuk = New System.Windows.Forms.Panel()
        Me.DateTimePicker_bm = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lv_barangmasuk = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlBrgKeluar = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cb_keterangan_bk = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker_bk = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSimpan_bk = New System.Windows.Forms.Button()
        Me.btnBatal_bk = New System.Windows.Forms.Button()
        Me.UpDown_bk = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_nmProduk_bk = New System.Windows.Forms.TextBox()
        Me.cb_idProduk_bk = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lv_barangKeluar = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BRGTableAdapter = New MMCoffee.DataSet1TableAdapters.BRGTableAdapter()
        Me.pnlLeftSide.SuspendLayout()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.UpDown_bm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BRGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBrgMasuk.SuspendLayout()
        Me.pnlBrgKeluar.SuspendLayout()
        CType(Me.UpDown_bk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, -1)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(279, 1013)
        Me.pnlLeftSide.TabIndex = 18
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = Global.MMCoffee.My.Resources.Resources.log_out__3_
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
        Me.btnHome.Image = Global.MMCoffee.My.Resources.Resources.home_icon_silhouette
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
        Me.btnReport.Image = Global.MMCoffee.My.Resources.Resources.business_report__3_
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
        Me.btnUpdtProduk.Image = Global.MMCoffee.My.Resources.Resources.coffee_bean
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
        Me.btnBack.Image = Global.MMCoffee.My.Resources.Resources.left_arrow_in_circular_button_black_symbol__3_
        Me.btnBack.Location = New System.Drawing.Point(5, 8)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(53, 47)
        Me.btnBack.TabIndex = 12
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnBrgMasuk
        '
        Me.btnBrgMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnBrgMasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrgMasuk.FlatAppearance.BorderSize = 0
        Me.btnBrgMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrgMasuk.ForeColor = System.Drawing.Color.White
        Me.btnBrgMasuk.Location = New System.Drawing.Point(5, 2)
        Me.btnBrgMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrgMasuk.Name = "btnBrgMasuk"
        Me.btnBrgMasuk.Size = New System.Drawing.Size(181, 38)
        Me.btnBrgMasuk.TabIndex = 17
        Me.btnBrgMasuk.Text = "Barang Masuk"
        Me.btnBrgMasuk.UseVisualStyleBackColor = False
        '
        'pnlTopSide
        '
        Me.pnlTopSide.Controls.Add(Me.btnBrgKeluar)
        Me.pnlTopSide.Controls.Add(Me.btnBrgMasuk)
        Me.pnlTopSide.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTopSide.Location = New System.Drawing.Point(283, 5)
        Me.pnlTopSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(972, 42)
        Me.pnlTopSide.TabIndex = 19
        '
        'btnBrgKeluar
        '
        Me.btnBrgKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnBrgKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrgKeluar.FlatAppearance.BorderSize = 0
        Me.btnBrgKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrgKeluar.ForeColor = System.Drawing.Color.White
        Me.btnBrgKeluar.Location = New System.Drawing.Point(189, 3)
        Me.btnBrgKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrgKeluar.Name = "btnBrgKeluar"
        Me.btnBrgKeluar.Size = New System.Drawing.Size(181, 38)
        Me.btnBrgKeluar.TabIndex = 18
        Me.btnBrgKeluar.Text = "Barang Keluar"
        Me.btnBrgKeluar.UseVisualStyleBackColor = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Jumlah Barang Masuk"
        Me.ColumnHeader5.Width = 140
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nama Produk"
        Me.ColumnHeader4.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID Produk"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tanggal"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        Me.ColumnHeader1.Width = 30
        '
        'btnSimpan_bm
        '
        Me.btnSimpan_bm.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSimpan_bm.ForeColor = System.Drawing.Color.White
        Me.btnSimpan_bm.Location = New System.Drawing.Point(682, 194)
        Me.btnSimpan_bm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan_bm.Name = "btnSimpan_bm"
        Me.btnSimpan_bm.Size = New System.Drawing.Size(100, 38)
        Me.btnSimpan_bm.TabIndex = 17
        Me.btnSimpan_bm.Text = "Simpan"
        Me.btnSimpan_bm.UseVisualStyleBackColor = False
        '
        'btnBatal_bm
        '
        Me.btnBatal_bm.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnBatal_bm.ForeColor = System.Drawing.Color.White
        Me.btnBatal_bm.Location = New System.Drawing.Point(558, 194)
        Me.btnBatal_bm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal_bm.Name = "btnBatal_bm"
        Me.btnBatal_bm.Size = New System.Drawing.Size(100, 38)
        Me.btnBatal_bm.TabIndex = 16
        Me.btnBatal_bm.Text = "Batal"
        Me.btnBatal_bm.UseVisualStyleBackColor = False
        '
        'UpDown_bm
        '
        Me.UpDown_bm.Location = New System.Drawing.Point(669, 111)
        Me.UpDown_bm.Margin = New System.Windows.Forms.Padding(2)
        Me.UpDown_bm.Name = "UpDown_bm"
        Me.UpDown_bm.Size = New System.Drawing.Size(163, 25)
        Me.UpDown_bm.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(475, 115)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Jumlah Barang Masuk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tanggal"
        '
        'tb_nmProduk_bm
        '
        Me.tb_nmProduk_bm.Location = New System.Drawing.Point(203, 198)
        Me.tb_nmProduk_bm.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nmProduk_bm.Name = "tb_nmProduk_bm"
        Me.tb_nmProduk_bm.Size = New System.Drawing.Size(253, 25)
        Me.tb_nmProduk_bm.TabIndex = 9
        '
        'cb_idProduk_bm
        '
        Me.cb_idProduk_bm.DataSource = Me.BRGBindingSource
        Me.cb_idProduk_bm.DisplayMember = "ID_PRODUK"
        Me.cb_idProduk_bm.FormattingEnabled = True
        Me.cb_idProduk_bm.Location = New System.Drawing.Point(203, 154)
        Me.cb_idProduk_bm.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_idProduk_bm.Name = "cb_idProduk_bm"
        Me.cb_idProduk_bm.Size = New System.Drawing.Size(253, 28)
        Me.cb_idProduk_bm.TabIndex = 7
        '
        'BRGBindingSource
        '
        Me.BRGBindingSource.DataMember = "BRG"
        Me.BRGBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Produk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Produk"
        '
        'pnlBrgMasuk
        '
        Me.pnlBrgMasuk.Controls.Add(Me.DateTimePicker_bm)
        Me.pnlBrgMasuk.Controls.Add(Me.Label8)
        Me.pnlBrgMasuk.Controls.Add(Me.btnSimpan_bm)
        Me.pnlBrgMasuk.Controls.Add(Me.btnBatal_bm)
        Me.pnlBrgMasuk.Controls.Add(Me.UpDown_bm)
        Me.pnlBrgMasuk.Controls.Add(Me.Label10)
        Me.pnlBrgMasuk.Controls.Add(Me.Label1)
        Me.pnlBrgMasuk.Controls.Add(Me.tb_nmProduk_bm)
        Me.pnlBrgMasuk.Controls.Add(Me.cb_idProduk_bm)
        Me.pnlBrgMasuk.Controls.Add(Me.Label3)
        Me.pnlBrgMasuk.Controls.Add(Me.Label2)
        Me.pnlBrgMasuk.Controls.Add(Me.lv_barangmasuk)
        Me.pnlBrgMasuk.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBrgMasuk.Location = New System.Drawing.Point(302, 51)
        Me.pnlBrgMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBrgMasuk.Name = "pnlBrgMasuk"
        Me.pnlBrgMasuk.Size = New System.Drawing.Size(933, 589)
        Me.pnlBrgMasuk.TabIndex = 20
        '
        'DateTimePicker_bm
        '
        Me.DateTimePicker_bm.Location = New System.Drawing.Point(203, 109)
        Me.DateTimePicker_bm.Name = "DateTimePicker_bm"
        Me.DateTimePicker_bm.Size = New System.Drawing.Size(253, 25)
        Me.DateTimePicker_bm.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(326, 42)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(284, 29)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "UPDATE BARANG MASUK"
        '
        'lv_barangmasuk
        '
        Me.lv_barangmasuk.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader11})
        Me.lv_barangmasuk.HideSelection = False
        Me.lv_barangmasuk.Location = New System.Drawing.Point(83, 243)
        Me.lv_barangmasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.lv_barangmasuk.Name = "lv_barangmasuk"
        Me.lv_barangmasuk.Size = New System.Drawing.Size(735, 314)
        Me.lv_barangmasuk.TabIndex = 1
        Me.lv_barangmasuk.UseCompatibleStateImageBehavior = False
        Me.lv_barangmasuk.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Keterangan"
        Me.ColumnHeader11.Width = 80
        '
        'pnlBrgKeluar
        '
        Me.pnlBrgKeluar.Controls.Add(Me.Label11)
        Me.pnlBrgKeluar.Controls.Add(Me.cb_keterangan_bk)
        Me.pnlBrgKeluar.Controls.Add(Me.DateTimePicker_bk)
        Me.pnlBrgKeluar.Controls.Add(Me.Label4)
        Me.pnlBrgKeluar.Controls.Add(Me.btnSimpan_bk)
        Me.pnlBrgKeluar.Controls.Add(Me.btnBatal_bk)
        Me.pnlBrgKeluar.Controls.Add(Me.UpDown_bk)
        Me.pnlBrgKeluar.Controls.Add(Me.Label5)
        Me.pnlBrgKeluar.Controls.Add(Me.Label6)
        Me.pnlBrgKeluar.Controls.Add(Me.tb_nmProduk_bk)
        Me.pnlBrgKeluar.Controls.Add(Me.cb_idProduk_bk)
        Me.pnlBrgKeluar.Controls.Add(Me.Label7)
        Me.pnlBrgKeluar.Controls.Add(Me.Label9)
        Me.pnlBrgKeluar.Controls.Add(Me.lv_barangKeluar)
        Me.pnlBrgKeluar.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBrgKeluar.Location = New System.Drawing.Point(301, 52)
        Me.pnlBrgKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBrgKeluar.Name = "pnlBrgKeluar"
        Me.pnlBrgKeluar.Size = New System.Drawing.Size(933, 589)
        Me.pnlBrgKeluar.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(476, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 20)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Keterangan"
        '
        'cb_keterangan_bk
        '
        Me.cb_keterangan_bk.FormattingEnabled = True
        Me.cb_keterangan_bk.Items.AddRange(New Object() {"Kadaluwarsa", "Return", "Lainnya"})
        Me.cb_keterangan_bk.Location = New System.Drawing.Point(670, 154)
        Me.cb_keterangan_bk.Name = "cb_keterangan_bk"
        Me.cb_keterangan_bk.Size = New System.Drawing.Size(162, 28)
        Me.cb_keterangan_bk.TabIndex = 30
        '
        'DateTimePicker_bk
        '
        Me.DateTimePicker_bk.Location = New System.Drawing.Point(203, 112)
        Me.DateTimePicker_bk.Name = "DateTimePicker_bk"
        Me.DateTimePicker_bk.Size = New System.Drawing.Size(254, 25)
        Me.DateTimePicker_bk.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(326, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(295, 29)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "UPDATE BARANG KELUAR"
        '
        'btnSimpan_bk
        '
        Me.btnSimpan_bk.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSimpan_bk.ForeColor = System.Drawing.Color.White
        Me.btnSimpan_bk.Location = New System.Drawing.Point(683, 201)
        Me.btnSimpan_bk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan_bk.Name = "btnSimpan_bk"
        Me.btnSimpan_bk.Size = New System.Drawing.Size(100, 37)
        Me.btnSimpan_bk.TabIndex = 17
        Me.btnSimpan_bk.Text = "Simpan"
        Me.btnSimpan_bk.UseVisualStyleBackColor = False
        '
        'btnBatal_bk
        '
        Me.btnBatal_bk.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBatal_bk.ForeColor = System.Drawing.Color.White
        Me.btnBatal_bk.Location = New System.Drawing.Point(559, 201)
        Me.btnBatal_bk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal_bk.Name = "btnBatal_bk"
        Me.btnBatal_bk.Size = New System.Drawing.Size(100, 37)
        Me.btnBatal_bk.TabIndex = 16
        Me.btnBatal_bk.Text = "Batal"
        Me.btnBatal_bk.UseVisualStyleBackColor = False
        '
        'UpDown_bk
        '
        Me.UpDown_bk.Location = New System.Drawing.Point(669, 111)
        Me.UpDown_bk.Margin = New System.Windows.Forms.Padding(2)
        Me.UpDown_bk.Name = "UpDown_bk"
        Me.UpDown_bk.Size = New System.Drawing.Size(163, 25)
        Me.UpDown_bk.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(475, 115)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Jumlah Barang Keluar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 116)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tanggal"
        '
        'tb_nmProduk_bk
        '
        Me.tb_nmProduk_bk.Location = New System.Drawing.Point(203, 198)
        Me.tb_nmProduk_bk.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nmProduk_bk.Name = "tb_nmProduk_bk"
        Me.tb_nmProduk_bk.Size = New System.Drawing.Size(254, 25)
        Me.tb_nmProduk_bk.TabIndex = 9
        '
        'cb_idProduk_bk
        '
        Me.cb_idProduk_bk.DataSource = Me.BRGBindingSource
        Me.cb_idProduk_bk.DisplayMember = "ID_PRODUK"
        Me.cb_idProduk_bk.FormattingEnabled = True
        Me.cb_idProduk_bk.Location = New System.Drawing.Point(203, 154)
        Me.cb_idProduk_bk.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_idProduk_bk.Name = "cb_idProduk_bk"
        Me.cb_idProduk_bk.Size = New System.Drawing.Size(254, 28)
        Me.cb_idProduk_bk.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 202)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nama Produk"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(80, 159)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ID Produk"
        '
        'lv_barangKeluar
        '
        Me.lv_barangKeluar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader12})
        Me.lv_barangKeluar.HideSelection = False
        Me.lv_barangKeluar.Location = New System.Drawing.Point(83, 243)
        Me.lv_barangKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.lv_barangKeluar.Name = "lv_barangKeluar"
        Me.lv_barangKeluar.Size = New System.Drawing.Size(735, 325)
        Me.lv_barangKeluar.TabIndex = 1
        Me.lv_barangKeluar.UseCompatibleStateImageBehavior = False
        Me.lv_barangKeluar.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "No"
        Me.ColumnHeader6.Width = 30
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tanggal"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID Produk"
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Nama Produk"
        Me.ColumnHeader9.Width = 130
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Jumlah Barang Keluar"
        Me.ColumnHeader10.Width = 140
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Keterangan"
        Me.ColumnHeader12.Width = 80
        '
        'BRGTableAdapter
        '
        Me.BRGTableAdapter.ClearBeforeFill = True
        '
        'FormStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlBrgMasuk)
        Me.Controls.Add(Me.pnlBrgKeluar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormStok"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlTopSide.ResumeLayout(False)
        CType(Me.UpDown_bm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BRGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBrgMasuk.ResumeLayout(False)
        Me.pnlBrgMasuk.PerformLayout()
        Me.pnlBrgKeluar.ResumeLayout(False)
        Me.pnlBrgKeluar.PerformLayout()
        CType(Me.UpDown_bk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnUpdtProduk As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents btnUpdtStok As Button
    Friend WithEvents btnBrgMasuk As Button
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents btnBrgKeluar As Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnSimpan_bm As Button
    Friend WithEvents btnBatal_bm As Button
    Friend WithEvents UpDown_bm As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_nmProduk_bm As TextBox
    Friend WithEvents cb_idProduk_bm As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlBrgMasuk As Panel
    Friend WithEvents lv_barangmasuk As ListView
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlBrgKeluar As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSimpan_bk As Button
    Friend WithEvents btnBatal_bk As Button
    Friend WithEvents UpDown_bk As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_nmProduk_bk As TextBox
    Friend WithEvents cb_idProduk_bk As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lv_barangKeluar As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btnLogout As Button
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents BRGBindingSource As BindingSource
    Friend WithEvents BRGTableAdapter As DataSet1TableAdapters.BRGTableAdapter
    Friend WithEvents DateTimePicker_bm As DateTimePicker
    Friend WithEvents DateTimePicker_bk As DateTimePicker
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents Label11 As Label
    Friend WithEvents cb_keterangan_bk As ComboBox
End Class
