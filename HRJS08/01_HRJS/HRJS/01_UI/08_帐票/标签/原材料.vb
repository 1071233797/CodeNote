Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class 原材料
    Public Sub SetControlValue(ByVal dtOrg As B原材料标签打印T)

        txt材料编号.Text = dtOrg.材料编号
        txt材料名称.Text = dtOrg.材料名称
        txt批次号.Text = dtOrg.批次
        txt长.Text = dtOrg.长
        txt宽.Text = dtOrg.宽
        txt高.Text = dtOrg.高
        txt库存区域.Text = dtOrg.库存名称
        bar详细.Text = dtOrg.申请单编号 + "|" + dtOrg.材料编号 + "|" + dtOrg.材料名称 + "|" + dtOrg.长 + "|" + dtOrg.宽 + "|" + dtOrg.高 + "|" + dtOrg.批次 + "|" + dtOrg.数量 + "|" + dtOrg.重量 + "|" + dtOrg.库存区域 + "|" + dtOrg.库存名称


    End Sub
End Class
