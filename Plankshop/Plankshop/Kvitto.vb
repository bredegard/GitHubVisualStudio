Public Class Kvitto
    Private _antalPengar As Integer
    Private _produkt As String
    Private _längd As Integer

#Region "Properties"
    Public Property AntalPengar As Integer
        Get
            Return _antalPengar
        End Get
        Set(value As Integer)
            _antalPengar = value
        End Set
    End Property
    Public Property Produkt As String
        Get
            Return _produkt
        End Get
        Set(value As String)
            _produkt = value
        End Set
    End Property
    Public Property Längd As Integer
        Get
            Return _längd
        End Get
        Set(value As Integer)
            _längd = value
        End Set
    End Property
#End Region

    Public Function LäggTillPengar(ByVal valIn As Integer) As Integer
        AntalPengar += valIn

    End Function


End Class