Imports System.Data.SqlClient
Imports System.Text

#Region "BllM外协加工管理T"
'------------------------------------------------------------------------------------
'   说明
'       BllM外协加工管理T
'   创建人
'       
'   创建时间
'       2016/5/25
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class BllM外协加工管理T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " IsExists "

    '插入数据
    Public Function IsExists外协订单编号(ByVal str外协订单编号 As String) As Boolean

        Dim objDal外协订单T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "Bll外协加工管理.IsExists"

        Try

            strSql = objDal外协订单T.IsExists外协订单编号(str外协订单编号)
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
    Public Function Insert(ByVal arry外协加工 As ArrayList) As Integer

        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协加工管理.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            'strSql = objDalM供应商T.Delete(arry供应商(0))
            'intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            For i = 0 To arry外协加工.Count - 1
                Dim cls外协加工T As New B外协加工管理T
                cls外协加工T = arry外协加工(i)
                If String.IsNullOrEmpty(cls外协加工T.外协订单编号) Then
                    strSql = objDal外协加工T.Insert(cls外协加工T)
                Else
                    strSql = objDal外协加工T.Insert(cls外协加工T)
                End If
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

    Public Function Insert生产实绩_外协(ByVal cls外协加工T As B外协加工管理T) As Integer

        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协加工管理.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            strSql = objDal外协加工T.Insert生产实绩_外协(cls外协加工T)

            intRows += ObjDBConn.PFn_ExcuteDB(strSql)


            ObjDBConn.PSb_Commit()
            ObjDBConn.PSb_CloseDB()

            Return intRows


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function InsertNew初始管理(ByVal arry外协加工 As ArrayList) As Integer

        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协加工管理.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            'strSql = objDalM供应商T.Delete(arry供应商(0))
            'intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            For i = 0 To arry外协加工.Count - 1
                Dim cls外协加工T As New B外协加工管理T
                cls外协加工T = arry外协加工(i)

                strSql = objDal外协加工T.InsertNew初始管理(cls外协加工T)

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
    Public Function Update(ByVal arry外协 As ArrayList) As Integer

        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.Update"
        Dim cls外协加工T As New B外协加工管理T
        Try

            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry外协.Count - 1
                cls外协加工T = New B外协加工管理T
                cls外协加工T = arry外协(i)
                'cls订单T.订单状态 = 1
                strSql = objDal外协加工T.Update(cls外协加工T)

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
    Public Function Update审核(ByVal cls外协加工T As B外协加工管理T) As Integer

        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll采购单.Update"
        Dim cls外协加工管理T As New B外协加工管理T
        Try
            strSql = objDal外协加工T.Update审核(cls外协加工T)
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
    Public Function Delete(ByVal cls外协加工T As B外协加工管理T) As Integer

        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协加工管理.Delete"

        Try

            strSql = objDal外协加工T.Delete(cls外协加工T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "InsertBatch "

    '插入数据
    Public Function InsertBatch(ByVal obj外协加工T As DataTable) As Integer

        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As New StringBuilder
        strErrorName = "BllM外协加工管理.InsertBatch"
        Dim strSqlCD As String = String.Empty
        Try
            If obj外协加工T Is Nothing OrElse obj外协加工T.Rows.Count = 0 Then
                Return intRows
            End If

            For index = 0 To obj外协加工T.Rows.Count - 1
                Dim clsM外协加工T As New B外协加工管理T

                Dim intLoopj As Integer
                Dim strCheckString As String = ""

                For intLoopj = 0 To obj外协加工T.Columns.Count - 1
                    strCheckString += obj外协加工T.Rows(index)(intLoopj).ToString
                Next

                If strCheckString = "" Then
                    Continue For
                End If

                clsM外协加工T.外协订单编号 = obj外协加工T.Rows(index)("外协订单编号").ToString
                clsM外协加工T.外协对象编号 = obj外协加工T.Rows(index)("外协对象编号").ToString
                clsM外协加工T.订单编号 = obj外协加工T.Rows(index)("订单编号").ToString
                clsM外协加工T.分图号 = obj外协加工T.Rows(index)("分图号").ToString
                clsM外协加工T.主图号 = obj外协加工T.Rows(index)(" 主图号").ToString
                clsM外协加工T.客户编号 = obj外协加工T.Rows(index)("客户编号").ToString
                clsM外协加工T.外协加工数量 = obj外协加工T.Rows(index)("外协加工数量").ToString
                clsM外协加工T.回厂日期1 = obj外协加工T.Rows(index)(" 回厂日期").ToString
                clsM外协加工T.原材料编号 = obj外协加工T.Rows(index)("原材料编号").ToString
                'clsM外协加工T.计划带料数量 = obj外协加工T.Rows(index)("计划带料数量").ToString
                clsM外协加工T.实际带料数量 = obj外协加工T.Rows(index)("实际带料数量").ToString
                clsM外协加工T.加工单价 = obj外协加工T.Rows(index)(" 加工单价").ToString
                clsM外协加工T.加工总金额 = obj外协加工T.Rows(index)(" 加工总金额").ToString
                clsM外协加工T.审核人 = obj外协加工T.Rows(index)("审核人").ToString
                clsM外协加工T.审核状态 = obj外协加工T.Rows(index)("审核状态").ToString
                clsM外协加工T.备注 = obj外协加工T.Rows(index)("备注").ToString
                'clsM外协加工T.作成者 = obj外协加工T.Rows(index)("作成者").ToString
                'clsM外协加工T.登陆者 = obj外协加工T.Rows(index)("登陆者").ToString
                'clsM外协加工T.登陆日期 = DateTime.Now

                strSql.Append(objDal外协加工T.Insert(clsM外协加工T))
            Next

            intRows = ObjDBConn.PFn_ExcuteDB(strSql.ToString)

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
    Public Function LoadByPKey(ByVal cls外协加工T As B外协加工管理T) As B外协加工管理T

        Dim obj外协加工T As New B外协加工管理T
        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDal外协加工T.LoadByPK(cls外协加工T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                obj外协加工T.外协订单编号 = sdr.Item("外协订单编号")             '外协订单编号

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return obj外协加工T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadByPKey实际外协 "

    '根据主键检索
    Public Function LoadByPKey实际外协(ByVal cls外协加工T As B外协加工管理T) As DataTable

        Dim obj外协加工T As New B外协加工管理T
        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDal外协加工T.LoadByPKey实际外协(cls外协加工T)
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
    Public Function LoadAll(ByVal cls外协加工T As B外协加工管理T) As DataTable

        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协加工管理.LoadAll"

        Try

            strSql = objDal外协加工T.LoadAll(cls外协加工T)
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
    Public Function LoadDsByWhere(ByVal clsM外协加工T As B外协加工管理T) As DataSet

        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协加工管理.LoadDsByWhere"
        Dim dsReturn As New DataSet
        Try

            strSql = objDal外协加工T.LoadHead(clsM外协加工T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)
            dsReturn.Tables.Add(dtReturn)

            strSql = objDal外协加工T.LoadBody(clsM外协加工T)
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
    Public Function LoadBand0(ByVal clsM外协加工T As B外协加工管理T) As DataTable
        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协加工管理.LoadBand0"
        Try

            strSql = objDal外协加工T.LoadBand0(clsM外协加工T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try
    End Function

#End Region

#Region "LoadBand(1)"

    '检索全部数据
    Public Function LoadBand1(ByVal clsM外协加工T As B外协加工管理T) As DataTable
        Dim objDal外协加工T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协加工管理.LoadBand1"
        Try

            strSql = objDal外协加工T.LoadBand1(clsM外协加工T)
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
    Public Function LoadByWhere(ByVal clsB外协加工管理T As B外协加工管理T) As DataSet

        Dim objDalB外协加工管理T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllB外协加工管理T.LoadByWhere"
        Dim dsReturn As New DataSet
        Try
            If clsB外协加工管理T.区分 = 1 Then
                clsB外协加工管理T.外协加工状态 = "1"
                strSql = objDalB外协加工管理T.LoadByWhere(clsB外协加工管理T)
                'tudu
                dtReturn = ObjDBConn.PFn_FillDataTable(strSql)
                dsReturn.Tables.Add(dtReturn)
                ObjDBConn.PSb_CloseDB()

                Return dsReturn
            Else

                strSql = objDalB外协加工管理T.LoadHead(clsB外协加工管理T)
                dtReturn = ObjDBConn.PFn_FillDataTable(strSql)
                dsReturn.Tables.Add(dtReturn)

                strSql = objDalB外协加工管理T.LoadByWhere(clsB外协加工管理T)
                dtReturn = ObjDBConn.PFn_FillDataTable(strSql)
                dsReturn.Tables.Add(dtReturn)

                ObjDBConn.PSb_CloseDB()
                Return dsReturn
            End If

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " Check主图分图 "

    '检索全部数据
    Public Function Check主图分图(ByVal cls外协加工管理T As B外协加工管理T) As DataTable

        Dim objDal外协加工管理T As New DalM外协加工管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协加工管理.Check主图分图"

        Try

            strSql = objDal外协加工管理T.Check主图分图(cls外协加工管理T)
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
