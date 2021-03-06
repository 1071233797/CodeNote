Imports System.Text

#Region "Dal订单表
'------------------------------------------------------------------------------------
'   说明
'       订单表的数据库操作SQL文
'   创建人
'       大连思铭科技 解辉品
'   创建时间
'       2016/5/25
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalM订单表T

#Region "IsExists"

    Public Function IsExists订单编号(ByVal str订单编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   B订单管理 " & vbCrLf)
            strSql.Append("WHERE  订单编号 = " & Utility.PFn_ChangeQuotation(str订单编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function IsExists厂内编号(ByVal str厂内编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   B订单管理 " & vbCrLf)
            strSql.Append("WHERE  厂内编号 = " & Utility.PFn_ChangeQuotation(str厂内编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B订单管理")          '订单表

            strSql.Append(" (订单编号")           '订单编号
            strSql.Append(" ,订单区分")           '出荷去向
            strSql.Append(" ,厂内编号")           '出荷方法
            strSql.Append(" ,客户编号")           '制造区分
            strSql.Append(" ,订单接受日期")           '部品番号
            strSql.Append(" ,产品图号")           '部品区分
            'strSql.Append(" ,产品名称")           '出荷数量
            strSql.Append(" ,产品区分")         '区分  
            ' strSql.Append(" ,产品种类名称")           '佳能要求
            strSql.Append(" ,机型制造编号")           '佳能要求
            strSql.Append(" ,品种规格")           '佳能要求
            strSql.Append(" ,型号")           '佳能要求
            strSql.Append(" ,含税单价")           '工程图番
            strSql.Append(" ,订单数量")         '机种
            strSql.Append(" ,含税总金额")           '包装方法
            strSql.Append(" ,未税单价")           '出荷日期
            strSql.Append(" ,未税总金额")         '备注
            'strSql.Append(" ,投产数量")
            strSql.Append(" ,币种")            '作成者
            strSql.Append(" ,交货方式")           '订单日期
            strSql.Append(" ,发货日期")           '出荷日期
            strSql.Append(" ,到货日期")         '备注
            strSql.Append(" ,目的港名")            '作成者
            'strSql.Append(" ,目的港编号")            '作成者
            strSql.Append(" ,产品发票号")           '订单日期
            strSql.Append(" ,产品助记码")           '出荷日期
            strSql.Append(" ,作成者编号")         '备注
            'strSql.Append(" ,登录者")            '作成者
            'strSql.Append(" ,登录日期")           '订单日期

            strSql.Append(" ,备注")            '作成者

            'lxq 2017-04-21 update 

            'strSql.Append(" ,审核状态")           '订单日期
            'strSql.Append(" ,审核备注")           '订单日期
            'strSql.Append(" ,审核人")           '订单日期

            'lxq 2017-04-21 end

            ' strSql.Append(" ,订单编号CD")           '订单日期
            strSql.Append(" ,订单状态")           '订单日期
            strSql.Append(")")

            strSql.Append(" VALUES ")

            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.订单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.订单区分))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.厂内编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.客户编号))

            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.订单接受日期))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.产品图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.产品区分))
            ' strSql.AppendFormat(" {0}," &vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.产品区分))
            'strSql.AppendFormat(" {0}," &vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.产品种类名称))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.机型制造编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.品种规格))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.型号))


            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.含税单价))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.订单数量))
            ' strSql.Append(cls订单表T.订单数量)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.含税总金额))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.未税单价))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.未税总金额))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.投产数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.币种))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.交货方式))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.发货日期))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.到货日期))
            If cls订单表T.目的港名 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.目的港名))
            End If

            If cls订单表T.产品发票号 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.产品发票号))

            End If
            If cls订单表T.产品助记码 = "" Then
                strSql.Append("NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.产品助记码))
            End If
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.作成者编号))
            'strSql.AppendFormat(" {0}," &vbCrLf,  Utility.PFn_ChangeQuotation(cls订单表T.登录者))
            'strSql.AppendFormat(" {0}," &vbCrLf,  Utility.PFn_ChangeQuotation(cls订单表T.登录日期))
            If cls订单表T.备注 = "" Then
                strSql.Append("NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.备注))
            End If

            'lxq 2017-04-21 update

            'If cls订单表T.审核状态 = "" Then
            '    strSql.Append(" NULL, ")
            '    strSql.Append(" NULL, ")
            '    strSql.Append(" NULL, ")
            'Else
            '    strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.审核状态))
            '    strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.审核备注))
            '    strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.审核人))
            'End If
            ' strSql.AppendFormat(" {0}," &vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.订单编号CD))

            'lxq 2017-04-21 end

            If cls订单表T.订单状态 = "" Then
                strSql.Append(" NULL ")
            Else
                strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.订单状态))

            End If
            strSql.Append("  )" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B订单管理 ") '订单表
            strSql.Append(" SET ")

            strSql.AppendFormat(" 订单区分=" & Utility.PFn_ChangeQuotation(cls订单表T.订单区分))
            strSql.AppendFormat(" ,客户编号=" & Utility.PFn_ChangeQuotation(cls订单表T.客户编号))
            strSql.AppendFormat(",订单接受日期=" & Utility.PFn_ChangeQuotation(cls订单表T.订单接受日期))
            strSql.AppendFormat(" ,产品图号=" & Utility.PFn_ChangeQuotation(cls订单表T.产品图号))

            ' strSql.AppendFormat(" ,产品名称=" & Utility.PFn_ChangeQuotation(cls订单表T.产品名称))
            strSql.AppendFormat(" ,产品区分=" & Utility.PFn_ChangeQuotation(cls订单表T.产品区分))
            'strSql.AppendFormat(" ,产品种类名称=" & Utility.PFn_ChangeQuotation(cls订单表T.产品种类名称))
            strSql.AppendFormat(" ,机型制造编号=" & Utility.PFn_ChangeQuotation(cls订单表T.机型制造编号))
            strSql.AppendFormat(" ,品种规格=" & Utility.PFn_ChangeQuotation(cls订单表T.品种规格))
            strSql.AppendFormat(" ,型号=" & Utility.PFn_ChangeQuotation(cls订单表T.型号))
            strSql.AppendFormat(" ,含税单价=" & Utility.PFn_ChangeQuotation(cls订单表T.含税单价))
            strSql.Append(" ,订单数量=" & cls订单表T.订单数量)
            strSql.Append(" ,投产数量=" & cls订单表T.投产数量)
            strSql.AppendFormat("  ,含税总金额=" & Utility.PFn_ChangeQuotation(cls订单表T.含税总金额))
            strSql.AppendFormat("  ,未税单价=" & Utility.PFn_ChangeQuotation(cls订单表T.未税单价))
            strSql.AppendFormat("  ,未税总金额=" & Utility.PFn_ChangeQuotation(cls订单表T.未税总金额))
            strSql.AppendFormat("  ,币种=" & Utility.PFn_ChangeQuotation(cls订单表T.币种))
            strSql.AppendFormat(" ,交货方式=" & Utility.PFn_ChangeQuotation(cls订单表T.交货方式))
            strSql.AppendFormat(" ,发货日期=" & Utility.PFn_ChangeQuotation(cls订单表T.发货日期))
            strSql.AppendFormat("  ,到货日期=" & Utility.PFn_ChangeQuotation(cls订单表T.到货日期))
            If cls订单表T.目的港名 = "" Then
                strSql.Append("  ,目的港名=NULL ")
            Else
                strSql.AppendFormat(" ,目的港名=" & Utility.PFn_ChangeQuotation(cls订单表T.目的港名))
            End If

            If cls订单表T.产品发票号 = "" Then
                strSql.Append("  ,产品发票号=NULL ")
            Else
                strSql.AppendFormat("  ,产品发票号=" & Utility.PFn_ChangeQuotation(cls订单表T.产品发票号))

            End If
            If cls订单表T.产品助记码 = "" Then
                strSql.Append(" ,产品助记码=NULL ")
            Else
                strSql.AppendFormat(" ,产品助记码=" & Utility.PFn_ChangeQuotation(cls订单表T.产品助记码))
            End If
            strSql.AppendFormat(" ,作成者编号=" & Utility.PFn_ChangeQuotation(cls订单表T.作成者编号))
            'strSql.AppendFormat(" ,更新者=" & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.更新者))
            ' strSql.AppendFormat(" ,更新日期=" & vbCrLf, Utility.PFn_ChangeQuotation(cls订单表T.更新日期))
            If cls订单表T.备注 = "" Then
                strSql.Append(" ,备注 =NULL ")
            Else
                strSql.AppendFormat(" ,备注 =" & Utility.PFn_ChangeQuotation(cls订单表T.备注))
            End If

            'lxq 2017-04-21 update
            'If cls订单表T.审核状态 = "" Then
            '    strSql.Append(" ,审核状态 = NULL ")
            '    strSql.Append(" ,审核备注 = NULL ")
            '    strSql.Append(" ,审核人 = NULL ")
            'Else
            '    strSql.AppendFormat(" ,审核状态 = " & Utility.PFn_ChangeQuotation(cls订单表T.审核状态))
            '    strSql.AppendFormat(" ,审核备注 = " & Utility.PFn_ChangeQuotation(cls订单表T.审核备注))
            '    strSql.AppendFormat(" ,审核人= " & Utility.PFn_ChangeQuotation(cls订单表T.审核人))
            'End If
            'lxq 2017-04-21 end

            If cls订单表T.订单状态 = "" Then
                strSql.Append(" ,订单状态 = NULL ")
            Else
                strSql.AppendFormat(" ,订单状态 = " & Utility.PFn_ChangeQuotation(cls订单表T.订单状态))

            End If
            strSql.Append(" WHERE ")
            strSql.Append(" 订单编号 = " & Utility.PFn_ChangeQuotation(cls订单表T.订单编号)) '订单编号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Update审核数据 "

    '数据更新操作
    Public Function Update审核数据(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE dbo.B订单管理 ") '订单表
            strSql.Append(" SET ")
            strSql.Append(" 审核状态=" & Utility.PFn_ChangeQuotation(cls订单表T.审核状态))
            strSql.Append(" ,审核备注=" & Utility.PFn_ChangeQuotation(cls订单表T.审核备注))
            strSql.Append(" ,审核人=" & Utility.PFn_ChangeQuotation(cls订单表T.审核人) & vbCrLf)
            strSql.Append("WHERE 订单编号 IN('" & cls订单表T.订单编号 & "')")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM B订单管理 ") '订单表)

            strSql.Append(" WHERE ")
            strSql.Append(" 订单编号 = " & Utility.PFn_ChangeQuotation(cls订单表T.订单编号)) '订单编号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "Get订单编号CD"

    Public Function Get订单编号CD(ByVal model As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("         + 1 AS 顺序号 " & vbCrLf)
            strSql.Append("FROM   B订单管理 " & vbCrLf)
            strSql.Append(" WHERE    1 = 1 " & vbCrLf)

            If model.订单编号 <> String.Empty Then
                strSql.Append(" AND 订单编号 =" & Utility.PFn_ChangeQuotation(model.订单编号) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try
    End Function
#End Region

#Region "LoadHead"

    Public Function LoadHead(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT DISTINCT TOP 1 订单.订单编号 " & vbCrLf)
            ' strSql.Append(" ,订单.订单区分")           '出荷去向
            strSql.Append(" ,vm订单区分.名称 AS 订单区分 " & vbCrLf)
            ' strSql.Append(" ,订单.产品种类名称")           '出荷去向

            strSql.Append(" ,订单.厂内编号")           '出荷方法
            strSql.Append(" ,订单.客户编号")           '制造区分
            strSql.Append(" ,客户.客户名称 AS 客户名称")           '制造区分
            strSql.Append(" ,客户.税率  ")           '税率
            strSql.Append(" ,订单.订单接受日期")           '部品番号
            strSql.Append(" ,订单.审核状态")           '订单日期
            strSql.Append(" ,订单.订单状态")           '订单日期
            strSql.Append(" ,订单.审核人")           '订单日期
            strSql.Append("  FROM   B订单管理 订单" & vbCrLf)
            strSql.Append("       LEFT JOIN m客户管理 客户 " & vbCrLf)
            strSql.Append("         ON 订单.客户编号 = 客户.客户编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM订单区分 ON VM订单区分.区分 = 订单.订单区分 " & vbCrLf)
            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 订单.订单编号 =" & Utility.PFn_ChangeQuotation(cls订单表T.订单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "LoadBody"

    Public Function LoadBody(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT DISTINCT " & vbCrLf)

            strSql.Append(" 订单.产品图号")           '部品区分
            ' strSql.Append(" ,订单.产品名称")           '出荷数量
            strSql.Append(" ,T图纸管理.品名 产品名称")           '出荷数量
            strSql.Append(" ,订单.产品区分")         '区分
            ' strSql.Append(" ,产品种类.产品种类名称 as 产品种类")           '佳能要求
            strSql.Append(" ,订单.机型制造编号")           '佳能要求
            strSql.Append(" ,订单.品种规格")           '佳能要求
            strSql.Append(" ,订单.型号")           '佳能要求
            strSql.Append(" ,订单.含税单价")           '工程图番
            strSql.Append(" ,订单.订单数量")         '机种
            'strSql.Append(" ,订单.投产数量")         '备注
            strSql.Append(" ,订单.含税总金额")           '包装方法
            strSql.Append(" ,订单.未税单价")           '出荷日期
            strSql.Append(" ,订单.未税总金额")         '备注

            strSql.Append(" ,订单.币种")            '作成者
            strSql.Append(" ,订单.交货方式")           '订单日期
            strSql.Append(" ,订单.发货日期")           '出荷日期
            strSql.Append(" ,订单.到货日期")         '备注
            strSql.Append(" ,订单.目的港名")           '订单日期
            strSql.Append(" ,订单.产品发票号")           '订单日期
            strSql.Append(" ,订单.产品助记码")           '出荷日期
            strSql.Append(" ,订单.作成者编号")         '备注
            strSql.Append(" ,人员.人员名 AS 作成者姓名")         '备注

            strSql.Append(" ,订单.备注")            '作成者
            ' strSql.Append(" ,订单.产品种类名称")           '佳能要求
            'strSql.Append(" ,订单.目的港编号")            '作成者
            'strSql.Append(" ,订单编号CD")           '订单日期


            strSql.Append("  FROM   B订单管理 订单" & vbCrLf)
            'strSql.Append("       LEFT JOIN M产品种类 产品种类 " & vbCrLf)
            'strSql.Append("         ON 订单.产品种类名称 = 产品种类.产品种类名称 " & vbCrLf)
            strSql.Append("       LEFT JOIN T图纸管理  " & vbCrLf)
            strSql.Append("         ON T图纸管理.产品图号 = 订单.产品图号 " & vbCrLf)


            strSql.Append("       LEFT JOIN M人员管理 人员 " & vbCrLf)
            strSql.Append("         ON 订单.作成者编号 = 人员.人员编号 " & vbCrLf)


            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 订单.订单编号 =" & Utility.PFn_ChangeQuotation(cls订单表T.订单编号) & vbCrLf)
            'strSql.Append("ORDER BY 订单.订单编号cd" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region

#Region " LoadByPK "

    '检索全部数据
    Public Function LoadByPK订单编号(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT TOP 1 订单.订单编号 " & vbCrLf)
            strSql.Append(" ,订单.订单区分")           '出荷去向
            strSql.Append(" ,订单.厂内编号")           '出荷方法
            strSql.Append(" ,订单.客户编号")           '制造区分
            strSql.Append(" ,客户.客户名称 AS 客户名称")           '制造区分
            strSql.Append(" ,订单.订单接受日期")           '部品番号
            strSql.Append(" ,订单.审核状态")           '订单日期

            strSql.Append("  FROM   B订单管理 订单" & vbCrLf)
            strSql.Append("       LEFT JOIN m客户管理 客户 " & vbCrLf)
            strSql.Append("         ON 订单.客户编号 = 客户.客户编号 " & vbCrLf)

            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 订单.订单编号 =" & Utility.PFn_ChangeQuotation(cls订单表T.订单编号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function LoadByPK订单编号1(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT TOP 1 订单.订单编号 " & vbCrLf)
            strSql.Append(" ,订单.订单区分")           '出荷去向
            strSql.Append(" ,订单.厂内编号")           '出荷方法
            strSql.Append(" ,订单.客户编号")           '制造区分
            strSql.Append(" ,客户.客户名称 AS 客户名称")           '制造区分
            strSql.Append(" ,订单.订单接受日期")           '部品番号
            strSql.Append(" ,订单.审核状态")           '订单日期

            strSql.Append("  FROM   B订单管理 订单" & vbCrLf)
            strSql.Append("       LEFT JOIN m客户管理 客户 " & vbCrLf)
            strSql.Append("         ON 订单.客户编号 = 客户.客户编号 " & vbCrLf)

            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 订单.订单编号 in(" & Utility.PFn_ChangeQuotation(cls订单表T.订单编号) & ")" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function LoadByPK厂内编号(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT TOP 1 订单.订单编号 " & vbCrLf)
            strSql.Append(" ,订单.订单区分")           '出荷去向
            strSql.Append(" ,订单.厂内编号")           '出荷方法
            strSql.Append(" ,订单.客户编号")           '制造区分
            strSql.Append(" ,客户.客户名称 AS 客户名称")           '制造区分
            strSql.Append(" ,订单.订单接受日期")           '部品番号
            strSql.Append(" ,订单.审核状态")           '订单日期

            strSql.Append("  FROM   B订单管理 订单" & vbCrLf)
            strSql.Append("       LEFT JOIN m客户管理 客户 " & vbCrLf)
            strSql.Append("         ON 订单.客户编号 = 客户.客户编号 " & vbCrLf)

            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 订单.厂内编号 =" & Utility.PFn_ChangeQuotation(cls订单表T.厂内编号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT 订单.客户编号 " & vbCrLf)
            strSql.Append(" ,订单.审核状态")
            strSql.Append("  FROM   B订单管理 订单" & vbCrLf)
            strSql.Append("       LEFT JOIN m客户管理 客户 " & vbCrLf)
            strSql.Append("         ON 订单.客户编号 = 客户.客户编号 " & vbCrLf)

            strSql.Append("WHERE  订单.订单编号 = " & Utility.PFn_ChangeQuotation(cls订单表T.订单编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#End Region

#Region " LoadBy图号"

    Public Function LoadBodyAll(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT" & vbCrLf)
            strSql.Append("        订单.订单编号 ," & vbCrLf)
            strSql.Append("        订单区分.名称 AS 订单区分 ," & vbCrLf)
            strSql.Append("        订单.厂内编号 ," & vbCrLf)
            strSql.Append("        订单.客户编号 ," & vbCrLf)
            strSql.Append("        客户.客户名称 AS 客户名称 ," & vbCrLf)
            strSql.Append("        订单.订单接受日期 ," & vbCrLf)
            strSql.Append("        订单.审核状态 ," & vbCrLf)
            strSql.Append("        订单.订单状态 ," & vbCrLf)
            strSql.Append("        订单.审核人 ," & vbCrLf)
            strSql.Append("        订单.审核备注 ," & vbCrLf)
            strSql.Append("        订单.产品图号 ," & vbCrLf)
            strSql.Append("        T图纸管理.品名 AS 产品名称," & vbCrLf)
            strSql.Append("        订单.产品区分 ," & vbCrLf)
            strSql.Append("        订单.机型制造编号 ," & vbCrLf)
            strSql.Append("        订单.品种规格 ," & vbCrLf)
            strSql.Append("        订单.型号 ," & vbCrLf)
            strSql.Append("        订单.含税单价 ," & vbCrLf)
            strSql.Append("        订单.订单数量 ," & vbCrLf)
            strSql.Append("        订单.含税总金额 ," & vbCrLf)
            strSql.Append("        订单.未税单价 ," & vbCrLf)
            strSql.Append("        订单.未税总金额 ," & vbCrLf)
            'strSql.Append("        订单.投产数量 ," & vbCrLf)
            strSql.Append("        订单.币种 ," & vbCrLf)
            strSql.Append("        订单.交货方式 ," & vbCrLf)
            strSql.Append("        订单.发货日期 ," & vbCrLf)
            strSql.Append("        订单.到货日期 ," & vbCrLf)
            strSql.Append("        订单.目的港名 ," & vbCrLf)
            strSql.Append("        订单.产品发票号 ," & vbCrLf)
            strSql.Append("        订单.产品助记码 ," & vbCrLf)
            strSql.Append("        订单.作成者编号 ," & vbCrLf)
            strSql.Append("        人员.人员名 AS 作成者姓名 ," & vbCrLf)
            strSql.Append("        订单.备注 " & vbCrLf)
            strSql.Append("" & vbCrLf)
            strSql.Append("FROM    B订单管理 订单" & vbCrLf)
            strSql.Append("" & vbCrLf)
            strSql.Append("        LEFT JOIN M客户管理 客户 ON 订单.客户编号 = 客户.客户编号" & vbCrLf)
            strSql.Append("        LEFT JOIN M人员管理 人员 ON 订单.作成者编号 = 人员.人员编号" & vbCrLf)
            strSql.Append("        LEFT JOIN VM订单区分 订单区分 ON 订单.订单区分 = 订单区分.区分" & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = 订单.产品图号" & vbCrLf)
            strSql.Append("WHERE   1 = 1" & vbCrLf)

            strSql.Append("   AND 订单.订单编号 =" & Utility.PFn_ChangeQuotation(cls订单表T.订单编号) & vbCrLf)
            If Not String.IsNullOrEmpty(cls订单表T.产品图号) Then
                strSql.Append("   AND 订单.产品图号 =" & Utility.PFn_ChangeQuotation(cls订单表T.产品图号) & vbCrLf)
            End If

            'strSql.Append("ORDER BY 订单.订单编号CD" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " LoadBodyAllexp"

    Public Function LoadBodyAllexp(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT distinct 订单.订单编号 " & vbCrLf)
            strSql.Append(" ,订单区分.名称 订单区分 ")           '订单区分
            strSql.Append(" ,订单.厂内编号")           '厂内编号
            strSql.Append(" ,订单.客户编号")           '客户编号
            strSql.Append(" ,客户.客户名称 AS 客户名称")           '客户名称
            strSql.Append(" ,订单.订单接受日期")           '订单接受日期
            strSql.Append(" ,审核状态.名称 审核状态")           '审核状态
            strSql.Append(" ,订单状态.名称 订单状态")           '订单状态
            strSql.Append(" ,订单.审核人")           '审核人
            strSql.Append(" ,订单.产品图号")           '产品图号
            strSql.Append(" ,产品区分.名称 产品区分")         '产品区分
            strSql.Append(" ,订单.机型制造编号")           '含税单价
            strSql.Append(" ,订单.品种规格")           '含税单价
            strSql.Append(" ,订单.型号")           '含税单价
            strSql.Append(" ,订单.含税单价")           '含税单价
            strSql.Append(" ,订单.订单数量")         '订单数量
            strSql.Append(" ,订单.含税总金额")           '含税总金额
            strSql.Append(" ,订单.未税单价")           '未税单价
            strSql.Append(" ,订单.未税总金额")         '未税总金额
            strSql.Append(" ,币种.名称 币种")            '币种
            strSql.Append(" ,交货方式.名称 交货方式")           '交货方式
            strSql.Append(" ,订单.发货日期")           '发货日期
            strSql.Append(" ,订单.到货日期")         '到货日期
            'strSql.Append(" ,客户.客户名称 as 目的港名")           '目的港名
            strSql.Append(" ,订单.目的港名")           '目的港名
            strSql.Append(" ,订单.产品发票号")           '产品发票号
            strSql.Append(" ,订单.产品助记码")           '产品助记码
            strSql.Append(" ,订单.作成者编号")         '作成者编号
            strSql.Append(" ,人员.人员名 AS 作成者姓名")         '作成者姓名
            strSql.Append(" ,备注")            '备注
            strSql.Append("  FROM   B订单管理 订单" & vbCrLf)
            strSql.Append("       LEFT JOIN m客户管理 客户 " & vbCrLf)
            strSql.Append("         ON 订单.客户编号 = 客户.客户编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN M人员管理 人员 " & vbCrLf)
            strSql.Append("         ON 订单.作成者编号 = 人员.人员编号 " & vbCrLf)
            strSql.Append("         LEFT JOIN vm订单区分 订单区分 ON 订单.订单区分 = 订单区分.区分 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM审核状态 审核状态 ON 审核状态.区分 = 订单.审核状态  " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM订单状态 订单状态 ON 订单状态.区分=订单.订单状态 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM产品区分 产品区分 ON 产品区分.区分=订单.产品区分 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM币种 币种 ON 币种.区分=订单.币种 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM交货方式 交货方式 ON 交货方式.区分=订单.交货方式 " & vbCrLf)
            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 订单.订单编号 in ('" & cls订单表T.订单编号 & "')" & vbCrLf)
            If Not String.IsNullOrEmpty(cls订单表T.产品图号) Then
                strSql.Append("   AND 订单.产品图号 =" & Utility.PFn_ChangeQuotation(cls订单表T.产品图号) & vbCrLf)
            End If

            strSql.Append("ORDER BY 订单接受日期" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " LoadByWherejd "

    '检索全部数据
    Public Function LoadByWherejd(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT  订单编号 ,")
            strSql.Append("        VM订单状态.名称 订单状态 ,")
            strSql.Append("        M客户管理.客户名称,")
            strSql.Append("        产品图号 ,")
            strSql.Append("        VM产品区分.名称 产品区分 ,")
            strSql.Append("        订单数量 ,")
            'strSql.Append("        投产数量 ,")
            strSql.Append("        品种规格 ,")
            strSql.Append("        备注 ,")
            strSql.Append("        发货日期,")
            strSql.Append("        订单.客户编号" & vbCrLf)
            strSql.Append("FROM    dbo.B订单管理 订单" & vbCrLf)
            strSql.Append("left JOIN dbo.VM订单状态 ON 订单.订单状态=VM订单状态.区分" & vbCrLf)
            strSql.Append("LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = 订单.客户编号" & vbCrLf)
            strSql.Append("LEFT JOIN dbo.VM产品区分 ON 订单.产品区分=VM产品区分.区分" & vbCrLf)

            strSql.Append("WHERE  1 = 1 " & vbCrLf)

            If Not String.IsNullOrEmpty(cls订单表T.订单编号) Then
                strSql.Append("     AND 订单编号= " & Utility.PFn_ChangeQuotation(cls订单表T.订单编号))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.订单状态) Then
                strSql.Append("     AND VM订单状态.区分= " & Utility.PFn_ChangeQuotation(cls订单表T.订单状态))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.客户编号) Then
                strSql.Append("     AND 订单.客户编号= " & Utility.PFn_ChangeQuotation(cls订单表T.客户编号))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.产品图号) Then
                strSql.Append("     AND 产品图号= " & Utility.PFn_ChangeQuotation(cls订单表T.产品图号))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.订单区分) Then
                strSql.Append("     AND VM产品区分.区分= " & Utility.PFn_ChangeQuotation(cls订单表T.订单区分))
            End If
            If (cls订单表T.发货日期 <> "1900/1/1") Then
                strSql.Append(" AND 发货日期 >=" & Utility.PFn_ChangeQuotation(cls订单表T.发货日期) & vbCrLf)
            End If

            If (cls订单表T.发货日期2 <> "1900/1/1") Then
                strSql.Append(" AND 发货日期 <=" & Utility.PFn_ChangeQuotation(cls订单表T.发货日期2) & vbCrLf)
            End If

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            '第一层
            strSql.Append(" SELECT DISTINCT 'false' 选择 , 订单编号 , ")
            'strSql.Append("         订单区分 , ")
            strSql.Append("          vm订单区分.名称 AS 订单区分, " & vbCrLf)
            strSql.Append("          vm订单状态.名称 AS 订单状态, " & vbCrLf)

            'strSql.Append("         订单状态 , ")
            strSql.Append("         B.客户名称, ")
            strSql.Append("         厂内编号 , ")
            strSql.Append("         订单接受日期, ")
            strSql.Append("          vm审核状态.名称 AS 审核状态, " & vbCrLf)
            ' strSql.Append("        ISNULL(VM审核状态.名称,'未审核') 审核状态  , " & vbCrLf)
            strSql.Append("         审核人 , ")
            strSql.Append("         审核备注  ")
            strSql.Append(" FROM    dbo.B订单管理 A ")
            strSql.Append(" INNER JOIN dbo.M客户管理 B ")
            strSql.Append(" ON B.客户编号 = A.客户编号 ")
            strSql.Append("        LEFT JOIN dbo.VM审核状态 ON VM审核状态.区分 =  A.审核状态 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM订单区分 ON VM订单区分.区分 =  A.订单区分 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM订单状态 ON VM订单状态.区分 =  A.订单状态 " & vbCrLf)
            'strSql.Append(" INNER JOIN dbo.VM订单区分 C ON a.订单区分=c.区分 ")
            'strSql.Append("         LEFT JOIN vm订单区分 " & vbCrLf)
            'strSql.Append("           ON 订单表.订单区分 = vm订单区分.区分 " & vbCrLf)


            strSql.Append("WHERE  1 = 1 " & vbCrLf)

            '页面条件check
            If Not String.IsNullOrEmpty(cls订单表T.产品发票号) Then
                strSql.Append("     AND A.产品发票号 LIKE '" & Utility.PFn_ChangeQuotation(cls订单表T.产品发票号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls订单表T.订单区分) Then
                strSql.Append("     AND A.订单区分= " & Utility.PFn_ChangeQuotation(cls订单表T.订单区分))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.订单状态) Then
                strSql.Append("     AND A.订单状态= " & Utility.PFn_ChangeQuotation(cls订单表T.订单状态))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.订单编号) Then
                strSql.Append("     AND A.订单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls订单表T.订单编号, True) & "%'")
            End If
            'If Not String.IsNullOrEmpty(cls订单表T.产品种类名称) Then
            '    strSql.Append("     AND A.产品种类名称 LIKE '" & Utility.PFn_ChangeQuotation(cls订单表T.产品种类名称, True) & "%'")
            'End If
            If Not String.IsNullOrEmpty(cls订单表T.客户编号) Then
                strSql.Append("     AND A.客户编号= " & Utility.PFn_ChangeQuotation(cls订单表T.客户编号))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.产品图号) Then
                strSql.Append("     AND A.产品图号 LIKE '" & Utility.PFn_ChangeQuotation(cls订单表T.产品图号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls订单表T.产品区分) Then
                strSql.Append("     AND A.产品区分= " & Utility.PFn_ChangeQuotation(cls订单表T.产品区分))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.目的港名) Then
                strSql.Append("     AND A.目的港名 LIKE '" & Utility.PFn_ChangeQuotation(cls订单表T.目的港名, True) & "%'")
            End If
            If (cls订单表T.发货日期 <> "1900/1/1") Then
                strSql.Append(" AND A.发货日期 >=" & Utility.PFn_ChangeQuotation(cls订单表T.发货日期) & vbCrLf)
            End If

            If (cls订单表T.发货日期2 <> "1900/1/1") Then
                strSql.Append(" AND A.发货日期 <=" & Utility.PFn_ChangeQuotation(cls订单表T.发货日期2) & vbCrLf)
            End If
            If (cls订单表T.到货日期 <> "1900/1/1") Then
                strSql.Append(" AND A.到货日期 >=" & Utility.PFn_ChangeQuotation(cls订单表T.到货日期) & vbCrLf)
            End If

            If (cls订单表T.到货日期2 <> "1900/1/1") Then
                strSql.Append(" AND A.到货日期 <=" & Utility.PFn_ChangeQuotation(cls订单表T.到货日期2) & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(cls订单表T.审核状态) Then
                strSql.Append("     AND A.审核状态 = '" & Utility.PFn_ChangeQuotation(cls订单表T.审核状态, True) & "'")
            End If
            strSql.Append(" ORDER BY 订单接受日期 desc ")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByWhere1 "

    '检索全部数据
    Public Function LoadByWhere1(ByVal cls订单表T As B订单表T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            '第二层
            'strSql.Append(" SELECT  订单编号 , ")
            'strSql.Append("         订单区分 , ")
            'strSql.Append("         B.客户名称, ")
            'strSql.Append("         厂内编号 , ")
            'strSql.Append("         订单接受日期 ")
            strSql.Append(" SELECT  distinct 订单编号 , ")
            strSql.Append("         A.产品图号 , ")
            strSql.Append("          vm产品区分.名称 AS 产品区分, " & vbCrLf)
            'strSql.Append("         产品种类名称 , ")
            strSql.Append("         机型制造编号 , ")
            strSql.Append("         品种规格 , ")
            strSql.Append("         A.型号 , ")
            strSql.Append("         发货日期 , ")
            strSql.Append("         到货日期 , ")
            strSql.Append("         订单数量 , ")
            'strSql.Append("         投产数量 , ")
            strSql.Append("         目的港名 , ")
            strSql.Append("         产品发票号 , ")
            strSql.Append("         A.产品助记码 , ")
            strSql.Append("          vm交货方式.名称 AS 交货方式, " & vbCrLf)
            ' strSql.Append("         交货方式 , ")
            strSql.Append("          vm币种.名称 AS 币种, " & vbCrLf)
            ' strSql.Append("         币种 , ")
            'strSql.Append("         E.名称 AS 审核状态 , ")

            strSql.Append("         A.备注 , ")
            strSql.Append("         b.人员名 作成者, ")
            strSql.Append("         D.图纸, ")
            strSql.Append("          vm审核状态.名称 AS 审核状态 " & vbCrLf)
            strSql.Append(" FROM    dbo.B订单管理 A ")
            strSql.Append("         INNER JOIN dbo.M人员管理 b ON A.作成者编号 = b.人员编号 ")
            strSql.Append("         LEFT JOIN dbo.T图纸管理 D ON D.产品图号 = A.产品图号 ")
            strSql.Append("         LEFT JOIN dbo.VM产品区分 ON VM产品区分.区分 =  A.产品区分 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM交货方式 ON VM交货方式.区分 =  A.交货方式 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM币种 ON VM币种.区分 =  A.币种 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM审核状态 ON VM审核状态.区分 =  A.审核状态 " & vbCrLf)

            'strSql.Append("         INNER JOIN dbo.VM交货方式 C ON a.交货方式=c.区分 ")
            ' strSql.Append("         INNER JOIN dbo.VM审核状态 E ON a.审核状态=E.区分 ")
            'strSql.Append(" FROM    dbo.B订单管理 A ")
            'strSql.Append(" INNER JOIN dbo.M客户管理 B ")
            'strSql.Append(" ON B.客户编号 = A.客户编号 ")



            strSql.Append("WHERE  1 = 1 " & vbCrLf)

            '页面条件check
            If Not String.IsNullOrEmpty(cls订单表T.产品发票号) Then
                strSql.Append("     AND A.产品发票号 LIKE '" & Utility.PFn_ChangeQuotation(cls订单表T.产品发票号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls订单表T.订单区分) Then
                strSql.Append("     AND A.订单区分= " & Utility.PFn_ChangeQuotation(cls订单表T.订单区分))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.订单状态) Then
                strSql.Append("     AND A.订单状态= " & Utility.PFn_ChangeQuotation(cls订单表T.订单状态))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.订单编号) Then
                strSql.Append("     AND A.订单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls订单表T.订单编号, True) & "%'")
            End If
            'If Not String.IsNullOrEmpty(cls订单表T.产品种类名称) Then
            '    strSql.Append("     AND A.产品种类名称 LIKE '" & Utility.PFn_ChangeQuotation(cls订单表T.产品种类名称, True) & "%'")
            'End If
            If Not String.IsNullOrEmpty(cls订单表T.客户编号) Then
                strSql.Append("     AND A.客户编号= " & Utility.PFn_ChangeQuotation(cls订单表T.客户编号))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.产品图号) Then
                strSql.Append("     AND A.产品图号 LIKE '" & Utility.PFn_ChangeQuotation(cls订单表T.产品图号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls订单表T.产品区分) Then
                strSql.Append("     AND A.产品区分= " & Utility.PFn_ChangeQuotation(cls订单表T.产品区分))
            End If
            If Not String.IsNullOrEmpty(cls订单表T.目的港名) Then
                strSql.Append("     AND A.目的港名 LIKE '" & Utility.PFn_ChangeQuotation(cls订单表T.目的港名, True) & "%'")
            End If
            'If (cls订单表T.发货日期 <> "1900/1/1") Then
            '    strSql.Append(" AND A.发货日期 >=" & Utility.PFn_ChangeQuotation(cls订单表T.发货日期) & vbCrLf)
            'End If

            'If (cls订单表T.发货日期2 <> "1900/1/1") Then
            '    strSql.Append(" AND A.发货日期 <=" & Utility.PFn_ChangeQuotation(cls订单表T.发货日期2.AddDays(1)) & vbCrLf)
            'End If
            'If (cls订单表T.到货日期 <> "1900/1/1") Then
            '    strSql.Append(" AND A.到货日期 >=" & Utility.PFn_ChangeQuotation(cls订单表T.到货日期) & vbCrLf)
            'End If

            'If (cls订单表T.到货日期2 <> "1900/1/1") Then
            '    strSql.Append(" AND A.到货日期<=" & Utility.PFn_ChangeQuotation(cls订单表T.到货日期2.AddDays(1)) & vbCrLf)
            'End If
            If Not String.IsNullOrEmpty(cls订单表T.审核状态) Then
                strSql.Append("     AND A.审核状态 = '" & Utility.PFn_ChangeQuotation(cls订单表T.审核状态, True) & "'")
            End If

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
