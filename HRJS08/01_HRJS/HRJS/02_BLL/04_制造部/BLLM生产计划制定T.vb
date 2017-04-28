Imports System.Text
Imports HRJS.Constant
Imports System.Data.SqlClient

Public Class BLLM生产计划制定T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arryList As ArrayList) As Integer

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()
            For i = 0 To arryList.Count - 1
                Dim cls生产计划制定T As New M生产计划制定T
                cls生产计划制定T = arryList(i)
                strSql = objDalM生产计划T.Insert(cls生产计划制定T)
                intRows += ObjDBConn.PFn_ExcuteDB(strSql)
                'For j = 0 To arry生产计划.Add (i).

                'Next
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

#Region " Update订单 "

    '根据主键更新数据
    Public Function Update订单(ByVal cls生产计划T As M生产计划制定T) As Integer

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.Update"

        Try

            strSql = objDalM生产计划T.Update订单(cls生产计划T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " Update工序 "

    '根据主键更新数据
    Public Function Update工序(ByVal arry生产计划 As ArrayList) As Integer

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.Update"

        Try

            For i = 0 To arry生产计划.Count - 1
                Dim cls生产计划T As New M生产计划制定T
                cls生产计划T = arry生产计划(i)

                strSql = objDalM生产计划T.Update工序(cls生产计划T)
                intRows += ObjDBConn.PFn_ExcuteDB(strSql)
            Next

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "Update产品 "

    '根据主键更新数据
    Public Function Update产品(ByVal arry生产计划 As ArrayList) As Integer

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.Update产品"

        Try

            For i = 0 To arry生产计划.Count - 1
                Dim cls生产计划T As New M生产计划制定T
                cls生产计划T = arry生产计划(i)

                strSql = objDalM生产计划T.Update产品(cls生产计划T)
                intRows += ObjDBConn.PFn_ExcuteDB(strSql)
            Next

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " Delete "

    '删除数据
    Public Function Delete(ByVal cls生产计划T As M生产计划制定T) As Integer

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.Delete"

        Try

            strSql = objDalM生产计划T.Delete(cls生产计划T)
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

    Public Function LoadByPKey(ByVal cls生产计划T As M生产计划制定T) As M生产计划制定T

        Dim objM生产计划T As New M生产计划制定T
        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Dim sdr As SqlDataReader

        Try

            strSql = objDalM生产计划T.LoadByPK(cls生产计划T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM生产计划T.订单编号 = sdr.Item("订单编号")            '订单编号


                'objM生产计划T.主图号 = sdr.Item("主图号")          '原材料名称 

                'objM生产计划T.上级图号 = sdr.Item("上级图号")          '原材料名称 

                'objM生产计划T.分图号 = sdr.Item("分图号")            '原材料区分
                'objM生产计划T.工序编号 = sdr.Item("工序编号")

                objM生产计划T.下达日期 = sdr.Item("下达日期")          '下达日期 
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM生产计划T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadByPKey1 "

    '根据主键检索

    Public Function LoadByPKey1(ByVal cls生产计划T As M生产计划制定T) As DataTable

        Dim objM生产计划T As New M生产计划制定T
        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Dim sdr As SqlDataReader

        Try

            strSql = objDalM生产计划T.LoadByPK(cls生产计划T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)


            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " Load生产计划 "

    '检索全部数据

    Public Function Load生产计划(ByVal cls生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.Load生产计划"

        Try

            strSql = objDalM生产计划T.Load生产计划(cls生产计划T)
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

    Public Function Load(ByVal cls生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.Load"

        Try

            strSql = objDalM生产计划T.Load(cls生产计划T)
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

    Public Function LoadSelect(ByVal cls生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.LoadAll"

        Try

            strSql = objDalM生产计划T.LoadSelect(cls生产计划T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadAllHead "

    '检索全部数据

    Public Function LoadAllHead(ByVal cls生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.LoadAllHead"

        Try

            strSql = objDalM生产计划T.LoadAllHead(cls生产计划T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadAllHead "

    '检索全部数据

    Public Function LoadAllHead1(ByVal cls生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.LoadAllHead1"

        Try

            strSql = objDalM生产计划T.LoadAllHead1(cls生产计划T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "LoadAllGrid"
    Public Function LoadAllGrid(ByVal clsM生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.LoadAllGrid"

        Try

            strSql = objDalM生产计划T.LoadAllGrid(clsM生产计划T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
#End Region
#Region "LoadAllGrid1"
    Public Function LoadAllGrid1(ByVal clsM生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.LoadAllGrid1"

        Try

            strSql = objDalM生产计划T.LoadAllGrid1(clsM生产计划T)
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

    Public Function LoadByWhere(ByVal cls生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.LoadByWhere"

        Try

            strSql = objDalM生产计划T.LoadByWhere(cls生产计划T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadByWhere1 "

    '检索全部数据

    Public Function LoadByWhere2(ByVal cls生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.LoadByWhere2"

        Try

            strSql = objDalM生产计划T.LoadByWhere2(cls生产计划T)
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

    Public Function SaveData(ByVal objM生产计划T As M生产计划制定T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM生产计划T As New DalM生产计划制定T

        Try

            objDbCon = New DbHelper
            '事務の開始

            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '原材料新規を処理

                    If objDbCon.PFn_ExcuteDB(objDalM生产计划T.Insert(objM生产计划T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '部门更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM生产计划T.Update产品(objM生产计划T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If
                    If objDbCon.PFn_ExcuteDB(objDalM生产计划T.Update工序(objM生产计划T)) < 0 Then
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

#Region " LoadByWhere3 "

    '检索全部数据

    Public Function LoadByWhere3(ByVal cls生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.LoadByWhere3"

        Try

            strSql = objDalM生产计划T.LoadByWhere3(cls生产计划T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region "CheckGrid"
    Public Function CheckGrid(ByVal clsM生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.CheckGrid"

        Try

            strSql = objDalM生产计划T.CheckGrid(clsM生产计划T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
#End Region

    Public Function LoadAll生产计划(ByVal clsM生产计划T As M生产计划制定T) As DataTable

        Dim objDalM生产计划T As New DalM生产计划制定T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM生产计划制定.LoadAll生产计划"

        Try

            strSql = objDalM生产计划T.LoadAll生产计划(clsM生产计划T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

End Class
