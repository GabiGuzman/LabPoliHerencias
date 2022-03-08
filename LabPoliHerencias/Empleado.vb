Public Class Empleado
    'Herencia'
    Inherits Persona
    'atributos'
    Private _tipocontratos As String
    Private _tiposueldo As Double
    'propiedades'
    Public Property Tipocontrato As String
        Get
            Return _tipocontratos

        End Get
        Set(value As String)
            _tipocontratos = value

        End Set
    End Property
    Public Property tiposueldos As Double

        Get
            Return _tiposueldo

        End Get
        Set(value As Double)
            _tiposueldo = value

        End Set
    End Property

    'operacion'
    Public Sub calcularSueldo(sueldoBase As Double)
        If (Me.Tipocontrato = "contratado") Then
            Me.tiposueldos = sueldoBase + 250
        ElseIf (Me.Tipocontrato = "Nombrado") Then
            Me.tiposueldos = sueldoBase + 500
        Else
            Me.tiposueldos = 0
        End If
    End Sub

End Class
