Imports HRJS.Constant
Imports Infragistics.Win.UltraWinGrid

Public Class frm外协加工一览

#Region "常数定義"

    Public Enum ENU_GRID As Integer
        选择 = 0
        外协订单编号 = 1
        主图号 = 2
        产品图号 = 3

    End Enum

#End Region

#Region "変数定義"
    Private mDtSearch As DataTable = Nothing
    Private mstr外协订单编号 As String = String.Empty
    Private mDt详细 As DataSet  'grid详细
    Private mDt详细订单1 As DataTable  'grid详细
    Private mDt详细订单2 As DataTable  'grid详细
    Public intDoubleClick As Integer = 0


    Public Property 外协订单编号() As String
        Get
            Return mstr外协订单编号
        End Get
        Set(ByVal Value As String)
            mstr外协订单编号 = Value
        End Set
    End Property

#End Region

#Region "Form Event"

    Private Sub frm外协加工一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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

    Private Sub frm外协加工一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm外协加工一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
                    btnF4全选.Focus()
                    btnF4全选_Click(Nothing, Nothing)

                Case Keys.F10
                    btn审核.Focus()
                    btn审核_Click(Nothing, Nothing)

                Case Keys.F11
                    btnF11外协计划表打印.Focus()
                    btnF11外协计划表打印_Click(Nothing, Nothing)

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

            If Not InputCheck() Then
                Exit Sub
            End If

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
    Private Sub btnF4全选_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4全选.Click

        Try
            Dim intRows As Integer

            If Me.grid外协加工一览.Rows.Count = 0 Then
                Exit Sub
            End If

            For intRows = 0 To Me.grid外协加工一览.Rows.Count - 1
                grid外协加工一览.Rows(intRows).Cells(0).Value = True
            Next

            grid外协加工一览.UpdateData()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub btn审核_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn审核.Click

        Dim frmSearch As frm审核
        Dim objM外协加工T As New B外协加工管理T
        Dim objBLLM外协加工T As New BllM外协加工管理T
        Dim dt As New DataTable
        Dim str外协计划单号 As String = String.Empty

        Try

            If grid外协加工一览.Rows.Count = 0 Then
                MsgBox("请选择需要审核的数据")
                Exit Sub
            End If

            If grid外协加工一览.ActiveRow.Cells Is Nothing Then
                MsgBox("请选择需要审核的数据")
                Exit Sub
            End If
            '获取所有所选择的需要审核的外协计划单号
            dt = grid外协加工一览.DataSource.tables(0)
            For Each drr As DataRow In dt.Rows
                If drr("选择") = 1 Then
                    If str外协计划单号 = String.Empty Then
                        str外协计划单号 = drr("外协计划单号")
                    Else
                        str外协计划单号 = str外协计划单号 & "','" & drr("外协计划单号")
                    End If
                End If
            Next
            objM外协加工T.外协订单编号 = str外协计划单号
            frmSearch = New frm审核

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = 1 Then

                '获取审核数据
                objM外协加工T.审核状态 = frmSearch.cmb审核状态.Value
                objM外协加工T.审核备注 = frmSearch.txt审核备注.Text
                objM外协加工T.审核人 = gObjM_人员T.人员编号

                '判断是否有审核数据
                If frmSearch.cmb审核状态.Value <> String.Empty Then

                    '修改外协加工表的审核数据

                    If objBLLM外协加工T.Update审核(objM外协加工T) > 0 Then
                        '提示审核成功
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "审核")
                    End If
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放
                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing

                End If

                '检索画面释放                frmSearch.Dispose()
                frmSearch = Nothing

            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnF11外协计划表打印_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11外协计划表打印.Click

        'Dim dialogResult As DialogResult
        'Dim fileFullName As String = ""

        'Dim strExt As String = ".xlsx"
        'Try

        'Catch ex As Exception

        'End Try

    End Sub

#End Region

#Region "Grid Event"

    Private Sub grid外协加工一览_DoubleClickRow(ByVal sender As System.Object, _
                                      ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                      Handles grid外协加工一览.DoubleClickRow

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

    Private Sub grid外协加工一览_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid外协加工一览.InitializeLayout

        Try
            Dim intLoopi As Integer
            For index = 1 To grid外协加工一览.DisplayLayout.Bands(0).Columns.Count - 1
                grid外协加工一览.DisplayLayout.Bands(0).Columns(intLoopi).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Next
            grid外协加工一览.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub grid外协加工一览_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
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

#Region "订单编号"

    Private Sub txt订单编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt订单编号.Enter

        Try

            Me.txt订单编号.Tag = Me.txt订单编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
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

                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号")     '订单编号

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

    Private Sub txt产品图号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt产品图号.Enter

        Try

            Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt产品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt产品图号.EditorButtonClick


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
#Region "外协对象"

    Private Sub txt外协对象_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt外协对象.Enter

        Try

            Me.txt外协对象.Tag = Me.txt外协对象.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt外协对象_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt外协对象.EditorButtonClick


        Dim frmSearch As frm外协对象一览
        Try
            frmSearch = New frm外协对象一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '    '根据检索画面数据进行设置

                    Me.txt外协对象.Text = frmSearch.ReturnTable.Rows(0)("外协对象编号")         '外协对象编号
                    Me.txt外协对象名称.Text = frmSearch.ReturnTable.Rows(0)("外协对象名称")     '外协对象名称

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
    Private Sub txt外协对象_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txt外协对象.Leave
        Dim objM外协对象T As M外协对象T
        Dim objBLLM外协对象T As BLLM外协对象T

        Try

            If txt外协对象.ReadOnly Then
                Exit Sub
            End If

            If Me.txt外协对象.Text.Trim <> String.Empty Then

                If Me.txt外协对象.Tag = Me.txt外协对象.Text.Trim Then
                    Exit Sub
                End If

                objM外协对象T = New M外协对象T

                objM外协对象T.外协对象编号 = txt外协对象.Text.Trim

                objBLLM外协对象T = New BLLM外协对象T

                objM外协对象T = objBLLM外协对象T.LoadByPKey(objM外协对象T)

                If objM外协对象T.外协对象名称 <> String.Empty Then

                    Me.txt外协对象名称.Text = objM外协对象T.外协对象名称
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "客户名称")
                    'Me.txt客户编号.Text = String.Empty
                    Me.txt外协对象名称.Text = String.Empty
                    Me.txt外协对象.Select()
                End If
            Else
                Me.txt外协对象.Text = String.Empty
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
#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try

            SetButtonStatus()

            'Grid初始化
            Me.InitGrid()
            Me.SetCombo()
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
#Region "SetPermission"

    Private Sub SetPermission()
        Try

            Me.btnF2查询.Enabled = Utility.PFn_GetAuth(Me.btnF2查询.Tag)
            Me.btnF3选择.Enabled = Utility.PFn_GetAuth(Me.btnF3选择.Tag)
            Me.btnF4全选.Enabled = Utility.PFn_GetAuth(Me.btnF4全选.Tag)
            Me.btnF11外协计划表打印.Enabled = Utility.PFn_GetAuth(Me.btnF11外协计划表打印.Tag)

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
                Me.btnF4全选.Visible = False
            Case Else
                Me.btnF4全选.Visible = False
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
            Me.txt外协订单编号.Text = String.Empty
            Me.txt外协对象.Text = String.Empty
            Me.txt外协对象名称.Text = String.Empty
            Me.txt订单编号.Text = String.Empty
            Me.txt产品图号.Text = String.Empty
            Me.dmt回厂日期sta.Text = DateAdd("M", -1, Now)
            Me.dmt回厂日期end.Text = DateTime.Now.ToString("yyyy/MM/dd")
            Me.cmb外协计划状态.Text = String.Empty
            Me.txt外协订单编号.Select()

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

        Dim dtCbo As System.Data.DataTable = Nothing            'コンボボックスデータテーブル

        Try

            Utility.PFn_SetCombo(Me.cmb外协计划状态, "VM外协计划状态", 0)

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
            mDtSearch.Columns.Add("外协计划单号")
            'mDtSearch.Columns.Add("主图号")
            mDtSearch.Columns.Add("外协对象")
            grid外协加工一览.DataSource = mDtSearch

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

            '必須チェック(MsgID=21) 
            If Not String.IsNullOrEmpty(dmt回厂日期sta.Text.Trim) And Not String.IsNullOrEmpty(dmt回厂日期end.Text.Trim) Then
                If DateTime.Parse(dmt回厂日期sta.DateTime) > DateTime.Parse(dmt回厂日期end.DateTime) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "回厂日期", "回厂日期")
                    dmt回厂日期sta.Focus()
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

#Region "DataSearch"

    Private Sub DataSearch()

        Dim objM外协加工T As B外协加工管理T

        Dim objBLLM外协加工T As New BllM外协加工管理T

        Try

            objM外协加工T = New B外协加工管理T
            objBLLM外协加工T = New BllM外协加工管理T
            objM外协加工T.外协订单编号 = Me.txt外协订单编号.Text.Trim
            objM外协加工T.外协对象编号 = Me.txt外协对象.Text.Trim
            objM外协加工T.订单编号 = Me.txt订单编号.Text.Trim
            objM外协加工T.主图号 = Me.txt产品图号.Text.Trim
            objM外协加工T.外协加工状态 = Me.cmb外协计划状态.Value
            If (Not Me.dmt回厂日期sta.Text.Trim = String.Empty) Then
                objM外协加工T.回厂日期1 = Me.dmt回厂日期sta.Text.Trim
            Else
                objM外协加工T.回厂日期1 = Constant.CGSTRDATE_DEFAULT
            End If

            If (Not Me.dmt回厂日期end.Text.Trim = String.Empty) Then
                objM外协加工T.回厂日期2 = Me.dmt回厂日期end.Text.Trim
            Else
                objM外协加工T.回厂日期2 = Constant.CGSTRDATE_DEFAULT
            End If
            If FormOpenMode = Constant.ENU_MODE.Model_Ref Then
                objM外协加工T.审核状态 = 1
            End If
            '查询の検索処理

            mDt详细 = New DataSet
            Me.mDt详细订单1 = New DataTable
            mDt详细订单1 = objBLLM外协加工T.LoadBand0(objM外协加工T)

            'mdt详细Band1データを記録テーブル初期化
            Me.mDt详细订单2 = New DataTable
            mDt详细订单2 = objBLLM外协加工T.LoadBand1(objM外协加工T)

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(2) As DataRelation

            mDt详细 = New DataSet
            'DataSetの親子関係を設定
            mDt详细.Relations.Clear()

            '親、子のテーブルを追加
            mDt详细订单1.TableName = "详细订单1"
            mDt详细.Tables.Add(mDt详细订单1)

            mDt详细订单2.TableName = "详细订单2"
            mDt详细.Tables.Add(mDt详细订单2)

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(0).Columns("外协计划单号")
            childCols(0) = mDt详细.Tables(1).Columns("外协计划单号")

            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(0))

            Me.grid外协加工一览.DataSource = mDt详细
            grid外协加工一览.Refresh()

            mDtSearch = objBLLM外协加工T.LoadBand0(objM外协加工T)

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grid外协加工一览.PClear()
                '検索データを表示する
                Me.grid外协加工一览.DataSource = mDtSearch

                'フォーカスの設定処理
                Me.txt外协订单编号.Focus()
            Else
                '検索データを表示する
                Me.grid外协加工一览.DataSource = mDt详细
                Me.grid外协加工一览.Focus()
                Me.grid外协加工一览.ActiveRow = Me.grid外协加工一览.Rows(0)
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

            With grid外协加工一览.DisplayLayout.Bands(1)

                .Columns("完成日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("完成日期").CellActivation = Activation.NoEdit
                .Columns("外协加工数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("带料数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("回厂日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("回厂日期").CellActivation = Activation.NoEdit
                .Columns("加工单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("加工总金额").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
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
#Region "Selection"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Selection()

        Dim objBll As New BllM外协加工管理T
        Dim objM外协加工T As New B外协加工管理T

        Try
            '选择行が無い場合
            If Me.grid外协加工一览.ActiveRow Is Nothing Then
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
            'objM订单T.制造区分 = Me.cbo制造区分.Value

            If intDoubleClick = 1 Then
                If grid外协加工一览.ActiveRow.Cells.Count < 7 Then
                    MsgBox("请选择图号。")
                    Exit Sub
                Else
                    objM外协加工T.主图号 = Me.grid外协加工一览.ActiveRow.Cells(ENU_GRID.产品图号).Text.Trim
                End If
            ElseIf intDoubleClick = 2 Then
                If grid外协加工一览.ActiveRow.Cells.Count < 7 Then
                    MsgBox("请选择图号。")
                    Exit Sub
                End If

                If Me.grid外协加工一览.ActiveRow.Cells.Count < 17 Then
                    If Me.grid外协加工一览.ActiveRow.Cells("外协计划状态").Value <> "已回厂" Then
                        MsgBox("请选择回厂的数据。")
                        Exit Sub
                    Else
                        objM外协加工T.分图号 = Me.grid外协加工一览.ActiveRow.Cells("分图号").Text.Trim
                    End If
                End If
                End If
            objM外协加工T.外协订单编号 = Me.grid外协加工一览.ActiveRow.Cells("外协计划单号").Text.Trim

                'テーブルにデータを追加
                ReturnTable = objBll.LoadAll(objM外协加工T)

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

#End Region
#End Region
End Class