Imports HRJS.Constant
Imports UserControl
Imports System.IO
Public Class frm报废品一览


#Region "变量定义"
    Private mDtSearch As DataTable = Nothing
    Private Z_ReturnTable As DataTable = Nothing
    Private mstr模具编号 As String = String.Empty
    Private mstr模具名称 As String = String.Empty
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("ScrapPath")
    Public Property 模具编号() As String
        Get
            Return mstr模具编号
        End Get
        Set(ByVal Value As String)
            mstr模具编号 = Value
        End Set
    End Property

    Public Property 模具名称() As String
        Get
            Return mstr模具名称
        End Get
        Set(ByVal Value As String)
            mstr模具名称 = Value
        End Set
    End Property

#End Region

#Region "Form Event"

    Private Sub frm报废品一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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
    Private Sub frm报废品一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm报废品一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
#End Region
#Region "Control Event"
    Private Sub txt报废品图号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt报废品图号.Enter

        Try

            Me.txt报废品图号.Tag = Me.txt报废品图号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt报废品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt报废品图号.EditorButtonClick


        Dim frmSearch As frm图纸信息一览
        Try

            frmSearch = New frm图纸信息一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt报废品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")     '产品图号

                    ' Me.txt产品种类名称.Text = frmSearch.ReturnTable.Rows(0)("产品种类名称")     '客户名称


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

    'Private Sub txt报废品图号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt报废品图号.Validating

    '    Dim objM图纸T As M图纸T
    '    Dim dtM图纸T As DataTable
    '    Dim objBllM图纸T As BLLM图纸T

    '    Try

    '        If txt报废品图号.ReadOnly Then
    '            Exit Sub
    '        End If


    '        If Me.txt报废品图号.Text.Trim <> String.Empty Then

    '            If Me.txt报废品图号.Tag = Me.txt报废品图号.Text.Trim Then
    '                Exit Sub
    '            End If
    '            objM图纸T = New M图纸T

    '            objM图纸T.产品图号 = txt报废品图号.Text.Trim

    '            objBllM图纸T = New BLLM图纸T

    '            dtM图纸T = objBllM图纸T.LoadByWhere(objM图纸T)

    '            If dtM图纸T.Rows.Count <> 0 Then

    '                Me.txt报废品图号.Text = dtM图纸T.Rows(0).Item("产品图号").ToString
    '            Else
    '                Me.txt报废品图号.Text = String.Empty
    '                'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID22, "客户名称")
    '                'Me.txt客户编号.Select()
    '            End If
    '        Else
    '            Me.txt报废品图号.Text = String.Empty
    '        End If

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

    Private Sub txt报废品订单编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt报废品订单编号.Enter

        Try

            Me.txt报废品订单编号.Tag = Me.txt报废品订单编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt报废品订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt报废品订单编号.EditorButtonClick


        Dim frmSearch As frm订单一览
        Try

            frmSearch = New frm订单一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt报废品订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号")     '订单编号

                    ' Me.txt产品种类名称.Text = frmSearch.ReturnTable.Rows(0)("产品种类名称")     '客户名称


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

    'Private Sub txt报废品订单编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt报废品订单编号.Validating

    '    Dim objM订单表T As B订单表T
    '    Dim dtM订单表T As DataTable
    '    Dim objBllM订单表T As BllM订单表T

    '    Try

    '        If txt报废品订单编号.ReadOnly Then
    '            Exit Sub
    '        End If


    '        If Me.txt报废品订单编号.Text.Trim <> String.Empty Then

    '            If Me.txt报废品订单编号.Tag = Me.txt报废品订单编号.Text.Trim Then
    '                Exit Sub
    '            End If
    '            objM订单表T = New B订单表T

    '            objM订单表T.产品图号 = txt报废品图号.Text.Trim

    '            objBllM订单表T = New BllM订单表T

    '            dtM订单表T = objBllM订单表T.LoadByWhere(objM订单表T)

    '            If dtM订单表T.Rows.Count <> 0 Then

    '                Me.txt报废品订单编号.Text = dtM订单表T.Rows(0).Item("订单编号").ToString
    '            Else
    '                Me.txt报废品订单编号.Text = String.Empty
    '                'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID22, "客户名称")
    '                'Me.txt客户编号.Select()
    '            End If
    '        Else
    '            Me.txt报废品订单编号.Text = String.Empty
    '        End If

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

    Private Sub txt报废品生产者_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt报废品生产者.Enter

        Try

            Me.txt报废品生产者.Tag = Me.txt报废品生产者.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt报废品生产者_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt报废品生产者.EditorButtonClick


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

                    ' Me.txt报废品生产者.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '客户编号

                    Me.txt报废品生产者.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '人员名                    Me.txt人员名称.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '人员名

                    ' Me.txt使用者部门.Text = frmSearch.ReturnTable.Rows(0)("部门名称")     '部门

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

    Private Sub txt报废品生产者_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt报废品生产者.Validating

        Dim objM人员T As M人员T
        Dim objBllM人员T As BLLM人员T

        Try

            If txt报废品生产者.ReadOnly Then
                Exit Sub
            End If

            If Me.txt报废品生产者.Text.Trim <> String.Empty Then

                If Me.txt报废品生产者.Tag = Me.txt报废品生产者.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt报废品生产者.Text.Trim

                objBllM人员T = New BLLM人员T

                objM人员T = objBllM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员编号 <> "" Then

                    Me.txt报废品生产者.Text = objM人员T.人员名                    Me.txt人员名称.Text = objM人员T.人员名     '部门


                Else
                    ' txt使用者编号.Text = String.Empty
                    Me.txt报废品生产者.Text = String.Empty
                    txt人员名称.Text = String.Empty
                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员姓名")
                    'Me.txt使用者编号.Select()
                End If
            Else
                Me.txt报废品生产者.Text = String.Empty
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
    Private Sub grdList_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles grdList.MouseDown
        Try

            If grdList.ActiveRow Is Nothing Then
                Exit Sub
            End If

            If grdList.ActiveRow.Cells.Count < 10 Then
                Exit Sub
            End If
          

            

            If grdList.ActiveRow.Cells("pic1").Value.ToString & "" <> "" AndAlso File.Exists(strServerPicturePath & grdList.ActiveRow.Cells("pic1").Value.ToString) Then
                SetPictureBoxImage(Me.pic1, strServerPicturePath & grdList.ActiveRow.Cells("pic1").Value.ToString)
            Else
                Me.pic1.Image = Nothing

            End If
            If grdList.ActiveRow.Cells("pic2").Value.ToString & "" <> "" AndAlso File.Exists(strServerPicturePath & grdList.ActiveRow.Cells("pic2").Value.ToString) Then
                SetPictureBoxImage(Me.pic2, strServerPicturePath & grdList.ActiveRow.Cells("pic2").Value.ToString)
            Else
                Me.pic2.Image = Nothing

            End If
            If grdList.ActiveRow.Cells("pic3").Value.ToString & "" <> "" AndAlso File.Exists(strServerPicturePath & grdList.ActiveRow.Cells("pic3").Value.ToString) Then
                SetPictureBoxImage(Me.pic3, strServerPicturePath & grdList.ActiveRow.Cells("pic3").Value.ToString)
            Else
                Me.pic3.Image = Nothing

            End If

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


    'Private Sub grdList_ClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles grdList.ClickCell
    '    'If grdList.ActiveCell.Equals(grdList.ActiveRow.Cells(0)) Then
    '    '    If grdList.ActiveCell.Value = 0 Then
    '    '        grdList.ActiveCell.Value = 1
    '    '    Else
    '    '        grdList.ActiveCell.Value = 0
    '    '    End If
    '    'End If

    '    If e.Cell.Equals(grdList.ActiveRow.Cells(0)) Then
    '        Me.grdList.UpdateData()
    '    End If

    'End Sub

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
            SetGridStyle()

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

#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try

            txt报废品图号.Text = String.Empty
            txt报废品订单编号.Text = String.Empty
            txt报废品生产者.Text = String.Empty
            txt报废品产生工序.Text = String.Empty
            'txt报废日期起.Text = String.Empty
            'txt报废日期止.Text = String.Empty
            Me.txt报废日期起.Text = DateAdd("M", -1, Now)
            Me.txt报废日期止.Text = DateTime.Now.ToString("yyyy/MM/dd")
            Me.pic1.Image = Nothing
            Me.pic2.Image = Nothing
            Me.pic3.Image = Nothing
            Me.txt报废品图号.Focus()

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

            mDtSearch.Columns.Add("报废品图号")
            mDtSearch.Columns.Add("报废品订单编号")
            mDtSearch.Columns.Add("报废品产生工序")
            mDtSearch.Columns.Add("客户名称")

            mDtSearch.Columns.Add("报废品数量")
            mDtSearch.Columns.Add("报废品生产者")
            mDtSearch.Columns.Add("报废日期")

            mDtSearch.Columns.Add("报废原因")
            mDtSearch.Columns.Add("处理结果")
            mDtSearch.Columns.Add("备注")
            mDtSearch.Columns.Add("pic1")
            mDtSearch.Columns.Add("pic2")
            mDtSearch.Columns.Add("pic3")
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
            Me.UcButton1.Enabled = Utility.PFn_GetAuth(Me.UcButton1.Tag)

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

        Dim objBll As New BllM报废品T
        Dim objM报废品T As New B报废品T

        Try

            '一览打开，不做处理            If FormOpenMode = ENU_MODE.Model_NULL Then
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
            objM报废品T.报废品订单编号 = Me.grdList.ActiveRow.Cells("报废品订单编号").Text.Trim

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objM报废品T)


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

        Dim objM报废品T As B报废品T

        Dim objBllM报废品T As New BllM报废品T

        Try
            objM报废品T = New B报废品T

            objM报废品T.报废品图号 = Me.txt报废品图号.Text.Trim
            objM报废品T.报废品订单编号 = Me.txt报废品订单编号.Value
            objM报废品T.报废品生产者 = Me.txt报废品生产者.Value
            objM报废品T.报废品产生工序 = Me.txt报废品产生工序.Value
            objM报废品T.报废日期起 = Me.txt报废日期起.Value
            objM报废品T.报废日期止 = Me.txt报废日期止.Value

            '查询の検索処理


            mDtSearch = objBllM报废品T.LoadByWhere(objM报废品T)


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
                Me.txt报废品图号.Focus()
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
#Region "图片大小设定"
    Friend Sub SetPictureBoxImage(ByVal pb As PictureBox, ByVal sFileName As String)
        '定义一个Bitmap对象作为绘制的接受对象
        Dim bmp As New Bitmap(pb.Width, pb.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        Dim img As Image = Image.FromFile(sFileName)
        Dim rectImage As New Rectangle(0, 0, bmp.Width, bmp.Height)
        '按比例缩放
        GetScaleZoomRect(img.Width, img.Height, rectImage.Width, rectImage.Height)
        g.DrawImage(img, rectImage)

        pb.Image = bmp
    End Sub

    Friend Sub GetScaleZoomRect(ByVal nSrcWidth As Integer, ByVal nSrcHeight As Integer, ByRef nDstWidth As Integer, ByRef nDstHeight As Integer)
        If nSrcWidth / nSrcHeight < nDstWidth / nDstHeight Then
            nDstWidth = nDstHeight * (nSrcWidth / nSrcHeight)
        Else
            nDstHeight = nDstWidth * (nSrcHeight / nSrcWidth)
        End If
    End Sub

#End Region
#Region "SetGridStyle"
    Private Sub SetGridStyle()

        Try
            With grdList.DisplayLayout.Bands(0)
                ' .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("pic1").Hidden = True
                .Columns("pic2").Hidden = True
                .Columns("pic3").Hidden = True
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


End Class