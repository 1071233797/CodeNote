Imports HRJS.Constant
Public Class frm终端设备管理

#Region "変数定義"

#End Region

#Region "Form Event"

    Private Sub frmPDA详细_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub frmPDA详细_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frmPDA详细_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

            FormOpenMode = Constant.ENU_MODE.Model_New

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

        Dim frmSearch As frm终端设备一览

        Try

            frmSearch = New frm终端设备一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            'PDA信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txtPDA编号.Text = frmSearch.ReturnTable.Rows(0)("PDA编号").ToString      'PDA编号
                    Me.txtPDAIP.Text = frmSearch.ReturnTable.Rows(0)("PDAIP").ToString          'PDAIP
                    Me.txtPDA负责人编号.Text = frmSearch.ReturnTable.Rows(0)("PDA负责人编号").ToString          'PDA负责人                    Me.txtPDA负责人姓名.Text = frmSearch.ReturnTable.Rows(0)("PDA负责人姓名").ToString          'PDA负责人                    Me.txt联系电话.Text = frmSearch.ReturnTable.Rows(0)("联系电话").ToString          '联系电话
                    Me.txt邮箱.Text = frmSearch.ReturnTable.Rows(0)("邮箱").ToString          '邮箱

                    Me.txt备注.Text = frmSearch.ReturnTable.Rows(0)("备注").ToString          '备注
                    '一览编辑用
                    'EditDataTable = frmSearch.ReturnTable
                    'SetFormData()
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
                FormOpenMode = Constant.ENU_MODE.Model_Update

                SetFormModel()

                'cobPDA类别.Select()
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

        Dim objMPDAT As New MPDAT

        Dim objBll As New BLLMPDAT

        Try
            If FormOpenMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            'If String.IsNullOrEmpty(txtPDA编号.Text.Trim) Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
            '    '処理終了
            '    Exit Sub
            'End If
            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objMPDAT.PDA编号 = txtPDA编号.Text.Trim

            If objBll.Delete(objMPDAT) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            FormOpenMode = Constant.ENU_MODE.Model_New

            ClearForm()

            SetFormModel()

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

            If FormOpenMode = Constant.ENU_MODE.Model_New Then
                Me.txtPDA编号.Select()
            Else
                Me.txtPDAIP.Select()
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
            '画面のComboの初期値を設定する
            'Me.SetCombo()

            '画面の内容を清空処理
            Me.ClearForm()
            '一览编辑用
            'Me.SetFormData()
            '権限の処理
            Me.SetPermission()

            Me.SetFormModel()

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
    ''一览编辑用
    Private Sub SetFormData()

        '根据检索画面数据进行设置
        'Me.txtPDA编号.Text = EditDataTable.Rows(0)("PDA编号").ToString      'PDA编号
        'Me.txtPDAIP.Text = EditDataTable.Rows(0)("PDAIP").ToString          'PDAIP
        'Me.txtPDA负责人编号.Text = EditDataTable.Rows(0)("PDA负责人编号").ToString          'PDA负责人        'Me.txtPDA负责人姓名.Text = EditDataTable.Rows(0)("PDA负责人姓名").ToString          'PDA负责人        'Me.txt联系电话.Text = EditDataTable.Rows(0)("联系电话").ToString          '联系电话
        'Me.txt邮箱.Text = EditDataTable.Rows(0)("邮箱").ToString          '邮箱

        'Me.txt备注.Text = EditDataTable.Rows(0)("备注").ToString          '备注
    End Sub

#End Region

#Region "SetCombo"

    'Private Sub SetCombo()

    '    Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

    '    Try

    '        '制限件数コンボボックス
    '        Utility.SetComboPDA(Me.cobPDA类别, "MPDA类别")

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

#End Region

#Region "SetFormModel"

    Private Sub SetFormModel()

        Try

            Select Case FormOpenMode

                Case Constant.ENU_MODE.Model_New

                    txtPDA编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txtPDA编号.Focus()
                Case Constant.ENU_MODE.Model_Update

                    txtPDA编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    txtPDAIP.Focus()
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

            Me.txtPDA编号.Text = String.Empty
            Me.txtPDAIP.Text = String.Empty
            Me.txtPDA负责人编号.Text = String.Empty
            Me.txtPDA负责人姓名.Text = String.Empty
            Me.txt联系电话.Text = String.Empty
            Me.txt邮箱.Text = String.Empty
            Me.txt备注.Text = String.Empty

            Me.txtPDA编号.Select()

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

            Dim objMPDAT As New MPDAT
            Dim objBll As New BLLMPDAT

            objMPDAT.PDA编号 = txtPDA编号.Text.Trim
            objMPDAT.PDAIP = txtPDAIP.Text.Trim
            objMPDAT.PDA负责人编号 = txtPDA负责人编号.Text.Trim
            'objMPDAT.PDA负责人姓名 = txtPDA负责人姓名.Text.Trim
            'objMPDAT.联系电话 = txt联系电话.Text.Trim
            'objMPDAT.邮箱 = txt邮箱.Text.Trim

            objMPDAT.备注 = txt备注.Text.Trim

            objMPDAT.登录者 = gObjM_人员T.人员编号
            objMPDAT.登录日期 = DateTime.Now
            objMPDAT.更新者 = gObjM_人员T.人员编号
            objMPDAT.更新日期 = DateTime.Now

            Select Case FormOpenMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objMPDAT).PDA编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "PDA编号")
                        txtPDA编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(objMPDAT) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                        Me.txtPDA编号.Select()
                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txtPDA编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update(objMPDAT) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txtPDA编号.Focus()
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
        Dim objM人员T As M人员T
        Dim objBllM人员T As BLLM人员T
        Try

            If FormOpenMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If

            '必須チェック(MsgID=21) 

            'PDAID
            If Me.txtPDA编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "PDA编号", "PDA编号")
                txtPDA编号.Focus()
                Return False
            End If

            'PDA名
            If Me.txtPDAIP.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "PDAIP", "PDAIP")
                txtPDAIP.Focus()
                Return False
            End If

            If Me.txtPDA负责人编号.Text.Trim <> String.Empty Then
                objM人员T = New M人员T

                objM人员T.人员编号 = txtPDA负责人编号.Text.Trim

                objBllM人员T = New BLLM人员T

                objM人员T = objBllM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员编号 = String.Empty Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "负责人")
                    txtPDA负责人编号.Focus()
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

#Region "SetPermission"

    Private Sub SetPermission()
        Try

            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)

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

#Region "Control Event"

#Region "负责人"

    Private Sub txtPDA负责人编号_Enter(sender As Object, e As EventArgs) Handles txtPDA负责人编号.Enter

        Try

            Me.txtPDA负责人编号.Tag = Me.txtPDA负责人编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txtPDA负责人编号_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtPDA负责人编号.EditorButtonClick


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

                    Me.txtPDA负责人编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '客户编号

                    Me.txtPDA负责人姓名.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '客户名称

                    Me.txt联系电话.Text = frmSearch.ReturnTable.Rows(0)("电话号码")     '客户名称
                    Me.txt邮箱.Text = frmSearch.ReturnTable.Rows(0)("邮箱")     '客户名称
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

    Private Sub txtPDA负责人编号_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPDA负责人编号.Validating

        Dim objM人员T As M人员T
        Dim objBllM人员T As BLLM人员T

        Try

            If txtPDA负责人编号.ReadOnly Then
                Exit Sub
            End If


            If Me.txtPDA负责人编号.Text.Trim <> String.Empty Then

                If Me.txtPDA负责人编号.Tag = Me.txtPDA负责人编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txtPDA负责人编号.Text.Trim

                objBllM人员T = New BLLM人员T

                objM人员T = objBllM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员编号 <> "" Then

                    Me.txtPDA负责人姓名.Text = objM人员T.人员名                    Me.txt联系电话.Text = objM人员T.电话号码
                    Me.txt邮箱.Text = objM人员T.邮箱

                Else
                    txtPDA负责人编号.Text = String.Empty
                    Me.txtPDA负责人姓名.Text = String.Empty

                End If
            Else
                Me.txtPDA负责人姓名.Text = String.Empty
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
End Class