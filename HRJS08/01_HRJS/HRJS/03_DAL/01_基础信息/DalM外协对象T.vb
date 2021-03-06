﻿Imports System.Text

Public Class DalM外协对象T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls外协对象T As M外协对象T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO M外协对象管理") 'M外协对象


            strSql.Append(" ( 外协对象编号")            '
            strSql.Append(" ,外协对象名称")             '
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
            strSql.Append(" ,交货方式" & vbCrLf)
            strSql.Append(" ,税率" & vbCrLf)

            strSql.Append(" ,外协对象编号CD")             '

            ' strSql.Append(" ,登录者" & vbCrLf)
            ' strSql.Append(" ,登录日期" & vbCrLf)

            strSql.Append(")")

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.外协对象编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.外协对象名称))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.公司地址))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.电话号码))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.邮政编码))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.传真号码))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.负责人姓名))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.负责人电话))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.负责人职务))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.负责人邮箱))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.负责人部门))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.供货方式))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.交货方式))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.税率))

            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.外协对象编号CD))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.登录者))
            ' strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.登录日期))

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
    Public Function Update(ByVal cls外协对象T As M外协对象T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       M外协对象管理 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)
            strSQL.AppendFormat(" 		公司地址 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.公司地址))
            strSQL.AppendFormat(" 		,电话号码 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.电话号码))
            strSQL.AppendFormat(" 		,邮政编码 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.邮政编码))
            strSQL.AppendFormat(" 		,传真号码 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.传真号码))
            strSQL.AppendFormat(" 		,供货方式 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.供货方式))
            strSQL.AppendFormat(" 		,交货方式 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.交货方式))
            strSQL.AppendFormat(" 		,税率 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.税率))

            strSQL.AppendFormat(" 		,负责人姓名 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.负责人姓名))
            strSQL.AppendFormat(" 		,负责人部门 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.负责人部门))
            strSQL.AppendFormat(" 		,负责人电话 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.负责人电话))
            strSQL.AppendFormat(" 		,负责人邮箱 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.负责人邮箱))
            strSQL.AppendFormat(" 		,负责人职务 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.负责人职务))

            'strSQL.AppendFormat(" 		,更新者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.更新者))
            ' strSQL.AppendFormat(" 		,更新日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.更新日期))


            strSQL.Append("  WHERE  1=1" & vbCrLf)
            strSQL.AppendFormat(" AND   外协对象编号CD = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协对象T.外协对象编号CD))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadCD "

    '检索全部数据    Public Function LoadCD(ByVal objM外协对象T As M外协对象T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	外协对象编号" & vbCrLf)
            strSql.Append(" FROM M外协对象管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            strSql.Append(" AND 外协对象编号CD = '" & Utility.PFn_ChangeQuotation(objM外协对象T.外协对象编号CD, True) & "'" & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal objM外协对象T As M外协对象T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM M外协对象管理" & vbCrLf)
            strSql.Append(" WHERE  1=1" & vbCrLf)
            strSql.Append(" AND 外协对象编号 =  '" & Utility.PFn_ChangeQuotation(objM外协对象T.外协对象编号, True) & "'" & vbCrLf)
            'SQLに戻る
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据    Public Function LoadInfoAll(ByVal objM外协对象T As M外协对象T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	外协对象编号" & vbCrLf)
            strSql.Append(" 	,外协对象名称" & vbCrLf)
            strSql.Append(" 	,公司地址" & vbCrLf)
            strSql.Append(" 	,电话号码" & vbCrLf)
            strSql.Append(" 	,邮政编码" & vbCrLf)
            strSql.Append(" 	,传真号码" & vbCrLf)
            strSql.Append(" 	,供货方式" & vbCrLf)
            strSql.Append(" 	,交货方式" & vbCrLf)
            strSql.Append(" 	,税率" & vbCrLf)
            strSql.Append(" FROM M外协对象管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            strSql.Append(" AND 外协对象编号 = '" & Utility.PFn_ChangeQuotation(objM外协对象T.外协对象编号, True) & "'" & vbCrLf)
            'strSql.Append(" WHERE LEFT(外协对象编号,7) = '" & Utility.PFn_ChangeQuotation(objM外协对象T.外协对象编号) & "'" & vbCrLf)
            strSql.Append(" ORDER BY 外协对象编号")
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function LoadGridAll(ByVal objM外协对象T As M外协对象T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	负责人姓名" & vbCrLf)
            strSql.Append(" 	,负责人职务" & vbCrLf)
            strSql.Append(" 	,负责人部门" & vbCrLf)
            strSql.Append(" 	,负责人电话" & vbCrLf)
            strSql.Append(" 	,负责人邮箱" & vbCrLf)
            strSql.Append(" 	,外协对象编号CD" & vbCrLf)
            strSql.Append(" FROM M外协对象管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            strSql.Append(" AND 外协对象编号= '" & Utility.PFn_ChangeQuotation(objM外协对象T.外协对象编号, True) & "'" & vbCrLf)
            'strSql.Append(" AND 外协对象名称= '" & Utility.PFn_ChangeQuotation(objM外协对象T.外协对象名称, True) & "'" & vbCrLf)

            'strSql.Append(" WHERE LEFT(外协对象编号,7) = '" & Utility.PFn_ChangeQuotation(objM外协对象T.外协对象编号) & "'" & vbCrLf)
            strSql.Append(" ORDER BY 外协对象编号CD")
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    Public Function LoadByPK(ByVal objM外协对象T As M外协对象T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try
            strSql.Append(" SELECT   " & vbCrLf)

            strSql.Append("     外协对象编号" & vbCrLf)
            strSql.Append(" 	,外协对象名称" & vbCrLf)
            strSql.Append(" 	,税率" & vbCrLf)
            strSql.Append(" FROM M外协对象管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM外协对象T.外协对象编号 <> String.Empty) Then
                strSql.Append(" AND 外协对象编号=" & Utility.PFn_ChangeQuotation(objM外协对象T.外协对象编号) & vbCrLf)
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
    Public Function LoadByWhere(ByVal objM外协对象T As M外协对象T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT distinct  " & vbCrLf)
            strSql.Append(" 	外协对象编号" & vbCrLf)
            strSql.Append(" 	,外协对象名称" & vbCrLf)
            strSql.Append(" 	,公司地址" & vbCrLf)
            strSql.Append(" 	,电话号码" & vbCrLf)
            strSql.Append(" 	,邮政编码" & vbCrLf)
            strSql.Append(" 	,传真号码" & vbCrLf)
            strSql.Append("     ,vm供货方式.名称 AS 供货方式" & vbCrLf)
            strSql.Append("     ,vm交货方式.名称 AS 交货方式" & vbCrLf)
            strSql.Append(" 	,税率" & vbCrLf)


            strSql.Append(" FROM M外协对象管理")
            strSql.Append("       LEFT JOIN vm供货方式 " & vbCrLf)
            strSql.Append("       ON M外协对象管理.供货方式 = vm供货方式.区分 " & vbCrLf)
            strSql.Append("       LEFT JOIN vm交货方式 " & vbCrLf)
            strSql.Append("       ON M外协对象管理.交货方式 = vm交货方式.区分 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM外协对象T.外协对象编号 <> String.Empty) Then
                strSql.Append(" AND 外协对象编号 LIKE '" & Utility.PFn_ChangeQuotation(objM外协对象T.外协对象编号, True) & "%'" & vbCrLf)
            End If
            If (objM外协对象T.外协对象名称 <> String.Empty) Then
                strSql.Append(" AND 外协对象名称 LIKE '%" & Utility.PFn_ChangeQuotation(objM外协对象T.外协对象名称, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 外协对象编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "Get外协对象编号CD"

    Public Function Get外协对象编号CD(ByVal model As M外协对象T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("         + 1 AS 顺序号 " & vbCrLf)
            strSql.Append("FROM   M外协对象管理 " & vbCrLf)
            strSql.Append(" WHERE    1 = 1 " & vbCrLf)

            If model.外协对象编号 <> String.Empty Then
                strSql.Append(" AND 外协对象编号 =" & Utility.PFn_ChangeQuotation(model.外协对象编号) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try
    End Function
#End Region


End Class
