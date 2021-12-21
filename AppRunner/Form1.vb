Public Class Form1

    Private Sub btnAppRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppRun.Click
        If txtAppName.Text = "" Then
            MsgBox("Please Enter any App Name First.", vbOKCancel + MsgBoxStyle.Exclamation, "VVIT")
            txtAppName.BackColor = Color.LightPink
            txtAppName.Focus()
            Exit Sub
        End If
        Dim pid = Shell(txtAppName.Text, AppWinStyle.NormalFocus)
        lstApp.Items.Add(pid)
        'MsgBox(pid)

    End Sub

    Private Sub txtAppName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAppName.KeyPress
        txtAppName.BackColor = Color.White
    End Sub

    
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtAppName.Text = ""
        txtAppName.Focus()
    End Sub

    Private Sub btnCloseApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseApp.Click
        If lstApp.Items.Count = 0 Then
            MsgBox("There is no one App in App List.")
            Exit Sub
        End If
        If lstApp.SelectedIndex < 0 Then
            MsgBox("Please select any App in App List.")
            Exit Sub
        End If
        If MsgBox("Are you sure to close the app?", vbYesNo + vbCritical, "VVIT") = MsgBoxResult.Yes Then
            Process.GetProcessById(lstApp.SelectedItem).Kill()
            lstApp.Items.Remove(lstApp.SelectedItem)
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
