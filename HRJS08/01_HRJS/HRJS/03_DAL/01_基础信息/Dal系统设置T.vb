Imports System.Text

Public Class Dal系统设置T

#Region " 备份数据库 "

    '备份数据库
    Public Function Exc_DBBackUp(ByVal objM数据库备份T As M数据库备份T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" BACKUP DATABASE " & Utility.PFn_ChangeQuotation(objM数据库备份T.数据库名, True) & " TO DISK=" & Utility.PFn_ChangeQuotation(objM数据库备份T.备份路径) & " WITH Format") '备份路径
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region "插入数据库备份日期"
    Public Function Insert_DBBackUp(ByVal objM数据库备份T As M数据库备份T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO M数据库备份") 'M数据库备份

            strSql.Append(" ( 备份路径")            '备份路径
            strSql.Append(" ,登录者")               '登录者 
            strSql.Append(" ,登录日期")             '登录日期 
            strSql.Append(")")

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM数据库备份T.备份路径))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM数据库备份T.登录者))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM数据库备份T.登录日期))

            strSql.Append("  )" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

#Region "上次备份信息"
    Public Function GetLastDBBackupInfo() As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT TOP 1  备份ID") 'M数据库备份
            strSql.Append("      ,备份路径")            '备份路径
            strSql.Append("      ,登录者")               '登录者 
            strSql.Append("      ,登录日期")             '登录日期 
            strSql.Append("  FROM M数据库备份 ")
            strSql.Append("  ORDER BY 备份ID DESC")
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

End Class
