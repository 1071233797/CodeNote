Public Class Form盘点菜单

    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub

    Private Sub Form盘点菜单_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub

    Private Sub btn原材料盘点_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn原材料盘点.Click
        Dim f As New F原材料盘点
        f.ShowDialog()
    End Sub

    Private Sub btn半成品盘点_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn半成品盘点.Click
        Dim f As New F半成品盘点
        f.ShowDialog()
    End Sub

    Private Sub btn产成品盘点_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn产成品盘点.Click
        Dim f As New F成品盘点
        f.ShowDialog()
    End Sub
End Class