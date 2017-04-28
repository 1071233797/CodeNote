Imports System.Text
Imports System.Data.SqlClient

Public Class DalM图纸T

#Region "IsExists"

    Public Function IsExists(ByVal str产品图号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   M图纸管理 " & vbCrLf)
            strSql.Append("WHERE  产品图号 = " & Utility.PFn_ChangeQuotation(str产品图号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO dbo.T图纸管理 " & vbCrLf)
            strSql.Append("         ( 产品图号 , " & vbCrLf)
            strSql.Append("           图纸版本编号 , " & vbCrLf)
            strSql.Append("           主图号 , " & vbCrLf)
            strSql.Append("           上级图号 , " & vbCrLf)
            strSql.Append("           品名 , " & vbCrLf)
            strSql.Append("           客户编号 , " & vbCrLf)
            strSql.Append("           图纸 , " & vbCrLf)
            strSql.Append("           原材料编号 , " & vbCrLf)
            'strSql.Append("           材料种类 , " & vbCrLf)
            'strSql.Append("           材质 , " & vbCrLf)
            'strSql.Append("           材料代号 , " & vbCrLf)
            strSql.Append("           图纸状态 , " & vbCrLf)
            strSql.Append("           单件重量 , " & vbCrLf)
            strSql.Append("           长 , " & vbCrLf)
            strSql.Append("           宽 , " & vbCrLf)
            strSql.Append("           高 , " & vbCrLf)
            strSql.Append("           数量 , " & vbCrLf)
            strSql.Append("           要求 , " & vbCrLf)
            strSql.Append("           备注 , " & vbCrLf)
            strSql.Append("           创建日期 , " & vbCrLf)
            strSql.Append("           登陆者 , " & vbCrLf)
            strSql.Append("           登陆日期 , " & vbCrLf)
            strSql.Append("           更新者 , " & vbCrLf)
            strSql.Append("           更新日期 " & vbCrLf)
            strSql.Append("         ) " & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat("  {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.产品图号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.图纸版本编号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.主图号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.上级图号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.品名))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.客户编号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.图纸图片))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.原材料编号))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.材料种类))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.材质))
            'strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.材料代码))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.图纸状态))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.单件重量))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.长))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.宽))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.高))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.数量))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.要求))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.备注))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.创建日期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.登录者))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.登录日期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.更新者))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.更新日期))
            strSql.Append(")" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

    Public Function Insert图纸关系(ByVal dr As DataRow) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO dbo.T图纸关系 " & vbCrLf)
            strSql.Append("          ( ID, CIID, 产品图号,关系ID ) " & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)

            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(dr("ID")))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(dr("CIID")))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(dr("图号")))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(dr("关系ID")))
            strSql.Append(")" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function
    Public Function insert流转票(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("    INSERT  INTO T流转票管理")
            strSql.Append("            ( 产品图号,外协加工 ,")
            strSql.Append("              组装品 ,")
            strSql.Append("              试做品 ,")
            strSql.Append("              工序编号 ,")
            strSql.Append("              工序名称 ,")
            strSql.Append("              加工内容简介 ,")
            strSql.Append("              作业场所 ,")
            strSql.Append("              图纸 ,")
            strSql.Append("              设备编号 ,")
            strSql.Append("              备注 ,")
            strSql.Append("              登陆者 ,")
            strSql.Append("              登陆日期 ,")
            strSql.Append("              更新者 ,")
            strSql.Append("              更新日期")
            strSql.Append("            )")
            strSql.Append("            SELECT  ")
            strSql.Append(Utility.PFn_ChangeQuotation(objM图纸T.产品图号) & vbCrLf)
            strSql.Append("                    ,外协加工 ,")
            strSql.Append("                    组装品 ,")
            strSql.Append("                    试做品 ,")
            strSql.Append("                    工序编号 ,")
            strSql.Append("                    工序名称 ,")
            strSql.Append("                    加工内容简介 ,")
            strSql.Append("                    作业场所 ,")
            strSql.Append("                    图纸 ,")
            strSql.Append("                    设备编号 ,")
            strSql.Append("                    备注 ,")
            strSql.Append("                    登陆者 ,")
            strSql.Append("                    登陆日期 ,")
            strSql.Append("                    更新者 ,")
            strSql.Append("                    更新日期")
            strSql.Append("            FROM    dbo.T流转票管理")
            strSql.Append("            WHERE   产品图号 =" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号1) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function
    Public Function insert工艺卡(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("INSERT INTO dbo.T工艺卡")
            strSql.Append("        ( 产品图号 ,")
            strSql.Append("          附加品名 ,")
            strSql.Append("          工序编号 ,")
            strSql.Append("          工序名称 ,")
            strSql.Append("          加工内容 ,")
            strSql.Append("          备注 ,")
            strSql.Append("          图纸 ,")
            strSql.Append("          录入时间 ,")
            strSql.Append("          上级图号 ,")
            strSql.Append("          作业者 ,")
            strSql.Append("          登陆者 ,")
            strSql.Append("          登陆日期 ,")
            strSql.Append("          更新者 ,")
            strSql.Append("          更新日期")
            strSql.Append("        )" & vbCrLf)
            strSql.Append("SELECT  ")
            strSql.Append(Utility.PFn_ChangeQuotation(objM图纸T.产品图号))
            strSql.Append("        ,附加品名 ,")
            strSql.Append("        工序编号 ,")
            strSql.Append("        工序名称 ,")
            strSql.Append("        加工内容 ,")
            strSql.Append("        备注 ,")
            strSql.Append("        图纸 ,")
            strSql.Append("        录入时间 ,")
            strSql.Append("        上级图号 ,")
            strSql.Append("        作业者 ,")
            strSql.Append("        登陆者 ,")
            strSql.Append("        登陆日期 ,")
            strSql.Append("        更新者 ,")
            strSql.Append("        更新日期" & vbCrLf)
            strSql.Append("FROM    dbo.T工艺卡" & vbCrLf)
            strSql.Append("WHERE   产品图号 =" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号1) & vbCrLf)
            strSql.Append(" OR   上级图号 =" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号1) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function
#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal objM图纸T As M图纸T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.AppendFormat(" UPDATE [HRJS].[dbo].[T图纸管理]" & vbCrLf)
            strSQL.AppendFormat("    SET " & vbCrLf)
            strSQL.AppendFormat("		 [产品图号]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.产品图号))
            strSQL.AppendFormat("       ,[图纸版本编号]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.图纸版本编号))
            strSQL.AppendFormat("       ,[主图号]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.主图号))
            strSQL.AppendFormat("       ,[上级图号]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.上级图号))
            strSQL.AppendFormat("       ,[品名]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.品名))
            strSQL.AppendFormat("       ,[客户编号]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.客户编号))
            strSQL.AppendFormat("       ,[图纸]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.图纸图片))
            strSQL.AppendFormat("       ,[原材料编号]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.原材料编号))
            'strSQL.AppendFormat("       ,[材料种类]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.材料种类))
            'strSQL.AppendFormat("       ,[材质]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.材质))
            'strSQL.AppendFormat("       ,[材料代号]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.材料代码))
            strSQL.AppendFormat("       ,[图纸状态]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.图纸状态))
            strSQL.AppendFormat("       ,[单件重量]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.单件重量))
            strSQL.AppendFormat("       ,[长]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.长))
            strSQL.AppendFormat("       ,[宽]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.宽))
            strSQL.AppendFormat("       ,[高]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.高))
            strSQL.AppendFormat("       ,[数量]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.数量))
            strSQL.AppendFormat("       ,[要求]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.要求))
            strSQL.AppendFormat("       ,[备注]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.备注))
            strSQL.AppendFormat("       ,[创建日期]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.创建日期))
            strSQL.AppendFormat("       ,[登陆者]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.登录者))
            strSQL.AppendFormat("       ,[登陆日期]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.登录日期))
            strSQL.AppendFormat("       ,[更新者]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.更新者))
            strSQL.AppendFormat("       ,[更新日期]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.更新日期))
            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("  产品图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.产品图号))
            'strSQL.AppendFormat("  产品图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.产品图号1))
            strSQL.AppendFormat(" and 主图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.主图号))
            strSQL.AppendFormat(" and 上级图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.上级图号))
            strSQL.Append("")
            'strSQL.Append("UPDATE [HRJS].[dbo].[T图纸管理]")
            'strSQL.Append("SET" & vbCrLf)
            'strSQL.AppendFormat("  [上级图号]  = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.产品图号))
            'strSQL.Append("  WHERE " & vbCrLf)
            'strSQL.AppendFormat("  主图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.主图号))
            ''strSQL.AppendFormat(" and 上级图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.产品图号))
            'strSQL.AppendFormat(" and 上级图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM图纸T.产品图号1))
            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM T图纸管理" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  产品图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM图纸T.产品图号1))
            strSql.AppendFormat(" and 主图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM图纸T.主图号))
            strSql.AppendFormat(" and 上级图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM图纸T.上级图号))
            strSql.Append("")
            'SQLに戻る            'strSql.Append(" DELETE FROM dbo.T图纸关系 WHERE 关系ID=" & vbCrLf)
            'strSql.Append(" (SELECT 关系ID FROM dbo.T图纸关系 Where " & vbCrLf)
            'strSql.AppendFormat(" CIID='0'and 产品图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM图纸T.主图号) & ")")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function


    '数据删除操作
    
#End Region
#Region " Delete1 "

    '数据删除操作
    Public Function Delete1(ByVal ojbM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM T图纸管理" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            'strSql.AppendFormat("  产品图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM图纸T.产品图号))
            strSql.AppendFormat(" 主图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM图纸T.主图号))
            'strSql.AppendFormat(" and 上级图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM图纸T.上级图号))
            strSql.Append("")
            'SQLに戻る            strSql.Append(" DELETE FROM dbo.T图纸关系 WHERE 关系ID=" & vbCrLf)
            strSql.Append(" (SELECT 关系ID FROM dbo.T图纸关系 Where " & vbCrLf)
            strSql.AppendFormat(" CIID='0'and 产品图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM图纸T.主图号) & ")")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function insert复制(ByVal ojbM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            'strSql.Append("WITH    关系 " & vbCrLf)
            'strSql.Append("          AS ( SELECT   图纸.ID - 关系.ID + 1 + MAXID ID , " & vbCrLf)
            'strSql.Append("                        CASE WHEN 图纸.CIID = 0 THEN 0 " & vbCrLf)
            'strSql.Append("                             ELSE 图纸.CIID - 关系.ID + 1 + MAXID " & vbCrLf)
            'strSql.Append("                        END CIID , " & vbCrLf)
            'strSql.Append("                        CASE WHEN 图纸.CIID = 0 THEN " & Utility.PFn_ChangeQuotation(ojbM图纸T.复制后图号) & " " & vbCrLf)
            'strSql.Append("                             ELSE 图纸.产品图号 " & vbCrLf)
            'strSql.Append("                        END 产品图号 , " & vbCrLf)
            'strSql.Append("                        MAX关系 + 1 关系ID , " & vbCrLf)
            'strSql.Append("                        图纸.产品图号 更新前图号 " & vbCrLf)
            'strSql.Append("               FROM     dbo.T图纸关系 关系 " & vbCrLf)
            'strSql.Append("                        INNER  JOIN dbo.T图纸关系 图纸 ON 图纸.关系ID = 关系.关系ID " & vbCrLf)
            'strSql.Append("                        LEFT JOIN ( SELECT  MAX(最大ID.ID) + 1 MAXID , " & vbCrLf)
            'strSql.Append("                                            MAX(最大ID.关系ID) + 1 MAX关系 " & vbCrLf)
            'strSql.Append("                                    FROM    dbo.T图纸关系 最大ID " & vbCrLf)
            'strSql.Append("                                  ) 最大 ON 1 = 1 " & vbCrLf)
            'strSql.Append("               WHERE    关系.产品图号 = " & Utility.PFn_ChangeQuotation(ojbM图纸T.主图号) & " AND 关系.CIID=0 " & vbCrLf)
            'strSql.Append("             ) " & vbCrLf)
            'strSql.Append("    INSERT  INTO dbo.T图纸管理 " & vbCrLf)
            'strSql.Append("            ( 产品图号 , " & vbCrLf)
            'strSql.Append("              图纸版本编号 , " & vbCrLf)
            'strSql.Append("              品名 , " & vbCrLf)
            'strSql.Append("              客户编号 , " & vbCrLf)
            'strSql.Append("              图纸 , " & vbCrLf)
            'strSql.Append("              材料种类 , " & vbCrLf)
            'strSql.Append("              材质 , " & vbCrLf)
            'strSql.Append("              材料代号 , " & vbCrLf)
            'strSql.Append("              单件重量 , " & vbCrLf)
            'strSql.Append("              长 , " & vbCrLf)
            'strSql.Append("              宽 , " & vbCrLf)
            'strSql.Append("              高 , " & vbCrLf)
            'strSql.Append("              数量 , " & vbCrLf)
            'strSql.Append("              单品耗材数量 , " & vbCrLf)
            'strSql.Append("              要求 , " & vbCrLf)
            'strSql.Append("              备注 , " & vbCrLf)
            'strSql.Append("              图纸状态 , " & vbCrLf)
            'strSql.Append("              创建日期 , " & vbCrLf)
            'strSql.Append("              主图号 , " & vbCrLf)
            'strSql.Append("              上级图号 , " & vbCrLf)
            'strSql.Append("              登陆者 , " & vbCrLf)
            'strSql.Append("              登陆日期 , " & vbCrLf)
            'strSql.Append("              更新者 , " & vbCrLf)
            'strSql.Append("              更新日期 " & vbCrLf)
            'strSql.Append("            ) " & vbCrLf)
            'strSql.Append("            SELECT " & vbCrLf)
            'strSql.Append("      " & vbCrLf)
            'strSql.Append("   DISTINCT         关系.产品图号 , " & vbCrLf)
            'strSql.Append("                    图纸.图纸版本编号 , " & vbCrLf)
            'strSql.Append("                    图纸.品名 , " & vbCrLf)
            'strSql.Append("                    图纸.客户编号 , " & vbCrLf)
            'strSql.Append("                    图纸.图纸 , " & vbCrLf)
            'strSql.Append("                    图纸.材料种类 , " & vbCrLf)
            'strSql.Append("                    图纸.材质 , " & vbCrLf)
            'strSql.Append("                    图纸.材料代号 , " & vbCrLf)
            'strSql.Append("                    图纸.单件重量 , " & vbCrLf)
            'strSql.Append("                    图纸.长 , " & vbCrLf)
            'strSql.Append("                    图纸.宽 , " & vbCrLf)
            'strSql.Append("                    图纸.高 , " & vbCrLf)
            'strSql.Append("                    图纸.数量 , " & vbCrLf)
            'strSql.Append("                    图纸.单品耗材数量 , " & vbCrLf)
            'strSql.Append("                    图纸.要求 , " & vbCrLf)
            'strSql.Append("                    图纸.备注 , " & vbCrLf)
            'strSql.Append("                    图纸.图纸状态 , " & vbCrLf)
            'strSql.Append("                    GETDATE() , " & vbCrLf)
            'strSql.Append("                    " & Utility.PFn_ChangeQuotation(ojbM图纸T.复制后图号) & " , " & vbCrLf)
            'strSql.Append("                    CASE WHEN 上级关系.产品图号 IS NULL THEN " & Utility.PFn_ChangeQuotation(ojbM图纸T.复制后图号) & " else 上级关系.产品图号 END , " & vbCrLf)
            'strSql.Append("                    图纸.登陆者 , " & vbCrLf)
            'strSql.Append("                    GETDATE() , " & vbCrLf)
            'strSql.Append("                    图纸.更新者 , " & vbCrLf)
            'strSql.Append("                    GETDATE() " & vbCrLf)
            'strSql.Append("            FROM    关系 " & vbCrLf)
            'strSql.Append("                    INNER JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = 关系.更新前图号 " & vbCrLf)
            'strSql.Append("                    LEFT JOIN 关系 上级关系 ON 关系.CIID = 上级关系.ID; " & vbCrLf)
            'strSql.Append(" " & vbCrLf)


            'strSql.Append(" INSERT dbo.T图纸关系 " & vbCrLf)
            'strSql.Append("        ( ID , " & vbCrLf)
            'strSql.Append("          CIID , " & vbCrLf)
            'strSql.Append("          产品图号 , " & vbCrLf)
            'strSql.Append("          关系ID " & vbCrLf)
            'strSql.Append("        ) " & vbCrLf)
            'strSql.Append("        SELECT  图纸.ID - 关系.ID + 1 + MAXID SUMID , " & vbCrLf)
            'strSql.Append("                CASE WHEN 图纸.CIID = 0 THEN 0 " & vbCrLf)
            'strSql.Append("                     ELSE 图纸.CIID - 关系.ID + 1 + MAXID " & vbCrLf)
            'strSql.Append("                END SUMCIID , " & vbCrLf)
            'strSql.Append("                CASE WHEN 图纸.CIID = 0 THEN " & Utility.PFn_ChangeQuotation(ojbM图纸T.复制后图号) & " " & vbCrLf)
            'strSql.Append("                     ELSE 图纸.产品图号 " & vbCrLf)
            'strSql.Append("                END SUM产品图号 , " & vbCrLf)
            'strSql.Append("                MAX关系 + 1 SUM关系 " & vbCrLf)
            'strSql.Append("        FROM    dbo.T图纸关系 关系 " & vbCrLf)
            'strSql.Append("                INNER  JOIN dbo.T图纸关系 图纸 ON 图纸.关系ID = 关系.关系ID " & vbCrLf)
            'strSql.Append("                LEFT JOIN ( SELECT  MAX(最大ID.ID) + 1 MAXID , " & vbCrLf)
            'strSql.Append("                                    MAX(最大ID.关系ID) + 1 MAX关系 " & vbCrLf)
            'strSql.Append("                            FROM    dbo.T图纸关系 最大ID " & vbCrLf)
            'strSql.Append("                          ) 最大 ON 1 = 1 " & vbCrLf)
            'strSql.Append("        WHERE   关系.产品图号 =  " & Utility.PFn_ChangeQuotation(ojbM图纸T.主图号) & ";   " & vbCrLf)
            'SQLに戻る            strSql.Append("WITH    关系")
            strSql.Append("          AS ( SELECT   图纸.ID - 关系.ID + 1 + MAXID ID ,")
            strSql.Append("                        CASE WHEN 图纸.CIID = 0 THEN 0")
            strSql.Append("                             ELSE 图纸.CIID - 关系.ID + 1 + MAXID")
            strSql.Append("                        END CIID ,")
            strSql.Append("                        CASE WHEN 图纸.CIID = 0 THEN " & Utility.PFn_ChangeQuotation(ojbM图纸T.复制后图号) & " " & vbCrLf)
            strSql.Append("                             ELSE 图纸.产品图号")
            strSql.Append("                        END 产品图号 ,")
            strSql.Append("                        MAX关系 + 1 关系ID ,")
            strSql.Append("                        图纸.产品图号 更新前图号 ,")
            strSql.Append("                        关系.产品图号 更新前主图号 ,")
            strSql.Append("                        CASE WHEN 上级.产品图号 IS NULL THEN 图纸.产品图号")
            strSql.Append("                             ELSE 上级.产品图号")
            strSql.Append("                        END 上级图号")
            strSql.Append("               FROM     dbo.T图纸关系 关系")
            strSql.Append("                        INNER  JOIN dbo.T图纸关系 图纸 ON 图纸.关系ID = 关系.关系ID")
            strSql.Append("                        LEFT JOIN ( SELECT  MAX(最大ID.ID) + 1 MAXID ,")
            strSql.Append("                                            MAX(最大ID.关系ID) + 1 MAX关系")
            strSql.Append("                                    FROM    dbo.T图纸关系 最大ID")
            strSql.Append("                                  ) 最大 ON 1 = 1")
            strSql.Append("                        LEFT JOIN dbo.T图纸关系 上级 ON 上级.关系ID = 关系.关系ID")
            strSql.Append("                                                  AND 上级.ID = 图纸.CIID")
            strSql.Append("               WHERE    关系.产品图号 = " & Utility.PFn_ChangeQuotation(ojbM图纸T.主图号) & "")
            strSql.Append("                        AND 关系.CIID = 0")
            strSql.Append("             )")
            strSql.Append("    INSERT  INTO dbo.T图纸管理")
            strSql.Append("            ( 产品图号 ,")
            strSql.Append("              图纸版本编号 ,")
            strSql.Append("              品名 ,")
            strSql.Append("              客户编号 ,")
            strSql.Append("              图纸 ,")
            strSql.Append("              原材料编号 ,")
            'strSql.Append("              材料种类 ,")
            'strSql.Append("              材质 ,")
            'strSql.Append("              材料代号 ,")
            strSql.Append("              单件重量 ,")
            strSql.Append("              长 ,")
            strSql.Append("              宽 ,")
            strSql.Append("              高 ,")
            strSql.Append("              数量 ,")
            strSql.Append("              单品耗材数量 ,")
            strSql.Append("              要求 ,")
            strSql.Append("              备注 ,")
            strSql.Append("              图纸状态 ,")
            strSql.Append("              创建日期 ,")
            strSql.Append("              主图号 ,")
            strSql.Append("              上级图号 ,")
            strSql.Append("              登陆者 ,")
            strSql.Append("              登陆日期 ,")
            strSql.Append("              更新者 ,")
            strSql.Append("              更新日期 ")
            strSql.Append("            )")
            strSql.Append("            SELECT ")
            strSql.Append("      ")
            strSql.Append("   DISTINCT         关系.产品图号 ,")
            strSql.Append("                    图纸.图纸版本编号 ,")
            strSql.Append("                    图纸.品名 ,")
            strSql.Append("                    图纸.客户编号 ,")
            strSql.Append("                    图纸.图纸 ,")
            strSql.Append("                    M原材料信息.原材料编号,")
            'strSql.Append("                    图纸.材料种类 ,")
            'strSql.Append("                    图纸.材质 ,")
            'strSql.Append("                    图纸.材料代号 ,")
            strSql.Append("                    图纸.单件重量 ,")
            strSql.Append("                    图纸.长 ,")
            strSql.Append("                    图纸.宽 ,")
            strSql.Append("                    图纸.高 ,")
            strSql.Append("                    图纸.数量 ,")
            strSql.Append("                    图纸.单品耗材数量 ,")
            strSql.Append("                    图纸.要求 ,")
            strSql.Append("                    图纸.备注 ,")
            strSql.Append("                    图纸.图纸状态 ,")
            strSql.Append("                    GETDATE() ,")
            strSql.Append("                    " & Utility.PFn_ChangeQuotation(ojbM图纸T.复制后图号) & " ,")
            strSql.Append("                    CASE WHEN 上级关系.产品图号 IS NULL THEN " & Utility.PFn_ChangeQuotation(ojbM图纸T.复制后图号) & "")
            strSql.Append("                         ELSE 上级关系.产品图号")
            strSql.Append("                    END ,")
            strSql.Append("                    图纸.登陆者 ,")
            strSql.Append("                    GETDATE() ,")
            strSql.Append("                    图纸.更新者 ,")
            strSql.Append("                    GETDATE()")
            strSql.Append("            FROM    关系")
            strSql.Append("                    INNER JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = 关系.更新前图号")
            strSql.Append("                                               AND 图纸.上级图号 = 关系.上级图号")
            strSql.Append("                                               AND 图纸.主图号 = 关系.更新前主图号")
            strSql.Append("                    LEFT JOIN dbo.M原材料信息 ON M原材料信息.原材料编号 = 图纸.原材料编号 ")
            strSql.Append("                    LEFT JOIN 关系 上级关系 ON 关系.CIID = 上级关系.ID;")
            strSql.Append(" ")
            strSql.Append("INSERT  dbo.T图纸关系")
            strSql.Append("        ( ID ,")
            strSql.Append("          CIID ,")
            strSql.Append("          产品图号 ,")
            strSql.Append("          关系ID ")
            strSql.Append("        )")
            strSql.Append("        SELECT  图纸.ID - 关系.ID + 1 + MAXID SUMID ,")
            strSql.Append("                CASE WHEN 图纸.CIID = 0 THEN 0")
            strSql.Append("                     ELSE 图纸.CIID - 关系.ID + 1 + MAXID")
            strSql.Append("                END SUMCIID ,")
            strSql.Append("                CASE WHEN 图纸.CIID = 0 THEN " & Utility.PFn_ChangeQuotation(ojbM图纸T.复制后图号) & " " & vbCrLf)
            strSql.Append("                     ELSE 图纸.产品图号")
            strSql.Append("                END SUM产品图号 ,")
            strSql.Append("                MAX关系 + 1 SUM关系")
            strSql.Append("        FROM    dbo.T图纸关系 关系")
            strSql.Append("                INNER  JOIN dbo.T图纸关系 图纸 ON 图纸.关系ID = 关系.关系ID")
            strSql.Append("                LEFT JOIN ( SELECT  MAX(最大ID.ID) MAXID ,")
            strSql.Append("                                    MAX(最大ID.关系ID) MAX关系")
            strSql.Append("                            FROM    dbo.T图纸关系 最大ID")
            strSql.Append("                          ) 最大 ON 1 = 1")
            strSql.Append("        WHERE   关系.产品图号 = " & Utility.PFn_ChangeQuotation(ojbM图纸T.主图号) & " " & vbCrLf)
            strSql.Append("                AND 关系.CIID = 0")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    '数据删除操作
    Public Function Delete图纸关系(ByVal ojbM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            'strSql.Append("DELETE  FROM dbo.T图纸关系 " & vbCrLf)
            'strSql.Append("WHERE   ID = ( SELECT  DISTINCT " & vbCrLf)
            'strSql.Append("                        T图纸关系.ID " & vbCrLf)
            'strSql.Append("               FROM     dbo.T图纸关系 " & vbCrLf)
            'strSql.Append("                        INNER JOIN dbo.T图纸关系 B ON B.关系ID = T图纸关系.关系ID " & vbCrLf)
            'strSql.Append("                                                  AND B.CIID = 0 " & vbCrLf)
            'strSql.Append("                        LEFT JOIN dbo.T图纸关系 C ON C.ID = T图纸关系.CIID " & vbCrLf)
            'strSql.Append("               WHERE    T图纸关系.产品图号 =" & Utility.PFn_ChangeQuotation(ojbM图纸T.产品图号) & vbCrLf)
            'strSql.Append("                        AND B.产品图号  =" & Utility.PFn_ChangeQuotation(ojbM图纸T.主图号) & vbCrLf)
            'strSql.Append("                        AND ( C.产品图号 =" & Utility.PFn_ChangeQuotation(ojbM图纸T.上级图号) & vbCrLf)
            'strSql.Append("                              OR C.产品图号 IS NULL " & vbCrLf)
            'strSql.Append("                            ) " & vbCrLf)
            'strSql.Append("             ) " & vbCrLf)



            strSql.Append(" DELETE FROM dbo.T图纸关系 WHERE 关系ID=" & vbCrLf)
            strSql.Append(" (SELECT 关系ID FROM dbo.T图纸关系 Where " & vbCrLf)
            strSql.AppendFormat(" CIID='0'and 产品图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM图纸T.主图号) & ")")

            'SQLに戻る
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " LoadAll "

    '检索全部数据    Public Function LoadAllGrid(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  材料种类 , " & vbCrLf)
            strSql.Append("         材质 , " & vbCrLf)
            strSql.Append("         型号 , " & vbCrLf)
            strSql.Append("         长 , " & vbCrLf)
            strSql.Append("         宽 [宽（直径）] , " & vbCrLf)
            strSql.Append("         高 [高（厚度）] , " & vbCrLf)
            strSql.Append("         单件重量 , " & vbCrLf)
            strSql.Append("         数量 [数量（每套）] , " & vbCrLf)
            strSql.Append("         要求 , " & vbCrLf)
            strSql.Append("         备注 " & vbCrLf)
            strSql.Append(" FROM    dbo.T图纸管理 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadAll流转票(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  产品图号 " & vbCrLf)
            strSql.Append(" FROM     dbo.T流转票管理 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号1) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadAll工艺卡(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  产品图号 " & vbCrLf)
            strSql.Append(" FROM     dbo.T工艺卡 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号1) & vbCrLf)
            strSql.Append(" OR 上级图号=" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号1) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadAllexp(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("WITH    图纸" & vbCrLf)
            strSql.Append("          AS ( SELECT DISTINCT" & vbCrLf)
            strSql.Append("                        T图纸管理.产品图号 ," & vbCrLf)
            strSql.Append("                        M客户管理.客户名称 ," & vbCrLf)
            strSql.Append("                        品名 ," & vbCrLf)
            strSql.Append("                        材料代号 ," & vbCrLf)
            strSql.Append("                        图纸 ," & vbCrLf)
            strSql.Append("                        CC.上级图号 ," & vbCrLf)
            strSql.Append("                        长 ," & vbCrLf)
            strSql.Append("                        宽 ," & vbCrLf)
            strSql.Append("                        高 ," & vbCrLf)
            strSql.Append("                        单件重量 ," & vbCrLf)
            strSql.Append("                        数量 ," & vbCrLf)
            strSql.Append("                        orderID ," & vbCrLf)
            strSql.Append("                        T图纸管理.备注" & vbCrLf)
            strSql.Append("               FROM     dbo.T图纸管理" & vbCrLf)
            strSql.Append("                        INNER JOIN dbo.M客户管理 ON M客户管理.客户编号 = T图纸管理.客户编号" & vbCrLf)
            strSql.Append("                        INNER JOIN ( SELECT ddd.产品图号 上级图号 ," & vbCrLf)
            strSql.Append("                                            aaa.CIID ," & vbCrLf)
            strSql.Append("                                            CASE WHEN aaa.CIID = 0 THEN 0" & vbCrLf)
            strSql.Append("                                                 ELSE aaa.CIID - bbb.ID + 1" & vbCrLf)
            strSql.Append("                                            END ID ," & vbCrLf)
            strSql.Append("                                            aaa.ID orderID," & vbCrLf)
            strSql.Append("                                            aaa.产品图号 ," & vbCrLf)
            strSql.Append("                                            主号" & vbCrLf)
            strSql.Append("                                     FROM   dbo.T图纸关系 aaa" & vbCrLf)
            strSql.Append("                                            INNER JOIN ( SELECT" & vbCrLf)
            strSql.Append("                                                              ID ," & vbCrLf)
            strSql.Append("                                                              关系ID ," & vbCrLf)
            strSql.Append("                                                              产品图号 主号" & vbCrLf)
            strSql.Append("                                                         FROM T图纸关系" & vbCrLf)
            strSql.Append("                                                         WHERE" & vbCrLf)
            strSql.Append("                                                              产品图号 IN ( SELECT" & vbCrLf)
            strSql.Append("                                                              产品图号" & vbCrLf)
            strSql.Append("                                                              FROM" & vbCrLf)
            strSql.Append("                                                              dbo.T图纸管理" & vbCrLf)
            strSql.Append("                                                              WHERE" & vbCrLf)
            strSql.Append("                                                              1 = 1 )" & vbCrLf)
            strSql.Append("     AND T图纸关系.产品图号 IN ('" & objM图纸T.产品图号 & "')" & vbCrLf)
            strSql.Append("                                                       ) bbb ON bbb.关系ID = aaa.关系ID" & vbCrLf)
            strSql.Append("                                            LEFT JOIN T图纸关系 ddd ON aaa.CIID = ddd.ID" & vbCrLf)
            strSql.Append("                                   ) CC ON CC.产品图号 = T图纸管理.产品图号" & vbCrLf)
            strSql.Append("             )" & vbCrLf)
            strSql.Append("    SELECT  A.品名 ," & vbCrLf)
            strSql.Append("            CASE WHEN E.产品图号 IS NOT NULL THEN E.客户名称" & vbCrLf)
            strSql.Append("                 WHEN D.产品图号 IS NOT NULL THEN D.客户名称" & vbCrLf)
            strSql.Append("                 WHEN C.产品图号 IS NOT NULL THEN C.客户名称" & vbCrLf)
            strSql.Append("                 WHEN B.产品图号 IS NOT NULL THEN B.客户名称" & vbCrLf)
            strSql.Append("                 WHEN A.产品图号 IS NOT NULL THEN A.客户名称" & vbCrLf)
            strSql.Append("            END 客户名称 ," & vbCrLf)
            strSql.Append("            ROW_NUMBER() OVER ( ORDER BY A.产品图号 ) AS 序号 ," & vbCrLf)
            strSql.Append("            A.产品图号 主图号 ," & vbCrLf)
            strSql.Append("            B.产品图号 分图号 ," & vbCrLf)
            strSql.Append("            C.产品图号 小分图号 ," & vbCrLf)
            strSql.Append("            D.产品图号 小小分图号 ," & vbCrLf)
            strSql.Append("            E.产品图号 最小分图号 ," & vbCrLf)
            strSql.Append("            CASE WHEN E.产品图号 IS NOT NULL THEN E.材料代号" & vbCrLf)
            strSql.Append("                 WHEN D.产品图号 IS NOT NULL THEN D.材料代号" & vbCrLf)
            strSql.Append("                 WHEN C.产品图号 IS NOT NULL THEN C.材料代号" & vbCrLf)
            strSql.Append("                 WHEN B.产品图号 IS NOT NULL THEN B.材料代号" & vbCrLf)
            strSql.Append("                 WHEN A.产品图号 IS NOT NULL THEN A.材料代号" & vbCrLf)
            strSql.Append("            END 材料代号或名称 ," & vbCrLf)
            strSql.Append("            CASE WHEN E.产品图号 IS NOT NULL THEN E.长" & vbCrLf)
            strSql.Append("                 WHEN D.产品图号 IS NOT NULL THEN D.长" & vbCrLf)
            strSql.Append("                 WHEN C.产品图号 IS NOT NULL THEN C.长" & vbCrLf)
            strSql.Append("                 WHEN B.产品图号 IS NOT NULL THEN B.长" & vbCrLf)
            strSql.Append("                 WHEN A.产品图号 IS NOT NULL THEN A.长" & vbCrLf)
            strSql.Append("            END 长 ," & vbCrLf)
            strSql.Append("            CASE WHEN E.产品图号 IS NOT NULL THEN E.宽" & vbCrLf)
            strSql.Append("                 WHEN D.产品图号 IS NOT NULL THEN D.宽" & vbCrLf)
            strSql.Append("                 WHEN C.产品图号 IS NOT NULL THEN C.宽" & vbCrLf)
            strSql.Append("                 WHEN B.产品图号 IS NOT NULL THEN B.宽" & vbCrLf)
            strSql.Append("                 WHEN A.产品图号 IS NOT NULL THEN A.宽" & vbCrLf)
            strSql.Append("            END 宽 ," & vbCrLf)
            strSql.Append("            CASE WHEN E.产品图号 IS NOT NULL THEN E.高" & vbCrLf)
            strSql.Append("                 WHEN D.产品图号 IS NOT NULL THEN D.高" & vbCrLf)
            strSql.Append("                 WHEN C.产品图号 IS NOT NULL THEN C.高" & vbCrLf)
            strSql.Append("                 WHEN B.产品图号 IS NOT NULL THEN B.高" & vbCrLf)
            strSql.Append("                 WHEN A.产品图号 IS NOT NULL THEN A.高" & vbCrLf)
            strSql.Append("            END 高 ," & vbCrLf)
            strSql.Append("            CASE WHEN E.产品图号 IS NOT NULL THEN E.单件重量" & vbCrLf)
            strSql.Append("                 WHEN D.产品图号 IS NOT NULL THEN D.单件重量" & vbCrLf)
            strSql.Append("                 WHEN C.产品图号 IS NOT NULL THEN C.单件重量" & vbCrLf)
            strSql.Append("                 WHEN B.产品图号 IS NOT NULL THEN B.单件重量" & vbCrLf)
            strSql.Append("                 WHEN A.产品图号 IS NOT NULL THEN A.单件重量" & vbCrLf)
            strSql.Append("            END 单件重量 ," & vbCrLf)
            strSql.Append("            CASE WHEN E.产品图号 IS NOT NULL THEN E.数量" & vbCrLf)
            strSql.Append("                 WHEN D.产品图号 IS NOT NULL THEN D.数量" & vbCrLf)
            strSql.Append("                 WHEN C.产品图号 IS NOT NULL THEN C.数量" & vbCrLf)
            strSql.Append("                 WHEN B.产品图号 IS NOT NULL THEN B.数量" & vbCrLf)
            strSql.Append("                 WHEN A.产品图号 IS NOT NULL THEN A.数量" & vbCrLf)
            strSql.Append("            END [数量/1套] ," & vbCrLf)
            strSql.Append("            '' 类别 ," & vbCrLf)
            strSql.Append("            '' 外购或外协 ," & vbCrLf)
            strSql.Append("            CASE WHEN E.产品图号 IS NOT NULL THEN E.备注" & vbCrLf)
            strSql.Append("                 WHEN D.产品图号 IS NOT NULL THEN D.备注" & vbCrLf)
            strSql.Append("                 WHEN C.产品图号 IS NOT NULL THEN C.备注" & vbCrLf)
            strSql.Append("                 WHEN B.产品图号 IS NOT NULL THEN B.备注" & vbCrLf)
            strSql.Append("                 WHEN A.产品图号 IS NOT NULL THEN A.备注" & vbCrLf)
            strSql.Append("            END 备注" & vbCrLf)
            strSql.Append("    FROM    图纸 A" & vbCrLf)
            strSql.Append("            LEFT JOIN 图纸 B ON A.产品图号 = B.上级图号" & vbCrLf)
            strSql.Append("            LEFT JOIN 图纸 C ON B.产品图号 = C.上级图号" & vbCrLf)
            strSql.Append("            LEFT JOIN 图纸 D ON C.产品图号 = D.上级图号" & vbCrLf)
            strSql.Append("            LEFT JOIN 图纸 E ON D.产品图号 = E.上级图号" & vbCrLf)
            strSql.Append("    WHERE   A.上级图号 IS NULL " & vbCrLf)
            strSql.Append("    ORDER BY A.orderID,B.orderID,C.orderID,D.orderID,E.orderID   " & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadAllexp2(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT")
            strSql.Append("        图纸.产品图号 ,")
            strSql.Append("        品名 ,")
            strSql.Append("        图纸 ,")
            strSql.Append("        上级图号 ,")
            strSql.Append("        长 ,")
            strSql.Append("        宽 ,")
            strSql.Append("        高 ,")
            strSql.Append("        单件重量 ,")
            strSql.Append("        数量 ,")
            strSql.Append("        备注 ,")
            strSql.Append("        关系.ID orderID")
            strSql.Append(" FROM   dbo.T图纸关系 主关系")
            strSql.Append("        INNER  JOIN dbo.T图纸关系 关系 ON 关系.关系ID = 主关系.关系ID")
            strSql.Append("        LEFT  JOIN dbo.T图纸关系 上级关系 ON 上级关系.ID = 关系.CIID")
            strSql.Append("                                     AND 上级关系.关系ID = 关系.关系ID")
            strSql.Append("        INNER  JOIN dbo.T图纸管理 图纸 ON 主关系.产品图号 = 图纸.主图号")
            strSql.Append("                                    AND ( 图纸.上级图号 = 上级关系.产品图号")
            strSql.Append("                                          OR 上级关系.产品图号 IS NULL")
            strSql.Append("                                        )")
            strSql.Append("                                    AND 图纸.产品图号 = 关系.产品图号")
            strSql.Append(" WHERE  主关系.CIID = 0")
            strSql.Append("        AND 主关系.产品图号 IN ('" & objM图纸T.产品图号 & "')" & vbCrLf)
            strSql.Append(" ORDER BY orderID")
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadAll(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  * " & vbCrLf)
            'strSql.Append(" 	产品图号" & vbCrLf)
            'strSql.Append(" 	,图纸名称 " & vbCrLf)
            'strSql.Append(" 	,图纸型号" & vbCrLf)
            'strSql.Append(" 	,维护周期" & vbCrLf)
            'strSql.Append(" 	,上次维护日期" & vbCrLf)
            'strSql.Append(" 	,使用状态" & vbCrLf)
            'strSql.Append(" 	,使用者编号" & vbCrLf)
            'strSql.Append(" 	,使用者姓名 " & vbCrLf)
            'strSql.Append(" 	,使用者部门名称" & vbCrLf)
            'strSql.Append(" 	,生产日期" & vbCrLf)
            'strSql.Append(" 	,存放区域 " & vbCrLf)
            'strSql.Append(" 	,维护负责人编号 " & vbCrLf)
            'strSql.Append(" 	,维护负责人姓名 " & vbCrLf)
            'strSql.Append(" 	,维护部门名称" & vbCrLf)
            'strSql.Append(" 	,负责人电话 " & vbCrLf)
            'strSql.Append(" 	,维护内容 " & vbCrLf)
            'strSql.Append(" 	,图纸图片 " & vbCrLf)
            'strSql.Append(" 	,登录者" & vbCrLf)
            'strSql.Append(" 	,登录日期 " & vbCrLf)
            'strSql.Append(" 	,更新者  " & vbCrLf)
            'strSql.Append(" 	,更新日期  " & vbCrLf)
            strSql.Append(" FROM T图纸管理")
            '检索条件 设定
            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadAll图纸(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT " & vbCrLf)
            strSql.Append("        产品图号 , " & vbCrLf)
            strSql.Append("        图纸版本编号 , " & vbCrLf)
            strSql.Append("        品名 , " & vbCrLf)
            strSql.Append("        图纸 , " & vbCrLf)
            strSql.Append("        T图纸管理.客户编号 , " & vbCrLf)
            strSql.Append("        M客户管理.客户名称 , " & vbCrLf)
            strSql.Append("        数量 , " & vbCrLf)
            strSql.Append("        M原材料信息.原材料编号,M原材料信息.原材料名称 , " & vbCrLf)
            strSql.Append("        VM材料种类.名称 材料种类 , " & vbCrLf)
            strSql.Append("        M原材料信息.材料代号 , " & vbCrLf)
            strSql.Append("        VM材质.名称 材质 , " & vbCrLf)
            strSql.Append("        T图纸管理.长 , " & vbCrLf)
            strSql.Append("        T图纸管理.宽 , " & vbCrLf)
            strSql.Append("        T图纸管理.高 , " & vbCrLf)
            strSql.Append("        单件重量 , " & vbCrLf)
            strSql.Append("        要求 , " & vbCrLf)
            strSql.Append("        图纸 , " & vbCrLf)
            strSql.Append("        创建日期, " & vbCrLf)
            strSql.Append("        更新日期, " & vbCrLf)
            strSql.Append("        备注,vm图纸状态.名称 图纸状态 " & vbCrLf)
            strSql.Append(" FROM   dbo.T图纸管理 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = T图纸管理.客户编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M原材料信息 ON M原材料信息.原材料编号 = T图纸管理.原材料编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM材料种类 ON dbo.VM材料种类.区分 = M原材料信息.材料种类 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM材质 ON dbo.VM材质.区分 = M原材料信息.材质 " & vbCrLf)
            strSql.Append("        LEFT JOIN vm图纸状态 ON dbo.vm图纸状态.区分 = T图纸管理.图纸状态 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号) & vbCrLf)
            If objM图纸T.产品图号 <> String.Empty Then
                strSql.Append(" AND 主图号=" & Utility.PFn_ChangeQuotation(objM图纸T.主图号) & vbCrLf)
            End If
            If objM图纸T.上级图号 <> String.Empty Then

                strSql.Append(" AND 上级图号=" & Utility.PFn_ChangeQuotation(objM图纸T.上级图号) & vbCrLf)
            End If

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function LoadAll图纸1(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT " & vbCrLf)
            strSql.Append("        T图纸管理.客户编号 , " & vbCrLf)
            strSql.Append("        M客户管理.客户名称  " & vbCrLf)
            strSql.Append(" FROM   dbo.T图纸管理 " & vbCrLf)
            strSql.Append("        INNER JOIN dbo.M客户管理 ON M客户管理.客户编号 = T图纸管理.客户编号 " & vbCrLf)

            '检索条件 设定
            strSql.Append(" WHERE 主图号=" & Utility.PFn_ChangeQuotation(objM图纸T.主图号) & vbCrLf)
            strSql.Append(" AND 产品图号=" & Utility.PFn_ChangeQuotation(objM图纸T.上级图号) & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function LoadAll密度(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  材质 , ")
            strSql.Append("         密度 ")
            strSql.Append(" FROM    dbo.M材质密度 ")
            '检索条件 设定
            strSql.Append(" WHERE 材质=" & Utility.PFn_ChangeQuotation(objM图纸T.材质) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region

#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	产品图号" & vbCrLf)

            strSql.Append(" 	,品名" & vbCrLf)
            strSql.Append(" FROM T图纸管理")
            '检索条件 设定
            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号) & vbCrLf)

            If objM图纸T.主图号 <> String.Empty Then
                strSql.Append(" and 主图号=" & Utility.PFn_ChangeQuotation(objM图纸T.主图号) & vbCrLf)
            End If

            If objM图纸T.上级图号 <> String.Empty Then
                strSql.Append(" and 上级图号=" & Utility.PFn_ChangeQuotation(objM图纸T.上级图号) & vbCrLf)
            End If




            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadIDMax() As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT ISNULL(MAX(ID),0) ID,ISNULL(MAX(关系ID),0) 关系ID FROM dbo.T图纸关系  " & vbCrLf)
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadByPKey产品图号(ByVal cls图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT * FROM dbo.T图纸关系" & vbCrLf)
            strSql.Append("WHERE   CIID=0 " & vbCrLf)
            strSql.Append("   AND 产品图号 in(" & Utility.PFn_ChangeQuotation(cls图纸T.产品图号) & ")" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region

#Region " LoadTree"

    '检索全部数据
    Public Function LoadTree(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  ddd.产品图号 上级图号 ,")
            strSql.Append("         aaa.ID ,")
            strSql.Append("         aaa.CIID ,")
            strSql.Append("         aaa.产品图号 ,")
            strSql.Append("         主号")
            strSql.Append(" FROM    dbo.T图纸关系 aaa")
            strSql.Append("         INNER JOIN ( SELECT ID ,")
            strSql.Append("                             关系ID ,")
            strSql.Append("                             产品图号 主号")
            strSql.Append("                      FROM   T图纸关系")
            strSql.Append("                      WHERE  产品图号 = " & Utility.PFn_ChangeQuotation(objM图纸T.产品图号) & " AND ciid='0'")
            strSql.Append("                    ) bbb ON bbb.关系ID = aaa.关系ID")
            strSql.Append("         LEFT JOIN T图纸关系 ddd ON aaa.CIID = ddd.ID ORDER BY   aaa.ID")
            '检索条件 设定

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function


#End Region

#Region " 一栏页面用"
    '检索全部数据    Public Function LoadByWhere2(ByVal objM图纸T As M图纸T, ByVal intCount As Integer) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            'strSql.Append(" SELECT DISTINCT TOP " & intCount & "" & vbCrLf)
            'strSql.Append("        'false' 选择,")
            'strSql.Append("        T图纸管理.产品图号 , " & vbCrLf)
            'strSql.Append("        图纸版本编号 , " & vbCrLf)
            'strSql.Append("        品名 , " & vbCrLf)
            'strSql.Append("        图纸 , " & vbCrLf)
            'strSql.Append("        数量 [数量（每套）] , " & vbCrLf)
            'strSql.Append("        M客户管理.客户编号 , " & vbCrLf)
            'strSql.Append("        M客户管理.客户名称 , " & vbCrLf)
            'strSql.Append("        VM材料种类.名称 材料种类 , " & vbCrLf)
            'strSql.Append("        VM材质.名称 材质 , " & vbCrLf)
            'strSql.Append("        T图纸管理.材料代号 , " & vbCrLf)
            'strSql.Append("        单件重量 , " & vbCrLf)
            'strSql.Append("        T图纸管理.长 , " & vbCrLf)
            'strSql.Append("        T图纸管理.宽 [宽（外径）] , " & vbCrLf)
            'strSql.Append("        T图纸管理.高 [高（厚度）] , " & vbCrLf)
            'strSql.Append("        要求 , " & vbCrLf)
            'strSql.Append("        备注 , " & vbCrLf)
            'strSql.Append("       CC.上级图号 , " & vbCrLf)
            'strSql.Append("        T图纸管理.主图号, " & vbCrLf)
            'strSql.Append("        T图纸管理.创建日期,  " & vbCrLf)
            'strSql.Append("        T图纸管理.更新日期,  " & vbCrLf)
            'strSql.Append("        VM图纸状态.名称 图纸状态 ,cc.orderId " & vbCrLf)
            'strSql.Append(" FROM   dbo.T图纸管理 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = T图纸管理.客户编号 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.VM材料种类 ON VM材料种类.区分 = T图纸管理.材料种类 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.VM材质 ON dbo.VM材质.区分 = T图纸管理.材质 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.VM图纸状态 ON dbo.VM图纸状态.区分 = T图纸管理.图纸状态 " & vbCrLf)
            'strSql.Append("        INNER JOIN ( SELECT DISTINCT ddd.产品图号 上级图号 , " & vbCrLf)
            'strSql.Append("                            aaa.CIID , " & vbCrLf)
            'strSql.Append("                            CASE WHEN aaa.CIID = 0 THEN 0 " & vbCrLf)
            'strSql.Append("                                 ELSE aaa.CIID - bbb.ID + 1 " & vbCrLf)
            'strSql.Append("                            END ID , " & vbCrLf)
            'strSql.Append("                            aaa.产品图号 , " & vbCrLf)
            'strSql.Append("                            主图号 ,aaa.ID orderId" & vbCrLf)
            'strSql.Append("                     FROM   dbo.T图纸关系 aaa " & vbCrLf)
            'strSql.Append("                            INNER JOIN ( SELECT DISTINCT ID , " & vbCrLf)
            'strSql.Append("                                                关系ID , " & vbCrLf)
            'strSql.Append("                                                产品图号 主图号 " & vbCrLf)
            'strSql.Append("                                         FROM   T图纸关系 " & vbCrLf)
            'strSql.Append("                                         WHERE  产品图号 IN ( SELECT " & vbCrLf)
            'strSql.Append("                                                              产品图号 " & vbCrLf)
            'strSql.Append("                                                          FROM " & vbCrLf)
            'strSql.Append("                                                              dbo.T图纸管理 " & vbCrLf)
            'strSql.Append("                                                          WHERE " & vbCrLf)
            'strSql.Append("                                                              1 = 1  " & vbCrLf)
            'If (objM图纸T.产品图号 <> String.Empty) Then
            '    strSql.Append(" AND 产品图号 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号, True) & "%'" & vbCrLf)
            'End If
            'If (objM图纸T.品名 <> String.Empty) Then
            '    strSql.Append(" AND 品名 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.品名, True) & "%'" & vbCrLf)
            'End If

            'If (objM图纸T.客户编号 <> String.Empty) Then
            '    strSql.Append(" AND 客户编号 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.客户编号, True) & "%'" & vbCrLf)
            'End If

            'If (objM图纸T.图纸状态 <> String.Empty) Then
            '    strSql.Append(" AND 图纸状态 =" & Utility.PFn_ChangeQuotation(objM图纸T.图纸状态) & "" & vbCrLf)
            'End If
            'strSql.Append("                                               ) AND T图纸关系.CIID = 0 " & vbCrLf)
            'strSql.Append("                                       ) bbb ON bbb.关系ID = aaa.关系ID " & vbCrLf)
            'strSql.Append("                            LEFT JOIN T图纸关系 ddd ON aaa.CIID = ddd.ID " & vbCrLf)
            'strSql.Append("                   ) CC ON CC.产品图号 = T图纸管理.产品图号 AND (cc.上级图号=T图纸管理.上级图号 OR cc.上级图号 IS NULL OR T图纸管理.上级图号 IS null)AND CC.主图号 = T图纸管理.主图号  ORDER BY cc.orderId  " & vbCrLf)
            ''检索条件 设定


            strSql.Append(" SELECT DISTINCT " & vbCrLf)
            strSql.Append("        'false' 选择 , " & vbCrLf)
            strSql.Append("        图纸管理.产品图号 , " & vbCrLf)
            strSql.Append("        图纸版本编号 , " & vbCrLf)
            strSql.Append("        品名 , " & vbCrLf)
            strSql.Append("        图纸 , " & vbCrLf)
            strSql.Append("        数量 [数量（每套）] , " & vbCrLf)
            strSql.Append("        M客户管理.客户编号 , " & vbCrLf)
            strSql.Append("        M客户管理.客户名称 , " & vbCrLf)
            strSql.Append("        M原材料信息.原材料名称 原材料名称 , " & vbCrLf)
            strSql.Append("        VM材料种类.名称 材料种类 , " & vbCrLf)
            strSql.Append("        VM材质.名称 材质 , " & vbCrLf)
            strSql.Append("        M原材料信息.材料代号 , " & vbCrLf)
            strSql.Append("        单件重量 , " & vbCrLf)
            strSql.Append("        图纸管理.长 , " & vbCrLf)
            strSql.Append("        图纸管理.宽 [宽（外径）] , " & vbCrLf)
            strSql.Append("        图纸管理.高 [高（厚度）] , " & vbCrLf)
            strSql.Append("        要求 , " & vbCrLf)
            strSql.Append("        备注 , " & vbCrLf)
            strSql.Append("        上级关系.产品图号 上级图号 , " & vbCrLf)
            strSql.Append("        图纸管理.主图号 , " & vbCrLf)
            strSql.Append("        图纸管理.创建日期 , " & vbCrLf)
            strSql.Append("        图纸管理.更新日期 , " & vbCrLf)
            strSql.Append("        VM图纸状态.名称 图纸状态 , " & vbCrLf)
            strSql.Append("        图纸.ID orderId  " & vbCrLf)

            strSql.Append(" FROM   dbo.T图纸关系 图纸 " & vbCrLf)
            strSql.Append("        INNER JOIN dbo.T图纸关系 关系 ON 图纸.关系ID = 关系.关系ID " & vbCrLf)
            strSql.Append("                                   AND 关系.CIID = 0 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸关系 上级关系 ON 上级关系.ID = 图纸.CIID " & vbCrLf)
            strSql.Append("                                    AND 图纸.关系ID = 上级关系.关系ID " & vbCrLf)
            strSql.Append("        INNER JOIN dbo.T图纸管理 图纸管理 ON 图纸管理.产品图号 = 图纸.产品图号 " & vbCrLf)
            strSql.Append("                                     AND 图纸管理.主图号 = 关系.产品图号 " & vbCrLf)
            strSql.Append("                                     AND ( 图纸管理.上级图号 = 上级关系.产品图号 " & vbCrLf)
            strSql.Append("                                           OR 上级关系.产品图号 IS NULL " & vbCrLf)
            strSql.Append("                                         ) " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M原材料信息 ON M原材料信息.原材料编号 = 图纸管理.原材料编号 " & vbCrLf)
       
            strSql.Append("        LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = 图纸管理.客户编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM材料种类 ON VM材料种类.区分 = M原材料信息.材料种类 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM材质 ON dbo.VM材质.区分 = M原材料信息.材质 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM图纸状态 ON dbo.VM图纸状态.区分 = 图纸管理.图纸状态 " & vbCrLf)
            strSql.Append(" WHERE  1 = 1 " & vbCrLf)
            If (objM图纸T.产品图号 <> String.Empty) Then
                strSql.Append(" AND 关系.产品图号 IN (SELECT distinct bb.产品图号 FROM dbo.T图纸关系 aa INNER JOIN dbo.T图纸关系 bb ON bb.关系ID = aa.关系ID AND bb.CIID=0 WHERE aa.产品图号  LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号, True) & "%')" & vbCrLf)
                'strSql.Append(" AND 图纸管理.产品图号 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号, True) & "%'" & vbCrLf)
            End If
            If (objM图纸T.品名 <> String.Empty) Then
                strSql.Append(" AND 图纸管理.品名 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.品名, True) & "%'" & vbCrLf)
            End If

            If (objM图纸T.客户编号 <> String.Empty) Then
                strSql.Append(" AND 图纸管理.客户编号 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.客户编号, True) & "%'" & vbCrLf)
            End If

            If (objM图纸T.图纸状态 <> String.Empty) Then
                strSql.Append(" AND 图纸状态 =" & Utility.PFn_ChangeQuotation(objM图纸T.图纸状态) & "" & vbCrLf)
            End If

            Return strSql.ToString()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadByWhereInfo(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  材料种类 ,")
            strSql.Append("         材质 ,")
            strSql.Append("         原材料编号 ,")
            strSql.Append("         单件重量 ,")
            strSql.Append("         长 ,")
            strSql.Append("         宽  [宽（外径）] ,")
            strSql.Append("         高  [高（厚度）],")
            'strSql.Append("         数量 ,")
            strSql.Append("         要求 ,")
            strSql.Append("         备注")
            strSql.Append(" FROM    T图纸管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM图纸T.产品图号 <> String.Empty) Then
                strSql.Append(" AND 产品图号 = '" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号, True) & "'" & vbCrLf)
            End If

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadByWhere1(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT distinct 产品图号 ,")
            strSql.Append("         图纸版本编号 ,")
            strSql.Append("         品名 ,")
            strSql.Append("         M客户管理.客户编号 ,")
            strSql.Append("         M客户管理.客户名称 ")
            '  strSql.Append("         图纸")
            strSql.Append(" FROM    dbo.T图纸管理")
            strSql.Append("         INNER JOIN dbo.M客户管理 ON M客户管理.客户编号 = T图纸管理.客户编号")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM图纸T.产品图号 <> String.Empty) Then
                strSql.Append(" AND 产品图号 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号, True) & "%'" & vbCrLf)
            End If
            If (objM图纸T.品名 <> String.Empty) Then
                strSql.Append(" AND 品名 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.品名, True) & "%'" & vbCrLf)
            End If

            If (objM图纸T.客户编号 <> String.Empty) Then
                strSql.Append(" AND T图纸管理.客户编号 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.客户编号, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 产品图号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region

#Region " LoadByWhere"

    '检索全部数据    Public Function LoadByWhere(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	产品图号" & vbCrLf)
            strSql.Append(" 	,图纸名称 " & vbCrLf)
            strSql.Append(" 	,图纸型号" & vbCrLf)
            strSql.Append(" 	,生产日期" & vbCrLf)
            strSql.Append(" 	,VM使用状态.名称 AS 使用状态" & vbCrLf)
            strSql.Append(" 	,维护周期" & vbCrLf)
            strSql.Append(" 	,上次维护日期" & vbCrLf)
            strSql.Append(" 	,存放区域" & vbCrLf)
            strSql.Append(" FROM M图纸管理 ")
            strSql.Append("      LEFT JOIN VM使用状态 ON M图纸管理.使用状态=VM使用状态.区分")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM图纸T.产品图号 <> String.Empty) Then
                strSql.Append(" AND 产品图号 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.产品图号, True) & "%'" & vbCrLf)
            End If
            'If (objM图纸T.图纸名称 <> String.Empty) Then
            '    strSql.Append(" AND 图纸名称 LIKE '%" & Utility.PFn_ChangeQuotation(objM图纸T.图纸名称, True) & "%'" & vbCrLf)
            'End If
            strSql.Append(" ORDER BY 产品图号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadBy订单"

    '检索全部数据    Public Function LoadBy订单(ByVal objM图纸T As M图纸T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT  订单编号" & vbCrLf)
            strSql.Append("FROM    dbo.B订单管理" & vbCrLf)
            strSql.Append("WHERE   产品图号 IN ( SELECT DISTINCT")
            strSql.Append("                            aaa.产品图号")
            strSql.Append("                  FROM      dbo.T图纸关系")
            strSql.Append("                            INNER JOIN dbo.T图纸关系 aaa ON aaa.关系ID = T图纸关系.关系ID")
            strSql.Append("                                                        AND aaa.CIID = 0")
            strSql.Append("                  WHERE     aaa.产品图号 = " & Utility.PFn_ChangeQuotation(objM图纸T.主图号))
            strSql.Append(")")
            strSql.Append("        AND 订单状态 = '2'")
            strSql.Append("        ")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadDataByWhere_Proc"

    '检索全部数据    Public Function LoadDataByWhere_Proc(ByVal objM图纸T As M图纸T) As SqlParameter()
        Dim parm(5) As SqlParameter
        parm(0) = New SqlParameter("@主图号", SqlDbType.NVarChar)
        parm(1) = New SqlParameter("@上级图号", SqlDbType.NVarChar)
        parm(2) = New SqlParameter("@产品图号old", SqlDbType.NVarChar)
        parm(3) = New SqlParameter("@产品图号new", SqlDbType.NVarChar)
        parm(4) = New SqlParameter("@订单编号", SqlDbType.NVarChar)
        parm(5) = New SqlParameter("@变量", SqlDbType.NVarChar)
        If Not String.IsNullOrEmpty(objM图纸T.主图号) Then
            parm(0).Value = objM图纸T.主图号
        Else
            parm(0).Value = DBNull.Value
        End If

        If Not String.IsNullOrEmpty(objM图纸T.上级图号) Then
            parm(1).Value = objM图纸T.上级图号
        Else
            parm(1).Value = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(objM图纸T.产品图号1) Then
            parm(2).Value = objM图纸T.产品图号1
        Else
            parm(2).Value = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(objM图纸T.产品图号) Then
            parm(3).Value = objM图纸T.产品图号
        Else
            parm(3).Value = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(objM图纸T.订单编号) Then
            parm(4).Value = objM图纸T.订单编号
        Else
            parm(4).Value = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(objM图纸T.变量) Then
            parm(5).Value = objM图纸T.变量
        Else
            parm(5).Value = DBNull.Value
        End If
        Return parm

    End Function

#End Region
End Class
