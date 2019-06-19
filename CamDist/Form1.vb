Public Class Main
    Private ReadOnly iOP As New OP

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iOP.CboItems(CBcam)
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

    Private Sub LimpiarCamposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarCamposToolStripMenuItem.Click
        NudAl.Value = 0 : NudALL.Value = 0 : NudAn.Value = 0 : NudDist.Value = 0 : CBcam.Text = "Seleccione una cámara"
    End Sub

    Private Sub NudAn_ValueChanged(sender As Object, e As EventArgs) Handles NudAn.ValueChanged
        If NudAn.Focused Then
            NudDist.Value = iOP.CDAncho(NudAn.Value, CBcam)
            NudAl.Value = iOP.CDdistAlt(NudDist.Value, NudALL.Value, CBcam)
        End If
    End Sub

    Private Sub NudAl_ValueChanged(sender As Object, e As EventArgs) Handles NudAl.ValueChanged
        If NudAl.Focused Then
            NudDist.Value = iOP.CDAlto(NudAl.Value, NudALL.Value, CBcam)
            NudAn.Value = iOP.CDdistAn(NudDist.Value, CBcam)
        End If
    End Sub
End Class
