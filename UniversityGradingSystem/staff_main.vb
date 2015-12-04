Imports System.Data.OleDb
Public Class staff_main
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim rdr As OleDb.OleDbDataReader
    Dim sql As String
    Private Sub staff_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn.Open()
        If cnn.State = ConnectionState.Open Then
            lb_stf_csts.Text = "Connection Available"
        Else
            lb_stf_csts.Text = "Connection Not Available"
        End If
        sql = "SELECT first_name, mid_name, last_name, major FROM stf_reg WHERE stf_id=" & Me.lb_stf_id.Text
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            lb_stf_name.Text = rdr(0) + " " + rdr(1) + " " + rdr(2)
            lb_stf_mjr.Text = rdr(3)
        End If

        If lb_stf_mjr.Text = "Mathematics" Then
            lbx_stf_sbjt.Items.Add("M101")
            lbx_stf_sbjt.Items.Add("M201")
            lbx_stf_sbjt.Items.Add("M301")
            lbx_stf_sbjt.Items.Add("M401")
            lbx_stf_sbjt.Items.Add("M501")
            lbx_stf_sbjt.Items.Add("M601")
            lbx_stf_sbjt.Items.Add("M701")
            lbx_stf_sbjt.Items.Add("M801")
        ElseIf lb_stf_mjr.Text = "Mechanics" Then
            lbx_stf_sbjt.Items.Add("ME101")
            lbx_stf_sbjt.Items.Add("ME201")
            lbx_stf_sbjt.Items.Add("ME301")
            lbx_stf_sbjt.Items.Add("ME401")
            lbx_stf_sbjt.Items.Add("ME501")
            lbx_stf_sbjt.Items.Add("ME601")
            lbx_stf_sbjt.Items.Add("ME701")
            lbx_stf_sbjt.Items.Add("ME801")
        ElseIf lb_stf_mjr.Text = "English" Then
            lbx_stf_sbjt.Items.Add("HU101")
            lbx_stf_sbjt.Items.Add("HU201")
            lbx_stf_sbjt.Items.Add("HU301")
            lbx_stf_sbjt.Items.Add("HU401")
            lbx_stf_sbjt.Items.Add("HU501")
            lbx_stf_sbjt.Items.Add("HU601")
            lbx_stf_sbjt.Items.Add("HU701")
            lbx_stf_sbjt.Items.Add("HU801")
        ElseIf lb_stf_mjr.Text = "Electronics" Then
            lbx_stf_sbjt.Items.Add("ES101")
            lbx_stf_sbjt.Items.Add("ES201")
            lbx_stf_sbjt.Items.Add("ES301")
            lbx_stf_sbjt.Items.Add("ES401")
            lbx_stf_sbjt.Items.Add("ES501")
            lbx_stf_sbjt.Items.Add("ES601")
            lbx_stf_sbjt.Items.Add("ES701")
            lbx_stf_sbjt.Items.Add("ES801")
        ElseIf lb_stf_mjr.Text = "Computer Science" Then
            lbx_stf_sbjt.Items.Add("CS101")
            lbx_stf_sbjt.Items.Add("CS201")
            lbx_stf_sbjt.Items.Add("CS301")
            lbx_stf_sbjt.Items.Add("CS401")
            lbx_stf_sbjt.Items.Add("CS501")
            lbx_stf_sbjt.Items.Add("CS601")
            lbx_stf_sbjt.Items.Add("CS701")
            lbx_stf_sbjt.Items.Add("CS801")
        End If

        sql = "SELECT vl FROM cfg WHERE rgstry='" & Me.lb_stf_mjr.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            If rdr(0) = 1 Then
                tb_entr_mrks.Enabled = False
                bt_st_mrks_sv.Enabled = False
                lb_stf_mrks.Enabled = False
                bt_stf_sbmt.Enabled = False
                lb_stf_mn_fsts.Text = "Marks Already Submitted"
            End If
        End If

        cnn.Close()
    End Sub
    Private Sub bt_stf_logout_Click(sender As Object, e As EventArgs) Handles bt_stf_logout.Click
        Me.Close()
        staff_login.Show()
    End Sub

    Private Sub bt_st_mrks_sv_Click(sender As Object, e As EventArgs) Handles bt_st_mrks_sv.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        If lbx_st_list.SelectedIndex = -1 Then
            MsgBox("Please select a Student ID")
        Else
            If Val(tb_entr_mrks.Text) < 101 Then
                If lbx_stf_sbjt.SelectedItem = "M101" Then
                    sql = "UPDATE st_sem1 SET m101=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "M201" Then
                    sql = "UPDATE st_sem2 SET m201=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "M301" Then
                    sql = "UPDATE st_sem3 SET m301=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "M401" Then
                    sql = "UPDATE st_sem4 SET m401=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "M501" Then
                    sql = "UPDATE st_sem5 SET m501=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "M601" Then
                    sql = "UPDATE st_sem6 SET m601=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "M701" Then
                    sql = "UPDATE st_sem7 SET m701=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "M801" Then
                    sql = "UPDATE st_sem8 SET m801=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ME101" Then
                    sql = "UPDATE st_sem1 SET me101=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ME201" Then
                    sql = "UPDATE st_sem2 SET me201=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ME301" Then
                    sql = "UPDATE st_sem3 SET me301=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ME401" Then
                    sql = "UPDATE st_sem4 SET me401=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ME501" Then
                    sql = "UPDATE st_sem5 SET me501=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ME601" Then
                    sql = "UPDATE st_sem6 SET me601=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ME701" Then
                    sql = "UPDATE st_sem7 SET me701=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ME801" Then
                    sql = "UPDATE st_sem8 SET me801=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ES101" Then
                    sql = "UPDATE st_sem1 SET cs101=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ES201" Then
                    sql = "UPDATE st_sem2 SET es201=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ES301" Then
                    sql = "UPDATE st_sem3 SET es301=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ES401" Then
                    sql = "UPDATE st_sem4 SET es401=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ES501" Then
                    sql = "UPDATE st_sem5 SET es501=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ES601" Then
                    sql = "UPDATE st_sem6 SET es601=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ES701" Then
                    sql = "UPDATE st_sem7 SET es701=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "ES801" Then
                    sql = "UPDATE st_sem8 SET es801=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "HU101" Then
                    sql = "UPDATE st_sem1 SET hu101=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "HU201" Then
                    sql = "UPDATE st_sem2 SET hu201=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "HU301" Then
                    sql = "UPDATE st_sem3 SET hu301=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "HU401" Then
                    sql = "UPDATE st_sem4 SET hu401=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "HU501" Then
                    sql = "UPDATE st_sem5 SET hu501=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "HU601" Then
                    sql = "UPDATE st_sem6 SET hu601=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "HU701" Then
                    sql = "UPDATE st_sem7 SET hu701=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "HU801" Then
                    sql = "UPDATE st_sem8 SET hu801=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "CS101" Then
                    sql = "UPDATE st_sem1 SET cs101=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "CS201" Then
                    sql = "UPDATE st_sem2 SET cs201=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "CS301" Then
                    sql = "UPDATE st_sem3 SET cs301=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "CS401" Then
                    sql = "UPDATE st_sem4 SET cs401=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "CS501" Then
                    sql = "UPDATE st_sem5 SET cs501=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "CS601" Then
                    sql = "UPDATE st_sem6 SET cs601=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "CS701" Then
                    sql = "UPDATE st_sem7 SET cs701=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                ElseIf lbx_stf_sbjt.SelectedItem = "CS801" Then
                    sql = "UPDATE st_sem8 SET cs801=" & tb_entr_mrks.Text & " WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
                    cmd = New OleDbCommand(sql, cnn)
                    rdr = cmd.ExecuteReader
                    If rdr.Read = True Then
                        tb_entr_mrks.Text = rdr(0)
                    End If
                End If
                lb_stf_mn_fsts.Text = "Record Updated"
            Else
                MsgBox("You can't enter marks more than 100")
            End If
        End If
        cnn.Close()
    End Sub

    Private Sub lbx_st_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_st_list.SelectedIndexChanged
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        If lbx_stf_sbjt.SelectedItem = "M101" Then
            sql = "SELECT m101 FROM st_sem1 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "M201" Then
            sql = "SELECT m201 FROM st_sem2 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "M301" Then
            sql = "SELECT m301 FROM st_sem3 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "M401" Then
            sql = "SELECT m401 FROM st_sem4 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "M501" Then
            sql = "SELECT m501 FROM st_sem5 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "M601" Then
            sql = "SELECT m601 FROM st_sem6 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "M701" Then
            sql = "SELECT m701 FROM st_sem7 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "M801" Then
            sql = "SELECT m801 FROM st_sem8 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ME101" Then
            sql = "SELECT me101 FROM st_sem1 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ME201" Then
            sql = "SELECT me201 FROM st_sem2 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ME301" Then
            sql = "SELECT me301 FROM st_sem3 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ME401" Then
            sql = "SELECT me401 FROM st_sem4 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ME501" Then
            sql = "SELECT me501 FROM st_sem5 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ME601" Then
            sql = "SELECT me601 FROM st_sem6 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ME701" Then
            sql = "SELECT me701 FROM st_sem7 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ME801" Then
            sql = "SELECT me801 FROM st_sem8 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "HU101" Then
            sql = "SELECT hu101 FROM st_sem1 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "HU201" Then
            sql = "SELECT hu201 FROM st_sem2 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "HU301" Then
            sql = "SELECT hu301 FROM st_sem3 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "HU401" Then
            sql = "SELECT hu401 FROM st_sem4 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "HU501" Then
            sql = "SELECT hu501 FROM st_sem5 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "HU601" Then
            sql = "SELECT hu601 FROM st_sem6 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "HU701" Then
            sql = "SELECT hu701 FROM st_sem7 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "HU801" Then
            sql = "SELECT hu801 FROM st_sem8 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ES101" Then
            sql = "SELECT es101 FROM st_sem1 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ES201" Then
            sql = "SELECT es201 FROM st_sem2 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ES301" Then
            sql = "SELECT es301 FROM st_sem3 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ES401" Then
            sql = "SELECT es401 FROM st_sem4 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ES501" Then
            sql = "SELECT es501 FROM st_sem5 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ES601" Then
            sql = "SELECT es601 FROM st_sem6 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ES701" Then
            sql = "SELECT es701 FROM st_sem7 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "ES801" Then
            sql = "SELECT es801 FROM st_sem8 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "CS101" Then
            sql = "SELECT cs101 FROM st_sem1 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "CS201" Then
            sql = "SELECT cs201 FROM st_sem2 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "CS301" Then
            sql = "SELECT cs301 FROM st_sem3 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "CS401" Then
            sql = "SELECT cs401 FROM st_sem4 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "CS501" Then
            sql = "SELECT cs501 FROM st_sem5 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "CS601" Then
            sql = "SELECT cs601 FROM st_sem6 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "CS701" Then
            sql = "SELECT cs701 FROM st_sem7 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        ElseIf lbx_stf_sbjt.SelectedItem = "CS801" Then
            sql = "SELECT cs801 FROM st_sem8 WHERE st_id=" & Me.lbx_st_list.SelectedItem & ""
            cmd = New OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                tb_entr_mrks.Text = rdr(0)
            End If
        End If
        cnn.Close()
    End Sub

    Private Sub lbx_stf_sbjt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbx_stf_sbjt.SelectedIndexChanged
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        If lbx_stf_sbjt.SelectedItem = "M101" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem1"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "M201" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem2"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "M301" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem3"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "M401" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem4"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "M501" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem5"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "M601" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem6"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "M701" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem7"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "M801" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem8"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ME101" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem1"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ME201" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem2"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ME301" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem3"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ME401" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem4"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ME501" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem5"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ME601" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem6"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ME701" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem7"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ME801" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem8"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "HU101" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem1"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "HU201" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem2"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "HU301" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem3"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "HU401" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem4"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "HU501" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem5"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "HU601" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem6"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "HU701" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem7"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "HU801" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem8"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ES101" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem1"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ES201" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem2"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ES301" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem3"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ES401" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem4"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ES501" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem5"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ES601" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem6"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ES701" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem7"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "ES801" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem8"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "CS101" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem1"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "CS201" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem2"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "CS301" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem3"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "CS401" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem4"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "CS501" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem5"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "CS601" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem6"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "CS701" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem7"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        ElseIf lbx_stf_sbjt.SelectedItem = "CS801" Then
            lbx_st_list.Items.Clear()
            sql = "SELECT st_id FROM st_sem8"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader

            While rdr.Read = True
                lbx_st_list.Items.Add(rdr(0))
            End While
        End If
        cnn.Close()
    End Sub

    Private Sub bt_stf_sbmt_Click(sender As Object, e As EventArgs) Handles bt_stf_sbmt.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        Dim res = MessageBox.Show("Do you want to submit Student Marks?", "Submit Marks", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If res = Windows.Forms.DialogResult.Yes Then
            cmd.Connection = cnn
            sql = "UPDATE cfg SET vl= 1 WHERE rgstry= '" & lb_stf_mjr.Text & "'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            Refresh()
            tb_entr_mrks.Enabled = False
            bt_st_mrks_sv.Enabled = False
            lb_stf_mrks.Enabled = False
            bt_stf_sbmt.Enabled = False
            lb_stf_mn_fsts.Text = "Marks Submitted"
        ElseIf res = Windows.Forms.DialogResult.No Then
            lb_stf_mn_fsts.Text = "Submition Aborted"
        End If
        cnn.Close()
    End Sub

    Private Sub tb_entr_mrks_TextChanged(sender As Object, e As EventArgs) Handles tb_entr_mrks.TextChanged
        If Val(tb_entr_mrks.Text) > 100 Then
            MsgBox("You can't enter more than 100")
            Exit Sub
        ElseIf Val(tb_entr_mrks.Text) < 0 Then
            MsgBox("You can't less than 0")
            Exit Sub
        End If
    End Sub
End Class