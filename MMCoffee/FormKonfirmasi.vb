Imports System.Data.OracleClient

Public Class FormKonfirmasi

    Dim cn As New OracleConnection
    Dim da As New OracleDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OracleCommand
    Dim dr As OracleDataReader
    Dim dt As New DataTable
    Dim no, notr, total As Integer


    Sub koneksi()
        cn = New OracleConnection("Data Source = XE; Persist Security Info=True; User Id=hr; Unicode=True; password=hr")
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub

    Private Sub FormKonfirmasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        notr = 20222201
        no = 1

        tbTglInv.Text = DateString
        tbWktInv.Text = TimeOfDay
        tbTglInv.Enabled = False
        tbWktInv.Enabled = False
        tbKodetrans.Text = notr

        ListView1.Items.Clear()

        cmd = New OracleCommand("select kodetransaksi, nmbrg, hrgbrg, jumlah, subtotal from invoice", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read()
                ListView1.Items.Add(no)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4))
                no += 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        cmd = New OracleCommand("select sum(subtotal) from invoice", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbTotalTrans.Text = dr(0).ToString
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        cmd = New OracleCommand("delete invoice", cn)
        cmd.ExecuteNonQuery()

        notr += 1
        tbKodetrans.Text = notr

        MsgBox("Invoice Berhasil Dicetak")
        FormTransaksi.Show()
        Me.Hide()

    End Sub

    Private Sub FormKonfirmasi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        koneksi()
        notr = 20222201
        no = 1

        tbTglInv.Text = DateString
        tbWktInv.Text = TimeOfDay
        tbTglInv.Enabled = False
        tbWktInv.Enabled = False
        tbKodetrans.Text = notr

        ListView1.Items.Clear()

        cmd = New OracleCommand("select kodetransaksi, nmbrg, hrgbrg, jumlah, subtotal from invoice", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read()
                ListView1.Items.Add(no)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4))
                no += 1
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        cmd = New OracleCommand("select sum(subtotal) from invoice", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbTotalTrans.Text = dr(0).ToString
    End Sub

End Class