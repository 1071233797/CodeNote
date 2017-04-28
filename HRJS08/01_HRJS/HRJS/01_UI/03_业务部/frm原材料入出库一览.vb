Imports HRJS.Constant
Imports System.Text
Imports System.IO

Public Class frm原材料入出库一览
#Region "常量定义"

    Public Enum ENU_GRID As Integer
        入出库单号 = 8
    End Enum

#End Region

#Region "变量定义"
    Private mDtSearch As DataTable = Nothing
    Private Z_ReturnTable As DataTable = Nothing
    Private mstr材料编号 As String = String.Empty
    Private mstr材料名称 As String = String.Empty
    Private mstr供应商编码 As String = String.Empty
    Private mstr供应商名称 As String = String.Empty


    Public Property 材料编号() As String
        Get
            Return mstr材料编号
        End Get
        Set(ByVal Value As String)
            mstr材料编号 = Value
        End Set
    End Property

    Public Property 材料名称() As String
        Get
            Return mstr材料名称
        End Get
        Set(ByVal Value As String)
            mstr材料名称 = Value
        End Set
    End Property
    Public Property 供应商编码() As String
        Get
            Return mstr供应商编码
        End Get
        Set(ByVal Value As String)
            mstr供应商编码 = Value
        End Set
    End Property
    Public Property 供应商名称() As String
        Get
            Return mstr供应商名称
        End Get
        Set(ByVal Value As String)
            mstr供应商名称 = Value
        End Set
    End Property
#End Region

#Region "Form Event"

    Private Sub frm入出库记录查询_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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

    Private Sub frm入出库记录查询_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm入出库记录查询_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                Case Keys.F11
                    btnF11入出库记录导出.Focus()
                    btnF11入出库记录导出_Click(Nothing, Nothing)
                    e.Handled = True

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
            ' Me.Selection()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF11入出库记录导出_Click(sender As Object, e As EventArgs) Handles btnF11入出库记录导出.Click

        Dim dialogResult As DialogResult
        Dim fileFullName As String = ""

        Dim strExt As String = ".xlsx"
        Try

            If Me.grdList.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID42, "原材料入出库记录一览") = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            '设置默认路径为当前应用程序根目录
            Me.FolderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory()

            '打开目录选择框
            dialogResult = Me.FolderBrowserDialog.ShowDialog()

            If dialogResult = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            '返回选择路径
            fileFullName = Me.FolderBrowserDialog.SelectedPath & "\原材料入出库记录一览 " & Format(Now(), "yyyy-MM-dd H-mm-ss ffff") & strExt

            'For i = 0 To grdList.Rows.Count - 1

            '    If grdList.Rows(i).Cells("选择").Value = 1 Then

            '        dtReturnTable.ImportRow(Me.mDtSearch.Rows(i))

            '    End If

            'Next

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If Utility.PFn_DataTableToExcel(mDtSearch, fileFullName) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "原材料入出库记录一览")
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "原材料入出库记录一览数据导出")
            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Grid Event"

    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                           Handles grdList.DoubleClickRow

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

    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdList.InitializeLayout

        Try

            grdList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub grdList_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles grdList.KeyDown
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

#Region "Control Event"

#Region "供应商编号"

    Private Sub txt供应商编号_Enter(sender As Object, e As EventArgs) Handles txt供应商编号.Enter

        Try

            Me.txt供应商编号.Tag = Me.txt供应商编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt供应商编号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt供应商编号.EditorButtonClick


        Dim frmSearch As frm供应商一览
        Try

            frmSearch = New frm供应商一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt供应商编号.Text = frmSearch.ReturnTable.Rows(0)("供应商编号")     '供应商编号

                    Me.txt供应商名称.Text = frmSearch.ReturnTable.Rows(0)("供应商名称")     '供应商名称


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


    Private Sub txt供应商编号_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt供应商编号.Validating

        Dim objM供应商T As M供应商T
        Dim dtM供应商T As DataTable
        Dim objBllM供应商T As BLLM供应商T

        Try

            If txt供应商编号.ReadOnly Then
                Exit Sub
            End If


            If Me.txt供应商编号.Text.Trim <> String.Empty Then

                If Me.txt供应商编号.Tag = Me.txt供应商编号.Text.Trim Then
                    Exit Sub
                End If
                objM供应商T = New M供应商T

                objM供应商T.供应商编号 = txt供应商编号.Text.Trim

                objBllM供应商T = New BLLM供应商T

                dtM供应商T = objBllM供应商T.LoadByWhere(objM供应商T)

                If dtM供应商T.Rows.Count <> 0 Then

                    Me.txt供应商名称.Text = dtM供应商T.Rows(0).Item("供应商名称").ToString
                Else
                    Me.txt供应商名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "供应商名称")
                    Me.txt供应商编号.Select()
                End If
            Else
                Me.txt供应商名称.Text = String.Empty
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

#Region "入出库单号"

    Private Sub txt入出库单号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt入出库单号.EditorButtonClick

        Dim frmSearch出库 As frm原材料出库申请一览
        Dim frmSearch入库 As frm原材料入库申请一览
        Try
            If Me.cob入出库区分.Rows(0).Selected = True Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "入出库区分", "入出库区分")
                cob入出库区分.Focus()
                Exit Sub
            Else
                If cob入出库区分.Rows(1).Selected = True Then
                    frmSearch入库 = New frm原材料入库申请一览
                    frmSearch入库.FormOpenMode = Constant.ENU_MODE.Model_Ref
                    frmSearch入库.ShowDialog()

                    '画面数据设置
                    If frmSearch入库.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                        If Not frmSearch入库.ReturnTable Is Nothing AndAlso 0 < frmSearch入库.ReturnTable.Rows.Count Then

                            '根据检索画面数据进行设置
                            Me.txt入出库单号.Text = frmSearch入库.ReturnTable.Rows(0)("申请单编号")     '部品番号

                        End If
                    End If
                Else
                    frmSearch出库 = New frm原材料出库申请一览
                    frmSearch出库.FormOpenMode = Constant.ENU_MODE.Model_Ref
                    frmSearch出库.ShowDialog()

                    '画面数据设置
                    If frmSearch出库.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                        If Not frmSearch出库.ReturnTable Is Nothing AndAlso 0 < frmSearch出库.ReturnTable.Rows.Count Then

                            '根据检索画面数据进行设置
                            Me.txt入出库单号.Text = frmSearch出库.ReturnTable.Rows(0)("申请单编号")     '部品番号

                        End If
                    End If
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
                Me.btnF3选择.Visible = True
        End Select
    End Sub
#End Region

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try

            '制限件数コンボボックス
            Utility.PFn_SetCombo(Me.cob入出库区分, "VM入出库区分", 0)
            'Utility.PFn_SetCombo(Me.cob材料区分, "VM材料区分", 1)

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
            Me.btnF11入出库记录导出.Enabled = Utility.PFn_GetAuth(Me.btnF11入出库记录导出.Tag)
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
            mDtSearch.Columns.Add("订单编号")
            mDtSearch.Columns.Add("材料批号")
            mDtSearch.Columns.Add("入出库单号")
            mDtSearch.Columns.Add("客户名称")
            mDtSearch.Columns.Add("材料名称")
            mDtSearch.Columns.Add("材料区分")
            mDtSearch.Columns.Add("材质/型号")
            mDtSearch.Columns.Add("入出库日期")
            mDtSearch.Columns.Add("入出库区域")
            mDtSearch.Columns.Add("数量（个）")
            mDtSearch.Columns.Add("重量（kg）")
            mDtSearch.Columns.Add("供应商名称")

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

#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try

            'cob入出库区分.Rows(0).Selected = True
            txt入出库单号.Text = String.Empty
            date开始日期.Text = DateAdd("M", -1, Now) 'String.Empty
            date结束日期.Text = DateTime.Now 'String.Empty
            'cob材料区分.Rows(0).Selected = True
            txt原材料编号.Text = String.Empty
            txt原材料名称.Text = String.Empty
            txt供应商编号.Text = String.Empty
            txt供应商名称.Text = String.Empty

            Me.cob入出库区分.Select()

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

        Dim objBll As New BLLM原材料入出库记录T
        Dim objM入出库记录T As New B原材料入出库一览T

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
            objM入出库记录T.入出库记录CD = Me.grdList.ActiveRow.Cells(ENU_GRID.入出库单号).Text.Trim

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objM入出库记录T)

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
        Dim objBllM入出库记录T As New BLLM原材料入出库记录T
        Dim objM入出库记录T As New B原材料入出库一览T
        
        Try
            objM入出库记录T = New B原材料入出库一览T
            If Me.cob入出库区分.Text <> String.Empty Then
                objM入出库记录T.入出库区分 = Me.cob入出库区分.Value
            End If

            objM入出库记录T.入出库申请单编号 = Me.txt入出库单号.Text.Trim
            objM入出库记录T.开始日期 = date开始日期.DateTime
            objM入出库记录T.结束日期 = date结束日期.DateTime
            'If Me.cob材料区分.Text <> String.Empty Then
            '    objM入出库记录T.材料区分 = cob材料区分.Value
            'End If

            objM入出库记录T.供应商编号 = txt供应商编号.Text.Trim
            objM入出库记录T.材料编号 = txt原材料编号.Text.Trim
            '查询の検索処理
            mDtSearch = objBllM入出库记录T.LoadByWhere(objM入出库记录T)

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
                Me.cob入出库区分.Focus()
            Else

                '検索データを表示する
                Me.grdList.DataSource = mDtSearch

                Me.grdList.Focus()
                Me.grdList.ActiveRow = Me.grdList.Rows(0)
            End If

            ''****************************************************
            ''查询の検索処理:件数
            'Dim dtCOUNT As New DataTable

            'dtCOUNT = objBllM部品T.GetGridData(objM部品T, True)

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