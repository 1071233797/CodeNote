Imports System.Text
Imports HRJS.Constant
Imports System.Data.SqlClient

Public Class BLLZ包装实际管理T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry包装 As ArrayList) As Integer

        Dim objDalZ包装实际T As New DalZ包装实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ包装实际管理.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry包装.Count - 1
                Dim objZ包装实际T As New Z包装实际管理T
                objZ包装实际T = arry包装(i)

                strSql = objDalZ包装实际T.Insert(objZ包装实际T)

                intRows += ObjDBConn.PFn_ExcuteDB(strSql)
            Next

            ObjDBConn.PSb_Commit()
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
    Public Function Update(ByVal clsZ包装实际T As Z包装实际管理T) As Integer

        Dim objDalZ包装实际T As New DalZ包装实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ包装实际管理.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalZ包装实际T.Update(clsZ包装实际T)
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
    Public Function Delete(ByVal clsZ包装实际T As Z包装实际管理T) As Integer

        Dim objDalZ包装实际T As New DalZ包装实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ包装实际管理.Delete"

        Try

            strSql = objDalZ包装实际T.Delete(clsZ包装实际T)
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

    Public Function LoadByPKey(ByVal clsZ包装实际T As Z包装实际管理T) As Z包装实际管理T

        Dim objZ包装实际T As New Z包装实际管理T
        Dim objDalZ包装实际T As New DalZ包装实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Dim sdr As SqlDataReader

        Try

            strSql = objDalZ包装实际T.LoadByPK(clsZ包装实际T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                'objM生产实际T.产品图号 = sdr.Item("产品图号")
                'objM生产实际T.品名 = sdr.Item("品名")
                'objM生产实际T.工序名称 = sdr.Item("工序名称")
                'objM生产实际T.加工内容 = sdr.Item("加工内容")
                'objM生产实际T.备注 = sdr.Item("备注")
                'objM生产实际T.作业者 = sdr.Item("作业者")
                ''objM工艺卡T.图纸图片 = sdr.Item("图纸图片")
                ''objM图纸T.维护负责人 = sdr.Item("维护负责人")
                ''objM图纸T.负责人电话 = sdr.Item("负责")人电话
                'objM工艺卡T.登陆者 = sdr.Item("登录者")
                'objM工艺卡T.登陆日期 = sdr.Item("登录日期")
                'objM工艺卡T.更新者 = sdr.Item("更新者")
                'objM工艺卡T.更新日期 = sdr.Item("更新日期")

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objZ包装实际T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsZ包装实际T As Z包装实际管理T) As DataTable

        Dim objDalZ包装实际T As New DalZ包装实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ包装实际管理.LoadAll"

        Try

            strSql = objDalZ包装实际T.LoadAll(clsZ包装实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAllGrid(ByVal clsZ包装实际T As Z包装实际管理T) As DataTable

        Dim objDalZ包装实际T As New DalZ包装实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ包装实际管理.LoadAllGrid"

        Try

            strSql = objDalZ包装实际T.LoadAllGrid(clsZ包装实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "Load人员"
    Public Function Load人员(ByVal clsZ包装实际T As Z包装实际管理T) As DataTable

        Dim objDalZ包装实际T As New DalZ包装实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ包装实际管理.LoadAllGrid"

        Try

            strSql = objDalZ包装实际T.Load人员(clsZ包装实际T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "Load订单"
    Public Function Load订单(ByVal clsZ包装实际T As Z包装实际管理T) As DataTable

        Dim objDalZ包装实际T As New DalZ包装实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ包装实际管理.LoadAllGrid"

        Try

            strSql = objDalZ包装实际T.Load订单(clsZ包装实际T)
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

    Public Function LoadByWhere(ByVal clsZ包装实际T As Z包装实际管理T) As DataTable

        Dim objDalZ包装实际T As New DalZ包装实际管理T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllZ包装实际管理.LoadByWhere"

        Try

            strSql = objDalZ包装实际T.LoadByWhere(clsZ包装实际T)
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

    Public Function SaveData(ByVal objZ包装实际T As Z包装实际管理T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalZ包装实际T As New DalZ包装实际管理T

        Try

            objDbCon = New DbHelper
            '事務の開始

            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '图纸新規を処理

                    If objDbCon.PFn_ExcuteDB(objDalZ包装实际T.Insert(objZ包装实际T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '图纸更新処理
                    If objDbCon.PFn_ExcuteDB(objDalZ包装实际T.Update(objZ包装实际T)) < 0 Then
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
