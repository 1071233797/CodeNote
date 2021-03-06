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

Public Class BLLB原材料库存盘点T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "
    Public Function Insert库存调整(ByVal cls库存调整TList As ArrayList) As Integer

        Dim objDal库存调整T As New DalM原材料库存盘点T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BLLB原材料库存盘点T.Insert库存调整"

        Try
            ObjDBConn.PSb_BeginTransaction()
            For index = 0 To cls库存调整TList.Count - 1
                Dim cls库存调整T As New B原材料库存盘点表T
                cls库存调整T = cls库存调整TList(index)

                'strSql = objDal库存调整T.Update库存(cls库存调整T)
                'intRows += ObjDBConn.PFn_ExcuteDB(strSql)

                strSql = objDal库存调整T.Insert(cls库存调整T)
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


#Region " Delete "

    '删除数据
    Public Function Delete(ByVal cls库存盘点表T As B原材料库存盘点表T) As Integer

        Dim objDal库存盘点表T As New DalM原材料库存盘点T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll库存盘点表.Delete"

        Try

            strSql = objDal库存盘点表T.Delete(cls库存盘点表T)
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
    Public Function LoadByPKey(ByVal cls库存盘点表T As B原材料库存盘点表T) As B原材料库存盘点表T

        Dim obj库存盘点表T As New B原材料库存盘点表T
        Dim objDal库存盘点表T As New DalM原材料库存盘点T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDal库存盘点表T.LoadAll(cls库存盘点表T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                obj库存盘点表T.货架编号 = sdr.Item("货架编号")           '货架编号
                'obj库存盘点表T.部品番号 = sdr.Item("部品番号")           '部品番号
                'obj库存盘点表T.部品区分 = Utility.PFn_IsDBNull(sdr.Item("部品区分"), "")             '部品区分
                'obj库存盘点表T.在库数量 = Utility.PFn_IsDBNull(sdr.Item("在库数量"), "")             '现库存数
                'obj库存盘点表T.盘点数量 = Utility.PFn_IsDBNull(sdr.Item("盘点数量"), "")           '盘点数
                'obj库存盘点表T.差异数 = Utility.PFn_IsDBNull(sdr.Item("差异数"), "")           '差异数
                'obj库存盘点表T.调整数量 = Utility.PFn_IsDBNull(sdr.Item("调整数量"), "")             '调整数量
                'obj库存盘点表T.调整后在库 = Utility.PFn_IsDBNull(sdr.Item("调整后在库"), "")           '调整后在库
                'obj库存盘点表T.盘点日期 = Utility.PFn_IsDBNull(sdr.Item("盘点日期"), "")             '盘点日期
                obj库存盘点表T.处理方式 = Utility.PFn_IsDBNull(sdr.Item("处理方式"), "")             '处理方式
                obj库存盘点表T.在库状态 = Utility.PFn_IsDBNull(sdr.Item("在库状态"), "")             '在库状态
                obj库存盘点表T.备注 = Utility.PFn_IsDBNull(sdr.Item("备注"), "")             '备注
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return obj库存盘点表T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal cls库存盘点表T As B原材料库存盘点表T) As DataTable

        Dim objDal库存盘点表T As New DalM原材料库存盘点T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll库存盘点表.LoadAll"

        Try

            strSql = objDal库存盘点表T.LoadAll(cls库存盘点表T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据
    Public Function LoadByWhere(ByVal clsM生产计划T As B原材料库存盘点表T) As DataTable
        Dim objDalB原材料库存盘点T As New DalM原材料库存盘点T

        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT库存盘点表T.LoadByWhere"

        Try

            strSql = objDalB原材料库存盘点T.LoadByWhere(clsM生产计划T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadLevel0"

    '检索全部数据
    Public Function LoadLevel0(ByVal clsMSearchT As B原材料库存盘点表T) As DataTable
        Dim objDalB原材料库存盘点T As New DalM原材料库存盘点T

        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT库存盘点表T.LoadLevel0"

        Try

            strSql = objDalB原材料库存盘点T.LoadLevel0(clsMSearchT)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadLevel1"

    '检索全部数据
    Public Function LoadLevel1(ByVal clsMSearchT As B原材料库存盘点表T) As DataTable
        Dim objDalB原材料库存盘点T As New DalM原材料库存盘点T

        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT库存盘点表T.LoadLevel1"

        Try

            strSql = objDalB原材料库存盘点T.LoadLevel1(clsMSearchT)
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
