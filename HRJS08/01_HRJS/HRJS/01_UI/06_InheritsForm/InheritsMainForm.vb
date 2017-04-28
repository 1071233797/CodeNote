Imports HRJS.Constant
Imports HRJS.Utility
Imports UserControl

Public Class InheritsMainForm

#Region "プロパティ変数"
    Private _CloseFlg As Boolean = False                '閉じるフラグ
    Public Const WM_CLOSE As Int64 = &H10

    'フォーム用API
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, _
                     ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
#End Region

#Region "プロパティ"
    ''' <summary>
    ''' 閉じるフラグ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>閉じるフラグ</remarks>
    Public Property CloseFlg() As Boolean
        Get
            CloseFlg = _CloseFlg
        End Get
        Set(ByVal value As Boolean)
            _CloseFlg = value
        End Set
    End Property
#End Region

#Region "事件"

    ''' <summary>
    ''' 画面の様式を設置する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>画面の様式を設置する</remarks>
    Private Sub BaseForm_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles Me.Layout
        '画面の文字を設置する
        'Me.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        'Me.MinimumSize = Me.Size
    End Sub


    Protected Overrides Sub [onload](ByVal e As System.EventArgs)

        'プッカスをセットする
        Call Sb_SetCursor(Me)

        'ヘッダを作成する
        Call Sb_SetFormText()

        'フォームを保存する
        Call Sb_AddFormToList(Me)

        MyBase.OnLoad(e)

    End Sub

    ''' <summary>
    ''' メッセージを判断する
    ''' </summary>
    ''' <param name="m"></param>
    ''' <remarks>メッセージを判断する</remarks>
    Protected Overrides Sub WndProc(ByRef m As Message)
        '画面上方の「×」ボタンを判断する
        If m.Msg = 99 AndAlso CInt(m.WParam) = 0 Then
            CloseFlg = True
            Me.Close()
        Else
            MyBase.WndProc(m)
        End If
    End Sub

   
    Private Sub InheritsMainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '「Shift」ボタン押下
        If e.Shift = True Then
            '「Enter」ボタン押下
            If e.KeyCode = Windows.Forms.Keys.Enter Then
                '「Shift」と「Tab」キーの処理を実行する
                Windows.Forms.SendKeys.Send("+{Tab}")
            End If

            '事件処理終了
            Exit Sub
        End If

        '「Ctrl」ボタン押下
        If e.Control Then
            '事件処理終了
            Exit Sub
        End If

        '「Enter」ボタン押下
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            '「Tab」キーの処理を実行する
            Windows.Forms.SendKeys.Send("{Tab}")

            '事件処理終了
            Exit Sub
        End If
    End Sub
#End Region

#Region "自定義関数"
    ''' <summary>
    ''' フォームをリストにセットする
    ''' </summary>
    ''' <param name="frmBaseForm">基本フォーム</param>
    ''' <remarks>フォームをリストにセットする</remarks>
    ''' <history>
    ''' 	[WangXin]	2010/02/22	Created
    ''' </history>
    Private Sub Sb_AddFormToList(ByVal frmBaseForm As InheritsMainForm)

        If frmBaseForm.Name <> "主画面" Then
            Constant.FormList.Add(frmBaseForm.Handle.ToInt64)
            Constant.FormNameList.Add(frmBaseForm.Name)
        End If
    End Sub

    ''' <summary>
    ''' 全部フォームを閉する
    ''' </summary>
    ''' <remarks>全部フォームを閉する</remarks>
    ''' <history>
    ''' 	[WangXin]	2010/02/22	Created
    ''' </history>
    Public Sub PSb_CloseAllForm()
        ComVariable.FormCloseMessageFlg = False
        For intCOunt As Integer = Constant.FormList.Count - 1 To 0 Step -1
            SendMessage(Utility.ToInteger(Constant.FormList.Item(intCOunt)), WM_CLOSE, 0, 0)
        Next
        ComVariable.FormCloseMessageFlg = True
    End Sub


    ''' <summary>
    ''' プッカスをセットする
    ''' </summary>
    ''' <param name="conParent">容器</param>
    ''' <remarks>プッカスをセットする</remarks>
    Private Sub Sb_SetCursor(ByVal conParent As Control)
        conParent.Cursor = Cursors.Arrow
        '全てコントロールをループする
        For Each cont As Control In conParent.Controls
            If cont.HasChildren Then
                Call Sb_SetCursor(cont)
            Else
                If cont.GetType() Is GetType(UCGridEdit) Then
                    cont.Cursor = Cursors.Arrow
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' フォームタイトルをセットする
    ''' </summary>
    ''' <remarks>フォームタイトルをセットする</remarks>
    Private Sub Sb_SetFormText()
        Dim strFormText As String = String.Empty

        '"機能名" + "［" + "営業所" + "："　+　営業所CD　+　営業所名　+　"］" +　半角Space　+　 "［" + "社員" + "："　+　社員CD　+　社員氏名　+　"］"
        'strFormText = Me.FeatureName

        'If Not Me.FeatureCode.Equals("Menu") And Not Me.FeatureCode.Equals(String.Empty) Then
        '    strFormText = strFormText & ComVariable.CON_BIGBRACKETS_LEFT & ComVariable.CON_CHARACHERS_BUSINESS _
        '                  & ComVariable.CON_SPECIAL_CHARACTERS_COLON & ComVariable.UserInfo.UserEigyouJoCode & ComVariable.CON_HALF_SPACE _
        '                  & ComVariable.UserInfo.UserEigyouJoName & ComVariable.CON_BIGBRACKETS_RIGHT _
        '                  & ComVariable.CON_HALF_SPACE _
        '                  & ComVariable.CON_BIGBRACKETS_LEFT & ComVariable.CON_CHARACHERS_EMPLOYEE _
        '                  & ComVariable.CON_SPECIAL_CHARACTERS_COLON & ComVariable.UserInfo.UserID & ComVariable.CON_HALF_SPACE _
        '                  & ComVariable.UserInfo.UserName & ComVariable.CON_BIGBRACKETS_RIGHT

        'End If

        ''画面モードを追加する
        'If Not Me.FormType.Equals(String.Empty) Then
        '    strFormText = strFormText & ComVariable.CON_ALL_STAR & Me.FormType
        'End If

        'フォームタイトルをセットする
        'Me.Text = strFormText

    End Sub
#End Region

End Class