Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class 不良品一覧 

    Public Sub SetControlValue(ByVal dt As DataTable)
        Me.DataSource = dt
        If dt.Rows.Count > 0 Then
            txtTotal.Text = dt.Rows(dt.Rows.Count - 1)("Total")
        End If
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If Not String.IsNullOrEmpty(txt1.Text) Then
            txtT1.Text = Convert.ToInt32(txtT1.Text) + Convert.ToInt32(txt1.Text)
        End If
        If Not String.IsNullOrEmpty(txt2.Text) Then
            txtT2.Text = Convert.ToInt32(txtT2.Text) + Convert.ToInt32(txt2.Text)
        End If
        If Not String.IsNullOrEmpty(txt3.Text) Then
            txtT3.Text = Convert.ToInt32(txtT3.Text) + Convert.ToInt32(txt3.Text)
        End If
        If Not String.IsNullOrEmpty(txt4.Text) Then
            txtT4.Text = Convert.ToInt32(txtT4.Text) + Convert.ToInt32(txt4.Text)
        End If
        If Not String.IsNullOrEmpty(txt5.Text) Then
            txtT5.Text = Convert.ToInt32(txtT5.Text) + Convert.ToInt32(txt5.Text)
        End If
        If Not String.IsNullOrEmpty(txt6.Text) Then
            txtT6.Text = Convert.ToInt32(txtT6.Text) + Convert.ToInt32(txt6.Text)
        End If
        If Not String.IsNullOrEmpty(txt19.Text) Then
            txtT19.Text = Convert.ToInt32(txtT19.Text) + Convert.ToInt32(txt19.Text)
        End If
        If Not String.IsNullOrEmpty(txt.Text) Then
            txtT.Text = Convert.ToInt32(txtT.Text) + Convert.ToInt32(txt.Text)
        End If
        If Not String.IsNullOrEmpty(txt7.Text) Then
            txtT7.Text = Convert.ToInt32(txtT7.Text) + Convert.ToInt32(txt7.Text)
        End If
        If Not String.IsNullOrEmpty(txt8.Text) Then
            txtT8.Text = Convert.ToInt32(txtT8.Text) + Convert.ToInt32(txt8.Text)
        End If
        If Not String.IsNullOrEmpty(txt9.Text) Then
            txtT9.Text = Convert.ToInt32(txtT9.Text) + Convert.ToInt32(txt9.Text)
        End If
        If Not String.IsNullOrEmpty(txt10.Text) Then
            txtT10.Text = Convert.ToInt32(txtT10.Text) + Convert.ToInt32(txt10.Text)
        End If
        If Not String.IsNullOrEmpty(txt11.Text) Then
            txtT11.Text = Convert.ToInt32(txtT11.Text) + Convert.ToInt32(txt11.Text)
        End If
        If Not String.IsNullOrEmpty(txt12.Text) Then
            txtT12.Text = Convert.ToInt32(txtT12.Text) + Convert.ToInt32(txt12.Text)
        End If
        If Not String.IsNullOrEmpty(txt13.Text) Then
            txtT13.Text = Convert.ToInt32(txtT13.Text) + Convert.ToInt32(txt13.Text)
        End If
        If Not String.IsNullOrEmpty(txt14.Text) Then
            txtT14.Text = Convert.ToInt32(txtT14.Text) + Convert.ToInt32(txt14.Text)
        End If
        If Not String.IsNullOrEmpty(txt15.Text) Then
            txtT15.Text = Convert.ToInt32(txtT15.Text) + Convert.ToInt32(txt15.Text)
        End If
        If Not String.IsNullOrEmpty(txt16.Text) Then
            txtT16.Text = Convert.ToInt32(txtT16.Text) + Convert.ToInt32(txt16.Text)
        End If
        If Not String.IsNullOrEmpty(txt17.Text) Then
            txtT17.Text = Convert.ToInt32(txtT17.Text) + Convert.ToInt32(txt17.Text)
        End If
        If Not String.IsNullOrEmpty(txt18.Text) Then
            txtT18.Text = Convert.ToInt32(txtT18.Text) + Convert.ToInt32(txt18.Text)
        End If
    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format
        txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd")
        TextBox1.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
        'txtTotal.Text = txtT.Text
    End Sub
End Class
