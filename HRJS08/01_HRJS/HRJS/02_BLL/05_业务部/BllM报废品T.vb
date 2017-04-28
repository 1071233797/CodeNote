
Imports System.Text
Imports HRJS.Constant
Imports System.Data.SqlClient
Public Class BllM报废品T




#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " IsExists "

    '插入数据
    Public Function IsExists(ByVal str报废品订单编号 As String) As Integer

        Dim objDalM报废品T As New DalM报废品T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "Bll报废品.IsExists"

        Try

            strSql = objDalM报废品T.IsExists(str报废品订单编号)
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
    Public Function Insert(ByVal clsM报废品T As B报废品T) As Integer

        Dim objDalM报废品T As New DalM报废品T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM报废品.Insert"

        Try

            strSql = objDalM报废品T.Insert(clsM报废品T)
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
    Public Function Update(ByVal clsM报废品T As B报废品T) As Integer

        Dim objDalM报废品T As New DalM报废品T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM报废品.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM报废品T.Update(clsM报废品T)
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
    Public Function Delete(ByVal clsM报废品T As B报废品T) As Integer

        Dim objDalM报废品T As New DalM报废品T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM报废品.Delete"

        Try

            strSql = objDalM报废品T.Delete(clsM报废品T)
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
    Public Function LoadByPKey(ByVal clsM报废品T As B报废品T) As B报废品T

        Dim objM报废品T As New B报废品T
        Dim objDalM报废品T As New DalM报废品T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM报废品T.LoadByPK(clsM报废品T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM报废品T.报废品订单编号 = sdr.Item("报废品订单编号")
                'objM报废品T.模具名称 = sdr.Item("模具名称")
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

            Return objM报废品T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsM报废品T As B报废品T) As DataTable

        Dim objDalM报废品T As New DalM报废品T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM报废品.LoadAll"

        Try

            strSql = objDalM报废品T.LoadAll(clsM报废品T)
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
    Public Function LoadByWhere(ByVal clsM报废品T As B报废品T) As DataTable

        Dim objDalM报废品T As New DalM报废品T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM报废品.LoadByWhere"

        Try

            strSql = objDalM报废品T.LoadByWhere(clsM报废品T)
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

    Public Function SaveData(ByVal objM报废品T As B报废品T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM报废品T As New DalM报废品T

        Try

            objDbCon = New DbHelper
            '事務の開始
            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '模具新規を処理
                    If objDbCon.PFn_ExcuteDB(objDalM报废品T.Insert(objM报废品T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '模具更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM报废品T.Update(objM报废品T)) < 0 Then
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


