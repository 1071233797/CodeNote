#Region "外协加工基础类"
'   创建人: 
'   创建日期: 
#End Region

Public Class B外协加工管理T

    '变量定义 
    Private str外协订单编号 As String = ""              '外协订单编号
    Private str外协对象编号 As String = ""              '外协对象
    Private str订单编号 As String = ""                  '订单编号
    Private str分图号 As String = ""                    '产品图号
    Private str主图号 As String = ""                    '主图号
    Private str上级图号 As String = ""                  '上级图号
    Private str客户编号 As String = ""                  '客户编号
    Private str客户名称 As String = ""                  '客户名称
    Private str外协加工数量 As String = ""              '外协加工数量
    Private str外协加工状态 As String = ""              '外协加工状态
    Private str外协工序 As String = ""                  '外协工序
    Private str回厂日期1 As DateTime                    '回厂日期
    Private str回厂日期2 As DateTime                    '回厂日期
    Private str计划制定日期1 As DateTime                '计划制定日期
    Private str计划制定日期2 As DateTime                '计划制定日期
    Private str原材料编号 As String = ""                '原材料编号
    Private str实际带料数量 As String = ""              '实际带料数量
    Private str加工单价 As String = ""                  '加工单价
    Private str加工总金额 As String = ""                '加工总金额
    Private str备注 As String = ""                      '备注
    Private str审核状态 As String = ""                  '审核状态
    Private str审核人 As String = ""                    '审核人
    Private str审核备注 As String = ""                  '审核备注
    Private str作成者编号 As String = ""                '作成者编号
    Private str完成日期 As String = ""                  '完成日期
    Private str As Integer
    Private str1 As Integer
    Public Property 完成日期() As String
        Get
            Return str完成日期
        End Get
        Set(ByVal Value As String)
            str完成日期 = Value
        End Set
    End Property
    Public Property 作成者编号() As String
        Get
            Return str作成者编号
        End Get
        Set(ByVal Value As String)
            str作成者编号 = Value
        End Set
    End Property

    Public Property 外协订单编号() As String
        Get
            Return str外协订单编号
        End Get
        Set(ByVal Value As String)
            str外协订单编号 = Value
        End Set
    End Property
    Public Property 外协对象编号() As String
        Get
            Return str外协对象编号
        End Get
        Set(ByVal Value As String)
            str外协对象编号 = Value
        End Set
    End Property

    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal Value As String)
            str订单编号 = Value
        End Set
    End Property

    Public Property 分图号() As String
        Get
            Return str分图号
        End Get
        Set(ByVal Value As String)
            str分图号 = Value
        End Set
    End Property

    Public Property 主图号() As String
        Get
            Return str主图号
        End Get
        Set(ByVal Value As String)
            str主图号 = Value
        End Set
    End Property

    Public Property 上级图号() As String
        Get
            Return str上级图号
        End Get
        Set(ByVal Value As String)
            str上级图号 = Value
        End Set
    End Property
    Public Property 客户编号() As String
        Get
            Return str客户编号
        End Get
        Set(ByVal Value As String)
            str客户编号 = Value
        End Set
    End Property
    Public Property 客户名称() As String
        Get
            Return str客户名称
        End Get
        Set(ByVal Value As String)
            str客户名称 = Value
        End Set
    End Property

    Public Property 外协加工数量() As String
        Get
            Return str外协加工数量
        End Get
        Set(ByVal Value As String)
            str外协加工数量 = Value
        End Set
    End Property

    Public Property 外协加工状态() As String
        Get
            Return str外协加工状态
        End Get
        Set(ByVal Value As String)
            str外协加工状态 = Value
        End Set
    End Property

    Public Property 外协工序() As String
        Get
            Return str外协工序
        End Get
        Set(ByVal Value As String)
            str外协工序 = Value
        End Set
    End Property

    Public Property 回厂日期1() As DateTime
        Get
            Return str回厂日期1
        End Get
        Set(ByVal Value As DateTime)
            str回厂日期1 = Value
        End Set
    End Property

    Public Property 回厂日期2() As DateTime
        Get
            Return str回厂日期2
        End Get
        Set(ByVal Value As DateTime)
            str回厂日期2 = Value
        End Set
    End Property
    Public Property 计划制定日期1() As DateTime
        Get
            Return str计划制定日期1
        End Get
        Set(ByVal Value As DateTime)
            str计划制定日期1 = Value
        End Set
    End Property

    Public Property 计划制定日期2() As DateTime
        Get
            Return str计划制定日期2
        End Get
        Set(ByVal Value As DateTime)
            str计划制定日期2 = Value
        End Set
    End Property
    Public Property 原材料编号() As String
        Get
            Return str原材料编号
        End Get
        Set(ByVal Value As String)
            str原材料编号 = Value
        End Set
    End Property

    Public Property 审核状态() As String
        Get
            Return str审核状态
        End Get
        Set(ByVal Value As String)
            str审核状态 = Value
        End Set
    End Property
    Public Property 审核人() As String
        Get
            Return str审核人
        End Get
        Set(ByVal Value As String)
            str审核人 = Value
        End Set
    End Property

    Public Property 实际带料数量() As String
        Get
            Return str实际带料数量
        End Get
        Set(ByVal Value As String)
            str实际带料数量 = Value
        End Set
    End Property
    Public Property 加工单价() As String
        Get
            Return str加工单价
        End Get
        Set(ByVal Value As String)
            str加工单价 = Value
        End Set
    End Property
    Public Property 加工总金额() As String
        Get
            Return str加工总金额
        End Get
        Set(ByVal Value As String)
            str加工总金额 = Value
        End Set
    End Property

    Public Property 备注() As String
        Get
            Return str备注
        End Get
        Set(ByVal Value As String)
            str备注 = Value
        End Set
    End Property
    Public Property 审核备注() As String
        Get
            Return str审核备注
        End Get
        Set(ByVal Value As String)
            str审核备注 = Value
        End Set
    End Property
    Public Property 区分() As String
        Get
            Return str
        End Get
        Set(ByVal Value As String)
            str = Value
        End Set
    End Property
    Public Property 区分1() As String
        Get
            Return str1
        End Get
        Set(ByVal Value As String)
            str1 = Value
        End Set
    End Property
End Class
