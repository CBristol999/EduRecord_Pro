Public Class AccountForm
    Private Sub AccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnApproval_Click(sender As Object, e As EventArgs) Handles btnApproval.Click
        RegistrationApproval.ShowDialog()
    End Sub

    Private Sub btnCoAdmin_Click(sender As Object, e As EventArgs) Handles btnCoAdmin.Click
        Dim AccountCreateDelete As New AccountCreateDelete
        AccountCreateDelete.btnDelete.Enabled = False
        AccountCreateDelete.btnSave.Enabled = True
        AccountCreateDelete.txtFullname.Enabled = True
        AccountCreateDelete.txtEmail.Enabled = True
        AccountCreateDelete.lblFullname.Enabled = True : AccountCreateDelete.lblEmail.Enabled = True
        AccountCreateDelete.ShowDialog()
    End Sub

    Private Sub btnDeleteAcc_Click(sender As Object, e As EventArgs) Handles btnDeleteAcc.Click
        Dim AccountCreateDelete As New AccountCreateDelete
        AccountCreateDelete.btnDelete.Enabled = True
        AccountCreateDelete.btnSave.Enabled = False
        AccountCreateDelete.txtFullname.Enabled = False
        AccountCreateDelete.txtEmail.Enabled = False
        AccountCreateDelete.lblFullname.Enabled = False : AccountCreateDelete.lblEmail.Enabled = False
        AccountCreateDelete.ShowDialog()
    End Sub


End Class