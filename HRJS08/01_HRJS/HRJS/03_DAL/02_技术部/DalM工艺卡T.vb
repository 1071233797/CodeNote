Imports System.Text

Public Class DalM工艺卡T

#Region "IsExists"

    'Public Function IsExists(ByVal str产品图号 As String)

    '    Dim strSql As New StringBuilder(System.String.Empty)    'Sql文



    '    Try
    '        strSql.Append("SELECT COUNT(1) " & vbCrLf)
    '        strSql.Append("FROM   T工艺卡 " & vbCrLf)
    '        strSql.Append("WHERE  产品图号 = " & Utility.PFn_ChangeQuotation(str产品图号))

    '        Return strSql.ToString

    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '        Return String.Empty
    '    End Try

    'End Function

#End Region

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objM工艺卡T As M工艺卡T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" INSERT INTO dbo.T工艺卡 " & vbCrLf)
            strSql.Append("         ( 产品图号 , " & vbCrLf)
            strSql.Append("           上级图号 , " & vbCrLf)
            'strSql.Append("           图纸版本编号 , " & vbCrLf)
            strSql.Append("           附加品名 , " & vbCrLf)
            strSql.Append("           工序编号 , " & vbCrLf)
            strSql.Append("           工序名称 , " & vbCrLf)
            strSql.Append("           图纸 , " & vbCrLf)
            strSql.Append("           加工内容 , " & vbCrLf)
            strSql.Append("           备注 , " & vbCrLf)

            strSql.Append("           录入时间 , " & vbCrLf)
            strSql.Append("           作业者 , " & vbCrLf)
            strSql.Append("           登陆者 , " & vbCrLf)
            strSql.Append("           登陆日期 , " & vbCrLf)
            strSql.Append("           更新者 , " & vbCrLf)
            strSql.Append("           更新日期 " & vbCrLf)
            strSql.Append("         ) " & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat("  {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.备注))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.上级图号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.品名))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.工序编号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.工序名称))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.图纸图片))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.加工内容))

            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.图纸图片))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.备注))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.录入时间))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.作业者))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.登陆者))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.登陆日期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.更新者))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.更新日期))
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
    Public Function Update(ByVal objM工艺卡T As M工艺卡T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSQL.AppendFormat(" UPDATE [HRJS].[dbo].[T工艺卡]" & vbCrLf)
            strSQL.AppendFormat("    SET " & vbCrLf)
            strSQL.AppendFormat("		 [产品图号]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号))
            strSQL.AppendFormat("       ,[工序名称]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.工序名称))
            strSQL.AppendFormat("       ,[品名]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.品名))
            strSQL.AppendFormat("       ,[加工内容]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.加工内容))
            strSQL.AppendFormat("       ,[作业者]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.作业者))
            strSQL.AppendFormat("       ,[备注]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.备注))
            strSQL.AppendFormat("       ,[登陆者]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.登陆者))
            strSQL.AppendFormat("       ,[登陆日期]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.登陆日期))
            strSQL.AppendFormat("       ,[更新者]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.更新者))
            strSQL.AppendFormat("       ,[更新日期]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.更新日期))
            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    产品图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM工艺卡T As M工艺卡T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" DELETE FROM T工艺卡" & vbCrLf)
            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(ojbM工艺卡T.产品图号) & vbCrLf)
            'SQLに戻る

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAllGrid "

    '检索全部数据
    Public Function LoadAllGrid(ByVal objM工艺卡T As M工艺卡T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT   " & vbCrLf)
            ' strSql.Append("         工序编号 , " & vbCrLf)
            strSql.Append("         工序名称 , " & vbCrLf)
            strSql.Append("         加工内容 , " & vbCrLf)
            strSql.Append("         备注 , " & vbCrLf)
            strSql.Append("         作业者 , " & vbCrLf)
            strSql.Append("         录入时间  " & vbCrLf)
            strSql.Append(" FROM    dbo.T工艺卡 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadAll(ByVal objM工艺卡T As M工艺卡T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT A.产品图号 ," & vbCrLf)
            strSql.Append("        T图纸管理.品名 ," & vbCrLf)
            strSql.Append("        A.附加品名 ," & vbCrLf)
            strSql.Append("        A.工序名称 ," & vbCrLf)
            strSql.Append("        A.加工内容 ," & vbCrLf)
            strSql.Append("        A.备注 ," & vbCrLf)
            strSql.Append("        A.作业者 ," & vbCrLf)
            strSql.Append("        A.上级图号 ," & vbCrLf)
            strSql.Append("        A.图纸 ," & vbCrLf)
            strSql.Append("        A.录入时间 ," & vbCrLf)
            strSql.Append("        A.登陆者 ," & vbCrLf)
            strSql.Append("        A.登陆日期 ," & vbCrLf)
            strSql.Append("        A.更新者 ," & vbCrLf)
            strSql.Append("        A.更新日期" & vbCrLf)
            strSql.Append(" FROM   T工艺卡 A" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = A.产品图号" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE  A.产品图号 =" & Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    '    Public Function LoadAll人员(ByVal objM工艺卡T As M工艺卡T) As String

    '        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


    '        Try
    '            strSql.Append(" SELECT  产品图号 , " & vbCrLf)
    '            strSql.Append("         品名 , " & vbCrLf)
    '            strSql.Append("         工序名称 , " & vbCrLf)
    '            strSql.Append("         加工内容 , " & vbCrLf)
    '            'strSql.Append("         人员名 客户名称 " & vbCrLf)
    '            strSql.Append(" FROM    dbo.T工艺卡管理 " & vbCrLf)
    '            'strSql.Append("         INNER JOIN dbo.M人员管理  " & vbCrLf)
    '            'strSql.Append("         ON 人员编号 = 客户编号 " & vbCrLf)
    '            '检索条件 设定
    '            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号) & vbCrLf)
    '            Return strSql.ToString()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.ToString)
    '            Return String.Empty
    '        End Try

    '    End Function
#End Region

#Region " LoadByPK"

    '检索全部数据

    Public Function LoadByPK(ByVal objM工艺卡T As M工艺卡T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	工序名称" & vbCrLf)
            strSql.Append(" FROM T工艺卡")
            '检索条件 设定
            strSql.Append(" WHERE 1=1" & vbCrLf)
            If objM工艺卡T.产品图号 <> String.Empty Then
                strSql.Append(" AND 产品图号 =" & Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号) & vbCrLf)
            End If
            If objM工艺卡T.工序名称 <> String.Empty Then
                strSql.Append(" AND 工序名称='" & Utility.PFn_ChangeQuotation(objM工艺卡T.工序名称, True) & "'" & vbCrLf)
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
    'tudo


    Public Function LoadByWhere(ByVal objM工艺卡T As M工艺卡T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append("        T工艺卡.产品图号 , " & vbCrLf)
            strSql.Append("        CASE WHEN T工艺卡.上级图号 IS NULL THEN T图纸管理.品名 " & vbCrLf)
            strSql.Append("             ELSE T工艺卡.附加品名 " & vbCrLf)
            strSql.Append("        END 品名 " & vbCrLf)
            strSql.Append(" FROM   T工艺卡 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = T工艺卡.产品图号 " & vbCrLf)
            strSql.Append("                               OR T图纸管理.产品图号 = T工艺卡.上级图号 " & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE 1=1" & vbCrLf)
            If objM工艺卡T.产品图号 <> String.Empty Then
                strSql.Append(" AND T工艺卡.产品图号 =" & Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号) & vbCrLf)
            End If
            'If objM工艺卡T.品名 <> String.Empty Then
            '    strSql.Append(" AND 品名 LIKE'" & Utility.PFn_ChangeQuotation(objM工艺卡T.品名, True) & "%'" & vbCrLf)
            'End If
            If objM工艺卡T.更新日期 <> String.Empty Then
                strSql.Append(" AND 录入时间>='" & Utility.PFn_ChangeQuotation(objM工艺卡T.作业者, True) & "'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 产品图号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByWhere1"

    '检索全部数据
    'tudo


    Public Function LoadByWhere1(ByVal objM工艺卡T As M工艺卡T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT " & vbCrLf)
            strSql.Append("     distinct 产品图号 " & vbCrLf)
            strSql.Append("      ,工序编号 " & vbCrLf)
            strSql.Append("      ,工序名称 " & vbCrLf)
            strSql.Append(" 	,加工内容  " & vbCrLf)
            strSql.Append("     ,录入时间 AS 录入日期" & vbCrLf)
            strSql.Append("     ,作业者" & vbCrLf)
            strSql.Append("FROM T工艺卡" & vbCrLf)
            strSql.Append("WHERE 1=1" & vbCrLf)
            If objM工艺卡T.产品图号 <> String.Empty Then
                strSql.Append(" AND 产品图号='" & Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号, True) & "'" & vbCrLf)
            End If
            'If objM工艺卡T.品名 <> String.Empty Then
            '    strSql.Append(" AND 品名='" & Utility.PFn_ChangeQuotation(objM工艺卡T.品名, True) & "'" & vbCrLf)
            'End If
            If objM工艺卡T.工序名称 <> String.Empty Then
                strSql.Append(" AND 工序名称='" & Utility.PFn_ChangeQuotation(objM工艺卡T.工序名称, True) & "'" & vbCrLf)
            End If
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadByWhere2(ByVal objM工艺卡T As M工艺卡T, ByVal intCount As Integer) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            'strSql.Append(" SELECT DISTINCT")
            'strSql.Append("         T图纸管理.产品图号 ,")
            'strSql.Append("         图纸版本编号 ,")
            'strSql.Append("         品名 ,")
            'strSql.Append("         图纸 ")
            ''strSql.Append("         M客户管理.客户编号 ,")
            ''strSql.Append("         M客户管理.客户名称 ")
            ''strSql.Append("         --图纸 ")
            ''strSql.Append("        -- 主号")
            'strSql.Append("         ,")
            'strSql.Append("         CC.上级图号")
            'strSql.Append(" FROM    dbo.T图纸管理")
            'strSql.Append("         INNER JOIN dbo.M客户管理 ON M客户管理.客户编号 = T图纸管理.客户编号")
            'strSql.Append("         INNER JOIN ( SELECT ddd.产品图号 上级图号 ,")
            'strSql.Append("                             aaa.CIID ,")
            'strSql.Append("                             CASE WHEN aaa.CIID = 0 THEN 0")
            'strSql.Append("                                  ELSE aaa.CIID - bbb.ID + 1")
            'strSql.Append("                             END ID ,")
            'strSql.Append("                             aaa.产品图号 ,")
            'strSql.Append("                             主号")
            'strSql.Append("                      FROM   dbo.T图纸关系 aaa")
            'strSql.Append("                             INNER JOIN ( SELECT ID ,")
            'strSql.Append("                                                 关系ID ,")
            'strSql.Append("                                                 产品图号 主号")
            'strSql.Append("                                          FROM   T图纸关系")
            'strSql.Append("                                          WHERE  产品图号 IN ( SELECT")
            'strSql.Append("                                                               产品图号")
            'strSql.Append("                                                         FROM  dbo.T图纸管理")
            'strSql.Append(" WHERE 1=1 " & vbCrLf)
            'If (objM工艺卡T.产品图号 <> String.Empty) Then
            '    strSql.Append(" AND 产品图号 LIKE '%" & Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号, True) & "%'" & vbCrLf)
            'End If
            'If (objM工艺卡T.品名 <> String.Empty) Then
            '    strSql.Append(" AND 品名 LIKE '%" & Utility.PFn_ChangeQuotation(objM工艺卡T.品名, True) & "%'" & vbCrLf)
            'End If

            'strSql.Append("                                                          )")
            'strSql.Append("                                        ) bbb ON bbb.关系ID = aaa.关系ID")
            'strSql.Append("                             LEFT JOIN T图纸关系 ddd ON aaa.CIID = ddd.ID")
            'strSql.Append("                    ) CC ON CC.产品图号 =  T图纸管理.产品图号 ")
            ''检索条件 设定



            strSql.Append("  SELECT DISTINCT top " & intCount & "")
            strSql.Append("            T工艺卡.产品图号 , " & vbCrLf)
            strSql.Append("            品名 , " & vbCrLf)
            strSql.Append("            T工艺卡.图纸 , " & vbCrLf)
            strSql.Append("            VM图纸状态.名称 图纸状态 , " & vbCrLf)
            strSql.Append("            上级关系.产品图号 上级图号 " & vbCrLf)
            strSql.Append("  FROM      dbo.T图纸关系 " & vbCrLf)
            strSql.Append("            INNER JOIN dbo.T图纸关系 分图关系 ON 分图关系.关系ID = T图纸关系.关系ID " & vbCrLf)
            strSql.Append("                                         AND T图纸关系.CIID = 0 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.T图纸关系 上级关系 ON 上级关系.ID = 分图关系.CIID AND 上级关系.关系ID = T图纸关系.关系ID" & vbCrLf)
            strSql.Append("            INNER JOIN dbo.T图纸管理 ON 主图号 = T图纸关系.产品图号 " & vbCrLf)
            strSql.Append("                                    AND ( 上级关系.产品图号 = 上级图号 " & vbCrLf)
            strSql.Append("                                          OR 上级关系.产品图号 IS NULL " & vbCrLf)
            strSql.Append("                                        ) " & vbCrLf)
            strSql.Append("                                    AND T图纸管理.产品图号 = 分图关系.产品图号 " & vbCrLf)
            strSql.Append("            LEFT JOIN VM图纸状态 ON dbo.VM图纸状态.区分 = T图纸管理.图纸状态 " & vbCrLf)
            strSql.Append("            INNER JOIN dbo.T工艺卡 ON T工艺卡.产品图号 = 分图关系.产品图号 " & vbCrLf)
            strSql.Append("  WHERE     T图纸关系.CIID = 0 " & vbCrLf)
            strSql.Append("            AND T图纸关系.产品图号 IN ( " & vbCrLf)
            strSql.Append("            SELECT DISTINCT " & vbCrLf)
            strSql.Append("                    ALL关系.产品图号 " & vbCrLf)
            strSql.Append("            FROM    dbo.T图纸关系 " & vbCrLf)
            strSql.Append("                    INNER JOIN dbo.T图纸关系 ALL关系 ON ALL关系.关系ID = T图纸关系.关系ID " & vbCrLf)
            strSql.Append("                    INNER JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = ALL关系.产品图号 " & vbCrLf)
            strSql.Append("            WHERE   1=1 " & vbCrLf)
            If (objM工艺卡T.产品图号 <> String.Empty) Then
                strSql.Append("                                                         AND T图纸管理.产品图号 LIKE '%" & Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号, True) & "%'" & vbCrLf)
            End If
            If (objM工艺卡T.品名 <> String.Empty) Then
                strSql.Append("                                                         AND T图纸管理.品名 LIKE '%" & Utility.PFn_ChangeQuotation(objM工艺卡T.品名, True) & "%'" & vbCrLf)
            End If
            If (objM工艺卡T.图纸状态 <> String.Empty) Then
                strSql.Append("                                                         AND T图纸管理.图纸状态 =" & Utility.PFn_ChangeQuotation(objM工艺卡T.图纸状态) & " " & vbCrLf)
            End If
            strSql.Append("                    AND ALL关系.CIID = 0  " & vbCrLf)
            strSql.Append("                    ) " & vbCrLf)
            strSql.Append(" UNION ALL " & vbCrLf)
            strSql.Append(" SELECT    产品图号 , " & vbCrLf)
            strSql.Append(" 附加品名 品名 , " & vbCrLf)
            strSql.Append(" 图纸 , " & vbCrLf)
            strSql.Append(" '使用' , " & vbCrLf)
            strSql.Append(" 上级图号 " & vbCrLf)
            strSql.Append(" FROM      T工艺卡 " & vbCrLf)
            strSql.Append(" WHERE     上级图号 IS NOT NULL " & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region

#Region " SetData "

    '检索全部数据
    Public Function SetData(ByVal objM工艺卡T As M工艺卡T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try

            strSql.Append(" SELECT " & vbCrLf)
            strSql.Append("        A.工序名称 ," & vbCrLf)
            strSql.Append("        A.加工内容 ," & vbCrLf)
            strSql.Append("        A.备注 ," & vbCrLf)
            strSql.Append("        A.作业者 ," & vbCrLf)         
            strSql.Append("        A.录入时间 " & vbCrLf)           
            strSql.Append(" FROM   T工艺卡 A" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = A.产品图号" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE  A.产品图号 =" & Utility.PFn_ChangeQuotation(objM工艺卡T.产品图号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
