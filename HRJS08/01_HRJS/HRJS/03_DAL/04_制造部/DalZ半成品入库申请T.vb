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

Public Class DalZ半成品入库申请T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO Z半成品入库申请")          '半成品入库申请

            strSql.Append(" (申请单编号")          '申请单编号
            strSql.Append(" ,申请者编号")          '申请者编号
            strSql.Append(" ,申请日期")           '领料日期
            strSql.Append(" ,半成品种类")           '领料重量
            strSql.Append(" ,订单编号")           '领料重量
            strSql.Append(" ,主图号")           '订单编号
            strSql.Append(" ,上级图号")           '订单编号
            strSql.Append(" ,分图号")           '材料编号
            strSql.Append(" ,工序编号")           '材料编号
            strSql.Append(" ,入库数量")           '产品图号
            strSql.Append(" ,备注")           '产品图号
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号))
            '申请者编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请者编号))
            '领料日期
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请日期))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.半成品种类))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.订单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.主图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.上级图号))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.分图号))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.半成品名称))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.工序编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.入库数量))
            '产品图号
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.备注))

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
    Public Function Update(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE 半成品入库申请 ") '半成品入库申请
            strSql.Append(" SET ")

            'strSql.AppendFormat(" 申请单编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号))
            '申请者编号
            strSql.AppendFormat(" ,申请者编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请者编号))
            '领料日期
            strSql.AppendFormat(" ,申请日期=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请日期))
            strSql.AppendFormat(" ,半成品种类=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.半成品种类))
            strSql.AppendFormat(" ,订单编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.订单编号))
            strSql.AppendFormat(" ,主图号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.主图号))
            '材料编号
            strSql.AppendFormat(" ,分图号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.分图号))
            strSql.AppendFormat(" ,半成品名称=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.半成品名称))
            strSql.AppendFormat(",工序编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.工序编号))
            '领料数量

            '领料重量

            '订单编号
            strSql.AppendFormat(",入库数量=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.入库数量))
            '产品图号
            strSql.AppendFormat("备注=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.备注))
            '登陆者
            '  strSql.AppendFormat("登陆者=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.登陆者))
            '登陆日期
            ' strSql.AppendFormat(" 登陆日期=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.登陆日期))
            '更新者
            ' strSql.AppendFormat("更新者=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.更新者))
            '更新日期
            'strSql.AppendFormat("更新日期=" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.更新日期))

            strSql.Append(" WHERE ")
            strSql.Append(" 申请单编号 = " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号)) '订单编号
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Updatezj "

    '数据更新操作
    Public Function Updatezj(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        'Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        'Try

        '    strSql.Append(" UPDATE Z半成品入库申请 ") '原材料入库申请
        '    strSql.Append(" SET ")
        '    strSql.AppendFormat(" 检查者编号={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.检查者编号))
        '    strSql.AppendFormat(" ,异常数量={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.异常数量))
        '    strSql.AppendFormat(" ,异常原因={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.异常原因))
        '    strSql.AppendFormat(" ,备注={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.备注))

        '    strSql.AppendFormat(" ,质检状态={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.质检状态))


        '    strSql.Append("  WHERE " & vbCrLf)
        '    strSql.AppendFormat("    申请单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号))

        '    Return strSql.ToString

        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        '    Return String.Empty
        'End Try

    End Function

#End Region


#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM Z半成品入库申请 ") '半成品入库申请)

            strSql.Append(" WHERE 申请单编号=" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Deletezj "

    '数据删除操作
    Public Function Deletezj(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        'Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        'Try
        '    strSql.Append(" UPDATE Z半成品入库申请 ") '原材料入库申请
        '    strSql.Append(" SET ")
        '    strSql.AppendFormat(" 检查者编号=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.检查者编号))
        '    strSql.AppendFormat(" ,异常数量=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.异常数量))
        '    strSql.AppendFormat(" ,异常原因=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.异常原因))
        '    strSql.AppendFormat(" ,备注=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.备注))

        '    strSql.AppendFormat(" ,质检状态=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.质检状态))

        '    strSql.Append("  WHERE " & vbCrLf)
        '    strSql.AppendFormat("    申请单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号))


        '    Return strSql.ToString

        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        '    Return String.Empty
        'End Try

    End Function

#End Region

#Region " LoadByPKey "

    '检索全部数据
    Public Function LoadByPKey(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         申请者编号 ")
           
            strSql.Append(" FROM    dbo.Z半成品入库申请")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAllHead "

    '检索全部数据
    Public Function LoadAllHead(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT DISTINCT  申请单编号 , ")
            strSql.Append("         申请者编号 , ")
            strSql.Append("         职务,部门 , ")
            strSql.Append("         A.申请日期, ")
            '半成品标签打印sta
            strSql.Append("         订单编号,  ")
            strSql.Append("         主图号,  ")
            strSql.Append("         上级图号,  ")
            strSql.Append("         分图号,  ")
            strSql.Append("         半成品种类,  ")
            strSql.Append("       入库数量,")
            strSql.Append("       工序编号" & vbCrLf)
            '半成品标签打印end
            strSql.Append(" FROM    dbo.Z半成品入库申请 A ")
            strSql.Append("         left JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 ")
            strSql.Append("WHERE   1 = 1" & vbCrLf)
            strSql.Append(" AND   申请单编号= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号) & vbCrLf)
            If Not String.IsNullOrEmpty(cls半成品入库申请T.分图号) Then
                strSql.Append(" AND   分图号= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.分图号) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllHeadzj "

    '检索全部数据
    Public Function LoadAllHeadzj(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT DISTINCT  申请单编号 , ")
            strSql.Append("         申请者编号 , ")
            strSql.Append("         职务,部门 , ")
            strSql.Append("         A.申请日期 ")
            strSql.Append(" FROM    dbo.Z半成品入库申请 A ")

            strSql.Append("         INNER JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 ")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllzj "

    '检索全部数据
    Public Function LoadAllzj(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

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
            strSql.Append(" WHERE   A.订单编号= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.订单编号) & vbCrLf)
            strSql.Append("or 申请单编号=" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadGridAll "

    '检索全部数据
    Public Function LoadGridAll(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT  半成品种类 , " & vbCrLf)
            strSql.Append("        订单编号 , " & vbCrLf)
            strSql.Append("        Z半成品入库申请.主图号 , " & vbCrLf)
            strSql.Append("        Z半成品入库申请.上级图号 , " & vbCrLf)
            strSql.Append("        分图号 , " & vbCrLf)
            strSql.Append("        图纸.品名 半成品名称 , " & vbCrLf)
            strSql.Append("        Z半成品入库申请.工序编号 , " & vbCrLf)
            strSql.Append("        T流转票管理.工序名称 , " & vbCrLf)
            strSql.Append("        入库数量 , " & vbCrLf)
            strSql.Append("        Z半成品入库申请.备注 " & vbCrLf)
            strSql.Append("FROM    dbo.Z半成品入库申请 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸管理 图纸 ON Z半成品入库申请.分图号 = 图纸.产品图号 " & vbCrLf)
            strSql.Append("                                   AND 图纸.主图号 = Z半成品入库申请.主图号 " & vbCrLf)
            strSql.Append("                                   AND 图纸.上级图号 = Z半成品入库申请.上级图号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T流转票管理 ON T流转票管理.工序编号 = Z半成品入库申请.工序编号 " & vbCrLf)
            strSql.Append("                                AND Z半成品入库申请.分图号 = T流转票管理.产品图号 " & vbCrLf)
            'strSql.Append("           LEFT JOIN dbo.T图纸管理 C ON C.产品图号 =  Z半成品入库申请.分图号                   " & vbCrLf)
            strSql.Append(" WHERE 申请单编号= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " 主图和分图存在CHECK "

    '检索全部数据
    Public Function Check主图分图(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT * FROM dbo.T图纸关系 A " & vbCrLf)
            strSql.Append("INNER JOIN dbo.T图纸关系 B  " & vbCrLf)
            strSql.Append("ON B.关系ID = A.关系ID " & vbCrLf)
            strSql.Append("WHERE a.分图号= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.分图号) & vbCrLf)
            strSql.Append("AND b.产品图号= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.主图号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT" & vbCrLf)
            strSql.Append("        0 AS 选择 ," & vbCrLf)
            strSql.Append("        A.申请单编号 ," & vbCrLf)
            strSql.Append("        B.人员名 申请者 ," & vbCrLf)
            strSql.Append("        B.职务 ," & vbCrLf)
            strSql.Append("        B.部门 ," & vbCrLf)
            strSql.Append("        A.申请日期 ," & vbCrLf)
            strSql.Append("        B.人员名 作成者 " & vbCrLf)
            strSql.Append(" FROM   dbo.Z半成品入库申请 A" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T流转票管理 ON A.工序编号 = T流转票管理.工序编号" & vbCrLf)
            strSql.Append("                                 and A.分图号 = T流转票管理.产品图号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号" & vbCrLf)
            strSql.Append(" WHERE  1 = 1" & vbCrLf)

            If Not String.IsNullOrEmpty(cls半成品入库申请T.申请单编号) Then
                strSql.Append("     AND A.申请单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号, True) & "%'")
            End If
          
            If (cls半成品入库申请T.申请者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请者编号) & vbCrLf)
            End If

            If (cls半成品入库申请T.开始日期 <> "1900/1/1") Then
                strSql.Append(" AND 申请日期 >= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.开始日期) & vbCrLf)
            End If

            If (cls半成品入库申请T.结束日期 <> "1900/1/1") Then
                strSql.Append(" AND 申请日期 <= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.结束日期.AddDays(1)) & vbCrLf)
            End If

            If (cls半成品入库申请T.订单编号 <> String.Empty) Then
                strSql.Append(" AND A.订单编号  = " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.订单编号) & vbCrLf)
            End If

            If Not String.IsNullOrEmpty(cls半成品入库申请T.主图号) Then
                strSql.Append("     AND A.主图号 LIKE '" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.主图号, True) & "%'")
            End If

            If Not String.IsNullOrEmpty(cls半成品入库申请T.工序名称) Then
                strSql.Append("     AND T流转票管理.工序名称  LIKE '" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.工序名称, True) & "%'")
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
    Public Function LoadByWhere1(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("  SELECT DISTINCT " & vbCrLf)
            strSql.Append("            A.申请单编号 , " & vbCrLf)
            strSql.Append("            D.名称 AS 半成品种类 , " & vbCrLf)
            strSql.Append("            A.订单编号 , " & vbCrLf)
            strSql.Append("            A.主图号 , " & vbCrLf)
            strSql.Append("            A.上级图号 , " & vbCrLf)
            strSql.Append("            A.分图号 , " & vbCrLf)
            strSql.Append("            图纸.品名 半成品名称 , " & vbCrLf)
            strSql.Append("            T流转票管理.工序名称 工序名称 , " & vbCrLf)
            strSql.Append("            A.入库数量 , " & vbCrLf)
            strSql.Append("            A.备注 , " & vbCrLf)
            strSql.Append("            VM质检状态.名称 质检状态 , " & vbCrLf)
            strSql.Append("            A.工序编号 " & vbCrLf)
            strSql.Append("  FROM      dbo.Z半成品入库申请 A " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.B订单管理 B ON B.订单编号 = A.订单编号 " & vbCrLf)
            strSql.Append("                                      AND B.产品图号 = A.主图号 " & vbCrLf)
            strSql.Append("            LEFT JOIN VM半成品种类 D ON D.区分 = A.半成品种类 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.T图纸管理 图纸 ON A.分图号 = 图纸.产品图号 " & vbCrLf)
            strSql.Append("                                       AND 图纸.上级图号 = A.上级图号 " & vbCrLf)
            strSql.Append("                                       AND 图纸.主图号 = A.主图号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.T流转票管理 ON A.工序编号 = T流转票管理.工序编号 " & vbCrLf)
            strSql.Append("                                    AND A.分图号 = T流转票管理.产品图号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M客户管理 C ON C.客户编号 = B.客户编号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.Z半成品入库质检 ON Z半成品入库质检.申请单编号 = A.申请单编号 " & vbCrLf)
            strSql.Append("                                      AND Z半成品入库质检.主图号 = A.主图号 " & vbCrLf)
            strSql.Append("                                      AND Z半成品入库质检.上级图号 = A.上级图号 " & vbCrLf)
            strSql.Append("                                      AND Z半成品入库质检.分图号 = A.分图号 " & vbCrLf)
            strSql.Append("            LEFT JOIN VM质检状态 ON VM质检状态.区分 = Z半成品入库质检.处理结果 " & vbCrLf)
            strSql.Append("  WHERE  1 = 1 ")
            If (cls半成品入库申请T.申请单编号 <> String.Empty) Then
                strSql.Append("     AND A.申请单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请单编号, True) & "%'")
            End If

            If (cls半成品入库申请T.申请者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.申请者编号) & vbCrLf)
            End If

            If (cls半成品入库申请T.开始日期 <> "1900/1/1") Then
                strSql.Append(" AND 申请日期 >= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.开始日期) & vbCrLf)
            End If

            If (cls半成品入库申请T.结束日期 <> "1900/1/1") Then
                strSql.Append(" AND 申请日期 <= " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.结束日期) & vbCrLf)
            End If

            If (cls半成品入库申请T.订单编号 <> String.Empty) Then
                strSql.Append(" AND A.订单编号  = " & Utility.PFn_ChangeQuotation(cls半成品入库申请T.订单编号) & vbCrLf)
            End If

            If Not String.IsNullOrEmpty(cls半成品入库申请T.主图号) Then
                strSql.Append("     AND A.主图号 LIKE '" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.主图号, True) & "%'")
            End If

            If Not String.IsNullOrEmpty(cls半成品入库申请T.工序名称) Then
                strSql.Append("     AND T流转票管理.工序名称  LIKE '" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.工序名称, True) & "%'")
            End If

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "SetData"

    Public Function SetData(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT   a.工序名称,a.工序编号,B.品名 " & vbCrLf)

            strSql.Append(" FROM    dbo.T流转票管理 A ")
            strSql.Append(" INNER JOIN  T图纸管理 B")
            strSql.Append(" ON  A.产品图号 = B.产品图号 ")
            strSql.Append(" WHERE A.产品图号=" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.半成品名称) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "Loaddava"

    Public Function Loaddava(ByVal cls半成品入库申请T As Z半成品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  " & vbCrLf)
            strSql.Append("       品名, " & vbCrLf)
            strSql.Append("       工序名称" & vbCrLf)
            strSql.Append("FROM   T图纸管理  " & vbCrLf)
            strSql.Append("LEFT JOIN dbo.T流转票管理 ON T流转票管理.产品图号 = T图纸管理.产品图号" & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 主图号=" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.主图号) & vbCrLf)
            If (cls半成品入库申请T.上级图号 <> String.Empty) Then
                strSql.Append(" AND 上级图号=" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.上级图号) & vbCrLf)
            End If
            strSql.Append(" AND T图纸管理.产品图号=" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.分图号) & vbCrLf)
            strSql.Append(" AND 工序编号=" & Utility.PFn_ChangeQuotation(cls半成品入库申请T.工序编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Load打印数据 "

    '检索全部数据
    Public Function Load打印数据(ByVal strWhere As String) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("  SELECT DISTINCT " & vbCrLf)
            strSql.Append("            A.申请单编号 , " & vbCrLf)
            strSql.Append("            D.名称 AS 半成品种类 , " & vbCrLf)
            strSql.Append("            A.订单编号 , " & vbCrLf)
            strSql.Append("            A.主图号 , " & vbCrLf)
            strSql.Append("            A.上级图号 , " & vbCrLf)
            strSql.Append("            A.分图号 , " & vbCrLf)
            strSql.Append("            图纸.品名 半成品名称 , " & vbCrLf)
            strSql.Append("            T流转票管理.工序名称 工序名称 , " & vbCrLf)
            strSql.Append("            A.入库数量 , " & vbCrLf)
            strSql.Append("            A.备注 , " & vbCrLf)
            strSql.Append("            VM质检状态.名称 质检状态 , " & vbCrLf)
            strSql.Append("            A.工序编号 " & vbCrLf)
            strSql.Append("  FROM      dbo.Z半成品入库申请 A " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.B订单管理 B ON B.订单编号 = A.订单编号 " & vbCrLf)
            strSql.Append("                                      AND B.产品图号 = A.主图号 " & vbCrLf)
            strSql.Append("            LEFT JOIN VM半成品种类 D ON D.区分 = A.半成品种类 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.T图纸管理 图纸 ON A.分图号 = 图纸.产品图号 " & vbCrLf)
            strSql.Append("                                       AND 图纸.上级图号 = A.上级图号 " & vbCrLf)
            strSql.Append("                                       AND 图纸.主图号 = A.主图号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.T流转票管理 ON A.工序编号 = T流转票管理.工序编号 " & vbCrLf)
            strSql.Append("                                    AND A.分图号 = T流转票管理.产品图号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M客户管理 C ON C.客户编号 = B.客户编号 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.Z半成品入库质检 ON Z半成品入库质检.申请单编号 = A.申请单编号 " & vbCrLf)
            strSql.Append("                                      AND Z半成品入库质检.主图号 = A.主图号 " & vbCrLf)
            strSql.Append("                                      AND Z半成品入库质检.上级图号 = A.上级图号 " & vbCrLf)
            strSql.Append("                                      AND Z半成品入库质检.分图号 = A.分图号 " & vbCrLf)
            strSql.Append("            LEFT JOIN VM质检状态 ON VM质检状态.区分 = Z半成品入库质检.处理结果 " & vbCrLf)
            strSql.Append(" WHERE   A.申请单编号 IN (" & strWhere & ")")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
End Class
