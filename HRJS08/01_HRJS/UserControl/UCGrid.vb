Imports System.ComponentModel
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Drawing
Imports System.Text
Imports Infragistics.Win.UltraWinEditors
Imports System.Data
Imports System.Windows.Forms.Keys

Public Class UCGrid

#Region "変数"
    Private _AllowColMoving As AllowColMoving = UltraWinGrid.AllowColMoving.NotAllowed
#End Region

#Region "イベント"

    Private Sub UCGrid_AfterSelectChange(ByVal sender As Object, ByVal e As AfterSelectChangeEventArgs) Handles Me.AfterSelectChange
        If Me.ActiveRow Is Nothing Then
            Exit Sub
        End If

        If Me.Selected.Cells.Count > 1 Then

            Me.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.CopyWithHeaders
        Else
            Me.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy

        End If

    End Sub

    Private Sub UCGrid_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Me.InitializeLayout


        Me.DisplayLayout.GroupByBox.Appearance.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical

        '行の高
        Me.DisplayLayout.Override.DefaultRowHeight = 20
        Me.Font = ComVariable.CON_FONT

        'ユーザーによる行の削除を許可するかどうかを決める値を設定します。
        Me.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]

        Me.DisplayLayout.Override.RowSelectorAppearance.TextHAlign = Infragistics.Win.HAlign.Center
        Me.DisplayLayout.Override.RowSelectorAppearance.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid

        'セルがクリックされたときに実行するアクションを設定します。
        Me.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect

        'ユーザーがヘッダをクリックすると何が発生するかを決定する値を返すか設定します。
        Me.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle

        '［Tab］キーが押されたときのコントロールの応答方法を示す値を設定します。
        Me.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl

        '行の選択タイプを設定します。
        Me.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended

        '列の選択タイプを設定します。
        Me.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None

        'セルの選択タイプを設定します。
        Me.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single

        'グリッドにおける垂直方向のスクロール方法を制御します。
        Me.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate

        'UltraGridの垂直方向の行スクロール方法を指定します。
        Me.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill

        '行号は表示あります
        Me.DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.SeparateElement

        '集計フッタのキャプションを非表示にする
        Me.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False
        'Me.DisplayLayout.Override.BorderStyleSummaryFooter = Infragistics.Win.UIElementBorderStyle.None
        Me.DisplayLayout.Override.BorderStyleSummaryFooter = Infragistics.Win.UIElementBorderStyle.Default
        Me.DisplayLayout.Override.CellAppearance.BorderColor = Color.Silver    'Color.Black
        Me.DisplayLayout.Override.RowAppearance.BorderColor = Color.Silver     'Color.Black

        Me.DisplayLayout.MaxColScrollRegions = 1
        Me.DisplayLayout.MaxRowScrollRegions = 1

        With e.Layout.Override
            If e.Layout.Bands.Count > 1 Then
                '「+」の表示状態を「無子データ不表示」にセットする
                .ExpansionIndicator = ShowExpansionIndicator.CheckOnDisplay
            Else
                .ExpansionIndicator = ShowExpansionIndicator.Default
            End If

        End With

        Me.DisplayLayout.Appearance.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.DisplayLayout.Appearance.BackColor = Color.LightGray
        Me.DisplayLayout.Appearance.BorderColor = Color.Silver              'Color.Black　　　Silver

        Me.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.DisplayLayout.Override.ActiveRowAppearance.BackColor = MUCColor.CommonEnter
        'System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DisplayLayout.Override.ActiveRowAppearance.ForeColor = Color.Black  'System.Drawing.Color.Black
        Me.DisplayLayout.Override.RowAlternateAppearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DisplayLayout.Override.ActiveCellAppearance.BackColor = MUCColor.CommonEnter
        Me.DisplayLayout.Override.ActiveCellAppearance.ForeColor = Color.Black

        Me.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.Vertical
        Me.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        'ユーザーによる列の移動を許可するかどうかを決める値を設定します。
        Me.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Default
        Me.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.Vertical
        Me.DisplayLayout.Override.CellAppearance.TextTrimming = TextTrimming.EllipsisCharacter

        '数字の赤いの対象
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance

        ConditionValueAppearance1 = New Infragistics.Win.ConditionValueAppearance( _
                            New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition( _
                                                               Infragistics.Win.ConditionOperator.Contains, "-", _
                                                               True, GetType(String)), Infragistics.Win.ICondition)}, _
                                                               New Infragistics.Win.Appearance() {Appearance1})

        '各バンドの列をセットする
        For intBand As Integer = 0 To e.Layout.Bands.Count - 1
            With e.Layout.Bands(intBand)
                '編集のスタイルは設定
                For i As Integer = 0 To .ColumnFilters.Count - 1

                    'グリッドの様式を初期設置する
                    Select Case .ColumnFilters(i).Column.Style
                        Case ColumnStyle.Double, ColumnStyle.Integer        '数字
                            '入力方式をセットする
                            .ColumnFilters(i).Column.ImeMode = Windows.Forms.ImeMode.Disable

                            '赤い数字を設置する
                            Appearance1.ForeColor = Color.Red
                            .ColumnFilters(i).Column.ValueBasedAppearance = ConditionValueAppearance1
                        Case ColumnStyle.Date, ColumnStyle.DateTime         '日付
                            '入力方式をセットする
                            .ColumnFilters(i).Column.ImeMode = Windows.Forms.ImeMode.Disable
                        Case Else

                    End Select
                Next
            End With
        Next intBand

    End Sub

    Private Sub UCGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            If e.KeyCode = Windows.Forms.Keys.F10 Or e.KeyCode = F2 Then
                e.Handled = True
            End If

            If Not Me.ActiveRow Is Nothing Then
                If e.KeyCode = Windows.Forms.Keys.PageDown AndAlso Me.ActiveRow.Index = Me.Rows.Count - 1 Then
                    e.Handled = True
                End If
            End If

            'UCUtility.EnterPressedEventArgs(e)
            UCUtility.CopyGridCell(e, Me)

        Catch ex As Exception
            '異常処理
            'ComException.Show(Me.ActiveFormFeatureCode, ex)
        End Try
    End Sub


#End Region

#Region "私有関数"

    Public Sub PSb_SummaryFooterCaption(ByVal lngCount As Long)

        Dim band As UltraGridBand = Me.DisplayLayout.Bands(0)
        Dim summary As SummarySettings
        ' Add a summary.
        'Dim summary As SummarySettings = band.Summaries.Add(SummaryType.Count, band.Columns("CustomerID"))
        If band.Summaries.Count = 0 Then
            summary = band.Summaries.Add(String.Empty)
        Else
            summary = band.Summaries.Item(0)
        End If

        ' Set the summary position to Left so that it shows up on the left of the
        ' summary footer area.
        summary.SummaryPosition = SummaryPosition.Left

        ' Set the format with which to format the calculated summary when displaying
        ' in the summary footer.
        'summary.DisplayFormat = "Record Count = {0:#####}"
        'summary.DisplayFormat = "Record Count =  " & lngCount
        summary.DisplayFormat = "計 : " & lngCount & "件"

        ' Set the appearance of the summary.
        summary.Lines = 1

        summary.Appearance.FontData.Name = "ＭＳ ゴシック"
        summary.Appearance.FontData.SizeInPoints = 10
        summary.Appearance.TextHAlign = HAlign.Left
        summary.Appearance.TextVAlign = VAlign.Middle
        summary.Appearance.ForeColor = Color.DarkBlue
        summary.Appearance.BackColor = Color.White

        summary.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed

        band.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
        ' Set the border style of summaries to desired value.
        band.Override.BorderStyleSummaryValue = UIElementBorderStyle.None

        ' Set the appearance of summary footer and the footer caption.
        band.Override.SummaryFooterAppearance.BackColor = Color.White
        band.Override.SummaryFooterCaptionAppearance.BackColor = Color.White

    End Sub
#End Region

End Class
