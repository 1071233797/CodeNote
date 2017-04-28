Imports System.Data.SqlClient
Imports System.Text

#Region "Bll采购单管理"
'------------------------------------------------------------------------------------
'   说明
'       采购单的数据操作层
'   创建人
'       
'   创建时间
'       2016/5/25
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class BllM原材料采购单管理T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " IsExists "

    '插入数据
    Public Function IsExists采购单编号(ByVal str采购单编号 As String) As Boolean

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "Bll采购单.IsExists"

        Try

            strSql = objDal采购单T.IsExists采购单编号(str采购单编号)
            objReturn = ObjDBConn.PFn_ExcuteScalar(strSql)
            ObjDBConn.PSb_CloseDB()

            If Convert.ToInt32(objReturn) = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry采购单 As ArrayList) As Integer

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            'strSql = objDalM供应商T.Delete(arry供应商(0))
            'intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            For i = 0 To arry采购单.Count - 1
                Dim cls采购T As New B原材料采购管理T
                cls采购T = arry采购单(i)   
                strSql = objDal采购单T.Insert(cls采购T)
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
    Public Function Update(ByVal arry订单 As ArrayList) As Integer

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.Update"
        Dim cls采购T As New B原材料采购管理T
        Try
            cls采购T = New B原材料采购管理T
            cls采购T = arry订单(0)
            ObjDBConn.PSb_BeginTransaction()

            strSql = objDal采购单T.Delete(cls采购T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)
            For i = 0 To arry订单.Count - 1
                cls采购T = New B原材料采购管理T
                cls采购T = arry订单(i)

                strSql = objDal采购单T.Insert(cls采购T)

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
#Region " Update审核 "

    '根据主键更新数据
    Public Function Update审核(ByVal cls采购单T As B原材料采购管理T) As Integer

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.Update"
        Dim cls采购T As New B原材料采购管理T
        Try
            strSql = objDal采购单T.Update审核(cls采购单T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " Update采购状态 "

    '根据主键更新数据
    Public Function Update采购状态(ByVal cls采购单T As B原材料采购管理T) As Integer

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.Update采购状态"
        Dim cls采购T As New B原材料采购管理T
        Try
            strSql = objDal采购单T.Update采购状态(cls采购单T)
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
    Public Function Delete(ByVal cls采购单T As B原材料采购管理T) As Integer

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.Delete"

        Try

            strSql = objDal采购单T.Delete(cls采购单T)
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
    Public Function LoadByPKey采购单编号(ByVal cls采购单T As B原材料采购管理T) As B原材料采购管理T

        Dim obj采购单T As New B原材料采购管理T
        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDal采购单T.LoadByPK采购单编号(cls采购单T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                obj采购单T.采购单编号 = sdr.Item("采购单编号")             '订单编号

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return obj采购单T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    ''检索全部数据
    Public Function LoadAll(ByVal cls采购单T As B原材料采购管理T) As DataTable

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.LoadAll"

        Try

            strSql = objDal采购单T.LoadAll(cls采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "LoadAll密度"
    Public Function LoadAll密度(ByVal cls采购单T As B原材料采购管理T) As DataTable

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM采购单.LoadAll密度"

        Try

            strSql = objDal采购单T.LoadAll密度(cls采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
#End Region
#Region " Load工序 "

    ''检索全部数据
    Public Function Load工序(ByVal cls采购单T As B原材料采购管理T) As DataTable

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.Load工序"

        Try

            strSql = objDal采购单T.Load工序(cls采购单T)
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

    ''检索全部数据
    Public Function SetData1(ByVal cls采购单T As B原材料采购管理T) As DataTable

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.SetData1"

        Try

            strSql = objDal采购单T.SetData1(cls采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadAllGrid1 "

    '检索全部数据


    Public Function LoadAllGrid1(ByVal cls原材料采购T As B原材料采购管理T) As DataTable

        Dim objDalM原材料T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM原材料采购.LoadAllGrid1"

        Try

            strSql = objDalM原材料T.LoadAllGrid1(cls原材料采购T)
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


    Public Function LoadAllHead(ByVal cls原材料采购T As B原材料采购管理T) As DataTable

        Dim objDalM原材料T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM原材料采购.LoadAllHead"

        Try

            strSql = objDalM原材料T.LoadAllHead(cls原材料采购T)
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

    ''检索全部数据
    Public Function SetData原材料(ByVal cls采购单T As B原材料采购管理T) As DataTable

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.SetData原材料"

        Try

            strSql = objDal采购单T.SetData原材料(cls采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "LoadDsByWhere"

    '检索全部数据
    Public Function LoadDsByWhere(ByVal clsM采购单T As B原材料采购管理T) As DataSet

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM采购单.LoadDsByWhere"
        Dim dsReturn As New DataSet
        Try

            strSql = objDal采购单T.LoadHead(clsM采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)
            dsReturn.Tables.Add(dtReturn)

            strSql = objDal采购单T.LoadBody(clsM采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)
            dsReturn.Tables.Add(dtReturn)


            ObjDBConn.PSb_CloseDB()

            Return dsReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "LoadDsByWhere1"

    '检索全部数据
    Public Function LoadDsByWhere1(ByVal clsM采购单T As B原材料采购管理T) As DataSet

        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM采购单.LoadDsByWhere1"
        Dim dsReturn As New DataSet
        Try

            strSql = objDal采购单T.LoadHead(clsM采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)
            dsReturn.Tables.Add(dtReturn)

            strSql = objDal采购单T.LoadBody1(clsM采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)
            dsReturn.Tables.Add(dtReturn)


            ObjDBConn.PSb_CloseDB()

            Return dsReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "LoadBand(0)"

    '检索全部数据
    Public Function LoadBand0(ByVal clsM采购单T As B原材料采购管理T) As DataTable
        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM采购单.LoadBand0"
        Try

            strSql = objDal采购单T.LoadBand0(clsM采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try
    End Function

#End Region

#Region "LoadBand1"

    '检索全部数据
    Public Function LoadBand1(ByVal clsM采购单T As B原材料采购管理T) As DataTable
        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM采购单.LoadBand1"
        Try

            strSql = objDal采购单T.LoadBand1(clsM采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try
    End Function

#End Region
#Region "ReportViewr"
    Public Function ReportViewr(ByVal clsM采购单T As B原材料采购管理T) As DataTable
        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM采购单.ReportViewr"
        Try

            strSql = objDal采购单T.ReportViewr(clsM采购单T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try
    End Function
#End Region
#Region "Get重量"
    Public Function Get重量(ByVal str主图号 As String, ByVal str上级图号 As String, ByVal str分图号 As String) As DataTable
        Dim objDal采购单T As New DalM原材料采购表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM采购单.Get重量"
        Try

            strSql = objDal采购单T.Get重量(str主图号, str上级图号, str分图号)
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
