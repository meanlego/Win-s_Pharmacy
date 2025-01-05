<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbDashboard = New System.Windows.Forms.PictureBox()
        Me.pbLogOut = New System.Windows.Forms.PictureBox()
        Me.pbReports = New System.Windows.Forms.PictureBox()
        Me.pbCashier = New System.Windows.Forms.PictureBox()
        Me.pbProducts = New System.Windows.Forms.PictureBox()
        Me.pbUsers = New System.Windows.Forms.PictureBox()
        Me.pbTerminate = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pbDashboard)
        Me.Panel1.Controls.Add(Me.pbLogOut)
        Me.Panel1.Controls.Add(Me.pbReports)
        Me.Panel1.Controls.Add(Me.pbCashier)
        Me.Panel1.Controls.Add(Me.pbProducts)
        Me.Panel1.Controls.Add(Me.pbUsers)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(91, 1106)
        Me.Panel1.TabIndex = 0
        '
        'pbDashboard
        '
        Me.pbDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDashboard.Image = CType(resources.GetObject("pbDashboard.Image"), System.Drawing.Image)
        Me.pbDashboard.Location = New System.Drawing.Point(3, 22)
        Me.pbDashboard.Name = "pbDashboard"
        Me.pbDashboard.Size = New System.Drawing.Size(112, 81)
        Me.pbDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDashboard.TabIndex = 13
        Me.pbDashboard.TabStop = False
        '
        'pbLogOut
        '
        Me.pbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLogOut.Image = CType(resources.GetObject("pbLogOut.Image"), System.Drawing.Image)
        Me.pbLogOut.Location = New System.Drawing.Point(13, 985)
        Me.pbLogOut.Name = "pbLogOut"
        Me.pbLogOut.Size = New System.Drawing.Size(56, 50)
        Me.pbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogOut.TabIndex = 12
        Me.pbLogOut.TabStop = False
        '
        'pbReports
        '
        Me.pbReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbReports.Image = CType(resources.GetObject("pbReports.Image"), System.Drawing.Image)
        Me.pbReports.Location = New System.Drawing.Point(3, 597)
        Me.pbReports.Name = "pbReports"
        Me.pbReports.Size = New System.Drawing.Size(85, 76)
        Me.pbReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReports.TabIndex = 11
        Me.pbReports.TabStop = False
        '
        'pbCashier
        '
        Me.pbCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCashier.Image = CType(resources.GetObject("pbCashier.Image"), System.Drawing.Image)
        Me.pbCashier.Location = New System.Drawing.Point(3, 485)
        Me.pbCashier.Name = "pbCashier"
        Me.pbCashier.Size = New System.Drawing.Size(85, 76)
        Me.pbCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCashier.TabIndex = 10
        Me.pbCashier.TabStop = False
        '
        'pbProducts
        '
        Me.pbProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbProducts.Image = CType(resources.GetObject("pbProducts.Image"), System.Drawing.Image)
        Me.pbProducts.Location = New System.Drawing.Point(3, 372)
        Me.pbProducts.Name = "pbProducts"
        Me.pbProducts.Size = New System.Drawing.Size(85, 76)
        Me.pbProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProducts.TabIndex = 9
        Me.pbProducts.TabStop = False
        '
        'pbUsers
        '
        Me.pbUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUsers.Image = CType(resources.GetObject("pbUsers.Image"), System.Drawing.Image)
        Me.pbUsers.Location = New System.Drawing.Point(3, 263)
        Me.pbUsers.Name = "pbUsers"
        Me.pbUsers.Size = New System.Drawing.Size(85, 76)
        Me.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUsers.TabIndex = 8
        Me.pbUsers.TabStop = False
        '
        'pbTerminate
        '
        Me.pbTerminate.BackColor = System.Drawing.Color.Transparent
        Me.pbTerminate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTerminate.Image = CType(resources.GetObject("pbTerminate.Image"), System.Drawing.Image)
        Me.pbTerminate.Location = New System.Drawing.Point(1970, 12)
        Me.pbTerminate.Name = "pbTerminate"
        Me.pbTerminate.Size = New System.Drawing.Size(58, 57)
        Me.pbTerminate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTerminate.TabIndex = 7
        Me.pbTerminate.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(120, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 51)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Dashboard"
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(152, 120)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(491, 52)
        Me.lblWelcome.TabIndex = 9
        Me.lblWelcome.Text = "Welcome, Admin"
        '
        'lbl_Date
        '
        Me.lbl_Date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Date.Font = New System.Drawing.Font("MS Reference Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Date.Location = New System.Drawing.Point(1601, 88)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(412, 52)
        Me.lbl_Date.TabIndex = 10
        Me.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Time
        '
        Me.lbl_Time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Time.Location = New System.Drawing.Point(1662, 140)
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(276, 52)
        Me.lbl_Time.TabIndex = 11
        Me.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1942, 1102)
        Me.Controls.Add(Me.lbl_Time)
        Me.Controls.Add(Me.lbl_Date)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbTerminate)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbTerminate As PictureBox
    Friend WithEvents pbUsers As PictureBox
    Friend WithEvents pbLogOut As PictureBox
    Friend WithEvents pbReports As PictureBox
    Friend WithEvents pbCashier As PictureBox
    Friend WithEvents pbProducts As PictureBox
    Friend WithEvents pbDashboard As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lbl_Date As Label
    Friend WithEvents lbl_Time As Label
    Friend WithEvents Timer As Timer
End Class
