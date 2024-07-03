Imports System.Runtime.InteropServices

Public Class CEProducto
    Private _id As Int16
    Private _nombre As String
    Private _precio As Double
    Private _categorias As String

    Public Property id As Int16
        Get
            Return _id
        End Get
        Set(value As Int16)
            _id = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Public Property categoria As String
        Get
            Return _categorias
        End Get
        Set(value As String)
            _categorias = value
        End Set
    End Property


End Class
