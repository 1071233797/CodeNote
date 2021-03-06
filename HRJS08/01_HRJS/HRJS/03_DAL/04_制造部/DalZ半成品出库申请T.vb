Imports System.Text

#Region "Dal原材料出库申请
'------------------------------------------------------------------------------------
'   说明
'       原材料出库申请的数据库操作SQL文
'   创建人
'       大连智云科技 李陈盛
'   创建时间
'       2016/8/29
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalZ半成品出库申请T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls半成品出库申请T As Z半成品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO Z半成品出库申请")          '半成品出库申请

            strSql.Append(" (申请单编号")          '申请单编号
            strSql.Append(" ,申请者编号")          '申请者编号
            strSql.Append(" ,申请日期")           '领料日期
            strSql.Append(" ,订单编号")           '材料编号
            strSql.Append(" ,主图号")           '领料数量
            strSql.Append(" ,上级图号")           '领料数量
            strSql.Append(" ,分图号")           '领料重量
            strSql.Append(" ,工序编号")           '订单编号
            strSql.Append(" ,出库数量")           '产品图号
            strSql.Append(" ,半成品种类")            '登陆者
            strSql.Append(" ,出库去向")           '登陆日期
            strSql.Append(" ,备注")            '更新者
            '更新日期
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请单编号))
            '申请者编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请者编号))
            '领料日期
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请日期))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.订单编号))
            '主图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.主图号))
            '上级图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.上级图号))
            '领料重量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.分图号))
            '订单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.工序编号))
            '产品图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.出库数量))
            '登陆者
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.半成品种类))
            '登陆日期
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.出库去向))
            '更新者
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品出库申请T.备注))
            '更新日期

            strSql.Append(" )")
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal cls半成品出库申请T As Z半成品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE 半成品出库申请 ") '半成品出库申请
            strSql.Append(" SET ")

            '申请单编号

            '申请者编号

            '领料日期

            '材料编号

            '领料数量

            '领料重量

            '订单编号

            '产品图号

            '登陆者

            '登陆日期

            '更新者

            '更新日期

            strSql.Append(" WHERE ")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls半成品出库申请T As Z半成品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM Z半成品出库申请 ") '半成品出库申请)

            strSql.Append(" WHERE 申请单编号=" & Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPKey "

    '检索全部数据
    Public Function LoadByPKey(ByVal cls半成品出库申请T As Z半成品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         申请者编号  ")
            strSql.Append(" FROM    dbo.Z半成品出库申请")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAllHead "

    '检索全部数据
    Public Function LoadAllHead(ByVal cls半成品出库申请T As Z半成品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         申请者编号 , ")
            strSql.Append("         职务,部门 , ")
            strSql.Append("         A.申请日期 ")
            strSql.Append(" FROM    dbo.Z半成品出库申请 A ")
            strSql.Append("         INNER JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 ")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadGridAll "

    '检索全部数据
    Public Function LoadGridAll(ByVal cls半成品出库申请T As Z半成品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT")
            strSql.Append("        A.订单编号 ,")
            strSql.Append("        A.主图号 ,")
            strSql.Append("        A.上级图号 ,")
            strSql.Append("        A.分图号 ,")
            strSql.Append("        A.工序编号 ,")
            strSql.Append("        流转票.工序名称 ,")
            strSql.Append("        VM半成品种类.区分  半成品种类编号,")
            strSql.Append("        VM半成品种类.名称 半成品种类名称 ,")
            strSql.Append("        SUM(库存.库存数量) 库存数量,")
            strSql.Append("        M货位管理.货位名称 库存区域 ,")
            strSql.Append("        A.出库数量 ,")
            strSql.Append("        A.出库去向 ,")
            strSql.Append("        A.备注" & vbCrLf)
            strSql.Append("FROM    dbo.Z半成品出库申请 A" & vbCrLf)
            strSql.Append("        INNER JOIN dbo.T图纸管理 图纸 ON 图纸.主图号 = A.主图号")
            strSql.Append("                                   AND 图纸.产品图号 = A.分图号")
            strSql.Append("                                   AND 图纸.上级图号 = A.上级图号")
            strSql.Append("        LEFT JOIN dbo.Z半成品库存 库存 ON 库存.订单编号 = A.订单编号")
            strSql.Append("                                   AND 库存.主图号 = A.主图号")
            strSql.Append("                                   AND 库存.分图号 = A.分图号")
            strSql.Append("        INNER JOIN dbo.B订单管理 B ON B.订单编号 = A.订单编号")
            strSql.Append("                                  AND B.产品图号 = A.主图号")
            strSql.Append("        LEFT JOIN dbo.M客户管理 客户 ON 客户.客户编号 = B.客户编号")
            strSql.Append("        LEFT JOIN dbo.T流转票管理 流转票 ON 流转票.产品图号 = A.分图号")
            strSql.Append("                                    AND 流转票.工序编号 = A.工序编号")
            strSql.Append("        LEFT JOIN dbo.VM半成品种类 ON VM半成品种类.区分 = A.半成品种类")
            strSql.Append("        LEFT JOIN dbo.M货位管理 ON 库存.库存区域 = M货位管理.货位编号" & vbCrLf)
            strSql.Append(" WHERE   A.申请单编号= " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请单编号) & vbCrLf)
            strSql.Append(" GROUP BY  A.订单编号 ,")
            strSql.Append("           A.主图号 ,")
            strSql.Append("           A.上级图号 ,")
            strSql.Append("           A.分图号 ,")
            strSql.Append("           A.工序编号 ,")
            strSql.Append("           流转票.工序名称 ,")
            strSql.Append("           VM半成品种类.区分,")
            strSql.Append("           VM半成品种类.名称 ,")
            strSql.Append("           M货位管理.货位名称 ,")
            strSql.Append("           A.出库数量 ,")
            strSql.Append("           A.出库去向 ,")
            strSql.Append("           A.备注")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls半成品出库申请T As Z半成品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT ")
            strSql.Append("         'false' 选择 , ")
            strSql.Append("         申请单编号 , ")
            strSql.Append("         B.人员名 申请者 , ")
            strSql.Append("         B.职务 , ")
            strSql.Append("         B.部门 , ")
            strSql.Append("         A.申请日期 , ")
            strSql.Append("         B.人员名 作成者 ")
            strSql.Append(" FROM    dbo.Z半成品出库申请 A ")
            strSql.Append("         INNER JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 ")
            strSql.Append(" WHERE   1 = 1 ")

            If (cls半成品出库申请T.订单编号 <> String.Empty) Then
                strSql.Append(" AND A.订单编号 = " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.订单编号) & vbCrLf)
            End If
         
            If (cls半成品出库申请T.申请者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请者编号) & vbCrLf)
            End If

            If Not String.IsNullOrEmpty(cls半成品出库申请T.申请单编号) Then
                strSql.Append("     AND A.申请单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请单编号, True) & "%'")
            End If

            If (cls半成品出库申请T.开始日期 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 >= " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.开始日期) & vbCrLf)
            End If

            If (cls半成品出库申请T.结束日期 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 <= " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.结束日期) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere1 "


    '检索全部数据
    Public Function LoadByWhere1(ByVal cls半成品出库申请T As Z半成品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT 申请单编号 ,")
            strSql.Append("        A.订单编号 ,")
            strSql.Append("        A.主图号 ,")
            strSql.Append("        A.上级图号,")
            strSql.Append("        A.分图号 ,")
            strSql.Append("        流转票.工序名称 ,")
            strSql.Append("        VM半成品种类.名称 半成品种类 ,")
            strSql.Append("        A.出库数量 ,")
            strSql.Append("        A.出库去向 ,")
            strSql.Append("        A.备注")
            strSql.Append(" FROM   dbo.Z半成品出库申请 A")
            strSql.Append("        LEFT JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号")
            strSql.Append("        LEFT JOIN dbo.T流转票管理 流转票 ON 流转票.产品图号 = A.分图号")
            strSql.Append("                                    AND 流转票.工序编号 = A.工序编号")
            strSql.Append("        LEFT JOIN dbo.VM半成品种类 ON VM半成品种类.区分 = A.半成品种类")
            strSql.Append("")
            strSql.Append(" WHERE  1 = 1" & vbCrLf)

            If (cls半成品出库申请T.订单编号 <> String.Empty) Then
                strSql.Append(" AND A.订单编号 = " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.订单编号) & vbCrLf)
            End If
            If (cls半成品出库申请T.申请者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请者编号) & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(cls半成品出库申请T.申请单编号) Then
                strSql.Append("     AND A.申请单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls半成品出库申请T.申请单编号, True) & "%'")
            End If
            If (cls半成品出库申请T.开始日期 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 >= " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.开始日期) & vbCrLf)
            End If

            If (cls半成品出库申请T.结束日期 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 <= " & Utility.PFn_ChangeQuotation(cls半成品出库申请T.结束日期) & vbCrLf)
            End If




            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "SetData "


    '检索全部数据
    Public Function SetData(ByVal cls半成品出库申请T As Z半成品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try

            strSql.Append("SELECT   A.订单编号, " & vbCrLf)
            strSql.Append("  A.主图号, " & vbCrLf)
            strSql.Append("  A.上级图号, " & vbCrLf)
            strSql.Append("  B.品名 AS 半成品种类名称," & vbCrLf)
            strSql.Append("  C.工序名称," & vbCrLf)
            strSql.Append("  C.工序编号," & vbCrLf)
            strSql.Append("   ISNULL( D.库存数量,0) AS 库存数量, " & vbCrLf)
            strSql.Append("   ISNULL( D.库存区域, '无库存' ) AS 库存区域" & vbCrLf)
            strSql.Append("  FROM dbo.Z生产计划制定 A" & vbCrLf)
            strSql.Append("  INNER JOIN dbo.T图纸管理 B ON B.产品图号 = A.分图号" & vbCrLf)
            strSql.Append("  INNER JOIN dbo.T流转票管理 C ON C.产品图号 = A.分图号" & vbCrLf)
            strSql.Append("   AND C.工序编号 = A.工序编号" & vbCrLf)
            strSql.Append(" LEFT JOIN Z半成品库存 D ON D.订单编号 = A.订单编号" & vbCrLf)
            strSql.Append("    AND D.分图号 = A.分图号 " & vbCrLf)
            strSql.Append(" WHERE    1 = 1  " & vbCrLf)
            If cls半成品出库申请T.订单编号 <> String.Empty Then
                strSql.Append(" AND A.订单编号 =" & Utility.PFn_ChangeQuotation(cls半成品出库申请T.订单编号) & vbCrLf)
            End If
            If cls半成品出库申请T.工序编号 <> String.Empty Then
                strSql.Append(" AND A.工序编号 =" & Utility.PFn_ChangeQuotation(cls半成品出库申请T.工序编号) & vbCrLf)
            End If
            If cls半成品出库申请T.分图号 <> String.Empty Then
                strSql.Append(" AND A.分图号 =" & Utility.PFn_ChangeQuotation(cls半成品出库申请T.分图号) & vbCrLf)
            End If
           
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
