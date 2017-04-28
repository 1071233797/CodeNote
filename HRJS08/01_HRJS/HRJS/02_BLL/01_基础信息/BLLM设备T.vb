Imports System.Text
Imports System.Data.SqlClient
Imports HRJS.Constant
Public Class BLLM设备T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " IsExists "

    '插入数据
    Public Function IsExists(ByVal str设备编号 As String) As Integer

        Dim objDalM设备T As New DalM设备T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "Bll设备.IsExists"

        Try

            strSql = objDalM设备T.IsExists(str设备编号)
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
    Public Function Insert(ByVal clsM设备T As M设备T) As Integer

        Dim objDalM设备T As New DalM设备T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM设备.Insert"

        Try

            strSql = objDalM设备T.Insert(clsM设备T)
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
    Public Function Update(ByVal clsM设备T As M设备T) As Integer

        Dim objDalM设备T As New DalM设备T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM设备.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM设备T.Update(clsM设备T)
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
    Public Function Delete(ByVal clsM设备T As M设备T) As Integer

        Dim objDalM设备T As New DalM设备T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM设备.Delete"

        Try

            strSql = objDalM设备T.Delete(clsM设备T)
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
    Public Function LoadByPKey(ByVal clsM设备T As M设备T) As M设备T

        Dim objM设备T As New M设备T
        Dim objDalM设备T As New DalM设备T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM设备T.LoadByPK(clsM设备T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM设备T.设备编号 = sdr.Item("设备编号")
                objM设备T.设备名称 = sdr.Item("设备名称")
                'objM设备T.设备型号 = sdr.Item("设备型号")
                'objM设备T.维护周期 = sdr.Item("维护周期")
                'objM设备T.上次维护日期 = sdr.Item("上次维护日期")
                'objM设备T.使用状态 = sdr.Item("使用状态")
                'objM设备T.设备产量 = sdr.Item("设备产量")
                'objM设备T.维护厂商 = sdr.Item("维护厂商")
                'objM设备T.维护负责人 = sdr.Item("维护负责人")
                'objM设备T.负责人电话 = sdr.Item("负责人电话")
                'objM设备T.登录者 = sdr.Item("登录者")
                'objM设备T.登录日期 = sdr.Item("登录日期")
                'objM设备T.更新者 = sdr.Item("更新者")
                'objM设备T.更新日期 = sdr.Item("更新日期")

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM设备T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsM设备T As M设备T) As DataTable

        Dim objDalM设备T As New DalM设备T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM设备.LoadAll"

        Try

            strSql = objDalM设备T.LoadAll(clsM设备T)
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
    Public Function LoadByWhere(ByVal clsM设备T As M设备T) As DataTable

        Dim objDalM设备T As New DalM设备T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM设备.LoadByWhere"

        Try

            strSql = objDalM设备T.LoadByWhere(clsM设备T)
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

    Public Function SaveData(ByVal objM设备T As M设备T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM设备T As New DalM设备T

        Try

            objDbCon = New DbHelper
            '事務の開始
            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '设备新規を処理
                    If objDbCon.PFn_ExcuteDB(objDalM设备T.Insert(objM设备T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '设备更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM设备T.Update(objM设备T)) < 0 Then
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
