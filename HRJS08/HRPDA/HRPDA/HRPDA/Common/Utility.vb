Imports System.Text
Imports System
Imports System.DBNull
Imports System.Data.SqlClient
Imports Microsoft.Win32
Imports System.IO
Imports System.Data

Public Class Utility

    Public Shared 操作者编号 As String
    Public Shared 操作PDA_IP As String

    Public Shared 出入库区分_入库 As String = "1"
    Public Shared 出入库区分_出库 As String = "2"

    Public Shared 库存状态_正常品 As String = "1"
    Public Shared 库存状态_返回品 As String = "2"
  

    Public Shared Function ExceSQL(ByVal sqlstr() As String) As Boolean

        Dim objDbHelper As New DbHelper
        Dim flag As Boolean = True
        Try
            objDbHelper.BeginTransaction()

            For index As Integer = 0 To sqlstr.Length - 1
                Dim re As Integer = objDbHelper.ExcuteNonQuery(sqlstr(index))

                If re = 0 Then
                    flag = False
                    Exit For
                End If
            Next

            If flag Then
                objDbHelper.Commit()
            Else
                objDbHelper.Rollback()
            End If

            objDbHelper.Dispose()

            Return flag

        Catch ex As Exception
            If Not objDbHelper Is Nothing Then
                objDbHelper.Dispose()
            End If
            Throw New Exception("ServerEXEC", ex)
        End Try
    End Function


    Public Shared Function ServerSelect(ByVal sqlstr As String) As DataTable


        Dim objDbHelper As New DbHelper

        Dim ret As New DataTable
        Try
            ret = objDbHelper.FillDataTable(sqlstr)

            objDbHelper.Dispose()

            Return ret

        Catch ex As Exception
            If Not objDbHelper Is Nothing Then
                objDbHelper.Dispose()
            End If
            Throw New Exception("ServerSelect", ex)
        End Try
    End Function


    Public Shared Function GetRoundID() As String

        Dim objDbHelper As New DbHelper

        Dim dt As New DataTable

        Dim sqlstr As String = "select convert(varchar, getdate(), 112)+ right('0000' + cast(RAND() as varchar),6)"

        Try
            dt = objDbHelper.FillDataTable(sqlstr)

            objDbHelper.Dispose()

            Return dt.Rows(0)(0).ToString

        Catch ex As Exception
            If Not objDbHelper Is Nothing Then
                objDbHelper.Dispose()
            End If
            Throw New Exception("ServerSelect", ex)
        End Try
    End Function


    Public Shared Function GetDateTime() As String

        Dim objDbHelper As New DbHelper

        Dim dt As New DataTable

        Dim sqlstr As String = "select getdate()"

        Try
            dt = objDbHelper.FillDataTable(sqlstr)

            objDbHelper.Dispose()

            Return dt.Rows(0)(0).ToString

        Catch ex As Exception
            If Not objDbHelper Is Nothing Then
                objDbHelper.Dispose()
            End If
            Throw New Exception("ServerSelect", ex)
        End Try
    End Function

    Public Shared Function isNumer(ByVal txt As System.Windows.Forms.TextBox) As Boolean

        Dim flag As Boolean = False
        If Not IsNumeric(txt.Text.Trim) Then
            flag = True
            txt.Text = String.Empty
            txt.Focus()
        End If
        Return flag
    End Function



End Class