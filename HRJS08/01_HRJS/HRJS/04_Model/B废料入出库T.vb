Public Class B废料入出库T

    Private str废料产生工序 As String = String.Empty
    Private str废料数量 As String = String.Empty
    Private str原材料名称 As String = String.Empty
    Private str原材料编号 As String = String.Empty
    Private str原材料规格 As String = String.Empty
    Private str原材料批号 As String = String.Empty
    Private str回收日期 As String = String.Empty
    Private str回收日期起 As DateTime
    Private str回收日期止 As DateTime

    Private str入出库区分 As String = String.Empty
    Private str备注 As String = String.Empty
    Private str登录者 As String = String.Empty
    Private str登录日期 As String = String.Empty
    Private str更新者 As String = String.Empty
    Private str更新日期 As String = String.Empty
    Public Property 回收日期起() As DateTime
        Get
            Return str回收日期起

        End Get
        Set(ByVal value As DateTime)
            str回收日期起 = value
        End Set
    End Property
    Public Property 回收日期止() As DateTime
        Get
            Return str回收日期止

        End Get
        Set(ByVal value As DateTime)
            str回收日期止 = value
        End Set
    End Property
    Public Property 备注() As String
        Get
            Return str备注


        End Get
        Set(ByVal value As String)
            str备注 = value
        End Set
    End Property
    Public Property 废料产生工序() As String
        Get
            Return str废料产生工序


        End Get
        Set(ByVal value As String)
            str废料产生工序 = value
        End Set
    End Property
    Public Property 入出库区分() As String
        Get
            Return str入出库区分

        End Get
        Set(ByVal value As String)
            str入出库区分 = value
        End Set
    End Property
    Public Property 废料数量() As String
        Get
            Return str废料数量


        End Get
        Set(ByVal value As String)
            str废料数量 = value
        End Set
    End Property
   
    Public Property 原材料名称() As String
        Get
            Return str原材料名称
        End Get
        Set(ByVal value As String)
            str原材料名称 = value
        End Set
    End Property

    Public Property 原材料编号() As String
        Get
            Return str原材料编号

        End Get
        Set(ByVal value As String)
            str原材料编号 = value
        End Set
    End Property
    Public Property 原材料规格() As String
        Get
            Return str原材料规格

        End Get
        Set(ByVal value As String)
            str原材料规格 = value
        End Set
    End Property

    Public Property 原材料批号() As String
        Get
            Return str原材料批号

        End Get
        Set(ByVal value As String)
            str原材料批号 = value
        End Set
    End Property

    Public Property 回收日期() As String
        Get
            Return str回收日期

        End Get
        Set(ByVal value As String)
            str回收日期 = value
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
  
End Class
