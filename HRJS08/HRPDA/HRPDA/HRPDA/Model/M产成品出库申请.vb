Public Class M产成品出库申请


    Private str出荷指示编号 As String = ""
    Public Property 出荷指示编号() As String
        Get
            Return str出荷指示编号
        End Get
        Set(ByVal Value As String)
            str出荷指示编号 = Value
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


    Private str出荷数量 As String = ""
    Public Property 出荷数量() As String
        Get
            Return str出荷数量
        End Get
        Set(ByVal Value As String)
            str出荷数量 = Value
        End Set
    End Property

    Private str出荷预定日 As String = ""
    Public Property 出荷预定日() As String
        Get
            Return str出荷预定日
        End Get
        Set(ByVal Value As String)
            str出荷预定日 = Value
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
