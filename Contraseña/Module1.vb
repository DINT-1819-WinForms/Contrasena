Module Module1
    ''' <summary>
    ''' Función que compone el mensaje de error a mostrar al ususario
    ''' </summary>
    ''' <param name="longitud">Indica si la comprobación de longitud ha sido correcta</param>
    ''' <param name="minuscula">Indica si la comprobación de letra minúscula ha sido correcta</param>
    ''' <param name="mayuscula">Indica si la comprobación de letra mayúscula ha sido correcta</param>
    ''' <param name="digito">Indica si la comprobación de dígito ha sido correcta</param>
    ''' <param name="puntuacion">Indica si la comprobación de signo de puntuación ha sido correcta</param>
    ''' <returns>EL mensaje de error</returns>
    Public Function MensajeError(longitud As Boolean, minuscula As Boolean, mayuscula As Boolean, digito As Boolean, puntuacion As Boolean) As String
        'Inicio del mensaje
        Dim mensaje As String = "Error en la validación:"

        'Componemos el mensaje en función de los parámetros recibidos
        If Not longitud Then
            mensaje &= vbCrLf & "- la contraseña es demasiado corta"
        End If

        If Not minuscula Then
            mensaje &= vbCrLf & "- la contraseña no contiene una letra minúscula"
        End If

        If Not mayuscula Then
            mensaje &= vbCrLf & "- la contraseña no contiene una letra mayúscula"
        End If

        If Not digito Then
            mensaje &= vbCrLf & "- la contraseña no contiene un dígito"
        End If

        If Not puntuacion Then
            mensaje &= vbCrLf & "- la contraseña no contiene un signo de puntuación"
        End If

        Return mensaje
    End Function
End Module
