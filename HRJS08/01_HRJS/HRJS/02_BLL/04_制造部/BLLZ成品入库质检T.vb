Imports System.Data.SqlClient

#Region "Bll成品入库质检"
'------------------------------------------------------------------------------------
'   说明
'       成品入库质检的数据操作层
'   创建人
'       大连智云科技 李陈盛
'   创建时间
'       2016/8/29
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class BLLZ成品入库质检T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry成品入库质检 As ArrayList) As Integer

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ成品入库质检T.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry成品入库质检.Count - 1
                Dim obj成品入库质检 As New Z成品入库质检T
                obj成品入库质检 = arry成品入库质检(i)

                strSql = objDal成品入库质检T.Insert(obj成品入库质检)

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
    Public Function Update(ByVal cls成品入库质检T As Z成品入库质检T) As Integer

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库质检.Update"

        Try

            strSql = objDal成品入库质检T.Update(cls成品入库质检T)
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
    Public Function Delete(ByVal cls成品入库质检T As Z成品入库质检T) As Integer

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库质检.Delete"

        Try

            strSql = objDal成品入库质检T.Delete(cls成品入库质检T)
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
    Public Function LoadByPKey(ByVal cls成品入库质检T As Z成品入库质检T) As Z成品入库质检T

        Dim obj成品入库质检T As New Z成品入库质检T
        Dim objRe成品入库质检T As New Z成品入库质检T
        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try

            strSql = objDal成品入库质检T.LoadByPKey(cls成品入库质检T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            If Not dtReturn Is Nothing AndAlso dtReturn.Rows.Count > 0 Then
                objRe成品入库质检T.申请单编号 = dtReturn.Rows(0).Item("申请单编号")
            End If



            Return objRe成品入库质检T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadByPKey1(ByVal cls成品入库质检T As Z成品入库质检T) As DataTable

        Dim obj成品入库质检T As New Z成品入库质检T
        Dim objRe成品入库质检T As New Z成品入库质检T
        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try

            strSql = objDal成品入库质检T.LoadByPKey(cls成品入库质检T)
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
    Public Function LoadAllHead(ByVal cls成品入库质检T As Z成品入库质检T) As DataTable

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库质检.LoadAll"

        Try

            strSql = objDal成品入库质检T.LoadAllHead(cls成品入库质检T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAllHead1(ByVal cls成品入库质检T As Z成品入库质检T) As DataTable

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库质检.LoadAll"

        Try

            strSql = objDal成品入库质检T.LoadAllHead1(cls成品入库质检T)
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
    Public Function LoadAllzj(ByVal cls成品入库质检T As Z成品入库质检T) As DataTable

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库质检.LoadAllzj "

        Try

            strSql = objDal成品入库质检T.LoadAllzj(cls成品入库质检T)
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
    Public Function LoadGridAll(ByVal cls成品入库质检T As Z成品入库质检T) As DataTable

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库质检.LoadAll"

        Try

            strSql = objDal成品入库质检T.LoadGridAll(cls成品入库质检T)
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
    Public Function LoadByWhere(ByVal cls成品入库质检T As Z成品入库质检T) As DataTable

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库质检.LoadByWhere"

        Try

            strSql = objDal成品入库质检T.LoadByWhere(cls成品入库质检T)
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
    Public Function LoadByWhere1(ByVal cls成品入库质检T As Z成品入库质检T) As DataTable

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库质检.LoadByWhere"

        Try

            strSql = objDal成品入库质检T.LoadByWhere1(cls成品入库质检T)
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
    Public Function SetData(ByVal cls成品入库质检T As Z成品入库质检T) As DataTable

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ成品入库质检T.SetData"

        Try

            strSql = objDal成品入库质检T.SetData(cls成品入库质检T)
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
    Public Function Check主图分图(ByVal cls成品入库质检T As Z成品入库质检T) As DataTable

        Dim objDal成品入库质检T As New DalZ成品入库质检T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll成品入库质检.Check主图分图"

        Try

            strSql = objDal成品入库质检T.Check主图分图(cls成品入库质检T)
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
