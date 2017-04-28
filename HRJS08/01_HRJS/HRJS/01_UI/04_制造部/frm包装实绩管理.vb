Imports HRJS.Constant

Public Class frm包装实绩管理

#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable
#End Region

#Region "Form Event"

    Private Sub frm包装实际管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub frm包装实际管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm包装实际管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                    'Case Keys.F5
                    '    btnF5行追加.Focus()
                    '    btnF5行追加_Click(Nothing, Nothing)
                    'Case Keys.F6
                    '    btnF6行删除.Focus()
                    '    btnF6行删除_Click(Nothing, Nothing)

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
#Region "Control Event"

#Region "订单"
    Private Sub txt订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick
        Dim frmSearch As frm订单一览
        Try

            frmSearch = New frm订单一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search
            frmSearch.intDoubleClick = 1
            '订单一览画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号").ToString        '订单编号
                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号").ToString        '订单编号
                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称").ToString        '订单编号
                    Me.txt计划生产数量.Text = frmSearch.ReturnTable.Rows(0)("订单数量").ToString        '订单编号
                    'SetData1()

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
#End Region
#Region "人员"
    Private Sub txt人员编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt人员编号.EditorButtonClick
        Dim frmSearch As frm人员一览
        Try

            frmSearch = New frm人员一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '人员一览画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt人员编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号").ToString        '人员编号

                    SetData()
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
    Private Sub txt人员编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt人员编号.Leave
        Dim objM人员T As M人员T
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt人员编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt人员编号.Text.Trim <> String.Empty Then

                If Me.txt人员编号.Tag = Me.txt人员编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt人员编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                objM人员T = objBLLM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员名 <> String.Empty Then


                    Me.txt人员名.Text = objM人员T.人员名     '客户名称

                    Me.txt职务.Text = objM人员T.职务

                    Me.txt部门名称.Text = objM人员T.部门

                    Me.dmt作业日期.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员名称")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt人员名.Text = String.Empty
                    Me.txt人员编号.Select()
                End If
            Else
                Me.txt人员编号.Text = String.Empty
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
#Region "流转票编号"
    Private Sub txt流转票编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs)
        Dim frmSearch As frm流转票一览
        Try

            frmSearch = New frm流转票一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '流转票一览画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号").ToString            '产品图号
                    'Me.txt流转票编号.Text = frmSearch.ReturnTable.Rows(0)("流转票编号").ToString        '流转票编号
                    'Me.txt作业指示.Text = frmSearch.ReturnTable.Rows(0)("加工内容简介").ToString        '加工内容简介
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
#End Region
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

        Dim frmSearch As frm包装实绩一览

        Try

            frmSearch = New frm包装实绩一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '包装实绩一览画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号").ToString          '订单编号

                    '设置画面数据
                    SetFormData()

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

        Dim objZ包装实际T As New Z包装实际管理T

        Dim objBll As New BLLZ包装实际管理T

        Try
            'If mIntFormMode = Constant.ENU_MODE.Model_New Then
            '    Exit Sub
            'End If

            '保存確認メッセージを表示する
            If Me.txt订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
                txt订单编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            objZ包装实际T.订单编号 = txt订单编号.Text.Trim

            If objBll.Delete(objZ包装实际T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()

            ClearForm()

            Me.txt人员编号.Focus()

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
                Me.txt订单编号.Select()
            Else
                Me.txt产品图号.Select()
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

            '交货方式
            Utility.PFn_SetCombo(Me.cmb作业方式, "VM作业方式", 0)

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

                    txt订单编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt人员编号.Focus()
                Case Constant.ENU_MODE.Model_Update

                    txt订单编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    txt人员编号.Focus()
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

            Me.txt人员编号.Text = String.Empty
            Me.txt人员名.Text = String.Empty
            Me.txt职务.Text = String.Empty
            Me.txt部门名称.Text = String.Empty
            Me.dmt作业日期.Text = Date.Now
            Me.cmb作业方式.Text = String.Empty
            Me.dmt完成日期.Text = Date.Now
            Me.txt订单编号.Text = String.Empty
            Me.txt产品图号.Text = String.Empty
            Me.txt客户名称.Text = String.Empty   
            Me.txt计划生产数量.Text = String.Empty
            Me.txt实际生产数量.Text = String.Empty
            'mdsGridDataSet.Clear()
            'Me.grid包装实际管理.DataSource = mdsGridDataSet
            Me.txt人员编号.Select()

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
    ''' <summary>
    ''' 画面の保存処理    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveData()

        Try

            Dim objZ包装实际T As New Z包装实际管理T
            Dim objBll As New BLLZ包装实际管理T
            Dim arryList As New ArrayList

            objZ包装实际T.订单编号 = txt订单编号.Text.Trim
            objZ包装实际T.产品图号 = txt产品图号.Text.Trim
            objZ包装实际T.人员编号 = txt人员编号.Text.Trim
            objZ包装实际T.作业日期 = dmt作业日期.Text.Trim
            objZ包装实际T.作业方式 = cmb作业方式.Text.Trim
            objZ包装实际T.完成日期 = dmt完成日期.Text.Trim
            objZ包装实际T.实际生产数 = txt实际生产数量.Text.Trim
            objZ包装实际T.登陆者 = gObjM_人员T.人员编号
            objZ包装实际T.登陆日期 = DateTime.Now
            objZ包装实际T.更新者 = gObjM_人员T.人员编号
            objZ包装实际T.更新日期 = DateTime.Now
            arryList.Add(objZ包装实际T)

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objZ包装实际T).订单编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "订单编号")
                        Me.txt订单编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt订单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update(objZ包装实际T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt人员编号.Focus()
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

        Try

            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If

            '必須チェック(MsgID=21) 

            ''人员编号
            If Me.txt人员编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "人员编号", "人员编号")
                txt人员编号.Focus()
                Return False
            End If

            ''订单编号
            If Me.txt订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
                txt订单编号.Focus()
                Return False
            End If

            '流转票编号()

            'If Me.txt流转票编号.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "流转票编号", "流转票编号")
            '    txt流转票编号.Focus()
            '    Return False
            'End If

            '制造批量号()

            'If Me.txt制造批量号.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "制造批量号", "制造批量号")
            '    txt制造批量号.Focus()
            '    Return False
            'End If

            '实际生产数量

            If Me.txt实际生产数量.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "实际生产数量", "实际生产数量")
                txt实际生产数量.Focus()
                Return False
            End If
            '完成日期

            If Me.dmt完成日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "完成日期", "完成日期")
                dmt完成日期.Focus()
                Return False
            End If
            '作业日期

            If Me.dmt作业日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "作业日期", "作业日期")
                dmt作业日期.Focus()
                Return False
            End If

            'If Not String.IsNullOrEmpty(dmt作业时间sta.Text.Trim) And Not String.IsNullOrEmpty(dmt作业时间end.Text.Trim) Then
            '    If DateTime.Parse(dmt作业时间end.DateTime) > DateTime.Parse(dmt作业时间sta.DateTime) Then
            '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "作业开始时间", "作业开始时间")
            '        dmt作业时间sta.Focus()
            '        Return False
            '    End If
            'End If

            'For Each dr As DataRow In Me.grid包装实际管理.DataSource.Rows
            '    If dr("图纸尺寸") & "" = "" Then
            '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "图纸尺寸") '图纸尺寸

            '        Return False
            '    End If
            '    If dr("公差") & "" = "" Then
            '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "公差") '公差

            '        Return False
            '    End If

            'Next

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
    ''' <summary>
    ''' 権限の制御処理
    ''' </summary>
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

#Region "SetData"
    Private Sub SetData()
        Dim objZ包装实际T As New Z包装实际管理T
        Dim objBll As BLLZ包装实际管理T

        Try
            '获取数据
            objZ包装实际T = New Z包装实际管理T
            objBll = New BLLZ包装实际管理T

            objZ包装实际T.人员编号 = txt人员编号.Text.Trim()

            If String.IsNullOrEmpty(objZ包装实际T.人员编号) Then
                objZ包装实际T.人员编号 = " "
            End If
            If txt人员编号.Text.Trim <> String.Empty Then
                mdsInfoDataSet = objBll.Load人员(objZ包装实际T)
                If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                    Me.txt人员编号.Text = mdsInfoDataSet.Rows(0)("人员编号").ToString()
                    Me.txt人员名.Text = mdsInfoDataSet.Rows(0)("人员名").ToString()
                    Me.txt职务.Text = mdsInfoDataSet.Rows(0)("职务").ToString()
                    Me.txt部门名称.Text = mdsInfoDataSet.Rows(0)("部门名称").ToString()

                Else
                    Me.txt人员编号.Text = String.Empty
                    Me.txt部门名称.Text = String.Empty
                End If
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

#Region "SetData1"

    Private Sub SetData1()

        Dim objZ包装实际T As New Z包装实际管理T
        Dim objBll As BLLZ包装实际管理T

        Try
            '获取数据
            objZ包装实际T = New Z包装实际管理T
            objBll = New BLLZ包装实际管理T

            objZ包装实际T.订单编号 = txt订单编号.Text.Trim()

            If String.IsNullOrEmpty(objZ包装实际T.订单编号) Then
                objZ包装实际T.订单编号 = " "
            End If
            If txt订单编号.Text.Trim <> String.Empty Then
                mdsInfoDataSet = objBll.Load订单(objZ包装实际T)
                If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                    Me.txt订单编号.Text = mdsInfoDataSet.Rows(0)("订单编号").ToString()
                    Me.txt产品图号.Text = mdsInfoDataSet.Rows(0)("产品图号").ToString()
                    Me.txt客户名称.Text = mdsInfoDataSet.Rows(0)("客户名称").ToString()
                    Me.txt计划生产数量.Text = mdsInfoDataSet.Rows(0)("订单数量").ToString()

                Else
                    Me.txt订单编号.Text = String.Empty
                    Me.txt产品图号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    Me.txt计划生产数量.Text = String.Empty
                End If
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

#Region "SetFormData"
    Private Sub SetFormData()
        Dim objZ包装实际T As New Z包装实际管理T
        Dim objBll As BLLZ包装实际管理T

        Try
            '获取数据
            objZ包装实际T = New Z包装实际管理T
            objBll = New BLLZ包装实际管理T

            objZ包装实际T.订单编号 = txt订单编号.Text.Trim()

            If String.IsNullOrEmpty(objZ包装实际T.订单编号) Then
                objZ包装实际T.订单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAll(objZ包装实际T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                Me.txt订单编号.Text = mdsInfoDataSet.Rows(0)("订单编号").ToString()
                Me.txt人员编号.Text = mdsInfoDataSet.Rows(0)("人员编号").ToString
                Me.txt人员名.Text = mdsInfoDataSet.Rows(0)("人员名").ToString
                Me.txt职务.Text = mdsInfoDataSet.Rows(0)("职务").ToString
                Me.txt部门名称.Text = mdsInfoDataSet.Rows(0)("部门名称").ToString
                Me.txt客户名称.Text = mdsInfoDataSet.Rows(0)("客户名称").ToString
                Me.txt产品图号.Text = mdsInfoDataSet.Rows(0)("产品图号").ToString
                Me.txt计划生产数量.Text = mdsInfoDataSet.Rows(0)("投产数量").ToString()
                Me.txt实际生产数量.Text = mdsInfoDataSet.Rows(0)("实际生产数").ToString()
                Me.dmt作业日期.Text = mdsInfoDataSet.Rows(0)("作业日期").ToString()
                Me.dmt完成日期.Text = mdsInfoDataSet.Rows(0)("完成日期").ToString()               
                Me.cmb作业方式.Text = mdsInfoDataSet.Rows(0)("作业方式").ToString()

            Else
                Me.txt订单编号.Text = String.Empty
                Me.txt人员编号.Text = String.Empty
                Me.txt人员名.Text = String.Empty
                Me.txt职务.Text = String.Empty
                Me.txt部门名称.Text = String.Empty
                Me.txt客户名称.Text = String.Empty
                Me.txt产品图号.Text = String.Empty
                Me.txt计划生产数量.Text = String.Empty
                Me.txt实际生产数量.Text = String.Empty
                Me.dmt作业日期.Text = String.Empty
                Me.dmt完成日期.Text = String.Empty
                Me.cmb作业方式.Text = String.Empty

            End If

            'mdsGridDataSet = objBll.LoadAllGrid(objZ包装实际T)
            'grid包装实际管理.DataSource = mdsGridDataSet

            'End If
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