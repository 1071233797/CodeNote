Imports HRJS.Constant
Public Class frm成品盘点管理

#Region "常数定義"

    Public Enum ENU_GRID As Integer
        选择 = 0
        订单编号 = 1
        产品图号 = 2
        产品名称 = 3
        客户名称 = 4
        在库总数量 = 5
        在库总重量 = 6
        盘点总数量 = 7
        盘点总重量 = 8
        差异总数量 = 9
        差异总重量 = 10
        差额调整数量 = 11
        差额调整重量 = 12
        调整后在库数量 = 13
        调整后在库重量 = 14
        入库日期 = 15
        处理方式 = 16
        处理方式1 = 17
        库存状态 = 18
    End Enum
#End Region

#Region "変数定義"

    Private mDtSearch As DataTable = Nothing
    Private mstr产品图号 As String = String.Empty
    Private mstr订单编号 As String = String.Empty
    Public Property 产品图号() As String
        Get
            Return mstr产品图号
        End Get
        Set(ByVal Value As String)
            mstr产品图号 = Value
        End Set
    End Property

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

    Private Sub frm成品盘点管理_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
    Private Sub frm成品盘点管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
    Private Sub frm成品盘点管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

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
                    btnF4保存.Focus()
                    btnF4保存_Click(Nothing, Nothing)

                Case Keys.F11
                    btnF11成品盘点表导出.Focus()
                    btnF11成品盘点表导出_Click(Nothing, Nothing)

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
                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号").ToString        '订单编号

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
                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号").ToString        '产品图号
                    Me.txt产品名称.Text = frmSearch.ReturnTable.Rows(0)("品名").ToString            '品名

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

        Dim objM产品图号T As M图纸T
        Dim objBllM产品图号T As BLLM图纸T

        Try

            If txt产品图号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt产品图号.Text.Trim <> String.Empty Then

                If Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim Then
                    Exit Sub
                End If

                objM产品图号T = New M图纸T

                objM产品图号T.产品图号 = txt产品图号.Text.Trim

                objBllM产品图号T = New BLLM图纸T

                objM产品图号T = objBllM产品图号T.LoadByPKey(objM产品图号T)

                If objM产品图号T.产品图号 <> "" Then

                    Me.txt产品名称.Text = objM产品图号T.品名

                Else
                    Me.txt产品图号.Text = String.Empty
                    Me.txt产品名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "产品图号")
                    Me.txt产品图号.Select()
                End If
            Else
                Me.txt产品名称.Text = String.Empty
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
#Region "客户"
    Private Sub txt客户编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt客户编号.EditorButtonClick
        Dim frmSearch As frm客户一览
        Try

            frmSearch = New frm客户一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号").ToString        '客户编号
                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称").ToString        '客户名称

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

                objM客户T = objBllM客户T.LoadByPKey(objM客户T)

                If objM客户T.客户编号 <> "" Then

                    Me.txt客户名称.Text = objM客户T.客户名称

                Else
                    Me.txt客户编号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "客户名称")
                    Me.txt客户编号.Select()
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
#Region "GRID"
    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdList.InitializeLayout

        Try
            grdList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            grdList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub grdList_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grdList.CellChange

        If grdList.DataSource Is Nothing OrElse grdList.Rows.Count = 0 Then
            Exit Sub
        End If
        grdList.UpdateData()
        '调整数量
        If grdList.ActiveCell.Band.Index = 1 Then
            If grdList.ActiveCell.Column.Index = ENU_GRID.差额调整数量 Then
                If Me.grdList.ActiveRow.Cells(ENU_GRID.处理方式).Value = 1 Then
                    Me.grdList.ActiveRow.Cells(ENU_GRID.调整后在库数量).Value = CInt(Me.grdList.ActiveRow.Cells(ENU_GRID.盘点总数量).Value) + CInt(Me.grdList.ActiveRow.Cells(ENU_GRID.差额调整数量).Value)
                Else
                    If Me.grdList.ActiveRow.Cells(ENU_GRID.处理方式).Value = 2 Then
                        Me.grdList.ActiveRow.Cells(ENU_GRID.调整后在库数量).Value = Me.grdList.ActiveRow.Cells(ENU_GRID.盘点总数量).Value - Me.grdList.ActiveRow.Cells(ENU_GRID.差额调整数量).Value
                    End If
                End If
            End If

            If grdList.ActiveCell.Column.Index = ENU_GRID.差额调整重量 Then
                If Me.grdList.ActiveRow.Cells(ENU_GRID.处理方式1).Value = 1 Then
                    Me.grdList.ActiveRow.Cells(ENU_GRID.调整后在库重量).Value = Me.grdList.ActiveRow.Cells(ENU_GRID.盘点总重量).Value + Me.grdList.ActiveRow.Cells(ENU_GRID.差额调整重量).Value
                Else
                    If Me.grdList.ActiveRow.Cells(ENU_GRID.处理方式).Value = 2 Then
                        Me.grdList.ActiveRow.Cells(ENU_GRID.调整后在库重量).Value = Me.grdList.ActiveRow.Cells(ENU_GRID.盘点总重量).Value - Me.grdList.ActiveRow.Cells(ENU_GRID.差额调整重量).Value
                    End If
                End If
            End If

            Exit Sub

        End If
        Me.grdList.UpdateData()

    End Sub
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
            '    処理終了()
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
            Me.DataSearch("search")

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

    Private Sub btnF4保存_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4保存.Click

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

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF11成品盘点表导出_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11成品盘点表导出.Click

        Try


            'Dim arrayList As New ArrayList

            'For intLoopi = 0 To Me.grdList.Rows.Count - 1
            '    If Me.grdList.Rows(intLoopi).Cells(ENU_GRID.选择).Value = 1 Then
            '        arrayList.Add(Me.grdList.Rows(intLoopi).Cells(ENU_GRID.盘点cd).Value)
            '    End If
            'Next

            ''选择行が無い場合
            'If arrayList.Count = 0 Then
            '    'メッセージ表示
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
            '    '処理終了
            '    Exit Sub
            'End If

            'frmPrint = New frmReportViewer

            'frmPrint.PrintMode = frmReportViewer.ENU_REPORT.库存盘点
            'frmPrint.SearchArrayList = arrayList

            'frmPrint.Show()

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

            Me.SetButtonStatus()
            'Grid初始化
            'Me.InitGrid()

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
                Me.btnF3选择.Visible = True
        End Select
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
            Me.btnF4保存.Enabled = Utility.PFn_GetAuth(Me.btnF4保存.Tag)
            Me.btnF11成品盘点表导出.Enabled = Utility.PFn_GetAuth(Me.btnF11成品盘点表导出.Tag)


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
            Me.txt产品图号.Text = String.Empty
            Me.txt产品名称.Text = String.Empty
            txt客户编号.Text = String.Empty
            txt客户名称.Text = String.Empty
            txt订单编号.Text = String.Empty
            Me.txt发货日期From.Value = DateAdd("M", -1, Now)
            Me.txt发货日期To.Value = DateTime.Now
            ck仅显示差异项.Checked = False
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

            Dim intLoopi As Integer
            'Dim intLoopj As Integer
            'Dim intEditRows As Integer


            If grdList.Rows.Count = 0 Then
                Return False
            End If
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

#Region "Selection"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Selection()

        Dim objBll成品盘点 As New BLLB原材料库存盘点T
        Dim objM成品盘点T As New B原材料库存盘点表T

        Try
            '选择行が無い場合
            If Me.grdList.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            '一览打开，不做处理
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If

            '查询の选择されたレCDを取得する
            objM成品盘点T.材料编号 = Me.grdList.ActiveRow.Cells("材料编号").Text.Trim

            'テーブルにデータを追加
            ReturnTable = objBll成品盘点.LoadAll(objM成品盘点T)

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

    Private Sub DataSearch(Optional ByVal strSearchModel As String = "inti")

        Dim objBll成品盘点 As New BLLB成品库存盘点T
        Dim objM成品盘点T As New B成品库存盘点T

        Try
            'If Not InputCheck() Then
            '    Exit Sub
            'End If
            objM成品盘点T = New B成品库存盘点T
            objBll成品盘点 = New BLLB成品库存盘点T
            If strSearchModel = "init" Then
                objM成品盘点T.入库日期1 = cgstrDATE_EMPTY
                objM成品盘点T.入库日期2 = cgstrDATE_EMPTY
            Else


                objM成品盘点T.产品图号 = txt产品图号.Text.Trim
                objM成品盘点T.订单编号 = txt订单编号.Text.Trim
                objM成品盘点T.客户编号 = txt客户编号.Text.Trim
                objM成品盘点T.入库日期1 = txt发货日期From.Text.Trim
                objM成品盘点T.入库日期2 = txt发货日期To.Text.Trim
                If ck仅显示差异项.Checked = True Then
                    objM成品盘点T.仅显示差异项 = "1"
                Else
                    objM成品盘点T.仅显示差异项 = "0"
                End If
            End If

            mDtSearch = objBll成品盘点.LoadLevel(objM成品盘点T)

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
                Me.txt产品图号.Focus()
                SetGridStyle()
            Else

                '検索データを表示する
                Me.grdList.DataSource = mDtSearch

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

#Region "SaveData"

    Private Sub SaveData()

        Dim objBll As BLLB成品库存盘点T

        Try
            Dim intLoopi As Integer
            Dim arrayList As New ArrayList

            For intLoopi = 0 To grdList.Rows.Count - 1
                Dim objModel As New B成品库存盘点T
                If grdList.Rows(intLoopi).Cells(ENU_GRID.差额调整数量).Value = 0 Then
                    Continue For
                End If
                objModel.产品图号 = grdList.Rows(intLoopi).Cells(ENU_GRID.产品图号).Value
                objModel.订单编号 = grdList.Rows(intLoopi).Cells(ENU_GRID.订单编号).Value
                objModel.调整后在库数量 = grdList.Rows(intLoopi).Cells(ENU_GRID.调整后在库数量).Value
                arrayList.Add(objModel)
            Next

            objBll = New BLLB成品库存盘点T

            If objBll.Update库存调整(arrayList) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                Me.DataSearch("Refresh")
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                Me.grdList.Select()
                Exit Sub
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

                .Columns("选择").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
                .Columns("选择").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
                .Columns("处理方式").Hidden = True
                .Columns("处理方式1").Hidden = True

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
            mDtSearch.Columns.Add("产品图号")
            mDtSearch.Columns.Add("产品名称")
            mDtSearch.Columns.Add("客户名称")
            mDtSearch.Columns.Add("在库总数量(个)")
            mDtSearch.Columns.Add("在库总重量(kg)")
            mDtSearch.Columns.Add("盘点总数量(个)")
            mDtSearch.Columns.Add("盘点总重量(kg)")
            mDtSearch.Columns.Add("差异总数量（个）")
            mDtSearch.Columns.Add("差异总重量（kg）")
            mDtSearch.Columns.Add("差额调整数量(个)")
            mDtSearch.Columns.Add("差额调整重量(kg)")
            mDtSearch.Columns.Add("调整后在库数量(个)")
            mDtSearch.Columns.Add("调整后在库重量(kg)")
            mDtSearch.Columns.Add("入库日期")
            mDtSearch.Columns.Add("处理方式")
            mDtSearch.Columns.Add("处理方式1")
            mDtSearch.Columns.Add("库存状态")

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