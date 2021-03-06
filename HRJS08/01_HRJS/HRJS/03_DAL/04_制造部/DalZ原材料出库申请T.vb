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

Public Class DalZ原材料出库申请T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls原材料出库申请T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO Z原材料出库申请")          '原材料出库申请

            strSql.Append(" (申请单编号")          '申请单编号
            strSql.Append(" ,领料者编号")          '领料者编号
            strSql.Append(" ,领料日期")           '领料日期
            strSql.Append(" ,材料编号")           '材料编号
            strSql.Append(" ,长")           '材料编号
            strSql.Append(" ,宽")           '材料编号
            strSql.Append(" ,高")           '材料编号

            strSql.Append(" ,领料数量")           '领料数量
            strSql.Append(" ,领料重量")           '领料重量
            strSql.Append(" ,订单编号")           '订单编号
            strSql.Append(" ,主图号")           '订单编号
            strSql.Append(" ,上级图号")           '订单编号
            strSql.Append(" ,分图号")           '产品图号
            strSql.Append(" ,备注")           '产品图号
            strSql.Append(" ,审核备注")           '更新日期
            strSql.Append(" ,审核状态")            '更新者
            strSql.Append(" ,审核人")           '更新日期
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号))
            '领料者编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料者编号))
            '领料日期
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料日期))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.材料编号))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.长))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.宽))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.高))
            '领料数量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料数量))
            '领料重量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料重量))
            '订单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.订单编号))
            '总图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.主图号))
            '总图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.上级图号))
            '产品图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.分图号))
            '登陆者
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.备注))
            
            '更新日期
            strSql.AppendFormat(" {0}, " & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.审核备注))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.审核状态))
            '更新日期
            strSql.AppendFormat(" {0} " & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.审核人))
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
    Public Function Update(ByVal cls原材料出库申请T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" IF ( SELECT    COUNT(*) " & vbCrLf)
            strSql.Append("      FROM      Z原材料出库申请 " & vbCrLf)
            strSql.Append("  WHERE " & vbCrLf)
            strSql.Append("  申请单编号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号) & vbCrLf)
            If (cls原材料出库申请T.材料编号 <> String.Empty) Then
                strSql.Append("  AND 材料编号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.材料编号) & vbCrLf)
            End If
            If (cls原材料出库申请T.主图号 <> String.Empty) Then
                strSql.Append("  AND 主图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.主图号) & vbCrLf)
            End If
            If (cls原材料出库申请T.上级图号 <> String.Empty) Then
                strSql.Append("  AND 上级图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.上级图号) & vbCrLf)
            End If
            If (cls原材料出库申请T.分图号 <> String.Empty) Then
                strSql.Append("  AND 分图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.分图号) & vbCrLf)
            End If
            strSql.Append("    ) = 0 " & vbCrLf)
            strSql.Append(" INSERT INTO Z原材料出库申请")          '原材料出库申请

            strSql.Append(" (申请单编号")          '申请单编号
            strSql.Append(" ,领料者编号")          '领料者编号
            strSql.Append(" ,领料日期")           '领料日期
            strSql.Append(" ,材料编号")           '材料编号
            strSql.Append(" ,长")           '材料编号
            strSql.Append(" ,宽")           '材料编号
            strSql.Append(" ,高")           '材料编号
            strSql.Append(" ,领料数量")           '领料数量
            strSql.Append(" ,领料重量")           '领料重量
            strSql.Append(" ,订单编号")           '订单编号
            strSql.Append(" ,主图号")           '订单编号
            strSql.Append(" ,上级图号")           '订单编号
            strSql.Append(" ,分图号")           '产品图号
            strSql.Append(" ,备注")           '产品图号
            strSql.Append(" ,审核备注")           '更新日期
            strSql.Append(" ,审核状态")            '更新者
            strSql.Append(" ,审核人")           '更新日期
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号))
            '领料者编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料者编号))
            '领料日期
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料日期))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.材料编号))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.长))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.宽))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.高))
            '领料数量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料数量))
            '领料重量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料重量))
            '订单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.订单编号))
            '总图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.主图号))
            '总图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.上级图号))
            '产品图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.分图号))
            '登陆者
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.备注))

            '更新日期
            strSql.AppendFormat(" {0}, " & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.审核备注))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.审核状态))
            '更新日期
            strSql.AppendFormat(" {0} " & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料出库申请T.审核人))
            strSql.Append(" )" & vbCrLf)
            strSql.Append("ELSE" & vbCrLf)
            strSql.Append(" UPDATE Z原材料出库申请 ") '原材料出库申请
            strSql.Append(" SET ")
            'strSql.AppendFormat(" 申请单编号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号))
            strSql.AppendFormat(" 领料者编号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料者编号))
            strSql.AppendFormat(" ,领料日期=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料日期))
            strSql.AppendFormat(" ,材料编号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.材料编号))
            strSql.AppendFormat(" ,长=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.长))
            strSql.AppendFormat(" ,宽=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.宽))
            strSql.AppendFormat(" ,高=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.高))
            strSql.AppendFormat(" ,领料数量=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料数量))
            strSql.AppendFormat(" ,领料重量=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料重量))
            strSql.AppendFormat(" ,订单编号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.订单编号))
            strSql.AppendFormat(", 主图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.主图号))

            strSql.AppendFormat(", 分图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.分图号))
            If cls原材料出库申请T.备注 = "" Then
                strSql.Append(" ,备注 =NULL ")
            Else
                strSql.AppendFormat(" ,备注 =" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.备注))
            End If
            If cls原材料出库申请T.审核状态 = "" Then
                strSql.Append(" ,审核状态 = 1 ")
                strSql.Append(" ,审核备注 = NULL ")
                strSql.Append(" ,审核人 = NULL ")
            Else
                strSql.AppendFormat(" ,审核状态 = " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.审核状态))
                strSql.AppendFormat(" ,审核备注 = " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.审核备注))
                strSql.AppendFormat(" ,审核人= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.审核人))
            End If
            strSql.Append(" WHERE ")
            strSql.Append(" 申请单编号 = " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号)) '订单编号
            strSql.Append(" AND 材料编号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.材料编号)) '材料编号
            strSql.Append(" AND 订单编号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.订单编号)) '订单编号
            strSql.Append(" AND 主图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.主图号)) '主图号
            strSql.Append(" AND 上级图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.上级图号)) '上级图号
            strSql.Append(" AND 分图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.分图号)) '分图号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Update审核 "

    '数据更新操作
    Public Function Update审核(ByVal cls原材料出库T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE Z原材料出库申请 ") '采购表
            strSql.Append(" SET ")
            strSql.Append(" 审核状态=" & Utility.PFn_ChangeQuotation(cls原材料出库T.审核状态))
            strSql.Append(" ,审核备注=" & Utility.PFn_ChangeQuotation(cls原材料出库T.审核备注))
            strSql.Append(" ,审核人=" & Utility.PFn_ChangeQuotation(cls原材料出库T.审核人) & vbCrLf)
            strSql.Append("WHERE 申请单编号=" & Utility.PFn_ChangeQuotation(cls原材料出库T.申请单编号))
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls原材料出库申请T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM Z原材料出库申请 ") '原材料出库申请)
            strSql.Append(" WHERE  1=1" & vbCrLf)
            strSql.Append(" AND 申请单编号 =  '" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号, True) & "'" & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPKey "

    '检索全部数据
    Public Function LoadByPKey(ByVal cls原材料出库申请T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         领料者编号  ")
            strSql.Append(" FROM    dbo.Z原材料出库申请")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号) & vbCrLf)
            strSql.Append(" AND   材料编号= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.材料编号) & vbCrLf)
            strSql.Append(" AND   订单编号= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.订单编号) & vbCrLf)
            strSql.Append(" AND   主图号= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.主图号) & vbCrLf)
            strSql.Append(" AND   上级图号= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.上级图号) & vbCrLf)
            strSql.Append(" AND   分图号= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.分图号) & vbCrLf)



            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal cls原材料出库申请T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         领料者编号  ")
            strSql.Append(" FROM    dbo.Z原材料出库申请")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号) & vbCrLf)


            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllHead "

    '检索全部数据
    Public Function LoadAllHead(ByVal cls原材料出库申请T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         领料者编号 , ")
            strSql.Append("         B.人员名 领料者名称 , ")
            strSql.Append("         B.职务 , ")
            strSql.Append("         B.部门 , ")
            strSql.Append("         a.领料日期 ")
            strSql.Append(" FROM    dbo.Z原材料出库申请 a ")
            strSql.Append("         INNER JOIN dbo.M人员管理 B  ")
            strSql.Append("         ON a.领料者编号 = B.人员编号 ")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadGridAll "

    '检索全部数据
    Public Function LoadGridAll(ByVal cls原材料出库申请T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT 材料编号, ")
            strSql.Append("  M原材料信息.原材料名称 材料名称, ")
            strSql.Append("  VM材料区分.名称 材料区分,")
            strSql.Append("  VM材质.名称 材质,")
            strSql.Append("  长,")
            strSql.Append("  宽,")
            strSql.Append("  高,")
            strSql.Append(" 领料数量 [领料数量（个）], ")
            strSql.Append(" 领料重量 [领料重量（kg）], ")
            strSql.Append(" Z原材料出库申请.订单编号,")
            strSql.Append(" Z原材料出库申请.主图号,")
            strSql.Append(" Z原材料出库申请.上级图号,")
            strSql.Append(" Z原材料出库申请.分图号,")
            strSql.Append(" Z原材料出库申请.备注, ")
            strSql.Append(" Z原材料出库申请.审核状态")
            strSql.Append(" FROM Z原材料出库申请 ")
            strSql.Append(" LEFT JOIN M原材料信息 ON Z原材料出库申请.材料编号 = M原材料信息.原材料编号 ")
            strSql.Append(" LEFT JOIN B订单管理 ON Z原材料出库申请.订单编号 = B订单管理.订单编号 ")
            strSql.Append(" LEFT JOIN VM材料区分 ON VM材料区分.区分 = M原材料信息.原材料区分 ")
            strSql.Append(" LEFT JOIN VM材质 ON VM材质.区分 = M原材料信息.材质 ")
            strSql.Append(" WHERE   Z原材料出库申请.申请单编号= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls原材料出库申请T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT ")
            strSql.Append("         0 选择 , ")
            strSql.Append("         申请单编号 , ")
            strSql.Append("         领料者编号 , ")
            strSql.Append("         B.人员名 领料者 , ")
            strSql.Append("         B.职务 , ")
            strSql.Append("         B.部门 , ")
            strSql.Append("         A.领料日期,   ")
            strSql.Append("         vm审核状态.名称 AS 审核状态, ")
            strSql.Append("         审核人,  ")
            strSql.Append("         审核备注  ")
            'strSql.Append("         A.更新者 作成者 ")
            strSql.Append(" FROM    dbo.Z原材料出库申请 A ")
            strSql.Append("         LEFT JOIN dbo.M人员管理 B ON A.领料者编号 = B.人员编号 ")
            strSql.Append("         LEFT JOIN dbo.M原材料信息 C ON C.原材料编号 = A.材料编号 ")
            strSql.Append("        INNER JOIN dbo.VM审核状态 ON VM审核状态.区分 =  A.审核状态 ")
            strSql.Append(" WHERE   1 = 1 ")
            If (cls原材料出库申请T.申请单编号 <> String.Empty) Then
                strSql.Append(" AND 申请单编号 like '" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号, True) & "%'")
            End If
            If (cls原材料出库申请T.领料者编号 <> String.Empty) Then
                strSql.Append(" AND 领料者编号 = " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料者编号) & vbCrLf)
            End If

            If (cls原材料出库申请T.材料区分 <> String.Empty) Then
                strSql.Append(" AND C.原材料区分 = " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.材料区分) & vbCrLf)
            End If

            If (cls原材料出库申请T.开始日期 <> "1900/1/1") Then
                strSql.Append(" AND A.领料日期 >= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.开始日期) & vbCrLf)
            End If

            If (cls原材料出库申请T.结束日期 <> "1900/1/1") Then
                strSql.Append(" AND A.领料日期 < " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.结束日期.AddDays(1)) & vbCrLf)
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
    Public Function LoadByWhere1(ByVal cls原材料出库申请T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT")
            strSql.Append("        申请单编号 ," & vbCrLf)
            strSql.Append("        M原材料信息.原材料名称 材料名称 ," & vbCrLf)
            strSql.Append("        VM材料区分.名称 材料区分 ," & vbCrLf)
            strSql.Append("        长," & vbCrLf)
            strSql.Append("        宽," & vbCrLf)
            strSql.Append("        高," & vbCrLf)
            strSql.Append("        领料数量 [领料数量（个）] ," & vbCrLf)
            strSql.Append("        领料重量 [领料重量（kg）] ," & vbCrLf)
            strSql.Append("        M原材料信息.材质 ," & vbCrLf)
            strSql.Append("        Z原材料出库申请.订单编号 ," & vbCrLf)
            strSql.Append("        Z原材料出库申请.主图号 ," & vbCrLf)
            strSql.Append("        Z原材料出库申请.上级图号 ," & vbCrLf)
            strSql.Append("        Z原材料出库申请.分图号 ," & vbCrLf)

            strSql.Append("        Z原材料出库申请.备注" & vbCrLf)

            strSql.Append("FROM    Z原材料出库申请" & vbCrLf)
            strSql.Append("        left JOIN M原材料信息 ON Z原材料出库申请.材料编号 = M原材料信息.原材料编号" & vbCrLf)
            strSql.Append("        left JOIN dbo.VM材料区分 ON  VM材料区分.区分 = M原材料信息.原材料区分" & vbCrLf)
            strSql.Append("        left JOIN B订单管理 ON B订单管理.订单编号 = Z原材料出库申请.订单编号" & vbCrLf)

            strSql.Append("WHERE   1 = 1" & vbCrLf)


            If (cls原材料出库申请T.申请单编号 <> String.Empty) Then
                strSql.Append(" AND 申请单编号 like '" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.申请单编号, True) & "%'")
            End If
            If (cls原材料出库申请T.领料者编号 <> String.Empty) Then
                strSql.Append(" AND 领料者编号 = " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.领料者编号) & vbCrLf)
            End If

            If (cls原材料出库申请T.材料区分 <> String.Empty) Then
                strSql.Append(" AND M原材料信息.原材料区分 = " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.材料区分) & vbCrLf)
            End If

            If (cls原材料出库申请T.开始日期 <> "1900/1/1") Then
                strSql.Append(" AND Z原材料出库申请.领料日期 >= " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.开始日期) & vbCrLf)
            End If

            If (cls原材料出库申请T.结束日期 <> "1900/1/1") Then
                strSql.Append(" AND Z原材料出库申请.领料日期 < " & Utility.PFn_ChangeQuotation(cls原材料出库申请T.结束日期.AddDays(1)) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "SetData"

    '检索全部数据
    Public Function SetData(ByVal cls原材料出库申请T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            'Select DISTINCT
            '        Z生产计划制定.订单编号 ,
            '        B原材料采购管理.主图号 ,
            '        B原材料采购管理.上级图号 ,
            '        分图号 ,
            '        材料编号 ,
            '        原材料名称 材料名称 ,
            '        VM材料区分.名称 材料区分 ,
            '        VM材质.名称 材质 ,
            '        T图纸管理.长 ,
            '        T图纸管理.宽 ,
            '        T图纸管理.高 ,
            '        Z生产计划制定.投产数量 * T图纸管理.数量 [领料数量（个）]
            'FROM    dbo.Z生产计划制定
            '        INNER JOIN dbo.B原材料采购管理 ON B原材料采购管理.订单编号 = Z生产计划制定.订单编号
            '                                   AND B原材料采购管理.主图号 = Z生产计划制定.产品图号
            '        INNER  JOIN dbo.M原材料信息 ON B原材料采购管理.材料编号 = M原材料信息.原材料编号
            '        INNER JOIN dbo.T图纸管理 ON T图纸管理.上级图号 = B原材料采购管理.上级图号
            '                                AND T图纸管理.主图号 = B原材料采购管理.主图号
            '                                AND T图纸管理.产品图号 = B原材料采购管理.分图号
            '        LEFT JOIN dbo.VM材料区分 ON VM材料区分.区分 = dbo.M原材料信息.原材料区分
            '        LEFT JOIN dbo.VM材质 ON VM材质.区分 = dbo.M原材料信息.材质
            'WHERE   Z生产计划制定.订单编号 = 'lxq'
            '        AND T图纸管理.主图号 = ''
            '        AND T图纸管理.上级图号 = ''
            '        AND T图纸管理.产品图号 = ''; 

            strSql.Append(" SELECT DISTINCT " & vbCrLf)
            strSql.Append("         Z生产计划制定.订单编号 , " & vbCrLf)
            strSql.Append("         T图纸管理.主图号 , " & vbCrLf)
            strSql.Append("         T图纸管理.上级图号 , " & vbCrLf)
            strSql.Append("         T图纸管理.产品图号 分图号, " & vbCrLf)
            strSql.Append("         M原材料信息.原材料编号 材料编号 , " & vbCrLf)
            strSql.Append("         原材料名称 材料名称 , " & vbCrLf)
            strSql.Append("         VM材料区分.名称 材料区分 , " & vbCrLf)
            strSql.Append("         VM材质.名称 材质 , " & vbCrLf)
            strSql.Append("         T图纸管理.长 , " & vbCrLf)
            strSql.Append("         T图纸管理.宽 , " & vbCrLf)
            strSql.Append("         T图纸管理.高 , " & vbCrLf)
            strSql.Append("         Z生产计划制定.投产数量 * T图纸管理.数量 [领料数量（个）], " & vbCrLf)
            strSql.Append("         Z生产计划制定.投产数量 * T图纸管理.数量 * T图纸管理.单件重量 [领料重量（kg）] " & vbCrLf)
            strSql.Append(" FROM    dbo.Z生产计划制定 " & vbCrLf)
            strSql.Append("         INNER JOIN dbo.T图纸管理 ON T图纸管理.主图号 = Z生产计划制定.产品图号 " & vbCrLf)
            strSql.Append("         INNER JOIN dbo.M原材料信息 ON M原材料信息.原材料编号 = T图纸管理.原材料编号 " & vbCrLf)
            'strSql.Append("                                   AND M原材料信息.材质 = T图纸管理.材质 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材料区分 ON VM材料区分.区分 = dbo.M原材料信息.原材料区分 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材质 ON VM材质.区分 = dbo.M原材料信息.材质 " & vbCrLf)
            strSql.Append(" WHERE Z生产计划制定.订单编号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.订单编号) & vbCrLf)
            strSql.Append("      and  T图纸管理.主图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.主图号) & vbCrLf)
            strSql.Append("      and  T图纸管理.产品图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.分图号) & vbCrLf)
            strSql.Append("      and  T图纸管理.上级图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.上级图号) & vbCrLf)
            Return strSql.ToString


            'strSql.Append(" SELECT  DISTINCT")
            'strSql.Append("        计划.订单编号 ,")
            'strSql.Append("        计划.主图号 ,")
            'strSql.Append("        计划.上级图号 ,")
            'strSql.Append("        计划.分图号 ,")
            'strSql.Append("        材料编号 ,")
            'strSql.Append("        M原材料信息.原材料名称 材料名称 ,")
            'strSql.Append("        dbo.VM材料区分.名称 材料区分 ,")
            'strSql.Append("        材质 ,")
            'strSql.Append("        长 ,")
            'strSql.Append("        宽 ,")
            'strSql.Append("        高 ,")
            'strSql.Append("        '' [领料数量(个)] ,")
            'strSql.Append("        '' [领料重量(kg)]" & vbCrLf)
            'strSql.Append("FROM    dbo.Z生产计划制定 计划" & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.B原材料采购管理 ON B原材料采购管理.主图号 = 计划.主图号")
            'strSql.Append("                                  AND B原材料采购管理.上级图号 = 计划.上级图号")
            'strSql.Append("                                  AND B原材料采购管理.分图号 = 计划.分图号")
            'strSql.Append("        LEFT JOIN dbo.M原材料信息 ON 原材料编号 = dbo.B原材料采购管理.材料编号")
            'strSql.Append("        LEFT JOIN dbo.VM材料区分 ON 区分 = dbo.M原材料信息.原材料区分" & vbCrLf)


            'strSql.Append(" WHERE 计划.订单编号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.订单编号) & vbCrLf)
            'strSql.Append("      and  计划.主图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.主图号) & vbCrLf)
            'strSql.Append("      and  计划.分图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.分图号) & vbCrLf)
            'strSql.Append("      and  计划.上级图号=" & Utility.PFn_ChangeQuotation(cls原材料出库申请T.上级图号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "ReportViewr"

    '检索全部数据
    Public Function ReportViewr(ByVal cls原材料出库T As Z原材料出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT DISTINCT")
            strSql.Append("        客户名称 ,")
            strSql.Append("        Z原材料出库申请.主图号 ,")
            strSql.Append("        T图纸管理.品名 ,")
            strSql.Append("        订单编号 ,")
            strSql.Append("        VM材质. 名称 材质 ,")
            strSql.Append("        CONVERT(VARCHAR(20), T图纸管理.长) + '*' + CONVERT(VARCHAR(20), T图纸管理.宽)")
            strSql.Append("        + '*' + CONVERT(VARCHAR(20), T图纸管理.高) 规格 ,")
            strSql.Append("        领料数量 张数 ,")
            strSql.Append("        领料重量 重量 ,")
            strSql.Append("        Z原材料出库申请.备注," & vbCrLf)
            strSql.Append("        申请单编号" & vbCrLf)
            strSql.Append("FROM    dbo.Z原材料出库申请" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.上级图号 = Z原材料出库申请.上级图号")
            strSql.Append("                               AND T图纸管理.主图号 = Z原材料出库申请.主图号")
            strSql.Append("                               AND dbo.T图纸管理.产品图号 = dbo.Z原材料出库申请.分图号")
            strSql.Append("        LEFT JOIN dbo.M原材料信息 ON dbo.M原材料信息.原材料编号 = dbo.Z原材料出库申请.材料编号")
            strSql.Append("        LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = T图纸管理.客户编号")
            strSql.Append("        LEFT JOIN dbo.VM材质 ON dbo.VM材质.区分=dbo.M原材料信息.材质" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            If Not String.IsNullOrEmpty(cls原材料出库T.申请单编号) Then
                strSql.Append("     申请单编号 in ('" & cls原材料出库T.申请单编号 & "')" & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
End Class
