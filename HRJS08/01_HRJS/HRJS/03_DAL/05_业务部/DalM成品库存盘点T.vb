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

Public Class DalM成品库存盘点T

#Region " Insert "

    '数据插入操作
    Public Function Insert备份(ByVal cls库存盘点表T As B成品库存盘点T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

    End Function

#End Region

#Region " Update库存 "

    '数据更新操作
    Public Function Update库存调整(ByVal cls库存盘点表T As B成品库存盘点T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B成品库存表 ") '库存盘点表
            strSql.Append(" SET ")

            '调整数量
            If cls库存盘点表T.调整后在库数量 = 0 Then
                strSql.Append(" 库存数量 = 0 ")
            Else
                strSql.Append(" 库存数量 = " & cls库存盘点表T.调整后在库数量)
            End If
            '调整数量
            If cls库存盘点表T.调整后在库重量 = 0 Then
                strSql.Append(" ,库存重量 = 0 ")
            Else
                strSql.Append(" ,库存重量 = " & cls库存盘点表T.调整后在库数量)
            End If
            strSql.Append(" WHERE  1=1 ")
            strSql.Append("  AND 产品图号 = " & Utility.PFn_ChangeQuotation(cls库存盘点表T.产品图号))
            strSql.Append("  AND 订单编号 = " & Utility.PFn_ChangeQuotation(cls库存盘点表T.订单编号))
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function


#End Region

#Region " LoadLevel "

    '检索全部数据
    Public Function LoadLevel(ByVal clsMSearchT As B成品库存盘点T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  DISTINCT")
            strSql.Append("        'false' 选择 ,")
            strSql.Append("        B成品库存盘点.订单编号 ,")
            strSql.Append("        B成品库存盘点.产品图号 ,")
            strSql.Append("        图纸管理.品名 产品名称 ,")
            strSql.Append("        M客户管理.客户名称 ,")
            strSql.Append("        ISNULL(SUM(B成品库存表.库存数量), 0) [在库总数量（个）] ,")
            strSql.Append("        ISNULL(SUM(B成品库存表.库存重量), 0) [在库总重量（kg）] ,")
            strSql.Append("        ISNULL(SUM(B成品库存盘点.盘点数量), 0) [盘点总数量（个）] ,")
            strSql.Append("        ISNULL(SUM(B成品库存盘点.盘点重量), 0) [盘点总重量（kg）] ,")
            strSql.Append("        ISNULL(SUM(B成品库存盘点.盘点数量), 0) - ISNULL(SUM(B成品库存表.库存数量), 0) [差异总数量（个）] ,")
            strSql.Append("        ISNULL(SUM(B成品库存盘点.盘点重量), 0) - ISNULL(SUM(B成品库存表.库存重量), 0) [差异总重量（kg）] ,")
            strSql.Append("        0 [差额调整数量（个）] ,")
            strSql.Append("        0 [差额调整重量（kg）] ,")
            strSql.Append("        ISNULL(SUM(B成品库存表.库存数量), 0) AS [调整后在库数量（个）] ,")
            strSql.Append("        ISNULL(SUM(B成品库存表.库存重量), 0) AS [调整后在库重量（kg）] ,")
            strSql.Append("        B成品库存表.入库日期 ,")
            strSql.Append("        CASE WHEN ISNULL(SUM(B成品库存表.库存数量), 0) > ISNULL(SUM(B成品库存盘点.盘点数量), 0)")
            strSql.Append("             THEN 1")
            strSql.Append("             ELSE CASE WHEN ISNULL(SUM(B成品库存表.库存数量), 0) < ISNULL(SUM(B成品库存盘点.盘点数量),")
            strSql.Append("                                                              0) THEN 2")
            strSql.Append("                  END")
            strSql.Append("        END AS 处理方式 ,")
            strSql.Append("        CASE WHEN ISNULL(SUM(B成品库存表.库存重量), 0) > ISNULL(SUM(B成品库存盘点.盘点重量), 0)")
            strSql.Append("             THEN 1")
            strSql.Append("             ELSE CASE WHEN ISNULL(SUM(B成品库存表.库存重量), 0) < ISNULL(SUM(B成品库存盘点.盘点重量),")
            strSql.Append("                                                              0) THEN 2")
            strSql.Append("                  END")
            strSql.Append("        END AS 处理方式1 ,")
            strSql.Append("        dbo.VM库存状态.名称 库存状态" & vbCrLf)
            strSql.Append("FROM    B成品库存盘点" & vbCrLf)
            strSql.Append("        LEFT JOIN T图纸管理 图纸管理 ON B成品库存盘点.产品图号 = 图纸管理.产品图号" & vbCrLf)
            strSql.Append("        LEFT JOIN B成品库存表 ON B成品库存表.产品图号 = B成品库存盘点.产品图号" & vbCrLf)
            strSql.Append("                            AND B成品库存表.订单编号 = B成品库存盘点.订单编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = 图纸管理.客户编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM库存状态 ON VM库存状态.区分 = B成品库存表.库存状态" & vbCrLf)
            strSql.Append(" WHERE  1 = 1 " & vbCrLf)

            If clsMSearchT.产品图号 <> "" Then
                strSql.Append("       AND B成品库存盘点.产品图号 =  " & Utility.PFn_ChangeQuotation(clsMSearchT.产品图号) & vbCrLf)
            End If

            If clsMSearchT.订单编号 <> "" Then
                strSql.Append("       AND B成品库存盘点.订单编号 =" & Utility.PFn_ChangeQuotation(clsMSearchT.订单编号) & vbCrLf)
            End If
            If clsMSearchT.仅显示差异项 <> "0" And clsMSearchT.仅显示差异项 <> "" Then
                strSql.Append("      AND B成品库存表.库存数量<>B成品库存盘点.盘点数量 " & vbCrLf)
            End If
            If clsMSearchT.客户编号 <> "" Then
                strSql.Append("      AND M客户管理.客户编号=" & Utility.PFn_ChangeQuotation(clsMSearchT.客户编号) & vbCrLf)
            End If

            If clsMSearchT.入库日期1 <> "1900/1/1" Then
                strSql.Append("      AND B成品库存表.入库日期>= " & Utility.PFn_ChangeQuotation(clsMSearchT.入库日期1) & vbCrLf)
            End If

            If clsMSearchT.入库日期2 <> "1900/1/1" Then
                strSql.Append("      AND B成品库存表.入库日期<= " & Utility.PFn_ChangeQuotation(clsMSearchT.入库日期2) & vbCrLf)
            End If
            strSql.Append("GROUP BY B成品库存盘点.订单编号 ,")
            strSql.Append("        B成品库存盘点.产品图号 ,")
            strSql.Append("        图纸管理.品名 ,")
            strSql.Append("        M客户管理.客户名称 ,")
            strSql.Append("        B成品库存表.入库日期 ,")
            strSql.Append("        VM库存状态.名称 ,")
            strSql.Append("        B成品库存表.库存数量 ,")
            strSql.Append("        B成品库存表.库存重量" & vbCrLf)
            strSql.Append("ORDER BY B成品库存表.入库日期 DESC")



            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
