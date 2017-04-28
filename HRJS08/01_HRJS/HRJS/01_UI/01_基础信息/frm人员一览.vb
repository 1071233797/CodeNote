Imports HRJS.Constant
Public Class frm人员一览
#Region "常量定义"

    Public Enum ENU_GRID As Integer
        人员编号 = 1
        人员名称 = 2
    End Enum

#End Region

#Region "变量定义"
    Private mDtSearch As DataTable = Nothing
    Private mstr人员编号 As String = String.Empty
    Private mstr人员名称 As String = String.Empty


    Public Property 人员编号() As String
        Get
            Return mstr人员编号
        End Get
        Set(ByVal Value As String)
            mstr人员编号 = Value
        End Set
    End Property

    Public Property 人员名称() As String
        Get
            Return mstr人员名称
        End Get
        Set(ByVal Value As String)
            mstr人员名称 = Value
        End Set
    End Property

#End Region

#Region "Form Event"

    Private Sub frm人员一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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

    Private Sub frm人员一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm人员一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                Case Keys.F4
                    btnF4全选.Focus()
                    btnF4全选_Click(Nothing, Nothing)


                Case Keys.F5
                    btnF5全解除.Focus()
                    btnF5全解除_Click(Nothing, Nothing)

                Case Keys.F6
                    btnF6删除.Focus()
                    btnF6删除_Click(Nothing, Nothing)

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

#Region "部门编号"

    Private Sub txt部门编号_Enter(sender As Object, e As EventArgs) Handles txt部门编号.Enter

        Try

            Me.txt部门编号.Tag = Me.txt部门编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt部门编号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt部门编号.EditorButtonClick


        Dim frmSearch As frm部门一览

        Try

            frmSearch = New frm部门一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt部门编号.Text = frmSearch.ReturnTable.Rows(0)("部门编号")     '部门编号

                    Me.txt部门名称.Text = frmSearch.ReturnTable.Rows(0)("部门名称")     '客户名称


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

    Private Sub txt部门编号_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt部门编号.Validating

        Dim objM部门T As M部门T
        Dim dtM部门T As DataTable
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt部门编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt部门编号.Text.Trim <> String.Empty Then

                If Me.txt部门编号.Tag = Me.txt部门编号.Text.Trim Then
                    Exit Sub
                End If

                objM部门T = New M部门T

                objM部门T.部门编号 = txt部门编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                dtM部门T = objBLLM人员T.LoadByBM(objM部门T)

                If dtM部门T.Rows.Count <> 0 Then

                    Me.txt部门名称.Text = dtM部门T.Rows(0).Item("部门名称").ToString
                Else
                    Me.txt部门名称.Text = String.Empty
                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID22, "部门名称")
                    'Me.txt部门编号.Select()
                End If
            Else
                Me.txt部门名称.Text = String.Empty
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

    Private Sub btnF1清空_Click(sender As Object, e As EventArgs) Handles btnF1清空.Click
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

    Private Sub btnF4全选_Click(sender As Object, e As EventArgs) Handles btnF4全选.Click
        Dim intRows As Integer

        If Me.grdList.Rows.Count = 0 Then
            Exit Sub
        End If

        For intRows = 0 To Me.grdList.Rows.Count - 1
            grdList.Rows(intRows).Cells(0).Value = 1
        Next
        grdList.UpdateData()
    End Sub

    Private Sub btnF5全解除_Click(sender As Object, e As EventArgs) Handles btnF5全解除.Click
        Dim intRows As Integer

        If Me.grdList.Rows.Count = 0 Then
            Exit Sub
        End If

        For intRows = 0 To Me.grdList.Rows.Count - 1
            grdList.Rows(intRows).Cells(0).Value = 0
        Next
        grdList.UpdateData()
    End Sub

    Private Sub btnF6删除_Click(sender As Object, e As EventArgs) Handles btnF6删除.Click

        Dim intRows As Integer
        Dim str人员编号 As String = ""

        Try

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            If Me.grdList.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Exit Sub
            End If

            For intRows = 0 To Me.grdList.Rows.Count - 1
                If grdList.Rows(intRows).Cells(0).Value = 1 Then
                    'arrayList.Add(grdList.Rows(intRows).Cells(ENU_GRID.人员编号).Value)
                    If str人员编号.Length = 0 Then
                        str人员编号 = Utility.PFn_ChangeQuotation(grdList.Rows(intRows).Cells(ENU_GRID.人员编号).Value)
                    Else
                        str人员编号 = str人员编号 + "," + Utility.PFn_ChangeQuotation(grdList.Rows(intRows).Cells(ENU_GRID.人员编号).Value)
                    End If
                End If
            Next

            If str人员编号.Length = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Exit Sub
            End If

            Dim objBll As New BLLM人员T

            intRows = objBll.DeleteBatch(str人员编号)

            If intRows > 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
                Dim objM人员T As New M人员T
                objM人员T.人员编号 = Me.txt人员编号.Text.Trim
                objM人员T.人员名 = Me.txt人员姓名.Text.Trim
                objM人员T.部门 = Me.txt部门编号.Text.Trim
                Dim dt人员 As New DataTable
                dt人员 = objBll.LoadByWhere(objM人员T)
                grdList.DataSource = dt人员
                If grdList.Rows.Count <> 0 Then
                    Me.DataSearch()
                    Me.grdList.Focus()
                End If
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
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

#Region "Grid Event"

    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                           Handles grdList.DoubleClickRow

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

    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdList.InitializeLayout

        Try
            Dim intLoopi As Integer
            For index = 1 To grdList.DisplayLayout.Bands(0).Columns.Count - 1
                grdList.DisplayLayout.Bands(0).Columns(intLoopi).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Next
            grdList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub grdList_ClickCell(sender As Object, e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles grdList.ClickCell
        If e.Cell.Equals(grdList.ActiveRow.Cells(0)) Then
            Me.grdList.UpdateData()
        End If
    End Sub

    Private Sub grdList_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles grdList.KeyDown
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

#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try
            '画面のComboの初期値を設定する
            'Me.SetCombo()

            'Grid初始化
            Me.InitGrid()

            '画面の内容を清空処理
            Me.ClearForm()
            SetButtonStatus()
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

#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try

            txt人员编号.Text = String.Empty
            txt人员姓名.Text = String.Empty
            txt部门编号.Text = String.Empty
            txt部门名称.Text = String.Empty
            Me.txt人员编号.Focus()

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
            mDtSearch.Columns.Add("人员编号")
            mDtSearch.Columns.Add("人员姓名")
            mDtSearch.Columns.Add("部门名称")
            mDtSearch.Columns.Add("电话号码")
            mDtSearch.Columns.Add("职务")
            mDtSearch.Columns.Add("工种")
            mDtSearch.Columns.Add("入职时间")

            grdList.DataSource = mDtSearch

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
    ''' <summary>
    ''' 権限の制御処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPermission()
        Try

            Me.btnF2查询.Enabled = Utility.PFn_GetAuth(Me.btnF2查询.Tag)
            Me.btnF3选择.Enabled = Utility.PFn_GetAuth(Me.btnF3选择.Tag)
            Me.btnF4全选.Enabled = Utility.PFn_GetAuth(Me.btnF4全选.Tag)
            Me.btnF5全解除.Enabled = Utility.PFn_GetAuth(Me.btnF5全解除.Tag)
            Me.btnF6删除.Enabled = Utility.PFn_GetAuth(Me.btnF6删除.Tag)
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

        Dim objBll As New BLLM人员T
        Dim objM人员T As New M人员T

        Try
            '一览打开，不做处理
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If

            '选择行が無い場合
            If Me.grdList.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            '查询の选择されたレCDを取得する
            objM人员T.人员编号 = Me.grdList.ActiveRow.Cells(ENU_GRID.人员编号).Text.Trim

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objM人员T)

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

        Dim objM人员T As M人员T

        Dim objBllM人员T As New BLLM人员T

        Try
            objM人员T = New M人员T

            objM人员T.人员编号 = Me.txt人员编号.Text.Trim
            objM人员T.人员名 = Me.txt人员姓名.Text.Trim
            objM人员T.部门 = Me.txt部门编号.Text.Trim

            '查询の検索処理
            mDtSearch = objBllM人员T.LoadByWhere(objM人员T)

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grdList.DataSource = mDtSearch

                'フォーカスの設定処理
                Me.txt人员编号.Focus()
            Else

                '検索データを表示する
                Me.grdList.DataSource = mDtSearch

                Me.grdList.Focus()
                Me.grdList.ActiveRow = Me.grdList.Rows(0)
            End If

            ''****************************************************
            ''查询の検索処理:件数
            'Dim dtCOUNT As New DataTable

            'dtCOUNT = objBllM人员T.GetGridData(objM人员T, True)

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

#End Region


End Class