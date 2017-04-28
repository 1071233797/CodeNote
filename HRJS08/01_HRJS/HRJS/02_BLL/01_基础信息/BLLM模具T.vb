Imports System.Text
Imports HRJS.Constant
Imports System.Data.SqlClient

Public Class BLLM模具T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " IsExists "

    '插入数据
    Public Function IsExists(ByVal str模具编号 As String) As Integer

        Dim objDalM模具T As New DalM模具T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "Bll模具.IsExists"

        Try

            strSql = objDalM模具T.IsExists(str模具编号)
            objReturn = ObjDBConn.PFn_ExcuteScalar(strSql)

            ObjDBConn.PSb_CloseDB()

            If Convert.ToInt32(objReturn) = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal clsM模具T As M模具T) As Integer

        Dim objDalM模具T As New DalM模具T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM模具.Insert"

        Try

            strSql = objDalM模具T.Insert(clsM模具T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Update "

    '根据主键更新数据
    Public Function Update(ByVal clsM模具T As M模具T) As Integer

        Dim objDalM模具T As New DalM模具T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM模具.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM模具T.Update(clsM模具T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)
            ObjDBConn.PSb_Commit()

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Delete "

    '删除数据
    Public Function Delete(ByVal clsM模具T As M模具T) As Integer

        Dim objDalM模具T As New DalM模具T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM模具.Delete"

        Try

            strSql = objDalM模具T.Delete(clsM模具T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadByPKey "

    '根据主键检索
    Public Function LoadByPKey(ByVal clsM模具T As M模具T) As M模具T

        Dim objM模具T As New M模具T
        Dim objDalM模具T As New DalM模具T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM模具T.LoadByPK(clsM模具T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM模具T.模具编号 = sdr.Item("模具编号")
                objM模具T.模具名称 = sdr.Item("模具名称")
                'objM模具T.模具型号 = sdr.Item("模具型号")
                'objM模具T.维护周期 = sdr.Item("维护周期")
                'objM模具T.上次维护日期 = sdr.Item("上次维护日期")
                'objM模具T.使用状态 = sdr.Item("使用状态")
                'objM模具T.模具产量 = sdr.Item("模具产量")
                'objM模具T.维护厂商 = sdr.Item("维护厂商")
                'objM模具T.维护负责人 = sdr.Item("维护负责人")
                'objM模具T.负责人电话 = sdr.Item("负责人电话")
                'objM模具T.登录者 = sdr.Item("登录者")
                'objM模具T.登录日期 = sdr.Item("登录日期")
                'objM模具T.更新者 = sdr.Item("更新者")
                'objM模具T.更新日期 = sdr.Item("更新日期")

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM模具T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsM模具T As M模具T) As DataTable

        Dim objDalM模具T As New DalM模具T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM模具.LoadAll"

        Try

            strSql = objDalM模具T.LoadAll(clsM模具T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal clsM模具T As M模具T) As DataTable

        Dim objDalM模具T As New DalM模具T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM模具.LoadByWhere"

        Try

            strSql = objDalM模具T.LoadByWhere(clsM模具T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region "SaveData"

    Public Function SaveData(ByVal objM模具T As M模具T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM模具T As New DalM模具T

        Try

            objDbCon = New DbHelper
            '事務の開始
            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '模具新規を処理
                    If objDbCon.PFn_ExcuteDB(objDalM模具T.Insert(objM模具T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '模具更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM模具T.Update(objM模具T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If
            End Select

            '事務のコミット
            objDbCon.PSb_Commit()

            'データベース接続を切断する
            objDbCon.PSb_CloseDB()

            Return Constant.ENU_RETURNTYPE.Succeed

        Catch ex As Exception

            '空対象をセットする
            If Not objDbCon Is Nothing Then
                'DB連接を閉じる
                objDbCon.PSb_CloseDB()
                objDbCon = Nothing
            End If

            Throw New Exception(MyMethodBase.ReflectedType.Name & "." & MyMethodBase.Name, ex)

        End Try

    End Function

#End Region

End Class
