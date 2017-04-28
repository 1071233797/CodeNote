Public Class M产成品出入库记录
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


    Private str入出库区分 As String = ""
    Public Property 入出库区分() As String
        Get
            Return str入出库区分
        End Get
        Set(ByVal Value As String)
            str入出库区分 = Value
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

    Private str库存状态 As String = ""
    Public Property 库存状态() As String
        Get
            Return str库存状态
        End Get
        Set(ByVal Value As String)
            str库存状态 = Value
        End Set
    End Property


    Private str入出库数量 As String = ""
    Public Property 入出库数量() As String
        Get
            Return str入出库数量
        End Get
        Set(ByVal Value As String)
            str入出库数量 = Value
        End Set
    End Property

    Private str入出库重量 As String = ""
    Public Property 入出库重量() As String
        Get
            Return str入出库重量
        End Get
        Set(ByVal Value As String)
            str入出库重量 = Value
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



    Private str库存区域 As String = ""
    Public Property 库存区域() As String
        Get
            Return str库存区域
        End Get
        Set(ByVal Value As String)
            str库存区域 = Value
        End Set
    End Property


    Private str操作者 As String = ""
    Public Property 操作者() As String
        Get
            Return str操作者
        End Get
        Set(ByVal Value As String)
            str操作者 = Value
        End Set
    End Property




    Private str操作PDA As String = ""
    Public Property 操作PDA() As String
        Get
            Return str操作PDA
        End Get
        Set(ByVal Value As String)
            str操作PDA = Value
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
