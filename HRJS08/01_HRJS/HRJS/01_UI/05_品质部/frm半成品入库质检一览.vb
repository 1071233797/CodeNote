Imports HRJS.Constant
Imports UserControl
Imports Infragistics.Win.UltraWinGrid

Public Class frm半成品入库质检一览
#Region "变量定义"
    Private mDtSearch As DataTable = Nothing


#End Region

#Region "Form Event"

    Private Sub frm半成品入库质检一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

    Private Sub frm半成品入库质检一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            'If Me.btnLogoOff.Text.ToString.Contains(CSTRLOGOFF) Then
            If Me.FormOpenMode <> Constant.ENU_MODE.Model_NULL Then
                Exit Sub
            End If
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

    Private Sub frm半成品入库质检一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                Case Keys.F2
                    btnF2查询.Focus()
                    btnF2查询_Click(Nothing, Nothing)

                Case Keys.F3
                    btnF3选择.Focus()
                    btnF3选择_Click(Nothing, Nothing)

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

#Region "Grid Event"

    Private Sub gridlist_DoubleClickRow(ByVal sender As System.Object, _
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                           Handles gridList.DoubleClickRow

        Try

            '选择処理
            Me.Selection()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridList.InitializeLayout

        Try
            Dim intLoopi As Integer
            For index = 1 To gridList.DisplayLayout.Bands(0).Columns.Count - 1
                gridList.DisplayLayout.Bands(0).Columns(intLoopi).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Next
            gridList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub gridlist_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridList.KeyDown
        Try

            If e.KeyCode <> Keys.Enter Then
                Exit Sub
            End If

            Select Case FormOpenMode

                Case Constant.ENU_MODE.Model_Search
                    '选择処理
                    Me.Selection()
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

#Region "Button Event"

    Private Sub btnF1清空_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF1清空.Click
        Try

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If
            ClearForm()
            InitGrid()

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

            ''关闭画面对话框
            'If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgNo Then
            '    '    '処理終了
            '    Exit Sub
            'End If

            'ReturnType = Constant.ENU_MSTSEARCH.SearchMCancel

            '画面を閉じる
            Me.Close()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF2查询_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2查询.Click
        Try

            '砂時計のカーソルが設定
            Me.Cursor = Cursors.WaitCursor

            '検索を実行
            Me.DataSearch()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF3选择_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF3选择.Click
        Try
            '选择処理
            Me.Selection()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#Region "人员编号"
    Private Sub UcText4_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt人员编号.EditorButtonClick


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

                    Me.txt人员编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '人员编号
                    Me.txt人员名称.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '人员名

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


                    Me.txt人员名称.Text = objM人员T.人员名     '客户名称


                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "检查者名称")
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
#Region "入库申请单"
    Private Sub txt入库申请单_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt入库申请单.EditorButtonClick

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
                    Me.txt入库申请单.Text = frmSearch.ReturnTable.Rows(0)("申请单编号")     '申请单编号

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

            'Grid初始化
            Me.InitGrid()

            '画面の内容を清空処理
            Me.ClearForm()
            '権限の処理            SetButtonStatus()
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

#Region "SetButtonStatus"
    Private Sub SetButtonStatus()
        Select Case FormOpenMode
            Case ENU_MODE.Model_NULL
                Me.btnF3选择.Visible = False
            Case Else
                Me.btnF3选择.Visible = True
        End Select
    End Sub
#End Region

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try

            '制限件数コンボボックス            Utility.PFn_SetCombo(Me.cmb处理结果, "VM质检状态", 0)
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "InitGrid"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitGrid()
        Try

            mDtSearch = New DataTable

            mDtSearch.Columns.Add("申请单编号")
            mDtSearch.Columns.Add("订单编号")
            mDtSearch.Columns.Add("主图号")
            mDtSearch.Columns.Add("上级图号")
            mDtSearch.Columns.Add("分图号")
            mDtSearch.Columns.Add("半成品名称")
            mDtSearch.Columns.Add("半成品种类")
            mDtSearch.Columns.Add("工序名称")
            mDtSearch.Columns.Add("入库数量")
            mDtSearch.Columns.Add("检查内容")
            mDtSearch.Columns.Add("检查数量")
            mDtSearch.Columns.Add("不良原因")
            mDtSearch.Columns.Add("处理结果")
            mDtSearch.Columns.Add("备注")
            mDtSearch.Columns.Add("检查者")
            mDtSearch.Columns.Add("检查日期")
        
            gridList.DataSource = mDtSearch

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

            'Me.txt原材料编号.Text = String.Empty
            'Me.txt原材料名称.Text = String.Empty
            Me.txt人员编号.Text = String.Empty
            Me.txt人员名称.Text = String.Empty
            Me.txt入库申请单.Text = String.Empty
            If cmb处理结果.Rows.Count > 0 Then
                cmb处理结果.Rows(0).Selected = False
            End If
            Me.dt检查日期S.Text = DateAdd("M", -1, Now)
            Me.dt检查日期E.Text = Date.Now

            txt入库申请单.Select()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "SetPermission"

    Private Sub SetPermission()
        Try

            Me.btnF2查询.Enabled = Utility.PFn_GetAuth(Me.btnF2查询.Tag)
            Me.btnF3选择.Enabled = Utility.PFn_GetAuth(Me.btnF3选择.Tag)

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Selection"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Selection()

        Dim objBll As New BLLZ半成品入库质检T
        Dim objZ半成品入库质检T As New Z半成品入库质检T

        Try
            '一览打开，不做处理
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If

            '选择行が無い場合
            If Me.gridList.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            '查询の选择されたレCDを取得する
            objZ半成品入库质检T.申请单编号 = Me.gridList.ActiveRow.Cells("申请单编号").Text.Trim

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAllHead(objZ半成品入库质检T)

            If ReturnTable Is Nothing OrElse ReturnTable.Rows.Count = 0 Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID19)
                Exit Sub
            End If

            ReturnType = Constant.ENU_MSTSEARCH.SearchMOk

            '画面を閉じる
            Me.Close()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "DataSearch"

    Private Sub DataSearch()

        Dim objB半成品入库质检T As New Z半成品入库质检T
        Dim objBll As New BLLZ半成品入库质检T

        Try
            objB半成品入库质检T = New Z半成品入库质检T

            'objB原材料入库申请T.材料编号 = Me.txt原材料编号.Text
            objB半成品入库质检T.检查者编号 = Me.txt人员编号.Text
            objB半成品入库质检T.申请单编号 = Me.txt入库申请单.Text.Trim
            objB半成品入库质检T.处理结果 = Me.cmb处理结果.Value
            objB半成品入库质检T.检查日期S = Me.dt检查日期S.Text
            objB半成品入库质检T.检查日期E = Me.dt检查日期E.Text

            Me.gridList.DataSource = Nothing

            Me.mDtSearch = New DataTable
            mDtSearch = objBll.LoadByWhere(objB半成品入库质检T)


            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.gridlist.PClear()
                '検索データを表示する
                Me.gridList.DataSource = mDtSearch

                'フォーカスの設定処理
                Me.txt入库申请单.Focus()
            Else
                '検索データを表示する
                Me.gridList.DataSource = mDtSearch
                Me.gridList.Focus()
                Me.gridList.ActiveRow = Me.gridList.Rows(0)
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
#Region "SetGridStyle"

    Private Sub SetGridStyle()
        Try

            With gridList.DisplayLayout.Bands(0)

                .Columns("入库数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("检查数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("不良数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("检查日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("检查日期").CellActivation = Activation.NoEdit
                .Columns("申请单编号").CellActivation = Activation.NoEdit

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

End Class