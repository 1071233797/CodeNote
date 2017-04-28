Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class 半成品

    Public Sub SetControlValue(ByVal dtOrg As Z半成品标签打印)
        txt订单编号.Text = dtOrg.订单编号
        txt主图号.Text = dtOrg.主图号
        txt分图号.Text = dtOrg.分图号
        txt半成品种类.Text = dtOrg.半成品种类
        txt库存区域.Text = dtOrg.库存区域
        bar详细.Text = dtOrg.订单编号 + "|" + dtOrg.主图号 + "|" + dtOrg.上级图号 + "|" + dtOrg.分图号 + "|" + dtOrg.工序编号 + "|" + dtOrg.入库数量 + "|" + dtOrg.半成品种类 + "|" + dtOrg.库存编号

    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub
End Class
