Imports System.Text

#Region "Dal采购表"
'------------------------------------------------------------------------------------
'   说明
'       采购表的数据库操作SQL文
'   创建人
'       大连思铭科技 解辉品
'   创建时间
'       2016/5/25
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalM采购表T

#Region "IsExists"

    Public Function IsExists采购单编号(ByVal str采购单编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   B原材料采购管理 " & vbCrLf)
            strSql.Append("WHERE  采购单编号 = " & Utility.PFn_ChangeQuotation(str采购单编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B原材料采购管理")          '采购表

            strSql.Append(" (采购单编号")           '采购编号
            strSql.Append(" ,人员编号")           '出荷去向
            strSql.Append(" ,供应商编号")           '出荷方法
            strSql.Append(" ,税率")           '制造区分
            strSql.Append(" ,申请日期")           '部品番号
            strSql.Append(" ,材料编号")           '部品区分
            strSql.Append(" ,材料名称")           '出荷数量
            strSql.Append(" ,材料区分")         '区分
            strSql.Append(" ,材质")         '区分
            strSql.Append(" ,类别")         '区分
            strSql.Append(" ,材料批号")         '区分
            strSql.Append(" ,长")            '试做品
            strSql.Append(" ,宽")           'イベント
            strSql.Append(" ,高")           'CENO
            strSql.Append(" ,订单编号")           '佳能要求
            strSql.Append(" ,计划采购数量")           '订单日期
            strSql.Append(" ,实际采购数量")           '订单日期
            strSql.Append(" ,计划采购重量")           '订单日期
            strSql.Append(" ,实际采购重量")           '订单日期

            strSql.Append(" ,含税单价")           '工程图番
            strSql.Append(" ,订单数量")         '机种
            strSql.Append(" ,含税总金额")           '包装方法
            strSql.Append(" ,未税单价")           '出荷日期
            strSql.Append(" ,未税总金额")         '备注
            strSql.Append(" ,币种")            '作成者
            strSql.Append(" ,供货方式")           '订单日期
            strSql.Append(" ,供货日期")           '出荷日期
          
            strSql.Append(" ,登录者")            '作成者
            strSql.Append(" ,登录日期")           '订单日期

            strSql.Append(" ,备注")            '作成者
            strSql.Append(" ,审核状态")           '订单日期
            strSql.Append(" ,审核人")           '订单日期
            strSql.Append(" ,采购单编号CD")           '订单日期
            strSql.Append(" ,产品图号")         '区分
            strSql.Append(" ,客户编号")            '作成者

            strSql.Append(" ,单价修改状态")           '订单日期
          
            strSql.Append(")")

            strSql.Append(" VALUES ")

            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.采购单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.作成者编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.供应商编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.税率))

            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.申请日期))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.原材料编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.原材料名称))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.材料区分))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.材质))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.类别))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.材料批号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.长))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.宽))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.高))
            If cls采购表T.订单编号 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.订单编号))
            End If
            If cls采购表T.计划采购数量 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.计划采购数量))
            End If
            If cls采购表T.实际采购数量 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.实际采购数量))
            End If
            If cls采购表T.计划采购重量 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.计划采购重量))
            End If
            If cls采购表T.实际采购重量 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.实际采购重量))
            End If
            If cls采购表T.含税单价 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.含税单价))
            End If
            If cls采购表T.订单数量 = 0 Then
                strSql.Append(" NULL, ")
            Else
                strSql.Append(cls采购表T.订单数量)
            End If
            If cls采购表T.含税总金额 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" ,{0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.含税总金额))
            End If
            If cls采购表T.未税单价 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.未税单价))
            End If
            If cls采购表T.未税总金额 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.未税总金额))
            End If
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.币种))
            If cls采购表T.供货方式 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.供货方式))
            End If
            If cls采购表T.供货日期 = "1900/1/1" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.供货日期))
            End If

            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.登录者))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.登录日期))
            If cls采购表T.备注 = "" Then
                strSql.Append("NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.备注))
            End If
            If cls采购表T.审核状态 = "" Or cls采购表T.审核状态 = "0" Then
                strSql.Append(" 0, ")
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.审核状态))
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.登录者))
            End If
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.采购单编号CD))
            If cls采购表T.产品图号 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.产品图号))
            End If
            If cls采购表T.客户编号 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.客户编号))
            End If
            If cls采购表T.单价修改状态 = "" Or cls采购表T.单价修改状态 = "0" Then
                strSql.Append(" 0 ")
            Else
                strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.单价修改状态))

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

    ''数据更新操作
    'Public Function Update(ByVal cls采购表T As B原材料采购管理T) As String

    '    Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

    '    Try

    '        strSql.Append(" UPDATE B订单管理 ") '采购表
    '        strSql.Append(" SET ")

    '        strSql.AppendFormat(" 订单区分=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.订单区分))
    '        strSql.AppendFormat(" ,客户编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.客户编号))

    '        'If cls采购表T.出荷日期 = "1900/01/01 0:00:00" Then
    '        '    strSql.Append(" ,出荷日期 = NULL ")
    '        'Else
    '        '    strSql.Append(" ,出荷日期 = '" & cls采购表T.出荷日期 & "'")
    '        'End If
    '        strSql.AppendFormat(",订单接受日期=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.订单接受日期))


    '        strSql.AppendFormat(" ,产品图号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.产品图号))
    '        strSql.AppendFormat(" ,产品名称=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.产品名称))
    '        strSql.AppendFormat(" ,产品区分=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.产品区分))
    '        strSql.AppendFormat(" ,长=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.长))
    '        strSql.AppendFormat(" ,宽=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.宽))
    '        strSql.AppendFormat(" ,高=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.高))
    '        strSql.AppendFormat(" ,产品种类编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.产品种类编号))
    '        strSql.AppendFormat(" ,含税单价=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.含税单价))
    '        strSql.Append(" ,订单数量=" & cls采购表T.订单数量)
    '        strSql.AppendFormat("  ,含税总金额=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.含税总金额))
    '        strSql.AppendFormat("  ,未税单价=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.未税单价))
    '        strSql.AppendFormat("  ,未税总金额=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.未税总金额))
    '        strSql.AppendFormat("  ,币种=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.币种))
    '        strSql.AppendFormat(" ,交货方式=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.交货方式))
    '        strSql.AppendFormat(" ,发货日期=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.发货日期))
    '        strSql.AppendFormat("  ,到货日期=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.到货日期))
    '        If cls采购表T.目的港名 = "" Then
    '            strSql.Append("  ,目的港名=NULL ")
    '        Else
    '            strSql.AppendFormat(" ,目的港名=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.目的港名))
    '        End If

    '        If cls采购表T.产品发票号 = "" Then
    '            strSql.Append("  ,产品发票号=NULL ")
    '        Else
    '            strSql.AppendFormat("  ,产品发票号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.产品发票号))

    '        End If
    '        If cls采购表T.产品助记码 = "" Then
    '            strSql.Append(" ,产品助记码=NULL ")
    '        Else
    '            strSql.AppendFormat(" ,产品助记码=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.产品助记码))
    '        End If
    '        strSql.AppendFormat(" ,作成者编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.作成者编号))
    '        strSql.AppendFormat(" ,更新者=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.更新者))
    '        strSql.AppendFormat(" ,更新日期=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.更新日期))
    '        If cls采购表T.备注 = "" Then
    '            strSql.Append(" ,备注 =NULL ")
    '        Else
    '            strSql.AppendFormat(" ,备注 =" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.备注))
    '        End If
    '        If cls采购表T.审核状态 = "" Then
    '            strSql.Append(" ,审核状态 = NULL ")
    '            strSql.Append(" ,审核人 = NULL ")
    '        Else
    '            strSql.AppendFormat(" ,审核状态 = " & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.审核状态))
    '            strSql.AppendFormat(" ,审核人= " & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.更新者))

    '        End If
    '        If cls采购表T.订单状态 = "" Then
    '            strSql.Append(" ,订单状态 = NULL ")
    '        Else
    '            strSql.AppendFormat(" ,订单状态 = " & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.订单状态))

    '        End If
    '        strSql.Append(" WHERE ")
    '        strSql.Append(" 订单编号CD = '" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号CD) & "'") '订单编号

    '        Return strSql.ToString

    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '        Return String.Empty
    '    End Try

    'End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM B原材料采购管理 ") '采购表)

            strSql.Append(" WHERE ")
            strSql.Append(" 采购单编号 = " & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号)) '订单编号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "Get采购单编号CD"

    Public Function Get采购单编号CD(ByVal model As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("         + 1 AS 顺序号 " & vbCrLf)
            strSql.Append("FROM   B原材料采购管理 " & vbCrLf)
            strSql.Append(" WHERE    1 = 1 " & vbCrLf)

            If model.采购单编号 <> String.Empty Then
                strSql.Append(" AND 采购单编号 =" & Utility.PFn_ChangeQuotation(model.采购单编号) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try
    End Function
#End Region

#Region "LoadHead"

    Public Function LoadHead(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT TOP 1 采购单.采购单编号 " & vbCrLf)
     
            strSql.Append(" ,采购单.人员编号")           '制造区分
            strSql.Append(" ,人员.人员名 AS 人员名称")           '制造区分
            strSql.Append(" ,采购单.供应商编号")           '制造区分
            strSql.Append(" ,供应商.供应商名称 AS 供应商名称")           '制造区分
            strSql.Append(" ,供应商.税率 AS 税率")           '制造区分
            strSql.Append(" ,采购单.申请日期")           '部品番号
            strSql.Append(" ,采购单.审核状态")           '采购日期
            strSql.Append(" ,采购单.审核人")           '采购日期
            strSql.Append("  FROM   B原材料采购管理 采购单" & vbCrLf)
            strSql.Append("       LEFT JOIN m人员管理 人员 " & vbCrLf)
            strSql.Append("         ON 采购单.人员编号 = 人员.人员编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m供应商管理 供应商 " & vbCrLf)
            strSql.Append("         ON 采购单.供应商编号 = 供应商.供应商编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m供应商管理 供应商税率 " & vbCrLf)
            strSql.Append("         ON 采购单.供应商编号 = 供应商税率.供应商编号 " & vbCrLf)

            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 采购单.采购单编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "LoadBody"

    Public Function LoadBody(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  " & vbCrLf)

            strSql.Append(" 采购.材料编号")           '部品区分
            strSql.Append(" ,采购.材料名称")           '出荷数量
            strSql.Append(" ,采购.材料区分")         '区分
            strSql.Append(" ,采购.材料批号")         '区分
            strSql.Append(" ,采购.材质 AS [材质/型号]")         '区分
            strSql.Append(" ,采购.类别")         '区分
            strSql.Append(" ,采购.长")            '试做品
            strSql.Append(" ,采购.宽 AS [宽（直径）]")           'イベント
            strSql.Append(" ,采购.高 AS [高（厚度）]")           'CENO
            strSql.Append(" ,采购.订单编号")         '区分
            strSql.Append(" ,采购.产品图号")         '区分
            strSql.Append(" ,图纸.品名 AS 产品名称")         '区分
            strSql.Append(" ,采购.订单数量")         '机种

            strSql.Append(" ,0 as [在库数量（个）]")
            'strSql.Append(" ,原材料库存管理.在库数量 as  [在库数量（个）]")           '佳能要求
            strSql.Append(" ,采购.计划采购数量 AS [计划采购数量（个）]")         '机种
            strSql.Append(" ,采购.实际采购数量 AS [实际采购数量（个）]")         '机种

            strSql.Append(" ,0 as [在库重量（kg）]")
            'strSql.Append(" ,原材料库存管理.在库重量 as [在库重量（kg）]")           '佳能要求
            strSql.Append(" ,采购.计划采购重量 AS [计划采购重量（kg）]")         '机种
            strSql.Append(" ,采购.实际采购重量 AS [实际采购重量（kg）]")         '机种

            strSql.Append(" ,采购.含税单价")           '工程图番
            strSql.Append(" ,采购.含税总金额")           '包装方法
            strSql.Append(" ,采购.未税单价")           '出荷日期
            strSql.Append(" ,采购.未税总金额")         '备注
            strSql.Append(" ,采购.币种")            '作成者

            strSql.Append(" ,采购.供货日期")           '出荷日期
            strSql.Append(" ,采购.供货方式")           '采购日期

            strSql.Append(" ,采购.备注")            '作成者
            strSql.Append(" ,采购.采购单编号CD")           '佳能要求
            strSql.Append(" ,采购.单价修改状态")            '作成者
            strSql.Append(" ,采购.客户编号")            '作成者
            strSql.Append("  FROM   B原材料采购管理 采购" & vbCrLf)
            strSql.Append("       LEFT JOIN T图纸管理 图纸 " & vbCrLf)
            strSql.Append("         ON 采购.产品图号 = 图纸.图纸编号 " & vbCrLf)

            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 采购.采购单编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号) & vbCrLf)
            strSql.Append("ORDER BY 采购.采购单编号cd" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK "

    '检索全部数据
    Public Function LoadByPK采购单编号(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT TOP 1 采购单.采购单编号 " & vbCrLf)

            strSql.Append(" ,采购单.人员编号")           '制造区分
            strSql.Append(" ,人员.人员名 AS 人员名称")           '制造区分
            strSql.Append(" ,采购单.供应商编号")           '制造区分
            strSql.Append(" ,供应商.供应商名称 AS 供应商名称")           '制造区分
            strSql.Append(" ,供应商.税率 AS 税率")           '制造区分
            strSql.Append(" ,采购单.申请日期")           '部品番号
            strSql.Append(" ,采购单.审核状态")           '采购日期
            strSql.Append(" ,采购单.审核人")           '采购日期
            strSql.Append("  FROM   B原材料采购管理 采购单" & vbCrLf)
            strSql.Append("       LEFT JOIN m人员管理 人员 " & vbCrLf)
            strSql.Append("         ON 采购单.人员编号 = 人员.人员编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m供应商管理 供应商 " & vbCrLf)
            strSql.Append("         ON 采购单.供应商编号 = 供应商.供应商编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m供应商管理 供应商税率 " & vbCrLf)
            strSql.Append("         ON 采购单.供应商编号 = 供应商税率.供应商编号 " & vbCrLf)

            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 采购单.采购单编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
 
#End Region

#Region "LoadBand0"

    Public Function LoadBand0(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT TOP 1  0 as 选择 " & vbCrLf)
            strSql.Append(" ,采购单.采购单编号")           '制造区分
            strSql.Append(" ,采购单.人员编号")           '制造区分
            strSql.Append(" ,人员.人员名 AS 人员名称")           '制造区分
            strSql.Append(" ,采购单.供应商编号")           '制造区分
            strSql.Append(" ,供应商.供应商名称 AS 供应商名称")           '制造区分
            strSql.Append(" ,供应商.税率 AS [税率(%)]")           '制造区分
            strSql.Append(" ,采购单.申请日期")           '部品番号
            strSql.Append(" ,CASE 采购单.审核状态 WHEN '1' THEN  '已审核'  else '未审核' end  AS 审核状态 " & vbCrLf)
            strSql.Append(" ,采购单.审核人")           '采购日期
            strSql.Append("  FROM   B原材料采购管理 采购单" & vbCrLf)
            strSql.Append("       LEFT JOIN m人员管理 人员 " & vbCrLf)
            strSql.Append("         ON 采购单.人员编号 = 人员.人员编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m供应商管理 供应商 " & vbCrLf)
            strSql.Append("         ON 采购单.供应商编号 = 供应商.供应商编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m供应商管理 供应商税率 " & vbCrLf)
            strSql.Append("         ON 采购单.供应商编号 = 供应商税率.供应商编号 " & vbCrLf)

            strSql.Append("WHERE  1=1 " & vbCrLf)
            If Not String.IsNullOrWhiteSpace(cls采购表T.采购单编号) Then
                strSql.Append("     AND 采购单.采购单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号, True) & "%'")
            End If
            If Not String.IsNullOrWhiteSpace(cls采购表T.原材料编号) Then
                strSql.Append("     AND 采购单.原材料编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.原材料编号, True) & "%'")
            End If
            If Not String.IsNullOrWhiteSpace(cls采购表T.客户编号) Then
                strSql.Append("     AND 采购单.客户编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.客户编号, True) & "%'")
            End If
            If Not String.IsNullOrWhiteSpace(cls采购表T.供应商编号) Then
                strSql.Append("     AND 采购单.供应商编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.供应商编号, True) & "%'")
            End If
            If Not String.IsNullOrWhiteSpace(cls采购表T.订单编号) Then
                strSql.Append("     AND 采购单.订单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号, True) & "%'")
            End If
            If Not String.IsNullOrWhiteSpace(cls采购表T.材料区分) Then
                strSql.Append("     AND 采购表.材料区分= " & Utility.PFn_ChangeQuotation(cls采购表T.材料区分))
            End If
            If (cls采购表T.供货日期 <> "1900/1/1") Then
                strSql.Append(" AND 采购表.供货日期 >=" & Utility.PFn_ChangeQuotation(cls采购表T.供货日期) & vbCrLf)
            End If
            If (cls采购表T.供货日期2 <> "1900/1/1") Then
                strSql.Append(" AND 采购表.供货日期 <" & Utility.PFn_ChangeQuotation(cls采购表T.供货日期2.AddDays(1)) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "LoadBand1"

    Public Function LoadBand1(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  " & vbCrLf)
            strSql.Append(" 采购.采购单编号")           '部品区分
            strSql.Append(" ,采购.材料编号")           '部品区分
            strSql.Append(" ,采购.材料名称")           '出荷数量
            strSql.Append(" ,采购.材料区分")         '区分
            strSql.Append(" ,采购.材料批号")         '区分
            strSql.Append(" ,采购.材质 AS [材质/型号]")         '区分
            strSql.Append(" ,采购.类别")         '区分
            strSql.Append(" ,采购.长")            '试做品
            strSql.Append(" ,采购.宽 AS [宽（直径）]")           'イベント
            strSql.Append(" ,采购.高 AS [高（厚度）]")           'CENO
            strSql.Append(" ,采购.订单编号")         '区分
            strSql.Append(" ,采购.产品图号")         '区分
            strSql.Append(" ,图纸.品名 AS 产品名称")         '区分
            strSql.Append(" ,采购.订单数量")         '机种

            strSql.Append(" ,0 as [在库数量（个）]")
            'strSql.Append(" ,原材料库存管理.在库数量 as  [在库数量（个）]")           '佳能要求
            strSql.Append(" ,采购.计划采购数量 AS [计划采购数量（个）]")         '机种
            strSql.Append(" ,采购.实际采购数量 AS [实际采购数量（个）]")         '机种

            strSql.Append(" ,0 as [在库重量（kg）]")
            'strSql.Append(" ,原材料库存管理.在库重量 as [在库重量（kg）]")           '佳能要求
            strSql.Append(" ,采购.计划采购重量 AS [计划采购重量（kg）]")         '机种
            strSql.Append(" ,采购.实际采购重量 AS [实际采购重量（kg）]")         '机种

            strSql.Append(" ,采购.含税单价")           '工程图番
            strSql.Append(" ,采购.含税总金额")           '包装方法
            strSql.Append(" ,采购.未税单价")           '出荷日期
            strSql.Append(" ,采购.未税总金额")         '备注
            strSql.Append(" ,采购.币种")            '作成者

            strSql.Append(" ,采购.供货日期")           '出荷日期
            strSql.Append(" ,采购.供货方式")           '采购日期

            strSql.Append(" ,采购.备注")            '作成者
            strSql.Append(" ,采购.采购单编号CD")           '佳能要求
            strSql.Append(" ,采购.单价修改状态")            '作成者
            strSql.Append(" ,采购.客户编号")            '作成者
            strSql.Append("  FROM   B原材料采购管理 采购" & vbCrLf)
            strSql.Append("       LEFT JOIN T图纸管理 图纸 " & vbCrLf)
            strSql.Append("         ON 采购.产品图号 = 图纸.图纸编号 " & vbCrLf)

            strSql.Append("WHERE  1=1 " & vbCrLf)
            If Not String.IsNullOrWhiteSpace(cls采购表T.采购单编号) Then
                strSql.Append("     AND 采购单.采购单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号, True) & "%'")
            End If
            If Not String.IsNullOrWhiteSpace(cls采购表T.原材料编号) Then
                strSql.Append("     AND 采购单.原材料编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.原材料编号, True) & "%'")
            End If
            If Not String.IsNullOrWhiteSpace(cls采购表T.客户编号) Then
                strSql.Append("     AND 采购单.客户编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.客户编号, True) & "%'")
            End If
            If Not String.IsNullOrWhiteSpace(cls采购表T.供应商编号) Then
                strSql.Append("     AND 采购单.供应商编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.供应商编号, True) & "%'")
            End If
            If Not String.IsNullOrWhiteSpace(cls采购表T.订单编号) Then
                strSql.Append("     AND 采购单.订单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号, True) & "%'")
            End If
            If Not String.IsNullOrWhiteSpace(cls采购表T.材料区分) Then
                strSql.Append("     AND 采购表.材料区分= " & Utility.PFn_ChangeQuotation(cls采购表T.材料区分))
            End If
            If (cls采购表T.供货日期 <> "1900/1/1") Then
                strSql.Append(" AND 采购表.供货日期 >=" & Utility.PFn_ChangeQuotation(cls采购表T.供货日期) & vbCrLf)
            End If
            If (cls采购表T.供货日期2 <> "1900/1/1") Then
                strSql.Append(" AND 采购表.供货日期 <" & Utility.PFn_ChangeQuotation(cls采购表T.供货日期2.AddDays(1)) & vbCrLf)
            End If
            strSql.Append("ORDER BY 采购.采购单编号cd" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
