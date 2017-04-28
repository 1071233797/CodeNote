Imports System.Reflection
Imports HRJS.Constant
Imports System.Text
Imports UserControl

Public Class InheritsSearchForm
     
#Region "プロパティ変数"
    Private _intReturnType As Integer              '选择
    Private _intSelectFLG As Integer = ENU_初期検索フラグ.検索
    Private _IntFormMode As Integer = ENU_MODE.Model_NULL
    Private _ReturnTable As DataTable           '戻るデータ
    Private _ReturnDataSet As DataSet           '戻るデータ
#End Region

#Region "変数"

#End Region

#Region "プロパティ"

    Public Property FormOpenMode() As Integer
        Get
            Return _IntFormMode
        End Get
        Set(ByVal Value As Integer)
            _IntFormMode = Value
        End Set
    End Property

    Public Property 初期検索フラグ() As Integer
        Get
            Return _intSelectFLG
        End Get
        Set(ByVal value As Integer)
            _intSelectFLG = value
        End Set
    End Property

    Public Property ReturnType() As Integer
        Get
            Return _intReturnType
        End Get
        Set(ByVal value As Integer)
            _intReturnType = value
        End Set
    End Property

    Public Property ReturnTable() As DataTable
        Get
            Return _ReturnTable
        End Get
        Set(ByVal value As DataTable)
            _ReturnTable = value
        End Set
    End Property

    Public Property ReturnDataSet() As DataSet
        Get
            Return _ReturnDataSet
        End Get
        Set(ByVal value As DataSet)
            _ReturnDataSet = value
        End Set
    End Property

#End Region

#Region "事件"
    Private Sub InheritsMasterForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Try
            'クリップボードを空にします。  
            Clipboard.Clear()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex, Me.Text)
        End Try

    End Sub

    'Private Sub InheritsMasterForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    '    '「F1」ボタン押下
    '    Select Case e.KeyValue

    '        Case Keys.F1
    '            If Not Me.Sb_SetButtonKey(Constant.CON_BUTTON_REFERRALS) Then
    '                '事件処理終了
    '                Exit Sub
    '            End If

    '            If Not Me.Sb_SetButtonKey(Constant.CON_BUTTON_SELECTION) Then
    '                '事件処理終了
    '                Exit Sub
    '            End If
    '        Case Keys.F2
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_NEW)
    '        Case Keys.F7
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_F7)
    '        Case Keys.F8
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_F8)
    '        Case Keys.F9
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_SEARCH)
    '        Case Keys.F10
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_F10)
    '        Case Keys.F11
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_F11)
    '        Case Keys.F12
    '            Call Me.Sb_SetButtonKey(Constant.CON_BUTTON_CLOSE)
    '    End Select

    '    'Ctrl+alt+O：
    '    'Ctrlキーを押下状態でCSV出力した場合はクリップボードへコピーする
    '    '（※内容はCSVファイル内容と同一のものとする）
    '    If e.Control = True Then
    '        If e.Alt = True Then
    '            If e.KeyValue = Keys.O Then
    '                Me.Sb_SetButtonKey(Constant.CON_BUTTON_CSVOUTPUT)
    '                'MessageBox.Show(" aaa")
    '            End If
    '        End If
    '    End If

    '    'If e.KeyValue = Windows.Forms.Keys.F1 Then
    '    '    '事件処理終了
    '    '    Exit Sub
    '    'End If

    'End Sub

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