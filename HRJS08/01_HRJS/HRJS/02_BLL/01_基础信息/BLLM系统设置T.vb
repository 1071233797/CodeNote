Imports System.Text
Imports System.Data.SqlClient

Public Class BLLM系统设置T

#Region "定义全局变量"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
    Dim objDal系统设置T As New Dal系统设置T
#End Region

#Region "数据库备份"

    Public Function Exc_DBBackUp(objM数据库备份T As M数据库备份T) As Integer

        Dim strSql As String = String.Empty
        Dim ObjDBConn As New DbHelper
        strErrorName = "BllM系统设置.数据库备份"

        Try
            'ObjDBConn.PSb_BeginTransaction()

            '备份数据库
            strSql = objDal系统设置T.Exc_DBBackUp(objM数据库备份T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            '插入备份记录
            strSql = String.Empty
            strSql = objDal系统设置T.Insert_DBBackUp(objM数据库备份T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            'ObjDBConn.PSb_Commit()
            ObjDBConn.PSb_CloseDB()

            Return intRows


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try


    End Function

#End Region

#Region "获取上次备份"
    Public Function GetLastDBBackupInfo() As M数据库备份T

        Dim strSql As String = String.Empty
        Dim objM数据库备份T As New M数据库备份T
        Dim ObjDBConn As New DbHelper
        strErrorName = "BllM系统设置.上次备份"
        Dim sdr As SqlDataReader
        Try
            strSql = objDal系统设置T.GetLastDBBackupInfo
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()
                objM数据库备份T.备份ID = sdr.Item("备份ID")
                objM数据库备份T.备份路径 = sdr.Item("备份路径")
                'objM数据库备份T.登录者 = sdr.Item("登录者")
                objM数据库备份T.登录日期 = sdr.Item("登录日期")
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM数据库备份T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)

        End Try





    End Function
#End Region

End Class
