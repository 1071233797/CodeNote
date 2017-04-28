Imports System.IO

Public Class frm包装实绩一览#Region "常数定義"

    Public Enum ENU_GRID As Integer
        订单编号 = 0
        产品图号 = 1

    End Enum

#End Region

#Region "変数定義"

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

    Private Sub frm包装实绩一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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
    Private Sub frm包装实绩一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm包装实绩一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
                    Me.txt品名.Text = frmSearch.ReturnTable.Rows(0)("品名").ToString        '产品名称

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
    Private Sub txt产品图号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt产品图号.Leave
        Dim objM图纸T As M图纸T
        Dim objBLLM图纸T As BLLM图纸T

        Try

            If txt产品图号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt产品图号.Text.Trim <> String.Empty Then

                If Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim Then
                    Exit Sub
                End If

                objM图纸T = New M图纸T

                objM图纸T.产品图号 = txt产品图号.Text.Trim

                objBLLM图纸T = New BLLM图纸T

                objM图纸T = objBLLM图纸T.LoadByPKey(objM图纸T)

                If objM图纸T.品名 <> String.Empty Then

                    Me.txt品名.Text = objM图纸T.品名     '客户名称

                Else
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "图纸")
                    Me.txt品名.Text = String.Empty
                    Me.txt作业者编号.Select()
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

#Region "部门"
    Private Sub txt部门编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt部门编号.EditorButtonClick
        Dim frmSearch As frm部门一览
        Try

            frmSearch = New frm部门一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt部门编号.Text = frmSearch.ReturnTable.Rows(0)("部门编号").ToString        '部门编号
                    Me.txt部门名称.Text = frmSearch.ReturnTable.Rows(0)("部门名称").ToString        '部门名称

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
    Private Sub txt部门编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt部门编号.Leave
        Dim objM部门T As M部门T
        Dim objBLLM部门T As BLLM部门T

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

                objBLLM部门T = New BLLM部门T

                objM部门T = objBLLM部门T.LoadByPKey(objM部门T)

                If objM部门T.部门名称 <> String.Empty Then

                    Me.txt部门名称.Text = objM部门T.部门名称     '客户名称

                Else
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "部门")
                    Me.txt部门名称.Text = String.Empty
                    Me.cmb作业方式.Select()
                End If
            Else
                Me.txt部门编号.Text = String.Empty
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#Region "人员"
    Private Sub txt作业者编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt作业者编号.EditorButtonClick
        Dim frmSearch As frm人员一览
        Try

            frmSearch = New frm人员一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt作业者编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号").ToString        '部门编号
                    Me.txt作业者名称.Text = frmSearch.ReturnTable.Rows(0)("人员名").ToString        '部门名称

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
    Private Sub txt作业者编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt作业者编号.Leave
        Dim objM人员T As M人员T
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt作业者编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt作业者编号.Text.Trim <> String.Empty Then

                If Me.txt作业者编号.Tag = Me.txt作业者编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt作业者编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                objM人员T = objBLLM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员名 <> String.Empty Then


                    Me.txt作业者名称.Text = objM人员T.人员名     '客户名称

                    'Me.txt职务.Text = objM人员T.职务

                    'Me.txt部门.Text = objM人员T.部门

                    'Me.dt申请日期.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt作业者名称.Text = String.Empty
                    Me.txt作业者编号.Select()
                End If
            Else
                Me.txt作业者编号.Text = String.Empty
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

    Private Sub btn导出_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn导出.Click

        Dim dialogResult As DialogResult
        Dim fileFullName As String = ""

        Dim strExt As String = ".xlsx"
        Try

            If Me.grid包装实际一览.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID42, "包装实绩一览") = Constant.ENU_SHOWMSG.showMsgNo Then
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
            fileFullName = Me.FolderBrowserDialog.SelectedPath & "\包装实绩一览 " & Format(Now(), "yyyy-MM-dd H-mm-ss ffff") & strExt

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If Utility.PFn_DataTableToExcel(mDtSearch, fileFullName) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "包装实绩一览")
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "包装实绩一览数据导出")
            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Grid Event"

    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                           Handles grid包装实际一览.DoubleClickRow

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

    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid包装实际一览.InitializeLayout

        Try

            grid包装实际一览.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

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
            Me.SetCombo()

            'Grid初始化

            Me.InitGrid()

            '画面の内容を清空処理
            Me.ClearForm()
            Me.txt部门编号.Select()
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

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try

            '交货方式
            Utility.PFn_SetCombo(Me.cmb作业方式, "VM作业方式", 0)

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

            txt部门编号.Text = String.Empty
            txt部门名称.Text = String.Empty
            txt作业者编号.Text = String.Empty
            txt作业者名称.Text = String.Empty
            txt订单编号.Text = String.Empty
            txt产品图号.Text = String.Empty
            cmb作业方式.Text = String.Empty
            txt品名.Text = String.Empty
            dmt作业日期sta.Text = DateAdd("M", -1, Now)
            dmt作业日期end.Text = DateAdd("M", +1, Now)

            Me.txt部门编号.Focus()

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
            mDtSearch.Columns.Add("作业者")
            mDtSearch.Columns.Add("部门名称")
            mDtSearch.Columns.Add("作业方式")
            mDtSearch.Columns.Add("作业开始日期")
            mDtSearch.Columns.Add("作业完成日期")
            mDtSearch.Columns.Add("计划生产数量")
            mDtSearch.Columns.Add("实际生产数量")
            grid包装实际一览.DataSource = mDtSearch

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
            Me.btn导出.Enabled = Utility.PFn_GetAuth(Me.btn导出.Tag)

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

        Dim objBll As New BLLZ包装实际管理T
        Dim objZ包装实际T As New Z包装实际管理T


        Try
            '选择行が無い場合
            If Me.grid包装实际一览.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objZ包装实际T.订单编号 = Me.grid包装实际一览.ActiveRow.Cells("订单编号").Text.Trim
            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objZ包装实际T)

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

        Dim objZ包装实际T As Z包装实际管理T

        Dim objBllZ包装实际T As New BLLZ包装实际管理T

        Try
            objZ包装实际T = New Z包装实际管理T
            objZ包装实际T.部门编号 = Me.txt部门编号.Text.Trim
            objZ包装实际T.作业方式 = Me.cmb作业方式.Text.Trim
            objZ包装实际T.作业者 = Me.txt作业者编号.Text.Trim
            If (Not Me.dmt作业日期sta.Text.Trim = String.Empty) Then
                objZ包装实际T.作业开始时间 = Me.dmt作业日期sta.Text.Trim
            Else
                objZ包装实际T.作业开始时间 = Constant.CGSTRDATE_DEFAULT
            End If

            If (Not Me.dmt作业日期end.Text.Trim = String.Empty) Then
                objZ包装实际T.作业完成时间 = Me.dmt作业日期end.Text.Trim
            Else
                objZ包装实际T.作业完成时间 = Constant.CGSTRDATE_DEFAULT
            End If
            objZ包装实际T.订单编号 = Me.txt订单编号.Text.Trim
            objZ包装实际T.产品图号 = Me.txt产品图号.Text.Trim

            '查询の検索処理

            mDtSearch = objBllZ包装实际T.LoadByWhere(objZ包装实际T)

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力

                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grid包装实际一览.DataSource = mDtSearch

                'フォーカスの設定処理
                Me.txt部门编号.Focus()
            Else

                '検索データを表示する
                Me.grid包装实际一览.DataSource = mDtSearch

                Me.grid包装实际一览.Focus()
                Me.grid包装实际一览.ActiveRow = Me.grid包装实际一览.Rows(0)
            End If

            ''****************************************************
            ''查询の検索処理:件数
            'Dim dtCOUNT As New DataTable

            'dtCOUNT = objBllM部门T.GetGridData(objM部门T, True)

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