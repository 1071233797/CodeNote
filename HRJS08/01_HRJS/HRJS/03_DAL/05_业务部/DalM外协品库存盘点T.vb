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

Public Class DalM外协品库存盘点T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls库存盘点表T As B外协品库存盘点T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try

            strSql.Append(" INSERT INTO B半成品库存盘点记录表")          '半成品入库申请
            strSql.Append(" (订单编号")          '申请单编号
            strSql.Append(" ,主图号")          '申请者编号
            strSql.Append(" ,上级图号")          '申请者编号
            strSql.Append(" ,分图号")          '申请者编号
            strSql.Append(" ,工序编号")        '领料日期
            strSql.Append(" ,在库数量")           '领料重量
            strSql.Append(" ,盘点日期")           '领料重量
            strSql.Append(" ,盘点数量")           '领料重量
            strSql.Append(" ,差异数")           '领料重量
            'strSql.Append(" ,调整数量")           '领料重量
            strSql.Append(" ,调整后库存")           '领料重量
            'strSql.Append(" ,在库状态")           '领料重量
            strSql.Append(" ,处理方式")           '领料重量        
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
           
            '申请者编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.订单编号))
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.主图号))
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.上级图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.分图号))
            '领料日期
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.加工工序))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.在库数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.入库日期))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.盘点数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.差异数量))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.调整数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.调整后在库数量))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.在库状态))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls库存盘点表T.处理方式))
            strSql.Append(" )")
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try


    End Function

#End Region

#Region " Update库存 "

    '数据更新操作
    Public Function Update库存调整(ByVal cls库存盘点表T As B外协品库存盘点T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE Z半成品库存") '库存盘点表
            strSql.Append(" SET ")

            '调整数量
            If cls库存盘点表T.调整后在库数量 = 0 Then
                strSql.Append(" 库存数量 = 0 ")
            Else
                strSql.Append(" 库存数量 = " & cls库存盘点表T.调整后在库数量)
            End If
            strSql.Append(" WHERE  1=1 ")
            If (cls库存盘点表T.分图号 <> String.Empty) Then
                strSql.Append("  AND 分图号 = " & Utility.PFn_ChangeQuotation(cls库存盘点表T.分图号))
            End If
            If (cls库存盘点表T.主图号 <> String.Empty) Then
                strSql.Append("  AND 主图号 = " & Utility.PFn_ChangeQuotation(cls库存盘点表T.主图号))
            End If
            If (cls库存盘点表T.上级图号 <> String.Empty) Then
                strSql.Append("  AND 上级图号 = " & Utility.PFn_ChangeQuotation(cls库存盘点表T.上级图号))
            End If
            If (cls库存盘点表T.工序编号 <> String.Empty) Then
                strSql.Append("  AND 工序编号 = " & Utility.PFn_ChangeQuotation(cls库存盘点表T.工序编号))
            End If
            If (cls库存盘点表T.订单编号 <> String.Empty) Then
                strSql.Append("  AND 订单编号 = " & Utility.PFn_ChangeQuotation(cls库存盘点表T.订单编号))
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function


#End Region

#Region " LoadLevel "

    '检索全部数据
    Public Function LoadLevel(ByVal clsMSearchT As B外协品库存盘点T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT   DISTINCT")
            strSql.Append("        半成品库存盘点.订单编号,")
            strSql.Append("        半成品库存盘点.主图号 ,")
            strSql.Append("        半成品库存盘点.上级图号 ,")
            strSql.Append("        半成品库存盘点.分图号,")
            strSql.Append("        图纸管理.品名 名称 ,")
            strSql.Append("        T流转票管理.工序名称 加工工序 ,")
            strSql.Append("        ISNULL(SUM(半成品库存表.库存数量), 0) 在库数量 ,")
            strSql.Append("        Z半成品入出库记录.入出库日期 入库日期 ,")
            strSql.Append("        盘点数量 ,")
            strSql.Append("        ISNULL(SUM(半成品库存盘点.盘点数量), 0) - ISNULL(SUM(半成品库存表.库存数量), 0) AS 差异数量 ,")
            strSql.Append("        0 AS 差额调整数量 ,")
            strSql.Append("        CASE WHEN ISNULL(半成品库存表.库存数量, 0) > ISNULL(半成品库存盘点.盘点数量, 0) THEN 1")
            strSql.Append("             ELSE CASE WHEN ISNULL(半成品库存表.库存数量, 0) < ISNULL(半成品库存盘点.盘点数量, 0)")
            strSql.Append("                       THEN 2")
            strSql.Append("                  END")
            strSql.Append("        END AS 处理方式 ,")
            strSql.Append("        ISNULL(半成品库存表.库存数量, 0) AS 调整后在库数量       ,")
            strSql.Append("        T流转票管理.工序编号" & vbCrLf)
            strSql.Append("FROM    B半成品库存盘点 半成品库存盘点" & vbCrLf)
            strSql.Append("        LEFT JOIN T图纸管理 图纸管理 ON 半成品库存盘点.主图号 = 图纸管理.主图号 AND 图纸管理.产品图号 = 半成品库存盘点.分图号 AND 图纸管理.上级图号 = 半成品库存盘点.上级图号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.Z半成品库存 半成品库存表 ON 半成品库存表.分图号 = 图纸管理.产品图号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T流转票管理 ON T流转票管理.产品图号 = 半成品库存盘点.分图号" & vbCrLf)
            strSql.Append("                                AND T流转票管理.工序编号 = 半成品库存表.工序编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.Z半成品入出库记录 ON Z半成品入出库记录.订单编号 = 半成品库存盘点.订单编号" & vbCrLf)
            strSql.Append("                                   AND Z半成品入出库记录.分图号 = 半成品库存盘点.分图号" & vbCrLf)

            strSql.Append(" WHERE  1 = 1 " & vbCrLf)
            strSql.Append("          AND Z半成品入出库记录.入出库区分='1'")
            If clsMSearchT.主图号 <> "" Then
                strSql.Append("       AND 半成品库存盘点.主图号 =  " & Utility.PFn_ChangeQuotation(clsMSearchT.主图号) & vbCrLf)
            End If

            If clsMSearchT.订单编号 <> "" Then
                strSql.Append("       AND 半成品库存盘点.订单编号 =" & Utility.PFn_ChangeQuotation(clsMSearchT.订单编号) & vbCrLf)
            End If

            If clsMSearchT.客户编号 <> "" Then
                strSql.Append("      AND 图纸管理.客户编号=" & Utility.PFn_ChangeQuotation(clsMSearchT.客户编号))
            End If

            If clsMSearchT.入库日期1 <> "1900/1/1" Then
                strSql.Append("      AND Z半成品入出库记录.入出库日期>= " & Utility.PFn_ChangeQuotation(clsMSearchT.入库日期1) & vbCrLf)
            End If

            If clsMSearchT.入库日期2 <> "1900/1/1" Then
                strSql.Append("      AND Z半成品入出库记录.入出库日期<= " & Utility.PFn_ChangeQuotation(clsMSearchT.入库日期2) & vbCrLf)
            End If
            strSql.Append("GROUP BY 半成品库存盘点.主图号 ,")
            strSql.Append("         半成品库存盘点.上级图号,")
            strSql.Append("         半成品库存盘点.分图号 ,")
            strSql.Append("        图纸管理.品名 ,")
            strSql.Append("        T流转票管理.工序名称 ,")
            strSql.Append("        半成品库存盘点.订单编号 ,")
            strSql.Append("        Z半成品入出库记录.入出库日期 ,")
            strSql.Append("        处理方式 ,")
            strSql.Append("        盘点数量 ,")
            strSql.Append("        半成品库存表.库存数量," & vbCrLf)
            strSql.Append("        T流转票管理.工序编号" & vbCrLf)
            strSql.Append("ORDER BY Z半成品入出库记录.入出库日期 DESC")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
