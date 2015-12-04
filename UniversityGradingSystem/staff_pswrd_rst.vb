Public Class staff_pswrd_rst
    Dim cnn, cnn1 As New OleDb.OleDbConnection
    Dim cmd, cmd1 As New OleDb.OleDbCommand
    Dim rdr, rdr1 As OleDb.OleDbDataReader
    Dim sql, sql1, entrpswrd, pswrd As String
    Dim id_sts = 0, mob_sts = 0
    Private Sub bt_stf_bck_Click(sender As Object, e As EventArgs) Handles bt_stf_bck.Click
        Me.Hide()
        staff_login.Show()
    End Sub

    Private Sub staff_pswrd_rst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn1 = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn1.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        tb_stf_id.Focus()
    End Sub

    Private Sub bt_stf_chck_Click(sender As Object, e As EventArgs) Handles bt_stf_chck.Click
        If cnn1.State = ConnectionState.Closed Then
            cnn1.Open()
        End If
        cmd1.Connection = cnn1
        sql1 = "SELECT stf_id FROM stf_reg"
        cmd1 = New OleDb.OleDbCommand(sql1, cnn1)
        rdr1 = cmd1.ExecuteReader
        While rdr1.Read = True
            If tb_stf_id.Text = "" Then
                id_sts = -1
                lb_stf_chck.Text = "Please enter a valid Staff ID"
            ElseIf tb_stf_id.Text = rdr1(0) Then
                id_sts = 1
                lb_stf_chck.Text = "Staff ID Found"
                Exit While
            Else
                id_sts = -2
                lb_stf_chck.Text = "Staff ID doesn't exsist"
            End If
        End While
        cnn1.Close()
    End Sub

    Private Sub bt_stf_vrfy_Click(sender As Object, e As EventArgs) Handles bt_stf_vrfy.Click
        If id_sts = 1 Then
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
            cmd1.Connection = cnn1
            sql1 = "SELECT mobile FROM stf_reg WHERE stf_id= " & tb_stf_id.Text & ""
            cmd1 = New OleDb.OleDbCommand(sql1, cnn1)
            rdr1 = cmd1.ExecuteReader
            If rdr1.Read = True Then
                If tb_stf_mob.Text = "" Then
                    mob_sts = -1
                ElseIf tb_stf_mob.Text = rdr1(0) Then
                    mob_sts = 1
                Else
                    mob_sts = -2
                End If
            End If

            If mob_sts = -1 Then
                lb_stf_vrfy.Text = "Please enter mobile no."
            ElseIf mob_sts = 1 Then
                lb_stf_vrfy.Text = "Staff ID Verified"
            ElseIf mob_sts = -2 Then
                lb_stf_vrfy.Text = "Enter a Valid mobile no."
            End If

            cnn1.Close()
        Else
            MessageBox.Show("Please Check Staff ID", "ID Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub bt_stf_sv_Click(sender As Object, e As EventArgs) Handles bt_stf_sv.Click
        cnn1.Open()
        If id_sts = 1 Then
            If mob_sts = 1 Then
                If Not tb_stf_entr_pswrd.Text = "" Then
                    If tb_stf_entr_pswrd.Text = tb_stf_rentr_pswrd.Text Then
                        cmd1.Connection = cnn1
                        sql1 = "UPDATE stf_security SET stf_password= '" & tb_stf_entr_pswrd.Text & "' WHERE stf_id= " & tb_stf_id.Text & ""
                        cmd1 = New OleDb.OleDbCommand(sql1, cnn1)
                        cmd1.ExecuteNonQuery()
                        Refresh()
                        MessageBox.Show("Staff ID " & tb_stf_id.Text & " has been updated", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Entered passwords doesn't match", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Enter a vaild Password", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
        cnn1.Close()
        tb_stf_id.Text = ""
        tb_stf_mob.Text = ""
        tb_stf_entr_pswrd.Text = ""
        tb_stf_rentr_pswrd.Text = ""
    End Sub

    Private Sub bt_stf_rst_Click(sender As Object, e As EventArgs) Handles bt_stf_rst.Click
        tb_stf_id.Text = ""
        tb_stf_mob.Text = ""
        tb_stf_entr_pswrd.Text = ""
        tb_stf_rentr_pswrd.Text = ""
    End Sub
End Class