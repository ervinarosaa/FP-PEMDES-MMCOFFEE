Imports System.Data.OracleClient

Public Class FormLandingPage
    Dim conn As New OracleConnection
    Dim cmd As New OracleCommand
    Dim dr As OracleDataReader

    Sub koneksi()
        conn = New OracleConnection("Data Source = XE; Persist Security Info=True; User Id=hr; Unicode=True; password=hr")
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        koneksi()
        If cb_login_as.Text = "Admin" Then
            'login admin
            Dim uname As String
            cmd = New OracleCommand("SELECT * FROM LOGINADM WHERE Username = '" &
                       tb_username.Text & "' AND Password = '" & tb_password.Text & "'", conn)
            dr = cmd.ExecuteReader()

            If (dr.Read() = True) Then
                MsgBox("Selamat Datang di Dashboard Admin")
                cb_login_as.ResetText()
                cb_login_as.ResetText()
                tb_username.Text = ""
                tb_password.Text = ""
                Me.Hide()
                FormAdmin.Show()
            Else
                MsgBox("Username/Password Salah!")
                cb_login_as.ResetText()
                tb_username.Text = ""
                tb_password.Text = ""
            End If
        ElseIf cb_login_as.Text = "Kasir" Then
            'login kasir
            Dim uname As String
            cmd = New OracleCommand("SELECT * FROM LOGINKSR WHERE Username = '" &
                       tb_username.Text & "' AND Password = '" & tb_password.Text & "'", conn)
            dr = cmd.ExecuteReader()

            If (dr.Read() = True) Then
                MsgBox("Selamat Datang di Dashboard Kasir")
                cb_login_as.ResetText()
                tb_username.Text = ""
                tb_password.Text = ""
                Me.Hide()
                FormDashboard.Show()
            Else
                MsgBox("Username/Password Salah!")
                cb_login_as.ResetText()
                tb_username.Text = ""
                tb_password.Text = ""
            End If
        End If
    End Sub

    Private Sub FormLandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class