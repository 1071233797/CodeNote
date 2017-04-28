Imports HRJS.Constant
Imports Infragistics.Win.UltraWinGrid
Imports System.Text

Public Class frm外协加工管理

#Region "常量定义"

    Private Enum ENU_GRID As Integer
        选择 = 0
        订单编号 = 1
        主图号 = 2
        上级图号 = 3
        分图号 = 4
        客户名称 = 5
        外协状态 = 6
        外协加工数量 = 7
        外协工序 = 8
        回厂日期 = 9
        原材料 = 10
        实际带料数量 = 11
        加工单价 = 12
        加工总金额 = 13
        备注 = 14
        审核状态 = 15
        审核人 = 16
    End Enum

#End Region

#Region "変数定義"
    Private mDtSearch As DataTable = Nothing
    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Private dsReturn As DataSet
    Private str审核状态 As String
    Private str审核人 As String
    Private str审核备注 As String
    Private str As Integer
    Private mds As Integer
#End Region

#Region "Form Event"

    Private Sub frm外协加工管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            '画面の初期化処理
            Me.InitForm()
            BindGridCombox()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frm外协加工管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            'If Me.btnLogoOff.Text.ToString.Contains(CSTRLOGOFF) Then

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

    Private Sub frm外协加工管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                Case Keys.F2
                    btnF2编辑.Focus()
                    btnF2编辑_Click(Nothing, Nothing)

                Case Keys.F3
                    btnF3保存.Focus()
                    btnF3保存_Click(Nothing, Nothing)

                Case Keys.F4
                    btnF4删除.Focus()
                    btnF4删除_Click(Nothing, Nothing)

                Case Keys.F5
                    btnF5行追加.Focus()
                    btnF5行追加_Click(Nothing, Nothing)

                Case Keys.F6
                    btnF6行删除.Focus()
                    btnF6行删除_Click(Nothing, Nothing)

                Case Keys.F10
                    btnF10.Focus()
                    btnF10_Click(Nothing, Nothing)

                Case Keys.F11
                    btnF11.Focus()
                    btnF11_Click(Nothing, Nothing)

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

            Me.Cursor = Cursors.WaitCursor

            mIntFormMode = Constant.ENU_MODE.Model_New
            ClearForm()
            SetFormModel()

            ''画面の初期化処理



        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF2编辑_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2编辑.Click

        Dim frmSearch As frm外协加工一览
        Try

            frmSearch = New frm外协加工一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt外协订单编号.Text = frmSearch.ReturnTable.Rows(0)("外协计划单号").ToString.Trim
                    mIntFormMode = Constant.ENU_MODE.Model_Update
                    DataSearch(True)
                    If grid外协加工管理.Rows.Count = 0 Then
                        Exit Sub
                    Else

                        If grid外协加工管理.ActiveRow.Cells(ENU_GRID.外协状态).Value = "已出厂" Then
                            grid外协加工管理.DisplayLayout.Bands(0).Columns(ENU_GRID.外协状态).CellActivation = Activation.NoEdit
                        End If
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

                '画面の修正処理
                mIntFormMode = Constant.ENU_MODE.Model_Update
                SetFormModel()

                If str审核状态 = "1" Then
                    If Me.btnF11.Enabled = False Then
                        Me.txt外协订单编号.ReadOnly = True
                        Me.txt外协对象.ReadOnly = True
                        Me.grid外协加工管理.Enabled = False
                        Me.btnF3保存.Enabled = False
                        Me.btnF4删除.Enabled = False
                        Me.btnF5行追加.Enabled = False
                        Me.btnF6行删除.Enabled = False
                    Else
                        Me.txt外协订单编号.ReadOnly = False
                        Me.txt外协对象.ReadOnly = False

                        Me.grid外协加工管理.Enabled = True
                        Me.btnF3保存.Enabled = True
                        Me.btnF4删除.Enabled = True
                        Me.btnF5行追加.Enabled = True
                        Me.btnF6行删除.Enabled = True
                    End If
                Else
                    Me.txt外协订单编号.ReadOnly = False
                    Me.txt外协对象.ReadOnly = False
                    Me.grid外协加工管理.Enabled = True
                    Me.btnF3保存.Enabled = True
                    Me.btnF4删除.Enabled = True
                    Me.btnF5行追加.Enabled = True
                    Me.btnF6行删除.Enabled = True
                End If

                'cob部门类别.Select()
            End If



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

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objM外协加工T As New B外协加工管理T

        Dim objBll As New BllM外协加工管理T

        Try

            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If String.IsNullOrEmpty(txt外协订单编号.Text.Trim) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If
            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objM外协加工T.外协订单编号 = txt外协订单编号.Text.Trim

            If objBll.Delete(objM外协加工T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
            ClearForm()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF5行追加_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF5行追加.Click

        Dim dr As DataRow
        Dim intRow As Integer
        Try

            '画面のCheck処理
            If Not AddCheck() Then
                Exit Sub
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
        If Me.grid外协加工管理.Rows.Count = 0 Then
            intRow = 0
        Else
            intRow = Me.grid外协加工管理.Rows.Count
        End If

        Dim tmpTable As New DataTable

        tmpTable = dsReturn.Tables(1).Copy()

        dr = dsReturn.Tables(1).NewRow

        dsReturn.Tables(1).Rows.Add(dr)
        dsReturn.Tables(1).AcceptChanges()

        With Me.grid外协加工管理
            .ActiveRow = .Rows(intRow)
            .Rows(intRow).Cells(0).Activate()
            '.ActiveRow.Cells(ENU_GRID.作成者编号).Value = gObjM_人员T.人员编号
            '.ActiveRow.Cells(ENU_GRID.作成者姓名).Value = gObjM_人员T.人员名
            .UpdateData()
            .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)

        End With

    End Sub

    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click

        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If Me.grid外协加工管理.ActiveRow Is Nothing Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            '「選択された行を削除してもよろしいですか？」
            If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID4) = _
                                                     ENU_SHOWMSG.showMsgNo Then
                '登録処理終了
                Me.Cursor = Cursors.Default
                Return
            End If


            intRow = Me.grid外协加工管理.ActiveRow.VisibleIndex

            intRowDelete = Me.grid外协加工管理.ActiveRow.Index

            Me.grid外协加工管理.Rows(intRowDelete).Delete(False)

            If Me.grid外协加工管理.Rows.VisibleRowCount = 0 Or Me.grid外协加工管理.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If Me.grid外协加工管理.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf Me.grid外协加工管理.Rows.VisibleRowCount = intRow Then
                    intRow = Me.grid外协加工管理.Rows.VisibleRowCount - 1
                End If

                Me.grid外协加工管理.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                Me.grid外协加工管理.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.grid外协加工管理.UpdateData()
            End If


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnF10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF10.Click, btnF10.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            ''订单导入
            ImportData()


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnF11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11.Click

        Dim frmSearch As frm审核
        Try
            frmSearch = New frm审核
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = 1 Then

                'If frmSearch.ReturnType <> String.Empty Then

                '根据检索画面数据进行设置                str审核状态 = frmSearch.cmb审核状态.Value
                str审核备注 = frmSearch.txt审核备注.Text
                str审核人 = gObjM_人员T.人员名
                '设置画面数据
                Update审核()
                'If frmSearch.cmb审核状态.Value = "2" Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "审核")

                'End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing

                End If

                '检索画面释放                frmSearch.Dispose()
                frmSearch = Nothing


                '画面の修正処理                mIntFormMode = Constant.ENU_MODE.Model_Update
                SetFormModel()

            End If

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
    Private Sub btn查询_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn查询.Click
        Try


            '砂時計のカーソルが設定
            Me.Cursor = Cursors.WaitCursor

            '検索を実行
            Me.DataSearch(False)
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
                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号")          '订单编号
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
                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")          '产品图号
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
    Private Sub txt外协对象_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt外协对象.EditorButtonClick
        Dim frmSearch As frm外协对象一览
        Try

            frmSearch = New frm外协对象一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt外协对象.Text = frmSearch.ReturnTable.Rows(0)("外协对象编号")          '外协对象编号
                    Me.txt外协对象名称.Text = frmSearch.ReturnTable.Rows(0)("外协对象名称")      '外协对象名称
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
    Private Sub txt外协对象_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt外协对象.Validating

        Dim objM外协对象T As M外协对象T
        Dim objBllM外协对象T As BLLM外协对象T

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

                objBllM外协对象T = New BLLM外协对象T

                objM外协对象T = objBllM外协对象T.LoadByPKey(objM外协对象T)

                If objM外协对象T.外协对象编号 <> "" Then

                    Me.txt外协对象名称.Text = objM外协对象T.外协对象名称

                    'Me.txt税率.Text = objM供应商T.税率
                Else
                    Me.txt外协对象.Text = String.Empty
                    Me.txt外协对象名称.Text = String.Empty
                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "供应商名称")
                    Me.txt外协对象.Select()
                End If
            Else
                Me.txt外协对象名称.Text = String.Empty
                'Me.txt税率.Text = String.Empty
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub txt外协对象_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt外协对象.Leave
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

                    Me.txt外协对象名称.Text = objM外协对象T.外协对象名称     '客户名称

                Else
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "外协对象")
                    Me.txt外协对象名称.Text = String.Empty
                    Me.grid外协加工管理.Select()
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
#End Region
#Region "Grid Event"


    Private Sub grid外协加工管理_ClickCellButton(ByVal sender As Object, ByVal e As CellEventArgs) Handles grid外协加工管理.ClickCellButton


        'Dim frmSearch外协 As frm外协申请一览
        'Try

        '    If Me.grid外协加工管理.ActiveCell Is Nothing Then
        '        Exit Sub
        '    End If



        '    'If Me.grid外协加工管理.DisplayLayout.Bands(0).Columns(ENU_GRID.订单编号).CellActivation = Activation.NoEdit Then
        '    '    Exit Sub
        '    'End If

        '    If Me.grid外协加工管理.ActiveRow.Cells(ENU_GRID.订单编号).Activation = Activation.NoEdit Then
        '        Exit Sub
        '    End If

        '    '砂時計のカーソルが設定
        '    Me.Cursor = Cursors.WaitCursor

        '    frmSearch外协 = New frm外协申请一览
        '    frmSearch外协.FormOpenMode = Constant.ENU_MODE.Model_Search
        '    frmSearch外协.ShowDialog()

        '    '画面数据设置
        '    If frmSearch外协.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

        '        If Not frmSearch外协.ReturnTable Is Nothing AndAlso 0 < frmSearch外协.ReturnTable.Rows.Count Then

        '            '根据检索画面数据进行设置
        '            Me.grid外协加工管理.ActiveRow.Cells(ENU_GRID.订单编号).Value = frmSearch外协.ReturnTable.Rows(0)("订单编号")     '部品番号
        '            Me.grid外协加工管理.ActiveRow.Cells(ENU_GRID.产品图号).Value = frmSearch外协.ReturnTable.Rows(0)("产品图号")
        '            Me.grid外协加工管理.ActiveRow.Cells(ENU_GRID.主图号).Value = frmSearch外协.ReturnTable.Rows(0)("主图号")
        '            Me.grid外协加工管理.ActiveRow.Cells(ENU_GRID.客户名称).Value = frmSearch外协.ReturnTable.Rows(0)("客户名称")
        '            Me.grid外协加工管理.ActiveRow.Cells(ENU_GRID.外协加工数量).Value = frmSearch外协.ReturnTable.Rows(0)("加工数量")
        '            Me.grid外协加工管理.ActiveRow.Cells(ENU_GRID.外协工序).Value = frmSearch外协.ReturnTable.Rows(0)("外协工序")
        '            Me.grid外协加工管理.ActiveRow.Cells(ENU_GRID.客户编号).Value = frmSearch外协.ReturnTable.Rows(0)("客户编号")
        '        End If
        '        If Not frmSearch外协.ReturnTable Is Nothing Then
        '            '检索画面释放

        '            frmSearch外协.ReturnTable.Dispose()
        '            frmSearch外协.ReturnTable = Nothing
        '            frmSearch外协.ReturnTable = Nothing
        '        End If
        '        '检索画面释放

        '        frmSearch外协.Dispose()
        '        frmSearch外协 = Nothing
        '    End If

        '    grid外协加工管理.UpdateData()

        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try
    End Sub
    Private Sub grid外协加工管理_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid外协加工管理.CellChange
        Try
            If grid外协加工管理.DataSource Is Nothing OrElse grid外协加工管理.Rows.Count = 0 Then
                Exit Sub
            End If
            grid外协加工管理.UpdateData()

            If Not IsDBNull(grid外协加工管理.ActiveRow.Cells("加工单价").Value) Then
                If Not IsDBNull(grid外协加工管理.ActiveRow.Cells(ENU_GRID.外协加工数量).Value) Then
                    grid外协加工管理.ActiveRow.Cells(ENU_GRID.加工总金额).Value = _
                        grid外协加工管理.ActiveRow.Cells("加工单价").Value * grid外协加工管理.ActiveRow.Cells(ENU_GRID.外协加工数量).Value
                Else
                    grid外协加工管理.ActiveRow.Cells(ENU_GRID.加工总金额).Value = 0

                End If
            End If
            Me.grid外协加工管理.UpdateData()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub grid外协加工管理_InitializeLayout(ByVal sender As Object, ByVal e As InitializeLayoutEventArgs) Handles grid外协加工管理.InitializeLayout
        grid外协加工管理.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid外协加工管理.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        grid外协加工管理.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
    End Sub

    Private Sub grid外协加工管理_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
        grid外协加工管理.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
    End Sub

    Private Sub grid外协加工管理_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

        If grid外协加工管理.Rows.Count = 0 Then
            Exit Sub
        End If

        If grid外协加工管理.ActiveCell.Equals(grid外协加工管理.Rows(grid外协加工管理.Rows.Count - 1).Cells(ENU_GRID.备注)) Then
            Exit Sub
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
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
            SetGridStyle()
            '画面の内容を清空処理
            Me.ClearForm()
            Me.SetFormModel()
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
            Me.txt订单编号.Text = String.Empty
            Me.txt外协工序.Text = String.Empty
            Me.txt产品图号.Text = String.Empty
            Me.txt外协订单编号.Text = "WXJH" & Now.ToString("yyyyMMddhhmmss")
            Me.txt外协对象.Text = String.Empty
            Me.txt外协对象名称.Text = String.Empty
            DataSearch1()
            Me.txt订单编号.Select()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region
#Region "DataSearch1"

    Private Sub DataSearch1()

        Dim objModel As B外协加工管理T

        Dim objBll As New BllM外协加工管理T

        Try
            objModel = New B外协加工管理T
            '查询の検索処理
            objModel.外协订单编号 = Me.txt外协订单编号.Text.Trim

            If String.IsNullOrEmpty(objModel.外协订单编号) Then
                objModel.外协订单编号 = " "
            End If

            dsReturn = objBll.LoadDsByWhere(objModel)

            If dsReturn.Tables.Count = 0 Then
                Exit Sub
            End If

            '新规
            'If mIntFormMode <> Constant.ENU_MODE.Model_New Then
            '显示订单信息
            If dsReturn.Tables(0).Rows.Count > 0 Then
                Me.txt外协订单编号.Text = dsReturn.Tables(0).Rows(0)("外协订单编号").ToString()
                Me.txt外协对象.Text = dsReturn.Tables(0).Rows(0)("外协对象").ToString()
                str审核状态 = dsReturn.Tables(1).Rows(0)("审核状态").ToString()
                str审核人 = dsReturn.Tables(1).Rows(0)("审核人").ToString()
            Else
                'Me.txt外协订单编号.Text = String.Empty
                Me.txt外协对象.Text = String.Empty

                str审核状态 = String.Empty
                str审核人 = String.Empty
            End If

            If dsReturn.Tables(1) Is Nothing OrElse dsReturn.Tables(1).Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                Me.grid外协加工管理.DataSource = dsReturn.Tables(1)

            Else
                Me.grid外协加工管理.DataSource = dsReturn.Tables(1)

                Me.grid外协加工管理.Focus()
                Me.grid外协加工管理.ActiveRow = Me.grid外协加工管理.Rows(0)
                BindGridCombox()
            End If

            'BindGridCombox()

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

    Private Sub DataSearch(ByVal strFlg As Boolean)

        Dim objB外协加工T As B外协加工管理T

        Dim objBLLM外协加工T As New BllM外协加工管理T
        Try
            objB外协加工T = New B外协加工管理T
            objBLLM外协加工T = New BllM外协加工管理T
            objB外协加工T.订单编号 = Me.txt订单编号.Text.Trim
            objB外协加工T.主图号 = Me.txt产品图号.Text.Trim
            objB外协加工T.外协工序 = Me.txt外协工序.Text.Trim

            If strFlg = True Then
                objB外协加工T.区分1 = 1
            Else
                objB外协加工T.区分1 = 2
            End If

            Me.grid外协加工管理.DataSource = Nothing
            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New
                    objB外协加工T.区分 = 1

                    dsReturn = objBLLM外协加工T.LoadByWhere(objB外协加工T)

                    If dsReturn Is Nothing OrElse dsReturn.Tables(0).Rows.Count = 0 Then

                        '結果０件ＭＳＧ出力
                        'メッセージCD：211
                        Me.Cursor = Cursors.Default

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                        '検索データを表示する
                        dsReturn.Clear()
                        Me.grid外协加工管理.DataSource = dsReturn
                        'フォーカスの設定処理
                        Me.txt订单编号.Focus()
                    Else
                        Me.grid外协加工管理.DataSource = dsReturn
                        Me.grid外协加工管理.Focus()
                        Me.grid外协加工管理.ActiveRow = Me.grid外协加工管理.Rows(0)
                        SetGridStyle()
                        BindGridCombox()
                    End If

                Case Constant.ENU_MODE.Model_Update
                    objB外协加工T.外协订单编号 = Me.txt外协订单编号.Text.Trim

                    If String.IsNullOrEmpty(objB外协加工T.外协订单编号) Then
                        objB外协加工T.外协订单编号 = " "
                    End If
                    objB外协加工T.区分 = 0

                    dsReturn = objBLLM外协加工T.LoadByWhere(objB外协加工T)

                    If dsReturn.Tables.Count = 0 Then
                        Exit Sub
                    End If

                    '新规
                    'If mIntFormMode <> Constant.ENU_MODE.Model_New Then
                    '显示订单信息
                    If dsReturn.Tables(0).Rows.Count > 0 Then
                        Me.txt外协订单编号.Text = dsReturn.Tables(0).Rows(0)("外协计划单号").ToString()
                        Me.txt外协对象.Text = dsReturn.Tables(0).Rows(0)("外协对象编号").ToString()
                        Me.txt外协对象名称.Text = dsReturn.Tables(0).Rows(0)("外协对象名称").ToString()
                    Else
                        Me.txt外协订单编号.Text = String.Empty
                        Me.txt外协对象.Text = String.Empty

                        'str审核状态 = String.Empty
                        'str审核人 = String.Empty
                    End If

                    If dsReturn.Tables(1) Is Nothing OrElse dsReturn.Tables(1).Rows.Count = 0 Then

                        Me.Cursor = Cursors.Default

                        Me.grid外协加工管理.DataSource = dsReturn.Tables(1)

                    Else
                        Me.grid外协加工管理.DataSource = dsReturn.Tables(1)

                        Me.grid外协加工管理.Focus()
                        Me.grid外协加工管理.ActiveRow = Me.grid外协加工管理.Rows(0)
                        SetGridStyle()
                        BindGridCombox()
                    End If

                Case Else
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
#Region "SetPermission"

    Private Sub SetPermission()
        Try

            'Me.btnF1清空.Enabled = Utility.PFn_GetAuth(Me.btnF1清空.Tag)
            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            Me.btnF5行追加.Enabled = Utility.PFn_GetAuth(Me.btnF5行追加.Tag)
            Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)
            'Me.btnF10.Enabled = Utility.PFn_GetAuth(Me.btnF11.Tag)
            Me.btnF11.Enabled = Utility.PFn_GetAuth(Me.btnF11.Tag)
            Me.btn查询.Enabled = Utility.PFn_GetAuth(Me.btn查询.Tag)

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

            With grid外协加工管理.DisplayLayout.Bands(0)

                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("选择").CellActivation = Activation.AllowEdit
                .Columns("外协状态").Style = ColumnStyle.DropDownList
                .Columns("外协加工数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("完成日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("回厂日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("带料数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("带料数量").Style = ColumnStyle.Double
                .Columns("加工单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("加工单价").Style = ColumnStyle.Double
                .Columns("加工总金额").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("加工总金额").Style = ColumnStyle.Double
                .Columns("订单编号").CellActivation = Activation.NoEdit
                .Columns("主图号").CellActivation = Activation.NoEdit
                .Columns("上级图号").CellActivation = Activation.NoEdit
                .Columns("分图号").CellActivation = Activation.NoEdit
                .Columns("客户名称").CellActivation = Activation.NoEdit
                '.Columns("外协状态").CellActivation = Activation.NoEdit
                .Columns("外协加工数量").CellActivation = Activation.NoEdit
                .Columns("外协工序").CellActivation = Activation.NoEdit
                .Columns("审核状态").CellActivation = Activation.NoEdit
                .Columns("审核状态").Hidden = True
                .Columns("审核人").Hidden = True
                .Columns("审核备注").Hidden = True
                .Columns("外协加工工序编号").Hidden = True
                '.Columns("是否外协加工").Hidden = True
                '.Columns("是否整体外协加工").Hidden = True
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
#Region "SetFormModel"

    Private Sub SetFormModel()

        Try

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    txt外协订单编号.ReadOnly = False
                    txt订单编号.ReadOnly = False
                    txt外协工序.ReadOnly = False
                    txt产品图号.ReadOnly = False
                    txt外协对象.ReadOnly = False
                    txt外协对象名称.ReadOnly = False
                    Me.grid外协加工管理.Enabled = True
                    Me.btnF5行追加.Visible = False
                    Me.btnF6行删除.Visible = False
                    Me.btnF11.Visible = False
                    Me.btn查询.Visible = True
                    Me.btnF10.Visible = False
                    labModel.Text = Constant.cgStrNew
                    txt订单编号.Select()
                Case Constant.ENU_MODE.Model_Update
                    txt订单编号.ReadOnly = True
                    txt外协工序.ReadOnly = True
                    txt产品图号.ReadOnly = True
                    txt外协订单编号.ReadOnly = True
                    txt外协订单编号.TabStop = False
                    Me.btn查询.Visible = False
                    str审核状态 = 0
                    str审核人 = String.Empty
                    'Me.btnF11.Enabled = Utility.PFn_GetAuth(Me.btnF11.Tag)
                    Me.btnF5行追加.Visible = False
                    Me.btnF6行删除.Visible = False
                    Me.btnF11.Visible = True
                    Me.btn查询.Visible = False
                    Me.btnF11.Enabled = True
                    Me.btnF10.Visible = False
                    txt外协对象.Select()
                    labModel.Text = Constant.cgStrUpdate

                Case Else

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
#Region "AddCheck"
    ''' <summary>
    ''' 画面のCheck処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Function AddCheck() As Boolean

        Try

            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If

            '必須チェック(MsgID=13) 

            '外协订单编号
            If Me.txt外协订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "外协订单编号", "外协订单编号")
                txt外协订单编号.Focus()
                Return False
            End If

            If Me.txt外协对象.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "外协对象", "外协对象")
                txt外协对象.Focus()
                Return False

            End If
            If grid外协加工管理.Rows.Count = 0 Then
                MsgBox("请点击查询！！！")
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
            Dim objB外协加工管理T As New B外协加工管理T
            Dim objBll As New BllM外协加工管理T

            Dim dt As New DataTable
            '必須チェック(MsgID=13) 

            '订单编号
            If Me.txt外协订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "外协订单编号", "外协订单编号")
                txt外协订单编号.Focus()
                Return False
            End If

            If Me.txt外协对象.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "外协对象", "外协对象")
                txt外协对象.Focus()
                Return False

            End If

            If grid外协加工管理.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "外协加工", "回厂日期")
                Me.btnF5行追加.Select()
                Return False
            End If

            Dim intLoopi As Integer

            For intLoopi = 0 To grid外协加工管理.Rows.Count - 1
                Select Case mIntFormMode

                    Case Constant.ENU_MODE.Model_New
                        If Me.grid外协加工管理.Rows(intLoopi).Cells("选择").Value.ToString() = 0 Then
                            Continue For
                        End If
                        If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.回厂日期).Value.ToString = "" Then
                            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "回厂日期", "外协加工")
                            Me.grid外协加工管理.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.回厂日期).Activated = True
                            Me.grid外协加工管理.Select()
                            Return False
                        End If
                        If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.外协状态).Value.ToString = "" Then
                            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "外协状态", "外协状态")
                            Me.grid外协加工管理.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.外协状态).Activated = True
                            Me.grid外协加工管理.Select()
                            Return False
                        End If
                        If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工单价).Value.ToString <> "" Then
                            If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工单价).Value <= 0 Then
                                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "加工单价", "外协加工")
                                Me.grid外协加工管理.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.加工单价).Activated = True
                                Me.grid外协加工管理.Select()
                                Return False
                            End If
                        End If
                        '加工总金额
                        If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工总金额).Value.ToString <> "" Then
                            If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工总金额).Value <= 0 Then

                                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "加工总金额", "外协加工")
                                Me.grid外协加工管理.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.加工总金额).Activated = True
                                Me.grid外协加工管理.Select()
                                Return False
                            End If
                        End If
                        objB外协加工管理T.分图号 = grid外协加工管理.Rows(intLoopi).Cells("分图号").Value.ToString()
                        objB外协加工管理T.主图号 = grid外协加工管理.Rows(intLoopi).Cells("主图号").Value.ToString()
                        dt = objBll.Check主图分图(objB外协加工管理T)

                        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                            MsgBox("产品图号：" & objB外协加工管理T.分图号 & "不属于主图号：" & objB外协加工管理T.主图号)
                            Return False
                        End If
                    Case Constant.ENU_MODE.Model_Update

                        If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.回厂日期).Value.ToString = "" Then
                            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "回厂日期", "外协加工")
                            Me.grid外协加工管理.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.回厂日期).Activated = True
                            Me.grid外协加工管理.Select()
                            Return False
                        End If
                        If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.外协状态).Value.ToString = "" Then
                            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "外协状态", "外协状态")
                            Me.grid外协加工管理.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.外协状态).Activated = True
                            Me.grid外协加工管理.Select()
                            Return False
                        End If
                        If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工单价).Value.ToString <> "" Then
                            If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工单价).Value <= 0 Then
                                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "加工单价", "外协加工")
                                Me.grid外协加工管理.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.加工单价).Activated = True
                                Me.grid外协加工管理.Select()
                                Return False
                            End If
                        End If
                        '加工总金额
                        If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工总金额).Value.ToString <> "" Then
                            If grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工总金额).Value <= 0 Then

                                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "加工总金额", "外协加工")
                                Me.grid外协加工管理.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.加工总金额).Activated = True
                                Me.grid外协加工管理.Select()
                                Return False
                            End If
                        End If

                        objB外协加工管理T.分图号 = grid外协加工管理.Rows(intLoopi).Cells("分图号").Value.ToString()
                        objB外协加工管理T.主图号 = grid外协加工管理.Rows(intLoopi).Cells("主图号").Value.ToString()
                        dt = objBll.Check主图分图(objB外协加工管理T)

                        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                            MsgBox("产品图号：" & objB外协加工管理T.分图号 & "不属于主图号：" & objB外协加工管理T.主图号)
                            Return False
                        End If
                End Select
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
#Region "ImportData"

    Private Sub ImportData()

        Dim filePath = String.Empty
        Dim dialogResult As DialogResult
        Dim ReturnDataTable As DataTable
        Dim objBll As New BllM外协加工管理T

        OpenFileDialog.FileName = ""
        OpenFileDialog.Filter = "excel工作簿(*.elsx)|*.xlsx|excel97-2003工作簿(*.xls)|*.xls"

        dialogResult = OpenFileDialog.ShowDialog()

        Try


            If dialogResult = Windows.Forms.DialogResult.OK Then
                filePath = OpenFileDialog.FileName
                Dim str = OpenFileDialog.Filter

                If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID37, "外协计划", filePath) = Constant.ENU_SHOWMSG.showMsgNo Then
                    '処理終了
                    Exit Sub
                End If


                '读取数据到datatable
                ReturnDataTable = Utility.PFn_ExcelToDataTable(filePath)

                'If Not ImportCheck(ReturnDataTable) Then
                '    Exit Sub
                'End If

                '插入数据
                If objBll.InsertBatch(ReturnDataTable) > 0 Then

                    '成功メッセージを表示する
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                    Me.DataSearch(False)
                Else
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID36)
                    Me.txt外协订单编号.Select()
                    Exit Sub
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
#Region "ImportCheck"
    ''' <summary>
    ''' 外协计划导入检查     ''' </summary>
    ''' <remarks></remarks>
    Private Function ImportCheck(ByVal dtTable As DataTable) As Boolean

        Dim intLoopRows As Integer
        Dim strMsg As New StringBuilder
        Dim objBll外协加工 As BllM外协加工管理T
        Dim objBll客户 As BLLM客户T
        'Dim objBll图号 As BLLM产品图号T
        Dim objBll人员 As BLLM人员T

        Try

            '如果没有数据退出处理          
            If dtTable.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID36, Constant.cgStrNew)
                Return False
            End If


            objBll外协加工 = New BllM外协加工管理T
            objBll客户 = New BLLM客户T
            'objBll图号 = New BLLM产品图号T
            objBll人员 = New BLLM人员T

            For intLoopRows = 0 To dtTable.Rows.Count - 1

                Dim intLoopj As Integer
                Dim strCheckString As String = ""

                For intLoopj = 0 To dtTable.Columns.Count - 1
                    strCheckString += dtTable.Rows(intLoopRows)(intLoopj).ToString
                Next

                If strCheckString = "" Then
                    Continue For
                End If

                '外协订单编号
                If Utility.NullToString(dtTable.Rows(intLoopRows)("外协订单编号")) = "" Then
                    strMsg.AppendFormat("行：{0}【外协订单编号】不能为空。" & vbCrLf, intLoopRows + 1)
                Else

                    If objBll外协加工.IsExists外协订单编号(dtTable.Rows(intLoopRows)("外协订单编号")) Then
                        strMsg.AppendFormat("行：{0}【外协订单编号】已存在。" & vbCrLf, intLoopRows + 1)
                    End If
                End If

                If Utility.NullToString(dtTable.Rows(intLoopRows)("外协对象")) = "" Then
                    strMsg.AppendFormat("行：{0}【外协对象】不能为空。" & vbCrLf, intLoopRows + 1)
                End If

                '出荷去向
                If Utility.NullToString(dtTable.Rows(intLoopRows)("客户编号")) = "" Then
                    strMsg.AppendFormat("行：{0}【客户编号】不能为空。" & vbCrLf, intLoopRows + 1)
                Else

                    If Not objBll客户.IsExists(dtTable.Rows(intLoopRows)("客户编号")) Then
                        strMsg.AppendFormat("行：{0}【客户编号】不存在。" & vbCrLf, intLoopRows + 1)
                    End If
                End If

                If Utility.NullToString(dtTable.Rows(intLoopRows)("产品图号")) = "" Then
                    strMsg.AppendFormat("行：{0}【产品图号】不能为空。" & vbCrLf, intLoopRows + 1)
                End If

                '出荷数量
                If Utility.NullToString(dtTable.Rows(intLoopRows)("外协加工数量")) = "" Then
                    strMsg.AppendFormat("行：{0}【外协加工数量】不能为空。" & vbCrLf, intLoopRows + 1)
                Else
                    If Not IsNumeric(dtTable.Rows(intLoopRows)("外协加工数量")) Then
                        strMsg.AppendFormat("行：{0}【外协加工数量】只能输入数字。" & vbCrLf, intLoopRows + 1)
                    End If
                End If

                '出荷日期
                If Utility.NullToString(dtTable.Rows(intLoopRows)("回厂日期")) = "" Then
                    strMsg.AppendFormat("行：{0}【回厂日期】不能为空。" & vbCrLf, intLoopRows + 1)
                End If
                '出荷日期
                If Utility.NullToString(dtTable.Rows(intLoopRows)("加工单价")) = "" Then
                    strMsg.AppendFormat("行：{0}【加工单价】不能为空。" & vbCrLf, intLoopRows + 1)
                End If

                If Utility.NullToString(dtTable.Rows(intLoopRows)("加工总金额")) = "" Then
                    strMsg.AppendFormat("行：{0}【加工总金额】不能为空。" & vbCrLf, intLoopRows + 1)
                End If

                '作成者     
                If Utility.NullToString(dtTable.Rows(intLoopRows)("作成者")) <> "" Then
                    If Not objBll人员.IsExists(dtTable.Rows(intLoopRows)("作成者")) Then
                        strMsg.AppendFormat("行：{0}【作成者】不存在。" & vbCrLf, intLoopRows + 1)
                    End If
                End If

            Next

            If strMsg.Length > 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID40, strMsg.ToString)
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
#Region "SaveData"

    Private Sub SaveData()

        Try

            Dim objBll As New BllM外协加工管理T
            Dim arrayList As New ArrayList
            Dim intLoopi As Integer
            Dim objM外协加工T As New B外协加工管理T

            For intLoopi = 0 To grid外协加工管理.Rows.Count - 1
                'Select Case mIntFormMode
                '    Case Constant.ENU_MODE.Model_New
                '        If grid外协加工管理.Rows(intLoopi).Cells("选择").Value.ToString = 1 Then
                '            objM外协加工T = New B外协加工管理T
                '            objM外协加工T.外协订单编号 = Me.txt外协订单编号.Text.Trim
                '            objM外协加工T.外协对象编号 = Me.txt外协对象.Text.Trim
                '            objM外协加工T.订单编号 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.订单编号).Value.ToString()
                '            objM外协加工T.分图号 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.分图号).Value.ToString()
                '            objM外协加工T.上级图号 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.上级图号).Value.ToString()
                '            objM外协加工T.主图号 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.主图号).Value.ToString()
                '            objM外协加工T.外协加工状态 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.外协状态).Value.ToString()
                '            objM外协加工T.外协加工数量 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.外协加工数量).Value.ToString()
                '            objM外协加工T.外协工序 = Me.grid外协加工管理.Rows(intLoopi).Cells("外协加工工序编号").Value.ToString()
                '            objM外协加工T.回厂日期1 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.回厂日期).Value.ToString()
                '            'objM外协加工T.下料规格 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.下料规格).Value.ToString()
                '            objM外协加工T.原材料编号 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.原材料).Value.ToString()
                '            objM外协加工T.实际带料数量 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.实际带料数量).Value.ToString()
                '            objM外协加工T.加工单价 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工单价).Value.ToString()
                '            objM外协加工T.加工总金额 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工总金额).Value.ToString()
                '            objM外协加工T.备注 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.备注).Value.ToString()
                '            'objM外协加工T.作成者 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.作成者).Value.ToString()

                '            If str审核状态 = String.Empty Then
                '                objM外协加工T.审核状态 = "1"
                '                objM外协加工T.审核人 = ""
                '                objM外协加工T.审核备注 = ""
                '            Else
                '                objM外协加工T.审核状态 = str审核状态                '                objM外协加工T.审核人 = str审核人                '                objM外协加工T.审核备注 = str审核备注


                '                'objM外协加工T.登陆者 = gObjM_人员T.人员编号
                '                'objM外协加工T.登陆日期 = DateTime.Now
                '            End If
                '            arrayList.Add(objM外协加工T)
                '        End If
                '    Case Constant.ENU_MODE.Model_Update
                If grid外协加工管理.Rows(intLoopi).Cells("选择").Value.ToString = 1 Then
                    objM外协加工T = New B外协加工管理T
                    objM外协加工T.外协订单编号 = Me.txt外协订单编号.Text.Trim
                    objM外协加工T.外协对象编号 = Me.txt外协对象.Text.Trim
                    objM外协加工T.订单编号 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.订单编号).Value.ToString()
                    objM外协加工T.分图号 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.分图号).Value.ToString()
                    objM外协加工T.上级图号 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.上级图号).Value.ToString()
                    objM外协加工T.主图号 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.主图号).Value.ToString()

                    If Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.外协状态).Value.ToString() = "已申请" Then
                        objM外协加工T.外协加工状态 = 1
                    ElseIf Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.外协状态).Value.ToString() = "已计划" Then
                        objM外协加工T.外协加工状态 = 2
                    ElseIf Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.外协状态).Value.ToString() = "已出厂" Then
                        objM外协加工T.外协加工状态 = 3
                    ElseIf Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.外协状态).Value.ToString() = "已回厂" Then
                        objM外协加工T.外协加工状态 = 4
                    End If
                    'objM外协加工T.外协加工状态 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.外协状态).Value.ToString()
                    objM外协加工T.外协加工数量 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.外协加工数量).Value.ToString()
                    objM外协加工T.外协工序 = Me.grid外协加工管理.Rows(intLoopi).Cells("外协加工工序编号").Value.ToString()
                    'objM外协加工T.完成日期 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.完成日期).Value.ToString()
                    objM外协加工T.回厂日期1 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.回厂日期).Value.ToString()
                    'objM外协加工T.下料规格 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.下料规格).Value.ToString()
                    'objM外协加工T.计划带料数量 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.计划带料数量).Value.ToString()
                    objM外协加工T.原材料编号 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.原材料).Value.ToString()
                    objM外协加工T.实际带料数量 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.实际带料数量).Value.ToString()
                    objM外协加工T.加工单价 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工单价).Value.ToString()
                    objM外协加工T.加工总金额 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.加工总金额).Value.ToString()
                    objM外协加工T.备注 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.备注).Value.ToString()
                    'objM外协加工T.作成者 = Me.grid外协加工管理.Rows(intLoopi).Cells(ENU_GRID.作成者).Value.ToString()

                    'lxq 2017-04-21 update
                    'If str审核状态 = String.Empty Then
                    '    objM外协加工T.审核状态 = "1"
                    '    objM外协加工T.审核人 = ""
                    '    objM外协加工T.审核备注 = ""
                    'Else
                    '    objM外协加工T.审核状态 = str审核状态                    '    objM外协加工T.审核人 = str审核人                    '    objM外协加工T.审核备注 = str审核备注
                    'lxq 2017-04-21 end

                    'objM外协加工T.登陆者 = gObjM_人员T.人员编号
                    'objM外协加工T.登陆日期 = DateTime.Now
                    'End If
                    arrayList.Add(objM外协加工T)
                End If
                'End Select

            Next

            Select mIntFormMode

                Case Constant.ENU_MODE.Model_New


                    If objBll.Update(arrayList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                        '显示当前订单
                        'Me.DataSearch()
                        ClearForm()
                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt外协订单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update(arrayList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)

                        '显示当前订单
                        Me.DataSearch(False)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt外协订单编号.Focus()
                        Exit Sub
                    End If

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
#Region "BindGridCombox"

    Private Sub BindGridCombox(Optional ByVal intRowIndex As Integer = 0)

        Try
            Utility.PFn_SetGirdCombo(Me.grid外协加工管理, "VM外协计划状态", ENU_GRID.外协状态)
        Catch ex As Exception

        End Try

    End Sub
#End Region
#Region "Update审核"

    Private Sub Update审核()
        Dim objModel As B外协加工管理T
        Dim objBll As New BllM外协加工管理T

        Try
            objModel = New B外协加工管理T
            objModel.外协订单编号 = Me.txt外协订单编号.Text.Trim
            If str审核状态 = String.Empty Then

                objModel.审核状态 = 1

            Else
                objModel.审核状态 = str审核状态
                objModel.审核备注 = str审核备注
                objModel.审核人 = str审核人
            End If
            mds = objBll.Update审核(objModel)
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