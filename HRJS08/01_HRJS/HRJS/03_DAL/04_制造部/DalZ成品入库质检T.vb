Imports System.Text

#Region "Dal成品入库质检"
'------------------------------------------------------------------------------------
'   说明
'       成品入库质检的数据库操作SQL文
'   创建人
'       大连智云科技 李陈盛
'   创建时间
'       2016/8/29
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalZ成品入库质检T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO Z成品入库质检")          '半成品入库申请

            strSql.Append(" (申请单编号")          '申请单编号
            strSql.Append(" ,检查者编号")          '申请者编号
            strSql.Append(" ,检查日期")            '检查日期
            strSql.Append(" ,订单编号")            '订单编号

            strSql.Append(" ,产品图号")           '产品图号
            strSql.Append(" ,检查内容")           '领料数量
            strSql.Append(" ,检查数量")           '材料编号
            strSql.Append(" ,不良数量")           '产品图号
            strSql.Append(" ,不良原因")           '产品图号
            strSql.Append(" ,处理结果")            '登陆者
            strSql.Append(" ,备注")           '登陆日期
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号))

            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.检查者编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.检查日期1))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.订单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.产品图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.检查内容))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.检查数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.不良数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.不良原因))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.处理结果))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.备注))
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
    Public Function Update(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        'Try

        '    strSql.Append(" UPDATE Z半成品入库质检 ") '半成品入库申请
        '    strSql.Append(" SET ")

        '    'strSql.AppendFormat(" 申请单编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号))
        '    '申请者编号
        '    strSql.AppendFormat(" 检查者编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.检查者编号))
        '    strSql.AppendFormat(" ,检查日期=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.检查日期))
        '    strSql.AppendFormat(" ,订单编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.订单编号))
        '    strSql.AppendFormat(" ,主图号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.主图号))
        '    strSql.AppendFormat(" ,分图号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.分图号))
        '    strSql.AppendFormat(" ,工序编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.工序编号))
        '    strSql.AppendFormat(" ,检查内容=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.检查内容))
        '    strSql.AppendFormat(" ,检查数量=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.检查数量))
        '    strSql.AppendFormat(" ,不良数量=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.不良数量))
        '    strSql.AppendFormat(" ,不良原因=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.不良原因))
        '    strSql.AppendFormat(" ,处理结果=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.处理结果))
        '    strSql.AppendFormat(" ,备注=" & vbCrLf, Utility.PFn_ChangeQuotation(cls成品入库质检T.备注))

        '    strSql.Append(" WHERE ")
        '    strSql.Append(" 申请单编号 = " & Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号)) '订单编号
        '    Return strSql.ToString

        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        '    Return String.Empty
        'End Try

    End Function

#End Region


#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM Z成品入库质检 ") '半成品入库申请)

            strSql.Append(" WHERE 申请单编号=" & Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


#Region " LoadByPKey "

    '检索全部数据
    Public Function LoadByPKey(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         申请者编号  ")
            strSql.Append(" FROM    dbo.Z成品入库申请")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAllHead "

    '检索全部数据
    Public Function LoadAllHead1(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT DISTINCT" & vbCrLf)
            strSql.Append("        A.申请单编号 ," & vbCrLf)
            strSql.Append("        B.人员名 申请者 ," & vbCrLf)
            strSql.Append("        A.申请日期" & vbCrLf)
            strSql.Append(" FROM   dbo.Z成品入库申请 A" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M人员管理 B ON B.人员编号 = A.申请者编号" & vbCrLf)

            strSql.Append(" WHERE   A.申请单编号= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadAllHead(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT a.申请单编号 ," & vbCrLf)
            strSql.Append("        检查者编号 ," & vbCrLf)
            strSql.Append("        B.人员名 检查者名称 ," & vbCrLf)
            strSql.Append("        入库申请.申请日期 ," & vbCrLf)
            strSql.Append("        M人员管理.人员名 申请者" & vbCrLf)
            strSql.Append(" FROM   dbo.Z成品入库质检 a" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M人员管理 B ON a.检查者编号 = B.人员编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.Z成品入库申请 入库申请 ON 入库申请.申请单编号 = a.申请单编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M人员管理 ON M人员管理.人员编号 = 入库申请.申请者编号" & vbCrLf)
            strSql.Append(" WHERE   A.申请单编号= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllzj "

    '检索全部数据
    Public Function LoadAllzj(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  distinct ")
            strSql.Append("         0 选择 , ")
            strSql.Append("         A.订单编号 , ")
            strSql.Append("         A.主图号 , ")
            strSql.Append("         A.产品图号 , ")
            strSql.Append("         A.半成品名称 , ")
            strSql.Append("         a.工序名称 , ")
            strSql.Append("         A.申请日期 , ")
            strSql.Append("         A.入库数量 , ")
            strSql.Append("         A.异常数量, ")
            strSql.Append("         A.异常原因, ")
            strSql.Append("         A.备注, ")
            strSql.Append("        A.质检状态 ")

            strSql.Append(" FROM    dbo.Z半成品入库申请 A ")
            strSql.Append("         LEFT JOIN dbo.B外协加工管理 B ON A.主图号 = B.主图号 ")
            strSql.Append("         INNER JOIN dbo.T图纸管理 F ON A.产品图号 = F.产品图号 ")
            strSql.Append("         INNER JOIN dbo.B订单管理 C ON F.产品图号 = C.产品图号 ")
            strSql.Append("         INNER JOIN dbo.M客户管理 D ON D.客户编号 = C.客户编号 ")
            strSql.Append("         INNER JOIN dbo.M人员管理 E ON A.申请者编号 = E.人员编号 ")
            strSql.Append(" WHERE   A.订单编号= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.订单编号) & vbCrLf)
            strSql.Append("or 申请单编号=" & Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadGridAll "

    '检索全部数据
    Public Function LoadGridAll(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT  A.订单编号 ," & vbCrLf)
            strSql.Append("        A.产品图号 ," & vbCrLf)
            strSql.Append("        A.入库数量 ," & vbCrLf)
            strSql.Append("        检查内容 ," & vbCrLf)
            strSql.Append("        检查数量 ," & vbCrLf)
            strSql.Append("        不良数量 ," & vbCrLf)
            strSql.Append("        不良原因 ," & vbCrLf)
            strSql.Append("        处理结果 ," & vbCrLf)
            strSql.Append("        B.备注" & vbCrLf)
            strSql.Append("FROM    dbo.Z成品入库申请 A" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.Z成品入库质检 B ON B.申请单编号 = A.申请单编号 AND B.产品图号 = A.产品图号" & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.T流转票管理 ON T流转票管理.工序编号 = A.工序编号" & vbCrLf)
            'strSql.Append("                                AND A.分图号 = T流转票管理.产品图号" & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.T图纸管理 E ON E.产品图号 = A.分图号" & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.VM半成品种类 F ON F.区分 = A.半成品种类" & vbCrLf)
            strSql.Append(" WHERE A.申请单编号= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " 主图和分图存在CHECK "

    '检索全部数据
    Public Function Check主图分图(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT * FROM dbo.T图纸关系 A " & vbCrLf)
            strSql.Append("INNER JOIN dbo.T图纸关系 B  " & vbCrLf)
            strSql.Append("ON B.关系ID = A.关系ID " & vbCrLf)
            strSql.Append("WHERE a.分图号= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.产品图号) & vbCrLf)
            'strSql.Append("AND b.产品图号= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.主图号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT")
            strSql.Append("        A.申请单编号 ,")
            strSql.Append("        A.订单编号 ,")
            strSql.Append("        A.产品图号 ,")
            strSql.Append("        入库数量 ,")
            strSql.Append("        A.检查内容 ,")
            strSql.Append("        A.检查数量 ,")
            strSql.Append("        A.不良数量 ,")
            strSql.Append("        A.不良原因 ,")
            strSql.Append("        VM质检状态.名称 处理结果 ,")
            strSql.Append("        A.备注 ,")
            strSql.Append("        M人员管理.人员名 检查者 ,")
            strSql.Append("        A.检查日期" & vbCrLf)
            strSql.Append(" FROM   dbo.Z成品入库质检 A")
            strSql.Append("        LEFT JOIN dbo.M人员管理 ON M人员管理.人员编号 = A.检查者编号")
            strSql.Append("        LEFT JOIN dbo.Z成品入库申请 c ON c.申请单编号 = A.申请单编号 AND c.产品图号 = A.产品图号")
            strSql.Append("        LEFT JOIN VM质检状态 ON VM质检状态.区分 = A.处理结果" & vbCrLf)
            strSql.Append(" WHERE  1 = 1" & vbCrLf)

            'strSql.Append(" WHERE   1 = 1 ")
            If Not String.IsNullOrEmpty(cls成品入库质检T.申请单编号) Then
                strSql.Append("     AND A.申请单编号=" & Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号) & vbCrLf)
            End If
            'If (cls成品入库质检T.申请单编号 <> String.Empty) Then
            '    strSql.Append(" AND 申请单编号 = " & Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号) & vbCrLf)
            'End If
            If (cls成品入库质检T.检查者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls成品入库质检T.检查者编号) & vbCrLf)
            End If

            If (cls成品入库质检T.处理结果 <> String.Empty) Then
                strSql.Append(" AND 处理结果 = " & Utility.PFn_ChangeQuotation(cls成品入库质检T.处理结果) & vbCrLf)
            End If

            If (cls成品入库质检T.检查日期1 <> "1900/1/1") Then
                strSql.Append(" AND 检查日期 >= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.检查日期1) & vbCrLf)
            End If

            If (cls成品入库质检T.检查日期2 <> "1900/1/1") Then
                strSql.Append(" AND 检查日期 <= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.检查日期2.AddDays(1)) & vbCrLf)
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
    Public Function LoadByWhere1(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("  SELECT DISTINCT " & vbCrLf)
            strSql.Append("            申请单编号 , " & vbCrLf)
            strSql.Append("  D.名称 AS 半成品种类, " & vbCrLf)
            strSql.Append("            A.订单编号 , " & vbCrLf)
            'strSql.Append("            A.订单编号 , " & vbCrLf)
            strSql.Append("            A.主图号 , " & vbCrLf)
            strSql.Append("            A.分图号 , " & vbCrLf)
            strSql.Append("            A.半成品名称 , " & vbCrLf)
            strSql.Append("            T流转票管理.工序名称 工序名称 , " & vbCrLf)

            strSql.Append("            A.入库数量 , " & vbCrLf)
            strSql.Append("            A.备注 " & vbCrLf)

            '  strSql.Append("            C.客户名称 " & vbCrLf)
            strSql.Append("  FROM      dbo.Z半成品入库申请 A " & vbCrLf)
            strSql.Append("            INNER JOIN dbo.B订单管理 B ON B.订单编号 = A.订单编号 " & vbCrLf)
            strSql.Append("            INNER JOIN vm半成品种类 D ON D.区分 = A.半成品种类 " & vbCrLf)

            'strSql.Append("         LEFT JOIN vm订单区分 订单区分 " & vbCrLf)
            'strSql.Append("           ON 订单.订单区分 = 订单区分.区分 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T流转票管理 ON A.工序编号 = T流转票管理.工序编号" & vbCrLf)
            strSql.Append("                                 and A.分图号 = T流转票管理.产品图号" & vbCrLf)
            strSql.Append("            INNER JOIN dbo.M客户管理 C ON C.客户编号 = B.客户编号 " & vbCrLf)

            strSql.Append("  WHERE  1 = 1 ")
            If (cls成品入库质检T.申请单编号 <> String.Empty) Then
                strSql.Append("     AND A.申请单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls成品入库质检T.申请单编号, True) & "%'")
            End If
            If (cls成品入库质检T.检查者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls成品入库质检T.检查者编号) & vbCrLf)
            End If

            'If (cls成品入库质检T.质检状态 <> String.Empty) Then
            '    strSql.Append(" AND C.原材料区分 = " & Utility.PFn_ChangeQuotation(cls成品入库质检T.质检状态) & vbCrLf)
            'End If

            If (cls成品入库质检T.检查日期1 <> "1900/1/1") Then
                strSql.Append(" AND 检查日期 >= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.检查日期1) & vbCrLf)
            End If

            If (cls成品入库质检T.检查日期2 <> "1900/1/1") Then
                strSql.Append(" AND 检查日期 <= " & Utility.PFn_ChangeQuotation(cls成品入库质检T.检查日期2.AddDays(1)) & vbCrLf)
            End If

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "SetData"

    Public Function SetData(ByVal cls成品入库质检T As Z成品入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT   a.工序名称,a.工序编号,B.品名 " & vbCrLf)

            strSql.Append(" FROM    dbo.T流转票管理 A ")
            strSql.Append(" INNER JOIN  T图纸管理 B")
            strSql.Append(" ON  A.产品图号 = B.产品图号 ")
            strSql.Append(" WHERE A.产品图号=" & Utility.PFn_ChangeQuotation(cls成品入库质检T.产品图号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
