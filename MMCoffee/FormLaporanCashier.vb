Imports System.Data.OracleClient

Public Class FormLaporanCashier

    Dim cn As New OracleConnection
    Dim da As New OracleDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OracleCommand
    Dim dr As OracleDataReader
    Dim dt As New DataTable

    Sub koneksi()
        cn = New OracleConnection("Data Source = XE; Persist Security Info=True; User Id=hr; Unicode=True; password=hr")
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        FormDashboard.Show()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Me.Hide()
        FormTransaksi.Show()
    End Sub

    Private Sub btnReportCashier_Click(sender As Object, e As EventArgs) Handles btnReportCashier.Click
        Me.Show()
    End Sub

    Private Sub FormLaporanCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        lvLapSat.Items.Clear()

        cmd = New OracleCommand("select notransaksisat, namabarangsat, jumlahsat, totaltransaksi from laporansatuan", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read()
                lvLapSat.Items.Add(dr.Item(0))
                lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(1))
                lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(2))
                lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(3))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        cmd = New OracleCommand("select sum(totaltransaksi) from laporansatuan", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbTotalPenjualan.Text = dr(0).ToString
    End Sub

    Private Sub FormLaporanCashier_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        koneksi()

        lvLapSat.Items.Clear()

        cmd = New OracleCommand("select notransaksisat, namabarangsat, jumlahsat, totaltransaksi from laporansatuan", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read()
                lvLapSat.Items.Add(dr.Item(0))
                lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(1))
                lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(2))
                lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(3))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        cmd = New OracleCommand("select sum(totaltransaksi) from laporansatuan", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbTotalPenjualan.Text = dr(0).ToString
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FormLandingPage.Show()
    End Sub

    Private Sub btnCariTgl_Click(sender As Object, e As EventArgs) Handles btnCariTgl.Click
        If DateTimePicker1.Text = "" Then
            MsgBox("Mohon mengisi textbox terlebih dahulu")
        Else
            lvLapSat.Items.Clear()

            cmd = New OracleCommand("select notransaksisat, namabarangsat, jumlahsat, totaltransaksi from laporansatuan where tanggal = '" & DateTimePicker1.Text & "'", cn)
            dr = cmd.ExecuteReader()

            If dr.HasRows = True Then
                While dr.Read()
                    lvLapSat.Items.Add(dr.Item(0))
                    lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(1))
                    lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(2))
                    lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(3))
                End While
                dr.Close()
            End If
            dr.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        lvLapSat.Items.Clear()

        cmd = New OracleCommand("select notransaksisat, namabarangsat, jumlahsat, totaltransaksi from laporansatuan", cn)
        dr = cmd.ExecuteReader()

        If dr.HasRows = True Then
            While dr.Read()
                lvLapSat.Items.Add(dr.Item(0))
                lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(1))
                lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(2))
                lvLapSat.Items(lvLapSat.Items.Count - 1).SubItems.Add(dr.Item(3))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

End Class