Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class 原材料采购计划单
    Dim i = 0
    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        txt编号.Text = "000001"
        txt完成日期.Text = DateTime.Now.ToString("yyyy-MM-dd")
        i += 1
        txt序号.Text = i
    End Sub
    Public Sub SetControlValue(ByVal dt As DataTable) 

    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub
End Class
