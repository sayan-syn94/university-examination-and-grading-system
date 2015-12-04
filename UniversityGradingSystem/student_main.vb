Imports System.Drawing.Imaging

Public Class student_main
    Dim cnn, cnn1 As OleDb.OleDbConnection
    Dim cmd, cmd1 As New OleDb.OleDbCommand
    Dim rdr, rdr1 As OleDb.OleDbDataReader
    Dim sql, sql1, path As String
    Dim th1, th2, th3, th4, th5 As Integer
    Private Sub bt_std_bck_Click(sender As Object, e As EventArgs) Handles bt_std_bck.Click
        Me.Close()
        student_login.Show()
    End Sub
    Private Sub bt_std_sv_Click(sender As Object, e As EventArgs) Handles bt_std_sv.Click

        sfd1_st.Filter = "Image Files (*.jpg)|*.jpg"
        If sfd1_st.ShowDialog = Windows.Forms.DialogResult.OK Then
            path = sfd1_st.FileName
        End If
        System.Threading.Thread.Sleep(2000)
        Dim bmpScreenshot As Bitmap = New Bitmap(Width, Height, PixelFormat.Format32bppArgb)
        Dim gfxScreenshot As Graphics = Graphics.FromImage(bmpScreenshot)
        gfxScreenshot.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, Me.Size, CopyPixelOperation.SourceCopy)
        bmpScreenshot.Save("" & path, ImageFormat.Jpeg)
        MessageBox.Show("Result has been saved", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub bt_std_prnt_Click(sender As Object, e As EventArgs) Handles bt_std_prnt.Click
        
        pd1_st.Document = pdoc1_st
        pd1_st.PrinterSettings = pdoc1_st.PrinterSettings
        pd1_st.AllowSomePages = True
        If pd1_st.ShowDialog = DialogResult.OK Then
            pdoc1_st.PrinterSettings = pd1_st.PrinterSettings
            pdoc1_st.Print()
        End If

    End Sub
    Private Sub pdoc1_st_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdoc1_st.PrintPage

        Dim bmpScreenshot As Bitmap = New Bitmap(Width, Height, PixelFormat.Format32bppArgb)
        Dim gfxScreenshot As Graphics = Graphics.FromImage(bmpScreenshot)
        gfxScreenshot.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, Me.Size, CopyPixelOperation.SourceCopy)
        bmpScreenshot.Save("D:\tmp.jpg", ImageFormat.Jpeg)
        Dim newImage As Image = Image.FromFile("D:\tmp.jpg")
        e.Graphics.DrawImage(newImage, 100, 100)

    End Sub

    Private Sub student_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn1 = New OleDb.OleDbConnection
        cnn1.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
            lb_st_csts.Text = "Connected"
        Else
            lb_st_csts.Text = "Not Connected"
        End If

        cmd.Connection = cnn
        sql = "SELECT st_session, st_college, st_stream FROM st_academic WHERE st_id=" & lb_st_id.Text & "AND st_semester= '" & lb_st_sem.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            lb_st_sesn.Text = rdr(0)
            lb_st_strm.Text = rdr(2)
            lb_st_cllg.Text = rdr(1)
        End If

        If lb_st_sem.Text = "1" Then
            lb_th1_c.Text = "M101"
            lb_th2_c.Text = "ME101"
            lb_th3_c.Text = "HU101"
            lb_th4_c.Text = "ES101"
            lb_th5_c.Text = "CS101"
        ElseIf lb_st_sem.Text = "2" Then
            lb_th1_c.Text = "M201"
            lb_th2_c.Text = "ME201"
            lb_th3_c.Text = "HU201"
            lb_th4_c.Text = "ES201"
            lb_th5_c.Text = "CS201"
        ElseIf lb_st_sem.Text = "3" Then
            lb_th1_c.Text = "M301"
            lb_th2_c.Text = "ME301"
            lb_th3_c.Text = "HU301"
            lb_th4_c.Text = "ES301"
            lb_th5_c.Text = "CS301"
        ElseIf lb_st_sem.Text = "4" Then
            lb_th1_c.Text = "M401"
            lb_th2_c.Text = "ME401"
            lb_th3_c.Text = "HU401"
            lb_th4_c.Text = "ES401"
            lb_th5_c.Text = "CS401"
        ElseIf lb_st_sem.Text = "5" Then
            lb_th1_c.Text = "M501"
            lb_th2_c.Text = "ME501"
            lb_th3_c.Text = "HU501"
            lb_th4_c.Text = "ES501"
            lb_th5_c.Text = "CS501"
        ElseIf lb_st_sem.Text = "6" Then
            lb_th1_c.Text = "M601"
            lb_th2_c.Text = "ME601"
            lb_th3_c.Text = "HU601"
            lb_th4_c.Text = "ES601"
            lb_th5_c.Text = "CS601"
        ElseIf lb_st_sem.Text = "7" Then
            lb_th1_c.Text = "M701"
            lb_th2_c.Text = "ME701"
            lb_th3_c.Text = "HU701"
            lb_th4_c.Text = "ES701"
            lb_th5_c.Text = "CS701"
        ElseIf lb_st_sem.Text = "8" Then
            lb_th1_c.Text = "M801"
            lb_th2_c.Text = "ME801"
            lb_th3_c.Text = "HU801"
            lb_th4_c.Text = "ES801"
            lb_th5_c.Text = "CS801"
        End If

        sql = "SELECT st_th1, st_th2, st_th3, st_th4, st_th5 FROM st_academic WHERE st_id=" & lb_st_id.Text & ""
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            lb_st_th1.Text = rdr(0)
            lb_st_th2.Text = rdr(2)
            lb_st_th3.Text = rdr(1)
            lb_st_th4.Text = rdr(3)
            lb_st_th5.Text = rdr(4)
        End If

        lb_th1_cr.Text = "4"
        lb_th2_cr.Text = "4"
        lb_th3_cr.Text = "4"
        lb_th4_cr.Text = "4"
        lb_th5_cr.Text = "4"
        lb_total_cr.Text = "20"

        cnn1.Open()
        cmd1.Connection = cnn1
        sql1 = "SELECT th1_l, th2_l, th3_l, th4_l, th5_l, th1_p, th2_p, th3_p, th4_p, th5_p, th1_cp, th2_cp, th3_cp, th4_cp, th5_cp, total_cp, cgpa FROM st_marksheet WHERE st_id= " & lb_st_id.Text & " AND st_semester='" & lb_st_sem.Text & "'"
        cmd1 = New OleDb.OleDbCommand(sql1, cnn1)
        rdr1 = cmd1.ExecuteReader
        If rdr1.Read = True Then
            lb_th1_l.Text = rdr1(0)
            lb_th2_l.Text = rdr1(1)
            lb_th3_l.Text = rdr1(2)
            lb_th4_l.Text = rdr1(3)
            lb_th5_l.Text = rdr1(4)
            lb_th1_p.Text = rdr1(5)
            lb_th2_p.Text = rdr1(6)
            lb_th3_p.Text = rdr1(7)
            lb_th4_p.Text = rdr1(8)
            lb_th5_p.Text = rdr1(9)
            lb_th1_cp.Text = rdr1(10)
            lb_th2_cp.Text = rdr1(11)
            lb_th3_cp.Text = rdr1(12)
            lb_th4_cp.Text = rdr1(13)
            lb_th5_cp.Text = rdr1(14)
            lb_total_cp.Text = rdr1(15)
            lb_st_cgpa.Text = rdr1(16)
        End If
        Refresh()
        cnn1.Close()
        cnn.Close()
    End Sub
End Class