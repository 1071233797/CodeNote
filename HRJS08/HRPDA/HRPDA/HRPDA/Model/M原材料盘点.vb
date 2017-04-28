Public Class M原材料盘点
    Private str盘点CD As String = ""

    Public Property 盘点CD() As String
        Get
            Return str盘点CD
        End Get
        Set(ByVal Value As String)
            str盘点CD = Value
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


    Private str在库数量 As String = ""

    Public Property 在库数量() As String
        Get
            Return str在库数量
        End Get
        Set(ByVal Value As String)
            str在库数量 = Value
        End Set
    End Property


    Private str在库重量 As String = ""

    Public Property 在库重量() As String
        Get
            Return str在库重量
        End Get
        Set(ByVal Value As String)
            str在库重量 = Value
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


    Private str盘点重量 As String = ""

    Public Property 盘点重量() As String
        Get
            Return str盘点重量
        End Get
        Set(ByVal Value As String)
            str盘点重量 = Value
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

    Private str操作PDA As String = ""

    Public Property 操作PDA() As String
        Get
            Return str操作PDA
        End Get
        Set(ByVal Value As String)
            str操作PDA = Value
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
