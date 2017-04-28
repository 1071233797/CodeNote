Imports Infragistics.Win.UltraWinGrid
Imports HRJS.Constant
Public Class frm生产检查管理#Region "常量定义"
    Private Enum ENU_GRID As Integer
        检查ID = 0
        订单编号 = 1
        主图号 = 2
        分图号 = 3
        产品名称 = 4
        本道工序编号 = 5
        工序名称 = 6
        生产数量 = 7
        检查内容 = 8
        检查数量 = 9
        不良数量 = 10
        不良原因 = 11
        处理结果 = 12
        备注 = 13

    End Enum
#End Region
#Region "変数定義"
    Private mDtSearch As DataTable = Nothing
    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New

    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable

#End Region

#Region "Form Event"

    Private Sub frm生产检查管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub frm生产检查管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm生产检查管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                Case Keys.F5
                    btnF5行追加.Focus()
                    btnF5行追加_Click(Nothing, Nothing)

                Case Keys.F6
                    btnF6行删除.Focus()
                    btnF6行删除_Click(Nothing, Nothing)

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

    Private Sub gridList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridList.InitializeLayout

        gridList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        gridList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False

    End Sub

    Private Sub gridList_ClickCellButton(ByVal sender As Object, ByVal e As CellEventArgs) Handles gridList.ClickCellButton


        'If gridList.ActiveRow = "" Then

        'End If

        If gridList.ActiveRow.Cells("订单编号").Activated Then
            Dim frmSearch As frm生产实绩一览            Try

                frmSearch = New frm生产实绩一览
                frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search
                ' frmSearch.intDoubleClick = 1

                '供应商查询画面打开
                frmSearch.ShowDialog()

                '画面数据设置
                If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                    If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                        '根据检索画面数据进行设置                        gridList.ActiveRow.Cells("订单编号").Value = frmSearch.ReturnTable.Rows(0)("订单编号")          '原材料编号                        gridList.ActiveRow.Cells("主图号").Value = frmSearch.ReturnTable.Rows(0)("主图号")     '原材料名称
                        If gridList.ActiveRow.Cells("上级图号").Value & "" = "" Then
                            gridList.ActiveRow.Cells("上级图号").Value = frmSearch.ReturnTable.Rows(0)("主图号").ToString
                        Else
                            gridList.ActiveRow.Cells("上级图号").Value = frmSearch.ReturnTable.Rows(0)("上级图号").ToString          '产品图号
                        End If

                        gridList.ActiveRow.Cells("分图号").Value = frmSearch.ReturnTable.Rows(0)("分图号")     '原材料名称
                        SetData1()
                        'Me.gridList.ActiveRow.Cells("入库数量").SelectAll()

                    End If

                    If Not frmSearch.ReturnTable Is Nothing Then
                        '检索画面释放                        frmSearch.ReturnTable.Dispose()
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

        End If


    End Sub

#End Region

#Region "Button Event"

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

            ' SetFormModel()

            SetData()

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

        Dim frmSearch As frm生产检查一览        Try
            frmSearch = New frm生产检查一览            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    Me.txt检查ID.Text = frmSearch.ReturnTable.Rows(0)("检查ID").ToString
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
                'SetFormModel()

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

        Dim objZ半成品入库申请T As New Z半成品入库申请T

        Dim objBll As New BLLZ半成品入库申请T

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If Me.txt检查者编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请单编号", "申请单编号")
                txt检查者编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            objZ半成品入库申请T.申请单编号 = txt检查者编号.Text.Trim

            If objBll.Delete(objZ半成品入库申请T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            'SetFormModel()
            ClearForm()
            SetFormData()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF5行追加_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF5行追加.Click

        Try

            Dim dr As DataRow
            Dim intRow As Integer
            'Dim objBll As New BLLZ生产检查管理T

            'If Not ADDCheck() Then
            '    Exit Sub
            'End If

            If gridList.Rows.Count = 0 Then
                intRow = 0
            Else
                intRow = gridList.Rows.Count
            End If

            dr = mdsGridDataSet.NewRow()

            mdsGridDataSet.Rows.Add(dr)
            mdsGridDataSet.AcceptChanges()

            With gridList
                .ActiveRow = .Rows(intRow)
                .Rows(intRow).Cells(0).Activate()
                .UpdateData()
                .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)

            End With
            SetGridStyle()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click

        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If gridList.ActiveRow Is Nothing Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            '「選択された行を削除してもよろしいですか？」
            If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID4) = ENU_SHOWMSG.showMsgNo Then
                '登録処理終了
                Me.Cursor = Cursors.Default
                Return
            End If


            intRow = gridList.ActiveRow.VisibleIndex

            intRowDelete = gridList.ActiveRow.Index

            gridList.Rows(intRowDelete).Delete(False)

            If gridList.Rows.VisibleRowCount = 0 Or gridList.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If gridList.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf gridList.Rows.VisibleRowCount = intRow Then
                    intRow = gridList.Rows.VisibleRowCount - 1
                End If

                gridList.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                gridList.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.gridList.UpdateData()
            End If


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
                Me.txt检查者编号.Select()
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

                    Me.txt检查者编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '客户编号

                    Me.txt检查者名称.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '客户名称

                    'Me.txt职务.Text = frmSearch.ReturnTable.Rows(0)("职务")     '部门

                    ' Me.txt部门.Text = frmSearch.ReturnTable.Rows(0)("部门名称")     '部门


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

    Private Sub txt检查者编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt检查者编号.Leave
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

                    ' Me.txt职务.Text = objM人员T.职务

                    'Me.txt部门.Text = objM人员T.部门

                    Me.txt检查日期.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员名称")
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
            '画面のComboの初期値を設定する
            Me.SetCombo()


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

#Region "SetCombo"

    Private Sub SetCombo()

        ' Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try
            Utility.PFn_SetGirdCombo(Me.gridList, "VM质检状态", ENU_GRID.处理结果)
            '交货方式
            'Utility.PFn_SetCombo(Me.cbo交货方式, "VM交货方式", 0)

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

                    txt检查者编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt检查者编号.Focus()
                Case Constant.ENU_MODE.Model_Update

                    txt检查者编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    Me.txt检查者编号.Focus()
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

            Me.txt检查者编号.Text = String.Empty
            Me.txt检查者名称.Text = String.Empty
            Me.txt检查日期.Text = DateTime.Now
            'Me.txt职务.Text = String.Empty
            'Me.txt部门.Text = String.Empty
            'Me.dt申请日期.Text = DateTime.Now
            'gridList.DataSource = Nothing

            Me.txt检查者编号.Select()

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
            Dim objZ生产检查管理T As New Z生产检查管理T
            Dim objBll As New BLLZ生产检查管理T
            Dim arryList As New ArrayList

            If gridList.Rows.Count > 0 Then

                For i = 0 To gridList.Rows.Count - 1
                    objZ生产检查管理T = New Z生产检查管理T

                    objZ生产检查管理T.检查ID = Me.txt检查ID.Text.Trim
                    objZ生产检查管理T.检查者编号 = Me.txt检查者编号.Text.Trim
                    objZ生产检查管理T.检查日期 = Me.txt检查日期.Text.Trim

                    objZ生产检查管理T.订单编号 = gridList.Rows(i).Cells("订单编号").Value.ToString()

                    objZ生产检查管理T.主图号 = gridList.Rows(i).Cells("主图号").Value.ToString()
                    objZ生产检查管理T.上级图号 = gridList.Rows(i).Cells("上级图号").Value.ToString()
                    objZ生产检查管理T.分图号 = gridList.Rows(i).Cells("分图号").Value.ToString()

                    objZ生产检查管理T.工序编号 = gridList.Rows(i).Cells("本道工序编号").Value.ToString()
                    objZ生产检查管理T.检查数量 = gridList.Rows(i).Cells("检查数量(个)").Value.ToString()
                    objZ生产检查管理T.检查内容 = gridList.Rows(i).Cells("检查内容").Value.ToString()
                    objZ生产检查管理T.不良数量 = gridList.Rows(i).Cells("不良数量(个)").Value.ToString()
                    objZ生产检查管理T.不良原因 = gridList.Rows(i).Cells("不良原因").Value.ToString()
                    objZ生产检查管理T.处理结果 = gridList.Rows(i).Cells("处理结果").Value.ToString()
                    objZ生产检查管理T.备注 = gridList.Rows(i).Cells("备注").Value.ToString()


                    'objZ半成品入库申请T.客户名称 = gridList.Rows(i).Cells("客户名称").Value.ToString()
                    'objZ生产检查管理T.登陆者 = gObjM_人员T.人员编号
                    ' objZ生产检查管理T.登陆日期 = DateTime.Now
                    'objZ生产检查管理T.更新者 = gObjM_人员T.人员编号
                    'objZ生产检查管理T.更新日期 = DateTime.Now
                    arryList.Add(objZ生产检查管理T)

                Next

            End If


            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objZ生产检查管理T).检查ID <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "检查编号")
                        Me.txt检查者编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt检查者编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update


                    If objBll.Delete(objZ生产检查管理T) > 0 AndAlso objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt检查者编号.Focus()
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

#Region "ADDCheck"
    Private Function ADDCheck() As Boolean

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If
            If Me.txt检查者编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查者", "检查者")
                txt检查者编号.Focus()
                Return False
            End If

            If Me.txt检查日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查日期", "检查日期")
                txt检查日期.Focus()
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
            Dim objZ生产实际管理T As New Z生产检查管理T
            Dim objBll As New BLLM生产实际管理T

            Dim dt As New DataTable
            '必須チェック(MsgID=21) 

            '申请单编号
            If Me.txt检查者编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查者", "检查者")
                txt检查者编号.Focus()
                Return False
            End If

            '客户名            If Me.txt检查日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查日期", "检查日期")
                txt检查日期.Focus()
                Return False
            End If

            If gridList.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
                Return False
            Else
                For i = 0 To gridList.Rows.Count - 1
                    'If gridList.Rows(i).Cells("检查数量(个)").Value.ToString() & "" = "" Then
                    '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查数量", "检查数量")
                    '    Return False
                    'End If
                    If gridList.Rows(i).Cells("检查内容").Value.ToString() & "" = "" Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查内容", "检查内容")
                        Return False
                    End If
                    If gridList.Rows(i).Cells("不良数量(个)").Value.ToString() & "" = "" Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "不良数量", "不良数量")
                        Return False
                    End If
                    If gridList.Rows(i).Cells("不良原因").Value.ToString() & "" = "" Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "不良原因", "不良原因")
                        Return False
                    End If
                    If gridList.Rows(i).Cells("处理结果").Value.ToString() & "" = "" Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "处理结果", "处理结果")
                        Return False
                    End If

                Next
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

            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            Me.btnF5行追加.Enabled = Utility.PFn_GetAuth(Me.btnF5行追加.Tag)
            Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)
            'Me.grid半成品入库申请.Enabled = Utility.PFn_GetAuth(Me.grid半成品入库申请.Tag)
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
        Dim objZ生产检查管理T As New Z生产检查管理T
        Dim objBll As BLLZ生产检查管理T

        Try
            '获取数据
            objZ生产检查管理T = New Z生产检查管理T
            objBll = New BLLZ生产检查管理T

            objZ生产检查管理T.检查ID = txt检查ID.Text.Trim()

            If String.IsNullOrEmpty(objZ生产检查管理T.检查ID) Then
                objZ生产检查管理T.检查ID = " "
            End If
            mdsInfoDataSet = objBll.LoadAllHead(objZ生产检查管理T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                Me.txt检查者编号.Text = mdsInfoDataSet.Rows(0)("检查者编号").ToString()
                Me.txt检查者名称.Text = mdsInfoDataSet.Rows(0)("检查者名称").ToString()
                ' Me.txt检查ID.Text = mdsInfoDataSet.Rows(0)("检查ID").ToString()
                Me.txt检查日期.Text = mdsInfoDataSet.Rows(0)("检查日期").ToString()

            Else
                Me.txt检查者编号.Text = String.Empty
                Me.txt检查者名称.Text = String.Empty
                ' Me.txt检查ID.Text = String.Empty
                Me.txt检查日期.Text = DateTime.Now
            End If

            mdsGridDataSet = objBll.LoadGridAll(objZ生产检查管理T)

            gridList.DataSource = mdsGridDataSet
            gridList.DisplayLayout.Bands(0).Columns("检查ID").Hidden = True

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

        'Dim objZ生产检查管理T As New Z生产检查管理T
        'Dim objBll As BLLZ生产检查管理T

        'Try
        '    '获取数据
        '    objZ生产检查管理T = New Z生产检查管理T
        '    objBll = New BLLZ生产检查管理T

        '    objZ生产检查管理T.检查ID = txt检查ID.Text.Trim()

        '    If String.IsNullOrEmpty(objZ生产检查管理T.检查ID) Then
        '        objZ生产检查管理T.检查ID = " "
        '    End If
        '    mdsInfoDataSet = objBll.LoadAllHead(objZ生产检查管理T)
        '    If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
        '        Me.txt检查者编号.Text = mdsInfoDataSet.Rows(0)("检查者编号").ToString()
        '        Me.txt检查者名称.Text = mdsInfoDataSet.Rows(0)("检查者名称").ToString()
        '        Me.txt检查日期.Text = mdsInfoDataSet.Rows(0)("检查日期").ToString()
        '    Else
        '        Me.txt检查者编号.Text = String.Empty
        '        Me.txt检查者名称.Text = String.Empty
        '        Me.txt检查日期.Text = DateTime.Now
        '    End If

        '    mdsGridDataSet = objBll.LoadGridAll(objZ生产检查管理T)
        '    'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
        '    gridList.DataSource = mdsGridDataSet
        '    'gridlist.DisplayLayout.Bands(0).Columns("客户编号CD").Hidden = True

        '    'End If
        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try
        Dim objBll As New BLLM生产实际管理T
        Dim objM生产实际T As New Z生产实际管理T


        Try
            objM生产实际T = New Z生产实际管理T
            objBll = New BLLM生产实际管理T

            If String.IsNullOrEmpty(objM生产实际T.订单编号) Then
                objM生产实际T.订单编号 = " "
            Else
                'objM生产实际T.订单编号 = gridList.ActiveRow.Cells("订单编号").Value.ToString()

            End If
            'If String.IsNullOrEmpty(objM生产实际T.产品图号) Then
            '    objM生产实际T.产品图号 = " "
            'End If
            '  objM生产实际T.产品图号 = gridList.ActiveRow.Cells("分图号").Value.ToString()
            ' If gridList.ActiveRow.Cells("订单编号").Value.ToString <> String.Empty Then

            mdsGridDataSet = objBll.SetData(objM生产实际T)
            If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then

                'Me.gridList.ActiveRow.Cells("主图号").Value = mDtSearch.Rows(0)("主图号")
                'Me.gridList.ActiveRow.Cells("分图号").Value = mDtSearch.Rows(0)("分图号")
                'Me.gridList.ActiveRow.Cells("产品名称").Value = mDtSearch.Rows(0)("产品名称")
                'Me.gridList.ActiveRow.Cells("工序编号").Value = mDtSearch.Rows(0)("工序编号")
                'Me.gridList.ActiveRow.Cells("工序名称").Value = mDtSearch.Rows(0)("工序名称")



            Else
                'Me.gridList.ActiveRow.Cells("主图号").Value = String.Empty
                'Me.gridList.ActiveRow.Cells("分图号").Value = String.Empty
                ' Me.gridList.ActiveRow.Cells("产品名称").Value = String.Empty
                ' Me.gridList.ActiveRow.Cells("工序编号").Value = String.Empty
                'Me.gridList.ActiveRow.Cells("工序名称").Value = String.Empty
                'End If
                gridList.DataSource = mdsGridDataSet
                SetGridStyle()
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
        Dim objM生产实际T As New Z生产实际管理T
        Dim objBll As BLLM生产实际管理T
        Try
            '获取数据
            objM生产实际T = New Z生产实际管理T
            objBll = New BLLM生产实际管理T
            objM生产实际T.订单编号 = gridList.ActiveRow.Cells("订单编号").Value.ToString()

            If String.IsNullOrEmpty(objM生产实际T.订单编号) Then
                objM生产实际T.订单编号 = " "
            End If
            If gridList.Rows(0).Cells("订单编号").Value.ToString <> String.Empty Then

                mDtSearch = objBll.SetData1(objM生产实际T)

                If Not mDtSearch Is Nothing And mDtSearch.Rows.Count > 0 Then
                    'Me.gridList.ActiveRow.Cells("主图号").Value = mDtSearch.Rows(0)("主图号")
                    'Me.gridList.ActiveRow.Cells("上级图号").Value = mDtSearch.Rows(0)("上级图号")
                    'Me.gridList.ActiveRow.Cells("分图号").Value = mDtSearch.Rows(0)("分图号")
                    Me.gridList.ActiveRow.Cells("产品名称").Value = mDtSearch.Rows(0)("产品名称")
                    Me.gridList.ActiveRow.Cells("本道工序编号").Value = mDtSearch.Rows(0)("本道工序编号")
                    Me.gridList.ActiveRow.Cells("工序名称").Value = mDtSearch.Rows(0)("工序名称")
                    Me.gridList.ActiveRow.Cells("生产数量(个)").Value = mDtSearch.Rows(0)("生产数量(个)")
                Else
                    Me.gridList.ActiveRow.Cells("主图号").Value = String.Empty
                    Me.gridList.ActiveRow.Cells("上级图号").Value = String.Empty
                    Me.gridList.ActiveRow.Cells("分图号").Value = String.Empty
                    Me.gridList.ActiveRow.Cells("产品名称").Value = String.Empty
                    Me.gridList.ActiveRow.Cells("本道工序编号").Value = String.Empty
                    Me.gridList.ActiveRow.Cells("工序名称").Value = String.Empty
                    Me.gridList.ActiveRow.Cells("生产数量(个)").Value = String.Empty

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

#Region "SetGridStyle"

    Private Sub SetGridStyle()
        Try


            With gridList.DisplayLayout.Bands(0)
                If gridList.DisplayLayout.Bands(0) Is Nothing Then
                    Exit Sub
                Else

                    '.Columns("发货日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                    '.Columns("到货日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                    '.Columns("发货日期").CellActivation = Activation.NoEdit
                    '.Columns("到货日期").CellActivation = Activation.NoEdit
                    .Columns("不良数量(个)").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

                    .Columns("生产数量(个)").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    .Columns("检查数量(个)").Style = ColumnStyle.Integer
                    .Columns("检查数量(个)").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    .Columns("本道工序编号").Hidden = True
                    ''.Columns("审核状态").Hidden = True
                    '.Columns("高").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    '.Columns("重量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    '.Columns("税率").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    '.Columns("含税单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If
            End With

        Catch ex As Exception
            '異常処理()
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル()
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region
#End Region


End Class