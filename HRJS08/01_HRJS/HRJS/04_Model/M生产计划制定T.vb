Public Class M生产计划制定T

    Private _str是否整体外协加工 As String = String.Empty
    Private _str是否抵补品 As String = String.Empty
    Private _str订单编号 As String = String.Empty
    Private _str投产数量 As String = String.Empty
    Private _str总件完成期限 As String = String.Empty
    Private _str小件完成期限 As String = String.Empty
    Private _str下达日期 As String = String.Empty
    Private _str工序编号 As String = String.Empty
    Private _str完成日1 As String
    Private _str完成日2 As String = String.Empty
    'Private _str完成日 As String = String.Empty
    'Private _str起始日 As String = String.Empty
    Private _str产品起始日 As String = String.Empty
    Private _str是否外协加工 As String = String.Empty
    Private _str外协数量 As String = String.Empty
    Private _str合格标准 As String = String.Empty
    Private _str作业者 As String = String.Empty
    Private _str是否为试做品 As String = String.Empty
    Private _str是否为组装品 As String = String.Empty
    Private _str产品状态 As String = String.Empty
    'Private _str生产计划制定状态 As String = String.Empty
    Private _str登陆者 As String = String.Empty
    Private _str登陆日期 As String = String.Empty
    Private _str更新者 As String = String.Empty
    Private _str更新日期 As String = String.Empty
    Private _str客户编号 As String = String.Empty
    Private _str分图号 As String = String.Empty
    Private _str主图号 As String = String.Empty
    Private _str上级图号 As String = String.Empty
    Private _str备注 As String = String.Empty
    Private _str备注1 As String = String.Empty
    Private _str外协理由 As String = String.Empty
    'Private _str制造批量号 As String = String.Empty

    ''' <summary>
    ''' 是否整体外协加工
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 是否整体外协加工() As String
        Get
            Return _str是否整体外协加工

        End Get
        Set(ByVal value As String)
            _str是否整体外协加工 = value
        End Set
    End Property
    ''' <summary>
    ''' 是否抵补品    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 是否抵补品() As String
        Get
            Return _str是否抵补品

        End Get
        Set(ByVal value As String)
            _str是否抵补品 = value
        End Set
    End Property
    ''' <summary>
    ''' 订单编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 订单编号() As String
        Get
            Return _str订单编号
        End Get
        Set(ByVal value As String)
            _str订单编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 投产数量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 投产数量() As String
        Get
            Return _str投产数量

        End Get
        Set(ByVal value As String)
            _str投产数量 = value
        End Set
    End Property
    ''' <summary>
    ''' 完成期限
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 总件完成期限() As String
        Get
            Return _str总件完成期限

        End Get
        Set(ByVal value As String)
            _str总件完成期限 = value
        End Set
    End Property

    ''' <summary>
    ''' 完成期限
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 小件完成期限() As String
        Get
            Return _str小件完成期限

        End Get
        Set(ByVal value As String)
            _str小件完成期限 = value
        End Set
    End Property
    ''' <summary>
    ''' 下达日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 下达日期() As String
        Get
            Return _str下达日期
        End Get
        Set(value As String)
            _str下达日期 = value
        End Set
    End Property

    ''' <summary>
    ''' 工序编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 工序编号() As String
        Get
            Return _str工序编号
        End Get
        Set(ByVal value As String)
            _str工序编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 完成日1
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 完成日1() As String
        Get
            Return _str完成日1

        End Get
        Set(ByVal value As String)
            _str完成日1 = value
        End Set
    End Property

    ''' <summary>
    ''' 完成日2
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 完成日2() As String

        Get
            Return _str完成日2

        End Get
        Set(ByVal value As String)
            _str完成日2 = value
        End Set
    End Property

    ''' <summary>
    ''' 产品起始日    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 产品起始日() As String
        Get
            Return _str产品起始日

        End Get
        Set(ByVal value As String)
            _str产品起始日 = value
        End Set
    End Property
    ''' <summary>
    ''' 是否外协加工
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 是否外协加工() As String
        Get
            Return _str是否外协加工


        End Get
        Set(ByVal value As String)
            _str是否外协加工 = value
        End Set
    End Property

    ''' <summary>
    ''' 外协数量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 外协数量() As String
        Get
            Return _str外协数量


        End Get
        Set(ByVal value As String)
            _str外协数量 = value
        End Set
    End Property
    ''' <summary>
    ''' 合格标准
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 合格标准() As String
        Get
            Return _str合格标准
        End Get
        Set(value As String)
            _str合格标准 = value
        End Set
    End Property

    ''' <summary>
    ''' 作业者    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 作业者() As String
        Get
            Return _str作业者

        End Get
        Set(value As String)
            _str作业者 = value
        End Set
    End Property

    ''' <summary>
    ''' 是否为试做品
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 是否为试做品() As String
        Get
            Return _str是否为试做品
        End Get
        Set(value As String)
            _str是否为试做品 = value
        End Set
    End Property

    ''' <summary>
    ''' 是否为组装品
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 是否为组装品() As String
        Get
            Return _str是否为组装品
        End Get
        Set(ByVal value As String)
            _str是否为组装品 = value
        End Set
    End Property
    ''' <summary>
    ''' 产品状态    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 产品状态() As String
        Get
            Return _str产品状态

        End Get
        Set(value As String)
            _str产品状态 = value
        End Set
    End Property

    '''' <summary>
    '''' 生产计划制定状态    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property 生产计划制定状态() As String
    '    Get
    '        Return _str生产计划制定状态
    '    End Get
    '    Set(ByVal value As String)
    '        _str生产计划制定状态 = value
    '    End Set
    'End Property

    ''' <summary>
    ''' 登陆者    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 登陆者() As String
        Get
            Return _str登陆者
        End Get
        Set(ByVal value As String)
            _str登陆者 = value
        End Set
    End Property

    ''' <summary>
    ''' 登陆日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 登陆日期() As String
        Get
            Return _str登陆日期
        End Get
        Set(ByVal value As String)
            _str登陆日期 = value
        End Set
    End Property

    ''' <summary>
    ''' 更新者    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 更新者() As String
        Get
            Return _str更新者
        End Get
        Set(ByVal value As String)
            _str更新者 = value
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
            Return _str更新日期
        End Get
        Set(ByVal value As String)
            _str更新日期 = value
        End Set
    End Property

    ''' <summary>
    ''' 客户编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 客户编号() As String
        Get
            Return _str客户编号
        End Get
        Set(ByVal value As String)
            _str客户编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 分图号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 分图号() As String
        Get
            Return _str分图号
        End Get
        Set(ByVal value As String)
            _str分图号 = value
        End Set
    End Property
    ''' <summary>
    ''' 主图号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 主图号() As String
        Get
            Return _str主图号
        End Get
        Set(ByVal value As String)
            _str主图号 = value
        End Set
    End Property
    ''' <summary>
    ''' 上级图号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 上级图号() As String
        Get
            Return _str上级图号

        End Get
        Set(ByVal value As String)
            _str上级图号 = value
        End Set
    End Property

    '''' <summary>
    '''' 制造批量号
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property 制造批量号() As String
    '    Get
    '        Return _str制造批量号
    '    End Get
    '    Set(ByVal value As String)
    '        _str制造批量号 = value
    '    End Set
    'End Property

    ''' <summary>
    ''' 备注
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 备注() As String
        Get
            Return _str备注
        End Get
        Set(ByVal value As String)
            _str备注 = value
        End Set
    End Property

    ''' <summary>
    ''' 备注1
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 备注1() As String
        Get
            Return _str备注1
        End Get
        Set(ByVal value As String)
            _str备注1 = value
        End Set
    End Property
    ''' <summary>
    ''' 外协理由
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 外协理由() As String
        Get
            Return _str外协理由
        End Get
        Set(ByVal value As String)
            _str外协理由 = value
        End Set
    End Property
End Class
