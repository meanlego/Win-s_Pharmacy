Imports System.Data.OleDb

Public Class frmReports
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call getSales_records()
        Call displaySales_records()
        Call CalculateTotals()

        dgvInventorySales.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)

        Sizes()
    End Sub


    Private Sub pbTerminate_Click(sender As Object, e As EventArgs) Handles pbTerminate.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to terminate the application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Terminate Application")

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Public Sub getSales_records()
        Call database_connection()
        dbADAP = New OleDb.OleDbDataAdapter("SELECT * FROM tblSales", dbCON)
        dbDS = New DataSet()
        dbADAP.Fill(dbDS, "tblSales")
        Call displaySales_records()
    End Sub

    Private Sub displaySales_records()
        dbDS.Tables("tblSales").AcceptChanges()

        dgvInventorySales.DataSource = Nothing
        dgvInventorySales.DataSource = dbDS.Tables("tblSales")
        dgvInventorySales.Refresh()
        dgvInventorySales.Enabled = True
    End Sub
    Sub Sizes()
        dgvInventorySales.Columns("Order Date").Width = 200
        dgvInventorySales.Columns("Item Code").Width = 100
        dgvInventorySales.Columns("Item Name").Width = 150
        dgvInventorySales.Columns("Type").Width = 100
        dgvInventorySales.Columns("Qty").Width = 50
        dgvInventorySales.Columns("Price").Width = 50
        dgvInventorySales.Columns("Discount").Width = 80
        dgvInventorySales.Columns("Amount").Width = 70
        dgvInventorySales.Columns("Total").Width = 70
        dgvInventorySales.Columns("Payment").Width = 70
        dgvInventorySales.Columns("Change").Width = 80
    End Sub
    Private Sub pbDashboard_Click(sender As Object, e As EventArgs) Handles pbDashboard.Click
        frmDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub pbUsers_Click(sender As Object, e As EventArgs) Handles pbUsers.Click
        frmUsers.Show()
        Me.Hide()
    End Sub

    Private Sub pbProducts_Click(sender As Object, e As EventArgs) Handles pbProducts.Click
        frmProducts.Show()
        Me.Hide()
    End Sub

    Private Sub pbCashier_Click(sender As Object, e As EventArgs) Handles pbCashier.Click
        frmCashier.Show()
        Me.Hide()
    End Sub

    Private Sub pbReports_Click(sender As Object, e As EventArgs) Handles pbReports.Click
        Me.Show()
    End Sub

    Private Sub pbLogOut_Click(sender As Object, e As EventArgs) Handles pbLogOut.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to Log Out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Log Out Account")
        If result = DialogResult.Yes Then
            frmLogIn.Clear()
            frmLogIn.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "CSV Files|*.csv"
        saveFileDialog.Title = "Save Inventory Sales"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            Try
                Using writer As New IO.StreamWriter(filePath)
                    For Each column As DataGridViewColumn In dgvInventorySales.Columns
                        writer.Write(column.HeaderText & ",")
                    Next
                    writer.WriteLine()
                    For Each row As DataGridViewRow In dgvInventorySales.Rows
                        If Not row.IsNewRow Then
                            Dim rowData As New List(Of String)
                            For Each cell As DataGridViewCell In row.Cells
                                rowData.Add(If(cell.Value IsNot Nothing, cell.Value.ToString(), ""))
                            Next
                            writer.WriteLine(String.Join(",", rowData))
                        End If
                    Next
                End Using

                MessageBox.Show("Data exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        Sizes()
    End Sub

    Sub CalculateTotals()
        Dim totalAmount As Decimal = 0
        Dim totalItems As Integer = 0

        Dim dt As DataTable = CType(dgvInventorySales.DataSource, DataTable)

        For Each row As DataRow In dt.Rows
            totalAmount += Convert.ToDecimal(row("Total"))
            totalItems += Convert.ToInt32(row("Qty"))
        Next

        lblTotalSales.Text = "₱" & totalAmount.ToString("N2")
        lblTotalItems.Text = totalItems

        getSales_records()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call Connection_State()

        Dim query As String
        If String.IsNullOrEmpty(txtSearch.Text) Then
            query = "SELECT * FROM tblSales"
        Else
            query = "SELECT * FROM tblSales WHERE [Order Date] LIKE @SearchText OR [Item Name] LIKE @SearchText OR [Type] LIKE @SearchText"
        End If

        dbADAP = New OleDb.OleDbDataAdapter(query, dbCON)

        If Not String.IsNullOrEmpty(txtSearch.Text) Then
            dbADAP.SelectCommand.Parameters.Add("@SearchText", OleDbType.VarChar).Value = "%" & txtSearch.Text & "%"
        End If

        dbDS = New DataSet()
        dbADAP.Fill(dbDS, "tblSales")
        Dim dt As DataTable = dbDS.Tables("tblSales")

        If dt.Rows.Count > 0 Then
            dgvInventorySales.DataSource = dt
        End If

        Sizes()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call Connection_State()
        If dgvInventorySales.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to permanently delete the selected records?",
        "Deleting Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If dbCON.State = ConnectionState.Closed Then
                    dbCON.Open()
                End If

                Try
                    Dim transaction As OleDbTransaction = dbCON.BeginTransaction()

                    For Each selectedRow As DataGridViewRow In dgvInventorySales.SelectedRows
                        If Not selectedRow.IsNewRow Then
                            Dim itemNumber As Integer
                            Try
                                itemNumber = Convert.ToInt32(selectedRow.Cells("Item Code").Value)
                            Catch ex As Exception
                                itemNumber = Convert.ToInt32(selectedRow.Cells(0).Value)
                            End Try


                            If itemNumber > 0 Then
                                dbCMD = New OleDb.OleDbCommand("DELETE FROM tblSales WHERE [Item Code] = ?", dbCON)
                                dbCMD.Transaction = transaction

                                dbCMD.Parameters.Clear()
                                dbCMD.Parameters.AddWithValue("?", itemNumber)

                                dbCMD.ExecuteNonQuery()

                                dgvInventorySales.Rows.Remove(selectedRow)
                            End If
                        End If
                    Next

                    transaction.Commit()

                    dbCON.Close()

                    MessageBox.Show("Selected records deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    If dbCON.State = ConnectionState.Open Then
                        dbCON.Close()
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Please select at least one record to delete.", "No Records Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        getSales_records()
        Sizes()
    End Sub

End Class

