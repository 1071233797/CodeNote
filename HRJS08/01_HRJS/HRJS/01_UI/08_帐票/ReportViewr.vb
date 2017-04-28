Public Class ReportViewr

    'Private _entityOffer As M_OfferInfoT
    '''' <summary>
    '''' 见积书
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property entityOffer() As M_OfferInfoT
    '    Get
    '        Return _entityOffer
    '    End Get
    '    Set(ByVal value As M_OfferInfoT)
    '        _entityOffer = value
    '    End Set
    'End Property


    Private _reportExportType As Constant.ReporyType
    ''' <summary>
    ''' 导出类型
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReportExportType() As Constant.ReporyType
        Get
            Return _reportExportType
        End Get
        Set(ByVal value As Constant.ReporyType)
            _reportExportType = value
        End Set
    End Property


    'Private _entityPr As T_PurchasingRecordsT
    '''' <summary>
    '''' 发注实体类
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property EntityPr() As T_PurchasingRecordsT
    '    Get
    '        Return _entityPr
    '    End Get
    '    Set(ByVal value As T_PurchasingRecordsT)
    '        _entityPr = value
    '    End Set
    'End Property



    'Private _entityOi As T_OrderInfoT
    '''' <summary>
    '''' 受注尸体了
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property EntityOi() As T_OrderInfoT
    '    Get
    '        Return _entityOi
    '    End Get
    '    Set(ByVal value As T_OrderInfoT)
    '        _entityOi = value
    '    End Set
    'End Property


    'Private _entityOer As Other_EntityReport
    '''' <summary>
    '''' 其他实体类
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property EntityOer() As Other_EntityReport
    '    Get
    '        Return _entityOer
    '    End Get
    '    Set(ByVal value As Other_EntityReport)
    '        _entityOer = value
    '    End Set
    'End Property

    'Private _EntityWh As M_WheelManagementT
    '''' <summary>
    '''' 砂轮
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property EntityWh() As M_WheelManagementT
    '    Get
    '        Return _EntityWh
    '    End Get
    '    Set(ByVal value As M_WheelManagementT)
    '        _EntityWh = value
    '    End Set
    'End Property

    'Private _EntitySPR As T_SBoxPrintRecordT
    '''' <summary>
    '''' label发行
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property EntitySPR() As T_SBoxPrintRecordT
    '    Get
    '        Return _EntitySPR
    '    End Get
    '    Set(ByVal value As T_SBoxPrintRecordT)
    '        _EntitySPR = value
    '    End Set
    'End Property


    'Private _ProductRecords As M_ProductManagementT
    '''' <summary>
    '''' 制品发行
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property ProductRecords() As M_ProductManagementT
    '    Get
    '        Return _ProductRecords
    '    End Get
    '    Set(ByVal value As M_ProductManagementT)
    '        _ProductRecords = value
    '    End Set
    'End Property


    'Private _EntityMM As M_MaterialManagementT
    '''' <summary>
    '''' 原材料发行
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property EntityMM() As M_MaterialManagementT
    '    Get
    '        Return _EntityMM
    '    End Get
    '    Set(ByVal value As M_MaterialManagementT)
    '        _EntityMM = value
    '    End Set
    'End Property

    'Private _EntityPJ As T_OrderProcessT
    '''' <summary>
    '''' 工程
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property EntityPJ() As T_OrderProcessT
    '    Get
    '        Return _EntityPJ
    '    End Get
    '    Set(ByVal value As T_OrderProcessT)
    '        _EntityPJ = value
    '    End Set
    'End Property


    'Private _EntityNi As T_NetherlandIssueT
    '''' <summary>
    '''' 出荷实体类
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property EntityNi() As T_NetherlandIssueT
    '    Get
    '        Return _EntityNi
    '    End Get
    '    Set(ByVal value As T_NetherlandIssueT)
    '        _EntityNi = value
    '    End Set
    'End Property


    Private _EntityOrg As M流转票管理T
    ''' <summary>
    ''' 流转票
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EntityOrg() As M流转票管理T
        Get
            Return _EntityOrg
        End Get
        Set(ByVal value As M流转票管理T)
            _EntityOrg = value
        End Set
    End Property
    Private ChuHe As B出荷指示T
    ''' <summary>
    ''' 流转票
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _ChuHe() As B出荷指示T
        Get
            Return ChuHe
        End Get
        Set(ByVal value As B出荷指示T)
            ChuHe = value
        End Set
    End Property
    Private CaiGou As B原材料采购管理T
    ''' <summary>
    ''' 原材料采购
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _CaiGou() As B原材料采购管理T
        Get
            Return CaiGou
        End Get
        Set(ByVal value As B原材料采购管理T)
            CaiGou = value
        End Set
    End Property
    Private Raw As Z原材料出库申请T
    ''' 原材料出库
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _Raw() As Z原材料出库申请T
        Get
            Return Raw
        End Get
        Set(ByVal value As Z原材料出库申请T)
            Raw = value
        End Set
    End Property

    Private CaiLiao As B原材料标签打印T
    ''' <summary>
    ''' 原材料标签打印
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _CaiLiao() As B原材料标签打印T
        Get
            Return CaiLiao
        End Get
        Set(ByVal value As B原材料标签打印T)
            CaiLiao = value
        End Set
    End Property

    Private BanCheng As Z半成品标签打印
    ''' <summary>
    ''' 半成品标签打印
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _BanCheng() As Z半成品标签打印
        Get
            Return BanCheng
        End Get
        Set(ByVal value As Z半成品标签打印)
            BanCheng = value
        End Set
    End Property

    Private ChengPen As Z成品标签打印
    ''' <summary>
    ''' 成品标签打印
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _ChengPen() As Z成品标签打印
        Get
            Return ChengPen
        End Get
        Set(ByVal value As Z成品标签打印)
            ChengPen = value
        End Set
    End Property
    Private _dtSource As DataTable
    ''' <summary>
    ''' 数据源
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DtSource() As DataTable
        Get
            Return _dtSource
        End Get
        Set(ByVal value As DataTable)
            _dtSource = value
        End Set
    End Property

    Private _dtOrg As DataTable
    ''' <summary>
    ''' 流转票
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DtOrg() As DataTable
        Get
            Return _dtOrg
        End Get
        Set(ByVal value As DataTable)
            _dtOrg = value
        End Set
    End Property


    Private Sub ReportViewr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Init_Load()
    End Sub

    Public Sub Init_Load()
       
        If ReportExportType = Constant.ReporyType.流转票 Then
            Dim org As New 生产工序
            org.SetControlValue(DtOrg, DtSource)
            arvMain.Document = org.Document
            org.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.出荷指示 Then
            Dim chuhe As New 出荷
            chuhe.SetControlValue(DtOrg, DtSource)
            arvMain.Document = chuhe.Document
            chuhe.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.原材料采购单 Then
            Dim CaiGou As New 原材料采购计划单
            CaiGou.DataSource = DtSource
            'CaiGou.SetControlValue(DtSource)
            arvMain.Document = CaiGou.Document
            CaiGou.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.原材料出库单 Then
            Dim RawLibrary As New 原材料出库单
            RawLibrary.DataSource = DtSource
            'CaiGou.SetControlValue(DtSource)
            arvMain.Document = RawLibrary.Document
            RawLibrary.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.原材料入库单 Then
            Dim ruKu As New 原材料入库明细
            ruKu.DataSource = DtSource
            'CaiGou.SetControlValue(DtSource)
            arvMain.Document = ruKu.Document
            ruKu.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.半成品入库单 Then
            Dim bCP As New 半成品入库申请
            bCP.DataSource = DtSource
            'CaiGou.SetControlValue(DtSource)
            arvMain.Document = bCP.Document
            bCP.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.成品入库单 Then
            Dim chengPinR As New 产成品入库明细
            chengPinR.DataSource = DtSource
            'CaiGou.SetControlValue(DtSource)
            arvMain.Document = chengPinR.Document
            chengPinR.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.原材料标签 Then
            Dim CaiLiao1 As New 原材料
            CaiLiao1.SetControlValue(CaiLiao)
            arvMain.Document = CaiLiao1.Document
            CaiLiao1.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.半成品标签 Then
            Dim BanCheng As New 半成品
            BanCheng.SetControlValue(_BanCheng)
            arvMain.Document = BanCheng.Document
            BanCheng.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.成品标签 Then
            Dim ChengPen As New 成品
            ChengPen.SetControlValue(_ChengPen)
            arvMain.Document = ChengPen.Document
            ChengPen.Run(False)
        End If
    End Sub

    Public Sub Print(ByVal page As Integer)
        Dim pd = New PrintDialog()
        'pd.UseEXDialog = True

        'If pd.ShowDialog() = DialogResult.OK Then
        If Printing.PrinterSettings.InstalledPrinters.Count = 0 Then
            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
            Exit Sub
        Else
            arvMain.Document.Printer.PrinterSettings.Copies = page
            arvMain.Document.Printer.PrinterSettings.PrinterName = pd.PrinterSettings.PrinterName
            arvMain.Document.Print(False, False)
        End If

    End Sub

    Public Sub PrintNote(ByVal page As Integer, ByVal ss As String)
        Dim pd = New PrintDialog()
        'pd.UseEXDialog = True

        'If pd.ShowDialog() = DialogResult.OK Then
        If Printing.PrinterSettings.InstalledPrinters.Count = 0 Then
            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
            Exit Sub
        Else
            arvMain.Document.Printer.PrinterSettings.Copies = page
            arvMain.Document.Printer.PrinterSettings.PrinterName = System.Configuration.ConfigurationManager.AppSettings.Get(ss)
            arvMain.Document.Print(False, False)
        End If

    End Sub
End Class