Imports HRJS.Constant
Imports HRJS.Utility
Imports UserControl

Public Class InheritsBusinessForm

    Private Sub InheritsBusinessForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Try

        '    'ログアウトのフラグを判断する
        '    If ComVariable.FormCloseMessageFlg = False Then
        '        Exit Sub
        '    End If

        '    'Not Me.labModel.Text.Contains("削除") 
        '    If Not Me.labModel.Text.Contains("参照") AndAlso _
        '         Not Me.labModel.Text.Contains("削除") AndAlso _
        '          Not Me.Text.Contains("検索") Then
        '        '画面を終了します。よろしいですか？
        '        If CommonMsg.ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgNo Then
        '            'キャンセル操作
        '            e.Cancel = True
        '        Else
        '            e.Cancel = False
        '        End If
        '    End If

        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex, Me.Text)

        'End Try
    End Sub

    'Private mbolデータ存在 As Boolean = True

    'Public Property データ存在() As Boolean
    '    Get
    '        Return mbolデータ存在
    '    End Get
    '    Set(ByVal Value As Boolean)
    '        mbolデータ存在 = Value
    '    End Set
    'End Property

    'Private mIsClose As Boolean = False
    'Public Property IsFormClose() As Boolean
    '    Get
    '        Return mIsClose
    '    End Get
    '    Set(ByVal value As Boolean)
    '        mIsClose = value
    '    End Set
    'End Property

    'Private Sub InheritsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    Try
    '        If mIsClose = True Then
    '            e.Cancel = True
    '            Exit Sub
    '        End If

    '        If mbolデータ存在 AndAlso Not Me.Text.Contains("[查询]") AndAlso Not Me.Text.Contains("検索") Then
    '            ''画面を終了します。よろしいですか？
    '            If CommonMsg.showMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgNo Then
    '                e.Cancel = True
    '                Return
    '            End If
    '        End If

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex, Me.Text)

    '    End Try
    'End Sub

    'Private Sub btn画面コピー_Click(sender As Object, e As EventArgs)

    '    Try
    '        '砂時計のカーソルが設定
    '        Me.Cursor = Cursors.WaitCursor

    '        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
    '        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 50.0!
    '        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 50.0!
    '        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 0.0!
    '        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0.0!
    '        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
    '        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.FullWindow)

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex, Me.Text)

    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default

    '    End Try

    'End Sub

    'Private Sub InheritsBusinessForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    '    '「F1」ボタン押下
    '    Select Case e.KeyValue

    '        Case Keys.F1
    '            If Not Me.Sb_SetButtonKey(Constant.CON_BUTTON_REFERRALS) Then
    '                '事件処理終了
    '                Exit Sub
    '            End If

    '            If Not Me.Sb_SetButtonKey(Constant.CON_BUTTON_COPY) Then
    '                '事件処理終了
    '                Exit Sub
    '            End If
    '        Case Keys.F2
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_NEW)
    '        Case Keys.F3
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_UPDATE)
    '        Case Keys.F4
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_DELETE)
    '        Case Keys.F5
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_CLEAR)
    '        Case Keys.F11
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_ENTRY)
    '        Case Keys.F12
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_CLOSE)
    '    End Select

    '    'If e.KeyValue = Windows.Forms.Keys.F1 Then
    '    '    '事件処理終了
    '    '    Exit Sub
    '    'End If
    'End Sub

#Region "自定義関数"

    Private Function Sb_SetButtonKey(ByVal strButtonName As String) As Boolean
        Dim strProwerButtonName As String = String.Empty        '権限ボタン名
        Dim i As Integer                                        '

        '画面のコントロールを判断する
        If Me.Controls.Count <= 0 Then
            Return False
        End If

        For i = 0 To Me.Controls.Count - 1
            'ボタンを判断する
            If Me.Controls(i).GetType() Is GetType(UCButton) Then
                If CType(Me.Controls(i), UCButton).Enabled Then
                    If CType(Me.Controls(i), UCButton).Visible Then
                        '権限ボタン名を取得する
                        strProwerButtonName = CType(Me.Controls(i), UCButton).FSearchButtonName
                        If strButtonName.Equals(strProwerButtonName) Then
                            'ボタンのクリック事件を実行する
                            Call CType(Me.Controls(i), UCButton).MyOnclick()

                            'ループ終了
                            Return False
                        End If
                    End If

                End If
            End If
        Next

        ''ボタンの存在を判断する
        'If Not Me.Controls(strButtonName) Is Nothing Then
        '    'ボタンの使用を判断する
        '    If CType(Me.Controls(strButtonName), CtlButton).Enabled Then
        '        'ボタンのクリック事件を実行する
        '        Call CType(Me.Controls(strButtonName), CtlButton).PSb_Onclick()
        '    End If
        'End If

        Return True

    End Function
#End Region
End Class