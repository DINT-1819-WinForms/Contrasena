Public Class Form1
    Private Sub MostrarCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MostrarCheckBox.CheckedChanged
        'En función del estado del CheckBox, cambiamos la propiedad que indica si se debe mostrar o no el texto
        If MostrarCheckBox.Checked Then
            ContraseñaTextBox.UseSystemPasswordChar = False
        Else
            ContraseñaTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ValidarButton_Click(sender As Object, e As EventArgs) Handles ValidarButton.Click
        Dim longitud, minuscula, mayuscula, digito, puntuacion As Boolean

        'Comprobamos que la contraseña tenga más de 8 caracteres
        longitud = If(ContraseñaTextBox.Text.Trim.Length < 8, False, True)

        For Each letra As Char In ContraseñaTextBox.Text.Trim
            Select Case letra
                Case "a"c To "z"c 'Comprobamos si el carácter es una letra minúscula
                    minuscula = True
                Case "A"c To "Z"c 'Comprobamos si el carácter es una letra mayúscula
                    mayuscula = True
                Case "0"c To "9"c 'Comprobamos si el carácter es un dígito
                    digito = True
                Case "."c, ";"c, "!"c, "@"c 'Comprobamos si el carácter es un signo de puntuación
                    puntuacion = True
            End Select
        Next

        If Not (longitud AndAlso minuscula AndAlso mayuscula AndAlso digito AndAlso puntuacion) Then
            'Si ha habido algún error, mostramos el mensaje utilizando la función definida en el módulo
            MessageBox.Show(MensajeError(longitud, minuscula, mayuscula, digito, puntuacion), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Situamos el foco en el TextBox
            ContraseñaTextBox.Focus()
        Else
            'Si no se han detectado errores, se informa al usuario
            MessageBox.Show("Contraseña correcta", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

End Class
