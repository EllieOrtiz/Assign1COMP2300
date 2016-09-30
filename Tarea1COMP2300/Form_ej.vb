Public Class Form_ej

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click       REM explica codigo en textbox y labels
        TextBox1.Text = "int sum = 0, prod = 1;" & Environment.NewLine & "int[] arg = { 1, 2, 3, 4, 5 };" & Environment.NewLine & "foreach (int value in arg) {" & Environment.NewLine & " sum += value;" & Environment.NewLine & "prod *= value;}"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False      REM boton go back vuelve a forma principal
    End Sub
End Class