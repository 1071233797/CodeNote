Public Class M半成品库存

    Private str订单编号 As String = ""
    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal Value As String)
            str订单编号 = Value
        End Set
    End Property

    Private str主图号 As String = ""
    Public Property 主图号() As String
        Get
            Return str主图号
        End Get
        Set(ByVal Value As String)
            str主图号 = Value
        End Set
    End Property


    Private str上级图号 As String = ""
    Public Property 上级图号() As String
        Get
            Return str上级图号
        End Get
        Set(ByVal Value As String)
            str上级图号 = Value
        End Set
    End Property


    Private str分图号 As String = ""
    Public Property 分图号() As String
        Get
            Return str分图号
        End Get
        Set(ByVal Value As String)
            str分图号 = Value
        End Set
    End Property


    Private str工序编号 As String = ""
    Public Property 工序编号() As String
        Get
            Return str工序编号
        End Get
        Set(ByVal Value As String)
            str工序编号 = Value
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

    Private str半成品种类 As String = ""
    Public Property 半成品种类() As String
        Get
            Return str半成品种类
        End Get
        Set(ByVal Value As String)
            str半成品种类 = Value
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



End Class
