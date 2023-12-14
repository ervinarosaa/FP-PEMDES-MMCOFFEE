Imports System.Data.OracleClient
Public Class FormLihatProduk
    Dim conn As New OracleConnection
    Dim dr As OracleDataReader
    Dim cmd As New OracleCommand
    Dim str, Ket As String

    Sub koneksi()
        conn.Close()
        conn = New OracleConnection("data source= (DESCRIPTION = " &
    "(ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-1AMLBSHE)(PORT = 1521)) " &
    "(CONNECT_DATA = " &
      "(SERVER = DEDICATED) " &
      "(SERVICE_NAME = XE) " &
    ") " &
  "); user id=hr; password=hr;")
        conn.Open()
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
        Me.Hide()
        FormLaporanAdmin.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FormProduk.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FormLandingPage.Show()
    End Sub

    Private Sub FormLihatProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        lv_lihatProduk.Items.Clear()
        cmd = New OracleCommand("SELECT * from BRG", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                lv_lihatProduk.Items.Add(dr.Item(0))
                lv_lihatProduk.Items(lv_lihatProduk.Items.Count - 1).SubItems.Add(dr.Item(1))
                lv_lihatProduk.Items(lv_lihatProduk.Items.Count - 1).SubItems.Add(dr.Item(2))
                lv_lihatProduk.Items(lv_lihatProduk.Items.Count - 1).SubItems.Add(dr.Item(3))
                lv_lihatProduk.Items(lv_lihatProduk.Items.Count - 1).SubItems.Add(dr.Item(4))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub
End Class