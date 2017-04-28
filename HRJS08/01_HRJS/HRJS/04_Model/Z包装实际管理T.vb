Public Class Z包装实际管理T

    Private _str订单编号 As String = String.Empty
    Private _str产品图号 As String = String.Empty
    Private _str人员编号 As String = String.Empty
    Private _str部门编号 As String = String.Empty
    Private _str作业者 As String = String.Empty
    Private _str作业日期 As String = String.Empty
    Private _str作业开始时间 As String = String.Empty
    Private _str作业完成时间 As String = String.Empty
    Private _str作业方式 As String = String.Empty
    Private _str完成日期 As String = String.Empty
    Private _str制造批量号 As String = String.Empty
    Private _str实际生产数 As String = String.Empty
    Private _str流转票编号 As String = String.Empty
    Private _str作业指示 As String = String.Empty
    Private _str图纸尺寸 As String = String.Empty
    Private _str公差 As String = String.Empty
    Private _str自检时间 As String = String.Empty
    Private _str自检结果 As String = String.Empty
    Private _str自检结果自评 As String = String.Empty
    Private _str不良品数量 As String = String.Empty
    Private _str待修品数量 As String = String.Empty
    Private _str报废品数量 As String = String.Empty
    Private _str登陆者 As String = String.Empty
    Private _str登陆日期 As String = String.Empty
    Private _str更新者 As String = String.Empty
    Private _str更新日期 As String = String.Empty

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
    ''' 产品图号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 产品图号() As String
        Get
            Return _str产品图号

        End Get
        Set(ByVal value As String)
            _str产品图号 = value
        End Set
    End Property
    ''' <summary>
    ''' 人员编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 人员编号() As String
        Get
            Return _str人员编号
        End Get
        Set(ByVal value As String)
            _str人员编号 = value
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
        Set(ByVal value As String)
            _str作业者 = value
        End Set
    End Property
    ''' <summary>
    ''' 部门编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 部门编号() As String
        Get
            Return _str部门编号
        End Get
        Set(ByVal value As String)
            _str部门编号 = value
        End Set
    End Property
    ''' <summary>
    ''' 作业日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 作业日期() As String
        Get
            Return _str作业日期

        End Get
        Set(ByVal value As String)
            _str作业日期 = value
        End Set
    End Property
    ''' <summary>
    ''' 作业开始时间    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 作业开始时间() As String
        Get
            Return _str作业开始时间

        End Get
        Set(ByVal value As String)
            _str作业开始时间 = value
        End Set
    End Property
    ''' <summary>
    ''' 作业完成时间
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 作业完成时间() As String
        Get
            Return _str作业完成时间
        End Get
        Set(ByVal value As String)
            _str作业完成时间 = value
        End Set
    End Property

    ''' <summary>
    ''' 作业方式
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 作业方式() As String
        Get
            Return _str作业方式
        End Get
        Set(ByVal value As String)
            _str作业方式 = value
        End Set
    End Property

    ''' <summary>
    ''' 完成日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 完成日期() As String
        Get
            Return _str完成日期

        End Get
        Set(ByVal value As String)
            _str完成日期 = value
        End Set
    End Property

    ''' <summary>
    ''' 制造批量号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 制造批量号() As String
        Get
            Return _str制造批量号
        End Get
        Set(ByVal value As String)
            _str制造批量号 = value
        End Set
    End Property

    ''' <summary>
    ''' 实际生产数    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 实际生产数() As String
        Get
            Return _str实际生产数

        End Get
        Set(ByVal value As String)
            _str实际生产数 = value
        End Set
    End Property

    ''' <summary>
    ''' 流转票编号    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 流转票编号() As String
        Get
            Return _str流转票编号
        End Get
        Set(ByVal value As String)
            _str流转票编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 作业指示
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 作业指示() As String
        Get
            Return _str作业指示

        End Get
        Set(ByVal value As String)
            _str作业指示 = value
        End Set
    End Property
    ''' <summary>
    ''' 图纸尺寸
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 图纸尺寸() As String
        Get
            Return _str图纸尺寸
        End Get
        Set(ByVal value As String)
            _str图纸尺寸 = value
        End Set
    End Property

    ''' <summary>
    ''' 公差
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 公差() As String
        Get
            Return _str公差
        End Get
        Set(ByVal value As String)
            _str公差 = value
        End Set
    End Property

    ''' <summary>
    ''' 自检时间
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 自检时间() As String
        Get
            Return _str自检时间
        End Get
        Set(ByVal value As String)
            _str自检时间 = value
        End Set
    End Property

    ''' <summary>
    ''' 自检结果
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 自检结果() As String
        Get
            Return _str自检结果
        End Get
        Set(ByVal value As String)
            _str自检结果 = value
        End Set
    End Property

    ''' <summary>
    ''' 自检结果自评
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 自检结果自评() As String
        Get
            Return _str自检结果自评
        End Get
        Set(ByVal value As String)
            _str自检结果自评 = value
        End Set
    End Property

    ''' <summary>
    ''' 不良品数量    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 不良品数量() As String
        Get
            Return _str不良品数量
        End Get
        Set(ByVal value As String)
            _str不良品数量 = value
        End Set
    End Property

    ''' <summary>
    ''' 待修品数量    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 待修品数量() As String
        Get
            Return _str待修品数量
        End Get
        Set(ByVal value As String)
            _str待修品数量 = value
        End Set
    End Property

    ''' <summary>
    ''' 报废品数量    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 报废品数量() As String
        Get
            Return _str报废品数量
        End Get
        Set(ByVal value As String)
            _str报废品数量 = value
        End Set
    End Property

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
End Class
