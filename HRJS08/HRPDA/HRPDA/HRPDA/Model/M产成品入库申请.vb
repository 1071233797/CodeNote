Public Class M产成品入库申请
    Private str申请单编号 As String = ""
    Public Property 申请单编号() As String
        Get
            Return str申请单编号
        End Get
        Set(ByVal Value As String)
            str申请单编号 = Value
        End Set
    End Property

    Private str申请者编号 As String = ""
    Public Property 申请者编号() As String
        Get
            Return str申请者编号
        End Get
        Set(ByVal Value As String)
            str申请者编号 = Value
        End Set
    End Property

    Private str申请日期 As String = ""
    Public Property 申请日期() As String
        Get
            Return str申请日期
        End Get
        Set(ByVal Value As String)
            str申请日期 = Value
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

    Private str产品图号 As String = ""
    Public Property 产品图号() As String
        Get
            Return str产品图号
        End Get
        Set(ByVal Value As String)
            str产品图号 = Value
        End Set
    End Property


    Private str入库数量 As String = ""
    Public Property 入库数量() As String
        Get
            Return str入库数量
        End Get
        Set(ByVal Value As String)
            str入库数量 = Value
        End Set
    End Property


    Private str入库重量 As String = ""
    Public Property 入库重量() As String
        Get
            Return str入库重量
        End Get
        Set(ByVal Value As String)
            str入库重量 = Value
        End Set
    End Property


    Private str备注 As String = ""
    Public Property 备注() As String
        Get
            Return str备注
        End Get
        Set(ByVal Value As String)
            str备注 = Value
        End Set
    End Property


End Class
