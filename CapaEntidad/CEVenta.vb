Imports System.Security.Cryptography

Public Class CEVenta
    Private _id As Int16
    Private _idCliente As Int16
    Private _fecha As DateTime
    Private _total As Double

    Public Property id As Int16
        Get
            Return _id
        End Get
        Set(value As Int16)
            _id = value
        End Set
    End Property

    Public Property idCliente As Int16
        Get
            Return _idCliente
        End Get
        Set(value As Int16)
            _idCliente = value
        End Set
    End Property

    Public Property fecha As DateTime
        Get
            Return _fecha
        End Get
        Set(value As DateTime)
            _fecha = value
        End Set
    End Property

    Public Property total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property

End Class
