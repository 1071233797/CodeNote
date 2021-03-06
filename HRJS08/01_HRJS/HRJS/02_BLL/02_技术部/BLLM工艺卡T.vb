Imports System.Text
Imports HRJS.Constant
Imports System.Data.SqlClient

Public Class BLLM工艺卡T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " IsExists "

    '插入数据
    'Public Function IsExists(ByVal str产品图号 As String) As Integer

    '    Dim objDalM工艺卡T As New DalM工艺卡T
    '    Dim ObjDBConn As New DbHelper
    '    Dim strSql As String = String.Empty
    '    Dim objReturn As Object
    '    strErrorName = "Bll工艺卡.IsExists"

    '    Try

    '        strSql = objDalM工艺卡T.IsExists(str产品图号)
    '        objReturn = ObjDBConn.PFn_ExcuteScalar(strSql)

    '        ObjDBConn.PSb_CloseDB()

    '        If Convert.ToInt32(objReturn) = 0 Then
    '            Return False
    '        Else
    '            Return True
    '        End If

    '    Catch ex As Exception
    '        ExHelper.ProcessDBHelper(ObjDBConn)
    '        Throw New Exception(strErrorName, ex)
    '    End Try

    'End Function

#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry图纸 As ArrayList) As Integer

        Dim objDalM工艺卡T As New DalM工艺卡T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry图纸.Count - 1
                Dim objM工艺卡T As New M工艺卡T
                objM工艺卡T = arry图纸(i)

                strSql = objDalM工艺卡T.Insert(objM工艺卡T)

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
    Public Function Update(ByVal clsM工艺卡T As M工艺卡T) As Integer

        Dim objDalM工艺卡T As New DalM工艺卡T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM工艺卡T.Update(clsM工艺卡T)
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
    Public Function Delete(ByVal clsM工艺卡T As M工艺卡T) As Integer

        Dim objDalM工艺卡T As New DalM工艺卡T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.Delete"

        Try

            strSql = objDalM工艺卡T.Delete(clsM工艺卡T)
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

    Public Function LoadByPKey(ByVal clsM工艺卡T As M工艺卡T) As M工艺卡T

        Dim objM工艺卡T As New M工艺卡T
        Dim objDalM工艺卡T As New DalM工艺卡T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Dim sdr As SqlDataReader

        Try

            strSql = objDalM工艺卡T.LoadByPK(clsM工艺卡T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()
                objM工艺卡T.工序名称 = sdr.Item("工序名称")
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM工艺卡T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsM工艺卡T As M工艺卡T) As DataTable

        Dim objDalM工艺卡T As New DalM工艺卡T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.LoadAll"

        Try

            strSql = objDalM工艺卡T.LoadAll(clsM工艺卡T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAllGrid(ByVal clsM工艺卡T As M工艺卡T) As DataTable

        Dim objDalM工艺卡T As New DalM工艺卡T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.LoadAllGrid"

        Try

            strSql = objDalM工艺卡T.LoadAllGrid(clsM工艺卡T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    '    Public Function LoadAll人员(ByVal clsM工艺卡T As M工艺卡T) As DataTable

    '        Dim objDalM工艺卡T As New DalM工艺卡T
    '        Dim ObjDBConn As New DbHelper
    '        Dim strSql As String = String.Empty
    '        strErrorName = "BllM工艺卡.LoadAll人员"

    '        Try

    '            strSql = objDalM工艺卡T.LoadAll人员(clsM工艺卡T)
    '            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

    '            ObjDBConn.PSb_CloseDB()

    '            Return dtReturn

    '        Catch ex As Exception
    '            ExHelper.ProcessDBHelper(ObjDBConn)
    '            Throw New Exception(strErrorName, ex)
    '        End Try

    '    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据

    Public Function LoadByWhere(ByVal clsM工艺卡T As M工艺卡T) As DataTable

        Dim objDalM工艺卡T As New DalM工艺卡T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.LoadByWhere"

        Try

            strSql = objDalM工艺卡T.LoadByWhere(clsM工艺卡T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadByWhere1"

    '检索全部数据

    Public Function LoadByWhere1(ByVal clsM工艺卡T As M工艺卡T) As DataTable

        Dim objDalM工艺卡T As New DalM工艺卡T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.LoadByWhere1"

        Try

            strSql = objDalM工艺卡T.LoadByWhere1(clsM工艺卡T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadByWhere2"

    Public Function LoadByWhere2(ByVal clsM工艺卡T As M工艺卡T, ByVal intCount As Integer) As DataTable



        Dim objDalM工艺卡T As New DalM工艺卡T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.LoadByWhere2"
        Try

            strSql = objDalM工艺卡T.LoadByWhere2(clsM工艺卡T, intCount)
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

    Public Function SaveData(ByVal objM工艺卡T As M工艺卡T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM工艺卡T As New DalM工艺卡T

        Try

            objDbCon = New DbHelper
            '事務の開始

            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '图纸新規を処理

                    If objDbCon.PFn_ExcuteDB(objDalM工艺卡T.Insert(objM工艺卡T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '图纸更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM工艺卡T.Update(objM工艺卡T)) < 0 Then
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

#Region " SetData "

    '检索全部数据
    Public Function SetData(ByVal clsM工艺卡T As M工艺卡T) As DataTable

        Dim objDalM工艺卡T As New DalM工艺卡T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.SetData"

        Try

            strSql = objDalM工艺卡T.SetData(clsM工艺卡T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

End Class
