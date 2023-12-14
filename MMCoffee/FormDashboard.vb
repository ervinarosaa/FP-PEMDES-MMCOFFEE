Imports System.Data.OracleClient

Public Class FormDashboard

    Dim cn As New OracleConnection
    Dim da As New OracleDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OracleCommand
    Dim dr As OracleDataReader
    Dim dt As New DataTable
    Dim si As Integer

    Sub koneksi()
        cn = New OracleConnection("Data Source = XE; Persist Security Info=True; User Id=hr; Unicode=True; password=hr")
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Show()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Me.Hide()
        FormTransaksi.Show()
    End Sub

    Private Sub btnReportCashier_Click(sender As Object, e As EventArgs) Handles btnReportCashier.Click
        Me.Hide()
        FormLaporanCashier.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FormLandingPage.Show()
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerDashboard.Enabled = True
        koneksi()

        cmd = New OracleCommand("select sum(jumlahsat) from laporansatuan where namabarangsat = 'Kopi Jahe'", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbProJahe.Text = dr(0).ToString

        cmd = New OracleCommand("select sum(jumlahsat) from laporansatuan where namabarangsat = 'Kopi Robusta'", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbProRobu.Text = dr(0).ToString

        cmd = New OracleCommand("select sum(stok_produk) from brg where id_produk = 101", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbStkJahe.Text = dr(0).ToString

        cmd = New OracleCommand("select sum(stok_produk) from brg where id_produk = 102", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbStkRobu.Text = dr(0).ToString

        cmd = New OracleCommand("select sum(totaltransaksi) from laporansatuan", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbPemasukan.Text = dr(0).ToString
    End Sub

    Private Sub FormDashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        koneksi()

        cmd = New OracleCommand("select sum(jumlahsat) from laporansatuan where namabarangsat = 'Kopi Jahe'", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbProJahe.Text = dr(0).ToString

        cmd = New OracleCommand("select sum(jumlahsat) from laporansatuan where namabarangsat = 'Kopi Robusta'", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbProRobu.Text = dr(0).ToString

        cmd = New OracleCommand("select sum(stok_produk) from brg where id_produk = 101", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbStkJahe.Text = dr(0).ToString

        cmd = New OracleCommand("select sum(stok_produk) from brg where id_produk = 102", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbStkRobu.Text = dr(0).ToString

        cmd = New OracleCommand("select sum(totaltransaksi) from laporansatuan", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbPemasukan.Text = dr(0).ToString
    End Sub

    Private Sub TimerDashboard_Tick(sender As Object, e As EventArgs) Handles TimerDashboard.Tick
        Label_Tanggal_Dashboard.Text = Date.Now.ToString("dddd, dd MMMM yyyy")   'Shows current date
        Label_Waktu_Dashboard.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class