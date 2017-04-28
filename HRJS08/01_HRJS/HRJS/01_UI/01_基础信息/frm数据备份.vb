Imports UserControl
Public Class frm数据备份

#Region "Form Event"

    Private Sub frm数据备份_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initForm()
    End Sub
    Private Sub frm数据备份_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

        Init()
        LoadData()
        SetPermission()

        txt数据库备份路径.Focus()
        txt数据库备份路径.Select()
    End Sub

#Region "KeyDown"
    Private Sub frm数据备份_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        '「F1」ボタン押下
        Select Case e.KeyValue

            Case Keys.F11
                Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_BACKUP)
            Case Keys.F12
                Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_CLOSE)
        End Select
    End Sub
#End Region
#End Region

#Region "Button Event"

    Private Sub txt数据库备份路径_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt数据库备份路径.EditorButtonClick
        OpenDialog()
    End Sub

    Private Sub txt数据库备份路径_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles txt数据库备份路径.DoubleClick
        OpenDialog()
    End Sub

    Private Sub btnBackUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11备份.Click

        Dim objBLLM系统设置T As New BLLM系统设置T
        Dim objM数据库备份T As M数据库备份T

        Try
            If Me.txt数据库备份路径.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "数据库备份路径")
                txt数据库备份路径.Focus()
                Exit Sub
            End If

            'If Not System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(Me.txt数据库备份路径.Text.Trim)) Then
            If Not System.IO.Directory.Exists(Me.txt数据库备份路径.Text.Trim) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID33) '目录不存在
                Exit Sub
            End If

            Me.txt数据库备份路径.Text = Me.txt数据库备份路径.Text.Trim & "\" & Constant.CON_DATABASE_NAME & String.Format("{0:yyyyMMddHHmmss}", DateTime.Now) & ".bak"

            objM数据库备份T = New M数据库备份T

            objM数据库备份T.数据库名 = Constant.CON_DATABASE_NAME
            objM数据库备份T.备份路径 = Me.txt数据库备份路径.Text.Trim
            objM数据库备份T.登录者 = gObjM_人员T.人员编号
            objM数据库备份T.登录日期 = DateTime.Now


            If objBLLM系统设置T.Exc_DBBackUp(objM数据库备份T) > 0 Then
                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrBakUpDB)
            Else

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrBakUpDB)
                Me.txt数据库备份路径.Select()
                Exit Sub

            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try


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
        Me.FolderBrowserDialog.Description = "选择数据库备份路径"

    End Sub

    Private Sub LoadData()

        Dim objBLLM系统设置T As BLLM系统设置T
        Dim objM数据库备份T As M数据库备份T

        objBLLM系统设置T = New BLLM系统设置T
        objM数据库备份T = objBLLM系统设置T.GetLastDBBackupInfo()

        Me.txt上次备份日期.Text = objM数据库备份T.登录日期
        Me.FolderBrowserDialog.SelectedPath = System.IO.Path.GetDirectoryName(objM数据库备份T.备份路径)

    End Sub

    Private Sub OpenDialog()
        Dim dialogResult As DialogResult

        dialogResult = Me.FolderBrowserDialog.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.OK Then
            Me.txt数据库备份路径.Text = Me.FolderBrowserDialog.SelectedPath

        End If
    End Sub


#Region "自定義関数"

    Private Function Sb_SetButtonKey(ByVal strButtonName As String) As Boolean
        Dim strProwerButtonName As String = String.Empty        '権限ボタン名
        Dim i As Integer                                        '

        '画面のコントロールを判断する
        If Me.Controls.Count <= 0 Then
            Return False
        End If

        For i = 0 To Me.Controls.Count - 1
            'ボタンを判断する
            If Me.Controls(i).GetType() Is GetType(UCButton) Then
                If CType(Me.Controls(i), UCButton).Enabled Then
                    If CType(Me.Controls(i), UCButton).Visible Then
                        '権限ボタン名を取得する
                        strProwerButtonName = CType(Me.Controls(i), UCButton).FSearchButtonName
                        If strButtonName.Equals(strProwerButtonName) Then
                            'ボタンのクリック事件を実行する
                            Call CType(Me.Controls(i), UCButton).MyOnclick()

                            'ループ終了
                            Return False
                        End If
                    End If

                End If
            End If
        Next

        ''ボタンの存在を判断する
        'If Not Me.Controls(strButtonName) Is Nothing Then
        '    'ボタンの使用を判断する
        '    If CType(Me.Controls(strButtonName), CtlButton).Enabled Then
        '        'ボタンのクリック事件を実行する
        '        Call CType(Me.Controls(strButtonName), CtlButton).PSb_Onclick()
        '    End If
        'End If

        Return True

    End Function

#Region "SetPermission"

    Private Sub SetPermission()
        Try

            Me.btnF11备份.Enabled = Utility.PFn_GetAuth(Me.btnF11备份.Tag)

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region
#End Region

#End Region

End Class