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

Public Class BLLM原材料入库申请T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry原材料入库申请 As ArrayList) As Integer

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM流转票管理T.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry原材料入库申请.Count - 1
                Dim obj原材料入库申请 As New B原材料入库申请T
                obj原材料入库申请 = arry原材料入库申请(i)

                strSql = objDal原材料入库申请T.Insert(obj原材料入库申请)

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
#Region " Insertzj "

    '插入数据
    Public Function Insertzj(ByVal arry原材料入库申请 As ArrayList) As Integer

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM流转票管理T.Insertzj"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry原材料入库申请.Count - 1
                Dim obj原材料入库申请 As New B原材料入库申请T
                obj原材料入库申请 = arry原材料入库申请(i)

                strSql = objDal原材料入库申请T.Insertzj(obj原材料入库申请)

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
    Public Function Update(ByVal cls原材料入库申请T As ArrayList) As Integer

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.Update"

        Try

            For i = 0 To cls原材料入库申请T.Count - 1
                Dim obj原材料入库申请 As New B原材料入库申请T
                obj原材料入库申请 = cls原材料入库申请T(i)

                strSql = objDal原材料入库申请T.Update(obj原材料入库申请)

                intRows += ObjDBConn.PFn_ExcuteDB(strSql)
            Next

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
    Public Function Updatezj(ByVal cls原材料入库申请T As B原材料入库申请T) As Integer

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.Updatezj"

        Try

            strSql = objDal原材料入库申请T.Updatezj(cls原材料入库申请T)
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
    Public Function Delete(ByVal cls原材料入库申请T As B原材料入库申请T) As Integer

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.Delete"

        Try

            strSql = objDal原材料入库申请T.Delete(cls原材料入库申请T)
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
    Public Function Deletezj(ByVal cls原材料入库申请T As B原材料入库申请T) As Integer

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.Deletezj"

        Try

            strSql = objDal原材料入库申请T.Deletezj(cls原材料入库申请T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " SetData1 "

    ''检索全部数据
    Public Function SetData原材料(ByVal cls入库T As B原材料入库申请T) As DataTable

        Dim objDal入库T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.SetData原材料"

        Try

            strSql = objDal入库T.SetData原材料(cls入库T)
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
    Public Function LoadByPKey(ByVal cls原材料入库申请T As B原材料入库申请T) As B原材料入库申请T

        Dim obj原材料入库申请T As New B原材料入库申请T
        Dim objRe原材料入库申请T As New B原材料入库申请T
        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try

            strSql = objDal原材料入库申请T.LoadByPKey(cls原材料入库申请T)
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

    Public Function LoadByPKey1(ByVal cls原材料入库申请T As B原材料入库申请T) As DataTable

        Dim obj原材料入库申请T As New B原材料入库申请T
        Dim objRe原材料入库申请T As New B原材料入库申请T
        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Try

            strSql = objDal原材料入库申请T.LoadAll(cls原材料入库申请T)
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
    Public Function LoadAllHead(ByVal cls原材料入库申请T As B原材料入库申请T) As DataTable

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.LoadAll"

        Try

            strSql = objDal原材料入库申请T.LoadAllHead(cls原材料入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAllHeadzj(ByVal cls原材料入库申请T As B原材料入库申请T) As DataTable

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.LoadAllHeadzj"

        Try

            strSql = objDal原材料入库申请T.LoadAllHeadzj(cls原材料入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAllHeadzj1(ByVal cls原材料入库申请T As B原材料入库申请T) As DataTable

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.LoadAllHeadzj1"

        Try

            strSql = objDal原材料入库申请T.LoadAllHeadzj1(cls原材料入库申请T)
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
    Public Function LoadAllzj(ByVal cls原材料入库申请T As B原材料入库申请T) As DataTable

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.LoadAllzj"

        Try

            strSql = objDal原材料入库申请T.LoadAllzj(cls原材料入库申请T)
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
    Public Function LoadGridAll(ByVal cls原材料入库申请T As B原材料入库申请T) As DataTable

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.LoadAll"

        Try

            strSql = objDal原材料入库申请T.LoadGridAll(cls原材料入库申请T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadGridAll编辑 "

    '检索全部数据
    Public Function LoadGridAll编辑(ByVal cls原材料入库申请T As B原材料入库申请T) As DataTable

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.LoadAll"

        Try

            strSql = objDal原材料入库申请T.LoadGridAll编辑(cls原材料入库申请T)
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
    Public Function LoadByWhere(ByVal cls原材料入库申请T As B原材料入库申请T) As DataTable

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.LoadByWhere"

        Try

            strSql = objDal原材料入库申请T.LoadByWhere(cls原材料入库申请T)
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
    Public Function LoadByWhere1(ByVal cls原材料入库申请T As B原材料入库申请T) As DataTable

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.LoadByWhere"

        Try

            strSql = objDal原材料入库申请T.LoadByWhere1(cls原材料入库申请T)
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

        Dim objDal原材料入库申请T As New DalM原材料入库申请T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料入库申请.Load打印数据"

        Try

            strSql = objDal原材料入库申请T.Load打印数据(strWhere)
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
