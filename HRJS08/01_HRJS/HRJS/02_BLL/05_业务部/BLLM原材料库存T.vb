Public Class BLLM原材料库存T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " LoadByPKey "

    '根据主键检索
    Public Function LoadByPKey(ByVal clsM原材料库存T As M原材料库存T) As DataTable

        Dim objDalM原材料库存T As New DalM原材料库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料库存.LoadByPKey"
        Try

            strSql = objDalM原材料库存T.LoadByPKey(clsM原材料库存T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAllu "

    '检索全部数据
    Public Function LoadAll(ByVal clsM原材料库存T As M原材料库存T) As DataTable

        Dim objDalM原材料库存T As New DalM原材料库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料库存.LoadAll"

        Try

            strSql = objDalM原材料库存T.LoadCodeAll(clsM原材料库存T)
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
    Public Function LoadByWhere(ByVal clsM原材料库存T As M原材料库存T) As DataTable

        Dim objDalM原材料库存T As New DalM原材料库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料库存.LoadByWhere"

        Try

            strSql = objDalM原材料库存T.LoadByWhere(clsM原材料库存T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadLevel "

    '检索全部数据
    Public Function LoadLevel0(ByVal clsM原材料库存T As M原材料库存T) As DataTable

        Dim objDalM原材料库存T As New DalM原材料库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料库存.LoadLevel0"

        Try

            strSql = objDalM原材料库存T.LoadLevel0(clsM原材料库存T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadLevel1(ByVal clsM原材料库存T As M原材料库存T) As DataTable

        Dim objDalM原材料库存T As New DalM原材料库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料库存.LoadAll"

        Try

            strSql = objDalM原材料库存T.LoadLevel1(clsM原材料库存T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadRepot "

    '根据主键检索
    Public Function LoadRepot(ByVal clsM原材料库存T As M原材料库存T) As DataTable

        Dim objDalM原材料库存T As New DalM原材料库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料库存.LoadRepot"
        Try

            strSql = objDalM原材料库存T.LoadRepot(clsM原材料库存T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

    Public Function LoadToFile(ByVal clsM原材料库存T As M原材料库存T) As DataTable

        'Dim objDalM零部件T As New DalM零部件T
        Dim objDalM原材料库存T As New DalM原材料库存T

        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM零部件追溯.LoadByWhere"

        Try

            strSql = objDalM原材料库存T.LoadToFile(clsM原材料库存T)
            'dtReturn = ObjDBConn.FillDataTable(strSql)

            'ObjDBConn.Dispose()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

End Class


Public Class BLLM原材料标签打印T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal cls原材料标签 As B原材料标签打印T) As Integer

        Dim objDal原材料标签打印T As New DalM原材料标签打印T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM原材料标签打印T.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            Dim obj原材料标签打印 As New B原材料标签打印T
            obj原材料标签打印 = cls原材料标签

            strSql = objDal原材料标签打印T.Insert(obj原材料标签打印)

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
#Region " SetData "

    '检索全部数据
    Public Function SetData(ByVal clsM原材料T As B原材料标签打印T) As DataTable

        Dim objDalM原材料T As New DalM原材料标签打印T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll原材料.LoadAll"

        Try

            strSql = objDalM原材料T.SetData(clsM原材料T)
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