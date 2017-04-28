Imports System.Text

Public Class DalM外协品库存T

#Region " Insert "

#End Region

#Region " Update "

    '数据更新操作 
#End Region

#Region " Delete "

    '数据删除操作 
#End Region

#Region " LoadAllB "

    '检索全部数据
    Public Function LoadAllB(ByVal clsM外协品库存T As B外协品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("    SELECT  库存.订单编号 ," & vbCrLf)
            strSql.Append("            库存.主图号 ," & vbCrLf)
            strSql.Append("            库存.上级图号 ," & vbCrLf)
            strSql.Append("            库存.分图号 ," & vbCrLf)
            strSql.Append("            库存.工序编号 ," & vbCrLf)
            strSql.Append("            流转票.工序名称 ," & vbCrLf)
            strSql.Append("            库存.半成品种类 半成品种类编号 ," & vbCrLf)
            strSql.Append("            VM半成品种类.名称 半成品种类名称 ," & vbCrLf)
            strSql.Append("            M货位管理.货位名称 库存区域 ," & vbCrLf)
            strSql.Append("            库存.库存数量" & vbCrLf)
            strSql.Append("    FROM    dbo.Z半成品库存 库存" & vbCrLf)
            strSql.Append("            LEFT  JOIN dbo.T图纸管理 图纸 ON 库存.主图号 = 图纸.产品图号" & vbCrLf)
            strSql.Append("            LEFT  JOIN dbo.T图纸管理 分图纸 ON 库存.分图号 = 分图纸.产品图号" & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M客户管理 客户 ON 客户.客户编号 = 图纸.客户编号" & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.T流转票管理 流转票 ON 流转票.产品图号 = 分图纸.产品图号" & vbCrLf)
            strSql.Append("                                        AND 流转票.工序编号 = 库存.工序编号" & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.VM半成品种类 ON VM半成品种类.区分 = 库存.半成品种类" & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M货位管理 ON 库存.库存区域 = M货位管理.货位编号" & vbCrLf)
            'strSql.Append("    WHERE   库存.订单编号 = N'20161019 ';" & vbCrLf)
            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 库存.订单编号 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.订单编号) & vbCrLf)
            strSql.Append("   AND 库存.主图号 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.主图号) & vbCrLf)
            strSql.Append("   AND 库存.上级图号 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.上级图号) & vbCrLf)
            strSql.Append("   AND 库存.分图号 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.产品图号) & vbCrLf)
            strSql.Append("   AND 流转票.工序编号 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.外协工序) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPKey "

    '检索全部数据
    Public Function LoadByPKey(ByVal clsM外协品库存T As B外协品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            ''strSql.Append("SELECT 制造批量号, " & vbCrLf)
            ''strSql.Append("       部品番号, " & vbCrLf)
            ''strSql.Append("       制造区分, " & vbCrLf)
            ''strSql.Append("       库存数量, " & vbCrLf)
            ''strSql.Append("       库存状态 " & vbCrLf)
            ''strSql.Append("FROM   库存表")

            'strSql.Append(GetSql)

            'strSql.Append("SELECT   a.制造批量号, " & vbCrLf)
            'strSql.Append("         a.部品番号, " & vbCrLf)
            'strSql.Append("         a.制造区分, " & vbCrLf)
            'strSql.Append("         SUM(a.在库数量) AS 在库数量, " & vbCrLf)
            'strSql.Append("         a.库存状态 " & vbCrLf)
            'strSql.Append("FROM     tmp库存 a " & vbCrLf)

            'strSql.Append(" WHERE 1=1 ") 'T车型库存)
            ''If clsM外协品库存T.制造批量号 <> String.Empty Then
            ''    strSql.Append(" AND a.制造批量号 ='" & Utility.PFn_ChangeQuotation(clsM外协品库存T.制造批量号) & "'" & vbCrLf)
            ''End If
            ''If clsM外协品库存T.制造区分 <> String.Empty Then
            ''    strSql.Append(" AND a.制造区分 ='" & Utility.PFn_ChangeQuotation(clsM外协品库存T.制造区分) & "'" & vbCrLf)
            ''End If
            ''If clsM外协品库存T.部品番号 <> String.Empty Then
            ''    strSql.Append(" AND a.部品番号 ='" & Utility.PFn_ChangeQuotation(clsM外协品库存T.部品番号) & "'" & vbCrLf)
            ''End If

            'strSql.Append("GROUP BY a.制造批量号,a.部品番号,a.制造区分,a.库存状态")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal clsM外协品库存T As B外协品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT distinct 0 as 选择, 库存.订单编号 , " & vbCrLf)
            strSql.Append("        客户.客户名称 , " & vbCrLf)
            strSql.Append("       库存.主图号 , " & vbCrLf)
            strSql.Append("       库存.上级图号 , " & vbCrLf)
            strSql.Append("       库存.分图号 , " & vbCrLf)
            strSql.Append("        分图纸.品名 产品名称 , " & vbCrLf)
            strSql.Append("        流转票.工序编号 , " & vbCrLf)
            strSql.Append("        流转票.工序名称 , " & vbCrLf)
            strSql.Append("        库存数量 , " & vbCrLf)
            strSql.Append("        VM半成品种类.名称 半成品种类 , " & vbCrLf)
            strSql.Append("        M货位管理.货位名称 库存区域 " & vbCrLf)
            strSql.Append("FROM    dbo.Z半成品库存 库存 " & vbCrLf)
            strSql.Append("        left  JOIN dbo.T图纸管理 图纸 ON 库存.主图号 = 图纸.产品图号 " & vbCrLf)
            strSql.Append("        left  JOIN dbo.T图纸管理 分图纸 ON 库存.分图号 = 分图纸.产品图号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M客户管理 客户 ON 客户.客户编号 = 图纸.客户编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T流转票管理 流转票 ON 流转票.产品图号 = 分图纸.产品图号 " & vbCrLf)
            strSql.Append("                                    AND 流转票.工序编号 = 库存.工序编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM半成品种类 ON VM半成品种类.区分 = 库存.半成品种类 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M货位管理 ON 库存.库存区域 = M货位管理.货位编号  " & vbCrLf)
            strSql.Append("WHERE    1 = 1 " & vbCrLf)

            If clsM外协品库存T.产品图号 <> String.Empty Then
                strSql.Append(" AND 库存.分图号 like '" & Utility.PFn_ChangeQuotation(clsM外协品库存T.产品图号, True) & "%'" & vbCrLf)
            End If

            If clsM外协品库存T.订单编号 <> String.Empty Then
                strSql.Append(" AND 库存.订单编号 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.订单编号) & vbCrLf)
            End If

            If clsM外协品库存T.外协工序 <> String.Empty Then
                strSql.Append(" AND 流转票.工序名称 like '%" & Utility.PFn_ChangeQuotation(clsM外协品库存T.外协工序, True) & "%'" & vbCrLf)
            End If

            If clsM外协品库存T.客户编号 <> String.Empty Then
                strSql.Append(" AND 图纸.客户编号 =  " & Utility.PFn_ChangeQuotation(clsM外协品库存T.客户编号) & vbCrLf)
            End If


            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " SetData "

    '检索全部数据
    Public Function SetData(ByVal clsM外协品库存T As B外协品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("    SELECT DISTINCT 库存.订单编号 ," & vbCrLf)
            strSql.Append("            库存.主图号 ," & vbCrLf)
            strSql.Append("            库存.分图号 ," & vbCrLf)
            strSql.Append("            库存.工序编号 ," & vbCrLf)
            strSql.Append("            流转票.工序名称 ," & vbCrLf)
            strSql.Append("            库存.半成品种类 半成品种类编号 ," & vbCrLf)
            strSql.Append("            VM半成品种类.名称 半成品种类名称 ," & vbCrLf)
            strSql.Append("            库存.库存数量 ," & vbCrLf)
            strSql.Append("            M货位管理.货位名称 库存区域  " & vbCrLf)
            strSql.Append("    FROM    dbo.Z半成品库存 库存" & vbCrLf)
            strSql.Append("            LEFT  JOIN dbo.T图纸管理 图纸 ON 库存.主图号 = 图纸.主图号" & vbCrLf)
            strSql.Append("            LEFT  JOIN dbo.T图纸管理 分图纸 ON 库存.分图号 = 分图纸.产品图号" & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M客户管理 客户 ON 客户.客户编号 = 图纸.客户编号" & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.T流转票管理 流转票 ON 流转票.产品图号 = 分图纸.产品图号" & vbCrLf)
            strSql.Append("                                        AND 流转票.工序编号 = 库存.工序编号" & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.VM半成品种类 ON VM半成品种类.区分 = 库存.半成品种类" & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M货位管理 ON 库存.库存区域 = M货位管理.货位编号" & vbCrLf)
            ' strSql.Append("    WHERE   库存.订单编号 = N'20161019 ';" & vbCrLf)
            strSql.Append("WHERE    1 = 1 " & vbCrLf)
            If clsM外协品库存T.订单编号 <> String.Empty Then
                strSql.Append(" AND 库存.订单编号 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.订单编号) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "库存Sql"

    Private Function GetSql() As String

        Dim strSql As New StringBuilder(System.String.Empty)

        Try
            'strSql.Append("WITH tmp库存 " & vbCrLf)
            'strSql.Append("     AS (SELECT   a.制造批量号, " & vbCrLf)
            'strSql.Append("                  a.部品番号, " & vbCrLf)
            'strSql.Append("                  b.客户编号, " & vbCrLf)
            'strSql.Append("                  c.客户名称, " & vbCrLf)
            'strSql.Append("                  e.金型番号名称 AS 型番, " & vbCrLf)
            'strSql.Append("                  a.制造区分, " & vbCrLf)
            'strSql.Append("                  a.库存状态 AS 库存状态cd, " & vbCrLf)
            'strSql.Append("                  f.名称 AS 库存状态, " & vbCrLf)
            'strSql.Append("                  Isnull(SUM(a.库存数量),0) AS 在库数量 " & vbCrLf)
            'strSql.Append("         FROM     库存表 a " & vbCrLf)
            'strSql.Append("                  LEFT JOIN m部品管理 b " & vbCrLf)
            'strSql.Append("                    ON a.部品番号 = b.部品番号 " & vbCrLf)
            'strSql.Append("                  LEFT JOIN m客户管理 c " & vbCrLf)
            'strSql.Append("                    ON b.客户编号 = c.客户编号 " & vbCrLf)
            'strSql.Append("                  LEFT JOIN 生产计划 d " & vbCrLf)
            'strSql.Append("                    ON a.制造批量号 = d.制造批量号 " & vbCrLf)
            'strSql.Append("                  LEFT JOIN m金型番号 e " & vbCrLf)
            'strSql.Append("                    ON a.金型番号 = e.金型番号cd " & vbCrLf)
            'strSql.Append("                  LEFT JOIN vm库存状态 f " & vbCrLf)
            'strSql.Append("                    ON a.库存状态 = f.区分 " & vbCrLf)
            'strSql.Append("         WHERE    a.制造区分 = '1' " & vbCrLf)
            ''strSql.Append("                  AND a.库存状态 <> 4 " & vbCrLf)
            'strSql.Append("         GROUP BY a.制造批量号,a.制造区分,a.部品番号,b.客户编号,c.客户名称,e.金型番号名称,f.名称,a.库存状态 " & vbCrLf)
            'strSql.Append("         UNION  " & vbCrLf)
            'strSql.Append("         SELECT   a.制造批量号, " & vbCrLf)
            'strSql.Append("                  a.部品番号, " & vbCrLf)
            'strSql.Append("                  c.客户编号, " & vbCrLf)
            'strSql.Append("                  d.客户名称, " & vbCrLf)
            'strSql.Append("                  '' AS 型番, " & vbCrLf)
            'strSql.Append("                  a.制造区分, " & vbCrLf)
            'strSql.Append("                  a.库存状态 AS 库存状态cd, " & vbCrLf)
            'strSql.Append("                  e.名称 AS 库存状态, " & vbCrLf)
            'strSql.Append("                  Isnull(SUM(a.库存数量),0) AS 在库数量 " & vbCrLf)
            'strSql.Append("         FROM     库存表 a " & vbCrLf)
            'strSql.Append("                  LEFT JOIN m组立品 c " & vbCrLf)
            'strSql.Append("                    ON a.部品番号 = c.组立部番 " & vbCrLf)
            'strSql.Append("                  LEFT JOIN m客户管理 d " & vbCrLf)
            'strSql.Append("                    ON c.客户编号 = d.客户编号 " & vbCrLf)
            'strSql.Append("                  LEFT JOIN vm库存状态 e " & vbCrLf)
            'strSql.Append("                    ON a.库存状态 = e.区分 " & vbCrLf)
            'strSql.Append("         WHERE    a.制造区分 = '2' " & vbCrLf)
            'strSql.Append("         GROUP BY a.制造批量号,a.制造区分,a.部品番号,c.客户编号,d.客户名称,e.名称,a.库存状态) " & vbCrLf)



            Return strSql.ToString()
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadLevel0 "

    '检索全部数据
    Public Function LoadLevel0(ByVal clsM外协品库存T As B外协品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            '    strSql.Append("SELECT  0 as 选择, " & vbCrLf)
            '    strSql.Append("       外协品库存表.外协品编号 AS 外协品编号, " & vbCrLf)
            '    strSql.Append("       M客户管理.客户名称 AS 客户名称, " & vbCrLf)
            '    strSql.Append("       外协品库存表.产品图号 AS 产品图号, " & vbCrLf)
            '    strSql.Append("       T图纸管理.品名 AS 产品名称, " & vbCrLf)
            '    strSql.Append("       外协品库存表.订单编号 AS 订单编号, " & vbCrLf)
            '    strSql.Append("       外协品库存表.外协工序 AS 外协工序, " & vbCrLf)
            '    strSql.Append("       外协品库存表.外协加工数量 AS 外协加工数量, " & vbCrLf)
            '    strSql.Append("       外协品库存表.入库日期 AS 入库日期, " & vbCrLf)
            '    strSql.Append("       外协品库存表.作成者 AS 作成者, " & vbCrLf)
            '    strSql.Append("       外协品库存表.库存区域 AS 库存区域, " & vbCrLf)
            '    strSql.Append("       外协品库存表.出库去向 AS 出库去向, " & vbCrLf)
            '    strSql.Append("       外协品库存表.计划带料数 AS 计划带料数, " & vbCrLf)
            '    strSql.Append("       外协品库存表.实际带料数 AS 实际带料数, " & vbCrLf)
            '    strSql.Append("       外协品库存表.备注 AS 备注, " & vbCrLf)

            '    strSql.Append("FROM   B外协品库存表 外协品库存表" & vbCrLf)
            '    strSql.Append("       LEFT JOIN M客户管理 " & vbCrLf)
            '    strSql.Append("         ON 外协品库存表.客户编号 =M客户管理.客户编号 " & vbCrLf)
            '    strSql.Append("       LEFT JOIN T图纸管理" & vbCrLf)
            '    strSql.Append("         ON 外协品库存表.产品图号 = T图纸管理.产品图号 " & vbCrLf)

            '    strSql.Append("WHERE    1 = 1 " & vbCrLf)

            '    If clsM外协品库存T.产品图号 <> String.Empty Then
            '        strSql.Append(" AND 原材料.材料编号 like '" & Utility.PFn_ChangeQuotation(clsM外协品库存T.产品图号, True) & "%'" & vbCrLf)
            '    End If

            '    If clsM外协品库存T.订单编号 <> String.Empty Then
            '        strSql.Append(" AND 原材料.材料区分 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.订单编号) & vbCrLf)
            '    End If

            '    If clsM外协品库存T.外协工序 <> String.Empty Then
            '        strSql.Append(" AND 原材料.材料类别 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.外协工序) & vbCrLf)
            '    End If

            '    If clsM外协品库存T.出库去向 <> String.Empty Then
            '        strSql.Append(" AND 原材料.材质型号 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.出库去向) & vbCrLf)
            '    End If
            '    If clsM外协品库存T.客户编号 <> String.Empty Then
            '        strSql.Append(" AND 原材料.供应商编号 like '" & Utility.PFn_ChangeQuotation(clsM外协品库存T.客户编号, True) & "%'" & vbCrLf)
            '    End If
            '    If (clsM外协品库存T.入库日期From <> "1900/1/1") Then
            '        strSql.Append(" AND 原材料.入库日期 >=" & Utility.PFn_ChangeQuotation(clsM外协品库存T.入库日期From) & vbCrLf)
            '    End If
            '    If (clsM外协品库存T.入库日期To <> "1900/1/1") Then
            '        strSql.Append(" AND 原材料.入库日期 <" & Utility.PFn_ChangeQuotation(clsM外协品库存T.入库日期To.AddDays(1)) & vbCrLf)
            '    End If



            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadLevel1 "

    '检索全部数据
    Public Function LoadLevel1(ByVal clsM外协品库存T As B外协品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            'strSql.Append("SELECT    原材料.材料编号 " & vbCrLf)
            'strSql.Append("         ,原材料.材料批号 " & vbCrLf)
            'strSql.Append("         ,原材料.库存区域 " & vbCrLf)
            'strSql.Append("         , isnull(原材料.库存数量,0) AS [数量（个）] " & vbCrLf)
            'strSql.Append("         , isnull(原材料.库存重量,0) AS [重量（kg）] " & vbCrLf)
            'strSql.Append("         , M供应商管理.供应商名称 AS 材料供应商 " & vbCrLf)
            'strSql.Append("         ,原材料.入库日期 AS 入库日期 " & vbCrLf)
            'strSql.Append("         ,原材料.含税单价 AS 含税单价 " & vbCrLf)
            'strSql.Append("         ,原材料.含税总金额 AS 结算金额 " & vbCrLf)
            'strSql.Append("         ,原材料.备注 AS 备注 " & vbCrLf)

            'strSql.Append("FROM     B外协品库存表 原材料 " & vbCrLf)
            'strSql.Append("       LEFT JOIN M供应商管理 " & vbCrLf)
            'strSql.Append("         ON 原材料.供应商编号 =M供应商管理.供应商编号 " & vbCrLf)

            'strSql.Append("WHERE    1 = 1 " & vbCrLf)

            'If clsM外协品库存T.材料编号 <> String.Empty Then
            '    strSql.Append(" AND 原材料.材料编号 like '" & Utility.PFn_ChangeQuotation(clsM外协品库存T.材料编号, True) & "%'" & vbCrLf)
            'End If

            'If clsM外协品库存T.材料区分 <> String.Empty Then
            '    strSql.Append(" AND 原材料.材料区分 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.材料区分) & vbCrLf)
            'End If

            'If clsM外协品库存T.材料类别 <> String.Empty Then
            '    strSql.Append(" AND 原材料.材料类别 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.材料类别) & vbCrLf)
            'End If

            'If clsM外协品库存T.材质型号 <> String.Empty Then
            '    strSql.Append(" AND 原材料.材质型号 =" & Utility.PFn_ChangeQuotation(clsM外协品库存T.材质型号) & vbCrLf)
            'End If
            'If clsM外协品库存T.供应商编号 <> String.Empty Then
            '    strSql.Append(" AND 原材料.供应商编号 like '" & Utility.PFn_ChangeQuotation(clsM外协品库存T.供应商编号, True) & "%'" & vbCrLf)
            'End If
            'If (clsM外协品库存T.入库日期From <> "1900/1/1") Then
            '    strSql.Append(" AND 原材料.入库日期 >=" & Utility.PFn_ChangeQuotation(clsM外协品库存T.入库日期From) & vbCrLf)
            'End If
            'If (clsM外协品库存T.入库日期To <> "1900/1/1") Then
            '    strSql.Append(" AND 原材料.入库日期 <" & Utility.PFn_ChangeQuotation(clsM外协品库存T.入库日期To.AddDays(1)) & vbCrLf)
            'End If

            'strSql.Append("GROUP BY 原材料.材料编号 ,原材料.材料批号,原材料.库存区域 ,原材料.库存数量 ,原材料.库存重量,M供应商管理.供应商名称,原材料.入库日期,原材料.含税单价,原材料.含税总金额,原材料.备注 " & vbCrLf)
            'strSql.Append(" HAVING  SUM(原材料.库存数量)>0 or SUM(原材料.库存重量)>0 " & vbCrLf)
            'strSql.Append("ORDER BY 原材料.材料批号" & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadRepot "

    '检索全部数据
    Public Function LoadRepot(ByVal arrayList As ArrayList) As String

        Dim clsM外协品库存T As B外协品库存T
        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            'clsM外协品库存T = New B外协品库存T

            'clsM外协品库存T = arrayList(0)

            'strSql.Append(GetSql)

            'strSql.Append("SELECT   a.制造批量号, " & vbCrLf)
            'strSql.Append("         Row_number() " & vbCrLf)
            'strSql.Append("           OVER(ORDER BY a.制造批量号, a.部品番号,b.部品名称, a.型番) AS 序号, " & vbCrLf)
            'strSql.Append("         a.部品番号 , " & vbCrLf)
            'strSql.Append("         b.部品名称 , " & vbCrLf)
            'strSql.Append("         SUM(a.在库数量) AS 数量, " & vbCrLf)
            'strSql.Append("         a.型番, " & vbCrLf)
            'strSql.Append("         '' AS 明细, " & vbCrLf)
            'strSql.Append("         NULL AS 棚卸日, " & vbCrLf)
            'strSql.Append("         '' AS 担当, " & vbCrLf)
            'strSql.Append("         '' AS 确认 " & vbCrLf)
            'strSql.Append("FROM     tmp库存 a " & vbCrLf)
            'strSql.Append("         LEFT JOIN m部品管理 b " & vbCrLf)
            'strSql.Append("           ON a.部品番号 = b.部品番号 " & vbCrLf)

            'strSql.Append(" WHERE 1=1 ")
            ''If clsM外协品库存T.制造批量号 <> String.Empty Then
            ''    strSql.Append(" AND a.制造批量号 ='" & Utility.PFn_ChangeQuotation(clsM外协品库存T.制造批量号) & "'" & vbCrLf)
            ''End If
            ''If clsM外协品库存T.制造区分 <> String.Empty Then
            ''    strSql.Append(" AND a.制造区分 ='" & Utility.PFn_ChangeQuotation(clsM外协品库存T.制造区分) & "'" & vbCrLf)
            ''End If
            ''If clsM外协品库存T.部品番号 <> String.Empty Then
            ''    strSql.Append(" AND a.部品番号 ='" & Utility.PFn_ChangeQuotation(clsM外协品库存T.部品番号) & "'" & vbCrLf)
            ''End If

            'strSql.Append(" GROUP BY a.制造批量号,a.部品番号,b.部品名称,a.型番")


            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

    Public Function LoadToFile(ByVal clsB外协品库存T As B外协品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            'strSql.Append(" SELECT  DISTINCT B外协品库存表.材料编号, ")
            'strSql.Append("         材料名称 , ")
            'strSql.Append("         材料型号 , ")
            'strSql.Append("         材料区分 , ")
            'strSql.Append("         材质型号 , ")
            'strSql.Append("         材料类别 , ")
            'strSql.Append("         库存总数量 , ")
            'strSql.Append("         库存总重量 , ")
            ''strSql.Append("         ISNULL(批次, '') 批次 , ")
            'strSql.Append("         库存区域 , ")
            'strSql.Append("         库存数量 , ")
            'strSql.Append("         库存重量 , ")
            'strSql.Append("         , M供应商管理.供应商名称 AS 材料供应商 " & vbCrLf)
            'strSql.Append("         入库日期 , ")
            'strSql.Append("         含税单价 , ")
            'strSql.Append("         含税总金额 , ")
            'strSql.Append("         备注 , ")

            'strSql.Append(" WHERE 1=1 " & vbCrLf)

            ''If clsB外协品库存T.材料编号 <> String.Empty Then
            ''    'strSql.Append(" AND B外协品库存表.材料编号='" & Utility.ChangeQuotation(clsB外协品库存T.材料编号) & "'" & vbCrLf)
            ''End If
            ''strSql.Append(" ORDER BY M零部件.零部件CD,零部件名,批次,数量 ")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

End Class



Public Class DalM外协品标签打印T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls外协品标签打印T As B外协品标签打印T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B外协品标签打印")          '外协品标签打印

            strSql.Append(" (材料编号")          '材料编号
            strSql.Append(" ,数量")              '数量
            strSql.Append(" ,重量")              '重量
            strSql.Append(" ,批次")              '批次
            strSql.Append(" ,库存区域")          '库存数量
            strSql.Append(" ,打印者")            '打印者
            strSql.Append(" ,打印时间")          '打印时间
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品标签打印T.材料编号))
            '数量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品标签打印T.数量))
            '重量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品标签打印T.重量))
            '批次
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品标签打印T.批次))
            '库存区域
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品标签打印T.库存区域))
            '打印者
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品标签打印T.打印者))
            '打印时间
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品标签打印T.打印时间))
            strSql.Append(" )")
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

End Class
