Imports System.Text

Public Class DalMPDAT

#Region "IsExists"

    Public Function IsExists(ByVal strPDA编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   MPDA管理 " & vbCrLf)
            strSql.Append("WHERE  PDA编号 = " & Utility.PFn_ChangeQuotation(strPDA编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal ojbMPDAT As MPDAT) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO MPDA管理") 'MPDA
            strSql.Append("  (" & vbCrLf)
            strSql.Append(" 	PDA编号," & vbCrLf)
            strSql.Append(" 	PDAIP," & vbCrLf)
            strSql.Append(" 	PDA负责人编号," & vbCrLf)
            'strSql.Append(" 	PDA负责人姓名," & vbCrLf)
            'strSql.Append(" 	联系电话," & vbCrLf)
            'strSql.Append(" 	邮箱," & vbCrLf)

            strSql.Append(" 	备注," & vbCrLf)
            strSql.Append(" 	登录者," & vbCrLf)
            strSql.Append(" 	登录日期 " & vbCrLf)
            strSql.Append("  )" & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.PDA编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.PDAIP))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.PDA负责人编号))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.PDA负责人姓名))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.联系电话))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.邮箱))

            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.备注))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.登录者))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.登录日期))

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
    Public Function Update(ByVal ojbMPDAT As MPDAT) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("     MPDA管理 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)

            strSQL.AppendFormat("     PDAIP = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.PDAIP))
            'PDA负责人

            strSQL.AppendFormat("     ,PDA负责人编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.PDA负责人编号))

            'strSQL.AppendFormat("     ,PDA负责人姓名 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.PDA负责人姓名))

            'strSQL.AppendFormat("     ,联系电话 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.联系电话))

            'strSQL.AppendFormat("     ,邮箱 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.邮箱))

            '备注
            'If Not ojbMPDAT.备注 = "" Then
            strSQL.Append("     ,备注 =" & Utility.PFn_ChangeQuotation(ojbMPDAT.备注))
            'End If
            strSQL.AppendFormat("    ,更新者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.更新者))
            strSQL.AppendFormat("    ,更新日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.更新日期))

            strSQL.Append(" WHERE ")
            strSQL.AppendFormat("    PDA编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.PDA编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbMPDAT As MPDAT) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM MPDA管理" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  PDA编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbMPDAT.PDA编号))

            'SQLに戻る
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal objMPDAT As MPDAT) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	PDA编号," & vbCrLf)
            strSql.Append(" 	PDAIP," & vbCrLf)
            strSql.Append(" 	PDA负责人编号," & vbCrLf)
            strSql.Append(" 	m人员管理.人员名 PDA负责人姓名," & vbCrLf)
            strSql.Append(" 	m人员管理.电话号码 联系电话," & vbCrLf)
            strSql.Append(" 	邮箱," & vbCrLf)

            strSql.Append(" 	备注" & vbCrLf)
            'strSql.Append(" 	登录者," & vbCrLf)
            'strSql.Append(" 	登录日期," & vbCrLf)
            'strSql.Append(" 	更新者," & vbCrLf)
            'strSql.Append(" 	更新日期" & vbCrLf)
            strSql.Append(" FROM MPDA管理" & vbCrLf)
            strSql.Append("left join m人员管理 on m人员管理.人员编号=MPDA管理.PDA负责人编号")
            '检索条件 设定
            strSql.Append(" WHERE PDA编号=" & Utility.PFn_ChangeQuotation(objMPDAT.PDA编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal objMPDAT As MPDAT) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	PDA编号," & vbCrLf)
            strSql.Append(" 	PDAIP," & vbCrLf)
            strSql.Append(" 	PDA负责人编号" & vbCrLf)
            'strSql.Append(" 	PDA负责人姓名," & vbCrLf)
            'strSql.Append(" 	联系电话," & vbCrLf)
            'strSql.Append(" 	邮箱," & vbCrLf)

            'strSql.Append(" 	备注," & vbCrLf)
            'strSql.Append(" 	登录者," & vbCrLf)
            'strSql.Append(" 	登录日期," & vbCrLf)
            'strSql.Append(" 	更新者," & vbCrLf)
            'strSql.Append(" 	更新日期" & vbCrLf)
            strSql.Append(" FROM MPDA管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objMPDAT.PDA编号 <> String.Empty) Then
                strSql.Append(" AND PDA编号=" & Utility.PFn_ChangeQuotation(objMPDAT.PDA编号) & vbCrLf)
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
    Public Function LoadByWhere(ByVal objMPDAT As MPDAT) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	PDA编号 as 终端设备编号," & vbCrLf)
            strSql.Append(" 	PDAIP as 终端设备IP," & vbCrLf)
            strSql.Append(" 	M人员管理.人员名  as 负责人姓名," & vbCrLf)
            strSql.Append(" 	电话号码 联系电话," & vbCrLf)
            strSql.Append(" 	邮箱," & vbCrLf)
            strSql.Append(" 	备注" & vbCrLf)
            'strSql.Append(" 	登录者," & vbCrLf)
            'strSql.Append(" 	登录日期," & vbCrLf)
            'strSql.Append(" 	更新者," & vbCrLf)
            'strSql.Append(" 	更新日期" & vbCrLf)
            strSql.Append(" FROM MPDA管理")
            strSql.Append("  left join M人员管理  on M人员管理.人员编号 =MPDA管理.PDA负责人编号 ")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objMPDAT.PDA编号 <> String.Empty) Then
                strSql.Append(" AND PDA编号 LIKE '%" & Utility.PFn_ChangeQuotation(objMPDAT.PDA编号, True) & "%'" & vbCrLf)
            End If
            If (objMPDAT.PDAIP <> String.Empty) Then
                strSql.Append(" AND PDAIP LIKE '%" & Utility.PFn_ChangeQuotation(objMPDAT.PDAIP, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY PDA编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
