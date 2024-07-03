Public Class CEVentaItem
    Private _id As Integer
    Private _idVenta As Integer
    Private _producto As String
    Private _precioUnitario As Double
    Private _cantidad As Integer
    Private _precioTotal As Double

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property idVenta As Integer
        Get
            Return _idVenta
        End Get
        Set(value As Integer)
            _idVenta = value
        End Set
    End Property

    Public Property producto As String
        Get
            Return _producto
        End Get
        Set(value As String)
            _producto = value
        End Set
    End Property

    Public Property precioUnitario As Double
        Get
            Return _precioUnitario
        End Get
        Set(value As Double)
            _precioUnitario = value
        End Set
    End Property

    Public Property cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property precioTotal As Double
        Get
            Return _precioTotal
        End Get
        Set(value As Double)
            _precioTotal = value
        End Set
    End Property
End Class
