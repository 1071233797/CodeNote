Imports System.Text

Public Class DalM原材料库存T

#Region " Insert "

#End Region

#Region " Update "

    '数据更新操作 
#End Region

#Region " Delete "

    '数据删除操作 
#End Region

#Region " LoadCodeAllu "

    '检索全部数据
    Public Function LoadCodeAll(ByVal clsT原材料库存T As M原材料库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  TOP 1 材料编号, " & vbCrLf)
            strSql.Append("       材料区分, " & vbCrLf)
            strSql.Append("       材料类别, " & vbCrLf)
            strSql.Append("       材质型号 " & vbCrLf)
    
            strSql.Append("FROM   B原材料库存表")
            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 材料编号 =" & Utility.PFn_ChangeQuotation(clsT原材料库存T.材料编号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPKey "

    '检索全部数据
    Public Function LoadByPKey(ByVal clsT原材料库存T As M原材料库存T) As String

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
            'If clsT原材料库存T.制造批量号 <> String.Empty Then
            '    strSql.Append(" AND a.制造批量号 ='" & Utility.PFn_ChangeQuotation(clsT原材料库存T.制造批量号) & "'" & vbCrLf)
            'End If
            'If clsT原材料库存T.制造区分 <> String.Empty Then
            '    strSql.Append(" AND a.制造区分 ='" & Utility.PFn_ChangeQuotation(clsT原材料库存T.制造区分) & "'" & vbCrLf)
            'End If
            'If clsT原材料库存T.部品番号 <> String.Empty Then
            '    strSql.Append(" AND a.部品番号 ='" & Utility.PFn_ChangeQuotation(clsT原材料库存T.部品番号) & "'" & vbCrLf)
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
    Public Function LoadByWhere(ByVal clsT原材料库存T As M原材料库存T) As String

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
            'If clsT原材料库存T.制造批量号 <> String.Empty Then
            '    strSql.Append(" AND a.制造批量号 ='" & Utility.PFn_ChangeQuotation(clsT原材料库存T.制造批量号) & "'" & vbCrLf)
            'End If
            'If clsT原材料库存T.制造区分 <> String.Empty Then
            '    strSql.Append(" AND a.制造区分 ='" & Utility.PFn_ChangeQuotation(clsT原材料库存T.制造区分) & "'" & vbCrLf)
            'End If
            'If clsT原材料库存T.部品番号 <> String.Empty Then
            '    strSql.Append(" AND a.部品番号 ='" & Utility.PFn_ChangeQuotation(clsT原材料库存T.部品番号) & "'" & vbCrLf)
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
    Public Function LoadLevel0(ByVal clsT原材料库存T As M原材料库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  'false' AS 选择 , " & vbCrLf)
            strSql.Append("        原材料.材料编号 , " & vbCrLf)
            strSql.Append("        M原材料信息.原材料名称 AS 材料名称 , " & vbCrLf)
            strSql.Append("        VM材料区分.名称 材料区分, " & vbCrLf)
            strSql.Append("        VM材质.名称 材质 , " & vbCrLf)
            strSql.Append("        VM材料种类.名称 材料种类, " & vbCrLf)
            strSql.Append("        ISNULL(SUM(原材料.库存数量), 0) AS [数量（个）] , " & vbCrLf)
            strSql.Append("        ISNULL(SUM(原材料.库存重量), 0) AS [重量（kg）] " & vbCrLf)
            strSql.Append("FROM    B原材料库存表 原材料 " & vbCrLf)
            strSql.Append("        LEFT JOIN M原材料信息 ON 原材料.材料编号 = M原材料信息.原材料编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.B原材料采购管理 ON B原材料采购管理.材料编号 = 原材料.材料编号" & vbCrLf)
            strSql.Append("        LEFT JOIN M供应商管理 " & vbCrLf)
            strSql.Append("         ON B原材料采购管理.供应商编号 =M供应商管理.供应商编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN VM材料区分 ON VM材料区分.区分=M原材料信息.原材料区分" & vbCrLf)
            strSql.Append("       LEFT JOIN VM材质 ON VM材质.区分=M原材料信息.材质" & vbCrLf)
            strSql.Append("       LEFT JOIN VM材料种类 ON VM材料种类.区分=M原材料信息.材料种类" & vbCrLf)
            strSql.Append("WHERE   1 = 1 " & vbCrLf)

            If clsT原材料库存T.材料编号 <> String.Empty Then
                strSql.Append(" AND 原材料.材料编号=" & Utility.PFn_ChangeQuotation(clsT原材料库存T.材料编号) & vbCrLf)
            End If

            If clsT原材料库存T.材料区分 <> String.Empty Then
                strSql.Append(" AND VM材料区分.区分 =" & Utility.PFn_ChangeQuotation(clsT原材料库存T.材料区分) & vbCrLf)
            End If

            If clsT原材料库存T.材料类别 <> String.Empty Then
                strSql.Append(" AND VM材料种类.区分 =" & Utility.PFn_ChangeQuotation(clsT原材料库存T.材料类别) & vbCrLf)
            End If

            If clsT原材料库存T.材质型号 <> String.Empty Then
                strSql.Append(" AND M原材料信息.材质=" & Utility.PFn_ChangeQuotation(clsT原材料库存T.材质型号) & vbCrLf)
            End If
            If clsT原材料库存T.供应商编号 <> String.Empty Then
                strSql.Append(" AND B原材料采购管理.供应商编号=" & Utility.PFn_ChangeQuotation(clsT原材料库存T.供应商编号) & vbCrLf)
            End If
            'If (clsT原材料库存T.入库日期From <> "1900/1/1") Then
            '    strSql.Append(" AND 原材料.入库日期 >=" & Utility.PFn_ChangeQuotation(clsT原材料库存T.入库日期From) & vbCrLf)
            'End If
            'If (clsT原材料库存T.入库日期To <> "1900/1/1") Then
            '    strSql.Append(" AND 原材料.入库日期 <" & Utility.PFn_ChangeQuotation(clsT原材料库存T.入库日期To.AddDays(1)) & vbCrLf)
            'End If

            strSql.Append("GROUP BY M原材料信息.原材料名称 ,VM材料区分.名称 ,原材料.材料编号 ,VM材料种类.名称 ,VM材质.名称 " & vbCrLf)

            strSql.Append(" HAVING  SUM(原材料.库存数量)>0 or SUM(原材料.库存重量)>0" & vbCrLf)
            strSql.Append("ORDER BY 原材料.材料编号" & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadLevel1 "

    '检索全部数据
    Public Function LoadLevel1(ByVal clsT原材料库存T As M原材料库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT    原材料.材料编号 " & vbCrLf)
            strSql.Append("         ,原材料.批次号 " & vbCrLf)
            strSql.Append("         ,原材料.库存区域 " & vbCrLf)
            strSql.Append("         , isnull(原材料.库存数量,0) AS [数量（个）] " & vbCrLf)
            strSql.Append("         , isnull(原材料.库存重量,0) AS [重量（kg）] " & vbCrLf)
            'strSql.Append("         , M供应商管理.供应商名称 AS 材料供应商 " & vbCrLf)
            strSql.Append("         ,原材料.入库日期 AS 入库日期 " & vbCrLf)
            strSql.Append("         ,B原材料采购管理.含税单价 AS 含税单价 " & vbCrLf)
            'strSql.Append("         ,原材料.含税总金额 AS 结算金额 " & vbCrLf)
            strSql.Append("         ,原材料.备注 AS 备注 " & vbCrLf)

            strSql.Append("FROM     B原材料库存表 原材料 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.M原材料信息 ON 原材料.材料编号=原材料编号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.B原材料采购管理 ON B原材料采购管理.材料编号 = 原材料.材料编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN VM材料区分 ON VM材料区分.区分=M原材料信息.原材料区分" & vbCrLf)
            strSql.Append("       LEFT JOIN VM材料种类 ON VM材料种类.区分=M原材料信息.材料种类" & vbCrLf)

            strSql.Append("WHERE    1 = 1 " & vbCrLf)

            If clsT原材料库存T.材料编号 <> String.Empty Then
                strSql.Append(" AND 原材料.材料编号=" & Utility.PFn_ChangeQuotation(clsT原材料库存T.材料编号) & vbCrLf)
            End If

            If clsT原材料库存T.材料区分 <> String.Empty Then
                strSql.Append(" AND VM材料区分.区分 =" & Utility.PFn_ChangeQuotation(clsT原材料库存T.材料区分) & vbCrLf)
            End If

            If clsT原材料库存T.材料类别 <> String.Empty Then
                strSql.Append(" AND VM材料种类.区分 =" & Utility.PFn_ChangeQuotation(clsT原材料库存T.材料类别) & vbCrLf)
            End If

            If clsT原材料库存T.材质型号 <> String.Empty Then
                strSql.Append(" AND M原材料信息.材质=" & Utility.PFn_ChangeQuotation(clsT原材料库存T.材质型号) & vbCrLf)
            End If
            If clsT原材料库存T.供应商编号 <> String.Empty Then
                strSql.Append(" AND B原材料采购管理.供应商编号 =" & Utility.PFn_ChangeQuotation(clsT原材料库存T.供应商编号) & vbCrLf)
            End If
            'If (clsT原材料库存T.入库日期From <> "1900/1/1") Then
            '    strSql.Append(" AND 原材料.入库日期 >=" & Utility.PFn_ChangeQuotation(clsT原材料库存T.入库日期From) & vbCrLf)
            'End If
            'If (clsT原材料库存T.入库日期To <> "1900/1/1") Then
            '    strSql.Append(" AND 原材料.入库日期 <" & Utility.PFn_ChangeQuotation(clsT原材料库存T.入库日期To.AddDays(1)) & vbCrLf)
            'End If

            strSql.Append("GROUP BY 原材料.材料编号 ,原材料.批次号,原材料.库存区域 ,原材料.库存数量 ,原材料.库存重量,原材料.入库日期,B原材料采购管理.含税单价,原材料.备注 " & vbCrLf)
            strSql.Append(" HAVING  SUM(原材料.库存数量)>0 or SUM(原材料.库存重量)>0 " & vbCrLf)
            strSql.Append("ORDER BY 原材料.批次号" & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadRepot "

    '检索全部数据
    Public Function LoadRepot(ByVal clsT原材料库存T As M原材料库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT ")
            strSql.Append("        原材料.材料编号 ,")
            strSql.Append("        M原材料信息.原材料名称 AS 材料名称 ,")
            strSql.Append("        VM材料区分.名称 材料区分 ,")
            strSql.Append("        VM材质.名称 材质 ,")
            strSql.Append("        VM材料种类.名称 材料种类 ,")
            strSql.Append("        原材料.批次号 ,")
            strSql.Append("        原材料.库存区域 ,")
            strSql.Append("        ISNULL(原材料.库存数量, 0) AS [数量（个）] ,")
            strSql.Append("        ISNULL(原材料.库存重量, 0) AS [重量（kg）] ,")
            strSql.Append("        M供应商管理.供应商名称 AS 材料供应商 ,")
            strSql.Append("        原材料.入库日期 AS 入库日期 ,")
            strSql.Append("        M原材料信息.含税单价 AS 含税单价 ,")
            strSql.Append("        原材料.备注 AS 备注" & vbCrLf)
            strSql.Append("FROM    B原材料库存表 原材料" & vbCrLf)
            strSql.Append("        LEFT JOIN M原材料信息 ON 原材料.材料编号 = M原材料信息.原材料编号" & vbCrLf)
            strSql.Append("        LEFT JOIN M供应商管理 ON M原材料信息.供应商编号 = M供应商管理.供应商编号" & vbCrLf)
            strSql.Append("        LEFT JOIN VM材料区分 ON VM材料区分.区分 = M原材料信息.原材料区分" & vbCrLf)
            strSql.Append("        LEFT JOIN VM材质 ON VM材质.区分 = M原材料信息.材质" & vbCrLf)
            strSql.Append("        LEFT JOIN VM材料种类 ON VM材料种类.区分 = M原材料信息.材料种类" & vbCrLf)
            strSql.Append("WHERE   " & vbCrLf)
            If clsT原材料库存T.材料编号 <> String.Empty Then
                strSql.Append(" 原材料.材料编号 in ('" & clsT原材料库存T.材料编号 & "')" & vbCrLf)
            End If
            strSql.Append("GROUP BY M原材料信息.原材料名称 ,")
            strSql.Append("        VM材料区分.名称 ,")
            strSql.Append("        原材料.材料编号 ,")
            strSql.Append("        VM材料种类.名称 ,")
            strSql.Append("        VM材质.名称 ,")
            strSql.Append("        原材料.材料编号 ,")
            strSql.Append("        原材料.批次号 ,")
            strSql.Append("        原材料.库存区域 ,")
            strSql.Append("        原材料.库存数量 ,")
            strSql.Append("        原材料.库存重量 ,")
            strSql.Append("        M供应商管理.供应商名称 ,")
            strSql.Append("        原材料.入库日期 ,")
            strSql.Append("        M原材料信息.含税单价 ,")
            strSql.Append("        原材料.备注" & vbCrLf)
            strSql.Append("HAVING  SUM(原材料.库存数量) > 0")
            strSql.Append("        OR SUM(原材料.库存重量) > 0")
            strSql.Append("ORDER BY 原材料.材料编号")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

    Public Function LoadToFile(ByVal clsM原材料库存T As M原材料库存T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  DISTINCT B原材料库存表.材料编号, ")
            strSql.Append("         材料名称 , ")
            strSql.Append("         材料型号 , ")
            strSql.Append("         材料区分 , ")
            strSql.Append("         材质型号 , ")
            strSql.Append("         材料类别 , ")
            strSql.Append("         库存总数量 , ")
            strSql.Append("         库存总重量 , ")
            'strSql.Append("         ISNULL(批次, '') 批次 , ")
            strSql.Append("         库存区域 , ")
            strSql.Append("         库存数量 , ")
            strSql.Append("         库存重量 , ")
            strSql.Append("         , M供应商管理.供应商名称 AS 材料供应商 " & vbCrLf)
            strSql.Append("         入库日期 , ")
            strSql.Append("         含税单价 , ")
            strSql.Append("         含税总金额 , ")
            strSql.Append("         备注 , ")
            
            strSql.Append(" WHERE 1=1 " & vbCrLf)

            If clsM原材料库存T.材料编号 <> String.Empty Then
                'strSql.Append(" AND B原材料库存表.材料编号='" & Utility.ChangeQuotation(clsM原材料库存T.材料编号) & "'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY M零部件.零部件CD,零部件名,批次,数量 ")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

End Class



Public Class DalM原材料标签打印T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls原材料标签打印T As B原材料标签打印T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B原材料标签打印记录")          '原材料标签打印

            strSql.Append(" (入库申请单编号")          '材料编号
            strSql.Append(" ,材料编号")
            strSql.Append(" ,批次号")
            strSql.Append(" ,长")
            strSql.Append(" ,宽")
            strSql.Append(" ,高")
            strSql.Append(" ,数量")              '数量
            strSql.Append(" ,重量")              '重量
            strSql.Append(" ,货位编号")          '库存数量
            strSql.Append(" ,打印者编号")            '打印者
            strSql.Append(" ,打印时间")          '打印时间
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.申请单编号))

            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.材料编号))
            '批次
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.批次))
            '长
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.长))
            '宽
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.宽))
            '高
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.高))
            '数量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.数量))
            '重量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.重量))
            '库存区域
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.库存区域))
            '打印者
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.打印者))
            '打印时间
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料标签打印T.打印时间))
            strSql.Append(" )")
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region
    Public Function SetData(ByVal clsM原材料T As B原材料标签打印T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  DISTINCT ")
            strSql.Append("         批次号, ")
            strSql.Append("         M原材料信息.原材料名称, ")
            strSql.Append("         长, ")
            strSql.Append("         宽, ")
            strSql.Append("         高, ")
            strSql.Append("         入库数量, ")
            strSql.Append("         入库重量 ")
            strSql.Append("From B原材料入库申请" & vbCrLf)
            strSql.Append("LEFT JOIN M原材料信息 ON M原材料信息.原材料编号=B原材料入库申请.材料编号" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)

            If clsM原材料T.申请单编号 <> String.Empty Then
                strSql.Append(" 申请单编号=" & Utility.PFn_ChangeQuotation(clsM原材料T.申请单编号) & vbCrLf)
            End If
            If clsM原材料T.材料编号 <> String.Empty Then
                strSql.Append(" AND 材料编号=" & Utility.PFn_ChangeQuotation(clsM原材料T.材料编号) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

End Class

