Imports System.Data.SqlClient

#Region "Bll原材料出库申请
'------------------------------------------------------------------------------------
'   说明
'       原材料出库申请的数据操作层
'   创建人
'       大连智云科技 李陈盛
'   创建时间
'       2016/8/29
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class BLLZ半成品入库申请T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry半成品入库申请 As ArrayList) As Integer

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM流转票管理T.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry半成品入库申请.Count - 1
                Dim obj半成品入库申请 As New Z半成品入库申请T
                obj半成品入库申请 = arry半成品入库申请(i)

                strSql = objDal半成品入库申请T.Insert(obj半成品入库申请)

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
    Public Function Update(ByVal cls半成品入库申请T As Z半成品入库申请T) As Integer

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.Update"

        Try

            strSql = objDal半成品入库申请T.Update(cls半成品入库申请T)
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
    Public Function Updatezj(ByVal cls半成品入库申请T As Z半成品入库申请T) As Integer

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.Updatezj"

        Try

            strSql = objDal半成品入库申请T.Updatezj(cls半成品入库申请T)
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
    Public Function Delete(ByVal cls半成品入库申请T As Z半成品入库申请T) As Integer

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.Delete"

        Try

            strSql = objDal半成品入库申请T.Delete(cls半成品入库申请T)
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
    Public Function Deletezj(ByVal cls半成品入库申请T As Z半成品入库申请T) As Integer

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.Deletezj "

        Try

            strSql = objDal半成品入库申请T.Deletezj(cls半成品入库申请T)
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
    Public Function LoadByPKey(ByVal cls半成品入库申请T As Z半成品入库申请T) As Z半成品入库申请T

        Dim obj半成品入库申请T As New Z半成品入库申请T
        Dim objRe半成品入库申请T As New Z半成品入库申请T
        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try

            strSql = objDal半成品入库申请T.LoadByPKey(cls半成品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            If Not dtReturn Is Nothing AndAlso dtReturn.Rows.Count > 0 Then
                objRe半成品入库申请T.申请单编号 = dtReturn.Rows(0).Item("申请单编号")
            End If



            Return objRe半成品入库申请T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadByPKey1(ByVal cls半成品入库申请T As Z半成品入库申请T) As DataTable

        Dim obj半成品入库申请T As New Z半成品入库申请T
        Dim objRe半成品入库申请T As New Z半成品入库申请T
        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try

            strSql = objDal半成品入库申请T.LoadByPKey(cls半成品入库申请T)
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
    Public Function LoadAllHead(ByVal cls半成品入库申请T As Z半成品入库申请T) As DataTable

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.LoadAll"

        Try

            strSql = objDal半成品入库申请T.LoadAllHead(cls半成品入库申请T)
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
    Public Function LoadAllHeadzj(ByVal cls半成品入库申请T As Z半成品入库申请T) As DataTable

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.LoadAllzj"

        Try

            strSql = objDal半成品入库申请T.LoadAllHeadzj(cls半成品入库申请T)
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
    Public Function LoadAllzj(ByVal cls半成品入库申请T As Z半成品入库申请T) As DataTable

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.LoadAllzj "

        Try

            strSql = objDal半成品入库申请T.LoadAllzj(cls半成品入库申请T)
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
    Public Function LoadGridAll(ByVal cls半成品入库申请T As Z半成品入库申请T) As DataTable

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.LoadAll"

        Try

            strSql = objDal半成品入库申请T.LoadGridAll(cls半成品入库申请T)
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
    Public Function LoadByWhere(ByVal cls半成品入库申请T As Z半成品入库申请T) As DataTable

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.LoadByWhere"

        Try

            strSql = objDal半成品入库申请T.LoadByWhere(cls半成品入库申请T)
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
    Public Function LoadByWhere1(ByVal cls半成品入库申请T As Z半成品入库申请T) As DataTable

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.LoadByWhere"

        Try

            strSql = objDal半成品入库申请T.LoadByWhere1(cls半成品入库申请T)
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
    Public Function SetData(ByVal cls半成品入库申请T As Z半成品入库申请T) As DataTable

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.SetData"

        Try

            strSql = objDal半成品入库申请T.SetData(cls半成品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " Check主图分图 "

    '检索全部数据
    Public Function Check主图分图(ByVal cls半成品入库申请T As Z半成品入库申请T) As DataTable

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.Check主图分图"

        Try

            strSql = objDal半成品入库申请T.Check主图分图(cls半成品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Loaddava "

    '检索全部数据
    Public Function Loaddava(ByVal cls半成品入库申请T As Z半成品入库申请T) As DataTable

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.Loaddava"

        Try

            strSql = objDal半成品入库申请T.Loaddava(cls半成品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " Load打印数据 "

    '检索全部数据
    Public Function Load打印数据(ByVal strWhere As String) As DataTable

        Dim objDal半成品入库申请T As New DalZ半成品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll半成品入库申请.Load打印数据"

        Try

            strSql = objDal半成品入库申请T.Load打印数据(strWhere)
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
