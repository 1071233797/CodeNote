Imports HRJS.Constant
Imports System.Text
Imports System.IO
Imports Infragistics.Win.UltraWinGrid

Public Class frm生产自检一览

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
        本道工序编号 = 13
    End Enum

#End Region

#Region "変数定義"

    Private mds详细 As DataSet = Nothing                'grd详细
    Private mdt详细Band0 As DataTable = Nothing                'grd详细
    Private mdt详细Band1 As DataTable = Nothing                'grd详细
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
#Region "人员"
    Private Sub txt人员编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt人员编号.EditorButtonClick
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
                    Me.txt人员编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号").ToString        '人员编号
                    Me.txt作业者名称.Text = frmSearch.ReturnTable.Rows(0)("人员名").ToString
                    'SetData()
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
    Private Sub txt人员编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt人员编号.Leave
        Dim objM人员T As M人员T
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt人员编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt人员编号.Text.Trim <> String.Empty Then

                If Me.txt人员编号.Tag = Me.txt人员编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt人员编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                objM人员T = objBLLM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员名 <> String.Empty Then


                    Me.txt作业者名称.Text = objM人员T.人员名     '客户名称

                    'Me.txt职务.Text = objM人员T.职务

                    'Me.txt部门.Text = objM人员T.部门

                    Me.txt产品图号.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt作业者名称.Text = String.Empty
                    Me.txt人员编号.Select()
                End If
            Else
                Me.txt人员编号.Text = String.Empty
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
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
                    'Me.txt产品名称.Text = frmSearch.ReturnTable.Rows(0)("品名").ToString        '产品名称

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

                If objM图纸T.产品图号 <> String.Empty Then


                    Me.txt产品图号.Text = objM图纸T.产品图号       '客户名称

                    ''Me.txt职务.Text = objM人员T.职务

                    'Me.txt部门名称.Text = objM人员T.部门

                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "产品图号")
                    'Me.txt人员编号.Text = String.Empty
                    'Me.txt产品名称.Text = String.Empty
                    'Me.txt部门名称.Text = String.Empty
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
#Region "人员"
    Private Sub txt作业者编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs)

        'Dim frmSearch As frm人员一览
        'Try

        '    frmSearch = New frm人员一览

        '    frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

        '    '供应商查询画面打开
        '    frmSearch.ShowDialog()

        '    '画面数据设置
        '    If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

        '        If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

        '            '根据检索画面数据进行设置
        '            Me.txt作业者编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号").ToString        '人员编号
        '            Me.txt作业者名称.Text = frmSearch.ReturnTable.Rows(0)("人员名").ToString        '人员名
        '            'Me.txt部门名称.Text = frmSearch.ReturnTable.Rows(0)("部门").ToString        '部门名称
        '            SetData()
        '        End If

        '        If Not frmSearch.ReturnTable Is Nothing Then
        '            '检索画面释放
        '            frmSearch.ReturnTable.Dispose()
        '            frmSearch.ReturnTable = Nothing
        '        End If

        '        '检索画面释放

        '        frmSearch.Dispose()
        '        frmSearch = Nothing
        '    End If
        '    '光标设置
        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    '异常处理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    '默认光标设置
        '    Me.Cursor = Cursors.Default
        'End Try
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
                                           Handles grid生产自检一览.DoubleClickRow

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

    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid生产自检一览.InitializeLayout

        Try

            grid生产自检一览.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            grid生产自检一览.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

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
            Me.txt人员编号.Select()
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

            'Utility.PFn_SetCombo(Me.cmb作业方式, "VM材料区分", 0)

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

            txt人员编号.Text = String.Empty
            'txt部门名称.Text = String.Empty
            txt作业者名称.Text = String.Empty
            txt订单编号.Text = String.Empty
            txt产品图号.Text = String.Empty
            'txt产品名称.Text = String.Empty
            dmt自检日期sta.Text = DateAdd("M", -1, Now)
            dmt自检日期end.Text = DateTime.Now.ToString("yyyy/MM/dd")

            txt人员编号.Focus()

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
            mDtSearch.Columns.Add("作业者")
            'mDtSearch.Columns.Add("作业日期")
            'mDtSearch.Columns.Add("作业方式")
            'mDtSearch.Columns.Add("作业开始时间")
            'mDtSearch.Columns.Add("作业结束时间")
            mDtSearch.Columns.Add("订单编号")
            'mDtSearch.Columns.Add("计划生产数量")
            mDtSearch.Columns.Add("主图号")
            mDtSearch.Columns.Add("上级图号")
            mDtSearch.Columns.Add("分图号")
            mDtSearch.Columns.Add("本道工序")
            mDtSearch.Columns.Add("本道工序编号")
            'mDtSearch.Columns.Add("上道工序")
            'mDtSearch.Columns.Add("下道工序")
            'mDtSearch.Columns.Add("图纸尺寸")
            'mDtSearch.Columns.Add("公差")
            'mDtSearch.Columns.Add("自检日期")
            'mDtSearch.Columns.Add("自检结果")
            'mDtSearch.Columns.Add("不良品数量")
            'mDtSearch.Columns.Add("待修品数量")
            'mDtSearch.Columns.Add("报废品数量")
            'mDtSearch.Columns.Add("备注")

            grid生产自检一览.DataSource = mDtSearch

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

        Dim objBll As New BLLM生产自检录入T
        Dim objM生产自检T As New Z生产自检录入T


        Try

            '一览打开，不做处理
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If

            '选择行が無い場合
            If Me.grid生产自检一览.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM生产自检T.订单编号 = Me.grid生产自检一览.ActiveRow.Cells("订单编号").Text.Trim
            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objM生产自检T)

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

        Dim objM生产自检T As Z生产自检录入T

        Dim objBllM生产自检T As New BLLM生产自检录入T

        Try
            objM生产自检T = New Z生产自检录入T
            objM生产自检T.作业者 = Me.txt作业者名称.Text.Trim
           
            If (Not Me.dmt自检日期sta.Text.Trim = String.Empty) Then
                objM生产自检T.自检日期sta = Me.dmt自检日期sta.Text.Trim
            Else
                objM生产自检T.自检日期sta = Constant.CGSTRDATE_DEFAULT
            End If
            If (Not Me.dmt自检日期end.Text.Trim = String.Empty) Then
                objM生产自检T.自检日期end = Me.dmt自检日期end.Text.Trim
            Else
                objM生产自检T.自检日期end = Constant.CGSTRDATE_DEFAULT
            End If
            objM生产自检T.订单编号 = Me.txt订单编号.Text.Trim
            objM生产自检T.分图号 = Me.txt产品图号.Text.Trim

            '查询の検索処理
            mds详细 = New DataSet

            'mdt详细Band0データを記録テーブル初期化
            Me.mdt详细Band0 = New DataTable
            mdt详细Band0 = objBllM生产自检T.LoadByWhere(objM生产自检T)

            'mdt详细Band1データを記録テーブル初期化
            Me.mdt详细Band1 = New DataTable
            mdt详细Band1 = objBllM生产自检T.LoadByWhere1(objM生产自检T)

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

            parentCols(0) = mds详细.Tables(0).Columns("订单编号")
            childCols(0) = mds详细.Tables(1).Columns("订单编号")
            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mds详细.Relations.Add(drBand(0))

            If mds详细 Is Nothing OrElse mds详细.Tables(0).Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grid生产自检一览.DataSource = Nothing
                InitGrid()
                'フォーカスの設定処理
                Me.txt作业者名称.Focus()
            Else

                '検索データを表示する
                Me.grid生产自检一览.DataSource = mds详细
                Me.grid生产自检一览.Focus()
                Me.grid生产自检一览.ActiveRow = Me.grid生产自检一览.Rows(0)
                SetGridStyle自检()
            End If

            ''****************************************************
            ''查询の検索処理:件数
            'Dim dtCOUNT As New DataTable

            'dtCOUNT = objBllM库存T.GetGridData(objM车型库存T, True)

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

#Region "ExportData"

    Private Sub ExportData()

        Dim dialogResult As DialogResult
        Dim fileFullName As String = ""
        Dim str订单编号S As String = String.Empty
        Dim str主图号S As String = String.Empty
        Dim str上级图号S As String = String.Empty
        Dim str分图号S As String = String.Empty
        Dim str本道工序编号S As String = String.Empty
        Dim strExt As String = ".xlsx"
        Dim ReturnDataTable As DataTable
        Dim dt As New DataTable
        Try

            If Me.grid生产自检一览.Rows.Count = 0 Then
                MsgBox("请选择导出信息")
                Exit Sub
            End If

            dt = grid生产自检一览.DataSource.tables(0)
            For Each drr As DataRow In dt.Rows

                If drr("选择") = 1 Then

                    If str订单编号S = String.Empty Then
                        str订单编号S = drr("订单编号")
                    Else
                        str订单编号S = str订单编号S & "','" & drr("订单编号")
                    End If

                    If str主图号S = String.Empty Then
                        str主图号S = drr("主图号")
                    Else
                        str主图号S = str主图号S & "','" & drr("主图号")
                    End If

                    If str上级图号S = String.Empty Then
                        str上级图号S = drr("上级图号")
                    Else
                        str上级图号S = str上级图号S & "','" & drr("上级图号")
                    End If

                    If str分图号S = String.Empty Then
                        str分图号S = drr("分图号")
                    Else
                        str分图号S = str分图号S & "','" & drr("分图号")
                    End If

                    If str本道工序编号S = String.Empty Then
                        str本道工序编号S = drr("本道工序编号")
                    Else
                        str本道工序编号S = str本道工序编号S & "','" & drr("本道工序编号")
                    End If

                End If

            Next
            If Me.grid生产自检一览.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID42, "生产自检一览") = Constant.ENU_SHOWMSG.showMsgNo Then
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
            fileFullName = Me.FolderBrowserDialog.SelectedPath & "\生产自检一览 " & Format(Now(), "yyyy-MM-dd H-mm-ss ffff") & strExt

            Dim objBll As New BLLM生产自检录入T
            Dim objM生产自检T As New Z生产自检录入T


            '选择行が無い場合
            If Me.grid生产自检一览.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM生产自检T.订单编号 = str订单编号S
            objM生产自检T.主图号 = str主图号S
            objM生产自检T.上级图号 = str上级图号S
            objM生产自检T.分图号 = str分图号S
            objM生产自检T.本道工序编号 = str本道工序编号S
            'テーブルにデータを追加
            ReturnTable = objBll.LoadAllexp(objM生产自检T)

            mDtSearch = ReturnTable

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If


            If Utility.PFn_DataTableToExcel(mDtSearch, fileFullName) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "生产自检一览")
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "生产自检一览数据导出")
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
#Region "SetGridStyle自检"
    Private Sub SetGridStyle自检()
        Try
            With grid生产自检一览.DisplayLayout.Bands(0)
                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("选择").CellActivation = Activation.AllowEdit
                .Columns("本道工序编号").Hidden = True
            End With
            With grid生产自检一览.DisplayLayout.Bands(1)
                .Columns("订单编号").Hidden = True

                .Columns("公差").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("自检日期").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                .Columns("不良品数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("待修品数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("报废品数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
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