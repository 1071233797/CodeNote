Imports System.Text

Public Class DalM生产计划制定T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO dbo.Z生产计划制定 " & vbCrLf)
            strSql.Append("         ( 订单编号 , " & vbCrLf)
            strSql.Append("           产品图号 , " & vbCrLf)
            strSql.Append("           投产数量 , " & vbCrLf)
            strSql.Append("           总件完成期限 , " & vbCrLf)
            strSql.Append("           小件完成期限 , " & vbCrLf)
            strSql.Append("           下达日期 , " & vbCrLf)
            strSql.Append("           作业者编号  " & vbCrLf)

            strSql.Append("         ) " & vbCrLf)
            strSql.Append(" VALUES  ( N'" & objM生产计划T.订单编号 & "' ," & vbCrLf)
            strSql.Append("           N'" & objM生产计划T.主图号 & "' ," & vbCrLf)
            strSql.Append("           N'" & objM生产计划T.投产数量 & "' ," & vbCrLf)
            strSql.Append("           N'" & objM生产计划T.总件完成期限 & "' ," & vbCrLf)
            strSql.Append("           N'" & objM生产计划T.小件完成期限 & "' ," & vbCrLf)
            strSql.Append("           N'" & objM生产计划T.下达日期 & "' ," & vbCrLf)
            strSql.Append("           N'" & objM生产计划T.作业者 & "' " & vbCrLf)
            strSql.Append("         ) " & vbCrLf)



            'strSql.Append("INSERT INTO Z生产计划制定")
            'strSql.Append("        ( 是否整体外协加工 ,")
            'strSql.Append("          订单编号 ,")
            'strSql.Append("          完成期限 ,")
            'strSql.Append("          下达日期 ,")
            'strSql.Append("          投产数量 ,")
            'strSql.Append("          是否外协加工 ,")
            'strSql.Append("          外协数量 ,")
            'strSql.Append("          合格标准 ,")
            'strSql.Append("          产品备注 ,")
            'strSql.Append("          登陆者 ,")
            'strSql.Append("          登陆日期 ,")
            'strSql.Append("          主图号 ,")
            'strSql.Append("          分图号 ,")
            'strSql.Append("          上级图号 ,")
            'strSql.Append("          工序编号 ,")
            'strSql.Append("          外协理由 ,")
            ''strSql.Append("          起始日 ,")
            ''strSql.Append("          完成日 ,")
            'strSql.Append("          作业者编号 ,")
            'strSql.Append("          工序备注")
            'strSql.Append("        )")
            'strSql.Append("         SELECT DISTINCT" & vbCrLf)
            'strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.是否整体外协加工) & vbCrLf)
            'strSql.Append(" 是否整体外协加工 ,")
            'strSql.Append("                订单编号 ,")
            'If ojbM生产计划T.主图号 = ojbM生产计划T.分图号 Then
            '    strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.总件完成期限) & vbCrLf)
            'Else
            '    strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.小件完成期限) & vbCrLf)
            'End If
            'strSql.Append("                完成期限,")
            'strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.下达日期) & vbCrLf)
            'strSql.Append("                下达日期 ,")
            'strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.投产数量) & vbCrLf)
            'strSql.Append("                投产数量 ,")
            'If ojbM生产计划T.是否整体外协加工 = True Then
            '    strSql.Append("                'True' ,")
            'Else
            '    strSql.Append("                'False' ,")
            'End If
            'If ojbM生产计划T.是否整体外协加工 = True Then
            '    strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.投产数量) & vbCrLf)
            'Else
            '    strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.外协数量) & vbCrLf)
            'End If
            'strSql.Append("                 外协数量 ,")
            'strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.合格标准) & vbCrLf)
            'strSql.Append("                 合格标准 ,")
            'strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.备注) & vbCrLf)
            'strSql.Append("                产品备注,")
            'strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.登陆者) & vbCrLf)
            'strSql.Append("                登陆者,")
            'strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.登陆日期) & vbCrLf)
            'strSql.Append("                登陆日期  ,")
            'strSql.Append("                B订单管理.产品图号 主图号,")
            'strSql.Append("                分图关系.产品图号 分图号,")
            'If ojbM生产计划T.上级图号 = "" Then
            '    strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.主图号) & vbCrLf)
            '    strSql.Append("                上级图号,")
            'Else
            '    strSql.Append(Utility.PFn_ChangeQuotation(ojbM生产计划T.上级图号) & vbCrLf)
            '    strSql.Append("                上级图号,")
            'End If
            'strSql.Append("                    工序编号 ,")
            'strSql.Append("                '' 外协理由 ,")
            'strSql.Append("                '' 作业者编号 ,")
            'strSql.Append("                '' 工序备注" & vbCrLf)
            'strSql.Append("        FROM    dbo.B订单管理" & vbCrLf)
            'strSql.Append("        INNER JOIN dbo.T图纸关系 ON	B订单管理.产品图号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.主图号) & vbCrLf)
            'strSql.Append("          AND CIID=0" & vbCrLf)
            'strSql.Append("        INNER JOIN dbo.T图纸关系 分图关系 ON 分图关系.关系ID = T图纸关系.关系ID" & vbCrLf)
            'strSql.Append("        LEFT JOIN dbo.T图纸关系 上级关系 ON 上级关系.ID = 分图关系.CIID" & vbCrLf)
            'strSql.Append("        INNER JOIN dbo.T图纸管理 ON 主图号 = T图纸关系.产品图号" & vbCrLf)
            'strSql.Append("                                AND ( 上级关系.产品图号 = 上级图号" & vbCrLf)
            'strSql.Append("                                      OR 上级关系.产品图号 IS NULL" & vbCrLf)
            'strSql.Append("                                    )" & vbCrLf)
            'strSql.Append("                                AND T图纸管理.产品图号 = 分图关系.产品图号" & vbCrLf)
            'strSql.Append("        INNER JOIN dbo.T流转票管理 ON T流转票管理.产品图号 = 分图关系.产品图号" & vbCrLf)
            'strSql.Append("        WHERE  订单编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            'strSql.Append("         AND 分图关系.产品图号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.分图号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update订单 "

    '数据更新操作
    Public Function Update订单(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文



        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       B订单管理 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)
            strSQL.Append("订单状态='2'")
            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("       订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号))
            strSQL.Append("AND 订单状态='1'")
            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Update产品"

    '数据更新操作
    Public Function Update产品(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文
        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       Z生产计划制定 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)
            If ojbM生产计划T.投产数量 = "" Then
                strSQL.Append("投产数量 = NULL")
            Else
                strSQL.Append(" 投产数量 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.投产数量) & vbCrLf)
            End If
            If ojbM生产计划T.总件完成期限 = "" Then
                strSQL.Append(",总件完成期限 = NULL")
            Else
                strSQL.Append(" ,总件完成期限 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.总件完成期限) & vbCrLf)
            End If
            If ojbM生产计划T.小件完成期限 = "" Then
                strSQL.Append(",小件完成期限 = NULL")
            Else
                strSQL.Append(" ,小件完成期限 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.小件完成期限) & vbCrLf)
            End If
            If ojbM生产计划T.下达日期 = "" Then
                strSQL.Append(",下达日期 = NULL")
            Else
                strSQL.Append(" ,下达日期 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.下达日期) & vbCrLf)
            End If

            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("       订单编号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号))
            strSQL.AppendFormat("    AND   产品图号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.主图号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Update工序"

    '数据更新操作
    Public Function Update工序(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文



        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       Z生产计划制定 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)
            If ojbM生产计划T.工序编号 = "" Then
                strSQL.Append("工序编号 = NULL")
            Else
                strSQL.Append(" 工序编号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.工序编号) & vbCrLf)
            End If
            If ojbM生产计划T.是否外协加工 = "" Then
                strSQL.Append(",是否外协加工 = NULL")
            Else
                strSQL.Append(" ,是否外协加工 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.是否外协加工) & vbCrLf)
            End If
            If ojbM生产计划T.外协数量 = "" Then
                strSQL.Append(",外协数量 = NULL")
            Else
                strSQL.Append(" ,外协数量 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.外协数量) & vbCrLf)
            End If
            'If ojbM生产计划T.起始日 = "" Then
            '    strSQL.Append(",起始日 = NULL")
            'Else
            '    strSQL.Append(" ,起始日 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.起始日) & vbCrLf)
            'End If
            'If ojbM生产计划T.完成日 = "" Then
            '    strSQL.Append(",完成日 = NULL")
            'Else
            '    strSQL.Append(" ,完成日 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.完成日) & vbCrLf)
            'End If
            If ojbM生产计划T.外协理由 = "" Then
                strSQL.Append(",外协理由 = NULL")
            Else
                strSQL.Append(" ,外协理由 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.外协理由) & vbCrLf)
            End If


            If ojbM生产计划T.作业者 = "" Then
                strSQL.Append(" ,作业者编号 =NULL ")
            Else
                strSQL.Append(",作业者编号 =" & Utility.PFn_ChangeQuotation(ojbM生产计划T.作业者) & vbCrLf)
            End If


            If ojbM生产计划T.备注 = "" Then
                strSQL.Append(" ,工序备注 = NULL ")
            Else
                strSQL.Append(" ,工序备注 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.备注) & vbCrLf)
            End If

            'strSQL.Append(" ,更新者" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM生产计划T.更新者))
            'strSQL.Append(" ,更新日期" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM生产计划T.更新日期))
            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("       主图号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.主图号))
            strSQL.AppendFormat("    AND   上级图号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.上级图号))
            strSQL.AppendFormat("    AND   分图号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.分图号))
            strSQL.AppendFormat("    AND   工序编号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.工序编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" DELETE FROM Z生产计划制定" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号))

            'SQLに戻る


            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Load"

    '检索全部数据


    Public Function Load(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" *" & vbCrLf)
            strSql.Append(" FROM Z生产计划制定")
            '检索条件 设定
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Load生产计划 "

    '检索全部数据


    Public Function Load生产计划(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 订单编号" & vbCrLf)
            strSql.Append(" FROM Z生产计划制定")
            '检索条件 设定
            strSql.Append(" WHERE 订单编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadSelect "

    '检索全部数据


    Public Function LoadSelect(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("  SELECT  DISTINCT " & vbCrLf)
            strSql.Append("         T图纸管理.产品图号 分图号 , " & vbCrLf)
            strSql.Append("         T图纸管理.品名 , " & vbCrLf)
            strSql.Append("         B订单管理.订单编号 , " & vbCrLf)
            strSql.Append("         B订单管理.订单数量 , " & vbCrLf)
            strSql.Append("         B订单管理.发货日期 , " & vbCrLf)
            strSql.Append("         Z生产计划制定.投产数量 , " & vbCrLf)
            strSql.Append("         Z生产计划制定.总件完成期限 , " & vbCrLf)
            strSql.Append("         Z生产计划制定.小件完成期限 , " & vbCrLf)
            strSql.Append("         Z生产计划制定.下达日期 , " & vbCrLf)
            strSql.Append("         M客户管理.客户名称 , " & vbCrLf)
            strSql.Append("         B订单管理.备注 , " & vbCrLf)
            strSql.Append("         T图纸管理.主图号 , " & vbCrLf)
            strSql.Append("         上级.产品图号 上级图号 " & vbCrLf)
            strSql.Append("  FROM   B订单管理 " & vbCrLf)
            strSql.Append("         LEFT JOIN Z生产计划制定 ON B订单管理.订单编号 = Z生产计划制定.订单编号 " & vbCrLf)
            strSql.Append("                              AND Z生产计划制定.产品图号 = B订单管理.产品图号 " & vbCrLf)
            strSql.Append("         INNER JOIN dbo.T图纸关系 关系 ON 关系.产品图号 = B订单管理.产品图号 " & vbCrLf)
            strSql.Append("                                    AND 关系.CIID = 0 " & vbCrLf)
            strSql.Append("         INNER JOIN T图纸关系 关系1 ON 关系1.关系ID = 关系.关系ID " & vbCrLf)
            strSql.Append("                                 --AND 关系1.产品图号 = Z生产计划制定.分图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.T图纸关系 上级 ON 上级.ID = 关系1.CIID " & vbCrLf)
            strSql.Append("                                   AND 上级.关系ID = 关系.关系ID " & vbCrLf)
            strSql.Append("         INNER  JOIN dbo.T图纸管理 ON Z生产计划制定.产品图号 = T图纸管理.主图号 " & vbCrLf)
            strSql.Append("                                  AND ( 上级.产品图号 = T图纸管理.上级图号 " & vbCrLf)
            strSql.Append("                                        OR 上级.产品图号 IS NULL " & vbCrLf)
            strSql.Append("                                      ) " & vbCrLf)
            strSql.Append("                                  AND T图纸管理.产品图号 = 关系1.产品图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = B订单管理.客户编号 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE  T图纸管理.产品图号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.分图号) & vbCrLf)
            strSql.Append(" AND Z生产计划制定.订单编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            If (ojbM生产计划T.主图号 <> String.Empty) Then
                strSql.Append(" AND T图纸管理.主图号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.主图号) & vbCrLf)
            End If
 
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllHead "

    '检索全部数据


    Public Function LoadAllHead1(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append(" B订单管理.订单编号" & vbCrLf)
            strSql.Append(" ,M客户管理.客户名称" & vbCrLf)
            strSql.Append(" ,B订单管理.发货日期" & vbCrLf)
            strSql.Append(" ,B订单管理.备注" & vbCrLf)
            strSql.Append(" FROM B订单管理")
            strSql.Append(" INNER JOIN M客户管理")
            strSql.Append(" ON B订单管理.客户编号=M客户管理.客户编号")

            '检索条件 设定
            strSql.Append(" WHERE B订单管理.订单编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllHead "

    '检索全部数据


    Public Function LoadAllHead(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append(" B订单管理.订单编号" & vbCrLf)
            strSql.Append(" ,M客户管理.客户名称" & vbCrLf)
            strSql.Append(" ,B订单管理.发货日期" & vbCrLf)
            strSql.Append(" ,完成期限" & vbCrLf)
            strSql.Append(" ,下达日期" & vbCrLf)
            strSql.Append(" ,B订单管理.备注" & vbCrLf)
            'strSql.Append(" ,B订单管理.计划生产数量 投产数量" & vbCrLf)
            strSql.Append(" FROM B订单管理")
            strSql.Append(" LEFT JOIN Z生产计划制定")
            strSql.Append(" ON B订单管理.订单编号=Z生产计划制定.订单编号")
            strSql.Append(" LEFT JOIN M客户管理")
            strSql.Append(" ON B订单管理.客户编号=M客户管理.客户编号")


            '检索条件 设定
            strSql.Append(" WHERE B订单管理.订单编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllGrid "

    '检索全部数据
    Public Function LoadAllGrid(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("  SELECT DISTINCT " & vbCrLf)
            strSql.Append("         订单.产品图号 , " & vbCrLf)
            strSql.Append("         图纸.品名 , " & vbCrLf)
            strSql.Append("         CASE WHEN 订单.产品区分 = 2 THEN '是' " & vbCrLf)
            strSql.Append("              ELSE '否' " & vbCrLf)
            strSql.Append("         END AS 是否为抵补品 , " & vbCrLf)
            strSql.Append("         CASE WHEN T流转票管理.试做品 = 'true' THEN '是' " & vbCrLf)
            strSql.Append("              ELSE '否' " & vbCrLf)
            strSql.Append("         END AS 是否为试做品 , " & vbCrLf)
            strSql.Append("         订单.订单数量 订货量, " & vbCrLf)
            strSql.Append("         ISNULL(计划.投产数量, 0) 投产数量 , " & vbCrLf)
            strSql.Append("         计划.总件完成期限 总件完成期限 , " & vbCrLf)
            strSql.Append("         计划.小件完成期限 小件完成期限 , " & vbCrLf)
            strSql.Append("         订单.发货日期 , " & vbCrLf)
            strSql.Append("         图纸.图纸 " & vbCrLf)
            strSql.Append("  FROM   dbo.B订单管理 订单 " & vbCrLf)
            strSql.Append("         INNER JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = 订单.产品图号 " & vbCrLf)
            strSql.Append("         INNER JOIN dbo.T流转票管理 ON T流转票管理.产品图号 = 订单.产品图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.Z生产计划制定 计划 ON 计划.订单编号 = 订单.订单编号 " & vbCrLf)
            strSql.Append("                                     AND 计划.产品图号 = 订单.产品图号 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 订单.订单编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllGrid1"

    '检索全部数据


    Public Function LoadAllGrid1(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try
            strSql.Append(" SELECT  distinct " & vbCrLf)
            strSql.Append("  T流转票管理.工序名称" & vbCrLf)
            strSql.Append(" ,T流转票管理.加工内容简介" & vbCrLf)
            strSql.Append(" ,T流转票管理.作业场所" & vbCrLf)
            strSql.Append(" ,T流转票管理.设备编号" & vbCrLf)
            strSql.Append(" ,CASE WHEN Z生产计划制定.是否整体外协加工 ='true' THEN 'true' WHEN dbo.Z生产计划制定.是否外协加工 IS NULL THEN 'false' ELSE Z生产计划制定.是否外协加工 END 是否外协加工" & vbCrLf)
            strSql.Append(" ,Z生产计划制定.外协理由" & vbCrLf)
            strSql.Append(" ,  CASE when 外协数量 IS NULL THEN 0 ELSE 外协数量 END 外协数量 " & vbCrLf)
            strSql.Append(" ,CASE  WHEN T流转票管理.组装品='true' then '是' else '否' end as 是否为组装品" & vbCrLf)
            'strSql.Append(",Z生产计划制定.产品起始日" & vbCrLf)
            'strSql.Append(",Z生产计划制定.产品完成日" & vbCrLf)
            strSql.Append(",Z生产计划制定.起始日" & vbCrLf)
            strSql.Append(",Z生产计划制定.完成日" & vbCrLf)
            strSql.Append(",Z生产计划制定.作业者编号" & vbCrLf)
            strSql.Append(" ,M人员管理.人员名 作业者名称" & vbCrLf)
            strSql.Append(" ,Z生产计划制定.工序备注 备注" & vbCrLf)
            strSql.Append(" ,Z生产计划制定.订单编号" & vbCrLf)
            strSql.Append(" ,Z生产计划制定.主图号" & vbCrLf)
            strSql.Append(" ,Z生产计划制定.分图号" & vbCrLf)
            strSql.Append(" ,Z生产计划制定.上级图号" & vbCrLf)
            strSql.Append(" ,T流转票管理.工序编号" & vbCrLf)
            strSql.Append(" ,T流转票管理.产品图号" & vbCrLf)
            strSql.Append(" FROM T流转票管理")
            strSql.Append(" LEFT JOIN  Z生产计划制定 ON T流转票管理.产品图号=Z生产计划制定.分图号")
            strSql.Append(" and  T流转票管理.工序编号=Z生产计划制定.工序编号")
            strSql.Append(" and  Z生产计划制定.订单编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.B订单管理 ON B订单管理.订单编号 = Z生产计划制定.订单编号")
            strSql.Append("                               AND B订单管理.产品图号 = Z生产计划制定.主图号")
            strSql.Append("        LEFT JOIN dbo.T图纸管理 ON T图纸管理.主图号 = Z生产计划制定.主图号")
            strSql.Append("                               AND T图纸管理.上级图号 = Z生产计划制定.上级图号")
            strSql.Append("                               AND T图纸管理.产品图号 = Z生产计划制定.分图号")
            strSql.Append(" LEFT JOIN   M人员管理 ON M人员管理.人员编号=Z生产计划制定.作业者编号")

            '检索条件 设定
            strSql.Append(" WHERE  1=1" & vbCrLf)
            If (ojbM生产计划T.分图号 <> String.Empty) Then
                strSql.Append(" AND T流转票管理.产品图号 in('" & ojbM生产计划T.分图号 & "')" & vbCrLf)
            End If
            'If (ojbM生产计划T.订单编号 <> String.Empty) Then
            '    strSql.Append(" AND Z生产计划制定.订单编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            'End If
            If (ojbM生产计划T.主图号 <> String.Empty) Then
                strSql.Append(" AND Z生产计划制定.主图号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.主图号) & vbCrLf)
            End If
            If (ojbM生产计划T.上级图号 <> String.Empty) Then
                strSql.Append(" AND Z生产计划制定.上级图号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.上级图号) & vbCrLf)
            End If
            'If (ojbM生产计划T.工序编号 <> String.Empty) Then
            '    strSql.Append(" AND T流转票管理.工序编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.工序编号) & vbCrLf)
            'End If
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据


    Public Function LoadByPK(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try

            strSql.Append(" SELECT  订单编号 , " & vbCrLf)
            strSql.Append("         产品图号 , " & vbCrLf)
            strSql.Append("         投产数量 , " & vbCrLf)
            strSql.Append("         总件完成期限 , " & vbCrLf)
            strSql.Append("         小件完成期限 , " & vbCrLf)
            strSql.Append("         下达日期 , " & vbCrLf)
            strSql.Append("         作业者编号 , " & vbCrLf)
            strSql.Append("         登陆者 , " & vbCrLf)
            strSql.Append("         登陆日期 , " & vbCrLf)
            strSql.Append("         更新者 , " & vbCrLf)
            strSql.Append("         更新日期 " & vbCrLf)
            strSql.Append(" FROM    HRJS.dbo.Z生产计划制定 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (ojbM生产计划T.订单编号 <> String.Empty) Then
                strSql.Append(" AND 订单编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            End If
            If (ojbM生产计划T.主图号 <> String.Empty) Then
                strSql.Append(" AND 产品图号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.主图号) & vbCrLf)
            End If

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据


    Public Function LoadByWhere(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append(" 订单编号" & vbCrLf)
            strSql.Append(" ,M客户管理.客户名称" & vbCrLf)
            strSql.Append(" ,完成期限" & vbCrLf)
            strSql.Append(" ,下达日期" & vbCrLf)
            strSql.Append(" FROM Z生产计划制定")
            strSql.Append(" LEFT JOIN M客户管理")
            strSql.Append(" ON M客户管理.客户编号= Z生产计划制定.客户编号")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (ojbM生产计划T.产品状态 = "整体外协") Then
                strSql.Append(" AND Z生产计划制定.是否整体外协加工 = 'true'" & vbCrLf)
            End If
            If (ojbM生产计划T.产品状态 = "抵补品") Then
                strSql.Append(" AND Z生产计划制定.是否抵补品 = 'true'" & vbCrLf)
            End If
            If (ojbM生产计划T.产品状态 = "试做品") Then
                strSql.Append(" AND Z生产计划制定.是否为试做品 = 'true'" & vbCrLf)
            End If
            If (ojbM生产计划T.订单编号 <> String.Empty) Then
                strSql.Append(" AND Z生产计划制定.订单编号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            End If
            If (ojbM生产计划T.完成日1 <> "1900/1/1") Then
                strSql.Append(" AND Z生产计划制定.完成日 >=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.完成日1) & vbCrLf)
            End If

            If (ojbM生产计划T.完成日2 <> "1900/1/1") Then
                strSql.Append(" AND Z生产计划制定.完成日 <" & Utility.PFn_ChangeQuotation(ojbM生产计划T.完成日2) & vbCrLf)
            End If
            If (ojbM生产计划T.客户编号 <> String.Empty) Then
                strSql.Append(" AND M客户管理.客户编号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.客户编号) & vbCrLf)
            End If
            If (ojbM生产计划T.主图号 <> String.Empty) Then
                strSql.Append(" AND Z生产计划制定.主图号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.主图号) & vbCrLf)
            End If
            strSql.Append(" ORDER BY Z生产计划制定.订单编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByWhere2"

    '检索全部数据


    Public Function LoadByWhere2(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("  SELECT DISTINCT " & vbCrLf)
            strSql.Append("         Z生产计划制定.订单编号 , " & vbCrLf)
            strSql.Append("         Z生产计划制定.产品图号 主图号, " & vbCrLf)
            strSql.Append("         上级.产品图号 上级图号 , " & vbCrLf)
            strSql.Append("         T图纸管理.产品图号 分图号 , " & vbCrLf)
            strSql.Append("         品名 , " & vbCrLf)
            strSql.Append("         ISNULL(B订单管理.订单数量, 0) * ISNULL(T图纸管理.数量, 1) AS 订货量 , " & vbCrLf)
            strSql.Append("         ISNULL(Z生产计划制定.投产数量, 0) * ISNULL(T图纸管理.数量, 1) AS 投产数量 , " & vbCrLf)
            strSql.Append("         CASE WHEN B订单管理.产品区分 = 2 THEN '是' " & vbCrLf)
            strSql.Append("              ELSE '否' " & vbCrLf)
            strSql.Append("         END AS 是否为抵补品 , " & vbCrLf)
            strSql.Append("         CASE WHEN T流转票管理.试做品 = 'true' THEN '是' " & vbCrLf)
            strSql.Append("              ELSE '否' " & vbCrLf)
            strSql.Append("         END AS 是否为试做品 , " & vbCrLf)
            strSql.Append("         Z生产计划制定.总件完成期限 , " & vbCrLf)
            strSql.Append("         Z生产计划制定.小件完成期限 , " & vbCrLf)
            strSql.Append("         B订单管理.备注 , " & vbCrLf)
            strSql.Append("         T图纸管理.图纸 " & vbCrLf)
            strSql.Append("  FROM   B订单管理 " & vbCrLf)
            strSql.Append("         LEFT JOIN Z生产计划制定 ON B订单管理.订单编号 = Z生产计划制定.订单编号 " & vbCrLf)
            strSql.Append("                              AND Z生产计划制定.产品图号 = B订单管理.产品图号 " & vbCrLf)
            strSql.Append("         INNER JOIN dbo.T图纸关系 关系 ON 关系.产品图号 = B订单管理.产品图号 " & vbCrLf)
            strSql.Append("                                    AND 关系.CIID = 0 " & vbCrLf)
            strSql.Append("         INNER JOIN T图纸关系 关系1 ON 关系1.关系ID = 关系.关系ID " & vbCrLf)
            strSql.Append("                                 --AND 关系1.产品图号 = Z生产计划制定.分图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.T图纸关系 上级 ON 上级.ID = 关系1.CIID " & vbCrLf)
            strSql.Append("                                   AND 上级.关系ID = 关系.关系ID " & vbCrLf)
            strSql.Append("         INNER  JOIN dbo.T图纸管理 ON Z生产计划制定.产品图号 = T图纸管理.主图号 " & vbCrLf)
            strSql.Append("                                  AND ( 上级.产品图号 = T图纸管理.上级图号 " & vbCrLf)
            strSql.Append("                                        OR 上级.产品图号 IS NULL " & vbCrLf)
            strSql.Append("                                      ) " & vbCrLf)
            strSql.Append("                                  AND T图纸管理.产品图号 = 关系1.产品图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN T流转票管理 ON T流转票管理.产品图号 = T图纸管理.产品图号 " & vbCrLf)
            strSql.Append("  WHERE  1 = 1 " & vbCrLf)
            'If (ojbM生产计划T.产品状态 = "整体外协") Then
            '    strSql.Append(" AND Z生产计划制定.是否整体外协加工 = 'true'" & vbCrLf)
            'End If
            If (ojbM生产计划T.产品状态 = "抵补品") Then
                strSql.Append(" AND B订单管理.产品区分 = '2'" & vbCrLf)
            End If
            If (ojbM生产计划T.产品状态 = "试做品") Then
                strSql.Append(" AND T流转票管理.试做品 = 'true'" & vbCrLf)
            End If
            If (ojbM生产计划T.订单编号 <> String.Empty) Then
                strSql.Append(" AND B订单管理.订单编号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            End If
            'If (ojbM生产计划T.完成日1 <> "") Then
            '    strSql.Append(" AND Z生产计划制定.产品完成日 >=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.完成日1) & vbCrLf)
            'End If

            'If (ojbM生产计划T.完成日2 <> "") Then
            '    strSql.Append(" AND Z生产计划制定.产品完成日 <" & Utility.PFn_ChangeQuotation(ojbM生产计划T.完成日2) & vbCrLf)
            'End If
            If (ojbM生产计划T.客户编号 <> String.Empty) Then
                strSql.Append(" AND M客户管理.客户编号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.客户编号) & vbCrLf)
            End If
            If (ojbM生产计划T.主图号 <> String.Empty) Then
                strSql.Append(" AND T图纸管理.产品图号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.主图号) & vbCrLf)
            End If




            'strSql.Append(" SELECT DISTINCT")
            'strSql.Append("        Z生产计划制定.订单编号 ,")
            'strSql.Append("        T图纸管理.主图号 ,")
            'strSql.Append("        上级.产品图号 上级图号,")
            'strSql.Append("        T图纸管理.产品图号 分图号 ,")
            'strSql.Append("        品名 ,")
            'strSql.Append("        ISNULL(B订单管理.订单数量, 0) * ISNULL(T图纸管理.数量, 0) AS 订货量 ,")
            'strSql.Append("        Z生产计划制定.投产数量 ,")
            'strSql.Append("        CASE WHEN Z生产计划制定.是否整体外协加工 = 'true' THEN '是'")
            'strSql.Append("             ELSE '否'")
            'strSql.Append("        END AS 是否整体外协加工 ,")
            'strSql.Append("        CASE WHEN B订单管理.产品区分 = 2 THEN '是'")
            'strSql.Append("             ELSE '否'")
            'strSql.Append("        END AS 是否为抵补品 ,")
            'strSql.Append("        CASE WHEN T流转票管理.试做品 = 'true' THEN '是'")
            'strSql.Append("             ELSE '否'")
            'strSql.Append("        END AS 是否为试做品 ,")
            'strSql.Append("        Z生产计划制定.产品起始日 ,")
            'strSql.Append("        Z生产计划制定.产品完成日 ,")
            'strSql.Append("        Z生产计划制定.合格标准 ,")
            'strSql.Append("        B订单管理.备注 ,")
            'strSql.Append("        T图纸管理.图纸 ")
            'strSql.Append(" FROM   B订单管理")
            'strSql.Append("        LEFT JOIN Z生产计划制定 ON B订单管理.订单编号 = Z生产计划制定.订单编号")
            'strSql.Append("                             AND Z生产计划制定.主图号 = B订单管理.产品图号")
            'strSql.Append("        INNER JOIN dbo.T图纸关系 关系 ON 关系.产品图号 = B订单管理.产品图号")
            'strSql.Append("                                   AND 关系.CIID = 0")
            'strSql.Append("        INNER JOIN T图纸关系 关系1 ON 关系1.关系ID = 关系.关系ID")
            'strSql.Append("                                AND 关系1.产品图号 = Z生产计划制定.分图号")
            'strSql.Append("        left JOIN dbo.T图纸关系 上级 ON 上级.ID = 关系1.CIID ")
            'strSql.Append("                                   AND 上级.关系ID = 关系.关系ID ")
            'strSql.Append("        INNER  JOIN dbo.T图纸管理 ON Z生产计划制定.主图号 = T图纸管理.主图号")
            'strSql.Append("                                AND (上级.产品图号 = T图纸管理.上级图号 OR 上级.产品图号 IS null)")
            'strSql.Append("                                AND T图纸管理.产品图号 = Z生产计划制定.分图号")
            'strSql.Append("        LEFT JOIN T流转票管理 ON T流转票管理.产品图号 = T图纸管理.产品图号")
            'strSql.Append(" WHERE  1 = 1 ")

            'If (ojbM生产计划T.产品状态 = "整体外协") Then
            '    strSql.Append(" AND Z生产计划制定.是否整体外协加工 = 'true'" & vbCrLf)
            'End If
            'If (ojbM生产计划T.产品状态 = "抵补品") Then
            '    strSql.Append(" AND B订单管理.产品区分 = '2'" & vbCrLf)
            'End If
            'If (ojbM生产计划T.产品状态 = "试做品") Then
            '    strSql.Append(" AND T流转票管理.试做品 = 'true'" & vbCrLf)
            'End If
            'If (ojbM生产计划T.订单编号 <> String.Empty) Then
            '    strSql.Append(" AND B订单管理.订单编号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            'End If
            'If (ojbM生产计划T.完成日1 <> "") Then
            '    strSql.Append(" AND Z生产计划制定.产品完成日 >=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.完成日1) & vbCrLf)
            'End If

            'If (ojbM生产计划T.完成日2 <> "") Then
            '    strSql.Append(" AND Z生产计划制定.产品完成日 <" & Utility.PFn_ChangeQuotation(ojbM生产计划T.完成日2) & vbCrLf)
            'End If
            'If (ojbM生产计划T.客户编号 <> String.Empty) Then
            '    strSql.Append(" AND M客户管理.客户编号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.客户编号) & vbCrLf)
            'End If
            'If (ojbM生产计划T.主图号 <> String.Empty) Then
            '    strSql.Append(" AND T图纸管理.主图号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.主图号) & vbCrLf)
            'End If
            '检索条件 设定
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere3"

    '检索全部数据
    Public Function LoadByWhere3(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append("  B.订单数量 - A.外协数量 AS 订单数量,  " & vbCrLf)
            strSql.Append(" 外协数量" & vbCrLf)
            strSql.Append(" FROM Z生产计划制定 A")
            strSql.Append(" INNER JOIN dbo.B订单管理 B ON B.订单编号 = A.订单编号")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            strSql.Append(" AND A.订单编号=" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "CheckGrid"

    '检索全部数据
    Public Function CheckGrid(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try
            strSql.Append("SELECT ")
            strSql.Append("        B订单管理.产品图号,")
            strSql.Append("        工序编号,工序名称")
            strSql.Append("        FROM dbo.B订单管理 INNER JOIN dbo.T流转票管理")
            strSql.Append("        ON T流转票管理.产品图号 = B订单管理.产品图号")
            '检索条件 设定
            strSql.Append(" WHERE 订单编号 =" & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

    Public Function LoadAll生产计划(ByVal ojbM生产计划T As M生产计划制定T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT DISTINCT")
            strSql.Append("         所有图纸.ID - 主图关系.ID + 1 图纸等级 ,")
            strSql.Append("         主图关系.产品图号 主图号 ,")
            strSql.Append("         CASE WHEN 上级.产品图号 IS NULL THEN 主图关系.产品图号")
            strSql.Append("              ELSE 上级.产品图号")
            strSql.Append("         END 上级图号 ,")
            strSql.Append("         流转票.产品图号 分图号 ,")
            strSql.Append("         流转票.图纸 ,")
            strSql.Append("         图纸.品名 ,")
            strSql.Append("         计划.投产数量 ,")
            strSql.Append("         CASE WHEN 流转票.产品图号=主图关系.产品图号  THEN 计划.总件完成期限")
            strSql.Append("              ELSE 计划.小件完成期限")
            strSql.Append("         END 完成期限 ,")
            strSql.Append("         计划.下达日期 ,")
            strSql.Append("         订单.订单编号 订单号 ,")
            strSql.Append("         订单.订单数量 订货量 ,")
            strSql.Append("         订单.发货日期 ,")
            strSql.Append("         '' 指示完成日期 ,")
            strSql.Append("         '' 作业起始日期 ,")
            strSql.Append("         流转票.工序编号 序号 ,")
            strSql.Append("         流转票.工序名称 ,")
            strSql.Append("         流转票.加工内容简介 ,")
            strSql.Append("         流转票.作业场所 ,")
            strSql.Append("         设备.设备名称")
            strSql.Append(" FROM    dbo.B订单管理 订单")
            strSql.Append("         LEFT  JOIN dbo.T图纸关系 主图关系 ON 主图关系.产品图号 = 订单.产品图号")
            strSql.Append("                                      AND 主图关系.CIID = 0")
            strSql.Append("         INNER JOIN dbo.T图纸关系 所有图纸 ON 所有图纸.关系ID = 主图关系.关系ID")
            strSql.Append("         LEFT JOIN dbo.T图纸关系 上级 ON 上级.关系ID = 主图关系.关系ID")
            strSql.Append("                                   AND 上级.ID = 所有图纸.CIID")
            strSql.Append("         LEFT JOIN dbo.T流转票管理 流转票 ON 流转票.产品图号 = 所有图纸.产品图号")
            strSql.Append("         LEFT JOIN dbo.M设备管理 设备 ON 设备.设备编号 = 流转票.设备编号")
            strSql.Append("         LEFT  JOIN dbo.T图纸管理 图纸 ON 图纸.主图号 = 主图关系.产品图号")
            strSql.Append("                                    AND ( 图纸.上级图号 = 上级.产品图号")
            strSql.Append("                                          OR 上级.产品图号 IS NULL")
            strSql.Append("                                        )")
            strSql.Append("                                    AND 图纸.产品图号 = 流转票.产品图号")
            strSql.Append("         LEFT JOIN dbo.Z生产计划制定 计划 ON 计划.订单编号 = 订单.订单编号")
            strSql.Append("                                      AND 计划.产品图号 = 主图关系.产品图号")
            '检索条件 设定
            strSql.Append(" where 1=1 ")
            If ojbM生产计划T.订单编号 <> "" Then
                strSql.Append("  AND 订单.订单编号 =  " & Utility.PFn_ChangeQuotation(ojbM生产计划T.订单编号) & vbCrLf)
            End If
            'If ojbM生产计划T.分图号 <> "" Then
            '    strSql.Append("  and 主图关系.产品图号 = " & Utility.PFn_ChangeQuotation(ojbM生产计划T.分图号) & vbCrLf)
            'End If
            strSql.Append("ORDER BY 图纸等级 , " & vbCrLf)
            strSql.Append("        流转票.工序编号 " & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

End Class
