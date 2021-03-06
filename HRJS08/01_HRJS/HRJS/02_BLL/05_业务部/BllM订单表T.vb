Imports System.Data.SqlClient
Imports System.Text

#Region "Bll订单表"
'------------------------------------------------------------------------------------
'   说明
'       订单表的数据操作层
'   创建人
'       大连智云科技 解辉品
'   创建时间
'       2016/5/25
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class BllM订单表T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " IsExists "

    '插入数据
    Public Function IsExists订单编号(ByVal str订单编号 As String) As Boolean

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "Bll订单表.IsExists"

        Try

            strSql = objDal订单表T.IsExists订单编号(str订单编号)
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

    Public Function IsExists厂内编号(ByVal str厂内编号 As String) As Boolean

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "Bll订单表.IsExists"

        Try

            strSql = objDal订单表T.IsExists厂内编号(str厂内编号)
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
    Public Function Insert(ByVal arry订单 As ArrayList) As Integer

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll订单表.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            'strSql = objDalM供应商T.Delete(arry供应商(0))
            'intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            For i = 0 To arry订单.Count - 1
                Dim cls订单T As New B订单表T
                cls订单T = arry订单(i)

                strSql = objDal订单表T.Insert(cls订单T)

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
#Region " Update审核数据 lxq add 2017-04-21"

    '根据主键更新数据
    Public Function Update审核数据(ByVal cls订单表T As B订单表T) As Integer

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll订单表.Update审核数据"
        Try

            strSql = objDal订单表T.Update审核数据(cls订单表T)
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
    Public Function Delete(ByVal cls订单表T As B订单表T) As Integer

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll订单表.Delete"

        Try

            strSql = objDal订单表T.Delete(cls订单表T)
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
    Public Function LoadByPKey厂内编号(ByVal cls订单表T As B订单表T) As B订单表T

        Dim obj订单表T As New B订单表T
        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDal订单表T.LoadByPK厂内编号(cls订单表T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                obj订单表T.订单编号 = sdr.Item("订单编号")             '订单编号
                obj订单表T.厂内编号 = sdr.Item("厂内编号")             '出荷去向

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return obj订单表T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadByPKey订单编号(ByVal cls订单表T As B订单表T) As B订单表T

        Dim obj订单表T As New B订单表T
        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDal订单表T.LoadByPK订单编号(cls订单表T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                obj订单表T.订单编号 = sdr.Item("订单编号")             '订单编号
                obj订单表T.厂内编号 = sdr.Item("厂内编号")             '出荷去向

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return obj订单表T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadByPKey订单编号1(ByVal cls订单表T As B订单表T) As B订单表T

        Dim obj订单表T As New B订单表T
        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDal订单表T.LoadByPK订单编号1(cls订单表T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                obj订单表T.订单编号 = sdr.Item("订单编号")             '订单编号
                obj订单表T.厂内编号 = sdr.Item("厂内编号")             '出荷去向

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return obj订单表T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadByPKey(ByVal cls订单表T As B订单表T) As B订单表T

        Dim obj订单表T As New B订单表T
        Dim objDalM订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM订单表T.LoadByPK(cls订单表T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                obj订单表T.客户编号 = sdr.Item("客户编号")          '人员CD
                obj订单表T.审核状态 = sdr.Item("审核状态")

            End If

            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return obj订单表T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadAllexp "

    ''检索全部数据
    Public Function LoadAllexp(ByVal cls订单表T As B订单表T) As DataTable

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll订单表.LoadAllexp"

        Try

            strSql = objDal订单表T.LoadBodyAllexp(cls订单表T)
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

    ''检索全部数据
    Public Function LoadAll(ByVal cls订单表T As B订单表T) As DataTable

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll订单表.LoadAll"

        Try

            strSql = objDal订单表T.LoadBodyAll(cls订单表T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadByWherejd "

    '检索全部数据
    Public Function LoadByWherejd(ByVal clsM订单表T As B订单表T) As DataTable

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM订单表.LoadByWherejd"

        Try

            strSql = objDal订单表T.LoadByWherejd(clsM订单表T)
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
    Public Function LoadByWhere(ByVal clsM订单表T As B订单表T) As DataTable

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM订单表.LoadByWhere"

        Try

            strSql = objDal订单表T.LoadByWhere(clsM订单表T)
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
    Public Function LoadByWhere1(ByVal clsM订单表T As B订单表T) As DataTable

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM订单表.LoadByWhere1"

        Try

            strSql = objDal订单表T.LoadByWhere1(clsM订单表T)
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
    Public Function LoadDsByWhere(ByVal clsM订单表T As B订单表T) As DataSet

        Dim objDal订单表T As New DalM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM订单表.LoadByWhere"
        Dim dsReturn As New DataSet
        Try

            strSql = objDal订单表T.LoadHead(clsM订单表T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)
            dsReturn.Tables.Add(dtReturn)

            strSql = objDal订单表T.LoadBody(clsM订单表T)
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

End Class
