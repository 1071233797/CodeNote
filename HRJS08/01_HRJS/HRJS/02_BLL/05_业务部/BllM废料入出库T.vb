Imports System.Data.SqlClient
Imports System.Text



Public Class BllM废料入出库T


    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Update "

    '根据主键更新数据
    'Public Function Update(ByVal clsM废料入出库T As B废料入出库T) As DataTable

    '    Dim objDal废料入出库T As New DalM废料入出库T
    '    Dim ObjDBConn As New DbHelper
    '    Dim strSql As String = String.Empty
    '    strErrorName = "BllM废料入出库.Update"

    '    Try

    '        ObjDBConn.PSb_BeginTransaction()
    '        strSql = objDal废料入出库T.Load外协(clsM废料入出库T)
    '        If strSql Is Nothing Then
    '            strSql = objDal废料入出库T.LoadByWhere(clsM废料入出库T)
    '        Else
    '            strSql = objDal废料入出库T.Update(clsM废料入出库T)
    '        End If
    '        intRows = ObjDBConn.PFn_ExcuteDB(strSql)
    '        ObjDBConn.PSb_Commit()

    '        ObjDBConn.PSb_CloseDB()
    '        LoadByWhere(clsM废料入出库T)
    '        Return dtReturn

    '    Catch ex As Exception
    '        ExHelper.ProcessDBHelper(ObjDBConn)
    '        Throw New Exception(strErrorName, ex)
    '    End Try

    'End Function

#End Region
    '#Region " LoadByPKey "

    '根据主键检索
    'Public Function LoadByPKey厂内编号(ByVal cls订单表T As B订单表T) As B订单表T

    '    Dim obj订单表T As New B订单表T
    '    Dim objDal订单表T As New DalM订单表T
    '    Dim ObjDBConn As New DbHelper
    '    Dim strSql As String = System.String.Empty    'Sql文
    '    Dim sdr As SqlDataReader

    '    Try

    '        strSql = objDal订单表T.LoadByPK厂内编号(cls订单表T)
    '        sdr = ObjDBConn.PFn_ExcuteReader(strSql)

    '        '数据存在
    '        If sdr.HasRows = True Then

    '            sdr.Read()

    '            obj订单表T.订单编号 = sdr.Item("订单编号")             '订单编号
    '            obj订单表T.厂内编号 = sdr.Item("厂内编号")             '出荷去向

    '        End If

    '        'DataReader关闭
    '        sdr.Close()
    '        ObjDBConn.PSb_CloseDB()

    '        Return obj订单表T

    '    Catch ex As Exception
    '        ExHelper.ProcessDBHelper(ObjDBConn)
    '        Throw New Exception(strErrorName, ex)
    '    End Try

    'End Function

    '    Public Function LoadByPKey订单编号(ByVal cls订单表T As B订单表T) As B订单表T

    '        Dim obj订单表T As New B订单表T
    '        Dim objDal订单表T As New DalM订单表T
    '        Dim ObjDBConn As New DbHelper
    '        Dim strSql As String = System.String.Empty    'Sql文
    '        Dim sdr As SqlDataReader

    '        Try

    '            strSql = objDal订单表T.LoadByPK订单编号(cls订单表T)
    '            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

    '            '数据存在
    '            If sdr.HasRows = True Then

    '                sdr.Read()

    '                obj订单表T.订单编号 = sdr.Item("订单编号")             '订单编号
    '                obj订单表T.厂内编号 = sdr.Item("厂内编号")             '出荷去向

    '            End If

    '            'DataReader关闭
    '            sdr.Close()
    '            ObjDBConn.PSb_CloseDB()

    '            Return obj订单表T

    '        Catch ex As Exception
    '            ExHelper.ProcessDBHelper(ObjDBConn)
    '            Throw New Exception(strErrorName, ex)
    '        End Try

    '    End Function


    '#End Region

    '#Region " LoadAll "

    '    ''检索全部数据
    '    Public Function LoadAll(ByVal cls外协申请一览T As B外协申请一览T) As DataTable

    '        Dim objDal外协申请一览T As New DalM外协申请一览T
    '        Dim ObjDBConn As New DbHelper
    '        Dim strSql As String = String.Empty
    '        strErrorName = "Bll外协申请一览.LoadAll"

    '        Try

    '            strSql = objDal外协申请一览T.LoadAll(cls外协申请一览T)
    '            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

    '            ObjDBConn.PSb_CloseDB()

    '            Return dtReturn

    '        Catch ex As Exception
    '            ExHelper.ProcessDBHelper(ObjDBConn)
    '            Throw New Exception(strErrorName, ex)
    '        End Try

    '    End Function

    '#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal clsB废料入出库T As B废料入出库T) As DataTable

        Dim objDalB废料入出库T As New DalM废料入出库T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllB废料入出库T.LoadByWhere"

        Try

            strSql = objDalB废料入出库T.LoadByWhere(clsB废料入出库T)
            'tudu
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
