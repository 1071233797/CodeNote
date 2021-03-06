Imports System.Text

#Region "Dal库存盘点表"
'------------------------------------------------------------------------------------
'   说明
'       库存盘点表的数据库操作SQL文
'   创建人
'       大连智云科技 刘春广
'   创建时间
'       2016/5/25
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalM原材料库存盘点T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls库存盘点表T As B原材料库存盘点表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B原材料库存盘点 ")            '库存盘点表

            strSql.Append(" (材料编号")           '货架编号
            strSql.Append(" ,批次号")           '部品番号
            strSql.Append(" ,在库数量")           '部品区分
            strSql.Append(" ,在库重量")           '现库存数
            strSql.Append(" ,盘点日期")            '盘点数
            strSql.Append(" ,盘点数量")            '差异数
            strSql.Append(" ,盘点重量")           '调整数量
            strSql.Append(" ,调整数量")          '调整后在库
            strSql.Append(" ,调整重量")           '盘点日期
            strSql.Append(" ,调整后在库数量")           '处理方式
            strSql.Append(" ,调整后在库重量")           '在库状态
            strSql.Append(" ,盘点人编号")         '备注
            strSql.Append(" ,操作PDA")         '备注
            strSql.Append(" ,备注")         '备注
            strSql.Append(" ,差异数量")         '备注
            strSql.Append(" ,差异重量")         '备注
            strSql.Append(" ,调整日期")         '备注
            strSql.Append(")")

            strSql.Append(" VALUES ")

            '现库存数
            If cls库存盘点表T.在库数量 = 0 Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append(" ," & cls库存盘点表T.在库数量)
            End If

            '盘点数
            If cls库存盘点表T.在库重量 = 0 Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append(" ," & cls库存盘点表T.在库重量)
            End If

            '处理方式
            If cls库存盘点表T.盘点数量 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append(" ," & Utility.PFn_ChangeQuotation(cls库存盘点表T.盘点数量))
            End If

            '在库状态
            If cls库存盘点表T.盘点重量 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append(" ," & Utility.PFn_ChangeQuotation(cls库存盘点表T.盘点重量))
            End If


            '在库状态
            If cls库存盘点表T.调整数量 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append(" ," & Utility.PFn_ChangeQuotation(cls库存盘点表T.调整数量))
            End If

            '在库状态
            If cls库存盘点表T.调整重量 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append(" ," & Utility.PFn_ChangeQuotation(cls库存盘点表T.调整重量))
            End If

            '在库状态
            If cls库存盘点表T.调整后在库数量 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append(" ," & Utility.PFn_ChangeQuotation(cls库存盘点表T.调整后在库数量))
            End If

            '在库状态
            If cls库存盘点表T.调整后在库重量 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append(" ," & Utility.PFn_ChangeQuotation(cls库存盘点表T.调整后在库重量))
            End If

            '备注
            If cls库存盘点表T.备注 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append(" ,'" & Utility.PFn_ChangeQuotation(cls库存盘点表T.备注) & "'")
            End If

            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    Public Function Update库存(ByVal cls库存调整T As B原材料库存盘点表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B原材料库存表" & vbCrLf)       '库存表

            strSql.Append("   SET 库存数量 = " & cls库存调整T.调整后在库数量)         '部品番号
            strSql.Append("   ,库存重量 = " & cls库存调整T.调整后在库重量)         '部品番号
            strSql.Append("    WHERE  1=1 ")

            strSql.Append("       AND  材料编号= " & Utility.PFn_ChangeQuotation(cls库存调整T.材料编号) & vbCrLf)

            strSql.Append("       AND  批次号= " & Utility.PFn_ChangeQuotation(cls库存调整T.材料批号) & vbCrLf)


            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls库存盘点表T As B原材料库存盘点表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM 库存盘点表 ") '库存盘点表)

            strSql.Append(" WHERE ")
            'strSql.Append(" 货架编号 = '" & Utility.PFn_ChangeQuotation(cls库存盘点表T.货架编号) & "'") '货架编号
            'strSql.Append("  AND 部品番号 = '" & Utility.PFn_ChangeQuotation(cls库存盘点表T.部品番号) & "'") '部品番号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal cls库存盘点表T As B原材料库存盘点表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT ")

            strSql.Append("  库存盘点表.货架编号 AS 货架编号")         '货架编号
            strSql.Append(" ,库存盘点表.部品番号 AS 部品番号")         '部品番号
            strSql.Append(" ,ISNULL(库存盘点表.部品区分,'') AS 部品区分")          '部品区分
            strSql.Append(" ,ISNULL(库存盘点表.现库存数,0) AS 现库存数")           '现库存数
            strSql.Append(" ,ISNULL(库存盘点表.盘点数,0) AS 盘点数")         '盘点数
            strSql.Append(" ,ISNULL(库存盘点表.差异数,0) AS 差异数")         '差异数
            strSql.Append(" ,ISNULL(库存盘点表.调整数量,0) AS 调整数量")           '调整数量
            strSql.Append(" ,ISNULL(库存盘点表.调整后在库,0) AS 调整后在库")         '调整后在库
            strSql.Append(" ,库存盘点表.盘点日期 AS 盘点日期")         '盘点日期
            strSql.Append(" ,ISNULL(库存盘点表.处理方式,'') AS 处理方式")          '处理方式
            strSql.Append(" ,ISNULL(库存盘点表.在库状态,'') AS 在库状态")          '在库状态
            strSql.Append(" ,ISNULL(库存盘点表.备注,'') AS 备注")          '备注

            strSql.Append(" FROM 库存盘点表 ") '库存盘点表)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls原材料T As B原材料库存盘点表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("WITH tmp部品 " & vbCrLf)
            strSql.Append("     AS (SELECT DISTINCT a.制造批量号, " & vbCrLf)
            strSql.Append("                         a.部品番号, " & vbCrLf)
            strSql.Append("                         b.部品名称, " & vbCrLf)
            strSql.Append("                         a.金型番号, " & vbCrLf)
            strSql.Append("                         b.客户编号, " & vbCrLf)
            strSql.Append("                         a.库存状态, " & vbCrLf)
            strSql.Append("                         a.制造区分 " & vbCrLf)
            strSql.Append("         FROM   库存表 a " & vbCrLf)
            strSql.Append("                LEFT JOIN m部品管理 b " & vbCrLf)
            strSql.Append("                  ON a.部品番号 = b.部品番号 " & vbCrLf)
            strSql.Append("         WHERE  a.制造区分 = '1' " & vbCrLf)
            strSql.Append("         UNION  " & vbCrLf)
            strSql.Append("         SELECT DISTINCT a.制造批量号, " & vbCrLf)
            strSql.Append("                         a.部品番号, " & vbCrLf)
            strSql.Append("                         b.组立品名 AS 部品名称, " & vbCrLf)
            strSql.Append("                         a.金型番号, " & vbCrLf)
            strSql.Append("                         b.客户编号, " & vbCrLf)
            strSql.Append("                         a.库存状态, " & vbCrLf)
            strSql.Append("                         a.制造区分 " & vbCrLf)
            strSql.Append("         FROM   库存表 a " & vbCrLf)
            strSql.Append("                LEFT JOIN m组立品 b " & vbCrLf)
            strSql.Append("                  ON a.部品番号 = b.组立部番 " & vbCrLf)
            strSql.Append("         WHERE  a.制造区分 = '2') " & vbCrLf)
            strSql.Append("SELECT 0 AS 选择, " & vbCrLf)
            strSql.Append("       a.部品番号, " & vbCrLf)
            strSql.Append("       b.部品名称, " & vbCrLf)
            strSql.Append("       b.金型番号 AS 型番, " & vbCrLf)
            strSql.Append("       b.制造批量号, " & vbCrLf)
            strSql.Append("       d.客户名称, " & vbCrLf)
            strSql.Append("       Isnull(a.在库数量,0) AS 在库数量, " & vbCrLf)
            strSql.Append("       Isnull(a.盘点数量,0) AS 盘点数量, " & vbCrLf)
            strSql.Append("       e.人员名 AS 盘点人, " & vbCrLf)
            strSql.Append("       a.盘点日期, " & vbCrLf)
            strSql.Append("       Isnull(a.差异数,0) AS 差异数, " & vbCrLf)
            strSql.Append("       a.处理方式, " & vbCrLf)
            strSql.Append("       Isnull(a.调整数量,0) AS 调整数量, " & vbCrLf)
            strSql.Append("       a.调整后库存 AS 调整后在库数量, " & vbCrLf)
            strSql.Append("       a.备注, " & vbCrLf)
            strSql.Append("       a.盘点cd " & vbCrLf)
            strSql.Append("FROM   库存盘点表 a " & vbCrLf)
            strSql.Append("       LEFT JOIN tmp部品 b " & vbCrLf)
            strSql.Append("         ON a.部品番号 = b.部品番号 " & vbCrLf)
            strSql.Append("            AND a.制造批量号 = b.制造批量号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m客户管理 d " & vbCrLf)
            strSql.Append("         ON b.客户编号 = d.客户编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m人员管理 e " & vbCrLf)
            strSql.Append("         ON a.盘点人编号 = e.人员编号 " & vbCrLf)


            strSql.Append("WHERE  1 = 1 " & vbCrLf)

            'If cls生产计划T.制造区分 <> "" Then
            '    strSql.Append("       AND b.制造区分 =  " & Utility.PFn_ChangeQuotation(cls生产计划T.制造区分) & vbCrLf)
            'End If

            'If cls生产计划T.部品番号 <> "" Then
            '    strSql.Append("       AND a.部品番号 like '" & Utility.ChangeQuotation(cls生产计划T.部品番号) & "%'" & vbCrLf)
            'End If

            'If cls生产计划T.客户编号 <> "" Then
            '    strSql.Append("       AND b.客户编号 = " & Utility.PFn_ChangeQuotation(cls生产计划T.客户编号) & vbCrLf)
            'End If

            'If cls生产计划T.仅显示差异项 <> "0" And cls生产计划T.仅显示差异项 <> "" Then
            '    strSql.Append("      AND a.在库数量<>a.盘点数量 ")
            'End If

            strSql.Append(" ORDER BY a.盘点日期 DESC,a.部品番号")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadLevel0 "

    '检索全部数据
    Public Function LoadLevel0(ByVal clsMSearchT As B原材料库存盘点表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT            'false' 选择, " & vbCrLf)
            strSql.Append("                         原材料库存盘点.材料编号," & vbCrLf)
            strSql.Append("                         原材料信息.原材料名称 AS 材料名称 , " & vbCrLf)
            strSql.Append("                         材料区分.名称 AS 材料区分, " & vbCrLf)
            strSql.Append("                          原材料信息.材质 AS [材质/型号],  " & vbCrLf)
            strSql.Append("                         Isnull(SUM(原材料库存表.库存数量),0) AS [在库总数量（个）], " & vbCrLf)
            strSql.Append("                         Isnull(SUM(原材料库存表.库存重量),0) AS [在库总重量（kg）], " & vbCrLf)

            strSql.Append("                          Isnull(SUM(原材料库存盘点.盘点数量),0) AS [盘点总数量（个）], " & vbCrLf)
            strSql.Append("                          Isnull(SUM(原材料库存盘点.盘点重量),0) AS [盘点总重量（kg）], " & vbCrLf)

            strSql.Append("          Isnull(SUM(原材料库存盘点.盘点数量),0)  " & vbCrLf)
            strSql.Append("         - Isnull(SUM(原材料库存表.库存数量),0) AS [差异总数量（个）], " & vbCrLf)
            strSql.Append("         Isnull(SUM(原材料库存盘点.盘点重量),0) " & vbCrLf)
            strSql.Append("         - Isnull(SUM(原材料库存表.库存重量),0) AS [差异总重量（kg）] " & vbCrLf)

            strSql.Append("FROM   B原材料库存盘点 原材料库存盘点 " & vbCrLf)
            strSql.Append("                LEFT JOIN M原材料信息 原材料信息 " & vbCrLf)
            strSql.Append("                  ON 原材料库存盘点.材料编号 = 原材料信息.原材料编号 " & vbCrLf)
            strSql.Append("                LEFT JOIN B原材料库存表 原材料库存表 " & vbCrLf)
            strSql.Append("                  ON 原材料库存表.材料编号 = 原材料信息.原材料编号 " & vbCrLf)
            strSql.Append("                LEFT JOIN vm材料区分 材料区分 " & vbCrLf)
            strSql.Append("               ON 原材料信息.原材料区分 = 材料区分.区分  " & vbCrLf)

            strSql.Append(" WHERE  1 = 1 " & vbCrLf)

            If clsMSearchT.材料区分 <> "" Then
                strSql.Append("       AND 材料区分.区分 =  " & Utility.PFn_ChangeQuotation(clsMSearchT.材料区分) & vbCrLf)
            End If

            If clsMSearchT.材料编号 <> "" Then
                strSql.Append("       AND 原材料库存盘点.材料编号 like '" & Utility.PFn_ChangeQuotation(clsMSearchT.材料编号, True) & "%'" & vbCrLf)
            End If

            If clsMSearchT.仅显示差异项 <> "0" And clsMSearchT.仅显示差异项 <> "" Then
                strSql.Append("      AND 原材料库存表.库存数量<>原材料库存盘点.盘点数量 ")
            End If

            If clsMSearchT.盘点日期From <> "1900/1/1" Then
                strSql.Append("      AND 原材料库存盘点.盘点日期>= " & Utility.PFn_ChangeQuotation(clsMSearchT.盘点日期From) & vbCrLf)
            End If

            If clsMSearchT.盘点日期To <> "1900/1/1" Then
                strSql.Append("      AND 原材料库存盘点.盘点日期<= " & Utility.PFn_ChangeQuotation(clsMSearchT.盘点日期To) & vbCrLf)
            End If
          
            strSql.Append("GROUP BY 原材料库存盘点.材料编号,原材料名称,材料区分.名称,原材料信息.材质  ,原材料库存盘点.盘点日期" & vbCrLf)
            strSql.Append(" ORDER BY 原材料库存盘点.盘点日期 DESC,原材料库存盘点.材料编号")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadLevel1 "

    '检索全部数据
    Public Function LoadLevel1(ByVal clsMSearchT As B原材料库存盘点表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT   " & vbCrLf)
            strSql.Append("       原材料库存盘点.批次号 材料批号, " & vbCrLf)
            strSql.Append("       Isnull(原材料库存表.库存数量,0) AS [在库数量（个）], " & vbCrLf)
            strSql.Append("       Isnull(原材料库存表.库存重量,0) AS [在库重量（kg）], " & vbCrLf)
            strSql.Append("       原材料库存表.入库日期, " & vbCrLf)
            strSql.Append("       Isnull(原材料库存盘点.盘点数量,0) AS [盘点数量（个）], " & vbCrLf)
            strSql.Append("       Isnull(原材料库存盘点.盘点重量,0) AS [盘点重量（kg）], " & vbCrLf)
            strSql.Append("       原材料库存盘点.盘点日期, " & vbCrLf)
            strSql.Append("          Isnull(原材料库存盘点.盘点数量,0)  " & vbCrLf)
            strSql.Append("         - Isnull(原材料库存表.库存数量,0) AS [差异数量（个）], " & vbCrLf)
            strSql.Append("         Isnull(原材料库存盘点.盘点重量,0) " & vbCrLf)
            strSql.Append("         - Isnull(原材料库存表.库存重量,0) AS [差异重量（kg）], " & vbCrLf)
            strSql.Append("       0 AS [差额调整数量（个）], " & vbCrLf)
            strSql.Append("       0 AS [差额调整重量（kg）], " & vbCrLf)
            strSql.Append("       CASE  WHEN Isnull(原材料库存表.库存数量,0) > Isnull(原材料库存盘点.盘点数量,0) THEN  1  else CASE  WHEN Isnull(原材料库存表.库存数量,0)<Isnull(原材料库存盘点.盘点数量,0) THEN 2 end end AS 处理方式, " & vbCrLf)
            strSql.Append("       Isnull(原材料库存表.库存数量,0) AS [调整后在库数量（个）], " & vbCrLf)
            strSql.Append("       Isnull(原材料库存表.库存重量,0) AS [调整后在库重量（kg）], " & vbCrLf)
            strSql.Append("       原材料库存盘点.备注 AS 备注, " & vbCrLf)
            strSql.Append("       原材料库存盘点.盘点CD, " & vbCrLf)
            strSql.Append("       原材料库存盘点.材料编号 " & vbCrLf)

            strSql.Append("FROM   B原材料库存盘点 原材料库存盘点" & vbCrLf)
            strSql.Append("                LEFT JOIN B原材料库存表 原材料库存表 " & vbCrLf)
            strSql.Append("                  ON 原材料库存表.材料编号 = 原材料库存盘点.材料编号 AND 原材料库存表.批次号 = 原材料库存盘点.批次号" & vbCrLf)
            strSql.Append("                LEFT JOIN M原材料信息 原材料信息 " & vbCrLf)
            strSql.Append("                  ON 原材料库存盘点.材料编号 = 原材料信息.原材料编号 " & vbCrLf)
            strSql.Append("                LEFT JOIN vm材料区分 材料区分 " & vbCrLf)
            strSql.Append("               ON 原材料信息.原材料区分 = 材料区分.区分  " & vbCrLf)
            strSql.Append("WHERE  1 = 1 " & vbCrLf)

            If clsMSearchT.材料区分 <> "" Then
                strSql.Append("       AND 材料区分.区分 =  " & Utility.PFn_ChangeQuotation(clsMSearchT.材料区分) & vbCrLf)
            End If

            If clsMSearchT.材料编号 <> "" Then
                strSql.Append("       AND 原材料库存盘点.材料编号 like '" & Utility.PFn_ChangeQuotation(clsMSearchT.材料编号, True) & "%'" & vbCrLf)
            End If

            If clsMSearchT.仅显示差异项 <> "0" And clsMSearchT.仅显示差异项 <> "" Then
                strSql.Append("      AND 原材料库存表.库存数量<>原材料库存盘点.盘点数量 ")
            End If

            If clsMSearchT.盘点日期From <> "1900/1/1" Then
                strSql.Append("      AND 原材料库存盘点.盘点日期>= " & Utility.PFn_ChangeQuotation(clsMSearchT.盘点日期From) & vbCrLf)
            End If

            If clsMSearchT.盘点日期To <> "1900/1/1" Then
                strSql.Append("      AND 原材料库存盘点.盘点日期<= " & Utility.PFn_ChangeQuotation(clsMSearchT.盘点日期To) & vbCrLf)
            End If

            strSql.Append("GROUP BY 原材料库存盘点.材料编号,原材料库存盘点.批次号,原材料库存表.库存数量,原材料库存表.库存重量,原材料库存表.入库日期,盘点日期,处理方式,原材料库存盘点.备注,盘点CD,盘点数量,盘点重量" & vbCrLf)
            strSql.Append(" ORDER BY 原材料库存盘点.盘点日期 DESC,原材料库存盘点.材料编号,原材料库存盘点.批次号")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
