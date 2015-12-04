Public Class staff_pswrd
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub staff_pswrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn.Open()
        tb_entrpswrd.Focus()
    End Sub

    Private Sub bt_rst_Click(sender As Object, e As EventArgs) Handles bt_rst.Click
        tb_entrpswrd.Text = ""
        tb_retrpswrd.Text = ""
    End Sub

    Private Sub bt_sv_Click(sender As Object, e As EventArgs) Handles bt_sv.Click
        If tb_entrpswrd.Text = tb_retrpswrd.Text Then
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            cmd.Connection = cnn
            cmd.CommandText = "INSERT INTO stf_security (stf_id,stf_password) VALUES (" & Me.tb_stf_id.Text & ", '" & tb_entrpswrd.Text & "')"
            cmd.ExecuteNonQuery()
            Refresh()
            cnn.Close()
            MessageBox.Show("Password for Staff ID " & tb_stf_id.Text & " has been set", "Set Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Hide()
            staff_register.Show()
        Else
            MsgBox("Password Don't Match")
        End If
    End Sub
End Class