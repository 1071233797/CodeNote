Option Strict On

Imports System.Data.SqlClient
Imports System.Data

#Region "DbHelper説明"

'--------------------------------------------------------------------------------
'概要


'   DBへアクセスの方法実見する


'作成
'   KDC鄭頴君 [2007-06-15]
'--------------------------------------------------------------------------------

#End Region
Public Class DbHelper

#Region " 変数定義"

    Private Const mcModuleName As String = "DBHelper"   'モジュール名称
    Private mConnection As SqlConnection                'データベースコネクト


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
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   なし


    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Public Sub New()

        Const cMethodName As String = "New"     'メソッド名称

        Try
            mConnection = New SqlConnection(TCXml.readXMl("ConnStr"))
            mCommand = New SqlCommand("", mConnection)
            Me.OpenConnection()
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#End Region

#Region " 私有関数"

#Region " OpenConnection()"

    '--------------------------------------------------------------------------------
    '概要


    '   データベースの接続を開ける

    '作成   
    '   KDC鄭頴君 [2007-06-18]
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
    '   KDC鄭頴君 [2007-06-18]
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
    '   KDC鄭頴君 [2007-06-18]
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
    '   KDC鄭頴君 [2007-06-18]
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
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   なし


    '戻り値
    '   なし


    '--------------------------------------------------------------------------------
    Public Sub BeginTransaction()

        Const cMethodName As String = "BeginTransaction"    'メソッド名称

        Try
            mTransaction = mConnection.BeginTransaction
            mCommand.Transaction = mTransaction
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#Region " Commit"

    '--------------------------------------------------------------------------------
    '概要


    '   事務処理コミット


    '作成   
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   なし


    '戻り値
    '   なし


    '--------------------------------------------------------------------------------
    Public Sub Commit()

        Const cMethodName As String = "Commit"  'メソッド名称

        Try
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
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   なし


    '戻り値
    '   なし


    '--------------------------------------------------------------------------------
    Public Sub Rollback()

        Const cMethodName As String = "Rollback"    'メソッド名称

        Try
            If Not mTransaction Is Nothing Then
                mTransaction.Rollback()
                mTransaction.Dispose()
                mTransaction = Nothing
            End If
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#Region " Dispose()"

    '--------------------------------------------------------------------------------
    '概要


    '   使用されているリソースを解放します

    '作成   
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   なし


    '戻り値
    '   なし


    '--------------------------------------------------------------------------------
    Public Sub Dispose()

        Const cMethodName As String = "Dispose" 'メソッド名称

        Try
            CloseConnection()

            mCommand.Dispose()
            mConnection.Dispose()

            mCommand = Nothing
            mConnection = Nothing
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Sub

#End Region

#Region " ExcuteNonQuery(ByVal strCommandText As String) As Integer"

    '--------------------------------------------------------------------------------
    '概要


    '   接続に対して Transact-SQL ステートメントを実行し、影響を受けた行数を返します


    '作成   
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   strCommandText:(In) ->Sql文

    '戻り値
    '   Integer:影響を受けた行数
    '--------------------------------------------------------------------------------
    Public Function ExcuteNonQuery(ByVal strCommandText As String) As Integer

        Const cMethodName As String = "ExcuteNonQuery"  'メソッド名称

        Try
            Me.PrepareCommand(strCommandText)

            Return mCommand.ExecuteNonQuery
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Function

#End Region

#Region " ExcuteReader(ByVal strCommandText As String) As SqlDataReader"

    '--------------------------------------------------------------------------------
    '概要


    '   コマンドが実行されます

    '作成   
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   strCommandText:(In) ->Sql文

    '戻り値
    '   SqlDataReader
    '--------------------------------------------------------------------------------
    Public Function ExcuteReader(ByVal strCommandText As String) As SqlDataReader

        Const cMethodName As String = "ExcuteReader"    'メソッド名称

        Try
            Me.PrepareCommand(strCommandText)

            Return mCommand.ExecuteReader
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Function

#End Region

#Region " ExcuteScalar(ByVal strCommandText As String) As Object"

    '--------------------------------------------------------------------------------
    '概要


    '   クエリを実行し、そのクエリが返す結果セットの最初の行にある最初の列を返します。

    '   残りの列または行は無視されます

    '作成   
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   strCommandText:(In) ->Sql文

    '戻り値
    '   Object:結果セットの最初の行の最初の列。結果セットが空の場合は、null 参照
    '--------------------------------------------------------------------------------
    Public Function ExcuteScalar(ByVal strCommandText As String) As Object

        Const cMethodName As String = "ExcuteScalar"    'メソッド名称

        Try
            Me.PrepareCommand(strCommandText)

            Return mCommand.ExecuteScalar
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Function

#End Region

#Region " FillDataSet(ByVal strCommandText As String) As DataSet"

    '--------------------------------------------------------------------------------
    '概要


    '   コマンドが実行されます

    '作成   
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   strCommandText: (In) ->Sql文

    '戻り値
    '   dataSet: レCDおよび必要に応じてスキーマを格納するための System.Data.DataSet
    '--------------------------------------------------------------------------------
    Public Function FillDataSet(ByVal strCommandText As String) As DataSet

        Const cMethodName As String = "FillDataSet" 'メソッド名称
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

#Region " FillDataTable(ByVal strCommandText As String) As DataTable"

    '--------------------------------------------------------------------------------
    '概要


    '   コマンドが実行されます

    '作成   
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   strCommandText: (In) ->Sql文

    '戻り値
    '   dataTable: レCDおよび必要に応じてスキーマを格納するための System.Data.DataTable
    '--------------------------------------------------------------------------------
    Public Function FillDataTable(ByVal strCommandText As String) As DataTable

        Const cMethodName As String = "FillDataTable"   'メソッド名称
        Dim dt As New DataTable

        Try
            Me.PrepareCommand(strCommandText)

            mDataAdapter = New SqlDataAdapter(mCommand)

            mDataAdapter.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Function

#End Region

#Region " Public Function FillDataTablePro(ByVal strCommandText As String, ByVal paraValus As SqlParameter()) As DataTable"

    '--------------------------------------------------------------------------------
    '概要


    '   コマンドが実行されます

    '作成   
    '   KDC鄭頴君 [2007-06-18]
    'パラメタ説明


    '   strCommandText: (In) ->Sql文

    '戻り値
    '   dataTable: レCDおよび必要に応じてスキーマを格納するための System.Data.DataTable
    '--------------------------------------------------------------------------------
    Public Function FillDataTablePro(ByVal strCommandText As String, ByVal paraValus As SqlParameter()) As DataTable

        Const cMethodName As String = "FillDataTablePro"   'メソッド名称
        Dim dt As New DataTable

        Try
            Me.PrepareCommandPro(strCommandText, paraValus)

            mDataAdapter = New SqlDataAdapter(mCommand)
            mCommand.CommandTimeout = 300

            mDataAdapter.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception(mcModuleName & cMethodName, ex)
        End Try

    End Function

#End Region

#End Region

End Class