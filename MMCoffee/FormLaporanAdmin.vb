Imports System.Data.OracleClient

Public Class FormLaporanAdmin
    Dim conn As New OracleConnection
    Dim dr As OracleDataReader
    Dim cmd As New OracleCommand
    Dim StokID, JMLKELUAR, JMLMASUK, NO As Integer
    Dim str, Ket As String
    Dim totalMasukRBS, totalKeluarRBS As Integer
    Dim totalMasukJHE, totalKeluarJHE As Integer

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FormLandingPage.Show()
    End Sub

    Sub koneksi()
        conn = New OracleConnection("Data Source = XE; Persist Security Info=True; User Id=hr; Unicode=True; password=hr")
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Private Sub btnUpdtStok_Click(sender As Object, e As EventArgs) Handles btnUpdtStok.Click
        Me.Hide()
        FormStok.Show()
    End Sub

    Private Sub btnUpdtProduk_Click(sender As Object, e As EventArgs) Handles btnUpdtProduk.Click
        Me.Hide()
        FormProduk.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub FormLaporanAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        'tabel kopi robusta
        totalMasukRBS = 0
        totalKeluarRBS = 0
        NO = 1
        lv_laporanRobusta.Items.Clear()
        cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, JUMLAH_PEMASUKAN, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE ID_PRODUK = '102'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_laporanRobusta.Items.Add(NO)
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(4))
                NO = NO + 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        For i As Integer = 0 To lv_laporanRobusta.Items.Count - 1
            totalMasukRBS = totalMasukRBS + CInt(lv_laporanRobusta.Items(i).SubItems(2).Text)
            totalKeluarRBS = totalKeluarRBS + CInt(lv_laporanRobusta.Items(i).SubItems(3).Text)
        Next
        jmRobusta.Text = totalMasukRBS
        jkRobusta.Text = totalKeluarRBS
        tsRobusta.Text = totalMasukRBS - totalKeluarRBS

        'tabel kopi jahe
        totalMasukJHE = 0
        totalKeluarJHE = 0
        NO = 1
        lv_laporanJahe.Items.Clear()
        cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, JUMLAH_PEMASUKAN, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE ID_PRODUK = '101'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_laporanJahe.Items.Add(NO)
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(4))
                NO = NO + 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        For i As Integer = 0 To lv_laporanJahe.Items.Count - 1
            totalMasukJHE = totalMasukJHE + CInt(lv_laporanJahe.Items(i).SubItems(2).Text)
            totalKeluarJHE = totalKeluarJHE + CInt(lv_laporanJahe.Items(i).SubItems(3).Text)
        Next
        jmJahe.Text = totalMasukJHE
        jkJahe.Text = totalKeluarJHE
        tsJahe.Text = totalMasukJHE - totalKeluarJHE
    End Sub

    Private Sub FormLaporanAdmin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        koneksi()
        'tabel kopi robusta
        totalMasukRBS = 0
        totalKeluarRBS = 0
        NO = 1
        lv_laporanRobusta.Items.Clear()
        cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, JUMLAH_PEMASUKAN, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE ID_PRODUK = '102'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_laporanRobusta.Items.Add(NO)
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_laporanRobusta.Items(lv_laporanRobusta.Items.Count - 1).SubItems.Add(dr.Item(4))
                NO = NO + 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        For i As Integer = 0 To lv_laporanRobusta.Items.Count - 1
            totalMasukRBS = totalMasukRBS + CInt(lv_laporanRobusta.Items(i).SubItems(2).Text)
            totalKeluarRBS = totalKeluarRBS + CInt(lv_laporanRobusta.Items(i).SubItems(3).Text)
        Next
        jmRobusta.Text = totalMasukRBS
        jkRobusta.Text = totalKeluarRBS
        tsRobusta.Text = totalMasukRBS - totalKeluarRBS

        'tabel kopi jahe
        totalMasukJHE = 0
        totalKeluarJHE = 0
        NO = 1
        lv_laporanJahe.Items.Clear()
        cmd = New OracleCommand("SELECT ID_STOK, TANGGAL, JUMLAH_PEMASUKAN, JUMLAH_PENGELUARAN, KETERANGAN from STOKBRG WHERE ID_PRODUK = '101'", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_laporanJahe.Items.Add(NO)
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_laporanJahe.Items(lv_laporanJahe.Items.Count - 1).SubItems.Add(dr.Item(4))
                NO = NO + 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        For i As Integer = 0 To lv_laporanJahe.Items.Count - 1
            totalMasukJHE = totalMasukJHE + CInt(lv_laporanJahe.Items(i).SubItems(2).Text)
            totalKeluarJHE = totalKeluarJHE + CInt(lv_laporanJahe.Items(i).SubItems(3).Text)
        Next
        jmJahe.Text = totalMasukJHE
        jkJahe.Text = totalKeluarJHE
        tsJahe.Text = totalMasukJHE - totalKeluarJHE
    End Sub
End Class