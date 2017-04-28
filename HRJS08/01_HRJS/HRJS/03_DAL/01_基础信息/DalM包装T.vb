Imports System.Text

Public Class DalM包装T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal ojbM包装T As M包装T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append("INSERT  dbo.M包装 ")
            strSql.Append("        (	包装物编号, ")
            strSql.Append("			包装物名称,  ")
            strSql.Append("			规格,  ")
            strSql.Append("			供应商编号,")
            strSql.Append(" 登录者")               '登录者 
            strSql.Append(" ,登录日期")             '登录日期 
            strSql.Append("  )VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.包装物编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.包装物名称))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.规格))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.供应商编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.登录者))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.登录日期))
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
    Public Function Update(ByVal ojbM包装T As M包装T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       M包装 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)

            strSQL.AppendFormat(" 		包装物编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.包装物编号))
            strSQL.AppendFormat(" 		,包装物名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.包装物名称))
            strSQL.AppendFormat(" 		,规格 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.规格))
            strSQL.AppendFormat(" 		,供应商编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.供应商编号))
            strSQL.AppendFormat(" ,更新者={0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.更新者))
            strSQL.AppendFormat(" ,更新日期={0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.更新日期))
            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    包装物编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.包装物编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM包装T As M包装T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" DELETE FROM M包装" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  包装物编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM包装T.包装物编号))

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

    Public Function LoadAll(ByVal objM包装T As M包装T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	包装物编号" & vbCrLf)
            strSql.Append(" 	,包装物名称" & vbCrLf)
            strSql.Append(" 	,规格" & vbCrLf)
            strSql.Append(" 	,M供应商管理.供应商编号" & vbCrLf)
            strSql.Append(" 	,M供应商管理.供应商名称" & vbCrLf)
            strSql.Append(" FROM M包装")
            strSql.Append("        INNER JOIN dbo.M供应商管理  ")
            strSql.Append("        ON M供应商管理.供应商编号 = M包装.供应商编号 ")
            '检索条件 设定
            strSql.Append(" WHERE 包装物编号=" & Utility.PFn_ChangeQuotation(objM包装T.包装物编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据

    Public Function LoadByPK(ByVal objM包装T As M包装T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	包装物编号," & vbCrLf)
            strSql.Append(" 	包装物名称," & vbCrLf)
            strSql.Append(" 	规格," & vbCrLf)
            strSql.Append(" 	供应商编号" & vbCrLf)

            strSql.Append(" FROM M包装")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM包装T.包装物编号 <> String.Empty) Then
                strSql.Append(" AND 包装物编号=" & Utility.PFn_ChangeQuotation(objM包装T.包装物编号) & vbCrLf)
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

    Public Function LoadByWhere(ByVal objM包装T As M包装T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append("SELECT  M包装.包装物编号 , ")
            strSql.Append("        M包装.包装物名称 , ")
            strSql.Append("        M包装.规格 , ")
            strSql.Append("        供应商名称 ")
            strSql.Append("FROM    dbo.M包装 ")
            strSql.Append("        INNER JOIN dbo.M供应商管理  ")
            strSql.Append("        ON M供应商管理.供应商编号 = M包装.供应商编号 ")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM包装T.包装物编号 <> String.Empty) Then
                strSql.Append(" AND 包装物编号 LIKE '" & Utility.PFn_ChangeQuotation(objM包装T.包装物编号, True) & "%'" & vbCrLf)
            End If
            If (objM包装T.包装物名称 <> String.Empty) Then
                strSql.Append(" AND 包装物名称 LIKE '%" & Utility.PFn_ChangeQuotation(objM包装T.包装物名称, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 包装物编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


End Class
