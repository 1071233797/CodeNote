Imports Infragistics.Win.UltraWinGrid
Imports HRJS.Constant

Public Class frm外协申请一览
#Region "常数定義"

    Public Enum ENU_GRID As Integer
        订单编号 = 0
        产品图号 = 1
    End Enum

#End Region

#Region "変数定義"

    Private mDtSearch As DataTable = Nothing
    Private mDt详细 As DataSet  'grid详细
    Private mstr订单编号 As String = String.Empty


    Public Property 订单编号() As String
        Get
            Return mstr订单编号
        End Get
        Set(ByVal Value As String)
            mstr订单编号 = Value
        End Set
    End Property

#End Region

#Region "Form Event"

    Private Sub frm外协申请一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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

    Private Sub frm外协申请一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm外协申请一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

#Region "订单"
    Private Sub txt订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick
        Dim frmSearch As frm订单一览
        Try

            frmSearch = New frm订单一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号")          '订单编号
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
#Region "产品图号"
    Private Sub txt产品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt产品图号.EditorButtonClick
        Dim frmSearch As frm图纸信息一览
        Try

            frmSearch = New frm图纸信息一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")          '产品图号
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
    Private Sub gridList_InitializeLayout(ByVal sender As Object, ByVal e As InitializeLayoutEventArgs) Handles gridList.InitializeLayout
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
#End Region
    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
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
        If e.Cell.Equals(gridList.ActiveRow.Cells("选择")) Then
            Me.gridList.UpdateData()
        End If
    End Sub
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

    Private Sub btnF12关闭_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF12关闭.Click
        Try


            '关闭画面对话框()

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
            'tudu

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

            'Grid初始化            Me.SetCombo()
            Me.InitGrid()

            '画面の内容を清空処理
            Me.ClearForm()
            Me.txt订单编号.Select()
            '権限の処理
            'Me.''SetPermission()

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
    ''' <summary>
    ''' 権限の制御処理    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPermission()
        'Try

        '    Me.btnF2查询.Enabled = Utility.PFn_GetAuth(Me.btnF2查询.Tag)
        '    Me.btnF3选择.Enabled = Utility.PFn_GetAuth(Me.btnF3选择.Tag)

        'Catch ex As Exception
        '    異常処理()
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    デフォルトのカーソル()
        '    Me.Cursor = Cursors.Default
        'End Try
    End Sub
#End Region
#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try
            'cob外协计划状态.Rows(0).Selected = False
            txt订单编号.Text = String.Empty
            txt产品图号.Text = String.Empty
            txt外协工序.Text = String.Empty
            txt外协申请日期起.Text = DateAdd("M", -1, Now)
            txt外协申请日期止.Text = Date.Now

            Me.txt订单编号.Focus()

            'gridList.DataSource = Nothing
            'Me.cob外协计划状态.Select()
            'InitGrid()

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
            mDtSearch.Columns.Add("订单编号")
            mDtSearch.Columns.Add("主图号")
            mDtSearch.Columns.Add("产品图号")
            mDtSearch.Columns.Add("客户名称")
            mDtSearch.Columns.Add("外协工序")
            mDtSearch.Columns.Add("外协加工数量")
            mDtSearch.Columns.Add("外协计划状态")
            mDtSearch.Columns.Add("外协申请日期")
            mDtSearch.Columns.Add("外协申请理由")
            mDtSearch.Columns.Add("完成日期")
            mDtSearch.Columns.Add("备注")
            mDtSearch.Columns.Add("申请者")

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
#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try

            '外协计划状态
            'Utility.PFn_SetCombo(Me.cob外协计划状态, "VM外协计划状态", 0)

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

            '必須チェック(MsgID=21) 
            If Not String.IsNullOrEmpty(txt外协申请日期起.Text.Trim) And Not String.IsNullOrEmpty(txt外协申请日期止.Text.Trim) Then
                If DateTime.Parse(txt外协申请日期起.DateTime) > DateTime.Parse(txt外协申请日期止.DateTime) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "申请日期", "申请日期")
                    txt外协申请日期起.Focus()
                    Return False
                End If

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

#Region "DataSearch"

    Private Sub DataSearch()

        Dim objB外协申请一览T As B外协申请一览T

        Dim objBLLM外协申请一览T As New BllM外协申请一览T

        Try
            objB外协申请一览T = New B外协申请一览T
            objBLLM外协申请一览T = New BllM外协申请一览T

            objB外协申请一览T.订单编号 = Me.txt订单编号.Text.Trim
            'objB外协申请一览T.外协加工状态 = Me.cob外协计划状态.Text.Trim

            If (Not Me.txt外协申请日期起.Text.Trim = String.Empty) Then
                objB外协申请一览T.外协申请日期起 = Me.txt外协申请日期起.Text.Trim
            Else
                objB外协申请一览T.外协申请日期起 = Constant.CGSTRDATE_DEFAULT
            End If

            If (Not Me.txt外协申请日期止.Text.Trim = String.Empty) Then
                objB外协申请一览T.外协申请日期止 = Me.txt外协申请日期止.Text.Trim
            Else
                objB外协申请一览T.外协申请日期止 = Constant.CGSTRDATE_DEFAULT
            End If

            objB外协申请一览T.产品图号 = Me.txt产品图号.Text.Trim
            objB外协申请一览T.外协工序 = Me.txt外协工序.Text.Trim

            Me.gridList.DataSource = Nothing

            mDtSearch = objBLLM外协申请一览T.Update(objB外协申请一览T)

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
                Me.txt订单编号.Focus()
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
#Region "SetGridStyle"

    Private Sub SetGridStyle()
        Try

            With gridList.DisplayLayout.Bands(0)

                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("选择").CellActivation = Activation.AllowEdit
                .Columns("外协申请日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("外协申请日期").CellActivation = Activation.NoEdit
                .Columns("完成日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("完成日期").CellActivation = Activation.NoEdit
                .Columns("加工数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

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
#Region "Selection"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Selection()

        Dim objBll As New BllM外协申请一览T
        Dim objM外协申请一览T As New B外协申请一览T

        Try
            '选择行が無い場合
            If Me.gridList.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            For intRows = 0 To Me.gridList.Rows.Count - 1
                gridList.Rows(intRows).Cells(0).Value = True
            Next

            objM外协申请一览T.订单编号 = Me.gridList.ActiveRow.Cells("订单编号").Text.Trim
            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objM外协申请一览T)

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

#End Region

End Class