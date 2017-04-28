Public Class M原材料库存

    Private str材料编号 As String = ""

    Public Property 材料编号() As String
        Get
            Return str材料编号
        End Get
        Set(ByVal Value As String)
            str材料编号 = Value
        End Set
    End Property

    Private str批次号 As String = ""

    Public Property 批次号() As String
        Get
            Return str批次号
        End Get
        Set(ByVal Value As String)
            str批次号 = Value
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
