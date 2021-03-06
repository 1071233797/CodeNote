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

Public Class DalM原材料采购表T

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
            strSql.Append(" ,作成者编号")           '出荷去向
            strSql.Append(" ,供应商编号")           '供应商编号
            strSql.Append(" ,申请日期")           '申请日期
            strSql.Append(" ,订单编号")           '订单编号
            strSql.Append(" ,主图号")           '出荷数量
            strSql.Append(" ,上级图号")           '出荷数量
            strSql.Append(" ,分图号")         '区分
            strSql.Append(" ,材料编号")         '材质
            strSql.Append(" ,长")            '试做品
            strSql.Append(" ,宽")           'イベント
            strSql.Append(" ,高")           '高
            strSql.Append(" ,重量")           '重量
            strSql.Append(" ,长度方向加工数量")            '试做品
            strSql.Append(" ,宽度方向加工数量")           'イベント
            strSql.Append(" ,[数量/张]")           '高
            strSql.Append(" ,单品耗材数量")           '佳能要求
            strSql.Append(" ,计划采购数量")           '订单日期
            strSql.Append(" ,实际采购数量")           '订单日期
            strSql.Append(" ,计划采购重量")           '订单日期
            strSql.Append(" ,实际采购重量")           '订单日期
            strSql.Append(" ,币种")         '机种
            strSql.Append(" ,含税单价")           '工程图番
            strSql.Append(" ,含税总金额")           '包装方法
            strSql.Append(" ,未税单价")           '出荷日期
            strSql.Append(" ,未税总金额")         '备注
            strSql.Append(" ,供货方式")           '订单日期
            strSql.Append(" ,供货日期")           '出荷日期
            strSql.Append(" ,备注")            '作成者

            'lxq 2017-04-21 update
            'strSql.Append(" ,审核人编号")           '订单日期
            'strSql.Append(" ,审核状态")           '订单日期
            'strSql.Append(" ,审核备注")           '订单日期
            'lxq 2017-04-21 end

            strSql.Append(" ,采购状态")           '订单日期
            strSql.Append(")")

            strSql.Append(" VALUES ")

            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.采购单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.作成者编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.供应商编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.申请日期))

            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.订单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.主图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.上级图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.分图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.原材料编号))
            If cls采购表T.长 = "" Then
                strSql.Append("NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.长))
            End If
            If cls采购表T.宽 = "" Then
                strSql.Append("NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.宽))
            End If
            If cls采购表T.高 = "" Then
                strSql.Append("NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.高))
            End If
            If cls采购表T.重量 = "" Then
                strSql.Append("NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.重量))
            End If
            If cls采购表T.长度方向加工数量 = "" Then
                strSql.Append("NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.长度方向加工数量))
            End If
            If cls采购表T.宽度方向加工数量 = "" Then
                strSql.Append("NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.宽度方向加工数量))
            End If
            If cls采购表T.数量1 = "" Then
                strSql.Append("NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.数量1))
            End If
            If cls采购表T.单品耗材数量 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.单品耗材数量))
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
            If cls采购表T.币种 = "" Then
                strSql.Append(" null, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.币种))
            End If
            If cls采购表T.含税单价 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.含税单价))
            End If

            If cls采购表T.含税总金额 = "" Then
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.含税总金额))
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
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.币种))
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

            If cls采购表T.备注 = "" Then
                strSql.Append("NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.备注))
            End If
            'lxq 2017-04-21 update 
            'If cls采购表T.审核状态 = "" Then
            '    strSql.Append(" NULL, ")
            '    strSql.Append(" NULL, ")
            '    strSql.Append(" NULL, ")
            'Else
            '    strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.审核人编号))
            '    strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.审核状态))
            '    strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.审核备注))
            'End If
            ' lxq 2017-04-21 end
            If cls采购表T.采购状态 = "" Then
                strSql.Append("NULL")
            Else
                strSql.AppendFormat("{0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.采购状态))
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
    'Public Function Update(ByVal cls采购表T As B原材料采购管理T) As String

    '    Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

    '    Try

    '        strSql.Append(" UPDATE B原材料采购管理 ") '采购表
    '        strSql.Append(" SET ")

    '        strSql.AppendFormat(" 人员编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.供应商编号))
    '        strSql.AppendFormat(" ,供应商编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.客户编号))

    '        If cls采购表T.申请日期 = "1900/01/01 0:00:00" Then
    '            strSql.Append(" ,申请日期 = NULL ")
    '        Else
    '            strSql.Append(" ,申请日期 = '" & cls采购表T.申请日期 & "'")
    '        End If
    '        strSql.AppendFormat(" ,材料编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.原材料编号))
    '        strSql.AppendFormat(" ,材料名称=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.原材料名称))
    '        strSql.AppendFormat(" ,材料区分=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.材料区分))
    '        strSql.AppendFormat(" ,材质=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.材质))
    '        strSql.AppendFormat(" ,类别=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.类别))
    '        strSql.AppendFormat(" ,长=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.长))
    '        strSql.AppendFormat(" ,宽=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.宽))
    '        strSql.AppendFormat(" ,高=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.高))
    '        strSql.AppendFormat(" ,订单编号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.订单编号))
    '        strSql.AppendFormat(" ,产品图号=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.产品图号))
    '        strSql.AppendFormat(" ,计划采购数量=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.计划采购数量))
    '        strSql.AppendFormat(" ,实际采购数量=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.实际采购数量))
    '        strSql.AppendFormat(" ,计划采购重量=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.计划采购重量))
    '        strSql.AppendFormat(" ,实际采购重量=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.实际采购重量))
    '        strSql.AppendFormat(" ,含税单价=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.含税单价))
    '        strSql.AppendFormat(" ,含税总金额=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.含税总金额))
    '        strSql.AppendFormat(" ,未税单价=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.未税单价))
    '        strSql.AppendFormat(" ,未税总金额=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.未税总金额))
    '        If cls采购表T.币种 = "" Then
    '            strSql.Append(",币种 =Null")
    '        Else
    '            strSql.AppendFormat(" ,币种=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.币种))
    '        End If
    '        If cls采购表T.供货日期 = "1900/01/01 0:00:00" Then
    '            strSql.Append(" ,供货日期 = NULL ")
    '        Else
    '            strSql.AppendFormat(" ,供货日期='" & cls采购表T.供货日期 & "'")
    '        End If
    '        If cls采购表T.供货方式 = "" Then
    '            strSql.Append(",供货方式 = NULL")
    '        Else
    '            strSql.AppendFormat(" ,供货方式=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.供货方式))

    '        End If
    '        If cls采购表T.备注 = "" Then
    '            strSql.Append(" ,备注 =NULL ")
    '        Else
    '            strSql.AppendFormat(" ,备注 =" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.备注))
    '        End If

    '        strSql.AppendFormat(" ,更新者=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.更新者))
    '        strSql.AppendFormat(" ,更新日期=" & vbCrLf, Utility.PFn_ChangeQuotation(cls采购表T.更新日期))
    '        strSql.Append(" WHERE ")
    '        strSql.Append(" 采购单编号CD = '" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号CD) & "'") '订单编号

    '        Return strSql.ToString

    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '        Return String.Empty
    '    End Try

    'End Function

#End Region
#Region " Update审核 "

    '数据更新操作
    Public Function Update审核(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B原材料采购管理 ") '采购表
            strSql.Append(" SET ")
            strSql.Append(" 审核状态=" & Utility.PFn_ChangeQuotation(cls采购表T.审核状态))
            strSql.Append(" ,审核备注=" & Utility.PFn_ChangeQuotation(cls采购表T.审核备注))
            strSql.Append(" ,审核人编号=" & Utility.PFn_ChangeQuotation(cls采购表T.审核人编号) & vbCrLf)
            strSql.Append("WHERE 采购单编号 in('" & cls采购表T.采购单编号 & "')")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Update采购状态 "

    '数据更新操作
    Public Function Update采购状态(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B原材料采购管理 ") '采购表
            strSql.Append(" SET ")
            strSql.Append(" 采购状态=" & Utility.PFn_ChangeQuotation(cls采购表T.采购状态) & vbCrLf)

            strSql.Append("WHERE 采购单编号=" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号))
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

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
#Region "LoadAll密度"
    Public Function LoadAll密度(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  材质 , ")
            strSql.Append("         密度 ")
            strSql.Append(" FROM    dbo.M材质密度 ")
            strSql.Append("INNER JOIN VM材质 ON VM材质 .名称 = M材质密度.材质 ")
            '检索条件 设定
            strSql.Append(" WHERE VM材质.区分=" & Utility.PFn_ChangeQuotation(cls采购表T.材质) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region "LoadHead"

    Public Function LoadAll(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT DISTINCT 采购单.采购单编号 " & vbCrLf)

            strSql.Append(" ,采购单.作成者编号")           '制造区分
            strSql.Append(" ,人员.人员名 AS 人员名称")           '制造区分
            strSql.Append(" ,采购单.供应商编号")           '制造区分
            strSql.Append(" ,供应商.供应商名称 AS 供应商名称")           '制造区分
            strSql.Append(" ,供应商.税率 AS 税率")           '制造区分
            strSql.Append(" ,采购单.申请日期,")           '部品番号
            'strSql.Append(" , 审核状态")           '采购日期
            'strSql.Append(" ,采购单.审核人")           '采购日期
            strSql.Append("        M原材料信息.原材料编号 AS 材料编号 , " & vbCrLf)
            strSql.Append("        M原材料信息.原材料名称 AS 材料名称 , " & vbCrLf)
            strSql.Append("        M原材料信息.原材料区分 AS 材料区分 , " & vbCrLf)
            strSql.Append("        M原材料信息.材料种类  , " & vbCrLf)
            strSql.Append("        M原材料信息.材质   " & vbCrLf)
            strSql.Append("  FROM   B原材料采购管理 采购单" & vbCrLf)
            strSql.Append("LEFT JOIN M原材料信息 ON 采购单.材料编号=M原材料信息.原材料编号" & vbCrLf)
            strSql.Append("       LEFT JOIN m人员管理 人员 " & vbCrLf)
            strSql.Append("         ON 采购单.作成者编号 = 人员.人员编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m供应商管理 供应商 " & vbCrLf)
            strSql.Append("         ON 采购单.供应商编号 = 供应商.供应商编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m供应商管理 供应商税率 " & vbCrLf)
            strSql.Append("         ON 采购单.供应商编号 = 供应商税率.供应商编号 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.VM审核状态 ON VM审核状态.区分=审核状态 " & vbCrLf)
            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 采购单.采购单编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号) & vbCrLf)

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

            strSql.Append(" ,采购单.作成者编号")           '制造区分
            strSql.Append(" ,人员.人员名 AS 人员名称")           '制造区分
            strSql.Append(" ,采购单.供应商编号")           '制造区分
            strSql.Append(" ,供应商.供应商名称 AS 供应商名称")           '制造区分
            strSql.Append(" ,供应商.税率 AS 税率")           '制造区分
            strSql.Append(" ,采购单.申请日期")           '部品番号
            'strSql.Append(" , 审核状态")           '采购日期
            'strSql.Append(" ,采购单.审核人")           '采购日期
            strSql.Append("  FROM   B原材料采购管理 采购单" & vbCrLf)
            strSql.Append("       LEFT JOIN m人员管理 人员 " & vbCrLf)
            strSql.Append("         ON 采购单.作成者编号 = 人员.人员编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m供应商管理 供应商 " & vbCrLf)
            strSql.Append("         ON 采购单.供应商编号 = 供应商.供应商编号 " & vbCrLf)
            strSql.Append("       LEFT JOIN m供应商管理 供应商税率 " & vbCrLf)
            strSql.Append("         ON 采购单.供应商编号 = 供应商税率.供应商编号 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.VM审核状态 ON VM审核状态.区分=审核状态 " & vbCrLf)
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
            strSql.Append("   WITH  vm订单采购 " & vbCrLf)
            strSql.Append("           AS ( SELECT DISTINCT " & vbCrLf)
            strSql.Append("                         0 选择 , " & vbCrLf)
            strSql.Append("                         订单.订单编号 , " & vbCrLf)
            strSql.Append("                         订单.订单数量 , " & vbCrLf)
            strSql.Append("                         A.产品图号 主图号 , " & vbCrLf)
            strSql.Append("                         A.品名 主图号名称 , " & vbCrLf)
            strSql.Append("                         图纸.上级图号 , " & vbCrLf)
            strSql.Append("                         图纸.产品图号 分图号 , " & vbCrLf)
            strSql.Append("                         图纸.品名 分图号名称 , " & vbCrLf)
            strSql.Append("                         原材料.材料代号 , " & vbCrLf)
            strSql.Append("                         CASE WHEN VM材料种类.名称 = '标准件' THEN 图纸.产品图号 " & vbCrLf)
            strSql.Append("                              ELSE 原材料.原材料编号 " & vbCrLf)
            strSql.Append("                         END 材料编号 , " & vbCrLf)
            strSql.Append("                         VM材料种类.名称 材料种类 , " & vbCrLf)
            strSql.Append("                         VM材质.名称 材质 , " & vbCrLf)
            strSql.Append("                         图纸.长 [长（图纸）] , " & vbCrLf)
            strSql.Append("                         图纸.宽 [宽（图纸）] , " & vbCrLf)
            strSql.Append("                         图纸.高 [高（图纸）] , " & vbCrLf)
            strSql.Append("                         图纸.数量 [数量（每套）] , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.长 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.宽 [宽（外径）] , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.高 [高（厚度）] , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.长度方向加工数量 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.宽度方向加工数量 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.[数量/张] , " & vbCrLf)
            strSql.Append("                         原材料.密度 , " & vbCrLf)
            strSql.Append("                         CASE WHEN VM材料种类.名称 = '标准件' THEN 图纸.单件重量 " & vbCrLf)
            strSql.Append("                              ELSE B原材料采购管理.重量 " & vbCrLf)
            strSql.Append("                         END 重量 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.单品耗材数量 单耗 , " & vbCrLf)
            strSql.Append("                         CASE WHEN VM材料种类.名称 = '标准件' " & vbCrLf)
            strSql.Append("                              THEN 图纸.数量 * ISNULL(订单.订单数量, 0) " & vbCrLf)
            strSql.Append("                              ELSE ISNULL(B原材料采购管理.单品耗材数量, 0) * ISNULL(订单.订单数量, " & vbCrLf)
            strSql.Append("                                                               0) " & vbCrLf)
            strSql.Append("                         END 计划采购数量 , " & vbCrLf)
            strSql.Append("                         实际采购数量 , " & vbCrLf)
            strSql.Append("                         计划采购重量 [计划采购重量（kg）] , " & vbCrLf)
            strSql.Append("                         实际采购重量 [实际采购重量（kg）] , " & vbCrLf)
            strSql.Append("                         VM币种.名称 币种 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.含税单价 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.含税总金额 , " & vbCrLf)
            strSql.Append("                         ISNULL(B原材料采购管理.含税单价, 0) * ISNULL(B原材料采购管理.单品耗材数量, 0) 单耗含税金额 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.未税单价 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.未税总金额 , " & vbCrLf)
            strSql.Append("                         供货日期 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.供货方式 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.备注 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.供应商编号 , " & vbCrLf)
            strSql.Append("                         订单.审核状态 , " & vbCrLf)
            strSql.Append("                         B原材料采购管理.采购状态 " & vbCrLf)
            strSql.Append("                FROM     dbo.B订单管理 订单 " & vbCrLf)
            strSql.Append("                         INNER JOIN dbo.T图纸管理 A ON A.产品图号 = 订单.产品图号 " & vbCrLf)
            strSql.Append("                         INNER JOIN dbo.T图纸关系 B ON B.产品图号 = A.产品图号 " & vbCrLf)
            strSql.Append("                                                   AND B.CIID = 0 " & vbCrLf)
            strSql.Append("                         INNER JOIN dbo.T图纸关系 C ON C.关系ID = B.关系ID " & vbCrLf)
            strSql.Append("                         LEFT JOIN dbo.T图纸关系 d ON d.关系ID = B.关系ID " & vbCrLf)
            strSql.Append("                                                  AND ( d.ID = C.CIID " & vbCrLf)
            strSql.Append("                                                        OR C.CIID IS NULL " & vbCrLf)
            strSql.Append("                                                      ) " & vbCrLf)
            strSql.Append("                         INNER JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = C.产品图号 " & vbCrLf)
            strSql.Append("                                                    AND 图纸.主图号 = A.主图号 " & vbCrLf)
            strSql.Append("                                                    AND ( d.产品图号 = 图纸.上级图号 " & vbCrLf)
            strSql.Append("                                                          OR d.产品图号 IS NULL " & vbCrLf)
            strSql.Append("                                                        ) " & vbCrLf)
            'strSql.Append("                                                    AND 图纸.材料种类 IS NOT NULL " & vbCrLf)
            'strSql.Append("                                                    AND 图纸.材料种类 <>'' " & vbCrLf)
            strSql.Append("                         LEFT JOIN dbo.M原材料信息 原材料 ON  原材料.原材料编号 = 图纸.原材料编号 " & vbCrLf)
            'strSql.Append("                                                     AND 原材料.材质 = 图纸.材质 " & vbCrLf)
            strSql.Append("                         LEFT JOIN dbo.B原材料采购管理 ON 订单.产品图号 = B原材料采购管理.主图号 " & vbCrLf)
            strSql.Append("                                                   AND B原材料采购管理.上级图号 = 图纸.上级图号 " & vbCrLf)
            strSql.Append("                                                   AND B原材料采购管理.分图号 = C.产品图号 " & vbCrLf)
            strSql.Append("                         LEFT JOIN dbo.VM币种 ON VM币种.区分 = 订单.币种 " & vbCrLf)
            strSql.Append("                         LEFT JOIN dbo.VM材料种类 ON VM材料种类.区分 = 原材料.材料种类 " & vbCrLf)
            strSql.Append("                         LEFT JOIN dbo.VM材质 ON VM材质.区分 = 原材料.材质 " & vbCrLf)
            strSql.Append("                WHERE    图纸.原材料编号 IS not NULL AND 图纸.原材料编号<>'' " & vbCrLf)
            If (cls采购表T.订单编号 <> String.Empty) Then
                strSql.Append("                        AND 订单.订单编号=" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号) & vbCrLf)
            End If
            strSql.Append("              ) " & vbCrLf)
            strSql.Append("     SELECT  vm订单采购.选择 , " & vbCrLf)
            strSql.Append("             vm订单采购.订单编号 , " & vbCrLf)
            strSql.Append("             vm订单采购.订单数量 , " & vbCrLf)
            strSql.Append("             vm订单采购.主图号 , " & vbCrLf)
            strSql.Append("             vm订单采购.主图号名称 , " & vbCrLf)
            strSql.Append("             vm订单采购.上级图号 , " & vbCrLf)
            strSql.Append("             vm订单采购.分图号 , " & vbCrLf)
            strSql.Append("             vm订单采购.分图号名称 , " & vbCrLf)
            strSql.Append("             vm订单采购.材料代号 , " & vbCrLf)
            strSql.Append("             vm订单采购.材料编号 , " & vbCrLf)
            strSql.Append("             vm订单采购.材料种类 , " & vbCrLf)
            strSql.Append("             vm订单采购.材质 , " & vbCrLf)
            strSql.Append("             vm订单采购.[长（图纸）] , " & vbCrLf)
            strSql.Append("             vm订单采购.[宽（图纸）] , " & vbCrLf)
            strSql.Append("             vm订单采购.[高（图纸）] , " & vbCrLf)
            strSql.Append("             vm订单采购.[数量（每套）] , " & vbCrLf)
            strSql.Append("             vm订单采购.长 , " & vbCrLf)
            strSql.Append("             vm订单采购.[宽（外径）] , " & vbCrLf)
            strSql.Append("             vm订单采购.[高（厚度）] , " & vbCrLf)
            strSql.Append("             vm订单采购.长度方向加工数量 , " & vbCrLf)
            strSql.Append("             vm订单采购.宽度方向加工数量 , " & vbCrLf)
            strSql.Append("             vm订单采购.[数量/张] , " & vbCrLf)
            strSql.Append("             vm订单采购.密度 , " & vbCrLf)
            strSql.Append("             vm订单采购.重量 , " & vbCrLf)
            strSql.Append("             vm订单采购.单耗 , " & vbCrLf)
            strSql.Append("             vm订单采购.计划采购数量 , " & vbCrLf)
            strSql.Append("             vm订单采购.实际采购数量 , " & vbCrLf)
            strSql.Append("             CONVERT(DECIMAL(18, 2), ISNULL(vm订单采购.计划采购数量, 0) " & vbCrLf)
            strSql.Append("             * ISNULL(vm订单采购.重量, 0)) AS [计划采购重量（kg）] , " & vbCrLf)
            strSql.Append("             vm订单采购.[实际采购重量（kg）] , " & vbCrLf)
            strSql.Append("             vm订单采购.币种 , " & vbCrLf)
            strSql.Append("             vm订单采购.含税单价 , " & vbCrLf)
            strSql.Append("             vm订单采购.含税总金额 , " & vbCrLf)
            strSql.Append("             vm订单采购.单耗含税金额 , " & vbCrLf)
            strSql.Append("             vm订单采购.未税单价 , " & vbCrLf)
            strSql.Append("             vm订单采购.未税总金额 , " & vbCrLf)
            strSql.Append("             vm订单采购.供货日期 , " & vbCrLf)
            strSql.Append("             vm订单采购.供货方式 , " & vbCrLf)
            strSql.Append("             vm订单采购.备注 , " & vbCrLf)
            strSql.Append("             vm订单采购.供应商编号 , " & vbCrLf)
            strSql.Append("             vm订单采购.审核状态 , " & vbCrLf)
            strSql.Append("             vm订单采购.采购状态 " & vbCrLf)
            strSql.Append("     FROM    vm订单采购 " & vbCrLf)
            strSql.Append("     EXCEPT " & vbCrLf)
            strSql.Append("     SELECT  vm订单采购.选择 , " & vbCrLf)
            strSql.Append("             vm订单采购.订单编号 , " & vbCrLf)
            strSql.Append("             vm订单采购.订单数量 , " & vbCrLf)
            strSql.Append("             vm订单采购.主图号 , " & vbCrLf)
            strSql.Append("             vm订单采购.主图号名称 , " & vbCrLf)
            strSql.Append("             vm订单采购.上级图号 , " & vbCrLf)
            strSql.Append("             vm订单采购.分图号 , " & vbCrLf)
            strSql.Append("             vm订单采购.分图号名称 , " & vbCrLf)
            strSql.Append("             vm订单采购.材料代号 , " & vbCrLf)
            strSql.Append("             vm订单采购.材料编号 , " & vbCrLf)
            strSql.Append("             vm订单采购.材料种类 , " & vbCrLf)
            strSql.Append("             vm订单采购.材质 , " & vbCrLf)
            strSql.Append("             vm订单采购.[长（图纸）] , " & vbCrLf)
            strSql.Append("             vm订单采购.[宽（图纸）] , " & vbCrLf)
            strSql.Append("             vm订单采购.[高（图纸）] , " & vbCrLf)
            strSql.Append("             vm订单采购.[数量（每套）] , " & vbCrLf)
            strSql.Append("             vm订单采购.长 , " & vbCrLf)
            strSql.Append("             vm订单采购.[宽（外径）] , " & vbCrLf)
            strSql.Append("             vm订单采购.[高（厚度）] , " & vbCrLf)
            strSql.Append("             vm订单采购.长度方向加工数量 , " & vbCrLf)
            strSql.Append("             vm订单采购.宽度方向加工数量 , " & vbCrLf)
            strSql.Append("             vm订单采购.[数量/张] , " & vbCrLf)
            strSql.Append("             vm订单采购.密度 , " & vbCrLf)
            strSql.Append("             vm订单采购.重量 , " & vbCrLf)
            strSql.Append("             vm订单采购.单耗 , " & vbCrLf)
            strSql.Append("             vm订单采购.计划采购数量 , " & vbCrLf)
            strSql.Append("             vm订单采购.实际采购数量 , " & vbCrLf)
            strSql.Append("             CONVERT(DECIMAL(18, 2), ISNULL(vm订单采购.计划采购数量, 0) " & vbCrLf)
            strSql.Append("             * ISNULL(vm订单采购.重量, 0)) AS [计划采购重量（kg）] , " & vbCrLf)
            strSql.Append("             vm订单采购.[实际采购重量（kg）] , " & vbCrLf)
            strSql.Append("             vm订单采购.币种 , " & vbCrLf)
            strSql.Append("             vm订单采购.含税单价 , " & vbCrLf)
            strSql.Append("             vm订单采购.含税总金额 , " & vbCrLf)
            strSql.Append("             vm订单采购.单耗含税金额 , " & vbCrLf)
            strSql.Append("             vm订单采购.未税单价 , " & vbCrLf)
            strSql.Append("             vm订单采购.未税总金额 , " & vbCrLf)
            strSql.Append("             vm订单采购.供货日期 , " & vbCrLf)
            strSql.Append("             vm订单采购.供货方式 , " & vbCrLf)
            strSql.Append("             vm订单采购.备注 , " & vbCrLf)
            strSql.Append("             vm订单采购.供应商编号 , " & vbCrLf)
            strSql.Append("             vm订单采购.审核状态 , " & vbCrLf)
            strSql.Append("             vm订单采购.采购状态 " & vbCrLf)
            strSql.Append("     FROM    vm订单采购 " & vbCrLf)
            strSql.Append("             INNER JOIN B原材料采购管理 ON B原材料采购管理.订单编号 = vm订单采购.订单编号 " & vbCrLf)
            strSql.Append("                                    AND B原材料采购管理.主图号 = vm订单采购.主图号 " & vbCrLf)
            strSql.Append("                                    AND B原材料采购管理.上级图号 = vm订单采购.上级图号 " & vbCrLf)
            strSql.Append("                                    AND B原材料采购管理.分图号 = vm订单采购.分图号 " & vbCrLf)
            strSql.Append("                                    AND vm订单采购.材料编号 = B原材料采购管理.材料编号 " & vbCrLf)
            strSql.Append("                                    AND B原材料采购管理.供应商编号 = vm订单采购.供应商编号 " & vbCrLf)
            strSql.Append("     ORDER BY vm订单采购.订单编号 , " & vbCrLf)
            strSql.Append("             vm订单采购.主图号 , " & vbCrLf)
            strSql.Append("             vm订单采购.上级图号 , " & vbCrLf)
            strSql.Append("             vm订单采购.分图号; " & vbCrLf)





            ''strSql.Append("SELECT DISTINCT " & vbCrLf)
            ''strSql.Append("        原材料编号 AS 材料编号 , " & vbCrLf)
            ''strSql.Append("        原材料名称 AS 材料名称 , " & vbCrLf)
            ''strSql.Append("        VM材料区分.名称 AS 材料区分 , " & vbCrLf)
            ''strSql.Append("        VM材料种类.名称 AS 材料种类  , " & vbCrLf)
            ''strSql.Append("        VM材质.名称 AS 材质   " & vbCrLf)
            ''strSql.Append("FROM M原材料信息" & vbCrLf)
            ''strSql.Append("LEFT JOIN B原材料采购管理 ON B原材料采购管理.材料编号=M原材料信息.原材料编号" & vbCrLf)
            ''strSql.Append("LEFT JOIN VM材料区分 ON VM材料区分.区分=M原材料信息.原材料区分" & vbCrLf)
            ''strSql.Append("LEFT JOIN VM材料种类 ON VM材料种类.区分=M原材料信息.材料种类" & vbCrLf)
            ''strSql.Append("LEFT JOIN VM材质 ON VM材质.区分=M原材料信息.材质" & vbCrLf)
            ''strSql.Append("WHERE B原材料采购管理.采购单编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号))
            'strSql.Append("  WITH    vm订单采购")
            'strSql.Append("          AS ( SELECT DISTINCT")
            'strSql.Append("                        0 选择 ,")
            'strSql.Append("                        订单.订单编号 ,")
            'strSql.Append("                        订单.订单数量 ,")
            'strSql.Append("                        A.产品图号 主图号 ,")
            'strSql.Append("                        A.品名 主图号名称 ,")
            'strSql.Append("                        图纸.上级图号 ,")
            'strSql.Append("                        图纸.产品图号 分图号 ,")
            'strSql.Append("                        图纸.品名 分图号名称 ,")
            'strSql.Append("                        图纸.材料代号 ,")
            'strSql.Append("                        CASE WHEN VM材料种类.名称 ='标准件' THEN 图纸.产品图号 ELSE  原材料.原材料编号 END 材料编号 ,")
            'strSql.Append("                        VM材料种类.名称 材料种类 ,")
            'strSql.Append("                        VM材质.名称 材质 ,")
            'strSql.Append("                        图纸.长 [长（图纸）] ,")
            'strSql.Append("                        图纸.宽 [宽（图纸）] ,")
            'strSql.Append("                        图纸.高 [高（图纸）] ,")
            'strSql.Append("                        图纸.数量 [数量（每套）] ,")
            'strSql.Append("                        B原材料采购管理.长 ,")
            'strSql.Append("                        B原材料采购管理.宽 [宽（外径）] ,")
            'strSql.Append("                        B原材料采购管理.高 [高（厚度）] ,")
            'strSql.Append("                        B原材料采购管理.长度方向加工数量 ,")
            'strSql.Append("                        B原材料采购管理.宽度方向加工数量 ,")
            'strSql.Append("                        B原材料采购管理.[数量/张] ,")
            'strSql.Append("                        原材料.密度 ,")
            'strSql.Append("                        CASE WHEN VM材料种类.名称='标准件' then 图纸. 单件重量 ELSE B原材料采购管理.重量 END 重量,")
            'strSql.Append("                        B原材料采购管理.单品耗材数量 ,")
            ''strSql.Append("                        ISNULL(B原材料采购管理.单品耗材数量, 0) * ISNULL(订单.订单数量, 0) 计划采购数量 ,")
            'strSql.Append("                         CASE WHEN VM材料种类.名称 = '标准件' " & vbCrLf)
            'strSql.Append("                              THEN 图纸.数量 * ISNULL(订单.订单数量, 0) " & vbCrLf)
            'strSql.Append("                              ELSE ISNULL(B原材料采购管理.单品耗材数量, 0) * ISNULL(订单.订单数量, " & vbCrLf)
            'strSql.Append("                                                               0) " & vbCrLf)
            'strSql.Append("                         END 计划采购数量 , " & vbCrLf)
            'strSql.Append("                        实际采购数量 ,")
            'strSql.Append("                        计划采购重量 [计划采购重量（kg）] ,")
            'strSql.Append("                        实际采购重量 [实际采购重量（kg）] ,")
            'strSql.Append("                        VM币种.名称 币种 ,")
            'strSql.Append("                        B原材料采购管理.含税单价 ,")
            'strSql.Append("                        B原材料采购管理.含税总金额 ,")
            'strSql.Append("                        B原材料采购管理.未税单价 ,")
            'strSql.Append("                        B原材料采购管理.未税总金额 ,")
            'strSql.Append("                        供货日期 ,")
            'strSql.Append("                        B原材料采购管理.供货方式 ,")
            'strSql.Append("                        B原材料采购管理.备注 ,")
            'strSql.Append("                        B原材料采购管理.供应商编号 ,")
            'strSql.Append("                        订单.审核状态 ,")
            'strSql.Append("                        B原材料采购管理.采购状态" & vbCrLf)
            'strSql.Append("               FROM     dbo.B订单管理 订单" & vbCrLf)
            'strSql.Append("                        INNER JOIN dbo.T图纸管理 A ON A.产品图号 = 订单.产品图号")
            'strSql.Append("                        INNER JOIN dbo.T图纸关系 B ON B.产品图号 = A.产品图号")
            'strSql.Append("                                                  AND B.CIID = 0")
            'strSql.Append("                        INNER JOIN dbo.T图纸关系 C ON C.关系ID = B.关系ID")
            'strSql.Append("                        LEFT JOIN dbo.T图纸关系 d ON d.关系ID = B.关系ID")
            'strSql.Append("                                                 AND ( d.ID = C.CIID")
            'strSql.Append("                                                       OR C.CIID IS NULL")
            'strSql.Append("                                                     )")
            'strSql.Append("                        INNER JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = C.产品图号")
            'strSql.Append("                                                   AND 图纸.主图号 = A.主图号")
            'strSql.Append("                                                   AND ( d.产品图号 = 图纸.上级图号")
            'strSql.Append("                                                         OR d.产品图号 IS NULL")
            'strSql.Append("                                                       )")
            'strSql.Append("                                                   AND 图纸.材料种类 IS NOT NULL")
            'strSql.Append("                        LEFT JOIN dbo.M原材料信息 原材料 ON 原材料.材料种类 = 图纸.材料种类")
            'strSql.Append("                                                    AND 原材料.材质 = 图纸.材质")
            'strSql.Append("                        LEFT JOIN dbo.B原材料采购管理 ON 订单.产品图号 = B原材料采购管理.主图号")
            'strSql.Append("                                                  AND B原材料采购管理.上级图号 = 图纸.上级图号")
            'strSql.Append("                                                  AND B原材料采购管理.分图号 = C.产品图号")
            'strSql.Append("                        LEFT JOIN dbo.VM币种 ON VM币种.区分 = 订单.币种")
            'strSql.Append("                        LEFT JOIN dbo.VM材料种类 ON VM材料种类.区分 = 图纸.材料种类")
            'strSql.Append("                        LEFT JOIN dbo.VM材质 ON VM材质.区分 = 图纸.材质" & vbCrLf)
            'strSql.Append("WHERE   1 = 1")
            'If (cls采购表T.订单编号 <> String.Empty) Then
            '    strSql.Append("                        AND 订单.订单编号=" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号) & vbCrLf)
            'End If

            'strSql.Append("             )")
            'strSql.Append("    SELECT vm订单采购.选择, vm订单采购.订单编号 ,")
            'strSql.Append("            vm订单采购.订单数量 ,")
            'strSql.Append("            vm订单采购.主图号 ,")
            'strSql.Append("            vm订单采购.主图号名称 ,")
            'strSql.Append("            vm订单采购.上级图号 ,")
            'strSql.Append("            vm订单采购.分图号 ,")
            'strSql.Append("            vm订单采购.分图号名称 ,")
            'strSql.Append("            vm订单采购.材料代号 ,")
            'strSql.Append("            vm订单采购.材料编号 ,")
            'strSql.Append("            vm订单采购.材料种类 ,")
            'strSql.Append("            vm订单采购.材质 ,")
            'strSql.Append("            vm订单采购.[长（图纸）] ,")
            'strSql.Append("            vm订单采购.[宽（图纸）] ,")
            'strSql.Append("            vm订单采购.[高（图纸）] ,")
            'strSql.Append("            vm订单采购.[数量（每套）] ,")
            'strSql.Append("            vm订单采购.长 ,")
            'strSql.Append("            vm订单采购.[宽（外径）] ,")
            'strSql.Append("            vm订单采购.[高（厚度）] ,")
            'strSql.Append("            vm订单采购.长度方向加工数量 ,")
            'strSql.Append("            vm订单采购.宽度方向加工数量 ,")
            'strSql.Append("            vm订单采购.[数量/张] ,")
            'strSql.Append("            vm订单采购.密度 ,")
            'strSql.Append("            vm订单采购.重量 ,")
            'strSql.Append("            vm订单采购.单品耗材数量 ,")
            'strSql.Append("            vm订单采购.计划采购数量 ,")
            'strSql.Append("            vm订单采购.实际采购数量 ,")
            'strSql.Append("            CONVERT(DECIMAL(18, 2), ISNULL(vm订单采购.计划采购数量, 0)")
            'strSql.Append("            * ISNULL(vm订单采购.重量, 0)) AS [计划采购重量（kg）] ,")
            'strSql.Append("            vm订单采购.[实际采购重量（kg）] ,")
            'strSql.Append("            vm订单采购.币种 ,")
            'strSql.Append("            vm订单采购.含税单价 ,")
            'strSql.Append("            vm订单采购.含税总金额 ,")
            'strSql.Append("            vm订单采购.未税单价 ,")
            'strSql.Append("            vm订单采购.未税总金额 ,")
            'strSql.Append("            vm订单采购.供货日期 ,")
            'strSql.Append("            vm订单采购.供货方式 ,")
            'strSql.Append("            vm订单采购.备注 ,")
            'strSql.Append("            vm订单采购.供应商编号 ,")
            'strSql.Append("            vm订单采购.审核状态 ,")
            'strSql.Append("            vm订单采购.采购状态" & vbCrLf)
            'strSql.Append("    FROM    vm订单采购" & vbCrLf)
            'strSql.Append("    EXCEPT" & vbCrLf)
            'strSql.Append("      SELECT vm订单采购.选择,  vm订单采购.订单编号 ,")
            'strSql.Append("            vm订单采购.订单数量 ,")
            'strSql.Append("            vm订单采购.主图号 ,")
            'strSql.Append("            vm订单采购.主图号名称 ,")
            'strSql.Append("            vm订单采购.上级图号 ,")
            'strSql.Append("            vm订单采购.分图号 ,")
            'strSql.Append("            vm订单采购.分图号名称 ,")
            'strSql.Append("            vm订单采购.材料代号 ,")
            'strSql.Append("            vm订单采购.材料编号 ,")
            'strSql.Append("            vm订单采购.材料种类 ,")
            'strSql.Append("            vm订单采购.材质 ,")
            'strSql.Append("            vm订单采购.[长（图纸）] ,")
            'strSql.Append("            vm订单采购.[宽（图纸）] ,")
            'strSql.Append("            vm订单采购.[高（图纸）] ,")
            'strSql.Append("            vm订单采购.[数量（每套）] ,")
            'strSql.Append("            vm订单采购.长 ,")
            'strSql.Append("            vm订单采购.[宽（外径）] ,")
            'strSql.Append("            vm订单采购.[高（厚度）] ,")
            'strSql.Append("            vm订单采购.长度方向加工数量 ,")
            'strSql.Append("            vm订单采购.宽度方向加工数量 ,")
            'strSql.Append("            vm订单采购.[数量/张] ,")
            'strSql.Append("            vm订单采购.密度 ,")
            'strSql.Append("            vm订单采购.重量 ,")
            'strSql.Append("            vm订单采购.单品耗材数量 ,")
            'strSql.Append("            vm订单采购.计划采购数量 ,")
            'strSql.Append("            vm订单采购.实际采购数量 ,")
            'strSql.Append("            CONVERT(DECIMAL(18, 2), ISNULL(vm订单采购.计划采购数量, 0)")
            'strSql.Append("            * ISNULL(vm订单采购.重量, 0)) AS [计划采购重量（kg）] ,")
            'strSql.Append("            vm订单采购.[实际采购重量（kg）] ,")
            'strSql.Append("            vm订单采购.币种 ,")
            'strSql.Append("            vm订单采购.含税单价 ,")
            'strSql.Append("            vm订单采购.含税总金额 ,")
            'strSql.Append("            vm订单采购.未税单价 ,")
            'strSql.Append("            vm订单采购.未税总金额 ,")
            'strSql.Append("            vm订单采购.供货日期 ,")
            'strSql.Append("            vm订单采购.供货方式 ,")
            'strSql.Append("            vm订单采购.备注 ,")
            'strSql.Append("            vm订单采购.供应商编号 ,")
            'strSql.Append("            vm订单采购.审核状态 ,")
            'strSql.Append("            vm订单采购.采购状态" & vbCrLf)
            'strSql.Append("    FROM    vm订单采购     " & vbCrLf)
            'strSql.Append("    INNER JOIN B原材料采购管理 ON B原材料采购管理.订单编号 = vm订单采购.订单编号")
            'strSql.Append("                                AND B原材料采购管理.主图号 = vm订单采购.主图号 ")
            'strSql.Append("                                AND B原材料采购管理.上级图号 = vm订单采购.上级图号 ")
            'strSql.Append("                                AND B原材料采购管理.分图号 = vm订单采购.分图号 ")
            'strSql.Append("                                AND vm订单采购.材料编号 = B原材料采购管理.材料编号 ")
            'strSql.Append("                                AND B原材料采购管理.供应商编号 = vm订单采购.供应商编号 " & vbCrLf)
            ''strSql.Append("    ORDER BY vm订单采购.材料编号,")
            ''strSql.Append("             vm订单采购.订单编号 ,")
            ''strSql.Append("             vm订单采购.主图号 , ")
            ''strSql.Append("             vm订单采购.分图号")
            'strSql.Append("    ORDER BY vm订单采购.订单编号,")
            'strSql.Append("             vm订单采购.主图号 ,")
            'strSql.Append("             vm订单采购.上级图号 , ")
            'strSql.Append("             vm订单采购.分图号")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "LoadBody1"

    Public Function LoadBody1(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT DISTINCT")
            strSql.Append("        0 选择 ,")
            strSql.Append("        B原材料采购管理.订单编号 ,")
            strSql.Append("        订单.订单数量 ,")
            strSql.Append("        B原材料采购管理.主图号 ,")
            strSql.Append("        图纸.品名 主图号名称 ,")
            strSql.Append("        B原材料采购管理.上级图号 ,")
            strSql.Append("        B原材料采购管理.分图号 ,")
            strSql.Append("        图纸.品名 分图号名称 ,")
            strSql.Append("        原材料.材料代号 ,")
            strSql.Append("        B原材料采购管理.材料编号 ,")
            strSql.Append("        VM材料种类.名称 材料种类 ,")
            strSql.Append("        VM材质.名称 材质 ,")
            strSql.Append("        图纸.长 [长（图纸）] ,")
            strSql.Append("        图纸.宽 [宽（图纸）] ,")
            strSql.Append("        图纸.高 [高（图纸）] ,")
            strSql.Append("        图纸.数量 [数量（每套）] ,")
            strSql.Append("        B原材料采购管理.长 ,")
            strSql.Append("        B原材料采购管理.宽 [宽（外径）] ,")
            strSql.Append("        B原材料采购管理.高 [高（厚度）] ,")
            strSql.Append("        B原材料采购管理.长度方向加工数量 ,")
            strSql.Append("        B原材料采购管理.宽度方向加工数量 ,")
            strSql.Append("        B原材料采购管理.[数量/张] ,")
            strSql.Append("        原材料.密度 ,")
            strSql.Append("        B原材料采购管理.重量 ,")
            strSql.Append("        B原材料采购管理.单品耗材数量 单耗 ,")
            strSql.Append("        ISNULL(B原材料采购管理.单品耗材数量, 0) * ISNULL(订单.订单数量, 0) 计划采购数量 ,")
            strSql.Append("        实际采购数量 ,")
            strSql.Append("        计划采购重量 [计划采购重量（kg）] ,")
            strSql.Append("        实际采购重量 [实际采购重量（kg）] ,")
            strSql.Append("        VM币种.名称 币种 ,")
            strSql.Append("        B原材料采购管理.含税单价 ,")
            strSql.Append("        B原材料采购管理.含税总金额 ,")
            strSql.Append("        ISNULL(B原材料采购管理.含税单价, 0) * ISNULL(B原材料采购管理.单品耗材数量, 0) 单耗含税金额 , " & vbCrLf)
            strSql.Append("        B原材料采购管理.未税单价 ,")
            strSql.Append("        B原材料采购管理.未税总金额 ,")
            strSql.Append("        供货日期 ,")
            strSql.Append("        B原材料采购管理.供货方式 ,")
            strSql.Append("        B原材料采购管理.备注 ,")
            strSql.Append("        B原材料采购管理.供应商编号 ,")
            strSql.Append("        B原材料采购管理.审核状态 ,")
            strSql.Append("        B原材料采购管理.审核备注 ,")
            strSql.Append("        B原材料采购管理.采购状态" & vbCrLf)
            strSql.Append("FROM    dbo.B原材料采购管理" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.B订单管理 订单 ON 订单.产品图号 = B原材料采购管理.主图号")
            strSql.Append("                                  AND 订单.订单编号 = B原材料采购管理.订单编号")
            strSql.Append("        INNER JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = B原材料采购管理.分图号")
            strSql.Append("                                   AND 图纸.主图号 = B原材料采购管理.主图号")
            strSql.Append("                                   AND 图纸.上级图号 = B原材料采购管理.上级图号")
            strSql.Append("        LEFT JOIN dbo.M原材料信息 原材料 ON 原材料.原材料编号 = 图纸.原材料编号")

            strSql.Append("        LEFT JOIN dbo.VM币种 ON VM币种.区分 = 订单.币种")
            strSql.Append("        LEFT JOIN dbo.VM材料种类 ON VM材料种类.区分 = 原材料.材料种类")
            strSql.Append("        LEFT JOIN dbo.VM材质 ON VM材质.区分 = 原材料.材质" & vbCrLf)
            strSql.Append("WHERE   1 = 1")
            If (cls采购表T.订单编号 <> String.Empty) Then
                strSql.Append("                        AND 订单.订单编号=" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号) & vbCrLf)
            End If
            If (cls采购表T.采购单编号 <> String.Empty) Then
                strSql.Append("                        AND B原材料采购管理.采购单编号=" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "LoadAllGrid1"

    Public Function LoadAllGrid1(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" WITH   vm订单采购 " & vbCrLf)
            strSql.Append("          AS ( SELECT DISTINCT " & vbCrLf)
            strSql.Append("                        0 选择 , " & vbCrLf)
            strSql.Append("                        订单.订单编号 , " & vbCrLf)
            strSql.Append("                        订单.订单数量 , " & vbCrLf)
            strSql.Append("                        A.产品图号 主图号 , " & vbCrLf)
            strSql.Append("                        A.品名 主图号名称 , " & vbCrLf)
            strSql.Append("                        图纸.上级图号 , " & vbCrLf)
            strSql.Append("                        图纸.产品图号 分图号 , " & vbCrLf)
            strSql.Append("                        图纸.品名 分图号名称 , " & vbCrLf)
            strSql.Append("                        原材料.原材料编号 , " & vbCrLf)
            strSql.Append("                        原材料.原材料名称 , " & vbCrLf)
            strSql.Append("                        VM材料种类.名称 材料种类 , " & vbCrLf)
            strSql.Append("                        VM材质.名称 材质 , " & vbCrLf)
            strSql.Append("                        图纸.长 [长（图纸）] , " & vbCrLf)
            strSql.Append("                        图纸.宽 [宽（图纸）] , " & vbCrLf)
            strSql.Append("                        图纸.高 [高（图纸）] , " & vbCrLf)
            strSql.Append("                        图纸.数量 [数量（每套）] , " & vbCrLf)
            strSql.Append("                        原材料.长 , " & vbCrLf)
            strSql.Append("                        原材料.宽 [宽（外径）] , " & vbCrLf)
            strSql.Append("                        原材料.高 [高（厚度）] , " & vbCrLf)
            strSql.Append("                        原材料.密度 , " & vbCrLf)
            strSql.Append("                        原材料.重量 , " & vbCrLf)
            strSql.Append("                        CONVERT(DECIMAL(18, 2), CASE WHEN VM材料种类.名称 = '标准件' " & vbCrLf)
            strSql.Append("                                                     THEN 0 " & vbCrLf)
            strSql.Append("                                                     WHEN VM材料种类.名称 = '标准件' " & vbCrLf)
            strSql.Append("                                                     THEN 0 " & vbCrLf)
            strSql.Append("                                                     WHEN VM材料种类.名称 = '板材' " & vbCrLf)
            strSql.Append("                                                     THEN 原材料.长 * 原材料.宽 " & vbCrLf)
            strSql.Append("                                                          * 原材料.高 * 原材料.密度 " & vbCrLf)
            strSql.Append("                                                          / 1000000 " & vbCrLf)
            strSql.Append("                                                          / ( ( 原材料.长 / ( 图纸.长 " & vbCrLf)
            strSql.Append("                                                              + 10 ) ) " & vbCrLf)
            strSql.Append("                                                              * ( 原材料.宽 " & vbCrLf)
            strSql.Append("                                                              / ( 图纸.宽 + 10 ) ) ) " & vbCrLf)
            strSql.Append("                                                          * 图纸.数量 " & vbCrLf)
            strSql.Append("                                                     WHEN VM材料种类.名称 = '棒材' " & vbCrLf)
            strSql.Append("                                                     THEN SQUARE(原材料.宽 / 2) " & vbCrLf)
            strSql.Append("                                                          * 3.14 / 1000000 " & vbCrLf)
            strSql.Append("                                                          * 原材料.长 * 原材料.密度 " & vbCrLf)
            strSql.Append("                                                          / ( 原材料.长 / ( 图纸.宽 " & vbCrLf)
            strSql.Append("                                                              + 10 ) ) " & vbCrLf)
            strSql.Append("                                                     WHEN VM材料种类.名称 = '管材' " & vbCrLf)
            strSql.Append("                                                     THEN ( 原材料.宽 - 原材料.高 ) " & vbCrLf)
            strSql.Append("                                                          * 原材料.高 * 原材料.密度 " & vbCrLf)
            strSql.Append("                                                          * 原材料.长 / 1000 " & vbCrLf)
            strSql.Append("                                                          / ( 原材料.长 / ( 图纸.长 " & vbCrLf)
            strSql.Append("                                                              + 10 ) ) * 图纸.数量 " & vbCrLf)
            strSql.Append("                                                END) AS 单品耗材数量 , " & vbCrLf)
            strSql.Append("                        CONVERT(DECIMAL(18, 2), CASE WHEN VM材料种类.名称 = '标准件' " & vbCrLf)
            strSql.Append("                                                     THEN 0 " & vbCrLf)
            strSql.Append("                                                     WHEN VM材料种类.名称 = '标准件' " & vbCrLf)
            strSql.Append("                                                     THEN 0 " & vbCrLf)
            strSql.Append("                                                     WHEN VM材料种类.名称 = '板材' " & vbCrLf)
            strSql.Append("                                                     THEN 原材料.长 * 原材料.宽 " & vbCrLf)
            strSql.Append("                                                          * 原材料.高 * 原材料.密度 " & vbCrLf)
            strSql.Append("                                                          / 1000000 " & vbCrLf)
            strSql.Append("                                                          / ( ( 原材料.长 / ( 图纸.长 " & vbCrLf)
            strSql.Append("                                                              + 10 ) ) " & vbCrLf)
            strSql.Append("                                                              * ( 原材料.宽 " & vbCrLf)
            strSql.Append("                                                              / ( 图纸.宽 + 10 ) ) ) " & vbCrLf)
            strSql.Append("                                                          * 图纸.数量 * 订单.订单数量 " & vbCrLf)
            strSql.Append("                                                     WHEN VM材料种类.名称 = '棒材' " & vbCrLf)
            strSql.Append("                                                     THEN SQUARE(原材料.宽 / 2) " & vbCrLf)
            strSql.Append("                                                          * 3.14 / 1000000 " & vbCrLf)
            strSql.Append("                                                          * 原材料.长 * 原材料.密度 " & vbCrLf)
            strSql.Append("                                                          / ( 原材料.长 / ( 图纸.宽 " & vbCrLf)
            strSql.Append("                                                              + 10 ) ) " & vbCrLf)
            strSql.Append("                                                          * 订单.订单数量 " & vbCrLf)
            strSql.Append("                                                     WHEN VM材料种类.名称 = '管材' " & vbCrLf)
            strSql.Append("                                                     THEN ( 原材料.宽 - 原材料.高 ) " & vbCrLf)
            strSql.Append("                                                          * 原材料.高 * 原材料.密度 " & vbCrLf)
            strSql.Append("                                                          * 原材料.长 / 1000 " & vbCrLf)
            strSql.Append("                                                          / ( 原材料.长 / ( 图纸.长 " & vbCrLf)
            strSql.Append("                                                              + 10 ) ) * 图纸.数量 " & vbCrLf)
            strSql.Append("                                                          * 订单.订单数量 " & vbCrLf)
            strSql.Append("                                                END) AS 计划采购数量 , " & vbCrLf)
            strSql.Append("                        B原材料采购管理.实际采购数量 , " & vbCrLf)
            strSql.Append("                        CONVERT(DECIMAL(18, 2), ISNULL(订单.订单数量, 0) " & vbCrLf)
            strSql.Append("                        * ISNULL(原材料.重量, 0)) AS [计划采购重量（kg）] , " & vbCrLf)
            strSql.Append("                        实际采购重量 [实际采购重量（kg）] , " & vbCrLf)
            strSql.Append("                        VM币种.名称 币种 , " & vbCrLf)
            strSql.Append("                        原材料.含税单价 , " & vbCrLf)
            strSql.Append("                        ISNULL(订单.订单数量, 0) * ISNULL(原材料.含税单价, 0) AS 含税总金额 , " & vbCrLf)
            strSql.Append("                        CONVERT(DECIMAL(18, 2), ISNULL(原材料.含税单价, 0) / ( 1 " & vbCrLf)
            strSql.Append("                                                              + ISNULL(M供应商管理.税率, " & vbCrLf)
            strSql.Append("                                                              0) * 0.01 )) AS 未税单价 , " & vbCrLf)
            strSql.Append("                        ISNULL(订单.订单数量, 0) " & vbCrLf)
            strSql.Append("                        * ( CONVERT(DECIMAL(18, 2), ISNULL(原材料.含税单价, 0) / ( 1 " & vbCrLf)
            strSql.Append("                                                              + ISNULL(M供应商管理.税率, " & vbCrLf)
            strSql.Append("                                                              0) * 0.01 )) ) AS 未税总金额 , " & vbCrLf)
            strSql.Append("                        B原材料采购管理.供货日期 , " & vbCrLf)
            strSql.Append("                        VM供货方式.名称 供货方式 , " & vbCrLf)
            strSql.Append("                        B原材料采购管理.备注 , " & vbCrLf)
            strSql.Append("                        M供应商管理.供应商编号 , " & vbCrLf)
            strSql.Append("                        订单.审核状态 , " & vbCrLf)
            strSql.Append("                        B原材料采购管理.采购状态 " & vbCrLf)
            strSql.Append("               FROM     dbo.B订单管理 订单 " & vbCrLf)
            strSql.Append("                        INNER JOIN dbo.T图纸管理 A ON A.产品图号 = 订单.产品图号 " & vbCrLf)
            strSql.Append("                        INNER JOIN dbo.T图纸关系 B ON B.产品图号 = A.产品图号 " & vbCrLf)
            strSql.Append("                                                  AND B.CIID = 0 " & vbCrLf)
            strSql.Append("                        INNER JOIN dbo.T图纸关系 C ON C.关系ID = B.关系ID " & vbCrLf)
            strSql.Append("                        LEFT JOIN dbo.T图纸关系 d ON d.关系ID = B.关系ID " & vbCrLf)
            strSql.Append("                                                 AND ( d.ID = C.CIID " & vbCrLf)
            strSql.Append("                                                       OR C.CIID IS NULL " & vbCrLf)
            strSql.Append("                                                     ) " & vbCrLf)
            strSql.Append("                        INNER JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = C.产品图号 " & vbCrLf)
            strSql.Append("                                                   AND 图纸.主图号 = A.主图号 " & vbCrLf)
            strSql.Append("                                                   AND ( d.产品图号 = 图纸.上级图号 " & vbCrLf)
            strSql.Append("                                                         OR d.产品图号 IS NULL " & vbCrLf)
            strSql.Append("                                                       ) " & vbCrLf)
            strSql.Append("                        INNER JOIN dbo.M原材料信息 原材料 ON 原材料.材料种类 = 图纸.材料种类 " & vbCrLf)
            strSql.Append("                                                     AND 原材料.材质 = 图纸.材质 " & vbCrLf)
            strSql.Append("                        LEFT JOIN dbo.VM材料种类 ON VM材料种类.区分 = 原材料.材料种类 " & vbCrLf)
            strSql.Append("                        LEFT JOIN dbo.VM材质 ON VM材质.区分 = 原材料.材质 " & vbCrLf)
            strSql.Append("                        INNER JOIN dbo.M供应商管理 ON M供应商管理.供应商编号 = 原材料.供应商编号 " & vbCrLf)
            strSql.Append("                        LEFT JOIN dbo.B原材料采购管理 ON B原材料采购管理.供应商编号 = M供应商管理.供应商编号 " & vbCrLf)
            strSql.Append("                                                  AND B原材料采购管理.订单编号 = 订单.订单编号 " & vbCrLf)
            strSql.Append("                                                  AND 订单.产品图号 = B原材料采购管理.主图号 " & vbCrLf)
            strSql.Append("                                                  AND B原材料采购管理.分图号 = C.产品图号 " & vbCrLf)
            strSql.Append("                                                  AND B原材料采购管理.上级图号 = 图纸.上级图号 " & vbCrLf)
            strSql.Append("                        LEFT JOIN dbo.VM供货方式 ON VM供货方式.区分 = M供应商管理.供货方式 " & vbCrLf)
            strSql.Append("                        LEFT JOIN dbo.VM币种 ON VM币种.区分 = 订单.币种 " & vbCrLf)
            strSql.Append("               WHERE    原材料.原材料编号  in ('" & cls采购表T.原材料编号 & "')" & vbCrLf)
            strSql.Append("                        AND M供应商管理.供应商编号  =" & Utility.PFn_ChangeQuotation(cls采购表T.供应商编号) & vbCrLf)
            strSql.Append("                        AND ( ( ISNULL(原材料.长, 0) >= ISNULL(图纸.长, 0) ) " & vbCrLf)
            strSql.Append("                              AND ( ISNULL(原材料.宽, 0) >= ISNULL(图纸.宽, 0) ) " & vbCrLf)
            strSql.Append("                              AND ( ISNULL(原材料.高, 0) >= ISNULL(图纸.高, 0) ) " & vbCrLf)
            strSql.Append("                              AND VM材料种类.名称 = '板材' " & vbCrLf)
            strSql.Append("                              OR VM材料种类.名称 <> '板材' " & vbCrLf)
            strSql.Append("                            ) " & vbCrLf)
            strSql.Append("                        AND ( ( ISNULL(原材料.长, 0) >= ISNULL(图纸.长, 0) ) " & vbCrLf)
            strSql.Append("                              AND ( ISNULL(原材料.宽, 0) = ISNULL(图纸.宽, 0) ) " & vbCrLf)
            strSql.Append("                              AND ( ISNULL(原材料.高, 0) = ISNULL(图纸.高, 0) ) " & vbCrLf)
            strSql.Append("                              AND VM材料种类.名称 = '管材' " & vbCrLf)
            strSql.Append("                              OR VM材料种类.名称 <> '管材' " & vbCrLf)
            strSql.Append("                            ) " & vbCrLf)
            strSql.Append("                        AND ( ( ISNULL(原材料.长, 0) >= ISNULL(图纸.长, 0) ) " & vbCrLf)
            strSql.Append("                              AND ( ISNULL(原材料.宽, 0) = ISNULL(图纸.宽, 0) ) " & vbCrLf)
            strSql.Append("                              AND VM材料种类.名称 = '管材' " & vbCrLf)
            strSql.Append("                              OR VM材料种类.名称 <> '管材' " & vbCrLf)
            strSql.Append("                            ) " & vbCrLf)
            strSql.Append("                        AND VM材料种类.名称  in ('" & cls采购表T.材料种类 & "')" & vbCrLf)
            strSql.Append("                        AND 订单.审核状态 = '2' " & vbCrLf)
            strSql.Append("                        AND B原材料采购管理.实际采购数量 IS NULL " & vbCrLf)
            If (cls采购表T.订单编号 <> String.Empty) Then
                strSql.Append("                        AND 订单.订单编号=" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号) & vbCrLf)
            End If
            strSql.Append("             ) " & vbCrLf)
            strSql.Append("    SELECT  vm订单采购.选择 , " & vbCrLf)
            strSql.Append("            vm订单采购.订单编号 , " & vbCrLf)
            strSql.Append("            vm订单采购.订单数量 , " & vbCrLf)
            strSql.Append("            vm订单采购.主图号 , " & vbCrLf)
            strSql.Append("            vm订单采购.主图号名称 , " & vbCrLf)
            strSql.Append("            vm订单采购.上级图号 , " & vbCrLf)
            strSql.Append("            vm订单采购.分图号 , " & vbCrLf)
            strSql.Append("            vm订单采购.分图号名称 , " & vbCrLf)
            strSql.Append("            vm订单采购.原材料编号 , " & vbCrLf)
            strSql.Append("            vm订单采购.原材料名称 , " & vbCrLf)
            strSql.Append("            vm订单采购.材料种类 , " & vbCrLf)
            strSql.Append("            vm订单采购.材质 , " & vbCrLf)
            strSql.Append("            vm订单采购.[长（图纸）] , " & vbCrLf)
            strSql.Append("            vm订单采购.[宽（图纸）] , " & vbCrLf)
            strSql.Append("            vm订单采购.[高（图纸）] , " & vbCrLf)
            strSql.Append("            vm订单采购.[数量（每套）] , " & vbCrLf)
            strSql.Append("            vm订单采购.长 , " & vbCrLf)
            strSql.Append("            vm订单采购.[宽（外径）] , " & vbCrLf)
            strSql.Append("            vm订单采购.[高（厚度）] , " & vbCrLf)
            strSql.Append("            vm订单采购.密度 , " & vbCrLf)
            strSql.Append("            vm订单采购.重量 , " & vbCrLf)
            strSql.Append("            vm订单采购.单品耗材数量 , " & vbCrLf)
            strSql.Append("            vm订单采购.计划采购数量 , " & vbCrLf)
            strSql.Append("            vm订单采购.实际采购数量 , " & vbCrLf)
            strSql.Append("            CONVERT(DECIMAL(18, 2), ISNULL(vm订单采购.计划采购数量, 0) " & vbCrLf)
            strSql.Append("            * ISNULL(vm订单采购.重量, 0)) AS [计划采购重量（kg）] , " & vbCrLf)
            strSql.Append("            vm订单采购.[实际采购重量（kg）] , " & vbCrLf)
            strSql.Append("            vm订单采购.币种 , " & vbCrLf)
            strSql.Append("            vm订单采购.含税单价 , " & vbCrLf)
            strSql.Append("            vm订单采购.含税总金额 , " & vbCrLf)
            strSql.Append("            vm订单采购.未税单价 , " & vbCrLf)
            strSql.Append("            vm订单采购.未税总金额 , " & vbCrLf)
            strSql.Append("            vm订单采购.供货日期 , " & vbCrLf)
            strSql.Append("            vm订单采购.供货方式 , " & vbCrLf)
            strSql.Append("            vm订单采购.备注 , " & vbCrLf)
            strSql.Append("            vm订单采购.供应商编号 , " & vbCrLf)
            strSql.Append("            vm订单采购.审核状态 , " & vbCrLf)
            strSql.Append("            vm订单采购.采购状态 " & vbCrLf)
            strSql.Append("    FROM    vm订单采购 " & vbCrLf)
            strSql.Append("    EXCEPT " & vbCrLf)
            strSql.Append("    SELECT  vm订单采购.选择 , " & vbCrLf)
            strSql.Append("            vm订单采购.订单编号 , " & vbCrLf)
            strSql.Append("            vm订单采购.订单数量 , " & vbCrLf)
            strSql.Append("            vm订单采购.主图号 , " & vbCrLf)
            strSql.Append("            vm订单采购.主图号名称 , " & vbCrLf)
            strSql.Append("            vm订单采购.上级图号 , " & vbCrLf)
            strSql.Append("            vm订单采购.分图号 , " & vbCrLf)
            strSql.Append("            vm订单采购.分图号名称 , " & vbCrLf)
            strSql.Append("            vm订单采购.原材料编号 , " & vbCrLf)
            strSql.Append("            vm订单采购.原材料名称 , " & vbCrLf)
            strSql.Append("            vm订单采购.材料种类 , " & vbCrLf)
            strSql.Append("            vm订单采购.材质 , " & vbCrLf)
            strSql.Append("            vm订单采购.[长（图纸）] , " & vbCrLf)
            strSql.Append("            vm订单采购.[宽（图纸）] , " & vbCrLf)
            strSql.Append("            vm订单采购.[高（图纸）] , " & vbCrLf)
            strSql.Append("            vm订单采购.[数量（每套）] , " & vbCrLf)
            strSql.Append("            vm订单采购.长 , " & vbCrLf)
            strSql.Append("            vm订单采购.[宽（外径）] , " & vbCrLf)
            strSql.Append("            vm订单采购.[高（厚度）] , " & vbCrLf)
            strSql.Append("            vm订单采购.密度 , " & vbCrLf)
            strSql.Append("            vm订单采购.重量 , " & vbCrLf)
            strSql.Append("            vm订单采购.单品耗材数量 , " & vbCrLf)
            strSql.Append("            vm订单采购.计划采购数量 , " & vbCrLf)
            strSql.Append("            vm订单采购.实际采购数量 , " & vbCrLf)
            strSql.Append("            CONVERT(DECIMAL(18, 2), ISNULL(vm订单采购.计划采购数量, 0) " & vbCrLf)
            strSql.Append("            * ISNULL(vm订单采购.重量, 0)) AS [计划采购重量（kg）] , " & vbCrLf)
            strSql.Append("            vm订单采购.[实际采购重量（kg）] , " & vbCrLf)
            strSql.Append("            vm订单采购.币种 , " & vbCrLf)
            strSql.Append("            vm订单采购.含税单价 , " & vbCrLf)
            strSql.Append("            vm订单采购.含税总金额 , " & vbCrLf)
            strSql.Append("            vm订单采购.未税单价 , " & vbCrLf)
            strSql.Append("            vm订单采购.未税总金额 , " & vbCrLf)
            strSql.Append("            vm订单采购.供货日期 , " & vbCrLf)
            strSql.Append("            vm订单采购.供货方式 , " & vbCrLf)
            strSql.Append("            vm订单采购.备注 , " & vbCrLf)
            strSql.Append("            vm订单采购.供应商编号 , " & vbCrLf)
            strSql.Append("            vm订单采购.审核状态 , " & vbCrLf)
            strSql.Append("            vm订单采购.采购状态 " & vbCrLf)
            strSql.Append("    FROM    vm订单采购 " & vbCrLf)
            strSql.Append("            INNER JOIN B原材料采购管理 ON B原材料采购管理.订单编号 = vm订单采购.订单编号 " & vbCrLf)
            strSql.Append("                                   AND B原材料采购管理.主图号 = vm订单采购.主图号 " & vbCrLf)
            strSql.Append("                                   AND B原材料采购管理.上级图号 = vm订单采购.上级图号 " & vbCrLf)
            strSql.Append("                                   AND B原材料采购管理.分图号 = vm订单采购.分图号 " & vbCrLf)
            strSql.Append("                                   AND vm订单采购.原材料编号 = B原材料采购管理.材料编号 " & vbCrLf)
            strSql.Append("                                   AND B原材料采购管理.供应商编号 = vm订单采购.供应商编号 " & vbCrLf)
            strSql.Append("    ORDER BY vm订单采购.原材料编号 , " & vbCrLf)
            strSql.Append("            vm订单采购.订单编号 , " & vbCrLf)
            strSql.Append("            vm订单采购.主图号 , " & vbCrLf)
            strSql.Append("            vm订单采购.分图号;    " & vbCrLf)



            'strSql.Append(" WITH   vm订单采购")
            'strSql.Append("          AS ( SELECT DISTINCT")
            'strSql.Append("                        0 选择 ,")
            'strSql.Append("                        订单.订单编号 ,")
            'strSql.Append("                        订单.订单数量 ,")
            ''strSql.Append("                        ISNULL(订单.投产数量, 订单.订单数量) 投产数量 ,")
            'strSql.Append("                        A.产品图号 主图号 ,")
            'strSql.Append("                        A.品名 主图号名称 ,")
            'strSql.Append("                        图纸.上级图号 ,")
            'strSql.Append("                        图纸.产品图号 分图号 ,")
            'strSql.Append("                        图纸.品名 分图号名称 ,")
            'strSql.Append("                        原材料.原材料编号 ,")
            'strSql.Append("                        原材料.原材料名称 ,")
            'strSql.Append("                        VM材料种类.名称 材料种类 ,")
            'strSql.Append("                        VM材质.名称 材质 ,")
            'strSql.Append("                        图纸.长 [长（图纸）] ,")
            'strSql.Append("                        图纸.宽 [宽（图纸）] ,")
            'strSql.Append("                        图纸.高 [高（图纸）] ,")
            'strSql.Append("                        图纸.数量 [数量（每套）] ,")
            'strSql.Append("                        原材料.长 ,")
            'strSql.Append("                        原材料.宽 [宽（外径）] ,")
            'strSql.Append("                        原材料.高 [高（厚度）] ,")
            'strSql.Append("                        原材料.密度 ,")
            'strSql.Append("                        原材料.重量 ,")
            'strSql.Append("                        CONVERT(DECIMAL(18, 2), CASE WHEN VM材料种类.名称 = '标准件'")
            'strSql.Append("                                                     THEN 0")
            'strSql.Append("                                                     WHEN VM材料种类.名称 = '标准件'")
            'strSql.Append("                                                     THEN 0")
            'strSql.Append("                                                     WHEN VM材料种类.名称 = '板材'")
            'strSql.Append("                                                     THEN 原材料.长 * 原材料.宽")
            'strSql.Append("                                                          * 原材料.高 * 原材料.密度")
            'strSql.Append("                                                          / 1000000")
            'strSql.Append("                                                          / ( ( 原材料.长 / ( 图纸.长")
            'strSql.Append("                                                              + 10 ) )")
            'strSql.Append("                                                              * ( 原材料.宽")
            'strSql.Append("                                                              / ( 图纸.宽 + 10 ) ) )")
            'strSql.Append("                                                          * 图纸.数量")
            'strSql.Append("                                                     WHEN VM材料种类.名称 = '棒材'")
            'strSql.Append("                                                     THEN SQUARE(原材料.宽 / 2)")
            'strSql.Append("                                                          * 3.14 / 1000000")
            'strSql.Append("                                                          * 原材料.长 * 原材料.密度")
            'strSql.Append("                                                          / ( 原材料.长 / ( 图纸.宽")
            'strSql.Append("                                                              + 10 ) )")
            'strSql.Append("                                                     WHEN VM材料种类.名称 = '管材'")
            'strSql.Append("                                                     THEN (原材料.宽 - 原材料.高)")
            'strSql.Append("                                                          * 原材料.高 * 原材料.密度")
            'strSql.Append("                                                          * 原材料.长 / 1000")
            'strSql.Append("                                                          / ( 原材料.长 / ( 图纸.长")
            'strSql.Append("                                                              + 10 ) ) * 图纸.数量")
            'strSql.Append("                                                END) AS 单品耗材数量 ,")
            'strSql.Append("                        CONVERT(DECIMAL(18, 2), CASE WHEN VM材料种类.名称 = '标准件'")
            'strSql.Append("                                                     THEN 0")
            'strSql.Append("                                                     WHEN VM材料种类.名称 = '标准件'")
            'strSql.Append("                                                     THEN 0")
            'strSql.Append("                                                     WHEN VM材料种类.名称 = '板材'")
            'strSql.Append("                                                     THEN 原材料.长 * 原材料.宽")
            'strSql.Append("                                                          * 原材料.高 * 原材料.密度")
            'strSql.Append("                                                          / 1000000")
            'strSql.Append("                                                          / ( ( 原材料.长 / ( 图纸.长")
            'strSql.Append("                                                              + 10 ) )")
            'strSql.Append("                                                              * ( 原材料.宽")
            'strSql.Append("                                                              / ( 图纸.宽 + 10 ) ) )")
            'strSql.Append("                                                          * 图纸.数量 * 订单.订单数量")
            'strSql.Append("                                                     WHEN VM材料种类.名称 = '棒材'")
            'strSql.Append("                                                     THEN SQUARE(原材料.宽 / 2)")
            'strSql.Append("                                                          * 3.14 / 1000000")
            'strSql.Append("                                                          * 原材料.长 * 原材料.密度")
            'strSql.Append("                                                          / ( 原材料.长 / ( 图纸.宽")
            'strSql.Append("                                                              + 10 ) )")
            'strSql.Append("                                                          * 订单.订单数量")
            'strSql.Append("                                                     WHEN VM材料种类.名称 = '管材'")
            'strSql.Append("                                                     THEN ( 原材料.宽 - 原材料.高 )")
            'strSql.Append("                                                          * 原材料.高 * 原材料.密度")
            'strSql.Append("                                                          * 原材料.长 / 1000")
            'strSql.Append("                                                          / ( 原材料.长 / ( 图纸.长")
            'strSql.Append("                                                              + 10 ) ) * 图纸.数量")
            'strSql.Append("                                                          * 订单.订单数量")
            'strSql.Append("                                                END) AS 计划采购数量 ,")
            'strSql.Append("                        B原材料采购管理.实际采购数量 ,")
            'strSql.Append("                        CONVERT(DECIMAL(18, 2), ISNULL(订单.订单数量, 0)")
            'strSql.Append("                        * ISNULL(原材料.重量, 0)) AS [计划采购重量（kg）] ,")
            'strSql.Append("                        实际采购重量 [实际采购重量（kg）] ,")
            'strSql.Append("                        VM币种.名称 币种 ,")
            'strSql.Append("                        原材料.含税单价 ,")
            'strSql.Append("                        ISNULL(订单.订单数量, 0) * ISNULL(原材料.含税单价, 0) AS 含税总金额 ,")
            'strSql.Append("                        CONVERT(DECIMAL(18, 2), ISNULL(原材料.含税单价, 0) / ( 1")
            'strSql.Append("                                                              + ISNULL(M供应商管理.税率,")
            'strSql.Append("                                                              0) * 0.01 )) AS 未税单价 ,")
            'strSql.Append("                        ISNULL(订单.订单数量, 0)")
            'strSql.Append("                        * ( CONVERT(DECIMAL(18, 2), ISNULL(原材料.含税单价, 0) / ( 1")
            'strSql.Append("                                                              + ISNULL(M供应商管理.税率,")
            'strSql.Append("                                                              0) * 0.01 )) ) AS 未税总金额 ,")
            'strSql.Append("                        B原材料采购管理.供货日期 ,")
            'strSql.Append("                        VM供货方式.名称 供货方式 ,")
            'strSql.Append("                        B原材料采购管理.备注 ,")
            'strSql.Append("                        M供应商管理.供应商编号 ,")
            'strSql.Append("                        订单.审核状态 ,")
            'strSql.Append("                        B原材料采购管理.采购状态")
            'strSql.Append("               FROM     dbo.B订单管理 订单")
            'strSql.Append("                        INNER JOIN dbo.T图纸管理 A ON A.产品图号 = 订单.产品图号")
            'strSql.Append("                        INNER JOIN dbo.T图纸关系 B ON B.产品图号 = A.产品图号")
            'strSql.Append("                                                  AND B.CIID = 0")
            'strSql.Append("                        INNER JOIN dbo.T图纸关系 C ON C.关系ID = B.关系ID")
            'strSql.Append("                        LEFT JOIN dbo.T图纸关系 d ON d.关系ID = B.关系ID")
            'strSql.Append("                                                 AND ( d.ID = C.CIID")
            'strSql.Append("                                                       OR C.CIID IS NULL")
            'strSql.Append("                                                     )")
            'strSql.Append("                        INNER JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = C.产品图号")
            'strSql.Append("                                                   AND 图纸.主图号 = A.主图号")
            'strSql.Append("                                                   AND ( d.产品图号 = 图纸.上级图号")
            'strSql.Append("                                                         OR d.产品图号 IS NULL")
            'strSql.Append("                                                       )")
            'strSql.Append("                        INNER JOIN dbo.M原材料信息 原材料 ON 原材料.材料种类 = 图纸.材料种类")
            'strSql.Append("                                                     AND 原材料.材质 = 图纸.材质")
            'strSql.Append("                        LEFT JOIN dbo.VM材料种类 ON VM材料种类.区分 = 原材料.材料种类")
            'strSql.Append("                        LEFT JOIN dbo.VM材质 ON VM材质.区分 = 原材料.材质")
            'strSql.Append("                        INNER JOIN dbo.M供应商管理 ON M供应商管理.供应商编号 = 原材料.供应商编号")
            'strSql.Append("                        LEFT JOIN dbo.B原材料采购管理 ON B原材料采购管理.供应商编号 = M供应商管理.供应商编号")
            'strSql.Append("                                                  AND B原材料采购管理.订单编号 = 订单.订单编号")
            'strSql.Append("                                                  AND 订单.产品图号 = B原材料采购管理.主图号")
            'strSql.Append("                                                  AND B原材料采购管理.分图号 = C.产品图号")
            'strSql.Append("                                                  AND B原材料采购管理.上级图号 = 图纸.上级图号")
            'strSql.Append("                        LEFT JOIN dbo.VM供货方式 ON VM供货方式.区分 = M供应商管理.供货方式")
            'strSql.Append("                        LEFT JOIN dbo.VM币种 ON VM币种.区分 = 订单.币种")
            'strSql.Append("                 WHERE  原材料.原材料编号 in ('" & cls采购表T.原材料编号 & "')" & vbCrLf)
            'strSql.Append("                        AND M供应商管理.供应商编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.供应商编号) & vbCrLf)

            'Select Case cls采购表T.材料种类
            '    Case "板材"
            '        strSql.Append("                        AND (ISNULL(原材料.长,0) >= ISNULL(图纸.长 ,0)) " & vbCrLf)
            '        strSql.Append("                        AND (ISNULL(原材料.宽,0) >= ISNULL(图纸.宽 ,0)) " & vbCrLf)
            '        strSql.Append("                        AND (ISNULL(原材料.高,0) >= ISNULL(图纸.高 ,0)) " & vbCrLf)

            '    Case "管材"
            '        strSql.Append("                        AND (ISNULL(原材料.长,0) >= ISNULL(图纸.长 ,0)) " & vbCrLf)
            '        strSql.Append("                        AND (ISNULL(原材料.宽,0) = ISNULL(图纸.宽 ,0)) " & vbCrLf)
            '        strSql.Append("                        AND (ISNULL(原材料.高,0) = ISNULL(图纸.高 ,0)) " & vbCrLf)
            '    Case "棒材"
            '        strSql.Append("                        AND (ISNULL(原材料.宽,0) = ISNULL(图纸.宽 ,0)) " & vbCrLf)
            'End Select
            'strSql.Append("                        AND VM材料种类.名称  in ('" & cls采购表T.材料种类 & "')" & vbCrLf)


            ''If (cls采购表T.材料种类 = "板材") Then
            ''    strSql.Append("                        AND (ISNULL(原材料.长,0) >= ISNULL(图纸.长 ,0)) " & vbCrLf)
            ''    strSql.Append("                        AND (ISNULL(原材料.宽,0) >= ISNULL(图纸.宽 ,0)) " & vbCrLf)
            ''    strSql.Append("                        AND (ISNULL(原材料.高,0) >= ISNULL(图纸.高 ,0)) " & vbCrLf)
            ''End If
            ''If (cls采购表T.材料种类 = "管材") Then
            ''    strSql.Append("                        AND (ISNULL(原材料.长,0) >= ISNULL(图纸.长 ,0)) " & vbCrLf)
            ''    strSql.Append("                        AND (ISNULL(原材料.宽,0) = ISNULL(图纸.宽 ,0)) " & vbCrLf)
            ''    strSql.Append("                        AND (ISNULL(原材料.高,0) = ISNULL(图纸.高 ,0)) " & vbCrLf)
            ''End If
            ''If (cls采购表T.材料种类 = "棒材") Then
            ''    strSql.Append("                        AND (ISNULL(原材料.宽,0) = ISNULL(图纸.宽 ,0)) " & vbCrLf)
            ''End If
            'strSql.Append("                        AND 订单.审核状态 = '2' " & vbCrLf)
            'strSql.Append("                        AND B原材料采购管理.实际采购数量 IS NULL " & vbCrLf)
            'If (cls采购表T.订单编号 <> String.Empty) Then
            '    strSql.Append("                        AND 订单.订单编号=" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号) & vbCrLf)
            'End If
            'strSql.Append("             ) " & vbCrLf)
            'strSql.Append("    SELECT  vm订单采购.选择 , " & vbCrLf)
            'strSql.Append("            vm订单采购.订单编号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.订单数量 , " & vbCrLf)
            ''strSql.Append("            vm订单采购.投产数量 , " & vbCrLf)
            'strSql.Append("            vm订单采购.主图号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.主图号名称 , " & vbCrLf)
            'strSql.Append("            vm订单采购.上级图号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.分图号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.分图号名称 , " & vbCrLf)
            'strSql.Append("            vm订单采购.原材料编号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.原材料名称 , " & vbCrLf)
            'strSql.Append("            vm订单采购.材料种类 , " & vbCrLf)
            'strSql.Append("            vm订单采购.材质 , " & vbCrLf)
            'strSql.Append("            vm订单采购.[长（图纸）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.[宽（图纸）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.[高（图纸）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.[数量（每套）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.长 , " & vbCrLf)
            'strSql.Append("            vm订单采购.[宽（外径）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.[高（厚度）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.密度 , " & vbCrLf)
            'strSql.Append("            vm订单采购.重量 , " & vbCrLf)
            'strSql.Append("            vm订单采购.单品耗材数量 , " & vbCrLf)
            'strSql.Append("            vm订单采购.计划采购数量 , " & vbCrLf)
            'strSql.Append("            vm订单采购.实际采购数量 , " & vbCrLf)
            'strSql.Append("            CONVERT(DECIMAL(18, 2), ISNULL(vm订单采购.计划采购数量, 0) " & vbCrLf)
            'strSql.Append("            * ISNULL(vm订单采购.重量, 0)) AS [计划采购重量（kg）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.[实际采购重量（kg）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.币种 , " & vbCrLf)
            'strSql.Append("            vm订单采购.含税单价 , " & vbCrLf)
            'strSql.Append("            vm订单采购.含税总金额 , " & vbCrLf)
            'strSql.Append("            vm订单采购.未税单价 , " & vbCrLf)
            'strSql.Append("            vm订单采购.未税总金额 , " & vbCrLf)
            'strSql.Append("            vm订单采购.供货日期 , " & vbCrLf)
            'strSql.Append("            vm订单采购.供货方式 , " & vbCrLf)
            'strSql.Append("            vm订单采购.备注 , " & vbCrLf)
            'strSql.Append("            vm订单采购.供应商编号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.审核状态 , " & vbCrLf)
            'strSql.Append("            vm订单采购.采购状态 " & vbCrLf)
            'strSql.Append("    FROM    vm订单采购 " & vbCrLf)
            'strSql.Append("    EXCEPT " & vbCrLf)
            'strSql.Append("    SELECT  vm订单采购.选择 , " & vbCrLf)
            'strSql.Append("            vm订单采购.订单编号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.订单数量 , " & vbCrLf)
            ''strSql.Append("            vm订单采购.投产数量 , " & vbCrLf)
            'strSql.Append("            vm订单采购.主图号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.主图号名称 , " & vbCrLf)
            'strSql.Append("            vm订单采购.上级图号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.分图号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.分图号名称 , " & vbCrLf)
            'strSql.Append("            vm订单采购.原材料编号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.原材料名称 , " & vbCrLf)
            'strSql.Append("            vm订单采购.材料种类 , " & vbCrLf)
            'strSql.Append("            vm订单采购.材质 , " & vbCrLf)
            'strSql.Append("            vm订单采购.[长（图纸）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.[宽（图纸）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.[高（图纸）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.[数量（每套）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.长 , " & vbCrLf)
            'strSql.Append("            vm订单采购.[宽（外径）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.[高（厚度）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.密度 , " & vbCrLf)
            'strSql.Append("            vm订单采购.重量 , " & vbCrLf)
            'strSql.Append("            vm订单采购.单品耗材数量 , " & vbCrLf)
            'strSql.Append("            vm订单采购.计划采购数量 , " & vbCrLf)
            'strSql.Append("            vm订单采购.实际采购数量 , " & vbCrLf)
            'strSql.Append("            CONVERT(DECIMAL(18, 2), ISNULL(vm订单采购.计划采购数量, 0) " & vbCrLf)
            'strSql.Append("            * ISNULL(vm订单采购.重量, 0)) AS [计划采购重量（kg）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.[实际采购重量（kg）] , " & vbCrLf)
            'strSql.Append("            vm订单采购.币种 , " & vbCrLf)
            'strSql.Append("            vm订单采购.含税单价 , " & vbCrLf)
            'strSql.Append("            vm订单采购.含税总金额 , " & vbCrLf)
            'strSql.Append("            vm订单采购.未税单价 , " & vbCrLf)
            'strSql.Append("            vm订单采购.未税总金额 , " & vbCrLf)
            'strSql.Append("            vm订单采购.供货日期 , " & vbCrLf)
            'strSql.Append("            vm订单采购.供货方式 , " & vbCrLf)
            'strSql.Append("            vm订单采购.备注 , " & vbCrLf)
            'strSql.Append("            vm订单采购.供应商编号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.审核状态 , " & vbCrLf)
            'strSql.Append("            vm订单采购.采购状态 " & vbCrLf)
            'strSql.Append("    FROM    vm订单采购 " & vbCrLf)
            'strSql.Append("            INNER JOIN B原材料采购管理 ON B原材料采购管理.订单编号 = vm订单采购.订单编号 " & vbCrLf)
            'strSql.Append("                                   AND B原材料采购管理.主图号 = vm订单采购.主图号 " & vbCrLf)
            'strSql.Append("                                   AND B原材料采购管理.上级图号 = vm订单采购.上级图号 " & vbCrLf)
            'strSql.Append("                                   AND B原材料采购管理.分图号 = vm订单采购.分图号 " & vbCrLf)
            'strSql.Append("                                   AND vm订单采购.原材料编号 = B原材料采购管理.材料编号 " & vbCrLf)
            'strSql.Append("                                   AND B原材料采购管理.供应商编号 = vm订单采购.供应商编号 " & vbCrLf)
            'strSql.Append("    ORDER BY vm订单采购.原材料编号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.订单编号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.主图号 , " & vbCrLf)
            'strSql.Append("            vm订单采购.分图号;   " & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "Load工序"

    Public Function Load工序(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT DISTINCT " & vbCrLf)
            strSql.Append("        'true' 选择 ," & vbCrLf)
            strSql.Append("        订单.订单编号 ," & vbCrLf)
            strSql.Append("        订单.订单数量 , " & vbCrLf)
            'strSql.Append("        ISNULL(订单.投产数量, 订单.订单数量) 投产数量 ," & vbCrLf)
            strSql.Append("        B原材料采购管理.主图号 ," & vbCrLf)
            strSql.Append("        A.品名 主图号名称 ," & vbCrLf)
            strSql.Append("        B原材料采购管理.上级图号 ," & vbCrLf)
            strSql.Append("        分图号 ," & vbCrLf)
            strSql.Append("        图纸.品名 分图号名称 ," & vbCrLf)
            strSql.Append("        原材料.原材料编号 ," & vbCrLf)
            strSql.Append("        原材料.原材料名称 ," & vbCrLf)
            strSql.Append("        VM材料种类.名称 材料种类 ," & vbCrLf)
            strSql.Append("        VM材质.名称 材质 ," & vbCrLf)
            strSql.Append("        图纸.长 [长（图纸）] ," & vbCrLf)
            strSql.Append("        图纸.宽 [宽（图纸）] ," & vbCrLf)
            strSql.Append("        图纸.高 [高（图纸）]," & vbCrLf)
            strSql.Append("        图纸.数量 [数量（每套）] ," & vbCrLf)
            strSql.Append("        原材料.长 ," & vbCrLf)
            strSql.Append("        原材料.宽 [宽（外径）] ," & vbCrLf)
            strSql.Append("        原材料.高 [高（厚度）] ," & vbCrLf)
            strSql.Append("        原材料.密度 ," & vbCrLf)
            strSql.Append("        原材料.重量 ," & vbCrLf)
            strSql.Append("        B原材料采购管理.单品耗材数量 , " & vbCrLf)
            strSql.Append("        计划采购数量 , " & vbCrLf)
            strSql.Append("        B原材料采购管理.实际采购数量," & vbCrLf)
            strSql.Append("        计划采购重量 as [计划采购重量（kg）]," & vbCrLf)
            strSql.Append("        实际采购重量  [实际采购重量（kg）]," & vbCrLf)
            strSql.Append("        B原材料采购管理.币种 ," & vbCrLf)
            'strSql.Append("        M供应商管理.税率 ," & vbCrLf)
            strSql.Append("        B原材料采购管理.含税单价 ," & vbCrLf)
            strSql.Append("        B原材料采购管理.含税总金额," & vbCrLf)
            strSql.Append("        B原材料采购管理.未税单价," & vbCrLf)
            strSql.Append("        B原材料采购管理.未税总金额," & vbCrLf)
            strSql.Append("        B原材料采购管理.供货日期 ," & vbCrLf)
            strSql.Append("        B原材料采购管理.供货方式 ," & vbCrLf)
            strSql.Append("        B原材料采购管理.备注," & vbCrLf)
            strSql.Append("        M供应商管理.供应商编号," & vbCrLf)
            strSql.Append("        B原材料采购管理.审核状态," & vbCrLf)
            strSql.Append("        VM采购状态.名称 采购状态" & vbCrLf)
            strSql.Append("FROM   dbo.B原材料采购管理 " & vbCrLf)
            strSql.Append("inner JOIN dbo.T图纸管理 A ON A.产品图号 = B原材料采购管理.主图号 " & vbCrLf)
            strSql.Append("inner JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = B原材料采购管理.分图号" & vbCrLf)
            'strSql.Append("LEFT JOIN dbo.T图纸关系 B ON B.产品图号 = A.产品图号 AND B.CIID = 0" & vbCrLf)
            'strSql.Append("LEFT JOIN dbo.T图纸关系 C ON C.关系ID = B.关系ID" & vbCrLf)
            strSql.Append("inner JOIN dbo.B订单管理 订单 on B原材料采购管理.订单编号 =订单.订单编号 AND 订单.产品图号=B原材料采购管理.主图号" & vbCrLf)
            strSql.Append("inner JOIN dbo.M原材料信息 原材料 ON 原材料.材料种类=图纸.材料种类 AND 原材料.材质 = 图纸.材质" & vbCrLf)
            strSql.Append("LEFT JOIN dbo.M供应商管理 ON M供应商管理.供应商编号 = 原材料.供应商编号 and B原材料采购管理.供应商编号 =M供应商管理.供应商编号 ")
            strSql.Append("inner JOIN dbo.VM材料种类 ON VM材料种类.区分 = 原材料.材料种类" & vbCrLf)
            strSql.Append("inner JOIN dbo.VM材质 ON VM材质.区分 = 原材料.材质" & vbCrLf)
            strSql.Append("inner JOIN dbo.VM供货方式 ON VM供货方式.区分 = 订单.交货方式" & vbCrLf)
            strSql.Append("inner JOIN dbo.VM币种 ON VM币种.区分 = 订单.币种" & vbCrLf)
            strSql.Append("LEFT JOIN dbo.VM采购状态 ON VM采购状态.区分 = B原材料采购管理.采购状态" & vbCrLf)
            strSql.Append("WHERE 原材料.原材料编号 in ('" & cls采购表T.原材料编号 & "')" & vbCrLf)
            strSql.Append("and B原材料采购管理.采购单编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号) & vbCrLf)
            If (cls采购表T.订单编号 <> String.Empty) Then
                strSql.Append("and 订单.订单编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号) & vbCrLf)
            End If
            strSql.Append("ORDER BY 原材料.原材料编号")
            'strSql.Append("and 原材料.供应商编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.供应商编号) & vbCrLf)
            'If Not String.IsNullOrEmpty(cls采购表T.订单编号) Then
            '    strSql.Append("     AND 采购单.订单编号=" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号) & vbCrLf)
            'End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "SetData1"

    Public Function SetData1(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("SELECT  原材料编号 , " & vbCrLf)
            strSql.Append("        原材料名称 , " & vbCrLf)
            strSql.Append("        VM材料区分.名称 原材料区分 , " & vbCrLf)
            strSql.Append("        VM材料类别.名称 类型 , " & vbCrLf)
            strSql.Append("        材质 , " & vbCrLf)
            strSql.Append("        ISNULL(M原材料信息.含税单价, 0) 含税单价 , " & vbCrLf)
            strSql.Append("        ISNULL(B原材料库存表.库存数量, 0) AS 在库数量 , " & vbCrLf)
            strSql.Append("        ISNULL(B原材料库存表.库存重量, 0) AS 在库重量 , " & vbCrLf)
            strSql.Append("        允许修改 , " & vbCrLf)
            strSql.Append("        ISNULL(重量, 0) 重量 " & vbCrLf)
            strSql.Append("FROM    dbo.M原材料信息 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.B原材料库存表 ON dbo.M原材料信息.原材料编号 = dbo.B原材料库存表.材料编号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材料区分 ON VM材料区分.区分=原材料区分 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材料类别 ON VM材料类别.区分=类型 " & vbCrLf)
            strSql.Append(" WHERE 原材料编号=" & Utility.PFn_ChangeQuotation(cls采购表T.原材料编号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "SetData原材料"

    Public Function SetData原材料(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  " & vbCrLf)

            strSql.Append(" [原材料编号]")
            strSql.Append(" ,[原材料名称]")
            strSql.Append(" ,[原材料区分]")
            strSql.Append(" ,[类型]")
            strSql.Append(" ,[材质]")
            strSql.Append(" FROM [dbo].[M原材料信息]")
            strSql.Append(" WHERE 原材料编号=" & Utility.PFn_ChangeQuotation(cls采购表T.原材料编号) & vbCrLf)

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

            strSql.Append(" ,采购单.作成者编号")           '制造区分
            strSql.Append(" ,人员.人员名 AS 人员名称")           '制造区分
            strSql.Append(" ,采购单.供应商编号")           '制造区分
            strSql.Append(" ,供应商.供应商名称 AS 供应商名称")           '制造区分
            strSql.Append(" ,供应商.税率 AS 税率")           '制造区分
            strSql.Append(" ,采购单.申请日期")           '部品番号
            strSql.Append(" ,采购单.审核状态")           '采购日期
            strSql.Append(" ,人员.人员名 AS 审核人")           '采购日期
            strSql.Append("  FROM   B原材料采购管理 采购单" & vbCrLf)
            strSql.Append("       LEFT JOIN m人员管理 人员 " & vbCrLf)
            strSql.Append("         ON 采购单.作成者编号 = 人员.人员编号 " & vbCrLf)
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
#Region " LoadAllHead "

    '检索全部数据


    Public Function LoadAllHead(ByVal ojbM原材料T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  原材料编号 ,")
            strSql.Append("         原材料名称 ,")
            strSql.Append("         原材料区分,")
            'strSql.Append("         批次号,")
            strSql.Append("         类型 ,")
            strSql.Append("         材质 ,")
            strSql.Append("         密度 ,")
            strSql.Append("         M原材料信息.长 ,")
            strSql.Append("         M原材料信息.宽 ,")
            strSql.Append("         订单编号 ,")
            strSql.Append("         M原材料信息.高")
            strSql.Append(" FROM    dbo.M原材料信息" & vbCrLf)
            strSql.Append("inner join B原材料采购管理 on B原材料采购管理.材料编号=M原材料信息.原材料编号")
            '检索条件 设定
            strSql.Append(" WHERE 原材料编号=" & Utility.PFn_ChangeQuotation(ojbM原材料T.原材料编号) & vbCrLf)
            Return strSql.ToString()
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

            strSql.Append("SELECT  distinct 0 AS 选择 , " & vbCrLf)
            strSql.Append("        采购单.采购单编号 , " & vbCrLf)
            strSql.Append("        采购单.申请日期 , " & vbCrLf)
            strSql.Append("        供应商.供应商名称 AS 供应商名称 , " & vbCrLf)
            strSql.Append("        供应商.税率 AS [税率(%)] , " & vbCrLf)
            'strSql.Append("        库存.库存数量 已入库数量," & vbCrLf)
            strSql.Append("        VM采购状态.名称 采购状态," & vbCrLf)
            strSql.Append("        ISNULL(VM审核状态.名称,'未审核') 审核状态  , " & vbCrLf)
            strSql.Append("        人员1.人员名 审核人 ," & vbCrLf)
            strSql.Append("        采购单.审核备注 , " & vbCrLf)
            strSql.Append("        人员.人员名 AS 作成者 " & vbCrLf)
            strSql.Append("FROM    B原材料采购管理 采购单 " & vbCrLf)
            strSql.Append("        LEFT JOIN M人员管理 人员 ON 采购单.作成者编号 = 人员.人员编号" & vbCrLf)
            strSql.Append("        LEFT JOIN M人员管理 人员1  ON 人员1.人员编号= 采购单.审核人编号" & vbCrLf)
            strSql.Append("        LEFT JOIN M供应商管理 供应商 ON 采购单.供应商编号 = 供应商.供应商编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN M供应商管理 供应商税率 ON 采购单.供应商编号 = 供应商税率.供应商编号 " & vbCrLf)

            strSql.Append("        LEFT JOIN dbo.VM审核状态 ON VM审核状态.区分 = 审核状态 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM采购状态 ON VM采购状态.区分 = 采购状态 " & vbCrLf)
            strSql.Append("        LEFT JOIN M原材料信息 ON M原材料信息.原材料编号 = 采购单.材料编号 " & vbCrLf)
            If (cls采购表T.区分 = True) Then
                strSql.Append("        LEFT JOIN B原材料入库申请 ON B原材料入库申请.采购单编号 = 采购单.采购单编号 " & vbCrLf)
            End If
            strSql.Append("WHERE  1=1 " & vbCrLf)
            If Not String.IsNullOrEmpty(cls采购表T.采购单编号) Then
                strSql.Append("     AND 采购单.采购单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls采购表T.原材料编号) Then
                strSql.Append("     AND 采购单.材料编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.原材料编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls采购表T.客户编号) Then
                strSql.Append("     AND 采购单.客户编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.客户编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls采购表T.材料区分) Then
                strSql.Append("     AND M原材料信息.原材料区分= " & Utility.PFn_ChangeQuotation(cls采购表T.材料区分))
            End If
            If Not String.IsNullOrEmpty(cls采购表T.供应商编号) Then
                strSql.Append("     AND 采购单.供应商编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.供应商编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls采购表T.订单编号) Then
                strSql.Append("     AND 采购单.订单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls采购表T.审核状态) Then
                strSql.Append("     AND VM审核状态.区分 =" & Utility.PFn_ChangeQuotation(cls采购表T.审核状态))
            End If
            If Not String.IsNullOrEmpty(cls采购表T.采购状态) Then
                strSql.Append("     AND VM采购状态.区分 =" & Utility.PFn_ChangeQuotation(cls采购表T.采购状态))
            End If
            If (cls采购表T.供货日期 <> "1900/1/1") Then
                strSql.Append(" AND 采购单.供货日期 >=" & Utility.PFn_ChangeQuotation(cls采购表T.供货日期) & vbCrLf)
            End If
            If (cls采购表T.供货日期2 <> "1900/1/1") Then
                strSql.Append(" AND 采购单.供货日期 <" & Utility.PFn_ChangeQuotation(CDate(cls采购表T.供货日期2).AddDays(1)) & vbCrLf)
            End If
            If (cls采购表T.区分 = True) Then
                strSql.Append("  AND  B原材料入库申请.采购单编号 IS NULL" & vbCrLf)
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

            strSql.Append(" SELECT  DISTINCT  " & vbCrLf)
            strSql.Append("         采购.采购单编号 , " & vbCrLf)
            strSql.Append("         采购.材料编号 , " & vbCrLf)
            strSql.Append("         CASE WHEN dbo.VM材料种类.名称 = '标准件' THEN 图纸.品名 " & vbCrLf)
            strSql.Append("              ELSE M原材料信息.原材料名称 " & vbCrLf)
            strSql.Append("         END 材料名称 , " & vbCrLf)
            strSql.Append("         CASE WHEN dbo.VM材料种类.名称 = '标准件' THEN dbo.VM材料种类.名称 " & vbCrLf)
            strSql.Append("              ELSE VM材料区分.名称 " & vbCrLf)
            strSql.Append("         END 材料区分 , " & vbCrLf)
            strSql.Append("         CASE WHEN dbo.VM材料种类.名称 = '标准件' THEN a.名称 " & vbCrLf)
            strSql.Append("              ELSE b.名称 " & vbCrLf)
            strSql.Append("         END 材质 , " & vbCrLf)
            strSql.Append("         采购.长 , " & vbCrLf)
            strSql.Append("         采购.宽 AS [宽（直径）] , " & vbCrLf)
            strSql.Append("         采购.高 AS [高（厚度）] , " & vbCrLf)
            strSql.Append("         采购.订单编号 , " & vbCrLf)
            strSql.Append("         采购.主图号 , " & vbCrLf)
            strSql.Append("         采购.上级图号 , " & vbCrLf)
            strSql.Append("         采购.分图号 , " & vbCrLf)
            strSql.Append("         图纸.品名 AS 产品名称 , " & vbCrLf)
            strSql.Append("         B订单管理.订单数量 AS 订单数量 , " & vbCrLf)
            strSql.Append("         采购.计划采购数量 AS [计划采购数量（个）] , " & vbCrLf)
            strSql.Append("         采购.实际采购数量 AS [实际采购数量（个）] , " & vbCrLf)
            strSql.Append("         采购.计划采购重量 AS [计划采购重量（kg）] , " & vbCrLf)
            strSql.Append("         采购.实际采购重量 AS [实际采购重量（kg）] , " & vbCrLf)
            strSql.Append("         采购.含税单价 , " & vbCrLf)
            strSql.Append("         采购.含税总金额 , " & vbCrLf)
            strSql.Append("         采购.未税单价 , " & vbCrLf)
            strSql.Append("         采购.未税总金额 , " & vbCrLf)
            strSql.Append("         SUM(B原材料库存表.库存数量) 已入库数量 , " & vbCrLf)
            strSql.Append("         采购.币种 , " & vbCrLf)
            strSql.Append("         采购.供货日期 , " & vbCrLf)
            strSql.Append("         VM供货方式.名称 供货方式 , " & vbCrLf)
            strSql.Append("         采购.备注 " & vbCrLf)
            strSql.Append(" FROM    B原材料采购管理 采购 " & vbCrLf)
            strSql.Append("         LEFT JOIN T图纸管理 图纸 ON 采购.分图号 = 图纸.产品图号 " & vbCrLf)
            strSql.Append("                               AND 图纸.主图号 = 采购.主图号 " & vbCrLf)
            strSql.Append("                               AND 采购.上级图号 = 图纸.上级图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN M原材料信息 ON M原材料信息.原材料编号 = 采购.材料编号 " & vbCrLf)
            strSql.Append("         LEFT JOIN B订单管理 ON B订单管理.订单编号 = 采购.订单编号 " & vbCrLf)
            strSql.Append("                            AND B订单管理.产品图号 = 采购.主图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN B原材料入库申请 ON B原材料入库申请.材料编号 = 采购.材料编号 " & vbCrLf)
            strSql.Append("                               AND B原材料入库申请.采购单编号 = 采购.采购单编号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.B原材料库存表 ON B原材料库存表.材料编号 = B原材料入库申请.材料编号 " & vbCrLf)
            strSql.Append("                                  AND B原材料库存表.批次号 = B原材料入库申请.批次号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材料区分 ON VM材料区分.区分 = M原材料信息.原材料区分 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材质 b ON b.区分 = M原材料信息.材质 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材质 a ON a.区分 = M原材料信息.材质 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM材料种类 ON VM材料种类.区分 = M原材料信息.材料种类 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.VM供货方式 ON VM供货方式.区分 = 采购.供货方式 " & vbCrLf)
            strSql.Append(" WHERE   1 = 1 " & vbCrLf)
            If Not String.IsNullOrEmpty(cls采购表T.采购单编号) Then
                strSql.Append("     AND 采购.采购单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls采购表T.原材料编号) Then
                strSql.Append("     AND 采购.材料编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.原材料编号))
            End If
            'If Not String.IsNullOrEmpty(cls采购表T.客户编号) Then
            '    strSql.Append("     AND 采购.客户编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.客户编号))
            'End If
            If Not String.IsNullOrEmpty(cls采购表T.供应商编号) Then
                strSql.Append("     AND 采购.供应商编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.供应商编号))
            End If
            If Not String.IsNullOrEmpty(cls采购表T.订单编号) Then
                strSql.Append("     AND 采购.订单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls采购表T.材料区分) Then
                strSql.Append("     AND M原材料信息.原材料区分= " & Utility.PFn_ChangeQuotation(cls采购表T.材料区分))
            End If
            If (cls采购表T.供货日期 <> "1900/1/1") Then
                strSql.Append(" AND 采购.供货日期 >=" & Utility.PFn_ChangeQuotation(cls采购表T.供货日期) & vbCrLf)
            End If
            If (cls采购表T.供货日期2 <> "1900/1/1") Then
                strSql.Append(" AND 采购.供货日期 <" & Utility.PFn_ChangeQuotation(CDate(cls采购表T.供货日期2).AddDays(1)) & vbCrLf)
            End If
            strSql.Append("GROUP BY 采购.采购单编号 , " & vbCrLf)
            strSql.Append("        采购.材料编号 , " & vbCrLf)
            strSql.Append("        CASE WHEN dbo.VM材料种类.名称='标准件' THEN 图纸. 品名 ELSE M原材料信息.原材料名称 END , " & vbCrLf)
            strSql.Append("        CASE WHEN dbo.VM材料种类.名称='标准件' THEN dbo.VM材料种类.名称 ELSE VM材料区分.名称 end , " & vbCrLf)
            strSql.Append("        CASE WHEN dbo.VM材料种类.名称='标准件' THEN a.名称 ELSE b.名称 END, " & vbCrLf)
            strSql.Append("        采购.长 , " & vbCrLf)
            strSql.Append("        采购.宽 , " & vbCrLf)
            strSql.Append("        采购.高 , " & vbCrLf)
            strSql.Append("        采购.订单编号 , " & vbCrLf)
            strSql.Append("        采购.主图号 ," & vbCrLf)
            strSql.Append("        采购.上级图号 ," & vbCrLf)
            strSql.Append("        采购.分图号 , " & vbCrLf)
            strSql.Append("        图纸.品名 , " & vbCrLf)
            strSql.Append("        B订单管理.订单数量 , " & vbCrLf)
            strSql.Append("        采购.计划采购数量 , " & vbCrLf)
            strSql.Append("        采购.实际采购数量 , " & vbCrLf)
            strSql.Append("        采购.计划采购重量 , " & vbCrLf)
            strSql.Append("        采购.实际采购重量 , " & vbCrLf)
            strSql.Append("        采购.含税单价 , " & vbCrLf)
            strSql.Append("        采购.含税总金额 , " & vbCrLf)
            strSql.Append("        采购.未税单价 , " & vbCrLf)
            strSql.Append("        采购.未税总金额 , " & vbCrLf)
            strSql.Append("        采购.币种 , " & vbCrLf)
            strSql.Append("        采购.供货日期 , " & vbCrLf)
            strSql.Append("        VM供货方式.名称 , " & vbCrLf)
            strSql.Append("        采购.备注 " & vbCrLf)
            strSql.Append("ORDER BY 采购.采购单编号  " & vbCrLf)





            'strSql.Append("SELECT  distinct 采购.采购单编号 , " & vbCrLf)
            'strSql.Append("        采购.材料编号 , " & vbCrLf)
            'strSql.Append("        M原材料信息.原材料名称 AS 材料名称 , " & vbCrLf)
            'strSql.Append("        VM材料区分.名称 材料区分 , " & vbCrLf)
            'strSql.Append("        VM材质.名称 AS 材质 , " & vbCrLf)

            'strSql.Append("        M原材料信息.长 , " & vbCrLf)
            'strSql.Append("        M原材料信息.宽 AS [宽（直径）] , " & vbCrLf)
            'strSql.Append("        M原材料信息.高 AS [高（厚度）] , " & vbCrLf)
            'strSql.Append("        采购.订单编号 , " & vbCrLf)
            'strSql.Append("        采购.分图号 , " & vbCrLf)
            'strSql.Append("        图纸.品名 AS 产品名称 , " & vbCrLf)
            'strSql.Append("        B订单管理.订单数量 AS 订单数量 , " & vbCrLf)
            'strSql.Append("        采购.计划采购数量 AS [计划采购数量（个）] , " & vbCrLf)
            'strSql.Append("        采购.实际采购数量 AS [实际采购数量（个）] , " & vbCrLf)
            'strSql.Append("        采购.计划采购重量 AS [计划采购重量（kg）] , " & vbCrLf)
            'strSql.Append("        采购.实际采购重量 AS [实际采购重量（kg）] , " & vbCrLf)
            'strSql.Append("        采购.含税单价 , " & vbCrLf)
            'strSql.Append("        采购.含税总金额 , " & vbCrLf)
            'strSql.Append("        采购.未税单价 , " & vbCrLf)
            'strSql.Append("        采购.未税总金额 , " & vbCrLf)
            'strSql.Append("        B原材料库存表.库存数量 已入库数量 ," & vbCrLf)
            'strSql.Append("         采购.币种 , " & vbCrLf)
            'strSql.Append("        采购.供货日期 , " & vbCrLf)
            'strSql.Append("        采购.供货方式 , " & vbCrLf)
            'strSql.Append("        采购.备注  " & vbCrLf)
            ''strSql.Append("        采购.采购单编号CD , " & vbCrLf)
            ''strSql.Append("        采购.单价修改状态 " & vbCrLf)
            'strSql.Append("FROM    B原材料采购管理 采购 " & vbCrLf)
            'strSql.Append("        LEFT JOIN T图纸管理 图纸 ON 采购.分图号 = 图纸.产品图号 " & vbCrLf)
            'strSql.Append("        LEFT JOIN M原材料信息 ON M原材料信息.原材料编号 = 采购.材料编号 " & vbCrLf)
            'strSql.Append("        LEFT JOIN B订单管理 ON B订单管理.订单编号 = 采购.订单编号 AND B订单管理.产品图号 = 采购.主图号 " & vbCrLf)
            'strSql.Append("        LEFT JOIN B原材料入库申请 ON B原材料入库申请.材料编号 = 采购.材料编号 AND B原材料入库申请.采购单编号 = 采购.采购单编号 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.B原材料库存表 ON B原材料库存表.材料编号 = B原材料入库申请.材料编号 AND B原材料库存表.批次号 = B原材料入库申请.批次号 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.VM材料区分 ON VM材料区分.区分= M原材料信息.原材料区分 " & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.VM材质 ON VM材质.区分= M原材料信息.材质 " & vbCrLf)
            'strSql.Append("WHERE   1 = 1 " & vbCrLf)
            'If Not String.IsNullOrEmpty(cls采购表T.采购单编号) Then
            '    strSql.Append("     AND 采购.采购单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.采购单编号, True) & "%'")
            'End If
            'If Not String.IsNullOrEmpty(cls采购表T.原材料编号) Then
            '    strSql.Append("     AND 采购.材料编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.原材料编号))
            'End If
            ''If Not String.IsNullOrEmpty(cls采购表T.客户编号) Then
            ''    strSql.Append("     AND 采购.客户编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.客户编号))
            ''End If
            'If Not String.IsNullOrEmpty(cls采购表T.供应商编号) Then
            '    strSql.Append("     AND 采购.供应商编号 =" & Utility.PFn_ChangeQuotation(cls采购表T.供应商编号))
            'End If
            'If Not String.IsNullOrEmpty(cls采购表T.订单编号) Then
            '    strSql.Append("     AND 采购.订单编号 LIKE '" & Utility.PFn_ChangeQuotation(cls采购表T.订单编号, True) & "%'")
            'End If
            'If Not String.IsNullOrEmpty(cls采购表T.材料区分) Then
            '    strSql.Append("     AND M原材料信息.原材料区分= " & Utility.PFn_ChangeQuotation(cls采购表T.材料区分))
            'End If
            'If (cls采购表T.供货日期 <> "1900/1/1") Then
            '    strSql.Append(" AND 采购.供货日期 >=" & Utility.PFn_ChangeQuotation(cls采购表T.供货日期) & vbCrLf)
            'End If
            'If (cls采购表T.供货日期2 <> "1900/1/1") Then
            '    strSql.Append(" AND 采购.供货日期 <" & Utility.PFn_ChangeQuotation(CDate(cls采购表T.供货日期2).AddDays(1)) & vbCrLf)
            'End If
            'strSql.Append("ORDER BY 采购.采购单编号" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "ReportViewr"

    Public Function ReportViewr(ByVal cls采购表T As B原材料采购管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            'strSql.Append("SELECT DISTINCT")
            'strSql.Append("        T图纸管理.品名 ,")
            'strSql.Append("        B订单管理.型号 ,")
            'strSql.Append("        B订单管理.品种规格 ,")
            'strSql.Append("        '' 执行标准 ,")
            'strSql.Append("        '' 类别 ,")
            'strSql.Append("        计划采购数量 ,")
            'strSql.Append("        计划采购重量 ,")
            'strSql.Append("        B原材料采购管理.含税单价 ,")
            'strSql.Append("        B原材料采购管理.含税总金额 ,")
            'strSql.Append("        供货日期 ,")
            'strSql.Append("        M供应商管理.供应商名称" & vbCrLf)
            'strSql.Append("FROM    dbo.B原材料采购管理" & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.B订单管理 ON B订单管理.订单编号 = B原材料采购管理.订单编号" & vbCrLf)
            'strSql.Append("                               AND B订单管理.产品图号 = B原材料采购管理.主图号" & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = B原材料采购管理.分图号" & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.M供应商管理 ON M供应商管理.供应商编号 = B原材料采购管理.供应商编号" & vbCrLf)
            strSql.Append("SELECT DISTINCT " & vbCrLf)
            strSql.Append("        CASE WHEN dbo.VM材料种类.名称='标准件' THEN dbo.T图纸管理.品名 ELSE 原材料.原材料名称 END 品名 ," & vbCrLf)
            strSql.Append("        CASE WHEN dbo.VM材料种类.名称='标准件' THEN dbo.T图纸管理.材质 ELSE 原材料.材质 END 型号 ," & vbCrLf)
            strSql.Append("        MAX(CONVERT(VARCHAR(20), B原材料采购管理.长) + '*' + CONVERT(VARCHAR(20), B原材料采购管理.宽) " & vbCrLf)
            strSql.Append("            + '*' + CONVERT(VARCHAR(20), B原材料采购管理.高)) 品种规格 , " & vbCrLf)
            strSql.Append("        '' 执行标准 , " & vbCrLf)
            strSql.Append("        CASE WHEN dbo.VM材料种类.名称='标准件' THEN dbo.VM材料种类.名称 ELSE 原材料.材料种类 END 类别 ," & vbCrLf)
            strSql.Append("        SUM(实际采购数量) 实际采购数量 , " & vbCrLf)
            strSql.Append("        SUM(实际采购重量) 实际采购重量 , " & vbCrLf)
            strSql.Append("        CONVERT(DECIMAL(18, 0),MAX(B原材料采购管理.含税单价)) 含税单价 , " & vbCrLf)
            strSql.Append("        CONVERT(DECIMAL(18, 0),SUM(B原材料采购管理.含税总金额)) 含税总金额 , " & vbCrLf)
            strSql.Append("        供货日期 , " & vbCrLf)
            strSql.Append("        MAX(M供应商管理.供应商名称) 供应商名称, " & vbCrLf)
            strSql.Append("        B原材料采购管理.备注 " & vbCrLf)
            strSql.Append("FROM    dbo.B原材料采购管理 " & vbCrLf)
            strSql.Append("        LEFT  JOIN dbo.M原材料信息 原材料 ON  B原材料采购管理.材料编号 = 原材料.原材料编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.B订单管理 ON B订单管理.订单编号 = B原材料采购管理.订单编号 " & vbCrLf)
            strSql.Append("                               AND B订单管理.产品图号 = B原材料采购管理.主图号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = B原材料采购管理.分图号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M供应商管理 ON M供应商管理.供应商编号 = B原材料采购管理.供应商编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM材料种类 ON dbo.T图纸管理.材料种类=dbo.VM材料种类.区分 " & vbCrLf)
            strSql.Append("WHERE  " & vbCrLf)
            If Not String.IsNullOrEmpty(cls采购表T.采购单编号) Then
                strSql.Append("     采购单编号 in ('" & cls采购表T.采购单编号 & "')" & vbCrLf)
            End If
            strSql.Append("GROUP BY CASE WHEN dbo.VM材料种类.名称='标准件' THEN dbo.T图纸管理.品名 ELSE 原材料.原材料名称 END  , " & vbCrLf)
            strSql.Append("         CASE WHEN dbo.VM材料种类.名称='标准件' THEN dbo.T图纸管理.材质 ELSE 原材料.材质 END," & vbCrLf)
            strSql.Append("         CASE WHEN dbo.VM材料种类.名称='标准件' THEN dbo.VM材料种类.名称 ELSE 原材料.材料种类 END ," & vbCrLf)
            strSql.Append("        供货日期 ," & vbCrLf)
            strSql.Append("        B原材料采购管理.备注" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "Get重量"

    Public Function Get重量(ByVal str主图号 As String, ByVal str上级图号 As String, ByVal str分图号 As String) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT 单件重量 FROM T图纸管理 WHERE 主图号='" & str主图号 & "' AND 上级图号='" & str上级图号 & "'AND 产品图号='" & str上级图号 & "'")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
End Class
