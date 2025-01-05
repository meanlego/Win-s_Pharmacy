<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.pbTerminate = New System.Windows.Forms.PictureBox()
        Me.pbShowPass = New System.Windows.Forms.PictureBox()
        Me.pbLogIn = New System.Windows.Forms.PictureBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.pbUnshowPass = New System.Windows.Forms.PictureBox()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShowPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUnshowPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUname
        '
        Me.txtUname.BackColor = System.Drawing.SystemColors.Window
        Me.txtUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUname.Location = New System.Drawing.Point(169, 214)
        Me.txtUname.Multiline = True
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(195, 30)
        Me.txtUname.TabIndex = 4
        '
        'pbTerminate
        '
        Me.pbTerminate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTerminate.Image = CType(resources.GetObject("pbTerminate.Image"), System.Drawing.Image)
        Me.pbTerminate.Location = New System.Drawing.Point(969, 8)
        Me.pbTerminate.Name = "pbTerminate"
        Me.pbTerminate.Size = New System.Drawing.Size(58, 57)
        Me.pbTerminate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTerminate.TabIndex = 6
        Me.pbTerminate.TabStop = False
        '
        'pbShowPass
        '
        Me.pbShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbShowPass.Image = CType(resources.GetObject("pbShowPass.Image"), System.Drawing.Image)
        Me.pbShowPass.Location = New System.Drawing.Point(371, 273)
        Me.pbShowPass.Name = "pbShowPass"
        Me.pbShowPass.Size = New System.Drawing.Size(37, 22)
        Me.pbShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShowPass.TabIndex = 7
        Me.pbShowPass.TabStop = False
        '
        'pbLogIn
        '
        Me.pbLogIn.Image = CType(resources.GetObject("pbLogIn.Image"), System.Drawing.Image)
        Me.pbLogIn.Location = New System.Drawing.Point(195, 375)
        Me.pbLogIn.Name = "pbLogIn"
        Me.pbLogIn.Size = New System.Drawing.Size(146, 44)
        Me.pbLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogIn.TabIndex = 5
        Me.pbLogIn.TabStop = False
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblResult.Location = New System.Drawing.Point(150, 172)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(258, 25)
        Me.lblResult.TabIndex = 8
        '
        'cboRole
        '
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Items.AddRange(New Object() {"ADMIN", "CASHIER"})
        Me.cboRole.Location = New System.Drawing.Point(169, 325)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(195, 30)
        Me.cboRole.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(168, 271)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(196, 27)
        Me.txtPassword.TabIndex = 10
        '
        'pbUnshowPass
        '
        Me.pbUnshowPass.BackColor = System.Drawing.Color.Transparent
        Me.pbUnshowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUnshowPass.Image = CType(resources.GetObject("pbUnshowPass.Image"), System.Drawing.Image)
        Me.pbUnshowPass.Location = New System.Drawing.Point(371, 273)
        Me.pbUnshowPass.Name = "pbUnshowPass"
        Me.pbUnshowPass.Size = New System.Drawing.Size(37, 22)
        Me.pbUnshowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUnshowPass.TabIndex = 11
        Me.pbUnshowPass.TabStop = False
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1036, 558)
        Me.Controls.Add(Me.pbUnshowPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.cboRole)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.pbShowPass)
        Me.Controls.Add(Me.pbTerminate)
        Me.Controls.Add(Me.pbLogIn)
        Me.Controls.Add(Me.txtUname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShowPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUnshowPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUname As TextBox
    Friend WithEvents pbTerminate As PictureBox
    Friend WithEvents pbShowPass As PictureBox
    Friend WithEvents pbLogIn As PictureBox
    Friend WithEvents lblResult As Label
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents pbUnshowPass As PictureBox
End Class
