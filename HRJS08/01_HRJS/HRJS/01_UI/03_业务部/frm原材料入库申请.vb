Imports HRJS.Constant
Imports Infragistics.Win.UltraWinGrid
Public Class frm原材料入库申请#Region "常量定义"
    Private Enum ENU_GRID As Integer
        材料编号 = 0
        材料名称 = 1
        材料区分 = 2
        材料种类 = 3
        材质 = 4
        长 = 5
        宽 = 6
        高 = 7
        实际采购数量 = 8
        实际采购重量 = 9
        入库数量 = 10
        入库重量 = 11
        ' 备注 = 11



    End Enum
#End Region
#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Private mDtSearch As DataTable = Nothing
    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable

#End Region

#Region "Form Event"

    Private Sub frm原材料入库申请_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            '画面の初期化処理
            Me.InitForm()
            'BindGridCombox()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frm原材料入库申请_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm原材料入库申请_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub grid原材料入库申请_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid原材料入库申请.InitializeLayout
        grid原材料入库申请.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid原材料入库申请.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False

    End Sub

    Private Sub grid原材料入库申请_ClickCellButton(ByVal sender As Object, ByVal e As CellEventArgs) Handles grid原材料入库申请.ClickCellButton

        Dim frmSearch原材料 As frm原材料采购一览        Dim frmSearch图纸 As frm图纸信息一览
        Dim frmSearch订单 As frm订单一览

        Try

            If Me.grid原材料入库申请.ActiveCell Is Nothing Then
                Exit Sub
            End If

            Select Case Me.grid原材料入库申请.ActiveCell.Column.Index

                Case ENU_GRID.材料编号

                    If Me.grid原材料入库申请.DisplayLayout.Bands(0).Columns(ENU_GRID.材料编号).CellActivation = Activation.NoEdit Then
                        Exit Sub
                    End If

                    If Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材料编号).Activation = Activation.NoEdit Then
                        Exit Sub
                    End If

                    '砂時計のカーソルが設定
                    Me.Cursor = Cursors.WaitCursor

                    frmSearch原材料 = New frm原材料采购一览
                    frmSearch原材料.FormOpenMode = Constant.ENU_MODE.Model_Search
                    frmSearch原材料.str采购单编号 = Me.txt采购单编号.Text
                    frmSearch原材料.txt采购单编号.Enabled = False
                    frmSearch原材料.intDoubleClick = 1
                    frmSearch原材料.ShowDialog()


                    '画面数据设置
                    If frmSearch原材料.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                        If Not frmSearch原材料.ReturnTable Is Nothing AndAlso 0 < frmSearch原材料.ReturnTable.Rows.Count Then

                            '根据检索画面数据进行设置
                            Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材料编号).Value = frmSearch原材料.ReturnTable.Rows(0)("原材料编号")     '部品番号
                            Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材料名称).Value = frmSearch原材料.ReturnTable.Rows(0)("原材料名称")     '订单编号
                            Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材料区分).Value = frmSearch原材料.ReturnTable.Rows(0)("原材料区分")     '订单编号
                            Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材质).Value = frmSearch原材料.ReturnTable.Rows(0)("材质")     '订单编号
                            Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.长).Value = frmSearch原材料.ReturnTable.Rows(0)("长")     '订单编号
                            Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.宽).Value = frmSearch原材料.ReturnTable.Rows(0)("宽")     '订单编号
                            Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.高).Value = frmSearch原材料.ReturnTable.Rows(0)("高")     '订单编号

                            SetData原材料()


                        End If
                        If Not frmSearch原材料.ReturnTable Is Nothing Then
                            '检索画面释放
                            frmSearch原材料.ReturnTable.Dispose()
                            frmSearch原材料.ReturnTable = Nothing
                            frmSearch原材料.ReturnTable = Nothing
                        End If
                        '检索画面释放

                        frmSearch原材料.Dispose()
                        frmSearch原材料 = Nothing
                    End If

                    'Case ENU_GRID.订单编号

                    '    If Me.grid原材料入库申请.DisplayLayout.Bands(0).Columns(ENU_GRID.订单编号).CellActivation = Activation.NoEdit Then
                    '        Exit Sub
                    '    End If

                    '    If Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.订单编号).Activation = Activation.NoEdit Then
                    '        Exit Sub
                    '    End If

                    '    '砂時計のカーソルが設定
                    '    Me.Cursor = Cursors.WaitCursor

                    '    frmSearch订单 = New frm订单一览                    '    frmSearch订单.intDoubleClick = 1
                    '    frmSearch订单.FormOpenMode = Constant.ENU_MODE.Model_Search
                    '    frmSearch订单.ShowDialog()

                    '    '画面数据设置
                    '    If frmSearch订单.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                    '        If Not frmSearch订单.ReturnTable Is Nothing AndAlso 0 < frmSearch订单.ReturnTable.Rows.Count Then

                    '            '根据检索画面数据进行设置
                    '            Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.订单编号).Value = frmSearch订单.ReturnTable.Rows(0)("订单编号")     '订单编号
                    '            Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.产品图号).Value = frmSearch订单.ReturnTable.Rows(0)("产品图号")     '订单数量
                    '            'Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.客户名称).Value = frmSearch订单.ReturnTable.Rows(0)("客户名称")     '订单数量


                    '        End If

                    '        If Not frmSearch订单.ReturnTable Is Nothing Then
                    '            '检索画面释放

                    '            frmSearch订单.ReturnTable.Dispose()
                    '            frmSearch订单.ReturnTable = Nothing
                    '        End If
                    '        '检索画面释放

                    '        frmSearch订单.Dispose()
                    '        frmSearch订单 = Nothing

                    '    End If
            End Select
            grid原材料入库申请.UpdateData()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
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

            SetFormModel()

            SetFormData()

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

        Dim frmSearch As frm原材料入库申请一览        Try
            frmSearch = New frm原材料入库申请一览            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    Me.txt申请单编号.Text = frmSearch.ReturnTable.Rows(0)("申请单编号").ToString
                    Me.txt采购单编号.Text = frmSearch.ReturnTable.Rows(0)("采购单编号").ToString
                    ' Me.txt批次号.Text = frmSearch.ReturnTable.Rows(0)("批次号").ToString
                    ' Me.txt备注.Text = frmSearch.ReturnTable.Rows(0)("备注").ToString
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
                Me.txt申请单编号.Select()
            Else
                Me.txt人员编号.Select()
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

        Dim objB原材料入库申请T As New B原材料入库申请T

        Dim objBll As New BLLM原材料入库申请T

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If Me.txt申请单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请单编号", "申请单编号")
                txt申请单编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            objB原材料入库申请T.申请单编号 = txt申请单编号.Text.Trim

            If objBll.Delete(objB原材料入库申请T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
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
        Dim dr As DataRow
        Dim intRow As Integer
        Dim objBll As New BLLM原材料入库申请T

        If grid原材料入库申请.Rows.Count = 0 Then
            intRow = 0
        Else
            intRow = grid原材料入库申请.Rows.Count
        End If

        dr = mdsGridDataSet.NewRow()

        mdsGridDataSet.Rows.Add(dr)
        mdsGridDataSet.AcceptChanges()

        With grid原材料入库申请
            .ActiveRow = .Rows(intRow)
            .Rows(intRow).Cells(0).Activate()
            .UpdateData()
            .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        End With
    End Sub

    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click

        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If grid原材料入库申请.ActiveRow Is Nothing Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            '「選択された行を削除してもよろしいですか？」
            If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID4) = ENU_SHOWMSG.showMsgNo Then
                '登録処理終了
                Me.Cursor = Cursors.Default
                Return
            End If


            intRow = grid原材料入库申请.ActiveRow.VisibleIndex

            intRowDelete = grid原材料入库申请.ActiveRow.Index

            grid原材料入库申请.Rows(intRowDelete).Delete(False)

            If grid原材料入库申请.Rows.VisibleRowCount = 0 Or grid原材料入库申请.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If grid原材料入库申请.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf grid原材料入库申请.Rows.VisibleRowCount = intRow Then
                    intRow = grid原材料入库申请.Rows.VisibleRowCount - 1
                End If

                grid原材料入库申请.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                grid原材料入库申请.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.grid原材料入库申请.UpdateData()
            End If


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt采购单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt采购单编号.EditorButtonClick


        Dim frmSearch As frm原材料采购一览
        Try

            frmSearch = New frm原材料采购一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search
            frmSearch.intDoubleClick = 2
            frmSearch.Bool = True
            '工程信息查询画面打开
            frmSearch.ShowDialog()

            If frmSearch.ReturnTable Is Nothing OrElse frmSearch.ReturnTable.Rows.Count = 0 Then
                Exit Sub
            End If

            ' If 'frmSearch.ReturnTable.Rows(0)("审核状态") <> "2" Then
            'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18, "审核状态", "审核状态")
            ' Exit Sub
            ' Else



            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt采购单编号.Text = frmSearch.ReturnTable.Rows(0)("采购单编号")     '采购单编号



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
            'Else
            '    frm原材料采购一览.gridList.ActiveRow.Selected = False
            ' End If
            '光标设置
            Me.txt人员编号.Focus()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '默认光标设置
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub txt人员编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt人员编号.EditorButtonClick


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

                    Me.txt人员编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '客户名称

                    Me.txt人员名称.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '客户名称

                    Me.txt职务.Text = frmSearch.ReturnTable.Rows(0)("职务")     '部门

                    Me.txt部门.Text = frmSearch.ReturnTable.Rows(0)("部门名称")     '部门


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
            Me.dt申请日期.Focus()
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


                    Me.txt人员名称.Text = objM人员T.人员名     '客户名称

                    Me.txt职务.Text = objM人员T.职务

                    Me.txt部门.Text = objM人员T.部门

                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员名称")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt人员名称.Text = String.Empty
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

#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try
            SetGridStyle()
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

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try

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
                    Me.txt采购单编号.Enabled = True
                    txt申请单编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt申请单编号.Focus()
                Case Constant.ENU_MODE.Model_Update
                    Me.txt采购单编号.Enabled = False
                    txt申请单编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    Me.txt采购单编号.Focus()
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
            Me.txt申请单编号.Text = "YCL" & Now.ToString("yyyyMMddhhmmss")
            Me.txt人员编号.Text = String.Empty
            Me.txt人员名称.Text = String.Empty
            Me.txt职务.Text = String.Empty
            Me.txt部门.Text = String.Empty
            Me.txt批次号.Text = "YCL" & Now.ToString("yyyyMMddhhmmss")
            Me.txt采购单编号.Text = String.Empty
            Me.dt申请日期.Text = Utility.PFn_GetDBTime.ToString

            'grid原材料出库申请.DataSource = Nothing

            Me.txt采购单编号.Select()

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
            Dim objM原材料入库申请T As New B原材料入库申请T
            Dim objBll As New BLLM原材料入库申请T
            Dim arryList As New ArrayList

            If grid原材料入库申请.Rows.Count > 0 Then

                For i = 0 To grid原材料入库申请.Rows.Count - 1
                    objM原材料入库申请T = New B原材料入库申请T
                    objM原材料入库申请T.申请单编号 = Me.txt申请单编号.Text.Trim
                    objM原材料入库申请T.采购单编号 = Me.txt采购单编号.Text.Trim
                    objM原材料入库申请T.申请者编号 = Me.txt人员编号.Text.Trim
                    objM原材料入库申请T.申请日期 = Me.dt申请日期.Text.Trim
                    objM原材料入库申请T.材料编号 = grid原材料入库申请.Rows(i).Cells(ENU_GRID.材料编号).Value.ToString()
                    objM原材料入库申请T.批次号 = Me.txt批次号.Text.Trim
                    objM原材料入库申请T.供应商批次号 = Me.txt供应商批次号.Text.Trim
                    objM原材料入库申请T.长 = grid原材料入库申请.Rows(i).Cells(ENU_GRID.长).Value.ToString()
                    objM原材料入库申请T.宽 = grid原材料入库申请.Rows(i).Cells(ENU_GRID.宽).Value.ToString()
                    objM原材料入库申请T.高 = grid原材料入库申请.Rows(i).Cells(ENU_GRID.高).Value.ToString()
                    objM原材料入库申请T.入库数量 = grid原材料入库申请.Rows(i).Cells(ENU_GRID.入库数量).Value.ToString()
                    objM原材料入库申请T.入库重量 = grid原材料入库申请.Rows(i).Cells(ENU_GRID.入库重量).Value.ToString()
                    objM原材料入库申请T.备注 = Me.txt备注.Text.Trim
                    ' objM原材料入库申请T.产品图号 = grid原材料入库申请.Rows(i).Cells(ENU_GRID.产品图号).Value.ToString()
                    'objM原材料入库申请T.客户名称 = grid原材料入库申请.Rows(i).Cells(ENU_GRID.客户名称).Value.ToString()
                    'objM原材料入库申请T.登陆者 = gObjM_人员T.人员编号
                    'objM原材料入库申请T.登陆日期 = DateTime.Now
                    '‘ objM原材料入库申请T.更新者 = gObjM_人员T.人员编号
                    ' objM原材料入库申请T.更新日期 = DateTime.Now
                    arryList.Add(objM原材料入库申请T)

                Next

            End If


            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objM原材料入库申请T).申请单编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "申请单编号")
                        Me.txt申请单编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt申请单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update
                    If objBll.Update(arryList) > 0 Then

                        ' If objBll.Delete(objM原材料入库申请T) > 0 AndAlso objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt申请单编号.Focus()
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
            If Me.txt申请单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请单编号", "申请单编号")
                txt申请单编号.Focus()
                Return False
            End If
            If Me.txt采购单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "采购单编号", "采购单编号")
                txt采购单编号.Focus()
                Return False
            End If
            '客户名            If Me.txt人员编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请者编号", "申请者编号")
                txt人员编号.Focus()
                Return False
            End If
            If Me.txt批次号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "批次号", "批次号")
                txt批次号.Focus()
                Return False
            End If
            For Each dr As DataRow In Me.grid原材料入库申请.DataSource.Rows
                If dr("材料编号") & "" = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "材料编号") '材料编号

                    Return False
                End If
                If dr("入库数量（个）") & "" = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "入库数量（个）") '入库数量（个）
                    Return False
                End If
                If dr("入库数量（个）") > dr("实际采购数量") Then
                    MsgBox("入库数量不能大于采购数量") '入库数量（个）
                    Return False
                End If
                If dr("入库重量（kg）") & "" = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "入库重量（kg）") '入库重量（kg）
                    Return False
                End If
                'If dr("订单编号") & "" = "" Then
                '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号") '订单编号

                '    Return False
                'End If
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
            'Me.btnF5行追加.Enabled = Utility.PFn_GetAuth(Me.btnF5行追加.Tag)
            'Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)
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
        Dim objZ原材料入库申请T As New B原材料入库申请T
        Dim objBll As BLLM原材料入库申请T

        Try
            '获取数据
            objZ原材料入库申请T = New B原材料入库申请T
            objBll = New BLLM原材料入库申请T

            objZ原材料入库申请T.申请单编号 = txt申请单编号.Text.Trim()
            objZ原材料入库申请T.采购单编号 = txt采购单编号.Text.Trim()

            If String.IsNullOrEmpty(objZ原材料入库申请T.申请单编号) Then
                objZ原材料入库申请T.申请单编号 = " "
            End If
            If String.IsNullOrEmpty(objZ原材料入库申请T.采购单编号) Then
                objZ原材料入库申请T.采购单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAllHead(objZ原材料入库申请T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                Me.txt申请单编号.Text = mdsInfoDataSet.Rows(0)("申请单编号").ToString()
                Me.txt采购单编号.Text = mdsInfoDataSet.Rows(0)("采购单编号").ToString()
                Me.txt人员编号.Text = mdsInfoDataSet.Rows(0)("申请者编号").ToString()
                Me.txt人员名称.Text = mdsInfoDataSet.Rows(0)("申请者名称").ToString()
                Me.txt职务.Text = mdsInfoDataSet.Rows(0)("职务").ToString()
                Me.txt部门.Text = mdsInfoDataSet.Rows(0)("部门").ToString()
                Me.dt申请日期.Text = mdsInfoDataSet.Rows(0)("申请日期").ToString()
                Me.txt批次号.Text = mdsInfoDataSet.Rows(0)("批次号").ToString()
                Me.txt供应商批次号.Text = mdsInfoDataSet.Rows(0)("供应商批次号").ToString()
                Me.txt备注.Text = mdsInfoDataSet.Rows(0)("备注").ToString()
            Else
                Me.txt申请单编号.Text = "YCL" & Now.ToString("yyyyMMddhhmmss")
                Me.txt人员编号.Text = String.Empty
                Me.txt职务.Text = String.Empty
                Me.txt部门.Text = String.Empty
                Me.dt申请日期.Text = Utility.PFn_GetDBTime.ToString
                Me.txt批次号.Text = "YCL" & Now.ToString("yyyyMMddhhmmss")
                Me.txt供应商批次号.Text = String.Empty
                Me.txt备注.Text = String.Empty
            End If

            mdsGridDataSet = objBll.LoadGridAll(objZ原材料入库申请T)
            'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
            grid原材料入库申请.DataSource = mdsGridDataSet
            'grid原材料入库申请.DisplayLayout.Bands(0).Columns("客户编号CD").Hidden = True

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

#Region "SetData原材料"
    Private Sub SetData原材料()
        Dim objM原材料入库申请T As New B原材料入库申请T
        Dim objBll As BLLM原材料入库申请T
        Dim frmSearch原材料 As frm原材料采购一览
        Try
            '获取数据
            objM原材料入库申请T = New B原材料入库申请T
            objBll = New BLLM原材料入库申请T
            frmSearch原材料 = New frm原材料采购一览
            objM原材料入库申请T.材料编号 = grid原材料入库申请.ActiveRow.Cells("材料编号").Value.ToString()
            objM原材料入库申请T.订单编号 = grid原材料入库申请.ActiveRow.Cells("订单编号").Value.ToString()
            frmSearch原材料.str采购单编号 = Me.txt采购单编号.Text

            objM原材料入库申请T.采购单编号 = frmSearch原材料.str采购单编号
            If String.IsNullOrEmpty(objM原材料入库申请T.材料编号) Then
                objM原材料入库申请T.材料编号 = " "
            End If
            If String.IsNullOrEmpty(objM原材料入库申请T.订单编号) Then
                objM原材料入库申请T.订单编号 = " "
            End If

            If grid原材料入库申请.Rows(0).Cells("材料编号").Value.ToString <> String.Empty AndAlso grid原材料入库申请.Rows(0).Cells("订单编号").Value.ToString <> String.Empty Then

                mDtSearch = objBll.SetData原材料(objM原材料入库申请T)

                If Not mDtSearch Is Nothing And mDtSearch.Rows.Count > 0 Then

                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材料编号).Value = mDtSearch.Rows(0)("原材料编号")
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材料名称).Value = mDtSearch.Rows(0)("原材料名称")
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材料区分).Value = mDtSearch.Rows(0)("原材料区分")
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材质).Value = mDtSearch.Rows(0)("材质")
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.长).Value = mDtSearch.Rows(0)("长")
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.宽).Value = mDtSearch.Rows(0)("宽")
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.高).Value = mDtSearch.Rows(0)("高")
                    'Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材质).Value = mDtSearch.Rows(0)("材质")
                    'Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.订单编号).Value = mDtSearch.Rows(0)("订单编号")
                    ' Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.产品图号).Value = mDtSearch.Rows(0)("产品图号")
                Else
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材料编号).Value = String.Empty
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材料名称).Value = String.Empty
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材料区分).Value = String.Empty
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.材质).Value = String.Empty
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.长).Value = String.Empty
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.宽).Value = String.Empty
                    Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.高).Value = String.Empty

                    'Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.订单编号).Value = String.Empty
                    'Me.grid原材料入库申请.ActiveRow.Cells(ENU_GRID.产品图号).Value = String.Empty
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

            With grid原材料入库申请.DisplayLayout.Bands(0)


                .Columns("材料名称").CellActivation = Activation.NoEdit
                .Columns("材料区分").CellActivation = Activation.NoEdit
                .Columns("材料种类").CellActivation = Activation.NoEdit

                .Columns("材质").CellActivation = Activation.NoEdit
                .Columns("长").CellActivation = Activation.NoEdit
                .Columns("宽").CellActivation = Activation.NoEdit
                .Columns("高").CellActivation = Activation.NoEdit
                .Columns("实际采购数量").CellActivation = Activation.NoEdit
                .Columns("实际采购重量").CellActivation = Activation.NoEdit
                .Columns("入库数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("入库重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

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
#Region "BindGridCombox"

    'Private Sub BindGridCombox(Optional ByVal intRowIndex As Integer = 0)

    '    Try
    '        Utility.PFn_SetGirdCombo(Me.grid原材料入库申请, "VM材料种类", ENU_GRID.材料种类)
    '    Catch ex As Exception

    '    End Try

    'End Sub

#End Region
#End Region

    Private Sub txt采购单编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt采购单编号.Leave

        Try

            If txt采购单编号.Text = "" Then

                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor

                '検索を実行
                Me.DataSearch()

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

        Dim objZ原材料入库申请T As New B原材料入库申请T
        Dim objBll As BLLM原材料入库申请T

        Try
            '获取数据
            objZ原材料入库申请T = New B原材料入库申请T
            objBll = New BLLM原材料入库申请T

            ' objZ原材料入库申请T.申请单编号 = txt申请单编号.Text.Trim()
            objZ原材料入库申请T.采购单编号 = txt采购单编号.Text.Trim()

           
            mDtSearch = objBll.LoadGridAll编辑(objZ原材料入库申请T)

            Me.grid原材料入库申请.DataSource = mDtSearch

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.gridlist.PClear()
                '検索データを表示する
                Me.grid原材料入库申请.DataSource = mDtSearch

                'フォーカスの設定処理
                Me.txt申请单编号.Focus()
            Else
                '検索データを表示する
                Me.grid原材料入库申请.DataSource = mDtSearch
                Me.grid原材料入库申请.Focus()
                Me.grid原材料入库申请.ActiveRow = Me.grid原材料入库申请.Rows(0)
            End If

            'BindGridCombox()
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
End Class