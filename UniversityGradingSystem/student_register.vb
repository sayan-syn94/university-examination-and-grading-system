Public Class student_register
    Dim cnn, cnn1 As OleDb.OleDbConnection
    Dim cmd, cmd1 As New OleDb.OleDbCommand
    Dim rdr, rdr1 As OleDb.OleDbDataReader
    Dim sql, sql1 As String
    Dim sts = 0, gen_id = 0
    Private Sub bt_bck_Click(sender As Object, e As EventArgs) Handles bt_bck.Click
        Me.Close()
        student_login.Show()
    End Sub
    Private Sub student_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn1 = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn.Open()
        cnn1.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
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

    Private Sub TabPage1_bt_rst_Click(sender As Object, e As EventArgs) Handles bt_rst.Click
        tb_st_id.Text = ""
        tb_st_fname.Text = ""
        tb_st_mname.Text = ""
        tb_st_lname.Text = ""
        dtp_st_dob.Text = ""
        tb_st_email.Text = ""
        tb_st_mob.Text = ""
        tb_st_ladrs.Text = ""
        tb_st_padrs.Text = ""
        cb_st_sesn_strt.Text = ""
        cb_st_sesn_end.Text = ""
        tb_st_cllg.Text = ""
        cb_st_strm.Text = ""
        cb_st_sem.Text = ""
        lb_st_fsts.Text = "Record Cleared"
    End Sub

    Private Sub tb1_bt_sv_Click(sender As Object, e As EventArgs) Handles bt_sv.Click
        If gen_id = 0 Then
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO st_reg (first_name,mid_name,last_name,date_of_birth,email,mobile,l_address,p_address) VALUES ('" & Me.tb_st_fname.Text & "', '" & Me.tb_st_mname.Text & "', '" & Me.tb_st_lname.Text & "', '" & Me.dtp_st_dob.Text & "', '" & Me.tb_st_email.Text & "', '" & Me.tb_st_mob.Text & "', '" & Me.tb_st_ladrs.Text & "', '" & Me.tb_st_padrs.Text & "')"
            cmd.ExecuteNonQuery()
            Refresh()

            cmd.Connection = cnn
            sql = "SELECT st_id FROM st_reg WHERE mobile= '" & tb_st_mob.Text & "'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                MsgBox("Your Registration ID is " & rdr(0))
                tb_st_id.Text = rdr(0)
            End If
            Refresh()
            cnn.Close()
            lb_st_fsts.Text = "Record Updated"
            gen_id = 0
        End If
        If Not tb_st_id.Text = "" Then
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO st_academic (st_id, st_session, st_college, st_stream, st_semester, st_th1, st_th2, st_th3, st_th4, st_th5) VALUES (" & Me.tb_st_id.Text & ", '" & Me.cb_st_sesn_strt.Text & "', '" & Me.tb_st_cllg.Text & "', '" & Me.cb_st_strm.Text & "', '" & Me.cb_st_sem.Text & "', '" & Me.tb_st_th1.Text & "', '" & Me.tb_st_th2.Text & "', '" & Me.tb_st_th3.Text & "', '" & Me.tb_st_th4.Text & "', '" & Me.tb_st_th5.Text & "')"
            cmd.ExecuteNonQuery()
            Refresh()
            If cb_st_sem.Text = "1" Then
                cmd.CommandText = "INSERT INTO st_sem1 (st_id, m101, me101, hu101, es101, cs101) VALUES (" & Me.tb_st_id.Text & ", 0, 0, 0, 0, 0)"
                cmd.ExecuteNonQuery()
                Refresh()
            End If
            If cb_st_sem.Text = "2" Then
                cmd.CommandText = "INSERT INTO st_sem2 (st_id, m201, me201, hu201, es201, cs201) VALUES (" & Me.tb_st_id.Text & ", 0, 0, 0, 0, 0)"
                cmd.ExecuteNonQuery()
                Refresh()
            End If
            If cb_st_sem.Text = "3" Then
                cmd.CommandText = "INSERT INTO st_sem3 (st_id, m301, me301, hu301, es301, cs301) VALUES (" & Me.tb_st_id.Text & ", 0, 0, 0, 0, 0)"
                cmd.ExecuteNonQuery()
                Refresh()
            End If
            If cb_st_sem.Text = "4" Then
                cmd.CommandText = "INSERT INTO st_sem4 (st_id, m401, me401, hu401, es401, cs401) VALUES (" & Me.tb_st_id.Text & ", 0, 0, 0, 0, 0)"
                cmd.ExecuteNonQuery()
                Refresh()
            End If
            If cb_st_sem.Text = "5" Then
                cmd.CommandText = "INSERT INTO st_sem5 (st_id, m501, me501, hu501, es501, cs501) VALUES (" & Me.tb_st_id.Text & ", 0, 0, 0, 0, 0)"
                cmd.ExecuteNonQuery()
                Refresh()
            End If
            If cb_st_sem.Text = "6" Then
                cmd.CommandText = "INSERT INTO st_sem6 (st_id, m601, me601, hu601, es601, cs601) VALUES (" & Me.tb_st_id.Text & ", 0, 0, 0, 0, 0)"
                cmd.ExecuteNonQuery()
                Refresh()
            End If
            If cb_st_sem.Text = "7" Then
                cmd.CommandText = "INSERT INTO st_sem7 (st_id, m701, me701, hu701, es701, cs701) VALUES (" & Me.tb_st_id.Text & ", 0, 0, 0, 0, 0)"
                cmd.ExecuteNonQuery()
                Refresh()
            End If
            If cb_st_sem.Text = "8" Then
                cmd.CommandText = "INSERT INTO st_sem8 (st_id, m801, me801, hu801, es801, cs801) VALUES (" & Me.tb_st_id.Text & ", 0, 0, 0, 0, 0)"
                cmd.ExecuteNonQuery()
                Refresh()
            End If

            cnn.Close()
            tb_st_fname.Text = ""
            tb_st_mname.Text = ""
            tb_st_lname.Text = ""
            dtp_st_dob.Text = ""
            tb_st_email.Text = ""
            tb_st_mob.Text = ""
            tb_st_ladrs.Text = ""
            tb_st_padrs.Text = ""
            tb_st_id.Text = ""
            cb_st_sesn_strt.Text = ""
            cb_st_sesn_end.Text = ""
            tb_st_cllg.Text = ""
            cb_st_strm.Text = ""
            cb_st_sem.Text = ""
            lb_st_fsts.Text = "Record Updated"
        Else
            MsgBox("Fill Mandatory Fields")
        End If
    End Sub

    Private Sub TabPage2_click(sender As Object, e As EventArgs) Handles TabPage2.Click
        lb_st_fsts.Text = "Record Not Saved"
    End Sub

    Private Sub cb_st_sesn_strt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_st_sesn_strt.SelectedIndexChanged
        cb_st_sesn_end.Text = Val(cb_st_sesn_strt.Text) + 4
    End Sub

    Private Sub cb_st_sesn_end_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_st_sesn_end.SelectedIndexChanged
        cb_st_sesn_strt.Text = Val(cb_st_sesn_end.Text) - 4
    End Sub

    Private Sub tb_st_id_TextChanged(sender As Object, e As EventArgs) Handles tb_st_id.TextChanged
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        cmd.Connection = cnn
        sql = "SELECT st_id FROM st_reg"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        While rdr.Read = True
            If Not tb_st_id.Text = "" Then
                If tb_st_id.Text = rdr(0) Then
                    sts = 1
                    Exit While
                Else
                    sts = -1
                End If
            Else
                sts = 0
            End If
        End While

        If sts = -1 Then
            lb_st_fsts.Text = "Please register student first"
        ElseIf sts = 1 Then
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If

            cmd1.Connection = cnn1
            sql1 = "SELECT first_name, mid_name, last_name, date_of_birth, email, mobile, l_address, p_address FROM st_reg WHERE st_id=" & tb_st_id.Text & ""
            cmd1 = New OleDb.OleDbCommand(sql1, cnn1)
            rdr1 = cmd1.ExecuteReader
            If rdr1.Read = True Then
                tb_st_fname.Text = rdr1(0)
                tb_st_mname.Text = rdr1(1)
                tb_st_lname.Text = rdr1(2)
                dtp_st_dob.Text = rdr1(3)
                tb_st_email.Text = rdr1(4)
                tb_st_mob.Text = rdr1(5)
                tb_st_ladrs.Text = rdr1(6)
                tb_st_padrs.Text = rdr1(7)
                lb_st_fsts.Text = "Student ID Found"
            End If
            Refresh()

            cmd1.Connection = cnn1
            sql1 = "SELECT st_session, st_college, st_stream FROM st_academic WHERE st_id=" & tb_st_id.Text & ""
            cmd1 = New OleDb.OleDbCommand(sql1, cnn1)
            rdr1 = cmd1.ExecuteReader
            If rdr1.Read = True Then
                cb_st_sesn_strt.Text = rdr1(0)
                tb_st_cllg.Text = rdr1(1)
                cb_st_strm.Text = rdr1(2)
            End If
            Refresh()
            cnn1.Close()
            gen_id = 1
        End If

        Refresh()
        cnn.Close()
    End Sub
End Class