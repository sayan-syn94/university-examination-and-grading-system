<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_login
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
        Me.bt_st_bck = New System.Windows.Forms.Button()
        Me.bt_st_getres = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_st_sem = New System.Windows.Forms.ComboBox()
        Me.tb_st_entr_rll = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_sgn_up = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_st_bck
        '
        Me.bt_st_bck.Location = New System.Drawing.Point(502, 344)
        Me.bt_st_bck.Name = "bt_st_bck"
        Me.bt_st_bck.Size = New System.Drawing.Size(70, 23)
        Me.bt_st_bck.TabIndex = 16
        Me.bt_st_bck.Text = "Back"
        Me.bt_st_bck.UseVisualStyleBackColor = True
        '
        'bt_st_getres
        '
        Me.bt_st_getres.Location = New System.Drawing.Point(376, 344)
        Me.bt_st_getres.Name = "bt_st_getres"
        Me.bt_st_getres.Size = New System.Drawing.Size(111, 23)
        Me.bt_st_getres.TabIndex = 13
        Me.bt_st_getres.Text = "Get Result"
        Me.bt_st_getres.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(372, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Semester"
        '
        'cb_st_sem
        '
        Me.cb_st_sem.FormattingEnabled = True
        Me.cb_st_sem.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cb_st_sem.Location = New System.Drawing.Point(502, 299)
        Me.cb_st_sem.Name = "cb_st_sem"
        Me.cb_st_sem.Size = New System.Drawing.Size(70, 21)
        Me.cb_st_sem.TabIndex = 11
        '
        'tb_st_entr_rll
        '
        Me.tb_st_entr_rll.Location = New System.Drawing.Point(502, 264)
        Me.tb_st_entr_rll.Name = "tb_st_entr_rll"
        Me.tb_st_entr_rll.Size = New System.Drawing.Size(70, 20)
        Me.tb_st_entr_rll.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Registration ID"
        '
        'bt_sgn_up
        '
        Me.bt_sgn_up.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_sgn_up.Location = New System.Drawing.Point(12, 344)
        Me.bt_sgn_up.Name = "bt_sgn_up"
        Me.bt_sgn_up.Size = New System.Drawing.Size(205, 23)
        Me.bt_sgn_up.TabIndex = 17
        Me.bt_sgn_up.Text = "Sign Up Here!"
        Me.bt_sgn_up.UseVisualStyleBackColor = True
        '
        'student_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UniversityGradingSystem.My.Resources.Resources.university_2325478b
        Me.ClientSize = New System.Drawing.Size(584, 379)
        Me.Controls.Add(Me.bt_st_bck)
        Me.Controls.Add(Me.bt_sgn_up)
        Me.Controls.Add(Me.bt_st_getres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_st_sem)
        Me.Controls.Add(Me.tb_st_entr_rll)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "student_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_st_getres As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_st_sem As System.Windows.Forms.ComboBox
    Friend WithEvents tb_st_entr_rll As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_st_bck As System.Windows.Forms.Button
    Friend WithEvents bt_sgn_up As System.Windows.Forms.Button
End Class
