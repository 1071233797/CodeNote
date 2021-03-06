Imports System.Data.SqlClient
Imports System.Text

#Region "Bll库存盘点表"
'------------------------------------------------------------------------------------
'   说明
'       库存盘点表的数据操作层
'   创建人
'       大连智云科技 刘春广
'   创建时间
'       2016/5/25
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class BLLB成品库存盘点T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据

    Public Function Insert备份(ByVal cls库存调整TList As ArrayList) As Integer

        Dim objDal库存调整T As New DalM成品库存盘点T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BLL外协品库存盘点T.Insert库存调整"

        Try
            ObjDBConn.PSb_BeginTransaction()
            For index = 0 To cls库存调整TList.Count - 1
                Dim cls库存调整T As New B成品库存盘点T
                cls库存调整T = cls库存调整TList(index)

                strSql = objDal库存调整T.Insert备份(cls库存调整T)
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
    Public Function Update库存调整(ByVal arrayList As ArrayList) As Integer

        Dim objDal库存盘点表T As New DalM成品库存盘点T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll库存盘点表.Update"
        Dim intLoopi As Integer

        Try

            ObjDBConn.PSb_BeginTransaction()

            For intLoopi = 0 To arrayList.Count - 1

                Dim objModel As New B成品库存盘点T
                objModel = arrayList(intLoopi)
                strSql = objDal库存盘点表T.Update库存调整(objModel)
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


#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal cls库存盘点表T As B成品库存盘点T) As DataTable

        Dim objDal库存盘点表T As New DalM外协品库存盘点T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll库存盘点表.LoadAll"

        'Try

        '    strSql = objDal库存盘点表T.LoadAll(cls库存盘点表T)
        '    dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

        '    ObjDBConn.PSb_CloseDB()

        '    Return dtReturn

        'Catch ex As Exception
        '    ExHelper.ProcessDBHelper(ObjDBConn)
        '    Throw New Exception(strErrorName, ex)
        'End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据
    Public Function LoadByWhere(ByVal clsM生产计划T As B成品库存盘点T) As DataTable
        Dim objDalB原材料库存盘点T As New DalM外协品库存盘点T

        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT库存盘点表T.LoadByWhere"

        'Try

        '    strSql = objDalB原材料库存盘点T.LoadByWhere(clsM生产计划T)
        '    dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

        '    ObjDBConn.PSb_CloseDB()

        '    Return dtReturn

        'Catch ex As Exception
        '    ExHelper.ProcessDBHelper(ObjDBConn)
        '    Throw New Exception(strErrorName, ex)
        'End Try

    End Function

#End Region

#Region " LoadLevel"

    '检索全部数据
    Public Function LoadLevel(ByVal clsMSearchT As B成品库存盘点T) As DataTable
        Dim objDalB成品库存盘点T As New DalM成品库存盘点T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT库存盘点表T.LoadLevel0"

        Try

            strSql = objDalB成品库存盘点T.LoadLevel(clsMSearchT)
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
