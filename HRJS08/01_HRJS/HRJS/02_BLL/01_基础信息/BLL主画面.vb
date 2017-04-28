Imports System.Text
Imports System.Data.SqlClient

Public Class BLL主画面
#Region "主画面"

#Region "UpdatePassWord"

    Public Function UpdatePassWord(ByVal objM人员T As M人员T) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbHelper As DbHelper = Nothing               'DBインスタンス
        Dim strRtnSQL As String = Nothing
        Dim objDal As New Dal主画面
        Dim strDBDateTime As String = String.Empty

        Try
            'データベースを接続する            objDbHelper = New DbHelper

            strDBDateTime = Utility.PFn_GetDBTime()

            '更新SQLを取得
            strRtnSQL = objDal.UpdatePassWordSQL(objM人员T)

            objDbHelper.PSb_BeginTransaction()

            '更新を実行する

            If objDbHelper.PFn_ExcuteDB(strRtnSQL.ToString) < 0 Then
                'ロールバック
                objDbHelper.PSb_Rollback()
                '保存処理終了
                Return Constant.ENU_RETURNTYPE.Failed
            End If

            '事務のコミット
            objDbHelper.PSb_Commit()

            'データベース接続を切断する
            objDbHelper.PSb_CloseDB()

            Return Constant.ENU_RETURNTYPE.Succeed

        Catch ex As Exception
            ExHelper.ProcessDBHelper(objDbHelper)
            Throw New Exception(MyMethodBase.ReflectedType.Name & "." & MyMethodBase.Name, ex)
        End Try
    End Function
#End Region

#Region "Check担当"

    Public Function Check担当(ByVal objM人员T As M人员T) As Boolean

        Dim dtTable As DataTable = Nothing          'データテーブル
        Dim objDal As New Dal主画面
        Dim objDbHelper As DbHelper = Nothing

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod

        Try

            'データベースを接続する            objDbHelper = New DbHelper

            'データの操作を実行する            dtTable = objDbHelper.PFn_FillDataTable(objDal.Check担当SQL(objM人员T))

            'フラグ設定
            If dtTable.Rows.Count <= 0 Then
                '人员CDが存在しない
                Return False
            Else
                ' 人员CDが存在する
                Return True
            End If
        Catch ex As Exception
            Throw New Exception(MyMethodBase.ReflectedType.Name & "." & MyMethodBase.Name, ex)
        End Try

    End Function
#End Region

#Region "Get担当Info"
    ''' <summary>
    ''' Get担当Info
    ''' </summary>
    ''' <param name="objM人员T"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Get担当Info(ByVal objM人员T As M人员T) As M人员T

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbHelper As DbHelper = Nothing
        Dim dtTable As DataTable = Nothing  'DBインスタンス
        Dim objM担当T As New M人员T                                        '戻り値
        Dim objDal As New Dal主画面
        Dim sdr As SqlDataReader
        Dim strSql As String = String.Empty

        Try

            strSql = objDal.Get担当InfoSQL(objM人员T)

            'データベースを接続する            objDbHelper = New DbHelper

            'データの操作を実行する
            sdr = objDbHelper.PFn_ExcuteReader(strSql.ToString)

            'データがある場所
            If sdr.HasRows = True Then

                objM担当T = New M人员T

                sdr.Read()

                objM担当T.人员编号 = Utility.NullToString(sdr.Item("人员编号"))
                objM担当T.人员名 = Utility.NullToString(sdr.Item("人员名"))
                objM担当T.密码 = Utility.NullToString(sdr.Item("密码"))
                objM担当T.部门 = Utility.NullToString(sdr.Item("部门"))
                objM担当T.电话号码 = Utility.NullToString(sdr.Item("电话号码"))

            End If

            'DataReaderを閉じる
            sdr.Close()

            'データベース接続を切断する
            objDbHelper.PSb_CloseDB()

            '結果に戻る
            Return objM担当T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(objDbHelper)
            Throw New Exception(MyMethodBase.ReflectedType.Name & "." & MyMethodBase.Name, ex)
        End Try

    End Function

#End Region

#Region "Get担当権限"

    Public Function Get担当権限(ByVal objM人员T As M人员T) As DataTable

        Dim objDbHelper As DbHelper = Nothing                                'DBインスタンス
        Dim dt担当権限 As DataTable = Nothing                                '戻り値
        Dim strRtnSQL As String
        Dim objDal As New Dal主画面

        Try
            'データベースを接続する            objDbHelper = New DbHelper
            dt担当権限 = New DataTable
            strRtnSQL = objDal.Get担当権限SQL(objM人员T)

            'データの操作を実行する            dt担当権限 = objDbHelper.PFn_FillDataTable(strRtnSQL)

            'データベース接続を切断する
            objDbHelper.PSb_CloseDB()

            Return dt担当権限

        Catch ex As Exception

            ExHelper.ProcessDBHelper(objDbHelper)
            Return Nothing
        End Try
    End Function

#End Region

#Region "InsertL登陆记录"
    '''' <summary>
    '''' ﾊﾟｽﾜｰﾄﾞ変更
    '''' </summary>
    '''' <param name="objM人员T"></param>
    '''' <remarks></remarks>
    'Public Function InsertL登陆记录(ByVal objM人员T As M人员T) As Integer

    '    Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
    '    Dim objDbHelper As DbHelper = Nothing               'DBインスタンス
    '    Dim strRtnSQL As String = Nothing
    '    Dim objDal As New Dal主画面
    '    Dim strDBDateTime As String = String.Empty

    '    Try
    '        'データベースを接続する    '        objDbHelper = New DbHelper

    '        strDBDateTime = objDbHelper.GetDBTime()

    '        objM人员T.z_登陆注销日時 = strDBDateTime

    '        '更新SQLを取得
    '        strRtnSQL = objDal.InsertL登陆记录SQL(objM人员T)

    '        objDbHelper.BeginTransaction()

    '        '更新を実行する

    '        If objDbHelper.ExcuteNonQuery(strRtnSQL.ToString) < 0 Then
    '            'ロールバック
    '            objDbHelper.Rollback()
    '            '保存処理終了
    '            Return Constant.ENU_RETURNTYPE.Failed
    '        End If

    '        '事務のコミット
    '        objDbHelper.Commit()

    '        'データベース接続を切断する
    '        objDbHelper.Dispose()

    '        Return Constant.ENU_RETURNTYPE.Succeed

    '    Catch ex As Exception
    '        ExHelper.ProcessDBHelper(objDbHelper)
    '        Throw New Exception(MyMethodBase.ReflectedType.Name & "." & MyMethodBase.Name, ex)
    '    End Try
    'End Function
#End Region

#Region "検索処理"
    Public Function GetGridData(ByVal objM人员T As M人员T) As DataTable

        Dim strSQL As String = Nothing
        Dim objDbHelper As DbHelper = Nothing                            'DBインスタンス
        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim dtRtnSearch As DataTable = Nothing
        Dim objDal As New Dal主画面

        Try
            'データベースを接続する            objDbHelper = New DbHelper

            strSQL = objDal.GetGridDataSQL(objM人员T)

            dtRtnSearch = objDbHelper.PFn_FillDataTable(strSQL.ToString)

            'データベース接続を切断する
            objDbHelper.PSb_CloseDB()

            Return dtRtnSearch

        Catch ex As Exception
            ExHelper.ProcessDBHelper(objDbHelper)
            Throw New Exception(MyMethodBase.ReflectedType.Name & "." & MyMethodBase.Name, ex)
        End Try
    End Function
#End Region

#End Region
End Class
