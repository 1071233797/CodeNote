Imports HRJS.Constant
Imports System.IO
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class frm人员管理

#Region "常数定義"

    Private Enum ENU_详细 As Integer

        階層 = 0
        表示 = 1
        区分 = 2
        区分1 = 3
        区分2 = 4

    End Enum

#End Region

#Region "変数定義"

    Private mds详细 As DataSet = Nothing                'grdList
    Private mdt详细Band0 As DataTable = Nothing                'grdList
    Private mdt详细Band2 As DataTable = Nothing                'grdList
    Private mdt详细Band1 As DataTable = Nothing                'grdList
    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    'Private mstr密码 As String = String.Empty         '密码
    Private mstr人员 As String = String.Empty             '人员

    Public Property 人员() As String
        Get
            Return mstr人员
        End Get
        Set(ByVal Value As String)
            mstr人员 = Value
        End Set
    End Property
#End Region

#Region "Form Event"

    Private Sub frm人员管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.InitForm()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frm人员管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm人员管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                Case Keys.F12
                    btnF12关闭.Focus()
                    btnF12关闭_Click(Nothing, Nothing)
                    e.Handled = True

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

#Region "Button Event"

    Private Sub btn全选_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn全选.Click

        Try
            Me.Cursor = Cursors.WaitCursor

            For i = 0 To grdList.Rows.Count - 1
                grdList.Rows(i).Cells(ENU_详细.表示).Value = "TRUE"

                For j = 0 To grdList.Rows(i).ChildBands(0).Rows.Count - 1
                    grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_详细.表示).Value = "TRUE"

                    For k = 0 To grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows.Count - 1
                        grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows(k).Cells(ENU_详细.表示).Value = "TRUE"
                    Next
                Next

            Next

            grdList.UpdateData()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btn全部解除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn全部解除.Click

        Try
            Me.Cursor = Cursors.WaitCursor

            For i = 0 To grdList.Rows.Count - 1
                grdList.Rows(i).Cells(ENU_详细.表示).Value = "FALSE"

                For j = 0 To grdList.Rows(i).ChildBands(0).Rows.Count - 1
                    grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_详细.表示).Value = "FALSE"

                    For k = 0 To grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows.Count - 1
                        grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows(k).Cells(ENU_详细.表示).Value = "FALSE"
                    Next
                Next

            Next

            grdList.UpdateData()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

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

        Dim frmSearch As frm人员一览

        Try

            frmSearch = New frm人员一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '全部解除画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt人员编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号").ToString          '人员CD
                    Me.txt人员名.Text = frmSearch.ReturnTable.Rows(0)("人员名").ToString          '人员名

                    Me.txt密码.Text = frmSearch.ReturnTable.Rows(0)("密码").ToString          '密码
                    Me.txt电话号码.Text = frmSearch.ReturnTable.Rows(0)("电话号码").ToString          '电话号码
                    Me.udt入职时间.Text = frmSearch.ReturnTable.Rows(0)("入职时间").ToString          '入职时间
                    Me.txt部门编号.Value = frmSearch.ReturnTable.Rows(0)("部门编号").ToString      '部门
                    Me.txt部门名称.Text = frmSearch.ReturnTable.Rows(0)("部门名称").ToString       '部门名称
                    Me.cob在职状态.Value = frmSearch.ReturnTable.Rows(0)("在职状态").ToString      '在职状态
                    Me.txt邮箱.Text = frmSearch.ReturnTable.Rows(0)("邮箱").ToString          '人员CD
                    Me.txt职务.Text = frmSearch.ReturnTable.Rows(0)("职务").ToString          '人员名                    Me.cob性别.Value = frmSearch.ReturnTable.Rows(0)("性别").ToString      '在职状态                    Me.txt工种.Text = frmSearch.ReturnTable.Rows(0)("工种").ToString          '密码
                    Me.txt办公电话.Text = frmSearch.ReturnTable.Rows(0)("办公电话").ToString
                    Setgrd()

                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放                frmSearch.Dispose()
                frmSearch = Nothing

                '画面の修正処理
                mIntFormMode = Constant.ENU_MODE.Model_Update

                SetFormModel()
                txt人员名.Focus()
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

        Dim objM人员T As New M人员T
        Dim objBll As New BLLM人员T

        Try

            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If
            '保存確認メッセージを表示する
            If Me.txt人员编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "人员编号", "人员编号")
                txt人员编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objM人员T.人员编号 = txt人员编号.Text.Trim

            'If objBll.Delete(objM人员T) > 0 Then

            If objBll.DeleteBatch(objM人员T.人员编号) > 0 Then

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

#End Region

#Region "Control Event"

#Region "部门编号"

    Private Sub txt部门编号_Enter(sender As Object, e As EventArgs) Handles txt部门编号.Enter

        Try

            Me.txt部门编号.Tag = Me.txt部门编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt部门编号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt部门编号.EditorButtonClick


        Dim frmSearch As frm部门一览

        Try

            frmSearch = New frm部门一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt部门编号.Text = frmSearch.ReturnTable.Rows(0)("部门编号")     '部门编号

                    Me.txt部门名称.Text = frmSearch.ReturnTable.Rows(0)("部门名称")     '客户名称


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

    Private Sub txt部门编号_Leave(sender As Object, e As EventArgs) Handles txt部门编号.Leave
        Dim objM部门T As M部门T
        Dim dtM部门T As DataTable
        Dim objBLLM人员T As BLLM人员T

        Try

            If txt部门编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt部门编号.Text.Trim <> String.Empty Then

                If Me.txt部门编号.Tag = Me.txt部门编号.Text.Trim Then
                    Exit Sub
                End If

                objM部门T = New M部门T

                objM部门T.部门编号 = txt部门编号.Text.Trim

                objBLLM人员T = New BLLM人员T

                dtM部门T = objBLLM人员T.LoadByBM(objM部门T)

                If dtM部门T.Rows.Count <> 0 Then

                    Me.txt部门名称.Text = dtM部门T.Rows(0).Item("部门名称").ToString
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "部门名称")
                    'Me.txt部门编号.Text = String.Empty
                    Me.txt部门名称.Text = String.Empty
                    Me.txt部门编号.Select()
                End If
            Else
                Me.txt部门编号.Text = String.Empty
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

    Private Sub grdList_CellChange(ByVal sender As Object, ByVal e As CellEventArgs) Handles grdList.CellChange

        Try

            If grdList.ActiveCell Is Nothing Then
                Exit Sub
            End If


            '砂時計のカーソルが設定

            Me.Cursor = Cursors.WaitCursor


            Select Case grdList.ActiveCell.Column.Index

                Case ENU_详细.表示

                    Select Case grdList.ActiveCell.Band.Index

                        Case 0

                            For j = 0 To grdList.ActiveRow.ChildBands(0).Rows.Count - 1
                                grdList.ActiveRow.ChildBands(0).Rows(j).Cells(ENU_详细.表示).Value = grdList.ActiveCell.Text

                                For k = 0 To grdList.ActiveRow.ChildBands(0).Rows(j).ChildBands(0).Rows.Count - 1
                                    grdList.ActiveRow.ChildBands(0).Rows(j).ChildBands(0).Rows(k).Cells(ENU_详细.表示).Value = grdList.ActiveCell.Text
                                Next
                            Next

                        Case 1

                            For j = 0 To grdList.ActiveRow.ChildBands(0).Rows.Count - 1
                                grdList.ActiveRow.ChildBands(0).Rows(j).Cells(ENU_详细.表示).Value = grdList.ActiveCell.Text
                            Next

                    End Select

            End Select

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub grdList_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles grdList.Enter
        Try

            If grdList.ActiveCell Is Nothing Then
                grdList.Rows(0).Cells(ENU_详细.表示).Activate()
                grdList.PSb_SetCellFocus(grdList.ActiveRow.Index, grdList.ActiveCell.Column.Index)
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As InitializeLayoutEventArgs) Handles grdList.InitializeLayout
        Try

            grdList.DisplayLayout.TabNavigation = TabNavigation.NextControlOnLastCell
            grdList.DisplayLayout.Override.CellClickAction = CellClickAction.EditAndSelectText
            grdList.DisplayLayout.Appearance.BorderColor = Color.Black
            grdList.DisplayLayout.Appearance.BackColor = Color.Transparent
            grdList.DisplayLayout.ViewStyleBand = ViewStyleBand.OutlookGroupBy
            grdList.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
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

            '画面の内容を清空処理
            Me.ClearForm()

            '権限の処理
            Me.SetPermission()

            txt人员编号.Select()

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

                    txt人员编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    Me.txt人员编号.Select()

                Case Constant.ENU_MODE.Model_Update

                    txt人员编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    Me.txt人员名.Select()
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
            Me.txt部门编号.Text = String.Empty
            Me.txt人员名.Text = String.Empty
            Me.txt密码.Text = String.Empty
            Me.txt部门编号.Text = String.Empty
            Me.txt部门名称.Text = String.Empty
            Me.cob在职状态.Rows(0).Selected = True
            Me.txt电话号码.Text = String.Empty
            Me.udt入职时间.Text = DateTime.Now

            Me.txt职务.Text = String.Empty
            Me.txt工种.Text = String.Empty
            Me.txt邮箱.Text = String.Empty
            Me.cob性别.Rows(0).Selected = True
            Me.txt办公电话.Text = String.Empty

            Me.txt人员编号.Focus()

            Setgrd()

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

            '部门コンボボックス

            'Utility.SetCombo(Me.cob在职状态, "VM部门")

            '在职状态コンボボックス
            Utility.PFn_SetCombo(Me.cob在职状态, "VM在职状态", 0)
            Utility.PFn_SetCombo(Me.cob性别, "VM性别", 1)

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

            Dim objM人员T As New M人员T
            Dim objBll As New BLLM人员T

            Dim objM人员权限T As New M人员权限T
            Dim arr人员权限 As New ArrayList

            objM人员T.人员编号 = txt人员编号.Text.Trim
            objM人员T.人员名 = txt人员名.Text.Trim
            objM人员T.密码 = txt密码.Text.Trim
            objM人员T.电话号码 = txt电话号码.Text.Trim
            objM人员T.入职时间 = udt入职时间.DateTime
            objM人员T.部门 = txt部门编号.Text.Trim
            objM人员T.在职状态 = cob在职状态.Value.ToString

            objM人员T.性别 = cob性别.Value
            objM人员T.职务 = txt职务.Text.Trim
            objM人员T.邮箱 = txt邮箱.Text.Trim
            objM人员T.办公电话 = txt办公电话.Text.Trim
            objM人员T.工种 = txt工种.Text.Trim

            objM人员T.登录者 = gObjM_人员T.人员编号
            objM人员T.登录日期 = DateTime.Now
            objM人员T.更新者 = gObjM_人员T.人员编号
            objM人员T.更新日期 = DateTime.Now

            For i = 0 To grdList.Rows.Count - 1

                If Utility.PFn_ToBoolean(grdList.Rows(i).Cells(ENU_详细.表示).Text) Then

                    objM人员权限T = New M人员权限T
                    objM人员权限T.人员编号 = txt人员编号.Text.Trim
                    objM人员权限T.菜单区分 = grdList.Rows(i).Cells(ENU_详细.区分).Value.ToString.Trim

                    arr人员权限.Add(objM人员权限T)

                End If

                For j = 0 To grdList.Rows(i).ChildBands(0).Rows.Count - 1

                    If Utility.PFn_ToBoolean(grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_详细.表示).Text) Then

                        objM人员权限T = New M人员权限T
                        objM人员权限T.人员编号 = txt人员编号.Text.Trim
                        objM人员权限T.菜单区分 = grdList.Rows(i).ChildBands(0).Rows(j).Cells(ENU_详细.区分).Value.ToString.Trim

                        arr人员权限.Add(objM人员权限T)

                    End If

                    For k = 0 To grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows.Count - 1

                        If Utility.PFn_ToBoolean(grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows(k).Cells(ENU_详细.表示).Text) Then

                            objM人员权限T = New M人员权限T
                            objM人员权限T.人员编号 = txt人员编号.Text.Trim
                            objM人员权限T.菜单区分 = grdList.Rows(i).ChildBands(0).Rows(j).ChildBands(0).Rows(k).Cells(ENU_详细.区分).Value.ToString.Trim

                            arr人员权限.Add(objM人员权限T)

                        End If
                    Next

                Next

            Next

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objM人员T).人员编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "人员编号")
                        txt人员编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(objM人员T, arr人员权限) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt人员编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update(objM人员T, arr人员权限) > 0 Then

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
            '人员CD
            If Me.txt人员编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "人员编号", "人员编号")
                txt人员编号.Focus()
                Return False
            End If

            '人员名
            If Me.txt人员名.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "人员名", "人员名")
                txt人员名.Focus()
                Return False
            End If

            '密码
            If Me.txt密码.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "密码", "密码")
                txt密码.Focus()
                Return False
            End If


            ''电话号码
            'If Me.txt电话号码.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID51, "电话号码", "电话号码")
            '    txt电话号码.Focus()
            '    Return False
            'End If

            ''入职时间
            'If Me.udt入职时间.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID51, "入职时间", "入职时间")
            '    udt入职时间.Focus()
            '    Return False
            'End If
            '性别
            If Me.cob性别.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "性别", "性别")
                cob性别.Focus()
                Return False
            End If

            '部门
            If Me.txt部门编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "部门", "部门")
                txt部门编号.Focus()
                Return False
            End If
            '在职状态

            If Me.cob在职状态.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "在职状态", "在职状态")
                cob在职状态.Focus()
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

#Region "Setgrd"
    Private Sub Setgrd()

        Try

            Dim objM人员T As New M人员T
            Dim objBll As New BLLM人员T

            objM人员T.人员编号 = txt人员编号.Text.Trim

            Me.grdList.DataSource = Nothing

            mds详细 = New DataSet

            'mdt详细Band0データを記録テーブル初期化

            Me.mdt详细Band0 = New DataTable
            mdt详细Band0 = objBll.Select详细Band0(objM人员T)

            'mdt详细Band1データを記録テーブル初期化

            Me.mdt详细Band1 = New DataTable
            Me.mdt详细Band1 = New DataTable
            mdt详细Band1 = objBll.Select详细Band1(objM人员T)

            'mdt详细Band2データを記録テーブル初期化

            Me.mdt详细Band2 = New DataTable
            Me.mdt详细Band2 = New DataTable
            mdt详细Band2 = objBll.Select详细Band2(objM人员T)

            ''------------------------------------------

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(2) As DataRelation

            mds详细 = New DataSet
            'DataSetの親子関係を設定
            mds详细.Relations.Clear()

            '親、子のテーブルを追加
            mdt详细Band0.TableName = "详细Band0"
            mds详细.Tables.Add(mdt详细Band0)

            mdt详细Band1.TableName = "详细Band1"
            mds详细.Tables.Add(mdt详细Band1)

            mdt详细Band2.TableName = "详细Band2"
            mds详细.Tables.Add(mdt详细Band2)

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mds详细.Tables(0).Columns("区分1")
            childCols(0) = mds详细.Tables(1).Columns("区分1")
            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mds详细.Relations.Add(drBand(0))

            ReDim parentCols(1)
            ReDim childCols(1)
            parentCols(0) = mds详细.Tables(1).Columns("区分1")
            childCols(0) = mds详细.Tables(2).Columns("区分1")

            parentCols(1) = mds详细.Tables(1).Columns("区分2")
            childCols(1) = mds详细.Tables(2).Columns("区分2")

            drBand(1) = New DataRelation("表示", parentCols, childCols, False)
            mds详细.Relations.Add(drBand(1))

            Me.grdList.DataSource = mds详细
            grdList.Refresh()

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

            Me.btn全选.Enabled = Utility.PFn_GetAuth(Me.btn全选.Tag)
            Me.btn全部解除.Enabled = Utility.PFn_GetAuth(Me.btn全部解除.Tag)

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

            With grdList.DisplayLayout.Bands(0)

                .Columns(ENU_详细.階層).Width = 103
                .Columns(ENU_详细.階層).CellActivation = Activation.NoEdit
                .Columns(ENU_详细.階層).CellAppearance.BackColor = Color.Silver
                .Columns(ENU_详细.階層).TabStop = False
                .Columns(ENU_详细.表示).Width = 38
                .Columns(ENU_详细.表示).Style = ColumnStyle.CheckBox
                .Columns(ENU_详细.区分).Hidden = True
                .Columns(ENU_详细.区分1).Hidden = True
            End With

            With grdList.DisplayLayout.Bands(1)

                .Columns(ENU_详细.階層).Width = 103
                .Columns(ENU_详细.階層).CellActivation = Activation.NoEdit
                .Columns(ENU_详细.階層).CellAppearance.BackColor = Color.Silver
                .Columns(ENU_详细.階層).TabStop = False
                .Columns(ENU_详细.表示).Width = 38
                .Columns(ENU_详细.表示).Style = ColumnStyle.CheckBox
                .Columns(ENU_详细.区分).Hidden = True
                .Columns(ENU_详细.区分1).Hidden = True
                .Columns(ENU_详细.区分2).Hidden = True

            End With

            With grdList.DisplayLayout.Bands(2)

                .Columns(ENU_详细.階層).Width = 94
                .Columns(ENU_详细.階層).CellActivation = Activation.NoEdit
                .Columns(ENU_详细.階層).CellAppearance.BackColor = Color.Silver
                .Columns(ENU_详细.階層).TabStop = False
                .Columns(ENU_详细.表示).Width = 38
                .Columns(ENU_详细.表示).Style = ColumnStyle.CheckBox
                .Columns(ENU_详细.区分).Hidden = True
                .Columns(ENU_详细.区分1).Hidden = True
                .Columns(ENU_详细.区分2).Hidden = True

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

#Region "FN_Check_LawlessChar"
    'Public Function Check_LawlessChar(ByVal Str As String) As Boolean
    '    Check_LawlessChar = False   '有则返回TRUE，否则FALSE

    '    Dim LawlessletterChar As Boolean = False
    '    Dim LawlessintChar As Boolean = False

    '    Dim S_Char As String
    '    Dim i As Integer
    '    For i = 1 To Len(Str)
    '        S_Char = Mid(Str, i, 1)
    '        If 48 <= Asc(S_Char) And Asc(S_Char) <= 57 Then
    '            LawlessintChar = True
    '        Else
    '            LawlessletterChar = True
    '        End If
    '    Next

    '    If LawlessintChar And LawlessletterChar Then
    '        Check_LawlessChar = True
    '    End If

    'End Function
#End Region

#End Region


    Private Sub UcLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcLabel2.Click

    End Sub
End Class
