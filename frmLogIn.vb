Imports System.Data.OleDb

Public Class frmLogIn
    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call database_connection()

    End Sub
    Private Sub pbTerminate_Click(sender As Object, e As EventArgs) Handles pbTerminate.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to terminate the application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Terminate Application")

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub pbLogIn_Click(sender As Object, e As EventArgs) Handles pbLogIn.Click
        If txtUname.Text = Nothing And txtPassword.Text = Nothing And cboRole.Text = Nothing Then
            MsgBox("All Fields are Required!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Log In")
            txtUname.Focus()
        ElseIf txtUname.Text = Nothing Then
            MsgBox("Please Enter Username", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Log In")
            txtUname.Focus()
        ElseIf txtPassword.Text = Nothing Then
            MsgBox("Please Enter Password", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Log In")
            txtPassword.Focus()
        ElseIf cboRole.Text = Nothing Then
            MsgBox("Please Select Role", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Log In")
            cboRole.Focus()
        Else
            If txtUname.Text = "Admin" And txtPassword.Text = "Admin" And cboRole.Text.ToUpper() = "ADMIN" Then
                frmDashboard.Show()
                Me.Hide()
            Else
                Call Connection_State()
                dbCMD = New OleDb.OleDbCommand("SELECT * FROM tblAccounts WHERE StrComp(Username, ?, 0) = 0 AND StrComp(Password, ?, 0) = 0 AND StrComp(Role, ?, 0) = 0", dbCON)
                dbCMD.Parameters.AddWithValue("?", txtUname.Text)
                dbCMD.Parameters.AddWithValue("?", txtPassword.Text)
                dbCMD.Parameters.AddWithValue("?", cboRole.Text.ToUpper())


                Dim result As Integer = Convert.ToInt32(dbCMD.ExecuteScalar())
                If result > 0 And cboRole.Text.ToUpper() = "CASHIER" Then
                    frmCashier.Show()
                    Me.Hide()
                    Call Clear()
                Else
                    MsgBox("You Have No Account Here", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Log In")

                End If
            End If
        End If
    End Sub

    Dim passwordVisible As Boolean = False
    Private Sub TogglePasswordVisibility()
        If passwordVisible Then
            txtPassword.PasswordChar = "●"
            pbShowPass.Visible = False
            pbUnshowPass.Visible = True
            passwordVisible = False
        Else
            txtPassword.PasswordChar = ControlChars.NullChar
            pbUnshowPass.Visible = False
            pbShowPass.Visible = True
            passwordVisible = True
        End If
    End Sub

    Private Sub pbShowPass_Click(sender As Object, e As EventArgs) Handles pbShowPass.Click
        TogglePasswordVisibility()
    End Sub

    Private Sub pbUnshowPass_Click(sender As Object, e As EventArgs) Handles pbUnshowPass.Click
        TogglePasswordVisibility()
    End Sub

    Public Sub Clear()
        txtUname.Clear()
        txtPassword.Clear()
        lblResult.Text = Nothing
        cboRole.Text = Nothing
    End Sub
End Class
