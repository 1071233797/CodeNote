Option Strict On

Imports System.Data.SqlClient
Imports HRJS.Constant
Imports HRJS.Utility
Imports System.Text

#Region "DbHelper説明"
''' <summary>
'''  DBへアクセスの方法実見する
''' </summary>
''' <remarks></remarks>
''' <history>
''' 	[ ]	2011/09/09	Created
''' </history>
#End Region

Public Class DbHelper

#Region " 変数定義"

    Private Const mcModuleName As String = "DBHelper"   'モジュール名称
    Private mConnection As SqlConnection                'データベースコネクト
    'Sharedで連接
    Private Shared mSharedConnection As SqlConnection

    Private mDataAdapter As SqlDataAdapter              'データベースアダプタ
    Private mTransaction As SqlTransaction              'トランザクション
    Private mCommand As SqlCommand                      'コマンド


    Public ReadOnly Property Trans() As SqlTransaction
        Get
            Return mTransaction
        End Get
    End Property

    Public ReadOnly Property Conn() As SqlConnection
        Get
            Return mConnection
        End Get
    End Property

#End Region

#Region " 構造関数"

#Region " New()"

    '--------------------------------------------------------------------------------
    '概要

    '   新しいオブジェクト

    '作成   
    '    [2013-01-04]
    'パラメタ説明

    '   なし

    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Public Sub New()

        Dim strDBConnection As String               'DBの連接文字

        'DBの連接文字を取得する
        strDBConnection = Me.Fn_GetDBConnectionString()

        '空を判断する
        If String.Empty.Equals(strDBConnection) Then

            '連絡失敗の異常を戻る
            Throw New Exception(CON_OPENDB_ERROR)

            '処理关闭
            Exit Sub
        End If

        Try
            'DBオブジェクトを作成する
            mConnection = New SqlConnection(strDBConnection)
            mCommand = New SqlCommand()
            mCommand.Connection = mConnection

            'DBアクセスを判断する
            If Not mConnection.State = ConnectionState.Open Then
                'DBを開く
                mConnection.Open()
            End If
        Catch ex As Exception
            'オラクルコマンドを解放する
            If Not mCommand Is Nothing Then
                mCommand.Dispose()
                mCommand = Nothing
            End If

            'DB連接を解放する
            If Not mConnection Is Nothing Then
                If mConnection.State = ConnectionState.Open Then
                    mConnection.Close()
                End If
                mConnection.Dispose()
                mConnection = Nothing
            End If

            '連絡失敗の異常を戻る
            Throw New Exception(CON_OPENDB_ERROR)
        End Try

    End Sub

#End Region

#End Region

#Region " 私有関数"

#Region " OpenConnection()"


    Private Function Fn_GetDBConnectionString() As String
        'DBの連接文字を取得する
        Fn_GetDBConnectionString = ConfigInfo.DBConnectionString
    End Function

    '--------------------------------------------------------------------------------
    '概要

    '   データベースの接続を開ける

    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   なし

    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Private Sub OpenConnection()

        Const cMethodName As String = "OpenConnection"  'メソッド名称

        Try
            If mConnection.State = ConnectionState.Closed Then
                mConnection.Open()
            End If
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#Region " CloseConnection()"

    '--------------------------------------------------------------------------------
    '概要

    '   データベース接続を切断する
    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   なし

    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Private Sub CloseConnection()

        Const cMethodName As String = "CloseConnection" 'メソッド名称

        Try
            If mConnection.State = ConnectionState.Open Then
                mConnection.Close()
                Utility.PSb_WriteLOGFile(2)
            End If
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#Region " PrepareCommand()"

    '--------------------------------------------------------------------------------
    '概要

    '   コマンドをセット
    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   strCommandText:(In) ->Sql文

    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Private Sub PrepareCommand(ByVal strCommandText As String)

        Const cMethodName As String = "PrepareCommand"  'メソッド名称

        Try
            mCommand.CommandText = strCommandText
            mCommand.CommandType = CommandType.Text
            mCommand.CommandTimeout = ConfigInfo.DBTimeOut
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#Region " PrepareCommandPro()"

    '--------------------------------------------------------------------------------
    '概要

    '   コマンドをセット
    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   strCommandText:(In) ->Sql文

    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Private Sub PrepareCommandPro(ByVal strCommandText As String, ByVal paraValus As SqlParameter())

        Const cMethodName As String = "PrepareCommandPro"  'メソッド名称
        Dim i As Integer

        Try
            mCommand.CommandText = strCommandText
            mCommand.CommandType = CommandType.StoredProcedure

            mCommand.Parameters.Clear()

            For i = 0 To paraValus.Length - 1
                mCommand.Parameters.Add(paraValus(i))
            Next i

        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#End Region

#Region " 共有関数"

#Region " BeginTransaction"

    '--------------------------------------------------------------------------------
    '概要

    '   事務処理開始

    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   なし

    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Public Sub PSb_BeginTransaction()

        Const cMethodName As String = "BeginTransaction"    'メソッド名称

        Try
            'LOGファイルを出力する
            Utility.PSb_WriteLOGFile(4, "Begin")

            mTransaction = mConnection.BeginTransaction
            mCommand.Transaction = mTransaction
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#Region " PSb_Commit"

    '--------------------------------------------------------------------------------
    '概要

    '   事務処理コミット

    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   なし

    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Public Sub PSb_Commit()

        Const cMethodName As String = "PSb_Commit"  'メソッド名称

        Try
            'LOGファイルを出力する
            Utility.PSb_WriteLOGFile(4, "PSb_Commit")

            mTransaction.Commit()
            mTransaction.Dispose()
            mTransaction = Nothing
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#Region " Rollback()"

    '--------------------------------------------------------------------------------
    '概要

    '   事務処理ロールバック
    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   なし

    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Public Sub PSb_Rollback()

        Const cMethodName As String = "PSb_Rollback"    'メソッド名称

        Try
            If Not mTransaction Is Nothing Then

                'LOGファイルを出力する
                Utility.PSb_WriteLOGFile(4, "PSb_Rollback")

                mTransaction.Rollback()
                mTransaction.Dispose()
                mTransaction = Nothing
            End If
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#Region " PSb_CloseDB()"

    '--------------------------------------------------------------------------------
    '概要

    '   使用されているリソースを解放します

    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   なし

    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Public Sub PSb_CloseDB()

        Const cMethodName As String = "PSb_CloseDB" 'メソッド名称

        Try
            CloseConnection()

            mCommand.Dispose()
            mConnection.Dispose()

            mCommand = Nothing
            mConnection = Nothing
        Catch ex As Exception
            Utility.PSb_WriteLOGFile(2)
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#Region " PFn_ExcuteReader(ByVal strCommandText As String) As SqlDataReader"

    '--------------------------------------------------------------------------------
    '概要

    '   コマンドが実行されます

    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   strCommandText:(In) ->Sql文

    '戻り値
    '   SqlDataReader
    '--------------------------------------------------------------------------------
    Public Function PFn_ExcuteReader(ByVal strCommandText As String) As SqlDataReader

        Const cMethodName As String = "PFn_ExcuteReader"    'メソッド名称

        Try

            'LOGファイルを出力する
            Utility.PSb_WriteLOGFile(2, strCommandText)

            Me.PrepareCommand(strCommandText)

            Return mCommand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(mcModuleName & "." & cMethodName, ex)
        End Try

    End Function

#End Region

#Region " PFn_ExcuteScalar(ByVal strCommandText As String) As Object"

    '--------------------------------------------------------------------------------
    '概要

    '   クエリを実行し、そのクエリが返す結果セットの最初の行にある最初の列を返します。

    '   残りの列または行は無視されます

    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   strCommandText:(In) ->Sql文

    '戻り値
    '   Object:結果セットの最初の行の最初の列。結果セットが空の場合は、null 参照
    '--------------------------------------------------------------------------------
    Public Function PFn_ExcuteScalar(ByVal strCommandText As String) As Object

        Const cMethodName As String = "PFn_ExcuteScalar"    'メソッド名称

        Try
            'LOGファイルを出力する
            Utility.PSb_WriteLOGFile(2, strCommandText)

            Me.PrepareCommand(strCommandText)

            Return mCommand.ExecuteScalar
        Catch ex As Exception
            Throw New Exception(mcModuleName & "." & cMethodName, ex)
        End Try

    End Function

#End Region

#Region " PFn_FillDataSet(ByVal strCommandText As String) As DataSet"

    '--------------------------------------------------------------------------------
    '概要

    '   コマンドが実行されます

    '作成   
    '    [2013-03-18]
    'パラメタ説明

    '   strCommandText: (In) ->Sql文

    '戻り値
    '   dataSet: レコードおよび必要に応じてスキーマを格納するための System.Data.DataSet
    '--------------------------------------------------------------------------------
    Public Function PFn_FillDataSet(ByVal strCommandText As String) As DataSet

        Const cMethodName As String = "PFn_FillDataSet" 'メソッド名称
        Dim ds As New DataSet

        Try
            Me.PrepareCommand(strCommandText)

            mDataAdapter = New SqlDataAdapter(mCommand)

            mDataAdapter.Fill(ds)

            Return ds
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Function

#End Region

#Region " PFn_FillDataTable(ByVal strCommandText As String) As DataTable"

    '--------------------------------------------------------------------------------
    '概要

    '   コマンドが実行されます

    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   strCommandText: (In) ->Sql文

    '戻り値
    '   dataTable: レコードおよび必要に応じてスキーマを格納するための System.Data.DataTable
    '--------------------------------------------------------------------------------
    Public Function PFn_FillDataTable(ByVal strCommandText As String) As DataTable

        Const cMethodName As String = "PFn_FillDataTable"   'メソッド名称
        Dim dt As New DataTable

        Try
            'LOGファイルを出力する
            Utility.PSb_WriteLOGFile(2, strCommandText)

            Me.PrepareCommand(strCommandText)

            mDataAdapter = New SqlDataAdapter(mCommand)

            mDataAdapter.Fill(dt)

            Return dt
        Catch ex As Exception
            Throw New Exception(mcModuleName & "." & cMethodName, ex)
        End Try

    End Function

#End Region

#Region " PFn_ExcuteDB(ByVal strCommandText As String) As Integer"

    '--------------------------------------------------------------------------------
    '概要

    '   接続に対して Transact-SQL ステートメントを実行し、影響を受けた行数を返します

    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   strCommandText:(In) ->Sql文

    '戻り値
    '   Integer:影響を受けた行数
    '--------------------------------------------------------------------------------
    Public Function PFn_ExcuteDB(ByVal strCommandText As String) As Integer

        Const cMethodName As String = "PFn_ExcuteDB"  'メソッド名称

        Try
            'LOGファイルを出力する
            Utility.PSb_WriteLOGFile(2, strCommandText)

            Me.PrepareCommand(strCommandText)

            Return mCommand.ExecuteNonQuery
        Catch ex As Exception
            Throw New Exception(mcModuleName & "." & cMethodName, ex)
        End Try

    End Function

#End Region

#Region "PFn_Sh_SelectProcedure"
    ''' <summary>
    ''' プロシージを実行する
    ''' </summary>
    ''' <param name="strProcedureName">プロシージ名</param>
    ''' <param name="paras">プロシージの引数</param>
    ''' <param name="intTimeOut">タイムアウト時間</param>
    ''' <remarks>プロシージを実行する</remarks>
    Public Shared Function PFn_Sh_SelectProcedure(ByVal strProcedureName As String, _
                                      ByVal paras() As SqlParameter, _
                                      Optional ByVal intTimeOut As Integer = 0) As Integer
        Dim sqlCom As SqlCommand = Nothing

        'DB連接を開く
        If Not Fn_OpenDB() Then
            PFn_Sh_SelectProcedure = -1

            '連絡失敗の異常を戻る
            Throw New Exception(Constant.CON_OPENDB_ERROR)

            Exit Function
        End If

        Try
            'SQL文を追加する
            sqlCom = New SqlCommand(strProcedureName, mSharedConnection)

            sqlCom.CommandType = CommandType.StoredProcedure

            'タイムアウト時間を判断する
            If 0 < intTimeOut Then
                '自定義の時間をセットする
                sqlCom.CommandTimeout = intTimeOut
            Else
                'システムの時間をセットする
                sqlCom.CommandTimeout = ConfigInfo.DBTimeOut
            End If

            '項目の値をセットする
            If Not paras Is Nothing Then
                '項目をループする
                For i = 0 To paras.Length - 1
                    'SQLの中、変数をセットする
                    sqlCom.Parameters.Add(paras(i))
                Next
            End If

            'LOGファイルを出力する--paras
            Utility.PSb_WriteLOGFileSQL(2, strProcedureName, paras)

            'DBを実行する
            PFn_Sh_SelectProcedure = sqlCom.ExecuteNonQuery()

            'オブジェクトの初期化をセットする
            sqlCom.CommandText = ""

            '引数を解放する
            sqlCom.Parameters.Clear()

            'オブジェクトを解放する
            sqlCom.Dispose()

            'DBを閉じる
            Call Sb_CloseDB()

            mSharedConnection = Nothing
        Catch ex As Exception
            PFn_Sh_SelectProcedure = -1

            '引数を解放する
            If Not sqlCom Is Nothing Then
                sqlCom.Parameters.Clear()
            End If

            'DBを閉じる
            Call Sb_CloseDB()

            ''異常メッセージを表示する
            'MsgBox(ex.ToString())
            Throw ex
        End Try
    End Function
#End Region

#Region " PFn_ExcuteProcedures"

    '-----------------------------------------------------------------------------
    '  概要
    '   接続に対して Transact-SQL ステートメントを実行し、影響を受けた行数を返します
    '  パラメタ説明
    '   commandText:(In) ->Sql文
    '   spPara():パラメタのArray
    '  機能説明
    '   接続に対して Transact-SQL ステートメントを実行し、影響を受けた行数を返します
    '  戻り値
    '   Integer:影響を受けた行数
    '  作成者
    '    関　明玉　 
    '  備考
    '    タイムアウト時間設定 180 秒
    '-----------------------------------------------------------------------------
    Public Function PFn_ExcuteProcedures(ByVal commandText As String, _
                                     ByVal spPara() As SqlClient.SqlParameter, _
                                     Optional ByRef outNVarNmString As String = "", _
                                     Optional ByVal ParamBtn As Boolean = False, _
                                     Optional ByVal intTimeOut As Integer = 0) As String

        Const cMethodName As String = "PFn_ExcuteProcedures"   'メソッド名称

        Try

            Dim ReturnValue As Integer          '影響を受けた行数
            Dim ParamString As String           'パラメタ

            ParamString = "@return"

            'LOGファイルを出力する--paras
            Utility.PSb_WriteLOGFileSQL(2, commandText, spPara)

            '接続に対して
            Me.PrepareCommandPro(commandText, spPara)

            'ステートメントを実行し
            mCommand.CommandTimeout = 180

            ''タイムアウト時間を判断する
            'If 0 < intTimeOut Then
            '    '自定義の時間をセットする
            '    mCommand.CommandTimeout = intTimeOut
            'Else
            '    'システムの時間をセットする
            '    mCommand.CommandTimeout = ConfigInfo.DBTimeOut
            'End If

            mCommand.ExecuteNonQuery()

            If outNVarNmString <> String.Empty Then
                outNVarNmString = mCommand.Parameters(outNVarNmString).Value.ToString.Trim
            End If

            If ParamBtn Then
                '影響を受けた行数を返します

                ReturnValue = Convert.ToInt32(mCommand.Parameters(ParamString).Value)
            End If

            '影響を受けた行数を戻し

            mCommand.Parameters.Clear()

            If ParamBtn Then
                Return Convert.ToString(ReturnValue)
            Else
                Return outNVarNmString
            End If

        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Function

#End Region

#End Region

#Region "Shared方法(類調用)"
   
    Private Shared Function Fn_OpenDB() As Boolean
        Try
            'DBオブジェクトを作成する
            mSharedConnection = New SqlConnection(ConfigInfo.DBConnectionString)

            'DBアクセスを判断する
            If Not mSharedConnection.State = ConnectionState.Open Then
                'DBを開く
                mSharedConnection.Open()
            End If

            Fn_OpenDB = True
        Catch ex As Exception

            Fn_OpenDB = False

            'DB連接を解放する
            If Not mSharedConnection Is Nothing Then
                If mSharedConnection.State = ConnectionState.Open Then
                    mSharedConnection.Close()
                End If
                mSharedConnection.Dispose()
                mSharedConnection = Nothing
            End If

            '連絡失敗の異常を戻る
            Throw New Exception(CON_OPENDB_ERROR)
        End Try
    End Function

    ''' <summary>
    ''' DBを閉じる
    ''' </summary>
    ''' <remarks>DBを閉じる</remarks>
    Private Shared Sub Sb_CloseDB()
        If mSharedConnection Is Nothing Then
            Exit Sub
        End If

        Try
            If mSharedConnection.State = ConnectionState.Open Then
                'DBを閉じる
                mSharedConnection.Close()
                mSharedConnection.Dispose()
                mSharedConnection = Nothing
                Utility.PSb_WriteLOGFile(2)
            End If
        Catch ex As Exception
            mSharedConnection.Dispose()
            mSharedConnection = Nothing
            Utility.PSb_WriteLOGFile(2)
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' DBからデータを戻る(Shared専用)
    ''' </summary>
    ''' <param name="strSQLBuilder">SQL文</param>
    ''' <param name="htPara">引数</param>
    ''' <param name="intTimeOut">タイムアウト時間</param>
    ''' <returns>テーブル</returns>
    ''' <remarks>DBからデータを戻る</remarks>
    Public Function PFn_SelectDB(ByVal strSQLBuilder As StringBuilder, _
                                        Optional ByVal htPara As Hashtable = Nothing, _
                                        Optional ByVal blnIsProcedure As Boolean = False, _
                                        Optional ByVal intTimeOut As Integer = 0) As DataTable
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim enumerator As IDictionaryEnumerator
        Dim ds As DataSet

        Try
            ''SQL文の存在を判断する
            'If strSQLBuilder Is Nothing Then
            '    PFn_ExcuteDB = -1
            '    Exit Function
            'End If

            'SQL文を追加する
            mCommand.CommandText = strSQLBuilder.ToString()

            'ストアド プロシージャを判断する
            If blnIsProcedure Then
                mCommand.CommandType = CommandType.StoredProcedure
            Else
                mCommand.CommandType = CommandType.Text
            End If

            'SQL文を追加する
            adapter.SelectCommand = mCommand

            'タイムアウト時間を判断する
            If 0 < intTimeOut Then
                '自定義の時間をセットする
                mCommand.CommandTimeout = intTimeOut
            Else
                'システムの時間をセットする
                mCommand.CommandTimeout = ConfigInfo.DBTimeOut
            End If

            '項目の値をセットする
            If Not htPara Is Nothing Then
                '臨時オブジェクトを変化する
                enumerator = htPara.GetEnumerator

                '項目をループする
                While enumerator.MoveNext()
                    'SQLの中、変数をセットする
                    If PFn_IsNothingOrNull(enumerator.Value) Then
                        mCommand.Parameters.AddWithValue("@" & PFn_ToString(enumerator.Key), DBNull.Value)
                    Else
                        mCommand.Parameters.AddWithValue("@" & PFn_ToString(enumerator.Key), enumerator.Value)
                    End If
                End While
            End If

            ds = New DataSet

            'LOGファイルを出力する
            Call Utility.PSb_WriteLOGFile(2, strSQLBuilder.ToString, htPara)

            'DBを検索する
            adapter.Fill(ds)

            '引数を解放する
            adapter.SelectCommand.Parameters.Clear()

            'オブジェクトを解放する
            adapter.Dispose()

            '検索したデータを戻る
            PFn_SelectDB = ds.Tables(0).Copy()

            ds = Nothing

            adapter = Nothing

            'オブジェクトの初期化をセットする
            mCommand.CommandText = String.Empty

            '引数を解放する
            mCommand.Parameters.Clear()
        Catch ex As Exception

            PFn_SelectDB = Nothing

            '引数を解放する
            adapter.SelectCommand.Parameters.Clear()

            'オブジェクトを解放する
            adapter.Dispose()
            adapter = Nothing

            '引数を解放する
            mCommand.Parameters.Clear()

            'オブジェクトの初期化をセットする
            mCommand.CommandText = String.Empty

            ''異常メッセージを表示する
            'MsgBox(ex.ToString())
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' DBからデータを戻る(Shared専用)
    ''' </summary>
    ''' <param name="strSQLBuilder">SQL文</param>
    ''' <param name="htPara">引数</param>
    ''' <param name="intTimeOut">タイムアウト時間</param>
    ''' <returns>テーブル</returns>
    ''' <remarks>DBからデータを戻る</remarks>
    Public Shared Function PFn_Sh_SelectDB(ByVal strSQLBuilder As StringBuilder, _
                                        Optional ByVal htPara As Hashtable = Nothing, _
                                        Optional ByVal blnIsProcedure As Boolean = False, _
                                        Optional ByVal intTimeOut As Integer = 0) As DataTable
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()
        Dim enumerator As IDictionaryEnumerator
        Dim ds As DataSet

        'DB連接を開く
        If Not Fn_OpenDB() Then
            PFn_Sh_SelectDB = Nothing

            '連絡失敗の異常を戻る
            Throw New Exception(CON_OPENDB_ERROR)

            Exit Function
        End If

        ''SQL文の存在を判断する
        'If strSQLBuilder Is Nothing Then
        '    PFn_Sh_SelectDB = Nothing
        '    Exit Function
        'End If

        Try
            'SQL文を追加する
            adapter.SelectCommand = New SqlCommand(strSQLBuilder.ToString(), mSharedConnection)

            'ストアド プロシージャを判断する
            If blnIsProcedure Then
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            Else
                adapter.SelectCommand.CommandType = CommandType.Text
            End If

            'タイムアウト時間を判断する
            If 0 < intTimeOut Then
                '自定義の時間をセットする
                adapter.SelectCommand.CommandTimeout = intTimeOut
            Else
                'システムの時間をセットする
                adapter.SelectCommand.CommandTimeout = ConfigInfo.DBTimeOut
            End If

            '項目の値をセットする
            If Not htPara Is Nothing Then
                '臨時オブジェクトを変化する
                enumerator = htPara.GetEnumerator

                '項目をループする
                While enumerator.MoveNext()
                    'SQLの中、変数をセットする
                    If PFn_IsNothingOrNull(enumerator.Value) Then
                        'mOracleCommand.Parameters.AddWithValue(":" & PFn_ToString(enumerator.Key), DBNull.Value)
                        adapter.SelectCommand.Parameters.AddWithValue("@" & PFn_ToString(enumerator.Key), DBNull.Value)
                    Else
                        adapter.SelectCommand.Parameters.AddWithValue("@" & PFn_ToString(enumerator.Key), enumerator.Value)
                    End If
                End While
            End If

            ds = New DataSet

            'LOGファイルを出力する
            Call Utility.PSb_WriteLOGFile(2, strSQLBuilder.ToString, htPara)

            'DBを検索する
            adapter.Fill(ds)

            '引数を解放する
            adapter.SelectCommand.Parameters.Clear()

            'オブジェクトを解放する
            adapter.Dispose()

            'DBを閉じる
            Call Sb_CloseDB()

            '検索したデータを戻る
            PFn_Sh_SelectDB = ds.Tables(0).Copy()

            'データセットを解放する
            ds.Dispose()
            ds = Nothing

            adapter = Nothing
            mSharedConnection = Nothing
        Catch ex As Exception
            PFn_Sh_SelectDB = Nothing

            '引数を解放する
            adapter.SelectCommand.Parameters.Clear()

            'オブジェクトを解放する
            adapter.Dispose()
            adapter = Nothing

            'DBを閉じる
            Call Sb_CloseDB()

            ''異常メッセージを表示する
            'MsgBox(ex.ToString())
            Throw ex
        End Try
    End Function


    ''' <summary>
    ''' DBの操作処理(新規、修正、削除)(Shared専用)
    ''' </summary>
    ''' <param name="strSQLBuilder">SQL文</param>
    ''' <param name="htPara">SQL文の引数</param>
    ''' <param name="intTimeOut">タイムアウト時間</param>
    ''' <returns>操作の行数</returns>
    ''' <remarks>DBの操作処理(新規、修正、削除)</remarks>
    Public Shared Function PFn_Sh_ExcuteDB(ByVal strSQLBuilder As StringBuilder, _
                                        Optional ByVal htPara As Hashtable = Nothing, _
                                        Optional ByVal intTimeOut As Integer = 0) As Integer
        Dim sqlCom As SqlCommand = Nothing
        Dim enumerator As IDictionaryEnumerator

        'DB連接を開く
        If Not Fn_OpenDB() Then
            PFn_Sh_ExcuteDB = -1

            '連絡失敗の異常を戻る
            Throw New Exception(Constant.CON_OPENDB_ERROR)

            Exit Function
        End If

        ''SQL文の存在を判断する
        'If strSQLBuilder Is Nothing Then
        '    PFn_Sh_ExcuteDB = -1
        '    Exit Function
        'End If

        Try
            'SQL文を追加する
            sqlCom = New SqlCommand(strSQLBuilder.ToString(), mSharedConnection)
            sqlCom.CommandType = CommandType.Text

            'タイムアウト時間を判断する
            If 0 < intTimeOut Then
                '自定義の時間をセットする
                sqlCom.CommandTimeout = intTimeOut
            Else
                'システムの時間をセットする
                sqlCom.CommandTimeout = ConfigInfo.DBTimeOut
            End If

            '項目の値をセットする
            If Not htPara Is Nothing Then
                '臨時オブジェクトを変化する
                enumerator = htPara.GetEnumerator

                '項目をループする
                While enumerator.MoveNext()
                    'SQLの中、変数をセットする
                    If PFn_IsNothingOrNull(enumerator.Value) Then
                        sqlCom.Parameters.AddWithValue("@" & PFn_ToString(enumerator.Key), DBNull.Value)
                    Else
                        sqlCom.Parameters.AddWithValue("@" & PFn_ToString(enumerator.Key), enumerator.Value)
                    End If
                End While
            End If

            'LOGファイルを出力する
            Call Utility.PSb_WriteLOGFile(2, strSQLBuilder.ToString, htPara)

            'DBを実行する
            PFn_Sh_ExcuteDB = sqlCom.ExecuteNonQuery()

            '引数を解放する
            sqlCom.Parameters.Clear()

            'オブジェクトを解放する
            sqlCom.Dispose()

            'DBを閉じる
            Call Sb_CloseDB()

            mSharedConnection = Nothing
        Catch ex As Exception
            PFn_Sh_ExcuteDB = -1

            '引数を解放する
            If Not sqlCom Is Nothing Then
                sqlCom.Parameters.Clear()
            End If

            'DBを閉じる
            Call Sb_CloseDB()

            ''異常メッセージを表示する
            'MsgBox(ex.ToString())
            Throw ex
        End Try
    End Function
#End Region


#Region "DB時間を戻る"

#Region "GetDBTime"

    Public Function PFn_GetDBTime(Optional ByVal int格式 As Integer = 121) As String

        Const mcMethodName As String = "PFn_GetDBTime"   'メソッド名称

        Try
            Dim ReturnTime As String                        'システム時間
            Dim WhereString As New StringBuilder(String.Empty)           'SQL文 

            '検索

            'SQL文 
            'WhereString.Append("select convert(varchar,getdate(),111) + ' ' + convert(varchar,getdate(),114)")
            WhereString.Append("select convert(varchar,getdate()," & int格式 & ")")

            'システム時間戻し 
            ReturnTime = Convert.ToString(PFn_ExcuteScalar(WhereString.ToString))

            Return ReturnTime

        Catch ex As Exception

            Throw New Exception(mcModuleName & mcMethodName, ex)

        End Try

    End Function

    Public Function PFn_GetDBTimeDT(Optional ByVal int格式 As Integer = 121) As DateTime

        Const mcMethodName As String = "PFn_GetDBTime"   'メソッド名称

        Try
            Dim ReturnTime As DateTime                        'システム時間
            Dim WhereString As New StringBuilder(String.Empty)           'SQL文 

            '検索

            'SQL文 
            'WhereString.Append("select convert(varchar,getdate(),111) + ' ' + convert(varchar,getdate(),114)")
            WhereString.Append("select convert(varchar,getdate()," & int格式 & ")")

            'システム時間戻し 
            ReturnTime = Convert.ToDateTime(PFn_ExcuteScalar(WhereString.ToString))

            Return ReturnTime

        Catch ex As Exception

            Throw New Exception(mcModuleName & mcMethodName, ex)

        End Try

    End Function
#End Region

#End Region

End Class
