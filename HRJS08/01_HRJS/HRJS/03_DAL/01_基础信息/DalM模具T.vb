Imports System.Text

Public Class DalM模具T

#Region "IsExists"

    Public Function IsExists(ByVal str模具编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   M模具管理 " & vbCrLf)
            strSql.Append("WHERE  模具编号 = " & Utility.PFn_ChangeQuotation(str模具编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objM模具T As M模具T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO M模具管理" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.Append(" 	模具编号" & vbCrLf)
            strSql.Append(" 	,模具名称 " & vbCrLf)
            strSql.Append(" 	,模具型号 " & vbCrLf)
            strSql.Append(" 	,维护周期 " & vbCrLf)
            strSql.Append(" 	,上次维护日期" & vbCrLf)
            strSql.Append(" 	,使用状态 " & vbCrLf)
            strSql.Append(" 	,使用者编号 " & vbCrLf)
            'strSql.Append(" 	,使用者姓名 " & vbCrLf)
            'strSql.Append(" 	,使用者部门名称 " & vbCrLf)
            strSql.Append(" 	,生产日期" & vbCrLf)
            strSql.Append(" 	,库存区域" & vbCrLf)
            strSql.Append(" 	,维护负责人编号 " & vbCrLf)
            'strSql.Append(" 	,维护负责人姓名" & vbCrLf)
            'strSql.Append(" 	,维护部门名称" & vbCrLf)
            'strSql.Append(" 	,负责人电话 " & vbCrLf)
            strSql.Append(" 	,维护内容 " & vbCrLf)
            strSql.Append(" 	,模具图片 " & vbCrLf)
            strSql.Append(" 	,登录者" & vbCrLf)
            strSql.Append(" 	,登录日期 " & vbCrLf)
            strSql.Append(" 	,类型 " & vbCrLf)
            strSql.Append(" 	,设计者 " & vbCrLf)
            strSql.Append(" 	,客户编号 " & vbCrLf)
            strSql.Append(" 	,制造日期 " & vbCrLf)
            strSql.Append("  )" & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat("  {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.模具编号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.模具名称))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.模具型号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.维护周期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.上次维护日期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.使用状态))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.使用者编号))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.使用者姓名))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.使用者部门))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.生产日期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.存放区域))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.维护人编号))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.维护人姓名))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.维护人部门))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.负责人电话))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.维护内容))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.模具图片))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.登录者))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.登录日期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.类型))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.设计者))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.客户编号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.制造日期))


            strSql.Append(")" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal objM模具T As M模具T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       M模具管理 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)

            strSQL.AppendFormat(" 		模具名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.模具名称))
            'If Not objM模具T.模具型号 = "" Then
            strSQL.AppendFormat(" 		,模具型号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.模具型号))
            'End If
            'If Not objM模具T.维护周期 = "" Then
            strSQL.AppendFormat(" 		,维护周期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.维护周期))
            'End If
            'If Not objM模具T.上次维护日期 = "" Then
            strSQL.AppendFormat(" 		,上次维护日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.上次维护日期))
            'End If
            'If Not objM模具T.使用状态 = "" Then
            strSQL.AppendFormat(" 		,使用状态 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.使用状态))
            'End If
            strSQL.AppendFormat(" 		,使用者编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.使用者编号))

            'strSQL.AppendFormat(" 		,使用者姓名 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.使用者姓名))

            'strSQL.AppendFormat(" 		,使用者部门名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.使用者部门))

            strSQL.AppendFormat(" 		,生产日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.生产日期))

            'If Not objM模具T.模具产量 = "" Then
            strSQL.AppendFormat(" 		,库存区域 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.存放区域))
            'End If
            'If Not objM模具T.维护厂商 = "" Then
            strSQL.AppendFormat(" 		,维护负责人编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.维护人编号))
            'End If
            'If Not objM模具T.维护负责人 = "" Then
            'strSQL.AppendFormat(" 		,维护负责人姓名 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.维护人姓名))
            'End If
            'strSQL.AppendFormat(" 		,维护部门名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.维护人部门))

            'If Not objM模具T.负责人电话 = "" Then
            ' strSQL.AppendFormat(" 		,负责人电话 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.负责人电话))
            'End If
            strSQL.AppendFormat(" 		,维护内容 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.维护内容))
            strSQL.AppendFormat(" 		,模具图片 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.模具图片))

            strSQL.AppendFormat(" 		,更新者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.更新者))
            strSQL.AppendFormat(" 		,更新日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.更新日期))
            strSQL.AppendFormat(" 		,类型 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.类型))
            strSQL.AppendFormat(" 		,设计者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.设计者))
            strSQL.AppendFormat(" 		,客户编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.客户编号))
            strSQL.AppendFormat(" 		,制造日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.制造日期))

            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    模具编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM模具T.模具编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM模具T As M模具T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM M模具管理" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  模具编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM模具T.模具编号))

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
    Public Function LoadAll(ByVal objM模具T As M模具T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            'strSql.Append("  SELECT 模具编号 , " & vbCrLf)
            'strSql.Append("         模具名称 , " & vbCrLf)
            'strSql.Append("         模具型号 , " & vbCrLf)
            'strSql.Append("         维护周期 , " & vbCrLf)
            'strSql.Append("         上次维护日期 , " & vbCrLf)
            'strSql.Append("         使用状态 , " & vbCrLf)
            'strSql.Append("         使用者编号 , " & vbCrLf)
            'strSql.Append("         使用者姓名 , " & vbCrLf)
            'strSql.Append("         使用者部门名称 , " & vbCrLf)
            'strSql.Append("         生产日期 , " & vbCrLf)
            'strSql.Append("         存放区域 , " & vbCrLf)
            'strSql.Append("         维护负责人编号 , " & vbCrLf)
            'strSql.Append("         维护负责人姓名 , " & vbCrLf)
            'strSql.Append("         维护部门名称 , " & vbCrLf)
            'strSql.Append("         M模具管理.负责人电话 , " & vbCrLf)
            'strSql.Append("         维护内容 , " & vbCrLf)
            'strSql.Append("         模具图片 , " & vbCrLf)
            'strSql.Append("         类型 , " & vbCrLf)
            'strSql.Append("         设计者 , " & vbCrLf)
            'strSql.Append("         M人员管理.人员名 设计者名称 , " & vbCrLf)
            'strSql.Append("         制造日期 , " & vbCrLf)
            'strSql.Append("         M客户管理.客户编号 , " & vbCrLf)
            'strSql.Append("         M客户管理.客户名称 " & vbCrLf)
            'strSql.Append("  FROM   M模具管理 " & vbCrLf)
            'strSql.Append("         INNER JOIN dbo.M人员管理 ON 人员编号 = 设计者 " & vbCrLf)
            'strSql.Append("         INNER JOIN dbo.M客户管理 ON M客户管理.客户编号 = M模具管理.客户编号 " & vbCrLf)
            strSql.Append("  SELECT  distinct  模具编号 , " & vbCrLf)
            strSql.Append("            类型 , " & vbCrLf)
            strSql.Append("            模具名称 , " & vbCrLf)
            strSql.Append("            模具型号 , " & vbCrLf)
            strSql.Append("            VM使用状态.名称 AS 使用状态 , " & vbCrLf)
            strSql.Append("            维护周期 , " & vbCrLf)
            strSql.Append("            设计者 , " & vbCrLf)
            strSql.Append("            c.人员名 设计者名称 , " & vbCrLf)
            strSql.Append("            制造日期 , " & vbCrLf)
            strSql.Append("            上次维护日期 , " & vbCrLf)
            strSql.Append("            使用状态 , " & vbCrLf)
            strSql.Append("            使用者编号 , " & vbCrLf)
            strSql.Append("            D.人员名 使用者姓名 , " & vbCrLf)
            strSql.Append("            A.客户编号 , " & vbCrLf)
            strSql.Append("            B.客户名称 , " & vbCrLf)
            strSql.Append("            D.部门 使用者部门名称 , " & vbCrLf)
            strSql.Append("            生产日期 , " & vbCrLf)
            strSql.Append("            库存区域 , " & vbCrLf)
            strSql.Append("            维护负责人编号 , " & vbCrLf)
            strSql.Append("            F.部门名称 维护部门名称 , " & vbCrLf)
            strSql.Append("            E.人员名 维护负责人姓名 , " & vbCrLf)
            strSql.Append("            维护内容 , " & vbCrLf)
            strSql.Append("            模具图片 , " & vbCrLf)
            strSql.Append("            E.电话号码 负责人电话 " & vbCrLf)
            strSql.Append("  FROM      M模具管理 A " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M客户管理 B ON B.客户编号 = A.客户编号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M人员管理 c ON A.设计者 = c.人员编号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M人员管理 D ON A.使用者编号 = D.人员编号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M人员管理 E ON A.维护负责人编号 = E.人员编号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M部门管理 F ON F.部门编号 = E.部门  " & vbCrLf)
            strSql.Append("            LEFT JOIN VM使用状态 ON A.使用状态 = VM使用状态.区分 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" and 模具编号=" & Utility.PFn_ChangeQuotation(objM模具T.模具编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal objM模具T As M模具T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	模具编号" & vbCrLf)
            strSql.Append(" 	,模具名称 " & vbCrLf)

            strSql.Append(" FROM M模具管理")
            '检索条件 设定
            strSql.Append(" WHERE 模具编号=" & Utility.PFn_ChangeQuotation(objM模具T.模具编号) & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据
    Public Function LoadByWhere(ByVal objM模具T As M模具T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("  SELECT  distinct  模具编号 , " & vbCrLf)
            strSql.Append("            VM模具类型.名称 AS 类型 , " & vbCrLf)
            strSql.Append("            模具名称 , " & vbCrLf)
            strSql.Append("            模具型号 , " & vbCrLf)
            strSql.Append("            生产日期 , " & vbCrLf)
            strSql.Append("            VM使用状态.名称 AS 使用状态 , " & vbCrLf)
            strSql.Append("            维护周期 , " & vbCrLf)
            strSql.Append("            设计者 , " & vbCrLf)
            strSql.Append("            c.人员名 设计者名称 , " & vbCrLf)

            strSql.Append("            上次维护日期 , " & vbCrLf)
            strSql.Append("            制造日期 , " & vbCrLf)
            strSql.Append("            库存区域 , " & vbCrLf)
            strSql.Append("            使用者编号 , " & vbCrLf)
            strSql.Append("            D.人员名 使用者姓名 , " & vbCrLf)
            strSql.Append("            维护负责人编号 , " & vbCrLf)
            strSql.Append("            E.部门 维护部门名称 , " & vbCrLf)
            strSql.Append("            E.人员名 维护负责人姓名 , " & vbCrLf)
            strSql.Append("            维护内容 , " & vbCrLf)
            strSql.Append("            模具图片 , " & vbCrLf)
            strSql.Append("            E.电话号码 负责人电话 " & vbCrLf)

            'strSql.Append("            使用状态 , " & vbCrLf)          
            'strSql.Append("            A.客户编号 , " & vbCrLf)
            'strSql.Append("            B.客户名称 , " & vbCrLf)
            'strSql.Append("            D.部门 使用者部门名称 , " & vbCrLf)




           
            strSql.Append("  FROM      M模具管理 A " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M客户管理 B ON B.客户编号 = A.客户编号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M人员管理 c ON A.设计者 = c.人员编号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M人员管理 D ON A.使用者编号 = D.人员编号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M人员管理 E ON A.维护负责人编号 = E.人员编号 " & vbCrLf)
            strSql.Append("            left join VM模具类型 on A.类型 = VM模具类型.区分 " & vbCrLf)
            strSql.Append("            LEFT JOIN VM使用状态 ON A.使用状态 = VM使用状态.区分 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM模具T.模具编号 <> String.Empty) Then
                strSql.Append(" AND 模具编号 LIKE '%" & Utility.PFn_ChangeQuotation(objM模具T.模具编号, True) & "%'" & vbCrLf)
            End If
            If (objM模具T.模具名称 <> String.Empty) Then
                strSql.Append(" AND 模具名称 LIKE '%" & Utility.PFn_ChangeQuotation(objM模具T.模具名称, True) & "%'" & vbCrLf)
            End If
            If (objM模具T.设计者 <> String.Empty) Then
                strSql.Append(" AND 设计者 LIKE '%" & Utility.PFn_ChangeQuotation(objM模具T.设计者, True) & "%'" & vbCrLf)
            End If

            If (objM模具T.客户编号 <> String.Empty) Then
                strSql.Append(" AND A.客户编号 LIKE '%" & Utility.PFn_ChangeQuotation(objM模具T.客户编号, True) & "%'" & vbCrLf)
            End If

            If (objM模具T.类型 <> String.Empty) Then
                strSql.Append(" AND a.类型 LIKE '%" & Utility.PFn_ChangeQuotation(objM模具T.类型, True) & "%'" & vbCrLf)
            End If

            If (objM模具T.模具型号 <> String.Empty) Then
                strSql.Append(" AND 模具型号 LIKE '%" & Utility.PFn_ChangeQuotation(objM模具T.模具型号, True) & "%'" & vbCrLf)
            End If

            strSql.Append(" ORDER BY 模具编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
