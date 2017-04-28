Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class 生产工序

    Public Sub SetControlValue(ByVal dtOrg As DataTable, ByVal dt As DataTable)

        txt表号.Text = ""
        txtNo.Text = ""
        txt品名.Text = dtOrg.Rows(0)("品名")
        txt图号.Text = dtOrg.Rows(0)("产品图号")
        If Not String.IsNullOrEmpty(Convert.ToString(dtOrg.Rows(0)("上级图号"))) Then
            txt总图号.Text = dtOrg.Rows(0)("上级图号")
        Else
            txt总图号.Text = dtOrg.Rows(0)("产品图号")
        End If
        'txt总图号.Text = dtOrg.Rows(0)("上级图号")
        If Not String.IsNullOrEmpty(Convert.ToString(dtOrg.Rows(0)("投产数量"))) Then
            txt投产数量.Text = dtOrg.Rows(0)("投产数量")
        Else
            txt投产数量.Text = ""
        End If
        If Not String.IsNullOrEmpty(Convert.ToString(dtOrg.Rows(0)("完成期限"))) Then
            txt完成期限.Text = dtOrg.Rows(0)("完成期限")
        Else
            txt完成期限.Text = ""
        End If
        If Not String.IsNullOrEmpty(Convert.ToString(dtOrg.Rows(0)("下达日期"))) Then
            txt下达日期.Text = dtOrg.Rows(0)("下达日期")
        Else
            txt下达日期.Text = ""
        End If

        txt订单编号.Text = dtOrg.Rows(0)("订单编号")
        If Not String.IsNullOrEmpty(Convert.ToString(dtOrg.Rows(0)("订货量"))) Then
            txt订货量.Text = dtOrg.Rows(0)("订货量")
        Else
            txt订货量.Text = ""
        End If
        If Not String.IsNullOrEmpty(Convert.ToString(dtOrg.Rows(0)("发货日期"))) Then
            txt发货日期.Text = dtOrg.Rows(0)("发货日期")
        Else
            txt发货日期.Text = ""
        End If

        If Not String.IsNullOrEmpty(Convert.ToString(dtOrg.Rows(0)("工序名称"))) Then
            txt工序名称.Text = dtOrg.Rows(0)("工序名称")
        Else
            txt工序名称.Text = ""
        End If
        If Not String.IsNullOrEmpty(Convert.ToString(dtOrg.Rows(0)("加工内容简介"))) Then
            txt加工内容简介.Text = dtOrg.Rows(0)("加工内容简介")
        Else
            txt加工内容简介.Text = ""
        End If
        If Not String.IsNullOrEmpty(Convert.ToString(dtOrg.Rows(0)("作业场所"))) Then
            txt作业场所.Text = dtOrg.Rows(0)("作业场所")
        Else
            txt作业场所.Text = ""
        End If
        If Not String.IsNullOrEmpty(Convert.ToString(dtOrg.Rows(0)("设备编号"))) Then
            txt设备编号.Text = dtOrg.Rows(0)("设备编号")
        Else
            txt设备编号.Text = ""
        End If
        Barcode1.Text = dtOrg.Rows(0)("产品图号") + "|" + txt总图号.Text
        'pic图纸.Image = dtOrg.Rows(0)("图纸")
        Me.DataSource = dt

    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format   
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
    End Sub
End Class
