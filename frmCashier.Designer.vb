<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashier))
        Me.pbTerminate = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtStocks = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgProducts = New System.Windows.Forms.DataGridView()
        Me.dgReports = New System.Windows.Forms.DataGridView()
        Me.ColumnNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.btnReceived = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbThreePercent = New System.Windows.Forms.RadioButton()
        Me.rbTwentyPercent = New System.Windows.Forms.RadioButton()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pbLogOut = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItemType = New System.Windows.Forms.TextBox()
        Me.pbAdd = New System.Windows.Forms.PictureBox()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lbl_OrderDate = New System.Windows.Forms.Label()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbTerminate
        '
        Me.pbTerminate.BackColor = System.Drawing.Color.Transparent
        Me.pbTerminate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTerminate.Image = CType(resources.GetObject("pbTerminate.Image"), System.Drawing.Image)
        Me.pbTerminate.Location = New System.Drawing.Point(1975, 12)
        Me.pbTerminate.Name = "pbTerminate"
        Me.pbTerminate.Size = New System.Drawing.Size(58, 57)
        Me.pbTerminate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTerminate.TabIndex = 7
        Me.pbTerminate.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1208, 46)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(408, 30)
        Me.txtSearch.TabIndex = 9
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(386, 142)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(408, 30)
        Me.txtItemName.TabIndex = 10
        '
        'txtItemCode
        '
        Me.txtItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(386, 99)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(408, 30)
        Me.txtItemCode.TabIndex = 11
        '
        'txtStocks
        '
        Me.txtStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStocks.Location = New System.Drawing.Point(1062, 140)
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.Size = New System.Drawing.Size(235, 30)
        Me.txtStocks.TabIndex = 12
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(1477, 141)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(190, 30)
        Me.txtQty.TabIndex = 13
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(1477, 91)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(190, 30)
        Me.txtPrice.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(212, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Item Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(903, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 29)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Item Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(941, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 29)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Stocks:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1395, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 29)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Qty:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1373, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 29)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(209, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 29)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Order Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(1056, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 29)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "SEARCH:"
        '
        'dgProducts
        '
        Me.dgProducts.AllowUserToAddRows = False
        Me.dgProducts.AllowUserToDeleteRows = False
        Me.dgProducts.AllowUserToResizeColumns = False
        Me.dgProducts.AllowUserToResizeRows = False
        Me.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProducts.EnableHeadersVisualStyles = False
        Me.dgProducts.Location = New System.Drawing.Point(37, 199)
        Me.dgProducts.MultiSelect = False
        Me.dgProducts.Name = "dgProducts"
        Me.dgProducts.ReadOnly = True
        Me.dgProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgProducts.RowTemplate.Height = 24
        Me.dgProducts.Size = New System.Drawing.Size(853, 655)
        Me.dgProducts.TabIndex = 23
        '
        'dgReports
        '
        Me.dgReports.AllowUserToAddRows = False
        Me.dgReports.AllowUserToDeleteRows = False
        Me.dgReports.AllowUserToResizeColumns = False
        Me.dgReports.AllowUserToResizeRows = False
        Me.dgReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnNumber, Me.ColumnCode, Me.ColumnName, Me.ColumnType, Me.ColumnPrice, Me.ColumnQty, Me.ColumnTotal})
        Me.dgReports.EnableHeadersVisualStyles = False
        Me.dgReports.Location = New System.Drawing.Point(922, 199)
        Me.dgReports.MultiSelect = False
        Me.dgReports.Name = "dgReports"
        Me.dgReports.ReadOnly = True
        Me.dgReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgReports.RowTemplate.Height = 24
        Me.dgReports.Size = New System.Drawing.Size(1080, 655)
        Me.dgReports.TabIndex = 24
        '
        'ColumnNumber
        '
        Me.ColumnNumber.HeaderText = "Item Number"
        Me.ColumnNumber.MinimumWidth = 2
        Me.ColumnNumber.Name = "ColumnNumber"
        Me.ColumnNumber.ReadOnly = True
        Me.ColumnNumber.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColumnCode
        '
        Me.ColumnCode.HeaderText = "Item Code"
        Me.ColumnCode.MinimumWidth = 6
        Me.ColumnCode.Name = "ColumnCode"
        Me.ColumnCode.ReadOnly = True
        '
        'ColumnName
        '
        Me.ColumnName.HeaderText = "Item Name"
        Me.ColumnName.MinimumWidth = 6
        Me.ColumnName.Name = "ColumnName"
        Me.ColumnName.ReadOnly = True
        '
        'ColumnType
        '
        Me.ColumnType.HeaderText = "Item Type"
        Me.ColumnType.MinimumWidth = 6
        Me.ColumnType.Name = "ColumnType"
        Me.ColumnType.ReadOnly = True
        '
        'ColumnPrice
        '
        Me.ColumnPrice.HeaderText = "Item Price"
        Me.ColumnPrice.MinimumWidth = 6
        Me.ColumnPrice.Name = "ColumnPrice"
        Me.ColumnPrice.ReadOnly = True
        '
        'ColumnQty
        '
        Me.ColumnQty.HeaderText = "Quantity"
        Me.ColumnQty.MinimumWidth = 6
        Me.ColumnQty.Name = "ColumnQty"
        Me.ColumnQty.ReadOnly = True
        '
        'ColumnTotal
        '
        Me.ColumnTotal.HeaderText = "Total"
        Me.ColumnTotal.MinimumWidth = 6
        Me.ColumnTotal.Name = "ColumnTotal"
        Me.ColumnTotal.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(25, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 29)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "DISCOUNT:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(457, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 62)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "PAYMENT RECEIVED:"
        '
        'txtPayment
        '
        Me.txtPayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(633, 82)
        Me.txtPayment.Multiline = True
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(155, 38)
        Me.txtPayment.TabIndex = 30
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(98, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 29)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "AMOUNT:"
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Black
        Me.lblAmount.Location = New System.Drawing.Point(249, 87)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(185, 33)
        Me.lblAmount.TabIndex = 34
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReceived
        '
        Me.btnReceived.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReceived.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceived.Location = New System.Drawing.Point(1407, 922)
        Me.btnReceived.Name = "btnReceived"
        Me.btnReceived.Size = New System.Drawing.Size(154, 39)
        Me.btnReceived.TabIndex = 35
        Me.btnReceived.Text = "RECEIVED"
        Me.btnReceived.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1407, 987)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(154, 35)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblChange)
        Me.GroupBox1.Controls.Add(Me.lblAmount)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPayment)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(223, 883)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1166, 169)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAYMENT"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbThreePercent)
        Me.GroupBox2.Controls.Add(Me.rbTwentyPercent)
        Me.GroupBox2.Location = New System.Drawing.Point(179, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 60)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'rbThreePercent
        '
        Me.rbThreePercent.AutoSize = True
        Me.rbThreePercent.Location = New System.Drawing.Point(85, 21)
        Me.rbThreePercent.Name = "rbThreePercent"
        Me.rbThreePercent.Size = New System.Drawing.Size(64, 29)
        Me.rbThreePercent.TabIndex = 1
        Me.rbThreePercent.TabStop = True
        Me.rbThreePercent.Text = "3%"
        Me.rbThreePercent.UseVisualStyleBackColor = True
        '
        'rbTwentyPercent
        '
        Me.rbTwentyPercent.AutoSize = True
        Me.rbTwentyPercent.Location = New System.Drawing.Point(6, 21)
        Me.rbTwentyPercent.Name = "rbTwentyPercent"
        Me.rbTwentyPercent.Size = New System.Drawing.Size(76, 29)
        Me.rbTwentyPercent.TabIndex = 0
        Me.rbTwentyPercent.TabStop = True
        Me.rbTwentyPercent.Text = "20%"
        Me.rbTwentyPercent.UseVisualStyleBackColor = True
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.Black
        Me.lblChange.Location = New System.Drawing.Point(963, 82)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(177, 37)
        Me.lblChange.TabIndex = 32
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(803, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 37)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "CHANGE:"
        '
        'pbLogOut
        '
        Me.pbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLogOut.Image = CType(resources.GetObject("pbLogOut.Image"), System.Drawing.Image)
        Me.pbLogOut.Location = New System.Drawing.Point(1980, 999)
        Me.pbLogOut.Name = "pbLogOut"
        Me.pbLogOut.Size = New System.Drawing.Size(71, 56)
        Me.pbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogOut.TabIndex = 35
        Me.pbLogOut.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(218, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 29)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Item Code:"
        '
        'txtItemType
        '
        Me.txtItemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemType.Location = New System.Drawing.Point(1062, 92)
        Me.txtItemType.Name = "txtItemType"
        Me.txtItemType.Size = New System.Drawing.Size(235, 30)
        Me.txtItemType.TabIndex = 38
        '
        'pbAdd
        '
        Me.pbAdd.Image = CType(resources.GetObject("pbAdd.Image"), System.Drawing.Image)
        Me.pbAdd.Location = New System.Drawing.Point(1622, 38)
        Me.pbAdd.Name = "pbAdd"
        Me.pbAdd.Size = New System.Drawing.Size(39, 38)
        Me.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAdd.TabIndex = 40
        Me.pbAdd.TabStop = False
        '
        'btnNewOrder
        '
        Me.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewOrder.Location = New System.Drawing.Point(1576, 922)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(154, 39)
        Me.btnNewOrder.TabIndex = 41
        Me.btnNewOrder.Text = "New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(1576, 987)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(154, 39)
        Me.btnDelete.TabIndex = 42
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lbl_OrderDate
        '
        Me.lbl_OrderDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_OrderDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_OrderDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_OrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OrderDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_OrderDate.Location = New System.Drawing.Point(386, 46)
        Me.lbl_OrderDate.Name = "lbl_OrderDate"
        Me.lbl_OrderDate.Size = New System.Drawing.Size(209, 29)
        Me.lbl_OrderDate.TabIndex = 43
        Me.lbl_OrderDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1906, 1008)
        Me.Controls.Add(Me.lbl_OrderDate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.pbAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtItemType)
        Me.Controls.Add(Me.pbLogOut)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgReports)
        Me.Controls.Add(Me.dgProducts)
        Me.Controls.Add(Me.btnReceived)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtStocks)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbTerminate)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCashier"
        Me.Text = "frmCashier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbTerminate As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents txtStocks As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgProducts As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents btnReceived As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pbLogOut As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtItemType As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgReports As DataGridView
    Friend WithEvents pbAdd As PictureBox
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents ColumnNumber As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCode As DataGridViewTextBoxColumn
    Friend WithEvents ColumnName As DataGridViewTextBoxColumn
    Friend WithEvents ColumnType As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrice As DataGridViewTextBoxColumn
    Friend WithEvents ColumnQty As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotal As DataGridViewTextBoxColumn
    Friend WithEvents lblChange As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_OrderDate As Label
    Friend WithEvents rbThreePercent As RadioButton
    Friend WithEvents rbTwentyPercent As RadioButton
End Class
