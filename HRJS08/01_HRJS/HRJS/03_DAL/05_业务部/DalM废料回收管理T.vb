Imports System.Text

Public Class DalM废料回收管理T

#Region "IsExists"

    Public Function IsExists(ByVal str原材料编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   B废料回收管理 " & vbCrLf)
            strSql.Append("WHERE  原材料编号 = " & Utility.PFn_ChangeQuotation(str原材料编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal ojbM废料回收管理T As B废料回收管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B废料回收管理") 'B废料回收管理

            strSql.Append(" ( 原材料编号")            '原材料编号
            strSql.Append(" ,原材料批号")             '原材料批号
            strSql.Append(" ,原材料名称")             '原材料名称
            strSql.Append(" ,废料产生工序")             '废料产生工序
            strSql.Append(" ,废料数量")             '废料数量
            strSql.Append(" ,材质")             '材质
            strSql.Append(" ,原材料规格")             '原材料规格
            strSql.Append(" ,回收日期")             '回收日期
            strSql.Append(" ,备注")             '备注

            strSql.Append(" ,登录者")               '登录者 
            strSql.Append(" ,登录日期")             '登录日期 
            strSql.Append(")")

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料批号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料名称))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.废料产生工序))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.废料数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.材质))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料规格))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.回收日期))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.备注))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.登录者))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.登录日期))

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
    Public Function Update(ByVal ojbM废料回收管理T As B废料回收管理T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("      B废料回收管理 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)

            strSQL.AppendFormat(" 		原材料批号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料批号))
            strSQL.AppendFormat(" 		,废料产生工序 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.废料产生工序))
            strSQL.AppendFormat(" 		,废料数量 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.废料数量))
            strSQL.AppendFormat(" 		,原材料规格 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料规格))
            strSQL.AppendFormat(" 		,回收日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.回收日期))
            strSQL.AppendFormat(" 		,备注 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.备注))
            strSQL.AppendFormat(" 		,更新者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.更新者))
            strSQL.AppendFormat(" 		,更新日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.更新日期))
            
            'If ojbM废料回收管理T.原材料批号 = "" Then
            '    strSQL.Append(" ,原材料批号 = NULL ")
            'Else
            '    strSQL.Append(" ,原材料批号 = " & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料批号) & vbCrLf)
            'End If
            'If ojbM废料回收管理T.废料产生工序 = "" Then
            '    strSQL.Append(" ,废料产生工序 = NULL ")
            'Else
            '    strSQL.Append(" ,废料产生工序 = " & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.废料产生工序) & vbCrLf)
            'End If
            'If ojbM废料回收管理T.废料数量 = "" Then
            '    strSQL.Append(" ,废料数量 = NULL ")
            'Else
            '    strSQL.Append(" ,废料数量 = " & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.废料数量) & vbCrLf)
            'End If
            'If ojbM废料回收管理T.原材料规格 = "" Then
            '    strSQL.Append(" ,原材料规格 = NULL ")
            'Else
            '    strSQL.Append(" ,原材料规格 = " & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料规格) & vbCrLf)
            'End If
            'If ojbM废料回收管理T.回收日期 = "" Then
            '    strSQL.Append(" ,回收日期 = NULL ")
            'Else
            '    strSQL.Append(" ,回收日期 = " & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.回收日期) & vbCrLf)
            'End If
            'If ojbM废料回收管理T.备注 = "" Then
            '    strSQL.Append(" ,备注 = NULL ")
            'Else
            '    strSQL.Append(" ,备注 = " & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.备注) & vbCrLf)
            'End If

            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    ID = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.ID))
            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM废料回收管理T As B废料回收管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM B废料回收管理" & vbCrLf)
            strSql.Append(" WHERE 1=1" & vbCrLf)
            If ojbM废料回收管理T.原材料编号 <> String.Empty Then
                strSql.AppendFormat(" and 原材料编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料编号))
            End If

            If ojbM废料回收管理T.ID <> String.Empty Then
                strSql.AppendFormat("   and ID = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM废料回收管理T.ID))
            End If


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
    Public Function LoadAll(ByVal ojbM废料回收管理T As B废料回收管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append("  原材料编号" & vbCrLf)            '原材料编号
            strSql.Append(" ,原材料批号" & vbCrLf)             '原材料批号
            strSql.Append(" ,原材料名称" & vbCrLf)             '原材料名称
            strSql.Append(" ,废料产生工序" & vbCrLf)             '废料产生工序
            strSql.Append(" ,废料数量" & vbCrLf)             '废料数量
            strSql.Append(" ,材质" & vbCrLf)             '材质
            strSql.Append(" ,原材料规格" & vbCrLf)             '原材料规格
            strSql.Append(" ,回收日期" & vbCrLf)             '回收日期
            strSql.Append(" ,备注" & vbCrLf)            '备注
            strSql.Append(" ,ID" & vbCrLf)            '备注

            'strSql.Append(" 	部门编号" & vbCrLf)
            'strSql.Append(" 	,部门名称" & vbCrLf)
            strSql.Append(" 	,登录者" & vbCrLf)
            strSql.Append(" 	,登录日期" & vbCrLf)
            strSql.Append(" 	,更新者" & vbCrLf)
            strSql.Append(" 	,更新日期" & vbCrLf)
            strSql.Append(" FROM B废料回收管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If ojbM废料回收管理T.ID <> String.Empty Then
                strSql.Append(" AND ID='" & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.ID, True) & "'" & vbCrLf)
            End If
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal ojbM废料回收管理T As B废料回收管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append("  原材料编号" & vbCrLf)            '原材料编号
            strSql.Append(" ,原材料批号" & vbCrLf)             '原材料批号
            strSql.Append(" ,原材料名称" & vbCrLf)             '原材料名称
            strSql.Append(" ,废料产生工序" & vbCrLf)             '废料产生工序
            strSql.Append(" ,废料数量" & vbCrLf)             '废料数量
            strSql.Append(" ,材质" & vbCrLf)             '材质
            strSql.Append(" ,原材料规格" & vbCrLf)             '原材料规格
            strSql.Append(" ,回收日期" & vbCrLf)             '回收日期
            strSql.Append(" ,备注" & vbCrLf)            '备注


            'strSql.Append(" 	部门编号" & vbCrLf)
            'strSql.Append(" 	,部门名称" & vbCrLf)
            strSql.Append(" 	,登录者" & vbCrLf)
            strSql.Append(" 	,登录日期" & vbCrLf)
            strSql.Append(" 	,更新者" & vbCrLf)
            strSql.Append(" 	,更新日期" & vbCrLf)
            strSql.Append(" FROM B废料回收管理")

            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (ojbM废料回收管理T.原材料批号 <> String.Empty) Then
                strSql.Append(" AND 原材料批号=" & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料批号) & vbCrLf)
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
    Public Function LoadByWhere(ByVal ojbM废料回收管理T As B废料回收管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append("  ID,原材料编号" & vbCrLf)            '原材料编号
            strSql.Append(" ,原材料批号" & vbCrLf)             '原材料批号
            strSql.Append(" ,原材料名称" & vbCrLf)             '原材料名称
            strSql.Append(" ,废料产生工序" & vbCrLf)             '废料产生工序
            strSql.Append(" ,废料数量" & vbCrLf)             '废料数量
            strSql.Append(" ,材质" & vbCrLf)             '材质
            strSql.Append(" ,原材料规格" & vbCrLf)             '原材料规格
            strSql.Append(" ,回收日期" & vbCrLf)             '回收日期
            strSql.Append(" ,备注" & vbCrLf)            '备注
            'strSql.Append(" 	部门编号" & vbCrLf)
            'strSql.Append(" 	,部门名称" & vbCrLf)
            'strSql.Append(" 	,登录者" & vbCrLf)
            'strSql.Append(" 	,登录日期" & vbCrLf)
            'strSql.Append(" 	,更新者" & vbCrLf)
            'strSql.Append(" 	,更新日期" & vbCrLf)
            strSql.Append(" FROM B废料回收管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If ojbM废料回收管理T.原材料编号 <> String.Empty Then
                strSql.Append(" AND 原材料编号='" & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料编号, True) & "'" & vbCrLf)
            End If
            'If (ojbM废料回收管理T.原材料编号 <> String.Empty) Then
            '    strSql.Append(" AND 原材料编号 LIKE '" & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.原材料编号, True) & "%'" & vbCrLf)
            'End If
            If (ojbM废料回收管理T.废料产生工序 <> String.Empty) Then
                strSql.Append(" AND 废料产生工序 LIKE '%" & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.废料产生工序, True) & "%'" & vbCrLf)
            End If
            If (ojbM废料回收管理T.回收开始时间 <> "1900/1/1") Then
                strSql.Append(" AND 回收日期 >=" & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.回收开始时间) & vbCrLf)
            End If

            If (ojbM废料回收管理T.回收结束时间 <> "1900/1/1") Then
                strSql.Append(" AND 回收日期 <" & Utility.PFn_ChangeQuotation(ojbM废料回收管理T.回收结束时间.AddDays(1)) & vbCrLf)
            End If
            strSql.Append(" ORDER BY 原材料编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


End Class
