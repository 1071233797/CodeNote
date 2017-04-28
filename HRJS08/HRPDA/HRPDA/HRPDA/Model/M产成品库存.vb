Public Class M产成品库存

    Private str产品图号 As String = ""
    Public Property 产品图号() As String
        Get
            Return str产品图号
        End Get
        Set(ByVal Value As String)
            str产品图号 = Value
        End Set
    End Property

    Private str订单编号 As String = ""
    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal Value As String)
            str订单编号 = Value
        End Set
    End Property

    Private str库存数量 As String = ""
    Public Property 库存数量() As String
        Get
            Return str库存数量
        End Get
        Set(ByVal Value As String)
            str库存数量 = Value
        End Set
    End Property


    Private str库存重量 As String = ""
    Public Property 库存重量() As String
        Get
            Return str库存重量
        End Get
        Set(ByVal Value As String)
            str库存重量 = Value
        End Set
    End Property

    Private str库存状态 As String = ""
    Public Property 库存状态() As String
        Get
            Return str库存状态
        End Get
        Set(ByVal Value As String)
            str库存状态 = Value
        End Set
    End Property


    Private str库存区域 As String = ""
    Public Property 库存区域() As String
        Get
            Return str库存区域
        End Get
        Set(ByVal Value As String)
            str库存区域 = Value
        End Set
    End Property

    Private str入库日期 As String = ""
    Public Property 入库日期() As String
        Get
            Return str入库日期
        End Get
        Set(ByVal Value As String)
            str入库日期 = Value
        End Set
    End Property


End Class
