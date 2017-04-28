Imports System.Text
Public Class DalM出荷指示T

#Region "IsExists"

    Public Function IsExists(ByVal str报废品订单编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   B报废品 " & vbCrLf)
            strSql.Append("WHERE  报废品订单编号 = " & Utility.PFn_ChangeQuotation(str报废品订单编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objM出荷指示T As B出荷指示T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B出荷指示" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            'strSql.Append(" 	出荷指示编号" & vbCrLf)
            strSql.Append(" 	订单编号 " & vbCrLf)
            strSql.Append(" 	,产品图号 " & vbCrLf)
            strSql.Append(" 	,出荷数量 " & vbCrLf)
            strSql.Append(" 	,出荷预定日" & vbCrLf)
            strSql.Append(" 	,备注 " & vbCrLf)
            strSql.Append("  )" & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            'strSql.AppendFormat("  {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.出荷指示编号))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.订单编号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.产品图号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.出荷数量))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.出荷预定日))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.备注))
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
    Public Function Update(ByVal objM出荷指示T As B出荷指示T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       B报废品 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)

            'strSQL.AppendFormat(" 		报废品订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.报废品订单编号))
            ''If Not objM模具T.模具型号 = "" Then
            'strSQL.AppendFormat(" 		,客户名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.客户名称))
            ''End If
            ''If Not objM模具T.维护周期 = "" Then
            'strSQL.AppendFormat(" 		,发货日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.发货日期))
            ''End If
            ''If Not objM模具T.上次维护日期 = "" Then
            'strSQL.AppendFormat(" 		,报废品图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.报废品图号))
            ''End If
            ''If Not objM模具T.使用状态 = "" Then
            'strSQL.AppendFormat(" 		,总图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.总图号))
            ''End If
            'strSQL.AppendFormat(" 		,报废品产生工序 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.报废品产生工序))

            'strSQL.AppendFormat(" 		,报废品数量 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.报废品数量))

            'strSQL.AppendFormat(" 		,报废品生产者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.报废品生产者))

            'strSQL.AppendFormat(" 		,报废日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.报废日期))

            ''If Not objM模具T.模具产量 = "" Then
            'strSQL.AppendFormat(" 		,报废原因 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.报废原因))
            ''End If
            ''If Not objM模具T.维护厂商 = "" Then
            'strSQL.AppendFormat(" 		,处理结果 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.处理结果))
            ''End If
            ''If Not objM模具T.维护负责人 = "" Then
            'strSQL.AppendFormat(" 		,备注 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.备注))
            ''End If

            'If objM出荷指示T.pic1 <> "" Then
            '    strSQL.AppendFormat(" 		,pic1 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.pic1))
            'End If

            'If objM出荷指示T.pic2 <> "" Then
            '    strSQL.AppendFormat(" 		,pic2 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.pic2))
            'End If

            'If objM出荷指示T.pic3 <> "" Then
            '    strSQL.AppendFormat(" 		,pic3 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.pic3))
            'End If
            'strSQL.AppendFormat(" 		,更新者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.更新者))
            'strSQL.AppendFormat(" 		,更新日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.更新日期))


            'strSQL.Append("  WHERE " & vbCrLf)
            'strSQL.AppendFormat("    报废品订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.报废品订单编号))

            'Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal objM出荷指示T As B出荷指示T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM B出荷指示" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM出荷指示T.订单编号))
            'SQLに戻る
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal objM出荷指示T As B出荷指示T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT")
            strSql.Append("        订单.订单编号 ,")
            strSql.Append("        发货日期 出荷日期 ,")
            strSql.Append("        客户名称 ,")
            strSql.Append("        订单.交货方式 出荷方式" & vbCrLf)
            strSql.Append("FROM    dbo.B订单管理 订单")
            strSql.Append("        LEFT JOIN dbo.M客户管理 客户 ON 客户.客户编号 = 订单.客户编号")
            strSql.Append("        LEFT JOIN dbo.VM交货方式 ON VM交货方式.区分 = 订单.交货方式" & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 订单.订单编号=" & Utility.PFn_ChangeQuotation(objM出荷指示T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadHead "

    '检索全部数据
    Public Function LoadHead(ByVal objM出荷指示T As B出荷指示T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT")
            strSql.Append("        订单.订单编号 ,")
            strSql.Append("        发货日期 出荷日期 ,")
            strSql.Append("        客户名称 ,")
            strSql.Append("        VM交货方式.名称 出荷方式," & vbCrLf)
            strSql.Append("        B出荷指示.出荷预定日," & vbCrLf)
            strSql.Append("        B出荷指示.备注" & vbCrLf)
            strSql.Append("FROM    dbo.B订单管理 订单")
            strSql.Append("        LEFT JOIN dbo.M客户管理 客户 ON 客户.客户编号 = 订单.客户编号")
            strSql.Append("        LEFT JOIN dbo.VM交货方式 ON VM交货方式.区分 = 订单.交货方式")
            strSql.Append("        LEFT JOIN B出荷指示 ON B出荷指示.订单编号 = 订单.订单编号")
            strSql.Append("                           AND B出荷指示.产品图号 = 订单.产品图号" & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 订单.订单编号=" & Utility.PFn_ChangeQuotation(objM出荷指示T.订单编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Load订单 "

    '检索全部数据
    Public Function Load订单(ByVal objM出荷指示T As B出荷指示T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT")
            strSql.Append("        订单.产品图号 ,")
            strSql.Append("        品名 产品名称 ,")
            strSql.Append("        订单数量 ,")
            strSql.Append("        出荷数量 已出荷数量 ,")
            strSql.Append("        库存数量 在库数量 ,")
            strSql.Append("        B出荷指示.出荷数量" & vbCrLf)
            strSql.Append("FROM    dbo.B订单管理 订单")
            strSql.Append("        LEFT JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = 订单.产品图号")
            strSql.Append("        LEFT JOIN dbo.B成品库存表 库存 ON 库存.订单编号 = 订单.订单编号")
            strSql.Append("                                   AND 库存.产品图号 = 订单.产品图号")
            strSql.Append("        LEFT JOIN B出荷指示 ON B出荷指示.订单编号 = 订单.订单编号")
            strSql.Append("                           AND B出荷指示.产品图号 = 订单.产品图号")
            '检索条件 设定
            strSql.Append(" WHERE 订单.订单编号=" & Utility.PFn_ChangeQuotation(objM出荷指示T.订单编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal objM出荷指示T As B出荷指示T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	出荷指示编号" & vbCrLf)
            ' strSql.Append(" 	,模具名称 " & vbCrLf)

            strSql.Append(" FROM B出荷指示")
            '检索条件 设定
            'strSql.Append(" WHERE 报废品订单编号=" & Utility.PFn_ChangeQuotation(objM出荷指示T.报废品订单编号) & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据
    Public Function LoadByWhere(ByVal objM出荷指示T As B出荷指示T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT")
            strSql.Append("        'false' 选择 ,")
            strSql.Append("        出荷.订单编号 ,")
            strSql.Append("        出荷.产品图号 ,")
            strSql.Append("        客户名称 ,")
            strSql.Append("        订单数量 ,")
            strSql.Append("        出荷预定日 出荷日期,")
            strSql.Append("        出荷数量 ,")
            strSql.Append("        VM交货方式.名称 出荷方式 ,")
            strSql.Append("        含税单价 产品单价 ,")
            strSql.Append("        出荷.备注" & vbCrLf)
            strSql.Append("FROM    dbo.B出荷指示 出荷")
            strSql.Append("        LEFT JOIN B订单管理 订单 ON 出荷.订单编号 = 订单.订单编号")
            strSql.Append("                              AND 出荷.产品图号 = 订单.产品图号")
            strSql.Append("        LEFT JOIN dbo.M客户管理 客户 ON 客户.客户编号 = 订单.客户编号")
            strSql.Append("        LEFT JOIN dbo.VM交货方式 ON VM交货方式.区分 = 订单.交货方式" & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM出荷指示T.产品图号 <> String.Empty) Then
                strSql.Append(" AND 出荷.产品图号 =" & Utility.PFn_ChangeQuotation(objM出荷指示T.产品图号) & vbCrLf)
            End If
            If (objM出荷指示T.订单编号 <> String.Empty) Then
                strSql.Append(" AND 出荷.订单编号 =" & Utility.PFn_ChangeQuotation(objM出荷指示T.订单编号) & vbCrLf)
            End If
            If (objM出荷指示T.客户编号 <> String.Empty) Then
                strSql.Append(" AND 客户.客户编号 =" & Utility.PFn_ChangeQuotation(objM出荷指示T.客户编号) & vbCrLf)
            End If

            If (objM出荷指示T.出荷方式 <> String.Empty) Then
                strSql.Append(" AND VM交货方式.区分=" & Utility.PFn_ChangeQuotation(objM出荷指示T.出荷方式) & vbCrLf)
            End If

            If (objM出荷指示T.出荷预定日 <> "1900/1/1") Then
                strSql.Append(" AND 出荷预定日 >=" & Utility.PFn_ChangeQuotation(objM出荷指示T.出荷预定日.ToString("yyyy/MM/dd")) & vbCrLf)
            End If

            If (objM出荷指示T.出荷预定日1 <> "1900/1/1") Then
                strSql.Append(" AND 出荷预定日 <=" & Utility.PFn_ChangeQuotation(objM出荷指示T.出荷预定日1.ToString("yyyy/MM/dd")) & vbCrLf)
            End If
            'strSql.Append(" ORDER BY 报废品订单编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "出荷实际一览检索"
#Region " LoadByWhere1"

    '出荷实际一览检索全部数据
    Public Function LoadByWhere1(ByVal objM出荷指示T As B出荷指示T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT")
            strSql.Append("        入出库.订单编号 ,")
            strSql.Append("        入出库.产品图号 ,")
            strSql.Append("        客户名称 ,")
            strSql.Append("        订单数量 ,")
            strSql.Append("        入出库日期 出荷日期 ,")
            strSql.Append("        入出库数量 出荷数量 ,")
            strSql.Append("        VM交货方式.名称 出荷方式 ,")
            strSql.Append("        入出库.备注" & vbCrLf)
            strSql.Append("FROM    dbo.B成品入出库记录 入出库" & vbCrLf)
            strSql.Append("        LEFT JOIN B订单管理 订单 ON 入出库.订单编号 = 订单.订单编号")
            strSql.Append("                              AND 入出库.产品图号 = 订单.产品图号")
            strSql.Append("        LEFT JOIN dbo.M客户管理 客户 ON 客户.客户编号 = 订单.客户编号")
            strSql.Append("        LEFT JOIN dbo.VM交货方式 ON VM交货方式.区分 = 订单.交货方式")
            strSql.Append("        LEFT JOIN dbo.VM入出库区分 ON VM入出库区分.区分 = 入出库.入出库区分" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE   1 = 1")
            strSql.Append("      AND 入出库.入出库区分='2'")
            If (objM出荷指示T.产品图号 <> String.Empty) Then
                strSql.Append(" AND 出荷.产品图号 =" & Utility.PFn_ChangeQuotation(objM出荷指示T.产品图号) & vbCrLf)
            End If
            If (objM出荷指示T.订单编号 <> String.Empty) Then
                strSql.Append(" AND 出荷.订单编号 =" & Utility.PFn_ChangeQuotation(objM出荷指示T.订单编号) & vbCrLf)
            End If
            If (objM出荷指示T.客户编号 <> String.Empty) Then
                strSql.Append(" AND 客户.客户编号 =" & Utility.PFn_ChangeQuotation(objM出荷指示T.客户编号) & vbCrLf)
            End If

            If (objM出荷指示T.出荷方式 <> String.Empty) Then
                strSql.Append(" AND VM交货方式.区分=" & Utility.PFn_ChangeQuotation(objM出荷指示T.出荷方式) & vbCrLf)
            End If

            If (objM出荷指示T.出荷预定日 <> "1900/1/1") Then
                strSql.Append(" AND 入出库日期 >=" & Utility.PFn_ChangeQuotation(objM出荷指示T.出荷预定日.ToString("yyyy/MM/dd")) & vbCrLf)
            End If

            If (objM出荷指示T.出荷预定日1 <> "1900/1/1") Then
                strSql.Append(" AND 入出库日期 <=" & Utility.PFn_ChangeQuotation(objM出荷指示T.出荷预定日1.ToString("yyyy/MM/dd")) & vbCrLf)
            End If
            'strSql.Append(" ORDER BY 报废品订单编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#End Region
End Class

