Imports HRJS.Constant
Imports System.IO
Public Class frm模具管理

#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Dim strPath As String = String.Empty
    Dim strPathFlg As Boolean = False
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("MouldPath")
#End Region

#Region "Form Event"

    Private Sub frm生产模具管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frm生产模具管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm模具详细_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                Case Keys.F11
                    btnF11图片导入.Focus()
                    btnF11图片导入_Click(Nothing, Nothing)
                    e.Handled = True

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

    Private Sub txt客户编号_BeforeEditorButtonCheckStateChanged(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.BeforeCheckStateChangedEventArgs) Handles txt客户编号.BeforeEditorButtonCheckStateChanged
        Dim frmSearch As frm客户一览
        Try

            frmSearch = New frm客户一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")     '客户编号

                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")     '客户名称
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放                frmSearch.Dispose()
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


    Private Sub txt客户编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt客户编号.EditorButtonClick
        Dim frmSearch As frm客户一览
        Try

            frmSearch = New frm客户一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")     '客户编号

                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")     '客户名称
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放                frmSearch.Dispose()
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

    Private Sub txt客户编号_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txt客户编号.Leave
        Dim objM客户T As M客户T
        Dim objBLLM客户T As BLLM客户T

        Try

            If txt客户编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt客户编号.Text.Trim <> String.Empty Then

                If Me.txt客户编号.Tag = Me.txt客户编号.Text.Trim Then
                    Exit Sub
                End If

                objM客户T = New M客户T

                objM客户T.客户编号 = txt客户编号.Text.Trim

                objBLLM客户T = New BLLM客户T

                objM客户T = objBLLM客户T.LoadByPKey(objM客户T)

                If objM客户T.客户名称 <> String.Empty Then

                    Me.txt客户名称.Text = objM客户T.客户名称
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "客户名称")
                    'Me.txt客户编号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    Me.txt客户编号.Select()
                End If
            Else
                Me.txt客户编号.Text = String.Empty
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
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

        Dim frmSearch As frm模具一览

        Try

            frmSearch = New frm模具一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '模具信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt模具编号.Text = frmSearch.ReturnTable.Rows(0)("模具编号").ToString          '模具编号
                    Me.txt模具名称.Text = frmSearch.ReturnTable.Rows(0)("模具名称").ToString          '模具名称
                    Me.cbo模具类型.Text = frmSearch.ReturnTable.Rows(0)("类型").ToString          '模具名称

                    Me.txt模具型号.Text = frmSearch.ReturnTable.Rows(0)("模具型号").ToString          '模具名称
                    Me.txt维护周期.Text = frmSearch.ReturnTable.Rows(0)("维护周期").ToString          '维护周期
                    Me.udt上次维护日期.Text = frmSearch.ReturnTable.Rows(0)("上次维护日期").ToString          '上次维护日期
                    Me.dt制造日期.Text = frmSearch.ReturnTable.Rows(0)("制造日期").ToString          '上次维护日期
                    Me.cbo使用状态.Text = frmSearch.ReturnTable.Rows(0)("使用状态").ToString          '使用状态                    Me.txt设计者编号.Text = frmSearch.ReturnTable.Rows(0)("设计者").ToString          '使用状态                    Me.txt设计者名称.Text = frmSearch.ReturnTable.Rows(0)("设计者名称").ToString          '使用状态                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号").ToString          '使用状态                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称").ToString          '使用状态
                    Me.txt使用者编号.Text = frmSearch.ReturnTable.Rows(0)("使用者编号").ToString          '模具编号
                    Me.txt使用者姓名.Text = frmSearch.ReturnTable.Rows(0)("使用者姓名").ToString          '模具名称
                    Me.txt使用者部门.Text = frmSearch.ReturnTable.Rows(0)("使用者部门名称").ToString
                    Me.udt生产日期.Text = frmSearch.ReturnTable.Rows(0)("生产日期").ToString          '上次维护日期

                    Me.txt存放区域.Text = frmSearch.ReturnTable.Rows(0)("库存区域").ToString          '维护厂商

                    Me.txt维护负责人编号.Text = frmSearch.ReturnTable.Rows(0)("维护负责人编号").ToString          '模具编号
                    Me.txt维护负责人姓名.Text = frmSearch.ReturnTable.Rows(0)("维护负责人姓名").ToString          '模具名称
                    Me.txt维护部门名称.Text = frmSearch.ReturnTable.Rows(0)("维护部门名称").ToString

                    Me.txt负责人电话.Text = frmSearch.ReturnTable.Rows(0)("负责人电话").ToString          '负责人电话                    Me.txt维护内容.Text = frmSearch.ReturnTable.Rows(0)("维护内容").ToString          '负责人电话                    If File.Exists(strServerPicturePath & frmSearch.ReturnTable.Rows(0)("模具图片").ToString()) Then
                        SetPictureBoxImage(Me.pic模具图片, strServerPicturePath & frmSearch.ReturnTable.Rows(0)("模具图片").ToString())
                    End If

                    strPath = frmSearch.ReturnTable.Rows(0)("模具图片").ToString()
                    strPathFlg = False
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

            'cbo模具类别.Select()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objM模具T As New M模具T

        Dim objBll As New BLLM模具T

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If
            '保存確認メッセージを表示する
            If Me.txt模具编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "模具编号", "模具编号")
                txt模具编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objM模具T.模具编号 = txt模具编号.Text.Trim

            If objBll.Delete(objM模具T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
            ClearForm()
            Me.txt模具编号.Focus()

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
            Call savePictureServerQuanXian()

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
                Me.txt模具编号.Select()
            Else
                Me.txt模具名称.Select()
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF11图片导入_Click(sender As Object, e As EventArgs) Handles btnF11图片导入.Click
        Try

            Dim dialogResult As DialogResult

            dialogResult = Me.OpenFileDialog.ShowDialog()

            If dialogResult = Windows.Forms.DialogResult.OK Then
                strPath = Me.OpenFileDialog.FileName
            Else
                Exit Sub
            End If
            If File.Exists(strPath) Then
                SetPictureBoxImage(Me.pic模具图片, strPath)
            End If

            strPathFlg = True
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
            Me.SetCombo()

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

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try

            '使用状态
            Utility.PFn_SetCombo(Me.cbo模具类型, "VM模具类型", 0)
            Utility.PFn_SetCombo(Me.cbo使用状态, "VM使用状态", 0)

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

                    txt模具编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt模具编号.Select()
                Case Constant.ENU_MODE.Model_Update

                    txt模具编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    txt模具名称.Select()
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

#Region "ClearForm"

    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()

        Try

            Me.txt模具编号.Text = String.Empty
            Me.cbo模具类型.Text = String.Empty
            Me.txt模具名称.Text = String.Empty
            Me.txt模具型号.Text = String.Empty
            Me.dt制造日期.Text = DateTime.Now
            Me.txt维护周期.Text = String.Empty
            Me.txt设计者编号.Text = String.Empty
            Me.txt设计者名称.Text = String.Empty
            Me.txt客户编号.Text = String.Empty
            Me.txt客户名称.Text = String.Empty
            Me.udt上次维护日期.Text = DateTime.Now
            Me.cbo使用状态.Rows(0).Selected = True
            Me.txt使用者编号.Text = String.Empty
            Me.txt使用者姓名.Text = String.Empty
            Me.txt使用者部门.Text = String.Empty
            Me.udt生产日期.Text = DateTime.Now
            Me.txt存放区域.Text = String.Empty
            Me.pic模具图片.Image = Nothing

            Me.txt维护负责人编号.Text = String.Empty
            Me.txt维护负责人姓名.Text = String.Empty
            Me.txt使用者部门.Text = String.Empty
            Me.txt维护部门名称.Text = String.Empty
            Me.txt负责人电话.Text = String.Empty
            Me.txt维护内容.Text = String.Empty
            Me.txt模具编号.Select()

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

            Dim objM模具T As New M模具T
            Dim objBll As New BLLM模具T

            objM模具T.模具编号 = txt模具编号.Text.Trim
            objM模具T.模具名称 = txt模具名称.Text.Trim
            objM模具T.模具型号 = txt模具型号.Text.Trim
            objM模具T.维护周期 = txt维护周期.Text.Trim
            objM模具T.设计者 = txt设计者编号.Text.Trim
            objM模具T.客户编号 = txt客户编号.Text.Trim
            If Not String.IsNullOrEmpty(udt上次维护日期.Text) Then
                objM模具T.上次维护日期 = udt上次维护日期.Text
            Else
                objM模具T.上次维护日期 = Nothing
            End If
            If Not String.IsNullOrEmpty(dt制造日期.Text) Then
                objM模具T.制造日期 = dt制造日期.Text
            Else
                objM模具T.制造日期 = Nothing
            End If

            If Not String.IsNullOrEmpty(cbo使用状态.Text) Then
                objM模具T.使用状态 = cbo使用状态.Value.Trim
            End If


            If Not String.IsNullOrEmpty(cbo模具类型.Text) Then
                objM模具T.类型 = cbo模具类型.Text.Trim
            End If
            objM模具T.使用者编号 = Me.txt使用者编号.Text.Trim
            'objM模具T.使用者姓名 = Me.txt使用者姓名.Text.Trim
            'objM模具T.使用者部门 = Me.txt使用者部门.Text.Trim

            If Not String.IsNullOrEmpty(udt生产日期.Text) Then
                objM模具T.生产日期 = udt生产日期.Text
            Else
                objM模具T.生产日期 = Nothing
            End If

            objM模具T.存放区域 = txt存放区域.Text.Trim
            objM模具T.维护人编号 = Me.txt维护负责人编号.Text.Trim
            'objM模具T.维护人姓名 = Me.txt维护负责人姓名.Text.Trim
            'objM模具T.维护人部门 = Me.txt维护部门名称.Text.Trim
            'objM模具T.负责人电话 = txt负责人电话.Text.Trim
            objM模具T.维护内容 = Me.txt维护内容.Text.Trim

            objM模具T.模具图片 = Me.txt模具编号.Text & Strings.Right(Path.GetFileName(strPath), 4)
            objM模具T.登录者 = gObjM_人员T.人员编号
            objM模具T.登录日期 = DateTime.Now
            objM模具T.更新者 = gObjM_人员T.人员编号
            objM模具T.更新日期 = DateTime.Now


            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objM模具T).模具编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "模具编号")
                        txt模具编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(objM模具T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                        File.Copy(strPath, strServerPicturePath & Me.txt模具编号.Text & Strings.Right(Path.GetFileName(strPath), 4), True)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt模具编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update(objM模具T) > 0 Then

                        If strPathFlg Then
                            File.Copy(strPath, strServerPicturePath & Me.txt模具编号.Text & Strings.Right(Path.GetFileName(strPath), 4), True)
                        End If


                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt模具编号.Focus()
                        Exit Sub
                    End If

            End Select
            frm生产模具管理_Load(Nothing, Nothing)
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
        Dim objM人员T As M人员T
        Dim objBllM人员T As BLLM人员T
        Try

            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If

            '必須チェック(MsgID=21) 

            '模具ID
            If Me.txt模具编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "模具编号", "模具编号")
                txt模具编号.Focus()
                Return False
            End If

            '判断输入内容是否为数字，跳出提示
            'If Not IsNumeric(Me.txt模具编号.Text.Trim) Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID30, "模具编号", "模具编号")
            '    txt模具编号.Focus()
            '    Return False
            'End If

            If Me.cbo模具类型.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "模具类型", "模具类型")
                cbo模具类型.Focus()
                Return False
            End If
            '模具名
            If Me.txt模具名称.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "模具名称", "模具名称")
                txt模具名称.Focus()
                Return False
            End If
            If Me.cbo使用状态.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "使用状态", "使用状态")
                cbo使用状态.Focus()
                Return False
            End If

            If Me.txt维护负责人编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "维护负责人编号", "维护负责人编号")
                txt维护负责人编号.Focus()
                Return False
            End If
            If Me.txt使用者编号.Text.Trim <> String.Empty Then
                objM人员T = New M人员T

                objM人员T.人员编号 = txt使用者编号.Text.Trim

                objBllM人员T = New BLLM人员T

                objM人员T = objBllM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员编号 = String.Empty Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "使用者")
                    txt使用者编号.Focus()
                    Return False
                End If
            End If
            If Me.txt维护负责人编号.Text.Trim <> String.Empty Then
                objM人员T = New M人员T

                objM人员T.人员编号 = txt维护负责人编号.Text.Trim

                objBllM人员T = New BLLM人员T

                objM人员T = objBllM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员编号 = String.Empty Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "维护负责人")
                    txt维护负责人编号.Focus()
                    Return False
                End If
            End If

            If pic模具图片.Image Is Nothing Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "模具图片")
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
            Me.btnF11图片导入.Enabled = Utility.PFn_GetAuth(Me.btnF11图片导入.Tag)
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

#Region "使用者"

    Private Sub txt使用者编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt使用者编号.Enter, txt设计者编号.Enter

        Try

            Me.txt使用者编号.Tag = Me.txt使用者编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt使用者编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt使用者编号.EditorButtonClick


        Dim frmSearch As frm人员一览
        Try

            frmSearch = New frm人员一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt使用者编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '客户编号

                    Me.txt使用者姓名.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '客户名称

                    Me.txt使用者部门.Text = frmSearch.ReturnTable.Rows(0)("部门名称")     '部门

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


    Private Sub txt设计者编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt设计者编号.EditorButtonClick


        Dim frmSearch As frm人员一览
        Try

            frmSearch = New frm人员一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt设计者编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '客户编号

                    Me.txt设计者名称.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '客户名称

                    'Me.txt使用者部门.Text = frmSearch.ReturnTable.Rows(0)("部门名称")     '部门

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

    'Private Sub txt使用者编号_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt使用者编号.Validating

    '    Dim objM人员T As M人员T
    '    Dim objBllM人员T As BLLM人员T

    '    Try

    '        If txt使用者编号.ReadOnly Then
    '            Exit Sub
    '        End If

    '        If Me.txt使用者编号.Text.Trim <> String.Empty Then

    '            If Me.txt使用者编号.Tag = Me.txt使用者编号.Text.Trim Then
    '                Exit Sub
    '            End If

    '            objM人员T = New M人员T

    '            objM人员T.人员编号 = txt使用者编号.Text.Trim

    '            objBllM人员T = New BLLM人员T

    '            objM人员T = objBllM人员T.LoadByPKey(objM人员T)

    '            If objM人员T.人员编号 <> "" Then

    '                Me.txt使用者姓名.Text = objM人员T.人员名    '                Me.txt使用者部门.Text = objM人员T.部门    '部门


    '            Else
    '                txt使用者编号.Text = String.Empty
    '                Me.txt使用者姓名.Text = String.Empty
    '                txt使用者部门.Text = String.Empty
    '                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员姓名")
    '                Me.txt使用者编号.Select()
    '            End If
    '        Else
    '            Me.txt使用者姓名.Text = String.Empty
    '            Me.txt使用者部门.Text = String.Empty
    '        End If

    '    Catch ex As Exception
    '        異常処理()
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        デフォルトのカーソル()
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

#End Region

#Region "维护人"

    Private Sub txt维护负责人编号_Enter(sender As Object, e As EventArgs) Handles txt维护负责人编号.Enter

        Try

            Me.txt维护负责人编号.Tag = Me.txt维护负责人编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt维护负责人编号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt维护负责人编号.EditorButtonClick


        Dim frmSearch As frm人员一览
        Try

            frmSearch = New frm人员一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt维护负责人编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '客户编号

                    Me.txt维护负责人姓名.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '客户名称

                    Me.txt维护部门名称.Text = frmSearch.ReturnTable.Rows(0)("部门名称")     '部门

                    Me.txt负责人电话.Text = frmSearch.ReturnTable.Rows(0)("电话号码")     '部门

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

    'Private Sub txt维护负责人编号_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt维护负责人编号.Validating

    '    Dim objM人员T As M人员T
    '    Dim objBllM人员T As BLLM人员T

    '    Try

    '        If txt维护负责人编号.ReadOnly Then
    '            Exit Sub
    '        End If

    '        If Me.txt维护负责人编号.Text.Trim <> String.Empty Then

    '            If Me.txt维护负责人编号.Tag = Me.txt维护负责人编号.Text.Trim Then
    '                Exit Sub
    '            End If

    '            objM人员T = New M人员T

    '            objM人员T.人员编号 = txt维护负责人编号.Text.Trim

    '            objBllM人员T = New BLLM人员T

    '            objM人员T = objBllM人员T.LoadByPKey(objM人员T)

    '            If objM人员T.人员编号 <> "" Then

    '                Me.txt维护负责人编号.Text = objM人员T.人员名    '                Me.txt维护部门名称.Text = objM人员T.部门    '部门


    '            Else
    '                txt维护负责人编号.Text = String.Empty
    '                Me.txt维护负责人姓名.Text = String.Empty
    '                txt维护部门名称.Text = String.Empty
    '                'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员姓名")
    '                'Me.txt使用者编号.Select()
    '            End If
    '        Else
    '            Me.txt维护负责人姓名.Text = String.Empty
    '            Me.txt维护部门名称.Text = String.Empty
    '        End If

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

#End Region
#End Region

#Region "图片大小设定"
    Friend Sub SetPictureBoxImage(ByVal pb As PictureBox, ByVal sFileName As String)
        '定义一个Bitmap对象作为绘制的接受对象
        Dim bmp As New Bitmap(pb.Width, pb.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        Dim img As Image = Image.FromFile(sFileName)
        Dim rectImage As New Rectangle(0, 0, bmp.Width, bmp.Height)
        '按比例缩放
        GetScaleZoomRect(img.Width, img.Height, rectImage.Width, rectImage.Height)
        g.DrawImage(img, rectImage)

        pb.Image = bmp
    End Sub

    Friend Sub GetScaleZoomRect(ByVal nSrcWidth As Integer, ByVal nSrcHeight As Integer, ByRef nDstWidth As Integer, ByRef nDstHeight As Integer)
        If nSrcWidth / nSrcHeight < nDstWidth / nDstHeight Then
            nDstWidth = nDstHeight * (nSrcWidth / nSrcHeight)
        Else
            nDstHeight = nDstWidth * (nSrcHeight / nSrcWidth)
        End If
    End Sub


#End Region


    Private Sub txt设计者编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt设计者编号.Leave
        Dim objM人员T As M人员T
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt设计者编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt设计者编号.Text.Trim <> String.Empty Then

                If Me.txt设计者编号.Tag = Me.txt设计者编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt设计者编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                objM人员T = objBLLM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员名 <> String.Empty Then


                    Me.txt设计者名称.Text = objM人员T.人员名     '客户名称

                    Me.udt上次维护日期.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "设计者名称")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt设计者名称.Text = String.Empty
                    Me.txt设计者编号.Select()
                End If
            Else
                Me.txt设计者编号.Text = String.Empty
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt使用者编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt使用者编号.Leave
        Dim objM人员T As M人员T
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt使用者编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt使用者编号.Text.Trim <> String.Empty Then

                If Me.txt使用者编号.Tag = Me.txt使用者编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt使用者编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                objM人员T = objBLLM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员名 <> String.Empty Then


                    Me.txt使用者姓名.Text = objM人员T.人员名     '客户名称


                    Me.txt使用者部门.Text = objM人员T.部门

                    Me.udt生产日期.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "使用者名称")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt使用者姓名.Text = String.Empty
                    Me.txt使用者部门.Text = String.Empty
                    Me.txt使用者编号.Select()
                End If
            Else
                Me.txt使用者编号.Text = String.Empty
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt维护负责人编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt维护负责人编号.Leave
        Dim objM人员T As M人员T
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt维护负责人编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt维护负责人编号.Text.Trim <> String.Empty Then

                If Me.txt维护负责人编号.Tag = Me.txt维护负责人编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt维护负责人编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                objM人员T = objBLLM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员名 <> String.Empty Then


                    Me.txt维护负责人姓名.Text = objM人员T.人员名     '客户名称


                    Me.txt维护部门名称.Text = objM人员T.部门
                    Me.txt负责人电话.Text = objM人员T.电话号码

                    Me.txt负责人电话.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员名称")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt维护负责人姓名.Text = String.Empty
                    Me.txt维护部门名称.Text = String.Empty
                    Me.txt维护负责人编号.Select()
                End If
            Else
                Me.txt维护负责人编号.Text = String.Empty
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    ''' <summary>
    ''' 获取访问服务器权限
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub savePictureServerQuanXian()
        Dim p As New Process
        '获取权限
        '--------------------------------------------------
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/c net use " & _
                                System.Configuration.ConfigurationManager.AppSettings.Get("PictureServer") & " " & Chr(34) & _
                                System.Configuration.ConfigurationManager.AppSettings.Get("PicturePassword") & Chr(34) & _
                                " /user:" & Chr(34) & _
                                System.Configuration.ConfigurationManager.AppSettings.Get("PictureUserID") & Chr(34)
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardInput = True
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardError = True
        p.StartInfo.CreateNoWindow = True
        p.Start()
        '--------------------------------------------------
    End Sub

    'Private Sub txt模具编号_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt模具编号.KeyPress
    '    '只能输入数字
    '    If Utility.IsDigit(e.KeyChar) = False Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    'End Sub

End Class