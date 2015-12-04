Public Class staff_register
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim rdr As OleDb.OleDbDataReader
    Dim sql As String
    Private Sub staff_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn.Open()
        If cnn.State = ConnectionState.Open Then
            lb_stf_csts.Text = "Connection Available"
            lb_stf_fsts.Text = "Record Not Saved"
            cnn.Close()
        Else
            lb_stf_csts.Text = "Connection Not Available"
            cnn.Close()
            lb_stf_fsts.Text = "Record Not Saved"
        End If
    End Sub
    Private Sub bt_stf_bck_Click(sender As Object, e As EventArgs) Handles bt_stf_bck.Click
        Me.Close()
        staff_login.Show()
    End Sub

    Private Sub bt_stf_sv_Click(sender As Object, e As EventArgs) Handles bt_stf_sv.Click
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO stf_reg (first_name,mid_name,last_name,date_of_birth,major,email,mobile,l_address,p_address) VALUES ('" & Me.tb_fname.Text & "', '" & Me.tb_mname.Text & "', '" & Me.tb_lname.Text & "', '" & Me.dtp_stf_dob.Text & "', '" & Me.cb_mjr.Text & "', '" & Me.tb_email.Text & "', '" & Me.tb_stf_mob.Text & "', '" & Me.tb_ladrs.Text & "', '" & Me.tb_padrs.Text & "')"
            cmd.ExecuteNonQuery()
            Refresh()

            cmd.Connection = cnn
            sql = "SELECT stf_id FROM stf_reg WHERE mobile= '" & tb_stf_mob.Text & "'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                MsgBox("Staff Registration ID is " & rdr(0))
            staff_pswrd.tb_stf_id.Text = rdr(0)
            End If
            Refresh()
        cnn.Close()

            lb_stf_fsts.Text = "Record Updated"
        Me.Hide()
            staff_pswrd.Show()
            tb_email.Text = ""
            tb_fname.Text = ""
            tb_ladrs.Text = ""
            tb_lname.Text = ""
            tb_mname.Text = ""
            tb_padrs.Text = ""
            tb_stf_mob.Text = ""
            dtp_stf_dob.Text = ""
        cb_mjr.Text = ""
    End Sub

    Private Sub bt_stf_rst_Click(sender As Object, e As EventArgs) Handles bt_stf_rst.Click
        lb_stf_fsts.Text = "Record Cleared"
        tb_email.Text = ""
        tb_stf_mob.Text = ""
        tb_fname.Text = ""
        tb_ladrs.Text = ""
        tb_lname.Text = ""
        tb_mname.Text = ""
        tb_padrs.Text = ""
    End Sub
End Class