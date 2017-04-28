Public Class M原材料出入库记录


    Private str入出库编号 As String = ""

    Public Property 入出库编号() As String
        Get
            Return str入出库编号
        End Get
        Set(ByVal Value As String)
            str入出库编号 = Value
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


    Private str申请单编号 As String = ""

    Public Property 申请单编号() As String
        Get
            Return str申请单编号
        End Get
        Set(ByVal Value As String)
            str申请单编号 = Value
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


    Private str操作者编号 As String = ""

    Public Property 操作者编号() As String
        Get
            Return str操作者编号
        End Get
        Set(ByVal Value As String)
            str操作者编号 = Value
        End Set
    End Property


    Private str操作PDA编号 As String = ""

    Public Property 操作PDA编号() As String
        Get
            Return str操作PDA编号
        End Get
        Set(ByVal Value As String)
            str操作PDA编号 = Value
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
