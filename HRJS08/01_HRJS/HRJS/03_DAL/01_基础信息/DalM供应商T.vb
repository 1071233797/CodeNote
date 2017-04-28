Imports System.Text

Public Class DalM供应商T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls供应商T As M供应商T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO M供应商管理") 'M供应商

            strSql.Append(" ( 供应商编号")            '
            strSql.Append(" ,供应商名称")             '
            strSql.Append(" ,公司地址")               '地址 
            strSql.Append(" ,电话号码")             '电话号码
            strSql.Append(" ,邮政编码")             '电话号码
            strSql.Append(" ,传真号码")             '电话号码
            strSql.Append(" ,负责人姓名")             '电话号码
            strSql.Append(" ,负责人电话")             '电话号码
            strSql.Append(" ,负责人职务")             '电话号码
            strSql.Append(" ,负责人邮箱")             '电话号码
            strSql.Append(" ,负责人部门")             '电话号码
            strSql.Append(" ,供货方式" & vbCrLf)
            strSql.Append(" ,税率" & vbCrLf)

            strSql.Append(" ,供应商编号CD")             '

            'strSql.Append(" ,登录者" & vbCrLf)
            'strSql.Append(" ,登录日期" & vbCrLf)

            strSql.Append(")")

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.供应商编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.供应商名称))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.公司地址))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.电话号码))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.邮政编码))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.传真号码))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.负责人姓名))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.负责人电话))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.负责人职务))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.负责人邮箱))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.负责人部门))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.供货方式))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.税率))

            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.供应商编号CD))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.登录者))
            'strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.登录日期))

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
    Public Function Update(ByVal cls供应商T As M供应商T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       M供应商管理 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)
            strSQL.AppendFormat(" 		公司地址 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.公司地址))
            strSQL.AppendFormat(" 		,电话号码 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.电话号码))
            strSQL.AppendFormat(" 		,邮政编码 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.邮政编码))
            strSQL.AppendFormat(" 		,传真号码 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.传真号码))
            strSQL.AppendFormat(" 		,供货方式 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.供货方式))
            strSQL.AppendFormat(" 		,税率 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.税率))

            strSQL.AppendFormat(" 		,负责人姓名 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.负责人姓名))
            strSQL.AppendFormat(" 		,负责人部门 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.负责人部门))
            strSQL.AppendFormat(" 		,负责人电话 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.负责人电话))
            strSQL.AppendFormat(" 		,负责人邮箱 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.负责人邮箱))
            strSQL.AppendFormat(" 		,负责人职务 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.负责人职务))

            'strSQL.AppendFormat(" 		,更新者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.更新者))
            'strSQL.AppendFormat(" 		,更新日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.更新日期))


            strSQL.Append("  WHERE  1=1" & vbCrLf)
            strSQL.AppendFormat(" AND   供应商编号CD = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls供应商T.供应商编号CD))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadCD "

    '检索全部数据    Public Function LoadCD(ByVal objM供应商T As M供应商T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	供应商编号" & vbCrLf)
            strSql.Append(" FROM M供应商管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            strSql.Append(" AND 供应商编号CD = '" & Utility.PFn_ChangeQuotation(objM供应商T.供应商编号CD, True) & "'" & vbCrLf)
           
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

        '数据删除操作
    Public Function Delete(ByVal objM供应商T As M供应商T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM M供应商管理" & vbCrLf)
            strSql.Append(" WHERE  1=1" & vbCrLf)
            strSql.Append(" AND 供应商编号 =  '" & Utility.PFn_ChangeQuotation(objM供应商T.供应商编号, True) & "'" & vbCrLf)
            'SQLに戻る
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据    Public Function LoadInfoAll(ByVal objM供应商T As M供应商T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	供应商编号" & vbCrLf)
            strSql.Append(" 	,供应商名称" & vbCrLf)
            strSql.Append(" 	,公司地址" & vbCrLf)
            strSql.Append(" 	,电话号码" & vbCrLf)
            strSql.Append(" 	,邮政编码" & vbCrLf)
            strSql.Append(" 	,传真号码" & vbCrLf)
            strSql.Append(" 	,供货方式" & vbCrLf)
            strSql.Append(" 	,税率" & vbCrLf)
            strSql.Append(" FROM M供应商管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            strSql.Append(" AND 供应商编号 = '" & Utility.PFn_ChangeQuotation(objM供应商T.供应商编号, True) & "'" & vbCrLf)
            'strSql.Append(" WHERE LEFT(供应商编号,7) = '" & Utility.PFn_ChangeQuotation(objM供应商T.供应商编号) & "'" & vbCrLf)
            strSql.Append(" ORDER BY 供应商编号")
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function LoadGridAll(ByVal objM供应商T As M供应商T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	负责人姓名" & vbCrLf)
            strSql.Append(" 	,负责人职务" & vbCrLf)
            strSql.Append(" 	,负责人部门" & vbCrLf)
            strSql.Append(" 	,负责人电话" & vbCrLf)
            strSql.Append(" 	,负责人邮箱" & vbCrLf)
            strSql.Append(" 	,供应商编号CD" & vbCrLf)
            strSql.Append(" FROM M供应商管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            strSql.Append(" AND 供应商编号= '" & Utility.PFn_ChangeQuotation(objM供应商T.供应商编号, True) & "'" & vbCrLf)
            'strSql.Append(" AND 供应商名称= '" & Utility.PFn_ChangeQuotation(objM供应商T.供应商名称, True) & "'" & vbCrLf)

            'strSql.Append(" WHERE LEFT(供应商编号,7) = '" & Utility.PFn_ChangeQuotation(objM供应商T.供应商编号) & "'" & vbCrLf)
            strSql.Append(" ORDER BY 供应商编号CD")
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    Public Function LoadByPK(ByVal objM供应商T As M供应商T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try
            strSql.Append(" SELECT   " & vbCrLf)

            strSql.Append("     供应商编号" & vbCrLf)
            strSql.Append(" 	,供应商名称" & vbCrLf)
            strSql.Append(" 	,税率" & vbCrLf)
            strSql.Append(" FROM M供应商管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM供应商T.供应商编号 <> String.Empty) Then
                strSql.Append(" AND 供应商编号=" & Utility.PFn_ChangeQuotation(objM供应商T.供应商编号) & vbCrLf)
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
    Public Function LoadByWhere(ByVal objM供应商T As M供应商T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT distinct  " & vbCrLf)
            strSql.Append(" 	供应商编号" & vbCrLf)
            strSql.Append(" 	,供应商名称" & vbCrLf)
            strSql.Append(" 	,公司地址" & vbCrLf)
            strSql.Append(" 	,电话号码" & vbCrLf)
            strSql.Append(" 	,邮政编码" & vbCrLf)
            strSql.Append(" 	,传真号码" & vbCrLf)
            strSql.Append("     ,vm供货方式.名称 AS 供货方式" & vbCrLf)
            strSql.Append(" 	,税率" & vbCrLf)


            strSql.Append(" FROM M供应商管理")
            strSql.Append("       LEFT JOIN vm供货方式 " & vbCrLf)
            strSql.Append("       ON M供应商管理.供货方式 = vm供货方式.区分 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM供应商T.供应商编号 <> String.Empty) Then
                strSql.Append(" AND 供应商编号 LIKE '" & Utility.PFn_ChangeQuotation(objM供应商T.供应商编号, True) & "%'" & vbCrLf)
            End If
            If (objM供应商T.供应商名称 <> String.Empty) Then
                strSql.Append(" AND 供应商名称 LIKE '%" & Utility.PFn_ChangeQuotation(objM供应商T.供应商名称, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 供应商编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "Get供应商编号CD"

    Public Function Get供应商编号CD(ByVal model As M供应商T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("         + 1 AS 顺序号 " & vbCrLf)
            strSql.Append("FROM   M供应商管理 " & vbCrLf)
            strSql.Append(" WHERE    1 = 1 " & vbCrLf)

            If model.供应商编号 <> String.Empty Then
                strSql.Append(" AND 供应商编号 =" & Utility.PFn_ChangeQuotation(model.供应商编号) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try
    End Function
#End Region


End Class
