Public Class ReportViewr

    'Private _entityOffer As M_OfferInfoT
    '''' <summary>
    '''' ������
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
    ''' ��������
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
    '''' ��עʵ����
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
    '''' ��עʬ����
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
    '''' ����ʵ����
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
    '''' ɰ��
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
    '''' label����
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
    '''' ��Ʒ����
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
    '''' ԭ���Ϸ���
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
    '''' ����
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
    '''' ����ʵ����
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


    Private _EntityOrg As M��תƱ����T
    ''' <summary>
    ''' ��תƱ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EntityOrg() As M��תƱ����T
        Get
            Return _EntityOrg
        End Get
        Set(ByVal value As M��תƱ����T)
            _EntityOrg = value
        End Set
    End Property
    Private ChuHe As B����ָʾT
    ''' <summary>
    ''' ��תƱ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _ChuHe() As B����ָʾT
        Get
            Return ChuHe
        End Get
        Set(ByVal value As B����ָʾT)
            ChuHe = value
        End Set
    End Property
    Private CaiGou As Bԭ���ϲɹ�����T
    ''' <summary>
    ''' ԭ���ϲɹ�
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _CaiGou() As Bԭ���ϲɹ�����T
        Get
            Return CaiGou
        End Get
        Set(ByVal value As Bԭ���ϲɹ�����T)
            CaiGou = value
        End Set
    End Property
    Private Raw As Zԭ���ϳ�������T
    ''' ԭ���ϳ���
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _Raw() As Zԭ���ϳ�������T
        Get
            Return Raw
        End Get
        Set(ByVal value As Zԭ���ϳ�������T)
            Raw = value
        End Set
    End Property

    Private CaiLiao As Bԭ���ϱ�ǩ��ӡT
    ''' <summary>
    ''' ԭ���ϱ�ǩ��ӡ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _CaiLiao() As Bԭ���ϱ�ǩ��ӡT
        Get
            Return CaiLiao
        End Get
        Set(ByVal value As Bԭ���ϱ�ǩ��ӡT)
            CaiLiao = value
        End Set
    End Property

    Private BanCheng As Z���Ʒ��ǩ��ӡ
    ''' <summary>
    ''' ���Ʒ��ǩ��ӡ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _BanCheng() As Z���Ʒ��ǩ��ӡ
        Get
            Return BanCheng
        End Get
        Set(ByVal value As Z���Ʒ��ǩ��ӡ)
            BanCheng = value
        End Set
    End Property

    Private ChengPen As Z��Ʒ��ǩ��ӡ
    ''' <summary>
    ''' ��Ʒ��ǩ��ӡ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _ChengPen() As Z��Ʒ��ǩ��ӡ
        Get
            Return ChengPen
        End Get
        Set(ByVal value As Z��Ʒ��ǩ��ӡ)
            ChengPen = value
        End Set
    End Property
    Private _dtSource As DataTable
    ''' <summary>
    ''' ����Դ
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
    ''' ��תƱ
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
       
        If ReportExportType = Constant.ReporyType.��תƱ Then
            Dim org As New ��������
            org.SetControlValue(DtOrg, DtSource)
            arvMain.Document = org.Document
            org.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.����ָʾ Then
            Dim chuhe As New ����
            chuhe.SetControlValue(DtOrg, DtSource)
            arvMain.Document = chuhe.Document
            chuhe.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.ԭ���ϲɹ��� Then
            Dim CaiGou As New ԭ���ϲɹ��ƻ���
            CaiGou.DataSource = DtSource
            'CaiGou.SetControlValue(DtSource)
            arvMain.Document = CaiGou.Document
            CaiGou.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.ԭ���ϳ��ⵥ Then
            Dim RawLibrary As New ԭ���ϳ��ⵥ
            RawLibrary.DataSource = DtSource
            'CaiGou.SetControlValue(DtSource)
            arvMain.Document = RawLibrary.Document
            RawLibrary.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.ԭ������ⵥ Then
            Dim ruKu As New ԭ���������ϸ
            ruKu.DataSource = DtSource
            'CaiGou.SetControlValue(DtSource)
            arvMain.Document = ruKu.Document
            ruKu.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.���Ʒ��ⵥ Then
            Dim bCP As New ���Ʒ�������
            bCP.DataSource = DtSource
            'CaiGou.SetControlValue(DtSource)
            arvMain.Document = bCP.Document
            bCP.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.��Ʒ��ⵥ Then
            Dim chengPinR As New ����Ʒ�����ϸ
            chengPinR.DataSource = DtSource
            'CaiGou.SetControlValue(DtSource)
            arvMain.Document = chengPinR.Document
            chengPinR.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.ԭ���ϱ�ǩ Then
            Dim CaiLiao1 As New ԭ����
            CaiLiao1.SetControlValue(CaiLiao)
            arvMain.Document = CaiLiao1.Document
            CaiLiao1.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.���Ʒ��ǩ Then
            Dim BanCheng As New ���Ʒ
            BanCheng.SetControlValue(_BanCheng)
            arvMain.Document = BanCheng.Document
            BanCheng.Run(False)
        End If
        If ReportExportType = Constant.ReporyType.��Ʒ��ǩ Then
            Dim ChengPen As New ��Ʒ
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