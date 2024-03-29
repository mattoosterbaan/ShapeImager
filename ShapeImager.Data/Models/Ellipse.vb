﻿Public Class Ellipse
    Inherits Shape
    Public Sub New()

    End Sub

    Public Sub New(centerX As Decimal, centerY As Decimal, radius1 As Decimal, radius2 As Decimal, orientation As Decimal)
        Center = New Vertex(centerX, centerY)
        MyBase.Orientation = orientation
        Me.Radius1 = radius1
        Me.Radius2 = radius2
    End Sub
    Public Overridable Property Radius1 As Decimal
    Public Overridable Property Radius2 As Decimal
    Public Overrides ReadOnly Property Area As Decimal
        Get
            Return Math.PI * Radius1 * Radius2
        End Get
    End Property

    Public Overrides ReadOnly Property Perimeter As Decimal
        Get
            Return 2 * Math.PI * Math.Sqrt((Radius1 * Radius1 + Radius2 * Radius2) / 2)
        End Get
    End Property
End Class
