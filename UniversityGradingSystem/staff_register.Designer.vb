<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_register
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
        Me.bt_stf_rst = New System.Windows.Forms.Button()
        Me.bt_stf_sv = New System.Windows.Forms.Button()
        Me.bt_stf_bck = New System.Windows.Forms.Button()
        Me.lb_stf_csts = New System.Windows.Forms.Label()
        Me.lb_stf_fsts = New System.Windows.Forms.Label()
        Me.tb_stf_mob = New System.Windows.Forms.TextBox()
        Me.cb_mjr = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_lname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_mname = New System.Windows.Forms.TextBox()
        Me.tb_fname = New System.Windows.Forms.TextBox()
        Me.tb_padrs = New System.Windows.Forms.TextBox()
        Me.tb_ladrs = New System.Windows.Forms.TextBox()
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.dtp_stf_dob = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bt_stf_rst
        '
        Me.bt_stf_rst.Location = New System.Drawing.Point(402, 527)
        Me.bt_stf_rst.Name = "bt_stf_rst"
        Me.bt_stf_rst.Size = New System.Drawing.Size(75, 23)
        Me.bt_stf_rst.TabIndex = 1
        Me.bt_stf_rst.Text = "Reset"
        Me.bt_stf_rst.UseVisualStyleBackColor = True
        '
        'bt_stf_sv
        '
        Me.bt_stf_sv.Location = New System.Drawing.Point(321, 527)
        Me.bt_stf_sv.Name = "bt_stf_sv"
        Me.bt_stf_sv.Size = New System.Drawing.Size(75, 23)
        Me.bt_stf_sv.TabIndex = 2
        Me.bt_stf_sv.Text = "Save"
        Me.bt_stf_sv.UseVisualStyleBackColor = True
        '
        'bt_stf_bck
        '
        Me.bt_stf_bck.Location = New System.Drawing.Point(484, 527)
        Me.bt_stf_bck.Name = "bt_stf_bck"
        Me.bt_stf_bck.Size = New System.Drawing.Size(75, 23)
        Me.bt_stf_bck.TabIndex = 3
        Me.bt_stf_bck.Text = "Back"
        Me.bt_stf_bck.UseVisualStyleBackColor = True
        '
        'lb_stf_csts
        '
        Me.lb_stf_csts.AutoSize = True
        Me.lb_stf_csts.Location = New System.Drawing.Point(478, 9)
        Me.lb_stf_csts.Name = "lb_stf_csts"
        Me.lb_stf_csts.Size = New System.Drawing.Size(94, 13)
        Me.lb_stf_csts.TabIndex = 4
        Me.lb_stf_csts.Text = "Connection Status"
        '
        'lb_stf_fsts
        '
        Me.lb_stf_fsts.AutoSize = True
        Me.lb_stf_fsts.Location = New System.Drawing.Point(12, 540)
        Me.lb_stf_fsts.Name = "lb_stf_fsts"
        Me.lb_stf_fsts.Size = New System.Drawing.Size(56, 13)
        Me.lb_stf_fsts.TabIndex = 5
        Me.lb_stf_fsts.Text = "File Status"
        '
        'tb_stf_mob
        '
        Me.tb_stf_mob.Location = New System.Drawing.Point(206, 302)
        Me.tb_stf_mob.Name = "tb_stf_mob"
        Me.tb_stf_mob.Size = New System.Drawing.Size(253, 20)
        Me.tb_stf_mob.TabIndex = 109
        '
        'cb_mjr
        '
        Me.cb_mjr.FormattingEnabled = True
        Me.cb_mjr.Items.AddRange(New Object() {"Management", "Mathematics", "Mechanics", "Computer Science", "English", "Electronics"})
        Me.cb_mjr.Location = New System.Drawing.Point(206, 214)
        Me.cb_mjr.Name = "cb_mjr"
        Me.cb_mjr.Size = New System.Drawing.Size(253, 21)
        Me.cb_mjr.TabIndex = 108
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Major"
        '
        'tb_lname
        '
        Me.tb_lname.Location = New System.Drawing.Point(206, 132)
        Me.tb_lname.Name = "tb_lname"
        Me.tb_lname.Size = New System.Drawing.Size(253, 20)
        Me.tb_lname.TabIndex = 106
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Last Name*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Middle Name"
        '
        'tb_mname
        '
        Me.tb_mname.Location = New System.Drawing.Point(206, 91)
        Me.tb_mname.Name = "tb_mname"
        Me.tb_mname.Size = New System.Drawing.Size(253, 20)
        Me.tb_mname.TabIndex = 103
        '
        'tb_fname
        '
        Me.tb_fname.Location = New System.Drawing.Point(206, 50)
        Me.tb_fname.Name = "tb_fname"
        Me.tb_fname.Size = New System.Drawing.Size(253, 20)
        Me.tb_fname.TabIndex = 102
        '
        'tb_padrs
        '
        Me.tb_padrs.Location = New System.Drawing.Point(207, 433)
        Me.tb_padrs.Multiline = True
        Me.tb_padrs.Name = "tb_padrs"
        Me.tb_padrs.Size = New System.Drawing.Size(252, 70)
        Me.tb_padrs.TabIndex = 101
        '
        'tb_ladrs
        '
        Me.tb_ladrs.Location = New System.Drawing.Point(206, 346)
        Me.tb_ladrs.Multiline = True
        Me.tb_ladrs.Name = "tb_ladrs"
        Me.tb_ladrs.Size = New System.Drawing.Size(252, 70)
        Me.tb_ladrs.TabIndex = 100
        '
        'tb_email
        '
        Me.tb_email.Location = New System.Drawing.Point(206, 256)
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(253, 20)
        Me.tb_email.TabIndex = 99
        '
        'dtp_stf_dob
        '
        Me.dtp_stf_dob.Location = New System.Drawing.Point(206, 173)
        Me.dtp_stf_dob.Name = "dtp_stf_dob"
        Me.dtp_stf_dob.Size = New System.Drawing.Size(253, 20)
        Me.dtp_stf_dob.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Mobile No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 433)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 20)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Permanent Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Email ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Local Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Date Of Birth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "First Name*"
        '
        'staff_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UniversityGradingSystem.My.Resources.Resources._2
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.tb_stf_mob)
        Me.Controls.Add(Me.cb_mjr)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tb_lname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_mname)
        Me.Controls.Add(Me.tb_fname)
        Me.Controls.Add(Me.tb_padrs)
        Me.Controls.Add(Me.tb_ladrs)
        Me.Controls.Add(Me.tb_email)
        Me.Controls.Add(Me.dtp_stf_dob)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb_stf_fsts)
        Me.Controls.Add(Me.lb_stf_csts)
        Me.Controls.Add(Me.bt_stf_bck)
        Me.Controls.Add(Me.bt_stf_sv)
        Me.Controls.Add(Me.bt_stf_rst)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "staff_register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_stf_rst As System.Windows.Forms.Button
    Friend WithEvents bt_stf_sv As System.Windows.Forms.Button
    Friend WithEvents bt_stf_bck As System.Windows.Forms.Button
    Friend WithEvents lb_stf_csts As System.Windows.Forms.Label
    Friend WithEvents lb_stf_fsts As System.Windows.Forms.Label
    Friend WithEvents tb_stf_mob As System.Windows.Forms.TextBox
    Friend WithEvents cb_mjr As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_mname As System.Windows.Forms.TextBox
    Friend WithEvents tb_fname As System.Windows.Forms.TextBox
    Friend WithEvents tb_padrs As System.Windows.Forms.TextBox
    Friend WithEvents tb_ladrs As System.Windows.Forms.TextBox
    Friend WithEvents tb_email As System.Windows.Forms.TextBox
    Friend WithEvents dtp_stf_dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
