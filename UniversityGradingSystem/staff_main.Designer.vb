<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_main
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_stf_name = New System.Windows.Forms.Label()
        Me.bt_st_mrks_sv = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt_stf_logout = New System.Windows.Forms.Button()
        Me.lb_stf_csts = New System.Windows.Forms.Label()
        Me.lb_stf_id = New System.Windows.Forms.Label()
        Me.lb_stf = New System.Windows.Forms.Label()
        Me.lbx_st_list = New System.Windows.Forms.ListBox()
        Me.tb_entr_mrks = New System.Windows.Forms.TextBox()
        Me.lb_stf_mrks = New System.Windows.Forms.Label()
        Me.lb_stf_mn_fsts = New System.Windows.Forms.Label()
        Me.lbx_stf_sbjt = New System.Windows.Forms.ListBox()
        Me.lb_stf_mjr = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_stf_sbmt = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome!"
        '
        'lb_stf_name
        '
        Me.lb_stf_name.AutoSize = True
        Me.lb_stf_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_stf_name.Location = New System.Drawing.Point(110, 41)
        Me.lb_stf_name.Name = "lb_stf_name"
        Me.lb_stf_name.Size = New System.Drawing.Size(59, 20)
        Me.lb_stf_name.TabIndex = 1
        Me.lb_stf_name.Text = "[Name]"
        '
        'bt_st_mrks_sv
        '
        Me.bt_st_mrks_sv.Location = New System.Drawing.Point(500, 378)
        Me.bt_st_mrks_sv.Name = "bt_st_mrks_sv"
        Me.bt_st_mrks_sv.Size = New System.Drawing.Size(75, 23)
        Me.bt_st_mrks_sv.TabIndex = 5
        Me.bt_st_mrks_sv.Text = "Save"
        Me.bt_st_mrks_sv.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Subject Teaching"
        '
        'bt_stf_logout
        '
        Me.bt_stf_logout.Location = New System.Drawing.Point(500, 38)
        Me.bt_stf_logout.Name = "bt_stf_logout"
        Me.bt_stf_logout.Size = New System.Drawing.Size(75, 23)
        Me.bt_stf_logout.TabIndex = 8
        Me.bt_stf_logout.Text = "Logout"
        Me.bt_stf_logout.UseVisualStyleBackColor = True
        '
        'lb_stf_csts
        '
        Me.lb_stf_csts.AutoSize = True
        Me.lb_stf_csts.Location = New System.Drawing.Point(461, 9)
        Me.lb_stf_csts.Name = "lb_stf_csts"
        Me.lb_stf_csts.Size = New System.Drawing.Size(100, 13)
        Me.lb_stf_csts.TabIndex = 9
        Me.lb_stf_csts.Text = "[Connection Status]"
        '
        'lb_stf_id
        '
        Me.lb_stf_id.AutoSize = True
        Me.lb_stf_id.Location = New System.Drawing.Point(77, 9)
        Me.lb_stf_id.Name = "lb_stf_id"
        Me.lb_stf_id.Size = New System.Drawing.Size(35, 13)
        Me.lb_stf_id.TabIndex = 10
        Me.lb_stf_id.Text = "XXXX"
        Me.lb_stf_id.Visible = False
        '
        'lb_stf
        '
        Me.lb_stf.AutoSize = True
        Me.lb_stf.Location = New System.Drawing.Point(25, 9)
        Me.lb_stf.Name = "lb_stf"
        Me.lb_stf.Size = New System.Drawing.Size(46, 13)
        Me.lb_stf.TabIndex = 11
        Me.lb_stf.Text = "Staff ID:"
        Me.lb_stf.Visible = False
        '
        'lbx_st_list
        '
        Me.lbx_st_list.FormattingEnabled = True
        Me.lbx_st_list.Location = New System.Drawing.Point(263, 136)
        Me.lbx_st_list.Name = "lbx_st_list"
        Me.lbx_st_list.Size = New System.Drawing.Size(312, 225)
        Me.lbx_st_list.TabIndex = 12
        '
        'tb_entr_mrks
        '
        Me.tb_entr_mrks.Location = New System.Drawing.Point(373, 378)
        Me.tb_entr_mrks.Name = "tb_entr_mrks"
        Me.tb_entr_mrks.Size = New System.Drawing.Size(108, 20)
        Me.tb_entr_mrks.TabIndex = 15
        '
        'lb_stf_mrks
        '
        Me.lb_stf_mrks.AutoSize = True
        Me.lb_stf_mrks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_stf_mrks.Location = New System.Drawing.Point(259, 378)
        Me.lb_stf_mrks.Name = "lb_stf_mrks"
        Me.lb_stf_mrks.Size = New System.Drawing.Size(95, 20)
        Me.lb_stf_mrks.TabIndex = 16
        Me.lb_stf_mrks.Text = "Enter Marks"
        '
        'lb_stf_mn_fsts
        '
        Me.lb_stf_mn_fsts.AutoSize = True
        Me.lb_stf_mn_fsts.Location = New System.Drawing.Point(18, 385)
        Me.lb_stf_mn_fsts.Name = "lb_stf_mn_fsts"
        Me.lb_stf_mn_fsts.Size = New System.Drawing.Size(62, 13)
        Me.lb_stf_mn_fsts.TabIndex = 17
        Me.lb_stf_mn_fsts.Text = "[File Status]"
        '
        'lbx_stf_sbjt
        '
        Me.lbx_stf_sbjt.FormattingEnabled = True
        Me.lbx_stf_sbjt.Location = New System.Drawing.Point(21, 168)
        Me.lbx_stf_sbjt.Name = "lbx_stf_sbjt"
        Me.lbx_stf_sbjt.Size = New System.Drawing.Size(167, 186)
        Me.lbx_stf_sbjt.TabIndex = 18
        '
        'lb_stf_mjr
        '
        Me.lb_stf_mjr.AutoSize = True
        Me.lb_stf_mjr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_stf_mjr.Location = New System.Drawing.Point(91, 94)
        Me.lb_stf_mjr.Name = "lb_stf_mjr"
        Me.lb_stf_mjr.Size = New System.Drawing.Size(56, 20)
        Me.lb_stf_mjr.TabIndex = 19
        Me.lb_stf_mjr.Text = "[Major]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Major : "
        '
        'bt_stf_sbmt
        '
        Me.bt_stf_sbmt.Location = New System.Drawing.Point(357, 38)
        Me.bt_stf_sbmt.Name = "bt_stf_sbmt"
        Me.bt_stf_sbmt.Size = New System.Drawing.Size(124, 23)
        Me.bt_stf_sbmt.TabIndex = 21
        Me.bt_stf_sbmt.Text = "Submit"
        Me.bt_stf_sbmt.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Student List"
        '
        'staff_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UniversityGradingSystem.My.Resources.Resources._2
        Me.ClientSize = New System.Drawing.Size(602, 417)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bt_stf_sbmt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lb_stf_mjr)
        Me.Controls.Add(Me.lbx_stf_sbjt)
        Me.Controls.Add(Me.lb_stf_mn_fsts)
        Me.Controls.Add(Me.lb_stf_mrks)
        Me.Controls.Add(Me.tb_entr_mrks)
        Me.Controls.Add(Me.lbx_st_list)
        Me.Controls.Add(Me.lb_stf)
        Me.Controls.Add(Me.lb_stf_id)
        Me.Controls.Add(Me.lb_stf_csts)
        Me.Controls.Add(Me.bt_stf_logout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bt_st_mrks_sv)
        Me.Controls.Add(Me.lb_stf_name)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "staff_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_stf_name As System.Windows.Forms.Label
    Friend WithEvents bt_st_mrks_sv As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_stf_logout As System.Windows.Forms.Button
    Friend WithEvents lb_stf_csts As System.Windows.Forms.Label
    Friend WithEvents lb_stf_id As System.Windows.Forms.Label
    Friend WithEvents lb_stf As System.Windows.Forms.Label
    Friend WithEvents lbx_st_list As System.Windows.Forms.ListBox
    Friend WithEvents tb_entr_mrks As System.Windows.Forms.TextBox
    Friend WithEvents lb_stf_mrks As System.Windows.Forms.Label
    Friend WithEvents lb_stf_mn_fsts As System.Windows.Forms.Label
    Friend WithEvents lbx_stf_sbjt As System.Windows.Forms.ListBox
    Friend WithEvents lb_stf_mjr As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_stf_sbmt As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
