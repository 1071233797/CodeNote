Public Class frm包装管理

#Region "変数定義"
    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
#End Region

#Region "Form Event"
    Private Sub frm包装管理详细_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            '画面の初期化処理
            Me.InitForm()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub frm包装管理详细_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm包装管理查询_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                Case Keys.F2
                    btnF2编辑.Focus()
                    btnF2编辑_Click(Nothing, Nothing)

                Case Keys.F3
                    btnF3保存.Focus()
                    btnF3保存_Click(Nothing, Nothing)

                Case Keys.F4
                    btnF4删除.Focus()
                    btnF4删除_Click(Nothing, Nothing)

                Case Keys.F12
                    btnF12关闭.Focus()
                    btnF12关闭_Click(Nothing, Nothing)
                    e.Handled = True

                Case Else

            End Select

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub btnF1清空_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF1清空.Click

        Try
            '清空画面对话框

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            ''画面の初期化処理
            ClearForm()

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub btnF12关闭_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF12关闭.Click


        Try

            '关闭画面对话框

            'If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgNo Then
            '    '処理終了
            '    Exit Sub
            'End If

            Me.Cursor = Cursors.WaitCursor

            ''画面の終了処理

            Me.Close()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub btnF2编辑_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2编辑.Click

        Dim frmSearch As frm包装一览


        Try

            frmSearch = New frm包装一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt包装物编号.Text = frmSearch.ReturnTable.Rows(0)("包装物编号").ToString          '包装物编号
                    Me.txt包装物名称.Text = frmSearch.ReturnTable.Rows(0)("包装物名称").ToString          '包装物名称
                    Me.txt规格.Text = frmSearch.ReturnTable.Rows(0)("规格").ToString          'txt规格
                    Me.txt供应商编号.Text = frmSearch.ReturnTable.Rows(0)("供应商编号").ToString          'txt供应商编号
                    Me.txt供应商名称.Text = frmSearch.ReturnTable.Rows(0)("供应商名称").ToString          'txt供应商名称

                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放

                frmSearch.Dispose()
                frmSearch = Nothing


                '画面の修正処理
                mIntFormMode = Constant.ENU_MODE.Model_Update

                SetFormModel()

            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objM包装T As New M包装T

        Dim objBll As New BLLM包装T

        Try

            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If Me.txt包装物编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "包装物编号", "包装物编号")
                txt包装物编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            objM包装T.包装物编号 = txt包装物编号.Text.Trim

            If objBll.Delete(objM包装T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
            ClearForm()
            Me.txt包装物编号.Focus()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub btnF3保存_Click(sender As Object, e As EventArgs) Handles btnF3保存.Click

        Try

            '画面のCheck処理
            If Not InputCheck() Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID2) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            '保存処理
            SaveData()
            Me.ClearForm()
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Me.txt包装物编号.Select()
            Else
                Me.txt包装物名称.Select()
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub txt供应商编号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt供应商编号.EditorButtonClick
        Dim frmSearch As frm供应商一览

        Try

            frmSearch = New frm供应商一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt供应商编号.Text = frmSearch.ReturnTable.Rows(0)("供应商编号")          '供应商编号

                    Me.txt供应商名称.Text = frmSearch.ReturnTable.Rows(0)("供应商名称")     '供应商名称


                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放

                frmSearch.Dispose()
                frmSearch = Nothing

            End If

            '光标设置
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '默认光标设置
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub txt供应商编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt供应商编号.Leave
        Dim objM供应商T As M供应商T
        Dim objBLLM供应商T As BLLM供应商T

        Try

            If Me.txt供应商编号.Text.Trim <> String.Empty Then

                If Me.txt供应商编号.Tag = Me.txt供应商编号.Text.Trim Then
                    Exit Sub
                End If

                objM供应商T = New M供应商T

                objM供应商T.供应商编号 = txt供应商编号.Text.Trim

                objBLLM供应商T = New BLLM供应商T

                objM供应商T = objBLLM供应商T.LoadByPKey(objM供应商T)

                If objM供应商T.供应商名称 <> String.Empty Then


                    Me.txt供应商名称.Text = objM供应商T.供应商名称    '客户名称


                    Me.btnF3保存.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "供应商名称")

                    Me.txt供应商编号.Text = String.Empty
                    Me.txt供应商名称.Text = String.Empty
                    Me.txt供应商编号.Select()
                End If
            Else
                Me.txt供应商编号.Text = String.Empty
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "InputCheck"
    ''' <summary>
    ''' 画面のCheck処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Function InputCheck() As Boolean

        Try

            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If
            '必須チェック(MsgID=21) 

            '包装物编号
            If Me.txt包装物编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "包装物编号", "包装物编号")
                txt包装物编号.Focus()
                Return False
            End If

            '包装物名称
            If Me.txt包装物名称.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "包装物名称", "包装物名称")
                txt包装物名称.Focus()
                Return False
            End If

            '规格
            If Me.txt规格.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "规格", "规格")
                txt规格.Focus()
                Return False
            End If

            '供应商编号
            If Me.txt供应商编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "供应商编号", "供应商编号")
                txt供应商编号.Focus()
                Return False
            End If

            '供应商名称
            If Me.txt供应商名称.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "供应商名称", "供应商名称")
                txt供应商名称.Focus()
                Return False
            End If

            Return True

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
            Return False
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Function

#End Region

#Region "SaveData"
    ''' <summary>
    ''' 画面の保存処理    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveData()

        Try

            Dim objM包装T As New M包装T
            Dim objBll As New BLLM包装T

            objM包装T.包装物编号 = txt包装物编号.Text.Trim
            objM包装T.包装物名称 = txt包装物名称.Text.Trim

            objM包装T.规格 = txt规格.Text.Trim
            objM包装T.供应商编号 = txt供应商编号.Text.Trim
            objM包装T.登录者 = Constant.LoginInfo.UserID
            objM包装T.登录日期 = DateTime.Now
            objM包装T.更新者 = Constant.LoginInfo.UserID
            objM包装T.更新日期 = DateTime.Now

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    '检查数据是否存在   
                    If objBll.LoadByPKey(objM包装T).包装物编号 <> String.Empty Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "包装物编号")
                        Me.txt包装物编号.Select()
                        '処理終了
                        Exit Sub
                    End If

                    '数据插入
                    If objBll.Insert(objM包装T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt包装物编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update(objM包装T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt包装物编号.Focus()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Delete

                    If objBll.Delete(objM包装T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrDelete)
                        Me.txt包装物编号.Focus()
                        Exit Sub
                    End If

            End Select

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try
            '画面のComboの初期値を設定する
            'Me.SetCombo()

            '画面の内容を清空処理
            Me.ClearForm()

            '権限の処理
            Me.SetPermission()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "清空"

    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()

        Try

            Me.txt包装物编号.Text = String.Empty
            Me.txt包装物名称.Text = String.Empty
            Me.txt规格.Text = String.Empty
            Me.txt供应商编号.Text = String.Empty
            Me.txt供应商名称.Text = String.Empty

            Me.txt包装物编号.Select()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "'SetPermission"
    ''' <summary>
    ''' 権限の制御処理    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPermission()
        Try

            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "SetFormModel"

    Private Sub SetFormModel()

        Try

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    txt包装物编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt包装物编号.Focus()
                Case Constant.ENU_MODE.Model_Update

                    txt包装物编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    txt包装物名称.Focus()
                Case Else

            End Select

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

    
 
End Class