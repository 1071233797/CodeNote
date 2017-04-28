Imports System.Data.SqlClient

#Region "Bll流转票管理"
'------------------------------------------------------------------------------------
'   说明
'       T流转票管理的数据操作层
'   创建人
'       大连智云科技 刘春广
'   创建时间
'       2016/8/22
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class BllM流转票管理T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry流转票 As ArrayList) As Integer

        Dim objDalM流转票管理T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM流转票管理T.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry流转票.Count - 1
                Dim objM流转票T As New M流转票管理T
                objM流转票T = arry流转票(i)

                strSql = objDalM流转票管理T.Insert(objM流转票T)

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
    Public Function Update(ByVal clsM流转票管理T As M流转票管理T) As Integer

        Dim objDalM流转票管理T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM流转票管理T.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM流转票管理T.Update(clsM流转票管理T)
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
    Public Function Delete(ByVal clsM流转票管理T As M流转票管理T) As Integer

        Dim objDalM流转票管理T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM流转票管理T.Delete"

        Try

            strSql = objDalM流转票管理T.Delete(clsM流转票管理T)
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
    Public Function LoadByPKey(ByVal clsM流转票管理T As M流转票管理T) As M流转票管理T

        Dim objM流转票管理T As New M流转票管理T
        Dim objDalM流转票管理T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM流转票管理T.LoadAll (clsM流转票管理T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM流转票管理T.产品图号 = sdr.Item("产品图号")           '加工内容简介
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM流转票管理T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadByPKey "

    '根据主键检索
    Public Function LoadByPKey1(ByVal clsM流转票管理T As M流转票管理T) As DataTable

        'Dim objM流转票管理T As New M流转票管理T
        'Dim objDalM流转票管理T As New DalM流转票管理T
        'Dim ObjDBConn As New DbHelper
        'Dim strSql As String = System.String.Empty    'Sql文
        'Dim sdr As SqlDataReader

        'Try

        '    strSql = objDalM流转票管理T.LoadByPK1(clsM流转票管理T)
        '    dtReturn = ObjDBConn.PFn_FillDataTable(strSql)


        '    ObjDBConn.PSb_CloseDB()

        '    Return dtReturn

        'Catch ex As Exception
        '    ExHelper.ProcessDBHelper(ObjDBConn)
        '    Throw New Exception(strErrorName, ex)
        'End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsM流转票管理T As M流转票管理T) As DataTable

        Dim objDalM流转票管理T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM流转票管理T.LoadAll"

        Try

            strSql = objDalM流转票管理T.LoadAll(clsM流转票管理T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAllGrid(ByVal clsM流转票管理T As M流转票管理T) As DataTable

        Dim objDalM流转票管理T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.LoadAllGrid"

        Try

            strSql = objDalM流转票管理T.LoadAllGrid(clsM流转票管理T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAllGrid1(ByVal clsM流转票管理T As M流转票管理T) As DataTable

        Dim objDalM流转票管理T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.LoadAllGrid"

        Try

            strSql = objDalM流转票管理T.LoadAllGrid1(clsM流转票管理T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAll流转票(ByVal clsM流转票管理T As M流转票管理T) As DataTable

        Dim objDalM流转票管理T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.LoadAllGrid"

        Try

            strSql = objDalM流转票管理T.LoadAll流转票(clsM流转票管理T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadAllGrid2(ByVal clsM流转票管理T As M流转票管理T) As DataTable

        Dim objDalM流转票管理T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM工艺卡.LoadAllGrid"

        Try

            strSql = objDalM流转票管理T.LoadAllGrid2(clsM流转票管理T)
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

    Public Function LoadByWhere2(ByVal clsM流转票管理T As M流转票管理T, ByVal intCount As Integer) As DataTable


        Dim objDalM流转票T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM流转票.LoadByWhere2"
        Try

            strSql = objDalM流转票T.LoadByWhere2(clsM流转票管理T, intCount)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
#End Region

#Region " SetData "

    '检索全部数据
    Public Function SetData(ByVal clsM流转票管理T As M流转票管理T) As DataTable

        Dim objDalM流转票T As New DalM流转票管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM流转票.SetData"

        Try

            strSql = objDalM流转票T.SetData(clsM流转票管理T)
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
