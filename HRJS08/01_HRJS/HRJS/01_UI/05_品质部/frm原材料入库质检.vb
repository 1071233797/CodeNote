Imports HRJS.Constant
Imports Infragistics.Win.UltraWinGrid
Public Class frm原材料入库质检
#Region "常量定义"
    Private mDtSearch As DataTable = Nothing
    Private Enum ENU_GRID As Integer
        采购单编号 = 0
        原材料编号 = 1
        原材料名称 = 2
        批次号 = 3
        长 = 4
        宽 = 5
        高 = 6
        供应商批次号 = 7
        申请日期 = 8
        申请者 = 9
        入库数量 = 10
        入库重量 = 11
        检查内容 = 12
        检查数量 = 13
        不良数量 = 14
        不良原因 = 15
        处理结果 = 16
        备注 = 17

    End Enum
#End Region
#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    ' Private mDtSearch As DataTable = Nothing
    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable

#End Region

#Region "Form Event"

    Private Sub frm原材料入库质检_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frm原材料入库质检_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm原材料入库质检_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
                    'btnF5直接入库.Focus()
                    'btnF5直接入库_Click(Nothing, Nothing)




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

   
    Private Sub grid原材料入库质检_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdList.InitializeLayout
        grdList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False

    End Sub

#End Region

#Region "Button Event"

    Private Sub btnF5直接入库_Click(ByVal sender As Object, ByVal e As EventArgs)

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

            ''关闭画面对话框

            'If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgNo Then
            '    '    '処理終了
            '    Exit Sub
            'End If

            'Me.Cursor = Cursors.WaitCursor

            ' ''画面の終了処理

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

        Dim objB原材料入库申请T As New B原材料入库申请T

        Dim objBll As New BLLM原材料入库申请T

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


            objB原材料入库申请T.申请单编号 = txt入库申请单编号.Text.Trim

            If objBll.Deletezj(objB原材料入库申请T) > 0 Then

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



        Dim frmSearch As frm原材料入库申请一览
        Try

            frmSearch = New frm原材料入库申请一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt入库申请单编号.Text = frmSearch.ReturnTable.Rows(0)("申请单编号")     '申请

                    Me.txt检查者编号.Focus()

                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放                frmSearch.Dispose()
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
    Private Sub txt人员编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt检查者编号.Leave
        Dim objM人员T As M人员T
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt检查者编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt检查者编号.Text.Trim <> String.Empty Then

                If Me.txt检查者编号.Tag = Me.txt检查者编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt检查者编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                objM人员T = objBLLM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员名 <> String.Empty Then


                    Me.txt检查者名称.Text = objM人员T.人员名     '客户名称


                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "检查者名称")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt检查者名称.Text = String.Empty
                    Me.txt检查者编号.Select()
                End If
            Else
                Me.txt检查者编号.Text = String.Empty
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
            'SetGridStyle()
            '画面のComboの初期値を設定する
            'Me.SetCombo()

            '画面の内容を清空処理
            Me.ClearForm()
            SetFormData()
            '権限の処理            Me.SetPermission()

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
            Me.txt申请者名称.Text = String.Empty
            Me.txt申请日期.Text = String.Empty
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
            Dim objM原材料入库质检T As New B原材料入库质检T
            Dim objBll As New BLLZ原材料入库质检T
            Dim arryList As New ArrayList

            If grdList.Rows.Count > 0 Then

                For i = 0 To grdList.Rows.Count - 1
                    objM原材料入库质检T = New B原材料入库质检T
                    objM原材料入库质检T.申请单编号 = Me.txt入库申请单编号.Text.Trim
                    objM原材料入库质检T.检查者编号 = Me.txt检查者编号.Text.Trim
                    objM原材料入库质检T.检查日期 = DateTime.Now
                    objM原材料入库质检T.材料编号 = grdList.Rows(i).Cells("原材料编号").Value.ToString()
                    'objM原材料入库质检T.订单编号 = grdList.Rows(i).Cells("订单编号").Value.ToString()
                    objM原材料入库质检T.长 = grdList.Rows(i).Cells("长").Value.ToString()
                    objM原材料入库质检T.宽 = grdList.Rows(i).Cells("宽").Value.ToString()
                    objM原材料入库质检T.高 = grdList.Rows(i).Cells("高").Value.ToString()
                    objM原材料入库质检T.检查内容 = grdList.Rows(i).Cells("检查内容").Value.ToString()
                    objM原材料入库质检T.检查数量 = grdList.Rows(i).Cells("检查数量").Value.ToString()
                    objM原材料入库质检T.不良数量 = grdList.Rows(i).Cells("不良数量").Value.ToString()
                    objM原材料入库质检T.不良原因 = grdList.Rows(i).Cells("不良原因").Value.ToString()
                    objM原材料入库质检T.处理结果 = grdList.Rows(i).Cells("处理结果").Value.ToString()
                    objM原材料入库质检T.备注 = grdList.Rows(i).Cells("备注").Value.ToString()
                    arryList.Add(objM原材料入库质检T)

                Next

            End If


            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_New

                    If objBll.insertCheck(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
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

            '客户名            If Me.txt检查者编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "检查者编号", "检查者编号")
                txt检查者编号.Focus()
                Return False
            End If

            If grdList Is Nothing OrElse grdList.Rows.Count = 0 Then
                Return False
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

#Region "SetPermission"

    Private Sub SetPermission()
        Try

            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            'Me.btnF5直接入库.Enabled = Utility.PFn_GetAuth(Me.btnF5直接入库.Tag)
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
        Dim objZ原材料入库申请T As New B原材料入库申请T
        Dim objBll As BLLM原材料入库申请T

        Try
            '获取数据
            objZ原材料入库申请T = New B原材料入库申请T
            objBll = New BLLM原材料入库申请T


            objZ原材料入库申请T.申请单编号 = txt入库申请单编号.Text.Trim()

            If String.IsNullOrEmpty(objZ原材料入库申请T.申请单编号) Then
                objZ原材料入库申请T.申请单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAllHeadzj(objZ原材料入库申请T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                Me.txt入库申请单编号.Text = mdsInfoDataSet.Rows(0)("申请单编号").ToString()
                Me.txt检查者编号.Text = mdsInfoDataSet.Rows(0)("检查者编号").ToString()
                Me.txt检查者名称.Text = mdsInfoDataSet.Rows(0)("检查者名称").ToString()
                Me.txt申请者名称.Text = mdsInfoDataSet.Rows(0)("申请者").ToString()
                Me.txt申请日期.Text = mdsInfoDataSet.Rows(0)("申请日期").ToString()
                'Me.txt部门.Text = mdsInfoDataSet.Rows(0)("部门").ToString()
                'Me.dt申请日期.Text = mdsInfoDataSet.Rows(0)("申请日期").ToString()
            Else
                Me.txt入库申请单编号.Text = ""
                Me.txt检查者编号.Text = String.Empty
                Me.txt检查者名称.Text = String.Empty
                Me.txt申请者名称.Text = String.Empty
                Me.txt申请日期.Text = String.Empty

                'Me.txt部门.Text = String.Empty
                'Me.dt申请日期.Text = String.Empty
            End If

            mdsGridDataSet = objBll.LoadAllzj(objZ原材料入库申请T)
            'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
            grdList.DataSource = mdsGridDataSet
            'grid原材料入库申请.DisplayLayout.Bands(0).Columns("客户编号CD").Hidden = True

            'End If
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
#Region "SetFormData1"

    Private Sub SetFormData1()
        Dim objZ原材料入库申请T As New B原材料入库申请T
        Dim objBll As BLLM原材料入库申请T

        Try
            '获取数据
            objZ原材料入库申请T = New B原材料入库申请T
            objBll = New BLLM原材料入库申请T


            objZ原材料入库申请T.申请单编号 = txt入库申请单编号.Text.Trim()

            If String.IsNullOrEmpty(objZ原材料入库申请T.申请单编号) Then
                objZ原材料入库申请T.申请单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAllHeadzj1(objZ原材料入库申请T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                Me.txt入库申请单编号.Text = mdsInfoDataSet.Rows(0)("申请单编号").ToString()
                ' Me.txt检查者编号.Text = mdsInfoDataSet.Rows(0)("检查者编号").ToString()
                'Me.txt检查者名称.Text = mdsInfoDataSet.Rows(0)("检查者名称").ToString()
                Me.txt申请者名称.Text = mdsInfoDataSet.Rows(0)("申请者").ToString()
                Me.txt申请日期.Text = mdsInfoDataSet.Rows(0)("申请日期").ToString()
                'Me.txt部门.Text = mdsInfoDataSet.Rows(0)("部门").ToString()
                'Me.dt申请日期.Text = mdsInfoDataSet.Rows(0)("申请日期").ToString()
            Else
                Me.txt入库申请单编号.Text = ""
                'Me.txt检查者编号.Text = String.Empty
                ' Me.txt检查者名称.Text = String.Empty
                Me.txt申请者名称.Text = String.Empty
                Me.txt申请日期.Text = String.Empty

                'Me.txt部门.Text = String.Empty
                'Me.dt申请日期.Text = String.Empty
            End If

            mdsGridDataSet = objBll.LoadAllzj(objZ原材料入库申请T)
            'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
            grdList.DataSource = mdsGridDataSet
            'grid原材料入库申请.DisplayLayout.Bands(0).Columns("客户编号CD").Hidden = True

            'End If
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

#Region "SetData原材料"
    'Private Sub SetData原材料()
    '    Dim objM原材料采购T As New B原材料采购管理T
    '    Dim objBll As BllM原材料采购单管理T
    '    Try
    '        '获取数据
    '        objM原材料采购T = New B原材料采购管理T
    '        objBll = New BllM原材料采购单管理T
    '        objM原材料采购T.原材料编号 = grdList.ActiveRow.Cells("材料编号").Value.ToString()

    '        If String.IsNullOrEmpty(objM原材料采购T.原材料编号) Then
    '            objM原材料采购T.原材料编号 = " "
    '        End If
    '        If grdList.Rows(0).Cells("材料编号").Value.ToString <> String.Empty Then
    '            mDtSearch = objBll.SetData原材料(objM原材料采购T)
    '            If Not mDtSearch Is Nothing And mDtSearch.Rows.Count > 0 Then

    '                Me.grdList.ActiveRow.Cells(ENU_GRID.原材料编号).Value = mDtSearch.Rows(0)("原材料批号")
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.原材料名称).Value = mDtSearch.Rows(0)("原材料名称")
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.申请日期).Value = mDtSearch.Rows(0)("申请日期")
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.申请者名称).Value = mDtSearch.Rows(0)("申请者名称")
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.入库数量).Value = mDtSearch.Rows(0)("入库数量")
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.入库重量).Value = mDtSearch.Rows(0)("入库重量")
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.异常数量).Value = mDtSearch.Rows(0)("异常数量")
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.异常原因).Value = mDtSearch.Rows(0)("异常原因")
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.备注).Value = mDtSearch.Rows(0)("备注")
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.质检状态).Value = mDtSearch.Rows(0)("质检状态")


    '            Else
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.原材料编号).Value = String.Empty
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.原材料名称).Value = String.Empty
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.申请日期).Value = String.Empty
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.申请者名称).Value = String.Empty
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.入库数量).Value = String.Empty
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.入库重量).Value = String.Empty
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.异常数量).Value = String.Empty
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.异常原因).Value = String.Empty
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.备注).Value = String.Empty
    '                Me.grdList.ActiveRow.Cells(ENU_GRID.质检状态).Value = String.Empty

    '            End If
    '        End If

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub
#End Region

#Region "SetGridStyle"


#End Region

#End Region

    Private Sub txt入库申请单编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt入库申请单编号.Leave
        Try

            If txt入库申请单编号.Text = "" Then

                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor

                '検索を実行
                SetFormData1()

            End If

            '砂時計のカーソルが設定
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
#Region "DataSearch"

    Private Sub DataSearch()

        Dim objB原材料入库申请T As New B原材料入库申请T
        Dim objBll As New BLLM原材料入库申请T

        Try
            objB原材料入库申请T = New B原材料入库申请T

            objB原材料入库申请T.申请单编号 = Me.txt入库申请单编号.Text.Trim

            Me.grdList.DataSource = Nothing

            mDtSearch = objBll.LoadAllzj(objB原材料入库申请T)


            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.gridlist.PClear()
                '検索データを表示する
                Me.grdList.DataSource = mDtSearch


                'フォーカスの設定処理
                Me.txt入库申请单编号.Focus()
            Else
                '検索データを表示する
                Me.grdList.DataSource = mDtSearch
                Me.grdList.Focus()
                Me.grdList.ActiveRow = Me.grdList.Rows(0)
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
            Utility.PFn_SetGirdCombo(Me.grdList, "VM质检状态", ENU_GRID.处理结果)

            ' Utility.PFn_SetGirdCombo(Me.gridList, "VM供货方式", ENU_GRID.供货方式tudu)
        Catch ex As Exception

        End Try

    End Sub

#End Region
#Region "SetGridStyle"

    Private Sub SetGridStyle()
        Try
            Me.txt申请日期.Enabled = False
            With grdList.DisplayLayout.Bands(0)

                .Columns("申请日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("原材料编号").CellActivation = Activation.NoEdit
                .Columns("原材料名称").CellActivation = Activation.NoEdit
                .Columns("入库数量").CellActivation = Activation.NoEdit
                .Columns("供应商批次号").CellActivation = Activation.NoEdit
                .Columns("入库数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("检查数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("不良数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
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

    Private Sub btnF2编辑_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF2编辑.Click

        Dim frmSearch As frm原材料入库质检一览
        Try

            frmSearch = New frm原材料入库质检一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt入库申请单编号.Text = frmSearch.ReturnTable.Rows(0)("申请单编号")     '申请
                    Me.txt检查者编号.Text = frmSearch.ReturnTable.Rows(0)("检查者编号")     '申请
                    txt人员编号_Leave(Nothing, Nothing)
                    SetFormData()

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
End Class