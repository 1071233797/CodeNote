Public Class M半成品出入库记录

    Private str入出库记录CD As String = ""
    Public Property 入出库记录CD() As String
        Get
            Return str入出库记录CD
        End Get
        Set(ByVal Value As String)
            str入出库记录CD = Value
        End Set
    End Property



    Private str申请单编号 As String = ""
    Public Property 申请单编号() As String
        Get
            Return str申请单编号
        End Get
        Set(ByVal Value As String)
            str申请单编号 = Value
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


    Private str入出库区分 As String = ""
    Public Property 入出库区分() As String
        Get
            Return str入出库区分
        End Get
        Set(ByVal Value As String)
            str入出库区分 = Value
        End Set
    End Property



    Private str数量 As String = ""
    Public Property 数量() As String
        Get
            Return str数量
        End Get
        Set(ByVal Value As String)
            str数量 = Value
        End Set
    End Property

    Private str入出库日期 As String = ""
    Public Property 入出库日期() As String
        Get
            Return str入出库日期
        End Get
        Set(ByVal Value As String)
            str入出库日期 = Value
        End Set
    End Property

    Private str操作者编号 As String = ""
    Public Property 操作者编号() As String
        Get
            Return str操作者编号
        End Get
        Set(ByVal Value As String)
            str操作者编号 = Value
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
