Imports System.Data.OracleClient

Public Class FormStok
    Dim conn As New OracleConnection
    Dim dr As OracleDataReader
    Dim cmd As New OracleCommand
    Dim StokID, JMLKELUAR, JMLMASUK, NO, JMLSTOK As Integer
    Dim str, Ket As String

    Sub koneksi()
        conn = New OracleConnection("Data Source = XE; Persist Security Info=True; User Id=hr; Unicode=True; password=hr")
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Private Sub btnBrgMasuk_Click(sender As Object, e As EventArgs) Handles btnBrgMasuk.Click
        pnlBrgMasuk.Visible = True
        pnlBrgKeluar.Visible = False
        cb_idProduk_bm.ResetText()
        tb_nmProduk_bm.Text = ""
    End Sub

    Private Sub btnBrgKeluar_Click(sender As Object, e As EventArgs) Handles btnBrgKeluar.Click
        pnlBrgKeluar.Visible = True
        pnlBrgMasuk.Visible = False
        cb_idProduk_bk.ResetText()
        tb_nmProduk_bk.Text = ""
        lv_barangKeluar.Items.Clear()
        cmd = New OracleCommand("SELECT  ID_STOK, TANGGAL, ID_PRODUK, NAMAPRODUK, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE KETERANGAN NOT IN 'Suplier'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_barangKeluar.Items.Add(NO)
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(4))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(5))
                NO = NO + 1
            End While
            dr.Close()
        End If
    End Sub

    Private Sub btnUpdtStok_Click(sender As Object, e As EventArgs) Handles btnUpdtStok.Click
        Me.Show()
    End Sub

    Private Sub btnSimpan_bm_Click(sender As Object, e As EventArgs) Handles btnSimpan_bm.Click
        koneksi()
        cmd = New OracleCommand("select count (*) ID_STOK from STOKBRG", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            StokID = dr("ID_STOK") + 1
        End If
        JMLKELUAR = 0
        NO = 1
        Ket = "Suplier"
        cmd = New OracleCommand("insert into STOKBRG values (" & StokID & ",'" & DateTimePicker_bm.Value.ToShortDateString & "','" & cb_idProduk_bm.Text & "'," &
                                 "'" & tb_nmProduk_bm.Text & "'," & UpDown_bm.Value & "," & JMLKELUAR & ",'" & Ket & "')", conn)
        cmd.ExecuteNonQuery()



        If cb_idProduk_bm.Text = "101" Then
            cmd = New OracleCommand("select STOK_PRODUK from BRG where ID_PRODUK = '101'", conn)
            dr = cmd.ExecuteReader()
            If (dr.Read() = True) Then
                JMLSTOK = dr("STOK_PRODUK")
            End If
            cmd = New OracleCommand("update brg set stok_produk = '" & (JMLSTOK + UpDown_bm.Value) & "' where ID_PRODUK = '101'", conn)
            cmd.ExecuteNonQuery()
        ElseIf cb_idProduk_bm.Text = "102" Then
            cmd = New OracleCommand("select STOK_PRODUK from BRG where ID_PRODUK = '102'", conn)
            dr = cmd.ExecuteReader()
            If (dr.Read() = True) Then
                JMLSTOK = dr("STOK_PRODUK")
            End If
            cmd = New OracleCommand("update brg set stok_produk = '" & (JMLSTOK + UpDown_bm.Value) & "' where ID_PRODUK = '102'", conn)
            cmd.ExecuteNonQuery()
        End If

        lv_barangmasuk.Items.Clear()
        cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, ID_PRODUK, NAMAPRODUK, JUMLAH_PEMASUKAN, KETERANGAN from STOKBRG WHERE KETERANGAN = 'Suplier'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_barangmasuk.Items.Add(NO)
                lv_barangmasuk.Items(lv_barangmasuk.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_barangmasuk.Items(lv_barangmasuk.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_barangmasuk.Items(lv_barangmasuk.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_barangmasuk.Items(lv_barangmasuk.Items.Count - 1).SubItems.Add(dr.Item(4))
                lv_barangmasuk.Items(lv_barangmasuk.Items.Count - 1).SubItems.Add(dr.Item(5))
                NO = NO + 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        UpDown_bm.Value = 0
        cb_idProduk_bm.ResetText()
        tb_nmProduk_bm.Text = ""
    End Sub

    Private Sub btnBatal_bm_Click(sender As Object, e As EventArgs) Handles btnBatal_bm.Click
        Dim batalTambah = MessageBox.Show("Anda yakin ingin membatalkan tambah stok ??", "Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If batalTambah = vbYes Then
            UpDown_bm.Value = 0
            cb_idProduk_bm.ResetText()
            tb_nmProduk_bm.Text = ""
            MsgBox("Stok Batal Dihapus")
        End If
    End Sub

    Private Sub cb_idProduk_bm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_idProduk_bm.SelectedIndexChanged
        koneksi()
        cmd = New OracleCommand("Select * from BRG Where ID_PRODUK= '" & cb_idProduk_bm.Text & "'", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            tb_nmProduk_bm.Text = dr("NAMAPRODUK")
        End If
    End Sub

    Private Sub cb_idProduk_bk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_idProduk_bk.SelectedIndexChanged
        koneksi()
        cmd = New OracleCommand("Select * from BRG Where ID_PRODUK= '" & cb_idProduk_bk.Text & "'", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            tb_nmProduk_bk.Text = dr("NAMAPRODUK")
        End If
    End Sub

    Private Sub btnBatal_bk_Click(sender As Object, e As EventArgs) Handles btnBatal_bk.Click
        Dim batalHapus = MessageBox.Show("Anda yakin ingin membatalkan menghapus stok ??", "Batal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If batalHapus = vbYes Then
            UpDown_bk.Value = 0
            cb_idProduk_bk.ResetText()
            tb_nmProduk_bk.Text = ""
            MsgBox("Stok Batal Dihapus")
        End If
    End Sub

    Private Sub btnSimpan_bk_Click(sender As Object, e As EventArgs) Handles btnSimpan_bk.Click
        koneksi()
        cmd = New OracleCommand("select count (*) ID_STOK from STOKBRG", conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            StokID = dr("ID_STOK") + 1
        End If
        Ket = "Suplier"
        JMLMASUK = 0
        NO = 1
        cmd = New OracleCommand("insert into STOKBRG values (" & StokID & ",'" & DateTimePicker_bk.Value.ToShortDateString & "','" & cb_idProduk_bk.Text & "'," &
                                 "'" & tb_nmProduk_bk.Text & "'," & JMLMASUK & "," & UpDown_bk.Value & ",'" & cb_keterangan_bk.Text & "')", conn)
        cmd.ExecuteNonQuery()

        If cb_idProduk_bk.Text = "101" Then
            cmd = New OracleCommand("select STOK_PRODUK from BRG where ID_PRODUK = '101'", conn)
            dr = cmd.ExecuteReader()
            If (dr.Read() = True) Then
                JMLSTOK = dr("STOK_PRODUK")
            End If
            cmd = New OracleCommand("update brg set stok_produk = '" & (JMLSTOK - UpDown_bk.Value) & "' where ID_PRODUK = '101'", conn)
            cmd.ExecuteNonQuery()
        ElseIf cb_idProduk_bk.Text = "102" Then
            cmd = New OracleCommand("select STOK_PRODUK from BRG where ID_PRODUK = '102'", conn)
            dr = cmd.ExecuteReader()
            If (dr.Read() = True) Then
                JMLSTOK = dr("STOK_PRODUK")
            End If
            cmd = New OracleCommand("update brg set stok_produk = '" & (JMLSTOK - UpDown_bk.Value) & "' where ID_PRODUK = '102'", conn)
            cmd.ExecuteNonQuery()
        End If

        lv_barangKeluar.Items.Clear()
        cmd = New OracleCommand("SELECT  ID_STOK, TANGGAL, ID_PRODUK, NAMAPRODUK, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE KETERANGAN NOT IN '" & Ket & "'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_barangKeluar.Items.Add(NO)
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(4))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(5))
                NO = NO + 1
            End While
            dr.Close()
        End If

        UpDown_bk.Value = 0
        cb_idProduk_bk.ResetText()
        tb_nmProduk_bk.Text = ""
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FormLandingPage.Show()
    End Sub

    Private Sub btnUpdtProduk_Click(sender As Object, e As EventArgs) Handles btnUpdtProduk.Click
        Me.Hide()
        FormProduk.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Hide()
        FormLaporanAdmin.ShowDialog()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub FormStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.BRG' table. You can move, or remove it, as needed.
        Me.BRGTableAdapter.Fill(Me.DataSet1.BRG)
        cb_idProduk_bm.ResetText()
        koneksi()
        NO = 1
        lv_barangmasuk.Items.Clear()
        cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, ID_PRODUK, NAMAPRODUK, JUMLAH_PEMASUKAN, KETERANGAN from STOKBRG WHERE KETERANGAN = 'Suplier'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_barangmasuk.Items.Add(NO)
                lv_barangmasuk.Items(lv_barangmasuk.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_barangmasuk.Items(lv_barangmasuk.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_barangmasuk.Items(lv_barangmasuk.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_barangmasuk.Items(lv_barangmasuk.Items.Count - 1).SubItems.Add(dr.Item(4))
                lv_barangmasuk.Items(lv_barangmasuk.Items.Count - 1).SubItems.Add(dr.Item(5))
                NO = NO + 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()


        NO = 1
        koneksi()
        lv_barangKeluar.Items.Clear()
        cmd = New OracleCommand("SELECT  ID_STOK, TANGGAL, ID_PRODUK, NAMAPRODUK, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE KETERANGAN NOT IN '" & Ket & "'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_barangKeluar.Items.Add(NO)
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(4))
                lv_barangKeluar.Items(lv_barangKeluar.Items.Count - 1).SubItems.Add(dr.Item(5))
                NO = NO + 1
            End While
            dr.Close()
        End If
        UpDown_bk.Value = 0
        cb_idProduk_bk.ResetText()
        tb_nmProduk_bk.Text = ""
        dr.Close()
        cmd.Dispose()
    End Sub
End Class