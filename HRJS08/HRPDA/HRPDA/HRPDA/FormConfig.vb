Public Class FormConfig

    
    Private Sub FormConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl连接字符串.Text = TCXml.readXMl("ConnStr")

    End Sub

    Private Sub FormConfig_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub

    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub

    Private Sub btn保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn保存.Click
        Dim value As String = "Data Source=" + txtIP.Text.Trim + ";database=" + txt数据库名.Text.Trim + ";user id=" + txt用户.Text.Trim + ";password=" + txt密码.Text.Trim + ""
        TCXml.updateXML("Config.xml", "ConnStr", value)
        lbl连接字符串.Text = TCXml.readXMl("ConnStr")
    End Sub
End Class