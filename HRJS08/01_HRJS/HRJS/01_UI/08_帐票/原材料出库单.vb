Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class 原材料出库单
    Dim i = 0

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt日期.Text = Now.ToLongDateString
    End Sub
End Class
