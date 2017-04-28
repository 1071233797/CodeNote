Public Class B报废品T

    Private str报废品订单编号 As String = String.Empty
    Private str客户名称 As String = String.Empty
    Private str发货日期 As String = String.Empty
    Private str报废品图号 As String = String.Empty
    Private str总图号 As String = String.Empty
    Private str报废品产生工序 As String = String.Empty
    Private str报废品数量 As String = String.Empty
    Private str报废品生产者 As String = String.Empty
    Private str报废日期 As String = String.Empty
    Private _str报废日期起 As DateTime
    Private _str报废日期止 As DateTime
    Private _str报废原因 As String = String.Empty
    Private _str处理结果 As String = String.Empty
    Private _str备注 As String = String.Empty
    Private _strpic1 As String = String.Empty
    Private _strpic2 As String = String.Empty
    Private _strpic3 As String = String.Empty

    Private str登录者 As String = String.Empty
    Private str登录日期 As String = String.Empty
    Private str更新者 As String = String.Empty
    Private str更新日期 As String = String.Empty
    Public Property 报废品订单编号() As String
        Get
            Return str报废品订单编号

        End Get
        Set(ByVal value As String)
            str报废品订单编号 = value
        End Set
    End Property
    Public Property 报废日期起() As DateTime
        Get
            Return _str报废日期起

        End Get
        Set(ByVal value As DateTime)
            _str报废日期起 = value
        End Set
    End Property

    Public Property 报废日期止() As DateTime
        Get
            Return _str报废日期止
        End Get
        Set(ByVal value As DateTime)
            _str报废日期止 = value
        End Set
    End Property

    Public Property 客户名称() As String
        Get
            Return str客户名称

        End Get
        Set(ByVal value As String)
            str客户名称 = value
        End Set
    End Property
    Public Property 发货日期() As String
        Get
            Return str发货日期

        End Get
        Set(ByVal value As String)
            str发货日期 = value
        End Set
    End Property

    Public Property 报废品图号() As String
        Get
            Return str报废品图号

        End Get
        Set(ByVal value As String)
            str报废品图号 = value
        End Set
    End Property

    Public Property 总图号() As String
        Get
            Return str总图号

        End Get
        Set(ByVal value As String)
            str总图号 = value
        End Set
    End Property

    Public Property 报废品产生工序() As String
        Get
            Return str报废品产生工序

        End Get
        Set(ByVal value As String)
            str报废品产生工序 = value
        End Set
    End Property
    Public Property 报废品数量() As String
        Get
            Return str报废品数量

        End Get
        Set(ByVal value As String)
            str报废品数量 = value
        End Set
    End Property
    Public Property 报废品生产者() As String
        Get
            Return str报废品生产者

        End Get
        Set(ByVal value As String)
            str报废品生产者 = value
        End Set
    End Property

    Public Property 报废日期() As String
        Get
            Return str报废日期


        End Get
        Set(ByVal value As String)
            str报废日期 = value
        End Set
    End Property


    Public Property 报废原因() As String
        Get
            Return _str报废原因


        End Get
        Set(ByVal value As String)
            _str报废原因 = value
        End Set
    End Property
    Public Property 处理结果() As String
        Get
            Return _str处理结果


        End Get
        Set(ByVal value As String)
            _str处理结果 = value
        End Set
    End Property
    Public Property 备注() As String
        Get
            Return _str备注


        End Get
        Set(ByVal value As String)
            _str备注 = value
        End Set
    End Property

    Public Property 登录者() As String
        Get
            Return str登录者
        End Get
        Set(ByVal value As String)
            str登录者 = value
        End Set
    End Property

    ''' <summary>
    ''' 登录日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 登录日期() As String
        Get
            Return str登录日期
        End Get
        Set(ByVal value As String)
            str登录日期 = value
        End Set
    End Property

    Public Property 更新者()
        Get
            Return str更新者
        End Get
        Set(ByVal value)
            str更新者 = value
        End Set
    End Property

    ''' <summary>
    ''' 更新日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 更新日期() As String
        Get
            Return str更新日期
        End Get
        Set(ByVal value As String)
            str更新日期 = value
        End Set
    End Property
    Public Property pic1() As String
        Get
            Return _strpic1
        End Get
        Set(ByVal value As String)
            _strpic1 = value
        End Set
    End Property
    Public Property pic2() As String
        Get
            Return _strpic2
        End Get
        Set(ByVal value As String)
            _strpic2 = value
        End Set
    End Property
    Public Property pic3() As String
        Get
            Return _strpic3
        End Get
        Set(ByVal value As String)
            _strpic3 = value
        End Set
    End Property
End Class
