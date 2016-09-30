Public Class Form_Content

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False      REM boton go back vuelve a forma principal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click   REM explica tipos de arrays dependiendo seleccion de botones
        TextBox1.Text = "This array consists of one column of memory locations."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = "Is a block of memory locations associated with a single memory variable and designated by row and column numbers."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = "The multidimensional arrays are used in cases where there is a need for arrays with a third of even a fourth dimension."
    End Sub
End Class