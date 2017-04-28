<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptBox
    Inherits DataDynamics.ActiveReports.ActiveReport3

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptBox))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Bar二维码 = New DataDynamics.ActiveReports.Barcode
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.lbl数量 = New DataDynamics.ActiveReports.Label
        Me.lbl重量 = New DataDynamics.ActiveReports.Label
        Me.lbl材料编号 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.lbl批次号 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.lbl库存区域 = New DataDynamics.ActiveReports.Label
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl重量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl材料编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl批次号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl库存区域, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Height = 0.0!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.Line2, Me.Bar二维码, Me.Line1, Me.Label1, Me.Line4, Me.Label4, Me.lbl数量, Me.lbl重量, Me.lbl材料编号, Me.Label5, Me.Line8, Me.Line10, Me.Label6, Me.lbl批次号, Me.Label3, Me.lbl库存区域})
        Me.Detail1.Height = 2.791667!
        Me.Detail1.Name = "Detail1"
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 0.75!
        Me.Shape1.Left = 0.0625!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.0625!
        Me.Shape1.Width = 3.0!
        '
        'Line2
        '
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0625!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.25!
        Me.Line2.Width = 2.1875!
        Me.Line2.X1 = 0.0625!
        Me.Line2.X2 = 2.25!
        Me.Line2.Y1 = 0.25!
        Me.Line2.Y2 = 0.25!
        '
        'Bar二维码
        '
        Me.Bar二维码.Border.BottomColor = System.Drawing.Color.Black
        Me.Bar二维码.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Bar二维码.Border.LeftColor = System.Drawing.Color.Black
        Me.Bar二维码.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Bar二维码.Border.RightColor = System.Drawing.Color.Black
        Me.Bar二维码.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Bar二维码.Border.TopColor = System.Drawing.Color.Black
        Me.Bar二维码.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Bar二维码.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Bar二维码.Height = 0.75!
        Me.Bar二维码.Left = 3.125!
        Me.Bar二维码.Name = "Bar二维码"
        Me.Bar二维码.Style = DataDynamics.ActiveReports.BarCodeStyle.QRCode
        Me.Bar二维码.Text = "Barcode1"
        Me.Bar二维码.Top = 0.0625!
        Me.Bar二维码.Width = 0.75!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.75!
        Me.Line1.Left = 0.6875!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0625!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 0.6875!
        Me.Line1.X2 = 0.6875!
        Me.Line1.Y1 = 0.0625!
        Me.Line1.Y2 = 0.8125!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0625!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.Label1.Text = "材料编号"
        Me.Label1.Top = 0.0625!
        Me.Label1.Width = 0.625!
        '
        'Line4
        '
        Me.Line4.Border.BottomColor = System.Drawing.Color.Black
        Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.LeftColor = System.Drawing.Color.Black
        Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.RightColor = System.Drawing.Color.Black
        Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.TopColor = System.Drawing.Color.Black
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0625!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.4375!
        Me.Line4.Width = 2.5!
        Me.Line4.X1 = 0.0625!
        Me.Line4.X2 = 2.5625!
        Me.Line4.Y1 = 0.4375!
        Me.Line4.Y2 = 0.4375!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.0625!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.Label4.Text = "数量"
        Me.Label4.Top = 0.25!
        Me.Label4.Width = 0.625!
        '
        'lbl数量
        '
        Me.lbl数量.Border.BottomColor = System.Drawing.Color.Black
        Me.lbl数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl数量.Border.LeftColor = System.Drawing.Color.Black
        Me.lbl数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl数量.Border.RightColor = System.Drawing.Color.Black
        Me.lbl数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl数量.Border.TopColor = System.Drawing.Color.Black
        Me.lbl数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl数量.Height = 0.1875!
        Me.lbl数量.HyperLink = Nothing
        Me.lbl数量.Left = 0.6875!
        Me.lbl数量.Name = "lbl数量"
        Me.lbl数量.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.lbl数量.Text = "lbl数量"
        Me.lbl数量.Top = 0.25!
        Me.lbl数量.Width = 0.8125!
        '
        'lbl重量
        '
        Me.lbl重量.Border.BottomColor = System.Drawing.Color.Black
        Me.lbl重量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl重量.Border.LeftColor = System.Drawing.Color.Black
        Me.lbl重量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl重量.Border.RightColor = System.Drawing.Color.Black
        Me.lbl重量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl重量.Border.TopColor = System.Drawing.Color.Black
        Me.lbl重量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl重量.Height = 0.1875!
        Me.lbl重量.HyperLink = Nothing
        Me.lbl重量.Left = 2.1875!
        Me.lbl重量.Name = "lbl重量"
        Me.lbl重量.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.lbl重量.Text = "lbl重量"
        Me.lbl重量.Top = 0.25!
        Me.lbl重量.Width = 0.875!
        '
        'lbl材料编号
        '
        Me.lbl材料编号.Border.BottomColor = System.Drawing.Color.Black
        Me.lbl材料编号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl材料编号.Border.LeftColor = System.Drawing.Color.Black
        Me.lbl材料编号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl材料编号.Border.RightColor = System.Drawing.Color.Black
        Me.lbl材料编号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl材料编号.Border.TopColor = System.Drawing.Color.Black
        Me.lbl材料编号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl材料编号.Height = 0.1875!
        Me.lbl材料编号.HyperLink = Nothing
        Me.lbl材料编号.Left = 0.6875!
        Me.lbl材料编号.Name = "lbl材料编号"
        Me.lbl材料编号.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.lbl材料编号.Text = "lbl材料编号"
        Me.lbl材料编号.Top = 0.0625!
        Me.lbl材料编号.Width = 2.375!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 1.5!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.Label5.Text = "重量"
        Me.Label5.Top = 0.25!
        Me.Label5.Width = 0.6875!
        '
        'Line8
        '
        Me.Line8.Border.BottomColor = System.Drawing.Color.Black
        Me.Line8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.LeftColor = System.Drawing.Color.Black
        Me.Line8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.RightColor = System.Drawing.Color.Black
        Me.Line8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.TopColor = System.Drawing.Color.Black
        Me.Line8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Height = 0.0!
        Me.Line8.Left = 0.0625!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.625!
        Me.Line8.Width = 3.0!
        Me.Line8.X1 = 0.0625!
        Me.Line8.X2 = 3.0625!
        Me.Line8.Y1 = 0.625!
        Me.Line8.Y2 = 0.625!
        '
        'Line10
        '
        Me.Line10.Border.BottomColor = System.Drawing.Color.Black
        Me.Line10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.LeftColor = System.Drawing.Color.Black
        Me.Line10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.RightColor = System.Drawing.Color.Black
        Me.Line10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.TopColor = System.Drawing.Color.Black
        Me.Line10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Height = 0.0!
        Me.Line10.Left = 0.0625!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.8125!
        Me.Line10.Width = 3.0!
        Me.Line10.X1 = 0.0625!
        Me.Line10.X2 = 3.0625!
        Me.Line10.Y1 = 0.8125!
        Me.Line10.Y2 = 0.8125!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.0625!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.Label6.Text = "批次"
        Me.Label6.Top = 0.4375!
        Me.Label6.Width = 0.625!
        '
        'lbl批次号
        '
        Me.lbl批次号.Border.BottomColor = System.Drawing.Color.Black
        Me.lbl批次号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl批次号.Border.LeftColor = System.Drawing.Color.Black
        Me.lbl批次号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl批次号.Border.RightColor = System.Drawing.Color.Black
        Me.lbl批次号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl批次号.Border.TopColor = System.Drawing.Color.Black
        Me.lbl批次号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl批次号.Height = 0.1875!
        Me.lbl批次号.HyperLink = Nothing
        Me.lbl批次号.Left = 0.6875!
        Me.lbl批次号.Name = "lbl批次号"
        Me.lbl批次号.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.lbl批次号.Text = "lbl批次号"
        Me.lbl批次号.Top = 0.4375!
        Me.lbl批次号.Width = 2.375!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.Label3.Text = "库存区域"
        Me.Label3.Top = 0.625!
        Me.Label3.Width = 0.625!
        '
        'lbl库存区域
        '
        Me.lbl库存区域.Border.BottomColor = System.Drawing.Color.Black
        Me.lbl库存区域.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl库存区域.Border.LeftColor = System.Drawing.Color.Black
        Me.lbl库存区域.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl库存区域.Border.RightColor = System.Drawing.Color.Black
        Me.lbl库存区域.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl库存区域.Border.TopColor = System.Drawing.Color.Black
        Me.lbl库存区域.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lbl库存区域.Height = 0.1875!
        Me.lbl库存区域.HyperLink = Nothing
        Me.lbl库存区域.Left = 0.6875!
        Me.lbl库存区域.Name = "lbl库存区域"
        Me.lbl库存区域.Style = "ddo-char-set: 0; font-size: 8.25pt; "
        Me.lbl库存区域.Text = "lbl库存区域"
        Me.lbl库存区域.Top = 0.625!
        Me.lbl库存区域.Width = 2.375!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'rptBox
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.0!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 5.9375!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        Me.WatermarkAlignment = DataDynamics.ActiveReports.PictureAlignment.TopLeft
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl重量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl材料编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl批次号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl库存区域, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Bar二维码 As DataDynamics.ActiveReports.Barcode
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents lbl数量 As DataDynamics.ActiveReports.Label
    Friend WithEvents lbl重量 As DataDynamics.ActiveReports.Label
    Friend WithEvents lbl材料编号 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line8 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line10 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents lbl批次号 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents lbl库存区域 As DataDynamics.ActiveReports.Label
End Class
