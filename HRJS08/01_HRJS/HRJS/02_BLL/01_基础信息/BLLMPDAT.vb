Imports System.Text
Imports System.Data.SqlClient
Imports HRJS.Constant

Public Class BLLMPDAT

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " IsExists "

    'IsExists
    Public Function IsExists(ByVal strPDA编号 As String) As Boolean

        Dim objDalMPDAT As New DalMPDAT
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "BllMPDA.IsExists"

        Try

            strSql = objDalMPDAT.IsExists(strPDA编号)
            objReturn = ObjDBConn.PFn_ExcuteScalar(strSql)
            ObjDBConn.PSb_CloseDB()

            If Convert.ToInt32(objReturn) = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal clsMPDAT As MPDAT) As Integer

        Dim objDalMPDAT As New DalMPDAT
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllMPDA.Insert"

        Try

            strSql = objDalMPDAT.Insert(clsMPDAT)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Update "

    '根据主键更新数据
    Public Function Update(ByVal clsMPDAT As MPDAT) As Integer

        Dim objDalMPDAT As New DalMPDAT
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllMPDA.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalMPDAT.Update(clsMPDAT)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)
            ObjDBConn.PSb_Commit()

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Delete "

    '删除数据
    Public Function Delete(ByVal clsMPDAT As MPDAT) As Integer

        Dim objDalMPDAT As New DalMPDAT
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllMPDA.Delete"

        Try

            strSql = objDalMPDAT.Delete(clsMPDAT)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadByPKey "

    '根据主键检索
    Public Function LoadByPKey(ByVal clsMPDAT As MPDAT) As MPDAT

        Dim objMPDAT As New MPDAT
        Dim objDalMPDAT As New DalMPDAT
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalMPDAT.LoadByPK(clsMPDAT)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objMPDAT.PDA编号 = sdr.Item("PDA编号")            'PDA名
                objMPDAT.PDAIP = sdr.Item("PDAIP")          'PDA类别 
                'If Not IsDBNull(sdr.Item("PDA负责人")) Then
                '    objMPDAT.PDA负责人 = sdr.Item("PDA负责人")          'PDA类别 
                'End If
                'If Not IsDBNull(sdr.Item("备注")) Then
                '    objMPDAT.备注 = sdr.Item("备注")          'PDA类别 
                'End If

                'If Not IsDBNull(sdr.Item("登录者")) Then
                '    objMPDAT.登录者 = sdr.Item("登录者")          'PDA类别 
                'End If
                'If Not IsDBNull(sdr.Item("登录日期")) Then
                '    objMPDAT.登录日期 = sdr.Item("登录日期")          'PDA类别
                'End If
                'If Not IsDBNull(sdr.Item("更新者")) Then
                '    objMPDAT.更新者 = sdr.Item("更新者")          'PDA类别 
                'End If
                'If Not IsDBNull(sdr.Item("更新日期")) Then
                '    objMPDAT.更新日期 = sdr.Item("更新日期")          'PDA类别 
                'End If
            End If
            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objMPDAT

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsMPDAT As MPDAT) As DataTable

        Dim objDalMPDAT As New DalMPDAT
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllMPDA.LoadAll"

        Try

            strSql = objDalMPDAT.LoadAll(clsMPDAT)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal clsMPDAT As MPDAT) As DataTable

        Dim objDalMPDAT As New DalMPDAT
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllMPDA.LoadByWhere"

        Try

            strSql = objDalMPDAT.LoadByWhere(clsMPDAT)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region "SaveData"

    Public Function SaveData(ByVal objMPDAT As MPDAT, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalMPDAT As New DalMPDAT

        Try

            objDbCon = New DbHelper
            '事務の開始
            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    'PDA新規を処理
                    If objDbCon.PFn_ExcuteDB(objDalMPDAT.Insert(objMPDAT)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    'PDA更新処理
                    If objDbCon.PFn_ExcuteDB(objDalMPDAT.Update(objMPDAT)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If
            End Select

            '事務のコミット
            objDbCon.PSb_Commit()

            'データベース接続を切断する
            objDbCon.PSb_CloseDB()

            Return Constant.ENU_RETURNTYPE.Succeed

        Catch ex As Exception

            '空対象をセットする
            If Not objDbCon Is Nothing Then
                'DB連接を閉じる
                objDbCon.PSb_CloseDB()
                objDbCon = Nothing
            End If

            Throw New Exception(MyMethodBase.ReflectedType.Name & "." & MyMethodBase.Name, ex)

        End Try

    End Function

#End Region


End Class
