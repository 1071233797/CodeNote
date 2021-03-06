Imports System.Text

#Region "Dal入出库记录
'------------------------------------------------------------------------------------
'   说明
'       成品入出库记录的数据库操作SQL文
'   创建人
'       大连智云科技 解辉品
'   创建时间
'       2016/5/24
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalM成品入出库记录T

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls入出库记录T As B成品入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            If cls入出库记录T.入出库区分 = "1" Then
                strSql.Append("SELECT DISTINCT")
                strSql.Append("        VM入出库区分.名称 入出库区分,")
                strSql.Append("        Z成品入库申请.申请单编号 ,")
                strSql.Append("        B成品入出库记录.订单编号 ,")
                strSql.Append("        B成品入出库记录.产品图号 ,")
                strSql.Append("        T图纸管理.品名 产品名称 ,")
                strSql.Append("        B订单管理.订单区分 ,")
                strSql.Append("        M客户管理.客户名称 ,")
                strSql.Append("        Z成品入库申请.入库数量 [产品数量（个）] ,")
                strSql.Append("        库存状态 ,")
                strSql.Append("        入出库日期 ,")
                strSql.Append("        操作者" & vbCrLf)
                strSql.Append("FROM    dbo.B成品入出库记录" & vbCrLf)
                strSql.Append("        LEFT JOIN dbo.B订单管理 ON B订单管理.产品图号 = B成品入出库记录.产品图号" & vbCrLf)
                strSql.Append("                               AND B订单管理.订单编号 = B成品入出库记录.订单编号" & vbCrLf)
                strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = B成品入出库记录.产品图号" & vbCrLf)
                strSql.Append("        LEFT JOIN dbo.Z成品入库申请 ON Z成品入库申请.产品图号 = B成品入出库记录.产品图号" & vbCrLf)
                strSql.Append("                                 AND Z成品入库申请.订单编号 = B成品入出库记录.订单编号" & vbCrLf)
                strSql.Append("        LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = B订单管理.客户编号" & vbCrLf)
                strSql.Append("        LEFT JOIN dbo.VM入出库区分 ON VM入出库区分.区分=B成品入出库记录.入出库区分" & vbCrLf)
                strSql.Append("WHERE   1 = 1 " & vbCrLf)
                If Not String.IsNullOrEmpty(cls入出库记录T.入出库区分) Then
                    strSql.Append("       AND VM入出库区分.区分 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库区分) & vbCrLf)
                End If
                If Not String.IsNullOrEmpty(cls入出库记录T.订单编号) Then
                    strSql.Append("       AND B成品入出库记录.订单编号 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.订单编号) & vbCrLf)
                End If
                If Not String.IsNullOrEmpty(cls入出库记录T.产品图号) Then
                    strSql.Append("       AND B成品入出库记录.产品图号 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.产品图号) & vbCrLf)
                End If
                If Not String.IsNullOrEmpty(cls入出库记录T.订单区分) Then
                    strSql.Append("       AND B订单管理.订单区分 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.订单区分) & vbCrLf)
                End If
                If Not String.IsNullOrEmpty(cls入出库记录T.客户编号) Then
                    strSql.Append("       AND M客户管理.客户编号 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.客户编号) & vbCrLf)
                End If
                If cls入出库记录T.入出库日期 <> "1900/1/1" Then
                    strSql.Append(" AND B成品入出库记录.入出库日期 >=" & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库日期) & vbCrLf)
                End If
                If cls入出库记录T.入出库日期1 <> "1900/1/1" Then
                    strSql.Append(" AND B成品入出库记录.入出库日期 <" & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库日期1.AddDays(1)) & vbCrLf)
                End If
                Return strSql.ToString
            Else
                strSql.Append("SELECT DISTINCT")
                strSql.Append("        VM入出库区分.名称 入出库区分,")
                strSql.Append("        B出荷指示.出荷指示编号 ,")
                strSql.Append("        B成品入出库记录.订单编号 ,")
                strSql.Append("        B成品入出库记录.产品图号 ,")
                strSql.Append("        T图纸管理.品名 产品名称 ,")
                strSql.Append("        B订单管理.订单区分 ,")
                strSql.Append("        M客户管理.客户名称 ,")
                strSql.Append("        B出荷指示.出荷数量 [产品数量（个）],")
                strSql.Append("        库存状态 ,")
                strSql.Append("        入出库日期 ,")
                strSql.Append("        操作者" & vbCrLf)
                strSql.Append("FROM    dbo.B成品入出库记录" & vbCrLf)
                strSql.Append("        LEFT JOIN dbo.B订单管理 ON B订单管理.产品图号 = B成品入出库记录.产品图号" & vbCrLf)
                strSql.Append("                               AND B订单管理.订单编号 = B成品入出库记录.订单编号" & vbCrLf)
                strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = B成品入出库记录.产品图号" & vbCrLf)
                strSql.Append("        LEFT JOIN dbo.B出荷指示 ON B出荷指示.产品图号 = B成品入出库记录.产品图号" & vbCrLf)
                strSql.Append("                                 AND B出荷指示.订单编号 = B成品入出库记录.订单编号" & vbCrLf)
                strSql.Append("        LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = B订单管理.客户编号" & vbCrLf)
                strSql.Append("        LEFT JOIN dbo.VM入出库区分 ON VM入出库区分.区分=B成品入出库记录.入出库区分" & vbCrLf)
                strSql.Append("WHERE   1 = 1 " & vbCrLf)
                If Not String.IsNullOrEmpty(cls入出库记录T.入出库区分) Then
                    strSql.Append("       AND VM入出库区分.区分 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库区分) & vbCrLf)
                End If
                If Not String.IsNullOrEmpty(cls入出库记录T.订单编号) Then
                    strSql.Append("       AND B成品入出库记录.订单编号 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.订单编号) & vbCrLf)
                End If
                If Not String.IsNullOrEmpty(cls入出库记录T.产品图号) Then
                    strSql.Append("       AND B成品入出库记录.产品图号 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.产品图号) & vbCrLf)
                End If
                If Not String.IsNullOrEmpty(cls入出库记录T.订单区分) Then
                    strSql.Append("       AND B订单管理.订单区分 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.订单区分) & vbCrLf)
                End If
                If Not String.IsNullOrEmpty(cls入出库记录T.客户编号) Then
                    strSql.Append("       AND M客户管理.客户编号 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.客户编号) & vbCrLf)
                End If
                If cls入出库记录T.入出库日期 <> "1900/1/1" Then
                    strSql.Append(" AND B成品入出库记录.入出库日期 >=" & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库日期) & vbCrLf)
                End If
                If cls入出库记录T.入出库日期1 <> "1900/1/1" Then
                    strSql.Append(" AND B成品入出库记录.入出库日期 <" & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库日期1.AddDays(1)) & vbCrLf)
                End If
                Return strSql.ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
