Public Class admin_login
    Private Sub bt_admin_back_Click(sender As Object, e As EventArgs) Handles bt_admin_back.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub bt_admin_login_Click(sender As Object, e As EventArgs) Handles bt_admin_login.Click
        If tb_admin_usr.Text = "" And tb_admin_pas.Text = "" Then
            MessageBox.Show("Please Enter Unsername and Password", "Access Deined", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Not tb_admin_usr.Text = "admin" Then
            MessageBox.Show("Invalid Username", "Access Deined", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Not tb_admin_usr.Text = "admin" And tb_admin_pas.Text = "" Then
            MessageBox.Show("Please enter Password", "Access Deined", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf tb_admin_usr.Text = "admin" And Not tb_admin_pas.Text = "root" Then
            MessageBox.Show("Wrong Password", "Access Deined", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf tb_admin_usr.Text = "admin" And tb_admin_pas.Text = "root" Then
            Me.Close()
            admin_main.Show()
        End If
    End Sub
End Class