Public Class B出荷指示T

    '检索用
    Private str出荷指示编号 As String = ""
    Private str订单编号 As String
    Private str产品图号 As String = ""
    Private str出荷数量 As String = ""
    Private str出荷预定日 As DateTime
    Private str出荷预定日1 As DateTime
    Private str备注 As String = ""
    Private str出荷方式 As String = ""
    Private str客户编号 As String = ""
    Private str客户名称 As String = ""
    Private str订单数量 As String = ""


#Region "属性"

    Public Property 出荷指示编号() As String
        Get
            Return str出荷指示编号
        End Get
        Set(ByVal Value As String)
            str出荷指示编号 = Value
        End Set
    End Property
    Public Property 产品图号() As String
        Get
            Return str产品图号
        End Get
        Set(ByVal Value As String)
            str产品图号 = Value
        End Set
    End Property

    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal Value As String)
            str订单编号 = Value
        End Set
    End Property

    Public Property 出荷数量() As String
        Get
            Return str出荷数量

        End Get
        Set(ByVal Value As String)
            str出荷数量 = Value
        End Set
    End Property
    Public Property 出荷预定日() As DateTime
        Get
            Return str出荷预定日

        End Get
        Set(ByVal Value As DateTime)
            str出荷预定日 = Value
        End Set
    End Property
    Public Property 出荷预定日1() As DateTime
        Get
            Return str出荷预定日1

        End Get
        Set(ByVal Value As DateTime)
            str出荷预定日1 = Value
        End Set
    End Property
    Public Property 备注() As String
        Get
            Return str备注
        End Get
        Set(ByVal Value As String)
            str备注 = Value
        End Set
    End Property

    Public Property 出荷方式() As String
        Get
            Return str出荷方式
        End Get
        Set(ByVal Value As String)
            str出荷方式 = Value
        End Set
    End Property

    Public Property 客户编号() As String
        Get
            Return str客户编号
        End Get
        Set(ByVal Value As String)
            str客户编号 = Value
        End Set
    End Property
    Public Property 客户名称() As String
        Get
            Return str客户名称
        End Get
        Set(ByVal Value As String)
            str客户名称 = Value
        End Set
    End Property
    Public Property 订单数量() As String
        Get
            Return str订单数量
        End Get
        Set(ByVal Value As String)
            str订单数量 = Value
        End Set
    End Property

#End Region

End Class
