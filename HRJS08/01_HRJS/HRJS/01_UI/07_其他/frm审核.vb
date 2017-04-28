Public Class frm审核
#Region "変数定義"
    Private str确定 As String
#End Region
#Region "Form Event"

    Private Sub frm审核_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        initForm()
    End Sub
    Private Sub frm审核_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            'If Me.btnLogoOff.Text.ToString.Contains(CSTRLOGOFF) Then

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgYes Then

                e.Cancel = False
            Else
                e.Cancel = True
            End If
            'End If

        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '释放光标
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub initForm()

        Utility.PFn_SetCombo(cmb审核状态, "VM审核状态", 0)

        cmb审核状态.Focus()
        cmb审核状态.Select()
    End Sub

#Region "KeyDown"
    Private Sub frm审核_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        '「F1」ボタン押下
        Select Case e.KeyCode

            Case Keys.F11
                btnF11确定.Focus()
                btnF11确定_Click(Nothing, Nothing)
            Case Keys.F12
                btnF12关闭.Focus()
                btnF12关闭_Click(Nothing, Nothing)
                e.Handled = True
            Case Else
        End Select
    End Sub
#End Region
#End Region

#Region "Button Event"
    Private Sub btnF11确定_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11确定.Click

        ReturnType = 1
        'str确定 = 1
        '画面を閉じる
        Me.Close()
    End Sub

    Private Sub btnF12关闭_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF12关闭.Click


        '关闭画面对话框
        'If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgNo Then
        '    '処理終了
        '    Exit Sub
        'End If

        Me.Close()

    End Sub

#End Region

#Region "Private Method"

    Private Sub Init()
        'Me.FolderBrowserDialog.Description = "选择数据库备份路径"

    End Sub

#End Region
End Class