<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducts))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbDashboard = New System.Windows.Forms.PictureBox()
        Me.pbLogOut = New System.Windows.Forms.PictureBox()
        Me.pbReports = New System.Windows.Forms.PictureBox()
        Me.pbCashier = New System.Windows.Forms.PictureBox()
        Me.pbProducts = New System.Windows.Forms.PictureBox()
        Me.pbUsers = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbTerminate = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPPrice = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.txtPCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPStocks = New System.Windows.Forms.TextBox()
        Me.dgProducts = New System.Windows.Forms.DataGridView()
        Me.pbSearch = New System.Windows.Forms.PictureBox()
        Me.cboPType = New System.Windows.Forms.ComboBox()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.pbDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(0, -13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(91, 1106)
        Me.Panel1.TabIndex = 1
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
        Me.pbProducts.BackColor = System.Drawing.Color.Green
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(137, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 51)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Products"
        '
        'pbTerminate
        '
        Me.pbTerminate.BackColor = System.Drawing.Color.Transparent
        Me.pbTerminate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTerminate.Image = CType(resources.GetObject("pbTerminate.Image"), System.Drawing.Image)
        Me.pbTerminate.Location = New System.Drawing.Point(1964, 9)
        Me.pbTerminate.Name = "pbTerminate"
        Me.pbTerminate.Size = New System.Drawing.Size(58, 57)
        Me.pbTerminate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTerminate.TabIndex = 11
        Me.pbTerminate.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1200, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 38)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Product Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1256, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 38)
        Me.Label4.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(332, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 38)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Product Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(341, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 38)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Product Code:"
        '
        'txtPPrice
        '
        Me.txtPPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPrice.Location = New System.Drawing.Point(1475, 191)
        Me.txtPPrice.Multiline = True
        Me.txtPPrice.Name = "txtPPrice"
        Me.txtPPrice.Size = New System.Drawing.Size(371, 35)
        Me.txtPPrice.TabIndex = 22
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1331, 117)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(437, 35)
        Me.txtSearch.TabIndex = 21
        '
        'txtPName
        '
        Me.txtPName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPName.Location = New System.Drawing.Point(606, 195)
        Me.txtPName.Multiline = True
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(370, 35)
        Me.txtPName.TabIndex = 20
        '
        'txtPCode
        '
        Me.txtPCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPCode.Location = New System.Drawing.Point(606, 118)
        Me.txtPCode.Multiline = True
        Me.txtPCode.Name = "txtPCode"
        Me.txtPCode.Size = New System.Drawing.Size(370, 35)
        Me.txtPCode.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1174, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(263, 38)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Product Stocks:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(346, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(234, 38)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Product Type:"
        '
        'txtPStocks
        '
        Me.txtPStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPStocks.Location = New System.Drawing.Point(1475, 255)
        Me.txtPStocks.Multiline = True
        Me.txtPStocks.Name = "txtPStocks"
        Me.txtPStocks.Size = New System.Drawing.Size(371, 35)
        Me.txtPStocks.TabIndex = 28
        '
        'dgProducts
        '
        Me.dgProducts.AllowUserToAddRows = False
        Me.dgProducts.AllowUserToDeleteRows = False
        Me.dgProducts.AllowUserToResizeColumns = False
        Me.dgProducts.AllowUserToResizeRows = False
        Me.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProducts.Location = New System.Drawing.Point(223, 380)
        Me.dgProducts.Name = "dgProducts"
        Me.dgProducts.RowHeadersWidth = 51
        Me.dgProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgProducts.RowTemplate.Height = 24
        Me.dgProducts.Size = New System.Drawing.Size(1623, 575)
        Me.dgProducts.TabIndex = 31
        '
        'pbSearch
        '
        Me.pbSearch.BackColor = System.Drawing.Color.Transparent
        Me.pbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSearch.Image = CType(resources.GetObject("pbSearch.Image"), System.Drawing.Image)
        Me.pbSearch.Location = New System.Drawing.Point(1774, 105)
        Me.pbSearch.Name = "pbSearch"
        Me.pbSearch.Size = New System.Drawing.Size(62, 54)
        Me.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSearch.TabIndex = 32
        Me.pbSearch.TabStop = False
        '
        'cboPType
        '
        Me.cboPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPType.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPType.FormattingEnabled = True
        Me.cboPType.Items.AddRange(New Object() {"MEDICINE", "GROCERY"})
        Me.cboPType.Location = New System.Drawing.Point(606, 256)
        Me.cboPType.Name = "cboPType"
        Me.cboPType.Size = New System.Drawing.Size(370, 37)
        Me.cboPType.TabIndex = 33
        '
        'mnuMain
        '
        Me.mnuMain.BackColor = System.Drawing.Color.Transparent
        Me.mnuMain.GripMargin = New System.Windows.Forms.Padding(0)
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(0)
        Me.mnuMain.Size = New System.Drawing.Size(1924, 24)
        Me.mnuMain.TabIndex = 34
        Me.mnuMain.Text = "mnuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete, Me.mnuSave, Me.mnuUpdate, Me.mnuCancel})
        Me.mnuFile.ForeColor = System.Drawing.Color.Green
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAdd.Size = New System.Drawing.Size(244, 26)
        Me.mnuAdd.Text = "&Add Product"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuEdit.Size = New System.Drawing.Size(244, 26)
        Me.mnuEdit.Text = "&Edit Product"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuDelete.Size = New System.Drawing.Size(244, 26)
        Me.mnuDelete.Text = "&Delete Product"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(244, 26)
        Me.mnuSave.Text = "&Save"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuUpdate.Size = New System.Drawing.Size(244, 26)
        Me.mnuUpdate.Text = "&Update"
        '
        'mnuCancel
        '
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCancel.Size = New System.Drawing.Size(244, 26)
        Me.mnuCancel.Text = "&Cancel"
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.cboPType)
        Me.Controls.Add(Me.pbSearch)
        Me.Controls.Add(Me.dgProducts)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPStocks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPPrice)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtPName)
        Me.Controls.Add(Me.txtPCode)
        Me.Controls.Add(Me.pbTerminate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mnuMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProducts"
        Me.Text = "frmProducts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbDashboard As PictureBox
    Friend WithEvents pbLogOut As PictureBox
    Friend WithEvents pbReports As PictureBox
    Friend WithEvents pbCashier As PictureBox
    Friend WithEvents pbProducts As PictureBox
    Friend WithEvents pbUsers As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbTerminate As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPPrice As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtPName As TextBox
    Friend WithEvents txtPCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPStocks As TextBox
    Friend WithEvents dgProducts As DataGridView
    Friend WithEvents pbSearch As PictureBox
    Friend WithEvents cboPType As ComboBox
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents mnuCancel As ToolStripMenuItem
End Class
