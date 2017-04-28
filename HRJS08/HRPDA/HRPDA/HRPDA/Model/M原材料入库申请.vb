Public Class M原材料入库申请

    Private str申请单编号 As String = ""
    Public Property 申请单编号() As String
        Get
            Return str申请单编号
        End Get
        Set(ByVal Value As String)
            str申请单编号 = Value
        End Set
    End Property

    Private str采购单编号 As String = ""
    Public Property 采购单编号() As String
        Get
            Return str采购单编号
        End Get
        Set(ByVal Value As String)
            str采购单编号 = Value
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

End Class
