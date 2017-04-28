Imports HRJS.Constant

Public Class frm出荷指示发行


#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Private mResturnDataSet As DataSet
    Private mDtOrder As DataTable
    Private mDtDetial As DataTable

    Private Enum ENU_GRID As Integer
        产品图号 = 0
        产品名称 = 1
        订单数量 = 2
        已出荷数量 = 3
        在库数量 = 4
        出荷数量 = 5

    End Enum

#End Region

#Region "Form Event"

    Private Sub frm出荷指示发行_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub frm出荷指示发行_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm出荷指示发行_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                    'Case Keys.F5
                    '    btnF5行追加.Focus()
                    '    btnF5行追加_Click(Nothing, Nothing)

                    'Case Keys.F6
                    '    btnF6行删除.Focus()
                    '    btnF6行删除_Click(Nothing, Nothing)

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

            ''画面の初期化処理
            ClearForm()

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF2编辑_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2编辑.Click

        Dim frmSearch As frm出荷指示一览

        Try

            frmSearch = New frm出荷指示一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '组立品信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置


                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号").ToString          '订单编号

                    Load订单()
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

                'cob组立品类别.Select()
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

        Dim objModelT As New B出荷指示T

        Dim objBll As New BllM出荷指示T

        Try
            '保存確認メッセージを表示する
            If txt订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If
            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objModelT.订单编号 = txt订单编号.Text.Trim

            If objBll.Delete(objModelT) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
            ClearForm()
            Me.txt订单编号.Focus()

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
            'If Not AddCheck() Then
            '    Exit Sub
            'End If

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

        tmpTable = mResturnDataSet.Tables(1).Copy()

        dr = mResturnDataSet.Tables(1).NewRow

        mResturnDataSet.Tables(1).Rows.Add(dr)
        mResturnDataSet.Tables(1).AcceptChanges()

        With Me.gridList
            .ActiveRow = .Rows(intRow)
            .Rows(intRow).Cells(0).Activate()
            .UpdateData()
            .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)

        End With

    End Sub

    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click

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
            If txt订单编号.ReadOnly Then
                Exit Sub
            End If


            frmSearch = New frm订单一览


            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置


                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号")

                    '出荷明细
                    Load订单()

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


    Private Sub txt订单编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt订单编号.Validating

        'Dim objModel As M订单表T
        'Dim dtTable As DataTable
        'Dim objBll As BllM订单表T

        Try

            '    If txt订单编号.ReadOnly Then
            '        Exit Sub
            '    End If

            '    If Me.txt订单编号.Tag = Me.txt订单编号.Text.Trim Then
            '        Exit Sub
            '    End If

            '    If Me.txt订单编号.Text.Trim <> String.Empty Then

            '        objModel = New M订单表T

            '        objModel.订单编号 = txt订单编号.Text.Trim
            '        objModel.订单日期 = "1900/1/1"
            '        objModel.订单日期2 = "1900/1/1"
            '        objBll = New BllM订单表T

            '        dtTable = objBll.LoadByWhere(objModel)

            '        If dtTable.Rows.Count <> 0 Then

            '            '出荷明细
            '            Load出荷指示(True)
            '        Else
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "订单编号")
            '            Me.txt订单编号.Select()
            '        End If
            '    Else

            '    End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Grid"
    Private Sub gridList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridlist.InitializeLayout

        gridlist.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        gridlist.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        'gridlist.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
    End Sub

    Private Sub gridList_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

        If gridList.ActiveCell.Equals(gridList.Rows(gridList.Rows.Count - 1).Cells(ENU_GRID.产品图号)) Then
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
    Private Sub InitForm()

        Try
            '画面のComboの初期値を設定する
            'Me.SetCombo()

            '画面の内容を清空処理
            Me.ClearForm()

            '権限の処理
            Me.SetPermission()

            Me.SetFormModel()

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

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try

            '制限件数コンボボックス


            'Utility.PFn_SetCombo(Me.cob制造区分, "VM制造区分", 1)

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

                    'Me.btnF4删除.Visible = False
                    'Me.btnF5行追加.Visible = True
                    'Me.btnF6行删除.Visible = True
                    labModel.Text = Constant.cgStrNew

                Case Constant.ENU_MODE.Model_Update
                    'Me.btnF5行追加.Visible = True
                    'Me.btnF6行删除.Visible = True
                    Me.btnF4删除.Visible = True
                    txt订单编号.ReadOnly = True
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

#Region "ClearForm"

    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()

        Try

            Me.txt备注.Text = String.Empty          '客户编号
            Me.txt订单编号.Text = String.Empty          '客户名称
            Me.txt客户名称.Text = String.Empty          '客户编号
            Me.txt出荷方式.Text = String.Empty          '组立品名
            Me.dmt出荷日期.Text = String.Empty        '子部品1供商
            Me.dmt出荷预定日.Text = DateTime.Now

            Load订单()

            Me.txt订单编号.Focus()


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

            Dim model As B出荷指示T
            Dim bll As New BllM出荷指示T

            Dim arryList As New ArrayList

            For i = 0 To gridList.Rows.Count - 1

                model = New B出荷指示T
                model.订单编号 = txt订单编号.Text.Trim

                '部品番号
                model.产品图号 = gridList.Rows(i).Cells(ENU_GRID.产品图号).Value.ToString()

                '制造批量号
                model.出荷数量 = gridList.Rows(i).Cells(ENU_GRID.出荷数量).Value.ToString()

                '箱数
                model.出荷预定日 = dmt出荷预定日.Text.Trim
                '备注
                model.备注 = Me.txt备注.Text.Trim

                arryList.Add(model)

                'End If

            Next

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If bll.LoadByPKey(model).出荷指示编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "出荷指示编号")
                        Me.txt订单编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If bll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt订单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If bll.Delete(model) > 0 AndAlso bll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
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

            If Me.gridList.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID24)
                gridList.Focus()
                Return False
            End If
            If Me.txt订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
                txt订单编号.Focus()
                Return False
            End If

            '必須チェック(MsgID=21) 
            Dim intLoopi As Integer
            For intLoopi = 0 To Me.gridList.Rows.Count - 1
                If gridList.Rows(intLoopi).Cells("出荷数量").Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "出荷数量", "出荷数量")
                    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells("出荷数量").Activated = True
                    Me.gridList.Select()
                    Return False
                End If

                'If gridList.Rows(intLoopi).Cells("出荷数量").Value.ToString <= gridList.Rows(intLoopi).Cells("订单数量").Value.ToString - gridList.Rows(intLoopi).Cells("已出荷数量").Value.ToString Then
                '    MsgBox("多于订单数量！")
                '    Me.gridList.Rows.GetRowAtVisibleIndex(intLoopi).Cells("公差").Activated = True
                '    Me.gridList.Select()
                '    Return False
                'End If

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

#Region "Load订单"
    Private Sub Load订单()
        Dim objB出荷指示T As New B出荷指示T

        Dim objBll As BllM出荷指示T

        Try
            '获取数据
            objB出荷指示T = New B出荷指示T
            objBll = New BllM出荷指示T

            objB出荷指示T.订单编号 = Me.txt订单编号.Text

            If Me.txt订单编号.Text <> String.Empty Then

                mDtOrder = objBll.LoadHead(objB出荷指示T)

                If Not mDtOrder Is Nothing And mDtOrder.Rows.Count > 0 Then

                    Me.txt订单编号.Text = mDtOrder.Rows(0)("订单编号").ToString()
                    Me.dmt出荷日期.Text = mDtOrder.Rows(0)("出荷日期").ToString()
                    Me.txt客户名称.Text = mDtOrder.Rows(0)("客户名称").ToString()
                    Me.txt出荷方式.Text = mDtOrder.Rows(0)("出荷方式").ToString()
                    Me.dmt出荷预定日.Text = mDtOrder.Rows(0)("出荷预定日").ToString()
                    Me.txt备注.Text = mDtOrder.Rows(0)("备注").ToString()
                    'Me.gridList.ActiveRow.Cells(ENU_GRID.产品图号).Value = mDtOrder.Rows(0)("产品图号").ToString()
                    'Me.gridList.Rows(0).Cells(ENU_GRID.产品名称).Value = mDtOrder.Rows(0)("产品名称").ToString()
                    'Me.gridList.Rows(0).Cells(ENU_GRID.订单数量).Value = mDtOrder.Rows(0)("订单数量").ToString()
                    'Me.gridList.Rows(0).Cells(ENU_GRID.已出荷数量).Value = mDtOrder.Rows(0)("已出荷数量").ToString()
                    'Me.gridList.Rows(0).Cells(ENU_GRID.在库数量).Value = mDtOrder.Rows(0)("在库数量").ToString()

                Else
                    Me.txt订单编号.Text = String.Empty
                    Me.dmt出荷日期.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    Me.txt出荷方式.Text = String.Empty
                End If

            End If
            mDtDetial = objBll.Load订单(objB出荷指示T)
            'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
            gridList.DataSource = mDtDetial
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

            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            'Me.btnF11.Enabled = Utility.PFn_GetAuth(Me.btnF11.Tag)
            'Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)

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