Imports System.Data.SqlClient

#Region "Bll原材料出库申请
'------------------------------------------------------------------------------------
'   说明
'       成品入库申请的数据操作层
'   创建人
'       大连智云科技 李陈盛
'   创建时间
'       2016/8/29
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class BLLZ成品入库申请T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry成品入库申请 As ArrayList) As Integer

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ成品入库申请T.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry成品入库申请.Count - 1
                Dim obj成品入库申请 As New Z成品入库申请T
                obj成品入库申请 = arry成品入库申请(i)

                strSql = objDal成品入库申请T.Insert(obj成品入库申请)

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
    Public Function Update(ByVal cls成品入库申请T As Z成品入库申请T) As Integer

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库申请.Update"

        Try

            strSql = objDal成品入库申请T.Update(cls成品入库申请T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " Updatezj "

    '根据主键更新数据
    Public Function Updatezj(ByVal cls成品入库申请T As Z成品入库申请T) As Integer

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库申请.Updatezj"

        Try

            strSql = objDal成品入库申请T.Updatezj(cls成品入库申请T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

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
    Public Function Delete(ByVal cls成品入库申请T As Z成品入库申请T) As Integer

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库申请.Delete"

        Try

            strSql = objDal成品入库申请T.Delete(cls成品入库申请T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " Deletezj "

    '删除数据
    Public Function Deletezj(ByVal cls成品入库申请T As Z成品入库申请T) As Integer

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库申请.Deletezj "

        Try

            strSql = objDal成品入库申请T.Deletezj(cls成品入库申请T)
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
    Public Function LoadByPKey(ByVal cls成品入库申请T As Z成品入库申请T) As Z成品入库申请T

        Dim obj成品入库申请T As New Z成品入库申请T
        Dim objRe成品入库申请T As New Z成品入库申请T
        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try

            strSql = objDal成品入库申请T.LoadByPKey(cls成品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            If Not dtReturn Is Nothing AndAlso dtReturn.Rows.Count > 0 Then
                objRe成品入库申请T.申请单编号 = dtReturn.Rows(0).Item("申请单编号")
            End If



            Return objRe成品入库申请T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadByPKey1(ByVal cls成品入库申请T As Z成品入库申请T) As DataTable

        Dim obj成品入库申请T As New Z成品入库申请T
        Dim objRe成品入库申请T As New Z成品入库申请T
        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try

            strSql = objDal成品入库申请T.LoadByPKey(cls成品入库申请T)
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
    Public Function LoadAllHead(ByVal cls成品入库申请T As Z成品入库申请T) As DataTable

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.LoadAll"

        Try

            strSql = objDal成品入库申请T.LoadAllHead(cls成品入库申请T)
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
    Public Function LoadAllHead1(ByVal cls成品入库申请T As Z成品入库申请T) As DataTable

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.LoadAll"

        Try

            strSql = objDal成品入库申请T.LoadAllHead1(cls成品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadAllHeadzj "

    '检索全部数据
    Public Function LoadAllHeadzj(ByVal cls成品入库申请T As Z成品入库申请T) As DataTable

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库申请.LoadAllzj"

        Try

            strSql = objDal成品入库申请T.LoadAllHeadzj(cls成品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadAllzj "

    '检索全部数据
    Public Function LoadAllzj(ByVal cls成品入库申请T As Z成品入库申请T) As DataTable

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.LoadAllzj "

        Try

            strSql = objDal成品入库申请T.LoadAllzj(cls成品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadGridAll "

    '检索全部数据
    Public Function LoadGridAll(ByVal cls成品入库申请T As Z成品入库申请T) As DataTable

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库申请.LoadAll"

        Try

            strSql = objDal成品入库申请T.LoadGridAll(cls成品入库申请T)
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
    Public Function LoadByWhere(ByVal cls成品入库申请T As Z成品入库申请T) As DataTable

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库申请.LoadByWhere"

        Try

            strSql = objDal成品入库申请T.LoadByWhere(cls成品入库申请T)
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
    Public Function LoadByWhere1(ByVal cls成品入库申请T As Z成品入库申请T) As DataTable

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库申请.LoadByWhere"

        Try

            strSql = objDal成品入库申请T.LoadByWhere1(cls成品入库申请T)
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

    ''检索全部数据
    Public Function SetData(ByVal cls成品入库申请T As Z成品入库申请T) As DataTable

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.SetData"

        Try

            strSql = objDal成品入库申请T.SetData(cls成品入库申请T)
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

    ''检索全部数据
    Public Function Update订单(ByVal cls成品入库申请T As Z成品入库申请T) As Integer

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.SetData"

        Try

            strSql = objDal成品入库申请T.Update订单(cls成品入库申请T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " Load打印数据 "

    '检索全部数据
    Public Function Load打印数据(ByVal strWhere As String) As DataTable

        Dim objDal成品入库申请T As New DalZ成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库申请.Load打印数据"

        Try

            strSql = objDal成品入库申请T.Load打印数据(strWhere)
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
