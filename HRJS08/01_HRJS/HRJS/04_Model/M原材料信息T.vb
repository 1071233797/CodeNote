Public Class M原材料信息T

    Private _str原材料编号 As String = String.Empty
    Private _str原材料名称 As String = String.Empty
    Private _str原材料区分 As String = String.Empty
    'Private _str批次号 As String = String.Empty
    Private _str材料种类 As String = String.Empty
    Private _str材料代号 As String = String.Empty
    Private _str重量 As String = String.Empty
    Private _str材质 As String = String.Empty
    Private _str长 As String = String.Empty
    Private _str宽 As String = String.Empty
    Private _str高 As String = String.Empty
    Private _str密度 As String = String.Empty
    Private _str供应商编号 As String = String.Empty
    Private _str税率 As String = String.Empty
    Private _str含税单价 As String = String.Empty
    Private _str未税单价 As String = String.Empty
    Private _str允许修改 As String = String.Empty

    ''' <summary>
    ''' 原材料编号    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 重量() As String
        Get
            Return _str重量

        End Get
        Set(ByVal value As String)
            _str重量 = value
        End Set
    End Property

    ''' <summary>
    ''' 原材料编号    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 材料代号() As String
        Get
            Return _str材料代号

        End Get
        Set(ByVal value As String)
            _str材料代号 = value
        End Set
    End Property

    ''' <summary>
    ''' 原材料编号    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 原材料编号() As String
        Get
            Return _str原材料编号
        End Get
        Set(ByVal value As String)
            _str原材料编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 原材料名称    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 原材料名称() As String
        Get
            Return _str原材料名称
        End Get
        Set(value As String)
            _str原材料名称 = value
        End Set
    End Property
    ''' <summary>
    ''' 原材料区分    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 原材料区分() As String
        Get
            Return _str原材料区分
        End Get
        Set(value As String)
            _str原材料区分 = value
        End Set
    End Property

    ''' <summary>
    ''' 类型
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 材料种类() As String
        Get
            Return _str材料种类
        End Get
        Set(ByVal value As String)
            _str材料种类 = value
        End Set
    End Property
    ''' <summary>
    ''' 材质
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 材质() As String
        Get
            Return _str材质
        End Get
        Set(value As String)
            _str材质 = value
        End Set
    End Property

    ''' <summary>
    ''' 材质
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 密度() As String
        Get
            Return _str密度
        End Get
        Set(value As String)
            _str密度 = value
        End Set
    End Property
    ''' <summary>
    ''' 长    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 长() As String
        Get
            Return _str长
        End Get
        Set(value As String)
            _str长 = value
        End Set
    End Property
    ''' <summary>
    ''' 宽    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 宽() As String
        Get
            Return _str宽
        End Get
        Set(value As String)
            _str宽 = value
        End Set
    End Property
    ''' <summary>
    ''' 高    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 高() As String
        Get
            Return _str高
        End Get
        Set(value As String)
            _str高 = value
        End Set
    End Property
    ''' <summary>
    ''' 供应商编号    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 供应商编号() As String
        Get
            Return _str供应商编号
        End Get
        Set(value As String)
            _str供应商编号 = value
        End Set
    End Property
    ''' <summary>
    ''' 税率
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 税率() As String
        Get
            Return _str税率
        End Get
        Set(value As String)
            _str税率 = value
        End Set
    End Property
    ''' <summary>
    ''' 含税单价
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 含税单价() As String
        Get
            Return _str含税单价
        End Get
        Set(value As String)
            _str含税单价 = value
        End Set
    End Property

    ''' <summary>
    ''' 含税单价
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 未税单价() As String
        Get
            Return _str未税单价
        End Get
        Set(value As String)
            _str未税单价 = value
        End Set
    End Property

    ''' <summary>
    ''' 允许修改
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 允许修改() As String
        Get
            Return _str允许修改
        End Get
        Set(value As String)
            _str允许修改 = value
        End Set
    End Property
End Class
