REM Elizabeth Ortiz
REM Este proyecto es un programa para estudiar el tema de los arrays en el area de la ciencia en computadoras. 
REM El mismo tiene una introduccion del tema, contenido de estudio y evaluacion.
REM Para propositos de este proyecto, la informacion fue recueprada de: Sprankle,M. y Hubbard,J(2008).Problem Solving and Programming Concepts (8th Edition)
Public Class Form1

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FormTopic.Visible = True        REM aparece forma de la definicion del tema
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Content.Visible = True     REM aparece forma de tipos de arrays
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form_ej.Visible = True      REM aparece forma de ejemplos de array en codigos
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Forma_evaluacion.Visible = True     REM aparece forma de prueba corta
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class




