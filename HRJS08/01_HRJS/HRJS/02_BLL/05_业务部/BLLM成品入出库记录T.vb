Imports System.Data.SqlClient

#Region "Bll入出库记录"

Public Class BLLM成品入出库记录T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String


#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls入出库记录T As B成品入出库一览T) As DataTable

        Dim objDal入出库记录T As New DalM成品入出库记录T
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

