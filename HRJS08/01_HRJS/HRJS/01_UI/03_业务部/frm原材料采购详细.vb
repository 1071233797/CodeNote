Imports Infragistics.Win.UltraWinGrid
Imports HRJS.Constant
Imports System.IO
Public Class frm原材料采购管理

#Region "常量定义"

    'Private Enum ENU_GRID1 As Integer
    '    材料编号 = 0
    '    材料名称 = 1
    '    材料区分 = 2
    '    材料种类 = 3
    '    材质 = 4
    'End Enum
    Private Enum ENU_GRID1 As Integer
        选择 = 0
        订单编号 = 1
        订单数量 = 2
        主图号 = 3
        主图号名称 = 4
        上级图号 = 5
        分图号 = 6
        分图号名称 = 7
        材料代号 = 8
        材料编号 = 9
        材料种类 = 10
        材质 = 11
        长 = 12
        宽 = 13
        高 = 14
        数量 = 15
        长1 = 16
        宽1 = 17
        高1 = 18
        长度方向加工数量 = 19
        宽度方向加工数量 = 20
        数量1 = 21
        密度 = 22
        重量 = 23
        单耗 = 24
        计划采购数量 = 25
        实际采购数量 = 26
        计划采购重量 = 27
        实际采购重量 = 28
        币种 = 29
        含税单价 = 30
        含税总金额 = 31
        单耗含税金额 = 32
        未税单价 = 33
        未税总金额 = 34
        供货日期 = 35
        供货方式 = 36
        备注 = 37
        '采购单编号CD = 33
        '单价修改状态 = 34
        '数量1 = 35
        '材料种类 = 36
    End Enum


#End Region

#Region "変数定義"
    Private mDtSearch As DataTable = Nothing
    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Private dsReturn As DataSet
    Private str审核状态 As String
    Private str审核人 As String
    Private str审核备注 As String
    Private str采购状态 As String
    Private mds As Integer
#End Region

#Region "Form Event"

    Private Sub frm原材料采购管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frm原材料采购管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm原材料采购管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
            If Not Me.grid订单.DataSource Is Nothing AndAlso Me.grid订单.DataSource.rows.count > 0 Then
                Me.grid订单.DataSource.clear()
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()

            ''画面の初期化処理
            ClearForm()


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF2编辑_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2编辑.Click

        Dim frmSearch As frm原材料采购一览

        Try

            frmSearch = New frm原材料采购一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    mIntFormMode = Constant.ENU_MODE.Model_Update

                    Me.txt采购单编号.Text = frmSearch.ReturnTable.Rows(0)("采购单编号").ToString.Trim

                    DataSearch1()

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
                SetFormModel()

                If str审核状态 = "1" Then
                    If Me.btnF11.Enabled = False Then
                        Me.txt采购单编号.ReadOnly = True
                        Me.txt人员编号.ReadOnly = True
                        Me.txt供应商编号.ReadOnly = True
                        'Me.grid订单.Enabled = False
                        Me.btnF3保存.Enabled = False
                        Me.btnF4删除.Enabled = False
                        Me.btnF5行追加.Enabled = False
                        Me.btnF6行删除.Enabled = False
                    Else
                        Me.txt人员编号.ReadOnly = False
                        Me.txt供应商编号.ReadOnly = False

                        'Me.grid订单.Enabled = True
                        Me.btnF3保存.Enabled = True
                        Me.btnF4删除.Enabled = True
                        Me.btnF5行追加.Enabled = True
                        Me.btnF6行删除.Enabled = True
                    End If
                Else
                    Me.txt人员编号.ReadOnly = False
                    Me.txt供应商编号.ReadOnly = False
                    'Me.grid订单.Enabled = True
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
            'ClearForm()

            'mIntFormMode = Constant.ENU_MODE.Model_New
            'Me.SetFormModel()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objM采购单T As New B原材料采购管理T

        Dim objBll As New BllM原材料采购单管理T

        Try

            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If String.IsNullOrEmpty(txt采购单编号.Text.Trim) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If
            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objM采购单T.采购单编号 = txt采购单编号.Text.Trim

            If objBll.Delete(objM采购单T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New
            If Not Me.grid订单.DataSource Is Nothing AndAlso Me.grid订单.DataSource.rows.count > 0 Then
                Me.grid订单.DataSource.clear()
            End If
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
            SetGridStyle()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
        If Me.grid订单.Rows.Count = 0 Then
            intRow = 0
        Else
            intRow = Me.grid订单.Rows.Count
        End If

        Dim tmpTable As New DataTable

        tmpTable = dsReturn.Tables(1).Copy()

        dr = dsReturn.Tables(1).NewRow

        dsReturn.Tables(1).Rows.Add(dr)
        dsReturn.Tables(1).AcceptChanges()

        With Me.grid订单
            .ActiveRow = .Rows(intRow)
            .Rows(intRow).Cells(0).Activate()
            '.ActiveRow.Cells(ENU_GRID1.作成者编号).Value = gObjM_人员T.人员编号
            '.ActiveRow.Cells(ENU_GRID1.作成者姓名).Value = gObjM_人员T.人员名

            .UpdateData()
            .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)

        End With

    End Sub

    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click
        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If Me.grid订单.ActiveRow Is Nothing Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            '「選択された行を削除してもよろしいですか？」


            If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID4) = ENU_SHOWMSG.showMsgNo Then
                '登録処理終了
                Me.Cursor = Cursors.Default
                Return
            End If


            intRow = Me.grid订单.ActiveRow.VisibleIndex

            intRowDelete = Me.grid订单.ActiveRow.Index

            'Me.grid订单.Rows(intRowDelete).Delete(False)
            dsReturn.Tables(1).Rows.RemoveAt(intRowDelete)
            'Me.grid订单.Rows(intRowDelete).Delete(False)
            If Me.grid订单.Rows.VisibleRowCount = 0 Or Me.grid订单.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If Me.grid订单.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf Me.grid订单.Rows.VisibleRowCount = intRow Then
                    intRow = Me.grid订单.Rows.VisibleRowCount - 1
                End If

                Me.grid订单.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                Me.grid订单.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.grid订单.UpdateData()
            End If


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11.Click
        'Try
        '    If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID41) = Constant.ENU_SHOWMSG.showMsgNo Then
        '        '処理終了
        '        Exit Sub
        '    End If
        '    SetFormModel()
        '    str审核状态 = 1
        '    SaveData()
        '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "审核")

        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try

        'Dim frmSearch As frm审核
        'Try
        '    frmSearch = New frm审核
        '    frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

        '    '部门信息查询画面打开
        '    frmSearch.ShowDialog()

        '    '画面数据设置
        '    If frmSearch.ReturnType = 1 Then

        '        'If frmSearch.ReturnType <> String.Empty Then

        '        '根据检索画面数据进行设置
        '        str审核状态 = frmSearch.cmb审核状态.Value
        '        str审核备注 = frmSearch.txt审核备注.Text
        '        str审核人 = gObjM_人员T.人员名

        '        '设置画面数据
        '        Update审核()
        '        'If frmSearch.cmb审核状态.Value = "2" Then
        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "审核")
        '        'End If

        '        If Not frmSearch.ReturnTable Is Nothing Then
        '            '检索画面释放


        '            frmSearch.ReturnTable.Dispose()
        '            frmSearch.ReturnTable = Nothing
        '        End If

        '        '检索画面释放
        '        frmSearch.Dispose()
        '        frmSearch = Nothing


        '        '画面の修正処理
        '        mIntFormMode = Constant.ENU_MODE.Model_Update
        '        SetFormModel()

        '    End If

        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try
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

    Private Sub btnF7全选择_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF7全选择.Click

        Dim intRows As Integer

        If Me.grid订单.Rows.Count = 0 Then
            Exit Sub
        End If

        For intRows = 0 To Me.grid订单.Rows.Count - 1
            grid订单.Rows(intRows).Cells(0).Value = 1
        Next
        grid订单.UpdateData()

    End Sub
    Private Sub btnF8全解除_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF8全解除.Click
        Dim intRows As Integer

        If Me.grid订单.Rows.Count = 0 Then
            Exit Sub
        End If

        For intRows = 0 To Me.grid订单.Rows.Count - 1
            grid订单.Rows(intRows).Cells(0).Value = 0
        Next
        grid订单.UpdateData()
    End Sub
#End Region

#Region "Control Event"

#Region "人员编号"

    Private Sub txt人员编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt人员编号.Enter

        Try

            Me.txt人员编号.Tag = Me.txt人员编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt人员编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt人员编号.EditorButtonClick


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


                    Me.txt人员编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '客户编号

                    Me.txt人员名称.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '客户名称


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

    Private Sub txt人员编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt人员编号.Validating

        Dim objM人员T As M人员T
        Dim objBllM人员T As BLLM人员T

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

                objBllM人员T = New BLLM人员T

                objM人员T = objBllM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员编号 <> "" Then

                    Me.txt人员名称.Text = objM人员T.人员名

                Else
                    Me.txt人员编号.Text = String.Empty
                    Me.txt人员名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员名称")
                    Me.txt人员编号.Select()
                End If
            Else
                Me.txt人员名称.Text = String.Empty
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

                    Me.txt税率.Text = frmSearch.ReturnTable.Rows(0)("税率")     '供应商名称


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

                If objM供应商T.供应商编号 <> "" Then

                    Me.txt供应商名称.Text = objM供应商T.供应商名称

                    Me.txt税率.Text = objM供应商T.税率
                Else
                    Me.txt供应商编号.Text = String.Empty
                    Me.txt供应商名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "供应商信息")
                    Me.txt供应商编号.Select()
                End If
            Else
                Me.txt供应商名称.Text = String.Empty
                Me.txt税率.Text = String.Empty
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
#Region "订单编号"
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
#End Region
#Region "Grid Event"

    Private Sub grid订单_ClickCellButton(ByVal sender As Object, ByVal e As CellEventArgs) Handles grid订单.ClickCellButton


        'Dim frmSearch原材料 As frm原材料信息一览

        Dim frmSearch订单 As frm订单一览


        Try

            If Me.grid订单.ActiveCell Is Nothing Then
                Exit Sub
            End If

            Select Case Me.grid订单.ActiveCell.Column.Index

                'Case ENU_GRID1.材料编号


                '    If Me.grid订单.DisplayLayout.Bands(0).Columns(ENU_GRID1.材料编号).CellActivation = Activation.NoEdit Then
                '        Exit Sub
                '    End If

                '    If Me.grid订单.ActiveRow.Cells(ENU_GRID1.材料编号).Activation = Activation.NoEdit Then
                '        Exit Sub
                '    End If

                '    砂時計のカーソルが設定()


                '    Me.Cursor = Cursors.WaitCursor

                '    frmSearch原材料 = New frm原材料信息一览
                '    frmSearch原材料.str供应商编号 = Me.txt供应商编号.Text
                '    frmSearch原材料.btnF1清空.Enabled = False
                '    frmSearch原材料.txt供应商编号.Enabled = False
                '    frmSearch原材料.FormOpenMode = Constant.ENU_MODE.Model_Search
                '    frmSearch原材料.ShowDialog()

                '    画面数据设置()
                '    If frmSearch原材料.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                '        If Not frmSearch原材料.ReturnTable Is Nothing AndAlso 0 < frmSearch原材料.ReturnTable.Rows.Count Then

                '            根据检索画面数据进行设置()
                '            If grid订单.DataSource.select("材料编号='" & frmSearch原材料.ReturnTable.Rows(0)("原材料编号") & "'").length > 0 Then
                '                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "材料编号")
                '            Else
                '                Me.grid订单.ActiveRow.Cells(ENU_GRID1.材料编号).Value = frmSearch原材料.ReturnTable.Rows(0)("原材料编号")     '部品番号
                '                Me.grid订单.ActiveRow.Cells(ENU_GRID1.材料名称).Value = frmSearch原材料.ReturnTable.Rows(0)("原材料名称")
                '                Me.grid订单.ActiveRow.Cells(ENU_GRID1.材料区分).Value = frmSearch原材料.ReturnTable.Rows(0)("原材料区分")
                '                Me.grid订单.ActiveRow.Cells("材料种类").Value = frmSearch原材料.ReturnTable.Rows(0)("材料种类")
                '                Me.grid订单.ActiveRow.Cells("材质").Value = frmSearch原材料.ReturnTable.Rows(0)("材质")

                '                Call grid订单_MouseDown(Nothing, Nothing)
                '            End If

                '            frmSearch原材料.ReturnTable = Nothing

                '        End If
                '    End If

                '    If Not frmSearch原材料.ReturnTable Is Nothing Then
                '        检索画面释放()



                '        frmSearch原材料.ReturnTable.Dispose()
                '        frmSearch原材料.ReturnTable = Nothing
                '        frmSearch原材料.ReturnTable = Nothing
                '    End If
                '    检索画面释放()



                '    frmSearch原材料.Dispose()
                '    frmSearch原材料 = Nothing


                Case ENU_GRID1.订单编号

                    If Me.grid订单.DisplayLayout.Bands(0).Columns(ENU_GRID1.订单编号).CellActivation = Activation.NoEdit Then
                        Exit Sub
                    End If

                    If Me.grid订单.ActiveRow.Cells(ENU_GRID1.订单编号).Activation = Activation.NoEdit Then
                        Exit Sub
                    End If

                    '砂時計のカーソルが設定

                    Me.Cursor = Cursors.WaitCursor

                    frmSearch订单 = New frm订单一览
                    frmSearch订单.intDoubleClick = 1
                    frmSearch订单.FormOpenMode = Constant.ENU_MODE.Model_Search
                    frmSearch订单.ShowDialog()

                    '画面数据设置
                    If frmSearch订单.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                        If Not frmSearch订单.ReturnTable Is Nothing AndAlso 0 < frmSearch订单.ReturnTable.Rows.Count Then

                            '根据检索画面数据进行设置
                            'If grid订单.DataSource.select("订单编号='" & frmSearch订单.ReturnTable.Rows(0)("订单编号") & "' AND 材料编号='" & Me.grid订单.ActiveRow.Cells(ENU_GRID1.材料编号).Value & "'").length > 0 Then
                            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "订单编号和材料编号")
                            'Else
                            Me.grid订单.ActiveRow.Cells(ENU_GRID1.订单编号).Value = frmSearch订单.ReturnTable.Rows(0)("订单编号")     '订单编号
                            Me.grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value = frmSearch订单.ReturnTable.Rows(0)("订单数量")     '订单数量
                            'Me.grid订单.ActiveRow.Cells(ENU_GRID1.产品图号).Value = frmSearch订单.ReturnTable.Rows(0)("产品图号")     '订单编号
                            'SetData()

                            'End If


                        End If

                        If Not frmSearch订单.ReturnTable Is Nothing Then
                            '检索画面释放


                            frmSearch订单.ReturnTable.Dispose()
                            frmSearch订单.ReturnTable = Nothing
                        End If
                        '检索画面释放


                        frmSearch订单.Dispose()
                        frmSearch订单 = Nothing

                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = _
                                grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = 0

                        End If
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.实际采购数量).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.含税总金额).Value = _
                                grid订单.ActiveRow.Cells(ENU_GRID1.实际采购数量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.含税总金额).Value = 0

                        End If

                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = _
                                grid订单.ActiveRow.Cells(ENU_GRID1.实际采购数量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = 0

                        End If
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.含税总金额).Value = 0
                        grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = 0
                    End If
            End Select
            grid订单.UpdateData()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub grid订单_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid订单.CellChange
        Try
            'Dim objBLL As New BllM原材料采购单管理T
            'Dim obj As New B原材料采购管理T
            'Dim dt As DataTable
            If grid订单.DataSource Is Nothing OrElse grid订单.Rows.Count = 0 Then
                Exit Sub
            End If
            grid订单.UpdateData()

            Select Case Me.grid订单.ActiveRow.Cells(ENU_GRID1.材料种类).Value

                Case "板材"

                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value = _
                        CInt(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value / (grid订单.ActiveRow.Cells(ENU_GRID1.长).Value + 10))
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value = 0
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                        grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value = _
                        CInt(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value / (grid订单.ActiveRow.Cells(ENU_GRID1.宽).Value + 10))

                        If grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value = 0 Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value = 1
                        End If

                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value = 0
                    End If

                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value) Then

                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.数量1).Value = _
                               CInt(grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value)
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.数量1).Value = 0
                        End If
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.数量1).Value = 0
                    End If

                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value) Then
                                If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value) AndAlso (grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value _
                                                * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value) <> 0 Then
                                    grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value = _
                                                Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value _
                                                * grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value _
                                                * grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value _
                                                * grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value _
                                                / 1000000 / (grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value _
                                                * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value) * grid订单.ActiveRow.Cells(ENU_GRID1.数量).Value, 2)
                                Else
                                    'Exit Select
                                    grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value = 0
                                End If
                            Else
                                grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value = 0
                            End If
                        End If
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value) Then
                                If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value) AndAlso (grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value _
                                            * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value) <> 0 Then
                                    'grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = _
                                    '            Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value _
                                    '            * grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value _
                                    '            * grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value _
                                    '            * grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value _
                                    '            / 1000000 / (grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value _
                                    '            / (grid订单.ActiveRow.Cells(ENU_GRID1.长).Value + 10) * (grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value _
                                    '           / (grid订单.ActiveRow.Cells(ENU_GRID1.宽).Value + 10))) * grid订单.ActiveRow.Cells(ENU_GRID1.数量).Value _
                                    '           * grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value, 2)



                                    grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = _
                                            Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value _
                                                       * grid订单.ActiveRow.Cells(ENU_GRID1.数量).Value _
                                            / (grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value _
                                            * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value), 2)
                                Else
                                    'Exit Select
                                    grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = 0
                                End If
                            Else
                                grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = 0
                            End If
                        End If
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value) Then
                                If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value) Then
                                    grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = _
                                                Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value _
                                                * grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value _
                                                * grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value _
                                                * grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value, 2) _
                                                / 1000000

                                Else
                                    'Exit Select
                                    grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = 0
                                End If
                            Else
                                grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = 0
                            End If
                        End If
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = _
                                        Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value _
                                        * grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value _
                                        * grid订单.ActiveRow.Cells(ENU_GRID1.数量).Value, 2)
                        Else
                            'Exit Select
                            grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = 0
                        End If
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = 0
                    End If



                Case "棒材"

                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value = _
                        CInt(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value / (grid订单.ActiveRow.Cells(ENU_GRID1.长).Value + 10))
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value = 0
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                        grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value = 1
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value = 0
                    End If

                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value) Then

                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.数量1).Value = _
                               CInt(grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value)
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.数量1).Value = 0
                        End If
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.数量1).Value = 0
                    End If


                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value) Then
                                grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value = _
                                Math.Round((grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value / 2) ^ 2 _
                                * 3.14 / 1000000 * grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value _
                                * grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value _
                                / grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value / (grid订单.ActiveRow.Cells(ENU_GRID1.长).Value + 10), 2)
                            Else
                                grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value = 0
                            End If
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value = 0
                        End If
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value) AndAlso (grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value _
                                       * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value) <> 0 Then
                                'grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = _
                                'Math.Round((grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value / 2) ^ 2 _
                                '* 3.14 / 1000000 * grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value _
                                '* grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value _
                                '/ (grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value / (grid订单.ActiveRow.Cells(ENU_GRID1.长).Value + 10)) _
                                '* grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.数量).Value, 2)
                                grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = _
                                       Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value _
                                                  * grid订单.ActiveRow.Cells(ENU_GRID1.数量).Value _
                                       / (grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value _
                                       * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value), 2)
                            Else
                                grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = 0
                            End If
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = 0
                        End If
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value) Then
                                grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = _
                                Math.Round((grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value / 2) ^ 2 _
                                * 3.14 _
                                * grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value _
                                * grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value / 1000000, 2)
                            Else
                                grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = 0
                            End If
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = 0
                        End If
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = 0
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = _
                                        Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value _
                                        * grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value, 2)
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = 0
                        End If
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = 0
                    End If

                Case "管材"
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value = _
                        CInt(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value / (grid订单.ActiveRow.Cells(ENU_GRID1.长).Value + 10))
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value = 0
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                        grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value = 1
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value = 0
                    End If

                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value) Then

                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.数量1).Value = _
                               CInt(grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value)
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.数量1).Value = 0
                        End If
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.数量1).Value = 0
                    End If





                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) AndAlso grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value <> 0 Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value) Then
                                If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value) AndAlso grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value <> 0 Then
                                    grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value = _
                                    Math.Round((grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value - grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value) _
                                    * grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value _
                                    * grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value _
                                    * grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value _
                                    / 1000 / grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value _
                                    * grid订单.ActiveRow.Cells(ENU_GRID1.数量).Value, 2)
                                Else
                                    grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value = 0
                                End If
                            Else
                                grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value = 0
                            End If
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value = 0
                        End If
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) AndAlso (grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value _
                              * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value) <> 0 Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value) Then
                                If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value) Then
                                    'grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = _
                                    'Math.Round((grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value - grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value) _
                                    '* grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value _
                                    '* grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value _
                                    '* grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value _
                                    '/ 1000 / (grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value / (grid订单.ActiveRow.Cells(ENU_GRID1.长).Value + 10)) _
                                    '* grid订单.ActiveRow.Cells(ENU_GRID1.数量).Value _
                                    '* grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value, 2)
                                    grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = _
                              Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value _
                                         * grid订单.ActiveRow.Cells(ENU_GRID1.数量).Value _
                              / (grid订单.ActiveRow.Cells(ENU_GRID1.长度方向加工数量).Value _
                              * grid订单.ActiveRow.Cells(ENU_GRID1.宽度方向加工数量).Value), 2)
                                Else
                                    grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = 0
                                End If
                            Else
                                grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = 0
                            End If
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.计划采购数量).Value = 0
                        End If
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value) Then
                                If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value) Then
                                    grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = _
                                    Math.Round(3.14 * ((grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value / 2) ^ 2 - ((grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value _
                                    - 2 * grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value) / 2) ^ 2) _
                                    * grid订单.ActiveRow.Cells(ENU_GRID1.密度).Value _
                                    * grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value, 2) / 1000000
                                Else
                                    grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = 0
                                End If
                            Else
                                grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = 0
                            End If
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = 0
                        End If
                    End If
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = _
                                        Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value _
                                        * grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value, 2)
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = 0
                            'grid订单.ActiveRow.Cells(ENU_GRID1.单品耗材数量).Value = 0
                        End If
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.计划采购重量).Value = 0
                    End If

                Case "标准件"
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.长1).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.宽1).Value) Then
                            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.高1).Value) Then
                                'obj.主图号 = grid订单.ActiveRow.Cells(ENU_GRID1.主图号).Value
                                'obj.上级图号 = grid订单.ActiveRow.Cells(ENU_GRID1.上级图号).Value
                                'obj.分图号 = grid订单.ActiveRow.Cells(ENU_GRID1.分图号).Value
                                'dt = objBLL.Get重量(obj.主图号.ToString, obj.上级图号.ToString, obj.分图号.ToString)
                                'If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                                '    grid订单.ActiveRow.Cells(ENU_GRID1.重量).Value = dt.Rows(0).Item("单件重量").ToString
                                'End If

                            End If
                        End If
                    End If
            End Select
            Select Case Me.grid订单.ActiveCell.Column.Index
                Case ENU_GRID1.含税单价
                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value) AndAlso txt税率.Text.Trim <> "" Then
                        grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value = _
                        grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value / (1 + Me.txt税率.Text.Trim * 0.01)
                        '含税单价.text = Format(含税单价.text, "###0.0000")
                        grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value = Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value, 4)
                        'Format(grid订单.ActiveRow.Cells(ENU_GRID.未税单价).Value, "####")
                        ' Math.Round(grid订单.ActiveRow.Cells(ENU_GRID.未税单价).Value, 4)

                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value = 0
                    End If

                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value) AndAlso Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value) Then
                        grid订单.ActiveRow.Cells(ENU_GRID1.单耗含税金额).Value = _
                        grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value * grid订单.ActiveRow.Cells(ENU_GRID1.单耗).Value
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.单耗含税金额).Value = 0
                    End If


                    If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.实际采购数量).Value) Then
                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.含税总金额).Value = _
                                grid订单.ActiveRow.Cells(ENU_GRID1.实际采购数量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.含税总金额).Value = 0

                        End If

                        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value) Then
                            grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = _
                                grid订单.ActiveRow.Cells(ENU_GRID1.实际采购数量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value
                            grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value, 4)
                        Else
                            grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = 0

                        End If
                    Else
                        grid订单.ActiveRow.Cells(ENU_GRID1.含税总金额).Value = 0
                        grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = 0
                    End If
            End Select
            Me.grid订单.UpdateData()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    'Private Sub grid订单_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    Dim objM采购T As B原材料采购管理T
    '    Dim objBLLM采购T As New BllM原材料采购单管理T
    '    Dim str材料编号 As String = String.Empty
    '    Dim str产品种类 As String = String.Empty
    '    Dim dtGridInfo As New DataTable
    '    Dim dt As New DataTable
    '    Try

    '        Select Case mIntFormMode

    '            Case Constant.ENU_MODE.Model_New
    '                If grid订单.Rows.Count = 0 Then
    '                    Exit Sub
    '                End If
    '                dt = grid订单.DataSource()
    '                For Each drr As DataRow In dt.Rows
    '                    If Not IsDBNull(drr("材料编号")) Then
    '                        If str材料编号 = String.Empty Then
    '                            str材料编号 = drr("材料编号")
    '                        Else
    '                            str材料编号 = str材料编号 & "','" & drr("材料编号")
    '                        End If

    '                        If str产品种类 = String.Empty Then
    '                            str产品种类 = drr("材料种类")
    '                        Else
    '                            str产品种类 = str产品种类 & "','" & drr("材料种类")
    '                        End If
    '                    End If

    '                Next
    '                objM采购T = New B原材料采购管理T
    '                If grid订单.ActiveRow Is Nothing Then
    '                    Exit Sub
    '                End If
    '                If Not IsDBNull(grid订单.ActiveRow.Cells("材料编号").Value) Then
    '                    objM采购T.原材料编号 = str材料编号
    '                Else
    '                    objM采购T.原材料编号 = ""
    '                End If
    '                objM采购T.供应商编号 = txt供应商编号.Text.Trim
    '                objM采购T.采购单编号 = txt采购单编号.Text.Trim
    '                objM采购T.订单编号 = txt订单编号.Text.Trim
    '                objM采购T.材料种类 = str产品种类
    '                Me.grid订单.DataSource = Nothing
    '                dtGridInfo = objBLLM采购T.LoadAllGrid1(objM采购T)
    '                Me.grid订单.DataSource = dtGridInfo

    '            Case Constant.ENU_MODE.Model_Update
    '                objM采购T = New B原材料采购管理T
    '                If grid订单.ActiveRow Is Nothing Then
    '                    Exit Sub
    '                End If
    '                If Not IsDBNull(grid订单.ActiveRow.Cells("材料编号").Value) Then
    '                    objM采购T.原材料编号 = grid订单.ActiveRow.Cells("材料编号").Value.ToString()
    '                Else
    '                    objM采购T.原材料编号 = ""
    '                End If
    '                objM采购T.供应商编号 = txt供应商编号.Text.Trim
    '                objM采购T.采购单编号 = txt采购单编号.Text.Trim
    '                objM采购T.订单编号 = txt订单编号.Text.Trim
    '                objM采购T.材料种类 = grid订单.ActiveRow.Cells("材料种类").Value.ToString
    '                Me.grid订单.DataSource = Nothing
    '                'dtGridInfo = objBLLM采购T.LoadAllGrid1(objM采购T)
    '                'Me.grid订单.DataSource = dtGridInfo

    '                dtGridInfo = objBLLM采购T.Load工序(objM采购T)
    '                Me.grid订单.DataSource = dtGridInfo

    '        End Select

    '        If Not dtGridInfo Is Nothing AndAlso dtGridInfo.Rows.Count > 0 Then
    '            SetGridStyle()
    '        End If

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub
    Private Sub grid订单_InitializeLayout(ByVal sender As Object, ByVal e As InitializeLayoutEventArgs) Handles grid订单.InitializeLayout
        grid订单.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid订单.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
    End Sub

    Private Sub grid订单_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
        grid订单.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
    End Sub

    Private Sub grid订单_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

        If grid订单.Rows.Count = 0 Then
            Exit Sub
        End If

        If grid订单.ActiveCell.Equals(grid订单.Rows(grid订单.Rows.Count - 1).Cells(ENU_GRID1.备注)) Then
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
            '権限の処理            Me.BindGridCombox()
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

#Region "ClearForm"

    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>e
    ''' <remarks></remarks>
    Private Sub ClearForm()

        Try
            Me.txt采购单编号.Text = "CG" & Now.ToString("yyyyMMddhhmmss")
            Me.txt人员编号.Text = String.Empty
            Me.txt人员名称.Text = String.Empty
            Me.txt供应商编号.Text = String.Empty
            Me.txt供应商名称.Text = String.Empty
            Me.txt订单编号.Text = String.Empty
            Me.txt税率.Text = String.Empty
            Me.txt申请日期.Text = DateTime.Now.ToString("yyyy/MM/dd")
            str审核状态 = String.Empty
            str审核人 = String.Empty

            DataSearch()

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

#Region "DataSearch"

    Private Sub DataSearch()

        Dim objModel As B原材料采购管理T

        Dim objBll As New BllM原材料采购单管理T

        Try
            objModel = New B原材料采购管理T
            '查询の検索処理

            objModel.采购单编号 = Me.txt采购单编号.Text.Trim
            objModel.订单编号 = Me.txt订单编号.Text.Trim
            If String.IsNullOrEmpty(objModel.采购单编号) Then
                objModel.采购单编号 = " "
            End If

            dsReturn = objBll.LoadDsByWhere(objModel)

            If dsReturn.Tables.Count = 0 Then
                Exit Sub
            End If

            '新规
            'If mIntFormMode <> Constant.ENU_MODE.Model_New Then
            '显示订单信息
            If txt人员编号.Text.Trim <> String.Empty Then
                txt人员编号.Text = txt人员编号.Text.Trim
                txt人员名称.Text = txt人员名称.Text.Trim
                txt供应商编号.Text = txt供应商编号.Text.Trim
                txt供应商名称.Text = txt供应商名称.Text.Trim
                txt税率.Text = txt税率.Text.Trim
                txt申请日期.Text = txt申请日期.Text.Trim
            Else
                If dsReturn.Tables(0).Rows.Count > 0 Then
                    Me.txt采购单编号.Text = dsReturn.Tables(0).Rows(0)("采购单编号").ToString()
                    Me.txt人员编号.Text = dsReturn.Tables(0).Rows(0)("作成者编号").ToString()
                    Me.txt人员名称.Text = dsReturn.Tables(0).Rows(0)("人员名称").ToString()
                    Me.txt供应商编号.Text = dsReturn.Tables(0).Rows(0)("供应商编号").ToString()
                    Me.txt供应商名称.Text = dsReturn.Tables(0).Rows(0)("供应商名称").ToString()
                    Me.txt税率.Text = dsReturn.Tables(0).Rows(0)("税率").ToString()
                    Me.txt申请日期.Text = dsReturn.Tables(0).Rows(0)("申请日期").ToString()

                    'str审核状态 = dsReturn.Tables(0).Rows(0)("审核状态").ToString()
                    'str审核人编号 = dsReturn.Tables(0).Rows(0)("审核人编号").ToString()
                Else
                    Me.txt采购单编号.Text = "CG" & Now.ToString("yyyyMMddhhmmss")
                    Me.txt人员编号.Text = String.Empty
                    Me.txt人员名称.Text = String.Empty
                    Me.txt供应商编号.Text = String.Empty
                    Me.txt供应商名称.Text = String.Empty
                    Me.txt税率.Text = String.Empty
                    Me.txt申请日期.DateTime = DateTime.Now
                    str审核状态 = String.Empty
                    str审核人 = String.Empty
                End If
            End If


            If dsReturn.Tables(1) Is Nothing OrElse dsReturn.Tables(1).Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                Me.grid订单.DataSource = dsReturn.Tables(1)

            Else
                Me.grid订单.DataSource = dsReturn.Tables(1)

                Me.grid订单.Focus()
                Me.grid订单.ActiveRow = Me.grid订单.Rows(0)
                'Call grid订单_MouseDown(Nothing, Nothing)
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
#Region "DataSearch1"

    Private Sub DataSearch1()

        Dim objModel As B原材料采购管理T

        Dim objBll As New BllM原材料采购单管理T

        Try
            objModel = New B原材料采购管理T
            '查询の検索処理

            objModel.采购单编号 = Me.txt采购单编号.Text.Trim
            objModel.订单编号 = Me.txt订单编号.Text.Trim
            If String.IsNullOrEmpty(objModel.采购单编号) Then
                objModel.采购单编号 = " "
            End If

            dsReturn = objBll.LoadDsByWhere1(objModel)

            If dsReturn.Tables.Count = 0 Then
                Exit Sub
            End If

            '新规
            'If mIntFormMode <> Constant.ENU_MODE.Model_New Then
            '显示订单信息
            If dsReturn.Tables(0).Rows.Count > 0 Then
                Me.txt采购单编号.Text = dsReturn.Tables(0).Rows(0)("采购单编号").ToString()
                Me.txt人员编号.Text = dsReturn.Tables(0).Rows(0)("作成者编号").ToString()
                Me.txt人员名称.Text = dsReturn.Tables(0).Rows(0)("人员名称").ToString()
                Me.txt供应商编号.Text = dsReturn.Tables(0).Rows(0)("供应商编号").ToString()
                Me.txt供应商名称.Text = dsReturn.Tables(0).Rows(0)("供应商名称").ToString()
                Me.txt税率.Text = dsReturn.Tables(0).Rows(0)("税率").ToString()
                Me.txt申请日期.Text = dsReturn.Tables(0).Rows(0)("申请日期").ToString()

                'str审核状态 = dsReturn.Tables(0).Rows(0)("审核状态").ToString()
                'str审核人 = dsReturn.Tables(0).Rows(0)("审核人编号").ToString()
            Else
                Me.txt采购单编号.Text = "CG" & Now.ToString("yyyyMMddhhmmss")
                Me.txt人员编号.Text = String.Empty
                Me.txt人员名称.Text = String.Empty
                Me.txt供应商编号.Text = String.Empty
                Me.txt供应商名称.Text = String.Empty
                Me.txt税率.Text = String.Empty
                Me.txt申请日期.DateTime = DateTime.Now
                'str审核状态 = String.Empty
                'str审核人 = String.Empty
            End If

            If dsReturn.Tables(1) Is Nothing OrElse dsReturn.Tables(1).Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                Me.grid订单.DataSource = dsReturn.Tables(1)

            Else
                Me.grid订单.DataSource = dsReturn.Tables(1)
                str审核状态 = dsReturn.Tables(1).Rows(0)("审核状态").ToString()
                str审核备注 = dsReturn.Tables(1).Rows(0)("审核备注").ToString()
                str采购状态 = dsReturn.Tables(1).Rows(0)("采购状态").ToString()
                Me.grid订单.Focus()
                Me.grid订单.ActiveRow = Me.grid订单.Rows(0)
                SetGridStyle()
                'Call grid订单_MouseDown(Nothing, Nothing)
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
#Region "SetPermission"

    Private Sub SetPermission()
        Try

            'Me.btnF1清空.Enabled = Utility.PFn_GetAuth(Me.btnF1清空.Tag)
            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            Me.btnF5行追加.Enabled = Utility.PFn_GetAuth(Me.btnF5行追加.Tag)
            Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)
            Me.btnF10.Enabled = Utility.PFn_GetAuth(Me.btnF11.Tag)
            Me.btnF11.Enabled = Utility.PFn_GetAuth(Me.btnF11.Tag)

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

                    txt采购单编号.ReadOnly = False
                    btnF11.Enabled = True

                    Me.txt人员编号.ReadOnly = False
                    Me.txt供应商编号.ReadOnly = False
                    Me.txt申请日期.ReadOnly = False
                    'Me.grid订单.Enabled = True
                    Me.btnF3保存.Enabled = True
                    Me.btnF4删除.Enabled = True
                    Me.btnF5行追加.Enabled = True
                    Me.btnF6行删除.Enabled = True
                    'Me.btnF11.Visible = False
                    'Me.btnF10.Visible = False
                    Me.btnF5行追加.Visible = False
                    Me.btnF6行删除.Visible = False
                    labModel.Text = Constant.cgStrNew
                    txt采购单编号.Select()
                Case Constant.ENU_MODE.Model_Update

                    txt采购单编号.ReadOnly = True
                    txt采购单编号.TabStop = False
                    'str审核状态 = 0
                    'str审核人 = String.Empty
                    'Me.btnF11.Enabled = Utility.PFn_GetAuth(Me.btnF11.Tag)
                    'Me.btnF11.Visible = True
                    'Me.btnF10.Visible = True
                    Me.btnF11.Enabled = True
                    txt人员编号.Select()
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

            '订单编号
            If Me.txt采购单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "采购单编号", "采购单编号")
                txt采购单编号.Focus()
                Return False
            End If

            If Me.txt人员编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "作成者", "作成者")
                txt人员编号.Focus()
                Return False
            Else
                Dim objModel = New M人员T
                Dim objBll = New BLLM人员T

                objModel.人员编号 = Me.txt人员编号.Text.Trim
                objModel = objBll.LoadByPKey(objModel)
                If objModel.人员编号 = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID17, "作成者", "作成者")
                    txt人员编号.Focus()
                    Return False
                End If
            End If

            If Me.txt供应商编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "供应商", "供应商")
                txt供应商编号.Focus()
                Return False
            Else
                Dim objModel = New M供应商T
                Dim objBll = New BLLM供应商T

                objModel.供应商编号 = Me.txt供应商编号.Text.Trim
                objModel = objBll.LoadByPKey(objModel)
                If objModel.供应商编号 = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID17, "供应商", "供应商")
                    txt供应商编号.Focus()
                    Return False
                End If
            End If

            '出荷日期
            If Me.txt申请日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请日期", "申请日期")
                txt申请日期.Focus()
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

            '必須チェック(MsgID=13) 

            '订单编号
            If Me.txt采购单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "采购单编号", "采购单编号")
                txt采购单编号.Focus()
                Return False
            End If

            If Me.txt人员编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "作成者", "作成者")
                txt人员编号.Focus()
                Return False
            Else
                Dim objModel = New M人员T
                Dim objBll = New BLLM人员T

                objModel.人员编号 = Me.txt人员编号.Text.Trim
                objModel = objBll.LoadByPKey(objModel)
                If objModel.人员编号 = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID17, "作成者", "作成者")
                    txt人员编号.Focus()
                    Return False
                End If
            End If

            'If Me.txt供应商编号.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "供应商", "供应商")
            '    txt供应商编号.Focus()
            '    Return False
            'Else
            '    Dim objModel = New M供应商T
            '    Dim objBll = New BLLM供应商T

            '    objModel.供应商编号 = Me.txt供应商编号.Text.Trim
            '    objModel = objBll.LoadByPKey(objModel)
            '    If objModel.供应商编号 = "" Then
            '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID17, "供应商", "供应商")
            '        txt供应商编号.Focus()
            '        Return False
            '    End If
            'End If

            '出荷日期
            If Me.txt申请日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请日期", "申请日期")
                txt申请日期.Focus()
                Return False
            End If

            If grid订单.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "采购材料", "采购单编号")
                Me.btnF5行追加.Select()
                Return False
            End If

            Dim intLoopi As Integer

            For intLoopi = 0 To grid订单.Rows.Count - 1

                Select Case mIntFormMode

                    Case Constant.ENU_MODE.Model_New
                        If Me.grid订单.Rows(intLoopi).Cells("选择").Value.ToString() = 0 Then
                            Continue For
                        End If
                    Case Constant.ENU_MODE.Model_Update
                        If Me.grid订单.Rows(intLoopi).Cells("选择").Value.ToString() = True Then
                            Continue For
                        End If
                End Select

                If grid订单.Rows(intLoopi).Cells(ENU_GRID1.实际采购数量).Value.ToString = "" And grid订单.Rows(intLoopi).Cells(ENU_GRID1.实际采购重量).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "实际采购量", "采购材料")
                    If grid订单.Rows(intLoopi).Cells(ENU_GRID1.实际采购数量).Value.ToString = "" Then
                        Me.grid订单.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID1.实际采购数量).Activated = True
                        Me.grid订单.Select()
                        Return False
                    Else
                        Me.grid订单.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID1.实际采购重量).Activated = True
                        Me.grid订单.Select()
                        Return False
                    End If
                End If

                If grid订单.Rows(intLoopi).Cells(ENU_GRID1.实际采购数量).Value.ToString <> "" Then
                    If grid订单.Rows(intLoopi).Cells(ENU_GRID1.实际采购数量).Value <= 0 Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "实际采购数量", "采购材料")
                        Me.grid订单.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID1.实际采购数量).Activated = True
                        Me.grid订单.Select()
                        Return False
                    End If
                End If

                If grid订单.Rows(intLoopi).Cells(ENU_GRID1.实际采购重量).Value.ToString <> "" Then
                    If grid订单.Rows(intLoopi).Cells(ENU_GRID1.实际采购重量).Value <= 0 Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "实际采购重量", "采购材料")
                        Me.grid订单.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID1.实际采购重量).Activated = True
                        Me.grid订单.Select()
                        Return False
                    End If
                End If
                If grid订单.Rows(intLoopi).Cells(ENU_GRID1.供货日期).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "供货日期", "采购材料")
                    Me.grid订单.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID1.供货日期).Activated = True
                    Me.grid订单.Select()
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

#Region "SaveData"

    Private Sub SaveData()

        Try


            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New
                    Dim objBll As New BllM原材料采购单管理T
                    Dim arrayList As New ArrayList
                    Dim objM采购单T As New B原材料采购管理T

                    For j = 0 To grid订单.Rows.Count - 1
                        If Me.grid订单.Rows(j).Cells("选择").Value.ToString() = 1 Then

                            objM采购单T = New B原材料采购管理T
                            objM采购单T.采购单编号 = Me.txt采购单编号.Text.Trim
                            objM采购单T.作成者编号 = Me.txt人员编号.Text.Trim
                            objM采购单T.供应商编号 = Me.txt供应商编号.Text.Trim
                            objM采购单T.申请日期 = Me.txt申请日期.Text.Trim
                            objM采购单T.税率 = Me.txt税率.Text.Trim
                            objM采购单T.审核备注 = str审核备注
                            objM采购单T.原材料编号 = Me.grid订单.Rows(j).Cells(ENU_GRID1.材料编号).Value.ToString()
                            objM采购单T.订单编号 = Me.grid订单.Rows(j).Cells(ENU_GRID1.订单编号).Value.ToString()
                            objM采购单T.主图号 = Me.grid订单.Rows(j).Cells(ENU_GRID1.主图号).Value.ToString()
                            objM采购单T.上级图号 = Me.grid订单.Rows(j).Cells(ENU_GRID1.上级图号).Value.ToString()
                            objM采购单T.分图号 = Me.grid订单.Rows(j).Cells(ENU_GRID1.分图号).Value.ToString()
                            objM采购单T.长 = Me.grid订单.Rows(j).Cells(ENU_GRID1.长1).Value.ToString()
                            objM采购单T.宽 = Me.grid订单.Rows(j).Cells(ENU_GRID1.宽1).Value.ToString()
                            objM采购单T.高 = Me.grid订单.Rows(j).Cells(ENU_GRID1.高1).Value.ToString()
                            objM采购单T.长度方向加工数量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.长度方向加工数量).Value.ToString()
                            objM采购单T.宽度方向加工数量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.宽度方向加工数量).Value.ToString()
                            objM采购单T.数量1 = Me.grid订单.Rows(j).Cells(ENU_GRID1.数量1).Value.ToString()
                            objM采购单T.重量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.重量).Value.ToString()
                            objM采购单T.单品耗材数量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.单耗).Value.ToString()
                            objM采购单T.计划采购数量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.计划采购数量).Value.ToString()
                            objM采购单T.实际采购数量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.实际采购数量).Value.ToString()
                            objM采购单T.计划采购重量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.计划采购重量).Value.ToString()
                            objM采购单T.实际采购重量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.实际采购重量).Value.ToString()
                            objM采购单T.币种 = Me.grid订单.Rows(j).Cells(ENU_GRID1.币种).Value.ToString()
                            objM采购单T.含税单价 = Me.grid订单.Rows(j).Cells(ENU_GRID1.含税单价).Value.ToString()
                            objM采购单T.含税总金额 = Me.grid订单.Rows(j).Cells(ENU_GRID1.含税总金额).Value.ToString()
                            objM采购单T.未税单价 = Me.grid订单.Rows(j).Cells(ENU_GRID1.未税单价).Value.ToString()
                            objM采购单T.未税总金额 = Me.grid订单.Rows(j).Cells(ENU_GRID1.未税总金额).Value.ToString()
                            objM采购单T.供货日期 = Me.grid订单.Rows(j).Cells(ENU_GRID1.供货日期).Value.ToString()
                            objM采购单T.供货方式 = Me.grid订单.Rows(j).Cells(ENU_GRID1.供货方式).Value.ToString()
                            objM采购单T.备注 = Me.grid订单.Rows(j).Cells(ENU_GRID1.备注).Value.ToString()

                            'If str审核状态 = String.Empty Then
                            '    objM采购单T.审核状态 = 1
                            '    objM采购单T.采购状态 = 1
                            '    'objM采购单T.审核人编号 = gObjM_人员T.人员编号
                            'Else
                            '    objM采购单T.审核状态 = str审核状态
                            '    objM采购单T.采购状态 = str采购状态
                            '    objM采购单T.审核人编号 = gObjM_人员T.人员编号

                            'End If

                            arrayList.Add(objM采购单T)
                        End If

                    Next

                    If arrayList.Count = 0 Then
                        MsgBox("请选择要保存的数据。")
                        Exit Sub
                    End If


                    If objBll.LoadByPKey采购单编号(objM采购单T).采购单编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "采购单编号")
                        Me.txt采购单编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arrayList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                        '显示当前订单
                        'Me.DataSearch()
                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt采购单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update
                    Dim objBll As New BllM原材料采购单管理T
                    Dim arrayList As New ArrayList
                    Dim objM采购单T As New B原材料采购管理T

                    'For i = 0 To grid订单.Rows.Count - 1
                    '    objM采购单T.原材料编号 = Me.grid订单.Rows(i).Cells(ENU_GRID1.材料编号).Value.ToString()
                    'Next

                    For j = 0 To grid订单.Rows.Count - 1

                        objM采购单T = New B原材料采购管理T
                        objM采购单T.采购单编号 = Me.txt采购单编号.Text.Trim
                        objM采购单T.作成者编号 = Me.txt人员编号.Text.Trim
                        objM采购单T.供应商编号 = Me.txt供应商编号.Text.Trim
                        objM采购单T.申请日期 = Me.txt申请日期.Text.Trim
                        objM采购单T.税率 = Me.txt税率.Text.Trim
                        objM采购单T.审核备注 = str审核备注
                        objM采购单T.原材料编号 = Me.grid订单.Rows(j).Cells(ENU_GRID1.材料编号).Value.ToString()
                        objM采购单T.订单编号 = Me.grid订单.Rows(j).Cells(ENU_GRID1.订单编号).Value.ToString()
                        objM采购单T.主图号 = Me.grid订单.Rows(j).Cells(ENU_GRID1.主图号).Value.ToString()
                        objM采购单T.上级图号 = Me.grid订单.Rows(j).Cells(ENU_GRID1.上级图号).Value.ToString()
                        objM采购单T.分图号 = Me.grid订单.Rows(j).Cells(ENU_GRID1.分图号).Value.ToString()
                        objM采购单T.长 = Me.grid订单.Rows(j).Cells(ENU_GRID1.长1).Value.ToString()
                        objM采购单T.宽 = Me.grid订单.Rows(j).Cells(ENU_GRID1.宽1).Value.ToString()
                        objM采购单T.高 = Me.grid订单.Rows(j).Cells(ENU_GRID1.高1).Value.ToString()
                        objM采购单T.长度方向加工数量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.长度方向加工数量).Value.ToString()
                        objM采购单T.宽度方向加工数量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.宽度方向加工数量).Value.ToString()
                        objM采购单T.数量1 = Me.grid订单.Rows(j).Cells(ENU_GRID1.数量1).Value.ToString()
                        objM采购单T.重量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.重量).Value.ToString()
                        objM采购单T.单品耗材数量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.单耗).Value.ToString()
                        objM采购单T.计划采购数量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.计划采购数量).Value.ToString()
                        objM采购单T.实际采购数量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.实际采购数量).Value.ToString()
                        objM采购单T.计划采购重量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.计划采购重量).Value.ToString()
                        objM采购单T.实际采购重量 = Me.grid订单.Rows(j).Cells(ENU_GRID1.实际采购重量).Value.ToString()
                        objM采购单T.币种 = Me.grid订单.Rows(j).Cells(ENU_GRID1.币种).Value.ToString()
                        objM采购单T.含税单价 = Me.grid订单.Rows(j).Cells(ENU_GRID1.含税单价).Value.ToString()
                        objM采购单T.含税总金额 = Me.grid订单.Rows(j).Cells(ENU_GRID1.含税总金额).Value.ToString()
                        objM采购单T.未税单价 = Me.grid订单.Rows(j).Cells(ENU_GRID1.未税单价).Value.ToString()
                        objM采购单T.未税总金额 = Me.grid订单.Rows(j).Cells(ENU_GRID1.未税总金额).Value.ToString()
                        objM采购单T.供货日期 = Me.grid订单.Rows(j).Cells(ENU_GRID1.供货日期).Value.ToString()
                        objM采购单T.供货方式 = Me.grid订单.Rows(j).Cells(ENU_GRID1.供货方式).Value.ToString()
                        objM采购单T.备注 = Me.grid订单.Rows(j).Cells(ENU_GRID1.备注).Value.ToString()

                        ' lxq 2017-04-21 update
                        'If str审核状态 = String.Empty Then
                        '    objM采购单T.审核状态 = 1

                        '    'objM采购单T.审核人编号 = gObjM_人员T.人员编号
                        'Else
                        '    objM采购单T.审核状态 = str审核状态
                        '    objM采购单T.审核人编号 = gObjM_人员T.人员编号
                        'End If
                        'lxq 2017-04-21 end
                        If str采购状态 = String.Empty Then

                            objM采购单T.采购状态 = 1

                        Else
                            objM采购单T.采购状态 = str采购状态

                        End If

                        arrayList.Add(objM采购单T)

                    Next



                    If objBll.Delete(objM采购单T) > 0 AndAlso objBll.Insert(arrayList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)

                        '显示当前订单
                        Me.DataSearch()
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt采购单编号.Focus()
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
#Region "Update审核"

    'lxq 2017-04-21 update

    'Private Sub Update审核()
    '    Dim objModel As B原材料采购管理T
    '    Dim objBll As New BllM原材料采购单管理T

    '    Try
    '        objModel = New B原材料采购管理T
    '        objModel.采购单编号 = Me.txt采购单编号.Text.Trim
    '        If str审核状态 = String.Empty Then
    '            objModel.审核状态 = 1
    '        Else
    '            objModel.审核状态 = str审核状态
    '            objModel.审核备注 = str审核备注
    '            objModel.审核人编号 = str审核人
    '        End If
    '        mds = objBll.Update审核(objModel)
    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

    'lxq 2017-04-21 end
#End Region
#Region "Update采购状态"

    Private Sub Update采购状态()
        Dim objModel As B原材料采购管理T
        Dim objBll As New BllM原材料采购单管理T

        Try
            objModel = New B原材料采购管理T
            objModel.采购单编号 = Me.txt采购单编号.Text.Trim
            If str采购状态 = String.Empty Then

                objModel.采购状态 = 1

            Else
                objModel.采购状态 = str采购状态

                'objModel.审核备注 = str审核备注
                'objModel.审核人编号 = str审核人

            End If
            mds = objBll.Update采购状态(objModel)
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

            With grid订单.DisplayLayout.Bands(0)
                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("选择").CellActivation = Activation.AllowEdit
                '.Columns("订单编号").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("订单编号").CellActivation = Activation.NoEdit
                .Columns("订单数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("订单数量").CellActivation = Activation.NoEdit
                '.Columns("投产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("投产数量").CellActivation = Activation.NoEdit
                .Columns("主图号").CellActivation = Activation.NoEdit
                .Columns("上级图号").CellActivation = Activation.NoEdit
                .Columns("主图号名称").CellActivation = Activation.NoEdit
                .Columns("分图号").CellActivation = Activation.NoEdit
                .Columns("分图号名称").CellActivation = Activation.NoEdit
                '.Columns("原材料编号").CellActivation = Activation.NoEdit
                '.Columns("原材料名称").CellActivation = Activation.NoEdit
                .Columns("材料代号").CellActivation = Activation.NoEdit
                .Columns("材料编号").CellActivation = Activation.NoEdit
                .Columns("材料种类").CellActivation = Activation.NoEdit
                .Columns("材质").CellActivation = Activation.NoEdit
                .Columns("长（图纸）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("长（图纸）").CellActivation = Activation.NoEdit
                .Columns("宽（图纸）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("宽（图纸）").CellActivation = Activation.NoEdit
                .Columns("高（图纸）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("高（图纸）").CellActivation = Activation.NoEdit
                .Columns("数量（每套）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("数量（每套）").CellActivation = Activation.NoEdit
                .Columns("长").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("长").CellActivation = Activation.NoEdit
                .Columns("宽（外径）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("宽（外径）").CellActivation = Activation.NoEdit
                .Columns("高（厚度）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("高（厚度）").CellActivation = Activation.NoEdit
                .Columns("密度").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("密度").CellActivation = Activation.NoEdit
                .Columns("重量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("重量").CellActivation = Activation.NoEdit
                .Columns("单耗").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("单耗").CellActivation = Activation.NoEdit
                .Columns("计划采购数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("计划采购数量").CellActivation = Activation.NoEdit
                .Columns("实际采购数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("实际采购数量").Style = ColumnStyle.Double
                .Columns("计划采购重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("计划采购重量（kg）").CellActivation = Activation.NoEdit
                .Columns("实际采购重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("实际采购重量（kg）").CellActivation = Activation.NoEdit
                .Columns("币种").CellActivation = Activation.NoEdit
                '.Columns("供货方式").ValueList.SelectedItemIndex = 1
                .Columns("含税单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("含税单价").CellActivation = Activation.NoEdit
                .Columns("含税总金额").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("含税总金额").CellActivation = Activation.NoEdit
                .Columns("单耗含税金额").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("单耗含税金额").CellActivation = Activation.NoEdit
                .Columns("未税单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("未税单价").CellActivation = Activation.NoEdit
                .Columns("未税总金额").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("未税总金额").CellActivation = Activation.NoEdit
                '.Columns("供货日期").Style = ColumnStyle.DateWithoutDropDown
                .Columns("供货日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("供应商编号").Hidden = True
                .Columns("审核状态").Hidden = True
                .Columns("审核备注").Hidden = True
                .Columns("采购状态").Hidden = True
                '.Columns("未税总单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            End With

        Catch ex As Exception
            '    '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            '    'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region
#Region "BindGridCombox"

    Private Sub BindGridCombox(Optional ByVal intRowIndex As Integer = 0)

        Try
            Utility.PFn_SetGirdCombo(Me.grid订单, "VM币种", ENU_GRID1.币种)
            Utility.PFn_SetGirdCombo(Me.grid订单, "VM供货方式", ENU_GRID1.供货方式)
        Catch ex As Exception

        End Try

    End Sub

#End Region
#Region "get密度"
    Public Function get密度(ByVal str材质 As String) As Double
        Dim objM采购T As New B原材料采购管理T
        Dim objBll As BllM原材料采购单管理T
        Dim dt密度 As New DataTable

        Try
            '获取数据
            objM采购T = New B原材料采购管理T
            objBll = New BllM原材料采购单管理T

            objM采购T.材质 = str材质
            If String.IsNullOrEmpty(objM采购T.材质) Then
                Return 0
            End If
            dt密度 = objBll.LoadAll密度(objM采购T)

            If Not dt密度 Is Nothing OrElse dt密度.Rows.Count > 0 Then
                Return dt密度.Rows(0).Item("密度")
            End If
            'End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Function
#End Region
#End Region


    Private Sub grid订单_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid订单.CellChange
        Try
            If grid订单.DataSource Is Nothing OrElse grid订单.Rows.Count = 0 Then
                Exit Sub
            End If
            grid订单.UpdateData()

            Select Case Me.grid订单.ActiveCell.Column.Index

                Case ENU_GRID1.实际采购数量

                    If Not IsDBNull(grid订单.ActiveRow.Cells("重量").Value) Then
                        Me.grid订单.ActiveRow.Cells("实际采购重量（kg）").Value = IIf(Me.grid订单.ActiveRow.Cells("实际采购数量").Value & "" = "", 0, Me.grid订单.ActiveRow.Cells("实际采购数量").Value) * Me.grid订单.ActiveRow.Cells("重量").Value
                    Else
                        'MsgBox("请输入长宽高的值！！")
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

    Private Sub btnF10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF10.Click
        Try
            '画面のCheck処理
            'If Not InputCheck() Then
            '    Exit Sub
            'End If


            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID2) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            str采购状态 = "2"
            Update采购状态()
            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "采购状态变更")

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt订单编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt订单编号.Leave
        DataSearch()
    End Sub

    Private Sub txt税率_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt供应商编号.Leave

        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value) Then
            If txt税率.Text.Trim <> String.Empty Then
                grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value = _
                            grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value / (1 + Me.txt税率.Text.Trim * 0.01)
                '含税单价.text = Format(含税单价.text, "###0.0000")
                grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value = Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value, 4)
                'Format(grid订单.ActiveRow.Cells(ENU_GRID.未税单价).Value, "####")
                ' Math.Round(grid订单.ActiveRow.Cells(ENU_GRID.未税单价).Value, 4)
            End If
        Else
            grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value = 0
        End If

        If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value) Then
            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value) Then
                grid订单.ActiveRow.Cells(ENU_GRID1.含税总金额).Value = _
                    grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.含税单价).Value
            Else
                grid订单.ActiveRow.Cells(ENU_GRID1.含税总金额).Value = 0

            End If

            If Not IsDBNull(grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value) Then
                grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = _
                    grid订单.ActiveRow.Cells(ENU_GRID1.订单数量).Value * grid订单.ActiveRow.Cells(ENU_GRID1.未税单价).Value
                grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = Math.Round(grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value, 4)
            Else
                grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = 0

            End If
        Else
            grid订单.ActiveRow.Cells(ENU_GRID1.含税总金额).Value = 0
            grid订单.ActiveRow.Cells(ENU_GRID1.未税总金额).Value = 0
        End If

    End Sub
End Class