Imports System.Text

Public Class DalM设备T

#Region "IsExists"

    Public Function IsExists(ByVal str设备编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   M设备管理 " & vbCrLf)
            strSql.Append("WHERE  设备编号 = " & Utility.PFn_ChangeQuotation(str设备编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objM设备T As M设备T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO M设备管理" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.Append(" 	设备编号" & vbCrLf)
            strSql.Append(" 	,设备名称 " & vbCrLf)
            strSql.Append(" 	,设备型号 " & vbCrLf)
            strSql.Append(" 	,维护周期 " & vbCrLf)
            strSql.Append(" 	,上次维护日期" & vbCrLf)
            strSql.Append(" 	,使用状态 " & vbCrLf)
            strSql.Append(" 	,使用者编号 " & vbCrLf)
            'strSql.Append(" 	,使用者姓名 " & vbCrLf)
            'strSql.Append(" 	,使用者部门名称 " & vbCrLf)
            strSql.Append(" 	,购买日期" & vbCrLf)
            strSql.Append(" 	,设备产量" & vbCrLf)
            strSql.Append(" 	,维护厂商 " & vbCrLf)
            strSql.Append(" 	,维护负责人" & vbCrLf)
            strSql.Append(" 	,负责人电话 " & vbCrLf)
            strSql.Append(" 	,维护内容 " & vbCrLf)
            strSql.Append(" 	,登录者" & vbCrLf)
            strSql.Append(" 	,登录日期 " & vbCrLf)
            strSql.Append("  )" & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat("  {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.设备编号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.设备名称))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.设备型号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.维护周期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.上次维护日期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.使用状态))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.使用者编号))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.使用者姓名))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.使用者部门))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.购买日期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.设备产量))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.维护厂商))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.维护负责人))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.负责人电话))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.维护内容))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.登录者))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.登录日期))

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
    Public Function Update(ByVal objM设备T As M设备T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       M设备管理 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)

            strSQL.AppendFormat(" 		设备名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.设备名称))
            'If Not objM设备T.设备型号 = "" Then
            strSQL.AppendFormat(" 		,设备型号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.设备型号))
            'End If
            'If Not objM设备T.维护周期 = "" Then
            strSQL.AppendFormat(" 		,维护周期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.维护周期))
            'End If
            'If Not objM设备T.上次维护日期 = "" Then
            strSQL.AppendFormat(" 		,上次维护日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.上次维护日期))
            'End If
            'If Not objM设备T.使用状态 = "" Then
            strSQL.AppendFormat(" 		,使用状态 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.使用状态))
            'End If
            strSQL.AppendFormat(" 		,使用者编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.使用者编号))
           
            'strSQL.AppendFormat(" 		,使用者姓名 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.使用者姓名))

            'strSQL.AppendFormat(" 		,使用者部门名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.使用者部门))
      
            strSQL.AppendFormat(" 		,购买日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.购买日期))

            'If Not objM设备T.设备产量 = "" Then
            strSQL.AppendFormat(" 		,设备产量 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.设备产量))
            'End If
            'If Not objM设备T.维护厂商 = "" Then
            strSQL.AppendFormat(" 		,维护厂商 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.维护厂商))
            'End If
            'If Not objM设备T.维护负责人 = "" Then
            strSQL.AppendFormat(" 		,维护负责人 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.维护负责人))
            'End If
            'If Not objM设备T.负责人电话 = "" Then
            strSQL.AppendFormat(" 		,负责人电话 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.负责人电话))
            'End If
            strSQL.AppendFormat(" 		,维护内容 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.维护内容))

            strSQL.AppendFormat(" 		,更新者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.更新者))
            strSQL.AppendFormat(" 		,更新日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.更新日期))
            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    设备编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM设备T.设备编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM设备T As M设备T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM M设备管理" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  设备编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM设备T.设备编号))

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
    Public Function LoadAll(ByVal objM设备T As M设备T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	设备编号" & vbCrLf)
            strSql.Append(" 	,设备名称 " & vbCrLf)
            strSql.Append(" 	,设备型号" & vbCrLf)
            strSql.Append(" 	,维护周期" & vbCrLf)
            strSql.Append(" 	,上次维护日期" & vbCrLf)
            strSql.Append(" 	,使用状态" & vbCrLf)
            strSql.Append(" 	,使用者编号" & vbCrLf)

            strSql.Append("     ,M人员管理.人员名 使用者姓名 ")
            ' strSql.Append(" 	,使用者部门名称" & vbCrLf)
            strSql.Append(" 	,购买日期" & vbCrLf)
            strSql.Append(" 	,设备产量 " & vbCrLf)
            strSql.Append(" 	,维护厂商 " & vbCrLf)
            strSql.Append(" 	,维护负责人" & vbCrLf)
            strSql.Append(" 	,负责人电话 " & vbCrLf)
            strSql.Append(" 	,维护内容 " & vbCrLf)
            'strSql.Append(" 	,登录者" & vbCrLf)
            'strSql.Append(" 	,登录日期 " & vbCrLf)
            'strSql.Append(" 	,更新者  " & vbCrLf)
            'strSql.Append(" 	,更新日期  " & vbCrLf)
            strSql.Append(" FROM M设备管理")
            strSql.Append("         LEFT JOIN M人员管理 ON M人员管理.人员编号 = M设备管理.使用者编号 ")

            '检索条件 设定
            strSql.Append(" WHERE 设备编号=" & Utility.PFn_ChangeQuotation(objM设备T.设备编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal objM设备T As M设备T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	设备编号" & vbCrLf)
            strSql.Append(" 	,设备名称 " & vbCrLf)
            strSql.Append(" 	,设备型号" & vbCrLf)
            strSql.Append(" 	,维护周期" & vbCrLf)
            strSql.Append(" 	,上次维护日期" & vbCrLf)
            strSql.Append(" 	,使用状态" & vbCrLf)
            strSql.Append(" 	,使用者编号" & vbCrLf)
            strSql.Append(" 	,使用者姓名 " & vbCrLf)
            strSql.Append(" 	,使用者部门名称" & vbCrLf)
            strSql.Append(" 	,购买日期" & vbCrLf)
            strSql.Append(" 	,设备产量 " & vbCrLf)
            strSql.Append(" 	,维护厂商 " & vbCrLf)
            strSql.Append(" 	,维护负责人" & vbCrLf)
            strSql.Append(" 	,负责人电话 " & vbCrLf)
            strSql.Append(" 	,维护内容 " & vbCrLf)
            'strSql.Append(" 	,登录者" & vbCrLf)
            'strSql.Append(" 	,登录日期 " & vbCrLf)
            'strSql.Append(" 	,更新者  " & vbCrLf)
            'strSql.Append(" 	,更新日期  " & vbCrLf)
            strSql.Append(" FROM M设备管理")
            '检索条件 设定
            strSql.Append(" WHERE 设备编号=" & Utility.PFn_ChangeQuotation(objM设备T.设备编号) & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据
    Public Function LoadByWhere(ByVal objM设备T As M设备T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  [设备编号] , ")
            strSql.Append("         [设备名称] , ")
            strSql.Append("         [设备型号] , ")
            strSql.Append("         [维护周期] , ")
            strSql.Append("         [上次维护日期] , ")
            strSql.Append("         VM使用状态.名称 AS 使用状态 , ")
            strSql.Append("         [设备产量] , ")
            strSql.Append("         [维护厂商] , ")
            strSql.Append("         [维护负责人] , ")
            strSql.Append("         [负责人电话] , ")
            ' strSql.Append("         [使用者编号] , ")
            strSql.Append("         M人员管理.人员名 使用者姓名 , ")
            strSql.Append("         M人员管理.部门 使用者部门名称 , ")

            strSql.Append("         [维护内容] , ")
            strSql.Append("         [购买日期] ")
            strSql.Append(" FROM    [HRJS].[dbo].[M设备管理] ")
            strSql.Append("         LEFT JOIN VM使用状态 ON M设备管理.使用状态 = VM使用状态.区分 ")
            strSql.Append("         LEFT JOIN M人员管理 ON M人员管理.人员编号 = M设备管理.使用者编号 ")

            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM设备T.设备编号 <> String.Empty) Then
                strSql.Append(" AND 设备编号 LIKE '%" & Utility.PFn_ChangeQuotation(objM设备T.设备编号, True) & "%'" & vbCrLf)
            End If
            If (objM设备T.设备名称 <> String.Empty) Then
                strSql.Append(" AND 设备名称 LIKE '%" & Utility.PFn_ChangeQuotation(objM设备T.设备名称, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 设备编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
