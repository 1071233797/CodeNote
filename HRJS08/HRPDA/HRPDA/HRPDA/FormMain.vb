Public Class FormMain


    Private Sub FormMain_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub



    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt用户.Focus()
    End Sub


    Private Sub ClearFrom()
        txt用户.Text = String.Empty
        txt密码.Text = String.Empty
        txt用户.Focus()

    End Sub

    Private Sub btn清空_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn清空.Click
        ClearFrom()
    End Sub

    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub

    Private Sub btn登录_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn登录.Click
        Try

        
            Dim m As New M用户
            m.用户名 = Me.txt用户.Text.Trim
            m.密码 = Me.txt密码.Text.Trim
            Utility.操作者编号 = DALUtility.F登录(m)
            Utility.操作PDA_IP = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(0).ToString()
            If Utility.操作者编号 <> String.Empty Then
                Dim FMenu As New FormMenu
                FMenu.ShowDialog()
            Else
                MsgBox("用户密码错误！")
                ClearFrom()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn配置_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn配置.Click
        Dim FConfig As New FormConfig
        FConfig.ShowDialog()
    End Sub
End Class
