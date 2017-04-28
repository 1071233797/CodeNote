Imports System.Text
Imports HRJS.Constant
Imports System.Data.SqlClient

Public Class BLLM产品种类T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal clsM产品种类T As M产品种类T) As Integer

        Dim objDalM产品种类T As New DalM产品种类T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM产品种类.Insert"

        Try

            strSql = objDalM产品种类T.Insert(clsM产品种类T)
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
    Public Function Update(ByVal clsM产品种类T As M产品种类T) As Integer

        Dim objDalM产品种类T As New DalM产品种类T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM产品种类.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM产品种类T.Update(clsM产品种类T)
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
    Public Function Delete(ByVal clsM产品种类T As M产品种类T) As Integer

        Dim objDalM产品种类T As New DalM产品种类T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM产品种类.Delete"

        Try

            strSql = objDalM产品种类T.Delete(clsM产品种类T)
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

    Public Function LoadByPKey(ByVal clsM产品种类T As M产品种类T) As M产品种类T

        Dim objM产品种类T As New M产品种类T
        Dim objDalM产品种类T As New DalM产品种类T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Dim sdr As SqlDataReader

        Try

            strSql = objDalM产品种类T.LoadByPK(clsM产品种类T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM产品种类T.产品种类编号 = sdr.Item("产品种类编号")            '产品种类编号

                objM产品种类T.产品种类名称 = sdr.Item("产品种类名称")          '产品种类名称 
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM产品种类T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据

    Public Function LoadAll(ByVal clsM产品种类T As M产品种类T) As DataTable

        Dim objDalM产品种类T As New DalM产品种类T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM产品种类.LoadAll"

        Try

            strSql = objDalM产品种类T.LoadAll(clsM产品种类T)
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

    Public Function LoadByWhere(ByVal clsM产品种类T As M产品种类T) As DataTable

        Dim objDalM产品种类T As New DalM产品种类T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM产品种类.LoadByWhere"

        Try

            strSql = objDalM产品种类T.LoadByWhere(clsM产品种类T)
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

    Public Function SaveData(ByVal objM产品种类T As M产品种类T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM产品种类T As New DalM产品种类T

        Try

            objDbCon = New DbHelper
            '事務の開始

            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '部门新規を処理

                    If objDbCon.PFn_ExcuteDB(objDalM产品种类T.Insert(objM产品种类T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '部门更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM产品种类T.Update(objM产品种类T)) < 0 Then
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
