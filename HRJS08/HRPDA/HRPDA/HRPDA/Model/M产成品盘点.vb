Public Class M产成品盘点
    Private str盘点CD As String = ""
    Public Property 盘点CD() As String
        Get
            Return str盘点CD
        End Get
        Set(ByVal Value As String)
            str盘点CD = Value
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


    Private str盘点日期 As String = ""
    Public Property 盘点日期() As String
        Get
            Return str盘点日期
        End Get
        Set(ByVal Value As String)
            str盘点日期 = Value
        End Set
    End Property


    Private str盘点人编号 As String = ""
    Public Property 盘点人编号() As String
        Get
            Return str盘点人编号
        End Get
        Set(ByVal Value As String)
            str盘点人编号 = Value
        End Set
    End Property


    Private str盘点数量 As String = ""
    Public Property 盘点数量() As String
        Get
            Return str盘点数量
        End Get
        Set(ByVal Value As String)
            str盘点数量 = Value
        End Set
    End Property


    Private str在库数量 As String = ""
    Public Property 在库数量() As String
        Get
            Return str在库数量
        End Get
        Set(ByVal Value As String)
            str在库数量 = Value
        End Set
    End Property




    Private str盘点重量 As String = "0"
    Public Property 盘点重量() As String
        Get
            Return str盘点重量
        End Get
        Set(ByVal Value As String)
            str盘点重量 = Value
        End Set
    End Property


    Private str在库重量 As String = "0"
    Public Property 在库重量() As String
        Get
            Return str在库重量
        End Get
        Set(ByVal Value As String)
            str在库重量 = Value
        End Set
    End Property




End Class
