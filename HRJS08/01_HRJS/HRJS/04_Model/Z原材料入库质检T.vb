#Region "原材料出库申请基础类"
'   创建人: 李陈盛
'   创建日期: 2016/8/29
#End Region

Public Class B原材料入库质检T

    '变量定义 
    Private str申请单编号 As String = String.Empty
    Private str检查者编号 As String = String.Empty
    Private str订单编号 As String = String.Empty
    Private str材料编号 As String = String.Empty
    Private str长 As String = String.Empty
    Private str宽 As String = String.Empty
    Private str高 As String = String.Empty
    Private str检查日期 As String = String.Empty
    Private str检查内容 As String = String.Empty
    Private str检查数量 As String = String.Empty
    Private str不良数量 As String = String.Empty
    Private str不良原因 As String = String.Empty
    Private str处理结果 As String = String.Empty
    Private str检查日期S As DateTime
    Private str检查日期E As DateTime
    Private str备注 As String = String.Empty
    Public Property 检查者编号() As String
        Get
            Return str检查者编号
        End Get
        Set(ByVal Value As String)
            str检查者编号 = Value
        End Set
    End Property
  

    '------------------------------------------------------------------------------------
    '  申请单编号
    '------------------------------------------------------------------------------------
    Public Property 申请单编号() As String
        Get
            Return str申请单编号
        End Get
        Set(ByVal Value As String)
            str申请单编号 = Value
        End Set
    End Property


    '------------------------------------------------------------------------------------
    '  检查内容
    '------------------------------------------------------------------------------------
    Public Property 材料编号() As String
        Get
            Return str材料编号
        End Get
        Set(ByVal Value As String)
            str材料编号 = Value
        End Set
    End Property
    Public Property 长() As String
        Get
            Return str长
        End Get
        Set(ByVal Value As String)
            str长 = Value
        End Set
    End Property
    Public Property 宽() As String
        Get
            Return str宽
        End Get
        Set(ByVal Value As String)
            str宽 = Value
        End Set
    End Property
    Public Property 高() As String
        Get
            Return str高
        End Get
        Set(ByVal Value As String)
            str高 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  str检查日期
    '------------------------------------------------------------------------------------
    Public Property 检查日期() As String
        Get
            Return str检查日期
        End Get
        Set(ByVal Value As String)
            str检查日期 = Value
        End Set
    End Property

    Public Property 检查日期S() As DateTime
        Get
            Return str检查日期S
        End Get
        Set(ByVal Value As DateTime)
            str检查日期S = Value
        End Set
    End Property
    Public Property 检查日期E() As DateTime
        Get
            Return str检查日期E
        End Get
        Set(ByVal Value As DateTime)
            str检查日期E = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  str检查日期
    '------------------------------------------------------------------------------------
    Public Property 检查内容() As String
        Get
            Return str检查内容
        End Get
        Set(ByVal Value As String)
            str检查内容 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  str检查数量
    '------------------------------------------------------------------------------------
    Public Property 检查数量() As String
        Get
            Return str检查数量
        End Get
        Set(ByVal Value As String)
            str检查数量 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  str检查日期
    '------------------------------------------------------------------------------------
    Public Property 不良数量() As String
        Get
            Return str不良数量
        End Get
        Set(ByVal Value As String)
            str不良数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  不良原因
    '------------------------------------------------------------------------------------
    Public Property 不良原因() As String
        Get
            Return str不良原因
        End Get
        Set(ByVal Value As String)
            str不良原因 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  处理结果
    '------------------------------------------------------------------------------------
    Public Property 处理结果() As String
        Get
            Return str处理结果
        End Get
        Set(ByVal Value As String)
            str处理结果 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  订单编号
    '------------------------------------------------------------------------------------
    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal Value As String)
            str订单编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  备注
    '------------------------------------------------------------------------------------
    Public Property 备注() As String
        Get
            Return str备注
        End Get
        Set(ByVal Value As String)
            str备注 = Value
        End Set
    End Property


End Class
