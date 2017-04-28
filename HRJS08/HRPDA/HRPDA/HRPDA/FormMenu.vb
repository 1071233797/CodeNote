Public Class FormMenu

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub


    Private Sub btn入库_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn入库.Click
        Dim F入库菜单 As New Form入库菜单
        F入库菜单.ShowDialog()
    End Sub

    Private Sub btn出库_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn出库.Click
        Dim F出库菜单 As New Form出库菜单
        F出库菜单.ShowDialog()
    End Sub

    Private Sub btn盘点_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn盘点.Click
        Dim F盘点菜单 As New Form盘点菜单
        F盘点菜单.ShowDialog()
    End Sub

    Private Sub FormMenu_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub
End Class