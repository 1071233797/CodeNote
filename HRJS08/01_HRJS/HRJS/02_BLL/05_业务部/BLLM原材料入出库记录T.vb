Imports System.Data.SqlClient

#Region "Bll入出库记录"

Public Class BLLM原材料入出库记录T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal cls入出库记录T As B原材料入出库一览T) As Integer

        Dim objDal入出库记录T As New DalM原材料入出库记录T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll入出库记录.Insert"

        Try

            strSql = objDal入出库记录T.Insert(cls入出库记录T)
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
    Public Function Update(ByVal cls入出库记录T As B原材料入出库一览T) As Integer

        Dim objDal入出库记录T As New DalM原材料入出库记录T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll入出库记录.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDal入出库记录T.Update(cls入出库记录T)
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
    Public Function Delete(ByVal cls入出库记录T As B原材料入出库一览T) As Integer

        Dim objDal入出库记录T As New DalM原材料入出库记录T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll入出库记录.Delete"

        Try

            strSql = objDal入出库记录T.Delete(cls入出库记录T)
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
    Public Function LoadByPKey(ByVal cls入出库记录T As B原材料入出库一览T) As B原材料入出库一览T

        Dim obj入出库记录T As New B原材料入出库一览T
        Dim objDal入出库记录T As New DalM原材料入出库记录T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDal入出库记录T.LoadAll(cls入出库记录T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                obj入出库记录T.入出库记录CD = sdr.Item("入出库记录CD")
                'obj入出库记录T.入出库单号 = sdr.Item("入出库单号")             '入出库单号
                'obj入出库记录T.出荷指示编号 = sdr.Item("出荷指示编号")           '部品番号
                'obj入出库记录T.制造批量号 = sdr.Item("制造批量号")             '制造批量号
                obj入出库记录T.入出库区分 = Utility.PFn_IsDBNull(sdr.Item("入出库区分"), "")           '入出库区分
                'obj入出库记录T.入出库数量 = Utility.PFn_IsDBNull(sdr.Item("入出库数量"), "")             '数量
                'obj入出库记录T.入出库日期 = Utility.PFn_IsDBNull(sdr.Item("入出库日期"), "")             '日期
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return obj入出库记录T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal cls入出库记录T As B原材料入出库一览T) As DataTable

        Dim objDal入出库记录T As New DalM原材料入出库记录T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll入出库记录.LoadAll"

        Try

            strSql = objDal入出库记录T.LoadAll(cls入出库记录T)
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
    Public Function LoadByWhere(ByVal cls入出库记录T As B原材料入出库一览T) As DataTable

        Dim objDal入出库记录T As New DalM原材料入出库记录T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll入出库记录.LoadByWhere"

        Try

            strSql = objDal入出库记录T.LoadByWhere(cls入出库记录T)
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

#End Region

