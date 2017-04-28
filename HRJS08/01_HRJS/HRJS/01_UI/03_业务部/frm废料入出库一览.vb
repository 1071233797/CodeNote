Imports HRJS.Constant
Imports UserControl
Public Class frm废料入出库一览
#Region "变量定义"
    Private mDtSearch As DataTable = Nothing
    Private mDt详细 As DataSet  'grid详细
    Private mDt详细图纸1 As DataTable  'grid详细
    Private mDt详细图纸2 As DataTable  'grid详细

#End Region
#Region "常数定義"

    Public Enum ENU_GRID As Integer
        区分 = 0
        粉料产生工序 = 1
        废料数量 = 2
        原材料批号 = 3
        原材料数量 = 4
        原材料规格 = 5
        回收日期 = 6
    End Enum

#End Region
#Region "Form Event"

    Private Sub frm废料入出库一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

    Private Sub frm废料入出库一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm废料入出库一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

            '制限件数コンボボックス            Utility.PFn_SetCombo(Me.cob废料入出库区分, "VM入出库区分", 0)
            'Utility.PFn_SetCombo(Me.cmb质检状态, "VM质检状态", 0)
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

            mDtSearch.Columns.Add("区分")
            mDtSearch.Columns.Add("废料产生工序")
            mDtSearch.Columns.Add("废料数量")
            mDtSearch.Columns.Add("原材料批号")
            mDtSearch.Columns.Add("原材料名称")
            mDtSearch.Columns.Add("原材料规格")
            mDtSearch.Columns.Add("回收日期")
            mDtSearch.Columns.Add("备注")


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

            Me.cob废料入出库区分.Text = String.Empty
            'If cob原材料区分.Rows.Count > 0 Then
            '    cob原材料区分.Rows(0).Selected = False
            'End If
            'If cmb质检状态.Rows.Count > 0 Then
            '    cmb质检状态.Rows(0).Selected = False
            'End If
            Me.txt废料产生工序.Text = String.Empty
            Me.txt原材料编号.Text = String.Empty
            Me.txt原材料名称.Text = String.Empty
            Me.txt回收日期起.Text = DateAdd("M", -1, Now)
            Me.txt回收日期止.Text = Date.Now

            cob废料入出库区分.Select()
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

        Dim objBll As New BLLM原材料入库申请T
        Dim objZ原材料入库申请T As New B原材料入库申请T

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
            objZ原材料入库申请T.申请单编号 = Me.gridList.ActiveRow.Cells("申请单编号").Text.Trim

            'テーブルにデータを追加
            ReturnTable = objBll.LoadByPKey1(objZ原材料入库申请T)

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

        Dim objB废料入出库一览T As B废料入出库T

        Dim objBLLM废料入出库T As New BllM废料入出库T
        Try
            objB废料入出库一览T = New B废料入出库T
            objBLLM废料入出库T = New BllM废料入出库T

            objB废料入出库一览T.废料产生工序 = Me.txt废料产生工序.Text.Trim
            objB废料入出库一览T.入出库区分 = Me.cob废料入出库区分.Text.Trim

            If (Not Me.txt回收日期起.Text.Trim = String.Empty) Then
                objB废料入出库一览T.回收日期起 = Me.txt回收日期起.Text.Trim
            Else
                objB废料入出库一览T.回收日期起 = Constant.CGSTRDATE_DEFAULT
            End If

            If (Not Me.txt回收日期止.Text.Trim = String.Empty) Then
                objB废料入出库一览T.回收日期止 = Me.txt回收日期止.Text.Trim
            Else
                objB废料入出库一览T.回收日期止 = Constant.CGSTRDATE_DEFAULT
            End If

            objB废料入出库一览T.原材料编号 = Me.txt原材料编号.Text.Trim
            objB废料入出库一览T.原材料名称 = Me.txt原材料名称.Text.Trim
            'objB废料入出库一览T.废料产生工序 = Me.txt废料产生工序.Text.Trim

            Me.gridList.DataSource = Nothing

            mDtSearch = objBLLM废料入出库T.LoadByWhere(objB废料入出库一览T)

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                mDtSearch.Clear()
                Me.gridList.DataSource = mDtSearch
                'フォーカスの設定処理
                Me.cob废料入出库区分.Focus()
            Else
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

                .Columns("回收日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                ' .Columns("完成日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("入出库数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

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