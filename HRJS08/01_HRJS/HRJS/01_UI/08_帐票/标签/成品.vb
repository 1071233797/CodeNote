Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class 成品

    Public Sub SetControlValue(ByVal dtOrg As Z成品标签打印)
        txt订单编号.Text = dtOrg.订单编号
        txt产品图号.Text = dtOrg.产品图号
        txt库存区域.Text = dtOrg.库存区域
        bar详细.Text = dtOrg.订单编号 + "|" + dtOrg.产品图号 + "|" + dtOrg.入库数量 + "|" + dtOrg.入库重量

    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub
End Class
