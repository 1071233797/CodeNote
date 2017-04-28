Public Class BLLM成品库存T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " LoadByPKey "

    '根据主键检索
    Public Function LoadByPKey(ByVal clsM成品库存T As B成品库存T) As DataTable

        Dim objDalM成品库存T As New DalM成品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT成品库存.LoadByPKey"
        Try

            strSql = objDalM成品库存T.LoadByPKey(clsM成品库存T)
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
    Public Function LoadAll(ByVal clsM成品库存T As B成品库存T) As DataTable

        Dim objDalM成品库存T As New DalM成品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT成品库存.LoadAll"

        Try

            strSql = objDalM成品库存T.LoadAll(clsM成品库存T)
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
    Public Function LoadByWhere(ByVal clsM成品库存T As B成品库存T) As DataTable

        Dim objDalM成品库存T As New DalM成品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT成品库存.LoadByWhere"

        Try

            strSql = objDalM成品库存T.LoadByWhere(clsM成品库存T)
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
    Public Function LoadLevel0(ByVal clsM成品库存T As B成品库存T) As DataTable

        Dim objDalM成品库存T As New DalM成品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT成品库存.LoadLevel0"

        Try

            strSql = objDalM成品库存T.LoadLevel0(clsM成品库存T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadLevel1(ByVal clsM成品库存T As B成品库存T) As DataTable

        Dim objDalM成品库存T As New DalM成品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT成品库存.LoadAll"

        Try

            strSql = objDalM成品库存T.LoadLevel1(clsM成品库存T)
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
    Public Function LoadRepot(ByVal arrayList As ArrayList) As DataTable

        Dim objDalM成品库存T As New DalM成品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllT成品库存.LoadRepot"
        Try

            strSql = objDalM成品库存T.LoadRepot(arrayList)
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
