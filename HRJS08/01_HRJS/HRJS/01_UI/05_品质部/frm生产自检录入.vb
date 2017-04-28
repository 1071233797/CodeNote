Imports HRJS.Constant

Public Class frm生产自检录入

#Region "常量定义"

    Private Enum ENU_GRID As Integer
        图纸尺寸 = 0
        公差 = 1
        自检时间 = 2
        自检结果 = 3
        不良品数量 = 4
        待修品数量 = 5
        报废品数量 = 6
        备注 = 7
    End Enum

#End Region
#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable
    Dim dt流转票 As New DataTable
#End Region

#Region "Form Event"

    Private Sub frm生产实际管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub frm生产实际管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm生产实际管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
    Private Sub cmb本道工序_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb本道工序.TextChanged

        If cmb本道工序.DataSource.Select("工序编号='" & cmb本道工序.Value - 1 & "'").length > 0 Then
            Me.txt上道工序.Text = cmb本道工序.DataSource.Select("工序编号='" & cmb本道工序.Value - 1 & "'")(0).ITEM("工序名称")
            'Me.txt作业指示.Text = cmb本道工序.DataSource.Select("工序编号='" & cmb本道工序.Value & "'")(0).ITEM("加工内容简介")
        Else
            Me.txt上道工序.Text = String.Empty
            'Me.txt作业指示.Text = String.Empty
        End If


        If cmb本道工序.DataSource.Select("工序编号='" & cmb本道工序.Value + 1 & "'").length > 0 Then
            Me.txt下道工序.Text = cmb本道工序.DataSource.Select("工序编号='" & cmb本道工序.Value + 1 & "'")(0).ITEM("工序名称")
            'Me.txt作业指示.Text = cmb本道工序.DataSource.Select("工序编号='" & cmb本道工序.Value & "'")(0).ITEM("加工内容简介")
        Else
            Me.txt下道工序.Text = String.Empty
            'Me.txt作业指示.Text = String.Empty
        End If

        If Not cmb本道工序.Value Is Nothing AndAlso cmb本道工序.DataSource.Select("工序编号='" & cmb本道工序.Value & "'").length > 0 Then
            Me.txt作业指示.Text = cmb本道工序.DataSource.Select("工序编号='" & cmb本道工序.Value & "'")(0).ITEM("加工内容简介")

        End If


    End Sub
#End Region
#Region "Control Event"

#Region "订单"
    Private Sub txt订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick
        Dim frmSearch As frm生产计划一览
        Try

            frmSearch = New frm生产计划一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号").ToString        '订单编号
                    'Me.txt主图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号").ToString          '产品图号
                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称").ToString
                    Me.txt主图号.Text = frmSearch.ReturnTable.Rows(0)("主图号").ToString

                    If frmSearch.ReturnTable.Rows(0)("上级图号").ToString & "" = "" Then
                        Me.txt上级图号.Text = frmSearch.ReturnTable.Rows(0)("主图号").ToString
                    Else
                        Me.txt上级图号.Text = frmSearch.ReturnTable.Rows(0)("上级图号").ToString          '产品图号
                    End If

                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("分图号").ToString
                    'Me.txt计划生产数量.Text = frmSearch.ReturnTable.Rows(0)("订单数量").ToString
                    Dim objM生产实际T As New Z生产实际管理T
                    Dim objBll As BLLM生产实际管理T
                    objM生产实际T = New Z生产实际管理T
                    objBll = New BLLM生产实际管理T
                    objM生产实际T.产品图号 = Me.txt产品图号.Text

                    dt流转票 = objBll.LoadGetCom(objM生产实际T)

                    Me.cmb本道工序.DataSource = dt流转票
                    Me.cmb本道工序.ValueMember = "工序编号"
                    Me.cmb本道工序.DisplayMember = "工序名称"
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
    Private Sub txt订单编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt订单编号.Leave
        'Dim objM生产计划查询T As M生产计划制定T
        'Dim objBLLM生产计划制定T As BLLM生产计划制定T

        'Try

        '    If txt订单编号.ReadOnly Then
        '        Exit Sub
        '    End If

        '    If Me.txt订单编号.Text.Trim <> String.Empty Then

        '        If Me.txt订单编号.Tag = Me.txt订单编号.Text.Trim Then
        '            Exit Sub
        '        End If

        '        objM生产计划查询T = New M生产计划制定T

        '        objM生产计划查询T.订单编号 = txt订单编号.Text.Trim

        '        objBLLM生产计划制定T = New BLLM生产计划制定T

        '        objM生产计划查询T = objBLLM生产计划制定T.LoadByPKey(objM生产计划查询T)


        '        If objM生产计划查询T.工序编号 <> String.Empty Then

        '            Me.txt主图号.Text = objM生产计划查询T.主图号
        '            Me.txt上级图号.Text = objM生产计划查询T.上级图号
        '            Me.txt产品图号.Text = objM生产计划查询T.分图号

        '            Dim objM生产实际T As New Z生产实际管理T
        '            Dim objBll As BLLM生产实际管理T
        '            objM生产实际T = New Z生产实际管理T
        '            objBll = New BLLM生产实际管理T
        '            objM生产实际T.产品图号 = Me.txt产品图号.Text
        '            dt流转票 = objBll.LoadGetCom(objM生产实际T)
        '            Me.cmb本道工序.DataSource = dt流转票
        '            Me.cmb本道工序.ValueMember = "工序编号"
        '            Me.cmb本道工序.DisplayMember = "工序名称"

        '        Else
        '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "订单信息")
        '            Me.txt订单编号.Text = String.Empty
        '            Me.txt主图号.Text = String.Empty
        '            Me.txt上级图号.Text = String.Empty
        '            Me.txt产品图号.Text = String.Empty
        '            Me.txt订单编号.Select()
        '        End If
        '    Else
        '        Me.txt订单编号.Text = String.Empty
        '    End If
        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try
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

                    Me.txt人员名.Text = objM人员T.人员名     '客户名称

                    Me.txt职务.Text = objM人员T.职务

                    Me.txt部门名称.Text = objM人员T.部门

                    Me.txt订单编号.Select()
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员名称")
                    'Me.txt人员编号.Text = String.Empty
                    Me.txt人员名.Text = String.Empty
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
#End Region
#Region "产品图号"
    Private Sub txt产品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs)
        'Dim frmSearch As frm流转票一览
        'Try

        '    frmSearch = New frm流转票一览

        '    frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

        '    '供应商查询画面打开
        '    frmSearch.ShowDialog()

        '    '画面数据设置
        '    If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

        '        If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

        '            '根据检索画面数据进行设置
        '            Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号").ToString        '流转票编号
        '            Dim objM生产自检T As New Z生产自检录入T
        '            Dim objBll As BLLM生产自检录入T
        '            objM生产自检T = New Z生产自检录入T
        '            objBll = New BLLM生产自检录入T
        '            objM生产自检T.产品图号 = Me.txt产品图号.Text

        '            dt流转票 = objBll.LoadGetCom(objM生产自检T)

        '            Me.cmb本道工序.DataSource = dt流转票
        '            Me.cmb本道工序.ValueMember = "工序编号"
        '            Me.cmb本道工序.DisplayMember = "工序名称"
        '            Me.txt作业指示.Text = frmSearch.ReturnTable.Rows(0)("加工内容简介").ToString        '加工内容简介
        '            'Me.txt设备编号.Text = frmSearch.ReturnTable.Rows(0)("设备编号").ToString            '设备编号
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

            Me.Cursor = Cursors.WaitCursor

            ''画面の初期化処理
            ClearForm()

            mIntFormMode = Constant.ENU_MODE.Model_New
            SetFormData()
            SetFormModel()

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

    Private Sub btnF2编辑_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2编辑.Click

        Dim frmSearch As frm生产自检一览

        Try

            frmSearch = New frm生产自检一览


            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '原材料信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置


                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号").ToString          '订单编号
                    SetFormData()
                    '设置画面数据
                    Timer1_Timer()

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

        Dim objM生产自检T As New Z生产实际管理T

        Dim objBll As New BLLM生产实际管理T

        Try
            'If mIntFormMode = Constant.ENU_MODE.Model_New Then
            '    Exit Sub
            'End If

            '保存確認メッセージを表示する
            If Me.txt订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
                txt订单编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            objM生产自检T.订单编号 = txt订单编号.Text.Trim

            If objBll.Delete(objM生产自检T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()

            ClearForm()

            Me.txt人员编号.Focus()

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
                Me.txt订单编号.Select()
            Else
                Me.txt主图号.Select()
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub btnF5行追加_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF5行追加.Click
        Try
            Dim dr As DataRow
            Dim intRow As Integer
            Dim objBll As BLLM生产自检录入T

            If Me.grid生产自检.Rows.Count = 0 Then
                intRow = 0
            Else
                intRow = Me.grid生产自检.Rows.Count
            End If

            dr = mdsGridDataSet.NewRow()

            mdsGridDataSet.Rows.Add(dr)
            mdsGridDataSet.AcceptChanges()

            With Me.grid生产自检

                .ActiveRow = .Rows(intRow)
                .Rows(intRow).Cells(0).Activate()
                .UpdateData()
                .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
            End With
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub grid生产自检_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid生产自检.InitializeLayout
        grid生产自检.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid生产自检.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
    End Sub
    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click
        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If Me.grid生产自检.ActiveRow Is Nothing Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            '「選択された行を削除してもよろしいですか？」

            If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID4) = ENU_SHOWMSG.showMsgNo Then
                '登録処理終了
                Me.Cursor = Cursors.Default
                Return
            End If


            intRow = Me.grid生产自检.ActiveRow.VisibleIndex

            intRowDelete = Me.grid生产自检.ActiveRow.Index

            Me.grid生产自检.Rows(intRowDelete).Delete(False)

            If Me.grid生产自检.Rows.VisibleRowCount = 0 Or Me.grid生产自检.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If Me.grid生产自检.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf Me.grid生产自检.Rows.VisibleRowCount = intRow Then
                    intRow = Me.grid生产自检.Rows.VisibleRowCount - 1
                End If

                Me.grid生产自检.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                Me.grid生产自检.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.grid生产自检.UpdateData()
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
            SetGridStyle自检()
            Me.SetFormData()
            '画面の内容を清空処理
            'Me.ClearForm()
            Me.SetCombo()
            '権限の処理
            Me.SetPermission()
            ClearForm()
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
                    labModel.Text = Constant.cgStrNew
                    txt人员编号.Focus()
                Case Constant.ENU_MODE.Model_Update

                    txt订单编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    txt订单编号.Focus()
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

            Me.txt人员编号.Text = String.Empty
            Me.txt人员名.Text = String.Empty
            Me.txt职务.Text = String.Empty
            Me.txt部门名称.Text = String.Empty
            Me.txt订单编号.Text = String.Empty
            Me.txt客户名称.Text = String.Empty
            Me.txt产品图号.Text = String.Empty
            Me.txt主图号.Text = String.Empty
            Me.txt上级图号.Text = String.Empty
            'Me.cmb本道工序.DataSource = LoadGetCom(arryList)
            Me.txt上道工序.Text = String.Empty
            Me.txt主图号.Text = String.Empty
            Me.cmb本道工序.Text = String.Empty
            Me.txt上道工序.Text = String.Empty
            Me.txt下道工序.Text = String.Empty
            Me.txt作业指示.Text = String.Empty
            'Me.txt设备编号.Text = String.Empty
            'Me.txt计划生产数量.Text = String.Empty
            'Me.txt实际生产数量.Text = String.Empty
            'Me.dmt完成日期.Text = String.Empty
            'Me.dmt作业日期.Text = Date.Now
            'Me.txt作业时间.Text = String.Empty
            'Me.cmb作业方式.Text = String.Empty
            LoadGetCom()
            'mdsGridDataSet.Clear()
            'Me.grid生产自检.DataSource = mdsGridDataSet

            Me.txt人员编号.Select()

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

        'Try
        '    '订单区分
        '    'Utility.PFn_SetCombo(Me.cmb作业方式, "VM作业方式", 0)
        '    Utility.PFn_SetCombo(Me.cmb本道工序, "VM作业方式", 0)
        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try
    End Sub

#End Region
#Region "SaveData"
    ''' <summary>
    ''' 画面の保存処理    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveData()

        Try

            Dim objM生产自检T As New Z生产自检录入T
            Dim objBll As New BLLM生产自检录入T
            Dim arryList As New ArrayList

            For i = 0 To grid生产自检.Rows.Count - 1
                objM生产自检T = New Z生产自检录入T
                objM生产自检T.人员编号 = txt人员编号.Text.Trim
                objM生产自检T.分图号 = txt产品图号.Text.Trim
                objM生产自检T.主图号 = txt主图号.Text.Trim
                objM生产自检T.上级图号 = txt上级图号.Text.Trim
                objM生产自检T.订单编号 = txt订单编号.Text.Trim
                'objM生产自检T.设备编号 = txt设备编号.Text.Trim
                objM生产自检T.本道工序编号 = cmb本道工序.Value
                'objM生产自检T.上道工序 = txt上道工序.Text.Trim
                'objM生产自检T.下道工序 = txt下道工序.Text.Trim
                objM生产自检T.作业指示 = txt作业指示.Text.Trim
                objM生产自检T.图纸尺寸 = grid生产自检.Rows(i).Cells(ENU_GRID.图纸尺寸).Value.ToString()
                objM生产自检T.公差 = grid生产自检.Rows(i).Cells(ENU_GRID.公差).Value.ToString()
                objM生产自检T.自检时间 = grid生产自检.Rows(i).Cells(ENU_GRID.自检时间).Value.ToString()
                objM生产自检T.自检结果 = grid生产自检.Rows(i).Cells(ENU_GRID.自检结果).Value.ToString()
                objM生产自检T.不良品数量 = grid生产自检.Rows(i).Cells(ENU_GRID.不良品数量).Value.ToString()
                objM生产自检T.待修品数量 = grid生产自检.Rows(i).Cells(ENU_GRID.待修品数量).Value.ToString()
                objM生产自检T.报废品数量 = grid生产自检.Rows(i).Cells(ENU_GRID.报废品数量).Value.ToString()
                objM生产自检T.备注 = grid生产自检.Rows(i).Cells(ENU_GRID.备注).Value.ToString()
                objM生产自检T.登陆者 = gObjM_人员T.人员编号
                objM生产自检T.登陆日期 = DateTime.Now
                objM生产自检T.更新者 = gObjM_人员T.人员编号
                objM生产自检T.更新日期 = DateTime.Now
                arryList.Add(objM生产自检T)
            Next

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objM生产自检T).订单编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "产品图号")
                        Me.txt订单编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt订单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Delete(objM生产自检T) > 0 AndAlso objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt人员编号.Focus()
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

            '必須チェック(MsgID=21) 

            ''人员编号
            Dim objZ生产质检录入T As New Z生产自检录入T

            Dim objBll As New BLLM生产自检录入T



            Dim dt As New DataTable
            If Me.txt人员编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "人员编号", "人员编号")
                txt人员编号.Focus()
                Return False
            End If

            ''订单编号


            If Me.txt订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
                txt订单编号.Focus()
                Return False
            End If

            If grid生产自检.Rows(0).Cells("自检时间").Value.ToString = "" Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "自检时间", "自检时间")
                Return False
            End If

            ''实际生产数量

            'If Me.txt实际生产数量.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "实际生产数量", "实际生产数量")
            '    txt实际生产数量.Focus()
            '    Return False
            'End If
            ''完成日期

            'If Me.dmt完成日期.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "完成日期", "完成日期")
            '    dmt完成日期.Focus()
            '    Return False
            'End If
            ''作业日期
            'If Me.txt作业时间.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "作业时间", "作业时间")
            '    txt作业时间.Focus()
            '    Return False
            'End If
            'If Me.cmb作业方式.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "作业方式", "作业方式")
            '    cmb作业方式.Focus()
            '    Return False
            'End If
            'If Not String.IsNullOrEmpty(dmt作业时间sta.Text.Trim) And Not String.IsNullOrEmpty(dmt作业时间end.Text.Trim) Then
            '    If DateTime.Parse(dmt作业时间end.DateTime) > DateTime.Parse(dmt作业时间sta.DateTime) Then
            '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "作业开始时间", "作业开始时间")
            '        dmt作业时间sta.Focus()
            '        Return False
            '    End If
            'End If
            Dim intLoopi As Integer
            For intLoopi = 0 To Me.grid生产自检.Rows.Count - 1
                If grid生产自检.Rows(intLoopi).Cells("图纸尺寸").Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "图纸尺寸", "图纸尺寸")
                    Me.grid生产自检.Rows.GetRowAtVisibleIndex(intLoopi).Cells("图纸尺寸").Activated = True
                    Me.grid生产自检.Select()
                    Return False
                End If

                If grid生产自检.Rows(intLoopi).Cells("公差").Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "公差", "公差")
                    Me.grid生产自检.Rows.GetRowAtVisibleIndex(intLoopi).Cells("公差").Activated = True
                    Me.grid生产自检.Select()
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
    ''' <summary>
    ''' 権限の制御処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPermission()
        Try

            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            Me.btnF5行追加.Enabled = Utility.PFn_GetAuth(Me.btnF5行追加.Tag)
            Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)

        Catch ex As Exception
            '異常処理()
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル()
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region
#Region "SetData"
    Private Sub SetData()
        Dim objM生产自检T As New Z生产实际管理T
        Dim objBll As BLLM生产实际管理T

        Try
            '获取数据
            objM生产自检T = New Z生产实际管理T
            objBll = New BLLM生产实际管理T

            objM生产自检T.人员编号 = txt人员编号.Text.Trim()

            If String.IsNullOrEmpty(objM生产自检T.人员编号) Then
                objM生产自检T.人员编号 = " "
            End If
            If txt人员编号.Text.Trim <> String.Empty Then
                mdsInfoDataSet = objBll.Load人员(objM生产自检T)
                If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                    Me.txt人员编号.Text = mdsInfoDataSet.Rows(0)("人员编号").ToString()
                    Me.txt人员名.Text = mdsInfoDataSet.Rows(0)("人员名").ToString()
                    Me.txt职务.Text = mdsInfoDataSet.Rows(0)("职务").ToString()
                    Me.txt部门名称.Text = mdsInfoDataSet.Rows(0)("部门名称").ToString()

                Else
                    Me.txt人员编号.Text = String.Empty
                    Me.txt部门名称.Text = String.Empty
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
#Region "LoadGetCom"
    Private Sub LoadGetCom()
        Dim objM生产自检T As New Z生产实际管理T
        Dim objBll As BLLM生产实际管理T
        Dim arryList As New ArrayList
        Try
            '获取数据
            objM生产自检T = New Z生产实际管理T
            objBll = New BLLM生产实际管理T

            objM生产自检T.产品图号 = txt主图号.Text.Trim()

            If String.IsNullOrEmpty(objM生产自检T.产品图号) Then
                objM生产自检T.产品图号 = " "
            End If
            If txt主图号.Text.Trim = String.Empty Then

                Me.cmb本道工序.DataSource = objBll.LoadGetCom(objM生产自检T)

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
#Region "SetData1"

    Private Sub SetData1()

        Dim objM生产自检T As New Z生产实际管理T
        Dim objBll As BLLM生产实际管理T

        Try
            '获取数据
            objM生产自检T = New Z生产实际管理T
            objBll = New BLLM生产实际管理T

            objM生产自检T.订单编号 = txt订单编号.Text.Trim()

            If String.IsNullOrEmpty(objM生产自检T.订单编号) Then
                objM生产自检T.订单编号 = " "
            End If
            If txt订单编号.Text.Trim <> String.Empty Then
                mdsInfoDataSet = objBll.Load订单(objM生产自检T)
                If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                    Me.txt订单编号.Text = mdsInfoDataSet.Rows(0)("订单编号").ToString()
                    Me.txt客户名称.Text = mdsInfoDataSet.Rows(0)("客户名称").ToString()
                    'Me.txt计划生产数量.Text = mdsInfoDataSet.Rows(0)("订单数量").ToString()

                Else
                    Me.txt订单编号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    'Me.txt计划生产数量.Text = String.Empty
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
#Region "SetData2"

    Private Sub SetData2()

        Dim objM生产自检T As New Z生产实际管理T
        Dim objBll As BLLM生产实际管理T

        Try
            '获取数据
            objM生产自检T = New Z生产实际管理T
            objBll = New BLLM生产实际管理T

            objM生产自检T.订单编号 = txt订单编号.Text.Trim()

            If String.IsNullOrEmpty(objM生产自检T.订单编号) Then
                objM生产自检T.订单编号 = " "
            End If
            If txt订单编号.Text.Trim <> String.Empty Then
                mdsInfoDataSet = objBll.Load订单(objM生产自检T)
                If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                    Me.txt订单编号.Text = mdsInfoDataSet.Rows(0)("订单编号").ToString()
                    Me.txt客户名称.Text = mdsInfoDataSet.Rows(0)("客户名称").ToString()
                    'Me.txt计划生产数量.Text = mdsInfoDataSet.Rows(0)("订单数量").ToString()

                Else
                    Me.txt订单编号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    'Me.txt计划生产数量.Text = String.Empty
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
#Region "SetFormData"
    Private Sub SetFormData()


        Dim objM生产自检T As New Z生产自检录入T
        Dim objBll As BLLM生产自检录入T

        Try
            '获取数据
            objM生产自检T = New Z生产自检录入T
            objBll = New BLLM生产自检录入T

            objM生产自检T.订单编号 = txt订单编号.Text.Trim()

            If String.IsNullOrEmpty(objM生产自检T.订单编号) Then
                objM生产自检T.订单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAll(objM生产自检T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                Me.txt订单编号.Text = mdsInfoDataSet.Rows(0)("订单编号").ToString()
                Me.txt人员编号.Text = mdsInfoDataSet.Rows(0)("作业者编号").ToString
                Me.txt人员名.Text = mdsInfoDataSet.Rows(0)("人员名").ToString
                Me.txt职务.Text = mdsInfoDataSet.Rows(0)("职务").ToString
                Me.txt部门名称.Text = mdsInfoDataSet.Rows(0)("部门名称").ToString
                Me.txt客户名称.Text = mdsInfoDataSet.Rows(0)("客户名称").ToString

                Me.txt产品图号.Text = mdsInfoDataSet.Rows(0)("分图号").ToString
                Me.txt主图号.Text = mdsInfoDataSet.Rows(0)("主图号").ToString
                Me.txt上级图号.Text = mdsInfoDataSet.Rows(0)("上级图号").ToString
                objM生产自检T.分图号 = Me.txt产品图号.Text
                dt流转票 = objBll.LoadGetCom(objM生产自检T)

                Me.cmb本道工序.DataSource = dt流转票
                Me.cmb本道工序.ValueMember = "工序编号"
                Me.cmb本道工序.DisplayMember = "工序名称"
                Me.cmb本道工序.Value = mdsInfoDataSet.Rows(0)("工序编号")
                'Me.cmb本道工序.Text = mdsInfoDataSet.Rows(0)("工序名称").ToString()
                'Me.txt上道工序.Text = mdsInfoDataSet.Rows(0)("上道工序").ToString()
                'Me.txt下道工序.Text = mdsInfoDataSet.Rows(0)("下道工序").ToString()
                'Me.txt作业时间.Text = mdsInfoDataSet.Rows(0)("作业时间").ToString()
                'Me.dmt作业时间end.Text = mdsInfoDataSet.Rows(0)("作业结束时间").ToString()
                'Me.cmb作业方式.Text = mdsInfoDataSet.Rows(0)("作业方式").ToString()
                Me.txt作业指示.Text = mdsInfoDataSet.Rows(0)("作业指示").ToString()
            Else
                Me.txt订单编号.Text = String.Empty
                Me.txt产品图号.Text = String.Empty
                Me.txt上级图号.Text = String.Empty
            End If

            mdsGridDataSet = objBll.LoadAllGrid(objM生产自检T)
            grid生产自检.DataSource = mdsGridDataSet

            'End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region
#Region "Timer1_Timer"
    Private Sub Timer1_Timer()
        Timer1.Interval = 7200000

        Dim objM生产自检T As New Z生产自检录入T
        Dim objBll As BLLM生产自检录入T

        Try
            '获取数据
            objM生产自检T = New Z生产自检录入T
            objBll = New BLLM生产自检录入T

            objM生产自检T.订单编号 = txt订单编号.Text.Trim()

            If String.IsNullOrEmpty(objM生产自检T.订单编号) Then
                objM生产自检T.订单编号 = " "
            End If
            'txt产品图号.Text = String.Empty

            mdsGridDataSet = objBll.LoadAllGrid(objM生产自检T)
            grid生产自检.DataSource = mdsGridDataSet

            'End If
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

            With grid生产自检.DisplayLayout.Bands(0)
                .Columns("自检时间").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
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