#Region "成品入库质检基础类"
'   创建人: 李陈盛
'   创建日期: 2016/8/29
#End Region

Public Class Z成品入库质检T

    '变量定义 
    Private str申请单编号 As String = String.Empty
    'Private str申请者编号 As String = String.Empty
    Private str申请日期 As String = String.Empty
    Private str产品图号 As String = String.Empty
    Private str检查日期1 As DateTime
    Private str检查日期2 As DateTime
    Private str检查者编号 As String = String.Empty

    Private str不良数量 As String = String.Empty
    Private str不良原因 As String = String.Empty
    Private str检查内容 As String = String.Empty
    Private str检查数量 As String = String.Empty
    Private str订单编号 As String = String.Empty
    Private str备注 As String = String.Empty
    Private str处理结果 As String = String.Empty

    '------------------------------------------------------------------------------------
    '  检查者编号
    '------------------------------------------------------------------------------------
    Public Property 检查日期1() As DateTime
        Get
            Return str检查日期1
        End Get
        Set(ByVal Value As DateTime)
            str检查日期1 = Value
        End Set
    End Property
    Public Property 检查日期2() As DateTime
        Get
            Return str检查日期2
        End Get
        Set(ByVal Value As DateTime)
            str检查日期2 = Value
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
    Public Property 产品图号() As String
        Get
            Return str产品图号
        End Get
        Set(ByVal Value As String)
            str产品图号 = Value
        End Set
    End Property
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
    Public Property 处理结果() As String
        Get
            Return str处理结果
        End Get
        Set(ByVal Value As String)
            str处理结果 = Value
        End Set
    End Property

End Class
