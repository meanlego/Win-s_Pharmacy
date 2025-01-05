Imports System.Data.OleDb

Public Class frmCashier
    Private Sub frmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getProduct_records()
        Call Clear_TextBoxes()

        lbl_OrderDate.Text = DateTime.Now.ToString("dd/MM/yyyy")
        dgProducts.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        dgReports.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
    End Sub
    Private Sub pbTerminate_Click(sender As Object, e As EventArgs) Handles pbTerminate.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to terminate the application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Terminate Application")

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub pbLogOut_Click(sender As Object, e As EventArgs) Handles pbLogOut.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to Log Out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Log Out Account")
        If result = DialogResult.Yes Then
            frmLogIn.Clear()
            frmLogIn.Show()
            Me.Hide()
        End If
    End Sub
    Sub getProduct_records()
        Call database_connection()
        dbADAP = New OleDb.OleDbDataAdapter("select * from tblProducts", dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblProducts")

        Call displayProduct_records()
        Call Lock_TextBoxes()
    End Sub
    Sub displayProduct_records()
        dbDS.Tables("tblProducts").AcceptChanges()
        dgProducts.DataSource = Nothing
        dgProducts.DataSource = dbDS.Tables("tblProducts")
        dgProducts.Enabled = True
    End Sub
    Sub getReports_records()
        Call database_connection()
        dbADAP = New OleDb.OleDbDataAdapter("select * from tblReports", dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblReports")

        Call Lock_TextBoxes()
        Call displayReports_records()
    End Sub
    Sub displayReports_records()
        dbDS.Tables("tblReports").AcceptChanges()
        dgReports.DataSource = Nothing
        dgReports.DataSource = dbDS.Tables("tblReports")
        dgReports.Enabled = True
    End Sub
    Sub Clear_TextBoxes()
        txtItemCode.Clear()
        txtItemName.Clear()
        txtItemType.Clear()
        txtPrice.Clear()
        txtQty.Clear()
        txtStocks.Clear()
        txtPayment.Clear()
        lblAmount.Text = Nothing
        lblChange.Text = Nothing
    End Sub

    Sub Lock_TextBoxes()
        txtItemCode.ReadOnly = True
        txtItemName.ReadOnly = True
        txtItemType.ReadOnly = True
        txtPrice.ReadOnly = True
        txtStocks.ReadOnly = True

    End Sub
    Sub Unlock_TextBoxes()
        txtItemCode.ReadOnly = False
        txtItemName.ReadOnly = False
        txtItemType.ReadOnly = False
        txtPrice.ReadOnly = False
        txtStocks.ReadOnly = False

    End Sub

    Private Sub pbAdd_Click(sender As Object, e As EventArgs) Handles pbAdd.Click
        If dgProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to add.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim newQty As Integer
        If Not Integer.TryParse(txtQty.Text, newQty) Or newQty <= 0 Then
            MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Call Connection_State()

        Try
            Dim selectedRow As DataGridViewRow = dgProducts.SelectedRows(0)
            Dim productCode As String = selectedRow.Cells("Product Code").Value.ToString()

            Dim query As String = "SELECT * FROM tblProducts WHERE [Product Code] = @ProductCode"
            Using dbCMD As New OleDb.OleDbCommand(query, dbCON)
                dbCMD.Parameters.AddWithValue("@ProductCode", productCode)

                dbDR = dbCMD.ExecuteReader()
                While dbDR.Read()

                    Dim currentStock As Integer = Convert.ToInt32(dbDR.Item("Product Stocks"))


                    If currentStock <= 0 Then
                        MsgBox("Insufficient stock. Unable to add product.", MsgBoxStyle.Exclamation, "Stock Error")
                        Exit Sub
                    End If

                    If newQty > currentStock Then
                        MsgBox("Requested quantity exceeds available stock.", MsgBoxStyle.Exclamation, "Stock Error")
                        Exit Sub
                    End If

                    Dim price As Decimal = Convert.ToDecimal(dbDR.Item("Product Price"))
                    Dim total As Decimal = price * newQty
                    dgReports.Rows.Add(New Object() {
                    dgReports.Rows.Count + 1,
                    dbDR.Item("Product Code").ToString(),
                    dbDR.Item("Product Name").ToString(),
                    dbDR.Item("Product Type").ToString(),
                    price.ToString("F2"),
                    newQty,
                    total.ToString("F2")
                })

                    Dim updatedStock As Integer = currentStock - newQty
                    Dim updateQuery As String = "UPDATE tblProducts SET [Product Stocks] = @UpdatedStock WHERE [Product Code] = @ProductCode"
                    Using updateCMD As New OleDb.OleDbCommand(updateQuery, dbCON)
                        updateCMD.Parameters.AddWithValue("@UpdatedStock", updatedStock)
                        updateCMD.Parameters.AddWithValue("@ProductCode", productCode)
                        updateCMD.ExecuteNonQuery()
                    End Using
                End While
            End Using

            txtQty.Clear()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dbCON IsNot Nothing AndAlso dbCON.State = ConnectionState.Open Then
                dbCON.Close()
            End If
        End Try

        For i = 0 To dgReports.Rows.Count - 1
            totalAmount += CDec(dgReports.Rows(i).Cells("ColumnTotal").Value)
        Next

        lblAmount.Text = totalAmount.ToString("₱#,##0.00")
    End Sub


    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        Dim newQty As Integer
        If Not Integer.TryParse(txtQty.Text, newQty) OrElse newQty <= 0 Then
            Exit Sub
        End If

        If dgReports.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = dgReports.SelectedRows(0)
        selectedRow.Cells("Quantity").Value = newQty

        Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells("Item Price").Value)
        Dim newTotal As Decimal = newQty * price

        selectedRow.Cells("Total").Value = newTotal.ToString("F2")
    End Sub



    Private Sub dgProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgProducts.SelectionChanged
        If dgProducts.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = dgProducts.CurrentRow

            txtItemCode.Text = selectedRow.Cells("Product Code")?.Value?.ToString()
            txtItemName.Text = selectedRow.Cells("Product Name")?.Value?.ToString()
            txtPrice.Text = selectedRow.Cells("Product Price")?.Value?.ToString()
            txtItemType.Text = selectedRow.Cells("Product Type")?.Value?.ToString()
            txtStocks.Text = selectedRow.Cells("Product Stocks")?.Value?.ToString()

        End If
    End Sub

    Private Sub btnReceived_Click(sender As Object, e As EventArgs) Handles btnReceived.Click
        Dim payment As Decimal
        If Decimal.TryParse(txtPayment.Text, payment) Then
            Dim totalAmount As Decimal
            If Decimal.TryParse(lblAmount.Text.Replace("₱", "").Trim(), totalAmount) Then
                If payment >= totalAmount Then
                    Dim change As Decimal = payment - totalAmount
                    lblChange.Text = change.ToString("₱#,##0.00")

                    SaveDataToDatabase()
                    RefreshSalesData()

                    Dim result As DialogResult = MessageBox.Show(
                    $"Change: {change.ToString("₱#,##0.00")}",
                    "Payment Confirmation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information
                )
                    If result = DialogResult.OK Then
                        ResetOrder()
                    End If

                    Dim frm As New frmReports()
                    frm.getSales_records()
                Else
                    MessageBox.Show("Payment is insufficient. Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Error parsing the total amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid payment amount. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ResetOrder()
        txtPayment.Clear()
        lblAmount.Text = "₱0.00"
        lblChange.Text = "₱0.00"
        dgReports.DataSource = Nothing
        dgReports.Rows.Clear()
    End Sub
    Private Sub RefreshSalesData()
        Dim frm As New frmReports
        frm.dgvInventorySales.Refresh()
    End Sub


    Sub SaveDataToDatabase()
        Connection_State()

        For Each row As DataGridViewRow In dgReports.Rows
            If row.IsNewRow Then Continue For

            Dim discountPercentage As Double = 0
            Dim totalAmount As Decimal = Convert.ToDecimal(lblAmount.Text.Replace("₱", "").Trim())
            Dim discountedAmount As Decimal = totalAmount

            If rbThreePercent.Checked Then
                discountPercentage = 3
                discountedAmount = totalAmount - (totalAmount * 0.03D)
            ElseIf rbTwentyPercent.Checked Then
                discountPercentage = 20
                discountedAmount = totalAmount - (totalAmount * 0.2D)
            End If

            Dim query As String = "INSERT INTO tblSales ([Order Date], [Item Code], [Item Name], [Type], [Price], [Qty], [Total], [Discount], [Amount], [Payment], [Change]) " &
                              "VALUES (@OrderDate, @ItemCode, @ItemName, @Type, @Price, @Qty, @Total, @Discount, @Amount, @Payment, @Change)"

            Using dbCMD As New OleDbCommand(query, dbCON)
                dbCMD.Parameters.Add("@OrderDate", OleDbType.Date).Value = DateTime.Now
                dbCMD.Parameters.Add("@ItemCode", OleDbType.VarChar).Value = row.Cells("ColumnCode").Value.ToString()
                dbCMD.Parameters.Add("@ItemName", OleDbType.VarChar).Value = row.Cells("ColumnName").Value.ToString()
                dbCMD.Parameters.Add("@Type", OleDbType.VarChar).Value = row.Cells("ColumnType").Value.ToString()
                dbCMD.Parameters.Add("@Price", OleDbType.Decimal).Value = Convert.ToDecimal(row.Cells("ColumnPrice").Value)
                dbCMD.Parameters.Add("@Qty", OleDbType.Integer).Value = Convert.ToInt32(row.Cells("ColumnQty").Value)
                dbCMD.Parameters.Add("@Total", OleDbType.Decimal).Value = Convert.ToDecimal(row.Cells("ColumnTotal").Value)
                dbCMD.Parameters.Add("@Discount", OleDbType.Double).Value = discountPercentage ' Add discount value
                dbCMD.Parameters.Add("@Amount", OleDbType.Decimal).Value = discountedAmount ' Use discounted amount
                dbCMD.Parameters.Add("@Payment", OleDbType.Decimal).Value = Convert.ToDecimal(txtPayment.Text)
                dbCMD.Parameters.Add("@Change", OleDbType.Decimal).Value = Convert.ToDecimal(lblChange.Text.Replace("₱", "").Trim())

                dbCMD.ExecuteNonQuery()
            End Using
        Next
    End Sub


    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        Call Connection_State()
        If dgReports.Rows.Count = 0 Then
            MessageBox.Show("There are no items for this order.", "No Items in Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want New Order?",
                                                     "New Order",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                For Each row As DataGridViewRow In dgReports.Rows
                    If row.IsNewRow Then Continue For

                    Dim productCode As String = row.Cells("ColumnCode").Value.ToString()
                    Dim qty As Integer = Convert.ToInt32(row.Cells("ColumnQty").Value)

                    Dim query As String = "UPDATE tblProducts SET [Product Stocks] = [Product Stocks] + @Qty WHERE [Product Code] = @ProductCode"
                    Using dbCMD As New OleDb.OleDbCommand(query, dbCON)
                        dbCMD.Parameters.AddWithValue("@Qty", qty)
                        dbCMD.Parameters.AddWithValue("@ProductCode", productCode)
                        dbCMD.ExecuteNonQuery()
                    End Using
                Next

                Call Clear_TextBoxes()
                dgReports.Rows.Clear()
                lblAmount.Text = "₱0.00"
                lblChange.Text = "₱0.00"
            Catch ex As Exception
                MessageBox.Show("An error occurred while canceling the transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call Connection_State()

        If dgReports.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to permanently delete this record?", "Deleting Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Dim selectedRowIndex As Integer = dgReports.SelectedRows(0).Index
                Dim productCode As String = dgReports.Rows(selectedRowIndex).Cells("ColumnCode").Value.ToString()
                Dim qty As Integer = Convert.ToInt32(dgReports.Rows(selectedRowIndex).Cells("ColumnQty").Value)

                Dim restoreQuery As String = "UPDATE tblProducts SET [Product Stocks] = [Product Stocks] + @Qty WHERE [Product Code] = @ProductCode"
                Using restoreCMD As New OleDb.OleDbCommand(restoreQuery, dbCON)
                    restoreCMD.Parameters.AddWithValue("@Qty", qty)
                    restoreCMD.Parameters.AddWithValue("@ProductCode", productCode)
                    restoreCMD.ExecuteNonQuery()
                End Using

                dgReports.Rows.RemoveAt(selectedRowIndex)

                Dim totalAmount As Decimal = 0
                For Each row As DataGridViewRow In dgReports.Rows
                    totalAmount += Convert.ToDecimal(row.Cells("ColumnTotal").Value)
                Next
                lblAmount.Text = totalAmount.ToString("₱#,##0.00")

                MessageBox.Show("Record deleted and stock restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("An error occurred while deleting the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not String.IsNullOrEmpty(txtSearch.Text) Then
            dbADAP = New OleDb.OleDbDataAdapter("SELECT * FROM tblProducts WHERE [Product Code] LIKE '%" & txtSearch.Text & "%' OR [Product Name] LIKE '%" & txtSearch.Text & "%' OR [Product Type] LIKE '%" & txtSearch.Text & "%'", dbCON)
            dbDS = New DataSet()
            dbADAP.Fill(dbDS, "tblProducts")

            Dim dt As DataTable = dbDS.Tables("tblProducts")

            If dt.Rows.Count > 0 Then
                dgProducts.DataSource = dt

                txtItemCode.Text = dt.Rows(0)("Product Code").ToString()
                txtItemName.Text = dt.Rows(0)("Product Name").ToString()
                txtPrice.Text = dt.Rows(0)("Product Price").ToString()
                txtItemType.Text = dt.Rows(0)("Product Type").ToString()
                txtStocks.Text = dt.Rows(0)("Product Stocks").ToString()
            End If
        Else
            Call getProduct_records()
            Call Clear_TextBoxes()
        End If
    End Sub

    Private originalTotalAmount As Decimal
    Private Sub rbThreePercent_CheckedChanged(sender As Object, e As EventArgs) Handles rbThreePercent.CheckedChanged
        If rbThreePercent.Checked Then
            Dim discountedAmount = totalAmount - (totalAmount * 0.03D)
            lblAmount.Text = discountedAmount.ToString("₱#,##0.00")
        End If
    End Sub

    Private Sub rbTwentyPercent_CheckedChanged(sender As Object, e As EventArgs) Handles rbTwentyPercent.CheckedChanged
        If rbTwentyPercent.Checked Then
            Dim discountedAmount = totalAmount - (totalAmount * 0.2D)
            lblAmount.Text = discountedAmount.ToString("₱#,##0.00")
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call Connection_State()
        If dgReports.Rows.Count = 0 Then
            MessageBox.Show("There are no items to cancel in the transaction.", "No Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel the transaction?",
                                                     "Cancel Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                For Each row As DataGridViewRow In dgReports.Rows
                    If row.IsNewRow Then Continue For

                    Dim productCode As String = row.Cells("ColumnCode").Value.ToString()
                    Dim qty As Integer = Convert.ToInt32(row.Cells("ColumnQty").Value)

                    Dim query As String = "UPDATE tblProducts SET [Product Stocks] = [Product Stocks] + @Qty WHERE [Product Code] = @ProductCode"
                    Using dbCMD As New OleDb.OleDbCommand(query, dbCON)
                        dbCMD.Parameters.AddWithValue("@Qty", qty)
                        dbCMD.Parameters.AddWithValue("@ProductCode", productCode)
                        dbCMD.ExecuteNonQuery()
                    End Using
                Next

                Call Clear_TextBoxes()
                dgReports.Rows.Clear()
                lblAmount.Text = "₱0.00"
                lblChange.Text = "₱0.00"

                MessageBox.Show("Transaction canceled successfully. Stocks have been restored.", "Transaction Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("An error occurred while canceling the transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



End Class