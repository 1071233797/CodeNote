Imports HRJS.Constant
Imports Infragistics.Win.UltraWinGrid
Public Class frm半成品入库质检
#Region "常量定义"
    Private mDtSearch As DataTable = Nothing
    Private Enum ENU_GRID As Integer

        订单编号 = 0
        主图号 = 1
        上级图号 = 2
        分图号 = 3
        半成品名称 = 4
        半成品种类 = 5
        工序编号 = 6
        工序名称 = 7
        入库数量 = 8
        检查内容 = 9
        检查数量 = 10
        不良数量 = 11
        不良原因 = 12
        处理结果 = 13
        备注 = 14

    End Enum
#End Region
#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    ' Private mDtSearch As DataTable = Nothing
    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable

#End Region

#Region "Form Event"

    Private Sub frm半成品入库质检_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frm半成品入库质检_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgYes Then

                e.Cancel = False
            Else
                e.Cancel = True
            End If

        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '释放光标
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frm半成品入库质检_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
                    ' Case Keys.F5
                    '   btnF5直接入库.Focus()
                    '   btnF5直接入库_Click(Nothing, Nothing)




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


    Private Sub grid半成品入库质检_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid半成品入库质检.InitializeLayout
        grid半成品入库质检.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid半成品入库质检.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False

    End Sub

#End Region

#Region "Button Event"

    Private Sub btnF2编辑_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2编辑.Click


        Dim frmSearch As frm半成品入库质检一览        Try
            frmSearch = New frm半成品入库质检一览            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    Me.txt入库申请单编号.Text = frmSearch.ReturnTable.Rows(0)("申请单编号").ToString
                    '设置画面数据
                    SetFormData()
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放                frmSearch.Dispose()
                frmSearch = Nothing


                '画面の修正処理                mIntFormMode = Constant.ENU_MODE.Model_Update
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

    Private Sub btnF1清空_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF1清空.Click

        Try
            '清空画面对话框            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            ''画面の初期化処理
            ClearForm()

            mIntFormMode = Constant.ENU_MODE.Model_New


            SetFormData()
            mIntFormMode = Constant.ENU_MODE.Model_New

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
                Me.txt入库申请单编号.Select()
            Else
                Me.txt检查者编号.Select()
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

        Dim objB半成品入库质检T As New Z半成品入库质检T

        Dim objBll As New BLLZ半成品入库质检T

        Try

            '保存確認メッセージを表示する
            If Me.txt入库申请单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "入库申请单编号", "入库申请单编号")
                txt入库申请单编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            objB半成品入库质检T.申请单编号 = txt入库申请单编号.Text.Trim

            If objBll.Delete(objB半成品入库质检T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New


            ClearForm()
            SetFormData1()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub txt入库申请单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt入库申请单编号.EditorButtonClick


        Dim frmSearch As frm半成品入库申请一览
        Try

            frmSearch = New frm半成品入库申请一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt入库申请单编号.Text = frmSearch.ReturnTable.Rows(0)("申请单编号")     '申请


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
    Private Sub txt检查者编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt检查者编号.EditorButtonClick


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

                    Me.txt检查者名称.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '人员名

                    Me.txt检查者编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '人员编号


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
    Private Sub txt人员编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt检查者编号.Leave
        Dim objM人员T As M人员T
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt检查者编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt检查者编号.Text.Trim <> String.Empty Then

                If Me.txt检查者编号.Tag = Me.txt检查者编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt检查者编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                objM人员T = objBLLM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员名 <> String.Empty Then


                    Me.txt检查者名称.Text = objM人员T.人员名     '客户名称


                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "检查者名称")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt检查者名称.Text = String.Empty
                    Me.txt检查者编号.Select()
                End If
            Else
                Me.txt检查者编号.Text = String.Empty
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
            'SetGridStyle()
            '画面のComboの初期値を設定する
            'Me.SetCombo()

            '画面の内容を清空処理
            Me.ClearForm()
            SetFormData()
            '権限の処理            Me.SetPermission()

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

            Me.txt入库申请单编号.Text = String.Empty
            Me.txt检查者编号.Text = String.Empty
            Me.txt检查者名称.Text = String.Empty
            Me.txt申请者名称.Text = String.Empty
            Me.txt申请日期.Text = String.Empty
            'grid原材料出库申请.DataSource = Nothing

            Me.txt入库申请单编号.Select()

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
            Dim objM半成品入库质检T As New Z半成品入库质检T
            Dim objBll As New BLLZ半成品入库质检T
            Dim arryList As New ArrayList

            If grid半成品入库质检.Rows.Count > 0 Then

                For i = 0 To grid半成品入库质检.Rows.Count - 1
                    objM半成品入库质检T = New Z半成品入库质检T
                    objM半成品入库质检T.申请单编号 = Me.txt入库申请单编号.Text.Trim
                    objM半成品入库质检T.检查者编号 = Me.txt检查者编号.Text.Trim
                    objM半成品入库质检T.检查日期 = DateTime.Now
                    objM半成品入库质检T.订单编号 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.订单编号).Value.ToString()
                    objM半成品入库质检T.主图号 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.主图号).Value.ToString()
                    objM半成品入库质检T.上级图号 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.上级图号).Value.ToString()
                    objM半成品入库质检T.分图号 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.分图号).Value.ToString()
                    objM半成品入库质检T.工序编号 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.工序编号).Value.ToString()
                    objM半成品入库质检T.检查内容 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.检查内容).Value.ToString()
                    objM半成品入库质检T.检查数量 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.检查数量).Value.ToString()
                    objM半成品入库质检T.不良数量 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.不良数量).Value.ToString()
                    objM半成品入库质检T.不良原因 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.不良原因).Value.ToString()
                    objM半成品入库质检T.处理结果 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.处理结果).Value.ToString()
                    objM半成品入库质检T.备注 = grid半成品入库质检.Rows(i).Cells(ENU_GRID.备注).Value.ToString()
                    ' objM半成品入库申请T.登陆者 = gObjM_人员T.人员编号
                    'objM半成品入库申请T.登陆日期 = DateTime.Now
                    'objM半成品入库申请T.更新者 = gObjM_人员T.人员编号
                    'objM半成品入库申请T.更新日期 = DateTime.Now
                    arryList.Add(objM半成品入库质检T)

                Next

            End If


            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt入库申请单编号.Focus()
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Delete(objM半成品入库质检T) > 0 And objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt入库申请单编号.Focus()
                        Exit Sub
                    End If

            End Select

        Catch ex As Exception
            '異常処理()
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル()
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

            '申请单编号
            If Me.txt入库申请单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请单编号", "申请单编号")
                txt入库申请单编号.Focus()
                Return False
            End If

            '客户名

            If Me.txt检查者编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查者编号", "检查者编号")
                txt检查者编号.Focus()
                Return False
            End If

            Dim intLoopi As Integer

            For intLoopi = 0 To grid半成品入库质检.Rows.Count - 1


                If grid半成品入库质检.Rows(intLoopi).Cells(ENU_GRID.检查内容).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查内容", "检查内容")
                    Me.grid半成品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.检查内容).Activated = True
                    Me.grid半成品入库质检.Select()
                    Return False
                End If
                If grid半成品入库质检.Rows(intLoopi).Cells(ENU_GRID.检查数量).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查数量", "检查数量")
                    Me.grid半成品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.检查数量).Activated = True
                    Me.grid半成品入库质检.Select()
                    Return False
                End If
                If grid半成品入库质检.Rows(intLoopi).Cells(ENU_GRID.不良数量).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "不良数量", "不良数量")
                    Me.grid半成品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.不良数量).Activated = True
                    Me.grid半成品入库质检.Select()
                    Return False
                End If

                '产品图号
                If grid半成品入库质检.Rows(intLoopi).Cells(ENU_GRID.不良数量).Value.ToString > grid半成品入库质检.Rows(intLoopi).Cells(ENU_GRID.入库数量).Value.ToString Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "不良数量", "不良数量")
                    Me.grid半成品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.不良数量).Activated = True
                    Me.grid半成品入库质检.Select()
                    Return False
                End If
                If grid半成品入库质检.Rows(intLoopi).Cells(ENU_GRID.不良数量).Value.ToString > grid半成品入库质检.Rows(intLoopi).Cells(ENU_GRID.检查数量).Value.ToString Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "检查数量", "检查数量")
                    Me.grid半成品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.检查数量).Activated = True
                    Me.grid半成品入库质检.Select()
                    Return False
                End If
                If grid半成品入库质检.Rows(intLoopi).Cells(ENU_GRID.不良原因).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "不良原因", "不良原因")
                    Me.grid半成品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.不良原因).Activated = True
                    Me.grid半成品入库质检.Select()
                    Return False
                End If
               
                If grid半成品入库质检.Rows(intLoopi).Cells(ENU_GRID.处理结果).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "处理结果", "处理结果")
                    Me.grid半成品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.处理结果).Activated = True
                    Me.grid半成品入库质检.Select()
                    Return False
                End If

            Next
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

            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            ' Me.btnF5直接入库.Enabled = Utility.PFn_GetAuth(Me.btnF5直接入库.Tag)
            ' Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)
            'Me.grid客户管理.Enabled = Utility.PFn_GetAuth(Me.grid客户管理.Tag)
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
        Dim objZ半成品入库质检T As New Z半成品入库质检T
        Dim objBll As BLLZ半成品入库质检T

        Try
            '获取数据
            objZ半成品入库质检T = New Z半成品入库质检T
            objBll = New BLLZ半成品入库质检T

            objZ半成品入库质检T.申请单编号 = txt入库申请单编号.Text.Trim()

            If String.IsNullOrEmpty(objZ半成品入库质检T.申请单编号) Then
                objZ半成品入库质检T.申请单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAllHead(objZ半成品入库质检T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                Me.txt入库申请单编号.Text = mdsInfoDataSet.Rows(0)("申请单编号").ToString()
                Me.txt检查者编号.Text = mdsInfoDataSet.Rows(0)("检查者编号").ToString()
                Me.txt检查者名称.Text = mdsInfoDataSet.Rows(0)("检查者名称").ToString()
                Me.txt申请者名称.Text = mdsInfoDataSet.Rows(0)("申请者").ToString()
                Me.txt申请日期.Text = mdsInfoDataSet.Rows(0)("申请日期").ToString()
            Else
                Me.txt入库申请单编号.Text = String.Empty
                Me.txt检查者编号.Text = String.Empty
                Me.txt检查者名称.Text = String.Empty
                Me.txt申请者名称.Text = String.Empty
                Me.txt申请日期.Text = String.Empty
            End If

            mdsGridDataSet = objBll.LoadGridAll(objZ半成品入库质检T)
            'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
            grid半成品入库质检.DataSource = mdsGridDataSet
            'grid原材料入库申请.DisplayLayout.Bands(0).Columns("客户编号CD").Hidden = True

            'End If
            BindGridCombox()
            SetGridStyle()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub SetFormData1()
        Dim objZ半成品入库质检T As New Z半成品入库质检T
        Dim objBll As BLLZ半成品入库质检T

        Try
            '获取数据
            objZ半成品入库质检T = New Z半成品入库质检T
            objBll = New BLLZ半成品入库质检T

            objZ半成品入库质检T.申请单编号 = txt入库申请单编号.Text.Trim()

            If String.IsNullOrEmpty(objZ半成品入库质检T.申请单编号) Then
                objZ半成品入库质检T.申请单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAllHead1(objZ半成品入库质检T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                Me.txt入库申请单编号.Text = mdsInfoDataSet.Rows(0)("申请单编号").ToString()
                ' Me.txt检查者编号.Text = mdsInfoDataSet.Rows(0)("检查者编号").ToString()
                ' Me.txt检查者名称.Text = mdsInfoDataSet.Rows(0)("检查者名称").ToString()
                Me.txt申请者名称.Text = mdsInfoDataSet.Rows(0)("申请者").ToString()
                Me.txt申请日期.Text = mdsInfoDataSet.Rows(0)("申请日期").ToString()
            Else
                Me.txt入库申请单编号.Text = String.Empty
                'Me.txt检查者编号.Text = String.Empty
                ' Me.txt检查者名称.Text = String.Empty
                Me.txt申请者名称.Text = String.Empty
                Me.txt申请日期.Text = String.Empty
            End If

            mdsGridDataSet = objBll.LoadGridAll(objZ半成品入库质检T)
            'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
            grid半成品入库质检.DataSource = mdsGridDataSet
            'grid原材料入库申请.DisplayLayout.Bands(0).Columns("客户编号CD").Hidden = True

            'End If
            BindGridCombox()
            SetGridStyle()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "SetData半成品"
    'Private Sub SetData半成品()
    '    Dim objM原材料采购T As New B原材料采购管理T
    '    Dim objBll As BllM原材料采购单管理T
    '    Try
    '        '获取数据
    '        objM原材料采购T = New B原材料采购管理T
    '        objBll = New BllM原材料采购单管理T
    '        objM原材料采购T.原材料编号 = grid半成品入库质检.ActiveRow.Cells("材料编号").Value.ToString()

    '        If String.IsNullOrEmpty(objM原材料采购T.原材料编号) Then
    '            objM原材料采购T.原材料编号 = " "
    '        End If
    '        If grid半成品入库质检.Rows(0).Cells("材料编号").Value.ToString <> String.Empty Then
    '            mDtSearch = objBll.SetData原材料(objM原材料采购T)
    '            If Not mDtSearch Is Nothing And mDtSearch.Rows.Count > 0 Then

    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.原材料编号).Value = mDtSearch.Rows(0)("原材料批号")
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.原材料名称).Value = mDtSearch.Rows(0)("原材料名称")
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.申请日期).Value = mDtSearch.Rows(0)("申请日期")
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.申请者名称).Value = mDtSearch.Rows(0)("申请者名称")
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.入库数量).Value = mDtSearch.Rows(0)("入库数量")
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.入库重量).Value = mDtSearch.Rows(0)("入库重量")
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.异常数量).Value = mDtSearch.Rows(0)("异常数量")
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.异常原因).Value = mDtSearch.Rows(0)("异常原因")
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.备注).Value = mDtSearch.Rows(0)("备注")
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.质检状态).Value = mDtSearch.Rows(0)("质检状态")


    '            Else
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.原材料编号).Value = String.Empty
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.原材料名称).Value = String.Empty
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.申请日期).Value = String.Empty
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.申请者名称).Value = String.Empty
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.入库数量).Value = String.Empty
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.入库重量).Value = String.Empty
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.异常数量).Value = String.Empty
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.异常原因).Value = String.Empty
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.备注).Value = String.Empty
    '                Me.grid半成品入库质检.ActiveRow.Cells(ENU_GRID.质检状态).Value = String.Empty

    '            End If
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

#Region "SetGridStyle"

    Private Sub SetGridStyle()
        Try
            Me.txt申请日期.Enabled = False

            With grid半成品入库质检.DisplayLayout.Bands(0)

                '.Columns("选择").Style = ColumnStyle.CheckBox

                .Columns(ENU_GRID.入库数量).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns(ENU_GRID.申请日期).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns(ENU_GRID.不良数量).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                .Columns(ENU_GRID.订单编号).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.主图号).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.分图号).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.半成品名称).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.半成品种类).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.工序名称).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.入库数量).CellActivation = Activation.NoEdit




            End With

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

    Private Sub txt入库申请单编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt入库申请单编号.Leave
        Try

            If txt入库申请单编号.Text = "" Then

                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor

                '検索を実行
                SetFormData1()


            End If

            '砂時計のカーソルが設定

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try


    End Sub
#Region "DataSearch"

    Private Sub DataSearch()

        Dim objB半成品入库申请T As New Z半成品入库申请T
        Dim objBll As New BLLZ半成品入库申请T

        Try
            objB半成品入库申请T = New Z半成品入库申请T

            objB半成品入库申请T.申请单编号 = Me.txt入库申请单编号.Text.Trim

            Me.grid半成品入库质检.DataSource = Nothing

            mDtSearch = objBll.LoadAllzj(objB半成品入库申请T)


            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.gridlist.PClear()
                '検索データを表示する
                Me.grid半成品入库质检.DataSource = mDtSearch

                'フォーカスの設定処理
                Me.txt入库申请单编号.Focus()
            Else
                '検索データを表示する
                Me.grid半成品入库质检.DataSource = mDtSearch
                Me.grid半成品入库质检.Focus()
                Me.grid半成品入库质检.ActiveRow = Me.grid半成品入库质检.Rows(0)
            End If

            BindGridCombox()
            SetGridStyle()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region
#Region "BindGridCombox"

    Private Sub BindGridCombox(Optional ByVal intRowIndex As Integer = 0)

        Try
            Utility.PFn_SetGirdCombo(Me.grid半成品入库质检, "VM质检状态", ENU_GRID.处理结果)
            ' Utility.PFn_SetGirdCombo(Me.gridList, "VM供货方式", ENU_GRID.供货方式)
        Catch ex As Exception

        End Try

    End Sub

#End Region
    Private Sub SetFormModel()

        Try

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    txt入库申请单编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt入库申请单编号.Focus()
                Case Constant.ENU_MODE.Model_Update

                    txt入库申请单编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    Me.txt入库申请单编号.Focus()
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
End Class