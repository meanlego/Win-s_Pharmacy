Public Class frmDashboard

    Private Sub pbTerminate_Click(sender As Object, e As EventArgs) Handles pbTerminate.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to terminate the application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Terminate Application")

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
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
        frmReports.Show()
        Me.Hide()
    End Sub

    Private Sub pbLogOut_Click(sender As Object, e As EventArgs) Handles pbLogOut.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to Log Out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Log Out Account")
        If result = DialogResult.Yes Then
            frmLogIn.Clear()
            frmLogIn.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Date.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lbl_Time.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class