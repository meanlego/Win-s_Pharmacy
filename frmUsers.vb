Imports System.Data.OleDb

Public Class frmUsers
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgUsers.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
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

    Private Sub pbLogOut_Click(sender As Object, e As EventArgs) Handles pbLogOut.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to Log Out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Log Out Account")
        If result = DialogResult.Yes Then
            frmLogIn.Clear()
            frmLogIn.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub pbDashboard_Click(sender As Object, e As EventArgs) Handles pbDashboard.Click
        frmDashboard.Show()
        Me.Show()
    End Sub

    Private Sub pbUsers_Click(sender As Object, e As EventArgs) Handles pbUsers.Click
        Me.Show()
    End Sub

    Private Sub pbProducts_Click(sender As Object, e As EventArgs) Handles pbProducts.Click
        frmProducts.Show()
        Me.Hide()
    End Sub

    Private Sub pbCashier_Click(sender As Object, e As EventArgs) Handles pbCashier.Click
        frmCashier.Show()
        Me.Show()
    End Sub

    Private Sub pbReports_Click(sender As Object, e As EventArgs) Handles pbReports.Click
        frmReports.Show()
        Me.Hide()
    End Sub


    Sub get_records()
        Call database_connection()
        dbADAP = New OleDb.OleDbDataAdapter("select * from tblAccounts", dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblAccounts")

        Call Lock_TextBoxes()
        Call display_records()
    End Sub
    Sub display_records()
        dbDS.Tables("tblAccounts").AcceptChanges()
        dgUsers.DataSource = Nothing
        dgUsers.DataSource = dbDS.Tables("tblAccounts")
        dgUsers.Enabled = True
    End Sub

    Private Sub pbTerminate_Click(sender As Object, e As EventArgs) Handles pbTerminate.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to terminate the application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Terminate Application")

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        Call Connection_State()

        If txtName.Text = "" Or txtUname.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please supply all the information needed!", MsgBoxStyle.Information, "Required")
            Exit Sub
        End If
        If MsgBox("Do you want to save the changes you made to this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Updating...") = MsgBoxResult.Yes Then
            Try
                Using dbCMD As New OleDb.OleDbCommand("UPDATE tblAccounts SET [Full Name] = @FullName, [Username] = @Username, [Password] = @Password, [Role] = @Role WHERE [User ID] = @UserID", dbCON)
                    dbCMD.Parameters.AddWithValue("@FullName", txtName.Text)
                    dbCMD.Parameters.AddWithValue("@Username", txtUname.Text)
                    dbCMD.Parameters.AddWithValue("@Password", txtPassword.Text)
                    dbCMD.Parameters.AddWithValue("@Role", cboRole.Text)
                    dbCMD.Parameters.AddWithValue("@UserID", lblUserID.Text)

                    Dim rowsAffected As Integer = dbCMD.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Record updated successfully!", MsgBoxStyle.Information, "Updated")
                    Else
                        MsgBox("No record was updated. Please check the details and try again.", MsgBoxStyle.Exclamation, "No Changes")
                    End If
                End Using
            Catch ex As Exception
                MsgBox($"An error occurred: {ex.Message}", MsgBoxStyle.Critical, "Error")
            End Try
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
        If String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtUname.Text) Or String.IsNullOrEmpty(txtPassword.Text) Or String.IsNullOrEmpty(cboRole.Text) Then
            MsgBox("All Fields are Required!", MsgBoxStyle.Exclamation Or MsgBoxStyle.Critical, "Validation Error")
            Exit Sub
        End If
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Save this Record?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            dbADAP = New OleDb.OleDbDataAdapter("SELECT * FROM tblAccounts WHERE [Full Name] = @FullName", dbCON)
            dbADAP.SelectCommand.Parameters.AddWithValue("@FullName", txtUname.Text.Trim())
            dbDS = New DataSet()
            dbADAP.Fill(dbDS, "tblAccounts")

            If dbDS.Tables("tblAccounts").Rows.Count > 0 Then
                MsgBox("Employee already exists!", MsgBoxStyle.Exclamation, "Error")
            Else

                dbCMD = New OleDb.OleDbCommand("INSERT INTO tblAccounts([Full Name],[Username],[Password],[Role])VALUES(@FullName,@Username,@Password,@Role)", dbCON)
                dbCMD.Parameters.AddWithValue("@FullName", txtName.Text.Trim())
                dbCMD.Parameters.AddWithValue("@Username", txtUname.Text.Trim())
                dbCMD.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
                dbCMD.Parameters.AddWithValue("@Role", cboRole.Text.Trim())

                Try
                    dbCMD.ExecuteNonQuery()
                    MsgBox("Employee added successfully!", MsgBoxStyle.Information, "Success")
                Catch ex As Exception
                    MsgBox("Error while saving the record: " & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
            mnuAdd.Visible = True
            mnuEdit.Visible = True
            mnuDelete.Visible = True
            mnuUpdate.Visible = False
            mnuSave.Visible = False
            mnuCancel.Visible = True
            Call Clear_TextBoxes()
        End If
        get_records()
    End Sub

    Private Sub dgUsers_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgUsers.CellFormatting
        If dgUsers.Columns(e.ColumnIndex).Name = "Password" Then
            If e.Value IsNot Nothing Then
                e.Value = New String("●"c, e.Value.ToString().Length)
            Else
                e.Value = String.Empty
            End If
        End If
    End Sub


    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to permanent delete this record?",
       "Deleting Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Call Connection_State()
            dbCMD = New OleDb.OleDbCommand("delete from tblAccounts where [Full Name] = @FullName", dbCON)
            dbCMD.Parameters.AddWithValue("@FullName", txtName.Text)
            dbCMD.ExecuteNonQuery()
            dbCON.Close()
        End If
        Call Clear_TextBoxes()
        Call get_records()
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
    Private Sub dgUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgUsers.SelectionChanged
        If dgUsers.CurrentRow IsNot Nothing Then
            Try
                Dim selectedRow As DataGridViewRow = dgUsers.CurrentRow

                lblUserID.Text = selectedRow.Cells("User ID")?.Value?.ToString()
                txtName.Text = selectedRow.Cells("Full Name")?.Value?.ToString()
                txtUname.Text = selectedRow.Cells("Username")?.Value?.ToString()
                txtPassword.Text = selectedRow.Cells("Password")?.Value?.ToString()


                Dim roleValue As String = selectedRow.Cells("Role")?.Value?.ToString()
                If Not String.IsNullOrEmpty(roleValue) AndAlso cboRole.Items.Contains(roleValue) Then
                    cboRole.Text = roleValue
                Else
                    cboRole.SelectedIndex = -1
                End If
            Catch ex As Exception
                MsgBox($"An error occurred while selecting a user: {ex.Message}", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub


    Sub Clear_TextBoxes()
        txtName.Clear()
        txtPassword.Clear()
        txtUname.Clear()
        lblUserID.Text = Nothing
        cboRole.Text = Nothing
    End Sub

    Sub Lock_TextBoxes()
        txtName.ReadOnly = True
        txtPassword.ReadOnly = True
        txtUname.ReadOnly = True
        cboRole.Enabled = False
    End Sub
    Sub Unlock_TextBoxes()
        txtName.ReadOnly = False
        txtPassword.ReadOnly = False
        txtUname.ReadOnly = False
        cboRole.Enabled = True
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not String.IsNullOrEmpty(txtSearch.Text) Then
            dbADAP = New OleDb.OleDbDataAdapter("SELECT * FROM tblAccounts WHERE [User ID] LIKE '%" & txtSearch.Text & "%' OR [Full Name] LIKE '%" & txtSearch.Text & "%'", dbCON)
            dbDS = New DataSet
            dbADAP.Fill(dbDS, "tblAccounts")

            Dim dt As DataTable = dbDS.Tables("tblAccounts")

            If dt.Rows.Count > 0 Then
                dgUsers.DataSource = dt
                lblUserID.Text = dt.Rows(0)("User ID").ToString()
                txtName.Text = dt.Rows(0)("Full Name").ToString()
                txtUname.Text = dt.Rows(0)("Username").ToString()
                txtPassword.Text = dt.Rows(0)("Password").ToString()
                cboRole.Text = dt.Rows(0)("Role").ToString()
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

    Private Sub mnuMain_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuMain.ItemClicked

    End Sub
End Class