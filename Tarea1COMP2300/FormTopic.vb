Public Class FormTopic

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False  REM al presionar el boton go back cierra la forma y vuelve a menu principal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click   REM cuando se presiona el boton definicion, aparece texto definicion de array
        TextBox1.Text = "When more than one memory location is designated for a single variable. Arrays are used in the problem-solving process. A programmer who has many values of data of the same kind -- many ages, temperatures, names --- can store them in the computer in the form of an array."

    End Sub
End Class
