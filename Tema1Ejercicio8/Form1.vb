Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBoxAltitude_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAltitude.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub TextBoxAltitude_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAltitude.TextChanged
        CalculateSpeed()

    End Sub

    Private Sub CalculateSpeed()
        Dim altitude As Decimal
        Dim speed As Decimal
        Dim strAltitude As String

        strAltitude = TextBoxAltitude.Text.Replace(".", ",")

        If Decimal.TryParse(strAltitude, altitude) Then
            speed = Math.Sqrt(2 * 9.8 * altitude)
            LabelSpeed.Text = Format(speed, "0.00")
        End If
    End Sub

    Private Sub OnlyNumbers(e As KeyPressEventArgs)
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
