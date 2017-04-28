Public Class Form入库菜单

    Private Sub btn原材料入库_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn原材料入库.Click
        Dim F As New F原材料入库
        F.ShowDialog()
    End Sub

   
    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub

    Private Sub Form入库菜单_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub

    Private Sub btn半成品入库_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn半成品入库.Click
        Dim F As New F半成品入库
        F.ShowDialog()
    End Sub

    Private Sub btn产成品入库_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn产成品入库.Click
        Dim F As New F成品入库
        F.ShowDialog()
    End Sub

    Private Sub btn返回品入库_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn返回品入库.Click
        Dim F As New F返品入库
        F.ShowDialog()
    End Sub
End Class