﻿Imports HRJS.Constant
Imports UserControl
Public Class frm生产设备一览
#Region "变量定义"
    Private mDtSearch As DataTable = Nothing
    Private Z_ReturnTable As DataTable = Nothing
    Private mstr设备编号 As String = String.Empty
    Private mstr设备名称 As String = String.Empty

    Public Property 设备编号() As String
        Get
            Return mstr设备编号
        End Get
        Set(ByVal Value As String)
            mstr设备编号 = Value
        End Set
    End Property

    Public Property 设备名称() As String
        Get
            Return mstr设备名称
        End Get
        Set(ByVal Value As String)
            mstr设备名称 = Value
        End Set
    End Property

#End Region

#Region "Form Event"

    Private Sub frm设备一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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
    Private Sub frm设备一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm设备一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

#End Region

#Region "Grid Event"

    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdList.DoubleClickRow

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

            grdList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

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


    Private Sub grdList_ClickCell(sender As Object, e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles grdList.ClickCell
        'If grdList.ActiveCell.Equals(grdList.ActiveRow.Cells(0)) Then
        '    If grdList.ActiveCell.Value = 0 Then
        '        grdList.ActiveCell.Value = 1
        '    Else
        '        grdList.ActiveCell.Value = 0
        '    End If
        'End If

        If e.Cell.Equals(grdList.ActiveRow.Cells(0)) Then
            Me.grdList.UpdateData()
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
            'Me.SetCombo()

            'Grid初始化            Me.SetGridStyle()
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

    'Private Sub SetCombo()

    '    Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

    '    Try

    '        '制限件数コンボボックス
    '        Utility.SetCombo设备(Me.cob设备类别, "M设备类别")

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

#End Region

#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try

            txt设备编号.Text = String.Empty
            txt设备名称.Text = String.Empty

            Me.txt设备编号.Focus()

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

            mDtSearch.Columns.Add("设备编号")
            mDtSearch.Columns.Add("设备名称")
            mDtSearch.Columns.Add("设备型号")
            mDtSearch.Columns.Add("维护周期")
            mDtSearch.Columns.Add("上次维护日期")
            mDtSearch.Columns.Add("使用状态")
            mDtSearch.Columns.Add("设备产量")
            mDtSearch.Columns.Add("维护厂商")
            mDtSearch.Columns.Add("维护负责人")
            mDtSearch.Columns.Add("负责人电话")
            mDtSearch.Columns.Add("使用者编号")
            mDtSearch.Columns.Add("使用者姓名")
            mDtSearch.Columns.Add("使用者部门名称")
            mDtSearch.Columns.Add("维护内容")
            mDtSearch.Columns.Add("购买日期")
            grdList.DataSource = mDtSearch
            'grdList.DisplayLayout.Bands(0).Columns(0).Hidden = True

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

        Dim objBll As New BLLM设备T
        Dim objM设备T As New M设备T

        Try

            '一览打开，不做处理            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If


            'If FormOpenMode = Constant.ENU_MODE.Model_Ref Then
            '    ReturnTable = New DataTable()
            '    ReturnTable.Columns.Add("设备编号")
            '    ReturnTable.Columns.Add("设备名称")
            '    ReturnTable.Columns.Add("设备型号")

            '    For i = 0 To grdList.Rows.Count - 1
            '        If grdList.Rows(i).Cells(0).Value = 1 Then
            '            Dim dr As DataRow = ReturnTable.NewRow()
            '            dr("设备编号") = grdList.Rows(i).Cells("设备编号").Value
            '            dr("设备名称") = grdList.Rows(i).Cells("设备名称").Value
            '            dr("设备型号") = grdList.Rows(i).Cells("设备型号").Value
            '            ReturnTable.Rows.Add(dr)
            '        End If
            '    Next

            'Else

            '选择行が無い場合
            If Me.grdList.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If


            If Me.grdList.ActiveRow.Cells("使用状态").Value = "维护中" Then
                MsgBox("该设备正在维护中，不能使用。")
                Exit Sub
            End If


            '查询の选择されたレCDを取得する
            objM设备T.设备编号 = Me.grdList.ActiveRow.Cells("设备编号").Text.Trim

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objM设备T)


            If ReturnTable Is Nothing OrElse ReturnTable.Rows.Count = 0 Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID19)
                Exit Sub
            End If

            'End If

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

        Dim objM设备T As M设备T

        Dim objBllM设备T As New BLLM设备T

        Try
            objM设备T = New M设备T

            objM设备T.设备编号 = Me.txt设备编号.Text.Trim
            objM设备T.设备名称 = Me.txt设备名称.Value

            '查询の検索処理


            mDtSearch = objBllM设备T.LoadByWhere(objM设备T)


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
                Me.txt设备编号.Focus()
            Else

                '検索データを表示する
                Me.grdList.DataSource = mDtSearch
                'If FormOpenMode = Constant.ENU_MODE.Model_Ref Then
                '    grdList.DisplayLayout.Bands(0).Columns(0).Hidden = False
                'End If

  

                'DataCheck()
                grdList.UpdateData()
                Me.grdList.Focus()
                Me.grdList.ActiveRow = Me.grdList.Rows(0)
            End If
            'For index As Integer = 0 To Me.grdList.Rows.Count - 1
            '    If Me.grdList.DataSource.Rows(index).Item("使用状态") = "维护中" Then
            '        Me.grdList.Rows(index).Appearance.BackColor = Color.Red
            '    End If
            'Next
            ''****************************************************
            ''查询の検索処理:件数
            'Dim dtCOUNT As New DataTable

            'dtCOUNT = objBllM设备T.GetGridData(objM设备T, True)

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
    '局右设置
    Private Sub SetGridStyle()
        Try

            With grdList.DisplayLayout.Bands(0)
                .Columns("设备产量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
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