Public Class M半成品出库申请

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

    Private str出库数量 As String = ""
    Public Property 出库数量() As String
        Get
            Return str出库数量
        End Get
        Set(ByVal Value As String)
            str出库数量 = Value
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



    Private str备注 As String = ""
    Public Property 备注() As String
        Get
            Return str备注
        End Get
        Set(ByVal Value As String)
            str备注 = Value
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


End Class
