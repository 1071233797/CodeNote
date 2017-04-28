Imports HRJS.Constant
Imports HRJS.Utility
Imports UserControl

Public Class InheritsMasterForm

#Region "プロパティ変数"
    Private _IntFormMode As Integer = ENU_MODE.Model_New
    Private _EditDataTable As DataTable           '戻るデータ
#End Region

#Region "プロパティ"
    '一览编辑用
    Public Property FormOpenMode() As Integer
        Get
            Return _IntFormMode
        End Get
        Set(ByVal Value As Integer)
            _IntFormMode = Value
        End Set
    End Property
    '一览编辑用
    Public Property EditDataTable() As DataTable
        Get
            Return _EditDataTable
        End Get
        Set(ByVal value As DataTable)
            _EditDataTable = value
        End Set
    End Property
#End Region

#Region "事件"
    Private Sub InheritsMasterForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

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

  
    'Private Sub InheritsMasterForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    ''「F1」ボタン押下
    '    Select Case e.KeyValue

    '        Case Keys.F1
    '            If Not Me.Sb_SetButtonKey(Constant.CON_BUTTON_REFERRALS) Then
    ''事件処理終了
    '                Exit Sub
    '            End If

    '            If Not Me.Sb_SetButtonKey(Constant.CON_BUTTON_COPY) Then
    ''事件処理終了
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

    ''If e.KeyValue = Windows.Forms.Keys.F1 Then
    ''    '事件処理終了
    ''    Exit Sub
    ''End If

    'End Sub

#End Region

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