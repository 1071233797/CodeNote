Public Class Form出库菜单



    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub

    Private Sub Form出库菜单_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub

    Private Sub btn原材料出库_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn原材料出库.Click
        Dim F As New F原材料出库
        F.ShowDialog()
    End Sub

    Private Sub btn半成品出库_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn半成品出库.Click
        Dim F As New F半成品出库
        F.ShowDialog()
    End Sub

    Private Sub btn产成品出库_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn产成品出库.Click
        Dim F As New F成品出库
        F.ShowDialog()
    End Sub
End Class