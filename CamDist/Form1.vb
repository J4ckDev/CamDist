Public Class Main
    Dim iOP As New OP

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAcercaDe_Click(sender As Object, e As EventArgs) Handles BtnAcercaDe.Click
        Info.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        FrmHelp.Show()
    End Sub
End Class
