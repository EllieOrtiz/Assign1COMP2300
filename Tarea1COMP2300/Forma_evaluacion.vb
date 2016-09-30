Public Class Forma_evaluacion REM abre forma de quiz

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False  REM cuando se presiona el boton go back se cierra la forma y vuelve al menu principal
    End Sub

    Private Sub Forma_evaluacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim total = 0       REM se declara una variable para sumar la puntuacion final de la prueba

        If TextBox1.Text = "single" Then        REM verifica cada una de las respuestas y va sumando puntos 
            total = total + 3
        Else : total = total + 0
        End If
        If CheckBox2.CheckState = 1 Then
            total = total + 3
        Else : total = total + 0
        End If
        If TextBox2.Text = "10" Then
            total = total + 4
        Else : total = total + 0

        End If
        MsgBox(total & " out of 10")        REM aparece un msgbox con el total obtenido en la prueba

    End Sub

End Class
