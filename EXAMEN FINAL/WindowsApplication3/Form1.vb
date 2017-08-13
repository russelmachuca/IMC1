Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PESO As Double
        Dim ALTURA As Double
        Dim IMC As Double
        PESO = Val(TextBox1.Text)
        ALTURA = Val(TextBox2.Text)
        IMC = PESO / (ALTURA * ALTURA)
        If IMC < 18.5 Then
            TextBox3.Text = IMC
            MsgBox("RIESGO.Bajo Peso")

        ElseIf IMC = 18.5 Then
            TextBox3.Text = IMC
            MsgBox("RIESGO: Peso Promedio")

        ElseIf IMC < 25 Then
            TextBox3.Text = IMC
            MsgBox("RIESGO: Peso promedio")

        ElseIf IMC = 25 Then
            TextBox3.Text = IMC
            MsgBox("RIESGO: Bajo Aumentado")

        ElseIf IMC < 30 Then
            TextBox3.Text = IMC
            MsgBox("RIESGO: Bajo Aumentado")

        ElseIf IMC = 30 Then
            TextBox3.Text = IMC
            MsgBox("RIESGO: Moderado")

        ElseIf IMC < 35 Then
            TextBox3.Text = IMC
            MsgBox("RIESGO: Moderadoo")

        ElseIf IMC = 35 Then
            TextBox3.Text = IMC
            MsgBox("RIESGO: Severo")

        ElseIf IMC < 40 Then
            TextBox3.Text = IMC
            MsgBox("RIESGO: MuySevero")
        ElseIf IMC >= 40 Then
            TextBox3.Text = IMC
            MsgBox("RIESGO.Bajo Peso")
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not TextBox1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se admiten Numeros")
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not TextBox2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se admiten Numeros")
        End If
    End Sub
End Class
