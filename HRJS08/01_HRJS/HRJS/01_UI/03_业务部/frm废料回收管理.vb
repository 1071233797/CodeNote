Imports HRJS.Constant
Public Class frm废料回收管理

#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Dim strID As String = String.Empty
#End Region

#Region "Form Event"

    Private Sub frm废料回收管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub frm废料回收管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm废料回收管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

#End Region

#Region "Button Event"

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

        Dim frmSearch As frm废料回收一览

        Try

            frmSearch = New frm废料回收一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '设备信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    strID = frmSearch.ReturnTable.Rows(0)("ID").ToString
                    Me.txt原材料编号.Text = frmSearch.ReturnTable.Rows(0)("原材料编号").ToString          '原材料编号
                    Me.txt原材料批号.Text = frmSearch.ReturnTable.Rows(0)("原材料批号").ToString          '原材料批号

                    Me.txt原材料名称.Text = frmSearch.ReturnTable.Rows(0)("原材料名称").ToString          '原材料名称
                    Me.txt废料产生工序.Text = frmSearch.ReturnTable.Rows(0)("废料产生工序").ToString          '废料产生工序
                    Me.txt废料数量.Text = frmSearch.ReturnTable.Rows(0)("废料数量").ToString          '废料数量

                    Me.txt材质.Text = frmSearch.ReturnTable.Rows(0)("材质").ToString          '材质
                    Me.txt原材料规格.Text = frmSearch.ReturnTable.Rows(0)("原材料规格").ToString          '原材料规格

                    Me.txt回收日期.Text = frmSearch.ReturnTable.Rows(0)("回收日期").ToString       '回收日期
                    Me.txt备注.Text = frmSearch.ReturnTable.Rows(0)("备注").ToString          '备注



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

            'cbo设备类别.Select()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objM废料回收管理T As New B废料回收管理T

        Dim objBll As New BLLM废料回收管理T

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If
            '保存確認メッセージを表示する
            If Me.txt原材料编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "原材料编号", "原材料编号")
                txt原材料编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objM废料回收管理T.原材料编号 = txt原材料编号.Text.Trim
            objM废料回收管理T.ID = strID

            If objBll.Delete(objM废料回收管理T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
            ClearForm()
            Me.txt原材料编号.Focus()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF3保存_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF3保存.Click

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

            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Me.txt原材料编号.Select()
            Else
                Me.txt原材料编号.Select()
            End If
            ''画面の初期化処理
            ' ClearForm()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try
            '画面のComboの初期値を設定する
            ' Me.SetCombo()

            'Me.SetInputDigit()

            '画面の内容を清空処理
            Me.ClearForm()

            '権限の処理
            Me.SetPermission()

            Me.txt原材料编号.Select()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "SetCombo"

    'Private Sub SetCombo()

    '    Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

    '    Try

    '        '使用状态
    '        Utility.PFn_SetCombo(Me.cbo使用状态, "VM使用状态", 0)

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

#End Region

#Region "SetFormModel"

    Private Sub SetFormModel()

        Try

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    txt原材料编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt原材料编号.Select()
                Case Constant.ENU_MODE.Model_Update

                    txt原材料编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    txt原材料编号.Select()
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

#Region "SetInputDigit"
    'Private Sub SetInputDigit()
    '    txt设备产量.IsDigit = True
    'End Sub
#End Region

#Region "ClearForm"

    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()

        Try

            Me.txt原材料编号.Text = String.Empty
            Me.txt原材料批号.Text = String.Empty
            Me.txt原材料名称.Text = String.Empty
            Me.txt废料产生工序.Text = String.Empty
            Me.txt废料数量.Text = String.Empty
            Me.txt材质.Text = String.Empty
            Me.txt原材料规格.Text = String.Empty

            Me.txt回收日期.Text = DateTime.Now
            Me.txt备注.Text = String.Empty
           
            Me.txt原材料编号.Select()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "SaveData"

    Private Sub SaveData()

        Try

            Dim objM废料回收管理T As New B废料回收管理T
            Dim objBll As New BLLM废料回收管理T
            objM废料回收管理T.ID = strID
            objM废料回收管理T.原材料编号 = txt原材料编号.Text.Trim
            objM废料回收管理T.原材料批号 = txt原材料批号.Text.Trim
            objM废料回收管理T.原材料名称 = txt原材料名称.Text.Trim
            objM废料回收管理T.废料产生工序 = txt废料产生工序.Text.Trim
            objM废料回收管理T.废料数量 = txt废料数量.Text.Trim
            objM废料回收管理T.材质 = txt材质.Text.Trim
            objM废料回收管理T.原材料规格 = txt原材料规格.Text.Trim
            objM废料回收管理T.回收日期 = txt回收日期.Text.Trim
            objM废料回收管理T.备注 = txt备注.Text.Trim
            'objM废料回收管理T.维护周期 = txt维护周期.Text.Trim



            objM废料回收管理T.登录者 = gObjM_人员T.人员编号
            objM废料回收管理T.登录日期 = DateTime.Now
            objM废料回收管理T.更新者 = gObjM_人员T.人员编号
            objM废料回收管理T.更新日期 = DateTime.Now



            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objM废料回收管理T).原材料编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "原材料编号")
                        txt原材料编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(objM废料回收管理T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt原材料编号.Select()
                        Exit Sub
                    End If



                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update(objM废料回收管理T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt原材料编号.Focus()
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

#Region "InputCheck"
    ''' <summary>
    ''' 画面のCheck処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Function InputCheck() As Boolean
        Dim objM废料回收管理T As B废料回收管理T
        Dim objBllM废料回收管理T As BLLM废料回收管理T
        Try

            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If

            '必須チェック(MsgID=21) 

            '设备ID
            If Me.txt原材料编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "原材料编号", "原材料编号")
                txt原材料编号.Focus()
                Return False
            End If

            If Me.txt原材料批号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "原材料批号", "原材料批号")
                txt原材料批号.Focus()
                Return False
            End If

            '设备名            If Me.txt原材料规格.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "原材料规格", "原材料规格")
                txt原材料规格.Focus()
                Return False
            End If

            If Me.txt废料产生工序.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "废料产生工序", "废料产生工序")
                txt废料产生工序.Focus()
                Return False
            End If
            If Me.txt废料数量.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID30, "废料数量", "废料数量")
                txt废料数量.Focus()
                Return False
            End If
            If Me.txt回收日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "回收日期", "回收日期")
                txt回收日期.Focus()
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

#Region "SetPermission"

    Private Sub SetPermission()
        Try

            'Me.btnF1清空.Enabled = Utility.PFn_GetAuth(Me.btnF1清空.Tag)
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

#End Region

#Region "Control Event"

#Region "原材料编号"

    Private Sub txt原材料编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt原材料编号.Enter

        Try

            Me.txt原材料编号.Tag = Me.txt原材料编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt原材料编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt原材料编号.EditorButtonClick


        Dim frmSearch As frm原材料信息一览
        Try

            frmSearch = New frm原材料信息一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt原材料编号.Text = frmSearch.ReturnTable.Rows(0)("原材料编号")     '原材料编号

                    Me.txt原材料名称.Text = frmSearch.ReturnTable.Rows(0)("原材料名称")     '原材料名称

                    ' Me.txt原材料规格.Text = frmSearch.ReturnTable.Rows(0)("原材料规格")     '原材料规格

                    Me.txt材质.Text = frmSearch.ReturnTable.Rows(0)("材质")     '材质

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

    Private Sub txt原材料编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt原材料编号.Validating

        Dim objM原材料信息T As M原材料信息T
        Dim objBllM原材料信息T As BLLM原材料信息T

        Try

            If txt原材料编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt原材料编号.Text.Trim <> String.Empty Then

                If Me.txt原材料编号.Tag = Me.txt原材料编号.Text.Trim Then
                    Exit Sub
                End If

                objM原材料信息T = New M原材料信息T

                objM原材料信息T.原材料编号 = txt原材料编号.Text.Trim

                objBllM原材料信息T = New BLLM原材料信息T

                objM原材料信息T = objBllM原材料信息T.LoadByPKey(objM原材料信息T)

                If objM原材料信息T.原材料编号 <> "" Then

                    Me.txt原材料编号.Text = objM原材料信息T.原材料编号                    Me.txt原材料名称.Text = objM原材料信息T.原材料名称   '部门
                    Me.txt材质.Text = objM原材料信息T.材质
                    ' Me.txt规格.Text = objM原材料信息T.原材规格

                Else
                    txt原材料编号.Text = String.Empty
                    Me.txt原材料名称.Text = String.Empty
                    txt材质.Text = String.Empty
                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员姓名")
                    'Me.txt使用者编号.Select()
                End If
            Else
                Me.txt原材料编号.Text = String.Empty
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt原材料编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt原材料编号.Leave
        Dim objM原材料信息T As M原材料信息T
        Dim objBLLM原材料信息T As BLLM原材料信息T

        Try

            If txt原材料编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt原材料编号.Text.Trim <> String.Empty Then

                If Me.txt原材料编号.Tag = Me.txt原材料编号.Text.Trim Then
                    Exit Sub
                End If

                objM原材料信息T = New M原材料信息T

                objM原材料信息T.原材料编号 = txt原材料编号.Text.Trim

                objBLLM原材料信息T = New BLLM原材料信息T

                objM原材料信息T = objBLLM原材料信息T.LoadByPKey(objM原材料信息T)

                If objM原材料信息T.原材料名称 <> String.Empty Then


                    Me.txt原材料名称.Text = objM原材料信息T.原材料名称     '客户名称


                    Me.txt原材料批号.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "原材料")
                    'Me.txt原材料编号.Text = String.Empty
                    Me.txt原材料名称.Text = String.Empty
                    Me.txt原材料编号.Select()
                End If
            Else
                Me.txt原材料编号.Text = String.Empty
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

#End Region

End Class