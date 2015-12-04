Public Class student_modify
    Dim cnn As OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim rdr As OleDb.OleDbDataReader
    Dim sql, pswrd As String
    Private Sub student_modify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn.Open()
        If cnn.State = ConnectionState.Open Then
            lb_st_csts.Text = "Connection Available"
            lb_st_fsts.Text = "Record Not Saved"
            tc_st.Visible = True
            cnn.Close()
        Else
            lb_st_csts.Text = "Connection Not Available"
            cnn.Close()
            lb_st_fsts.Text = "Record Not Saved"
        End If
        tb_st_id.Focus()
    End Sub

    Private Sub bt_bck_Click(sender As Object, e As EventArgs) Handles bt_bck.Click
        Me.Close()
        admin_main.Show()
    End Sub

    Private Sub bt_rst_Click(sender As Object, e As EventArgs) Handles bt_rst.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        cmd.Connection = cnn
        sql = "SELECT first_name, mid_name, last_name, date_of_birth, email, mobile, l_address, p_address FROM st_reg WHERE st_id=" & tb_st_id.Text & ""
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            tb_st_fname.Text = rdr(0)
            tb_st_mname.Text = rdr(1)
            tb_st_lname.Text = rdr(2)
            dtp_st_dob.Text = rdr(3)
            tb_st_email.Text = rdr(4)
            tb_st_mob.Text = rdr(5)
            tb_st_ladrs.Text = rdr(6)
            tb_st_padrs.Text = rdr(7)
        End If
        Refresh()

        cmd.Connection = cnn
        sql = "SELECT st_session, st_college, st_stream, st_semester FROM st_academic WHERE st_id=" & tb_st_id.Text & ""
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            cb_st_ssn_strt.Text = rdr(0)
            cb_st_ssn_end.Text = Val(cb_st_ssn_strt.Text) + 4
            tb_st_cllg.Text = rdr(1)
            cb_st_strm.Text = rdr(2)
            cb_st_sem.Text = rdr(3)
        End If
        Refresh()

        cnn.Close()
        tb_st_id.Focus()
        lb_st_fsts.Text = "Record Fetched"
    End Sub

    Private Sub bt_st_del_Click(sender As Object, e As EventArgs) Handles bt_st_del.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        pswrd = InputBox("Input Admin Password", Title:="Admin Access Required").ToString
        If pswrd = "root" Then
            cmd.Connection = cnn
            cmd.CommandText = "DELETE * FROM st_reg WHERE st_id=" & Me.tb_st_id.Text & ""
            cmd.ExecuteNonQuery()
            Refresh()

            cmd.Connection = cnn
            cmd.CommandText = "DELETE * FROM st_academic WHERE st_id=" & Me.tb_st_id.Text & ""
            cmd.ExecuteNonQuery()
            Refresh()

            cnn.Close()
            lb_st_fsts.Text = "Record Deleted"
            tb_st_id.Text = ""
            tb_st_fname.Text = ""
            tb_st_mname.Text = ""
            tb_st_lname.Text = ""
            dtp_st_dob.Text = ""
            tb_st_email.Text = ""
            tb_st_mob.Text = ""
            tb_st_ladrs.Text = ""
            tb_st_padrs.Text = ""
            tb_st_id.Focus()
        End If
        cnn.Close()
    End Sub

    Private Sub bt_sv_Click(sender As Object, e As EventArgs) Handles bt_sv.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd.Connection = cnn
        sql = "UPDATE st_reg SET first_name= '" & tb_st_fname.Text & "', last_name= '" & tb_st_lname.Text & "', date_of_birth= '" & dtp_st_dob.Text & "', email= '" & tb_st_email.Text & "', mobile= '" & tb_st_mob.Text & "', l_address= '" & tb_st_ladrs.Text & "', p_address= '" & tb_st_padrs.Text & "' WHERE st_id=" & tb_st_id.Text & ""
        cmd = New OleDb.OleDbCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        Refresh()

        cmd.Connection = cnn
        sql = "UPDATE st_academic SET st_session= '" & cb_st_ssn_strt.Text & "', st_college= '" & tb_st_cllg.Text & "', st_stream= '" & cb_st_strm.Text & "', st_semester= '" & cb_st_sem.Text & "' WHERE st_id=" & tb_st_id.Text & ""
        cmd = New OleDb.OleDbCommand(sql, cnn)
        cmd.ExecuteNonQuery()
        Refresh()

        cnn.Close()
        tb_st_id.Focus()
        lb_st_fsts.Text = "Record Updated"
    End Sub
End Class