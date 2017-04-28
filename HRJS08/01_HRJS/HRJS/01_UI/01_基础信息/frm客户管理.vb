Imports HRJS.Constant
Imports UserControl
Imports Infragistics.Win.UltraWinGrid
Public Class frm客户管理

#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New

    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable

#End Region

#Region "Form Event"

    Private Sub frm客户管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frm客户一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm客户管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub gridList_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid客户管理.InitializeLayout
        grid客户管理.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid客户管理.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
    End Sub

#End Region

#Region "Button Event"

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

            SetFormModel()

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

    Private Sub btnF2编辑_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2编辑.Click

        Dim frmSearch As frm客户一览        Try
            frmSearch = New frm客户一览            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号").ToString
                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称").ToString
                    '设置画面数据
                    SetFormData()
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放                frmSearch.Dispose()
                frmSearch = Nothing


                '画面の修正処理                mIntFormMode = Constant.ENU_MODE.Model_Update
                SetFormModel()
                Me.txt客户名称.Select()
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

        Dim objM客户T As New M客户T

        Dim objBll As New BLLM客户T

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If Me.txt客户编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户编号", "客户编号")
                txt客户编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            objM客户T.客户编号 = txt客户编号.Text.Trim

            If objBll.Delete(objM客户T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
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

    Private Sub btnF5行追加_Click(sender As Object, e As EventArgs) Handles btnF5行追加.Click
        Dim dr As DataRow
        Dim intRow As Integer
        Dim objBll As New BLLM客户T

        If Me.grid客户管理.Rows.Count = 0 Then
            intRow = 0
        Else
            intRow = Me.grid客户管理.Rows.Count
        End If

        dr = mdsGridDataSet.NewRow()

        mdsGridDataSet.Rows.Add(dr)
        mdsGridDataSet.AcceptChanges()

        With Me.grid客户管理
            .ActiveRow = .Rows(intRow)
            .Rows(intRow).Cells(0).Activate()
            .UpdateData()
            .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        End With
    End Sub

    Private Sub btnF6行删除_Click(sender As Object, e As EventArgs) Handles btnF6行删除.Click

        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If Me.grid客户管理.ActiveRow Is Nothing Then
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


            intRow = Me.grid客户管理.ActiveRow.VisibleIndex

            intRowDelete = Me.grid客户管理.ActiveRow.Index

            Me.grid客户管理.Rows(intRowDelete).Delete(False)

            If Me.grid客户管理.Rows.VisibleRowCount = 0 Or Me.grid客户管理.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If Me.grid客户管理.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf Me.grid客户管理.Rows.VisibleRowCount = intRow Then
                    intRow = Me.grid客户管理.Rows.VisibleRowCount - 1
                End If

                Me.grid客户管理.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                Me.grid客户管理.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.grid客户管理.UpdateData()
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

            ''画面の初期化処理
            ClearForm()

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()

            SetFormData()
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
            SetFormData()
            '権限の処理()
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

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try

            '交货方式
            Utility.PFn_SetCombo(Me.cbo交货方式, "VM交货方式", 0)

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

                    txt客户编号.ReadOnly = False
                    txt客户名称.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt客户编号.Focus()
                Case Constant.ENU_MODE.Model_Update

                    txt客户编号.ReadOnly = True
                    'txt客户名称.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    txt客户名称.Focus()
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

            Me.txt客户编号.Text = String.Empty
            Me.txt客户名称.Text = String.Empty
            Me.txt传真号码.Text = String.Empty
            Me.txt公司地址.Text = String.Empty
            Me.txt电话号码.Text = String.Empty
            Me.txt邮政编码.Text = String.Empty
            Me.cbo交货方式.Rows(0).Selected = True
            Me.txt税率.Text = String.Empty

            'grid客户管理.DataSource = Nothing

            Me.txt客户编号.Select()

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
            Dim objM客户T As New M客户T
            Dim objBll As New BLLM客户T
            Dim arryList As New ArrayList

            If grid客户管理.Rows.Count = 0 Then
                objM客户T = New M客户T
                objM客户T.客户编号 = Me.txt客户编号.Text.Trim
                objM客户T.客户名称 = txt客户名称.Text.Trim
                objM客户T.公司地址 = txt公司地址.Text.Trim
                objM客户T.电话号码 = txt电话号码.Text.Trim
                objM客户T.传真号码 = txt传真号码.Text.Trim
                objM客户T.邮政编码 = txt邮政编码.Text.Trim
                objM客户T.交货方式 = cbo交货方式.Value
                objM客户T.税率 = txt税率.Text.Trim
                'objM客户T.登录者 = gObjM_人员T.人员编号
                'objM客户T.登录日期 = DateTime.Now
                'objM客户T.更新者 = gObjM_人员T.人员编号
                'objM客户T.更新日期 = DateTime.Now
                arryList.Add(objM客户T)
            Else

                For i = 0 To grid客户管理.Rows.Count - 1
                    objM客户T = New M客户T
                    objM客户T.客户编号 = txt客户编号.Text.Trim
                    objM客户T.客户名称 = txt客户名称.Text.Trim
                    objM客户T.公司地址 = txt公司地址.Text.Trim
                    objM客户T.电话号码 = txt电话号码.Text.Trim
                    objM客户T.传真号码 = txt传真号码.Text.Trim
                    objM客户T.邮政编码 = txt邮政编码.Text.Trim
                    objM客户T.交货方式 = cbo交货方式.Value
                    objM客户T.税率 = txt税率.Text.Trim

                    objM客户T.负责人姓名 = grid客户管理.Rows(i).Cells("负责人姓名").Value.ToString()
                    objM客户T.负责人部门 = grid客户管理.Rows(i).Cells("负责人部门").Value.ToString()
                    objM客户T.负责人电话 = grid客户管理.Rows(i).Cells("负责人电话").Value.ToString()
                    objM客户T.负责人邮箱 = grid客户管理.Rows(i).Cells("负责人邮箱").Value.ToString()
                    objM客户T.负责人职务 = grid客户管理.Rows(i).Cells("负责人职务").Value.ToString()
                    objM客户T.客户编号CD = grid客户管理.Rows(i).Cells("客户编号CD").Value.ToString()

                    'objM客户T.登录者 = gObjM_人员T.人员编号
                    'objM客户T.登录日期 = DateTime.Now
                    'objM客户T.更新者 = gObjM_人员T.人员编号
                    'objM客户T.更新日期 = DateTime.Now
                    arryList.Add(objM客户T)

                Next

            End If


            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objM客户T).客户编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "客户编号")
                        Me.txt客户编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt客户编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt客户编号.Focus()
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

            '客户ID
            If Me.txt客户编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户编号", "客户编号")
                txt客户编号.Focus()
                Return False
            End If

            '客户名

            If Me.txt客户名称.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户名称", "客户名称")
                txt客户名称.Focus()
                Return False
            End If
            If Me.cbo交货方式.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "交货方式", "交货方式")
                cbo交货方式.Focus()
            End If
            If Me.txt税率.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "税率", "税率")
                txt税率.Focus()
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
            Me.btnF5行追加.Enabled = Utility.PFn_GetAuth(Me.btnF5行追加.Tag)
            Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)
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
        Dim objM客户T As New M客户T
        Dim objBll As BLLM客户T

        Try
            '获取数据
            objM客户T = New M客户T
            objBll = New BLLM客户T

            objM客户T.客户编号 = txt客户编号.Text.Trim()
            objM客户T.客户名称 = txt客户名称.Text.Trim()
            If String.IsNullOrEmpty(objM客户T.客户编号) Then
                objM客户T.客户编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadInfoAll(objM客户T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                Me.txt客户编号.Text = mdsInfoDataSet.Rows(0)("客户编号").ToString()
                Me.txt客户名称.Text = mdsInfoDataSet.Rows(0)("客户名称").ToString()
                Me.txt公司地址.Text = mdsInfoDataSet.Rows(0)("公司地址").ToString()
                Me.txt电话号码.Text = mdsInfoDataSet.Rows(0)("电话号码").ToString()
                Me.txt邮政编码.Text = mdsInfoDataSet.Rows(0)("邮政编码").ToString()
                Me.txt传真号码.Text = mdsInfoDataSet.Rows(0)("传真号码").ToString()
                Me.cbo交货方式.Value = mdsInfoDataSet.Rows(0)("交货方式").ToString()
                Me.txt税率.Text = mdsInfoDataSet.Rows(0)("税率").ToString()
            Else
                Me.txt客户编号.Text = String.Empty
                Me.txt客户名称.Text = String.Empty
                Me.txt传真号码.Text = String.Empty
                Me.txt公司地址.Text = String.Empty
                Me.txt电话号码.Text = String.Empty
                Me.txt邮政编码.Text = String.Empty
                Me.cbo交货方式.Rows(0).Selected = True
                Me.txt税率.Text = String.Empty
            End If

            mdsGridDataSet = objBll.LoadGridAll(objM客户T)
            'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
            grid客户管理.DataSource = mdsGridDataSet
            grid客户管理.DisplayLayout.Bands(0).Columns("客户编号CD").Hidden = True

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

#End Region

    Private Sub txt税率_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt税率.KeyPress
        '只能输入数字
        If Utility.IsDigit(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    
End Class