Imports System.Text
Imports HRJS.Constant
Imports System.Data.SqlClient

Public Class BLLM图纸T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " IsExists "

    '插入数据
    Public Function IsExists(ByVal str产品图号 As String) As Integer

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "Bll图纸.IsExists"

        Try

            strSql = objDalM图纸T.IsExists(str产品图号)
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
    Public Function Insert(ByVal arry图纸 As ArrayList, ByVal dt As DataTable) As Integer

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            For i = 0 To arry图纸.Count - 1
                Dim objM图纸T As New M图纸T
                objM图纸T = arry图纸(i)

                strSql = objDalM图纸T.Insert(objM图纸T)

                intRows += ObjDBConn.PFn_ExcuteDB(strSql)
            Next

            strSql = objDalM图纸T.Delete图纸关系(arry图纸(0))
            intRows = intRows + ObjDBConn.PFn_ExcuteDB(strSql)

            For Each dr As DataRow In dt.Rows
                strSql = objDalM图纸T.Insert图纸关系(dr)

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
    Public Function Update(ByVal clsM图纸T As M图纸T, ByVal dt As DataTable) As Integer

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM图纸T.Update(clsM图纸T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            strSql = objDalM图纸T.Delete图纸关系(clsM图纸T)
            intRows = intRows + ObjDBConn.PFn_ExcuteDB(strSql)

            For Each dr As DataRow In dt.Rows
                strSql = objDalM图纸T.Insert图纸关系(dr)

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

#Region " Delete "

    '删除数据
    Public Function Delete(ByVal clsM图纸T As M图纸T, ByVal flg As Boolean) As Integer

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.Delete"

        Try

            If flg Then
                strSql = objDalM图纸T.Delete(clsM图纸T)
                intRows = ObjDBConn.PFn_ExcuteDB(strSql)
                strSql = objDalM图纸T.Delete图纸关系(clsM图纸T)
                intRows = intRows + ObjDBConn.PFn_ExcuteDB(strSql)
            Else
                strSql = objDalM图纸T.Delete1(clsM图纸T)
                intRows = ObjDBConn.PFn_ExcuteDB(strSql)
            End If

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function insert复制(ByVal clsM图纸T As M图纸T) As Integer

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.insert复制"

        Try

            strSql = objDalM图纸T.insert复制(clsM图纸T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)
            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function insert流转票(ByVal clsM图纸T As M图纸T) As Integer

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.insert流转票"

        Try

            strSql = objDalM图纸T.insert流转票(clsM图纸T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)
            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function insert工艺卡(ByVal clsM图纸T As M图纸T) As Integer

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.insert工艺卡"

        Try

            strSql = objDalM图纸T.insert工艺卡(clsM图纸T)
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

    '根据主键检索    Public Function LoadAll流转票(ByVal clsM图纸T As M图纸T) As M图纸T

        Dim objM图纸T As New M图纸T
        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM图纸T.LoadAll流转票(clsM图纸T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM图纸T.产品图号 = sdr.Item("产品图号")

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM图纸T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAll工艺卡(ByVal clsM图纸T As M图纸T) As M图纸T

        Dim objM图纸T As New M图纸T
        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM图纸T.LoadAll工艺卡(clsM图纸T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM图纸T.产品图号 = sdr.Item("产品图号")

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM图纸T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadByPKey(ByVal clsM图纸T As M图纸T) As M图纸T

        Dim objM图纸T As New M图纸T
        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM图纸T.LoadByPK(clsM图纸T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM图纸T.产品图号 = sdr.Item("产品图号")
                objM图纸T.品名 = sdr.Item("品名")
                'objM图纸T.图纸名称 = sdr.Item("图纸名称")
                'objM图纸T.图纸型号 = sdr.Item("图纸型号")
                'objM图纸T.维护周期 = sdr.Item("维护周期")
                'objM图纸T.上次维护日期 = sdr.Item("上次维护日期")
                'objM图纸T.使用状态 = sdr.Item("使用状态")
                'objM图纸T.图纸产量 = sdr.Item("图纸产量")
                'objM图纸T.维护厂商 = sdr.Item("维护厂商")
                'objM图纸T.维护负责人 = sdr.Item("维护负责人")
                'objM图纸T.负责人电话 = sdr.Item("负责人电话")
                'objM图纸T.登录者 = sdr.Item("登录者")
                'objM图纸T.登录日期 = sdr.Item("登录日期")
                'objM图纸T.更新者 = sdr.Item("更新者")
                'objM图纸T.更新日期 = sdr.Item("更新日期")

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM图纸T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadIDMax() As DataTable
        'LoadIDMax = 0
        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文        Try

            strSql = objDalM图纸T.LoadIDMax()

            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn


            'sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            ''数据存在
            'If sdr.HasRows = True Then

            '    sdr.Read()

            '    LoadIDMax = sdr.Item("ID")

            'End If

            ''DataReader关闭
            'sdr.Close()
            'ObjDBConn.PSb_CloseDB()

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadByPKey产品图号(ByVal cls图纸T As M图纸T) As M图纸T

        Dim obj图纸T As New M图纸T
        Dim objDal图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDal图纸T.LoadByPKey产品图号(cls图纸T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                obj图纸T.产品图号 = sdr.Item("产品图号")             '订单编号
                'obj订单表T.厂内编号 = sdr.Item("厂内编号")             '出荷去向

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return obj图纸T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function


#End Region

#Region " LoadAll "

    '检索全部数据    Public Function LoadAllexp(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadAllexp"

        Try

            strSql = objDalM图纸T.LoadAllexp(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAllexp2(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadAllexp2"

        Try

            strSql = objDalM图纸T.LoadAllexp2(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAll(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadAll"

        Try

            strSql = objDalM图纸T.LoadAll(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAllGrid(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadAllGrid"

        Try

            strSql = objDalM图纸T.LoadAllGrid(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadTree(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadAllGrid"

        Try

            strSql = objDalM图纸T.LoadTree(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadAll图纸(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadAll人员"

        Try

            strSql = objDalM图纸T.LoadAll图纸(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadAll图纸1(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadAll人员"

        Try

            strSql = objDalM图纸T.LoadAll图纸1(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadAll密度(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadAll密度"

        Try

            strSql = objDalM图纸T.LoadAll密度(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " 图纸一览用 "
    Public Function LoadByWhereInfo(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadByWhere"

        Try

            strSql = objDalM图纸T.LoadByWhereInfo(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    '检索全部数据    Public Function LoadByWhere1(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadByWhere"

        Try

            strSql = objDalM图纸T.LoadByWhere1(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

    Public Function LoadByWhere2(ByVal clsM图纸T As M图纸T, ByVal intCount As Integer) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadByWhere"

        Try

            strSql = objDalM图纸T.LoadByWhere2(clsM图纸T, intCount)
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

    '检索全部数据    Public Function LoadByWhere(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadByWhere"

        Try

            strSql = objDalM图纸T.LoadByWhere(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadBy订单 "

    '检索全部数据    Public Function LoadBy订单(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadBy订单"

        Try

            strSql = objDalM图纸T.LoadBy订单(clsM图纸T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadDataByWhere_Proc "

    '检索全部数据    Public Function LoadDataByWhere_Proc(ByVal clsM图纸T As M图纸T) As DataTable

        Dim objDalM图纸T As New DalM图纸T
        Dim ObjDBConn As New DbHelper
        'Dim strSql As String = String.Empty
        strErrorName = "BllM图纸.LoadByWhere"
        Dim pro = "图号修改"
        Try

            Dim strSql = objDalM图纸T.LoadDataByWhere_Proc(clsM图纸T)
            Dim parm = ObjDBConn.PFn_ExcuteProcedures(pro, strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region "SaveData"

    Public Function SaveData(ByVal objM图纸T As M图纸T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM图纸T As New DalM图纸T

        Try

            objDbCon = New DbHelper
            '事務の開始
            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '图纸新規を処理
                    If objDbCon.PFn_ExcuteDB(objDalM图纸T.Insert(objM图纸T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '图纸更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM图纸T.Update(objM图纸T)) < 0 Then
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
