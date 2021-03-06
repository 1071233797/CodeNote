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

Public Class DalM原材料入库申请T

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
            strSql.Append(" ,长")           '材料编号
            strSql.Append(" ,宽")           '材料编号
            strSql.Append(" ,高")           '材料编号
            strSql.Append(" ,批次号")           '入库数量
            strSql.Append(" ,供应商批次号")           '入库数量
            strSql.Append(" ,入库数量")           '入库数量
            strSql.Append(" ,入库重量")           '入库重量

            strSql.Append(" ,备注")           '订单编号
            'strSql.Append(" ,产品图号")           '产品图号
            'strSql.Append(" ,登陆者")            '登陆者
            'strSql.Append(" ,登陆日期")           '登陆日期
            'strSql.Append(" ,更新者")            '更新者
            ' strSql.Append(" ,更新日期")           '更新日期
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
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.长))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.宽))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.高))

            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.批次号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.供应商批次号))
            '入库数量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.入库数量))
            '入库重量()
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.入库重量))
            '订单编号
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.备注))
            '产品图号
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.产品图号))
            ' ''客户名称
            ''strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.客户名称))
            ''登陆者
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.登陆者))
            ''登陆日期
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.登陆日期))
            ''更新者
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.更新者))
            ''更新日期
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

            strSql.Append(" UPDATE B原材料入库申请 " & vbCrLf) '原材料入库申请
            strSql.Append(" SET " & vbCrLf)

            strSql.AppendFormat(" 		申请者编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请者编号))
            strSql.AppendFormat(" 		,采购单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.采购单编号))
            strSql.AppendFormat(" 		,申请日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请日期))
            strSql.AppendFormat(" 		,批次号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.批次号))
            strSql.AppendFormat(" 		,供应商批次号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.供应商批次号))
            strSql.AppendFormat(" 		,入库数量 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.入库数量))
            strSql.AppendFormat(" 		,入库重量 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.入库重量))
            strSql.AppendFormat(" 		,备注 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.备注))
            'cls原材料入库申请T

            '更新日期
            strSql.Append("  WHERE  1=1" & vbCrLf)
            strSql.AppendFormat(" AND   申请单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号))
            strSql.AppendFormat(" AND   材料编号={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.材料编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Updatezj "

    '数据更新操作
    Public Function Updatezj(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B原材料入库申请 ") '原材料入库申请
            strSql.Append(" SET ")
            strSql.AppendFormat(" 检查者编号={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.检查者编号))
            strSql.AppendFormat(" ,异常数量={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.异常数量))
            strSql.AppendFormat(" ,异常原因={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.异常原因))
            strSql.AppendFormat(" ,备注={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.备注))

            strSql.AppendFormat(" ,质检状态={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.质检状态))


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

            strSql.Append("  WHERE " & vbCrLf)
            strSql.AppendFormat("    申请单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "SetData原材料"

    Public Function SetData原材料(ByVal cls入库T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  " & vbCrLf)

            strSql.Append(" [原材料编号]")
            strSql.Append(" ,[原材料名称]")
            strSql.Append(" ,[原材料区分]")
            strSql.Append(" ,[类型]")
            strSql.Append(" ,[材质]")
            strSql.Append(" ,[dbo].[B原材料采购管理].订单编号")
            strSql.Append(" ,[dbo].[B原材料采购管理].产品图号")
            strSql.Append(" FROM [dbo].[M原材料信息]")
            strSql.Append("inner join [dbo].[B原材料采购管理] on [dbo].[B原材料采购管理].材料编号=[dbo].[M原材料信息].原材料编号")

            strSql.Append(" WHERE 原材料编号=" & Utility.PFn_ChangeQuotation(cls入库T.材料编号) & vbCrLf)
            If Not String.IsNullOrEmpty(cls入库T.订单编号) Then
                strSql.Append("     AND [dbo].[B原材料采购管理].订单编号 =" & Utility.PFn_ChangeQuotation(cls入库T.订单编号))
            End If
            If Not String.IsNullOrEmpty(cls入库T.采购单编号) Then
                strSql.Append("     AND [dbo].[B原材料采购管理].采购单编号 =" & Utility.PFn_ChangeQuotation(cls入库T.采购单编号))
            End If
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
#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT 申请单编号 ," & vbCrLf)
            strSql.Append("        采购单编号 ," & vbCrLf)
            strSql.Append("        申请单编号," & vbCrLf)
            strSql.Append("        申请日期," & vbCrLf)
            strSql.Append("        批次号," & vbCrLf)
            strSql.Append("        供应商批次号," & vbCrLf)
            strSql.Append("        备注," & vbCrLf)
            strSql.Append("       材料编号," & vbCrLf)
            strSql.Append("       长," & vbCrLf)
            strSql.Append("       宽," & vbCrLf)
            strSql.Append("       高," & vbCrLf)
            strSql.Append("       入库数量," & vbCrLf)
            strSql.Append("       入库重量" & vbCrLf)
            strSql.Append(" FROM   dbo.B原材料入库申请" & vbCrLf)
            strSql.Append("WHERE   1 = 1" & vbCrLf)
            strSql.Append(" AND   申请单编号= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号) & vbCrLf)
            If Not String.IsNullOrEmpty(cls原材料入库申请T.材料编号) Then
                strSql.Append(" AND   材料编号= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.材料编号) & vbCrLf)
            End If
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
            strSql.Append("         采购单编号 , ")
            strSql.Append("         B.人员名 申请者名称 , ")
            strSql.Append("         B.职务 , ")
            strSql.Append("         B.部门 , ")
            strSql.Append("         A.申请日期, ")
            strSql.Append("         A.批次号, ")
            strSql.Append("         A.供应商批次号, ")
            strSql.Append("         A.备注 ")
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
    Public Function LoadAllHeadzj(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT a.申请单编号 ," & vbCrLf)

            strSql.Append("        检查者编号 ," & vbCrLf)
            strSql.Append("        B.人员名 检查者名称 ," & vbCrLf)
            strSql.Append("        入库申请.申请日期 ," & vbCrLf)
            strSql.Append("        M人员管理.人员名 申请者" & vbCrLf)
            strSql.Append(" FROM   dbo.Z原材料入库质检 a" & vbCrLf)

            strSql.Append("        LEFT JOIN dbo.M人员管理 B ON a.检查者编号 = B.人员编号                  " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.B原材料入库申请 入库申请 ON 入库申请.申请单编号 = a.申请单编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M人员管理  ON M人员管理.人员编号=入库申请.申请者编号" & vbCrLf)
            strSql.Append(" WHERE   a.申请单编号= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function LoadAllHeadzj1(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT a.申请单编号 ," & vbCrLf)
            strSql.Append("        a.申请日期 ," & vbCrLf)
            strSql.Append("        M人员管理.人员名 申请者" & vbCrLf)
            strSql.Append(" FROM   dbo.B原材料入库申请 a" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M人员管理  ON M人员管理.人员编号=a.申请者编号" & vbCrLf)
            strSql.Append(" WHERE   a.申请单编号= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号) & vbCrLf)

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
            strSql.Append(" SELECT 入库申请.材料编号 , " & vbCrLf)
            strSql.Append("        原材料.原材料名称 材料名称 , " & vbCrLf)
            strSql.Append("        材料区分.名称 材料区分 , " & vbCrLf)
            strSql.Append("        材料种类.名称 材料种类 , " & vbCrLf)
            strSql.Append("        原材料.材质 , " & vbCrLf)
            strSql.Append("        采购.长 , " & vbCrLf)
            strSql.Append("        采购.宽 , " & vbCrLf)
            strSql.Append("        采购.高 , " & vbCrLf)
            strSql.Append("        SUM(采购.实际采购数量) 实际采购数量 , " & vbCrLf)
            strSql.Append("        SUM(采购.实际采购重量) 实际采购重量 , " & vbCrLf)
            strSql.Append("        MAX(入库申请.入库数量) [入库数量（个）] , " & vbCrLf)
            strSql.Append("        MAX(入库申请.入库重量) [入库重量（kg）]   " & vbCrLf)
            strSql.Append(" FROM   dbo.B原材料入库申请 入库申请 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.B原材料采购管理 采购 ON 入库申请.采购单编号 = 采购.采购单编号 " & vbCrLf)
            strSql.Append("                                     AND 入库申请.材料编号 = 采购.材料编号 " & vbCrLf)
            strSql.Append("        LEFT  JOIN dbo.M原材料信息 原材料 ON 原材料.原材料编号 = 入库申请.材料编号 " & vbCrLf)
            strSql.Append("  " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM材料区分 材料区分 ON 材料区分.区分 = 原材料.原材料区分 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM材料种类 材料种类 ON 材料种类.区分 = 原材料.材料种类 " & vbCrLf)
            strSql.Append(" WHERE  入库申请.采购单编号 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.采购单编号) & vbCrLf)
            strSql.Append(" GROUP BY 入库申请.采购单编号 , " & vbCrLf)
            strSql.Append("        入库申请.材料编号 , " & vbCrLf)
            strSql.Append("        原材料.原材料名称 , " & vbCrLf)
            strSql.Append("        材料区分.名称 , " & vbCrLf)
            strSql.Append("        材料种类.名称 , " & vbCrLf)
            strSql.Append("        原材料.材质 , " & vbCrLf)
            strSql.Append("        采购.长 , " & vbCrLf)
            strSql.Append("        采购.宽 , " & vbCrLf)
            strSql.Append("        采购.高;  " & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    
#End Region


#Region " LoadGridAll编辑 "

    '检索全部数据
    Public Function LoadGridAll编辑(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try


            strSql.Append("  SELECT 采购.材料编号 , " & vbCrLf)
            strSql.Append("         原材料.原材料名称 材料名称 , " & vbCrLf)
            strSql.Append("         材料区分.名称 材料区分 , " & vbCrLf)
            strSql.Append("         材料种类.名称 材料种类 , " & vbCrLf)
            strSql.Append("         材质.名称 材质 , " & vbCrLf)
            strSql.Append("         采购.长 , " & vbCrLf)
            strSql.Append("         采购.宽 , " & vbCrLf)
            strSql.Append("         采购.高 , " & vbCrLf)
            strSql.Append("         SUM(采购.实际采购数量) 实际采购数量 , " & vbCrLf)
            strSql.Append("         SUM(采购.实际采购重量) 实际采购重量 , " & vbCrLf)
            strSql.Append("         SUM(入库申请.入库数量) [入库数量（个）] , " & vbCrLf)
            strSql.Append("         SUM(入库申请.入库重量) [入库重量（kg）] " & vbCrLf)
            strSql.Append("  FROM   dbo.B原材料采购管理 采购 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.B原材料入库申请 入库申请 ON 入库申请.采购单编号 = 采购.采购单编号 " & vbCrLf)
            strSql.Append("                                        AND 入库申请.材料编号 = 采购.材料编号 " & vbCrLf)
            strSql.Append("         LEFT  JOIN dbo.M原材料信息 原材料 ON 原材料.原材料编号 = 采购.材料编号 " & vbCrLf)
            strSql.Append("         --AND 原材料.材料种类 = 4 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材料区分 材料区分 ON 材料区分.区分 = 原材料.原材料区分 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材料种类 材料种类 ON 材料种类.区分 = 原材料.材料种类 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材质 材质 ON 材质.区分 = 原材料.材质 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.T图纸管理 图纸 ON 采购.材料编号 = 图纸.产品图号 " & vbCrLf)
            strSql.Append("                                   AND 图纸.原材料编号 = 原材料.原材料编号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材料区分 材料区分1 ON 材料区分1.区分 = 原材料.材料种类 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材料种类 材料种类1 ON 材料种类1.区分 = 原材料.材料种类 " & vbCrLf)
            strSql.Append("  WHERE  采购.采购单编号 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.采购单编号) & vbCrLf)
            strSql.Append("  GROUP BY 采购.采购单编号 , " & vbCrLf)
            strSql.Append("         采购.材料编号 , " & vbCrLf)
            strSql.Append("         原材料.原材料名称 , " & vbCrLf)
            strSql.Append("         材料区分.名称 , " & vbCrLf)
            strSql.Append("         材料种类.名称 , " & vbCrLf)
            strSql.Append("         材质.名称 , " & vbCrLf)
            strSql.Append("         采购.长 , " & vbCrLf)
            strSql.Append("         采购.宽 , " & vbCrLf)
            strSql.Append("         采购.高;  " & vbCrLf)





            'strSql.Append(" SELECT 采购.材料编号 , " & vbCrLf)
            'strSql.Append("        原材料.原材料名称 材料名称 , " & vbCrLf)
            'strSql.Append("        材料区分.名称 材料区分 , " & vbCrLf)
            'strSql.Append("        材料种类.名称 材料种类 , " & vbCrLf)
            'strSql.Append("        原材料.材质 , " & vbCrLf)
            'strSql.Append("        采购.长 , " & vbCrLf)
            'strSql.Append("        采购.宽 , " & vbCrLf)
            'strSql.Append("        采购.高 , " & vbCrLf)
            'strSql.Append("        SUM(采购.实际采购数量) 实际采购数量 , " & vbCrLf)
            'strSql.Append("        SUM(采购.实际采购重量) 实际采购重量 , " & vbCrLf)
            'strSql.Append("        SUM(入库申请.入库数量) [入库数量（个）] , " & vbCrLf)
            'strSql.Append("        SUM(入库申请.入库重量) [入库重量（kg）] " & vbCrLf)
            'strSql.Append(" FROM   dbo.B原材料采购管理 采购 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.B原材料入库申请 入库申请 ON 入库申请.采购单编号 = 采购.采购单编号 " & vbCrLf)
            'strSql.Append("                                       AND 入库申请.材料编号 = 采购.材料编号 " & vbCrLf)
            'strSql.Append("        LEFT  JOIN dbo.M原材料信息 原材料 ON 原材料.原材料编号 = 采购.材料编号 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.VM材料区分 材料区分 ON 材料区分.区分 = 原材料.原材料区分 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.VM材料种类 材料种类 ON 材料种类.区分 = 原材料.材料种类 " & vbCrLf)
            'strSql.Append(" WHERE  采购.采购单编号  = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.采购单编号) & vbCrLf)
            'strSql.Append(" GROUP BY 采购.采购单编号 , " & vbCrLf)
            'strSql.Append("        采购.材料编号 , " & vbCrLf)
            'strSql.Append("        原材料.原材料名称 , " & vbCrLf)
            'strSql.Append("        材料区分.名称 , " & vbCrLf)
            'strSql.Append("        材料种类.名称 , " & vbCrLf)
            'strSql.Append("        原材料.材质 , " & vbCrLf)
            'strSql.Append("        采购.长 , " & vbCrLf)
            'strSql.Append("        采购.宽 , " & vbCrLf)
            'strSql.Append("        采购.高; " & vbCrLf)


            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT ")
            strSql.Append("         0 选择 , ")
            strSql.Append("         A.申请单编号 , ")
            strSql.Append("         采购单编号 , ")
            strSql.Append("         A.批次号 , ")
            strSql.Append("         A.供应商批次号 , ")
            'strSql.Append("         B.人员编号 , ")
            strSql.Append("         B.人员名 申请者 , ")
            strSql.Append("         B.职务 , ")
            strSql.Append("         E.部门名称 , ")
            strSql.Append("         A.申请日期 , ")

            strSql.Append("         A.备注 ")
            strSql.Append(" FROM    dbo.B原材料入库申请 A ")
            strSql.Append("         LEFT JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 ")
            strSql.Append("         LEFT JOIN dbo.M部门管理 E ON E.部门编号 = B.部门 ")
            strSql.Append("         LEFT JOIN dbo.M原材料信息 C ON A.材料编号 = C.原材料编号 ")
            strSql.Append("         LEFT JOIN dbo.Z原材料入库质检 F ON F.申请单编号 = A.申请单编号 ")
            strSql.Append(" WHERE   1 = 1 ")
            If (cls原材料入库申请T.申请单编号 <> String.Empty) Then
                strSql.Append(" AND A.申请单编号 like '" & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号, True) & "%'")
            End If
            If (cls原材料入库申请T.申请者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请者编号) & vbCrLf)
            End If

            If (cls原材料入库申请T.材料区分 <> String.Empty) Then
                strSql.Append(" AND C.原材料区分 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.材料区分) & vbCrLf)
            End If
            If (cls原材料入库申请T.质检状态 <> String.Empty) Then
                strSql.Append(" AND F.处理结果 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.质检状态) & vbCrLf)
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

#Region " LoadByWhere1 "

    '检索全部数据
    Public Function LoadByWhere1(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            'strSql.Append(" SELECT distinct 0 选择,A.申请单编号 , ")
            strSql.Append(" SELECT DISTINCT" & vbCrLf)
            strSql.Append("        0 选择 ," & vbCrLf)
            strSql.Append("        A.申请单编号 ," & vbCrLf)
            strSql.Append("        A.材料编号 ," & vbCrLf)
            strSql.Append("        C.原材料名称 材料名称 ," & vbCrLf)
            strSql.Append("       g.名称 AS 材料区分 ," & vbCrLf)
            strSql.Append("       A.长 , " & vbCrLf)
            strSql.Append("       A.宽 ," & vbCrLf)
            strSql.Append("       A.高 ," & vbCrLf)
            strSql.Append("        A.入库数量 [入库数量（个）] ," & vbCrLf)
            strSql.Append("        A.入库重量 [入库重量（kg）] ," & vbCrLf)
            strSql.Append("        C.材质 ," & vbCrLf)
            strSql.Append("        x.名称 质检状态" & vbCrLf)
            'strSql.Append("        A.材料编号" & vbCrLf)
            strSql.Append(" FROM   dbo.B原材料入库申请 A" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M原材料信息 C ON C.原材料编号 = A.材料编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM材料区分 g ON g.区分 = c.原材料区分" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.Z原材料入库质检 F ON F.申请单编号 = A.申请单编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM质检状态 x ON x.区分 = F.处理结果" & vbCrLf)
            strSql.Append(" WHERE   1 = 1 ")
            If (cls原材料入库申请T.申请单编号 <> String.Empty) Then
                strSql.Append(" AND A.申请单编号 like '" & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请单编号, True) & "%'")
            End If
            If (cls原材料入库申请T.申请者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.申请者编号) & vbCrLf)
            End If

            If (cls原材料入库申请T.材料区分 <> String.Empty) Then
                strSql.Append(" AND C.原材料区分 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.材料区分) & vbCrLf)
            End If
            If (cls原材料入库申请T.质检状态 <> String.Empty) Then
                strSql.Append(" AND F.处理结果 = " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.质检状态) & vbCrLf)
            End If
            If (cls原材料入库申请T.开始日期 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 >= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.开始日期) & vbCrLf)
            End If

            If (cls原材料入库申请T.结束日期 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 <= " & Utility.PFn_ChangeQuotation(cls原材料入库申请T.结束日期) & vbCrLf)
            End If
            strSql.Append("order by A.申请单编号")
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
            strSql.Append("        A.采购单编号 , " & vbCrLf)
            strSql.Append("        A.材料编号 原材料编号 , " & vbCrLf)
            strSql.Append("        C.原材料名称 原材料名称 , " & vbCrLf)
            strSql.Append("        A.批次号 , " & vbCrLf)
            strSql.Append("        A.长 , " & vbCrLf)
            strSql.Append("        A.宽 , " & vbCrLf)
            strSql.Append("        A.高 , " & vbCrLf)
            strSql.Append("        A.供应商批次号 , " & vbCrLf)
            ' strSql.Append("        A.订单编号 , " & vbCrLf)
            strSql.Append("        A.申请日期 , " & vbCrLf)
            strSql.Append("        B.人员名 申请者 , " & vbCrLf)
            strSql.Append("        A.入库数量 , " & vbCrLf)
            strSql.Append("        A.入库重量 , " & vbCrLf)
            strSql.Append("        D.检查内容 , " & vbCrLf)
            strSql.Append("        D.检查数量 , " & vbCrLf)
            strSql.Append("        D.不良数量 , " & vbCrLf)
            strSql.Append("        D.不良原因 , " & vbCrLf)

            strSql.Append("        F.名称 处理结果 , " & vbCrLf)
            strSql.Append("        D.备注 " & vbCrLf)
            strSql.Append(" FROM   dbo.B原材料入库申请 A " & vbCrLf)

            strSql.Append("        INNER JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 " & vbCrLf)
            strSql.Append("        INNER JOIN dbo.M原材料信息 C ON C.原材料编号 = A.材料编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN Z原材料入库质检 D ON D.申请单编号 = A.申请单编号 " & vbCrLf)
            'strSql.Append("                                AND D.订单编号 = A.订单编号 " & vbCrLf)
            strSql.Append("                                AND D.材料编号 = C.原材料编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN VM质检状态 F ON F.区分 = D.处理结果 " & vbCrLf)
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
#Region " Load打印数据 "

    '检索全部数据
    Public Function Load打印数据(ByVal strWhere As String) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("  SELECT DISTINCT")
            strSql.Append("         B原材料入库申请.申请单编号 ,")
            strSql.Append("         B原材料入库申请.采购单编号,")
            strSql.Append("         B原材料入库申请.批次号,")
            strSql.Append("         M原材料信息.原材料名称 材料名称 ,")
            strSql.Append("         VM材料区分.名称 AS 材料区分 ,")
            strSql.Append("         B原材料入库申请.长 ,")
            strSql.Append("         B原材料入库申请.宽 ,")
            strSql.Append("         B原材料入库申请.高 ,")
            strSql.Append("         B原材料入库申请.入库数量,")
            strSql.Append("         B原材料入库申请.入库重量,")
            strSql.Append("         VM材质.名称 材质 ,")
            strSql.Append("         VM质检状态.名称 质检状态")
            strSql.Append("  FROM   dbo.B原材料入库申请 ")
            strSql.Append("         LEFT JOIN dbo.M原材料信息 ON M原材料信息.原材料编号 = B原材料入库申请.材料编号")
            strSql.Append("         LEFT JOIN dbo.VM材料区分  ON VM材料区分.区分 = M原材料信息.原材料区分")
            strSql.Append("         LEFT JOIN dbo.Z原材料入库质检  ON Z原材料入库质检.申请单编号 = B原材料入库申请.申请单编号")
            strSql.Append("         LEFT JOIN dbo.VM质检状态  ON VM质检状态.区分 = Z原材料入库质检.处理结果")
            strSql.Append("         LEFT JOIN dbo.VM材质 ON VM材质.区分 = M原材料信息.材质")
            strSql.Append("  WHERE  1 = 1 ")
            If (strWhere <> String.Empty) Then
                strSql.Append(" AND B原材料入库申请.申请单编号  IN (" & strWhere & ")")
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
End Class
