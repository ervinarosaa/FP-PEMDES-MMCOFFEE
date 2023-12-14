Imports System.Data.OracleClient

Public Class FormProduk
    Dim conn As New OracleConnection
    Dim dr As OracleDataReader
    Dim cmd As New OracleCommand
    Dim StokID, JMLKELUAR, JMLMASUK, NO As Integer
    Dim Ket As String
    Dim totalMasukRBS, totalKeluarRBS As Integer
    Dim totalMasukJHE, totalKeluarJHE As Integer

    Sub koneksi()
        conn = New OracleConnection("Data Source = XE; Persist Security Info=True; User Id=hr; Unicode=True; password=hr")
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Private Sub btnTbhProduk_Click(sender As Object, e As EventArgs) Handles btnTbhProduk.Click
        pnlTbhProduk.Visible = True
        pnlHpsProduk.Visible = False
    End Sub

    Private Sub btnHpsProduk_Click(sender As Object, e As EventArgs) Handles btnHpsProduk.Click
        pnlHpsProduk.Visible = True
        pnlTbhProduk.Visible = False
        Me.BRGTableAdapter.Fill(Me.DataSet2.BRG)
        cb_idProduk_hp.ResetText()
        tb_nmProduk_hp.Text = ""
        tb_harga_hp.Text = ""
        tb_stok_hp.Text = ""
    End Sub

    Private Sub btnUpdtStok_Click(sender As Object, e As EventArgs) Handles btnUpdtStok.Click
        Me.Hide()
        FormStok.Show()
    End Sub

    Private Sub btnUpdtProduk_Click(sender As Object, e As EventArgs) Handles btnUpdtProduk.Click
        Me.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Hide()
        FormLaporanAdmin.ShowDialog()
    End Sub

    Private Sub btnLihat_tp_Click(sender As Object, e As EventArgs) Handles btnLihat_tp.Click
        Me.Hide()
        FormLihatProduk.ShowDialog()
    End Sub

    Private Sub btnSimpan_tp_Click(sender As Object, e As EventArgs) Handles btnSimpan_tp.Click
        koneksi()
        cmd = New OracleCommand("Select * from BRG Where ID_PRODUK= '" & tb_idProduk_tp.Text & "'", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            'update
            cmd = New OracleCommand("Update BRG set NAMAPRODUK = '" & tb_nmProduk_tp.Text & "',HARGA_SATUAN = " & CDbl(tb_harga_tp.Text) &
                                    "where ID_PRODUK = '" & tb_idProduk_tp.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Detail Produk Berhasil Diupdate")

        Else
            'Tambah ke database tabel BRG
            cmd = New OracleCommand("insert into BRG values ('" & tb_idProduk_tp.Text & "','" & tb_nmProduk_tp.Text & "'," & CDbl(tb_harga_tp.Text) &
                                     "," & CInt(tb_stok_tp.Text) & ",'" & DateTimePicker_tp.Value.ToShortDateString & "')", conn)
            cmd.ExecuteNonQuery()

            cmd = New OracleCommand("select count (*) ID_STOK from STOKBRG", conn)
            dr = cmd.ExecuteReader()
            If (dr.Read() = True) Then
                StokID = dr("ID_STOK") + 1
            End If

            'tambah ke database tabel STOKBRG
            JMLKELUAR = 0
            NO = 1
            Ket = "Suplier"
            cmd = New OracleCommand("insert into STOKBRG values (" & StokID & ",'" & DateTimePicker_tp.Value.ToShortDateString & "','" & tb_idProduk_tp.Text & "'," &
                                     "'" & tb_nmProduk_tp.Text & "'," & CInt(tb_stok_tp.Text) & "," & JMLKELUAR & ",'" & Ket & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Produk Berhasil Ditambahkan")
        End If


        'Bersihkan textbox
        tb_idProduk_tp.Text = ""
        tb_nmProduk_tp.Text = ""
        tb_harga_tp.Text = ""
        tb_stok_tp.Text = ""
        'update combo box
        Me.BRGTableAdapter.Fill(Me.DataSet2.BRG)
    End Sub

    Private Sub btnLihat_hp_Click(sender As Object, e As EventArgs) Handles btnLihat_hp.Click
        Me.Hide()
        FormLihatProduk.ShowDialog()
    End Sub

    Private Sub cb_idProduk_hp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_idProduk_hp.SelectedIndexChanged
        koneksi()
        cmd = New OracleCommand("Select * from BRG Where ID_PRODUK= '" & cb_idProduk_hp.Text & "'", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            tb_nmProduk_hp.Text = dr("NAMAPRODUK")
            tb_harga_hp.Text = dr("HARGA_SATUAN")
            tb_stok_hp.Text = dr("STOK_PRODUK")
            If (dr("ID_PRODUK") = "102") Then
                totalMasukRBS = 0
                totalKeluarRBS = 0
                NO = 1
                FormLaporanAdmin.lv_laporanRobusta.Items.Clear()
                cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, JUMLAH_PEMASUKAN, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE ID_PRODUK = '102'", conn)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read()
                        FormLaporanAdmin.lv_laporanRobusta.Items.Add(NO)
                        FormLaporanAdmin.lv_laporanRobusta.Items(FormLaporanAdmin.lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(1))
                        FormLaporanAdmin.lv_laporanRobusta.Items(FormLaporanAdmin.lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(2))
                        FormLaporanAdmin.lv_laporanRobusta.Items(FormLaporanAdmin.lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(3))
                        FormLaporanAdmin.lv_laporanRobusta.Items(FormLaporanAdmin.lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(4))
                        NO = NO + 1
                    End While
                    dr.Close()
                End If
                dr.Close()
                cmd.Dispose()
                For i As Integer = 0 To FormLaporanAdmin.lv_laporanRobusta.Items.Count - 1
                    totalMasukRBS = totalMasukRBS + CInt(FormLaporanAdmin.lv_laporanRobusta.Items(i).SubItems(2).Text)
                    totalKeluarRBS = totalKeluarRBS + CInt(FormLaporanAdmin.lv_laporanRobusta.Items(i).SubItems(3).Text)
                Next
                tb_stok_hp.Text = totalMasukRBS - totalKeluarRBS

            ElseIf (dr("ID_PRODUK") = "101") Then
                totalMasukJHE = 0
                totalKeluarJHE = 0
                NO = 1
                FormLaporanAdmin.lv_laporanJahe.Items.Clear()
                cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, JUMLAH_PEMASUKAN, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE ID_PRODUK = '101'", conn)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read()
                        FormLaporanAdmin.lv_laporanJahe.Items.Add(NO)
                        FormLaporanAdmin.lv_laporanJahe.Items(FormLaporanAdmin.lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(1))
                        FormLaporanAdmin.lv_laporanJahe.Items(FormLaporanAdmin.lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(2))
                        FormLaporanAdmin.lv_laporanJahe.Items(FormLaporanAdmin.lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(3))
                        FormLaporanAdmin.lv_laporanJahe.Items(FormLaporanAdmin.lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(4))
                        NO = NO + 1
                    End While
                    dr.Close()
                End If
                dr.Close()
                cmd.Dispose()
                For i As Integer = 0 To FormLaporanAdmin.lv_laporanJahe.Items.Count - 1
                    totalMasukJHE = totalMasukJHE + CInt(FormLaporanAdmin.lv_laporanJahe.Items(i).SubItems(2).Text)
                    totalKeluarJHE = totalKeluarJHE + CInt(FormLaporanAdmin.lv_laporanJahe.Items(i).SubItems(3).Text)
                Next
                tb_stok_hp.Text = totalMasukJHE - totalKeluarJHE
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FormLandingPage.Show()
    End Sub

    Private Sub tb_idProduk_tp_TextChanged(sender As Object, e As EventArgs) Handles tb_idProduk_tp.TextChanged
        koneksi()
        cmd = New OracleCommand("Select * from BRG Where ID_PRODUK= '" & tb_idProduk_tp.Text & "'", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            tb_nmProduk_tp.Text = dr("NAMAPRODUK")
            tb_harga_tp.Text = dr("HARGA_SATUAN")
            tb_stok_tp.Text = dr("STOK_PRODUK")
        End If
    End Sub

    Private Sub btnBatal_hp_Click(sender As Object, e As EventArgs) Handles btnBatal_hp.Click
        Dim batalHapus = MessageBox.Show("Anda yakin ingin membatalkan tambah produk ??", "Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If batalHapus = vbYes Then
            cb_idProduk_hp.ResetText()
            tb_nmProduk_hp.Text = ""
            tb_harga_hp.Text = ""
            tb_stok_hp.Text = ""
            MsgBox("Produk Batal Dihapus")
        End If
    End Sub

    Private Sub btnSimpan_hp_Click(sender As Object, e As EventArgs) Handles btnSimpan_hp.Click
        Dim hapus = MessageBox.Show("Anda yakin ingin menghapus produk ??", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hapus = vbYes Then
            koneksi()
            'Hapus dari database tabel BRG sesuai dengan id_produk
            cmd = New OracleCommand("delete BRG where ID_PRODUK='" & cb_idProduk_hp.Text & "'", conn)
            cmd.ExecuteNonQuery()

            cmd = New OracleCommand("select count (*) ID_STOK from STOKBRG", conn)
            dr = cmd.ExecuteReader()
            If (dr.Read() = True) Then
                StokID = dr("ID_STOK") + 1
            End If

            'Tambah ke database tabel STOKBRG (barang keluar/pengurangan semua sisa stok yang ada)
            Ket = "Lainnya"
            JMLMASUK = 0
            NO = 1
            cmd = New OracleCommand("insert into STOKBRG values (" & StokID & ",'" & DateTimePicker_hp.Value.ToShortDateString & "','" & cb_idProduk_hp.Text & "'," &
                                     "'" & tb_nmProduk_hp.Text & "'," & JMLMASUK & "," & CInt(tb_stok_hp.Text) & ",'" & Ket & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Produk Berhasil Dihapus")
            cb_idProduk_hp.ResetText()
            tb_nmProduk_hp.Text = ""
            tb_harga_hp.Text = ""
            tb_stok_hp.Text = ""
            Me.BRGTableAdapter.Fill(Me.DataSet2.BRG)

            'coba
            koneksi()
            cmd = New OracleCommand("Select * from BRG Where ID_PRODUK= '" & cb_idProduk_hp.Text & "'", conn)
            dr = cmd.ExecuteReader()
            If (dr.Read() = True) Then
                tb_nmProduk_hp.Text = dr("NAMAPRODUK")
                tb_harga_hp.Text = dr("HARGA_SATUAN")
                If (dr("ID_PRODUK") = "102") Then
                    totalMasukRBS = 0
                    totalKeluarRBS = 0
                    NO = 1
                    FormLaporanAdmin.lv_laporanRobusta.Items.Clear()
                    cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, JUMLAH_PEMASUKAN, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE ID_PRODUK = '102'", conn)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            FormLaporanAdmin.lv_laporanRobusta.Items.Add(NO)
                            FormLaporanAdmin.lv_laporanRobusta.Items(FormLaporanAdmin.lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(1))
                            FormLaporanAdmin.lv_laporanRobusta.Items(FormLaporanAdmin.lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(2))
                            FormLaporanAdmin.lv_laporanRobusta.Items(FormLaporanAdmin.lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(3))
                            FormLaporanAdmin.lv_laporanRobusta.Items(FormLaporanAdmin.lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(4))
                            NO = NO + 1
                        End While
                        dr.Close()
                    End If
                    dr.Close()
                    cmd.Dispose()
                    For i As Integer = 0 To FormLaporanAdmin.lv_laporanRobusta.Items.Count - 1
                        totalMasukRBS = totalMasukRBS + CInt(FormLaporanAdmin.lv_laporanRobusta.Items(i).SubItems(2).Text)
                        totalKeluarRBS = totalKeluarRBS + CInt(FormLaporanAdmin.lv_laporanRobusta.Items(i).SubItems(3).Text)
                    Next
                    tb_stok_hp.Text = totalMasukRBS - totalKeluarRBS

                ElseIf (dr("ID_PRODUK") = "101") Then
                    totalMasukJHE = 0
                    totalKeluarJHE = 0
                    NO = 1
                    FormLaporanAdmin.lv_laporanJahe.Items.Clear()
                    cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, JUMLAH_PEMASUKAN, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE ID_PRODUK = '101'", conn)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            FormLaporanAdmin.lv_laporanJahe.Items.Add(NO)
                            FormLaporanAdmin.lv_laporanJahe.Items(FormLaporanAdmin.lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(1))
                            FormLaporanAdmin.lv_laporanJahe.Items(FormLaporanAdmin.lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(2))
                            FormLaporanAdmin.lv_laporanJahe.Items(FormLaporanAdmin.lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(3))
                            FormLaporanAdmin.lv_laporanJahe.Items(FormLaporanAdmin.lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(4))
                            NO = NO + 1
                        End While
                        dr.Close()
                    End If
                    dr.Close()
                    cmd.Dispose()
                    For i As Integer = 0 To FormLaporanAdmin.lv_laporanJahe.Items.Count - 1
                        totalMasukJHE = totalMasukJHE + CInt(FormLaporanAdmin.lv_laporanJahe.Items(i).SubItems(2).Text)
                        totalKeluarJHE = totalKeluarJHE + CInt(FormLaporanAdmin.lv_laporanJahe.Items(i).SubItems(3).Text)
                    Next
                    tb_stok_hp.Text = totalMasukJHE - totalKeluarJHE
                End If
            End If
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.BRG' table. You can move, or remove it, as needed.
        Me.BRGTableAdapter.Fill(Me.DataSet2.BRG)
    End Sub

    Private Sub btnBatal_tp_Click(sender As Object, e As EventArgs) Handles btnBatal_tp.Click
        Dim batalTambah = MessageBox.Show("Anda yakin ingin membatalkan tambah produk ?", "Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If batalTambah = vbYes Then
            tb_idProduk_tp.Text = ""
            tb_nmProduk_tp.Text = ""
            tb_harga_tp.Text = ""
            tb_stok_tp.Text = ""
            MsgBox("Produk Batal Ditambahkan")
        End If
    End Sub
End Class