Public Class Profesor
    'Herencia'
    Inherits Persona
    'atributos'
    Private _categoria As String
    Private _codigo As Double

    'Atributo'
    Public Property Categoria As String
        Get
            Return _categoria

        End Get
        Set(value As String)
            _categoria = value

        End Set
    End Property
    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value

        End Set
    End Property

    'Operacion'
    Public Sub generarcodigo()
        Me.Codigo = "Contratado" & Me.Apellidos.Substring(0, 3) & "22"

    End Sub


End Class
