Imports HRJS.Constant
Imports System.Windows.Forms
Imports System.Text
Imports System.Collections
Imports System.Data

Public Class CommonMsg
#Region "変数"
    Private Shared strMessageInfo As String = String.Empty
    Private Shared strMessageType As String = String.Empty
    Public Shared mblnShowMessageFlg As Boolean = False
#End Region

#Region "関数"

    Private Shared Function Fn_GetMessageInfo(ByVal strMsgID As String, _
                                              ByVal strMsgItem1 As String) As String
        Dim strSQL As StringBuilder
        Dim htTable As Hashtable
        Dim tbMessage As DataTable
        Dim i As Integer

        Fn_GetMessageInfo = String.Empty

        'SQL文をセットする
        strSQL = New StringBuilder()
        strSQL.Append("SELECT 信息ID,信息类型,信息内容,备注 FROM dbo.M信息 ")
        strSQL.Append(" WHERE 信息ID =  @信息ID ")

        'SQL文の中、引数をセットする
        htTable = New Hashtable()
        htTable.Add("信息ID", strMsgID)


        '検索する
        tbMessage = DbHelper.PFn_Sh_SelectDB(strSQL, htTable)
        If tbMessage Is Nothing Then
            Exit Function
        End If

        'メッセージ情報を取得する
        For i = 0 To tbMessage.Rows.Count - 1
            'メッセージデータを取得する

            strMessageInfo = Utility.PFn_ToString(tbMessage.Rows(i).Item("信息内容"))
            Fn_GetMessageInfo = strMessageInfo

            'ヒント項目を判断する
            If Not strMsgItem1.Equals(String.Empty) Then
                '改行符を追加する
                Fn_GetMessageInfo = Fn_GetMessageInfo & Constant.CON_ENTER
            End If

            'メッセージ類型を取得する
            strMessageType = Utility.PFn_ToString(tbMessage.Rows(i).Item("信息类型"))
        Next

    End Function

    ''' <summary>
    ''' メッセージを表示する
    ''' </summary>
    ''' <param name="strMsgTitle">機能コード</param>
    ''' <param name="strMsgID">メッセージコード</param>
    ''' <param name="strMsgItem1">引数1</param>
    ''' <param name="strMsgItem2">引数2</param>
    ''' <param name="strMsgItem3">引数3</param>
    ''' <returns>メッセージ枚挙</returns>
    ''' <remarks>メッセージを表示する</remarks>
    Public Shared Function PFn_ShowMsg(ByVal strMsgTitle As String, _
                                              ByVal strMsgID As String, _
                                              Optional ByVal strMsgItem1 As String = "", _
                                              Optional ByVal strMsgItem2 As String = "", _
                                              Optional ByVal strMsgItem3 As String = "") As DialogResult
        Dim strTitle As String              'メッセージタスクバー
        Dim strContents As String           'メッセージ情報

        '画面ID＋"("＋メッセージマスタ：メッセージID＋")"　とすること
        'strTitle = strMsgTitle ' FeatureCode & ComVariable.CON_BRACKETS_LEFT & strMsgID & ComVariable.CON_BRACKETS_RIGHT

        strTitle = strMsgTitle & Constant.CON_BRACKETS_LEFT & strMsgID & Constant.CON_BRACKETS_RIGHT

        'メッセージ情報を取得する
        strContents = Fn_GetMessageInfo(strMsgID, strMsgItem1)

        '引数を変換する
        strContents = strContents.Replace("\n", vbCrLf)

        If strMsgItem1 <> String.Empty Then
            strContents = strContents.Replace("\1", strMsgItem1)
        End If

        If strMsgItem2 <> String.Empty Then
            strContents = strContents.Replace("\2", strMsgItem2)
        End If

        If strMsgItem3 <> String.Empty Then
            strContents = strContents.Replace("\3", strMsgItem3)
        End If

        '1:確認  2: 警告  3: エラー  4: はい、いいえ  5:はい、いいえ、キャンセル
        Select Case strMessageType
            Case "1"
                '1：Information(情報)
                PFn_ShowMsg = MessageBox.Show(strContents, strTitle, _
                                                     MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "2"
                '2:Exclamation(注意)
                PFn_ShowMsg = MessageBox.Show(strContents, strTitle, _
                                                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Case "3"
                '3:Critical(警告)
                PFn_ShowMsg = MessageBox.Show(strContents, strTitle, _
                                                     MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case "4"
                '4:YesNo(+Question(問い合わせ))
                'If strMsgID = ComMessage.CON_MESSAGE_ID3 OrElse _
                '        strMsgID = ComMessage.CON_MESSAGE_ID1000069 OrElse _
                '        strMsgID = ComMessage.CON_MESSAGE_ID1000011 OrElse _
                '        strMsgID = ComMessage.CON_MESSAGE_ID1000012 Then
                '    PFn_ShowMsg = MessageBox.Show(strContents, strTitle, _
                '                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                'Else
                PFn_ShowMsg = MessageBox.Show(strContents, strTitle, _
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                'End If
            Case "5"
                '5:YesNoCancel(+Question(問い合わせ))
                PFn_ShowMsg = MessageBox.Show(strContents, strTitle, _
                                                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            Case Else

                PFn_ShowMsg = DialogResult.None
        End Select

        mblnShowMessageFlg = True

    End Function
#End Region

End Class
