Imports HRJS.Constant
Public Class frm成品库存一览
#Region "変数定義"

    Private mDtSearch As DataTable = Nothing
    Private mds详细 As DataSet = Nothing                'grd详细
    Private mdt详细Band0 As DataTable = Nothing                'grd详细
    Private mdt详细Band1 As DataTable = Nothing                'grd详细
    'Private mstr车型库存 As String = String.Empty

#End Region

#Region "Form Event"

    Private Sub frm成品库存一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try
    End Sub

    Private Sub frm成品库存一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm成品库存一览_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

#End Region

#Region "Button Event"

    Private Sub btnF1清空_Click(sender As Object, e As EventArgs) Handles btnF1清空.Click
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
            'Me.Selection()
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
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs)

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

    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

        Try
            grdList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

            grdList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            grdList.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub grdList_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
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

#Region "Control Event"

#Region "产品图号"

    Private Sub txt产品图号_Enter(sender As Object, e As EventArgs) Handles txt产品图号.Enter

        Try

            Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt产品图号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt产品图号.EditorButtonClick


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

                    Me.txt产品名称.Text = frmSearch.ReturnTable.Rows(0)("品名")     '部品名称

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

    Private Sub txt产品图号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt产品图号.Validating

        Dim objM产品T As M图纸T
        Dim dtM客户T As DataTable
        Dim objBLLM产品T As BLLM图纸T
        Try

            If txt产品图号.ReadOnly Then
                Exit Sub
            End If
            If Me.txt产品图号.Text.Trim <> String.Empty Then
                If Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim Then
                    Exit Sub
                End If
            End If


            If Me.txt产品图号.Text.Trim <> String.Empty Then

                objM产品T = New M图纸T

                objM产品T.产品图号 = txt产品图号.Text.Trim

                objBLLM产品T = New BLLM图纸T

                objM产品T = objBLLM产品T.LoadByPKey(objM产品T)

                If objM产品T.产品图号 <> "" Then

                    Me.txt产品名称.Text = objM产品T.品名
                Else
                    Me.txt产品名称.Text = String.Empty
                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "部品名称")
                    'Me.txt产品图号.Select()
                End If
            Else
                Me.txt产品图号.Text = String.Empty
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

#Region "客户编号"

    Private Sub txt客户编号_Enter(sender As Object, e As EventArgs) Handles txt客户编号.Enter

        Try

            Me.txt客户编号.Tag = Me.txt客户编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt客户编号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt客户编号.EditorButtonClick


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


    Private Sub txt客户编号_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt客户编号.Validating

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

#Region "订单编号"

    Private Sub txt订单编号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick

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

#End Region

#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    ''' 
    Private Sub InitForm()

        Try
            'Grid初始化
            'Me.InitGrid()

            Utility.PFn_SetCombo(Me.cob订单区分, "VM订单区分", 0)

            '画面の内容を清空処理
            Me.ClearForm()

            '権限の処理
            Me.SetButtonStatus()
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

            If cob订单区分.Rows.Count > 0 Then
                cob订单区分.Rows(0).Selected = True
            End If

            txt产品图号.Text = String.Empty
            txt产品名称.Text = String.Empty
            txt客户编号.Text = String.Empty
            txt客户名称.Text = String.Empty
            txt订单编号.Text = String.Empty
            txt发货日期From.Text = DateAdd("M", -1, Now)
            txt发货日期To.Text = DateTime.Now
            Me.txt产品图号.Select()

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

            If Not String.IsNullOrEmpty(txt发货日期From.Text.Trim) And Not String.IsNullOrEmpty(txt发货日期To.Text.Trim) Then
                If DateTime.Parse(txt发货日期From.DateTime) > DateTime.Parse(txt发货日期To.DateTime) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "发货日期", "发货日期")
                    txt发货日期From.Focus()
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

#Region "Selection"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Selection()

        Dim objBll As New BLLM成品库存T
        Dim objCls As New B成品库存T
        Try
            '选择行が無い場合
            If Me.grdList.ActiveRow Is Nothing Then
                'メッセージ表示
                'CommonMsg.ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID25)
                '処理終了
                Exit Sub
            End If

            '查询の选择されたレCDを取得する
            objCls.产品图号 = Me.grdList.ActiveRow.Cells("产品图号").Text.Trim

            'テーブルにデータを追加

            ReturnTable = objBll.LoadAll(objCls)

            If ReturnTable Is Nothing OrElse ReturnTable.Rows.Count = 0 Then
                'メッセージ表示

                'CommonMsg.ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID26)
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

    Private Sub DataSearch(Optional ByVal strSearchModel As String = "inti")

        Dim objBll成品库存 As New BLLM成品库存T
        Dim objM成品库存T As New B成品库存T

        Try

            objM成品库存T = New B成品库存T
            objBll成品库存 = New BLLM成品库存T
            'If strSearchModel = "init" Then
            '    objM成品库存T.发货日期From = cgstrDATE_EMPTY
            '    objM成品库存T.发货日期To = cgstrDATE_EMPTY
            'Else
            If cob订单区分.Text.Trim = String.Empty Then
                objM成品库存T.订单区分 = String.Empty
            Else
                objM成品库存T.订单区分 = cob订单区分.Value
            End If
            objM成品库存T.客户编号 = txt客户编号.Text.Trim
            objM成品库存T.订单编号 = txt订单编号.Text.Trim
            objM成品库存T.产品图号 = txt产品图号.Text.Trim
            objM成品库存T.发货日期From = Me.txt发货日期From.Text
            objM成品库存T.发货日期To = Me.txt发货日期To.Text


            'End If

            Me.grdList.DataSource = Nothing

            mds详细 = New DataSet

            'mdt详细Band0データを記録テーブル初期化

            Me.mdt详细Band0 = New DataTable
            mdt详细Band0 = objBll成品库存.LoadLevel0(objM成品库存T)

            'mdt详细Band1データを記録テーブル初期化

            Me.mdt详细Band1 = New DataTable
            mdt详细Band1 = objBll成品库存.LoadLevel1(objM成品库存T)

            ''------------------------------------------

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(2) As DataRelation

            mds详细 = New DataSet
            'DataSetの親子関係を設定
            mds详细.Relations.Clear()  '两者的关系清空

            '親、子のテーブルを追加
            mdt详细Band0.TableName = "详细Band0"
            mds详细.Tables.Add(mdt详细Band0)

            mdt详细Band1.TableName = "详细Band1"
            mds详细.Tables.Add(mdt详细Band1)


            ReDim parentCols(0) '声明数组
            ReDim childCols(0)

            parentCols(0) = mds详细.Tables(0).Columns("订单编号")
            childCols(0) = mds详细.Tables(1).Columns("订单编号")
            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mds详细.Relations.Add(drBand(0))

            Me.grdList.DataSource = mds详细
            grdList.Refresh()

            If mdt详细Band0 Is Nothing OrElse mdt详细Band0.Rows.Count = 0 Then
                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grdList.DataSource = mds详细
                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default
                If strSearchModel <> "init" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                End If
                'フォーカスの設定処理
                Me.txt产品图号.Focus()
            Else

                '検索データを表示する
                Me.grdList.DataSource = mds详细

                Me.grdList.Focus()
                Me.grdList.ActiveRow = Me.grdList.Rows(0)
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
            With grdList.DisplayLayout.Bands(0)

                .Columns("发货日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("发货日期").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit


            End With
            With grdList.DisplayLayout.Bands(1)


                .Columns("在库数量(个)").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("在库重量(kg)").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("入库日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("入库日期").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
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

#Region "InitGrid"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitGrid()
        Try

            mDtSearch = New DataTable
            mDtSearch.Columns.Add("订单编号")
            mDtSearch.Columns.Add("订单区分")
            mDtSearch.Columns.Add("客户名称")
            mDtSearch.Columns.Add("发货日期")

            grdList.DataSource = mDtSearch

            'If Not Me.gridlist.DataSource Is Nothing OrElse Me.gridlist.Rows.Count > 0 Then
            '    Me.gridlist.DataSource.clear()
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

#End Region

End Class