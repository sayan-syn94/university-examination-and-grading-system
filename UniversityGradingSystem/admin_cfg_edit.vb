Public Class admin_cfg_edit
    Dim cnn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim rdr As OleDb.OleDbDataReader
    Dim sql As String
    Dim m, mec, hu, es, cs, res As Integer
    Private Sub admin_cfg_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider = Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database\university_sys.mdb"
        cnn.Open()
        sql = "SELECT vl FROM cfg WHERE rgstry= 'Mathematics'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            If rdr(0) = 1 Then
                cbx_m.Checked = True
            Else
                cbx_m.Checked = False
            End If
        End If
        Refresh()
        sql = "SELECT vl FROM cfg WHERE rgstry= 'Mechanics'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            If rdr(0) = 1 Then
                cbx_me.Checked = True
            Else
                cbx_me.Checked = False
            End If
        End If
        Refresh()
        sql = "SELECT vl FROM cfg WHERE rgstry= 'English'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            If rdr(0) = 1 Then
                cbx_hu.Checked = True
            Else
                cbx_hu.Checked = False
            End If
        End If
        Refresh()
        sql = "SELECT vl FROM cfg WHERE rgstry= 'Electronics'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            If rdr(0) = 1 Then
                cbx_es.Checked = True
            Else
                cbx_es.Checked = False
            End If
        End If
        Refresh()
        sql = "SELECT vl FROM cfg WHERE rgstry= 'Computer Science'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            If rdr(0) = 1 Then
                cbx_cs.Checked = True
            Else
                cbx_cs.Checked = False
            End If
        End If
        Refresh()
        sql = "SELECT vl FROM cfg WHERE rgstry= 'generate_res'"
        cmd = New OleDb.OleDbCommand(sql, cnn)
        rdr = cmd.ExecuteReader
        If rdr.Read = True Then
            If rdr(0) = 1 Then
                cbx_gen_res.Checked = True
            Else
                cbx_gen_res.Checked = False
            End If
        End If
        Refresh()
        cnn.Close()
    End Sub
    Private Sub bt_bck_Click(sender As Object, e As EventArgs) Handles bt_bck.Click
        Me.Close()
        admin_main.Show()
    End Sub
    Private Sub bt_sv_Click(sender As Object, e As EventArgs) Handles bt_sv.Click

        Dim res = MessageBox.Show("Do you want to make these changes?", "Configuration File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = Windows.Forms.DialogResult.Yes Then
            cnn.Open()
            cmd.Connection = cnn
            If cbx_m.Checked = True Then
                sql = "UPDATE cfg SET vl=1 WHERE rgstry= 'Mathematics'"
            Else
                sql = "UPDATE cfg SET vl=0 WHERE rgstry= 'Mathematics'"
            End If
            cmd = New OleDb.OleDbCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            Refresh()
            If cbx_cs.Checked = True Then
                sql = "UPDATE cfg SET vl=1 WHERE rgstry= 'Computer Science'"
            Else
                sql = "UPDATE cfg SET vl=0 WHERE rgstry= 'Computer Science'"
            End If
            cmd = New OleDb.OleDbCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            Refresh()
            If cbx_me.Checked = True Then
                sql = "UPDATE cfg SET vl=1 WHERE rgstry= 'Mechanics'"
            Else
                sql = "UPDATE cfg SET vl=0 WHERE rgstry= 'Mechanics'"
            End If
            cmd = New OleDb.OleDbCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            Refresh()
            If cbx_hu.Checked = True Then
                sql = "UPDATE cfg SET vl=1 WHERE rgstry= 'English'"
            Else
                sql = "UPDATE cfg SET vl=0 WHERE rgstry= 'English'"
            End If
            cmd = New OleDb.OleDbCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            Refresh()
            If cbx_es.Checked = True Then
                sql = "UPDATE cfg SET vl=1 WHERE rgstry= 'Electronics'"
            Else
                sql = "UPDATE cfg SET vl=0 WHERE rgstry= 'Electronics'"
            End If
            cmd = New OleDb.OleDbCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            Refresh()
            If cbx_gen_res.Checked = True Then
                sql = "UPDATE cfg SET vl=1 WHERE rgstry= 'generate_res'"
            Else
                sql = "UPDATE cfg SET vl=0 WHERE rgstry= 'generate_res'"
            End If
            cmd = New OleDb.OleDbCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            Refresh()
            cnn.Close()
            Me.Close()
            admin_main.Show()
        ElseIf res = Windows.Forms.DialogResult.No Then
            cnn.Open()
            sql = "SELECT vl FROM cfg WHERE rgstry= 'Mathematics'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                If rdr(0) = 1 Then
                    cbx_m.Checked = True
                Else
                    cbx_m.Checked = False
                End If
            End If
            Refresh()
            sql = "SELECT vl FROM cfg WHERE rgstry= 'Mechanics'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                If rdr(0) = 1 Then
                    cbx_me.Checked = True
                Else
                    cbx_me.Checked = False
                End If
            End If
            Refresh()
            sql = "SELECT vl FROM cfg WHERE rgstry= 'English'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                If rdr(0) = 1 Then
                    cbx_hu.Checked = True
                Else
                    cbx_hu.Checked = False
                End If
            End If
            Refresh()
            sql = "SELECT vl FROM cfg WHERE rgstry= 'Electronics'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                If rdr(0) = 1 Then
                    cbx_es.Checked = True
                Else
                    cbx_es.Checked = False
                End If
            End If
            Refresh()
            sql = "SELECT vl FROM cfg WHERE rgstry= 'Computer Science'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                If rdr(0) = 1 Then
                    cbx_cs.Checked = True
                Else
                    cbx_cs.Checked = False
                End If
            End If
            Refresh()
            sql = "SELECT vl FROM cfg WHERE rgstry= 'generate_res'"
            cmd = New OleDb.OleDbCommand(sql, cnn)
            rdr = cmd.ExecuteReader
            If rdr.Read = True Then
                If rdr(0) = 1 Then
                    cbx_gen_res.Checked = True
                Else
                    cbx_gen_res.Checked = False
                End If
            End If
            Refresh()
            cnn.Close()
            'Me.Close()
            'admin_main.Show()
        End If
    End Sub
End Class