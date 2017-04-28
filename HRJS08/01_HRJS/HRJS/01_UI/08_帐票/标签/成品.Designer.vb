<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class 成品

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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(成品))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.txt订单编号 = New DataDynamics.ActiveReports.TextBox
        Me.txt产品图号 = New DataDynamics.ActiveReports.TextBox
        Me.txt库存区域 = New DataDynamics.ActiveReports.TextBox
        Me.bar详细 = New DataDynamics.ActiveReports.Barcode
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt库存区域, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Height = 0.04166667!
        Me.Detail1.Name = "Detail1"
        '
        'PageHeader1
        '
        Me.PageHeader1.CanGrow = False
        Me.PageHeader1.CanShrink = True
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Label1, Me.Label2, Me.Label4, Me.txt订单编号, Me.txt产品图号, Me.txt库存区域, Me.bar详细})
        Me.PageHeader1.Height = 1.771!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.125!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.125!
        Me.Line1.Width = 3.75!
        Me.Line1.X1 = 0.125!
        Me.Line1.X2 = 3.875!
        Me.Line1.Y1 = 0.125!
        Me.Line1.Y2 = 0.125!
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
        Me.Line2.Top = 1.625!
        Me.Line2.Width = 3.75!
        Me.Line2.X1 = 0.125!
        Me.Line2.X2 = 3.875!
        Me.Line2.Y1 = 1.625!
        Me.Line2.Y2 = 1.625!
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
        Me.Line3.Height = 1.5!
        Me.Line3.Left = 0.125!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.125!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 0.125!
        Me.Line3.X2 = 0.125!
        Me.Line3.Y1 = 0.125!
        Me.Line3.Y2 = 1.625!
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
        Me.Line4.Height = 1.5!
        Me.Line4.Left = 3.875!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.125!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 3.875!
        Me.Line4.X2 = 3.875!
        Me.Line4.Y1 = 0.125!
        Me.Line4.Y2 = 1.625!
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
        Me.Label1.Left = 0.1875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = ""
        Me.Label1.Text = "订单编号"
        Me.Label1.Top = 0.1875!
        Me.Label1.Width = 0.8125!
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
        Me.Label2.Left = 0.1875!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = ""
        Me.Label2.Text = "产品图号"
        Me.Label2.Top = 0.4375!
        Me.Label2.Width = 0.8125!
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
        Me.Label4.Left = 0.1875!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = ""
        Me.Label4.Text = "库存区域"
        Me.Label4.Top = 0.6875!
        Me.Label4.Width = 0.8125!
        '
        'txt订单编号
        '
        Me.txt订单编号.Border.BottomColor = System.Drawing.Color.Black
        Me.txt订单编号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt订单编号.Border.LeftColor = System.Drawing.Color.Black
        Me.txt订单编号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt订单编号.Border.RightColor = System.Drawing.Color.Black
        Me.txt订单编号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt订单编号.Border.TopColor = System.Drawing.Color.Black
        Me.txt订单编号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt订单编号.Height = 0.1979167!
        Me.txt订单编号.Left = 1.0625!
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Style = ""
        Me.txt订单编号.Text = "TextBox1"
        Me.txt订单编号.Top = 0.1875!
        Me.txt订单编号.Width = 1.0!
        '
        'txt产品图号
        '
        Me.txt产品图号.Border.BottomColor = System.Drawing.Color.Black
        Me.txt产品图号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt产品图号.Border.LeftColor = System.Drawing.Color.Black
        Me.txt产品图号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt产品图号.Border.RightColor = System.Drawing.Color.Black
        Me.txt产品图号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt产品图号.Border.TopColor = System.Drawing.Color.Black
        Me.txt产品图号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt产品图号.Height = 0.1979167!
        Me.txt产品图号.Left = 1.0625!
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.Style = ""
        Me.txt产品图号.Text = "TextBox1"
        Me.txt产品图号.Top = 0.4375!
        Me.txt产品图号.Width = 1.0!
        '
        'txt库存区域
        '
        Me.txt库存区域.Border.BottomColor = System.Drawing.Color.Black
        Me.txt库存区域.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt库存区域.Border.LeftColor = System.Drawing.Color.Black
        Me.txt库存区域.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt库存区域.Border.RightColor = System.Drawing.Color.Black
        Me.txt库存区域.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt库存区域.Border.TopColor = System.Drawing.Color.Black
        Me.txt库存区域.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txt库存区域.Height = 0.1979167!
        Me.txt库存区域.Left = 1.0625!
        Me.txt库存区域.Name = "txt库存区域"
        Me.txt库存区域.Style = ""
        Me.txt库存区域.Text = "TextBox1"
        Me.txt库存区域.Top = 0.6875!
        Me.txt库存区域.Width = 1.0!
        '
        'bar详细
        '
        Me.bar详细.Border.BottomColor = System.Drawing.Color.Black
        Me.bar详细.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.bar详细.Border.LeftColor = System.Drawing.Color.Black
        Me.bar详细.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.bar详细.Border.RightColor = System.Drawing.Color.Black
        Me.bar详细.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.bar详细.Border.TopColor = System.Drawing.Color.Black
        Me.bar详细.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.bar详细.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.bar详细.Height = 0.938!
        Me.bar详细.Left = 2.875!
        Me.bar详细.Name = "bar详细"
        Me.bar详细.Style = DataDynamics.ActiveReports.BarCodeStyle.QRCode
        Me.bar详细.Text = "Barcode1"
        Me.bar详细.Top = 0.1875!
        Me.bar详细.Width = 0.938!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.05208333!
        Me.PageFooter1.Name = "PageFooter1"
        '
        '成品
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.0!
        Me.PageSettings.PaperHeight = 5.511811!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperWidth = 3.937008!
        Me.PrintWidth = 4.021!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt库存区域, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    Friend WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents txt订单编号 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txt产品图号 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txt库存区域 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents bar详细 As DataDynamics.ActiveReports.Barcode
End Class
