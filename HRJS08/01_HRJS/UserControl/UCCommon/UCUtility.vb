Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinGrid
Imports System.Text.RegularExpressions

Public Class UCUtility

#Region " EnterPressedEventArgs"

    ''-----------------------------------------------------------------------------
    ''  概要
    ''    エンターキーを押す    ''  パラメタ説明
    ''    なし
    ''  機能説明
    ''    無し
    ''  戻り値
    ''    e           :System.Windows.Forms.KeyEventArgs
    ''  作成者    ''    KDC徐鵬［20081201］V0.0.1
    ''  備考    ''
    ''-----------------------------------------------------------------------------
    'Public Shared Sub EnterPressedEventArgs(ByVal e As System.Windows.Forms.KeyEventArgs)

    '    If e.KeyCode = System.Windows.Forms.Keys.Enter Then

    '        If e.Shift Then
    '            System.Windows.Forms.SendKeys.Send("+{TAB}")
    '        ElseIf Not e.Shift Then
    '            System.Windows.Forms.SendKeys.Send("{TAB}")
    '        End If

    '    End If

    'End Sub

#End Region

#Region " 入力タイプ "

#Region " CanInputDate "

    Public Shared Function CanInputDate(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

        If Not (Char.IsDigit(e.KeyChar) _
                Or Asc(e.KeyChar) = Keys.Insert _
                Or Asc(e.KeyChar) = Keys.Sleep _
                Or Asc(e.KeyChar) = Keys.Back _
                Or Asc(e.KeyChar) = Keys.Enter) Then

            Return True

        End If

    End Function

#End Region

#Region " CanInputTime "

    Public Shared Function CanInputTime(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

        If Not (Char.IsDigit(e.KeyChar) _
                Or Asc(e.KeyChar) = Keys.RButton + Keys.D8 _
                Or Asc(e.KeyChar) = Keys.Back _
                Or Asc(e.KeyChar) = Keys.Enter) Then

            Return True

        End If

    End Function

#End Region

#Region " CanInputDigit "

    Public Shared Function CanInputDigit(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

        If Not (Char.IsDigit(e.KeyChar) _
                Or Asc(e.KeyChar) = Keys.Back _
                Or Asc(e.KeyChar) = Keys.Enter) Then

            Return True

        End If

    End Function

#End Region

#Region " CanInputLetterOrDigit "

    Public Shared Function CanInputLetterOrDigit(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

        If Not (Char.IsLetterOrDigit(e.KeyChar) _
                Or Asc(e.KeyChar) = Keys.Back _
                Or Asc(e.KeyChar) = Keys.Enter) Then

            Return True

        End If

    End Function

#End Region

#Region " CanInputLetterOrDigitOrBlank "

    Public Shared Function CanInputLetterOrDigitOrBlank(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

        If Not (Char.IsLetterOrDigit(e.KeyChar) _
                Or Asc(e.KeyChar) = Keys.Back _
                Or Asc(e.KeyChar) = Keys.Enter _
                Or Asc(e.KeyChar) = Keys.Space) Then

            Return True

        End If

    End Function

#End Region

#Region " CanInputLetterEventArgs "

    Public Shared Function CanInputLetter(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

        If Not (Char.IsLetter(e.KeyChar) _
                Or Asc(e.KeyChar) = Keys.Back _
                Or Asc(e.KeyChar) = Keys.Enter) Then

            Return True

        End If

    End Function

#End Region

#Region " CanInputTelEventArgs "

    Public Shared Function CanInputTel(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

        If Not (Char.IsDigit(e.KeyChar) _
                Or Asc(e.KeyChar) = Keys.Back _
                Or Asc(e.KeyChar) = Keys.Enter _
                Or Asc(e.KeyChar) = Keys.Insert _
                Or Asc(e.KeyChar) = Keys.Down _
                Or Asc(e.KeyChar) = Keys.Select _
                ) Then
            Return True
        End If

    End Function

#End Region

#Region " CanInputDigitTelLetter "

    Public Shared Function CanInputDigitTelLetter(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

        If Not (Char.IsLetterOrDigit(e.KeyChar) _
                Or Asc(e.KeyChar) = Keys.Back _
                Or Asc(e.KeyChar) = Keys.Enter _
                Or Asc(e.KeyChar) = Keys.Insert _
                Or Asc(e.KeyChar) = Keys.Down _
                Or Asc(e.KeyChar) = Keys.Select _
                ) Then
            Return True
        End If

    End Function

#End Region


#Region " CanInputCommaOrDigit "

    Public Shared Function CanInputCommaOrDigit(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

        If Not (IsDigitOrComma(e.KeyChar) _
                Or Asc(e.KeyChar) = Keys.Back _
                Or Asc(e.KeyChar) = Keys.Enter) Then

            Return True

        End If

    End Function

#End Region

#Region " PFn_IsDate"

    '-----------------------------------------------------------------------------
    '  概要
    '    Dateかどうかをチェックする
    '  パラメタ説明
    '    ParamString   :String
    '  機能説明
    '    無し
    '  戻り値
    '   Boolean ①True    :Dateがあります　②False   :数字がありませでした
    '  作成者    '    KDC［20081201］V0.0.1
    '  備考    '-----------------------------------------------------------------------------
    Public Shared Function PFn_IsDate(ByVal ParamString As String) As Boolean

        Dim CharArray As Char()

        '文字列Arrayを切替
        CharArray = ParamString.ToCharArray

        For Each ItemChar As Char In CharArray

            If Not (Char.IsDigit(ItemChar) _
                    Or Asc(ItemChar) = Keys.Insert _
                    Or Asc(ItemChar) = Keys.Sleep) Then
                Return False
            End If

        Next    '文字列Arrayをloopへ

        Return True

    End Function

#End Region

#Region " IsTime"

    '-----------------------------------------------------------------------------
    '  概要
    '    Timeかどうかをチェックする
    '  パラメタ説明
    '    ParamString   :String
    '  機能説明
    '    無し
    '  戻り値
    '   Boolean ①True    :Timeがあります　②False   :数字がありませでした
    '  作成者    '    KDC［20081201］V0.0.1
    '  備考    '-----------------------------------------------------------------------------
    Public Shared Function IsTime(ByVal ParamString As String) As Boolean

        Dim CharArray As Char()

        '文字列Arrayを切替
        CharArray = ParamString.ToCharArray

        For Each ItemChar As Char In CharArray

            If Not (Char.IsDigit(ItemChar) _
                    Or Asc(ItemChar) = Keys.RButton + Keys.D8) Then
                Return False
            End If

        Next    '文字列Arrayをloopへ

        Return True

    End Function

#End Region

#Region " PFn_IsDigit"

    '-----------------------------------------------------------------------------
    '  概要
    '    数字かどうかをチェックする
    '  パラメタ説明
    '    ParamString   :String
    '  機能説明
    '    無し
    '  戻り値
    '   Boolean ①True    :数字があります　②False   :数字がありませでした
    '  作成者    '    KDC［20081201］V0.0.1
    '  備考    '-----------------------------------------------------------------------------
    Public Shared Function PFn_IsDigit(ByVal ParamString As String) As Boolean

        Dim CharArray As Char()

        '文字列Arrayを切替
        CharArray = ParamString.ToCharArray

        For Each ItemChar As Char In CharArray

            '/*
            '*　数字のみのチェック
            '*  半角のみ：0～9
            '*/
            If Not (Char.IsDigit(ItemChar)) Then
                Return False    '数字がありませでした
            End If

        Next    '文字列Arrayをloopへ

        Return True

    End Function

#End Region

#Region " PFn_IsTelZip"

    '-----------------------------------------------------------------------------
    '  概要
    '    電話と郵便かどうかをチェックする
    '  パラメタ説明
    '    ParamString   :String
    '  機能説明
    '    無し
    '  戻り値
    '   Boolean ①True    :あります　②False   :ありませでした
    '  作成者    '    KDC［20081201］V0.0.1
    '  備考    '
    '-----------------------------------------------------------------------------
    Public Shared Function PFn_IsTelZip(ByVal ParamString As String) As Boolean

        Dim CharArray As Char()

        '文字列Arrayを切替
        CharArray = ParamString.ToCharArray

        For Each ItemChar As Char In CharArray

            '/*
            '*　数字のみと-のチェック
            '*  半角のみ：0～9と－

            '*/
            If Not (Char.IsDigit(ItemChar) _
                    Or Asc(ItemChar) = Keys.Insert _
                    Or Asc(ItemChar) = Keys.Down _
                    Or Asc(ItemChar) = Keys.Select) Then
                Return False 'ありませでした
            End If

        Next   '文字列Arrayをloopへ

        Return True

    End Function

#End Region

#Region " PFn_DigitTelLetter"

    '-----------------------------------------------------------------------------
    '  概要
    '    電話と郵便かどうかをチェックする
    '  パラメタ説明
    '    ParamString   :String
    '  機能説明
    '    無し
    '  戻り値
    '   Boolean ①True    :あります　②False   :ありませでした
    '  作成者    '    KDC［20081201］V0.0.1
    '  備考    '
    '-----------------------------------------------------------------------------
    Public Shared Function PFn_DigitTelLetter(ByVal ParamString As String) As Boolean

        Dim CharArray As Char()

        '文字列Arrayを切替
        CharArray = ParamString.ToCharArray

        For Each ItemChar As Char In CharArray

            '/*
            '*　数字のみと-のチェック
            '*  半角のみ：0～9と－

            '*/
            If Not (Char.IsDigit(ItemChar) _
                    Or Asc(ItemChar) = Keys.Insert _
                    Or Asc(ItemChar) = Keys.Down _
                    Or Asc(ItemChar) = Keys.Select _
                    Or (Asc(Char.ToUpper(ItemChar)) >= Keys.A _
                    And Asc(Char.ToUpper(ItemChar)) <= Keys.Z)) Then
                Return False 'ありませでした
            End If

        Next   '文字列Arrayをloopへ

        Return True

    End Function

#End Region

#Region " IsLetterOrDigit"

    '-----------------------------------------------------------------------------
    '  概要
    '    数字とレターかどうかをチェックする
    '  パラメタ説明
    '    ParamString   :String
    '  機能説明
    '    無し
    '  戻り値
    '   Boolean ①True    :あります　②False   :ありませでした
    '  作成者    '    KDC［20081201］V0.0.1
    '  備考    '
    '-----------------------------------------------------------------------------
    Public Shared Function PFn_IsLetterOrDigit(ByVal ParamString As String) As Boolean

        Dim CharArray As Char()

        '文字列Arrayを切替
        CharArray = ParamString.ToCharArray

        For Each ItemChar As Char In CharArray

            '/*
            '*　数字のみと-のチェック
            '*  半角のみ：0～9と－とA(a)～Z(z)
            '*/
            If Not (Char.IsDigit(ItemChar) _
                    Or Asc(ItemChar) = Keys.Insert _
                    Or (Asc(Char.ToUpper(ItemChar)) >= Keys.A _
                    And Asc(Char.ToUpper(ItemChar)) <= Keys.Z)) Then

                Return False 'ありませでした

            End If

        Next   '文字列Arrayをloopへ

        Return True

    End Function

#End Region

#Region " PFn_IsLetterOrDigitOrBlank"

    '-----------------------------------------------------------------------------
    '  概要
    '    数字とレターとブランクかどうかをチェックする
    '  パラメタ説明
    '    ParamString   :String
    '  機能説明
    '    無し
    '  戻り値
    '   Boolean ①True    :あります　②False   :ありませでした
    '  作成者    '    KDC_李濤［20140201］V0.0.1
    '  備考    '
    '-----------------------------------------------------------------------------
    Public Shared Function PFn_IsLetterOrDigitOrBlank(ByVal ParamString As String) As Boolean

        Dim CharArray As Char()

        '文字列Arrayを切替
        CharArray = ParamString.ToCharArray

        For Each ItemChar As Char In CharArray

            '/*
            '*　数字のみと-のチェック
            '*  半角のみ：0～9と－とA(a)～Z(z)
            '*/
            If Not (Char.IsDigit(ItemChar) Or _
                     (Asc(Char.ToUpper(ItemChar)) >= Keys.A And _
                      Asc(Char.ToUpper(ItemChar)) <= Keys.Z) Or _
                       Asc(ItemChar) = Keys.Space) Then

                Return False 'ありませでした

            End If

        Next   '文字列Arrayをloopへ

        Return True

    End Function

#End Region

#Region " PFn_IsLetter"

    '-----------------------------------------------------------------------------
    '  概要
    '    半角とレターかどうかをチェックする
    '  パラメタ説明
    '    ParamString   :String
    '  機能説明
    '    無し
    '  戻り値
    '   Boolean ①True    :あります　②False   :ありませでした
    '  作成者    '    KDC徐鵬［20081201］V0.0.1
    '  備考    '
    '-----------------------------------------------------------------------------
    Public Shared Function PFn_IsLetter(ByVal ParamString As String) As Boolean

        Dim CharArray As Char()

        '文字列Arrayを切替
        CharArray = ParamString.ToCharArray

        For Each ItemChar As Char In CharArray

            '/*
            '*　半角のみ：A(a)～Z(z)のチェック
            '*/
            If Not ((Asc(Char.ToUpper(ItemChar)) >= Keys.A _
                    And Asc(Char.ToUpper(ItemChar)) <= Keys.Z)) Then

                Return False 'ありませでした

            End If

        Next   '文字列Arrayをloopへ

        Return True

    End Function

#End Region

#Region " IsDigitOrComma"

    '-----------------------------------------------------------------------------
    '  概要
    '    数字かどうかをチェックする
    '  パラメタ説明
    '    ParamString   :String
    '  機能説明
    '    無し
    '  戻り値
    '   Boolean ①True    :数字があります　②False   :数字がありませでした
    '  作成者    '    KDC［20081201］V0.0.1
    '  備考    '-----------------------------------------------------------------------------
    Public Shared Function IsDigitOrComma(ByVal ParamString As String) As Boolean

        Dim CharArray As Char()

        '文字列Arrayを切替
        CharArray = ParamString.ToCharArray

        For Each ItemChar As Char In CharArray

            '/*
            '*　数字のみのチェック
            '*  半角のみ：0～9
            '*/
            If Not (Char.IsDigit(ItemChar) Or Asc(ItemChar) = Asc(",") Or Asc(ItemChar) = Asc(".")) Then
                Return False    '数字がありませでした
            End If

        Next    '文字列Arrayをloopへ

        Return True

    End Function

#End Region

#Region "formatCdByMaxLgh"

    '-----------------------------------------------------------------------------
    '  概要
    '    ゼロ埋めして、処理する
    '  パラメタ説明
    '   strCd               :コード
    '   intMaxLgh           :最大桁数
    '  機能説明
    '   なし
    '  戻り値
    '    String
    '  作成者
    '    
    '  備考
    '
    '-----------------------------------------------------------------------------
    Public Shared Function PFn_formatCdByMaxLgh(ByVal strCd As String, ByVal intMaxLgh As Int64) As String

        '▼変数定義
        Const cstrMethodName As String = "Utility.formatCdByMaxLgh"     'メソッド名称
        Dim intloopi As Integer = 0
        Dim strTemp As String

        Try

            strTemp = strCd
            For intloopi = 1 To intMaxLgh - strCd.Length
                strTemp = "0" & strTemp
            Next
            Return strTemp

        Catch ex As Exception
            Throw New Exception(cstrMethodName, ex)
        End Try

    End Function

#End Region

#End Region

#Region " CopyGridCell "

    Public Shared Sub CopyGridCell(ByVal e As System.Windows.Forms.KeyEventArgs, ByVal ugrdList As UltraGrid)

        If ugrdList.Rows Is Nothing Then
            Exit Sub
        End If

        If ugrdList.Rows.Count <> 0 Then

            If Not ugrdList.ActiveCell Is Nothing Then

                If e.KeyData = Keys.Control + Keys.C Then

                    Dim strClip As String

                    strClip = ugrdList.ActiveCell.Text.Trim

                    Clipboard.SetDataObject(strClip, True)

                End If

            End If

        End If

    End Sub

#End Region
 
#Region "文字列を処理"

    Public Shared Function PFn_Trim(ByVal objValue As Object) As String
        If objValue Is Nothing Then
            PFn_Trim = String.Empty
        Else
            Try
                '両端空格を削除する
                PFn_Trim = PFn_ToString(objValue).Trim

                '特別文字を処理する

            Catch ex As Exception
                PFn_Trim = String.Empty
            End Try
        End If
    End Function

    ''' <summary>
    ''' 文字列に変化する
    ''' </summary>
    ''' <param name="objValue">変化前に文字</param>
    ''' <returns>文字列</returns>
    ''' <remarks>文字列に変化する</remarks>
    Public Shared Function PFn_ToString(ByVal objValue As Object) As String
        If objValue Is Nothing OrElse IsDBNull(objValue) Then
            PFn_ToString = String.Empty
        Else
            Try
                PFn_ToString = Convert.ToString(objValue)
            Catch ex As Exception
                PFn_ToString = String.Empty
            End Try
        End If
    End Function

    Public Shared Function PFn_ToInteger(ByVal objValue As Object) As Integer
        If objValue Is Nothing OrElse IsDBNull(objValue) Then
            PFn_ToInteger = 0
        Else
            Try
                PFn_ToInteger = CInt(objValue)
            Catch ex As Exception
                PFn_ToInteger = 0
            End Try
        End If
    End Function

    ''' <summary>
    ''' 長整数を変化する
    ''' </summary>
    ''' <param name="objValue">数字オブジェクト</param>
    ''' <returns>長整数</returns>
    ''' <remarks>長整数を変化する</remarks>
    Public Shared Function PFn_ToLong(ByVal objValue As Object) As Long
        If objValue Is Nothing OrElse IsDBNull(objValue) Then
            PFn_ToLong = 0
        Else
            Try
                PFn_ToLong = CType(objValue, Long)
            Catch ex As Exception
                PFn_ToLong = 0
            End Try
        End If
    End Function

  
    Public Shared Function PFn_ToDouble(ByVal objValue As Object) As Double
        If objValue Is Nothing OrElse IsDBNull(objValue) Then
            PFn_ToDouble = 0
        Else
            Try
                PFn_ToDouble = CDbl(objValue)
            Catch ex As Exception
                PFn_ToDouble = 0
            End Try
        End If
    End Function

    Public Shared Function PFn_ToDecimal(ByVal objValue As Object) As Decimal
        If objValue Is Nothing OrElse IsDBNull(objValue) Then
            PFn_ToDecimal = 0
        Else
            Try
                PFn_ToDecimal = CDec(objValue)
            Catch ex As Exception
                PFn_ToDecimal = 0
            End Try
        End If
    End Function

    Public Shared Function PFn_ToDateTime(ByVal objValue As Object) As DateTime

        '「Nothing」を判断する
        If objValue Is Nothing Then
            PFn_ToDateTime = Nothing
        End If

        '日付を判断する
        If Not IsDate(objValue) Then
            '空を戻る
            PFn_ToDateTime = Nothing
            Exit Function
        End If

        Try
            '日付を変化する
            PFn_ToDateTime = CDate(objValue)
        Catch ex As Exception
            PFn_ToDateTime = Nothing
        End Try
    End Function

    ''' <summary>
    ''' 「nothing」と「DBNull」を判断する
    ''' </summary>
    ''' <param name="objValue">判断対象</param>
    ''' <returns>true又はfalse</returns>
    ''' <remarks>「nothing」と「DBNull」を判断する</remarks>
    Public Shared Function PFn_IsNothingOrNull(ByVal objValue As Object) As Boolean
        PFn_IsNothingOrNull = True
        If objValue Is Nothing Then
            Exit Function
        End If

        If objValue Is DBNull.Value Then
            Exit Function
        End If

        PFn_IsNothingOrNull = False
    End Function

    ''' <summary>
    ''' 「nothing」と「DBNull」を判断する
    ''' </summary>
    ''' <param name="objValue">判断対象</param>
    ''' <returns>true又はfalse</returns>
    ''' <remarks>「nothing」と「DBNull」を判断する</remarks>
    Public Shared Function PFn_IsNothingOrNullOrBlank(ByVal objValue As Object) As Boolean
        PFn_IsNothingOrNullOrBlank = True
        If objValue Is Nothing Then
            Exit Function
        End If

        If objValue Is DBNull.Value Then
            Exit Function
        End If

        If objValue = String.Empty Then
            Exit Function
        End If

        PFn_IsNothingOrNullOrBlank = False
    End Function

    Public Shared Function PFn_IsNumber(ByVal objValue As Object) As Boolean
        PFn_IsNumber = True
        objValue = PFn_ToString(objValue)

        If PFn_IsRegex(ComVariable.CON_REGEX_NUMBER, objValue) Then
            Exit Function
        End If

        PFn_IsNumber = False
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function PFn_ToDecimalNull(ByVal objValue As Object) As Object

        If objValue Is Nothing OrElse IsDBNull(objValue) OrElse objValue.ToString = String.Empty Then
            PFn_ToDecimalNull = DBNull.Value
        Else
            PFn_ToDecimalNull = objValue
        End If

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function PFn_ToDBNull(ByVal objValue As Object) As Object
        If objValue Is Nothing Then
            PFn_ToDBNull = DBNull.Value
        Else
            PFn_ToDBNull = objValue
        End If
    End Function

    ''' <summary>
    ''' 「nothing」と「DBNull」を変化する
    ''' </summary>
    ''' <param name="objValue">数字オブジェクト</param>
    ''' <returns>Boolean</returns>
    ''' <remarks>DBNullを変化する</remarks>
    Public Shared Function PFn_ToBoolean(ByVal objValue As Object) As Boolean
        If objValue Is Nothing OrElse IsDBNull(objValue) Then
            PFn_ToBoolean = False
        Else
            Try
                PFn_ToBoolean = objValue
            Catch ex As Exception
                PFn_ToBoolean = False
            End Try
        End If
    End Function

#Region "正規表現の方法"
    ''' <summary>
    ''' 正規表現の文字列について、正確性を戻る
    ''' </summary>
    ''' <param name="strRegex">正規表現の文字列</param>
    ''' <param name="strValue">判断の文字列</param>
    ''' <returns>true:正確  false:正確しない</returns>
    ''' <remarks>正規表現の文字列について、正確性を戻る</remarks>
    Public Shared Function PFn_IsRegex(ByVal strRegex As String, _
                                       ByVal strValue As String) As Boolean
        Dim rege As System.Text.RegularExpressions.Regex               '正規表現
        Dim ma As Match                 '数字関数
        Try
            '正規表現の計算方法をセットする
            rege = New System.Text.RegularExpressions.Regex(strRegex)

            '計算する
            ma = rege.Match(strValue)

            '正確性を戻る
            PFn_IsRegex = ma.Success

            'オブジェクトをクリアする
            ma = Nothing
            rege = Nothing
        Catch ex As Exception
            PFn_IsRegex = False

            'オブジェクトをクリアする
            ma = Nothing
            rege = Nothing
        End Try
    End Function
#End Region

#Region "文字チェック"
 
    ''' <summary>
    ''' 文字の全角をチェックする
    ''' </summary>
    ''' <param name="objValue">全角文字</param>
    ''' <returns>true:全角文字  false:全角文字がない</returns>
    ''' <remarks>文字の全角をチェックする</remarks>
    Public Shared Function PFn_CheckAllEm(ByVal objValue As String) As Boolean
        Dim i As Integer
        PFn_CheckAllEm = True

        If objValue.Equals(String.Empty) Then
            '空を戻る
            Exit Function
        End If

        For i = 0 To objValue.Length - 1
            '全角をチェックする
            If (0 <= Asc(objValue.Substring(i, 1)) AndAlso _
                Asc(objValue.Substring(i, 1)) < 256) Then

                PFn_CheckAllEm = False
                Exit For
            End If
        Next i
    End Function

    ''' <summary>
    ''' 文字の半角をチェックする
    ''' </summary>
    ''' <param name="objValue">半角文字</param>
    ''' <returns>true:半角文字  false:半角文字がない</returns>
    ''' <remarks>文字の半角をチェックする</remarks>
    Public Shared Function PFn_CheckHalfEm(ByVal objValue As String) As Boolean
        Dim i As Integer
        PFn_CheckHalfEm = True

        If objValue.Equals(String.Empty) Then
            '空を戻る
            Exit Function
        End If

        For i = 0 To objValue.Length - 1
            '半角をチェックする
            If (Asc(objValue.Substring(i, 1)) < 0 OrElse _
                256 <= Asc(objValue.Substring(i, 1))) Then
                PFn_CheckHalfEm = False
                Exit For
            End If
        Next i
    End Function

    ''' <summary>
    ''' 文字の半角をチェックする
    ''' </summary>
    ''' <param name="objValue">半角文字</param>
    ''' <returns>true:半角文字  false:半角文字がない</returns>
    ''' <remarks>文字の半角をチェックする</remarks>
    Public Shared Function PFn_CheckHalfEmHaihun(ByVal objValue As String) As Boolean
        Dim i As Integer
        PFn_CheckHalfEmHaihun = True

        If objValue.Equals(String.Empty) Then
            '空を戻る
            Exit Function
        End If

        For i = 0 To objValue.Length - 1
            '半角をチェックする
            If (Asc(objValue.Substring(i, 1)) >= 97 AndAlso Asc(objValue.Substring(i, 1)) <= 122) OrElse _
                (Asc(objValue.Substring(i, 1)) >= 65 AndAlso Asc(objValue.Substring(i, 1)) <= 90) OrElse _
                 (Asc(objValue.Substring(i, 1)) >= 48 AndAlso Asc(objValue.Substring(i, 1)) <= 57) OrElse _
                 Asc(objValue.Substring(i, 1)) = 45 Then
            Else
                PFn_CheckHalfEmHaihun = False
                Exit For
            End If
        Next i
    End Function

    Public Shared Function PFn_CheckTel(ByVal objValue As String) As Boolean
        PFn_CheckTel = True
        Dim intASCNum As Integer               'ASC番号

        If objValue.Equals(String.Empty) Then
            '空を戻る
            Exit Function
        End If

        '電話番号をチェックする
        For i As Integer = 0 To objValue.Length - 1
            intASCNum = Asc(objValue.Substring(i, 1))

            '電話番号をチェック処理
            If (32 <= intASCNum AndAlso intASCNum <= 64) OrElse _
                (91 <= intASCNum AndAlso intASCNum <= 96) OrElse _
                (123 <= intASCNum AndAlso intASCNum <= 126) Then
                '「0-9」と「-」を判断する
                PFn_CheckTel = True
            Else
                PFn_CheckTel = False
                Exit For
            End If
        Next
    End Function
#End Region

#End Region

End Class
