Imports Infragistics.Win.UltraWinGrid
Imports HRJS.Constant
Public Class frm成品入库申请
#Region "常量定义"
    Private Enum ENU_GRID As Integer

        订单编号 = 0
        产品图号 = 1
        入库数量 = 2
        入库重量 = 3
        备注 = 4

    End Enum
#End Region
#Region "変数定義"

    Private mDtSearch As DataTable = Nothing
    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Private mds As Integer
    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable

#End Region

#Region "Form Event"

    Private Sub frm成品入库申请_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frm成品入库申请_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm成品入库申请_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub grid成品入库申请_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid成品入库申请.InitializeLayout
        grid成品入库申请.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid成品入库申请.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
    End Sub

    Private Sub grid成品入库申请_ClickCellButton(ByVal sender As Object, ByVal e As CellEventArgs) Handles grid成品入库申请.ClickCellButton


        'If grid成品入库申请.ActiveCe = "" Then

        'End If

        'If grid成品入库申请.ActiveRow.Cells("分图号").Activated Then
        Dim frmSearch As frm订单一览        Try
            
            frmSearch = New frm订单一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search
            'frmSearch.mstr产品图号 = Me.grid成品入库申请.ActiveRow.Cells("主图号").Text
            'frmSearch.txt产品图号.Enabled = False
            'frmSearch.btnF1清空.Enabled = False
            ' frmSearch.intDoubleClick = 1
            frmSearch.ShowDialog()

            '供应商查询画面打开
            ' frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    If grid成品入库申请.DataSource.select("订单编号='" & frmSearch.ReturnTable.Rows(0)("订单编号") & "'").length > 0 Or grid成品入库申请.DataSource.select("产品图号='" & frmSearch.ReturnTable.Rows(0)("产品图号") & "'").length > 0 Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "产品图号")
                    Else
                        grid成品入库申请.ActiveRow.Cells(ENU_GRID.订单编号).Value = frmSearch.ReturnTable.Rows(0)("订单编号")          '订单编号                   
                        grid成品入库申请.ActiveRow.Cells(ENU_GRID.产品图号).Value = frmSearch.ReturnTable.Rows(0)("产品图号")          '产品图号


                    End If
                    frmSearch.ReturnTable = Nothing
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

        Dim frmSearch As frm成品入库申请一览        Try
            frmSearch = New frm成品入库申请一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    Me.txt申请单编号.Text = frmSearch.ReturnTable.Rows(0)("申请单编号").ToString
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

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objZ成品入库申请T As New Z成品入库申请T

        Dim objBll As New BLLZ成品入库申请T

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


            objZ成品入库申请T.申请单编号 = txt申请单编号.Text.Trim

            If objBll.Delete(objZ成品入库申请T) > 0 Then

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
        Dim objBll As New BLLZ成品入库申请T

        If grid成品入库申请.Rows.Count = 0 Then
            intRow = 0
        Else
            intRow = grid成品入库申请.Rows.Count
        End If

        dr = mdsGridDataSet.NewRow()

        mdsGridDataSet.Rows.Add(dr)
        mdsGridDataSet.AcceptChanges()

        With grid成品入库申请
            .ActiveRow = .Rows(intRow)
            .Rows(intRow).Cells(0).Activate()
            .UpdateData()
            .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)

        End With
        SetGridStyle()
    End Sub

    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click

        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If grid成品入库申请.ActiveRow Is Nothing Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            '「選択された行を削除してもよろしいですか？」
            If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID4) = ENU_SHOWMSG.showMsgNo Then
                '登録処理終了
                Me.Cursor = Cursors.Default
                Return
            End If


            intRow = grid成品入库申请.ActiveRow.VisibleIndex

            intRowDelete = grid成品入库申请.ActiveRow.Index

            grid成品入库申请.Rows(intRowDelete).Delete(False)

            If grid成品入库申请.Rows.VisibleRowCount = 0 Or grid成品入库申请.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If grid成品入库申请.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf grid成品入库申请.Rows.VisibleRowCount = intRow Then
                    intRow = grid成品入库申请.Rows.VisibleRowCount - 1
                End If

                grid成品入库申请.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                grid成品入库申请.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.grid成品入库申请.UpdateData()
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
                Me.txt申请单编号.Select()
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub txt申请者编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt申请者编号.EditorButtonClick


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

                    Me.txt申请者编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '客户编号

                    Me.txt申请者名称.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '客户名称

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
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '默认光标设置
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub txt申请者编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt申请者编号.Leave
        Dim objM人员T As M人员T
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt申请者编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt申请者编号.Text.Trim <> String.Empty Then

                If Me.txt申请者编号.Tag = Me.txt申请者编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt申请者编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                objM人员T = objBLLM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员名 <> String.Empty Then


                    Me.txt申请者名称.Text = objM人员T.人员名     '客户名称

                    Me.txt职务.Text = objM人员T.职务

                    Me.txt部门.Text = objM人员T.部门

                    Me.dt申请日期.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员名称")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt申请者名称.Text = String.Empty
                    Me.txt申请者编号.Select()
                End If
            Else
                Me.txt申请者编号.Text = String.Empty
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

#Region "SetFormModel"

    Private Sub SetFormModel()

        Try

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    txt申请单编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt申请单编号.Focus()
                Case Constant.ENU_MODE.Model_Update

                    txt申请单编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    Me.txt申请者编号.Focus()
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

            Me.txt申请单编号.Text = "CP" & Now.ToString("yyyyMMddhhmmss")
            Me.txt申请者编号.Text = String.Empty
            Me.txt申请者名称.Text = String.Empty
            Me.txt职务.Text = String.Empty
            Me.txt部门.Text = String.Empty
            Me.dt申请日期.Text = DateTime.Now
            'grid成品入库申请.DataSource = Nothing

            Me.txt申请单编号.Select()

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
            Dim objZ成品入库申请T As New Z成品入库申请T
            Dim objBll As New BLLZ成品入库申请T
            Dim arryList As New ArrayList

            If grid成品入库申请.Rows.Count > 0 Then

                For i = 0 To grid成品入库申请.Rows.Count - 1
                    objZ成品入库申请T = New Z成品入库申请T
                    objZ成品入库申请T.申请单编号 = Me.txt申请单编号.Text.Trim
                    objZ成品入库申请T.申请者编号 = Me.txt申请者编号.Text.Trim
                    objZ成品入库申请T.申请日期1 = Me.dt申请日期.Text.Trim
                    objZ成品入库申请T.订单编号 = grid成品入库申请.Rows(i).Cells(ENU_GRID.订单编号).Value.ToString()
                    objZ成品入库申请T.产品图号 = grid成品入库申请.Rows(i).Cells(ENU_GRID.产品图号).Value.ToString()
                    objZ成品入库申请T.入库数量 = grid成品入库申请.Rows(i).Cells(ENU_GRID.入库数量).Value.ToString()
                    objZ成品入库申请T.入库重量 = grid成品入库申请.Rows(i).Cells(ENU_GRID.入库重量).Value.ToString()
                    objZ成品入库申请T.备注 = grid成品入库申请.Rows(i).Cells(ENU_GRID.备注).Value.ToString()
                    arryList.Add(objZ成品入库申请T)

                Next

            End If
            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objZ成品入库申请T).申请单编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "申请单编号")
                        Me.txt申请单编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                        Update订单()
                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt申请单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Delete(objZ成品入库申请T) > 0 AndAlso objBll.Insert(arryList) > 0 Then

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
            Dim objZ成品入库申请T As New Z成品入库申请T
            Dim objBll As New BLLZ成品入库申请T

            Dim dt As New DataTable
            '必須チェック(MsgID=21) 

            '申请单编号
            If Me.txt申请单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请单编号", "申请单编号")
                txt申请单编号.Focus()
                Return False
            End If

            '客户名            If Me.txt申请者编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请者编号", "申请者编号")
                txt申请者编号.Focus()
                Return False
            End If

            'If grid成品入库申请.Rows.Count = 0 Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "分图号", "分图号")
            '    Return False
            'Else
            '    For i = 0 To grid成品入库申请.Rows.Count - 1
            '        If grid成品入库申请.Rows(i).Cells("半成品种类").Value.ToString() & "" = "" Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "半成品种类", "半成品种类")
            '            Return False
            '        End If
            '        If grid成品入库申请.Rows(i).Cells("分图号").Value.ToString() & "" = "" Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "分图号", "分图号")
            '            Return False
            '        End If
            '        If grid成品入库申请.Rows(i).Cells("工序名称").Value.ToString() & "" = "" Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "工序名称", "工序名称")
            '            Return False
            '        End If
            '        If grid成品入库申请.Rows(i).Cells("半成品名称").Value.ToString() & "" = "" Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "半成品名称", "半成品名称")
            '            Return False
            '        End If
            '        If grid成品入库申请.Rows(i).Cells("订单编号").Value.ToString() & "" = "" Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
            '            Return False
            '        End If
            '        If grid成品入库申请.Rows(i).Cells("主图号").Value.ToString() & "" = "" Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "主图号", "主图号")
            '            Return False
            '        End If
            '        If grid成品入库申请.Rows(i).Cells("入库数量").Value.ToString() & "" = "" Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "入库数量", "入库数量")
            '            Return False
            '        End If

            '        objZ成品入库申请T.分图号 = grid成品入库申请.Rows(i).Cells("分图号").Value.ToString()
            '        objZ成品入库申请T.主图号 = grid成品入库申请.Rows(i).Cells("主图号").Value.ToString()
            ' dt = objBll.Check主图分图(objZ成品入库申请T)

            ' If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            'MsgBox("产品图号：" & objZ成品入库申请T.分图号 & "不属于主图号：" & objZ成品入库申请T.主图号)
            ' Return False
            '  End If

            'Next
            'End If


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

#Region "ADDCheck"
    Private Function ADDCheck() As Boolean

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If
            If grid成品入库申请.Rows.Count = 0 Then
                Return False
            Else
                For i = 0 To grid成品入库申请.Rows.Count - 1
                    If grid成品入库申请.Rows(i).Cells(ENU_GRID.入库数量).Value.ToString() & "" = "" Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "入库数量", "入库数量")
                        Return False
                    End If
                    If grid成品入库申请.Rows(i).Cells(ENU_GRID.入库重量).Value.ToString() & "" = "" Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "入库重量", "入库重量")
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
            'Me.grid成品入库申请.Enabled = Utility.PFn_GetAuth(Me.grid成品入库申请.Tag)
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
        Dim objZ成品入库申请T As New Z成品入库申请T
        Dim objBll As BLLZ成品入库申请T

        Try
            '获取数据
            objZ成品入库申请T = New Z成品入库申请T
            objBll = New BLLZ成品入库申请T

            objZ成品入库申请T.申请单编号 = txt申请单编号.Text.Trim()

            If String.IsNullOrEmpty(objZ成品入库申请T.申请单编号) Then
                objZ成品入库申请T.申请单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAllHead(objZ成品入库申请T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                Me.txt申请单编号.Text = mdsInfoDataSet.Rows(0)("申请单编号").ToString()
                Me.txt申请者编号.Text = mdsInfoDataSet.Rows(0)("申请者编号").ToString()
                Me.txt申请者名称.Text = mdsInfoDataSet.Rows(0)("人员名").ToString()
                Me.txt职务.Text = mdsInfoDataSet.Rows(0)("职务").ToString()
                Me.txt部门.Text = mdsInfoDataSet.Rows(0)("部门").ToString()
                Me.dt申请日期.Text = mdsInfoDataSet.Rows(0)("申请日期").ToString()
            Else
                Me.txt申请单编号.Text = "CP" & Now.ToString("yyyyMMddhhmmss")
                Me.txt申请者编号.Text = String.Empty
                Me.txt申请者名称.Text = String.Empty
                Me.txt职务.Text = String.Empty
                Me.txt部门.Text = String.Empty
                Me.dt申请日期.Text = DateTime.Now
            End If

            mdsGridDataSet = objBll.LoadGridAll(objZ成品入库申请T)
            'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
            grid成品入库申请.DataSource = mdsGridDataSet
            'grid成品入库申请.DisplayLayout.Bands(0).Columns("客户编号CD").Hidden = True

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

#Region "Update订单"
    Private Sub Update订单()
        Dim objZ成品入库申请T As New Z成品入库申请T
        Dim objBll As New BLLZ成品入库申请T
        Dim arryList As New ArrayList
        Try
            '获取数据
            objZ成品入库申请T = New Z成品入库申请T
            objBll = New BLLZ成品入库申请T
            objZ成品入库申请T.订单编号 = grid成品入库申请.Rows(0).Cells(ENU_GRID.订单编号).Value.ToString()

            If String.IsNullOrEmpty(objZ成品入库申请T.订单编号) Then
                objZ成品入库申请T.订单编号 = " "
            End If
            If grid成品入库申请.Rows(0).Cells(ENU_GRID.订单编号).Value.ToString() <> String.Empty Then
                mds = objBll.Update订单(objZ成品入库申请T)
                'If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                '    Me.txt订单编号.Text = mdsInfoDataSet.Rows(0)("订单编号").ToString()
                '    Me.txt客户名称.Text = mdsInfoDataSet.Rows(0)("客户名称").ToString()
                '    Me.dmt发货日期.Text = mdsInfoDataSet.Rows(0)("发货日期").ToString()
                '    Me.txt备注.Text = mdsInfoDataSet.Rows(0)("备注").ToString()
                '    Me.pic图纸.Text = mdsInfoDataSet.Rows(0)("图纸").ToString()

                'Else
                '    Me.txt订单编号.Text = String.Empty
                '    Me.txt完成期限.Text = String.Empty
                'End If
                '    mdsGridDataSet = objBll.LoadAllGrid(objM生产计划T)
                '    Me.grid生产计划制定.DataSource = mdsGridDataSet
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

#Region "SetGridStyle"

    Private Sub SetGridStyle()
        Try
            'With grdList.DisplayLayout.Bands(0)
            '    .Columns("选择").Style = ColumnStyle.CheckBox
            'End With

            'With grid成品入库申请.DisplayLayout.Bands(0)
            '    If grid成品入库申请.DisplayLayout.Bands(0) Is Nothing Then
            '        Exit Sub
            '    Else
            '        .Columns("外协品").CellActivation.= False
            '        .Columns("发货日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            '        .Columns("到货日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            '        .Columns("发货日期").CellActivation = Activation.NoEdit
            '        .Columns("到货日期").CellActivation = Activation.NoEdit

            '        .Columns("订单数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '        .Columns("投产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '        .Columns("图纸").Hidden = True
            '        .Columns("审核状态").Hidden = True
            '        '.Columns("高").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '        '.Columns("重量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '        '.Columns("税率").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '        '.Columns("含税单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '    End If
            'End With

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