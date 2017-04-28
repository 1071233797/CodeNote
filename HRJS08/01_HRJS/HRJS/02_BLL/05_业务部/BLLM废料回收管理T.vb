Imports System.Text
Imports System.Data.SqlClient
Imports HRJS.Constant
Public Class BLLM废料回收管理T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " IsExists "

    '插入数据
    Public Function IsExists(ByVal str原材料编号 As String) As Integer

        Dim objDalM废料回收管理T As New DalM废料回收管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "Bll废料回收管理.IsExists"

        Try

            strSql = objDalM废料回收管理T.IsExists(str原材料编号)
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
    Public Function Insert(ByVal clsM废料回收管理T As B废料回收管理T) As Integer

        Dim objDalM废料回收管理T As New DalM废料回收管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM废料回收管理.Insert"

        Try

            strSql = objDalM废料回收管理T.Insert(clsM废料回收管理T)
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
    Public Function Update(ByVal clsM废料回收管理T As B废料回收管理T) As Integer

        Dim objDalM废料回收管理T As New DalM废料回收管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM废料回收管理.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM废料回收管理T.Update(clsM废料回收管理T)
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
    Public Function Delete(ByVal clsM废料回收管理T As B废料回收管理T) As Integer

        Dim objDalM废料回收管理T As New DalM废料回收管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM废料回收管理.Delete"

        Try

            strSql = objDalM废料回收管理T.Delete(clsM废料回收管理T)
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
    Public Function LoadByPKey(ByVal clsM废料回收管理T As B废料回收管理T) As B废料回收管理T

        Dim objM废料回收管理T As New B废料回收管理T
        Dim objDalM废料回收管理T As New DalM废料回收管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM废料回收管理T.LoadByPK(clsM废料回收管理T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                'objM废料回收管理T.原材料编号 = sdr.Item("原材料编号")            '废料回收管理名
                objM废料回收管理T.原材料批号 = sdr.Item("原材料批号")          '废料回收管理类别 
                'objM废料回收管理T.登录者 = sdr.Item("登录者")
                'objM废料回收管理T.登录日期 = sdr.Item("登录日期")
                'objM废料回收管理T.更新者 = sdr.Item("更新者")
                'objM废料回收管理T.更新日期 = sdr.Item("更新日期")
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM废料回收管理T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsM废料回收管理T As B废料回收管理T) As DataTable

        Dim objDalM废料回收管理T As New DalM废料回收管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM废料回收管理.LoadAll"

        Try

            strSql = objDalM废料回收管理T.LoadAll(clsM废料回收管理T)
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
    Public Function LoadByWhere(ByVal clsM废料回收管理T As B废料回收管理T) As DataTable

        Dim objDalM废料回收管理T As New DalM废料回收管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM废料回收管理.LoadByWhere"

        Try

            strSql = objDalM废料回收管理T.LoadByWhere(clsM废料回收管理T)
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

    Public Function SaveData(ByVal objM废料回收管理T As B废料回收管理T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM废料回收管理T As New DalM废料回收管理T

        Try

            objDbCon = New DbHelper
            '事務の開始
            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '废料回收管理新規を処理
                    If objDbCon.PFn_ExcuteDB(objDalM废料回收管理T.Insert(objM废料回收管理T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '废料回收管理更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM废料回收管理T.Update(objM废料回收管理T)) < 0 Then
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
