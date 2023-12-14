Imports System.Data.OracleClient

Public Class FormTransaksi

    Dim cn As New OracleConnection
    Dim da As New OracleDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OracleCommand
    Dim dr As OracleDataReader
    Dim dt As New DataTable
    Dim kopi1, kopi2, notr, StokID, JMLMASUK As Integer
    Dim Ket As String

    Sub koneksi()
        cn = New OracleConnection("Data Source = XE; Persist Security Info=True; User Id=hr; Unicode=True; password=hr")
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        FormDashboard.Show()
    End Sub

    Private Sub btnReportCashier_Click(sender As Object, e As EventArgs) Handles btnReportCashier.Click
        Me.Hide()
        FormLaporanCashier.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        FormLandingPage.Show()
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.BRG' table. You can move, or remove it, as needed.
        Me.BRGTableAdapter.Fill(Me.DataSet3.BRG)
        'TODO: This line of code loads data into the 'Mmcoffeefix.MMCOFFEE' table. You can move, or remove it, as needed.
        Me.MMCOFFEETableAdapter1.Fill(Me.Mmcoffeefix.MMCOFFEE)
        notr = 20222201
        kopi1 = 0
        kopi2 = 0

        koneksi()
        ComboBoxCoffee.Text = "Select Coffee"

        tbKodeTrans.Text = notr
        wkt.Text = TimeOfDay
        tbKodeTrans.Enabled = False
        wkt.Enabled = False

        cmd = New OracleCommand("select stok_produk from brg where id_produk = 101", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbStkJ.Text = dr!stok_produk

        cmd = New OracleCommand("select stok_produk from brg where id_produk = 102", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        tbStkR.Text = dr!stok_produk
    End Sub

    Private Sub ComboBoxCoffee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCoffee.SelectedIndexChanged
        koneksi()
        cmd = New OracleCommand("select * from brg where id_produk = '" & Microsoft.VisualBasic.Left(ComboBoxCoffee.Text, 6) & "'", cn)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            tbNamaBrg.Text = dr!namaproduk
            tbHargaBrg.Text = dr!harga_satuan
        End If
    End Sub

    Private Sub btnSmpn_Click(sender As Object, e As EventArgs) Handles btnSmpn.Click
        tbTotal.Text = Val(tbTotal.Text) + Val(tbSubTtl.Text)
        tbPenghasilan.Text = Val(tbPenghasilan.Text) + Val(tbSubTtl.Text)

        If ComboBoxCoffee.Text = 101 Then
            kopi1 += Val(nudJml.Text)
        ElseIf ComboBoxCoffee.Text = 102 Then
            kopi2 += Val(nudJml.Text)
        End If

        cmd = New OracleCommand("insert into invoice values ('" & tbKodeTrans.Text & "', '" & DateTimePicker1.Text & "','" & ComboBoxCoffee.Text & "', '" & tbNamaBrg.Text & "', '" & tbHargaBrg.Text & "', '" & nudJml.Text & "', '" & tbSubTtl.Text & "')", cn)
        dr = cmd.ExecuteReader

        ListView1.Items.Clear()

        cmd = New OracleCommand("select kdbrg, nmbrg, hrgbrg, jumlah, subtotal from invoice", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub nudJml_KeyDown(sender As Object, e As KeyEventArgs) Handles nudJml.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbSubTtl.Text = Val(tbHargaBrg.Text) * Val(nudJml.Text)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ComboBoxCoffee.Text = ""
        tbNamaBrg.Text = ""
        tbHargaBrg.Text = ""
        nudJml.Text = ""
        tbSubTtl.Text = ""
    End Sub

    Private Sub tbBayar_KeyDown(sender As Object, e As KeyEventArgs) Handles tbBayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(tbBayar.Text) < Val(tbTotal.Text) Then
                MsgBox("Uang Anda Kurang", vbInformation + vbOKOnly, "Informasi")
                Exit Sub

            Else
                tbKembalian.Text = Val(tbBayar.Text) - Val(tbTotal.Text)
            End If
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If tbCari.Text = "" Then
            MsgBox("Mohon isi textbox terlebih dahulu")
        Else
            ListView1.Items.Clear()

            cmd = New OracleCommand("select kdbrg, nmbrg, hrgbrg, jumlah, subtotal from invoice where kdbrg = '" & tbCari.Text & "'", cn)
            dr = cmd.ExecuteReader()

            If dr.HasRows = True Then
                While dr.Read()
                    ListView1.Items.Add(dr.Item(0))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4))
                End While
                dr.Close()
            End If
            dr.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub btnBatalPesan_Click(sender As Object, e As EventArgs) Handles btnBatalPesan.Click

        cmd = New OracleCommand("delete laporansatuan where notransaksisat = '" & tbKodeTrans.Text & "'", cn)
        cmd.ExecuteNonQuery()

        cmd = New OracleCommand("delete invoice", cn)
        cmd.ExecuteNonQuery()

        ListView1.Items.Clear()
        cmd = New OracleCommand("select kdbrg, nmbrg, hrgbrg, jumlah, subtotal from invoice", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()

        ComboBoxCoffee.Text = ""
        tbNamaBrg.Text = ""
        tbHargaBrg.Text = ""
        nudJml.Text = ""
        tbSubTtl.Text = ""

        tbTotal.Text = ""
        tbBayar.Text = ""
        tbKembalian.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        cmd = New OracleCommand("delete laporansatuan where notransaksisat = '" & tbKodeTrans.Text & "' AND namabarangsat = '" & tbNamaBrg.Text & "'", cn)
        cmd.ExecuteNonQuery()

        cmd = New OracleCommand("delete invoice where kdbrg = '" & ComboBoxCoffee.Text & "'", cn)
        cmd.ExecuteNonQuery()

        ListView1.Items.Clear()

        cmd = New OracleCommand("select kdbrg, nmbrg, hrgbrg, jumlah, subtotal from invoice", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ListView1.Items.Clear()

        cmd = New OracleCommand("select kdbrg, nmbrg, hrgbrg, jumlah, subtotal from invoice", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                ListView1.Items.Add(dr.Item(0))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4))
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs) Handles btnKonfirmasi.Click
        For i As Integer = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(0).Text = "101" Then
                cmd = New OracleCommand("insert into laporansatuan values ('" & tbKodeTrans.Text & "', '" & ListView1.Items(i).SubItems(1).Text & "', '" &
                                        ListView1.Items(i).SubItems(3).Text & "', '" & ListView1.Items(i).SubItems(4).Text & "', '" & DateTimePicker1.Text & "')", cn)
                cmd.ExecuteNonQuery()

                tbStkJ.Text = Val(tbStkJ.Text) - Val(nudJml.Text)
                cmd = New OracleCommand("update brg set stok_produk = '" & tbStkJ.Text & "' where id_produk = 101", cn)
                cmd.ExecuteNonQuery()

                cmd = New OracleCommand("select count (*) ID_STOK from STOKBRG", cn)
                dr = cmd.ExecuteReader()
                If (dr.Read() = True) Then
                    StokID = dr("ID_STOK") + 1
                End If
                Ket = "Penjualan"
                JMLMASUK = 0
                cmd = New OracleCommand("insert into STOKBRG values (" & StokID & ",'" & DateTimePicker1.Value.ToShortDateString & "','101'," &
                                         "'" & ListView1.Items(i).SubItems(1).Text & "'," & JMLMASUK & "," & CInt(ListView1.Items(i).SubItems(3).Text) & ",'" & Ket & "')", cn)
                cmd.ExecuteNonQuery()

            ElseIf ListView1.Items(i).SubItems(0).Text = "102" Then
                cmd = New OracleCommand("insert into laporansatuan values ('" & tbKodeTrans.Text & "', '" & ListView1.Items(i).SubItems(1).Text & "', '" &
                                        ListView1.Items(i).SubItems(3).Text & "', '" & ListView1.Items(i).SubItems(4).Text & "', '" & DateTimePicker1.Text & "')", cn)
                cmd.ExecuteNonQuery()

                tbStkR.Text = Val(tbStkR.Text) - Val(nudJml.Text)
                cmd = New OracleCommand("update brg set stok_produk = '" & tbStkR.Text & "' where id_produk = 102", cn)
                cmd.ExecuteNonQuery()

                cmd = New OracleCommand("select count (*) ID_STOK from STOKBRG", cn)
                dr = cmd.ExecuteReader()
                If (dr.Read() = True) Then
                    StokID = dr("ID_STOK") + 1
                End If
                Ket = "Penjualan"
                JMLMASUK = 0
                cmd = New OracleCommand("insert into STOKBRG values (" & StokID & ",'" & DateTimePicker1.Value.ToShortDateString & "','102'," &
                                         "'" & ListView1.Items(i).SubItems(1).Text & "'," & JMLMASUK & "," & CInt(ListView1.Items(i).SubItems(3).Text) & ",'" & Ket & "')", cn)
                cmd.ExecuteNonQuery()
            End If
        Next

        ListView1.Items.Clear()

        notr += 1
        tbKodeTrans.Text = notr

        ComboBoxCoffee.Text = ""
        tbNamaBrg.Text = ""
        tbHargaBrg.Text = ""
        nudJml.Text = ""
        tbSubTtl.Text = ""
        tbTotal.Text = ""
        tbBayar.Text = ""
        tbKembalian.Text = ""

        Me.Hide()
        FormKonfirmasi.Show()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            ComboBoxCoffee.Text = ListView1.SelectedItems(0).SubItems(0).Text
            tbNamaBrg.Text = ListView1.SelectedItems(0).SubItems(1).Text
            tbHargaBrg.Text = ListView1.SelectedItems(0).SubItems(2).Text
            nudJml.Text = ListView1.SelectedItems(0).SubItems(3).Text
            tbSubTtl.Text = ListView1.SelectedItems(0).SubItems(4).Text
        End If
    End Sub
End Class