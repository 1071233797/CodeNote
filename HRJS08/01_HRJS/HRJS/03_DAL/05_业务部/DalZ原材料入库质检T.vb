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

Public Class DalZ原材料入库质检T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B原材料入库申请")          '原材料入库申请

            strSql.Append(" (申请单编号")          '申请单编号
            strSql.Append(" ,申请者编号")          '申请者编号
            strSql.Append(" ,采购单编号")          '申请者编号
            strSql.Append(" ,申请日期")           '申请日期
            strSql.Append(" ,材料编号")           '材料编号
            strSql.Append(" ,入库数量")           '入库数量
            strSql.Append(" ,入库重量")           '入库重量
            strSql.Append(" ,订单编号")           '订单编号
            strSql.Append(" ,产品图号")           '产品图号
            'strSql.Append(" ,登陆者")            '登陆者
            ' strSql.Append(" ,登陆日期")           '登陆日期
            ' strSql.Append(" ,更新者")            '更新者
            'strSql.Append(" ,更新日期")           '更新日期
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号))
            '申请者编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请者编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.采购单编号))
            '申请日期
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请日期))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.材料编号))
            '入库数量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.入库数量))
            '入库重量()
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.入库重量))
            '订单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.订单编号))
            '产品图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.产品图号))
            ''客户名称
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.客户名称))
            '登陆者
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.登陆者))
            '登陆日期
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.登陆日期))
            '更新者
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.更新者))
            '更新日期
            'strSql.AppendFormat(" {0} " & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.更新日期))
            strSql.Append(" )")
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region
#Region " Insertzj "

    '数据插入操作
    Public Function Insertzj(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B原材料入库申请")          '原材料入库申请

            strSql.Append(" (检查者编号")          '检查者编号
            strSql.Append(" ,异常数量")          '异常数量
            strSql.Append(" ,异常原因")           '异常原因
            strSql.Append(" ,备注")           '备注
            'strSql.Append(" ,入库数量")           '入库数量
            'strSql.Append(" ,入库重量")           '入库重量
            'strSql.Append(" ,订单编号")           '订单编号
            'strSql.Append(" ,产品图号")           '产品图号
            'strSql.Append(" ,登陆者")            '登陆者
            'strSql.Append(" ,登陆日期")           '登陆日期
            'strSql.Append(" ,更新者")            '更新者
            strSql.Append(" ,质检状态")           '质检状态
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.检查者编号))
            '申请者编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.异常数量))
            '申请日期
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.异常原因))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.备注))
            '入库数量
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.入库数量))
            ''入库重量()
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.入库重量))
            ''订单编号
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.订单编号))
            ''产品图号
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.产品图号))
            ''客户名称
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.质检状态))
            '登陆者
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.登陆者))
            ''登陆日期
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.登陆日期))
            ''更新者
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.更新者))
            ''更新日期
            'strSql.AppendFormat(" {0} " & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.更新日期))
            'strSql.Append(" )")
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region
#Region " Update "

    '数据更新操作
    Public Function Update(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE 原材料入库申请 ") '原材料入库申请
            strSql.Append(" SET ")

            '申请单编号

            '申请者编号

            '申请日期

            '材料编号

            '入库数量

            '入库重量

            '订单编号

            '产品图号

            '质检状态

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
#Region " Updatezj "

    '数据更新操作
    Public Function insertCheck(ByVal cls原材料入库质检T As B原材料入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" IF ( SELECT    COUNT(*) " & vbCrLf)
            strSql.Append("      FROM      Z原材料入库质检 " & vbCrLf)
            strSql.Append("  WHERE " & vbCrLf)
            strSql.AppendFormat("    申请单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.申请单编号))
            'strSql.AppendFormat(" and 订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.订单编号))
            strSql.AppendFormat(" and 材料编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.材料编号))
            strSql.Append("    ) = 0 " & vbCrLf)

            strSql.Append("INSERT INTO [HRJS].[dbo].[Z原材料入库质检] " & vbCrLf)
            strSql.Append("           ([申请单编号] " & vbCrLf)
            strSql.Append("           ,[材料编号] " & vbCrLf)
            strSql.Append("           ,[长] " & vbCrLf)
            strSql.Append("           ,[宽] " & vbCrLf)
            strSql.Append("           ,[高] " & vbCrLf)
            ' strSql.Append("           ,[订单编号] " & vbCrLf)
            strSql.Append("           ,[检查者编号] " & vbCrLf)
            strSql.Append("           ,[检查日期] " & vbCrLf)
            strSql.Append("           ,[检查内容] " & vbCrLf)
            strSql.Append("           ,[检查数量] " & vbCrLf)
            strSql.Append("           ,[不良数量] " & vbCrLf)
            strSql.Append("           ,[不良原因] " & vbCrLf)
            strSql.Append("           ,[处理结果] " & vbCrLf)
            strSql.Append("           ,[备注]) " & vbCrLf)
            strSql.Append("     VALUES " & vbCrLf)
            strSql.Append("           (" & Utility.PFn_ChangeQuotation(cls原材料入库质检T.申请单编号) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.材料编号) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.长) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.宽) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.高) & vbCrLf)
            'strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.订单编号) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查者编号) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查日期) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查内容) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查数量) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.不良数量) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.不良原因) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.处理结果) & vbCrLf)
            strSql.Append("           ," & Utility.PFn_ChangeQuotation(cls原材料入库质检T.备注) & vbCrLf)
            strSql.Append("           )")
            strSql.Append(" ELSE " & vbCrLf)
            strSql.AppendFormat("UPDATE [HRJS].[dbo].[Z原材料入库质检] ")
            strSql.AppendFormat("   SET [申请单编号] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.申请单编号))
            strSql.AppendFormat("      ,[材料编号] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.材料编号))
            strSql.AppendFormat("      ,[长] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.长))
            strSql.AppendFormat("      ,[宽] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.宽))
            strSql.AppendFormat("      ,[高] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.高))
            'strSql.AppendFormat("      ,[订单编号] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.订单编号))
            strSql.AppendFormat("      ,[检查者编号] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查者编号))
            strSql.AppendFormat("      ,[检查日期] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查日期))
            strSql.AppendFormat("      ,[检查内容] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查内容))
            strSql.AppendFormat("      ,[检查数量] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查数量))
            strSql.AppendFormat("      ,[不良数量] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.不良数量))
            strSql.AppendFormat("      ,[不良原因] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.不良原因))
            strSql.AppendFormat("      ,[处理结果] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.处理结果))
            strSql.AppendFormat("      ,[备注] = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.备注))
            strSql.AppendFormat("  WHERE " & vbCrLf)
            strSql.AppendFormat("    申请单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.申请单编号))
            'strSql.AppendFormat(" and 订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.订单编号))
            strSql.AppendFormat(" and 材料编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库质检T.材料编号))
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" DELETE FROM B原材料入库申请" & vbCrLf)
            strSql.Append(" WHERE  1=1" & vbCrLf)
            strSql.Append(" AND 申请单编号 =  '" & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号, True) & "'" & vbCrLf)
            'SQLに戻る

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Deletezj "

    '数据删除操作
    Public Function Deletezj(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" UPDATE B原材料入库申请 ") '原材料入库申请
            strSql.Append(" SET ")
            strSql.AppendFormat(" 检查者编号=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.检查者编号))
            strSql.AppendFormat(" ,异常数量=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.异常数量))
            strSql.AppendFormat(" ,异常原因=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.异常原因))
            strSql.AppendFormat(" ,备注=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.备注))

            strSql.AppendFormat(" ,质检状态=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.质检状态))

            strSql.Append("  WHERE " & vbCrLf)
            strSql.AppendFormat("    申请单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号))

            '申请单编号
            'strSql.AppendFormat(" ," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.异常数量))
            'strSql.AppendFormat(" ," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.异常原因))
            'strSql.AppendFormat(" ," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.备注))
            'strSql.AppendFormat(" ," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.检查者编号))
            'strSql.AppendFormat("  " & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.质检状态))
            'strSql.Append(" )")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


#Region " LoadByPKey "

    '检索全部数据
    Public Function LoadByPKey(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         申请者编号  ")
            strSql.Append(" FROM    dbo.B原材料入库申请")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAllHead "

    '检索全部数据
    Public Function LoadAllHead(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         申请者编号 , ")
            strSql.Append("         B.人员名 申请者名称 , ")
            strSql.Append("         B.职务 , ")
            strSql.Append("         B.部门 , ")
            strSql.Append("         A.申请日期 ")
            strSql.Append(" FROM    dbo.B原材料入库申请 a ")
            strSql.Append("         INNER JOIN dbo.M人员管理 B  ")
            strSql.Append("         ON a.申请者编号 = B.人员编号 ")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadGridAll "

    '检索全部数据
    Public Function LoadGridAll(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  distinct A.材料编号 , ")
            strSql.Append("         B.原材料名称 材料名称 , ")
            strSql.Append("         B.原材料区分 材料区分, ")
            'strSql.Append("         B.原材料区分 材料种类, ")
            strSql.Append("         B.材质 , ")
            strSql.Append("         入库数量 [入库数量（个）] , ")
            strSql.Append("         A.入库重量 [入库重量（kg）] , ")
            strSql.Append("         A.订单编号 , ")
            strSql.Append("         A.产品图号  ")
            'strSql.Append("         D.客户名称 ")
            strSql.Append(" FROM    dbo.B原材料入库申请 A ")
            strSql.Append("         INNER JOIN dbo.M原材料信息 B ON A.材料编号 = B.原材料编号 ")
            strSql.Append("         INNER JOIN dbo.B订单管理 C ON A.订单编号 = C.订单编号 ")
            'strSql.Append("         INNER JOIN dbo.M客户管理 D ON D.客户编号 = C.客户编号 ")
            strSql.Append(" WHERE   A.申请单编号= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls原材料入库质检T As B原材料入库质检T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("  SELECT	DISTINCT" & vbCrLf)
            strSql.Append("            A.申请单编号 ," & vbCrLf)
            strSql.Append("            d.采购单编号 ," & vbCrLf)
            strSql.Append("            d.材料编号 原材料编号 ," & vbCrLf)
            strSql.Append("            C.原材料名称 原材料名称 ," & vbCrLf)
            strSql.Append("            d.批次号 ," & vbCrLf)
            strSql.Append("            d.供应商批次号 ," & vbCrLf)
            strSql.Append("            d.申请日期 ," & vbCrLf)
            strSql.Append("            B.人员名 申请者 ," & vbCrLf)
            strSql.Append("            d.入库数量 ," & vbCrLf)
            strSql.Append("            d.入库重量 ," & vbCrLf)
            strSql.Append("            a.检查内容 ," & vbCrLf)
            strSql.Append("            a.检查数量 ," & vbCrLf)
            strSql.Append("            a.不良数量 ," & vbCrLf)
            strSql.Append("            a.不良原因 ," & vbCrLf)
            strSql.Append("            F.名称 处理结果 ," & vbCrLf)
            strSql.Append("            E.人员名 检查者编号 ," & vbCrLf)
            strSql.Append("            a.检查日期 ," & vbCrLf)
            strSql.Append("            a.备注" & vbCrLf)
            strSql.Append("  FROM      dbo.Z原材料入库质检 A" & vbCrLf)
            strSql.Append("            INNER JOIN b原材料入库申请 D ON D.申请单编号 = A.申请单编号 AND A. 材料编号=D.材料编号" & vbCrLf)
            strSql.Append("                                     " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M原材料信息 C ON C.原材料编号 = A.材料编号 AND A. 材料编号=C.原材料编号" & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M人员管理 B ON d.申请者编号 = B.人员编号                         " & vbCrLf)
            strSql.Append("            LEFT JOIN VM质检状态 F ON F.区分 = A.处理结果" & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.M人员管理 E ON E.人员编号 = A.检查者编号" & vbCrLf)
            strSql.Append("  WHERE     1 = 1 " & vbCrLf)
            If (cls原材料入库质检T.材料编号 <> String.Empty) Then
                strSql.Append("            AND D.材料编号 = " & Utility.PFn_ChangeQuotation(cls原材料入库质检T.材料编号) & vbCrLf)

            End If
            If (cls原材料入库质检T.检查者编号 <> String.Empty) Then
                strSql.Append("            AND A.检查者编号 = " & Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查者编号) & vbCrLf)
            End If

            If (cls原材料入库质检T.申请单编号 <> String.Empty) Then
                strSql.Append("            AND A.申请单编号 = " & Utility.PFn_ChangeQuotation(cls原材料入库质检T.申请单编号) & vbCrLf)
            End If

            If (cls原材料入库质检T.处理结果 <> String.Empty) Then
                strSql.Append("            AND A.处理结果 = " & Utility.PFn_ChangeQuotation(cls原材料入库质检T.处理结果) & vbCrLf)
            End If

            If (cls原材料入库质检T.检查日期S <> "1900/1/1") Then
                strSql.Append("            AND A.检查日期 >= " & Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查日期S) & vbCrLf)
            End If

            If (cls原材料入库质检T.检查日期E <> "1900/1/1") Then
                strSql.Append("            AND A.检查日期 <= " & Utility.PFn_ChangeQuotation(cls原材料入库质检T.检查日期E.AddDays(1)) & vbCrLf)
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
    Public Function LoadByWhere1(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT distinct 0 选择,申请单编号 , ")
            strSql.Append("         C.原材料名称 材料名称 , ")
            strSql.Append("         C.原材料区分 AS 材料区分 , ")
            ''strSql.Append("         C.批次号 材料批号 , ")
            strSql.Append("         A.入库数量 [入库数量（个）] , ")
            strSql.Append("         A.入库重量 [入库重量（kg）] , ")
            strSql.Append("         C.材质 , ")
            strSql.Append("         A.订单编号 , ")
            strSql.Append("         A.产品图号 , ")
            strSql.Append("         E.客户名称 , ")
            strSql.Append("         A.质检状态 ")
            strSql.Append(" FROM    dbo.B原材料入库申请 A ")
            strSql.Append("         INNER JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 ")
            strSql.Append("         INNER JOIN dbo.M原材料信息 C ON C.原材料编号 = A.材料编号 ")
            strSql.Append("         INNER JOIN dbo.B订单管理 d ON d.订单编号 = A.订单编号 ")
            strSql.Append("         INNER JOIN dbo.M客户管理 E ON E.客户编号 = d.客户编号 ")
            strSql.Append(" WHERE   1 = 1 ")
            If (cls原材料入库申请T.申请单编号 <> String.Empty) Then
                strSql.Append(" AND 申请单编号 like '" & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号, True) & "%'")
            End If
            If (cls原材料入库申请T.申请者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请者编号) & vbCrLf)
            End If

            If (cls原材料入库申请T.材料区分 <> String.Empty) Then
                strSql.Append(" AND C.原材料区分 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.材料区分) & vbCrLf)
            End If
            If (cls原材料入库申请T.质检状态 <> String.Empty) Then
                strSql.Append(" AND 质检状态 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.质检状态) & vbCrLf)
            End If
            If (cls原材料入库申请T.开始日期 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 >= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.开始日期) & vbCrLf)
            End If

            If (cls原材料入库申请T.结束日期 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 <= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.结束日期) & vbCrLf)
            End If




            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllzj "

    '检索全部数据
    Public Function LoadAllzj(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT " & vbCrLf)
            strSql.Append("        A.材料编号 原材料编号 , " & vbCrLf)
            strSql.Append("        C.原材料名称 原材料名称 , " & vbCrLf)
            strSql.Append("        A.订单编号 , " & vbCrLf)
            strSql.Append("        A.申请日期 , " & vbCrLf)
            strSql.Append("        B.人员名 申请者 , " & vbCrLf)
            strSql.Append("        A.入库数量 , " & vbCrLf)
            strSql.Append("        D.检查内容 , " & vbCrLf)
            strSql.Append("        D.检查数量 , " & vbCrLf)
            strSql.Append("        D.不良数量 , " & vbCrLf)
            strSql.Append("        D.不良原因 , " & vbCrLf)
            strSql.Append("        D.处理结果 , " & vbCrLf)
            strSql.Append("        D.备注 " & vbCrLf)
            strSql.Append(" FROM   dbo.B原材料入库申请 A " & vbCrLf)
            strSql.Append("        INNER JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 " & vbCrLf)
            strSql.Append("        INNER JOIN dbo.M原材料信息 C ON C.原材料编号 = A.材料编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN Z原材料入库质检 D ON D.申请单编号 = A.申请单编号 " & vbCrLf)
            strSql.Append("                                AND D.订单编号 = A.订单编号 " & vbCrLf)
            strSql.Append("                                AND D.原材料编号 = C.原材料编号 " & vbCrLf)
            strSql.Append(" WHERE  1 = 1 " & vbCrLf)
            If (cls原材料入库申请T.申请单编号 <> String.Empty) Then
                strSql.Append(" AND A.申请单编号 like '" & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号, True) & "%'")
            End If
            'If (cls原材料入库申请T.申请者编号 <> String.Empty) Then
            '    strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请者编号) & vbCrLf)
            'End If

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region

End Class
