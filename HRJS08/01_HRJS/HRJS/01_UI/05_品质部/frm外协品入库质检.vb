Imports HRJS.Constant
Imports Infragistics.Win.UltraWinGrid
Public Class frm外协品入库质检
#Region "常量定义"
    Private mDtSearch As DataTable = Nothing
    Private Enum ENU_GRID As Integer
        选择 = 0
        主图好 = 1
        产品图号 = 2
        品名 = 3
        申请日期 = 4
        申请者名称 = 5
        入库数量 = 6
        入库重量 = 7
        异常数量 = 8
        异常原因 = 9
        备注 = 10
        质检状态 = 11



    End Enum
#End Region
#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    ' Private mDtSearch As DataTable = Nothing
    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable

#End Region

#Region "Form Event"

    Private Sub frm外协品入库质检_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frm外协品入库质检_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgYes Then

                e.Cancel = False
            Else
                e.Cancel = True
            End If

        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '释放光标
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frm外协品入库质检_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                Case Keys.F3
                    btnF3保存.Focus()
                    btnF3保存_Click(Nothing, Nothing)

                Case Keys.F4
                    btnF4删除.Focus()
                    btnF4删除_Click(Nothing, Nothing)
                Case Keys.F5
                    btnF5直接入库.Focus()
                    btnF5直接入库_Click(Nothing, Nothing)




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


    Private Sub grid外协品入库质检_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid外协品入库质检.InitializeLayout
        grid外协品入库质检.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid外协品入库质检.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False

    End Sub

#End Region

#Region "Button Event"

    Private Sub btnF5直接入库_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF5直接入库.Click

    End Sub

    Private Sub btnF1清空_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF1清空.Click

        Try
            '清空画面对话框            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            ''画面の初期化処理
            ClearForm()

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormData()

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

            Me.Cursor = Cursors.WaitCursor

            ''画面の終了処理

            Me.Close()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF3保存_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF3保存.Click

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

            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Me.txt入库申请单编号.Select()
            Else
                Me.txt检查者编号.Select()
            End If


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objB外协品入库申请T As New B外协品入库申请T

        Dim objBll As New BLLM外协品入库申请T

        Try

            '保存確認メッセージを表示する
            If Me.txt入库申请单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "入库申请单编号", "入库申请单编号")
                txt入库申请单编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            objB外协品入库申请T.申请单编号 = txt入库申请单编号.Text.Trim

            If objBll.Deletezj(objB外协品入库申请T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New


            ClearForm()
            SetFormData()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub txt入库申请单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt入库申请单编号.EditorButtonClick


        Dim frmSearch As frm外协品入库申请一览
        Try

            frmSearch = New frm外协品入库申请一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt入库申请单编号.Text = frmSearch.ReturnTable.Rows(0)("申请单编号")     '申请


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
    Private Sub txt检查者编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt检查者编号.EditorButtonClick


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

                    Me.txt检查者名称.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '人员名

                    Me.txt检查者编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '人员编号


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

#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try
            'SetGridStyle()
            '画面のComboの初期値を設定する
            'Me.SetCombo()

            '画面の内容を清空処理
            Me.ClearForm()
            SetFormData()
            '権限の処理            'Me.SetPermission()

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

            Me.txt入库申请单编号.Text = String.Empty
            Me.txt检查者编号.Text = String.Empty
            Me.txt检查者名称.Text = String.Empty

            'grid原材料出库申请.DataSource = Nothing

            Me.txt入库申请单编号.Select()

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

        Try
            Dim objM外协品入库申请T As New B外协品入库申请T
            Dim objBll As New BLLM外协品入库申请T
            Dim arryList As New ArrayList

            If grid外协品入库质检.Rows.Count > 0 Then

                For i = 0 To grid外协品入库质检.Rows.Count - 1
                    objM外协品入库申请T = New B外协品入库申请T
                    objM外协品入库申请T.申请单编号 = Me.txt入库申请单编号.Text.Trim
                    objM外协品入库申请T.检查者编号 = Me.txt检查者编号.Text.Trim
                    'objM原材料入库申请T.申请者编号 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.申请者名称).Value.ToString()
                    'objM原材料入库申请T.申请日期 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.申请日期).Value.ToString()
                    'objM原材料入库申请T.材料编号 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.原材料批号).Value.ToString()
                    'objM原材料入库申请T.材料名称 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.原材料名称).Value.ToString()
                    'objM原材料入库申请T.材料区分 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.材料区).Value.ToString()
                    'objM原材料入库申请T.材质 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.材质).Value.ToString()
                    'objM原材料入库申请T.入库数量 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.入库数量).Value.ToString()


                    'objM原材料入库申请T.入库重量 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.入库重量).Value.ToString()
                    'objM原材料入库申请T.订单编号 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.订单编).Value.ToString()
                    'objM原材料入库申请T.产品图号 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.产品图号).Value.ToString()
                    'objM原材料入库申请T.客户名称 = grid原材料入库质检.Rows(i).Cells(ENU_GRID.客户名称).Value.ToString()
                    objM外协品入库申请T.异常数量 = grid外协品入库质检.Rows(i).Cells(ENU_GRID.异常数量).Value.ToString()
                    objM外协品入库申请T.异常原因 = grid外协品入库质检.Rows(i).Cells(ENU_GRID.异常原因).Value.ToString()

                    objM外协品入库申请T.备注 = grid外协品入库质检.Rows(i).Cells(ENU_GRID.备注).Value.ToString()
                    objM外协品入库申请T.质检状态 = grid外协品入库质检.Rows(i).Cells(ENU_GRID.质检状态).Value.ToString()
                    ' objM外协品入库申请T.登陆日 = DateTime.Now
                    objM外协品入库申请T.登陆者 = gObjM_人员T.人员编号
                    objM外协品入库申请T.登陆日期 = DateTime.Now
                    objM外协品入库申请T.更新者 = gObjM_人员T.人员编号
                    objM外协品入库申请T.更新日期 = DateTime.Now
                    arryList.Add(objM外协品入库申请T)

                Next

            End If


            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.Updatezj(objM外协品入库申请T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                        Me.txt入库申请单编号.Focus()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Updatezj(objM外协品入库申请T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt入库申请单编号.Focus()
                        Exit Sub
                    End If

            End Select

        Catch ex As Exception
            '異常処理()
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル()
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

            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If

            '必須チェック(MsgID=21) 

            '申请单编号
            If Me.txt入库申请单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请单编号", "申请单编号")
                txt入库申请单编号.Focus()
                Return False
            End If

            '客户名

            If Me.txt检查者编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查者编号", "检查者编号")
                txt检查者编号.Focus()
                Return False
            End If

            Dim intLoopi As Integer

            For intLoopi = 0 To grid外协品入库质检.Rows.Count - 1




                '产品图号
                If grid外协品入库质检.Rows(intLoopi).Cells(ENU_GRID.异常数量).Value > grid外协品入库质检.Rows(intLoopi).Cells(ENU_GRID.入库数量).Value Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "异常数量", "异常数量")
                    Me.grid外协品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.异常数量).Activated = True
                    Me.grid外协品入库质检.Select()
                    Return False
                End If
                If grid外协品入库质检.Rows(intLoopi).Cells(ENU_GRID.异常原因).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "异常原因", "异常原因")
                    Me.grid外协品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.异常原因).Activated = True
                    Me.grid外协品入库质检.Select()
                    Return False
                End If
                If grid外协品入库质检.Rows(intLoopi).Cells(ENU_GRID.备注).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "备注", "备注")
                    Me.grid外协品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.备注).Activated = True
                    Me.grid外协品入库质检.Select()
                    Return False
                End If
                If grid外协品入库质检.Rows(intLoopi).Cells(ENU_GRID.质检状态).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "质检状态", "质检状态")
                    Me.grid外协品入库质检.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.质检状态).Activated = True
                    Me.grid外协品入库质检.Select()
                    Return False
                End If

            Next
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

#Region "SetPermission"

    Private Sub SetPermission()
        Try

            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            Me.btnF5直接入库.Enabled = Utility.PFn_GetAuth(Me.btnF5直接入库.Tag)
            ' Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)
            'Me.grid客户管理.Enabled = Utility.PFn_GetAuth(Me.grid客户管理.Tag)
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "SetFormData"

    Private Sub SetFormData()
        Dim objZ外协品入库申请T As New B外协品入库申请T
        Dim objBll As BLLM外协品入库申请T

        Try
            '获取数据
            objZ外协品入库申请T = New B外协品入库申请T
            objBll = New BLLM外协品入库申请T

            objZ外协品入库申请T.申请单编号 = txt入库申请单编号.Text.Trim()

            If String.IsNullOrEmpty(objZ外协品入库申请T.申请单编号) Then
                objZ外协品入库申请T.申请单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAllHead(objZ外协品入库申请T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                Me.txt入库申请单编号.Text = mdsInfoDataSet.Rows(0)("申请单编号").ToString()
                Me.txt检查者编号.Text = mdsInfoDataSet.Rows(0)("检查者编号").ToString()
                Me.txt检查者名称.Text = mdsInfoDataSet.Rows(0)("检查者名称").ToString()
                'Me.txt部门.Text = mdsInfoDataSet.Rows(0)("部门").ToString()
                'Me.dt申请日期.Text = mdsInfoDataSet.Rows(0)("申请日期").ToString()
            Else
                Me.txt入库申请单编号.Text = String.Empty
                Me.txt检查者编号.Text = String.Empty
                Me.txt检查者名称.Text = String.Empty
                'Me.txt部门.Text = String.Empty
                'Me.dt申请日期.Text = String.Empty
            End If

            mdsGridDataSet = objBll.LoadGridAll(objZ外协品入库申请T)
            'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
            grid外协品入库质检.DataSource = mdsGridDataSet
            'grid原材料入库申请.DisplayLayout.Bands(0).Columns("客户编号CD").Hidden = True

            'End If
            BindGridCombox()
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

            With grid外协品入库质检.DisplayLayout.Bands(0)

                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns(ENU_GRID.入库数量).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns(ENU_GRID.入库重量).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns(ENU_GRID.异常数量).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns(ENU_GRID.主图好).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.产品图号).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.品名).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.申请日期).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.申请者名称).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.入库数量).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.入库重量).CellActivation = Activation.NoEdit
                .Columns(ENU_GRID.申请日期).CellActivation = Activation.NoEdit


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

    Private Sub txt入库申请单编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt入库申请单编号.Leave
        Try

            If txt入库申请单编号.Text = "" Then

                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor

                '検索を実行
                Me.DataSearch()

            End If

            '砂時計のカーソルが設定

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try


    End Sub
#Region "DataSearch"

    Private Sub DataSearch()

        Dim objB外协品入库申请T As New B外协品入库申请T
        Dim objBll As New BLLM外协品入库申请T

        Try
            objB外协品入库申请T = New B外协品入库申请T

            objB外协品入库申请T.申请单编号 = Me.txt入库申请单编号.Text.Trim

            Me.grid外协品入库质检.DataSource = Nothing

            mDtSearch = objBll.LoadAllzj(objB外协品入库申请T)


            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.gridlist.PClear()
                '検索データを表示する
                Me.grid外协品入库质检.DataSource = mDtSearch

                'フォーカスの設定処理
                Me.txt入库申请单编号.Focus()
            Else
                '検索データを表示する
                Me.grid外协品入库质检.DataSource = mDtSearch
                Me.grid外协品入库质检.Focus()
                Me.grid外协品入库质检.ActiveRow = Me.grid外协品入库质检.Rows(0)
            End If

            BindGridCombox()
            SetGridStyle()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region
#Region "BindGridCombox"

    Private Sub BindGridCombox(Optional ByVal intRowIndex As Integer = 0)

        Try
            Utility.PFn_SetGirdCombo(Me.grid外协品入库质检, "VM质检状态", ENU_GRID.质检状态)
            ' Utility.PFn_SetGirdCombo(Me.gridList, "VM供货方式", ENU_GRID.供货方式)
        Catch ex As Exception

        End Try

    End Sub

#End Region

    Private Sub grid外协品入库质检_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grid外协品入库质检.KeyPress

    End Sub
End Class