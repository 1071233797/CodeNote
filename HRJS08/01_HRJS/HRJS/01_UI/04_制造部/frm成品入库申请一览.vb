Imports HRJS.Constant
Imports UserControl

Imports Infragistics.Win.UltraWinGrid
Public Class frm成品入库申请一览
#Region "变量定义"
    Private mDtSearch As DataTable = Nothing
    Private mDt详细 As DataSet  'grid详细
    Private mDt详细图纸1 As DataTable  'grid详细
    Private mDt详细图纸2 As DataTable  'grid详细
    Public intDoubleClick As Integer = 0

#End Region

#Region "Form Event"

    Private Sub frm成品入库申请一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

    Private Sub frm成品入库申请一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm成品入库申请一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
                                           Handles gridlist.DoubleClickRow

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

    Private Sub gridlist_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridlist.InitializeLayout

        Try
            Dim intLoopi As Integer
            For index = 1 To gridlist.DisplayLayout.Bands(0).Columns.Count - 1
                gridlist.DisplayLayout.Bands(0).Columns(intLoopi).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Next
            gridlist.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub gridlist_ClickCel(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles gridlist.ClickCell
        If e.Cell.Equals(gridlist.ActiveRow.Cells(0)) Then
            Me.gridlist.UpdateData()
        End If
    End Sub

    Private Sub gridlist_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridlist.KeyDown
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

            '关闭画面对话框
            'If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgNo Then
            '    '処理終了
            '    Exit Sub
            'End If

            ReturnType = Constant.ENU_MSTSEARCH.SearchMCancel

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

    Private Sub UcText4_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt申请者编号.EditorButtonClick


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


                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "申请者名称")
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



    Private Sub gridlist_ClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles gridlist.ClickCell
        If e.Cell.Equals(gridlist.ActiveRow.Cells(0)) Then
            Me.gridlist.UpdateData()
        End If
    End Sub

    '打印入库票
    Private Sub btn11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11.Click
        Dim objB成品入库申请T As New Z成品入库申请T
        Dim objBll As New BLLZ成品入库申请T
        Dim strWhere As String = ""
        Try

            If gridlist.Rows.Count = 0 Then
                MsgBox("请选择需要打印的数据")
                Exit Sub
            End If

            For index As Integer = 0 To gridlist.Rows.Count - 1

                If gridlist.Rows(index).Cells("选择").Value = 1 Then
                    objB成品入库申请T.申请单编号 = gridlist.Rows(index).Cells("申请单编号").Value
                    strWhere += ",'" & objB成品入库申请T.申请单编号 & "'"
                End If
            Next
            If strWhere <> "" Then
                strWhere = "''" + strWhere
            End If
            Dim dtall As DataTable = objBll.Load打印数据(strWhere)

            If dtall.Rows.Count > 0 Then
                Dim rpt As New 产成品入库明细
                Dim rv As New ReportViewr
                rv.ReportExportType = Constant.ReporyType.成品入库单
                'rv.PurchaseOrder = objM采购单T
                rv.DtSource = dtall
                rv.ShowDialog()
                rv.Init_Load()
            End If

        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '默认光标设置
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

#Region "SetPermission"

    Private Sub SetPermission()
        Try

            Me.btnF2查询.Enabled = Utility.PFn_GetAuth(Me.btnF2查询.Tag)
            Me.btnF3选择.Enabled = Utility.PFn_GetAuth(Me.btnF3选择.Tag)
            Me.btn11.Enabled = Utility.PFn_GetAuth(Me.btn11.Tag)
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

#Region "InitGrid"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitGrid()
        Try

            mDtSearch = New DataTable

            mDtSearch.Columns.Add("选择")
            mDtSearch.Columns.Add("申请单编号")
            mDtSearch.Columns.Add("申请者")
            mDtSearch.Columns.Add("职务")
            mDtSearch.Columns.Add("部门")
            mDtSearch.Columns.Add("申请日期")
            'mDtSearch.Columns.Add("作成者")
            ' mDtSearch.Columns.Add("备注")

            gridlist.DataSource = mDtSearch

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

            Me.txt申请单编号.Text = String.Empty
            Me.txt申请者编号.Text = String.Empty
            Me.txt申请者名称.Text = String.Empty
            Me.cmb质检状态.Text = String.Empty
            Me.dmt申请日期sta.Text = DateAdd("M", -1, Now)
            Me.dmt申请日期end.Text = Date.Now

            txt申请单编号.Select()
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

        Dim objBll As New BLLZ成品入库申请T
        Dim objZ成品入库申请T As New Z成品入库申请T

        Try
            '一览打开，不做处理
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If

            '选择行が無い場合
            If Me.gridlist.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            '查询の选择されたレCDを取得する()
            If intDoubleClick = 1 Then
                If gridlist.ActiveRow.Cells.Count < 8 Then
                    MsgBox("请选择图号。")
                    Exit Sub
                Else
                    objZ成品入库申请T.产品图号 = Me.gridlist.ActiveRow.Cells("产品图号").Text.Trim
                End If
            End If


            objZ成品入库申请T.申请单编号 = Me.gridlist.ActiveRow.Cells("申请单编号").Text.Trim
            'If Me.gridlist.ActiveRow.Cells("订单编号").Text.Trim <> String.Empty Then
            '    objZ成品入库申请T.订单编号 = Me.gridlist.ActiveRow.Cells("订单编号").Text.Trim
            'Else
            '    objZ成品入库申请T.订单编号 = ""
            'End If

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAllHead1(objZ成品入库申请T)

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

        Dim objZ成品入库申请T As New Z成品入库申请T

        Dim objBll As New BLLZ成品入库申请T

        Try
            objZ成品入库申请T = New Z成品入库申请T

            objZ成品入库申请T.申请单编号 = Me.txt申请单编号.Text.Trim
            objZ成品入库申请T.申请者编号 = Me.txt申请者编号.Text.Trim
            objZ成品入库申请T.处理结果 = Me.cmb质检状态.Text

            '查询の検索処理

            'mDtSearch = objBll.LoadByWhere(objZ成品入库申请T)

            If (Not Me.dmt申请日期sta.Text.Trim = String.Empty) Then
                objZ成品入库申请T.申请日期1 = Me.dmt申请日期sta.Text.Trim
            Else
                objZ成品入库申请T.申请日期1 = Constant.CGSTRDATE_DEFAULT
            End If

            If (Not Me.dmt申请日期end.Text.Trim = String.Empty) Then
                objZ成品入库申请T.申请日期2 = Me.dmt申请日期end.Text.Trim
            Else
                objZ成品入库申请T.申请日期2 = Constant.CGSTRDATE_DEFAULT
            End If
            Me.gridlist.DataSource = Nothing

            mDt详细 = New DataSet
            Me.mDt详细图纸1 = New DataTable
            mDt详细图纸1 = objBll.LoadByWhere(objZ成品入库申请T)

            'mdt详细Band1データを記録テーブル初期化
            Me.mDt详细图纸2 = New DataTable
            mDt详细图纸2 = objBll.LoadByWhere1(objZ成品入库申请T)

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(2) As DataRelation

            mDt详细 = New DataSet
            'DataSetの親子関係を設定
            mDt详细.Relations.Clear()

            '親、子のテーブルを追加
            mDt详细图纸1.TableName = "详细图纸1"
            mDt详细.Tables.Add(mDt详细图纸1)

            mDt详细图纸2.TableName = "详细图纸2"
            mDt详细.Tables.Add(mDt详细图纸2)

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(0).Columns("申请单编号")
            childCols(0) = mDt详细.Tables(1).Columns("申请单编号")

            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(0))

            Me.gridlist.DataSource = mDt详细
            gridlist.Refresh()


            If mDt详细 Is Nothing OrElse mDt详细.Tables(0).Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.UcGrid2.PClear()
                '検索データを表示する
                Me.gridlist.DataSource = mDt详细

                'フォーカスの設定処理
                Me.txt申请单编号.Focus()
            Else
                '検索データを表示する
                Me.gridlist.DataSource = mDt详细
                Me.gridlist.Focus()
                Me.gridlist.ActiveRow = Me.gridlist.Rows(0)
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

#End Region
#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try

            '制限件数コンボボックス

            Utility.PFn_SetCombo(Me.cmb质检状态, "VM质检状态", 0)

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

            With gridlist.DisplayLayout.Bands(0)
                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("申请日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("申请日期").CellActivation = Activation.NoEdit
            End With

            With gridlist.DisplayLayout.Bands(1)

                '.Columns("申请单编号").Hidden = True
                '.Columns("质检状态").CellActivation = Activation.NoEdit
                '.Columns("半成品名称").CellAppearance.BackColor = Color.Silver
                .Columns("入库数量(个)").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("入库重量(kg)").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("隐藏").Hidden = True
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


End Class