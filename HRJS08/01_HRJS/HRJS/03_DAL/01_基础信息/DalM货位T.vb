Imports System.Text

Public Class DalM货位T

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
    Public Function Insert(ByVal ojbM货位管理T As M货位T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO M货位管理") 'M货位

            strSql.Append(" ( 货位编号")            '货位编号
            strSql.Append(" ,货位名称")             '货位名称
            strSql.Append(")")

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM货位管理T.货位编号))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM货位管理T.货位名称))
  

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
    Public Function Update(ByVal ojbM货位管理T As M货位T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       M货位管理 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)

            strSQL.AppendFormat(" 		货位名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM货位管理T.货位名称))

            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    货位编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM货位管理T.货位编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM货位管理T As M货位T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM M货位管理" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  货位编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM货位管理T.货位编号))

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
    Public Function LoadAll(ByVal objM货位T As M货位T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	货位编号" & vbCrLf)
            strSql.Append(" 	,货位名称" & vbCrLf)
            'strSql.Append(" 	,登录者" & vbCrLf)
            'strSql.Append(" 	,登录日期" & vbCrLf)
            'strSql.Append(" 	,更新者" & vbCrLf)
            'strSql.Append(" 	,更新日期" & vbCrLf)
            strSql.Append(" FROM M货位管理")
            '检索条件 设定
            strSql.Append(" WHERE 货位编号=" & Utility.PFn_ChangeQuotation(objM货位T.货位编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal objM货位T As M货位T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	货位编号," & vbCrLf)
            strSql.Append(" 	货位名称" & vbCrLf)
            'strSql.Append(" 	登录者," & vbCrLf)
            'strSql.Append(" 	登录日期," & vbCrLf)
            'strSql.Append(" 	更新者," & vbCrLf)
            'strSql.Append(" 	更新日期" & vbCrLf)
            strSql.Append(" FROM M货位管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM货位T.货位编号 <> String.Empty) Then
                strSql.Append(" AND 货位编号=" & Utility.PFn_ChangeQuotation(objM货位T.货位编号) & vbCrLf)
            End If
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Load库存"

    '检索全部数据
    Public Function Load库存(ByVal objM货位T As M货位T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try


            strSql.Append(" 	SELECT 库存区域 FROM dbo.B原材料库存表 WHERE 库存区域=" & Utility.PFn_ChangeQuotation(objM货位T.货位编号) & vbCrLf)
            strSql.Append(" 	UNION all SELECT 库存区域 FROM dbo.Z半成品库存 WHERE 库存区域=" & Utility.PFn_ChangeQuotation(objM货位T.货位编号) & vbCrLf)
            strSql.Append(" 	UNION all SELECT 库存区域 FROM dbo.B成品库存表 WHERE 库存区域=" & Utility.PFn_ChangeQuotation(objM货位T.货位编号) & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据
    Public Function LoadByWhere(ByVal objM货位T As M货位T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	货位编号" & vbCrLf)
            strSql.Append(" 	,货位名称" & vbCrLf)
            'strSql.Append(" 	,登录者" & vbCrLf)
            'strSql.Append(" 	,登录日期" & vbCrLf)
            'strSql.Append(" 	,更新者" & vbCrLf)
            'strSql.Append(" 	,更新日期" & vbCrLf)
            strSql.Append(" FROM M货位管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM货位T.货位编号 <> String.Empty) Then
                strSql.Append(" AND 货位编号 LIKE '" & Utility.PFn_ChangeQuotation(objM货位T.货位编号, True) & "%'" & vbCrLf)
            End If
            If (objM货位T.货位名称 <> String.Empty) Then
                strSql.Append(" AND 货位名称 LIKE '%" & Utility.PFn_ChangeQuotation(objM货位T.货位名称, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 货位编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


End Class
