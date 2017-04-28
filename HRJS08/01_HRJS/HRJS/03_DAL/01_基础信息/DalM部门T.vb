Imports System.Text

Public Class DalM部门T

#Region "IsExists"

    Public Function IsExists(ByVal str部门编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   M部门管理 " & vbCrLf)
            strSql.Append("WHERE  部门编号 = " & Utility.PFn_ChangeQuotation(str部门编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal ojbM部门管理T As M部门T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO M部门管理") 'M部门

            strSql.Append(" ( 部门编号")            '部门编号
            strSql.Append(" ,部门名称")             '部门名称
            strSql.Append(" ,登录者")               '登录者 
            strSql.Append(" ,登录日期")             '登录日期 
            strSql.Append(")")

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM部门管理T.部门编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM部门管理T.部门名称))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM部门管理T.登录者))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM部门管理T.登录日期))

            strSql.Append("  )" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal ojbM部门管理T As M部门T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       M部门管理 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)

            strSQL.AppendFormat(" 		部门名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM部门管理T.部门名称))

            strSQL.AppendFormat(" 		,更新者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM部门管理T.更新者))
            strSQL.AppendFormat(" 		,更新日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM部门管理T.更新日期))
            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    部门编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM部门管理T.部门编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM部门管理T As M部门T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM M部门管理" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  部门编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM部门管理T.部门编号))

            'SQLに戻る
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal objM部门T As M部门T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	部门编号" & vbCrLf)
            strSql.Append(" 	,部门名称" & vbCrLf)
            'strSql.Append(" 	,登录者" & vbCrLf)
            'strSql.Append(" 	,登录日期" & vbCrLf)
            'strSql.Append(" 	,更新者" & vbCrLf)
            'strSql.Append(" 	,更新日期" & vbCrLf)
            strSql.Append(" FROM M部门管理")
            '检索条件 设定
            strSql.Append(" WHERE 部门编号=" & Utility.PFn_ChangeQuotation(objM部门T.部门编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal objM部门T As M部门T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	部门编号," & vbCrLf)
            strSql.Append(" 	部门名称," & vbCrLf)
            strSql.Append(" 	登录者," & vbCrLf)
            strSql.Append(" 	登录日期," & vbCrLf)
            strSql.Append(" 	更新者," & vbCrLf)
            strSql.Append(" 	更新日期" & vbCrLf)
            strSql.Append(" FROM M部门管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM部门T.部门编号 <> String.Empty) Then
                strSql.Append(" AND 部门编号=" & Utility.PFn_ChangeQuotation(objM部门T.部门编号) & vbCrLf)
            End If
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据
    Public Function LoadByWhere(ByVal objM部门T As M部门T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	部门编号" & vbCrLf)
            strSql.Append(" 	,部门名称" & vbCrLf)
            'strSql.Append(" 	,登录者" & vbCrLf)
            'strSql.Append(" 	,登录日期" & vbCrLf)
            'strSql.Append(" 	,更新者" & vbCrLf)
            'strSql.Append(" 	,更新日期" & vbCrLf)
            strSql.Append(" FROM M部门管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM部门T.部门编号 <> String.Empty) Then
                strSql.Append(" AND 部门编号 LIKE '" & Utility.PFn_ChangeQuotation(objM部门T.部门编号, True) & "%'" & vbCrLf)
            End If
            If (objM部门T.部门名称 <> String.Empty) Then
                strSql.Append(" AND 部门名称 LIKE '%" & Utility.PFn_ChangeQuotation(objM部门T.部门名称, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 部门编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


End Class
