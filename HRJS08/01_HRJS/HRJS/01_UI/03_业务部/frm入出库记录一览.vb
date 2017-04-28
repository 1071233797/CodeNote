Imports HRJS.Constant

Public Class frm入出库记录一览#Region "変数定義"

    Private mDtSearch As DataTable = Nothing
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

    Private Sub frm入出库一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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
    Private Sub frm入出库一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm入出库一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                Case Keys.F2
                    btnF2查询.Focus()
                    btnF2查询_Click(Nothing, Nothing)

                    'Case Keys.F3
                    '    btnF3选择.Focus()
                    '    btnF3选择_Click(Nothing, Nothing)

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
                    Me.txt客户编号.Text = String.Empty
                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID22, "客户名称")
                    'Me.txt客户编号.Select()
                End If
            Else
                Me.txt客户编号.Text = String.Empty
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

        Dim frmSearch2 As frm图纸信息一览


        Try


            frmSearch = New frm图纸信息一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '    '根据检索画面数据进行设置


                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")     '客户编号

                    'Me.txt产品名称.Text = frmSearch.ReturnTable.Rows(0)("品名")     '部品名称

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
    'Private Sub txt产品图号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt产品图号.Validating

    '    Dim objM产品T As M图纸T
    '    Dim dtM客户T As DataTable
    '    Dim objBLLM产品T As BLLM图纸T
    '    Try

    '        If txt产品图号.ReadOnly Then
    '            Exit Sub
    '        End If
    '        If Me.txt产品图号.Text.Trim <> String.Empty Then
    '            If Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim Then
    '                Exit Sub
    '            End If
    '        End If


    '        If Me.txt产品图号.Text.Trim <> String.Empty Then

    '            objM产品T = New M图纸T

    '            objM产品T.产品图号 = txt产品图号.Text.Trim

    '            objBLLM产品T = New BLLM图纸T

    '            objM产品T = objBLLM产品T.LoadByPKey(objM产品T)

    '            If objM产品T.产品图号 <> "" Then

    '                Me.txt产品名称.Text = objM产品T.品名
    '            Else
    '                Me.txt产品名称.Text = String.Empty
    '                'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "部品名称")
    '                'Me.txt产品图号.Select()
    '            End If
    '        Else
    '            Me.txt产品名称.Text = String.Empty
    '        End If

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub



#End Region

#Region "订单编号"

    Private Sub txt订单编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt订单编号.Enter

        Try

            Me.txt订单编号.Tag = Me.txt订单编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick


        Dim frmSearch As frm订单一览

        Try
            If txt订单编号.ReadOnly Then
                Exit Sub
            End If


            frmSearch = New frm订单一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号")
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


    'Private Sub txt订单编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt订单编号.Validating

    '    Dim objModel As B订单表T
    '    Dim dtTable As DataTable
    '    Dim objBll As BllM订单表T

    '    Try

    '        If txt订单编号.ReadOnly Then
    '            Exit Sub
    '        End If

    '        If Me.txt订单编号.Tag = Me.txt订单编号.Text.Trim Then
    '            Exit Sub
    '        End If

    '        If Me.txt订单编号.Text.Trim <> String.Empty Then

    '            objModel = New B订单表T

    '            objModel.订单编号 = txt订单编号.Text.Trim
    '            objBll = New BllM订单表T

    '            dtTable = objBll.LoadByWhere(objModel)

    '            If dtTable.Rows.Count <> 0 Then

    '                '出荷明细
    '                'SetGridData()
    '            Else
    '                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "订单编号")
    '                Me.txt订单编号.Select()
    '            End If
    '        Else

    '        End If

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

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

            If Not InputCheck() Then
                Exit Sub
            End If

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

    'Private Sub btnF3选择_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF3选择.Click
    '    Try
    '        '选择処理
    '        Me.Selection()

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

#End Region

#Region "Grid Event"


    Private Sub gridList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid成品入出库一览.InitializeLayout

        Try

            grid成品入出库一览.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub gridList_ClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles grid成品入出库一览.ClickCell
        If e.Cell.Equals(grid成品入出库一览.ActiveRow.Cells(0)) Then
            Me.grid成品入出库一览.UpdateData()
        End If
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
            SetButtonStatus()
            'Grid初始化
            Me.InitGrid()

            '画面の内容を清空処理
            Me.ClearForm()

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
                Me.btnF3选择.Visible = False
        End Select
    End Sub
#End Region

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try
            '制造区分
            Utility.PFn_SetCombo(Me.cmb入出库区分, "VM入出库区分", 0)
            Utility.PFn_SetCombo(Me.cmb订单区分, "VM订单区分", 0)

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

            
            If Me.cmb入出库区分.Value = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "入出库区分", "入出库区分")
                cmb入出库区分.Focus()
                Return False
            End If

            'If Not String.IsNullOrWhiteSpace(dt出荷日期.Text.Trim) And Not String.IsNullOrWhiteSpace(dt出荷日期2.Text.Trim) Then
            '    If DateTime.Parse(dt出荷日期.DateTime) > DateTime.Parse(dt出荷日期2.DateTime) Then
            '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "出荷日期", "出荷日期")
            '        dt出荷日期.Focus()
            '        Return False
            '    End If
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

#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try
            Me.cmb订单区分.Text = String.Empty
            Me.cmb入出库区分.Text = String.Empty
            Me.txt订单编号.Text = String.Empty
            Me.txt产品图号.Text = String.Empty
            Me.txt客户编号.Text = String.Empty
            Me.txt客户名称.Text = String.Empty
            Me.dmt入出库日期end.Text = DateTime.Now
            Me.dmt入出库日期sta.Text = DateAdd("M", -1, Now)


            Me.txt订单编号.Focus()
            Me.txt订单编号.Select()

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
            mDtSearch.Columns.Add("入出库区分")
            mDtSearch.Columns.Add("入出库单号")
            mDtSearch.Columns.Add("订单编号")
            mDtSearch.Columns.Add("产品图号")
            mDtSearch.Columns.Add("产品名称")
            mDtSearch.Columns.Add("订单区分")
            mDtSearch.Columns.Add("客户名称")
            mDtSearch.Columns.Add("产品数量（个）")
            mDtSearch.Columns.Add("库存状态")
            mDtSearch.Columns.Add("入出库日期")
            mDtSearch.Columns.Add("操作者")

            grid成品入出库一览.DataSource = mDtSearch

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
            'Me.btnF11出荷表打印.Enabled = Utility.PFn_GetAuth(Me.btnF11出荷表打印.Tag)
            'Me.btnF4全选.Enabled = Utility.PFn_GetAuth(Me.btnF4全选.Tag)
            'Me.btnF5全解除.Enabled = Utility.PFn_GetAuth(Me.btnF5全解除.Tag)

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

        Dim objModel As B成品入出库一览T

        Dim objBLL As New BLLM成品入出库记录T

        Try

            objModel = New B成品入出库一览T
            If Not IsNothing(Me.cmb订单区分.Value) Then
                objModel.订单区分 = Me.cmb订单区分.Value.ToString()
            End If
            If Not IsNothing(Me.cmb入出库区分.Value) Then
                objModel.入出库区分 = Me.cmb入出库区分.Value.ToString()
            End If
            objModel.产品图号 = Me.txt产品图号.Text.Trim
            objModel.订单编号 = Me.txt订单编号.Text.Trim

            objModel.入出库日期 = Me.dmt入出库日期sta.Text
            objModel.入出库日期1 = Me.dmt入出库日期end.Text
            objModel.客户编号 = txt客户编号.Text.Trim

            '查询の検索処理
            mDtSearch = objBLL.LoadByWhere(objModel)

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.gridList.PClear()
                '検索データを表示する
                Me.grid成品入出库一览.DataSource = mDtSearch

                'フォーカスの設定処理
                Me.txt订单编号.Focus()
            Else

                '検索データを表示する
                Me.grid成品入出库一览.DataSource = mDtSearch

                Me.grid成品入出库一览.Focus()
                Me.grid成品入出库一览.ActiveRow = Me.grid成品入出库一览.Rows(0)
                'SetGridStyle()
            End If

            ''****************************************************
            ''查询の検索処理:件数
            'Dim dtCOUNT As New DataTable

            'dtCOUNT = objBllM部门T.GetGridData(objM部门T, True)

            'Me.gridList.PSummaryFooterCaption(dtCOUNT.Rows.Count)
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

            'With gridList.DisplayLayout.Bands(0)


            '    .Columns("出荷日期").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

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
#End Region
End Class