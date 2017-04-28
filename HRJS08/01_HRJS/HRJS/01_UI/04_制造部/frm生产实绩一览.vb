Imports HRJS.Constant

Imports Infragistics.Win.UltraWinGrid
Imports System.IO

Public Class frm生产实绩一览
#Region "常数定義"

    Public Enum ENU_GRID As Integer
        作业者 = 0
        作业日期 = 1
        作业方式 = 2
        作业时间 = 3
        订单编号 = 4
        产品图号 = 5
        计划生产数量 = 6
        实际生产数量 = 7
        设备编号 = 8
        本道工序 = 9
        上道工序 = 10
        下道工序 = 11
        完成日期 = 12

    End Enum

#End Region

#Region "変数定義"

    Private mDtSearch As DataTable = Nothing
    Private mdsInfoDataSet As DataTable
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

    Private Sub frm生产实绩一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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
    Private Sub frm生产实绩一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm生产实绩一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                    'Case Keys.F11
                    '    btnF11生产数据导出.Focus()
                    '    btnF11生产数据导出_Click(Nothing, Nothing)

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
                    Me.txt产品名称.Text = frmSearch.ReturnTable.Rows(0)("品名").ToString        '产品名称

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
        Dim dtM图纸T As DataTable
        Dim objBllM图纸T As BLLM图纸T

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

                objBllM图纸T = New BLLM图纸T

                objM产品图号T = objBllM图纸T.LoadByPKey(objM产品图号T)

                If objM产品图号T.产品图号 <> String.Empty Then

                    Me.txt产品名称.Text = objM产品图号T.品名


                Else
                    Me.txt产品图号.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "供应商编号")
                    Me.txt产品图号.Select()
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
                    Me.txt作业者编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号").ToString        '人员编号
                    Me.txt作业者名称.Text = frmSearch.ReturnTable.Rows(0)("人员名").ToString        '人员名
                    'Me.txt部门名称.Text = frmSearch.ReturnTable.Rows(0)("部门").ToString        '部门名称
                    SetData()
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
    Private Sub txt作业者编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt作业者编号.Validating

        Dim objM人员T As M人员T
        Dim dtM人员T As DataTable
        Dim objBllM人员T As BLLM人员T

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

                objBllM人员T = New BLLM人员T

                objM人员T = objBllM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员编号 <> String.Empty Then

                    Me.txt作业者名称.Text = objM人员T.人员名

                Else
                    Me.txt作业者编号.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员信息")
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

    Private Sub btnF11生产数据导出_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11生产数据导出.Click

        Try
            Me.Cursor = Cursors.WaitCursor

            ''订单导入
            ExportData()


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

#End Region

#Region "Grid Event"

    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                           Handles grid生产实际一览.DoubleClickRow

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

    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid生产实际一览.InitializeLayout

        Try

            grid生产实际一览.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            grid生产实际一览.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

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
            Me.txt作业者编号.Select()
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

            '制限件数コンボボックス

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

            txt作业者编号.Text = String.Empty
            'txt部门名称.Text = String.Empty
            txt作业者名称.Text = String.Empty
            txt订单编号.Text = String.Empty
            txt产品图号.Text = String.Empty
            txt产品名称.Text = String.Empty
            cmb作业方式.Text = String.Empty
            dmt作业日期sta.Text = DateAdd("M", -1, Now)
            dmt作业日期end.Text = DateTime.Now.ToString("yyyy/MM/dd")

            txt作业者编号.Focus()

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
            mDtSearch.Columns.Add("订单编号")
            mDtSearch.Columns.Add("主图号")
            mDtSearch.Columns.Add("上级图号")
            mDtSearch.Columns.Add("分图号")
            mDtSearch.Columns.Add("作业时间")
            mDtSearch.Columns.Add("作业方式")
            mDtSearch.Columns.Add("作业日期")
            'mDtSearch.Columns.Add("完成日期")
            mDtSearch.Columns.Add("计划生产数量")
            mDtSearch.Columns.Add("实际生产数量")
            mDtSearch.Columns.Add("设备编号")
            mDtSearch.Columns.Add("作业者")

            grid生产实际一览.DataSource = mDtSearch

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
            Me.btnF11生产数据导出.Enabled = Utility.PFn_GetAuth(Me.btnF11生产数据导出.Tag)

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

        Dim objBll As New BLLM生产实际管理T
        Dim objM生产实际T As New Z生产实际管理T


        Try
            '一览打开，不做处理
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If

            '选择行が無い場合
            If Me.grid生产实际一览.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM生产实际T.订单编号 = Me.grid生产实际一览.ActiveRow.Cells("订单编号").Text.Trim
            objM生产实际T.上级图号 = Me.grid生产实际一览.ActiveRow.Cells("上级图号").Text.Trim
            objM生产实际T.分图号 = Me.grid生产实际一览.ActiveRow.Cells("分图号").Text.Trim

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objM生产实际T)

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

        Dim objM生产实际T As Z生产实际管理T

        Dim objBllM生产实际T As New BLLM生产实际管理T

        Try
            objM生产实际T = New Z生产实际管理T

            objM生产实际T.作业者编号 = Me.txt作业者编号.Text.Trim
            objM生产实际T.作业者 = Me.txt作业者名称.Text.Trim
            objM生产实际T.作业方式 = Me.cmb作业方式.Text.Trim
            '  objM生产实际T.作业者 = Me.txt作业者.Text.Trim
            'objM生产实际T.作业时间 = Me.dmt作业日期sta.Text.Trim
            If (Not Me.dmt作业日期sta.Text.Trim = String.Empty) Then
                objM生产实际T.作业日期sta = Me.dmt作业日期sta.Text.Trim
            Else
                objM生产实际T.作业日期sta = Constant.CGSTRDATE_DEFAULT
            End If
            If (Not Me.dmt作业日期end.Text.Trim = String.Empty) Then
                objM生产实际T.作业日期end = Me.dmt作业日期end.Text.Trim
            Else
                objM生产实际T.作业日期end = Constant.CGSTRDATE_DEFAULT
            End If
            objM生产实际T.订单编号 = Me.txt订单编号.Text.Trim
            objM生产实际T.产品图号 = Me.txt产品图号.Text.Trim

            '查询の検索処理

            mDtSearch = objBllM生产实际T.LoadByWhere(objM生产实际T)

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力

                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grid生产实际一览.DataSource = mDtSearch

                'フォーカスの設定処理
                txt作业者编号.Focus()
            Else

                '検索データを表示する
                Me.grid生产实际一览.DataSource = mDtSearch

                Me.grid生产实际一览.Focus()
                Me.grid生产实际一览.ActiveRow = Me.grid生产实际一览.Rows(0)
                SetGridStyle实际()
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

#Region "SetData"
    Private Sub SetData()
        Dim objM生产实际T As New Z生产实际管理T
        Dim objBll As BLLM生产实际管理T

        Try
            '获取数据
            objM生产实际T = New Z生产实际管理T
            objBll = New BLLM生产实际管理T

            objM生产实际T.人员编号 = txt作业者编号.Text.Trim()

            If String.IsNullOrEmpty(objM生产实际T.人员编号) Then
                objM生产实际T.人员编号 = " "
            End If
            If txt作业者编号.Text.Trim <> String.Empty Then
                mdsInfoDataSet = objBll.Load人员(objM生产实际T)
                If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                    ' Me.txt作业者编号.Text = mdsInfoDataSet.Rows(0)("人员编号").ToString()
                    ' Me.txt人员名.Text = mdsInfoDataSet.Rows(0)("人员名").ToString()
                    ' Me.txt职务.Text = mdsInfoDataSet.Rows(0)("职务").ToString()
                    'Me.txt部门名称.Text = mdsInfoDataSet.Rows(0)("部门名称").ToString()

                Else
                    Me.txt作业者编号.Text = String.Empty
                    Me.txt作业者名称.Text = String.Empty
                    'Me.txt部门名称.Text = String.Empty
                End If
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

#Region "ExportData"

    Private Sub ExportData()

        Dim dialogResult As DialogResult
        Dim fileFullName As String = ""
        Dim str生产实际S As String = String.Empty
        Dim str生产工序S As String = String.Empty
        Dim strExt As String = ".xlsx"
        Dim ReturnDataTable As DataTable
        Dim dt As New DataTable
        Try
            dt = grid生产实际一览.DataSource()
            For Each drr As DataRow In dt.Rows
                If drr("选择") = 1 Then
                    If str生产实际S = String.Empty Then
                        str生产实际S = drr("订单编号")
                        str生产工序S = drr("本道工序")
                    Else
                        str生产实际S = str生产实际S & "','" & drr("订单编号")
                        str生产工序S = str生产工序S & "','" & drr("本道工序")

                    End If
                End If
            Next
            If Me.grid生产实际一览.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID42, "生产实际一览") = Constant.ENU_SHOWMSG.showMsgNo Then
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
            fileFullName = Me.FolderBrowserDialog.SelectedPath & "\生产实际一览 " & Format(Now(), "yyyy-MM-dd H-mm-ss ffff") & strExt

            Dim objM生产实际T As New Z生产实际管理T

            Dim objBllM生产实际T As New BLLM生产实际管理T

            '选择行が無い場合
            If Me.grid生产实际一览.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM生产实际T.订单编号 = str生产实际S
            objM生产实际T.本道工序 = str生产工序S

            'テーブルにデータを追加
            ReturnTable = objBllM生产实际T.LoadAllexp(objM生产实际T)

            mDtSearch = ReturnTable
            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If Utility.PFn_DataTableToExcel(mDtSearch, fileFullName) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "生产实际一览")
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "生产实际一览数据导出")
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
#Region "SetGridStyle实际"
    Private Sub SetGridStyle实际()
        Try

            With grid生产实际一览.DisplayLayout.Bands(0)
                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("选择").CellActivation = Activation.AllowEdit
                .Columns("作业日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("作业日期").CellActivation = Activation.NoEdit
                .Columns("计划生产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("实际生产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("完成日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                '.Columns("完成日期").CellActivation = Activation.NoEdit
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