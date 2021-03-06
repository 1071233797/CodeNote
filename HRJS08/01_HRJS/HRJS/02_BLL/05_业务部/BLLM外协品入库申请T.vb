Imports System.Data.SqlClient

#Region "BLLM外协品入库申请T"
'------------------------------------------------------------------------------------
'   说明
'       外协品入库申请的数据操作层
'   创建人
'       大连智云科技 李陈盛
'   创建时间
'       2016/8/29
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class BLLM外协品入库申请T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry外协品入库申请 As ArrayList) As Integer

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协品入库申请.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry外协品入库申请.Count - 1
                Dim cls外协申请T As New B外协品入库申请T
                cls外协申请T = arry外协品入库申请(i)

                strSql = objDal外协品入库申请T.Insert(cls外协申请T)


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
    Public Function Update(ByVal cls外协品入库申请T As B外协品入库申请T) As Integer

        'Dim objDal外协品入库申请T As New DalM外协品入库申请T
        'Dim ObjDBConn As New DbHelper
        'Dim strSql As String = String.Empty
        'strErrorName = "Bll外协品入库申请.Update"

        'Try

        '    strSql = objDal外协品入库申请T.Update(cls外协品入库申请T)
        '    intRows = ObjDBConn.PFn_ExcuteDB(strSql)

        '    ObjDBConn.PSb_CloseDB()

        '    Return intRows

        'Catch ex As Exception
        '    ExHelper.ProcessDBHelper(ObjDBConn)
        '    Throw New Exception(strErrorName, ex)
        'End Try

    End Function

#End Region
#Region " Updatezj "

    '根据主键更新数据
    Public Function Updatezj(ByVal cls外协品入库申请T As B外协品入库申请T) As Integer

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.Updatezj"

        Try

            strSql = objDal外协品入库申请T.Updatezj(cls外协品入库申请T)
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
    Public Function Delete(ByVal cls外协品入库申请T As B外协品入库申请T) As Integer

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.Delete"

        Try

            strSql = objDal外协品入库申请T.Delete(cls外协品入库申请T)
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
    Public Function Deletezj(ByVal cls外协品入库申请T As B外协品入库申请T) As Integer

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.Deletezj"

        Try

            strSql = objDal外协品入库申请T.Deletezj(cls外协品入库申请T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Check主图分图 "

    '检索全部数据
    Public Function Check主图分图(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim objDal外协品入库申请T As New DalM外协品入库申请T

        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.Check主图分图"

        Try

            strSql = objDal外协品入库申请T.Check主图分图(cls外协品入库申请T)
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
    Public Function LoadByPKey(ByVal cls外协品入库申请T As B外协品入库申请T) As B外协品入库申请T

        Dim obj外协品入库申请T As New B外协品入库申请T
        Dim objRe原材料入库申请T As New B外协品入库申请T
        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try

            strSql = objDal外协品入库申请T.LoadByPKey(cls外协品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            If Not dtReturn Is Nothing AndAlso dtReturn.Rows.Count > 0 Then
                objRe原材料入库申请T.申请单编号 = dtReturn.Rows(0).Item("申请单编号")
            End If



            Return objRe原材料入库申请T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadByPKey1(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim obj外协品入库申请T As New B外协品入库申请T
        Dim objRe原材料入库申请T As New B外协品入库申请T
        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try

            strSql = objDal外协品入库申请T.LoadByPKey(cls外协品入库申请T)
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
    Public Function LoadAll(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.LoadAll"

        Try

            strSql = objDal外协品入库申请T.LoadAll(cls外协品入库申请T)
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
    Public Function LoadAllzj(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.LoadAllzj"

        Try

            strSql = objDal外协品入库申请T.LoadAllzj(cls外协品入库申请T)
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
    Public Function LoadAllHead(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.LoadAllHead"

        Try

            strSql = objDal外协品入库申请T.LoadAllHead(cls外协品入库申请T)
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
    Public Function SetData(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.SetData"

        Try

            strSql = objDal外协品入库申请T.SetData(cls外协品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " SetData1 "

    '检索全部数据
    Public Function SetData1(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.SetData"

        Try

            strSql = objDal外协品入库申请T.SetData1(cls外协品入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadGetCom "

    '根据主键检索

    Public Function LoadGetCom(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Try
            strSql = objDal外协品入库申请T.LoadGetCom(cls外协品入库申请T)
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
    Public Function LoadGridAll(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.LoadAll"

        Try

            strSql = objDal外协品入库申请T.LoadGridAll(cls外协品入库申请T)
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
    Public Function LoadByWhere(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.LoadByWhere"

        Try

            strSql = objDal外协品入库申请T.LoadByWhere(cls外协品入库申请T)
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
    Public Function LoadByWhere1(ByVal cls外协品入库申请T As B外协品入库申请T) As DataTable

        Dim objDal外协品入库申请T As New DalM外协品入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品入库申请.LoadByWhere"

        Try

            strSql = objDal外协品入库申请T.LoadByWhere1(cls外协品入库申请T)
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
