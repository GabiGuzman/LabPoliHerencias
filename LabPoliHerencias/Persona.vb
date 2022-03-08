Public Class Persona
    'Atributos'
    Private _nombre As String
    Private _apellido As String
    Private _documento As String
    Private _tipo As String
    'Propiedades'
    Public Property Nombres As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellido

        End Get
        Set(value As String)
            _apellido = value

        End Set
    End Property
    Public Property Documentos As String
        Get
            Return _documento

        End Get
        Set(value As String)
            _documento = value

        End Set
    End Property
    Public Property Tipos As String
        Get
            Return _tipo

        End Get
        Set(value As String)
            _tipo = value

        End Set
    End Property
End Class
