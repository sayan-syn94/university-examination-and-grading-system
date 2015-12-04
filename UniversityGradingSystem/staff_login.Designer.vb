<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_login
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
        Me.mb_stf_pswrd = New System.Windows.Forms.MaskedTextBox()
        Me.tb_stf_id = New System.Windows.Forms.TextBox()
        Me.bt_staff_back = New System.Windows.Forms.Button()
        Me.bt_staff_login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_sgn_up = New System.Windows.Forms.Button()
        Me.ll_stf_pswrd = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mb_stf_pswrd
        '
        Me.mb_stf_pswrd.Location = New System.Drawing.Point(403, 120)
        Me.mb_stf_pswrd.Name = "mb_stf_pswrd"
        Me.mb_stf_pswrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mb_stf_pswrd.Size = New System.Drawing.Size(131, 20)
        Me.mb_stf_pswrd.TabIndex = 12
        '
        'tb_stf_id
        '
        Me.tb_stf_id.Location = New System.Drawing.Point(403, 87)
        Me.tb_stf_id.Name = "tb_stf_id"
        Me.tb_stf_id.Size = New System.Drawing.Size(131, 20)
        Me.tb_stf_id.TabIndex = 11
        '
        'bt_staff_back
        '
        Me.bt_staff_back.Location = New System.Drawing.Point(478, 160)
        Me.bt_staff_back.Name = "bt_staff_back"
        Me.bt_staff_back.Size = New System.Drawing.Size(75, 23)
        Me.bt_staff_back.TabIndex = 10
        Me.bt_staff_back.Text = "Back"
        Me.bt_staff_back.UseVisualStyleBackColor = True
        '
        'bt_staff_login
        '
        Me.bt_staff_login.Location = New System.Drawing.Point(391, 160)
        Me.bt_staff_login.Name = "bt_staff_login"
        Me.bt_staff_login.Size = New System.Drawing.Size(75, 23)
        Me.bt_staff_login.TabIndex = 9
        Me.bt_staff_login.Text = "Login"
        Me.bt_staff_login.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'bt_sgn_up
        '
        Me.bt_sgn_up.Location = New System.Drawing.Point(298, 160)
        Me.bt_sgn_up.Name = "bt_sgn_up"
        Me.bt_sgn_up.Size = New System.Drawing.Size(75, 23)
        Me.bt_sgn_up.TabIndex = 13
        Me.bt_sgn_up.Text = "Sign Up"
        Me.bt_sgn_up.UseVisualStyleBackColor = True
        '
        'll_stf_pswrd
        '
        Me.ll_stf_pswrd.AutoSize = True
        Me.ll_stf_pswrd.Location = New System.Drawing.Point(461, 199)
        Me.ll_stf_pswrd.Name = "ll_stf_pswrd"
        Me.ll_stf_pswrd.Size = New System.Drawing.Size(92, 13)
        Me.ll_stf_pswrd.TabIndex = 14
        Me.ll_stf_pswrd.TabStop = True
        Me.ll_stf_pswrd.Text = "Forgot Password?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UniversityGradingSystem.My.Resources.Resources.staff2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 254)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'staff_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 280)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ll_stf_pswrd)
        Me.Controls.Add(Me.bt_sgn_up)
        Me.Controls.Add(Me.mb_stf_pswrd)
        Me.Controls.Add(Me.tb_stf_id)
        Me.Controls.Add(Me.bt_staff_back)
        Me.Controls.Add(Me.bt_staff_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "staff_login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mb_stf_pswrd As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tb_stf_id As System.Windows.Forms.TextBox
    Friend WithEvents bt_staff_back As System.Windows.Forms.Button
    Friend WithEvents bt_staff_login As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_sgn_up As System.Windows.Forms.Button
    Friend WithEvents ll_stf_pswrd As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
