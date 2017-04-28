Imports HRJS.Constant

Public Class frm原材料盘点管理
#Region "常数定義"

    Public Enum ENU_GRID As Integer
        选择 = 0
        材料编号 = 1
        材料名称 = 2
        材料区分 = 3
        材质 = 4
        在库总数量 = 5
        在库总重量 = 6
        盘点总数量 = 7
        盘点总重量 = 8
        差异总数量 = 9
        差异总重量 = 10
    End Enum

    Public Enum ENU_GRID2 As Integer
        材料批号 = 0
        在库数量 = 1
        在库重量 = 2
        入库日期 = 3
        盘点数量 = 4
        盘点重量 = 5
        盘点日期 = 6
        差异数量 = 7
        差异重量 = 8
        差额调整数量 = 9
        差额调整重量 = 10
        处理方式 = 11
        调整后在库数量 = 12
        调整后在库重量 = 13
        备注 = 14
        盘点CD = 15
        材料编号 = 16
    End Enum


    Private mds详细 As DataSet = Nothing                'grdList
    Private mdt详细Band0 As DataTable = Nothing                'grdList
    Private mdt详细Band1 As DataTable = Nothing                'grdList
#End Region

#Region "変数定義"

    Private mDtSearch As DataTable = Nothing
    Private mstr材料编号 As String = String.Empty


    Public Property 材料编号() As String
        Get
            Return mstr材料编号
        End Get
        Set(ByVal Value As String)
            mstr材料编号 = Value
        End Set
    End Property

#End Region

#Region "Form Event"

    Private Sub frm原材料盘点管理_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
    Private Sub frm原材料盘点管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
    Private Sub frm原材料盘点管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

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
                    btnF11原材料盘点表打印.Focus()
                    btnF11原材料盘点表打印_Click(Nothing, Nothing)

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

#Region "原材料编号"

    Private Sub txt原材料编号_Enter(sender As Object, e As EventArgs) Handles txt原材料编号.Enter

        Try

            Me.txt原材料编号.Tag = Me.txt原材料编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt原材料编号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt原材料编号.EditorButtonClick
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
    Private Sub txt原材料编号_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt原材料编号.Validating
        Dim objM原材料T As M原材料信息T
        Dim dtM原材料T As DataTable
        Dim objBllM原材料T As BLLM原材料信息T

        Try

            If txt原材料编号.ReadOnly Then
                Exit Sub
            End If


            If Me.txt原材料编号.Text.Trim <> String.Empty Then

                If Me.txt原材料编号.Tag = Me.txt原材料编号.Text.Trim Then
                    Exit Sub
                End If
                objM原材料T = New M原材料信息T

                objM原材料T.原材料编号 = txt原材料编号.Text.Trim

                objBllM原材料T = New BLLM原材料信息T

                dtM原材料T = objBllM原材料T.LoadByWhere(objM原材料T)

                If dtM原材料T.Rows.Count <> 0 Then

                    Me.txt原材料名称.Text = dtM原材料T.Rows(0).Item("原材料名称").ToString
                Else
                    Me.txt原材料名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "原材料名称")
                    Me.txt原材料编号.Select()
                End If
            Else
                Me.txt原材料名称.Text = String.Empty
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
            '清空画面对话框
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If
            ClearForm()
            Me.DataSearch("init")
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
        'Try
        '    '选择処理
        '    Me.Selection()

        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try
    End Sub

    Private Sub btnF4保存_Click(sender As Object, e As EventArgs) Handles btnF4保存.Click

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

    Private Sub btnF11原材料盘点表打印_Click(sender As Object, e As EventArgs) Handles btnF11原材料盘点表打印.Click

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

#Region "Grid Event"

    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                           Handles grdList.DoubleClickRow

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

    Private Sub grdList_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles grdList.KeyDown
        'Try

        '    If grdList.ActiveCell.Equals(grdList.Rows(grdList.Rows.Count - 1).Cells(ENU_GRID2.备注)) Then
        '        Exit Sub
        '    End If

        '    If e.KeyCode = Keys.Enter Then
        '        e.Handled = True
        '        SendKeys.Send("{TAB}")
        '    End If

        '    Select Case FormOpenMode

        '        Case Constant.ENU_MODE.Model_Search
        '            '选择処理
        '            'Me.Selection()
        '    End Select

        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try

    End Sub

    Private Sub grdList_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grdList.CellChange

        If grdList.DataSource Is Nothing OrElse grdList.Rows.Count = 0 Then
            Exit Sub
        End If
        grdList.UpdateData()
        '调整数量
        If grdList.ActiveCell.Band.Index = 1 Then
            If grdList.ActiveCell.Column.Index = ENU_GRID2.差额调整数量 Then
                If Me.grdList.ActiveRow.Cells(ENU_GRID2.处理方式).Value = 1 Then
                    Me.grdList.ActiveRow.Cells(ENU_GRID2.调整后在库数量).Value = CInt(Me.grdList.ActiveRow.Cells(ENU_GRID2.盘点数量).Value) + CInt(Me.grdList.ActiveRow.Cells(ENU_GRID2.差额调整数量).Value)
                Else
                    If Me.grdList.ActiveRow.Cells(ENU_GRID2.处理方式).Value = 2 Then
                        Me.grdList.ActiveRow.Cells(ENU_GRID2.调整后在库数量).Value = Me.grdList.ActiveRow.Cells(ENU_GRID2.盘点数量).Value - Me.grdList.ActiveRow.Cells(ENU_GRID2.差额调整数量).Value
                    End If
                End If
            End If

            If grdList.ActiveCell.Column.Index = ENU_GRID2.差额调整重量 Then
                If Me.grdList.ActiveRow.Cells(ENU_GRID2.处理方式).Value = 1 Then
                    Me.grdList.ActiveRow.Cells(ENU_GRID2.调整后在库重量).Value = Me.grdList.ActiveRow.Cells(ENU_GRID2.盘点重量).Value + Me.grdList.ActiveRow.Cells(ENU_GRID2.差额调整重量).Value
                Else
                    If Me.grdList.ActiveRow.Cells(ENU_GRID2.处理方式).Value = 2 Then
                        Me.grdList.ActiveRow.Cells(ENU_GRID2.调整后在库重量).Value = Me.grdList.ActiveRow.Cells(ENU_GRID2.盘点重量).Value - Me.grdList.ActiveRow.Cells(ENU_GRID2.差额调整重量).Value
                    End If
                End If
            End If

            Exit Sub

        End If
        Me.grdList.UpdateData()

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

            SetCombo()

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

#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try
            Me.txt原材料编号.Text = String.Empty
            Me.txt原材料名称.Text = String.Empty
            If Me.cob材料区分.Rows.Count > 0 Then
                Me.cob材料区分.Value = String.Empty
            End If
            Me.dt盘点日期To.Text = Date.Now
            Me.dt盘点日期From.Text = DateAdd("M", -1, Now)
            ck仅显示差异项.Checked = False
            Me.txt原材料编号.Select()
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
            '使用状态
            Utility.PFn_SetCombo(Me.cob材料区分, "VM材料区分", 0)
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
            Me.btnF4保存.Enabled = Utility.PFn_GetAuth(Me.btnF4保存.Tag)
            Me.btnF11原材料盘点表打印.Enabled = Utility.PFn_GetAuth(Me.btnF11原材料盘点表打印.Tag)


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
            If Not String.IsNullOrEmpty(dt盘点日期From.Text.Trim) And Not String.IsNullOrEmpty(dt盘点日期To.Text.Trim) Then
                If DateTime.Parse(dt盘点日期From.DateTime) > DateTime.Parse(dt盘点日期To.DateTime) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "盘点日期", "盘点日期")
                    dt盘点日期From.Focus()
                    Return False
                End If
            End If
            For intLoopi = 0 To grdList.Rows.Count - 1
                'If grdList.Rows(intLoopi).Cells(ENU_GRID.选择).Value = 0 Then
                '    Continue For
                'End If
                'For intEditRows = 0 To grdList.Rows(intLoopi).ChildBands(0).Rows.Count - 1
                '    If grdList.Rows(intLoopi).ChildBands(0).Rows(intEditRows).Cells(ENU_GRID2.处理方式).Value.ToString = "" Then
                '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "处理方式", "库存盘点")
                '        Me.grdList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID2.处理方式).Activated = True
                '        Me.grdList.Select()
                '        Return False
                '    End If

                '    '    If grdList.Rows(intLoopi).ChildBands(0).Rows(intLoopj).Cells(ENU_GRID2.调整数量).Value = 0 Then
                '    '        Continue For
                '    '    Else
                '    '        intEditRows += 1
                '    '    End If
                'Next
            Next

            'If intEditRows = 0 Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID43)
            '    Return False
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

#Region "BindGridCombox"
    Private Sub BindGridCombox(Optional ByVal intRowIndex As Integer = 0)

        Try
            Utility.PFn_SetGirdCombo(Me.grdList, "VM盘点处理方式", ENU_GRID2.处理方式)
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "DataSearch"

    Private Sub DataSearch(Optional ByVal strSearchModel As String = "inti")

        Dim objBll原材料盘点 As New BLLB原材料库存盘点T
        Dim objM原材料盘点T As New B原材料库存盘点表T

        Try
            If Not InputCheck() Then
                Exit Sub
            End If
            objM原材料盘点T = New B原材料库存盘点表T
            objBll原材料盘点 = New BLLB原材料库存盘点T
            If strSearchModel = "init" Then
                objM原材料盘点T.盘点日期From = cgstrDATE_EMPTY
                objM原材料盘点T.盘点日期To = cgstrDATE_EMPTY
            Else
                If cob材料区分.Text.Trim = String.Empty Then
                    objM原材料盘点T.材料区分 = String.Empty
                Else
                    objM原材料盘点T.材料区分 = cob材料区分.Value
                End If

                objM原材料盘点T.材料编号 = txt原材料编号.Text.Trim
                objM原材料盘点T.盘点日期From = dt盘点日期From.DateTime
                objM原材料盘点T.盘点日期To = dt盘点日期To.DateTime
                If ck仅显示差异项.Checked = True Then
                    objM原材料盘点T.仅显示差异项 = "1"
                Else
                    objM原材料盘点T.仅显示差异项 = "0"
                End If
            End If

            Me.grdList.DataSource = Nothing

            mds详细 = New DataSet

            'mdt详细Band0データを記録テーブル初期化

            Me.mdt详细Band0 = New DataTable
            mdt详细Band0 = objBll原材料盘点.LoadLevel0(objM原材料盘点T)

            'mdt详细Band1データを記録テーブル初期化

            Me.mdt详细Band1 = New DataTable
            mdt详细Band1 = objBll原材料盘点.LoadLevel1(objM原材料盘点T)

            ''------------------------------------------

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(1) As DataRelation

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

            parentCols(0) = mds详细.Tables(0).Columns("材料编号")
            childCols(0) = mds详细.Tables(1).Columns("材料编号")

            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mds详细.Relations.Add(drBand(0))


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
                Me.txt原材料编号.Focus()
            Else

                '検索データを表示する
                Me.grdList.DataSource = mds详细

                Me.BindGridCombox()
                'Dim intLoopi As Integer

                'For intLoopi = 0 To grdList.DisplayLayout.Bands(0).Columns.Count - 1
                '    Me.grdList.DisplayLayout.Bands(0).Columns(intLoopi).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                '    Me.grdList.DisplayLayout.Bands(0).Columns(intLoopi).TabStop = False
                'Next
                'For intLoopi = 0 To Me.grdList.ActiveRow.ChildBands(0).Rows.Count - 1
                    Me.grdList.DisplayLayout.Bands(1).Columns(ENU_GRID2.处理方式).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                    Me.grdList.DisplayLayout.Bands(1).Columns(ENU_GRID2.处理方式).TabStop = False
                'Next

                Me.grdList.Focus()
                Me.grdList.ActiveRow = Me.grdList.Rows(0)
                SetGridStyle()
            End If

            'Me.grdList.DisplayLayout.Bands(1).Columns(ENU_GRID2.盘点CD).Hidden = True
            'Me.grdList.DisplayLayout.Bands(1).Columns(ENU_GRID2.材料编号).Hidden = True

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

        Dim objBll As BLLB原材料库存盘点T

        Try

            Dim arrayList As New ArrayList

            For i = 0 To grdList.Rows.Count - 1

                For j = 0 To grdList.Rows(i).ChildBands(0).Rows.Count - 1
                    If grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_GRID2.差额调整数量).Value = 0 Then
                        Continue For
                    End If
                    Dim objModel As New B原材料库存盘点表T
                    objModel.材料编号 = grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_GRID2.材料编号).Value
                    objModel.材料批号 = grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_GRID2.材料批号).Value

                    'objModel.处理方式 = grdList.Rows(intLoopi).Cells(ENU_GRID2.处理方式).Value
                    objModel.调整后在库数量 = grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_GRID2.调整后在库数量).Value.ToString
                    objModel.调整后在库重量 = grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_GRID2.调整后在库重量).Value.ToString
                    objModel.盘点人编号 = gObjM_人员T.人员编号
                    objModel.调整日期 = DateTime.Now
                    arrayList.Add(objModel)
                Next
            Next
            objBll = New BLLB原材料库存盘点T

            If objBll.Insert库存调整(arrayList) > 0 Then

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
                .Columns("在库总数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("在库总重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("盘点总数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("盘点总重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("差异总数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("差异总重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            End With
            With grdList.DisplayLayout.Bands(1)


                .Columns("在库数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("在库重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("入库日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("盘点日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("盘点数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("盘点重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("差异数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("差异重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("差额调整数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("差额调整重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("调整后在库数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("调整后在库重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("盘点CD").Hidden = True
                .Columns("材料编号").Hidden = True

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