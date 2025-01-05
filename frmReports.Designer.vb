<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbDashboard = New System.Windows.Forms.PictureBox()
        Me.pbLogOut = New System.Windows.Forms.PictureBox()
        Me.pbReports = New System.Windows.Forms.PictureBox()
        Me.pbCashier = New System.Windows.Forms.PictureBox()
        Me.pbProducts = New System.Windows.Forms.PictureBox()
        Me.pbUsers = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbTerminate = New System.Windows.Forms.PictureBox()
        Me.dgvInventorySales = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pbDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventorySales, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(-1, -10)
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
        Me.pbReports.BackColor = System.Drawing.Color.Green
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(130, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 51)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Reports"
        '
        'pbTerminate
        '
        Me.pbTerminate.BackColor = System.Drawing.Color.Transparent
        Me.pbTerminate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTerminate.Image = CType(resources.GetObject("pbTerminate.Image"), System.Drawing.Image)
        Me.pbTerminate.Location = New System.Drawing.Point(1943, 12)
        Me.pbTerminate.Name = "pbTerminate"
        Me.pbTerminate.Size = New System.Drawing.Size(58, 57)
        Me.pbTerminate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTerminate.TabIndex = 10
        Me.pbTerminate.TabStop = False
        '
        'dgvInventorySales
        '
        Me.dgvInventorySales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventorySales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvInventorySales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInventorySales.ColumnHeadersHeight = 29
        Me.dgvInventorySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventorySales.Location = New System.Drawing.Point(188, 126)
        Me.dgvInventorySales.Name = "dgvInventorySales"
        Me.dgvInventorySales.ReadOnly = True
        Me.dgvInventorySales.RowHeadersWidth = 51
        Me.dgvInventorySales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvInventorySales.RowTemplate.Height = 24
        Me.dgvInventorySales.Size = New System.Drawing.Size(1669, 813)
        Me.dgvInventorySales.TabIndex = 11
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1405, 57)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(342, 43)
        Me.txtSearch.TabIndex = 12
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Green
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(1589, 976)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(99, 51)
        Me.btnExport.TabIndex = 13
        Me.btnExport.Text = "Print"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(638, 971)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(246, 56)
        Me.lblTotalSales.TabIndex = 14
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalItems
        '
        Me.lblTotalItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItems.Location = New System.Drawing.Point(1261, 971)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(246, 55)
        Me.lblTotalItems.TabIndex = 15
        Me.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(398, 981)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 39)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total Sales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(931, 979)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(289, 39)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total Items Sold:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Green
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(1725, 974)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 51)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalItems)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvInventorySales)
        Me.Controls.Add(Me.pbTerminate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventorySales, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvInventorySales As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnExport As Button
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDelete As Button
End Class
