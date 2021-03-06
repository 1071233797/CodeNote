Imports System.Text
Imports HRJS.Constant
Imports System.Data.SqlClient

Public Class BLLM生产实际管理T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry图纸 As ArrayList, ByVal int更新 As Integer) As Integer

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry图纸.Count - 1
                Dim objM生产实际T As New Z生产实际管理T
                objM生产实际T = arry图纸(i)

                strSql = objDalM生产实际T.Insert(objM生产实际T, int更新)

                intRows += ObjDBConn.PFn_ExcuteDB(strSql)
            Next

            ObjDBConn.PSb_Commit()
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
    Public Function Update(ByVal clsM生产实际T As Z生产实际管理T) As Integer

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM生产实际T.Update(clsM生产实际T)
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
    Public Function Delete(ByVal clsM生产实际T As Z生产实际管理T) As Integer

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.Delete"

        Try

            strSql = objDalM生产实际T.Delete(clsM生产实际T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadGetCom "

    '根据主键检索

    Public Function LoadGetCom(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try


            strSql = objDalM生产实际T.LoadGetCom(clsM生产实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn
        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadByPKey "

    '根据主键检索

    Public Function LoadByPKey(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objM生产实际T As New Z生产实际管理T
        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Dim sdr As SqlDataReader

        Try

            strSql = objDalM生产实际T.LoadByPK(clsM生产实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "
    '检索全部数据
    Public Function LoadAll(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.LoadAll"

        Try

            strSql = objDalM生产实际T.LoadAll(clsM生产实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function CheckOutSourcing(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "CheckOutSourcing"

        Try

            strSql = objDalM生产实际T.CheckOutSourcing(clsM生产实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function SetData(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.SetData"

        Try

            strSql = objDalM生产实际T.SetData(clsM生产实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function SetData1(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.SetData1"

        Try

            strSql = objDalM生产实际T.SetData1(clsM生产实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAllGrid(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.LoadAllGrid"

        Try

            strSql = objDalM生产实际T.LoadAllGrid(clsM生产实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "Load人员"
    Public Function Load人员(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.LoadAllGrid"

        Try

            strSql = objDalM生产实际T.Load人员(clsM生产实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "Load订单"
    Public Function Load订单(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.LoadAllGrid"

        Try

            strSql = objDalM生产实际T.Load订单(clsM生产实际T)
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

    Public Function LoadByWhere(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.LoadByWhere"

        Try

            strSql = objDalM生产实际T.LoadByWhere(clsM生产实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAllexp "

    ''检索全部数据
    Public Function LoadAllexp(ByVal clsM生产实际T As Z生产实际管理T) As DataTable

        Dim objDalM生产实际T As New DalZ生产实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产实际管理.LoadAllexp"

        Try

            strSql = objDalM生产实际T.LoadBodyAllexp(clsM生产实际T)
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

    Public Function SaveData(ByVal objM生产实际T As Z生产实际管理T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM生产实际T As New DalZ生产实际管理T

        Try

            objDbCon = New DbHelper
            '事務の開始

            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '图纸新規を処理

                    If objDbCon.PFn_ExcuteDB(objDalM生产实际T.Insert(objM生产实际T, 1)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '图纸更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM生产实际T.Update(objM生产实际T)) < 0 Then
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
