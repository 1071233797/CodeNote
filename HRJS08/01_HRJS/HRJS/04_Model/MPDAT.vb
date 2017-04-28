Public Class MPDAT

    Private _strPDA编号 As String
    Public Property PDA编号() As String
        Get
            Return _strPDA编号
        End Get
        Set(ByVal value As String)
            _strPDA编号 = value
        End Set
    End Property

    Private _strPDAIP As String
    Public Property PDAIP() As String
        Get
            Return _strPDAIP
        End Get
        Set(ByVal value As String)
            _strPDAIP = value
        End Set
    End Property

    Private _strPDA负责人编号 As String
    Public Property PDA负责人编号() As String
        Get
            Return _strPDA负责人编号
        End Get
        Set(ByVal value As String)
            _strPDA负责人编号 = value
        End Set
    End Property

    Private _strPDA负责人姓名 As String
    Public Property PDA负责人姓名() As String
        Get
            Return _strPDA负责人姓名
        End Get
        Set(ByVal value As String)
            _strPDA负责人姓名 = value
        End Set
    End Property

    Private _str联系电话 As String
    Public Property 联系电话() As String
        Get
            Return _str联系电话

        End Get
        Set(ByVal value As String)
            _str联系电话 = value
        End Set
    End Property

    Private _str邮箱 As String
    Public Property 邮箱() As String
        Get
            Return _str邮箱

        End Get
        Set(ByVal value As String)
            _str邮箱 = value
        End Set
    End Property
    Private _str备注 As String
    Public Property 备注() As String
        Get
            Return _str备注
        End Get
        Set(ByVal value As String)
            _str备注 = value
        End Set
    End Property

    Private _str登录者 As String
    Public Property 登录者() As String
        Get
            Return _str登录者
        End Get
        Set(ByVal value As String)
            _str登录者 = value
        End Set
    End Property

    Private _str登录日期 As String
    Public Property 登录日期() As String
        Get
            Return _str登录日期
        End Get
        Set(ByVal value As String)
            _str登录日期 = value
        End Set
    End Property

    Private _str更新者 As String
    Public Property 更新者() As String
        Get
            Return _str更新者
        End Get
        Set(ByVal value As String)
            _str更新者 = value
        End Set
    End Property

    Private _str更新日期 As String
    Public Property 更新日期() As String
        Get
            Return _str更新日期
        End Get
        Set(ByVal value As String)
            _str更新日期 = value
        End Set
    End Property

End Class
