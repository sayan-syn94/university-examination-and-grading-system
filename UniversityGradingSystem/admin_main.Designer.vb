<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_main
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
        Me.bt_admin_logout = New System.Windows.Forms.Button()
        Me.welcm_msg = New System.Windows.Forms.Label()
        Me.bt_gen_reslt = New System.Windows.Forms.Button()
        Me.bt_del_st_db = New System.Windows.Forms.Button()
        Me.bt_del_stf_db = New System.Windows.Forms.Button()
        Me.bt_mod_st = New System.Windows.Forms.Button()
        Me.bt_mod_stf = New System.Windows.Forms.Button()
        Me.lb_adm_csts = New System.Windows.Forms.Label()
        Me.lb_adm_fsts = New System.Windows.Forms.Label()
        Me.bt_adm_cfg = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bt_del_reslt = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_admin_logout
        '
        Me.bt_admin_logout.Location = New System.Drawing.Point(408, 424)
        Me.bt_admin_logout.Name = "bt_admin_logout"
        Me.bt_admin_logout.Size = New System.Drawing.Size(144, 23)
        Me.bt_admin_logout.TabIndex = 2
        Me.bt_admin_logout.Text = "Logout"
        Me.bt_admin_logout.UseVisualStyleBackColor = True
        '
        'welcm_msg
        '
        Me.welcm_msg.AutoSize = True
        Me.welcm_msg.Font = New System.Drawing.Font("Tempus Sans ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcm_msg.Location = New System.Drawing.Point(33, 41)
        Me.welcm_msg.Name = "welcm_msg"
        Me.welcm_msg.Size = New System.Drawing.Size(217, 35)
        Me.welcm_msg.TabIndex = 3
        Me.welcm_msg.Text = "Welcome Admin!"
        '
        'bt_gen_reslt
        '
        Me.bt_gen_reslt.Location = New System.Drawing.Point(368, 107)
        Me.bt_gen_reslt.Name = "bt_gen_reslt"
        Me.bt_gen_reslt.Size = New System.Drawing.Size(184, 27)
        Me.bt_gen_reslt.TabIndex = 4
        Me.bt_gen_reslt.Text = "Generate Student Result"
        Me.bt_gen_reslt.UseVisualStyleBackColor = True
        '
        'bt_del_st_db
        '
        Me.bt_del_st_db.Location = New System.Drawing.Point(368, 173)
        Me.bt_del_st_db.Name = "bt_del_st_db"
        Me.bt_del_st_db.Size = New System.Drawing.Size(184, 27)
        Me.bt_del_st_db.TabIndex = 5
        Me.bt_del_st_db.Text = "Delete Student Database"
        Me.bt_del_st_db.UseVisualStyleBackColor = True
        '
        'bt_del_stf_db
        '
        Me.bt_del_stf_db.Location = New System.Drawing.Point(368, 206)
        Me.bt_del_stf_db.Name = "bt_del_stf_db"
        Me.bt_del_stf_db.Size = New System.Drawing.Size(184, 27)
        Me.bt_del_stf_db.TabIndex = 6
        Me.bt_del_stf_db.Text = "Delete Staff Database"
        Me.bt_del_stf_db.UseVisualStyleBackColor = True
        '
        'bt_mod_st
        '
        Me.bt_mod_st.Location = New System.Drawing.Point(368, 272)
        Me.bt_mod_st.Name = "bt_mod_st"
        Me.bt_mod_st.Size = New System.Drawing.Size(184, 27)
        Me.bt_mod_st.TabIndex = 7
        Me.bt_mod_st.Text = "Modify Student Details"
        Me.bt_mod_st.UseVisualStyleBackColor = True
        '
        'bt_mod_stf
        '
        Me.bt_mod_stf.Location = New System.Drawing.Point(368, 239)
        Me.bt_mod_stf.Name = "bt_mod_stf"
        Me.bt_mod_stf.Size = New System.Drawing.Size(184, 27)
        Me.bt_mod_stf.TabIndex = 8
        Me.bt_mod_stf.Text = "Modify Staff Details"
        Me.bt_mod_stf.UseVisualStyleBackColor = True
        '
        'lb_adm_csts
        '
        Me.lb_adm_csts.AutoSize = True
        Me.lb_adm_csts.Location = New System.Drawing.Point(439, 13)
        Me.lb_adm_csts.Name = "lb_adm_csts"
        Me.lb_adm_csts.Size = New System.Drawing.Size(100, 13)
        Me.lb_adm_csts.TabIndex = 9
        Me.lb_adm_csts.Text = "[Connection Status]"
        '
        'lb_adm_fsts
        '
        Me.lb_adm_fsts.AutoSize = True
        Me.lb_adm_fsts.Location = New System.Drawing.Point(12, 434)
        Me.lb_adm_fsts.Name = "lb_adm_fsts"
        Me.lb_adm_fsts.Size = New System.Drawing.Size(81, 13)
        Me.lb_adm_fsts.TabIndex = 10
        Me.lb_adm_fsts.Text = "[Record Status]"
        '
        'bt_adm_cfg
        '
        Me.bt_adm_cfg.Location = New System.Drawing.Point(368, 305)
        Me.bt_adm_cfg.Name = "bt_adm_cfg"
        Me.bt_adm_cfg.Size = New System.Drawing.Size(184, 27)
        Me.bt_adm_cfg.TabIndex = 11
        Me.bt_adm_cfg.Text = "Edit Configuration FIle"
        Me.bt_adm_cfg.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UniversityGradingSystem.My.Resources.Resources.How_to_Configure_Magento_Admin_Users1
        Me.PictureBox1.Location = New System.Drawing.Point(29, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 296)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'bt_del_reslt
        '
        Me.bt_del_reslt.Location = New System.Drawing.Point(368, 140)
        Me.bt_del_reslt.Name = "bt_del_reslt"
        Me.bt_del_reslt.Size = New System.Drawing.Size(184, 27)
        Me.bt_del_reslt.TabIndex = 13
        Me.bt_del_reslt.Text = "Delete Student Marksheet"
        Me.bt_del_reslt.UseVisualStyleBackColor = True
        '
        'admin_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.bt_del_reslt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bt_adm_cfg)
        Me.Controls.Add(Me.lb_adm_fsts)
        Me.Controls.Add(Me.lb_adm_csts)
        Me.Controls.Add(Me.bt_mod_stf)
        Me.Controls.Add(Me.bt_mod_st)
        Me.Controls.Add(Me.bt_del_stf_db)
        Me.Controls.Add(Me.bt_del_st_db)
        Me.Controls.Add(Me.bt_gen_reslt)
        Me.Controls.Add(Me.welcm_msg)
        Me.Controls.Add(Me.bt_admin_logout)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "admin_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_admin_logout As System.Windows.Forms.Button
    Friend WithEvents welcm_msg As System.Windows.Forms.Label
    Friend WithEvents bt_gen_reslt As System.Windows.Forms.Button
    Friend WithEvents bt_del_st_db As System.Windows.Forms.Button
    Friend WithEvents bt_del_stf_db As System.Windows.Forms.Button
    Friend WithEvents bt_mod_st As System.Windows.Forms.Button
    Friend WithEvents bt_mod_stf As System.Windows.Forms.Button
    Friend WithEvents lb_adm_csts As System.Windows.Forms.Label
    Friend WithEvents lb_adm_fsts As System.Windows.Forms.Label
    Friend WithEvents bt_adm_cfg As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bt_del_reslt As System.Windows.Forms.Button
End Class
