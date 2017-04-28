Imports HRJS.Constant

Public Class frm订单进度查询

#Region "常数定義"

    Public Enum ENU_GRID As Integer
        订单编号 = 0
        订单状态 = 1
        客户名称 = 2
        产品图号 = 3
        产品区分 = 4
        产品种类 = 5
        规格 = 6
        加工工序 = 7
        发货日期 = 8
        订单数量 = 9
        备注 = 10


    End Enum

#End Region

#Region "変数定義"

    Private mDtSearch As DataTable = Nothing
    Private mstr原材料编号 As String = String.Empty


    Public Property 原材料编号() As String
        Get
            Return mstr原材料编号

        End Get
        Set(ByVal Value As String)
            mstr原材料编号 = Value
        End Set
    End Property

#End Region

#Region "Form Event"

    Private Sub frm订单进度查询_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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
    Private Sub frm订单进度查询_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm订单进度查询_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
#Region "Control Event"

#Region "订单编号"

    Private Sub txt订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick

        Dim frmSearch订单 As frm订单一览
        Try
            frmSearch订单 = New frm订单一览
            frmSearch订单.FormOpenMode = Constant.ENU_MODE.Model_Ref
            frmSearch订单.ShowDialog()

            '画面数据设置
            If frmSearch订单.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch订单.ReturnTable Is Nothing AndAlso 0 < frmSearch订单.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt订单编号.Text = frmSearch订单.ReturnTable.Rows(0)("订单编号")     '部品番号

                End If
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
#Region "产品图号"

    Private Sub txt产品图号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt产品图号.Enter

        Try

            Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt产品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt产品图号.EditorButtonClick


        Dim frmSearch As frm图纸信息一览
        Try
            frmSearch = New frm图纸信息一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '    '根据检索画面数据进行设置

                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")     '客户编号

                    ' Me.txt产品名称.Text = frmSearch.ReturnTable.Rows(0)("品名")     '部品名称

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
#Region "客户编号"

    Private Sub txt客户编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt客户编号.Enter

        Try

            Me.txt客户编号.Tag = Me.txt客户编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
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

                    '根据检索画面数据进行设置

                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")     '客户编号

                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")     '客户名称


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


    Private Sub txt客户编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt客户编号.Validating

        Dim objM客户T As M客户T
        Dim dtM客户T As DataTable
        Dim objBllM客户T As BLLM客户T

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

                objBllM客户T = New BLLM客户T

                dtM客户T = objBllM客户T.LoadByWhere(objM客户T)

                If dtM客户T.Rows.Count <> 0 Then

                    Me.txt客户名称.Text = dtM客户T.Rows(0).Item("客户名称").ToString
                Else
                    Me.txt客户名称.Text = String.Empty
                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID22, "客户名称")
                    'Me.txt客户编号.Select()
                End If
            Else
                Me.txt客户名称.Text = String.Empty
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
#Region "Button Event"

    Private Sub btnF1清空_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF1清空.Click
        Try
            '清空画面对话框

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
            ' Me.Selection()

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

#End Region

#Region "Grid Event"

    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                           Handles gridList.DoubleClickRow

        Try

            '选择処理
            ' Me.Selection()

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

            gridList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub gridList_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridList.KeyDown
        Try

            If e.KeyCode <> Keys.Enter Then
                Exit Sub
            End If

            Select Case FormOpenMode

                Case Constant.ENU_MODE.Model_Search
                    '选择処理
                    ' Me.Selection()
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
            SetButtonStatus()
            Me.InitGrid()

            '画面の内容を清空処理
            Me.ClearForm()
            Me.txt订单编号.Select()
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

            '制限件数コンボボックス

            Utility.PFn_SetCombo(Me.cob产品区分, "VM产品区分", 0)
            Utility.PFn_SetCombo(Me.cob订单状态, "VM订单状态", 0)

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

            txt订单编号.Text = String.Empty
            txt产品图号.Text = String.Empty
            txt客户编号.Text = String.Empty
            txt客户名称.Text = String.Empty
            cob产品区分.Text = String.Empty
            cob订单状态.Text = String.Empty
            'txt回收日期.Text = Date.Now
            'txt回收日期2.Text = Date.Now
            Me.txt发货日期起.Text = DateAdd("M", -1, Now)
            Me.txt发货日期止.Text = DateTime.Now.ToString("yyyy/MM/dd")


            Me.txt订单编号.Focus()

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
            mDtSearch.Columns.Add("订单编号")
            mDtSearch.Columns.Add("订单状态")
            mDtSearch.Columns.Add("客户名称")
            mDtSearch.Columns.Add("产品图号")
            mDtSearch.Columns.Add("产品区分")
            mDtSearch.Columns.Add("订单数量")
            mDtSearch.Columns.Add("投产数量")
            mDtSearch.Columns.Add("品种规格")
            mDtSearch.Columns.Add("备注")
            mDtSearch.Columns.Add("发货日期")
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

#Region "'SetPermission"

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
    'Private Sub Selection()

    '    Dim objBll As New BLLM废料回收管理T
    '    Dim objM废料回收管理T As New B废料回收管理T


    '    Try
    '        '选择行が無い場合
    '        If Me.grdList.ActiveRow Is Nothing Then
    '            'メッセージ表示
    '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
    '            '処理終了
    '            Exit Sub
    '        End If

    '        objM废料回收管理T.ID = Me.grdList.ActiveRow.Cells("ID").Text.Trim
    '        'テーブルにデータを追加
    '        ReturnTable = objBll.LoadAll(objM废料回收管理T)

    '        If ReturnTable Is Nothing OrElse ReturnTable.Rows.Count = 0 Then
    '            'メッセージ表示
    '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID19)
    '            Exit Sub
    '        End If

    '        ReturnType = Constant.ENU_MSTSEARCH.SearchMOk

    '        '画面を閉じる
    '        Me.Close()
    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try

    'End Sub

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
#Region "DataSearch"

    Private Sub DataSearch()

        Dim objM订单表T As B订单表T

        Dim objBLLM订单表T As New BllM订单表T

        Try

            objM订单表T = New B订单表T
            objBLLM订单表T = New BllM订单表T

            objM订单表T.订单编号 = Me.txt订单编号.Text.Trim
            objM订单表T.产品图号 = Me.txt产品图号.Text.Trim
            objM订单表T.产品区分 = Me.cob产品区分.Value

            objM订单表T.订单状态 = Me.cob订单状态.Value
            objM订单表T.客户编号 = Me.txt客户编号.Text.Trim
            'objM订单表T. = Me.txt产品图号.Text.Trim
            'objM订单表T.加工工序 = Me.txt加工工序.Text.Trim

            If (Not Me.txt发货日期起.Text.Trim = String.Empty) Then
                objM订单表T.发货日期 = Me.txt发货日期起.Text.Trim
            Else
                objM订单表T.发货日期 = Constant.CGSTRDATE_DEFAULT
            End If

            If (Not Me.txt发货日期止.Text.Trim = String.Empty) Then
                objM订单表T.发货日期2 = Me.txt发货日期止.Text.Trim
            Else
                objM订单表T.发货日期2 = Constant.CGSTRDATE_DEFAULT
            End If

            '查询の検索処理

            mDtSearch = objBLLM订单表T.LoadByWherejd(objM订单表T)


            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力

                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.gridList.DataSource = mDtSearch

                'フォーカスの設定処理
                Me.txt订单编号.Focus()
            Else

                '検索データを表示する
                Me.gridList.DataSource = mDtSearch

                Me.gridList.Focus()
                Me.gridList.ActiveRow = Me.gridList.Rows(0)
                SetGridStyle()
            End If

            ' DatagrdListView1.Columns(0).Visible = False
            ''****************************************************
            ''查询の検索処理:件数
            'Dim dtCOUNT As New DataTable

            'dtCOUNT = objBllM部门T.GetGridData(objM部门T, True)

            'Me.grdList.PSummaryFooterCaption(dtCOUNT.Rows.Count)
            ''****************************************************

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

                .Columns("客户编号").Hidden = True

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