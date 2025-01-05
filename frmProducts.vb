Imports System.Data.OleDb

Public Class frmProducts
    Private Sub pbDashboard_Click(sender As Object, e As EventArgs) Handles pbDashboard.Click
        frmDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub pbUsers_Click(sender As Object, e As EventArgs) Handles pbUsers.Click
        frmUsers.Show()
        Me.Hide()
    End Sub

    Private Sub pbProducts_Click(sender As Object, e As EventArgs) Handles pbProducts.Click
        Me.Show()
    End Sub

    Private Sub pbCashier_Click(sender As Object, e As EventArgs) Handles pbCashier.Click
        frmCashier.Show()
        Me.Close()
    End Sub

    Private Sub pbReports_Click(sender As Object, e As EventArgs) Handles pbReports.Click
        frmReports.Show()
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
    Private Sub pbTerminate_Click(sender As Object, e As EventArgs) Handles pbTerminate.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to terminate the application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Terminate Application")

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgProducts.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        mnuFile.Font = New Font("Microsft Sans Serif", 12)
        mnuMain.Padding = New Padding(75, 5, 75, 5)

        Call get_records()

        Call Clear_TextBoxes()
        Call Lock_TextBoxes()
        mnuAdd.Visible = True
        mnuEdit.Visible = True
        mnuDelete.Visible = True
        mnuUpdate.Visible = False
        mnuSave.Visible = False
        mnuCancel.Visible = True
    End Sub

    Private Sub mnuMain_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuMain.ItemClicked

    End Sub
    Sub get_records()
        Call database_connection()
        dbADAP = New OleDb.OleDbDataAdapter("select * from tblProducts", dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblProducts")

        Call Clear_TextBoxes()
        Call Lock_TextBoxes()
        Call display_records()
    End Sub
    Sub display_records()
        dbDS.Tables("tblProducts").AcceptChanges()
        dgProducts.DataSource = Nothing
        dgProducts.DataSource = dbDS.Tables("tblProducts")
        dgProducts.Enabled = True
    End Sub
    Sub Clear_TextBoxes()
        txtPCode.Clear()
        txtPName.Clear()
        txtPPrice.Clear()
        txtPStocks.Clear()
        cboPType.Text = Nothing
    End Sub

    Sub Lock_TextBoxes()
        txtPCode.ReadOnly = True
        txtPName.ReadOnly = True
        txtPPrice.ReadOnly = True
        txtPStocks.ReadOnly = True
        cboPType.Enabled = False
    End Sub
    Sub Unlock_TextBoxes()
        txtPCode.ReadOnly = True
        txtPName.ReadOnly = False
        txtPPrice.ReadOnly = False
        txtPStocks.ReadOnly = False
        cboPType.Enabled = True
    End Sub
    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        Call Connection_State()

        If txtPCode.Text = "" Or txtPName.Text = "" Or txtPPrice.Text = "" Or cboPType.Text = "" Or txtPStocks.Text = "" Then
            MsgBox("Please supply all the information needed!", MsgBoxStyle.Information, "Required")
            Exit Sub
        ElseIf Not IsNumeric(txtPCode.Text) Then
            MsgBox("Please enter a valid numeric value for the Product Code.", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf Not IsNumeric(txtPPrice.Text) Then
            MsgBox("Please enter a valid numeric value for the Price.", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf Not IsNumeric(txtPStocks.Text) Then
            MsgBox("Please enter a valid numeric value for the Stocks.", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")

        End If
        If Not IsNumeric(txtPCode.Text) Then
            MsgBox("Please enter a valid numeric value for the Product Code.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        Dim originalProductCode As String = txtPCode.Tag?.ToString()

        If MsgBox("Do you want to save the changes you made to this record, including the Product Code?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Updating...") = MsgBoxResult.Yes Then
            Using dbCMD As New OleDb.OleDbCommand("UPDATE tblProducts SET [Product Code] = @ProductCode, [Product Name] = @ProductName, [Product Price] = @ProductPrice, [Product Type] = @ProductType, [Product Stocks] = @ProductStocks WHERE [Product Code] = @ProductCode", dbCON)

                dbCMD.Parameters.AddWithValue("@ProductCode", txtPCode.Text.Trim())
                dbCMD.Parameters.AddWithValue("@ProductName", txtPName.Text.Trim())
                dbCMD.Parameters.AddWithValue("@ProductPrice", txtPPrice.Text.Trim())
                dbCMD.Parameters.AddWithValue("@ProductType", cboPType.Text.Trim())
                dbCMD.Parameters.AddWithValue("@ProductStocks", txtPStocks.Text.Trim())

                Dim rowsAffected As Integer = dbCMD.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Record updated successfully!", MsgBoxStyle.Information, "Updated")
                Else
                    MsgBox("No record was updated. Please check the details and try again.", MsgBoxStyle.Exclamation, "No Changes")
                End If
            End Using
        End If

        Clear_TextBoxes()
        get_records()

        mnuAdd.Visible = True
        mnuEdit.Visible = True
        mnuDelete.Visible = True
        mnuUpdate.Visible = False
        mnuSave.Visible = False
        mnuCancel.Visible = True
    End Sub
    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        Call Connection_State()
        If txtPName.Text = "" Or txtPPrice.Text = "" Or cboPType.Text = "" Or txtPStocks.Text = "" Then
            MsgBox("All Fields are Required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf Not IsNumeric(txtPPrice.Text) Then
            MsgBox("Please enter a valid numeric value for the Price.", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf Not IsNumeric(txtPStocks.Text) Then
            MsgBox("Please enter a valid numeric value for the Stocks.", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to Save this Record?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                dbADAP = New OleDb.OleDbDataAdapter("SELECT * FROM tblProducts WHERE [Product Name] = @ProductName", dbCON)
                dbADAP.SelectCommand.Parameters.AddWithValue("@ProductName", txtPName.Text.Trim())
                dbDS = New DataSet()
                dbADAP.Fill(dbDS, "tblProducts")

                If dbDS.Tables("tblProducts").Rows.Count > 0 Then
                    MsgBox("Product already exists!", MsgBoxStyle.Exclamation, "Error")
                Else
                    Dim newProductCode As String = GenerateCustomProductCode()

                    dbCMD = New OleDb.OleDbCommand("INSERT INTO tblProducts([Product Code],[Product Name],[Product Price],[Product Type],[Product Stocks])VALUES(@ProductCode,@ProductName,@ProductPrice,@ProductType,@ProductStocks)", dbCON)
                    dbCMD.Parameters.AddWithValue("@ProductCode", newProductCode)
                    dbCMD.Parameters.AddWithValue("@ProductName", txtPName.Text.Trim())
                    dbCMD.Parameters.AddWithValue("@ProductPrice", txtPPrice.Text.Trim())
                    dbCMD.Parameters.AddWithValue("@ProductType", cboPType.Text.Trim())
                    dbCMD.Parameters.AddWithValue("@ProductStocks", txtPStocks.Text.Trim())

                    dbCMD.ExecuteNonQuery()
                    MsgBox("Product added successfully!", MsgBoxStyle.Information, "Success")
                End If
            End If

            mnuAdd.Visible = True
            mnuEdit.Visible = True
            mnuDelete.Visible = True
            mnuUpdate.Visible = False
            mnuSave.Visible = False
            mnuCancel.Visible = True

            Call get_records()
            Call Clear_TextBoxes()
        End If
    End Sub
    Private Function GenerateCustomProductCode() As String
        Dim lastUserID As Long = 0
        Try
            Using dbCMD As New OleDb.OleDbCommand("SELECT MAX([Product Code]) FROM tblProducts", dbCON)
                Dim result = dbCMD.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    Dim lastCode As String = result.ToString()
                    If lastCode.StartsWith("20250") Then
                        lastUserID = Convert.ToInt64(lastCode.Substring(5))
                    End If
                End If
            End Using
        Catch ex As Exception
            MsgBox($"Error retrieving last Product Code: {ex.Message}", MsgBoxStyle.Critical, "Error")
        End Try
        Dim newProductCode As String = (lastUserID + 1).ToString()
        Return "20250" & newProductCode
    End Function



    Private Sub dgProducts_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgProducts.CellFormatting
        If dgProducts.Columns(e.ColumnIndex).Name = "Password" Then
            e.Value = New String("●"c, e.Value.ToString().Length)
        End If
    End Sub
    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        If txtPCode.Text = "" Or txtPName.Text = "" Or txtPPrice.Text = "" Or cboPType.Text = "" Or txtPStocks.Text = "" Then
            MsgBox("There's Nothing to Delete!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to permanent delete this record?",
       "Deleting Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Call Connection_State()
                dbCMD = New OleDb.OleDbCommand("delete from tblProducts where [Product Code] = @ProductCode", dbCON)
                dbCMD.Parameters.AddWithValue("@ProductCode", txtPCode.Text)
                dbCMD.ExecuteNonQuery()
                dbCON.Close()
            End If
        End If
        Call get_records()
        Call Clear_TextBoxes()
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        Call Unlock_TextBoxes()
        Call Clear_TextBoxes()
        mnuAdd.Visible = False
        mnuEdit.Visible = False
        mnuDelete.Visible = False
        mnuUpdate.Visible = True
        mnuSave.Visible = False
        mnuCancel.Visible = True
    End Sub

    Private Sub mnuAdd_Click(sender As Object, e As EventArgs) Handles mnuAdd.Click
        Call Unlock_TextBoxes()
        Call Clear_TextBoxes()
        mnuAdd.Visible = False
        mnuEdit.Visible = False
        mnuDelete.Visible = False
        mnuUpdate.Visible = False
        mnuSave.Visible = True
        mnuCancel.Visible = True
    End Sub

    Private Sub mnuCancel_Click(sender As Object, e As EventArgs) Handles mnuCancel.Click
        Call Lock_TextBoxes()
        Call Clear_TextBoxes()
        mnuAdd.Visible = True
        mnuEdit.Visible = True
        mnuDelete.Visible = True
        mnuUpdate.Visible = False
        mnuSave.Visible = False
        mnuCancel.Visible = True
    End Sub
    Private Sub dgProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgProducts.SelectionChanged
        If dgProducts.CurrentRow IsNot Nothing Then
            Try
                Dim selectedRow As DataGridViewRow = dgProducts.CurrentRow

                txtPCode.Text = selectedRow.Cells("Product Code")?.Value?.ToString()
                txtPName.Text = selectedRow.Cells("Product Name")?.Value?.ToString()
                txtPPrice.Text = selectedRow.Cells("Product Price")?.Value?.ToString()
                txtPStocks.Text = selectedRow.Cells("Product Stocks")?.Value?.ToString()


                Dim roleValue As String = selectedRow.Cells("Product Type")?.Value?.ToString()
                If Not String.IsNullOrEmpty(roleValue) AndAlso cboPType.Items.Contains(roleValue) Then
                    cboPType.Text = roleValue
                Else
                    cboPType.SelectedIndex = -1
                End If
            Catch ex As Exception
                MsgBox($"An error occurred while selecting a user: {ex.Message}", MsgBoxStyle.Critical, "Error")
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

                txtPName.Text = dt.Rows(0)("Product Name").ToString()
                txtPPrice.Text = dt.Rows(0)("Product Price").ToString()
                cboPType.Text = dt.Rows(0)("Product Type").ToString()
                txtPStocks.Text = dt.Rows(0)("Product Stocks").ToString()
            End If
        Else
            Call get_records()
            Call Clear_TextBoxes()
        End If
    End Sub

    Private Sub mnuMain_MouseDown(sender As Object, e As MouseEventArgs) Handles mnuMain.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip.Show(Cursor.Position)
        End If
    End Sub
End Class