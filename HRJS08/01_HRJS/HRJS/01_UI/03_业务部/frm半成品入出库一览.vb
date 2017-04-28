Imports Infragistics.Win.UltraWinGrid
Imports System.IO

Public Class frm外协品入出库一览
#Region "変数定義"

    Private mDtSearch As DataTable = Nothing

    Private mds详细 As DataSet = Nothing                'grd详细
    Private mdt详细Band0 As DataTable = Nothing                'grd详细
    Private mdt详细Band1 As DataTable = Nothing                'grd详细
    'Private mstr车型库存 As String = String.Empty

#End Region

#Region "Form Event"

    Private Sub frm外协品入库申请一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub frm外协品入出库一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm外协品入出库一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

    Private Sub txt产品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt产品图号.EditorButtonClick


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

                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")

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

    Private Sub txt订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick


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

                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")
                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")

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

    Private Sub btnF11入出库记录导出_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11入出库记录导出.Click

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

#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    ''' 
    Private Sub InitForm()

        Try
            '画面のComboの初期値を設定する
            Me.SetCombo()
            'Grid初始化
            Me.InitGrid()

            'Utility.PFn_SetCombo(cob材料区分, "VM材料区分", 1)

            'Utility.PFn_SetCombo(cob材料类别, "VM材料类别", 1)

            '画面の内容を清空処理
            Me.ClearForm()

            '権限の処理

            'Me.SetPermission()

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

            '交货方式
            Utility.PFn_SetCombo(Me.cbo入出库区分, "VM入出库区分", 0)

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
            mdt详细Band0 = New DataTable

            mdt详细Band0.Columns.Add("入出库区分")
            mdt详细Band0.Columns.Add("客户名称")
            mdt详细Band0.Columns.Add("产品图号")
            mdt详细Band0.Columns.Add("产品名称")
            mdt详细Band0.Columns.Add("订单编号")
            mdt详细Band0.Columns.Add("数量")
            mdt详细Band0.Columns.Add("入出库日期")
            mdt详细Band0.Columns.Add("出库去向")
          grdList.DataSource = mdt详细Band0

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
            Me.cbo入出库区分.Text = String.Empty
            'Me.cbo入出库区分.Rows(0).Selected = True
            txt产品图号.Text = String.Empty
            txt订单编号.Text = String.Empty
            txt客户编号.Text = String.Empty
            txt客户名称.Text = String.Empty
            Me.date开始日期.Text = DateAdd("M", -1, Now)
            Me.date结束日期.Text = DateTime.Now.ToString("yyyy/MM/dd")
            Me.cbo入出库区分.Select()

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
        Dim objBllM入出库记录T As New BLLM外协品入出库记录T
        Dim objM入出库记录T As New B外协品入出库一览T

        Try
            objM入出库记录T = New B外协品入出库一览T
            If Me.cbo入出库区分.Text <> String.Empty Then
                objM入出库记录T.入出库区分 = Me.cbo入出库区分.Value
            End If

            objM入出库记录T.产品图号 = Me.txt产品图号.Text.Trim
            objM入出库记录T.订单编号 = Me.txt订单编号.Text.Trim
            objM入出库记录T.客户编号 = Me.txt客户编号.Text.Trim
            objM入出库记录T.开始日期 = date开始日期.DateTime
            objM入出库记录T.结束日期 = date结束日期.DateTime

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
                Me.cbo入出库区分.Focus()
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