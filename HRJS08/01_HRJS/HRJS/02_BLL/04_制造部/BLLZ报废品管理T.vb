Imports System.Data.SqlClient

#Region "BllZ报废品管理T
'------------------------------------------------------------------------------------
'   说明
'       Z报废品管理T的数据操作层
'   创建人
'       大连智云科技 李陈盛
'   创建时间
'       2016/8/31
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class BLLZ报废品管理T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal clsZ报废品管理T As Z报废品管理T) As Integer

        Dim objDalZ报废品管理T As New DalZ报废品管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ报废品管理T.Insert"

        Try

            strSql = objDalZ报废品管理T.Insert(clsZ报废品管理T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

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
    Public Function Update(ByVal clsZ报废品管理T As Z报废品管理T) As Integer

        Dim objDalZ报废品管理T As New DalZ报废品管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ报废品管理T.Update"

        Try


            strSql = objDalZ报废品管理T.Update(clsZ报废品管理T)
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
    Public Function Delete(ByVal clsZ报废品管理T As Z报废品管理T) As Integer

        Dim objDalZ报废品管理T As New DalZ报废品管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ报废品管理T.Delete"

        Try

            strSql = objDalZ报废品管理T.Delete(clsZ报废品管理T)
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
    Public Function LoadByPKey(ByVal clsZ报废品管理T As Z报废品管理T) As Z报废品管理T

        Dim objZ报废品管理T As New Z报废品管理T
        Dim objDalZ报废品管理T As New DalZ报废品管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalZ报废品管理T.LoadAll(clsZ报废品管理T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objZ报废品管理T.订单编号 = sdr.Item("订单编号")           '订单编号
                objZ报废品管理T.报废品图号 = sdr.Item("报废品图号")             '报废品图号
                objZ报废品管理T.总图号 = sdr.Item("总图号")             '总图号
                objZ报废品管理T.报废品产生工序 = sdr.Item("报废品产生工序")             '报废品产生工序
                objZ报废品管理T.报废品数量 = sdr.Item("报废品数量")             '报废品数量
                objZ报废品管理T.报废品生产者 = sdr.Item("报废品生产者")           '报废品生产者
                objZ报废品管理T.报废日期 = sdr.Item("报废日期")           '报废日期
                objZ报废品管理T.图片1 = sdr.Item("图片1")             '图片1
                objZ报废品管理T.图片2 = sdr.Item("图片2")             '图片2
                objZ报废品管理T.图片3 = sdr.Item("图片3")             '图片3
                objZ报废品管理T.报废原因 = sdr.Item("报废原因")           '报废原因
                objZ报废品管理T.品质处理结果 = sdr.Item("品质处理结果")           '品质处理结果
                objZ报废品管理T.备注 = sdr.Item("备注 ")             '备注 
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objZ报废品管理T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsZ报废品管理T As Z报废品管理T) As DataTable

        Dim objDalZ报废品管理T As New DalZ报废品管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ报废品管理T.LoadAll"

        Try

            strSql = objDalZ报废品管理T.LoadAll(clsZ报废品管理T)
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
