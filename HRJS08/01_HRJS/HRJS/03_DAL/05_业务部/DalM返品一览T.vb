Imports System.Text

#Region "Dal入出库记录
'------------------------------------------------------------------------------------
'   说明
'       入出库记录的数据库操作SQL文
'   创建人
'       大连智云科技 解辉品
'   创建时间
'       2016/5/24
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalM返品一览T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls入出库记录T As B原材料入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B原材料入出库记录")            '入出库记录

            strSql.Append(" (入出库单号")          '入出库单号
            strSql.Append(" ,出荷指示编号")
            strSql.Append(" ,制造批量号")          '制造批量号
            strSql.Append(" ,入出库区分")          '入出库区分
            strSql.Append(" ,入出库数量")         '数量
            strSql.Append(" ,入出库日期")         '日期
            strSql.Append(" ,备注")         '日期
            strSql.Append(")")

            strSql.Append(" VALUES ")

            ''入出库单号
            'strSql.Append(" ('" & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库单号) & "'")

            ''出荷指示编号
            'If cls入出库记录T.出荷指示编号 = 0 Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append("," & cls入出库记录T.出荷指示编号)
            'End If

            ''制造批量号
            'strSql.Append(" ,'" & Utility.PFn_ChangeQuotation(cls入出库记录T.制造批量号) & "'")


            ''入出库区分
            'If cls入出库记录T.入出库区分 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库区分) & "'")
            'End If

            ''数量
            'If cls入出库记录T.入出库数量 = 0 Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ," & cls入出库记录T.入出库数量)
            'End If

            ''日期
            'If cls入出库记录T.入出库日期 = "1900/01/01 0:00:00" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(",'" & cls入出库记录T.入出库日期 & "'")
            'End If

            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal cls入出库记录T As B原材料入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B原材料入出库记录 ") '入出库记录
            strSql.Append(" SET ")

            ''制造批量号
            'strSql.Append(" ,制造批量号 = '" & Utility.PFn_ChangeQuotation(cls入出库记录T.制造批量号) & "'")

            ''入出库区分
            'If cls入出库记录T.入出库区分 = "" Then
            '    strSql.Append(" ,入出库区分 = NULL ")
            'Else
            '    strSql.Append(" ,入出库区分 = '" & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库区分) & "'")
            'End If

            ''数量
            'If cls入出库记录T.入出库数量 = 0 Then
            '    strSql.Append(" ,数量 = NULL ")
            'Else
            '    strSql.Append(" ,数量 = " & cls入出库记录T.入出库数量)
            'End If

            ''日期
            'If cls入出库记录T.入出库日期 = "1900/01/01 0:00:00" Then
            '    strSql.Append(" ,日期 = NULL ")
            'Else
            '    strSql.Append(" ,日期 = '" & cls入出库记录T.入出库日期 & "'")
            'End If

            strSql.Append(" WHERE ")
            strSql.Append(" 入出库记录CD = " & cls入出库记录T.入出库记录CD) '入出库单号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls入出库记录T As B原材料入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM B原材料入出库记录 ") '入出库记录)

            strSql.Append(" WHERE ")
            strSql.Append(" 入出库记录CD = " & cls入出库记录T.入出库记录CD) '入出库单号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal cls入出库记录T As B原材料入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT ")

            strSql.Append("  入出库记录.入出库单号 AS 入出库单号")           '入出库单号
            strSql.Append(" ,入出库记录.材料编号 AS 材料编号")         '部品番号
            strSql.Append(" ,入出库记录.材料批号 AS 材料批号")           '制造批量号
            strSql.Append(" ,ISNULL(入出库记录.订单编号,'') AS 订单编号")          '部品区分
            strSql.Append(" ,ISNULL(入出库记录.入出库区分,'') AS 入出库区分")            '入出库区分
            strSql.Append(" ,ISNULL(入出库记录.入出库数量,0) AS [数量（个）]")           '数量
            strSql.Append(" ,ISNULL(入出库记录.入出库重量,0) AS [重量（kg）]")           '数量
            strSql.Append(" ,入出库记录.入出库日期 AS 入出库日期")         '日期

            strSql.Append(" FROM B原材料入出库记录 入出库记录 ") '入出库记录)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls返品一览T As B返品一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT DISTINCT")
            strSql.Append("        B成品入出库记录.订单编号 ,")
            strSql.Append("        B成品入出库记录.产品图号 ,")
            strSql.Append("        品名 产品名称 ,")
            strSql.Append("        客户名称 ,")
            strSql.Append("        完成日 生产日期 ,")
            strSql.Append("        入出库数量 返品数量 ,")
            strSql.Append("        VM库存状态.名称 库存状态" & vbCrLf)
            strSql.Append("FROM    dbo.B成品入出库记录" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = B成品入出库记录.产品图号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.Z生产计划制定 ON Z生产计划制定.订单编号 = B成品入出库记录.订单编号" & vbCrLf)
            strSql.Append("                                 AND Z生产计划制定.主图号 = B成品入出库记录.产品图号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = T图纸管理.客户编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM库存状态 ON VM库存状态.区分=B成品入出库记录.库存状态" & vbCrLf)
            strSql.Append(" WHERE  1 = 1 and  库存状态='2'    " & vbCrLf)
            If Not String.IsNullOrEmpty(cls返品一览T.客户编号) Then
                strSql.Append("       AND M客户管理.客户编号 = " & Utility.PFn_ChangeQuotation(cls返品一览T.客户编号) & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(cls返品一览T.产品图号) Then
                strSql.Append("       AND B成品入出库记录.产品图号 = " & Utility.PFn_ChangeQuotation(cls返品一览T.产品图号) & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(cls返品一览T.订单编号) Then
                strSql.Append("       AND Z生产计划制定.订单编号 = " & Utility.PFn_ChangeQuotation(cls返品一览T.订单编号) & vbCrLf)
            End If
            If cls返品一览T.开始日期 <> "1900/1/1" Then
                strSql.Append(" AND Z生产计划制定.完成日 >=" & Utility.PFn_ChangeQuotation(cls返品一览T.开始日期) & vbCrLf)
            End If
            If cls返品一览T.结束日期 <> "1900/1/1" Then
                strSql.Append(" AND Z生产计划制定.完成日 <" & Utility.PFn_ChangeQuotation(cls返品一览T.结束日期.AddDays(1)) & vbCrLf)
            End If

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
