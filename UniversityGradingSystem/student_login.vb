Public Class student_login
    Dim cnn, cnn1, cnn2, cnn3 As New OleDb.OleDbConnection
    Dim cmd, cmd1, cmd2, cmd3 As New OleDb.OleDbCommand
    Dim rdr, rdr1, rdr2, rdr3 As OleDb.OleDbDataReader
    Dim sql, sql1, sql2, sql3, sem As String
    Dim sts = 0, sm_sts = 0
    Private Sub student_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"

        cnn1 = New OleDb.OleDbConnection
        cnn1.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"

        cnn2 = New OleDb.OleDbConnection
        cnn2.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"

        cnn3 = New OleDb.OleDbConnection
        cnn3.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"

        tb_st_entr_rll.Focus()
    End Sub

    Private Sub bt_st_getres_Click(sender As Object, e As EventArgs) Handles bt_st_getres.Click

        cmd1.Connection = cnn1
        sql1 = "SELECT vl FROM cfg WHERE rgstry= 'generate_res'"
        cmd1 = New OleDb.OleDbCommand(sql1, cnn1)
        cnn1.Open()
        rdr1 = cmd1.ExecuteReader
        If rdr1.Read = True Then

            If rdr1(0) = 1 Then
                If tb_st_entr_rll.Text = "" And cb_st_sem.SelectedItem = "" Then
                    sts = -2
                    sm_sts = -2
                ElseIf tb_st_entr_rll.Text = "" And Not cb_st_sem.SelectedItem = "" Then
                    sts = -2
                ElseIf Not tb_st_entr_rll.Text = "" And cb_st_sem.SelectedItem = "" Then
                    sm_sts = -2
                Else
                    cmd2.Connection = cnn2
                    sql2 = "SELECT st_id FROM st_reg"
                    cmd2 = New OleDb.OleDbCommand(sql2, cnn2)
                    cnn2.Open()
                    rdr2 = cmd2.ExecuteReader
                    While rdr2.Read = True
                        If tb_st_entr_rll.Text = rdr2(0) Then
                            sts = 1
                            Exit While
                        Else
                            sts = -1
                        End If
                    End While
                    cnn2.Close()

                    cmd3.Connection = cnn3
                    sql3 = "SELECT st_semester FROM st_academic WHERE st_id=" & Me.tb_st_entr_rll.Text & ""
                    cmd3 = New OleDb.OleDbCommand(sql3, cnn3)
                    cnn3.Open()
                    rdr3 = cmd3.ExecuteReader
                    While rdr3.Read = True
                        If cb_st_sem.SelectedItem = rdr3(0) Then
                            sm_sts = 1
                            Exit While
                        Else
                            sm_sts = -1
                        End If
                    End While
                    cnn3.Close()

                End If

                If sts = 1 And sm_sts = 1 Then
                    cmd.Connection = cnn
                    sql = "SELECT first_name, mid_name, last_name FROM st_reg WHERE st_id=" & Me.tb_st_entr_rll.Text & ""
                    cmd = New OleDb.OleDbCommand(sql, cnn)
                    cnn.Open()
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        Me.Hide()
                        student_main.lb_st_id.Text = tb_st_entr_rll.Text
                        student_main.lb_st_name.Text = rdr(0) + " " + rdr(1) + " " + rdr(2)
                        student_main.lb_st_sem.Text = cb_st_sem.SelectedItem
                        student_main.Show()
                        Me.Close()
                    End If
                    cnn.Close()
                    sts = 0
                ElseIf sts = -1 Then
                    MessageBox.Show("Student ID doesn't exsist", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    sts = 0
                ElseIf sts = -2 Then
                    MessageBox.Show("Please enter a Student ID first", "Empty Student ID", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    sts = 0
                ElseIf sm_sts = -1 Then
                    MessageBox.Show("Student has not registered in Semester " & cb_st_sem.SelectedItem, "Result Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    sm_sts = 0
                ElseIf sm_sts = -2 Then
                    MessageBox.Show("Please select semester for Student", "Empty Semester", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    sm_sts = 0
                End If

            Else
                MessageBox.Show("Result has not been generated, contact Administrator", "Result", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        End If
        cnn1.Close()

    End Sub

    Private Sub bt_st_bck_Click(sender As Object, e As EventArgs) Handles bt_st_bck.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub bt_sgn_up_Click(sender As Object, e As EventArgs) Handles bt_sgn_up.Click
        Me.Hide()
        student_register.Show()
    End Sub
End Class