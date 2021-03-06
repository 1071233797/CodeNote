#Region "原材料出库申请基础类"
'   创建人: 李陈盛
'   创建日期: 2016/8/29
#End Region

Public Class Z半成品入库质检T

    '变量定义 
    Private str申请单编号 As String = String.Empty
    Private str申请者编号 As String = String.Empty
    Private str申请日期 As String = String.Empty
    Private str分图号 As String = String.Empty
    Private str检查日期 As String = String.Empty
    Private str检查者编号 As String = String.Empty
    Private str上级图号 As String = String.Empty
    Private str不良数量 As String = String.Empty
    Private str不良原因 As String = String.Empty
    Private str检查内容 As String = String.Empty
    Private str检查数量 As String = String.Empty
    ' Private str处理结果结果 As String = String.Empty
    Private str订单编号 As String = String.Empty
    Private str备注 As String = String.Empty
   
    Private str工序编号 As String = String.Empty
   
    Private str主图号 As String = String.Empty
    Private str入库数量 As String = String.Empty

    Private str处理结果 As String = String.Empty
    Private str检查日期S As DateTime
    Private str检查日期E As DateTime

    '------------------------------------------------------------------------------------
    '  产品图号
    '------------------------------------------------------------------------------------
    Public Property 上级图号() As String
        Get
            Return str上级图号
        End Get
        Set(ByVal Value As String)
            str上级图号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  检查者编号
    '------------------------------------------------------------------------------------
    Public Property 检查日期S() As DateTime
        Get
            Return str检查日期S
        End Get
        Set(ByVal Value As DateTime)
            str检查日期S = Value
        End Set
    End Property
    Public Property 检查日期E() As DateTime
        Get
            Return str检查日期E
        End Get
        Set(ByVal Value As DateTime)
            str检查日期E = Value
        End Set
    End Property
    Public Property 检查日期() As String
        Get
            Return str检查日期
        End Get
        Set(ByVal Value As String)
            str检查日期 = Value
        End Set
    End Property

    Public Property 检查者编号() As String
        Get
            Return str检查者编号
        End Get
        Set(ByVal Value As String)
            str检查者编号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  异常数量
    '------------------------------------------------------------------------------------
    Public Property 不良数量() As String
        Get
            Return str不良数量
        End Get
        Set(ByVal Value As String)
            str不良数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  异常数量
    '------------------------------------------------------------------------------------
    Public Property 检查数量() As String
        Get
            Return str检查数量
        End Get
        Set(ByVal Value As String)
            str检查数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  异常数量
    '------------------------------------------------------------------------------------
    Public Property 检查内容() As String
        Get
            Return str检查内容
        End Get
        Set(ByVal Value As String)
            str检查内容 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  异常原因
    '------------------------------------------------------------------------------------
    Public Property 不良原因() As String
        Get
            Return str不良原因
        End Get
        Set(ByVal Value As String)
            str不良原因 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  备注
    '------------------------------------------------------------------------------------
    Public Property 备注() As String
        Get
            Return str备注
        End Get
        Set(ByVal Value As String)
            str备注 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  工序名称
    '------------------------------------------------------------------------------------
    Public Property 工序编号() As String
        Get
            Return str工序编号
        End Get
        Set(ByVal Value As String)
            str工序编号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  申请单编号
    '------------------------------------------------------------------------------------
    Public Property 申请单编号() As String
        Get
            Return str申请单编号
        End Get
        Set(ByVal Value As String)
            str申请单编号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  领料者编号
    '------------------------------------------------------------------------------------
    Public Property 申请者编号() As String
        Get
            Return str申请者编号
        End Get
        Set(ByVal Value As String)
            str申请者编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  申请日期
    '------------------------------------------------------------------------------------
    Public Property 申请日期() As String
        Get
            Return str申请日期
        End Get
        Set(ByVal Value As String)
            str申请日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  产品图号
    '------------------------------------------------------------------------------------
    Public Property 分图号() As String
        Get
            Return str分图号
        End Get
        Set(ByVal Value As String)
            str分图号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  str半成品名称
    '------------------------------------------------------------------------------------
   
    '------------------------------------------------------------------------------------
    '  入库数量
    '------------------------------------------------------------------------------------
    Public Property 入库数量() As String
        Get
            Return str入库数量
        End Get
        Set(ByVal Value As String)
            str入库数量 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  客户名称
    '------------------------------------------------------------------------------------
   

    '------------------------------------------------------------------------------------
    '  订单编号
    '------------------------------------------------------------------------------------
    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal Value As String)
            str订单编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  主图号
    '------------------------------------------------------------------------------------
    Public Property 主图号() As String
        Get
            Return str主图号
        End Get
        Set(ByVal Value As String)
            str主图号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    Public Property 处理结果() As String
        Get
            Return str处理结果
        End Get
        Set(ByVal Value As String)
            str处理结果 = Value
        End Set
    End Property

End Class
