Imports HRJS.Constant
Public Class frm原材料标签打印

#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New

#End Region

#Region "Form Event"
    Dim _str原材料材料编号 As Object
    Dim str数量 As Object
    Dim str重量 As Object
    Dim str批次 As Object
    Dim str库存区域 As Object
    Dim str原材料材料编号 As Object

    Private Sub frm原材料标签打印_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub frm原材料标签打印_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm原材料标签打印_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                Case Keys.F2
                    btnF2查询.Focus()
                    btnF2查询_Click(Nothing, Nothing)

                    'Case Keys.F3
                    '    btnF3选择.Focus()
                    '    btnF3选择_Click(Nothing, Nothing)

                Case Keys.F11
                    btnF11打印.Focus()
                    btnF11打印_Click(Nothing, Nothing)

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
            'ClearForm()

            'mIntFormMode = Constant.ENU_MODE.Model_New

            'SetFormModel()

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

    Private Sub btnF2查询_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2查询.Click

        'Dim frmSearch As frm原材料标签打印


        'Try

        '    frmSearch = New frm原材料标签打印

        '    frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

        '    '部门信息查询画面打开
        '    frmSearch.ShowDialog()

        '    '画面数据设置
        '    If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

        '        If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

        '            '根据检索画面数据进行设置

        '            Me.txt原材料材料编号.Text = frmSearch.ReturnTable.Rows(0)("原材料材料编号").ToString          '原材料材料编号
        '            Me.txt数量.Text = frmSearch.ReturnTable.Rows(0)("数量").ToString                              '数量
        '            Me.txt重量.Text = frmSearch.ReturnTable.Rows(0)("重量").ToString                              '重量
        '            Me.txt批次.Text = frmSearch.ReturnTable.Rows(0)("批次").ToString                              '批次 
        '            Me.txt库存区域.Text = frmSearch.ReturnTable.Rows(0)("库存区域").ToString                      '库存区域

        '        End If

        '        If Not frmSearch.ReturnTable Is Nothing Then
        '            '检索画面释放

        '            frmSearch.ReturnTable.Dispose()
        '            frmSearch.ReturnTable = Nothing
        '        End If

        '        '检索画面释放

        '        frmSearch.Dispose()
        '        frmSearch = Nothing


        '        '画面の修正処理

        '        'mIntFormMode = Constant.ENU_MODE.Model_Update

        '        'SetFormModel()

        '    End If

        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try

    End Sub

    Private Sub btnF3选择_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF3选择.Click

        'Dim objB原材料标签打印T As New M原材料库存T

        'Dim objBll As New BLLM原材料库存T

        'Try
        '    If mIntFormMode = Constant.ENU_MODE.Model_New Then
        '        Exit Sub
        '    End If
        '    '保存確認メッセージを表示する
        '    If Me.txt原材料材料编号.Text.Trim = String.Empty Then
        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "原材料材料编号", "原材料材料编号")
        '        txt原材料材料编号.Focus()
        '        Exit Sub
        '    End If

        '    '保存確認メッセージを表示する
        '    If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
        '        '処理終了
        '        Exit Sub
        '    End If

        '    objB原材料标签打印T.原材料材料编号 = txt原材料材料编号.Text.Trim

        '    If objBll.Delete(objB原材料库存T) > 0 Then

        '        '成功メッセージを表示する
        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
        '    Else
        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
        '    End If

        '    'mIntFormMode = Constant.ENU_MODE.Model_New

        '    'SetFormModel()
        '    ClearForm()
        '    Me.txt原材料材料编号.Focus()

        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try

    End Sub

    Private Sub btnF11打印_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11打印.Click
        Try
            Call printbox()
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

            '権限の処理

            'Me.SetPermission()

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

            Me.txt原材料材料编号.Text = String.Empty
            Me.txt数量.Text = String.Empty
            Me.txt重量.Text = String.Empty
            Me.txt批次.Text = String.Empty
            Me.txt库存区域.Text = String.Empty
            Me.txt原材料材料编号.Select()

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

            '原材料材料ID
            If Me.txt原材料材料编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "原材料材料编号", "原材料材料编号")
                txt原材料材料编号.Focus()
                Return False
            End If

            '材料数量
            If Me.txt数量.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "数量", "数量")
                txt数量.Focus()
                Return False
            End If

            '材料重量
            If Me.txt重量.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "重量", "重量")
                txt重量.Focus()
                Return False
            End If

            '批次
            If Me.txt批次.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "批次", "批次")
                txt批次.Focus()
                Return False
            End If

            '库存区域
            If Me.txt库存区域.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "库存区域", "库存区域")
                txt库存区域.Focus()
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

#Region "SetPermission"

    'Private Sub SetPermission()
    '    Try

    '        Me.btnF2查询.Enabled = Utility.PFn_GetAuth(Me.btnF2查询.Tag)
    '        Me.btnF3选择.Enabled = Utility.PFn_GetAuth(Me.btnF3选择.Tag)
    '        ''Me.btnF11打印.Enabled = Utility.PFn_GetAuth(Me.btnF11打印.Tag)

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub
#End Region

#End Region

    Private Sub printbox()
        Try

            Dim rpt As New rptBox

            ' PrinterSettings.PrinterName()
            rpt.lbl材料编号.Text = Me.txt原材料材料编号.Text
            rpt.lbl数量.Text = Me.txt数量.Text
            rpt.lbl重量.Text = Me.txt重量.Text
            rpt.lbl批次号.Text = Me.txt批次.Text
            rpt.lbl库存区域.Text = Me.txt库存区域.Text


            'rpt.Bar二维码.Text = txt原材料材料编号.Text & "|" & txt数量.Text & "|" & txt重量.Text & "|" & txt批次.Text & "|" & txt库存区域.Text

            rpt.Bar二维码.Text = txt原材料材料编号.Text & "|" & txt数量.Text & "|" & txt重量.Text & "|" & txt批次.Text & "|" & txt库存区域.Text

            Dim printername As String = System.Configuration.ConfigurationManager.AppSettings.Get("PrinterName").ToString
            If printername <> "" Then
                rpt.Document.Printer.PrinterName = printername
            End If


            rpt.Run(False)
            rpt.Document.Print(False, False)


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

End Class