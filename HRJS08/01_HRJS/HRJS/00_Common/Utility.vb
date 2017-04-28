Imports System.Text
Imports System
Imports System.DBNull
Imports HRJS.Constant
Imports System.Text.RegularExpressions
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports System.Data.SqlClient
Imports Microsoft.Win32
Imports System.IO
Imports Microsoft.Office.Interop
Public Class Utility
    Implements IEnumerable

    '画面について
    Private FormsCollection As Collection                           '画面名称

#Region "LOGファイルを出力する"

    Public Shared Sub PSb_WriteLOGFile(ByVal intLogType As Integer, _
                                       ByVal strLogInfo As String, _
                                       Optional ByVal htPara As Hashtable = Nothing)
        Dim logW As IO.StreamWriter
        Dim logPath As String = "LOG\"
        Dim fileName As String
        Dim enumerator As IDictionaryEnumerator
        Dim strLog As StringBuilder
        Dim i As Integer

        Try
            '「EXE」パスを取得する
            logPath = My.Application.Info.DirectoryPath & "\" & logPath

            strLog = New StringBuilder

            'LOG出力を判断する
            Select Case intLogType
                Case 1
                Case 2
                    If PFn_NullToString(ConfigInfo.LOGSQLFlg).Equals("0") Then
                        Exit Sub
                    End If
                Case 3
                    If PFn_NullToString(ConfigInfo.LOGExceptionFlg).Equals("0") Then
                        Exit Sub
                    End If
                Case 4
                    If PFn_NullToString(ConfigInfo.LOGTransactionFlg).Equals("0") Then
                        Exit Sub
                    End If
            End Select

            'ファイル名をセットする
            fileName = Now.ToString("yyyyMMdd") & ".txt"

            'フォルダの存在を判断する
            If IO.Directory.Exists(logPath) = False Then
                'フォルダを新規する
                IO.Directory.CreateDirectory(logPath)
            End If

            'LOGファイルを開く
            ' , System.Text.Encoding.GetEncoding("shift-jis")
            logW = New IO.StreamWriter(logPath & fileName, True, System.Text.Encoding.GetEncoding("shift-jis"))

            'LOG内容をセットする
            logW.WriteLine()

            'Dim strAry As String() = PFn_NullToString(ConfigInfo.DBConnectionString).Split(";")
            'If PFn_NullToString(ConfigInfo.DBConnectionString) <> "" Then
            '    Dim strAry1 As String() = strAry(0).Split("=")
            '    Dim strAry2 As String() = strAry(1).Split("=")

            '    If PFn_NullToString(ConfigInfo.DBConnectionString).Split(";").Length > 0 Then
            '        logW.WriteLine(Format(Now, "yyyy-MM-dd HH:mm:ss.fff").ToString & "-----------------------------------------------" _
            '                                      & "【" & strAry1(1) & "】" & ":" _
            '                                      & "【" & strAry2(1) & "】" & ":" _
            '                                      & "【" & LoginInfo.UserID & "】" & ":" _
            '                                      & "【" & LoginInfo.UserName & "】" & ":" _
            '                                      & "【" & LoginInfo.UserPC & "】" & ":" _
            '                                      & "【" & LoginInfo.UserIP & "】")
            '    Else
            '        logW.WriteLine(Format(Now, "yyyy-MM-dd HH:mm:ss.fff").ToString & "-----------------------------------------------")
            '    End If
            'Else
            logW.WriteLine(Format(Now, "yyyy-MM-dd HH:mm:ss.fff").ToString & "-----------------------------------------------")
            'End If

            'LOG内容を判断する
            Select Case intLogType
                Case 1
                Case 2
                    If htPara Is Nothing AndAlso _
                    (strLogInfo.Contains("パスワード") = False AndAlso _
                    strLogInfo.ToUpper.Contains("PASSWORD") = False) Then

                        logW.WriteLine("SQL文:")
                        logW.WriteLine(strLogInfo)
                    Else

                        If Not htPara Is Nothing Then
                            '臨時オブジェクトを変化する
                            enumerator = htPara.GetEnumerator
                            '臨時SQL文をセットする
                            strLog.Append(PFn_NullToString(strLogInfo))

                            Dim arrSort(htPara.Count - 1) As String
                            htPara.Keys().CopyTo(arrSort, 0)
                            Array.Sort(arrSort, New SortBySizeDesc)

                            '項目をループする
                            While enumerator.MoveNext()
                                '変数を変換する
                                strLog = strLog.Replace("@" & PFn_NullToString(arrSort(i)), _
                                                        "'" & PFn_NullToString(htPara.Item(arrSort(i))) & "'")
                                i = i + 1
                            End While

                            logW.WriteLine(strLog)
                        Else
                            logW.WriteLine("SQL文:")
                            logW.WriteLine(strLogInfo)
                        End If

                    End If
                Case 3
                    logW.WriteLine("异常:")
                    logW.WriteLine(strLogInfo)
                Case 4
                    logW.WriteLine("事务处理:" & "-----------------------" & strLogInfo)
            End Select

            '释放
            logW.Close()
            logW.Dispose()
            logW = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PSb_WriteLOGFile(ByVal intLogType As Integer)
        Dim logW As IO.StreamWriter
        Dim logPath As String = "LOG\"
        Dim fileName As String

        Try
            '「EXE」パスを取得する
            logPath = My.Application.Info.DirectoryPath & "\" & logPath

            'LOG出力を判断する
            Select Case intLogType
                Case 1
                    'If ConfigInfo.LOGFormFlg.Equals("0") Then
                    '    Exit Sub
                    'End If
                Case 2
                    If ConfigInfo.LOGSQLFlg.Equals("0") Then
                        Exit Sub
                    End If
                Case 3
                    If ConfigInfo.LOGExceptionFlg.Equals("0") Then
                        Exit Sub
                    End If
                Case 4
                    If ConfigInfo.LOGTransactionFlg.Equals("0") Then
                        Exit Sub
                    End If
            End Select

            'ファイル名をセットする
            fileName = Now.ToString("yyyyMMdd") & ".txt"

            'フォルダの存在を判断する
            If IO.Directory.Exists(logPath) = False Then
                'フォルダを新規する
                IO.Directory.CreateDirectory(logPath)
            End If

            'LOGファイルを開く
            logW = New IO.StreamWriter(logPath & fileName, True, System.Text.Encoding.GetEncoding("shift-jis"))

            'LOG内容をセットする
            logW.WriteLine()

            'LOG内容を判断する
            Select Case intLogType
                Case 1
                    logW.WriteLine("@@-OpenDB:")
                    logW.WriteLine(Now.ToString() & " " & My.Computer.Name & "===================================================")
                Case 2
                    logW.WriteLine("CloseDB-@@:")
                    logW.WriteLine(Now.ToString() & " " & My.Computer.Name & "===================================================")
                    logW.WriteLine()

            End Select

            '解放する
            logW.Close()
            logW.Dispose()
            logW = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PSb_WriteLOGFileSQL(ByVal intLogType As Integer, _
                                       ByVal strLogInfo As String, _
                                       Optional ByVal paras() As SqlParameter = Nothing)
        Dim logW As IO.StreamWriter
        Dim logPath As String = "LOG\"
        Dim fileName As String
        Dim strLog As String
        Try
            '「EXE」パスを取得する
            logPath = My.Application.Info.DirectoryPath & "\" & logPath

            'LOG出力を判断する
            Select Case intLogType
                Case 1
                Case 2
                    If PFn_NullToString(ConfigInfo.LOGSQLFlg).Equals("0") Then
                        Exit Sub
                    End If
                Case 3
                    If PFn_NullToString(ConfigInfo.LOGExceptionFlg).Equals("0") Then
                        Exit Sub
                    End If
                Case 4
                    If PFn_NullToString(ConfigInfo.LOGTransactionFlg).Equals("0") Then
                        Exit Sub
                    End If
            End Select

            'ファイル名をセットする
            fileName = Now.ToString("yyyyMMdd") & ".txt"

            'フォルダの存在を判断する
            If IO.Directory.Exists(logPath) = False Then
                'フォルダを新規する
                IO.Directory.CreateDirectory(logPath)
            End If

            'LOGファイルを開く
            logW = New IO.StreamWriter(logPath & fileName, True, System.Text.Encoding.GetEncoding("shift-jis"))

            'LOG内容をセットする
            logW.WriteLine()
            logW.WriteLine(Now.ToString() & "-----------------------------------------------")

            'LOG内容を判断する
            Select Case intLogType
                Case 1
                    logW.WriteLine("画面:")
                Case 2
                    If paras Is Nothing Then
                        logW.WriteLine("SQL文:")
                        logW.WriteLine(strLogInfo)
                    Else
                        strLog = strLogInfo
                        '項目をループする
                        For i = 0 To paras.Length - 1
                            '変数を変換する
                            strLog = strLog & "," & PFn_ToString(paras(i).Value) & ","
                        Next

                        logW.WriteLine(strLog)
                    End If
                Case 3
                    logW.WriteLine("異常:")
                    logW.WriteLine(strLogInfo)

                Case 9

                    logW.WriteLine(strLogInfo)

            End Select

            '解放する
            logW.Close()
            logW.Dispose()
            logW = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PSb_ThrowError(ByVal ex As Exception)

        Dim strPath As String
        Dim strFile As String
        Dim strUSER_ID As String = String.Empty
        Dim objStreamLog As StreamWriter
        Dim strMark As String
        Dim strFormFileName As String

        strMark = "***********************************************"
        strFormFileName = ex.Message

        '「EXE」パスを取得する
        strPath = Configuration.PFn_GetAppConfigValue("PATH_LOG")

        If gObjM_人员T.人员编号 <> String.Empty Then
            strUSER_ID = "[" & gObjM_人员T.人员编号 & "]"
        End If

        strFile = My.Application.Info.DirectoryPath & strPath & "ERR_" & strUSER_ID & _
                  "[" & Format(Utility.PFn_GetDBTime, Constant.cgstrDATE_FORMATDAY5) & "]_Log.txt"

        If Not System.IO.Directory.Exists(strPath) Then
            Directory.CreateDirectory(strPath)
        End If

        objStreamLog = New StreamWriter(strFile, True, System.Text.Encoding.GetEncoding("Shift_JIS"))

        objStreamLog.WriteLine(strMark)
        objStreamLog.WriteLine("作成日時：" & Format(Utility.PFn_GetDBTime, Constant.cgstrDATE_FORMATDAY6))
        objStreamLog.WriteLine("作成者  ：" & gObjM_人员T.人员编号 & " " & gObjM_人员T.人员名)
        objStreamLog.WriteLine(strMark)

        objStreamLog.WriteLine("エラー内容：" & ex.ToString)
        objStreamLog.WriteLine("エラー場所：" & strFormFileName)

        objStreamLog.Close()

    End Sub

    'LOGファイルが存在
    Public Shared Sub PSb_CSVCheckLOGFile(ByVal strLogFilePath As String)
        Dim logPath As String = "LOG\"
        Dim fileName As String = String.Empty
        Dim strLogPath As String = String.Empty
        Dim strLogFile As String = String.Empty

        Dim strLogOutFilePath As String = String.Empty
        Try

            strLogPath = System.IO.Path.GetDirectoryName(strLogFilePath)
            strLogPath = strLogPath & "\" & logPath
            strLogOutFilePath = strLogPath

            'フォルダの存在を判断する
            If IO.Directory.Exists(strLogPath) = False Then
                'フォルダを新規する
                IO.Directory.CreateDirectory(strLogPath)
            End If

            strLogFile = System.IO.Path.GetFileName(strLogFilePath)
            strLogFile = strLogFile.Substring(0, strLogFile.LastIndexOf(".")).ToLower().Trim()
            'ファイル名をセットする
            fileName = strLogFile & ".log"     'Now.ToString("yyyyMMdd") & 

            strLogOutFilePath = strLogPath & fileName

            '***************ファイルを削除****************
            If System.IO.File.Exists(strLogOutFilePath) Then
                System.IO.File.Delete(strLogOutFilePath)
            End If
            '***************ファイルを削除****************
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub PSb_CSVWriteLOGFile(ByVal strLogFilePath As String, _
                                          ByVal intRow As Integer, _
                                          ByVal intCol As Integer, _
                                          Optional ByVal intLogType As Integer = 1, _
                                          Optional ByVal strCSVMessage As String = "", _
                                          Optional ByRef strLogOutFilePath As String = "")
        Dim logW As IO.StreamWriter
        Dim logPath As String = "LOG\"
        Dim fileName As String = String.Empty
        Dim strLogPath As String = String.Empty
        Dim strLogFile As String = String.Empty

        Try

            strLogPath = System.IO.Path.GetDirectoryName(strLogFilePath)
            strLogPath = strLogPath & "\" & logPath
            strLogOutFilePath = strLogPath

            'フォルダの存在を判断する
            If IO.Directory.Exists(strLogPath) = False Then
                'フォルダを新規する
                IO.Directory.CreateDirectory(strLogPath)
            End If

            strLogFile = System.IO.Path.GetFileName(strLogFilePath)
            strLogFile = strLogFile.Substring(0, strLogFile.LastIndexOf(".")).ToLower().Trim()
            'ファイル名をセットする
            fileName = strLogFile & ".log"     'Now.ToString("yyyyMMdd") & 

            strLogOutFilePath = strLogPath & fileName

            'LOGファイルを開く
            logW = New IO.StreamWriter(strLogOutFilePath, True, System.Text.Encoding.GetEncoding("shift-jis"))

            'LOG内容をセットする
            logW.WriteLine()

            'LOG内容を判断する
            Select Case intLogType
                Case 1
                    '「行位置：\1、列位置：\2のデータが無効です。」：\1＝ファイル行数、\2＝チェックカラム位置
                    logW.WriteLine(" 行位置： " & intRow & "、列位置：" & intCol & "のデータが無効です。")
                Case 2
                    '「行位置：\1　商品CDが商品マスタに存在しません。」：\1＝ファイル行数
                    logW.WriteLine(" 行位置： " & intRow & "商品CDが商品マスタに存在しません。")
                Case 3
                    '「行位置：\1　適用開始日は\2よりも未来の日付である必要があります。」
                    '：\1＝ファイル行数、\2＝MAX（M商品単価履歴．適用開始日（条件：商品CD（3カラム目））
                    logW.WriteLine(" 行位置： " & intRow & "適用開始日は" & strCSVMessage & "よりも未来の日付である必要があります。")
                Case 4
                    logW.WriteLine(" " & "-----------------------")
                Case 5
                    '「行位置：\1　商品CDが外部マスタに存在しません。」：\1＝ファイル行数
                    logW.WriteLine(" 行位置： " & intRow & "商品CDが外部マスタに存在しません。")
                Case 6
                    '「行位置：\1　適用期間が重複しています。」：\1＝ファイル行数
                    logW.WriteLine(" 行位置： " & intRow & "適用期間が重複しています。")
                Case 7
                    '「行位置：\1　受注日が商品の販売ディスコン日を超えています。」：\1＝ファイル行数
                    logW.WriteLine(" 行位置： " & intRow & "受注日が商品の販売ディスコン日を超えています。")

                Case 8
                    '「行位置：\1　売上数量を満たす委託残のある出荷が特定できません。」：\1＝ファイル行数
                    logW.WriteLine(" 行位置： " & intRow & "売上数量を満たす委託残のある出荷が特定できません。")

                Case 9
                    '「行位置：\1　単価が無効です。受注時単価、売上時単価、商品単価のいずれとも一致しません。」：\1＝ファイル行数
                    logW.WriteLine(" 行位置： " & intRow & "単価が無効です。受注時単価、売上時単価、商品単価のいずれとも一致しません。")

            End Select

            '解放する
            logW.Close()
            logW.Dispose()
            logW = Nothing

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "対象のソート"

    ''' <summary>
    ''' 文字長さでソート(昇順)
    ''' </summary>
    ''' <remarks>ソート用</remarks>
    Public Class SortBySizeAsc
        Implements IComparer

        Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
           Implements IComparer.Compare
            Return New CaseInsensitiveComparer().Compare(x.ToString.Length, y.ToString.Length)
        End Function

    End Class

    ''' <summary>
    ''' 文字長さでソート(降順)
    ''' </summary>
    ''' <remarks>ソート用</remarks>
    Public Class SortBySizeDesc
        Implements IComparer

        Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
           Implements IComparer.Compare
            Return New CaseInsensitiveComparer().Compare(y.ToString.Length, x.ToString.Length)
        End Function

    End Class

    ''' <summary>
    ''' 文字でソート(昇順)
    ''' </summary>
    ''' <remarks>ソート用</remarks>
    Public Class SortByCharAsc
        Implements IComparer
        Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
           Implements IComparer.Compare
            Return New CaseInsensitiveComparer().Compare(x, y)
        End Function
    End Class

    ''' <summary>
    ''' 文字でソート(降順)
    ''' </summary>
    ''' <remarks>ソート用</remarks>
    Public Class SortByCharDesc
        Implements IComparer
        Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
           Implements IComparer.Compare
            Return New CaseInsensitiveComparer().Compare(y, x)
        End Function
    End Class

#End Region

#Region "NULLを文字列に変化する"

    ''' <summary>
    ''' 文字列に変化する
    ''' </summary>
    ''' <param name="objValue">変化前に文字</param>
    ''' <returns>対象　または　文字列</returns>
    ''' <remarks>文字列に変化する</remarks>
    Public Shared Function PFn_NullToString(ByVal objValue As Object) As String
        If objValue Is Nothing OrElse Information.IsDBNull(objValue) Then
            Return String.Empty
        Else
            Try
                PFn_NullToString = Convert.ToString(objValue)
            Catch ex As Exception
                Return String.Empty
            End Try
        End If
    End Function

    Public Shared Function PFn_NullToZero(ByVal objValue As Object) As Object
        If objValue Is Nothing OrElse Information.IsDBNull(objValue) Then
            Return 0
        Else
            Return objValue
        End If
    End Function

    Public Shared Function PFn_EmptyToZero(ByVal objValue As Object) As Object
        If objValue Is Nothing OrElse _
            Information.IsDBNull(objValue) OrElse _
             objValue.ToString.Equals(String.Empty) Then
            Return 0
        Else
            Return objValue
        End If
    End Function

#End Region

#Region " PSb_GetPermission"

    'True:権限がある
    'False：権限がない
    Public Shared Function PSb_GetPermission(ByVal strValue As String, _
                                             Optional ByRef int権限フラグ As Integer = 0) As Boolean

        Dim blnReturn As Boolean = False
        Dim strSql As New StringBuilder(String.Empty)
        Dim objDbHelper As DbHelper = Nothing
        Dim strMethodName As String = "Utility.PSb_GetPermission"
        Dim dt権限 As DataTable

        Try
            strSql.AppendLine(" SELECT  " & vbCrLf)
            strSql.AppendLine(" 権限フラグ " & vbCrLf)
            strSql.AppendLine(" FROM M_担当者 " & vbCrLf)
            strSql.AppendLine(" LEFT JOIN vm権限明細 " & vbCrLf)
            strSql.AppendLine(" ON M_担当者.権限コード = vm権限明細.権限コード ")
            strSql.AppendLine(" WHERE 1=1  " & vbCrLf)
            strSql.AppendLine(" AND 担当者コード = '" & LoginInfo.UserID & "'")
            strSql.AppendLine(" AND 権限明細コード = '" & strValue & "'")
            strSql.AppendLine(" AND (権限フラグ = 0 OR 権限フラグ = 1)")

            objDbHelper = New DbHelper

            dt権限 = objDbHelper.PFn_FillDataTable(strSql.ToString)

            If dt権限.Rows.Count > 0 Then
                int権限フラグ = dt権限.Rows(0).Item("権限フラグ")

                If int権限フラグ = 1 Then
                    blnReturn = True
                Else
                    blnReturn = False
                End If
            Else
                blnReturn = True
            End If
            'データベース接続を切断する
            objDbHelper.PSb_CloseDB()

            Return blnReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(objDbHelper)
            Throw New Exception(strMethodName, ex)

        End Try

    End Function

#End Region

#Region " PFn_GetAuth"

    '権限
    Public Shared Function PFn_GetAuth(ByVal strTag As String) As Boolean

        Dim objDbConn As DbHelper
        Dim strSql As New StringBuilder(String.Empty)           'SQL文 
        Dim intFlg As Integer
        Dim bln権限 As Boolean = False

        '検索

        'データベースConnet
        objDbConn = New DbHelper

        'SQL文 
        strSql.Append(" SELECT " & vbCrLf)
        strSql.Append("     1" & vbCrLf)
        strSql.Append(" FROM " & vbCrLf)
        strSql.Append("    M人员权限" & vbCrLf)
        strSql.Append(" WHERE " & vbCrLf)
        strSql.AppendFormat("    人员编号={0}" & vbCrLf, PFn_ChangeQuotation(gObjM_人员T.人员编号))
        strSql.AppendFormat(" AND 菜单区分={0}" & vbCrLf, PFn_ChangeQuotation(strTag))

        'Guid 
        intFlg = objDbConn.PFn_ExcuteScalar(strSql.ToString)

        'データベースClose
        objDbConn.PSb_CloseDB()

        Return intFlg

    End Function

#End Region

#Region "PFN_Round"
    '-------------------------------------------------------
    '関数名
    '   FN_Round
    '概要
    '   データの端数処理
    'パラメタ説明
    '   パラメタ名：(In)  decKin -> 処理のデータ(Input金額)
    '   パラメタ名：(In)  intHasuCd -> 端数処理区分CD
    '   パラメタ名：(In)  intKeta -> 小数点の桁の数
    '戻り値
    '   Decimal：処理の後のデータ
    '作成者   
    '    蔡　挺   [2008-11-10] V1.0.1
    '更新者
    '   なし
    '-------------------------------------------------------
    Public Shared Function PFN_Round(ByVal dblWork As Decimal, _
                                    Optional ByVal intWork As Integer = 0) As Decimal

        Dim strWork As String
        Dim intPoint As Integer

        If dblWork = 0 Then
            Return dblWork
        Else
            strWork = dblWork.ToString
            intPoint = strWork.IndexOf(".")

            If intPoint <> -1 Then
                strWork = strWork.Substring(intPoint, strWork.Length - intPoint)
            Else
                If intWork = 0 Then
                    Return dblWork
                End If
            End If

            If intWork = 0 Then

                intPoint = strWork.IndexOf(".")

                If intPoint = 0 Then
                    strWork = "0" & strWork.Substring(0, 2)
                Else
                    strWork = strWork.Substring(0, 3)
                End If

                If CType(strWork, Decimal) >= 0.5 Then
                    dblWork = Math.Floor(dblWork) + 1
                Else
                    dblWork = Math.Floor(dblWork)
                End If

                Return dblWork
            Else
                If strWork.Length <= 2 Then
                    dblWork = dblWork + 5 / (10 ^ (intWork + strWork.Length + 2))
                Else
                    dblWork = dblWork + 5 / (10 ^ (intWork + strWork.Length - 1))
                End If

                Return Math.Round(dblWork, intWork)

            End If

        End If

    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="decKin"></param>
    ''' <param name="int端数区分"></param>
    ''' <param name="intKeta"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' <EditAuthor>gaoheze</EditAuthor>
    ''' <EditTime>2014-02-26</EditTime>
    Public Shared Function PFn_Round(ByVal decKin As Decimal, ByVal int端数区分 As Integer, ByVal intKeta As Integer) As Decimal

        Dim dblSum As Decimal

        dblSum = 10 ^ intKeta

        Select Case int端数区分
            Case Enum_金額端数区分.四捨五入  '1：四捨五入
                If decKin < 0 Then
                    Return Utility.PFN_Round(System.Math.Abs(decKin), intKeta) * -1
                Else
                    Return Utility.PFN_Round(decKin, intKeta)
                End If

            Case Enum_金額端数区分.切り捨て  '2：切り捨て
                Return Math.Floor(decKin * dblSum) / dblSum

            Case Enum_金額端数区分.切り上げ  '3：切り上げ
                Return Math.Ceiling(decKin * dblSum) / dblSum

            Case Else
                Return decKin

        End Select

    End Function

#End Region

#Region "PFn_SetCombo"

#Region " SelectDigits"

    '-----------------------------------------------------------------------------
    '  概要
    '    桁数を取る
    '  パラメタ説明
    '   ViewNm               :View名称
    '  機能説明
    '   なし
    '  戻り値
    '    Integer
    '  作成者
    '     
    '  備考
    '
    '-----------------------------------------------------------------------------
    Public Shared Function SelectDigits(ByVal ViewNm As String, ByVal objDbHelper As DbHelper) As Integer

        '▼変数定義
        Const cstrMethodName As String = "Utility.SelectDigits"     'メソッド名称
        Dim dt As New DataTable
        Dim intLength As Integer = 0
        Dim strWhere As String = String.Empty
        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            Dim int As Integer = 0

            Select Case ViewNm.Substring(0, 2)

                Case "ＮＭ"

                    strWhere = ViewNm.Replace("ＮＭ", "") & "区分"

                Case "ＦＬ"

                    strWhere = ViewNm.Replace("ＦＬＧ", "") & "フラグ"

            End Select

            'For Each FieldInfo In gobjM_Ｓ管理.GetType.GetFields

            '    If FieldInfo.Name = strWhere Then
            '        intLength = FieldInfo.GetValue(gobjM_Ｓ管理)
            '        Exit For
            '    End If
            'Next

            strSql = New StringBuilder(System.String.Empty)    'Sql文

            strSql.Append(" Select ")
            strSql.Append(" 桁数 ")

            'テーブル
            strSql.Append(" From M管理 ")
            strSql.Append(" WHERE 管理区分= '" & strWhere & "'" & vbCrLf)

            dt = objDbHelper.PFn_FillDataTable(strSql.ToString)

            If dt.Rows.Count > 0 Then
                intLength = dt.Rows(0).Item(0)
            End If

            Return intLength

        Catch ex As Exception
            Throw New Exception(cstrMethodName, ex)
        End Try

    End Function

#End Region

    Public Shared Function PFn_SetCombo(ByVal cboTarget As Infragistics.Win.UltraWinEditors.UltraComboEditor, _
                                        ByVal ViewNm As String, _
                                        Optional ByVal blankFlg As Integer = 0) As Boolean

        Dim intLength As Integer = 0
        Dim intLengthLast As Integer = 0
        Dim i As Integer
        Dim objDbHelper As New DbHelper
        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Dim dt As DataTable
        Dim strMethodName As String = "Utility.PFn_SetCombo"

        Try

            cboTarget.DataSource = Nothing
            cboTarget.Items.Clear()

            strSql.Append(" Select ")
            strSql.Append(" 区分,")
            strSql.Append(" 名称 AS DisplayText ")

            'テーブル
            strSql.Append(" From ")
            strSql.Append(" " & ViewNm & "")                                        'システム管理マスタ

            strSql.Append(" ORDER BY CONVERT(INT,表示順) ,区分")

            dt = objDbHelper.PFn_FillDataTable(strSql.ToString)

            If dt.Rows.Count <> 0 Then

                If blankFlg = 1 Then
                    cboTarget.Items.Add(" ", "  ")
                End If

                For i = 0 To dt.Rows.Count - 1

                    If dt.Rows(i).Item(1).ToString.Trim.Equals(String.Empty) Then
                        cboTarget.Items.Add(dt.Rows(i).Item(0), " ")
                    Else
                        cboTarget.Items.Add(dt.Rows(i).Item(0), dt.Rows(i).Item(1).ToString)

                        'テキストの文字列の長さを取得する
                        intLength = System.Text.Encoding.Default.GetByteCount(dt.Rows(i).Item(1).ToString.Trim)

                        If intLength > intLengthLast Then
                            intLengthLast = intLength
                        End If
                    End If
                Next i

            End If

            cboTarget.SelectedIndex = 0

            If cboTarget.Width <= 8.2 * intLengthLast Then
                cboTarget.DropDownListWidth = 8.2 * intLengthLast
            Else
                cboTarget.DropDownListWidth = cboTarget.Width
            End If

            objDbHelper.PSb_CloseDB()

            Return True

        Catch ex As Exception

            If Not objDbHelper Is Nothing Then
                objDbHelper.PSb_CloseDB()
            End If

            Return False
        End Try

    End Function

    Public Shared Function PFn_SetCombo(ByVal cboTarget As Infragistics.Win.UltraWinGrid.UltraCombo, _
                                        ByVal strTableNm As String, _
                                        Optional ByVal blankFlg As Integer = 0) As Boolean

        Dim objDbHelper As New DbHelper
        Dim strSql As New StringBuilder
        Dim dt As DataTable
        Dim strMethodName As String = "Utility.PFn_SetCombo"
        Dim intCdLength As Integer = 0
        Dim intCdLengthLast As Integer = 0
        Dim isSuccess As Boolean = False

        Try

            cboTarget.DataSource = Nothing

            strSql.Append(" Select ")
            strSql.Append(" 区分,")
            strSql.Append(" 名称  ")

            'テーブル
            strSql.AppendLine(" From ")
            strSql.AppendLine(strTableNm & " ")
            strSql.Append(" ORDER BY CONVERT(INT,顺序) ,区分")

            dt = objDbHelper.PFn_FillDataTable(strSql.ToString)

            If dt.Rows.Count > 0 Then
                isSuccess = True
            Else
                isSuccess = False
            End If

            If blankFlg = 1 Then
                Dim dr As DataRow
                dr = dt.NewRow
                dt.Rows.InsertAt(dr, 0)
            End If

            cboTarget.DataMember = dt.TableName
            cboTarget.DataSource = dt

            cboTarget.ValueMember = "区分"
            cboTarget.DisplayMember = "名称"
            cboTarget.DropDownStyle = UltraComboStyle.DropDownList
            cboTarget.DisplayLayout.Grid.DisplayLayout.ScrollBounds = ScrollBounds.ScrollToFill
            cboTarget.DisplayLayout.Bands(0).Columns("区分").Width = 50
            cboTarget.DisplayLayout.Bands(0).Columns("名称").Width = 150
            cboTarget.DisplayLayout.Grid.DisplayLayout.Override.HotTrackRowAppearance.BackColor = System.Drawing.SystemColors.Highlight
            cboTarget.DisplayLayout.Grid.DisplayLayout.Override.HotTrackRowAppearance.ForeColor = Color.White
            cboTarget.DisplayLayout.Grid.DisplayLayout.Override.SelectedRowAppearance.BackColor = Color.White
            cboTarget.DisplayLayout.Grid.DisplayLayout.Override.SelectedRowAppearance.ForeColor = Color.Black

            objDbHelper.PSb_CloseDB()

            Return isSuccess

        Catch ex As Exception
            Throw New Exception(strMethodName, ex)
        End Try

    End Function

    Public Shared Function CheckcomboValue(ByVal strTableNm As String, ByVal intCount As Integer) As Boolean

        Dim objDbHelper As New DbHelper
        Dim strSql As New StringBuilder
        Dim dt As DataTable
        Dim strMethodName As String = "Utility.CheckcomboValue"
        Dim isSuccess As Boolean = False

        Try

            strSql.Append(" Select ")
            strSql.Append(" 区分,")
            strSql.Append(" 名称  ")

            'テーブル
            strSql.AppendLine(" From ")
            strSql.AppendLine(strTableNm & " ")
            strSql.Append(" ORDER BY CONVERT(INT,顺序) ,区分")

            dt = objDbHelper.PFn_FillDataTable(strSql.ToString)

            If dt.Rows.Count = intCount Then
                isSuccess = True
            Else
                isSuccess = False
            End If

            Return isSuccess

        Catch ex As Exception
            Throw New Exception(strMethodName, ex)
        End Try

    End Function
    Public Shared Function PFn_SetGirdCombo(ByVal gridTarget As UserControl.UCGridEdit, _
                                           ByVal strTableNm As String, _
                                           ByVal intColumnIndex As Integer) As Boolean

        Dim objDbHelper As New DbHelper
        Dim strSql As New StringBuilder
        Dim dt As DataTable
        Dim strMethodName As String = "Utility.PFn_SetGirdCombo"
        Dim intCdLength As Integer = 0
        Dim intCdLengthLast As Integer = 0
        Dim isSuccess As Boolean = False

        Try
            Dim vl As New Infragistics.Win.ValueList
            'gridTarget.DataSource = Nothing

            strSql.Append(" Select ")
            strSql.Append(" 区分,")
            strSql.Append(" 名称  ")

            'テーブル
            strSql.AppendLine(" From ")
            strSql.AppendLine(strTableNm & " ")
            strSql.Append(" ORDER BY CONVERT(INT,顺序) ,区分")

            dt = objDbHelper.PFn_FillDataTable(strSql.ToString)

            If dt.Rows.Count > 0 Then
                isSuccess = True
            Else
                isSuccess = False
            End If

            'If blankFlg = 0 Then
            '    Dim dr As DataRow
            '    dr = dt.NewRow
            '    dr("区分") = ""
            '    dt.Rows.InsertAt(dr, 0)
            'End If

            'cboTarget.DataMember = dt.TableName
            'cboTarget.DataSource = dt

            'cboTarget.ValueMember = "区分"
            'cboTarget.DisplayMember = "名称"
            'cboTarget.DropDownStyle = UltraComboStyle.DropDownList
            'cboTarget.DisplayLayout.Grid.DisplayLayout.ScrollBounds = ScrollBounds.ScrollToFill
            'cboTarget.DisplayLayout.Bands(0).Columns("区分").Width = 50
            'cboTarget.DisplayLayout.Bands(0).Columns("名称").Width = 150
            'cboTarget.DisplayLayout.Grid.DisplayLayout.Override.HotTrackRowAppearance.BackColor = System.Drawing.SystemColors.Highlight
            'cboTarget.DisplayLayout.Grid.DisplayLayout.Override.HotTrackRowAppearance.ForeColor = Color.White
            'cboTarget.DisplayLayout.Grid.DisplayLayout.Override.SelectedRowAppearance.BackColor = Color.White
            'cboTarget.DisplayLayout.Grid.DisplayLayout.Override.SelectedRowAppearance.ForeColor = Color.Black
            Dim intLoopi As Integer

            For intLoopi = 0 To dt.Rows.Count - 1
                vl.ValueListItems.Add(dt.Rows(intLoopi).Item(0), dt.Rows(intLoopi).Item(1))
            Next intLoopi

            gridTarget.DisplayLayout.Bands(0).Columns(intColumnIndex).Style = ColumnStyle.DropDownList
            gridTarget.DisplayLayout.Bands(0).Columns(intColumnIndex).ValueList = vl
            gridTarget.DisplayLayout.Bands(0).Columns(intColumnIndex).ValueList.SelectedItemIndex = 0

            objDbHelper.PSb_CloseDB()

            Return isSuccess

        Catch ex As Exception
            Throw New Exception(strMethodName, ex)
        End Try
    End Function

    Public Shared Function PFn_SetCombo(ByVal cboTarget As Infragistics.Win.UltraWinEditors.UltraComboEditor, _
                                        ByVal strCd As String, _
                                        ByVal strName As String, _
                                        ByVal strTableNm As String, _
                                        Optional ByVal blankFlg As Integer = 0, _
                                        Optional ByVal strWhere As String = "", _
                                        Optional ByVal strOrderBy As String = "") As Boolean

        Dim intLength As Integer = 0
        Dim intLengthLast As Integer = 0
        Dim i As Integer
        Dim objDbHelper As New DbHelper
        Dim strSql As String
        Dim dt As DataTable
        Dim strMethodName As String = "Utility.PFn_SetCombo"

        Try

            cboTarget.DataSource = Nothing
            cboTarget.Items.Clear()

            strSql = ""
            strSql = strSql & " SELECT  "

            strSql = strSql & strCd & ","
            strSql = strSql & strName

            'テーブル
            strSql = strSql & " From "
            strSql = strSql & strTableNm & " "

            If strWhere <> "" Then
                strSql = strSql & strWhere & ""
            End If

            If strOrderBy <> "" Then
                strSql = strSql & " ORDER BY " & strOrderBy & " "
            End If

            dt = objDbHelper.PFn_FillDataTable(strSql)

            If dt.Rows.Count <> 0 Then

                If blankFlg = 1 Then
                    cboTarget.Items.Add(" ", "  ")
                End If

                For i = 0 To dt.Rows.Count - 1

                    If dt.Rows(i).Item(1).ToString.Trim.Equals(String.Empty) Then
                        cboTarget.Items.Add(dt.Rows(i).Item(0), " ")
                    Else
                        cboTarget.Items.Add(dt.Rows(i).Item(0), dt.Rows(i).Item(1).ToString)

                        'テキストの文字列の長さを取得する
                        intLength = System.Text.Encoding.Default.GetByteCount(dt.Rows(i).Item(1).ToString.Trim)

                        If intLength > intLengthLast Then
                            intLengthLast = intLength
                        End If
                    End If
                Next i

            End If

            cboTarget.SelectedIndex = 0

            If cboTarget.Width <= 8.2 * intLengthLast Then
                cboTarget.DropDownListWidth = 8.2 * intLengthLast
            Else
                cboTarget.DropDownListWidth = cboTarget.Width
            End If

            objDbHelper.PSb_CloseDB()

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared Function PFn_SetCombo(ByVal cboTarget As Infragistics.Win.UltraWinGrid.UltraCombo, _
                                        ByVal strCd As String, _
                                        ByVal strName As String, _
                                        ByVal strTableNm As String, _
                                        Optional ByVal blankFlg As Integer = 0, _
                                        Optional ByVal strWhere As String = "", _
                                        Optional ByVal strOrderBy As String = "", _
                                        Optional ByVal intNumWidth As Integer = 50, _
                                        Optional ByVal intColWidth As Integer = 150) As Boolean

        Dim objDbHelper As New DbHelper
        Dim strBuilder As New StringBuilder
        Dim dt As DataTable
        Dim strMethodName As String = "Utility.PFn_SetCombo"
        Dim intCdLength As Integer = 0
        Dim intCdLengthLast As Integer = 0
        Dim isSuccess As Boolean = False

        Try

            cboTarget.DataSource = Nothing


            strBuilder.AppendLine(" SELECT  ")

            strBuilder.AppendLine(strCd & ",")
            strBuilder.AppendLine(strName)

            'テーブル
            strBuilder.AppendLine(" From ")
            strBuilder.AppendLine(strTableNm & " ")

            If Not String.IsNullOrEmpty(strWhere) Then
                strBuilder.AppendLine(strWhere & " ")
            End If

            If Not String.IsNullOrEmpty(strOrderBy) Then
                strBuilder.AppendLine(" ORDER BY " & strOrderBy & " ")
            End If

            dt = objDbHelper.PFn_FillDataTable(strBuilder.ToString)

            If dt.Rows.Count > 0 Then
                isSuccess = True
            Else
                isSuccess = False
            End If

            If blankFlg = 1 Then
                Dim dr As DataRow
                dr = dt.NewRow
                dt.Rows.InsertAt(dr, 0)
            End If

            cboTarget.DataMember = dt.TableName
            cboTarget.DataSource = dt

            cboTarget.ValueMember = strCd
            cboTarget.DisplayMember = strName
            cboTarget.DropDownStyle = UltraComboStyle.DropDown
            cboTarget.DisplayLayout.Grid.DisplayLayout.ScrollBounds = ScrollBounds.ScrollToFill
            cboTarget.DisplayLayout.Bands(0).Columns(strCd).Width = intNumWidth
            cboTarget.DisplayLayout.Bands(0).Columns(strName).Width = intColWidth
            cboTarget.DisplayLayout.Grid.DisplayLayout.Override.HotTrackRowAppearance.BackColor = System.Drawing.SystemColors.Highlight
            cboTarget.DisplayLayout.Grid.DisplayLayout.Override.HotTrackRowAppearance.ForeColor = Color.White
            cboTarget.DisplayLayout.Grid.DisplayLayout.Override.SelectedRowAppearance.BackColor = Color.White
            cboTarget.DisplayLayout.Grid.DisplayLayout.Override.SelectedRowAppearance.ForeColor = Color.Black

            objDbHelper.PSb_CloseDB()

            Return isSuccess

        Catch ex As Exception
            Throw New Exception(strMethodName, ex)
        End Try

    End Function

    Public Shared Sub PFn_SetComboFromM管理詳細ByWhere(ByVal cboTarget As Infragistics.Win.UltraWinEditors.UltraComboEditor, ByVal strWhere As String)

        Dim intLength As Integer = 0
        'Dim intLengthLast As Integer = 0
        'Dim i As Integer
        Dim objDbHelper As New DbHelper
        Dim strSql As String = String.Empty
        Dim rdr As SqlDataReader
        Dim strMethodName As String = "Utility.PFn_SetCombo"
        Dim strBlank As String = " "

        Try

            cboTarget.DataSource = Nothing
            cboTarget.Items.Clear()

            strSql = " SELECT  キー1 ,文字列1 From  M管理詳細 "

            If strWhere <> "" Then
                strSql = strSql & strWhere & ""
            End If

            strSql = strSql & " ORDER BY 表示順"

            rdr = objDbHelper.PFn_ExcuteReader(strSql.ToString)

            If rdr.HasRows = False Then
                rdr.Close()
                objDbHelper.PSb_CloseDB()
                Exit Sub
            End If

            'intLength = SelectDigits(ViewNm, objDbHelper)

            While rdr.Read
                If PFn_IsDBNull(rdr.Item("文字列1"), "") = String.Empty Then
                    cboTarget.Items.Add(PFn_AddZero(rdr.Item(" キー1"), intLength), strBlank)
                Else
                    cboTarget.Items.Add(PFn_AddZero(rdr.Item("キー1"), intLength), PFn_AddZero(rdr.Item("キー1"), intLength) & " " & rdr.Item("文字列1").ToString)
                End If
            End While

            rdr.Close()
            objDbHelper.PSb_CloseDB()

        Catch ex As Exception
            If Not objDbHelper Is Nothing Then
                objDbHelper.PSb_CloseDB()
            End If
            Throw New Exception("Utility" & strMethodName, ex)

        End Try

    End Sub


#End Region

#Region "コンボボックス相関関数"
    ''' <summary>
    ''' グリッドのdropDownリストの項目をセットする
    ''' </summary>
    ''' <param name="strSql">SQL文</param>
    ''' <param name="intGroupIndex">グリッドのBand番号</param>
    ''' <param name="intColumnIndex">グリッドの列番号</param>
    ''' <param name="htPara">Where条件パラメーター</param>
    ''' <remarks>グリッドのdropDownリストの項目をセットする</remarks>
    ''' <history>
    ''' 	[関]
    ''' </history>
    Public Shared Sub PSb_SetComboBox(ByVal UCCtlGrid As UserControl.UCGridEdit, _
                               ByVal strSql As StringBuilder, _
                               ByVal intColumnIndex As Integer, _
                               Optional ByVal intGroupIndex As Integer = 0, _
                               Optional ByVal htPara As Hashtable = Nothing, _
                               Optional ByVal blnHasNullRow As Boolean = False)

        Dim dtData As DataTable = Nothing
        Dim strColumnName As String = String.Empty
        Dim objValueList As Infragistics.Win.ValueList
        Dim intRows As Integer = 0

        Try
            'グリッドのキーを取得する
            strColumnName = UCCtlGrid.DisplayLayout.Bands(intGroupIndex).Columns(intColumnIndex).Key

            'リストを判断する
            If UCCtlGrid.DisplayLayout.ValueLists.Exists(intGroupIndex & strColumnName) Then
                UCCtlGrid.DisplayLayout.ValueLists.Remove(intGroupIndex & strColumnName)
            End If

            'リストを新規する
            objValueList = UCCtlGrid.DisplayLayout.ValueLists.Add(intGroupIndex & strColumnName)

            '空白行を判断する
            If blnHasNullRow Then
                '空白行を追加する
                Call objValueList.ValueListItems.Add(String.Empty, String.Empty)
            End If

            'データを戻る
            If Not htPara Is Nothing Then
                dtData = DbHelper.PFn_Sh_SelectDB(strSql, htPara)
            Else
                dtData = DbHelper.PFn_Sh_SelectDB(strSql)
            End If

            Dim strBlank As String = ""

            'データの存在を判断する
            If Not dtData Is Nothing OrElse dtData.Rows.Count > 0 Then
                'リストのデータを設置する
                For intRows = 0 To dtData.Rows.Count - 1
                    If Utility.PFn_ToString(dtData.Rows(intRows).Item(1)) <> "" Then
                        strBlank = Utility.PFn_ToString(dtData.Rows(intRows).Item(0)) & " " & _
                                    Utility.PFn_ToString(dtData.Rows(intRows).Item(1))
                    Else
                        strBlank = " "
                    End If

                    Call objValueList.ValueListItems.Add(Utility.PFn_ToString(dtData.Rows(intRows).Item(0)), _
                                                strBlank)
                Next
            End If

            'リストを追加する
            UCCtlGrid.DisplayLayout.Bands(intGroupIndex).Columns(intColumnIndex).ValueList = objValueList
        Catch ex As Exception
            If Not dtData Is Nothing Then
                dtData.Dispose()
            End If
        End Try
    End Sub

#End Region

#Region "通配符"

    '-----------------------------------------------------------------------------
    '概要

    '   'を変える

    'パラメタ説明

    '   str     :String
    '戻り値
    '   String 型

    '備考

    '    なし

    '-----------------------------------------------------------------------------

    Public Shared Function PFn_ChangeQuotation(ByVal str As String, _
                                               Optional ByVal blnLike As Boolean = False) As String

        Dim strValue As String

        If blnLike Then
            strValue = PFn_NullToString(str).Replace("'", "''")
        Else
            If Not String.IsNullOrEmpty(str) Then
                strValue = "N" + "'" & Replace(str, "'", "''") & "'"
            Else
                strValue = "Null"
            End If
        End If

        Return strValue

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
    '    蔡挺2007/11/01
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

#Region "PFn_GetTableByWhere "

    ''' <summary>
    ''' データテーブルを取得
    ''' </summary>
    ''' <param name="strColumns">列名</param>
    ''' <param name="strWhere">検索条件</param>
    ''' <param name="strTableName">テーブル名称</param>
    ''' <param name="intLock">True:with(ROWLOCK,UPDLOCK) False : NOLOCK </param>
    ''' <param name="objDbHelper">データベースリンク</param>
    ''' <return>データテーブル</return>
    ''' <remarks>2013/01/09 </remarks>
    Public Shared Function PFn_GetTableByWhere(ByVal strColumns As String, _
                                               ByVal strWhere As String, _
                                               ByVal strTableName As String, _
                                               Optional ByVal intLock As Boolean = False, _
                                               Optional ByRef objDbHelper As DbHelper = Nothing) As DataTable

        Dim dt As DataTable
        Dim strSql As New StringBuilder(String.Empty)
        Dim modDbHelper As DbHelper = Nothing

        Try
            strSql.Append(" SELECT " & strColumns & vbCrLf)

            If Not strTableName.Trim.Equals(String.Empty) Then
                strSql.Append(" FROM " & strTableName & vbCrLf)
            End If

            If intLock Then
                strSql.Append(" WITH(ROWLOCK,UPDLOCK) ")
            End If

            strSql.Append(" " & strWhere & vbCrLf)

            If objDbHelper Is Nothing Then
                modDbHelper = New DbHelper

                dt = modDbHelper.PFn_FillDataTable(strSql.ToString)

                modDbHelper.PSb_CloseDB()
            Else
                dt = objDbHelper.PFn_FillDataTable(strSql.ToString)
            End If

            Return dt

        Catch ex As Exception
            ExHelper.ProcessDBHelper(objDbHelper)
            Throw ex

        End Try

    End Function

    Public Shared Function PFn_GetNameByCd(ByVal strColumn As String, _
                                           ByVal strWhere As String, _
                                           ByVal strTableName As String, _
                                           Optional ByRef objDbHelper As DbHelper = Nothing) As String

        Dim strSql As New StringBuilder(String.Empty)
        Dim modDbHelper As DbHelper = Nothing
        Dim dt As DataTable

        Try
            strSql.Append(" SELECT " & strColumn & vbCrLf)

            If Not strTableName.Trim.Equals(String.Empty) Then
                strSql.Append(" FROM " & strTableName & vbCrLf)
            End If

            strSql.Append(" " & strWhere & vbCrLf)

            If objDbHelper Is Nothing Then
                modDbHelper = New DbHelper

                dt = modDbHelper.PFn_FillDataTable(strSql.ToString)

                modDbHelper.PSb_CloseDB()
            Else
                dt = objDbHelper.PFn_FillDataTable(strSql.ToString)
            End If

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0).ToString
            Else
                Return String.Empty
            End If

        Catch ex As Exception
            ExHelper.ProcessDBHelper(objDbHelper)
            Throw ex

        End Try

    End Function

#End Region

#Region " PFn_GetDBTime"

    Public Shared Function PFn_GetDBTime(Optional ByVal int格式 As Integer = 121) As String

        Dim dlFunctionName As String = "PFn_GetDBTime"          'メソッド名称
        Dim objDbHelper As DbHelper = Nothing

        Try
            Dim ReturnTime As String                        'システム時間
            Dim WhereString As New StringBuilder(String.Empty)           'SQL文 

            '検索

            'データベースConnet
            objDbHelper = New DbHelper

            'SQL文 
            'WhereString.Append("select convert(varchar,getdate(),111) + ' ' + convert(varchar,getdate(),114)")
            WhereString.Append("select convert(varchar,getdate()," & int格式 & ")")

            'システム時間戻し 
            ReturnTime = Convert.ToString(objDbHelper.PFn_ExcuteScalar(WhereString.ToString))

            'データベースClose
            objDbHelper.PSb_CloseDB()

            Return ReturnTime

        Catch ex As Exception
            ExHelper.ProcessDBHelper(objDbHelper)
            Throw New Exception("Utility" & dlFunctionName, ex)

        End Try

    End Function

#End Region

#Region "PFN_GetByte"
    Public Shared Function PFN_GetByte(ByVal StrText As String) As Boolean

        Dim intCharLen As Integer = 0
        Dim strTemp As String = String.Empty

        For i As Integer = 1 To StrText.Length

            strTemp = Mid(StrText, i, 1)
            intCharLen = System.Text.Encoding.Default.GetByteCount(strTemp)

            If intCharLen = 2 Then
                Return False
            End If

        Next

        Return True

    End Function
#End Region

#Region "PFn_IsNothing"

    '--------------------------------------------------------------------------------
    '概要

    '   Nothingかどうかをチェックする
    'パラメタ説明

    '   obj     :Object
    '   value   :Object
    '戻り値
    '   Object 型

    '備考

    '   なし

    '--------------------------------------------------------------------------------
    Public Shared Function PFn_IsNothing(ByVal obj As Object, ByVal value As Object) As Object

        If Information.IsNothing(obj) Then
            Return value
        Else
            Return obj
        End If

    End Function

#End Region

#Region " PFn_IsDBNull"

    '--------------------------------------------------------------------------------
    '概要
    '   DBNullかどうかをチェックする
    'パラメタ説明
    '   obj     :Object
    '   value   :Object
    '戻り値
    '   Object 型
    '備考
    '   なし
    '--------------------------------------------------------------------------------
    Public Shared Function PFn_IsDBNull(ByVal obj As Object, ByVal value As Object) As Object

        If Information.IsDBNull(obj) Then
            Return value
        Else
            Return obj
        End If

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
    '  作成者
    '    ［20081201］V0.0.1
    '  備考
    '-----------------------------------------------------------------------------
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

#Region "PFn_IsDate"

    '--------------------------------------------------------------------------------
    '概要

    '   Dateかどうかをチェックする
    'パラメタ説明

    '   obj     :Object
    '戻り値
    '   Object 型

    '備考

    '   なし

    '--------------------------------------------------------------------------------
    Public Shared Function PFn_IsDate(ByVal obj As Object) As Boolean

        'If Information.IsDate(obj) Then
        '    Return True
        'Else
        '    Return False
        'End If

        If PFn_ToDateTime(obj) = Nothing Then
            Return False
        Else
            Return True
        End If

    End Function

#End Region

#Region " PFn_CanInputLetterOrDigit "

    Public Shared Function PFn_CanInputLetterOrDigit(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean

        If Not (Char.IsLetterOrDigit(e.KeyChar) _
                Or Asc(e.KeyChar) = Keys.Back _
                Or Asc(e.KeyChar) = Keys.Enter) Then

            Return True

        End If

        Return False

    End Function

#End Region

#Region " PFn_RemoveZero"

    Public Shared Function PFn_RemoveZero(ByVal d As Decimal) As String

        Dim strTemp As String = d.ToString
        Dim intLen As Integer = 0

        intLen = strTemp.Length

        For intTemp As Integer = 0 To intLen - 1

            If strTemp.IndexOf(".") <> -1 Then
                If strTemp.Chars(intLen - 1 - intTemp) <> "0" Then
                    If strTemp.Chars(intLen - 1 - intTemp) = "." Then
                        Return strTemp.Substring(0, intLen - intTemp - 1)
                    Else
                        Return strTemp
                    End If
                End If
            End If
            strTemp = strTemp.Substring(0, intLen - 1 - intTemp)
        Next

        Return strTemp

    End Function

#End Region

#Region " PFn_AddZero"

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
    '    蔡挺2007/11/01
    '  備考
    '
    '-----------------------------------------------------------------------------
    Public Shared Function PFn_AddZero(ByVal strCd As String, ByVal intMaxLgh As Int64) As String

        '▼変数定義
        Const cstrMethodName As String = "Utility.AddZero"     'メソッド名称
        Dim intloopi As Integer = 0
        Dim strTemp As String

        Try
            If strCd = String.Empty Then
                Return strCd
            End If

            If intMaxLgh = 0 Then
                Return strCd
            End If

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

    Public Shared Function ToInteger(ByVal objValue As Object) As Integer
        If objValue Is Nothing OrElse IsDBNull(objValue) Then
            ToInteger = 0
        Else
            Try
                ToInteger = CInt(objValue)
            Catch ex As Exception
                ToInteger = 0
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

        If CDate(objValue) <= CDate(CGSTRDATE_DEFAULT) Then
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

        If PFn_IsRegex(Constant.CON_REGEX_NUMBER, objValue) Then
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

#End Region

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

#Region "構造関数"

#Region " New"

    '-----------------------------------------------------------------------------
    '  概要
    '   新しいオブジェクト
    '  パラメタ説明
    '   なし
    '  機能説明
    '   新しいオブジェクト
    '  戻り値
    '   なし
    '  作成者
    '   ［20090430］V1.0.0
    '  備考
    '
    '-----------------------------------------------------------------------------
    Public Sub New()

        FormsCollection = New Collection
        Return

    End Sub

#End Region

#End Region

#Region "Overridable"

    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        Return FormsCollection.GetEnumerator
    End Function

#End Region

#Region " エクセルプロセスを取得 "

#Region "2013/12/12 李濤 Created"

    Public Shared Sub PSB_WindowThreadProcessId(ByVal excelApp As Object, _
                                                ByRef ProcessID() As Integer, _
                                                ByRef ProcessIndex As Integer)

        Try
            GetWindowThreadProcessId(excelApp.Hwnd, ProcessID(ProcessIndex))

            ProcessIndex = ProcessIndex + 1

        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub PSB_CloseProcessExcel(ByVal ProcessID() As Integer)

        Try
            If ProcessID.Length <> 0 Then
                For Index = 0 To ProcessID.Length - 1
                    Dim X_Process As New System.Diagnostics.Process

                    Try
                        X_Process = System.Diagnostics.Process.GetProcessById(ProcessID(Index))
                    Catch ex As Exception
                        Continue For
                    End Try

                    If Not X_Process.HasExited Then
                        X_Process.Kill()
                    End If
                Next
            End If

            GC.Collect()

        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub PSB_CloseProcessSingleExcel(ByVal excelApp As Object)

        Try
            Dim ProcessID As Integer = 0

            GetWindowThreadProcessId(excelApp.Hwnd, ProcessID)

            Dim X_Process As New System.Diagnostics.Process

            Try
                X_Process = System.Diagnostics.Process.GetProcessById(ProcessID)
            Catch ex As Exception

            End Try

            If Not X_Process.HasExited Then
                X_Process.Kill()
            End If

            GC.Collect()

        Catch ex As Exception

        End Try

    End Sub

    Public Declare Function GetWindowThreadProcessId Lib "user32" (ByVal hWnd As Integer, ByRef lpdwProcessId As Integer) As Integer

#End Region
#End Region

#Region " エクセルバージョンを取得 "
#Region "2013/12/12 李濤 Created"

    Public Shared Function PFN_ExcelVersion() As String

        Dim ExcelVersion As String = String.Empty
        Dim RegistryKeys As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Office")
        Dim RegistryKeyIn As RegistryKey = Nothing
        Dim KeyNames As String() = RegistryKeys.GetSubKeyNames()

        For Index = 0 To KeyNames.Length - 1
            If KeyNames.GetValue(Index).Equals("11.0") Then
                RegistryKeyIn = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Office\" & _
                                                                 KeyNames.GetValue(Index) & "\Excel")

                If Not RegistryKeyIn Is Nothing Then
                    ExcelVersion = "2003"
                End If

            ElseIf KeyNames.GetValue(Index).Equals("12.0") Then
                RegistryKeyIn = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Office\" & _
                                                                 KeyNames.GetValue(Index) & "\Excel")

                If Not RegistryKeyIn Is Nothing Then
                    ExcelVersion = "2007"
                End If

            ElseIf KeyNames.GetValue(Index).Equals("14.0") Then
                RegistryKeyIn = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Office\" & _
                                                                 KeyNames.GetValue(Index) & "\Excel")

                If Not RegistryKeyIn Is Nothing Then
                    ExcelVersion = "2010"
                End If

            ElseIf KeyNames.GetValue(Index).Equals("15.0") Then
                RegistryKeyIn = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Office\" & _
                                                                 KeyNames.GetValue(Index) & "\Excel")

                If Not RegistryKeyIn Is Nothing Then
                    ExcelVersion = "2013"
                End If

            End If
        Next

        Return ExcelVersion

    End Function

#End Region
#End Region
 
#Region "画面のタイトル処理"

    ' ''' <summary>
    ' ''' 画面のタイトル処理
    ' ''' </summary>
    ' ''' <param name="str画面名称">画面名称</param>
    ' ''' <param name="int画面モード">画面モード</param>
    ' '''<returns>タイトル文字列</returns>
    ' ''' <remarks></remarks>
    'Public Shared Function PFN_SetTitle(ByVal str画面名称 As String, _
    '                                    ByVal int画面モード As Integer) As String

    '    Dim strTitle As new StringBuilder 

    '    strTitle.Append(str画面名称 & "　")

    '    'モード情報を追加
    '    Select Case int画面モード
    '        '新規モードと新規ｺﾋﾟｰモード
    '        Case ENU_MODE.Model_New
    '            strTitle.Append("[新規]")
    '            '更新モード
    '        Case ENU_MODE.Model_Update, ENU_MODE.Model_Update_1, ENU_MODE.Model_Update_2
    '            strTitle.Append("[更新]")
    '            '照会モード
    '        Case ENU_MODE.Model_Ref
    '            strTitle.Append("[照会]")
    '            '検索モード
    '        Case ENU_MODE.Model_Search
    '            strTitle.Append("[検索]")
    '            '削除モード
    '        Case ENU_MODE.Model_Delete
    '            strTitle.Append("[削除]")
    '        Case ENU_MODE.Model_NULL
    '            strTitle.Append("[一覧]")
    '        Case ENU_MODE.Model_NULL1
    '            strTitle.Append("[新規]")
    '    End Select

    '    'ログイン情報を追加
    '    strTitle.Append("　" & LoginInfo.UserID & "　" & LoginInfo.UserName)

    '    Return strTitle.ToString

    'End Function

#End Region

#Region " 検索項目の名称処理 "

   
    Public Shared Function PFn_GetFreeWordSQL(ByVal strWord As String, _
                                              ByVal strS As String(), _
                                              Optional ByVal strAsTableOtherName As String = "") As String

        Dim aryFreeWord As ArrayList = Nothing
        Dim strHalfSpaces As String()
        Dim strAllSpaces As String()

        Dim strRtnSql As StringBuilder = Nothing
        Dim strTmp As String = ""

        Dim i As Integer
        Dim j As Integer

        'フリーワードの文字=空白の場合、空白を戻す
        If strWord.Trim = "" Then
            Return strWord.Trim
        End If

        aryFreeWord = New ArrayList

        '半角スペースを分離
        strHalfSpaces = strWord.Split(" ")

        For Each str1 As String In strHalfSpaces

            If str1.Trim <> String.Empty Then
                '全角スペースを分離
                strAllSpaces = str1.Split("　")

                '分離文字列を配列へ実装
                For Each str2 As String In strAllSpaces
                    If str2.Trim <> String.Empty Then
                        aryFreeWord.Add(PFn_ChangeQuotation(str2.ToUpper.Trim, True))
                    End If
                Next
            End If

        Next

        '検索条件で文字列を作る
        If aryFreeWord.Count > 0 Then
            strRtnSql = New StringBuilder

            If strAsTableOtherName <> String.Empty Then
                strTmp = strAsTableOtherName & "."
            End If

            i = 0

            For Each strKey As String In strS

                If i = 0 Then
                    strRtnSql.Append(" AND" & vbCrLf)
                    strRtnSql.Append(" (" & vbCrLf)
                Else
                    strRtnSql.Append(" AND")
                End If

                j = 0

                For Each strValue As String In aryFreeWord

                    If j = 0 Then
                        strRtnSql.Append(" " & strTmp & strKey & " LIKE '%" & strValue & "%'" & vbCrLf)
                    Else
                        strRtnSql.Append(" AND " & strTmp & strKey & " LIKE '%" & strValue & "%'" & vbCrLf)
                    End If

                    j = j + 1

                Next

                i = i + 1
            Next

            strRtnSql.Append(" )" & vbCrLf)

        End If

        Return strRtnSql.ToString

    End Function

#End Region

#Region "GridRowMove"
    Public Shared Sub GridRowMove_Bottom(ByRef sender As UserControl.UCGridEdit)
        If IsNothing(sender.DataSource) Then
            Exit Sub
        End If

        If sender.Rows.Count = 0 Then
            Exit Sub
        End If

        If IsNothing(sender.ActiveRow) Then
            Exit Sub
        End If

        If sender.ActiveRow.Index = sender.Rows.Count - 1 Or sender.ActiveRow.Index = sender.Rows.Count - 2 Then
            Exit Sub
        End If

        Dim dt As DataTable = CType(sender.DataSource, DataTable)

        Dim dr As DataRow = dt.NewRow

        For Each dc As DataColumn In dt.Columns
            dr(dc.ColumnName) = sender.ActiveRow.Cells(dc.ColumnName).Value
        Next
        dt.Rows.RemoveAt(sender.ActiveRow.Index)

        dt.Rows.InsertAt(dr, dt.Rows.Count - 1)

        sender.DataSource = dt

        sender.Rows(dt.Rows.Count - 2).Activate()

        sender.Update()
        sender.UpdateData()

        'If sender.ActiveRow.Index <> sender.Rows.Count - 1 And sender.Rows.Count > 2 Then
        '    sender.Rows.Move(sender.ActiveRow, sender.Rows.Count - 2)
        'End If
    End Sub

    Public Shared Sub GridRowMove_UpBoolean(ByVal sender As UserControl.UCGridEdit, Optional ByVal int削除 As Integer = 0)
        Dim blnChoose As Boolean = False
        If IsNothing(sender.DataSource) Then
            Exit Sub
        End If

        If sender.Rows.Count = 0 Then
            Exit Sub
        End If

        If IsNothing(sender.ActiveRow) Then
            Exit Sub
        End If

        If sender.ActiveRow.Index = 0 Then
            Exit Sub
        End If

        'If sender.ActiveRow.Index = sender.Rows.Count - 1 Then
        '    Exit Sub
        'End If

        Dim rowIndex As Integer = sender.ActiveRow.Index

        Dim dt As DataTable = CType(sender.DataSource, DataTable)

        Dim dr As DataRow = dt.NewRow

        For Each dc As DataColumn In dt.Columns
            dr(dc.ColumnName) = sender.ActiveRow.Cells(dc.ColumnName).Value
        Next

        If sender.Rows(rowIndex).Cells(int削除).Value = True Then
            blnChoose = True
        End If

        dt.Rows.RemoveAt(rowIndex)

        dt.Rows.InsertAt(dr, rowIndex - 1)

        If blnChoose = True Then
            For i As Integer = 0 To sender.Rows(rowIndex - 1).Cells.Count - 1
                If i <> int削除 Then
                    sender.Rows(rowIndex - 1).Cells(i).Activation = Activation.NoEdit
                    sender.Rows(rowIndex - 1).Cells(i).TabStop = DefaultableBoolean.False
                    sender.Rows(rowIndex - 1).Cells(i).Appearance.BackColor = Color.Silver
                End If
            Next

        End If

        sender.DataSource = dt

        sender.Rows(rowIndex - 1).Activate()
        sender.Update()
        sender.UpdateData()

        'If sender.ActiveRow.Index <> sender.Rows.Count - 1 Then
        '    sender.Rows.Move(sender.ActiveRow, sender.ActiveRow.Index - 1)
        'End If

        'sender.UpdateData()
    End Sub

    Public Shared Sub GridRowMove_DownBoolean(ByVal sender As UserControl.UCGridEdit, Optional ByVal int削除 As Integer = 0)
        Dim blnChoose As Boolean = False

        If IsNothing(sender.DataSource) Then
            Exit Sub
        End If

        If sender.Rows.Count = 0 Then
            Exit Sub
        End If

        If IsNothing(sender.ActiveRow) Then
            Exit Sub
        End If

        If sender.Rows.Count <= 1 Then
            Exit Sub
        End If

        If sender.ActiveRow.Index = sender.Rows.Count - 1 Then
            Exit Sub
        End If

        Dim rowIndex As Integer = sender.ActiveRow.Index

        Dim dt As DataTable = CType(sender.DataSource, DataTable)

        Dim dr As DataRow = dt.NewRow

        For Each dc As DataColumn In dt.Columns
            dr(dc.ColumnName) = sender.ActiveRow.Cells(dc.ColumnName).Value
        Next

        If sender.Rows(rowIndex).Cells(int削除).Value = True Then
            blnChoose = True
        End If

        dt.Rows.RemoveAt(rowIndex)

        dt.Rows.InsertAt(dr, rowIndex + 1)

        sender.DataSource = dt
        sender.Rows(rowIndex + 1).Activate()
        sender.Update()
        sender.UpdateData()

        If blnChoose = True Then
            For i As Integer = 0 To sender.Rows(rowIndex + 1).Cells.Count - 1
                If i <> int削除 Then
                    sender.Rows(rowIndex + 1).Cells(i).Activation = Activation.NoEdit
                    sender.Rows(rowIndex + 1).Cells(i).TabStop = DefaultableBoolean.False
                    sender.Rows(rowIndex + 1).Cells(i).Appearance.BackColor = Color.Silver
                End If
            Next

        End If


        'If sender.Rows.Count > 2 Then
        '    If sender.ActiveRow.Index = sender.Rows.Count - 1 Or sender.ActiveRow.Index = sender.Rows.Count - 2 Then
        '        Exit Sub
        '    End If

        '    sender.Rows.Move(sender.ActiveRow, sender.ActiveRow.Index + 1)
        'End If

        'sender.UpdateData()
    End Sub

    Public Shared Sub GridRowMove_UpIntegar(ByVal sender As UserControl.UCGridEdit, Optional ByVal int削除 As Integer = 0)
        Dim blnChoose As Boolean = False

        If IsNothing(sender.DataSource) Then
            Exit Sub
        End If

        If sender.Rows.Count = 0 Then
            Exit Sub
        End If

        If IsNothing(sender.ActiveRow) Then
            Exit Sub
        End If

        If sender.ActiveRow.Index = 0 Then
            Exit Sub
        End If

        'If sender.ActiveRow.Index = sender.Rows.Count - 1 Then
        '    Exit Sub
        'End If

        Dim rowIndex As Integer = sender.ActiveRow.Index

        Dim dt As DataTable = CType(sender.DataSource, DataTable)

        Dim dr As DataRow = dt.NewRow

        For Each dc As DataColumn In dt.Columns
            dr(dc.ColumnName) = sender.ActiveRow.Cells(dc.ColumnName).Value
        Next

        If sender.Rows(rowIndex).Cells(int削除).Column.Style = ColumnStyle.CheckBox Then
            If sender.Rows(rowIndex).Cells(int削除).Value = 1 Then
                blnChoose = True
            End If
        End If

        dt.Rows.RemoveAt(rowIndex)

        dt.Rows.InsertAt(dr, rowIndex - 1)

        sender.DataSource = dt

        sender.Rows(rowIndex - 1).Activate()
        sender.Update()
        sender.UpdateData()

        If blnChoose = True Then
            For i As Integer = 0 To sender.Rows(rowIndex - 1).Cells.Count - 1
                If i <> int削除 Then
                    sender.Rows(rowIndex - 1).Cells(i).Activation = Activation.NoEdit
                    sender.Rows(rowIndex - 1).Cells(i).TabStop = DefaultableBoolean.False
                    sender.Rows(rowIndex - 1).Cells(i).Appearance.BackColor = Color.Silver
                End If
            Next

        End If

        'If sender.ActiveRow.Index <> sender.Rows.Count - 1 Then
        '    sender.Rows.Move(sender.ActiveRow, sender.ActiveRow.Index - 1)
        'End If

        'sender.UpdateData()
    End Sub

    Public Shared Sub GridRowMove_DownIntegar(ByVal sender As UserControl.UCGridEdit, Optional ByVal int削除 As Integer = 0)
        Dim blnChoose As Boolean = False

        If IsNothing(sender.DataSource) Then
            Exit Sub
        End If

        If sender.Rows.Count = 0 Then
            Exit Sub
        End If

        If IsNothing(sender.ActiveRow) Then
            Exit Sub
        End If

        If sender.Rows.Count <= 1 Then
            Exit Sub
        End If

        If sender.ActiveRow.Index = sender.Rows.Count - 1 Then
            Exit Sub
        End If

        Dim rowIndex As Integer = sender.ActiveRow.Index

        Dim dt As DataTable = CType(sender.DataSource, DataTable)

        Dim dr As DataRow = dt.NewRow

        For Each dc As DataColumn In dt.Columns
            dr(dc.ColumnName) = sender.ActiveRow.Cells(dc.ColumnName).Value
        Next

        If sender.Rows(rowIndex).Cells(int削除).Column.Style = ColumnStyle.CheckBox Then
            If sender.Rows(rowIndex).Cells(int削除).Value = 1 Then
                blnChoose = True
            End If
        End If

        dt.Rows.RemoveAt(rowIndex)

        dt.Rows.InsertAt(dr, rowIndex + 1)

        sender.DataSource = dt
        sender.Rows(rowIndex + 1).Activate()
        sender.Update()
        sender.UpdateData()

        If blnChoose = True Then
            For i As Integer = 0 To sender.Rows(rowIndex + 1).Cells.Count - 1
                If i <> int削除 Then
                    sender.Rows(rowIndex + 1).Cells(i).Activation = Activation.NoEdit
                    sender.Rows(rowIndex + 1).Cells(i).TabStop = DefaultableBoolean.False
                    sender.Rows(rowIndex + 1).Cells(i).Appearance.BackColor = Color.Silver
                End If
            Next

        End If

        'If sender.Rows.Count > 2 Then
        '    If sender.ActiveRow.Index = sender.Rows.Count - 1 Or sender.ActiveRow.Index = sender.Rows.Count - 2 Then
        '        Exit Sub
        '    End If

        '    sender.Rows.Move(sender.ActiveRow, sender.ActiveRow.Index + 1)
        'End If

        'sender.UpdateData()
    End Sub

    Public Shared Sub GridRowMove_Top(ByVal sender As UserControl.UCGridEdit)
        If IsNothing(sender.DataSource) Then
            Exit Sub
        End If

        If sender.Rows.Count = 0 Then
            Exit Sub
        End If

        If IsNothing(sender.ActiveRow) Then
            Exit Sub
        End If

        If sender.ActiveRow.Index = sender.Rows.Count - 1 Then
            Exit Sub
        End If

        Dim dt As DataTable = CType(sender.DataSource, DataTable)

        Dim dr As DataRow = dt.NewRow

        For Each dc As DataColumn In dt.Columns
            dr(dc.ColumnName) = sender.ActiveRow.Cells(dc.ColumnName).Value
        Next
        dt.Rows.RemoveAt(sender.ActiveRow.Index)

        dt.Rows.InsertAt(dr, 0)

        sender.DataSource = dt
        sender.Rows(0).Activate()
        sender.Update()
        sender.UpdateData()

        'If sender.ActiveRow.Index <> sender.Rows.Count - 1 Then
        '    sender.Rows.Move(sender.ActiveRow, 0)
        'End If

        'sender.UpdateData()
    End Sub

#End Region

#Region "PFn_SetTextBox_Name"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender">TextBox_CD_Value</param>
    ''' <param name="senderName">TextBoxCodeName</param>
    ''' <param name="strWhereColName">PKName</param>
    ''' <param name="strTableName">TableName</param>
    ''' <param name="strRetrueColName">RetrueColNameValue</param>
    ''' <remarks></remarks>
    ''' <author>gaoheze</author>
    ''' <time>2014-02-28</time>
    Public Shared Sub PFn_SetTextBox_Name(ByVal sender As Object, _
                                          ByVal senderName As Object, _
                                          ByVal strWhereColName As String, _
                                          ByVal strTableName As String, _
                                          ByVal strRetrueColName As String)
        If String.IsNullOrEmpty(senderName.Text) <> True Then
            Dim dtTemp As New DataTable
            dtTemp = Utility.PFn_GetTableByWhere("*", "WHERE 表示フラグ=1 AND " & strWhereColName & " = '" & sender.Text & "'", strTableName)
            If dtTemp.Rows.Count > 0 Then
                senderName.z_txtName = dtTemp.Rows(0)(strRetrueColName).ToString
            Else
                senderName.z_txtName = String.Empty
            End If

        Else
            senderName.z_txtName = String.Empty
        End If
    End Sub
#End Region

#Region "PFn_OutputCSVData"

    '-------------------------------------------------------
    '関数名
    '   PFn_OutputCSVData
    '概要
    '　CSVを出力する
    'パラメタ説明
    '   パラメタ名：(In)  dtCsvOut、 strFileName、intMark
    '   パラメタ名：(Out) Boolean
    '戻り値
    '   戻り型：Boolean
    '作成者   
    '   関　明玉 [2010-08-24] V1.0.0
    '更新者
    '  byRef uproCsv As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    '-------------------------------------------------------
    Public Shared Function PFn_OutputCSVData(ByVal dtCsvOut As DataTable, _
                                         ByVal strFileName As String, _
                                         Optional ByVal intMark As Integer = 1) As Boolean

        Const cmstrMethodName As String = "PFn_OutputCSVData"

        Try
            Dim dialog As New SaveFileDialog
            Dim strCopyPathName As String
            Dim strFilePath As String
            Dim intLoopRow As Integer
            Dim intLoopCol As Integer
            Dim objStreamWrite As StreamWriter
            Dim strCSVData As New StringBuilder(System.String.Empty) 'SQL文
            Dim strMark As String = """"
            Dim strContains As StringBuilder

            strContains = New StringBuilder

            strFilePath = String.Empty

            ''はじめに表示されるフォルダを指定する
            strFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            strFilePath = strFilePath & "\" & strFileName & ".CSV"
            'If strFilePath <> String.Empty Then
            '    'パース不存在の場合はパースを作成する
            '    If Not File.Exists(objKanriT.moji1) Then
            '        Try
            '            Directory.CreateDirectory(objKanriT.moji1)
            '        Catch ex As Exception
            '            Return False
            '        End Try
            '    End If

            'End If

            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            dialog.Filter = "ExcelFile(*.csv)|*.csv"
            dialog.FileName = strFileName

            '上書き確認する
            dialog.OverwritePrompt = True

            '出力選択ダイアログを表示する、キャンセル場合、画面に戻る、「OK」場合は、続く
            If dialog.ShowDialog = DialogResult.OK Then
                strCopyPathName = dialog.FileName

                'If System.IO.File.Exists(strCopyPathName) = True Then

                '    Try
                '        System.IO.File.Delete(strCopyPathName)
                '    Catch ex As Exception
                '        CommonMsg.showMsg("システム", 20, "対象のファイルが、使用中為、保存できません。")
                '        Return False
                '    End Try

                'End If

                objStreamWrite = New StreamWriter(strCopyPathName, False, System.Text.Encoding.GetEncoding("Shift_JIS"))
                strCSVData = New StringBuilder(System.String.Empty)
                'DBファイル名を出力

                'strCSVData.AppendFormat("{0},{1}", Constant.cgstrCsvDbName, dtCsvOut.TableName)
                'objStreamWrite.WriteLine(strCSVData.ToString)
                strCSVData = New StringBuilder(System.String.Empty)

                For intLoopCol = 0 To dtCsvOut.Columns.Count - 1
                    'レコード

                    If intLoopCol <> 0 Then
                        strCSVData.Append(",")
                    End If
                    strCSVData.Append(dtCsvOut.Columns(intLoopCol).ColumnName.ToString)
                Next

                objStreamWrite.WriteLine(strCSVData.ToString)

                strCSVData = New StringBuilder(System.String.Empty)
                If dtCsvOut.Rows.Count <> 0 Then
                    For intLoopRow = 0 To dtCsvOut.Rows.Count - 1
                        For intLoopCol = 0 To dtCsvOut.Columns.Count - 1
                            'レコード

                            If intMark <> 0 Then
                                If intLoopCol <> 0 Then
                                    strCSVData.Append(",")
                                End If

                                'If ISNOorCD(dtCsvOut, intLoopRow, intLoopCol) Then
                                '    strCSVData.Append(strMark & "'" & dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), "").Replace("""", """""") & strMark)
                                'Else
                                strCSVData.Append(strMark & dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), "").Replace("""", """""") & strMark)
                                'End If

                            Else
                                If intLoopCol <> 0 Then
                                    strCSVData.Append(",")
                                End If

                                'If ISNOorCD(dtCsvOut, intLoopRow, intLoopCol) Then
                                '    strCSVData.Append("'" & dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), ""))
                                'Else
                                strCSVData.Append(dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), ""))
                                'End If
                            End If

                        Next

                        objStreamWrite.WriteLine(strCSVData.ToString)

                        strContains.Append(strCSVData.ToString & vbCrLf)

                        strCSVData = New StringBuilder(System.String.Empty)

                    Next
                End If

                objStreamWrite.Close()
            Else
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw New Exception(cmstrMethodName, ex)
            Return False
        End Try

    End Function

    Public Shared Function PFn_OutputCSVData(ByVal dtCsvOut As DataTable, _
                                             ByVal strFilePath As String, _
                                             ByVal strFileName As String, _
                                             Optional ByVal intMark As Integer = 1) As Boolean

        Const cmstrMethodName As String = "PFn_OutputCSVData"

        Dim objDbHelper As DbHelper = Nothing
        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Dim dt As DataTable

        Try
            Dim dialog As New SaveFileDialog
            Dim strCopyPathName As String
            Dim intLoopRow As Integer
            Dim intLoopCol As Integer
            Dim objStreamWrite As StreamWriter
            Dim strCSVData As New StringBuilder(System.String.Empty) 'SQL文
            Dim strMark As String = """"
            Dim strContains As StringBuilder

            strContains = New StringBuilder

            If strFileName.Contains("NM") Then

                strSql.Append(" Select ")
                strSql.Append(" 区分,")
                strSql.Append(" 名称 ")

                'テーブル
                strSql.Append(" From ")
                strSql.Append(" " & strFilePath & "")                                        'システム管理マスタ

                strSql.Append(" ORDER BY CONVERT(INT,表示順) ,区分")

                objDbHelper = New DbHelper

                dt = objDbHelper.PFn_FillDataTable(strSql.ToString)

                objDbHelper.PSb_CloseDB()

                If dt.Rows.Count <> 0 Then
                    strFilePath = PFn_Trim(dt.Rows(0).Item("名称"))
                End If

                strFilePath = strFilePath & strFileName & ".CSV"
            Else

                strFilePath = strFilePath & "\" & strFileName & ".CSV"
            End If

            'If strFilePath <> String.Empty Then
            '    'パース不存在の場合はパースを作成する
            '    If Not File.Exists(objKanriT.moji1) Then
            '        Try
            '            Directory.CreateDirectory(objKanriT.moji1)
            '        Catch ex As Exception
            '            Return False
            '        End Try
            '    End If

            'End If

            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            dialog.Filter = "ExcelFile(*.csv)|*.csv"
            dialog.FileName = strFileName

            '上書き確認する
            dialog.OverwritePrompt = True

            '出力選択ダイアログを表示する、キャンセル場合、画面に戻る、「OK」場合は、続く
            If dialog.ShowDialog = DialogResult.OK Then
                strCopyPathName = dialog.FileName

                'If System.IO.File.Exists(strCopyPathName) = True Then

                '    Try
                '        System.IO.File.Delete(strCopyPathName)
                '    Catch ex As Exception
                '        CommonMsg.showMsg("システム", 20, "対象のファイルが、使用中為、保存できません。")
                '        Return False
                '    End Try

                'End If

                objStreamWrite = New StreamWriter(strCopyPathName, False, System.Text.Encoding.GetEncoding("Shift_JIS"))
                strCSVData = New StringBuilder(System.String.Empty)
                'DBファイル名を出力

                'strCSVData.AppendFormat("{0},{1}", Constant.cgstrCsvDbName, dtCsvOut.TableName)
                'objStreamWrite.WriteLine(strCSVData.ToString)
                strCSVData = New StringBuilder(System.String.Empty)

                For intLoopCol = 0 To dtCsvOut.Columns.Count - 1
                    'レコード

                    If intLoopCol <> 0 Then
                        strCSVData.Append(",")
                    End If
                    strCSVData.Append(dtCsvOut.Columns(intLoopCol).ColumnName.ToString)
                Next

                objStreamWrite.WriteLine(strCSVData.ToString)

                strCSVData = New StringBuilder(System.String.Empty)
                If dtCsvOut.Rows.Count <> 0 Then
                    For intLoopRow = 0 To dtCsvOut.Rows.Count - 1
                        For intLoopCol = 0 To dtCsvOut.Columns.Count - 1
                            'レコード

                            If intMark <> 0 Then
                                If intLoopCol <> 0 Then
                                    strCSVData.Append(",")
                                End If

                                'If ISNOorCD(dtCsvOut, intLoopRow, intLoopCol) Then
                                '    strCSVData.Append(strMark & "'" & dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), "").Replace("""", """""") & strMark)
                                'Else
                                strCSVData.Append(strMark & dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), "").Replace("""", """""") & strMark)
                                'End If

                            Else
                                If intLoopCol <> 0 Then
                                    strCSVData.Append(",")
                                End If

                                'If ISNOorCD(dtCsvOut, intLoopRow, intLoopCol) Then
                                '    strCSVData.Append("'" & dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), ""))
                                'Else
                                strCSVData.Append(dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), ""))
                                'End If
                            End If

                        Next

                        objStreamWrite.WriteLine(strCSVData.ToString)

                        strContains.Append(strCSVData.ToString & vbCrLf)

                        strCSVData = New StringBuilder(System.String.Empty)

                    Next
                End If

                objStreamWrite.Close()
            Else
                Return False
            End If

            Return True

        Catch ex As Exception
            If Not objDbHelper Is Nothing Then
                objDbHelper.PSb_CloseDB()
            End If

            Throw New Exception(cmstrMethodName, ex)
            Return False
        End Try
    End Function

    Public Shared Function ISNOorCD(ByVal dt As DataTable, ByVal intRow As Integer, ByVal intCol As Integer) As Boolean

        If IsNumeric(dt.Rows(intRow).Item(intCol).ToString) Then

            If dt.Columns(intCol).ColumnName.Contains("NO") Or _
                dt.Columns(intCol).ColumnName.Contains("No") Or _
                dt.Columns(intCol).ColumnName.Contains("CD") Or _
                dt.Columns(intCol).ColumnName.Contains("枝番") Or _
                dt.Columns(intCol).ColumnName.Contains("Cd") Then

                Return True

            End If

        End If

        Return False

    End Function

#End Region

#Region "PFn_SetClipboard"
    'Ctrl+alt+O：
    'Ctrlキーを押下状態でCSV出力した場合はクリップボードへコピーする
    '（※内容はCSVファイル内容と同一のものとする）
    Public Shared Function PFn_SetClipboard(ByVal dtCsvOut As DataTable, _
                                             Optional ByVal intMark As Integer = 1) As Boolean

        Dim strCSVData As StringBuilder = Nothing          'SQL文
        Dim strContains As StringBuilder = Nothing
        Dim strMark As String = """"

        Const cmstrMethodName As String = "PFn_SetClipboard"

        Try
            If dtCsvOut.Rows.Count = 0 Then
                Return False
            End If

            strContains = New StringBuilder
            strCSVData = New StringBuilder(System.String.Empty)

            For intLoopCol = 0 To dtCsvOut.Columns.Count - 1
                'レコード

                If intLoopCol <> 0 Then
                    strCSVData.Append(",")
                End If
                strCSVData.Append(dtCsvOut.Columns(intLoopCol).ColumnName.ToString)
            Next

            strContains.Append(strCSVData.ToString & vbCrLf)

            If dtCsvOut.Rows.Count <> 0 Then
                For intLoopRow = 0 To dtCsvOut.Rows.Count - 1

                    strCSVData = New StringBuilder(System.String.Empty)

                    For intLoopCol = 0 To dtCsvOut.Columns.Count - 1

                        If intMark <> 0 Then
                            If intLoopCol <> 0 Then
                                strCSVData.Append(",")
                            End If

                            'If ISNOorCD(dtCsvOut, intLoopRow, intLoopCol) Then
                            '    strCSVData.Append(strMark & "'" & dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), "").Replace("""", """""") & strMark)
                            'Else
                            strCSVData.Append(strMark & dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), "").Replace("""", """""") & strMark)
                            'End If

                        Else
                            If intLoopCol <> 0 Then
                                strCSVData.Append(",")
                            End If

                            'If ISNOorCD(dtCsvOut, intLoopRow, intLoopCol) Then
                            '    strCSVData.Append("'" & dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), ""))
                            'Else
                            strCSVData.Append(dtCsvOut.Rows(intLoopRow).Item(intLoopCol).ToString.Replace(Chr(10), "").Replace(Chr(13), "").Replace(Chr(13) + Chr(10), ""))
                            'End If
                        End If
                    Next

                    strContains.Append(strCSVData.ToString & vbCrLf)

                Next
            End If

            Clipboard.SetText(strContains.ToString)

            Return True

        Catch ex As Exception
            Throw New Exception(cmstrMethodName, ex)
            Return False
        End Try

    End Function
#End Region
 
#Region "PSb_FirstEditableCellInGrid"
    'グリッド内のアクティブセルを設定します。

    Public Shared Sub PSb_FirstEditableCellInGrid(ByRef grid As UserControl.UCGridEdit)

        If grid.Rows Is Nothing Then
            Exit Sub
        End If

        If grid.Rows.Count = 0 Then
            If grid.Rows.VisibleRowCount <> 0 Then
                For intBand = 0 To grid.DisplayLayout.Bands.Count - 1

                    For intCol As Integer = 0 To grid.DisplayLayout.Bands(intBand).Columns.Count - 1
                        If grid.DisplayLayout.Bands(intBand).Columns(intCol).Hidden = False Then
                            If grid.DisplayLayout.Bands(intBand).Columns(intCol).TabStop = True Then
                                If grid.DisplayLayout.Bands(intBand).Columns(intCol).CellActivation = Activation.NoEdit Then
                                Else
                                    grid.ActiveCell = grid.DisplayLayout.Rows.TemplateAddRow.Cells(intCol)
                                    grid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)

                                    Exit Sub
                                End If
                            End If

                        End If
                    Next
                Next

            End If
        Else

            For intBand = 0 To grid.DisplayLayout.Bands.Count - 1

                For intRow As Integer = 0 To grid.DisplayLayout.Rows.Count - 1

                    For intCol As Integer = 0 To grid.DisplayLayout.Bands(intBand).Columns.Count - 1
                        If grid.DisplayLayout.Bands(intBand).Columns(intCol).Hidden = False Then
                            If grid.DisplayLayout.Bands(intBand).Columns(intCol).TabStop = True Then
                                If grid.DisplayLayout.Rows(intRow).Cells(intCol).Activation = Activation.NoEdit OrElse _
                                             grid.DisplayLayout.Bands(intBand).Columns(intCol).CellActivation = Activation.NoEdit Then
                                Else
                                    grid.ActiveCell = grid.DisplayLayout.Rows(intRow).Cells(intCol)
                                    grid.ActiveCell.Appearance.BackColor = ColorEnter  'Color.PapayaWhip
                                    grid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                                    Exit Sub
                                End If
                            End If

                        End If
                    Next

                Next

            Next

        End If

    End Sub
#End Region

#Region "PSb_LastEditableCellInGrid"
    'グリッド内のアクティブセルを設定します。

    Public Shared Sub PSb_LastEditableCellInGrid(ByRef grid As UserControl.UCGridEdit)

        If grid.Rows Is Nothing Then
            Exit Sub
        End If

        If grid.Rows.Count = 0 Then
            If grid.Rows.VisibleRowCount <> 0 Then
                For intBand = 0 To grid.DisplayLayout.Bands.Count - 1

                    For intCol As Integer = grid.DisplayLayout.Bands(intBand).Columns.Count - 1 To 0 Step -1
                        If grid.DisplayLayout.Bands(intBand).Columns(intCol).Hidden = False Then
                            If grid.DisplayLayout.Bands(intBand).Columns(intCol).CellActivation = Activation.NoEdit Then
                            Else
                                grid.ActiveCell = grid.DisplayLayout.Rows.TemplateAddRow.Cells(intCol)
                                grid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)

                                Exit Sub
                            End If
                        End If
                    Next
                Next

            End If
        Else

            For intBand = 0 To grid.DisplayLayout.Bands.Count - 1

                For intRow As Integer = grid.DisplayLayout.Rows.Count - 1 To 0 Step -1
                    For intCol As Integer = grid.DisplayLayout.Bands(intBand).Columns.Count - 1 To 0 Step -1
                        If grid.DisplayLayout.Bands(intBand).Columns(intCol).Hidden = False Then
                            If grid.DisplayLayout.Rows(intRow).Cells(intCol).Activation = Activation.NoEdit OrElse _
                                grid.DisplayLayout.Bands(intBand).Columns(intCol).CellActivation = Activation.NoEdit Then
                            Else
                                grid.ActiveCell = grid.DisplayLayout.Rows(intRow).Cells(intCol)
                                grid.ActiveCell.Appearance.BackColor = ColorEnter  'Color.PapayaWhip
                                grid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                                Exit Sub
                            End If
                        End If
                    Next

                Next

            Next

        End If

    End Sub
#End Region

#Region " PFn_SetGridName"
    ''グリッドにデータソースを指定します。
    Public Shared Function PFn_SetGridName(ByVal dt As DataTable, _
                                           ByVal ugrd As UserControl.UCGrid) As Boolean

        Dim i As Integer

        For i = 0 To ugrd.DisplayLayout.Bands(0).Columns.Count - 1
            dt.Columns(i).ColumnName = ugrd.DisplayLayout.Bands(0).Columns(i).Key
        Next i

        ugrd.DataSource = dt

        Return True

    End Function

    Public Shared Function PFn_SetGridName(ByVal dt As DataTable, _
                                       ByVal ugrd As UserControl.UCGridEdit) As Boolean

        Dim i As Integer

        For i = 0 To ugrd.DisplayLayout.Bands(0).Columns.Count - 1
            dt.Columns(i).ColumnName = ugrd.DisplayLayout.Bands(0).Columns(i).Key
        Next i

        ugrd.DataSource = dt

        Return True

    End Function

#End Region

#Region "NULLを文字列に変化する"

    ''' <summary>
    ''' 文字列に変化する
    ''' </summary>
    ''' <param name="objValue">変化前に文字</param>
    ''' <returns>対象　または　文字列</returns>
    ''' <remarks>文字列に変化する</remarks>
    Public Shared Function NullToString(ByVal objValue As Object) As String
        If objValue Is Nothing OrElse Information.IsDBNull(objValue) Then
            Return String.Empty
        Else
            Try
                NullToString = Convert.ToString(objValue)
            Catch ex As Exception
                Return String.Empty
            End Try
        End If
    End Function

   
    Public Shared Function NullToZero(ByVal objValue As Object) As Object
        If objValue Is Nothing OrElse Information.IsDBNull(objValue) Then
            Return 0
        Else
            Return objValue
        End If
    End Function

   
    Public Shared Function EmptyToZero(ByVal objValue As Object) As Object
        If objValue Is Nothing OrElse _
            Information.IsDBNull(objValue) OrElse _
             objValue.ToString.Equals(String.Empty) Then
            Return 0
        Else
            Return objValue
        End If
    End Function

#End Region

#Region "PFn_ExcelToDataTable"
    Public Shared Function PFn_ExcelToDataTable(FileName As String) As DataTable

        Dim dtRetrunTable As New DataTable

        Dim strConn As String = ("Provider=Microsoft.Ace.OleDb.12.0;" & "data source=") + FileName & ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'"

        Dim conn As New OleDb.OleDbConnection(strConn)
        conn.Open()

        Dim myDataSet As DataSet = New DataSet

        Dim strExcel = "SELECT * FROM [sheet1$]"


        Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(strExcel, conn)
            Try
                da.Fill(myDataSet)
                dtRetrunTable = myDataSet.Tables(0)
            Catch ex As Exception

            Finally
                conn = Nothing
                da.Dispose()
            End Try

        End Using

        Return dtRetrunTable

    End Function

#End Region

    Public Shared Function PFn_DataTableToExcel(ByVal Table As DataTable, ByVal FileName As String) As Boolean

        Dim oExcel As New Excel.Application

        Dim obook As Excel.Workbook

        Dim oSheet As Excel.Worksheet

        Try

            obook = oExcel.Workbooks.Add '(Directory.GetCurrentDirectory() & "\Templates\Template_Export.xlsx")

            oSheet = obook.Worksheets(1)

            'oSheet.Name = SheetName

            Dim r As Integer, c As Integer

            Dim rCount As Integer

            Dim cCount As Integer

            rCount = Table.Rows.Count

            cCount = Table.Columns.Count()

            For c = 1 To cCount

                oSheet.Cells(1, c) = Table.Columns(c - 1).Caption '设置列标题

            Next

            c = 0 : r = 0

            For r = 1 To rCount

                For c = 1 To cCount

                    oSheet.Columns(c).EntireColumn.NumberFormatLocal = "@"
                    oSheet.Cells(r + 1, c) = CStr(Table.Rows(r - 1)(c - 1).ToString)

                Next
                oSheet.Columns.EntireColumn.AutoFit() '列宽自适应。
            Next

            obook.Saved = True
            obook.SaveCopyAs(FileName)

            Return True

        Catch ex As Exception

            Return False
        Finally

            oExcel = Nothing
            obook = Nothing
            oSheet = Nothing
        End Try

    End Function



    Public Shared Function IsDigit(ByVal e As Char) As Boolean

        If Char.IsDigit(e) Or Asc(e) = Keys.Back Or Asc(e) = Keys.Enter Or Asc(e) = Keys.Delete Then
            Return False    '数字
        End If
        Return True

    End Function
End Class