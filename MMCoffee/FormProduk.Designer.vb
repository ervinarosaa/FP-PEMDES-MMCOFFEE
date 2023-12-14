<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduk
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
        Me.btnHpsProduk = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.btnTbhProduk = New System.Windows.Forms.Button()
        Me.pnlHpsProduk = New System.Windows.Forms.Panel()
        Me.cb_idProduk_hp = New System.Windows.Forms.ComboBox()
        Me.BRGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New MMCoffee.DataSet2()
        Me.DateTimePicker_hp = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_harga_hp = New System.Windows.Forms.TextBox()
        Me.tb_stok_hp = New System.Windows.Forms.TextBox()
        Me.tb_nmProduk_hp = New System.Windows.Forms.TextBox()
        Me.btnLihat_hp = New System.Windows.Forms.Button()
        Me.btnSimpan_hp = New System.Windows.Forms.Button()
        Me.btnBatal_hp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlTbhProduk = New System.Windows.Forms.Panel()
        Me.DateTimePicker_tp = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_harga_tp = New System.Windows.Forms.TextBox()
        Me.tb_stok_tp = New System.Windows.Forms.TextBox()
        Me.tb_nmProduk_tp = New System.Windows.Forms.TextBox()
        Me.tb_idProduk_tp = New System.Windows.Forms.TextBox()
        Me.btnLihat_tp = New System.Windows.Forms.Button()
        Me.btnSimpan_tp = New System.Windows.Forms.Button()
        Me.btnBatal_tp = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnUpdtProduk = New System.Windows.Forms.Button()
        Me.btnUpdtStok = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.BRGTableAdapter = New MMCoffee.DataSet2TableAdapters.BRGTableAdapter()
        Me.pnlTopSide.SuspendLayout()
        Me.pnlHpsProduk.SuspendLayout()
        CType(Me.BRGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTbhProduk.SuspendLayout()
        Me.pnlLeftSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHpsProduk
        '
        Me.btnHpsProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnHpsProduk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHpsProduk.FlatAppearance.BorderSize = 0
        Me.btnHpsProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHpsProduk.ForeColor = System.Drawing.Color.White
        Me.btnHpsProduk.Location = New System.Drawing.Point(283, 2)
        Me.btnHpsProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHpsProduk.Name = "btnHpsProduk"
        Me.btnHpsProduk.Size = New System.Drawing.Size(262, 55)
        Me.btnHpsProduk.TabIndex = 18
        Me.btnHpsProduk.Text = "Hapus Produk"
        Me.btnHpsProduk.UseVisualStyleBackColor = False
        '
        'pnlTopSide
        '
        Me.pnlTopSide.Controls.Add(Me.btnHpsProduk)
        Me.pnlTopSide.Controls.Add(Me.btnTbhProduk)
        Me.pnlTopSide.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTopSide.ForeColor = System.Drawing.Color.White
        Me.pnlTopSide.Location = New System.Drawing.Point(283, 3)
        Me.pnlTopSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(972, 59)
        Me.pnlTopSide.TabIndex = 35
        '
        'btnTbhProduk
        '
        Me.btnTbhProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnTbhProduk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTbhProduk.FlatAppearance.BorderSize = 0
        Me.btnTbhProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTbhProduk.Location = New System.Drawing.Point(2, 2)
        Me.btnTbhProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTbhProduk.Name = "btnTbhProduk"
        Me.btnTbhProduk.Size = New System.Drawing.Size(277, 55)
        Me.btnTbhProduk.TabIndex = 17
        Me.btnTbhProduk.Text = "Tambah Produk"
        Me.btnTbhProduk.UseVisualStyleBackColor = False
        '
        'pnlHpsProduk
        '
        Me.pnlHpsProduk.Controls.Add(Me.cb_idProduk_hp)
        Me.pnlHpsProduk.Controls.Add(Me.DateTimePicker_hp)
        Me.pnlHpsProduk.Controls.Add(Me.Label1)
        Me.pnlHpsProduk.Controls.Add(Me.tb_harga_hp)
        Me.pnlHpsProduk.Controls.Add(Me.tb_stok_hp)
        Me.pnlHpsProduk.Controls.Add(Me.tb_nmProduk_hp)
        Me.pnlHpsProduk.Controls.Add(Me.btnLihat_hp)
        Me.pnlHpsProduk.Controls.Add(Me.btnSimpan_hp)
        Me.pnlHpsProduk.Controls.Add(Me.btnBatal_hp)
        Me.pnlHpsProduk.Controls.Add(Me.Label2)
        Me.pnlHpsProduk.Controls.Add(Me.Label3)
        Me.pnlHpsProduk.Controls.Add(Me.Label4)
        Me.pnlHpsProduk.Controls.Add(Me.Label5)
        Me.pnlHpsProduk.Controls.Add(Me.Label6)
        Me.pnlHpsProduk.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlHpsProduk.Location = New System.Drawing.Point(296, 90)
        Me.pnlHpsProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHpsProduk.Name = "pnlHpsProduk"
        Me.pnlHpsProduk.Size = New System.Drawing.Size(1149, 638)
        Me.pnlHpsProduk.TabIndex = 34
        '
        'cb_idProduk_hp
        '
        Me.cb_idProduk_hp.DataSource = Me.BRGBindingSource
        Me.cb_idProduk_hp.DisplayMember = "ID_PRODUK"
        Me.cb_idProduk_hp.FormattingEnabled = True
        Me.cb_idProduk_hp.Location = New System.Drawing.Point(537, 240)
        Me.cb_idProduk_hp.Name = "cb_idProduk_hp"
        Me.cb_idProduk_hp.Size = New System.Drawing.Size(278, 28)
        Me.cb_idProduk_hp.TabIndex = 29
        '
        'BRGBindingSource
        '
        Me.BRGBindingSource.DataMember = "BRG"
        Me.BRGBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePicker_hp
        '
        Me.DateTimePicker_hp.Location = New System.Drawing.Point(536, 192)
        Me.DateTimePicker_hp.Name = "DateTimePicker_hp"
        Me.DateTimePicker_hp.Size = New System.Drawing.Size(279, 25)
        Me.DateTimePicker_hp.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(523, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "HAPUS PRODUK"
        '
        'tb_harga_hp
        '
        Me.tb_harga_hp.Location = New System.Drawing.Point(536, 390)
        Me.tb_harga_hp.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_harga_hp.Name = "tb_harga_hp"
        Me.tb_harga_hp.Size = New System.Drawing.Size(279, 25)
        Me.tb_harga_hp.TabIndex = 26
        '
        'tb_stok_hp
        '
        Me.tb_stok_hp.Location = New System.Drawing.Point(536, 343)
        Me.tb_stok_hp.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_stok_hp.Name = "tb_stok_hp"
        Me.tb_stok_hp.Size = New System.Drawing.Size(279, 25)
        Me.tb_stok_hp.TabIndex = 25
        '
        'tb_nmProduk_hp
        '
        Me.tb_nmProduk_hp.Location = New System.Drawing.Point(536, 293)
        Me.tb_nmProduk_hp.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nmProduk_hp.Name = "tb_nmProduk_hp"
        Me.tb_nmProduk_hp.Size = New System.Drawing.Size(279, 25)
        Me.tb_nmProduk_hp.TabIndex = 24
        '
        'btnLihat_hp
        '
        Me.btnLihat_hp.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnLihat_hp.ForeColor = System.Drawing.Color.White
        Me.btnLihat_hp.Location = New System.Drawing.Point(673, 455)
        Me.btnLihat_hp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLihat_hp.Name = "btnLihat_hp"
        Me.btnLihat_hp.Size = New System.Drawing.Size(121, 40)
        Me.btnLihat_hp.TabIndex = 21
        Me.btnLihat_hp.Text = "Lihat"
        Me.btnLihat_hp.UseVisualStyleBackColor = False
        '
        'btnSimpan_hp
        '
        Me.btnSimpan_hp.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSimpan_hp.ForeColor = System.Drawing.Color.White
        Me.btnSimpan_hp.Location = New System.Drawing.Point(536, 455)
        Me.btnSimpan_hp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan_hp.Name = "btnSimpan_hp"
        Me.btnSimpan_hp.Size = New System.Drawing.Size(121, 40)
        Me.btnSimpan_hp.TabIndex = 20
        Me.btnSimpan_hp.Text = "Simpan"
        Me.btnSimpan_hp.UseVisualStyleBackColor = False
        '
        'btnBatal_hp
        '
        Me.btnBatal_hp.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnBatal_hp.ForeColor = System.Drawing.Color.White
        Me.btnBatal_hp.Location = New System.Drawing.Point(396, 455)
        Me.btnBatal_hp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal_hp.Name = "btnBatal_hp"
        Me.btnBatal_hp.Size = New System.Drawing.Size(121, 40)
        Me.btnBatal_hp.TabIndex = 19
        Me.btnBatal_hp.Text = "Batal"
        Me.btnBatal_hp.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 394)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 347)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(379, 297)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nama Produk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 246)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "ID Produk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(379, 197)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Tanggal"
        '
        'pnlTbhProduk
        '
        Me.pnlTbhProduk.Controls.Add(Me.DateTimePicker_tp)
        Me.pnlTbhProduk.Controls.Add(Me.Label7)
        Me.pnlTbhProduk.Controls.Add(Me.tb_harga_tp)
        Me.pnlTbhProduk.Controls.Add(Me.tb_stok_tp)
        Me.pnlTbhProduk.Controls.Add(Me.tb_nmProduk_tp)
        Me.pnlTbhProduk.Controls.Add(Me.tb_idProduk_tp)
        Me.pnlTbhProduk.Controls.Add(Me.btnLihat_tp)
        Me.pnlTbhProduk.Controls.Add(Me.btnSimpan_tp)
        Me.pnlTbhProduk.Controls.Add(Me.btnBatal_tp)
        Me.pnlTbhProduk.Controls.Add(Me.Label8)
        Me.pnlTbhProduk.Controls.Add(Me.Label9)
        Me.pnlTbhProduk.Controls.Add(Me.Label10)
        Me.pnlTbhProduk.Controls.Add(Me.Label11)
        Me.pnlTbhProduk.Controls.Add(Me.Label12)
        Me.pnlTbhProduk.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTbhProduk.Location = New System.Drawing.Point(297, 89)
        Me.pnlTbhProduk.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTbhProduk.Name = "pnlTbhProduk"
        Me.pnlTbhProduk.Size = New System.Drawing.Size(1163, 716)
        Me.pnlTbhProduk.TabIndex = 35
        '
        'DateTimePicker_tp
        '
        Me.DateTimePicker_tp.Location = New System.Drawing.Point(508, 195)
        Me.DateTimePicker_tp.Name = "DateTimePicker_tp"
        Me.DateTimePicker_tp.Size = New System.Drawing.Size(279, 25)
        Me.DateTimePicker_tp.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(495, 108)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 29)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "TAMBAH PRODUK"
        '
        'tb_harga_tp
        '
        Me.tb_harga_tp.Location = New System.Drawing.Point(509, 392)
        Me.tb_harga_tp.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_harga_tp.Name = "tb_harga_tp"
        Me.tb_harga_tp.Size = New System.Drawing.Size(279, 25)
        Me.tb_harga_tp.TabIndex = 26
        '
        'tb_stok_tp
        '
        Me.tb_stok_tp.Location = New System.Drawing.Point(509, 345)
        Me.tb_stok_tp.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_stok_tp.Name = "tb_stok_tp"
        Me.tb_stok_tp.Size = New System.Drawing.Size(279, 25)
        Me.tb_stok_tp.TabIndex = 25
        '
        'tb_nmProduk_tp
        '
        Me.tb_nmProduk_tp.Location = New System.Drawing.Point(509, 295)
        Me.tb_nmProduk_tp.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nmProduk_tp.Name = "tb_nmProduk_tp"
        Me.tb_nmProduk_tp.Size = New System.Drawing.Size(279, 25)
        Me.tb_nmProduk_tp.TabIndex = 24
        '
        'tb_idProduk_tp
        '
        Me.tb_idProduk_tp.Location = New System.Drawing.Point(509, 245)
        Me.tb_idProduk_tp.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_idProduk_tp.Name = "tb_idProduk_tp"
        Me.tb_idProduk_tp.Size = New System.Drawing.Size(279, 25)
        Me.tb_idProduk_tp.TabIndex = 23
        '
        'btnLihat_tp
        '
        Me.btnLihat_tp.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnLihat_tp.ForeColor = System.Drawing.Color.White
        Me.btnLihat_tp.Location = New System.Drawing.Point(662, 459)
        Me.btnLihat_tp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLihat_tp.Name = "btnLihat_tp"
        Me.btnLihat_tp.Size = New System.Drawing.Size(125, 40)
        Me.btnLihat_tp.TabIndex = 21
        Me.btnLihat_tp.Text = "Lihat"
        Me.btnLihat_tp.UseVisualStyleBackColor = False
        '
        'btnSimpan_tp
        '
        Me.btnSimpan_tp.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSimpan_tp.ForeColor = System.Drawing.Color.White
        Me.btnSimpan_tp.Location = New System.Drawing.Point(516, 459)
        Me.btnSimpan_tp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan_tp.Name = "btnSimpan_tp"
        Me.btnSimpan_tp.Size = New System.Drawing.Size(125, 40)
        Me.btnSimpan_tp.TabIndex = 20
        Me.btnSimpan_tp.Text = "Simpan"
        Me.btnSimpan_tp.UseVisualStyleBackColor = False
        '
        'btnBatal_tp
        '
        Me.btnBatal_tp.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnBatal_tp.ForeColor = System.Drawing.Color.White
        Me.btnBatal_tp.Location = New System.Drawing.Point(368, 458)
        Me.btnBatal_tp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal_tp.Name = "btnBatal_tp"
        Me.btnBatal_tp.Size = New System.Drawing.Size(125, 40)
        Me.btnBatal_tp.TabIndex = 19
        Me.btnBatal_tp.Text = "Batal"
        Me.btnBatal_tp.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 396)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 349)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Stok"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(352, 299)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Nama Produk"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(352, 248)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "ID Produk"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(352, 199)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Tanggal"
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
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 3)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(279, 1011)
        Me.pnlLeftSide.TabIndex = 36
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = Global.MMCoffee.My.Resources.Resources.log_out__3_
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(18, 272)
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
        'BRGTableAdapter
        '
        Me.BRGTableAdapter.ClearBeforeFill = True
        '
        'FormProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlTbhProduk)
        Me.Controls.Add(Me.pnlHpsProduk)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormProduk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTopSide.ResumeLayout(False)
        Me.pnlHpsProduk.ResumeLayout(False)
        Me.pnlHpsProduk.PerformLayout()
        CType(Me.BRGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTbhProduk.ResumeLayout(False)
        Me.pnlTbhProduk.PerformLayout()
        Me.pnlLeftSide.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHpsProduk As Button
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents btnTbhProduk As Button
    Friend WithEvents pnlHpsProduk As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_harga_hp As TextBox
    Friend WithEvents tb_stok_hp As TextBox
    Friend WithEvents tb_nmProduk_hp As TextBox
    Friend WithEvents btnLihat_hp As Button
    Friend WithEvents btnSimpan_hp As Button
    Friend WithEvents btnBatal_hp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlTbhProduk As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_harga_tp As TextBox
    Friend WithEvents tb_stok_tp As TextBox
    Friend WithEvents tb_nmProduk_tp As TextBox
    Friend WithEvents tb_idProduk_tp As TextBox
    Friend WithEvents btnLihat_tp As Button
    Friend WithEvents btnSimpan_tp As Button
    Friend WithEvents btnBatal_tp As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnUpdtProduk As Button
    Friend WithEvents btnUpdtStok As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents DateTimePicker_tp As DateTimePicker
    Friend WithEvents cb_idProduk_hp As ComboBox
    Friend WithEvents DateTimePicker_hp As DateTimePicker
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents BRGBindingSource As BindingSource
    Friend WithEvents BRGTableAdapter As DataSet2TableAdapters.BRGTableAdapter
End Class
