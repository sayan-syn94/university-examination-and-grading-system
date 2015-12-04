Public Class staff_login
    Dim cnn, cnn1 As New OleDb.OleDbConnection
    Dim cmd, cmd1 As New OleDb.OleDbCommand
    Dim rdr, rdr1 As OleDb.OleDbDataReader
    Dim sql, sql1, entrpswrd, pswrd As String
    Dim sts = 0
    Private Sub staff_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn1 = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn1.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        tb_stf_id.Focus()
    End Sub
    Private Sub bt_staff_login_Click(sender As Object, e As EventArgs) Handles bt_staff_login.Click
        If cnn1.State = ConnectionState.Closed Then
            cnn1.Open()
        End If
        cmd1.Connection = cnn1
        sql1 = "SELECT stf_id FROM stf_reg"
        cmd1 = New OleDb.OleDbCommand(sql1, cnn1)
        rdr1 = cmd1.ExecuteReader
        While rdr1.Read = True
            If tb_stf_id.Text = "" Then
                sts = -1
            ElseIf tb_stf_id.Text = rdr1(0) Then
                sts = 1
                Exit While
            Else
                sts = -2
            End If
        End While

        If sts = -1 Then
            MessageBox.Show("Please enter Staff ID", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf sts = 1 Then
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            sql = "SELECT stf_password FROM stf_security WHERE stf_id=" & tb_stf_id.Text & ""
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                If mb_stf_pswrd.Text = rdr(0) Then
                    Me.Hide()
                    staff_main.lb_stf_id.Text = tb_stf_id.Text
                    tb_stf_id.Text = ""
                    mb_stf_pswrd.Text = ""
                    staff_main.Show()
                    Me.Close()
                ElseIf mb_stf_pswrd.Text = "" Then
                    MessageBox.Show("Please Enter Password!", "Password Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    mb_stf_pswrd.Text = ""
                    MessageBox.Show("Wrong Password!", "Password Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            cnn.Close()
        Else
            MessageBox.Show("Invalid Staff ID, Please register", "Registration Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Refresh()
        cnn1.Close()
    End Sub

    Private Sub bt_staff_back_Click(sender As Object, e As EventArgs) Handles bt_staff_back.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub bt_sgn_up_Click(sender As Object, e As EventArgs) Handles bt_sgn_up.Click
        Me.Close()
        staff_register.Show()
    End Sub

    Private Sub ll_stf_pswrd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_stf_pswrd.LinkClicked
        Me.Close()
        staff_pswrd_rst.Show()
    End Sub
End Class