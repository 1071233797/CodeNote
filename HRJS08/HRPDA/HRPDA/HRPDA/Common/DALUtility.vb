Imports System.Data

Public Class DALUtility



#Region " 登录"


    Public Shared Function F登录(ByVal m As M用户) As String

        Try
            Dim RE As String = String.Empty

            Dim strSql As String = "SELECT 人员编号 from M人员管理 where 人员名='" & m.用户名 & "' and 密码='" & m.密码 & "'"

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            If dt.Rows.Count > 0 Then
                RE = dt.Rows(0)(0).ToString
            End If

            Return RE

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function



#End Region


#Region " 原材料"


    Public Shared Function select原材料入库申请(ByVal m As M原材料入库申请) As DataTable
        Try

            Dim strSql As String = " SELECT  [申请单编号]"
            strSql += " ,[材料编号]"
            strSql += " ,[批次号]"
            strSql += " ,[入库数量]"
            strSql += ",[入库重量]"

            strSql += " FROM [B原材料入库申请] where 申请单编号='" + m.申请单编号 + "' and  材料编号='" + m.材料编号 + "' and 批次号='" + m.批次号 + "'"
            
            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Shared Function select原材料出库申请(ByVal m As M原材料出库申请) As DataTable
        Try

            Dim strSql As String = " SELECT  [申请单编号]"
            strSql += " ,[材料编号]"
            strSql += " ,[领料数量]"
            strSql += ",[领料重量]"

            strSql += " FROM [Z原材料出库申请] where 申请单编号='" + m.申请单编号 + "' and  材料编号='" + m.材料编号 + "'"

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

   

    Public Shared Function select原材料库存(ByVal m As M原材料库存) As DataTable
        Try

            Dim strSql As String = " SELECT  [材料编号]"
            strSql += " ,[批次号],[库存数量],[库存重量]"

            strSql += " FROM [B原材料库存表] where 材料编号='" + m.材料编号 + "' and  批次号='" + m.批次号 + "'"

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Shared Function select原材料名称(ByVal str原材料编号 As String) As String
        Try
            Dim str原材料名称 As String = ""

            Dim strSql As String = " SELECT  [原材料名称]"

            strSql += " FROM [M原材料信息] where 原材料编号='" + str原材料编号 + "'"

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            If dt.Rows.Count > 0 Then
                str原材料名称 = dt.Rows(0)(0).ToString
            End If

            Return str原材料名称

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Shared Function select原材料出库SUM(ByVal m As M原材料出入库记录) As DataTable
        Try

            Dim strSql As String = " SELECT  [材料编号]"

            strSql += ",sum(入出库数量) as 数量"
            strSql += ",sum(入出库重量) as 重量"

            strSql += " FROM [B原材料入出库记录] where 申请单编号='" + m.申请单编号 + "' and 材料编号='" + m.材料编号 + "'  group by 材料编号"

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Shared Function insert原材料(ByVal m1 As M原材料出入库记录, ByVal m2 As M原材料库存) As Boolean
        Try

            Dim value(1) As String
            value(0) = insert原材料入库记录(m1)
            value(1) = insert原材料库存(m2)

            Return Utility.ExceSQL(value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function



    Public Shared Function update原材料(ByVal m1 As M原材料出入库记录, ByVal m2 As M原材料库存) As Boolean
        Try
            Dim value(1) As String
            value(0) = insert原材料入库记录(m1)
            value(1) = update原材料库存(m2)

            Return Utility.ExceSQL(value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function



    Private Shared Function insert原材料入库记录(ByVal m As M原材料出入库记录) As String

        Try

            Dim strSql As String = " INSERT INTO [B原材料入出库记录] "
            strSql += " ([入出库编号]"
            strSql += ",[入出库区分]"
            strSql += ",[申请单编号]"
            strSql += " ,[材料编号]"
            strSql += " ,[批次号]"
            strSql += ",[入出库数量]"
            strSql += ",[入出库重量]"
            strSql += ",[入出库日期]"
            strSql += ",[库存区域]"
            strSql += " ,[操作者编号]"
            strSql += " ,[操作PDA编号]"
            strSql += " ,[备注])"
            strSql += " VALUES("

            strSql += " '" & m.入出库编号 & "'"
            strSql += " ,'" & m.入出库区分 & "'"
            strSql += " ,'" & m.申请单编号 & "'"
            strSql += " ,'" & m.材料编号 & "'"
            strSql += " ,'" & m.批次号 & "'"
            strSql += " ," & m.入出库数量 & ""
            strSql += " ," & m.入出库重量 & ""
            strSql += " ,'" & m.入出库日期 & "'"
            strSql += " ,'" & m.库存区域 & "'"
            strSql += " ,'" & m.操作者编号 & "'"
            strSql += " ,'" & m.操作PDA编号 & "'"
            strSql += " ,'" & m.备注 & "')"



            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Private Shared Function insert原材料库存(ByVal m As M原材料库存) As String

        Try

            Dim strSql As String = "  INSERT INTO [B原材料库存表] "
            strSql += " ([材料编号]"
            strSql += " ,[批次号]"
            strSql += "  ,[库存数量]"
            strSql += "  ,[库存重量]"
            strSql += "  ,[库存区域]"
            strSql += "  ,[入库日期]"
            strSql += "  ,[备注])"
            strSql += "  VALUES"
            strSql += "  ('" & m.材料编号 & "'"
            strSql += "  ,'" & m.批次号 & "'"
            strSql += "  ," & m.库存数量 & ""
            strSql += " ," & m.库存重量 & ""
            strSql += "  ,'" & m.库存区域 & "'"
            strSql += " ,'" & m.入库日期 & "'"
            strSql += "  ,'" & m.备注 & "')"


            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Private Shared Function update原材料库存(ByVal m As M原材料库存) As String

        Try

            Dim strSql As String = " UPDATE [B原材料库存表] SET "

            strSql += " [库存数量] = 库存数量-" + m.库存数量
            strSql += " ,[库存重量] = 库存重量-" + m.库存重量

            strSql += "WHERE 材料编号='" + m.材料编号 + "' and 批次号='" + m.批次号 + "'"

            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Shared Function insert原材料(ByVal m1 As M原材料盘点) As Boolean
        Try
            Dim value(0) As String
            value(0) = insert原材料盘点(m1)
            Return Utility.ExceSQL(value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function

    Private Shared Function insert原材料盘点(ByVal m As M原材料盘点) As String

        Try

            Dim strSql As String = "  INSERT INTO [B原材料库存盘点] "
            strSql += " ([盘点CD]"
            strSql += " ,[材料编号]"
            strSql += " ,[批次号]"
            strSql += "  ,[在库数量]"
            strSql += "  ,[在库重量]"
            strSql += "  ,[盘点数量]"
            strSql += "  ,[盘点重量]"
            strSql += "  ,[盘点人编号]"
            strSql += "  ,[操作PDA]"
            strSql += "  ,[盘点日期]"
            strSql += "  ,[备注])"
            strSql += "  VALUES"
            strSql += "  ('" & m.盘点CD & "'"
            strSql += "  ,'" & m.材料编号 & "'"
            strSql += "  ,'" & m.批次号 & "'"
            strSql += "  ," & m.在库数量 & ""
            strSql += " ," & m.在库重量 & ""
            strSql += "  ," & m.盘点数量 & ""
            strSql += " ," & m.盘点重量 & ""
            strSql += " ,'" & m.盘点人编号 & "'"
            strSql += " ,'" & m.操作PDA & "'"
            strSql += " ,'" & m.盘点日期 & "'"
            strSql += "  ,'" & m.备注 & "')"


            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
#End Region


#Region " 半成品"


    Public Shared Function select半成品入库申请(ByVal m As M半成品入库申请) As DataTable
        Try

            Dim strSql As String = " SELECT [申请单编号]"
            strSql += " ,[订单编号]"
            strSql += ",[主图号]"
            strSql += ",[上级图号]"
            strSql += ",[分图号]"
            strSql += ",[工序编号]"
            strSql += ",[入库数量]"
            strSql += " ,[半成品种类]"

            strSql += "FROM [Z半成品入库申请] where 申请单编号='" + m.申请单编号 + "' and 订单编号='" + m.订单编号 + "' and 主图号='" + m.主图号 + "' and 分图号='" + m.分图号 + "' and 工序编号='" + m.工序编号 + "'"


            If m.上级图号 <> "" Then
                strSql += " and 上级图号='" + m.上级图号 + "'"
            End If

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Shared Function select半成品出库申请(ByVal m As M半成品出库申请) As DataTable
        Try

            Dim strSql As String = " SELECT [申请单编号]"
            strSql += " ,[订单编号]"
            strSql += ",[主图号]"
            strSql += ",[上级图号]"
            strSql += ",[分图号]"
            strSql += ",[工序编号]"
            strSql += ",[出库数量]"
            strSql += " ,[半成品种类]"

            strSql += " FROM [Z半成品出库申请] where 申请单编号='" + m.申请单编号 + "' and 订单编号='" + m.订单编号 + "' and 主图号='" + m.主图号 + "' and 分图号='" + m.分图号 + "' and 工序编号='" + m.工序编号 + "'"

            If m.上级图号 <> "" Then
                strSql += " and 上级图号='" + m.上级图号 + "'"
            End If

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Shared Function select工序名称(ByVal str图号 As String, ByVal str工序编号 As String) As String
        Try
            Dim str工序名称 As String = ""
            Dim strSql As String = " SELECT [工序名称]"
           
            strSql += "FROM [T流转票管理] where 产品图号='" + str图号 + "' and 工序编号='" + str工序编号 + "' "

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            If dt.Rows.Count > 0 Then
                str工序名称 = dt.Rows(0)(0).ToString
            End If

            Return str工序名称

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Shared Function select图名(ByVal str图号 As String) As String
        Try
            Dim str工序名称 As String = ""
            Dim strSql As String = " SELECT [品名]"

            strSql += "FROM [T图纸管理] where 产品图号='" + str图号 + "' "

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            If dt.Rows.Count > 0 Then
                str工序名称 = dt.Rows(0)(0).ToString
            End If

            Return str工序名称

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function



    Public Shared Function select半成品库存(ByVal m As M半成品库存) As DataTable
        Try

            Dim strSql As String = "SELECT  [订单编号]"
            strSql += " ,[主图号]"
            strSql += " ,[上级图号]"
            strSql += "  ,[分图号]"
            strSql += " ,[工序编号]"
            strSql += "  ,[库存数量]"
            strSql += " ,[半成品种类]"
            strSql += " ,[库存区域] "
            strSql += "  FROM [Z半成品库存] where 订单编号='" + m.订单编号 + "' and 主图号='" + m.主图号 + "' and 分图号='" + m.分图号 + "' and 工序编号='" + m.工序编号 + "'"


            If m.上级图号 <> "" Then
                strSql += " and 上级图号='" + m.上级图号 + "'"
            End If

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Shared Function select半成品出库SUM(ByVal m As M半成品出入库记录) As DataTable
        Try

            Dim strSql As String = " select 订单编号,主图号,分图号,工序编号,sum(数量) as 数量 "

            strSql += " from Z半成品入出库记录 where 申请单编号='" + m.申请单编号 + "' and 订单编号='" + m.订单编号 + "' "
            strSql += " and 主图号='" + m.主图号 + "' and 分图号='" + m.分图号 + "' and 工序编号='" + m.工序编号 + "' "

            If m.上级图号 <> "" Then
                strSql += " and 上级图号='" + m.上级图号 + "'"
            End If

            strSql += " group by 订单编号,主图号,分图号,工序编号"

            If m.上级图号 <> "" Then
                strSql += ",上级图号"
            End If


            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Shared Function insert半成品(ByVal m1 As M半成品出入库记录, ByVal m2 As M半成品库存) As Boolean
        Try
            Dim value(1) As String
            value(0) = insert半成品入库记录(m1)
            value(1) = insert半成品库存(m2)

            Return Utility.ExceSQL(value)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function



    Public Shared Function update半成品(ByVal m1 As M半成品出入库记录, ByVal m2 As M半成品库存) As Boolean
        Try
            Dim value(1) As String
            value(0) = insert半成品入库记录(m1)
            value(1) = update半成品库存(m2)

            Return Utility.ExceSQL(value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function



    Private Shared Function insert半成品入库记录(ByVal m As M半成品出入库记录) As String

        Try

            Dim strSql As String = " INSERT INTO [Z半成品入出库记录]"
            strSql += " ([入出库记录CD]"
            strSql += " ,[申请单编号]"
            strSql += " ,[订单编号]"
            strSql += " ,[主图号]"
            strSql += " ,[上级图号]"
            strSql += " ,[分图号]"
            strSql += ",[工序编号]"
            strSql += " ,[入出库区分]"
            strSql += ",[数量]"
            strSql += " ,[入出库日期]"
            strSql += " ,[操作者编号])"
            strSql += " VALUES "
            strSql += " ('" + m.入出库记录CD + "'"
            strSql += " ,'" + m.申请单编号 + "'"
            strSql += " ,'" + m.订单编号 + "'"
            strSql += " ,'" + m.主图号 + "'"
            strSql += " ,'" + m.上级图号 + "'"
            strSql += " ,'" + m.分图号 + "'"
            strSql += " ,'" + m.工序编号 + "'"
            strSql += " ,'" + m.入出库区分 + "'"
            strSql += " ," + m.数量 + ""
            strSql += " ,'" + m.入出库日期 + "'"
            strSql += ",'" + m.操作者编号 + "')"

            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Private Shared Function insert半成品库存(ByVal m As M半成品库存) As String

        Try

            Dim strSql As String = " INSERT INTO [Z半成品库存]"
            strSql += " ([订单编号]"
            strSql += ",[主图号]"
            strSql += ",[上级图号]"
            strSql += ",[分图号]"
            strSql += ",[工序编号]"
            strSql += ",[库存数量]"
            strSql += ",[半成品种类]"
            strSql += " ,[库存区域])"
            strSql += " VALUES "
            strSql += " ('" + m.订单编号 + "'"
            strSql += " ,'" + m.主图号 + "'"
            strSql += " ,'" + m.上级图号 + "'"
            strSql += ",'" + m.分图号 + "'"
            strSql += " ,'" + m.工序编号 + "'"
            strSql += " ," + m.库存数量 + ""
            strSql += " ,'" + m.半成品种类 + "'"
            strSql += ",'" + m.库存区域 + "')"

            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Private Shared Function update半成品库存(ByVal m As M半成品库存) As String

        Try

            Dim strSql As String = " UPDATE [Z半成品库存] SET "

            strSql += " [库存数量] = 库存数量-" + m.库存数量

            strSql += "WHERE 订单编号='" + m.订单编号 + "' "
            strSql += " and 主图号='" + m.主图号 + "' and 分图号='" + m.分图号 + "' and 工序编号='" + m.工序编号 + "' "


            If m.上级图号 <> "" Then
                strSql += " and 上级图号='" + m.上级图号 + "'"
            End If

            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Shared Function insert半成品(ByVal m1 As M半成品盘点) As Boolean
        Try
            Dim value(0) As String
            value(0) = insert半成品盘点(m1)

            Return Utility.ExceSQL(value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Shared Function insert半成品盘点(ByVal m As M半成品盘点) As String

        Try

            Dim strSql As String = "  INSERT INTO [B半成品库存盘点] "
            strSql += " ([盘点CD]"
            strSql += ",[订单编号]"
            strSql += ",[主图号]"
            strSql += ",[上级图号]"
            strSql += ",[分图号]"
            strSql += ",[工序编号]"
            strSql += ",[盘点日期]"
            strSql += ",[盘点人编号]"
            strSql += ",[在库数量]"
            strSql += ",[盘点数量])"
            strSql += "  VALUES"
            strSql += " ('" & m.盘点CD & "'"
            strSql += ",'" & m.订单编号 & "'"
            strSql += ",'" & m.主图号 & "'"
            strSql += ",'" & m.上级图号 & "'"
            strSql += ",'" & m.分图号 & "'"
            strSql += ",'" & m.工序编号 & "'"
            strSql += ",'" & m.盘点日期 & "'"
            strSql += ",'" & m.盘点人编号 & "'"
            strSql += "," & m.在库数量 & ""
            strSql += "," & m.盘点数量 & ")"

            Return strSql


           


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


#End Region


#Region " 成品"


    Public Shared Function select产成品入库申请(ByVal m As M产成品入库申请) As DataTable
        Try

            Dim strSql As String = " SELECT [申请单编号]"

            strSql += " ,[订单编号]"
            strSql += " ,[产品图号]"
            strSql += ",[入库数量]"
            strSql += ",[入库重量]"


            strSql += "FROM [Z成品入库申请] where 申请单编号='" + m.申请单编号 + "' and 订单编号='" + m.订单编号 + "' and 产品图号='" + m.产品图号 + "'"

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Shared Function select产成品出库申请(ByVal m As M产成品出库申请) As DataTable
        Try

            Dim strSql As String = " SELECT [出荷指示编号]"
            strSql += " ,[订单编号]"
            strSql += ",[产品图号]"
            strSql += ",[出荷数量]"

            strSql += " FROM [B出荷指示] where 出荷指示编号='" + m.出荷指示编号 + "' and 订单编号='" + m.订单编号 + "' and 产品图号='" + m.产品图号 + "'"


            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function



    Public Shared Function select产成品库存(ByVal m As M产成品库存) As DataTable
        Try

            Dim strSql As String = "SELECT  [产品图号]"
            strSql += " ,[订单编号]"
            strSql += " ,[库存数量]"
            strSql += ",[库存重量]"
            strSql += ",[库存状态]"
            strSql += ",[库存区域]"
            strSql += ",[入库日期]"

            strSql += "  FROM [B成品库存表] where 订单编号='" + m.订单编号 + "' and 产品图号='" + m.产品图号 + "'"

            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Shared Function select产成品出库SUM(ByVal m As M产成品出入库记录) As DataTable
        Try

            Dim strSql As String = " select 订单编号,产品图号,sum(入出库数量) as 数量 ,sum(入出库重量) as 重量 "

            strSql += " from B成品入出库记录 where "
            strSql += " 申请单编号='" + m.申请单编号 + "' and 产品图号='" + m.产品图号 + "'  and 订单编号='" + m.订单编号 + "' "

            strSql += " group by 订单编号,产品图号"


            Dim dt As DataTable = Utility.ServerSelect(strSql)

            Return dt

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Shared Function insert产成品(ByVal m1 As M产成品出入库记录, ByVal m2 As M产成品库存) As Boolean
        Try
            Dim value(1) As String
            value(0) = insert产成品入库记录(m1)
            value(1) = insert产成品库存(m2)

            Return Utility.ExceSQL(value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function



    Public Shared Function update产成品(ByVal m1 As M产成品出入库记录, ByVal m2 As M产成品库存) As Boolean
        Try
            Dim value(1) As String
            value(0) = insert产成品入库记录(m1)
            value(1) = update产成品库存(m2)

            Return Utility.ExceSQL(value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function



    Private Shared Function insert产成品入库记录(ByVal m As M产成品出入库记录) As String

        Try

            Dim strSql As String = " INSERT INTO [B成品入出库记录]"
            strSql += " ([入出库记录CD]"
            strSql += " ,[入出库区分]"
            strSql += ",[申请单编号]"
            strSql += ",[订单编号]"
            strSql += ",[产品图号]"
            strSql += ",[库存状态]"
            strSql += " ,[入出库数量]"
            strSql += ",[入出库重量]"
            strSql += ",[入出库日期]"
            strSql += ",[库存区域]"
            strSql += ",[操作者]"
            strSql += ",[操作PDA]"
            strSql += ",[备注])"
            strSql += " VALUES "
            strSql += "('" + m.入出库记录CD + "'"
            strSql += " ,'" + m.入出库区分 + "'"
            strSql += " ,'" + m.申请单编号 + "'"
            strSql += " ,'" + m.订单编号 + "'"
            strSql += " ,'" + m.产品图号 + "'"
            strSql += " ,'" + m.库存状态 + "'"
            strSql += " ," + m.入出库数量 + ""
            strSql += " ," + m.入出库重量 + ""
            strSql += ",'" + m.入出库日期 + "'"
            strSql += ",'" + m.库存区域 + "'"
            strSql += ",'" + m.操作者 + "'"
            strSql += ",'" + m.操作PDA + "'"
            strSql += " ,'" + m.备注 + "')"

            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Private Shared Function insert产成品库存(ByVal m As M产成品库存) As String

        Try

            Dim strSql As String = " INSERT INTO [B成品库存表]"
            strSql += " ([产品图号]"
            strSql += ",[订单编号]"
            strSql += ",[库存数量]"
            strSql += ",[库存重量]"
            strSql += ",[库存状态]"
            strSql += ",[库存区域]"
            strSql += ",[入库日期])"
            strSql += " VALUES "
            strSql += "('" + m.产品图号 + "'"
            strSql += " ,'" + m.订单编号 + "'"
            strSql += "," + m.库存数量 + ""
            strSql += "," + m.库存重量 + ""
            strSql += ",'" + m.库存状态 + "'"
            strSql += " ,'" + m.库存区域 + "'"
            strSql += ",'" + m.入库日期 + "')"

            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Private Shared Function update产成品库存(ByVal m As M产成品库存) As String

        Try

            Dim strSql As String = " UPDATE [B成品库存表] SET "

            strSql += " [库存数量] = 库存数量-" + m.库存数量

            strSql += ", [库存重量] = 库存重量-" + m.库存重量

            strSql += " WHERE 订单编号='" + m.订单编号 + "' "
            strSql += " and 产品图号='" + m.产品图号 + "' "

            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Shared Function insert产成品(ByVal m1 As M产成品盘点) As Boolean
        Try
            Dim value(0) As String
            value(0) = insert产成品盘点(m1)
            MsgBox(value(0))
            Return Utility.ExceSQL(value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Shared Function insert产成品盘点(ByVal m As M产成品盘点) As String

        Try

            Dim strSql As String = "INSERT INTO [B成品库存盘点]"
            strSql += "([盘点CD]"
            strSql += " ,[订单编号]"
            strSql += ",[产品图号]"
            strSql += ",[盘点日期]"
            strSql += ",[盘点人编号]"
            strSql += ",[盘点数量]"
            strSql += ",[盘点重量]"
            strSql += ",[在库数量]"
            strSql += ",[在库重量])"
            strSql += " VALUES "
            strSql += "('" + m.盘点CD + "'"
            strSql += " ,'" + m.订单编号 + "'"
            strSql += ",'" + m.产品图号 + "'"
            strSql += " ,'" + m.盘点日期 + "'"
            strSql += ",'" + m.盘点人编号 + "'"
            strSql += " ," + m.盘点数量 + ""
            strSql += " ," + m.盘点重量 + ""
            strSql += " ," + m.在库数量 + ""
            strSql += " ," + m.在库重量 + ""
            strSql += ")"

            Return strSql

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


#End Region

End Class
