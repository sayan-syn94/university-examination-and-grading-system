<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_modify
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tb_st_id = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lb_st_fsts = New System.Windows.Forms.Label()
        Me.lb_st_csts = New System.Windows.Forms.Label()
        Me.bt_bck = New System.Windows.Forms.Button()
        Me.bt_rst = New System.Windows.Forms.Button()
        Me.bt_sv = New System.Windows.Forms.Button()
        Me.lb_astr = New System.Windows.Forms.Label()
        Me.bt_st_del = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb_st_th = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_st_th5 = New System.Windows.Forms.TextBox()
        Me.tb_st_th4 = New System.Windows.Forms.TextBox()
        Me.tb_st_th3 = New System.Windows.Forms.TextBox()
        Me.tb_st_th2 = New System.Windows.Forms.TextBox()
        Me.tb_st_th1 = New System.Windows.Forms.TextBox()
        Me.cb_st_sem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cb_st_ssn_end = New System.Windows.Forms.ComboBox()
        Me.cb_st_ssn_strt = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tb_st_cllg = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cb_st_strm = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tb_st_mob = New System.Windows.Forms.TextBox()
        Me.tb_st_lname = New System.Windows.Forms.TextBox()
        Me.tb_st_mname = New System.Windows.Forms.TextBox()
        Me.tb_st_fname = New System.Windows.Forms.TextBox()
        Me.tb_st_padrs = New System.Windows.Forms.TextBox()
        Me.tb_st_ladrs = New System.Windows.Forms.TextBox()
        Me.tb_st_email = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtp_st_dob = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tc_st = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.gb_st_th.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tc_st.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_st_id
        '
        Me.tb_st_id.Location = New System.Drawing.Point(118, 19)
        Me.tb_st_id.Name = "tb_st_id"
        Me.tb_st_id.Size = New System.Drawing.Size(212, 20)
        Me.tb_st_id.TabIndex = 96
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(22, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(77, 13)
        Me.Label31.TabIndex = 95
        Me.Label31.Text = "Registration ID"
        '
        'lb_st_fsts
        '
        Me.lb_st_fsts.AutoSize = True
        Me.lb_st_fsts.Location = New System.Drawing.Point(26, 448)
        Me.lb_st_fsts.Name = "lb_st_fsts"
        Me.lb_st_fsts.Size = New System.Drawing.Size(62, 13)
        Me.lb_st_fsts.TabIndex = 94
        Me.lb_st_fsts.Text = "[File Status]"
        '
        'lb_st_csts
        '
        Me.lb_st_csts.AutoSize = True
        Me.lb_st_csts.Location = New System.Drawing.Point(514, 19)
        Me.lb_st_csts.Name = "lb_st_csts"
        Me.lb_st_csts.Size = New System.Drawing.Size(100, 13)
        Me.lb_st_csts.TabIndex = 93
        Me.lb_st_csts.Text = "[Connection Status]"
        '
        'bt_bck
        '
        Me.bt_bck.Location = New System.Drawing.Point(553, 443)
        Me.bt_bck.Name = "bt_bck"
        Me.bt_bck.Size = New System.Drawing.Size(75, 23)
        Me.bt_bck.TabIndex = 92
        Me.bt_bck.Text = "Back"
        Me.bt_bck.UseVisualStyleBackColor = True
        '
        'bt_rst
        '
        Me.bt_rst.Location = New System.Drawing.Point(472, 443)
        Me.bt_rst.Name = "bt_rst"
        Me.bt_rst.Size = New System.Drawing.Size(75, 23)
        Me.bt_rst.TabIndex = 91
        Me.bt_rst.Text = "Reset"
        Me.bt_rst.UseVisualStyleBackColor = True
        '
        'bt_sv
        '
        Me.bt_sv.Location = New System.Drawing.Point(391, 443)
        Me.bt_sv.Name = "bt_sv"
        Me.bt_sv.Size = New System.Drawing.Size(75, 23)
        Me.bt_sv.TabIndex = 90
        Me.bt_sv.Text = "Save"
        Me.bt_sv.UseVisualStyleBackColor = True
        '
        'lb_astr
        '
        Me.lb_astr.AutoSize = True
        Me.lb_astr.ForeColor = System.Drawing.Color.Red
        Me.lb_astr.Location = New System.Drawing.Point(99, 22)
        Me.lb_astr.Name = "lb_astr"
        Me.lb_astr.Size = New System.Drawing.Size(11, 13)
        Me.lb_astr.TabIndex = 97
        Me.lb_astr.Text = "*"
        '
        'bt_st_del
        '
        Me.bt_st_del.Location = New System.Drawing.Point(310, 443)
        Me.bt_st_del.Name = "bt_st_del"
        Me.bt_st_del.Size = New System.Drawing.Size(75, 23)
        Me.bt_st_del.TabIndex = 98
        Me.bt_st_del.Text = "Delete"
        Me.bt_st_del.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb_st_th)
        Me.TabPage2.Controls.Add(Me.cb_st_sem)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.cb_st_ssn_end)
        Me.TabPage2.Controls.Add(Me.cb_st_ssn_strt)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.tb_st_cllg)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.cb_st_strm)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(603, 357)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Academic Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb_st_th
        '
        Me.gb_st_th.Controls.Add(Me.Label34)
        Me.gb_st_th.Controls.Add(Me.Label33)
        Me.gb_st_th.Controls.Add(Me.Label32)
        Me.gb_st_th.Controls.Add(Me.Label30)
        Me.gb_st_th.Controls.Add(Me.Label10)
        Me.gb_st_th.Controls.Add(Me.tb_st_th5)
        Me.gb_st_th.Controls.Add(Me.tb_st_th4)
        Me.gb_st_th.Controls.Add(Me.tb_st_th3)
        Me.gb_st_th.Controls.Add(Me.tb_st_th2)
        Me.gb_st_th.Controls.Add(Me.tb_st_th1)
        Me.gb_st_th.Enabled = False
        Me.gb_st_th.Location = New System.Drawing.Point(18, 132)
        Me.gb_st_th.Name = "gb_st_th"
        Me.gb_st_th.Size = New System.Drawing.Size(336, 161)
        Me.gb_st_th.TabIndex = 154
        Me.gb_st_th.TabStop = False
        Me.gb_st_th.Text = "Theory Papers"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(14, 129)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 13)
        Me.Label34.TabIndex = 153
        Me.Label34.Text = "Theory Paper 5"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(14, 102)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 13)
        Me.Label33.TabIndex = 152
        Me.Label33.Text = "Theory Paper 4"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(14, 76)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 13)
        Me.Label32.TabIndex = 151
        Me.Label32.Text = "Theory Paper 3"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(14, 52)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 13)
        Me.Label30.TabIndex = 150
        Me.Label30.Text = "Theory Paper 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "Theory Paper 1"
        '
        'tb_st_th5
        '
        Me.tb_st_th5.Enabled = False
        Me.tb_st_th5.Location = New System.Drawing.Point(112, 126)
        Me.tb_st_th5.Name = "tb_st_th5"
        Me.tb_st_th5.Size = New System.Drawing.Size(201, 20)
        Me.tb_st_th5.TabIndex = 145
        Me.tb_st_th5.Text = "Computer Science"
        '
        'tb_st_th4
        '
        Me.tb_st_th4.Enabled = False
        Me.tb_st_th4.Location = New System.Drawing.Point(112, 99)
        Me.tb_st_th4.Name = "tb_st_th4"
        Me.tb_st_th4.Size = New System.Drawing.Size(201, 20)
        Me.tb_st_th4.TabIndex = 144
        Me.tb_st_th4.Text = "Electronics"
        '
        'tb_st_th3
        '
        Me.tb_st_th3.Enabled = False
        Me.tb_st_th3.Location = New System.Drawing.Point(112, 73)
        Me.tb_st_th3.Name = "tb_st_th3"
        Me.tb_st_th3.Size = New System.Drawing.Size(201, 20)
        Me.tb_st_th3.TabIndex = 143
        Me.tb_st_th3.Text = "English"
        '
        'tb_st_th2
        '
        Me.tb_st_th2.Enabled = False
        Me.tb_st_th2.Location = New System.Drawing.Point(112, 49)
        Me.tb_st_th2.Name = "tb_st_th2"
        Me.tb_st_th2.Size = New System.Drawing.Size(201, 20)
        Me.tb_st_th2.TabIndex = 142
        Me.tb_st_th2.Text = "Mechanics"
        '
        'tb_st_th1
        '
        Me.tb_st_th1.Enabled = False
        Me.tb_st_th1.Location = New System.Drawing.Point(112, 23)
        Me.tb_st_th1.Name = "tb_st_th1"
        Me.tb_st_th1.Size = New System.Drawing.Size(201, 20)
        Me.tb_st_th1.TabIndex = 141
        Me.tb_st_th1.Text = "Mathematics"
        '
        'cb_st_sem
        '
        Me.cb_st_sem.FormattingEnabled = True
        Me.cb_st_sem.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cb_st_sem.Location = New System.Drawing.Point(130, 91)
        Me.cb_st_sem.Name = "cb_st_sem"
        Me.cb_st_sem.Size = New System.Drawing.Size(192, 21)
        Me.cb_st_sem.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Semester"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(217, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(16, 13)
        Me.Label24.TabIndex = 102
        Me.Label24.Text = "to"
        '
        'cb_st_ssn_end
        '
        Me.cb_st_ssn_end.FormattingEnabled = True
        Me.cb_st_ssn_end.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.cb_st_ssn_end.Location = New System.Drawing.Point(239, 11)
        Me.cb_st_ssn_end.Name = "cb_st_ssn_end"
        Me.cb_st_ssn_end.Size = New System.Drawing.Size(83, 21)
        Me.cb_st_ssn_end.TabIndex = 101
        '
        'cb_st_ssn_strt
        '
        Me.cb_st_ssn_strt.FormattingEnabled = True
        Me.cb_st_ssn_strt.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cb_st_ssn_strt.Location = New System.Drawing.Point(131, 11)
        Me.cb_st_ssn_strt.Name = "cb_st_ssn_strt"
        Me.cb_st_ssn_strt.Size = New System.Drawing.Size(80, 21)
        Me.cb_st_ssn_strt.TabIndex = 100
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(39, 13)
        Me.Label23.TabIndex = 99
        Me.Label23.Text = "Sesion"
        '
        'tb_st_cllg
        '
        Me.tb_st_cllg.Location = New System.Drawing.Point(131, 37)
        Me.tb_st_cllg.Name = "tb_st_cllg"
        Me.tb_st_cllg.Size = New System.Drawing.Size(191, 20)
        Me.tb_st_cllg.TabIndex = 98
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 97
        Me.Label22.Text = "College*"
        '
        'cb_st_strm
        '
        Me.cb_st_strm.FormattingEnabled = True
        Me.cb_st_strm.Items.AddRange(New Object() {"Computer Science", "Mechanical Engineering", "Civil Engineering", "Chemical Engineering", "Electronics Engineering", "Electrical Engineering", "Bio Technology", "Information Technology"})
        Me.cb_st_strm.Location = New System.Drawing.Point(131, 63)
        Me.cb_st_strm.Name = "cb_st_strm"
        Me.cb_st_strm.Size = New System.Drawing.Size(192, 21)
        Me.cb_st_strm.TabIndex = 96
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Stream"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tb_st_mob)
        Me.TabPage1.Controls.Add(Me.tb_st_lname)
        Me.TabPage1.Controls.Add(Me.tb_st_mname)
        Me.TabPage1.Controls.Add(Me.tb_st_fname)
        Me.TabPage1.Controls.Add(Me.tb_st_padrs)
        Me.TabPage1.Controls.Add(Me.tb_st_ladrs)
        Me.TabPage1.Controls.Add(Me.tb_st_email)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.dtp_st_dob)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(603, 357)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Student Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tb_st_mob
        '
        Me.tb_st_mob.Location = New System.Drawing.Point(135, 171)
        Me.tb_st_mob.Name = "tb_st_mob"
        Me.tb_st_mob.Size = New System.Drawing.Size(196, 20)
        Me.tb_st_mob.TabIndex = 83
        '
        'tb_st_lname
        '
        Me.tb_st_lname.Location = New System.Drawing.Point(135, 70)
        Me.tb_st_lname.Name = "tb_st_lname"
        Me.tb_st_lname.Size = New System.Drawing.Size(196, 20)
        Me.tb_st_lname.TabIndex = 82
        '
        'tb_st_mname
        '
        Me.tb_st_mname.Location = New System.Drawing.Point(135, 43)
        Me.tb_st_mname.Name = "tb_st_mname"
        Me.tb_st_mname.Size = New System.Drawing.Size(196, 20)
        Me.tb_st_mname.TabIndex = 79
        '
        'tb_st_fname
        '
        Me.tb_st_fname.Location = New System.Drawing.Point(135, 17)
        Me.tb_st_fname.Name = "tb_st_fname"
        Me.tb_st_fname.Size = New System.Drawing.Size(196, 20)
        Me.tb_st_fname.TabIndex = 78
        '
        'tb_st_padrs
        '
        Me.tb_st_padrs.Location = New System.Drawing.Point(135, 268)
        Me.tb_st_padrs.Multiline = True
        Me.tb_st_padrs.Name = "tb_st_padrs"
        Me.tb_st_padrs.Size = New System.Drawing.Size(196, 44)
        Me.tb_st_padrs.TabIndex = 77
        '
        'tb_st_ladrs
        '
        Me.tb_st_ladrs.Location = New System.Drawing.Point(135, 211)
        Me.tb_st_ladrs.Multiline = True
        Me.tb_st_ladrs.Name = "tb_st_ladrs"
        Me.tb_st_ladrs.Size = New System.Drawing.Size(196, 44)
        Me.tb_st_ladrs.TabIndex = 76
        '
        'tb_st_email
        '
        Me.tb_st_email.Location = New System.Drawing.Point(135, 144)
        Me.tb_st_email.Name = "tb_st_email"
        Me.tb_st_email.Size = New System.Drawing.Size(196, 20)
        Me.tb_st_email.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Last name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Middle Name"
        '
        'dtp_st_dob
        '
        Me.dtp_st_dob.Location = New System.Drawing.Point(135, 106)
        Me.dtp_st_dob.Name = "dtp_st_dob"
        Me.dtp_st_dob.Size = New System.Drawing.Size(196, 20)
        Me.dtp_st_dob.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Mobile No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Permanent Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Email ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Local Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Date Of Birth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "First Name"
        '
        'tc_st
        '
        Me.tc_st.Controls.Add(Me.TabPage1)
        Me.tc_st.Controls.Add(Me.TabPage2)
        Me.tc_st.Location = New System.Drawing.Point(19, 51)
        Me.tc_st.Name = "tc_st"
        Me.tc_st.SelectedIndex = 0
        Me.tc_st.Size = New System.Drawing.Size(611, 383)
        Me.tc_st.TabIndex = 89
        '
        'student_modify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 482)
        Me.Controls.Add(Me.bt_st_del)
        Me.Controls.Add(Me.tb_st_id)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.lb_st_fsts)
        Me.Controls.Add(Me.lb_st_csts)
        Me.Controls.Add(Me.bt_bck)
        Me.Controls.Add(Me.bt_rst)
        Me.Controls.Add(Me.bt_sv)
        Me.Controls.Add(Me.lb_astr)
        Me.Controls.Add(Me.tc_st)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "student_modify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Student Details"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gb_st_th.ResumeLayout(False)
        Me.gb_st_th.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.tc_st.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_st_id As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lb_st_fsts As System.Windows.Forms.Label
    Friend WithEvents lb_st_csts As System.Windows.Forms.Label
    Friend WithEvents bt_bck As System.Windows.Forms.Button
    Friend WithEvents bt_rst As System.Windows.Forms.Button
    Friend WithEvents bt_sv As System.Windows.Forms.Button
    Friend WithEvents lb_astr As System.Windows.Forms.Label
    Friend WithEvents bt_st_del As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cb_st_sem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cb_st_ssn_end As System.Windows.Forms.ComboBox
    Friend WithEvents cb_st_ssn_strt As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tb_st_cllg As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cb_st_strm As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tb_st_mob As System.Windows.Forms.TextBox
    Friend WithEvents tb_st_lname As System.Windows.Forms.TextBox
    Friend WithEvents tb_st_mname As System.Windows.Forms.TextBox
    Friend WithEvents tb_st_fname As System.Windows.Forms.TextBox
    Friend WithEvents tb_st_padrs As System.Windows.Forms.TextBox
    Friend WithEvents tb_st_ladrs As System.Windows.Forms.TextBox
    Friend WithEvents tb_st_email As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp_st_dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tc_st As System.Windows.Forms.TabControl
    Friend WithEvents gb_st_th As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_st_th5 As System.Windows.Forms.TextBox
    Friend WithEvents tb_st_th4 As System.Windows.Forms.TextBox
    Friend WithEvents tb_st_th3 As System.Windows.Forms.TextBox
    Friend WithEvents tb_st_th2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_st_th1 As System.Windows.Forms.TextBox
End Class
