﻿Public Class Z生产自检录入T

    Private _str订单编号 As String = String.Empty
    Private _str分图号 As String = String.Empty
    Private _str主图号 As String = String.Empty
    Private _str上级图号 As String = String.Empty
    Private _str人员编号 As String = String.Empty
    'Private _str部门编号 As String = String.Empty
    Private _str作业日期 As String = String.Empty
    Private _str自检日期sta As String = String.Empty
    Private _str自检日期end As String = String.Empty
    'Private _str作业开始日期 As String = String.Empty
    'Private _str作业结束日期 As String = String.Empty
    Private _str作业时间 As String = String.Empty
    Private _str作业指示 As String = String.Empty
    'Private _str作业结束时间 As String = String.Empty
    Private _str作业方式 As String = String.Empty
    Private _str作业者 As String = String.Empty
    Private _str本道工序编号 As String = String.Empty
    'Private _str上道工序 As String = String.Empty
    'Private _str下道工序 As String = String.Empty
    Private _str完成日期 As String = String.Empty
    'Private _str制造批量号 As String = String.Empty
    'Private _str设备编号 As String = String.Empty
    Private _str实际生产数 As String = String.Empty
    Private _str流转票编号 As String = String.Empty
    Private _str图纸尺寸 As String = String.Empty
    Private _str公差 As String = String.Empty
    Private _str自检时间 As String = String.Empty
    Private _str自检结果 As String = String.Empty
    Private _str备注 As String = String.Empty
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
    Public Property 上级图号() As String
        Get
            Return _str上级图号

        End Get
        Set(ByVal value As String)
            _str上级图号 = value
        End Set
    End Property

    ''' <summary>
    ''' 订单编号
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
    Public Property 自检日期sta() As String
        Get
            Return _str自检日期sta

        End Get
        Set(ByVal value As String)
            _str自检日期sta = value
        End Set
    End Property
    Public Property 自检日期end() As String
        Get
            Return _str自检日期end

        End Get
        Set(ByVal value As String)
            _str自检日期end = value
        End Set
    End Property
    Public Property 主图号() As String
        Get
            Return _str主图号

        End Get
        Set(ByVal value As String)
            _str主图号 = value
        End Set
    End Property
    Public Property 订单编号() As String
        Get
            Return _str订单编号

        End Get
        Set(ByVal value As String)
            _str订单编号 = value
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
    ''' 部门编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Property 部门编号() As String
    '    Get
    '        Return _str部门编号
    '    End Get
    '    Set(ByVal value As String)
    '        _str部门编号 = value
    '    End Set
    'End Property
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
    ''' 作业日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Property 作业开始日期() As String
    '    Get
    '        Return _str作业开始日期

    '    End Get
    '    Set(ByVal value As String)
    '        _str作业开始日期 = value
    '    End Set
    'End Property
    ''' <summary>
    ''' 作业日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Property 作业结束日期() As String
    '    Get
    '        Return _str作业结束日期

    '    End Get
    '    Set(ByVal value As String)
    '        _str作业结束日期 = value
    '    End Set
    'End Property
    ''' <summary>
    ''' 作业开始时间    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 作业时间() As String
        Get
            Return _str作业时间


        End Get
        Set(ByVal value As String)
            _str作业时间 = value
        End Set
    End Property
    '''' <summary>
    '''' 作业结束时间
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property 作业结束时间() As String
    '    Get
    '        Return _str作业结束时间
    '    End Get
    '    Set(ByVal value As String)
    '        _str作业结束时间 = value
    '    End Set
    'End Property

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
    ''' 本道工序编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 本道工序编号() As String
        Get
            Return _str本道工序编号

        End Get
        Set(ByVal value As String)
            _str本道工序编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 上道工序
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Property 上道工序() As String
    '    Get
    '        Return _str上道工序

    '    End Get
    '    Set(ByVal value As String)
    '        _str上道工序 = value
    '    End Set
    'End Property

    ''' <summary>
    ''' 下道工序
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Property 下道工序() As String
    '    Get
    '        Return _str下道工序

    '    End Get
    '    Set(ByVal value As String)
    '        _str下道工序 = value
    '    End Set
    'End Property

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
    'Public Property 制造批量号() As String
    '    Get
    '        Return _str制造批量号
    '    End Get
    '    Set(ByVal value As String)
    '        _str制造批量号 = value
    '    End Set
    'End Property

    ''' <summary>
    ''' 设备编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    'Public Property 设备编号() As String
    '    Get
    '        Return _str设备编号
    '    End Get
    '    Set(ByVal value As String)
    '        _str设备编号 = value
    '    End Set
    'End Property

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
