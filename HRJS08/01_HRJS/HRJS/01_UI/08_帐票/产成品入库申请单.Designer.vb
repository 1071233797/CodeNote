<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class 产成品入库明细

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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(产成品入库明细))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txt品名 = New DataDynamics.ActiveReports.TextBox
        Me.txt订单号 = New DataDynamics.ActiveReports.TextBox
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.Line20 = New DataDynamics.ActiveReports.Line
        Me.Line28 = New DataDynamics.ActiveReports.Line
        Me.Line32 = New DataDynamics.ActiveReports.Line
        Me.txt重量 = New DataDynamics.ActiveReports.TextBox
        Me.txt备注 = New DataDynamics.ActiveReports.TextBox
        Me.Line33 = New DataDynamics.ActiveReports.Line
        Me.Line34 = New DataDynamics.ActiveReports.Line
        Me.txt图号 = New DataDynamics.ActiveReports.TextBox
        Me.Line35 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.Line25 = New DataDynamics.ActiveReports.Line
        Me.Line26 = New DataDynamics.ActiveReports.Line
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Line27 = New DataDynamics.ActiveReports.Line
        Me.Line29 = New DataDynamics.ActiveReports.Line
        Me.Line36 = New DataDynamics.ActiveReports.Line
        Me.Line38 = New DataDynamics.ActiveReports.Line
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.Line42 = New DataDynamics.ActiveReports.Line
        Me.Line45 = New DataDynamics.ActiveReports.Line
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.Line46 = New DataDynamics.ActiveReports.Line
        Me.Barcode1 = New DataDynamics.ActiveReports.Barcode
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Label22 = New DataDynamics.ActiveReports.Label
        CType(Me.txt品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt订单号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt重量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt品名, Me.txt订单号, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line28, Me.Line32, Me.txt重量, Me.txt备注, Me.Line33, Me.Line34, Me.txt图号, Me.Line35, Me.Line10, Me.TextBox2, Me.TextBox3, Me.TextBox1})
        Me.Detail1.Height = 0.3125!
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
        Me.txt品名.DataField = "产品图号"
        Me.txt品名.Height = 0.25!
        Me.txt品名.Left = 2.125!
        Me.txt品名.Name = "txt品名"
        Me.txt品名.Style = ""
        Me.txt品名.Text = Nothing
        Me.txt品名.Top = 0.0!
        Me.txt品名.Width = 1.75!
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
        Me.txt订单号.DataField = "品名"
        Me.txt订单号.Height = 0.25!
        Me.txt订单号.Left = 3.875!
        Me.txt订单号.Name = "txt订单号"
        Me.txt订单号.Style = ""
        Me.txt订单号.Text = Nothing
        Me.txt订单号.Top = 0.0!
        Me.txt订单号.Width = 1.4375!
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
        Me.Line17.Height = 0.3125!
        Me.Line17.Left = 2.125!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.0!
        Me.Line17.Width = 0.0!
        Me.Line17.X1 = 2.125!
        Me.Line17.X2 = 2.125!
        Me.Line17.Y1 = 0.0!
        Me.Line17.Y2 = 0.3125!
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
        Me.Line18.Height = 0.3125!
        Me.Line18.Left = 3.875!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.0!
        Me.Line18.Width = 0.0!
        Me.Line18.X1 = 3.875!
        Me.Line18.X2 = 3.875!
        Me.Line18.Y1 = 0.0!
        Me.Line18.Y2 = 0.3125!
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
        Me.Line19.Height = 0.3125!
        Me.Line19.Left = 0.125!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.0!
        Me.Line19.Width = 0.0!
        Me.Line19.X1 = 0.125!
        Me.Line19.X2 = 0.125!
        Me.Line19.Y1 = 0.0!
        Me.Line19.Y2 = 0.3125!
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
        Me.Line20.Height = 0.3125!
        Me.Line20.Left = 6.5!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0.0!
        Me.Line20.Width = 0.0!
        Me.Line20.X1 = 6.5!
        Me.Line20.X2 = 6.5!
        Me.Line20.Y1 = 0.0!
        Me.Line20.Y2 = 0.3125!
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
        Me.Line28.Height = 0.3125!
        Me.Line28.Left = 5.375!
        Me.Line28.LineWeight = 1.0!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 0.0!
        Me.Line28.Width = 0.0!
        Me.Line28.X1 = 5.375!
        Me.Line28.X2 = 5.375!
        Me.Line28.Y1 = 0.0!
        Me.Line28.Y2 = 0.3125!
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
        Me.Line32.Height = 0.3125!
        Me.Line32.Left = 7.4375!
        Me.Line32.LineWeight = 1.0!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 0.0!
        Me.Line32.Width = 0.0!
        Me.Line32.X1 = 7.4375!
        Me.Line32.X2 = 7.4375!
        Me.Line32.Y1 = 0.0!
        Me.Line32.Y2 = 0.3125!
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
        Me.txt重量.DataField = "入库数量"
        Me.txt重量.Height = 0.25!
        Me.txt重量.Left = 5.4375!
        Me.txt重量.Name = "txt重量"
        Me.txt重量.Style = "text-align: right; "
        Me.txt重量.Text = Nothing
        Me.txt重量.Top = 0.0!
        Me.txt重量.Width = 0.9375!
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
        Me.txt备注.DataField = "入库重量"
        Me.txt备注.Height = 0.25!
        Me.txt备注.Left = 6.5!
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Style = "text-align: right; "
        Me.txt备注.Text = Nothing
        Me.txt备注.Top = 0.0!
        Me.txt备注.Width = 0.8125!
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
        Me.Line33.Height = 0.3125!
        Me.Line33.Left = 8.25!
        Me.Line33.LineWeight = 1.0!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 0.0!
        Me.Line33.Width = 0.0!
        Me.Line33.X1 = 8.25!
        Me.Line33.X2 = 8.25!
        Me.Line33.Y1 = 0.0!
        Me.Line33.Y2 = 0.3125!
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
        Me.Line34.Height = 0.3125!
        Me.Line34.Left = 10.9375!
        Me.Line34.LineWeight = 1.0!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 0.0!
        Me.Line34.Width = 0.0!
        Me.Line34.X1 = 10.9375!
        Me.Line34.X2 = 10.9375!
        Me.Line34.Y1 = 0.0!
        Me.Line34.Y2 = 0.3125!
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
        Me.txt图号.DataField = "订单编号"
        Me.txt图号.Height = 0.25!
        Me.txt图号.Left = 0.1875!
        Me.txt图号.Name = "txt图号"
        Me.txt图号.Style = ""
        Me.txt图号.Text = Nothing
        Me.txt图号.Top = 0.0!
        Me.txt图号.Width = 1.9375!
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
        Me.Line35.Left = 0.125!
        Me.Line35.LineWeight = 1.0!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 0.3125!
        Me.Line35.Width = 10.8125!
        Me.Line35.X1 = 0.125!
        Me.Line35.X2 = 10.9375!
        Me.Line35.Y1 = 0.3125!
        Me.Line35.Y2 = 0.3125!
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
        Me.Line10.Left = 9.25!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.0!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 9.25!
        Me.Line10.X2 = 9.25!
        Me.Line10.Y1 = 0.0!
        Me.Line10.Y2 = 0.3125!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.DataField = "备注"
        Me.TextBox2.Height = 0.25!
        Me.TextBox2.Left = 9.3125!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = ""
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 1.625!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.DataField = "质检状态"
        Me.TextBox3.Height = 0.25!
        Me.TextBox3.Left = 7.5!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = ""
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.6875!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line25, Me.Line26, Me.Label5, Me.Line27, Me.Line29, Me.Line36, Me.Line38, Me.Label9, Me.Label10, Me.Label20, Me.Line42, Me.Label22, Me.Line45, Me.Label23, Me.Line46, Me.Barcode1, Me.Line1, Me.Line2, Me.Label1, Me.Line5, Me.Line3, Me.Line4, Me.Label19, Me.Label2})
        Me.GroupHeader1.DataField = "申请单编号"
        Me.GroupHeader1.Height = 1.444444!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.Line25.Left = 2.125!
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 1.125!
        Me.Line25.Width = 0.0!
        Me.Line25.X1 = 2.125!
        Me.Line25.X2 = 2.125!
        Me.Line25.Y1 = 1.125!
        Me.Line25.Y2 = 1.4375!
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
        Me.Line26.Left = 7.4375!
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 1.125!
        Me.Line26.Width = 0.0!
        Me.Line26.X1 = 7.4375!
        Me.Line26.X2 = 7.4375!
        Me.Line26.Y1 = 1.125!
        Me.Line26.Y2 = 1.4375!
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
        Me.Label5.Height = 0.3125!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 4.375!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "text-decoration: none; ddo-char-set: 0; font-weight: normal; font-size: 18pt; "
        Me.Label5.Text = "产成品入库申请单"
        Me.Label5.Top = 0.375!
        Me.Label5.Width = 2.5!
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
        Me.Line27.Height = 0.0!
        Me.Line27.Left = 0.125!
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 1.4375!
        Me.Line27.Width = 10.8125!
        Me.Line27.X1 = 0.125!
        Me.Line27.X2 = 10.9375!
        Me.Line27.Y1 = 1.4375!
        Me.Line27.Y2 = 1.4375!
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
        Me.Line29.Left = 3.875!
        Me.Line29.LineWeight = 1.0!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 1.125!
        Me.Line29.Width = 0.0!
        Me.Line29.X1 = 3.875!
        Me.Line29.X2 = 3.875!
        Me.Line29.Y1 = 1.125!
        Me.Line29.Y2 = 1.4375!
        '
        'Line36
        '
        Me.Line36.Border.BottomColor = System.Drawing.Color.Black
        Me.Line36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line36.Border.LeftColor = System.Drawing.Color.Black
        Me.Line36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line36.Border.RightColor = System.Drawing.Color.Black
        Me.Line36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line36.Border.TopColor = System.Drawing.Color.Black
        Me.Line36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line36.Height = 0.3125!
        Me.Line36.Left = 5.375!
        Me.Line36.LineWeight = 1.0!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 1.125!
        Me.Line36.Width = 0.0!
        Me.Line36.X1 = 5.375!
        Me.Line36.X2 = 5.375!
        Me.Line36.Y1 = 1.125!
        Me.Line36.Y2 = 1.4375!
        '
        'Line38
        '
        Me.Line38.Border.BottomColor = System.Drawing.Color.Black
        Me.Line38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line38.Border.LeftColor = System.Drawing.Color.Black
        Me.Line38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line38.Border.RightColor = System.Drawing.Color.Black
        Me.Line38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line38.Border.TopColor = System.Drawing.Color.Black
        Me.Line38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line38.Height = 0.3125!
        Me.Line38.Left = 6.5!
        Me.Line38.LineWeight = 1.0!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 1.125!
        Me.Line38.Width = 0.0!
        Me.Line38.X1 = 6.5!
        Me.Line38.X2 = 6.5!
        Me.Line38.Y1 = 1.125!
        Me.Line38.Y2 = 1.4375!
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
        Me.Label9.Left = 2.5625!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = ""
        Me.Label9.Text = "产品图号"
        Me.Label9.Top = 1.1875!
        Me.Label9.Width = 0.875!
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
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 4.375!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = ""
        Me.Label10.Text = "品名"
        Me.Label10.Top = 1.1875!
        Me.Label10.Width = 0.75!
        '
        'Label20
        '
        Me.Label20.Border.BottomColor = System.Drawing.Color.Black
        Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.LeftColor = System.Drawing.Color.Black
        Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.RightColor = System.Drawing.Color.Black
        Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.TopColor = System.Drawing.Color.Black
        Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Height = 0.1875!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 6.5!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = ""
        Me.Label20.Text = "入库重量(kg)"
        Me.Label20.Top = 1.1875!
        Me.Label20.Width = 0.9375!
        '
        'Line42
        '
        Me.Line42.Border.BottomColor = System.Drawing.Color.Black
        Me.Line42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line42.Border.LeftColor = System.Drawing.Color.Black
        Me.Line42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line42.Border.RightColor = System.Drawing.Color.Black
        Me.Line42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line42.Border.TopColor = System.Drawing.Color.Black
        Me.Line42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line42.Height = 1.1875!
        Me.Line42.Left = 10.9375!
        Me.Line42.LineWeight = 1.0!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 0.25!
        Me.Line42.Width = 0.0!
        Me.Line42.X1 = 10.9375!
        Me.Line42.X2 = 10.9375!
        Me.Line42.Y1 = 0.25!
        Me.Line42.Y2 = 1.4375!
        '
        'Line45
        '
        Me.Line45.Border.BottomColor = System.Drawing.Color.Black
        Me.Line45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line45.Border.LeftColor = System.Drawing.Color.Black
        Me.Line45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line45.Border.RightColor = System.Drawing.Color.Black
        Me.Line45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line45.Border.TopColor = System.Drawing.Color.Black
        Me.Line45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line45.Height = 0.3125!
        Me.Line45.Left = 10.1875!
        Me.Line45.LineWeight = 1.0!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 0.5!
        Me.Line45.Width = 0.0!
        Me.Line45.X1 = 10.1875!
        Me.Line45.X2 = 10.1875!
        Me.Line45.Y1 = 0.5!
        Me.Line45.Y2 = 0.8125!
        '
        'Label23
        '
        Me.Label23.Border.BottomColor = System.Drawing.Color.Black
        Me.Label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.LeftColor = System.Drawing.Color.Black
        Me.Label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.RightColor = System.Drawing.Color.Black
        Me.Label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.TopColor = System.Drawing.Color.Black
        Me.Label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Height = 0.1875!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 7.5!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = ""
        Me.Label23.Text = "质检状态"
        Me.Label23.Top = 1.1875!
        Me.Label23.Width = 0.6875!
        '
        'Line46
        '
        Me.Line46.Border.BottomColor = System.Drawing.Color.Black
        Me.Line46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line46.Border.LeftColor = System.Drawing.Color.Black
        Me.Line46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line46.Border.RightColor = System.Drawing.Color.Black
        Me.Line46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line46.Border.TopColor = System.Drawing.Color.Black
        Me.Line46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line46.Height = 0.0!
        Me.Line46.Left = 0.125!
        Me.Line46.LineWeight = 1.0!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 0.25!
        Me.Line46.Width = 10.8125!
        Me.Line46.X1 = 0.125!
        Me.Line46.X2 = 10.9375!
        Me.Line46.Y1 = 0.25!
        Me.Line46.Y2 = 0.25!
        '
        'Barcode1
        '
        Me.Barcode1.Border.BottomColor = System.Drawing.Color.Black
        Me.Barcode1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.LeftColor = System.Drawing.Color.Black
        Me.Barcode1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.RightColor = System.Drawing.Color.Black
        Me.Barcode1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.Border.TopColor = System.Drawing.Color.Black
        Me.Barcode1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode1.DataField = "申请单编号"
        Me.Barcode1.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode1.Height = 0.749!
        Me.Barcode1.Left = 10.125!
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.Style = DataDynamics.ActiveReports.BarCodeStyle.QRCode
        Me.Barcode1.Text = "Barcode1"
        Me.Barcode1.Top = 0.3125!
        Me.Barcode1.Width = 0.749!
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
        Me.Line1.Height = 0.9375!
        Me.Line1.Left = 0.125!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.5!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 0.125!
        Me.Line1.X2 = 0.125!
        Me.Line1.Y1 = 0.5!
        Me.Line1.Y2 = 1.4375!
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
        Me.Line2.Left = 0.125!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.125!
        Me.Line2.Width = 10.8125!
        Me.Line2.X1 = 0.125!
        Me.Line2.X2 = 10.9375!
        Me.Line2.Y1 = 1.125!
        Me.Line2.Y2 = 1.125!
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
        Me.Label1.Left = 0.6875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = ""
        Me.Label1.Text = "订单编号"
        Me.Label1.Top = 1.1875!
        Me.Label1.Width = 0.8125!
        '
        'Line5
        '
        Me.Line5.Border.BottomColor = System.Drawing.Color.Black
        Me.Line5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.LeftColor = System.Drawing.Color.Black
        Me.Line5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.RightColor = System.Drawing.Color.Black
        Me.Line5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.TopColor = System.Drawing.Color.Black
        Me.Line5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Height = 0.5625!
        Me.Line5.Left = 0.125!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.25!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 0.125!
        Me.Line5.X2 = 0.125!
        Me.Line5.Y1 = 0.25!
        Me.Line5.Y2 = 0.8125!
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
        Me.Line3.Height = 0.3125!
        Me.Line3.Left = 8.25!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 1.125!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 8.25!
        Me.Line3.X2 = 8.25!
        Me.Line3.Y1 = 1.125!
        Me.Line3.Y2 = 1.4375!
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
        Me.Line4.Left = 9.25!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.125!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 9.25!
        Me.Line4.X2 = 9.25!
        Me.Line4.Y1 = 1.125!
        Me.Line4.Y2 = 1.4375!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.25!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.Label19.Left = 5.4375!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = ""
        Me.Label19.Text = "入库数量(个)"
        Me.Label19.Top = 1.1875!
        Me.Label19.Width = 0.9375!
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
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 8.3125!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = ""
        Me.Label2.Text = "申请者"
        Me.Label2.Top = 1.1875!
        Me.Label2.Width = 0.6875!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.DataField = "申请者"
        Me.TextBox1.Height = 0.25!
        Me.TextBox1.Left = 8.375!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = ""
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.6875!
        '
        'Label22
        '
        Me.Label22.Border.BottomColor = System.Drawing.Color.Black
        Me.Label22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.LeftColor = System.Drawing.Color.Black
        Me.Label22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.RightColor = System.Drawing.Color.Black
        Me.Label22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.TopColor = System.Drawing.Color.Black
        Me.Label22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Height = 0.1875!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 9.9375!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = ""
        Me.Label22.Text = "备注"
        Me.Label22.Top = 1.1875!
        Me.Label22.Width = 0.375!
        '
        '产成品入库明细
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
        CType(Me.txt重量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents txt品名 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txt订单号 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txt备注 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line17 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line18 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line19 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line20 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line28 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line32 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line33 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line34 As DataDynamics.ActiveReports.Line
    Friend WithEvents txt图号 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line35 As DataDynamics.ActiveReports.Line
    Friend WithEvents txt重量 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line10 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents Line25 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line26 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line27 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line29 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line36 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line38 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label20 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line42 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line45 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label23 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line46 As DataDynamics.ActiveReports.Line
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Barcode1 As DataDynamics.ActiveReports.Barcode
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label19 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label22 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
End Class
