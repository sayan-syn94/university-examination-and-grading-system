Public Class main
    Private Sub bt_admin_login_Click(sender As Object, e As EventArgs) Handles bt_admin_login.Click
        Me.Hide()
        admin_login.Show()
    End Sub
    Private Sub bt_staff_login_Click(sender As Object, e As EventArgs) Handles bt_staff_login.Click
        Me.Hide()
        staff_login.Show()
    End Sub
    Private Sub bt_student_login_Click(sender As Object, e As EventArgs) Handles bt_student_login.Click
        Me.Hide()
        student_login.Show()
    End Sub
    Private Sub bt_exit_Click(sender As Object, e As EventArgs) Handles bt_exit.Click
        End
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Developed by Soumeet, Rausan, Sayan", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
