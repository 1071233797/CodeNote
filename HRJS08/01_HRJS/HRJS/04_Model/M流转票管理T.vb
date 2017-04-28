#Region "T流转票管理基础类"
'   创建人: 刘春广
'   创建日期: 2016/8/22
#End Region

Public Class M流转票管理T

    '变量定义 
    Private str产品图号 As String = ""                    '加工内容简介    Private str备注 As String = ""                    '加工内容简介
    Private str品名 As String = ""                    '加工内容简介    Private str图纸状态 As String = ""
    Private str是否为外协加工工序 As String = ""                  '是否整体外协加工
    Private str是否为组装品 As String = ""                    '是否为组装品
    Private str工序名称 As String = ""                    '是否为组装品 
    Private str工序编号 As String = ""                    '是否为组装品
    Private str加工内容简介 As String = ""                    '加工内容简介    Private str是否为试做品 As String = ""                    '是否为组装品
    Private str作业场所 As String = ""                  '作业场所
    Private str设备编号 As String = ""                  '设备编号
    Private str登陆者 As String = ""                   '登陆者    Private str登陆日期 As String                     '登陆日期
    Private str更新者 As String = ""                   '更新者    Private str更新日期 As String                     '更新日期
    Private _str图纸图片 As String
    Public Property 图纸图片() As String
        Get
            Return _str图纸图片
        End Get
        Set(ByVal value As String)
            _str图纸图片 = value
        End Set
    End Property

    Public Property 工序编号() As String
        Get
            Return str工序编号

        End Get
        Set(ByVal Value As String)
            str工序编号 = Value
        End Set
    End Property
    Public Property 图纸状态() As String
        Get
            Return str图纸状态

        End Get
        Set(ByVal Value As String)
            str图纸状态 = Value
        End Set
    End Property
    Public Property 备注() As String
        Get
            Return str备注

        End Get
        Set(ByVal Value As String)
            str备注 = Value
        End Set
    End Property
    Public Property 是否为试做品() As String
        Get
            Return str是否为试做品

        End Get
        Set(ByVal Value As String)
            str是否为试做品 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  加工内容简介
    '------------------------------------------------------------------------------------
    Public Property 加工内容简介() As String
        Get
            Return str加工内容简介
        End Get
        Set(ByVal Value As String)
            str加工内容简介 = Value
        End Set
    End Property



    '------------------------------------------------------------------------------------
    '  产品图号

    '------------------------------------------------------------------------------------
    Public Property 产品图号() As String
        Get
            Return str产品图号

        End Get
        Set(ByVal Value As String)
            str产品图号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  产品图号

    '------------------------------------------------------------------------------------
    Public Property 品名() As String
        Get
            Return str品名

        End Get
        Set(ByVal Value As String)
            str品名 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  作业场所
    '------------------------------------------------------------------------------------
    Public Property 作业场所() As String
        Get
            Return str作业场所
        End Get
        Set(ByVal Value As String)
            str作业场所 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  设备编号
    '------------------------------------------------------------------------------------
    Public Property 设备编号() As String
        Get
            Return str设备编号
        End Get
        Set(ByVal Value As String)
            str设备编号 = Value
        End Set
    End Property


    '------------------------------------------------------------------------------------
    '  是否为外协加工工序
    '------------------------------------------------------------------------------------
    Public Property 是否为外协加工工序() As String
        Get
            Return str是否为外协加工工序
        End Get
        Set(ByVal Value As String)
            str是否为外协加工工序 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  是否为组装品
    '------------------------------------------------------------------------------------
    Public Property 是否为组装品() As String
        Get
            Return str是否为组装品
        End Get
        Set(ByVal Value As String)
            str是否为组装品 = Value
        End Set
    End Property


    '------------------------------------------------------------------------------------
    '  工序名称
    '------------------------------------------------------------------------------------
    Public Property 工序名称() As String
        Get
            Return str工序名称
        End Get
        Set(ByVal Value As String)
            str工序名称 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  登陆者
    '------------------------------------------------------------------------------------
    Public Property 登陆者() As String
        Get
            Return str登陆者
        End Get
        Set(ByVal Value As String)
            str登陆者 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  登陆日期
    '------------------------------------------------------------------------------------
    Public Property 登陆日期() As String
        Get
            Return str登陆日期
        End Get
        Set(ByVal Value As String)
            str登陆日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  更新者
    '------------------------------------------------------------------------------------
    Public Property 更新者() As String
        Get
            Return str更新者
        End Get
        Set(ByVal Value As String)
            str更新者 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  更新日期
    '------------------------------------------------------------------------------------
    Public Property 更新日期() As String
        Get
            Return str更新日期
        End Get
        Set(ByVal Value As String)
            str更新日期 = Value
        End Set
    End Property

End Class
