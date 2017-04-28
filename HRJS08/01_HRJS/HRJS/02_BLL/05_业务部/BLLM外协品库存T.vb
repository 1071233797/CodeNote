Public Class BLLM外协品库存T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " LoadByPKey "

    '根据主键检索
    Public Function LoadByPKey(ByVal clsM外协品库存T As B外协品库存T) As DataTable

        Dim objDalM外协品库存T As New DalM外协品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品库存.LoadByPKey"
        Try

            strSql = objDalM外协品库存T.LoadByPKey(clsM外协品库存T)
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
    'Public Function LoadAll(ByVal clsM外协品库存T As B外协品库存T) As DataTable

    '    Dim objDalM外协品库存T As New DalM外协品库存T
    '    Dim ObjDBConn As New DbHelper
    '    Dim strSql As String = String.Empty
    '    strErrorName = "Bll外协品库存.LoadAll"

    '    Try

    '        strSql = objDalM外协品库存T.LoadCodeAll(clsM外协品库存T)
    '        dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

    '        ObjDBConn.PSb_CloseDB()

    '        Return dtReturn

    '    Catch ex As Exception
    '        ExHelper.ProcessDBHelper(ObjDBConn)
    '        Throw New Exception(strErrorName, ex)
    '    End Try

    'End Function

#End Region
#Region " LoadAllB "

    '检索全部数据
    Public Function LoadAllB(ByVal clsM外协品库存T As B外协品库存T) As DataTable

        Dim objDalM外协品库存T As New DalM外协品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品库存.LoadAllB"

        Try

            strSql = objDalM外协品库存T.LoadAllB(clsM外协品库存T)
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
    Public Function LoadByWhere(ByVal clsM外协品库存T As B外协品库存T) As DataTable

        Dim objDalM外协品库存T As New DalM外协品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品库存.LoadByWhere"

        Try

            strSql = objDalM外协品库存T.LoadByWhere(clsM外协品库存T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " SetData "

    '检索全部数据
    Public Function SetData(ByVal clsM外协品库存T As B外协品库存T) As DataTable

        Dim objDalM外协品库存T As New DalM外协品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品库存.SetData"

        Try

            strSql = objDalM外协品库存T.SetData(clsM外协品库存T)
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
    Public Function LoadLevel0(ByVal clsM外协品库存T As B外协品库存T) As DataTable

        Dim objDalM外协品库存T As New DalM外协品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品库存.LoadLevel0"

        Try

            strSql = objDalM外协品库存T.LoadLevel0(clsM外协品库存T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadLevel1(ByVal clsM外协品库存T As B外协品库存T) As DataTable

        Dim objDalM外协品库存T As New DalM外协品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品库存.LoadAll"

        Try

            strSql = objDalM外协品库存T.LoadLevel1(clsM外协品库存T)
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

        Dim objDalM外协品库存T As New DalM外协品库存T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "Bll外协品库存.LoadRepot"
        Try

            strSql = objDalM外协品库存T.LoadRepot(arrayList)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

    Public Function LoadToFile(ByVal clsM外协品库存T As B外协品库存T) As DataTable

        'Dim objDalM零部件T As New DalM零部件T
        Dim objDalM外协品库存T As New DalM外协品库存T

        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM零部件追溯.LoadByWhere"

        Try

            strSql = objDalM外协品库存T.LoadToFile(clsM外协品库存T)
            'dtReturn = ObjDBConn.FillDataTable(strSql)

            'ObjDBConn.Dispose()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

End Class


Public Class BLLM外协品标签打印T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry外协品标签打印 As ArrayList) As Integer

        Dim objDal外协品标签打印T As New DalM外协品标签打印T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协品标签打印T.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry外协品标签打印.Count - 1
                Dim obj外协品标签打印 As New B外协品标签打印T
                obj外协品标签打印 = arry外协品标签打印(i)

                strSql = objDal外协品标签打印T.Insert(obj外协品标签打印)

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
End Class