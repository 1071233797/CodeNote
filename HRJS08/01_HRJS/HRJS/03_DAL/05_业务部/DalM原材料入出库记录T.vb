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

Public Class DalM原材料入出库记录T

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
    Public Function LoadByWhere(ByVal cls入出库记录T As B原材料入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  DISTINCT  " & vbCrLf)
            strSql.Append("        VM入出库区分.名称 区分 ,  " & vbCrLf)
            strSql.Append("        入出库记录.入出库编号 入出库单号 ,  " & vbCrLf)
            strSql.Append("        采购.订单编号 ,  " & vbCrLf)
            strSql.Append("        原材料信息.原材料名称 AS 材料名称 ,  " & vbCrLf)
            strSql.Append("        入出库记录.批次号 材料批号 ,  " & vbCrLf)
            'strSql.Append("        VM材料区分.名称 材料区分 ,  " & vbCrLf)
            strSql.Append("        原材料信息.原材料名称 AS 材料名称 ,  " & vbCrLf)
            strSql.Append("        VM材质.名称 AS [材质/型号] ,  " & vbCrLf)
            strSql.Append("        客户.客户名称 AS 客户名称 ,  " & vbCrLf)
            strSql.Append("        入出库记录.入出库日期 ,  " & vbCrLf)
            strSql.Append("        入出库记录.库存区域 入出库区域 ,  " & vbCrLf)
            strSql.Append("        入出库记录.入出库数量 AS [数量（个）] ,  " & vbCrLf)
            strSql.Append("        入出库记录.入出库重量 AS [重量（kg）] ,  " & vbCrLf)
            strSql.Append("        供应商.供应商名称 AS 供应商名称 ,  " & vbCrLf)
            strSql.Append("        订单.客户编号 ,  " & vbCrLf)
            strSql.Append("        入出库记录.材料编号 ,  " & vbCrLf)
            strSql.Append("        采购.供应商编号  " & vbCrLf)
            strSql.Append("FROM    B原材料入出库记录 入出库记录  " & vbCrLf)
            strSql.Append("        LEFT JOIN M原材料信息 原材料信息 ON 入出库记录.材料编号 = 原材料信息.原材料编号  " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.B原材料入库申请 入库 ON 入库.批次号 = 入出库记录.批次号  " & vbCrLf)
            strSql.Append("                                     AND 入库.材料编号 = 入出库记录.材料编号  " & vbCrLf)
            strSql.Append("                                           LEFT JOIN dbo.B原材料采购管理 采购 ON 采购.采购单编号 = 入库.采购单编号  " & vbCrLf)
            strSql.Append("                                     AND 采购.材料编号 = 入库.材料编号  " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.B订单管理 订单 ON 订单.订单编号 = 采购.订单编号  " & vbCrLf)
            strSql.Append("        LEFT JOIN M客户管理 客户 ON 订单.客户编号 = 客户.客户编号  " & vbCrLf)
            strSql.Append("        LEFT JOIN M供应商管理 供应商 ON 采购.供应商编号 = 供应商.供应商编号  " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM材料区分 ON VM材料区分.区分=原材料信息.原材料区分 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM材质 ON VM材质.区分=原材料信息.材质 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM入出库区分 ON VM入出库区分.区分=入出库记录.入出库区分 " & vbCrLf)
            strSql.Append("WHERE   1 = 1  " & vbCrLf)

            If Not String.IsNullOrEmpty(cls入出库记录T.入出库区分) Then
                strSql.Append("       AND 入出库记录.入出库区分 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库区分) & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(cls入出库记录T.入出库申请单编号) Then
                strSql.Append("       AND 入出库记录.入出库编号 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库申请单编号) & vbCrLf)
            End If
            If cls入出库记录T.开始日期 <> "1900/1/1" Then
                strSql.Append(" AND 入出库记录.入出库日期 >=" & Utility.PFn_ChangeQuotation(cls入出库记录T.开始日期) & vbCrLf)
            End If
            If cls入出库记录T.结束日期 <> "1900/1/1" Then
                strSql.Append(" AND 入出库记录.入出库日期 <" & Utility.PFn_ChangeQuotation(cls入出库记录T.结束日期.AddDays(1)) & vbCrLf)
            End If
            'If cls入出库记录T.开始日期 <> "1900/1/1" Then
            '    strSql.Append("       AND  CONVERT(VARCHAR(10),入出库记录.入出库日期,120)  >= '" & Utility.PFn_ChangeQuotation(cls入出库记录T.开始日期.ToString("yyyy-MM-dd")) & "' " & vbCrLf)
            'End If
            'If cls入出库记录T.结束日期 <> "1900/1/1" Then
            '    strSql.Append("       AND CONVERT(VARCHAR(10),入出库记录.入出库日期,120) <= '" & Utility.PFn_ChangeQuotation(cls入出库记录T.结束日期.ToString("yyyy-MM-dd")) & "' " & vbCrLf)
            'End If
            'If Not String.IsNullOrEmpty(cls入出库记录T.材料区分) Then
            '    strSql.Append("       AND 原材料信息.原材料区分 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.材料区分) & vbCrLf)
            'End If
            If Not String.IsNullOrEmpty(cls入出库记录T.材料编号) Then
                strSql.Append("       AND 入出库记录.材料编号 like '" & Utility.PFn_ChangeQuotation(cls入出库记录T.材料编号, True) & "' " & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(cls入出库记录T.供应商编号) Then
                strSql.Append("       AND 采购.供应商编号 like '" & Utility.PFn_ChangeQuotation(cls入出库记录T.供应商编号, True) & "'")
            End If

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
