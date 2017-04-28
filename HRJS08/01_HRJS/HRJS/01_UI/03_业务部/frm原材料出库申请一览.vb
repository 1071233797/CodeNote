﻿Imports HRJS.Constant
Imports UserControl
Imports Infragistics.Win.UltraWinGrid

Public Class frm原材料出库申请一览
#Region "变量定义"
    Private mDtSearch As DataTable = Nothing
    Private mDt详细 As DataSet  'grid详细
    Private mDt详细图纸1 As DataTable  'grid详细
    Private mDt详细图纸2 As DataTable  'grid详细

#End Region


#Region "Form Event"

    Private Sub frm原材料出库申请一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

    Private Sub frm原材料出库申请一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm原材料出库申请一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub grdList_ClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles gridList.ClickCell
        If e.Cell.Equals(gridList.ActiveRow.Cells(0)) Then
            Me.gridList.UpdateData()
        End If
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

                    'Me.txt职务.Text = objM人员T.职务

                    'Me.txt部门.Text = objM人员T.部门

                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员名称")
                    Me.txt人员编号.Text = String.Empty
                    Me.txt人员名称.Text = String.Empty
                    'Me.txt职务.Text = String.Empty
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

            '制限件数コンボボックス            Utility.PFn_SetCombo(Me.cob原材料区分, "VM材料区分", 0)

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

            mDtSearch.Columns.Add("选择")
            mDtSearch.Columns.Add("申请单编号")
            mDtSearch.Columns.Add("领料者编号")
            mDtSearch.Columns.Add("领料者")
            mDtSearch.Columns.Add("职务")
            mDtSearch.Columns.Add("部门")
            mDtSearch.Columns.Add("申请日期")
            mDtSearch.Columns.Add("作成者")


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

            Me.txt出库申请单号.Text = String.Empty
            Me.txt人员编号.Text = String.Empty
            Me.txt人员名称.Text = String.Empty
            Me.dt申请开始日期.Text = DateAdd("M", -1, Now)
            Me.dt申请结束日期.Text = Date.Now
            Me.cob原材料区分.Text = String.Empty

            txt出库申请单号.Select()
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

#Region "Selection"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Selection()

        Dim objBll As New BLLZ原材料出库申请T
        Dim objZ原材料出库申请T As New Z原材料出库申请T

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
            objZ原材料出库申请T.申请单编号 = Me.gridList.ActiveRow.Cells("申请单编号").Text.Trim

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objZ原材料出库申请T)

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

        Dim objZ原材料出库申请T As New Z原材料出库申请T
        Dim objBll As New BLLZ原材料出库申请T

        Try
            objZ原材料出库申请T = New Z原材料出库申请T

            objZ原材料出库申请T.申请单编号 = Me.txt出库申请单号.Text.Trim
            objZ原材料出库申请T.领料者编号 = Me.txt人员编号.Text.Trim
            objZ原材料出库申请T.材料区分 = Me.cob原材料区分.Value
            objZ原材料出库申请T.开始日期 = Me.dt申请开始日期.Text
            objZ原材料出库申请T.结束日期 = Me.dt申请结束日期.Text
            Me.gridList.DataSource = Nothing

            mDt详细 = New DataSet
            Me.mDt详细图纸1 = New DataTable
            mDt详细图纸1 = objBll.LoadByWhere(objZ原材料出库申请T)

            'mdt详细Band1データを記録テーブル初期化
            Me.mDt详细图纸2 = New DataTable
            mDt详细图纸2 = objBll.LoadByWhere1(objZ原材料出库申请T)

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(1) As DataRelation

            mDt详细 = New DataSet
            'DataSetの親子関係を設定
            mDt详细.Relations.Clear()

            '親、子のテーブルを追加
            mDt详细图纸1.TableName = "详细图纸1"
            mDt详细.Tables.Add(mDt详细图纸1)

            mDt详细图纸2.TableName = "详细图纸2"
            mDt详细.Tables.Add(mDt详细图纸2)

            ReDim parentCols(0) '声明数组
            ReDim childCols(0)

            parentCols(0) = mDt详细.Tables(0).Columns("申请单编号")
            childCols(0) = mDt详细.Tables(1).Columns("申请单编号")
            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(0))

            Me.gridList.DataSource = mDt详细
            gridList.Refresh()


            If mDt详细 Is Nothing OrElse mDt详细.Tables(0).Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.gridlist.PClear()
                '検索データを表示する
                Me.gridList.DataSource = mDt详细

                'フォーカスの設定処理
                Me.txt出库申请单号.Focus()
            Else
                '検索データを表示する
                Me.gridList.DataSource = mDt详细
                'Me.gridList.DataSource(0).cell("选择").style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
                'Me.gridList.DataSource(0).cell("选择").value = True

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

                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("选择").CellActivation = Activation.AllowEdit
                .Columns("领料日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("领料日期").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            End With
            With gridList.DisplayLayout.Bands(1)
                .Columns("领料数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("领料重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("申请单编号").Hidden = True
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


    Private Sub btn11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11.Click
        Dim objM原材料出库T As Z原材料出库申请T
        Dim arrayList As ArrayList
        Dim rv As New ReportViewr
        Dim str申请单编号 As String = String.Empty
        Dim dt As New System.Data.DataTable
        Try

            If Me.gridList.Rows.Count = 0 Then
                MsgBox("请选择需要打印的数据")
                Exit Sub
            End If
            dt = gridList.DataSource.tables(0)
            str申请单编号 = String.Empty
            For Each drr As DataRow In dt.Rows

                If drr("选择") = 1 Then

                    If drr("审核状态") = "审核通过" Then
                        If str申请单编号 = String.Empty Then
                            str申请单编号 = drr("申请单编号")

                        Else
                            str申请单编号 = str申请单编号 & "','" & drr("申请单编号")

                        End If
                    Else
                        MsgBox("请选择审核通过的数据！！！")
                        Exit Sub
                    End If


                End If

            Next

            If str申请单编号 = String.Empty Then
                MsgBox(" 请选择需要打印的出库单。")
                Exit Sub
            End If

            Dim bllOp As New BLLZ原材料出库申请T
            objM原材料出库T = New Z原材料出库申请T
            objM原材料出库T.申请单编号 = str申请单编号
            Dim dts = bllOp.ReportViewr(objM原材料出库T)
            rv.ReportExportType = Constant.ReporyType.原材料出库单
            rv._Raw = objM原材料出库T
            rv.DtSource = dts
            rv.ShowDialog()
            rv.Init_Load()
            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "打印")
        Catch ex As Exception
            ExHelper.ProcessEx(ex)
            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "打印")
        End Try
    End Sub
End Class