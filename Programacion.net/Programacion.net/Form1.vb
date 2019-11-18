Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\invierno.jpg")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\otoño.jpg")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\primavera.jpg")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\verano.jpg")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'MsgBox("La tecla a sido pulsada", MsgBoxStyle.Critical)'
        'MsgBox(e.KeyChar)

        If e.KeyChar = "1" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\invierno.jpg")
        ElseIf e.KeyChar = "2" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\primavera.jpg")
        ElseIf e.KeyChar = "3" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\otoño.jpg")
        ElseIf e.KeyChar = "4" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\verano.jpg")
        End If
        MsgBox("La imagen a cambiado", MsgBoxStyle.Exclamation)
        'SOLAMENTE PERMITE INGRESAR NUMEROS, LAS LETRAS QUEDAN BLOQUEADAS
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        ' If e.KeyCode = "112" Then
        'PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\invierno.jpg")
        'ElseIf e.KeyCode = "113" Then
        'PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\primavera.jpg")
        'ElseIf e.KeyCode = "114" Then
        'PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\otoño.jpg")
        'ElseIf e.KeyCode = "115" Then
        'PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Contabilidad\Desktop\Programacion .net\verano.jpg")
        'End If
    End Sub
End Class
