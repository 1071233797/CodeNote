Imports Infragistics.Win.UltraWinGrid
Imports HRJS.Constant


Public Class frm原材料采购一览
#Region "変数定義"

    Private mds详细 As DataSet = Nothing                'grd详细
    Private mdt详细Band0 As System.Data.DataTable = Nothing                'grd详细
    Private mdt详细Band1 As System.Data.DataTable = Nothing                'grd详细
    Public str采购单编号 As String = String.Empty
    Public intDoubleClick As Integer = 0
    Public Bool As Boolean = False
    Dim i As Integer = 0

#End Region

#Region "Form Event"

    Private Sub frm原材料采购一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                Case Keys.F10
                    btn审核.Focus()
                    btn审核_Click(Nothing, Nothing)

                Case Keys.F11
                    btnF11原材料采购单打印.Focus()
                    btnF11原材料采购单打印_Click(Nothing, Nothing)

                Case Keys.F12
                    btnF12关闭.Focus()
                    btnF12关闭_Click(Nothing, Nothing)
                    e.Handled = True

                Case Else

            End Select

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try
    End Sub

    Private Sub frm原材料采购一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm原材料采购一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Dim strMSG As String = String.Empty
        Dim dt As New DataTable

        For Each dr As DataRow In dt.Rows

            If dr("流转票") & "" = "" Then
                If strMSG = String.Empty Then
                    strMSG = dr("产品图号")
                Else
                    strMSG = strMSG & "回车" & dr("产品图号")
                End If
            End If
        Next

        If strMSG <> "" Then

            If MsgBox(strMSG & "以上图号没有流转票信息，是否还要保存!", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            Else
                Exit Sub
            End If

        End If


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

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As System.Data.DataTable = Nothing            'コンボボックスデータテーブル

        Try

            Utility.PFn_SetCombo(Me.cob审核状态, "VM审核状态", 0)

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
            Me.Selection()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridList.InitializeLayout

        Try
            Dim intLoopi As Integer
            For index = 1 To gridList.DisplayLayout.Bands(0).Columns.Count - 1
                gridList.DisplayLayout.Bands(0).Columns(intLoopi).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Next
            gridList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    'Private Sub grdList_ClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles gridList.ClickCell
    '    If e.Cell.Equals(gridList.ActiveRow.Cells("选择")) Then
    '        Me.gridList.UpdateData()
    '    End If
    'End Sub
    Private Sub btnF11原材料采购单打印_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11原材料采购单打印.Click

        Dim objM原材料采购T As B原材料采购管理T
        Dim arrayList As ArrayList
        Dim rv As New ReportViewr
        Dim str采购单编号 As String = String.Empty
        Dim dt As New System.Data.DataTable
        Try

            If Me.gridList.Rows.Count = 0 Then
                MsgBox("请选择需要打印的数据")
                Exit Sub
            End If
            dt = gridList.DataSource.tables(0)

            str采购单编号 = String.Empty
            For Each drr As DataRow In dt.Rows

                If drr("选择") = 1 Then
                    If drr("审核状态") = "审核通过" Then
                        If str采购单编号 = String.Empty Then
                            str采购单编号 = drr("采购单编号")

                        Else
                            str采购单编号 = str采购单编号 & "','" & drr("采购单编号")

                        End If
                    Else
                        MsgBox("请选择审核通过的数据！！！")
                        Exit Sub
                    End If
                End If

            Next

            If str采购单编号 = String.Empty Then
                MsgBox(" 请选择打印的采购单。")
                Exit Sub
            End If

            Dim bllOp As New BllM原材料采购单管理T
            objM原材料采购T = New B原材料采购管理T
            objM原材料采购T.采购单编号 = str采购单编号
            Dim dts = bllOp.ReportViewr(objM原材料采购T)
            rv.ReportExportType = Constant.ReporyType.原材料采购单
            rv._CaiGou = objM原材料采购T
            'rv.DtOrg = dtOrg
            rv.DtSource = dts
            rv.ShowDialog()
            rv.Init_Load()
            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "打印")
        Catch ex As Exception
            ExHelper.ProcessEx(ex)
            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "打印")
        End Try
    End Sub
    ' lxq 2017-04-21 add
    Private Sub btn审核_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn审核.Click
        Dim frmSearch As frm审核
        Dim objM原材料采购T As New B原材料采购管理T
        Dim objBll As New BllM原材料采购单管理T
        Dim str采购单编号 As String = String.Empty
        Dim dt As New DataTable
        Try

            '没有数据退出该方法
            If gridList.Rows.Count = 0 Then
                MsgBox("请选择需要审核的数据")
                Exit Sub
            End If
            If gridList.ActiveRow.Cells Is Nothing Then
                MsgBox("请选择需要审核的数据")
                Exit Sub
            End If

            '获取所有所选择的需要审核的采购单编号
            dt = gridList.DataSource.tables(0)
            For Each drr As DataRow In dt.Rows
                objM原材料采购T = New B原材料采购管理T
                If drr("选择") = 1 Then
                    If str采购单编号 = String.Empty Then
                        str采购单编号 = drr("采购单编号")
                    Else
                        str采购单编号 = str采购单编号 & "','" & drr("采购单编号")
                    End If
                End If
            Next
            objM原材料采购T.采购单编号 = str采购单编号
            frmSearch = New frm审核
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = 1 Then

                '根据检索画面数据进行设置
                objM原材料采购T.审核状态 = frmSearch.cmb审核状态.Value
                objM原材料采购T.审核备注 = frmSearch.txt审核备注.Text
                objM原材料采购T.审核人编号 = gObjM_人员T.人员编号

                '判断是否有审核数据
                If frmSearch.cmb审核状态.Value <> String.Empty Then

                    '修改采购单表的审核数据

                    If objBll.Update审核(objM原材料采购T) > 0 Then
                        '提示审核成功
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "审核")
                    End If
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

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    ' lxq 2017-04-21 end
#End Region

    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                       ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                       Handles gridList.DoubleClickRow

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
#Region "Control Event"

#Region "供应商编号"

    Private Sub txt供应商编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt供应商编号.Enter

        Try

            Me.txt供应商编号.Tag = Me.txt供应商编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt供应商编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt供应商编号.EditorButtonClick


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


    Private Sub txt供应商编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt供应商编号.Validating

        Dim objM供应商T As M供应商T
        Dim dtM供应商T As System.Data.DataTable
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

                objM供应商T = objBllM供应商T.LoadByPKey(objM供应商T)

                If objM供应商T.供应商编号 <> String.Empty Then

                    Me.txt供应商名称.Text = objM供应商T.供应商名称

                Else
                    Me.txt供应商名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "供应商编号")
                    Me.txt供应商编号.Select()
                End If
            Else
                Me.txt供应商编号.Text = String.Empty
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

    Private Sub txt原材料编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt原材料编号.Enter

        Try

            Me.txt原材料编号.Tag = Me.txt原材料编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt原材料编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt原材料编号.EditorButtonClick


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


    Private Sub txt原材料编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt原材料编号.Validating

        Dim objM原材料T As M原材料信息T
        Dim dtM原材料T As System.Data.DataTable
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

    '#Region "客户编号"

    '    Private Sub txt客户编号_Enter(ByVal sender As Object, ByVal e As EventArgs)

    '        Try

    '            Me.txt客户编号.Tag = Me.txt客户编号.Text.Trim

    '        Catch ex As Exception
    '            '異常処理
    '            ExHelper.ProcessEx(ex)
    '        End Try

    '    End Sub

    '    Private Sub txt客户编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs)


    '        Dim frmSearch As frm客户一览

    '        Try

    '            frmSearch = New frm客户一览

    '            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

    '            '工程信息查询画面打开
    '            frmSearch.ShowDialog()

    '            '画面数据设置
    '            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

    '                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

    '                    '根据检索画面数据进行设置


    '                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")     '客户编号

    '                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")     '客户名称


    '                End If

    '                If Not frmSearch.ReturnTable Is Nothing Then
    '                    '检索画面释放


    '                    frmSearch.ReturnTable.Dispose()
    '                    frmSearch.ReturnTable = Nothing
    '                End If

    '                '检索画面释放


    '                frmSearch.Dispose()
    '                frmSearch = Nothing

    '            End If

    '            '光标设置
    '            Me.Cursor = Cursors.Default
    '        Catch ex As Exception
    '            '异常处理
    '            ExHelper.ProcessEx(ex)
    '        Finally
    '            '默认光标设置
    '            Me.Cursor = Cursors.Default
    '        End Try

    '    End Sub


    '    Private Sub txt客户编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

    '        Dim objM客户T As M客户T
    '        Dim dtM客户T As DataTable
    '        Dim objBllM客户T As BLLM客户T

    '        Try

    '            If txt客户编号.ReadOnly Then
    '                Exit Sub
    '            End If


    '            If Me.txt客户编号.Text.Trim <> String.Empty Then

    '                If Me.txt客户编号.Tag = Me.txt客户编号.Text.Trim Then
    '                    Exit Sub
    '                End If
    '                objM客户T = New M客户T

    '                objM客户T.客户编号 = txt客户编号.Text.Trim

    '                objBllM客户T = New BLLM客户T

    '                objM客户T = objBllM客户T.LoadByPKey(objM客户T)

    '                If objM客户T.客户编号 <> String.Empty Then

    '                    Me.txt客户名称.Text = objM客户T.客户名称
    '                Else
    '                    Me.txt客户名称.Text = String.Empty
    '                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "客户编号")
    '                    Me.txt客户编号.Select()
    '                End If
    '            Else
    '                Me.txt客户编号.Text = String.Empty
    '            End If

    '        Catch ex As Exception
    '            '異常処理
    '            ExHelper.ProcessEx(ex)
    '        Finally
    '            'デフォルトのカーソル
    '            Me.Cursor = Cursors.Default
    '        End Try
    '    End Sub

    '#End Region

#Region "订单编号"

    Private Sub txt订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick

        Dim frmSearch订单 As frm订单一览

        Try
            frmSearch订单 = New frm订单一览

            frmSearch订单.FormOpenMode = Constant.ENU_MODE.Model_Ref
            frmSearch订单.ShowDialog()

            '画面数据设置
            If frmSearch订单.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch订单.ReturnTable Is Nothing AndAlso 0 < frmSearch订单.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt订单编号.Text = frmSearch订单.ReturnTable.Rows(0)("订单编号")     '部品番号

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
    ''' 
    Private Sub InitForm()

        Try
            'Grid初始化
            SetCombo()
            Me.InitGrid()

            SetButtonStatus()

            Utility.PFn_SetCombo(cob原材料区分, "VM材料区分", 0)
            Utility.PFn_SetCombo(cmb采购状态, "VM采购状态", 0)
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

#Region "InitGrid"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitGrid()
        Try
            mdt详细Band0 = New System.Data.DataTable

            mdt详细Band0.Columns.Add("选择")
            mdt详细Band0.Columns.Add("采购单编号")
            mdt详细Band0.Columns.Add("申请日期")
            mdt详细Band0.Columns.Add("供应商名称")
            mdt详细Band0.Columns.Add("税率(%)")
            mdt详细Band0.Columns.Add("采购状态")
            mdt详细Band0.Columns.Add("审核状态")
            mdt详细Band0.Columns.Add("审核人")
            mdt详细Band0.Columns.Add("审核备注")
            'mdt详细Band0.Columns.Add("审核状态")
            mdt详细Band0.Columns.Add("作成者")
            mdt详细Band0.Columns.Add("备注")
            gridList.DataSource = mdt详细Band0

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
            txt采购单编号.Text = str采购单编号

            txt原材料编号.Text = String.Empty
            txt原材料名称.Text = String.Empty
            txt订单编号.Text = String.Empty
            'If cob原材料区分.Rows.Count > 0 Then
            '    cob原材料区分.Rows(0).Selected = False
            'End If
            cob原材料区分.Text = String.Empty
            txt供货日期From.Text = DateAdd("M", -1, Now)
            txt供货日期To.Text = Date.Now
            txt供应商编号.Text = String.Empty
            txt供应商名称.Text = String.Empty
            Me.cob审核状态.Text = String.Empty
            Me.cmb采购状态.Text = String.Empty
            'txt客户编号.Text = String.Empty
            'txt客户名称.Text = String.Empty
            Me.txt采购单编号.Select()

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
            Me.btnF11原材料采购单打印.Enabled = Utility.PFn_GetAuth(Me.btnF11原材料采购单打印.Tag)

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
            If Not String.IsNullOrEmpty(txt供货日期From.Text.Trim) And Not String.IsNullOrEmpty(txt供货日期To.Text.Trim) Then
                If DateTime.Parse(txt供货日期From.DateTime) > DateTime.Parse(txt供货日期To.DateTime) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "发货日期", "发货日期")
                    txt供货日期From.Focus()
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

        Dim objM采购T As B原材料采购管理T
        Dim objBllM采购T As New BllM原材料采购单管理T

        Try
            If Not InputCheck() Then
                Exit Sub
            End If
            objM采购T = New B原材料采购管理T
            If Bool = True Then
                objM采购T.区分 = True
            End If
            objM采购T.采购单编号 = Me.txt采购单编号.Text.Trim
            objM采购T.材料区分 = Me.cob原材料区分.Value
            objM采购T.原材料编号 = Me.txt原材料编号.Text.Trim
            objM采购T.订单编号 = txt订单编号.Text.Trim
            objM采购T.审核状态 = Me.cob审核状态.Value
            objM采购T.采购状态 = Me.cmb采购状态.Value
            objM采购T.供应商编号 = Me.txt供应商编号.Text.Trim
            'objM采购T.客户编号 = Me.txt客户编号.Text.Trim
            If (Not Me.txt供货日期From.Text.Trim = String.Empty) Then
                objM采购T.供货日期 = txt供货日期From.Text.Trim
            Else
                objM采购T.供货日期 = Constant.CGSTRDATE_DEFAULT
            End If
            If (Not Me.txt供货日期To.Text.Trim = String.Empty) Then
                objM采购T.供货日期2 = Me.txt供货日期To.Text.Trim
            Else
                objM采购T.供货日期2 = Constant.CGSTRDATE_DEFAULT
            End If

            '查询の検索処理

            mds详细 = New DataSet

            'mdt详细Band0データを記録テーブル初期化

            Me.mdt详细Band0 = New System.Data.DataTable
            mdt详细Band0 = objBllM采购T.LoadBand0(objM采购T)

            'mdt详细Band1データを記録テーブル初期化


            Me.mdt详细Band1 = New System.Data.DataTable
            mdt详细Band1 = objBllM采购T.LoadBand1(objM采购T)

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

            parentCols(0) = mds详细.Tables(0).Columns("采购单编号")
            childCols(0) = mds详细.Tables(1).Columns("采购单编号")
            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mds详细.Relations.Add(drBand(0))


            'ReDim parentCols(1)
            'ReDim childCols(1)


            'parentCols(0) = mds详细.Tables(1).Columns("采购单编号")
            'childCols(0) = mds详细.Tables(2).Columns("采购单编号")

            'parentCols(1) = mds详细.Tables(1).Columns("材料编号")
            'childCols(1) = mds详细.Tables(2).Columns("材料编号")

            'drBand(1) = New DataRelation("表示", parentCols, childCols, False)
            'mds详细.Relations.Add(drBand(1))

            If mds详细 Is Nothing OrElse mds详细.Tables(0).Rows.Count = 0 Then

                '結果０件ＭＳＧ出力


                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.gridList.DataSource = Nothing
                InitGrid()
                'フォーカスの設定処理
                Me.txt采购单编号.Focus()
            Else

                '検索データを表示する
                Me.gridList.DataSource = mds详细
                Me.gridList.Focus()
                Me.gridList.ActiveRow = Me.gridList.Rows(0)
                SetGridStyle()
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

#Region "SetGridStyle"

    Private Sub SetGridStyle()
        Try
            With gridList.DisplayLayout.Bands(0)
                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("选择").CellActivation = Activation.AllowEdit
                .Columns("申请日期").CellActivation = Activation.NoEdit

            End With

            With gridList.DisplayLayout.Bands(1)
                .Columns("长").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("宽（直径）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("高（厚度）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("订单数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("计划采购数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("实际采购数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("计划采购重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("实际采购重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("含税单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("含税总金额").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("未税单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("未税总金额").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("供货日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("供货日期").CellActivation = Activation.NoEdit
                .Columns("采购单编号").Hidden = True
                '.Columns("采购单编号CD").Hidden = True
                '.Columns("单价修改状态").Hidden = True
                ' .Columns("客户编号").Hidden = True


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

        Dim objBll原材料采购 As New BllM原材料采购单管理T
        Dim objCls As New B原材料采购管理T


        'Dim objBll As New BLLM原材料信息T
        'Dim objM原材料T As New M原材料信息T
        Try
            '选择行が無い場合
            If Me.gridList.ActiveRow Is Nothing Then
                'メッセージ表示
                'CommonMsg.ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID25)
                '処理終了
                Exit Sub
            End If
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If
            If intDoubleClick = 1 Then
                If Me.gridList.ActiveRow.Cells.Count < 1 Then
                    MsgBox("请选择原材料。")
                    Exit Sub
                Else
                    objCls.原材料编号 = Me.gridList.ActiveRow.Cells("材料编号").Text.Trim

                    ReturnTable = objBll原材料采购.LoadAllHead(objCls)
                End If
            ElseIf intDoubleClick = 2 Then
                If Me.gridList.ActiveRow.Cells.Count < 13 Then
                    If Me.gridList.ActiveRow.Cells("审核状态").Value <> "审核通过" Then
                        MsgBox("请选择审核通过的数据。")
                        Exit Sub
                    End If

                End If

                objCls.采购单编号 = Me.gridList.ActiveRow.Cells("采购单编号").Text.Trim

                'テーブルにデータを追加
                ReturnTable = objBll原材料采购.LoadAll(objCls)
            Else
                objCls.采购单编号 = Me.gridList.ActiveRow.Cells("采购单编号").Text.Trim

                'テーブルにデータを追加
                ReturnTable = objBll原材料采购.LoadAll(objCls)
            End If



            '查询の选择されたレCDを取得する

            'For intRows = 0 To Me.gridList.Rows.Count - 1
            '    gridList.Rows(intRows).Cells(0).Value = True
            'Next

            If ReturnTable Is Nothing OrElse ReturnTable.Rows.Count = 0 Then
                'メッセージ表示
                'CommonMsg.ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID26)
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
    Private Sub PringReport(ByRef i As Integer)

        Dim rv As New ReportViewr
        Dim objModel As B原材料采购管理T
        Try
            objModel = New B原材料采购管理T
            objModel.采购单编号 = gridList.ActiveRow.Cells("采购单编号").Text
            Dim bllOp As New BllM原材料采购单管理T
            Dim dt = bllOp.ReportViewr(objModel)

            rv.ReportExportType = Constant.ReporyType.原材料采购单
            rv._CaiGou = objModel
            'rv.DtOrg = dtOrg
            rv.DtSource = dt
            rv.ShowDialog()
            rv.Init_Load()

            'rv.Print()
        Catch ex As Exception
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try


    End Sub
#End Region
End Class