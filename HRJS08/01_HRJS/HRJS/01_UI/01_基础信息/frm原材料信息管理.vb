Imports HRJS.Constant
Public Class frm原材料信息管理

#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New

#End Region

#Region "Form Event"
    
    Private Sub frm原材料信息管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub frm原材料信息管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm原材料信息管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                    'Case Keys.F2
                    '    btnF2编辑.Focus()
                    '    btnF2编辑_Click(Nothing, Nothing)

                Case Keys.F3
                    btnF3保存.Focus()
                    btnF3保存_Click(Nothing, Nothing)

                    'Case Keys.F4
                    '    btnF4删除.Focus()
                    '    btnF4删除_Click(Nothing, Nothing)

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

        Dim frmSearch As frm原材料信息一览


        Try

            frmSearch = New frm原材料信息一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '货位信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt原材料编号.Text = frmSearch.ReturnTable.Rows(0)("原材料编号").ToString          '货位编号
                    Me.txt原材料名称.Text = frmSearch.ReturnTable.Rows(0)("原材料名称").ToString          '货位名称
                    Me.cob原材料区分.Value = frmSearch.ReturnTable.Rows(0)("原材料区分").ToString          '使用状态
                    Me.cob材料种类.Value = frmSearch.ReturnTable.Rows(0)("材料种类").ToString          '使用状态
                    Me.cob材质.Value = frmSearch.ReturnTable.Rows(0)("材质").ToString          '使用状态                    Me.txt材料代号.Text = frmSearch.ReturnTable.Rows(0)("材料代号").ToString
                    Me.txt密度.Text = frmSearch.ReturnTable.Rows(0)("密度").ToString          '货位名称

                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放
                frmSearch.Dispose()
                frmSearch = Nothing
                SetInputDigit()

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
                Me.txt原材料编号.Select()
            Else
                Me.txt原材料名称.Select()
            End If

            '画面の修正処理
            mIntFormMode = Constant.ENU_MODE.Model_Update
            SetFormModel()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objM原材料信息T As New M原材料信息T

        Dim objBll As New BLLM原材料信息T

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If
            '保存確認メッセージを表示する
            If Me.txt原材料编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "原材料编号", "原材料编号")
                txt原材料编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objM原材料信息T.原材料编号 = txt原材料编号.Text.Trim

            If objBll.Delete(objM原材料信息T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
            ClearForm()
            Me.txt原材料编号.Focus()

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

#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try
            '画面のComboの初期値を設定する()
            Me.SetCombo()

            '画面の内容を清空処理
            Me.ClearForm()

            Me.SetInputDigit()

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

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try

            '使用状态
            Utility.PFn_SetCombo(Me.cob原材料区分, "VM材料区分", 1)
            Utility.PFn_SetCombo(Me.cob材料种类, "VM材料种类", 0)
            Utility.PFn_SetCombo(Me.cob材质, "VM材质", 1)

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

            Me.txt原材料编号.Text = String.Empty
            Me.txt原材料名称.Text = String.Empty
            Me.cob原材料区分.Rows(0).Selected = True
            Me.cob材料种类.Rows(0).Selected = True
            Me.cob材质.Rows(0).Selected = True
            Me.txt密度.Text = String.Empty
            txt材料代号.Text = String.Empty
            Me.txt原材料编号.Select()

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

#Region "SetFormModel"

    Private Sub SetFormModel()

        Try

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    txt原材料编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt原材料编号.Select()
                Case Constant.ENU_MODE.Model_Update

                    txt原材料编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    txt原材料名称.Select()
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

#Region "InputCheck"
    ''' <summary>
    ''' 画面のCheck処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Function InputCheck() As Boolean
        Dim objM原材料信息T As M原材料信息T
        Dim objBllM原材料信息T As BLLM原材料信息T
        Try

            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If

            '必須チェック(MsgID=21) 

            '设备ID
            If Me.txt原材料编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "原材料编号", "原材料编号")
                txt原材料编号.Focus()
                Return False
            End If

            '设备ID
            'If Me.txt原材料名称.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "原材料名称", "原材料名称")
            '    txt原材料名称.Focus()
            '    Return False
            'End If
          
            '设备名
            'If Me.txt密度.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "密度", "密度")
            '    txt密度.Focus()
            '    Return False
            'End If

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

            Dim objM原材料信息T As New M原材料信息T
            Dim objBllM原材料信息T As New BLLM原材料信息T

            objM原材料信息T.原材料编号 = txt原材料编号.Text.Trim
            objM原材料信息T.原材料名称 = txt原材料名称.Text.Trim
            objM原材料信息T.材料代号 = txt材料代号.Text.Trim
            objM原材料信息T.密度 = txt密度.Text.Trim
            If Not String.IsNullOrEmpty(cob原材料区分.Text) Then
                objM原材料信息T.原材料区分 = cob原材料区分.Value.Trim
            End If
            If Not String.IsNullOrEmpty(cob材料种类.Text) Then
                objM原材料信息T.材料种类 = cob材料种类.Value.Trim
            End If
            If Not String.IsNullOrEmpty(cob材质.Text) Then
                objM原材料信息T.材质 = cob材质.Value.Trim
            End If

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBllM原材料信息T.LoadByPKey(objM原材料信息T).原材料编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "原材料编号")
                        txt原材料编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBllM原材料信息T.Insert(objM原材料信息T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt原材料编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBllM原材料信息T.Update(objM原材料信息T) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt原材料编号.Focus()
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

#Region "SetInputDigit"
    Private Sub SetInputDigit()
        txt密度.IsDigit = True
    End Sub
#End Region

#End Region

    Private Sub cob材料种类_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cob材料种类.Leave
        Try
            If cob材料种类.Text = "标准件" Then
                MsgBox("标准件请参照图纸")
                Me.cob材料种类.Text = String.Empty
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class