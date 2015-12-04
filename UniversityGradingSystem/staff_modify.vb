Public Class staff_modify
    Dim cnn, cnn1 As New OleDb.OleDbConnection
    Dim cmd, cmd1 As New OleDb.OleDbCommand
    Dim rdr, rdr1 As OleDb.OleDbDataReader
    Dim sql, sql1, pswrd As String
    Dim sts = 0
    Private Sub bt_mod_st_del_Click(sender As Object, e As EventArgs) Handles bt_mod_stf_del.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        pswrd = InputBox("Input Admin Password", Title:="Admin Access Required").ToString
        If pswrd = "root" Then
            cmd.Connection = cnn
            cmd.CommandText = "DELETE * FROM stf_reg WHERE stf_id=" & Me.tb_stf_id.Text & ""
            cmd.ExecuteNonQuery()
            Refresh()
            cnn.Close()
            lb_stf_mod_fsts.Text = "Record Deleted"
            tb_stf_id.Text = ""
            tb_stf_fname.Text = ""
            tb_stf_mname.Text = ""
            tb_stf_lname.Text = ""
            dtp_stf_dob.Text = ""
            tb_stf_mjr.Text = ""
            tb_stf_email.Text = ""
            tb_stf_mob.Text = ""
            tb_stf_ladrs.Text = ""
            tb_stf_padrs.Text = ""
            tb_stf_id.Focus()
        End If
        cnn.Close()
    End Sub

    Private Sub staff_modify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gb_mod_stf.Visible = False

        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"

        cnn1 = New OleDb.OleDbConnection
        cnn1.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"

        cnn.Open()
        If cnn.State = ConnectionState.Open Then
            lb_stf_mod_csts.Text = "Connection Available"
            lb_stf_mod_fsts.Text = "Record Not Saved"
            gb_mod_stf.Visible = True
            cnn.Close()
        Else
            lb_stf_mod_csts.Text = "Connection Not Available"
            cnn.Close()
            lb_stf_mod_fsts.Text = "Record Not Saved"
        End If
        tb_stf_id.Focus()
    End Sub

    Private Sub tb_stf_id_TextChanged(sender As Object, e As EventArgs) Handles tb_stf_id.TextChanged

    End Sub

    Private Sub bt_mod_st_rst_Click(sender As Object, e As EventArgs) Handles bt_mod_st_rst.Click

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
            MessageBox.Show("Required Field Missing", "Enter Staff ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf sts = 1 Then
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            sql = "SELECT first_name, mid_name, last_name, date_of_birth, major, email, mobile, l_address, p_address FROM stf_reg WHERE stf_id=" & tb_stf_id.Text
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_stf_fname.Text = rdr(0)
                tb_stf_mname.Text = rdr(1)
                tb_stf_lname.Text = rdr(2)
                dtp_stf_dob.Text = rdr(3)
                tb_stf_mjr.Text = rdr(4)
                tb_stf_email.Text = rdr(5)
                tb_stf_mob.Text = rdr(6)
                tb_stf_ladrs.Text = rdr(7)
                tb_stf_padrs.Text = rdr(8)
            End If
            Refresh()
            cnn.Close()
            tb_stf_id.Enabled = False
            lb_stf_mod_fsts.Text = "Record Fetched"
        ElseIf sts = -2 Then
            MessageBox.Show("Invalid Staff ID, Please register", "Enter Staff ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Refresh()
        cnn1.Close()
    End Sub

    Private Sub bt_mod_st_bck_Click(sender As Object, e As EventArgs) Handles bt_mod_st_bck.Click
        Me.Close()
        admin_main.Show()
    End Sub

    Private Sub bt_mod_st_sv_Click(sender As Object, e As EventArgs) Handles bt_mod_st_sv.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd.Connection = cnn
        sql = "UPDATE stf_reg SET first_name= '" & tb_stf_fname.Text & "', last_name= '" & tb_stf_lname.Text & "', date_of_birth= '" & dtp_stf_dob.Text & "', email= '" & tb_stf_email.Text & "', mobile= '" & tb_stf_mob.Text & "', l_address= '" & tb_stf_ladrs.Text & "', p_address= '" & tb_stf_padrs.Text & "' WHERE stf_id=" & tb_stf_id.Text & ""
        cmd = New OleDb.OleDbCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        Refresh()

        cnn.Close()
    End Sub
End Class