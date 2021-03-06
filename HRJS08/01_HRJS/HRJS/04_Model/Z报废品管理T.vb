#Region "Z报废品管理T基础类"
'   创建人: 李陈盛
'   创建日期: 2016/8/31
#End Region

Public Class Z报废品管理T

    '变量定义 
    Private str订单编号 As String = ""                  '订单编号
    Private str报废品图号 As String = ""                 '报废品图号
    Private str总图号 As String = ""                   '总图号
    Private str报废品产生工序 As String = ""                   '报废品产生工序
    Private int报废品数量 As Integer = 0                 '报废品数量
    Private str报废品生产者 As String = ""                    '报废品生产者
    Private dtm报废日期 As DateTime                     '报废日期
    Private str图片1 As String = ""                   '图片1
    Private str图片2 As String = ""                   '图片2
    Private str图片3 As String = ""                   '图片3
    Private str报废原因 As String = ""                  '报废原因
    Private str品质处理结果 As String = ""                    '品质处理结果
    Private str备注 As String = ""                    '备注 

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
    '  报废品图号
    '------------------------------------------------------------------------------------
    Public Property 报废品图号() As String
        Get
            Return str报废品图号
        End Get
        Set(ByVal Value As String)
            str报废品图号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  总图号
    '------------------------------------------------------------------------------------
    Public Property 总图号() As String
        Get
            Return str总图号
        End Get
        Set(ByVal Value As String)
            str总图号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  报废品产生工序
    '------------------------------------------------------------------------------------
    Public Property 报废品产生工序() As String
        Get
            Return str报废品产生工序
        End Get
        Set(ByVal Value As String)
            str报废品产生工序 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  报废品数量
    '------------------------------------------------------------------------------------
    Public Property 报废品数量() As Integer
        Get
            Return int报废品数量
        End Get
        Set(ByVal Value As Integer)
            int报废品数量 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  报废品生产者
    '------------------------------------------------------------------------------------
    Public Property 报废品生产者() As String
        Get
            Return str报废品生产者
        End Get
        Set(ByVal Value As String)
            str报废品生产者 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  报废日期
    '------------------------------------------------------------------------------------
    Public Property 报废日期() As DateTime
        Get
            Return dtm报废日期
        End Get
        Set(ByVal Value As DateTime)
            dtm报废日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  图片1
    '------------------------------------------------------------------------------------
    Public Property 图片1() As String
        Get
            Return str图片1
        End Get
        Set(ByVal Value As String)
            str图片1 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  图片2
    '------------------------------------------------------------------------------------
    Public Property 图片2() As String
        Get
            Return str图片2
        End Get
        Set(ByVal Value As String)
            str图片2 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  图片3
    '------------------------------------------------------------------------------------
    Public Property 图片3() As String
        Get
            Return str图片3
        End Get
        Set(ByVal Value As String)
            str图片3 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  报废原因
    '------------------------------------------------------------------------------------
    Public Property 报废原因() As String
        Get
            Return str报废原因
        End Get
        Set(ByVal Value As String)
            str报废原因 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  品质处理结果
    '------------------------------------------------------------------------------------
    Public Property 品质处理结果() As String
        Get
            Return str品质处理结果
        End Get
        Set(ByVal Value As String)
            str品质处理结果 = Value
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
