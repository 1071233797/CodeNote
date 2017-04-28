<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class 原材料出库单

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
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(原材料出库单))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txt品名 = New DataDynamics.ActiveReports.TextBox
        Me.txt订单号 = New DataDynamics.ActiveReports.TextBox
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.Line20 = New DataDynamics.ActiveReports.Line
        Me.txt材质 = New DataDynamics.ActiveReports.TextBox
        Me.Line28 = New DataDynamics.ActiveReports.Line
        Me.txt规格 = New DataDynamics.ActiveReports.TextBox
        Me.Line30 = New DataDynamics.ActiveReports.Line
        Me.Line31 = New DataDynamics.ActiveReports.Line
        Me.Line32 = New DataDynamics.ActiveReports.Line
        Me.txt重量 = New DataDynamics.ActiveReports.TextBox
        Me.txt备注 = New DataDynamics.ActiveReports.TextBox
        Me.Line33 = New DataDynamics.ActiveReports.Line
        Me.Line34 = New DataDynamics.ActiveReports.Line
        Me.txt图号 = New DataDynamics.ActiveReports.TextBox
        Me.Line35 = New DataDynamics.ActiveReports.Line
        Me.txt客户名称 = New DataDynamics.ActiveReports.TextBox
        Me.txt张数 = New DataDynamics.ActiveReports.TextBox
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line21 = New DataDynamics.ActiveReports.Line
        Me.Line22 = New DataDynamics.ActiveReports.Line
        Me.Line25 = New DataDynamics.ActiveReports.Line
        Me.Line26 = New DataDynamics.ActiveReports.Line
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Line27 = New DataDynamics.ActiveReports.Line
        Me.Line29 = New DataDynamics.ActiveReports.Line
        Me.txt日期 = New DataDynamics.ActiveReports.TextBox
        Me.Barcode2 = New DataDynamics.ActiveReports.Barcode
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        CType(Me.txt品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt订单号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt材质, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt规格, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt重量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt张数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt品名, Me.txt订单号, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.txt材质, Me.Line28, Me.txt规格, Me.Line30, Me.Line31, Me.Line32, Me.txt重量, Me.txt备注, Me.Line33, Me.Line34, Me.txt图号, Me.Line35, Me.txt客户名称, Me.txt张数})
        Me.Detail1.Height = 0.4270833!
        Me.Detail1.Name = "Detail1"
        '
        'txt品名
        '
        Me.txt品名.Border.BottomColor = System.Drawing.Color.Black
        Me.txt品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt品名.Border.LeftColor = System.Drawing.Color.Black
        Me.txt品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt品名.Border.RightColor = System.Drawing.Color.Black
        Me.txt品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt品名.Border.TopColor = System.Drawing.Color.Black
        Me.txt品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt品名.DataField = "品名"
        Me.txt品名.Height = 0.25!
        Me.txt品名.Left = 3.75!
        Me.txt品名.Name = "txt品名"
        Me.txt品名.Style = ""
        Me.txt品名.Text = Nothing
        Me.txt品名.Top = 0.0!
        Me.txt品名.Width = 1.25!
        '
        'txt订单号
        '
        Me.txt订单号.Border.BottomColor = System.Drawing.Color.Black
        Me.txt订单号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt订单号.Border.LeftColor = System.Drawing.Color.Black
        Me.txt订单号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt订单号.Border.RightColor = System.Drawing.Color.Black
        Me.txt订单号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt订单号.Border.TopColor = System.Drawing.Color.Black
        Me.txt订单号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt订单号.DataField = "订单编号"
        Me.txt订单号.Height = 0.25!
        Me.txt订单号.Left = 5.0!
        Me.txt订单号.Name = "txt订单号"
        Me.txt订单号.Style = ""
        Me.txt订单号.Text = Nothing
        Me.txt订单号.Top = 0.0!
        Me.txt订单号.Width = 1.1875!
        '
        'Line17
        '
        Me.Line17.Border.BottomColor = System.Drawing.Color.Black
        Me.Line17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line17.Border.LeftColor = System.Drawing.Color.Black
        Me.Line17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line17.Border.RightColor = System.Drawing.Color.Black
        Me.Line17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line17.Border.TopColor = System.Drawing.Color.Black
        Me.Line17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line17.Height = 0.4375!
        Me.Line17.Left = 2.25!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.0!
        Me.Line17.Width = 0.0!
        Me.Line17.X1 = 2.25!
        Me.Line17.X2 = 2.25!
        Me.Line17.Y1 = 0.0!
        Me.Line17.Y2 = 0.4375!
        '
        'Line18
        '
        Me.Line18.Border.BottomColor = System.Drawing.Color.Black
        Me.Line18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.LeftColor = System.Drawing.Color.Black
        Me.Line18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.RightColor = System.Drawing.Color.Black
        Me.Line18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.TopColor = System.Drawing.Color.Black
        Me.Line18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Height = 0.4375!
        Me.Line18.Left = 3.75!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.0!
        Me.Line18.Width = 0.0!
        Me.Line18.X1 = 3.75!
        Me.Line18.X2 = 3.75!
        Me.Line18.Y1 = 0.0!
        Me.Line18.Y2 = 0.4375!
        '
        'Line19
        '
        Me.Line19.Border.BottomColor = System.Drawing.Color.Black
        Me.Line19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.LeftColor = System.Drawing.Color.Black
        Me.Line19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.RightColor = System.Drawing.Color.Black
        Me.Line19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.TopColor = System.Drawing.Color.Black
        Me.Line19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Height = 0.4375!
        Me.Line19.Left = 0.4375!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.0!
        Me.Line19.Width = 0.0!
        Me.Line19.X1 = 0.4375!
        Me.Line19.X2 = 0.4375!
        Me.Line19.Y1 = 0.0!
        Me.Line19.Y2 = 0.4375!
        '
        'Line20
        '
        Me.Line20.Border.BottomColor = System.Drawing.Color.Black
        Me.Line20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line20.Border.LeftColor = System.Drawing.Color.Black
        Me.Line20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line20.Border.RightColor = System.Drawing.Color.Black
        Me.Line20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line20.Border.TopColor = System.Drawing.Color.Black
        Me.Line20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line20.Height = 0.4375!
        Me.Line20.Left = 5.0!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0.0!
        Me.Line20.Width = 0.0!
        Me.Line20.X1 = 5.0!
        Me.Line20.X2 = 5.0!
        Me.Line20.Y1 = 0.0!
        Me.Line20.Y2 = 0.4375!
        '
        'txt材质
        '
        Me.txt材质.Border.BottomColor = System.Drawing.Color.Black
        Me.txt材质.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt材质.Border.LeftColor = System.Drawing.Color.Black
        Me.txt材质.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt材质.Border.RightColor = System.Drawing.Color.Black
        Me.txt材质.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt材质.Border.TopColor = System.Drawing.Color.Black
        Me.txt材质.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt材质.DataField = "材质"
        Me.txt材质.Height = 0.25!
        Me.txt材质.Left = 6.25!
        Me.txt材质.Name = "txt材质"
        Me.txt材质.Style = ""
        Me.txt材质.Text = Nothing
        Me.txt材质.Top = 0.0!
        Me.txt材质.Width = 0.5!
        '
        'Line28
        '
        Me.Line28.Border.BottomColor = System.Drawing.Color.Black
        Me.Line28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line28.Border.LeftColor = System.Drawing.Color.Black
        Me.Line28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line28.Border.RightColor = System.Drawing.Color.Black
        Me.Line28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line28.Border.TopColor = System.Drawing.Color.Black
        Me.Line28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line28.Height = 0.4375!
        Me.Line28.Left = 6.1875!
        Me.Line28.LineWeight = 1.0!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 0.0!
        Me.Line28.Width = 0.0!
        Me.Line28.X1 = 6.1875!
        Me.Line28.X2 = 6.1875!
        Me.Line28.Y1 = 0.0!
        Me.Line28.Y2 = 0.4375!
        '
        'txt规格
        '
        Me.txt规格.Border.BottomColor = System.Drawing.Color.Black
        Me.txt规格.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt规格.Border.LeftColor = System.Drawing.Color.Black
        Me.txt规格.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt规格.Border.RightColor = System.Drawing.Color.Black
        Me.txt规格.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt规格.Border.TopColor = System.Drawing.Color.Black
        Me.txt规格.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt规格.DataField = "规格"
        Me.txt规格.Height = 0.25!
        Me.txt规格.Left = 6.8125!
        Me.txt规格.Name = "txt规格"
        Me.txt规格.Style = ""
        Me.txt规格.Text = Nothing
        Me.txt规格.Top = 0.0!
        Me.txt规格.Width = 1.0625!
        '
        'Line30
        '
        Me.Line30.Border.BottomColor = System.Drawing.Color.Black
        Me.Line30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line30.Border.LeftColor = System.Drawing.Color.Black
        Me.Line30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line30.Border.RightColor = System.Drawing.Color.Black
        Me.Line30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line30.Border.TopColor = System.Drawing.Color.Black
        Me.Line30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line30.Height = 0.4375!
        Me.Line30.Left = 7.875!
        Me.Line30.LineWeight = 1.0!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 0.0!
        Me.Line30.Width = 0.0!
        Me.Line30.X1 = 7.875!
        Me.Line30.X2 = 7.875!
        Me.Line30.Y1 = 0.0!
        Me.Line30.Y2 = 0.4375!
        '
        'Line31
        '
        Me.Line31.Border.BottomColor = System.Drawing.Color.Black
        Me.Line31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line31.Border.LeftColor = System.Drawing.Color.Black
        Me.Line31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line31.Border.RightColor = System.Drawing.Color.Black
        Me.Line31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line31.Border.TopColor = System.Drawing.Color.Black
        Me.Line31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line31.Height = 0.4375!
        Me.Line31.Left = 6.75!
        Me.Line31.LineWeight = 1.0!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 0.0!
        Me.Line31.Width = 0.0!
        Me.Line31.X1 = 6.75!
        Me.Line31.X2 = 6.75!
        Me.Line31.Y1 = 0.0!
        Me.Line31.Y2 = 0.4375!
        '
        'Line32
        '
        Me.Line32.Border.BottomColor = System.Drawing.Color.Black
        Me.Line32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line32.Border.LeftColor = System.Drawing.Color.Black
        Me.Line32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line32.Border.RightColor = System.Drawing.Color.Black
        Me.Line32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line32.Border.TopColor = System.Drawing.Color.Black
        Me.Line32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line32.Height = 0.4375!
        Me.Line32.Left = 8.5625!
        Me.Line32.LineWeight = 1.0!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 0.0!
        Me.Line32.Width = 0.0!
        Me.Line32.X1 = 8.5625!
        Me.Line32.X2 = 8.5625!
        Me.Line32.Y1 = 0.0!
        Me.Line32.Y2 = 0.4375!
        '
        'txt重量
        '
        Me.txt重量.Border.BottomColor = System.Drawing.Color.Black
        Me.txt重量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt重量.Border.LeftColor = System.Drawing.Color.Black
        Me.txt重量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt重量.Border.RightColor = System.Drawing.Color.Black
        Me.txt重量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt重量.Border.TopColor = System.Drawing.Color.Black
        Me.txt重量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt重量.DataField = "重量"
        Me.txt重量.Height = 0.25!
        Me.txt重量.Left = 8.5625!
        Me.txt重量.Name = "txt重量"
        Me.txt重量.Style = ""
        Me.txt重量.Text = Nothing
        Me.txt重量.Top = 0.0!
        Me.txt重量.Width = 0.8125!
        '
        'txt备注
        '
        Me.txt备注.Border.BottomColor = System.Drawing.Color.Black
        Me.txt备注.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt备注.Border.LeftColor = System.Drawing.Color.Black
        Me.txt备注.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt备注.Border.RightColor = System.Drawing.Color.Black
        Me.txt备注.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt备注.Border.TopColor = System.Drawing.Color.Black
        Me.txt备注.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt备注.DataField = "备注"
        Me.txt备注.Height = 0.25!
        Me.txt备注.Left = 9.5625!
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Style = ""
        Me.txt备注.Text = Nothing
        Me.txt备注.Top = 0.0!
        Me.txt备注.Width = 1.0!
        '
        'Line33
        '
        Me.Line33.Border.BottomColor = System.Drawing.Color.Black
        Me.Line33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line33.Border.LeftColor = System.Drawing.Color.Black
        Me.Line33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line33.Border.RightColor = System.Drawing.Color.Black
        Me.Line33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line33.Border.TopColor = System.Drawing.Color.Black
        Me.Line33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line33.Height = 0.4375!
        Me.Line33.Left = 9.375!
        Me.Line33.LineWeight = 1.0!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 0.0!
        Me.Line33.Width = 0.0!
        Me.Line33.X1 = 9.375!
        Me.Line33.X2 = 9.375!
        Me.Line33.Y1 = 0.0!
        Me.Line33.Y2 = 0.4375!
        '
        'Line34
        '
        Me.Line34.Border.BottomColor = System.Drawing.Color.Black
        Me.Line34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line34.Border.LeftColor = System.Drawing.Color.Black
        Me.Line34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line34.Border.RightColor = System.Drawing.Color.Black
        Me.Line34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line34.Border.TopColor = System.Drawing.Color.Black
        Me.Line34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line34.Height = 0.4375!
        Me.Line34.Left = 10.5625!
        Me.Line34.LineWeight = 1.0!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 0.0!
        Me.Line34.Width = 0.0!
        Me.Line34.X1 = 10.5625!
        Me.Line34.X2 = 10.5625!
        Me.Line34.Y1 = 0.0!
        Me.Line34.Y2 = 0.4375!
        '
        'txt图号
        '
        Me.txt图号.Border.BottomColor = System.Drawing.Color.Black
        Me.txt图号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt图号.Border.LeftColor = System.Drawing.Color.Black
        Me.txt图号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt图号.Border.RightColor = System.Drawing.Color.Black
        Me.txt图号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt图号.Border.TopColor = System.Drawing.Color.Black
        Me.txt图号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt图号.DataField = "主图号"
        Me.txt图号.Height = 0.25!
        Me.txt图号.Left = 2.25!
        Me.txt图号.Name = "txt图号"
        Me.txt图号.Style = ""
        Me.txt图号.Text = Nothing
        Me.txt图号.Top = 0.0!
        Me.txt图号.Width = 1.4375!
        '
        'Line35
        '
        Me.Line35.Border.BottomColor = System.Drawing.Color.Black
        Me.Line35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line35.Border.LeftColor = System.Drawing.Color.Black
        Me.Line35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line35.Border.RightColor = System.Drawing.Color.Black
        Me.Line35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line35.Border.TopColor = System.Drawing.Color.Black
        Me.Line35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line35.Height = 0.0!
        Me.Line35.Left = 0.4375!
        Me.Line35.LineWeight = 1.0!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 0.4375!
        Me.Line35.Width = 10.125!
        Me.Line35.X1 = 0.4375!
        Me.Line35.X2 = 10.5625!
        Me.Line35.Y1 = 0.4375!
        Me.Line35.Y2 = 0.4375!
        '
        'txt客户名称
        '
        Me.txt客户名称.Border.BottomColor = System.Drawing.Color.Black
        Me.txt客户名称.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt客户名称.Border.LeftColor = System.Drawing.Color.Black
        Me.txt客户名称.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt客户名称.Border.RightColor = System.Drawing.Color.Black
        Me.txt客户名称.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt客户名称.Border.TopColor = System.Drawing.Color.Black
        Me.txt客户名称.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt客户名称.DataField = "客户名称"
        Me.txt客户名称.Height = 0.25!
        Me.txt客户名称.Left = 0.5!
        Me.txt客户名称.Name = "txt客户名称"
        Me.txt客户名称.Style = ""
        Me.txt客户名称.Text = Nothing
        Me.txt客户名称.Top = 0.0!
        Me.txt客户名称.Width = 1.75!
        '
        'txt张数
        '
        Me.txt张数.Border.BottomColor = System.Drawing.Color.Black
        Me.txt张数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt张数.Border.LeftColor = System.Drawing.Color.Black
        Me.txt张数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt张数.Border.RightColor = System.Drawing.Color.Black
        Me.txt张数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt张数.Border.TopColor = System.Drawing.Color.Black
        Me.txt张数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt张数.DataField = "张数"
        Me.txt张数.Height = 0.25!
        Me.txt张数.Left = 7.875!
        Me.txt张数.Name = "txt张数"
        Me.txt张数.Style = ""
        Me.txt张数.Text = Nothing
        Me.txt张数.Top = 0.0!
        Me.txt张数.Width = 0.625!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line3, Me.Line4, Me.Line6, Me.Label2, Me.Line8, Me.Label4, Me.Line10, Me.Line13, Me.Line21, Me.Line22, Me.Line25, Me.Line26, Me.Label5, Me.Label6, Me.Label9, Me.Label10, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Line27, Me.Line29, Me.txt日期, Me.Barcode2, Me.Label19})
        Me.GroupHeader1.DataField = "申请单编号"
        Me.GroupHeader1.Height = 1.069444!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'Line3
        '
        Me.Line3.Border.BottomColor = System.Drawing.Color.Black
        Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.LeftColor = System.Drawing.Color.Black
        Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.RightColor = System.Drawing.Color.Black
        Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.TopColor = System.Drawing.Color.Black
        Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.4375!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.75!
        Me.Line3.Width = 10.125!
        Me.Line3.X1 = 0.4375!
        Me.Line3.X2 = 10.5625!
        Me.Line3.Y1 = 0.75!
        Me.Line3.Y2 = 0.75!
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
        Me.Line4.Height = 0.3125!
        Me.Line4.Left = 2.25!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.75!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 2.25!
        Me.Line4.X2 = 2.25!
        Me.Line4.Y1 = 0.75!
        Me.Line4.Y2 = 1.0625!
        '
        'Line6
        '
        Me.Line6.Border.BottomColor = System.Drawing.Color.Black
        Me.Line6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.LeftColor = System.Drawing.Color.Black
        Me.Line6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.RightColor = System.Drawing.Color.Black
        Me.Line6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.TopColor = System.Drawing.Color.Black
        Me.Line6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Height = 0.3125!
        Me.Line6.Left = 8.5625!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.75!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 8.5625!
        Me.Line6.X2 = 8.5625!
        Me.Line6.Y1 = 0.75!
        Me.Line6.Y2 = 1.0625!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.3125!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 4.375!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "text-decoration: none; ddo-char-set: 0; font-weight: normal; font-size: 15.75pt; " & _
            ""
        Me.Label2.Text = "原 材 料 领 料 单"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 2.125!
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
        Me.Line8.Left = 0.4375!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.0625!
        Me.Line8.Width = 10.125!
        Me.Line8.X1 = 0.4375!
        Me.Line8.X2 = 10.5625!
        Me.Line8.Y1 = 1.0625!
        Me.Line8.Y2 = 1.0625!
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
        Me.Label4.Left = 1.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = ""
        Me.Label4.Text = "客户名称"
        Me.Label4.Top = 0.8125!
        Me.Label4.Width = 0.8125!
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
        Me.Line10.Height = 0.3125!
        Me.Line10.Left = 3.75!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.75!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 3.75!
        Me.Line10.X2 = 3.75!
        Me.Line10.Y1 = 0.75!
        Me.Line10.Y2 = 1.0625!
        '
        'Line13
        '
        Me.Line13.Border.BottomColor = System.Drawing.Color.Black
        Me.Line13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.LeftColor = System.Drawing.Color.Black
        Me.Line13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.RightColor = System.Drawing.Color.Black
        Me.Line13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.TopColor = System.Drawing.Color.Black
        Me.Line13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Height = 0.3125!
        Me.Line13.Left = 5.0!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.75!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 5.0!
        Me.Line13.X2 = 5.0!
        Me.Line13.Y1 = 0.75!
        Me.Line13.Y2 = 1.0625!
        '
        'Line21
        '
        Me.Line21.Border.BottomColor = System.Drawing.Color.Black
        Me.Line21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line21.Border.LeftColor = System.Drawing.Color.Black
        Me.Line21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line21.Border.RightColor = System.Drawing.Color.Black
        Me.Line21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line21.Border.TopColor = System.Drawing.Color.Black
        Me.Line21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line21.Height = 0.3125!
        Me.Line21.Left = 6.1875!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.75!
        Me.Line21.Width = 0.0!
        Me.Line21.X1 = 6.1875!
        Me.Line21.X2 = 6.1875!
        Me.Line21.Y1 = 0.75!
        Me.Line21.Y2 = 1.0625!
        '
        'Line22
        '
        Me.Line22.Border.BottomColor = System.Drawing.Color.Black
        Me.Line22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line22.Border.LeftColor = System.Drawing.Color.Black
        Me.Line22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line22.Border.RightColor = System.Drawing.Color.Black
        Me.Line22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line22.Border.TopColor = System.Drawing.Color.Black
        Me.Line22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line22.Height = 0.3125!
        Me.Line22.Left = 6.75!
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 0.75!
        Me.Line22.Width = 0.0!
        Me.Line22.X1 = 6.75!
        Me.Line22.X2 = 6.75!
        Me.Line22.Y1 = 0.75!
        Me.Line22.Y2 = 1.0625!
        '
        'Line25
        '
        Me.Line25.Border.BottomColor = System.Drawing.Color.Black
        Me.Line25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.LeftColor = System.Drawing.Color.Black
        Me.Line25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.RightColor = System.Drawing.Color.Black
        Me.Line25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.TopColor = System.Drawing.Color.Black
        Me.Line25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Height = 0.3125!
        Me.Line25.Left = 7.875!
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 0.75!
        Me.Line25.Width = 0.0!
        Me.Line25.X1 = 7.875!
        Me.Line25.X2 = 7.875!
        Me.Line25.Y1 = 0.75!
        Me.Line25.Y2 = 1.0625!
        '
        'Line26
        '
        Me.Line26.Border.BottomColor = System.Drawing.Color.Black
        Me.Line26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.LeftColor = System.Drawing.Color.Black
        Me.Line26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.RightColor = System.Drawing.Color.Black
        Me.Line26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.TopColor = System.Drawing.Color.Black
        Me.Line26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Height = 0.3125!
        Me.Line26.Left = 9.375!
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 0.75!
        Me.Line26.Width = 0.0!
        Me.Line26.X1 = 9.375!
        Me.Line26.X2 = 9.375!
        Me.Line26.Y1 = 0.75!
        Me.Line26.Y2 = 1.0625!
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
        Me.Label5.Left = 2.875!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = ""
        Me.Label5.Text = "图号"
        Me.Label5.Top = 0.8125!
        Me.Label5.Width = 0.375!
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
        Me.Label6.Left = 4.125!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = ""
        Me.Label6.Text = "品名"
        Me.Label6.Top = 0.8125!
        Me.Label6.Width = 0.5!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 5.1875!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = ""
        Me.Label9.Text = "订单号"
        Me.Label9.Top = 0.8125!
        Me.Label9.Width = 0.625!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.DataField = "材质"
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 6.3125!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = ""
        Me.Label10.Text = "材质"
        Me.Label10.Top = 0.8125!
        Me.Label10.Width = 0.375!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Height = 0.1875!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 7.0!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = ""
        Me.Label13.Text = "规   格"
        Me.Label13.Top = 0.8125!
        Me.Label13.Width = 0.625!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Height = 0.1875!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 8.0625!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = ""
        Me.Label14.Text = "张数"
        Me.Label14.Top = 0.8125!
        Me.Label14.Width = 0.4375!
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Height = 0.1875!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 8.8125!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = ""
        Me.Label15.Text = "重量"
        Me.Label15.Top = 0.8125!
        Me.Label15.Width = 0.4375!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Height = 0.1875!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 9.6875!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = ""
        Me.Label16.Text = "备   注"
        Me.Label16.Top = 0.8125!
        Me.Label16.Width = 0.5!
        '
        'Line27
        '
        Me.Line27.Border.BottomColor = System.Drawing.Color.Black
        Me.Line27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line27.Border.LeftColor = System.Drawing.Color.Black
        Me.Line27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line27.Border.RightColor = System.Drawing.Color.Black
        Me.Line27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line27.Border.TopColor = System.Drawing.Color.Black
        Me.Line27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line27.Height = 0.3125!
        Me.Line27.Left = 0.4375!
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 0.75!
        Me.Line27.Width = 0.0!
        Me.Line27.X1 = 0.4375!
        Me.Line27.X2 = 0.4375!
        Me.Line27.Y1 = 0.75!
        Me.Line27.Y2 = 1.0625!
        '
        'Line29
        '
        Me.Line29.Border.BottomColor = System.Drawing.Color.Black
        Me.Line29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line29.Border.LeftColor = System.Drawing.Color.Black
        Me.Line29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line29.Border.RightColor = System.Drawing.Color.Black
        Me.Line29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line29.Border.TopColor = System.Drawing.Color.Black
        Me.Line29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line29.Height = 0.3125!
        Me.Line29.Left = 10.5625!
        Me.Line29.LineWeight = 1.0!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 0.75!
        Me.Line29.Width = 0.0!
        Me.Line29.X1 = 10.5625!
        Me.Line29.X2 = 10.5625!
        Me.Line29.Y1 = 0.75!
        Me.Line29.Y2 = 1.0625!
        '
        'txt日期
        '
        Me.txt日期.Border.BottomColor = System.Drawing.Color.Black
        Me.txt日期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt日期.Border.LeftColor = System.Drawing.Color.Black
        Me.txt日期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt日期.Border.RightColor = System.Drawing.Color.Black
        Me.txt日期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt日期.Border.TopColor = System.Drawing.Color.Black
        Me.txt日期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt日期.Height = 0.1875!
        Me.txt日期.Left = 1.3125!
        Me.txt日期.Name = "txt日期"
        Me.txt日期.Style = ""
        Me.txt日期.Text = Nothing
        Me.txt日期.Top = 0.5!
        Me.txt日期.Width = 1.25!
        '
        'Barcode2
        '
        Me.Barcode2.Border.BottomColor = System.Drawing.Color.Black
        Me.Barcode2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode2.Border.LeftColor = System.Drawing.Color.Black
        Me.Barcode2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode2.Border.RightColor = System.Drawing.Color.Black
        Me.Barcode2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode2.Border.TopColor = System.Drawing.Color.Black
        Me.Barcode2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode2.DataField = "申请单编号"
        Me.Barcode2.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode2.Height = 0.749!
        Me.Barcode2.Left = 9.75!
        Me.Barcode2.Name = "Barcode2"
        Me.Barcode2.Style = DataDynamics.ActiveReports.BarCodeStyle.QRCode
        Me.Barcode2.Text = "Barcode1"
        Me.Barcode2.Top = 0.0!
        Me.Barcode2.Width = 0.749!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.Black
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.LeftColor = System.Drawing.Color.Black
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.RightColor = System.Drawing.Color.Black
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.TopColor = System.Drawing.Color.Black
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Height = 0.1875!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.4375!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = ""
        Me.Label19.Text = "申请日期："
        Me.Label19.Top = 0.5!
        Me.Label19.Width = 0.875!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.25!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        '原材料出库单
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.0!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 11.0!
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.txt品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt订单号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt材质, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt规格, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt重量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt张数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txt品名 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txt订单号 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txt材质 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txt规格 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txt备注 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line17 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line18 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line19 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line20 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line28 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line30 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line31 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line32 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line33 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line34 As DataDynamics.ActiveReports.Line
    Friend WithEvents txt图号 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line35 As DataDynamics.ActiveReports.Line
    Friend WithEvents txt客户名称 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txt重量 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txt张数 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line8 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line10 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line13 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line21 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line22 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line25 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line26 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label15 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label16 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line27 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line29 As DataDynamics.ActiveReports.Line
    Friend WithEvents txt日期 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Barcode2 As DataDynamics.ActiveReports.Barcode
    Friend WithEvents Label19 As DataDynamics.ActiveReports.Label
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
End Class
