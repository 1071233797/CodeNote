Imports System.Text

Public Class DalM成品库存T

#Region " Insert "

#End Region

#Region " Update "

    '数据更新操作 
#End Region

#Region " Delete "

    '数据删除操作 
#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsT库存T As B成品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT 制造批量号, " & vbCrLf)
            strSql.Append("       部品番号, " & vbCrLf)
            strSql.Append("       制造区分, " & vbCrLf)
            strSql.Append("       库存数量, " & vbCrLf)
            strSql.Append("       库存状态 " & vbCrLf)
            strSql.Append("FROM   库存表")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPKey "

    '检索全部数据
    Public Function LoadByPKey(ByVal clsT库存T As B成品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            'strSql.Append("SELECT 制造批量号, " & vbCrLf)
            'strSql.Append("       部品番号, " & vbCrLf)
            'strSql.Append("       制造区分, " & vbCrLf)
            'strSql.Append("       库存数量, " & vbCrLf)
            'strSql.Append("       库存状态 " & vbCrLf)
            'strSql.Append("FROM   库存表")

            strSql.Append(GetSql)

            strSql.Append("SELECT   a.制造批量号, " & vbCrLf)
            strSql.Append("         a.部品番号, " & vbCrLf)
            strSql.Append("         a.制造区分, " & vbCrLf)
            strSql.Append("         SUM(a.在库数量) AS 在库数量, " & vbCrLf)
            strSql.Append("         a.库存状态 " & vbCrLf)
            strSql.Append("FROM     tmp库存 a " & vbCrLf)

            strSql.Append(" WHERE 1=1 ") 'T车型库存)
            'If clsT库存T.制造批量号 <> String.Empty Then
            '    strSql.Append(" AND a.制造批量号 =" & Utility.PFn_ChangeQuotation(clsT库存T.制造批量号) & vbCrLf)
            'End If
            'If clsT库存T.制造区分 <> String.Empty Then
            '    strSql.Append(" AND a.制造区分 =" & Utility.PFn_ChangeQuotation(clsT库存T.制造区分) & vbCrLf)
            'End If
            'If clsT库存T.部品番号 <> String.Empty Then
            '    strSql.Append(" AND a.部品番号 ='" & Utility.PFn_ChangeQuotation(clsT库存T.部品番号) & "'" & vbCrLf)
            'End If

            strSql.Append("GROUP BY a.制造批量号,a.部品番号,a.制造区分,a.库存状态")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal clsT库存T As B成品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(GetSql)

            strSql.Append("SELECT   a.制造批量号, " & vbCrLf)
            strSql.Append("         a.部品番号, " & vbCrLf)
            strSql.Append("         a.制造区分, " & vbCrLf)
            strSql.Append("         SUM(a.在库数量) AS 在库数量, " & vbCrLf)
            strSql.Append("         a.库存状态 " & vbCrLf)
            strSql.Append("FROM     tmp库存 a " & vbCrLf)
            strSql.Append(" WHERE 1=1 ") 'T车型库存)
            If clsT库存T.制造批量号 <> String.Empty Then
                strSql.Append(" AND a.制造批量号 ='" & Utility.PFn_ChangeQuotation(clsT库存T.制造批量号) & "'" & vbCrLf)
            End If
            'If clsT库存T.制造区分 <> String.Empty Then
            '    strSql.Append(" AND a.制造区分 ='" & Utility.PFn_ChangeQuotation(clsT库存T.制造区分) & "'" & vbCrLf)
            'End If
            'If clsT库存T.部品番号 <> String.Empty Then
            '    strSql.Append(" AND a.部品番号 ='" & Utility.PFn_ChangeQuotation(clsT库存T.部品番号) & "'" & vbCrLf)
            'End If

            strSql.Append("GROUP BY a.制造批量号,a.部品番号,a.制造区分,a.库存状态")


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
            strSql.Append("WITH tmp库存 " & vbCrLf)
            strSql.Append("     AS (SELECT   a.制造批量号, " & vbCrLf)
            strSql.Append("                  a.部品番号, " & vbCrLf)
            strSql.Append("                  b.客户编号, " & vbCrLf)
            strSql.Append("                  c.客户名称, " & vbCrLf)
            strSql.Append("                  e.金型番号名称 AS 型番, " & vbCrLf)
            strSql.Append("                  a.制造区分, " & vbCrLf)
            strSql.Append("                  a.库存状态 AS 库存状态cd, " & vbCrLf)
            strSql.Append("                  f.名称 AS 库存状态, " & vbCrLf)
            strSql.Append("                  Isnull(SUM(a.库存数量),0) AS 在库数量 " & vbCrLf)
            strSql.Append("         FROM     库存表 a " & vbCrLf)
            strSql.Append("                  LEFT JOIN m部品管理 b " & vbCrLf)
            strSql.Append("                    ON a.部品番号 = b.部品番号 " & vbCrLf)
            strSql.Append("                  LEFT JOIN m客户管理 c " & vbCrLf)
            strSql.Append("                    ON b.客户编号 = c.客户编号 " & vbCrLf)
            strSql.Append("                  LEFT JOIN 生产计划 d " & vbCrLf)
            strSql.Append("                    ON a.制造批量号 = d.制造批量号 " & vbCrLf)
            strSql.Append("                  LEFT JOIN m金型番号 e " & vbCrLf)
            strSql.Append("                    ON a.金型番号 = e.金型番号cd " & vbCrLf)
            strSql.Append("                  LEFT JOIN vm库存状态 f " & vbCrLf)
            strSql.Append("                    ON a.库存状态 = f.区分 " & vbCrLf)
            strSql.Append("         WHERE    a.制造区分 = '1' " & vbCrLf)
            'strSql.Append("                  AND a.库存状态 <> 4 " & vbCrLf)
            strSql.Append("         GROUP BY a.制造批量号,a.制造区分,a.部品番号,b.客户编号,c.客户名称,e.金型番号名称,f.名称,a.库存状态 " & vbCrLf)
            strSql.Append("         UNION  " & vbCrLf)
            strSql.Append("         SELECT   a.制造批量号, " & vbCrLf)
            strSql.Append("                  a.部品番号, " & vbCrLf)
            strSql.Append("                  c.客户编号, " & vbCrLf)
            strSql.Append("                  d.客户名称, " & vbCrLf)
            strSql.Append("                  '' AS 型番, " & vbCrLf)
            strSql.Append("                  a.制造区分, " & vbCrLf)
            strSql.Append("                  a.库存状态 AS 库存状态cd, " & vbCrLf)
            strSql.Append("                  e.名称 AS 库存状态, " & vbCrLf)
            strSql.Append("                  Isnull(SUM(a.库存数量),0) AS 在库数量 " & vbCrLf)
            strSql.Append("         FROM     库存表 a " & vbCrLf)
            strSql.Append("                  LEFT JOIN m组立品 c " & vbCrLf)
            strSql.Append("                    ON a.部品番号 = c.组立部番 " & vbCrLf)
            strSql.Append("                  LEFT JOIN m客户管理 d " & vbCrLf)
            strSql.Append("                    ON c.客户编号 = d.客户编号 " & vbCrLf)
            strSql.Append("                  LEFT JOIN vm库存状态 e " & vbCrLf)
            strSql.Append("                    ON a.库存状态 = e.区分 " & vbCrLf)
            strSql.Append("         WHERE    a.制造区分 = '2' " & vbCrLf)
            strSql.Append("         GROUP BY a.制造批量号,a.制造区分,a.部品番号,c.客户编号,d.客户名称,e.名称,a.库存状态) " & vbCrLf)



            Return strSql.ToString()
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


#Region " LoadLevel0 "

    '检索全部数据
    Public Function LoadLevel0(ByVal clsT成品库存T As B成品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT DISTINCT B成品库存表.订单编号,")
            strSql.Append("       vm订单区分.名称 AS 订单区分,")
            strSql.Append("       客户名称,")
            strSql.Append("       发货日期" & vbCrLf)
            strSql.Append("FROM  dbo.B成品库存表" & vbCrLf)
            strSql.Append("LEFT JOIN B订单管理 ON B订单管理.订单编号 = B成品库存表.订单编号" & vbCrLf)
            strSql.Append("                     AND B订单管理.产品图号 = B成品库存表.产品图号" & vbCrLf)
            strSql.Append("LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = B订单管理.客户编号" & vbCrLf)
            strSql.Append("LEFT JOIN dbo.VM订单区分 ON dbo.VM订单区分.区分=B订单管理.订单区分" & vbCrLf)
            strSql.Append("WHERE    1 = 1 " & vbCrLf)

            If clsT成品库存T.产品图号 <> String.Empty Then
                strSql.Append(" AND B成品库存表.产品图号 =" & Utility.PFn_ChangeQuotation(clsT成品库存T.产品图号) & vbCrLf)
            End If

            If clsT成品库存T.订单区分 <> String.Empty Then
                strSql.Append(" AND VM订单区分.区分 =" & Utility.PFn_ChangeQuotation(clsT成品库存T.订单区分) & vbCrLf)
            End If

            If clsT成品库存T.订单编号 <> String.Empty Then
                strSql.Append(" AND B成品库存表.订单编号 =" & Utility.PFn_ChangeQuotation(clsT成品库存T.订单编号) & vbCrLf)
            End If
            If clsT成品库存T.客户编号 <> String.Empty Then
                strSql.Append(" AND B订单管理.客户编号 =" & Utility.PFn_ChangeQuotation(clsT成品库存T.客户编号) & vbCrLf)
            End If
            If (clsT成品库存T.发货日期From <> "1900/1/1") Then
                strSql.Append(" AND B订单管理.发货日期 >=" & Utility.PFn_ChangeQuotation(clsT成品库存T.发货日期From) & vbCrLf)
            End If
            If (clsT成品库存T.发货日期To <> "1900/1/1") Then
                strSql.Append(" AND B订单管理.发货日期 <" & Utility.PFn_ChangeQuotation(clsT成品库存T.发货日期To.AddDays(1)) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadLevel1 "

    '检索全部数据
    Public Function LoadLevel1(ByVal clsT成品库存T As B成品库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT DISTINCT")
            strSql.Append("        B成品库存表.订单编号 ,")
            strSql.Append("        B成品库存表.产品图号 ,")
            strSql.Append("        品名 产品名称 ,")
            strSql.Append("        库存区域 ,")
            strSql.Append("        SUM(库存数量) [在库数量(个)] ,")
            strSql.Append("        SUM(库存重量) [在库重量(kg)] ,")
            strSql.Append("        VM库存状态.名称 库存状态 ,")
            strSql.Append("        入库日期" & vbCrLf)
            strSql.Append("FROM    dbo.B成品库存表")
            strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = B成品库存表.产品图号" & vbCrLf)
            strSql.Append("        LEFT JOIN B订单管理 ON B订单管理.订单编号 = B成品库存表.订单编号" & vbCrLf)
            strSql.Append("                     AND B订单管理.产品图号 = B成品库存表.产品图号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM库存状态 ON VM库存状态.区分 = B成品库存表.库存状态" & vbCrLf)
            strSql.Append("WHERE    1 = 1 AND VM库存状态.区分 = '1'" & vbCrLf)

            If clsT成品库存T.产品图号 <> String.Empty Then
                strSql.Append(" AND B成品库存表.产品图号=" & Utility.PFn_ChangeQuotation(clsT成品库存T.产品图号) & vbCrLf)
            End If

            If clsT成品库存T.订单编号 <> String.Empty Then
                strSql.Append(" AND B成品库存表.订单编号=" & Utility.PFn_ChangeQuotation(clsT成品库存T.订单编号) & vbCrLf)
            End If

            If (clsT成品库存T.发货日期From <> "1900/1/1") Then
                strSql.Append(" AND B订单管理.发货日期 >=" & Utility.PFn_ChangeQuotation(clsT成品库存T.发货日期From) & vbCrLf)
            End If
            If (clsT成品库存T.发货日期To <> "1900/1/1") Then
                strSql.Append(" AND B订单管理.发货日期 <" & Utility.PFn_ChangeQuotation(clsT成品库存T.发货日期To.AddDays(1)) & vbCrLf)
            End If

            strSql.Append("GROUP BY B成品库存表.订单编号 ,")
            strSql.Append("        B成品库存表.产品图号 ,")
            strSql.Append("        品名 ,")
            strSql.Append("        库存区域 ,")
            strSql.Append("        VM库存状态.名称 ,")
            strSql.Append("        入库日期")
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

        Dim clsT库存T As B成品库存T
        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            clsT库存T = New B成品库存T

            clsT库存T = arrayList(0)

            strSql.Append(GetSql)

            strSql.Append("SELECT   a.制造批量号, " & vbCrLf)
            strSql.Append("         Row_number() " & vbCrLf)
            strSql.Append("           OVER(ORDER BY a.制造批量号, a.部品番号,b.部品名称, a.型番) AS 序号, " & vbCrLf)
            strSql.Append("         a.部品番号 , " & vbCrLf)
            strSql.Append("         b.部品名称 , " & vbCrLf)
            strSql.Append("         SUM(a.在库数量) AS 数量, " & vbCrLf)
            strSql.Append("         a.型番, " & vbCrLf)
            strSql.Append("         '' AS 明细, " & vbCrLf)
            strSql.Append("         NULL AS 棚卸日, " & vbCrLf)
            strSql.Append("         '' AS 担当, " & vbCrLf)
            strSql.Append("         '' AS 确认 " & vbCrLf)
            strSql.Append("FROM     tmp库存 a " & vbCrLf)
            strSql.Append("         LEFT JOIN m部品管理 b " & vbCrLf)
            strSql.Append("           ON a.部品番号 = b.部品番号 " & vbCrLf)

            strSql.Append(" WHERE 1=1 ")
            If clsT库存T.制造批量号 <> String.Empty Then
                strSql.Append(" AND a.制造批量号 ='" & Utility.PFn_ChangeQuotation(clsT库存T.制造批量号) & "'" & vbCrLf)
            End If
            'If clsT库存T.制造区分 <> String.Empty Then
            '    strSql.Append(" AND a.制造区分 ='" & Utility.PFn_ChangeQuotation(clsT库存T.制造区分) & "'" & vbCrLf)
            'End If
            'If clsT库存T.部品番号 <> String.Empty Then
            '    strSql.Append(" AND a.部品番号 ='" & Utility.PFn_ChangeQuotation(clsT库存T.部品番号) & "'" & vbCrLf)
            'End If

            strSql.Append(" GROUP BY a.制造批量号,a.部品番号,b.部品名称,a.型番")


            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
