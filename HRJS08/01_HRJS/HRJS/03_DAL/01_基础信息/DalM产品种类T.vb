Imports System.Text

Public Class DalM产品种类T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal ojbM产品种类T As M产品种类T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" INSERT INTO M产品种类") 'M产品种类

            strSql.Append(" ( 产品种类编号")            '产品种类编号
            strSql.Append(" ,产品种类名称")             '产品种类名称
            strSql.Append(")")

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM产品种类T.产品种类编号))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM产品种类T.产品种类名称))

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
    Public Function Update(ByVal ojbM产品种类T As M产品种类T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       M产品种类 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)

            strSQL.AppendFormat(" 		产品种类名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM产品种类T.产品种类名称))
            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    产品种类编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM产品种类T.产品种类编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM产品种类T As M产品种类T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM M产品种类" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  产品种类编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM产品种类T.产品种类编号))

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

    Public Function LoadAll(ByVal ojbM产品种类T As M产品种类T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	产品种类编号" & vbCrLf)
            strSql.Append(" 	,产品种类名称" & vbCrLf)
            strSql.Append(" FROM M产品种类")
            '检索条件 设定
            strSql.Append(" WHERE 产品种类编号=" & Utility.PFn_ChangeQuotation(ojbM产品种类T.产品种类编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据

    Public Function LoadByPK(ByVal ojbM产品种类T As M产品种类T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	产品种类编号," & vbCrLf)
            strSql.Append(" 	产品种类名称" & vbCrLf)
            strSql.Append(" FROM M产品种类")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (ojbM产品种类T.产品种类编号 <> String.Empty) Then
                strSql.Append(" AND 产品种类编号=" & Utility.PFn_ChangeQuotation(ojbM产品种类T.产品种类编号) & vbCrLf)
            End If
            If (ojbM产品种类T.产品种类名称 <> String.Empty) Then
                strSql.Append(" AND 产品种类名称=" & Utility.PFn_ChangeQuotation(ojbM产品种类T.产品种类名称) & vbCrLf)
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

    Public Function LoadByWhere(ByVal ojbM产品种类T As M产品种类T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	产品种类编号" & vbCrLf)
            strSql.Append(" 	,产品种类名称" & vbCrLf)
            strSql.Append(" FROM M产品种类")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (ojbM产品种类T.产品种类编号 <> String.Empty) Then
                strSql.Append(" AND 产品种类编号 =" & Utility.PFn_ChangeQuotation(ojbM产品种类T.产品种类编号) & vbCrLf)
            End If
            If (ojbM产品种类T.产品种类名称 <> String.Empty) Then
                strSql.Append(" AND 产品种类名称 LIKE '%" & Utility.PFn_ChangeQuotation(ojbM产品种类T.产品种类名称, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 产品种类编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


End Class
