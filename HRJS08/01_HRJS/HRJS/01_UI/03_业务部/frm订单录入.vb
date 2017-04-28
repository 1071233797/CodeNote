Imports Infragistics.Win.UltraWinGrid
Imports HRJS.Constant

Public Class frm订单录入

#Region "常量定义"

    Private Enum ENU_GRID As Integer
        产品图号 = 0
        产品名称 = 1
        产品区分 = 2
        机型制造编号 = 3
        品种规格 = 4
        型号 = 5
        含税单价 = 6
        订单数量 = 7
        含税总金额 = 8
        未税单价 = 9
        未税总金额 = 10
        币种 = 11
        交货方式 = 12
        发货日期 = 13
        到货日期 = 14
        目的港名 = 15
        产品发票号 = 16
        产品助记码 = 17
        作成者编号 = 18
        作成者姓名 = 19
        备注 = 20
        '订单编号CD = 22

    End Enum

#End Region

#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Private dsReturn As DataSet
    Private str审核状态 As String
    Private str订单状态 As String
    Private str审核人 As String
    Private str审核备注 As String
    Dim dbl税率 As Double
    Dim strPathFlg As Boolean = False
    Dim strPath As String
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("PicturePath")
    Dim strTechnologyPathPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("PicturePath")
#End Region

#Region "Form Event"

    Private Sub frm订单录入_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frm订单录入_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm订单录入_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub btnF1清空_Click(sender As Object, e As EventArgs) Handles btnF1清空.Click

        Try
            '清空画面对话框
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

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

    Private Sub btnF2编辑_Click(sender As Object, e As EventArgs) Handles btnF2编辑.Click

        Dim frmSearch As frm订单一览
        Try

            frmSearch = New frm订单一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号").ToString.Trim
                    Me.txt厂内编号.Text = frmSearch.ReturnTable.Rows(0)("厂内编号").ToString.Trim
                    Me.cob订单区分.Text = frmSearch.ReturnTable.Rows(0)("订单区分").ToString.Trim
                    DataSearch()

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
                If str审核状态 = "已审核" Then
                    If Me.btnF11.Enabled = False Then
                        Me.txt客户编号.ReadOnly = True
                        Me.udt订单接受日期.ReadOnly = True
                        Me.cob订单区分.ReadOnly = True
                        Me.gridList.Enabled = False
                        Me.btnF3保存.Enabled = False
                        Me.btnF4删除.Enabled = False
                        Me.btnF5行追加.Enabled = False
                        Me.btnF6行删除.Enabled = False
                    Else
                        Me.txt客户编号.ReadOnly = False
                        Me.udt订单接受日期.ReadOnly = False
                        Me.cob订单区分.ReadOnly = False
                        Me.gridList.Enabled = True
                        Me.btnF3保存.Enabled = True
                        Me.btnF4删除.Enabled = True
                        Me.btnF5行追加.Enabled = True
                        Me.btnF6行删除.Enabled = True
                    End If
                Else
                    Me.txt客户编号.ReadOnly = False
                    Me.udt订单接受日期.ReadOnly = False
                    Me.cob订单区分.ReadOnly = False
                    Me.gridList.Enabled = True
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

    Private Sub btnF3保存_Click(sender As Object, e As EventArgs) Handles btnF3保存.Click

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

    Private Sub btnF4删除_Click(sender As Object, e As EventArgs) Handles btnF4删除.Click

        Dim objM订单表T As New B订单表T

        Dim objBll As New BllM订单表T

        Try

            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If String.IsNullOrEmpty(txt订单编号.Text.Trim) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If
            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objM订单表T.订单编号 = txt订单编号.Text.Trim

            If objBll.Delete(objM订单表T) > 0 Then

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


        If Me.gridList.Rows Is Nothing OrElse Me.gridList.Rows.Count = 0 Then
            intRow = 0
        Else
            intRow = Me.gridList.Rows.Count
        End If

        Dim tmpTable As New DataTable

        tmpTable = dsReturn.Tables(1).Copy()

        dr = dsReturn.Tables(1).NewRow

        dsReturn.Tables(1).Rows.Add(dr)
        dsReturn.Tables(1).AcceptChanges()

        With Me.gridList
            .ActiveRow = .Rows(intRow)
            .Rows(intRow).Cells(0).Activate()
            .ActiveRow.Cells(ENU_GRID.作成者编号).Value = gObjM_人员T.人员编号
            .ActiveRow.Cells(ENU_GRID.作成者姓名).Value = gObjM_人员T.人员名
            .UpdateData()
            .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)

        End With

    End Sub

    Private Sub btnF6行删除_Click(sender As Object, e As EventArgs) Handles btnF6行删除.Click

        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If Me.gridList.ActiveRow Is Nothing Then
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


            intRow = Me.gridList.ActiveRow.VisibleIndex

            intRowDelete = Me.gridList.ActiveRow.Index

            Me.gridList.Rows(intRowDelete).Delete(False)

            If Me.gridList.Rows.VisibleRowCount = 0 Or Me.gridList.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If Me.gridList.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf Me.gridList.Rows.VisibleRowCount = intRow Then
                    intRow = Me.gridList.Rows.VisibleRowCount - 1
                End If

                Me.gridList.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                Me.gridList.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.gridList.UpdateData()
            End If


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF11_Click(sender As Object, e As EventArgs) Handles btnF11.Click
        'Try
        '    '画面のCheck処理
        '    If Not InputCheck() Then
        '        Exit Sub
        '    End If


        '    '保存確認メッセージを表示する
        '    If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID2) = Constant.ENU_SHOWMSG.showMsgNo Then
        '        '処理終了
        '        Exit Sub
        '    End If

        '    str审核状态 = "已审核"
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

        '        '根据检索画面数据进行设置        '        str审核状态 = frmSearch.cmb审核状态.Value
        '        str审核备注 = frmSearch.txt审核备注.Text
        '        str审核人 = gObjM_人员T.人员名
        '        'objM订单表T.登录者 = gObjM_人员T.人员编号
        '        '设置画面数据
        '        SaveData()
        '        If frmSearch.cmb审核状态.Value = "2" Then
        '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "审核")

        '        End If

        '        If Not frmSearch.ReturnTable Is Nothing Then
        '            '检索画面释放

        '            frmSearch.ReturnTable.Dispose()
        '            frmSearch.ReturnTable = Nothing
        '        End If

        '        '检索画面释放        '        frmSearch.Dispose()
        '        frmSearch = Nothing


        '        '画面の修正処理        '        mIntFormMode = Constant.ENU_MODE.Model_Update
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

    Private Sub btnF12关闭_Click(sender As Object, e As EventArgs) Handles btnF12关闭.Click

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

#End Region

#Region "Control Event"

#Region "客户编号"

    Private Sub txt客户编号_Enter(sender As Object, e As EventArgs) Handles txt客户编号.Enter

        Try

            Me.txt客户编号.Tag = Me.txt客户编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt客户编号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt客户编号.EditorButtonClick


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

                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")     '客户编号

                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")     '客户名称

                    dbl税率 = frmSearch.ReturnTable.Rows(0)("税率")

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

    Private Sub txt客户编号_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt客户编号.Validating
        'tudu
        Dim objM客户T As M客户T
        Dim objBllM客户T As BLLM客户T

        Try

            If txt客户编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt客户编号.Text.Trim <> String.Empty Then

                If Me.txt客户编号.Tag = Me.txt客户编号.Text.Trim Then
                    Exit Sub
                End If

                objM客户T = New M客户T

                objM客户T.客户编号 = txt客户编号.Text.Trim


                objBllM客户T = New BLLM客户T

                objM客户T = objBllM客户T.LoadByPKey(objM客户T)

                If objM客户T.客户编号 <> "" Then

                    Me.txt客户名称.Text = objM客户T.客户名称

                Else
                    Me.txt客户编号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "客户名称")
                    Me.txt客户编号.Select()
                End If
            Else
                Me.txt客户名称.Text = String.Empty
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

#Region "Grid Event"
    'tudu

    Private Sub gridList_ClickCellButton(ByVal sender As Object, ByVal e As CellEventArgs) Handles gridList.ClickCellButton

        Dim frmSearch图纸 As frm图纸信息一览
        Dim frmSearch产品种类 As frm产品种类一览
        Dim frmSearch人员 As frm人员一览
        'Dim frmSearch客户 As frm客户一览

        Try

            If Me.gridList.ActiveCell Is Nothing Then
                Exit Sub
            End If

            Select Case Me.gridList.ActiveCell.Column.Index

                Case ENU_GRID.产品图号

                    If Me.gridList.DisplayLayout.Bands(0).Columns(ENU_GRID.产品图号).CellActivation = Activation.NoEdit Then
                        Exit Sub
                    End If

                    If Me.gridList.ActiveRow.Cells(ENU_GRID.产品图号).Activation = Activation.NoEdit Then
                        Exit Sub
                    End If

                    '砂時計のカーソルが設定
                    Me.Cursor = Cursors.WaitCursor

                    frmSearch图纸 = New frm图纸信息一览
                    frmSearch图纸.FormOpenMode = Constant.ENU_MODE.Model_Search
                    frmSearch图纸.bol订单 = True
                    frmSearch图纸.ShowDialog()

                    '画面数据设置
                    If frmSearch图纸.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                        If Not frmSearch图纸.ReturnTable Is Nothing AndAlso 0 < frmSearch图纸.ReturnTable.Rows.Count Then

                            '根据检索画面数据进行设置
                            If gridList.DataSource.select("产品图号='" & frmSearch图纸.ReturnTable.Rows(0)("产品图号") & "'").length > 0 Then
                                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "产品图号")
                            Else
                                Me.gridList.ActiveRow.Cells(ENU_GRID.产品图号).Value = frmSearch图纸.ReturnTable.Rows(0)("产品图号")     '产品图号

                                Me.gridList.ActiveRow.Cells(ENU_GRID.产品名称).Value = frmSearch图纸.ReturnTable.Rows(0)("品名")     '产品名称

                            End If

                        End If

                        If Not frmSearch图纸.ReturnTable Is Nothing Then
                            '检索画面释放

                            frmSearch图纸.ReturnTable.Dispose()
                            frmSearch图纸.ReturnTable = Nothing
                            frmSearch图纸.ReturnTable = Nothing
                        End If
                        '检索画面释放

                        frmSearch图纸.Dispose()
                        frmSearch图纸 = Nothing
                    End If


                    'Case ENU_GRID.产品种类

                    '    If Me.gridList.DisplayLayout.Bands(0).Columns(ENU_GRID.产品种类).CellActivation = Activation.NoEdit Then
                    '        Exit Sub
                    '    End If

                    '    If Me.gridList.ActiveRow.Cells(ENU_GRID.产品种类).Activation = Activation.NoEdit Then
                    '        Exit Sub
                    '    End If

                    '    '砂時計のカーソルが設定
                    '    Me.Cursor = Cursors.WaitCursor

                    '    frmSearch产品种类 = New frm产品种类一览
                    '    frmSearch产品种类.FormOpenMode = Constant.ENU_MODE.Model_Search
                    '    frmSearch产品种类.ShowDialog()

                    '    '画面数据设置
                    '    If frmSearch产品种类.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                    '        If Not frmSearch产品种类.ReturnTable Is Nothing AndAlso 0 < frmSearch产品种类.ReturnTable.Rows.Count Then

                    '            '根据检索画面数据进行设置
                    '            Me.gridList.ActiveRow.Cells(ENU_GRID.产品种类).Value = frmSearch产品种类.ReturnTable.Rows(0)("产品种类名称")     '产品种类名称

                    '            ' Me.gridList.ActiveRow.Cells(ENU_GRID.产品种类编号).Value = frmSearch产品种类.ReturnTable.Rows(0)("产品名称")     '部品名称


                    '        End If

                    '        If Not frmSearch产品种类.ReturnTable Is Nothing Then
                    '            '检索画面释放

                    '            frmSearch产品种类.ReturnTable.Dispose()
                    '            frmSearch产品种类.ReturnTable = Nothing
                    '            frmSearch产品种类.ReturnTable = Nothing
                    '        End If
                    '        '检索画面释放

                    '        frmSearch产品种类.Dispose()
                    '        frmSearch产品种类 = Nothing
                    '    End If

                Case ENU_GRID.作成者编号
                    If Me.gridList.DisplayLayout.Bands(0).Columns(ENU_GRID.作成者编号).CellActivation = Activation.NoEdit Then
                        Exit Sub
                    End If

                    If Me.gridList.ActiveRow.Cells(ENU_GRID.作成者编号).Activation = Activation.NoEdit Then
                        Exit Sub
                    End If

                    '砂時計のカーソルが設定
                    Me.Cursor = Cursors.WaitCursor

                    frmSearch人员 = New frm人员一览
                    frmSearch人员.FormOpenMode = Constant.ENU_MODE.Model_Search
                    frmSearch人员.ShowDialog()

                    '画面数据设置
                    If frmSearch人员.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                        If Not frmSearch人员.ReturnTable Is Nothing AndAlso 0 < frmSearch人员.ReturnTable.Rows.Count Then

                            '根据检索画面数据进行设置
                            Me.gridList.ActiveRow.Cells(ENU_GRID.作成者编号).Value = frmSearch人员.ReturnTable.Rows(0)("人员编号")     '部品番号

                            Me.gridList.ActiveRow.Cells(ENU_GRID.作成者姓名).Value = frmSearch人员.ReturnTable.Rows(0)("人员名")     '部品名称


                        End If

                        If Not frmSearch人员.ReturnTable Is Nothing Then
                            '检索画面释放

                            frmSearch人员.ReturnTable.Dispose()
                            frmSearch人员.ReturnTable = Nothing
                            frmSearch人员.ReturnTable = Nothing
                        End If
                        '检索画面释放

                        frmSearch人员.Dispose()
                        frmSearch人员 = Nothing
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


    Private Sub gridList_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridList.CellChange
        Try
            If gridList.DataSource Is Nothing OrElse gridList.Rows.Count = 0 Then
                Exit Sub
            End If
            gridList.UpdateData()

            Select Case Me.gridList.ActiveCell.Column.Index

                Case ENU_GRID.订单数量
                    If Not IsDBNull(gridList.ActiveRow.Cells(ENU_GRID.订单数量).Value) Then
                        If Not IsDBNull(gridList.ActiveRow.Cells(ENU_GRID.含税单价).Value) Then
                            gridList.ActiveRow.Cells(ENU_GRID.含税总金额).Value = _
                                gridList.ActiveRow.Cells(ENU_GRID.订单数量).Value * gridList.ActiveRow.Cells(ENU_GRID.含税单价).Value
                        Else
                            gridList.ActiveRow.Cells(ENU_GRID.含税总金额).Value = 0

                        End If

                        If Not IsDBNull(gridList.ActiveRow.Cells(ENU_GRID.未税单价).Value) Then
                            gridList.ActiveRow.Cells(ENU_GRID.未税总金额).Value = _
                                gridList.ActiveRow.Cells(ENU_GRID.订单数量).Value * gridList.ActiveRow.Cells(ENU_GRID.未税单价).Value
                            gridList.ActiveRow.Cells(ENU_GRID.未税总金额).Value = Math.Round(gridList.ActiveRow.Cells(ENU_GRID.未税总金额).Value, 4)

                        Else
                            gridList.ActiveRow.Cells(ENU_GRID.未税总金额).Value = 0

                        End If
                    Else
                        gridList.ActiveRow.Cells(ENU_GRID.含税总金额).Value = 0
                        gridList.ActiveRow.Cells(ENU_GRID.未税总金额).Value = 0
                    End If

                Case ENU_GRID.含税单价
                    If Not IsDBNull(gridList.ActiveRow.Cells(ENU_GRID.含税单价).Value) Then
                        gridList.ActiveRow.Cells(ENU_GRID.未税单价).Value = _
                        gridList.ActiveRow.Cells(ENU_GRID.含税单价).Value / (1 + Me.dbl税率 * 0.01)
                        '含税单价.text = Format(含税单价.text, "###0.0000")
                        gridList.ActiveRow.Cells(ENU_GRID.未税单价).Value = Math.Round(gridList.ActiveRow.Cells(ENU_GRID.未税单价).Value, 4)
                        'Format(gridList.ActiveRow.Cells(ENU_GRID.未税单价).Value, "####")
                        ' Math.Round(gridList.ActiveRow.Cells(ENU_GRID.未税单价).Value, 4)

                    Else
                        gridList.ActiveRow.Cells(ENU_GRID.未税单价).Value = 0
                    End If

                    If Not IsDBNull(gridList.ActiveRow.Cells(ENU_GRID.订单数量).Value) Then
                        If Not IsDBNull(gridList.ActiveRow.Cells(ENU_GRID.含税单价).Value) Then
                            gridList.ActiveRow.Cells(ENU_GRID.含税总金额).Value = _
                                gridList.ActiveRow.Cells(ENU_GRID.订单数量).Value * gridList.ActiveRow.Cells(ENU_GRID.含税单价).Value
                        Else
                            gridList.ActiveRow.Cells(ENU_GRID.含税总金额).Value = 0

                        End If

                        If Not IsDBNull(gridList.ActiveRow.Cells(ENU_GRID.未税单价).Value) Then
                            gridList.ActiveRow.Cells(ENU_GRID.未税总金额).Value = _
                                gridList.ActiveRow.Cells(ENU_GRID.订单数量).Value * gridList.ActiveRow.Cells(ENU_GRID.未税单价).Value
                            gridList.ActiveRow.Cells(ENU_GRID.未税总金额).Value = Math.Round(gridList.ActiveRow.Cells(ENU_GRID.未税总金额).Value, 4)
                        Else
                            gridList.ActiveRow.Cells(ENU_GRID.未税总金额).Value = 0

                        End If
                    Else
                        gridList.ActiveRow.Cells(ENU_GRID.含税总金额).Value = 0
                        gridList.ActiveRow.Cells(ENU_GRID.未税总金额).Value = 0
                    End If
            End Select
            Me.gridList.UpdateData()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub gridList_InitializeLayout(ByVal sender As Object, ByVal e As InitializeLayoutEventArgs) Handles gridList.InitializeLayout
        gridList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        gridList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
    End Sub

    Private Sub gridList_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles gridList.GotFocus
        gridList.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
    End Sub

    Private Sub gridList_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridList.KeyDown

        If gridList.Rows.Count = 0 Then
            Exit Sub
        End If

        If gridList.ActiveCell.Equals(gridList.Rows(gridList.Rows.Count - 1).Cells(ENU_GRID.备注)) Then
            Exit Sub
        End If

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
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
            '画面のComboの初期値を設定する
            Me.SetCombo()

            '画面の内容を清空処理
            Me.ClearForm()
            SetFormModel()
            'SetGridStyle()
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

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try
            '订单区分
            Utility.PFn_SetCombo(Me.cob订单区分, "VM订单区分", 0)
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
            Me.txt客户编号.Text = String.Empty
            Me.txt客户名称.Text = String.Empty
            Me.udt订单接受日期.Text = DateTime.Now.ToString("yyyy/MM/dd")
            Me.txt厂内编号.Text = String.Empty
            Me.cob订单区分.Text = String.Empty
            'If Me.cob订单区分.Rows.Count > 0 Then
            '    Me.cob订单区分.Rows(0).Selected = True
            'End If

            DataSearch()

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

#Region "DataSearch"

    Private Sub DataSearch()

        Dim objModel As B订单表T

        Dim objBll As New BllM订单表T

        Try
            objModel = New B订单表T
            '查询の検索処理
            objModel.订单编号 = Me.txt订单编号.Text.Trim
            objModel.厂内编号 = Me.txt厂内编号.Text.Trim
            objModel.订单区分 = Me.cob订单区分.Text.Trim

            If String.IsNullOrEmpty(objModel.订单编号) Then
                objModel.订单编号 = " "
            End If
            If String.IsNullOrEmpty(objModel.厂内编号) Then
                objModel.厂内编号 = " "
            End If
            If String.IsNullOrEmpty(objModel.订单区分) Then
                objModel.订单区分 = " "
            End If

            dsReturn = objBll.LoadDsByWhere(objModel)

            If dsReturn.Tables.Count = 0 Then
                Exit Sub
            End If

            '新规
            'If mIntFormMode <> Constant.ENU_MODE.Model_New Then
            '显示订单信息
            If dsReturn.Tables(0).Rows.Count > 0 Then
                Me.txt订单编号.Text = dsReturn.Tables(0).Rows(0)("订单编号").ToString()
                Me.txt客户编号.Text = dsReturn.Tables(0).Rows(0)("客户编号").ToString()
                Me.txt客户名称.Text = dsReturn.Tables(0).Rows(0)("客户名称").ToString()
                Me.udt订单接受日期.DateTime = dsReturn.Tables(0).Rows(0)("订单接受日期").ToString()
                Me.cob订单区分.Text = dsReturn.Tables(0).Rows(0)("订单区分").ToString()
                Me.txt厂内编号.Text = dsReturn.Tables(0).Rows(0)("厂内编号").ToString()
                str审核状态 = dsReturn.Tables(0).Rows(0)("审核状态").ToString()
                str订单状态 = dsReturn.Tables(0).Rows(0)("订单状态").ToString()
                dbl税率 = dsReturn.Tables(0).Rows(0)("税率").ToString()
                str审核人 = dsReturn.Tables(0).Rows(0)("审核人").ToString()
            Else
                Me.txt订单编号.Text = String.Empty
                Me.txt客户编号.Text = String.Empty
                Me.txt客户名称.Text = String.Empty
                Me.udt订单接受日期.DateTime = DateTime.Now
                Me.cob订单区分.Rows(0).Selected = True
                Me.txt厂内编号.Text = String.Empty
                str审核状态 = String.Empty
                str订单状态 = "1"
                str审核人 = String.Empty
            End If

            If dsReturn.Tables(1) Is Nothing OrElse dsReturn.Tables(1).Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                Me.gridList.DataSource = dsReturn.Tables(1)

            Else
                Me.gridList.DataSource = dsReturn.Tables(1)

                Me.gridList.Focus()
                Me.gridList.ActiveRow = Me.gridList.Rows(0)

            End If

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

#Region "BindGridCombox"
    Private Sub BindGridCombox(Optional ByVal intRowIndex As Integer = 0)

        Try
            Utility.PFn_SetGirdCombo(Me.gridList, "VM产品区分", ENU_GRID.产品区分)
            Utility.PFn_SetGirdCombo(Me.gridList, "VM交货方式", ENU_GRID.交货方式)
            Utility.PFn_SetGirdCombo(Me.gridList, "VM币种", ENU_GRID.币种)
        Catch ex As Exception

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

                    txt订单编号.ReadOnly = False
                    txt厂内编号.ReadOnly = False
                    txt订单编号.TabStop = True
                    txt厂内编号.TabStop = True


                    Me.txt客户编号.ReadOnly = False
                    Me.udt订单接受日期.ReadOnly = False
                    Me.cob订单区分.ReadOnly = False
                    Me.gridList.Enabled = True
                    Me.btnF3保存.Enabled = True
                    Me.btnF4删除.Enabled = True
                    Me.btnF5行追加.Enabled = True
                    Me.btnF6行删除.Enabled = True
                    'Me.btnF11.Visible = False
                    Me.btnF11.Enabled = False
                    'Me.btnF11.Hidden = True
                    ' str审核状态 = 2
                    str审核人 = String.Empty
                    labModel.Text = Constant.cgStrNew
                    txt订单编号.Select()
                Case Constant.ENU_MODE.Model_Update

                    txt订单编号.ReadOnly = True
                    txt厂内编号.ReadOnly = True
                    txt订单编号.TabStop = False
                    txt厂内编号.TabStop = False
                    '  str审核状态 = 0
                    str审核人 = String.Empty
                    'Me.btnF11.Enabled = Utility.PFn_GetAuth(Me.btnF11.Tag)
                    'Me.btnF11.Visible = True
                    Me.btnF11.Enabled = True
                    cob订单区分.Select()
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
    ''' 行追加のCheck処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Function AddCheck() As Boolean
        Try
            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If
            '必須チェック(MsgID=13) 

            '订单编号
            If Me.txt订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
                txt订单编号.Focus()
                Return False
            End If

            If Me.txt厂内编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "厂内编号", "厂内编号")
                txt厂内编号.Focus()
                Return False
            End If

            If Me.txt客户编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户编号", "客户编号")
                txt客户编号.Focus()
                Return False
            End If

            '出荷日期
            If Me.udt订单接受日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单接受日期", "订单接受日期")
                udt订单接受日期.Focus()
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
            If Me.txt订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
                txt订单编号.Focus()
                Return False
            End If

            If Me.txt厂内编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "厂内编号", "厂内编号")
                txt厂内编号.Focus()
                Return False
            End If

            If Me.txt客户编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户编号", "客户编号")
                txt客户编号.Focus()
                Return False
            End If
            If Me.txt客户名称.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户编号", "客户编号")
                txt客户编号.Focus()
                Return False
            End If

            '出荷日期
            If Me.udt订单接受日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单接受日期", "订单接受日期")
                udt订单接受日期.Focus()
                Return False
            End If

            If gridList.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单产品", "订单编号")
                Me.btnF5行追加.Select()
                Return False
            End If

            Dim intLoopi As Integer

            For intLoopi = 0 To gridList.Rows.Count - 1
                'While gridList.Rows.Count > 1
                '    If gridList.Rows(intLoopi).Cells(ENU_GRID.产品图号).Value.ToString = gridList.Rows(intLoopi + 1).Cells(ENU_GRID.产品图号).Value.ToString Then
                '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "产品图号", "订单产品")
                '        Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.产品图号).Activated = True
                '        Me.gridList.Select()
                '        Return False
                '    End If
                '    While gridList.Rows.Count - 1 = intLoopi

                '    End While
                'End While
                '产品图号
                If gridList.Rows(intLoopi).Cells(ENU_GRID.产品图号).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品图号", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.产品图号).Activated = True
                    Me.gridList.Select()
                    Return False
                Else
                    'tudu
                    Dim objModel = New M图纸T
                    Dim objBll = New BLLM图纸T

                    objModel.产品图号 = gridList.Rows(intLoopi).Cells(ENU_GRID.产品图号).Value.ToString()
                    objModel = objBll.LoadByPKey(objModel)
                    If objModel.产品图号 = "" Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID17, "产品图号", "订单产品")
                        Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.产品图号).Activated = True
                        Me.gridList.Select()
                        Return False
                    End If
                End If

                If gridList.Rows(intLoopi).Cells(ENU_GRID.产品名称).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品名称", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.产品名称).Activated = True
                    Me.gridList.Select()
                    Return False
                End If
                '产品区分()
                If gridList.Rows(intLoopi).Cells(ENU_GRID.产品区分).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品区分", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.产品区分).Activated = True
                    Me.gridList.Select()
                    Return False
                End If
                'If gridList.Rows(intLoopi).Cells(ENU_GRID.产品种类).Text = "" Then
                '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品种类", "订单产品")
                '    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.产品种类).Activated = True
                '    Me.gridList.Select()
                '    Return False
                'Else
                '    'tudu
                '    Dim objModel = New M产品种类T
                '    Dim objBll = New BLLM产品种类T

                '    objModel.产品种类名称 = gridList.Rows(intLoopi).Cells(ENU_GRID.产品种类).Text
                '    objModel = objBll.LoadByPKey(objModel)
                '    If objModel.产品种类名称 = "" Then
                '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID17, "产品种类", "订单产品")
                '        Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.产品种类).Activated = True
                '        Me.gridList.Select()
                '        Return False
                '    End If
                'End If
                If gridList.Rows(intLoopi).Cells(ENU_GRID.机型制造编号).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "机型制造编号", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.机型制造编号).Activated = True
                    Me.gridList.Select()
                    Return False
                End If
                If gridList.Rows(intLoopi).Cells(ENU_GRID.含税单价).Value.ToString = "" Or "0" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "含税单价", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.含税单价).Activated = True
                    Me.gridList.Select()
                    Return False
                End If
                If gridList.Rows(intLoopi).Cells(ENU_GRID.品种规格).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "品种规格", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.品种规格).Activated = True
                    Me.gridList.Select()
                    Return False
                End If
                '订单数量
                If DBNull.Value.Equals(gridList.Rows(intLoopi).Cells(ENU_GRID.订单数量).Value) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单数量", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.订单数量).Activated = True
                    Me.gridList.Select()
                    Return False
                End If
                If gridList.Rows(intLoopi).Cells(ENU_GRID.型号).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "型号", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.型号).Activated = True
                    Me.gridList.Select()
                    Return False
                End If

                '订单数量

                'If DBNull.Value.Equals(gridList.Rows(intLoopi).Cells(ENU_GRID.投产数量).Value) Then
                '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "投产数量", "订单产品")
                '    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.投产数量).Activated = True
                '    Me.gridList.Select()
                '    Return False
                'End If
                If DBNull.Value.Equals(gridList.Rows(intLoopi).Cells(ENU_GRID.币种).Value) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "币种", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.币种).Activated = True
                    Me.gridList.Select()
                    Return False
                End If
                If DBNull.Value.Equals(gridList.Rows(intLoopi).Cells(ENU_GRID.交货方式).Value) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "交货方式", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.交货方式).Activated = True
                    Me.gridList.Select()
                    Return False
                End If

                '发货日期
                If gridList.Rows(intLoopi).Cells(ENU_GRID.发货日期).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "发货日期", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.发货日期).Activated = True
                    Me.gridList.Select()
                    Return False
                End If

                If Format(CDate(gridList.Rows(intLoopi).Cells(ENU_GRID.发货日期).Value.ToString), "yyyy/MM/dd") < Format(CDate(Me.udt订单接受日期.DateTime.ToString), "yyyy/MM/dd") Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "发货日期", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.发货日期).Activated = True
                    Me.gridList.Select()
                    Return False
                End If

                '到货日期
                If gridList.Rows(intLoopi).Cells(ENU_GRID.到货日期).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "到货日期", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.到货日期).Activated = True
                    Me.gridList.Select()
                    Return False
                End If

                If Not gridList.Rows(intLoopi).Cells(ENU_GRID.到货日期).Value >= gridList.Rows(intLoopi).Cells(ENU_GRID.发货日期).Value Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "到货日期", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.到货日期).Activated = True
                    Me.gridList.Select()
                    Return False
                End If

                '目的港名()
                If gridList.Rows(intLoopi).Cells(ENU_GRID.目的港名).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "目的港名", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.目的港名).Activated = True
                    Me.gridList.Select()
                    Return False
                End If
                '担当者()
                If DBNull.Value.Equals(gridList.Rows(intLoopi).Cells(ENU_GRID.产品发票号).Value) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品发票号", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.产品发票号).Activated = True
                    Me.gridList.Select()
                    Return False
                End If

                If gridList.Rows(intLoopi).Cells(ENU_GRID.作成者编号).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "作成者", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.作成者编号).Activated = True
                    Me.gridList.Select()
                    Return False
                Else

                    Dim objModel = New M人员T
                    Dim objBll = New BLLM人员T

                    objModel.人员编号 = gridList.Rows(intLoopi).Cells(ENU_GRID.作成者编号).Value.ToString()
                    objModel = objBll.LoadByPKey(objModel)
                    If objModel.人员编号 = "" Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID17, "作成者", "订单产品")
                        Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.作成者编号).Activated = True
                        Me.gridList.Select()
                        Return False
                    End If
                End If
                If gridList.Rows(intLoopi).Cells(ENU_GRID.作成者姓名).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "作成者", "订单产品")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells(ENU_GRID.作成者姓名).Activated = True
                    Me.gridList.Select()
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

            Dim objBll As New BllM订单表T
            Dim arrayList As New ArrayList
            Dim intLoopi As Integer
            Dim objM订单表T As New B订单表T

            For intLoopi = 0 To gridList.Rows.Count - 1

                objM订单表T = New B订单表T

                objM订单表T.订单编号 = Me.txt订单编号.Text.Trim
                objM订单表T.客户编号 = Me.txt客户编号.Text.Trim
                objM订单表T.订单区分 = Me.cob订单区分.Value
                objM订单表T.订单接受日期 = Me.udt订单接受日期.Text.Trim
                objM订单表T.厂内编号 = Me.txt厂内编号.Text.Trim
                objM订单表T.审核备注 = str审核备注

                objM订单表T.产品图号 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.产品图号).Value.ToString()
                objM订单表T.产品名称 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.产品名称).Value.ToString()

                objM订单表T.产品区分 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.产品区分).Value.ToString()
                objM订单表T.机型制造编号 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.机型制造编号).Value.ToString()
                objM订单表T.品种规格 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.品种规格).Value.ToString()
                objM订单表T.型号 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.型号).Value.ToString()


                objM订单表T.含税单价 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.含税单价).Value.ToString()
                objM订单表T.订单数量 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.订单数量).Value.ToString()
                'objM订单表T.投产数量 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.投产数量).Value.ToString()
                objM订单表T.含税总金额 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.含税总金额).Value.ToString()
                objM订单表T.未税单价 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.未税单价).Value.ToString()
                objM订单表T.未税总金额 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.未税总金额).Value.ToString()

                'objM订单表T.产品种类名称 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.产品种类).Value.ToString()
                objM订单表T.币种 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.币种).Value.ToString()
                objM订单表T.交货方式 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.交货方式).Value.ToString()
                objM订单表T.发货日期 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.发货日期).Value.ToString()
                objM订单表T.到货日期 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.到货日期).Value.ToString()
                objM订单表T.目的港名 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.目的港名).Value.ToString()

                objM订单表T.产品发票号 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.产品发票号).Value.ToString()
                objM订单表T.产品助记码 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.产品助记码).Value.ToString()
                objM订单表T.作成者编号 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.作成者编号).Value.ToString()


                objM订单表T.备注 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.备注).Value.ToString()

                
                ' objM订单表T.审核人 = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.作成者编号).Value.ToString()

                'If str审核状态 = String.Empty Then
                '    objM订单表T.审核状态 = "1"
                '    objM订单表T.审核人 = ""
                '    objM订单表T.审核备注 = ""
                'Else
                '    objM订单表T.审核状态 = str审核状态                '    objM订单表T.审核人 = str审核人                '    objM订单表T.审核备注 = str审核备注


                'End If




                If str订单状态 = String.Empty Then
                    objM订单表T.订单状态 = "1"
                Else
                    objM订单表T.订单状态 = str订单状态
                End If

                'objM订单表T.订单编号CD = Me.gridList.Rows(intLoopi).Cells(ENU_GRID.订单编号CD).Value.ToString()

                'objM订单表T.登录者 = gObjM_人员T.人员编号
                'objM订单表T.登录日期 = DateTime.Now
                'objM订单表T.更新者 = gObjM_人员T.人员编号
                'objM订单表T.更新日期 = DateTime.Now
                arrayList.Add(objM订单表T)
            Next

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey订单编号(objM订单表T).订单编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "订单编号")
                        Me.txt订单编号.Select()
                        '処理終了
                        ' ClearForm()

                        Exit Sub
                    End If

                    If objBll.LoadByPKey厂内编号(objM订单表T).厂内编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "厂内编号")
                        Me.txt厂内编号.Select()
                        '処理終了
                        'ClearForm()
                        Exit Sub

                    End If

                    If objBll.Insert(arrayList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                        '显示当前订单
                        Me.DataSearch()
                        ' ClearForm()

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt订单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Delete(objM订单表T) > 0 AndAlso objBll.Insert(arrayList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)

                        '显示当前订单
                        Me.DataSearch()
                        ' ClearForm()

                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt订单编号.Focus()
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

#Region "SetGridStyle"

    Private Sub SetGridStyle()
        Try

            'With gridList.DisplayLayout.Bands(0)
            '    .Columns("含税单价").MaxLength = 3

            'End With

        Catch ex As Exception
            '異常処理()
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル()
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#End Region

End Class