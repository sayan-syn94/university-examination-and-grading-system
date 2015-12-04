Imports System.Data.OleDb

Public Class admin_main
    Dim cnn, cnn1, cnn2 As New OleDb.OleDbConnection
    Dim cmd, cmd1, cmd2 As New OleDb.OleDbCommand
    Dim rdr, rdr1, rdr2 As OleDb.OleDbDataReader
    Dim sql, sql1, sql2 As String
    Dim m, mec, hu, es, cs, res As Integer
    Dim th1, th2, th3, th4, th5, st_id, th1_p, th2_p, th3_p, th4_p, th5_p, th_cr, total_cr, th1_cp, th2_cp, th3_cp, th4_cp, th5_cp, total_cp, cgpa
    Dim th1_l, th2_l, th3_l, th4_l, th5_l, st_sem As String
    Private Sub admin_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn1 = New OleDb.OleDbConnection
        cnn1.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn2 = New OleDb.OleDbConnection
        cnn2.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"

        cnn.Open()
        If cnn.State = ConnectionState.Open Then
            lb_adm_csts.Text = "Connection Available"
        Else
            lb_adm_csts.Text = "Connection Not Available"
        End If

        sql = "SELECT vl FROM cfg WHERE rgstry= 'Mathematics'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            m = rdr(0)
        End If

        sql = "SELECT vl FROM cfg WHERE rgstry= 'Computer Science'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            cs = rdr(0)
        End If

        sql = "SELECT vl FROM cfg WHERE rgstry= 'Mechanics'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            mec = rdr(0)
        End If

        sql = "SELECT vl FROM cfg WHERE rgstry= 'English'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            hu = rdr(0)
        End If

        sql = "SELECT vl FROM cfg WHERE rgstry= 'Electronics'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            es = rdr(0)
        End If

        sql = "SELECT vl FROM cfg WHERE rgstry= 'generate_res'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            res = rdr(0)
        End If

        If m = 0 And mec = 0 And hu = 0 And es = 0 And cs = 0 Then
            bt_gen_reslt.Enabled = False
        End If

        If res = 1 Then
            bt_gen_reslt.Enabled = False
        End If

        cnn.Close()
    End Sub

    Private Sub bt_admin_logout_Click(sender As Object, e As EventArgs) Handles bt_admin_logout.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub bt_del_st_db_Click(sender As Object, e As EventArgs) Handles bt_del_st_db.Click
        Dim pswrd As String
        pswrd = InputBox("Input Admin Password to delete Student Database", Title:="Admin Access Required").ToString
        If pswrd = "root" Then
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            cmd.CommandText = "DELETE * FROM st_reg"
            cmd.ExecuteNonQuery()
            Refresh()
            cmd.CommandText = "DELETE * FROM st_academic"
            cmd.ExecuteNonQuery()
            Refresh()
            cmd.CommandText = "DELETE * FROM st_sem1"
            cmd.ExecuteNonQuery()
            Refresh()
            cmd.CommandText = "DELETE * FROM st_sem2"
            cmd.ExecuteNonQuery()
            Refresh()
            cmd.CommandText = "DELETE * FROM st_sem3"
            cmd.ExecuteNonQuery()
            Refresh()
            cmd.CommandText = "DELETE * FROM st_sem4"
            cmd.ExecuteNonQuery()
            Refresh()
            cmd.CommandText = "DELETE * FROM st_sem5"
            cmd.ExecuteNonQuery()
            Refresh()
            cmd.CommandText = "DELETE * FROM st_sem6"
            cmd.ExecuteNonQuery()
            Refresh()
            cmd.CommandText = "DELETE * FROM st_sem7"
            cmd.ExecuteNonQuery()
            Refresh()
            cmd.CommandText = "DELETE * FROM st_sem8"
            cmd.ExecuteNonQuery()
            Refresh()
            cnn.Close()
            lb_adm_fsts.Text = "Student Records Cleared"
        End If
    End Sub

    Private Sub bt_del_stf_db_Click(sender As Object, e As EventArgs) Handles bt_del_stf_db.Click
        Dim pswrd As String
        pswrd = InputBox("Input Admin Password to delete Staff Database", Title:="Admin Access Required").ToString
        If pswrd = "root" Then
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            cmd.CommandText = "DELETE * FROM stf_reg"
            cmd.ExecuteNonQuery()
            Refresh()
            Dim res = MessageBox.Show("Security Database will also be cleared", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If res = Windows.Forms.DialogResult.OK Then
                cmd.CommandText = "DELETE * FROM stf_security"
                cmd.ExecuteNonQuery()
                Refresh()
            End If
            lb_adm_fsts.Text = "Staff Records cleared"
            cnn.Close()
        End If
    End Sub

    Private Sub bt_mod_stf_Click(sender As Object, e As EventArgs) Handles bt_mod_stf.Click
        Me.Hide()
        staff_modify.Show()
    End Sub

    Private Sub bt_mod_st_Click(sender As Object, e As EventArgs) Handles bt_mod_st.Click
        Me.Hide()
        student_modify.Show()
    End Sub

    Private Sub bt_gen_reslt_Click(sender As Object, e As EventArgs) Handles bt_gen_reslt.Click
        Dim res = MessageBox.Show("Do you want to generate Student Result?", "Result Generation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = Windows.Forms.DialogResult.Yes Then
            cnn.Open()
            cmd.Connection = cnn
            sql = "SELECT st_id, st_semester FROM st_academic"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader()
            While rdr.Read = True
                st_id = rdr(0)
                st_sem = rdr(1)
                cnn1.Open()
                cmd1.Connection = cnn1
                If st_sem = "1" Then
                    sql1 = "SELECT m101, me101, hu101, es101, cs101 FROM st_sem1 WHERE st_id=" & st_id
                ElseIf st_sem = "2" Then
                    sql1 = "SELECT m201, me201, hu201, es201, cs201 FROM st_sem2 WHERE st_id=" & st_id
                ElseIf st_sem = "3" Then
                    sql1 = "SELECT m301, me301, hu301, es301, cs301 FROM st_sem3 WHERE st_id=" & st_id
                ElseIf st_sem = "4" Then
                    sql1 = "SELECT m401, me401, hu401, es401, cs401 FROM st_sem4 WHERE st_id=" & st_id
                ElseIf st_sem = "5" Then
                    sql1 = "SELECT m501, me501, hu501, es501, cs501 FROM st_sem5 WHERE st_id=" & st_id
                ElseIf st_sem = "6" Then
                    sql1 = "SELECT m601, me601, hu601, es601, cs601 FROM st_sem6 WHERE st_id=" & st_id
                ElseIf st_sem = "7" Then
                    sql1 = "SELECT m701, me701, hu701, es701, cs701 FROM st_sem7 WHERE st_id=" & st_id
                ElseIf st_sem = "8" Then
                    sql1 = "SELECT m801, me801, hu801, es801, cs801 FROM st_sem8 WHERE st_id=" & st_id
                End If
                cmd1 = New OleDb.OleDbCommand(sql1, cnn1)
                rdr1 = cmd1.ExecuteReader()
                If rdr1.Read = True Then
                    th1 = rdr1(0)
                    th2 = rdr1(1)
                    th3 = rdr1(2)
                    th4 = rdr1(3)
                    th5 = rdr1(4)
                End If

                If th1 < 100 And th1 > 90 Then
                    th1_l = "O"
                ElseIf th1 < 90 And th1 > 80 Then
                    th1_l = "E"
                ElseIf th1 < 80 And th1 > 70 Then
                    th1_l = "A"
                ElseIf th1 < 70 And th1 > 60 Then
                    th1_l = "B"
                ElseIf th1 < 60 And th1 > 50 Then
                    th1_l = "C"
                ElseIf th1 < 50 And th1 > 40 Then
                    th1_l = "D"
                ElseIf th1 < 40 And th1 > 0 Then
                    th1_l = "F"
                End If

                If th2 < 100 And th2 > 90 Then
                    th2_l = "O"
                ElseIf th2 < 90 And th2 > 80 Then
                    th2_l = "E"
                ElseIf th2 < 80 And th2 > 70 Then
                    th2_l = "A"
                ElseIf th2 < 70 And th2 > 60 Then
                    th2_l = "B"
                ElseIf th2 < 60 And th2 > 50 Then
                    th2_l = "C"
                ElseIf th2 < 50 And th2 > 40 Then
                    th2_l = "D"
                ElseIf th2 < 40 And th2 > 0 Then
                    th2_l = "F"
                End If

                If th3 < 100 And th3 > 90 Then
                    th3_l = "O"
                ElseIf th3 < 90 And th3 > 80 Then
                    th3_l = "E"
                ElseIf th3 < 80 And th3 > 70 Then
                    th3_l = "A"
                ElseIf th3 < 70 And th3 > 60 Then
                    th3_l = "B"
                ElseIf th3 < 60 And th3 > 50 Then
                    th3_l = "C"
                ElseIf th3 < 50 And th3 > 40 Then
                    th3_l = "D"
                ElseIf th3 < 40 And th3 > 0 Then
                    th3_l = "F"
                End If

                If th4 < 100 And th4 > 90 Then
                    th4_l = "O"
                ElseIf th4 < 90 And th4 > 80 Then
                    th4_l = "E"
                ElseIf th4 < 80 And th4 > 70 Then
                    th4_l = "A"
                ElseIf th4 < 70 And th4 > 60 Then
                    th4_l = "B"
                ElseIf th4 < 60 And th4 > 50 Then
                    th4_l = "C"
                ElseIf th4 < 50 And th4 > 40 Then
                    th4_l = "D"
                ElseIf th4 < 40 And th4 > 0 Then
                    th4_l = "F"
                End If

                If th5 < 100 And th5 > 90 Then
                    th5_l = "O"
                ElseIf th5 < 90 And th5 > 80 Then
                    th5_l = "E"
                ElseIf th5 < 80 And th5 > 70 Then
                    th5_l = "A"
                ElseIf th5 < 70 And th5 > 60 Then
                    th5_l = "B"
                ElseIf th5 < 60 And th5 > 50 Then
                    th5_l = "C"
                ElseIf th5 < 50 And th5 > 40 Then
                    th5_l = "D"
                ElseIf th5 < 40 And th5 > 0 Then
                    th5_l = "F"
                End If


                If th1_l = "O" Then
                    th1_p = "10"
                ElseIf th1_l = "E" Then
                    th1_p = "9"
                ElseIf th1_l = "A" Then
                    th1_p = "8"
                ElseIf th1_l = "B" Then
                    th1_p = "7"
                ElseIf th1_l = "C" Then
                    th1_p = "6"
                ElseIf th1_l = "D" Then
                    th1_p = "5"
                ElseIf th1_l = "F" Then
                    th1_p = "2"
                End If

                If th2_l = "O" Then
                    th2_p = "10"
                ElseIf th2_l = "E" Then
                    th2_p = "9"
                ElseIf th2_l = "A" Then
                    th2_p = "8"
                ElseIf th2_l = "B" Then
                    th2_p = "7"
                ElseIf th2_l = "C" Then
                    th2_p = "6"
                ElseIf th2_l = "D" Then
                    th2_p = "5"
                ElseIf th2_l = "F" Then
                    th2_p = "2"
                End If

                If th3_l = "O" Then
                    th3_p = "10"
                ElseIf th3_l = "E" Then
                    th3_p = "9"
                ElseIf th3_l = "A" Then
                    th3_p = "8"
                ElseIf th3_l = "B" Then
                    th3_p = "7"
                ElseIf th3_l = "C" Then
                    th3_p = "6"
                ElseIf th3_l = "D" Then
                    th3_p = "5"
                ElseIf th3_l = "F" Then
                    th3_p = "2"
                End If

                If th4_l = "O" Then
                    th4_p = "10"
                ElseIf th4_l = "E" Then
                    th4_p = "9"
                ElseIf th4_l = "A" Then
                    th4_p = "8"
                ElseIf th4_l = "B" Then
                    th4_p = "7"
                ElseIf th4_l = "C" Then
                    th4_p = "6"
                ElseIf th4_l = "D" Then
                    th4_p = "5"
                ElseIf th4_l = "F" Then
                    th4_p = "2"
                End If

                If th5_l = "O" Then
                    th5_p = "10"
                ElseIf th5_l = "E" Then
                    th5_p = "9"
                ElseIf th5_l = "A" Then
                    th5_p = "8"
                ElseIf th5_l = "B" Then
                    th5_p = "7"
                ElseIf th5_l = "C" Then
                    th5_p = "6"
                ElseIf th5_l = "D" Then
                    th5_p = "5"
                ElseIf th5_l = "F" Then
                    th5_p = "2"
                End If

                th_cr = 4
                total_cr = 20

                th1_cp = th1_p * th_cr
                th2_cp = th2_p * th_cr
                th3_cp = th3_p * th_cr
                th4_cp = th4_p * th_cr
                th5_cp = th5_p * th_cr

                total_cr = th_cr + th_cr + th_cr + th_cr + th_cr
                total_cp = th1_cp + th2_cp + th3_cp + th4_cp + th5_cp

                cgpa = total_cp / total_cr

                cnn2.Open()
                cmd2.Connection = cnn2
                cmd2.CommandText = "INSERT INTO st_marksheet (st_id, st_semester, th1, th2, th3, th4, th5, th1_l, th2_l, th3_l, th4_l, th5_l, th1_p, th2_p, th3_p, th4_p, th5_p, th1_cp, th2_cp, th3_cp, th4_cp, th5_cp, total_cp, cgpa) VALUES (" & Val(st_id) & ", '" & Val(st_sem) & "', '" & Val(th1) & "', '" & Val(th2) & "', '" & Val(th3) & "', '" & Val(th4) & "', '" & Val(th5) & "', '" & th1_l & "', '" & th2_l & "', '" & th3_l & "', '" & th4_l & "', '" & th5_l & "', '" & Val(th1_p) & "', '" & Val(th2_p) & "', '" & Val(th3_p) & "', '" & Val(th4_p) & "', '" & Val(th5_p) & "'   , '" & Val(th1_cp) & "', '" & Val(th2_cp) & "', '" & Val(th3_cp) & "', '" & Val(th4_cp) & "', '" & Val(th5_cp) & "', '" & Val(total_cp) & "', '" & Val(cgpa) & "')"
                cmd2.ExecuteNonQuery()
                Refresh()
                cnn2.Close()
                Refresh()
                cnn1.Close()
            End While
            Refresh()
            cnn.Close()

            cnn.Open()
            cmd.Connection = cnn
            sql = "UPDATE cfg SET vl= 1 WHERE rgstry= 'generate_res'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            Refresh()
            bt_gen_reslt.Enabled = False
            lb_adm_fsts.Text = "Result Generated"
            cnn.Close()

        ElseIf res = Windows.Forms.DialogResult.No Then
            lb_adm_fsts.Text = "Result Generation Aborted"
        End If
    End Sub

    Private Sub bt_adm_cfg_Click(sender As Object, e As EventArgs) Handles bt_adm_cfg.Click
        Me.Close()
        Dim res = MessageBox.Show("Please Edit Carefully. Wrong Entry might lead to system failure", "Configuration File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If res = Windows.Forms.DialogResult.OK Then
            admin_cfg_edit.Show()
        End If
    End Sub

    Private Sub bt_del_reslt_Click(sender As Object, e As EventArgs) Handles bt_del_reslt.Click
        Dim res = MessageBox.Show("Do you want to delete Student Marksheet?", "Result Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = Windows.Forms.DialogResult.Yes Then
            cnn.Open()
            cmd.Connection = cnn
            sql = "SELECT vl FROM cfg WHERE rgstry='generate_res'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader()
            If rdr.Read = True Then
                If rdr(0) = 1 Then
                    cnn2.Open()
                    cmd2.Connection = cnn2
                    cmd2.CommandText = "DELETE * FROM st_marksheet"
                    cmd2.ExecuteNonQuery()
                    Refresh()
                    sql2 = "UPDATE cfg SET vl=0 WHERE rgstry='generate_res'"
                    cmd2 = New OleDb.OleDbCommand(sql2, cnn2)
                    cmd2.ExecuteNonQuery()
                    Refresh()
                    cnn2.Close()
                    bt_gen_reslt.Enabled = True
                    lb_adm_fsts.Text = "Marksheet Deleted"
                Else
                    MessageBox.Show("Result has not been generated", "Result Deletion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End If
            Refresh()
            cnn.Close()

        ElseIf res = Windows.Forms.DialogResult.No Then
            lb_adm_fsts.Text = "Marksheet Deletion Aborted"
        End If
    End Sub
End Class