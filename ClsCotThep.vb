Public Class ClsCotThep
    Private m_ThepDoc As String
    Public Property ThepDoc() As String
        Get
            Return m_ThepDoc
        End Get
        Set(ByVal value As String)
            m_ThepDoc = value
        End Set
    End Property
    Private m_ThepDai As String

    Private m_SoThanh As String

    Public Property SoThanh() As String
        Get
            Return m_SoThanh
        End Get
        Set(ByVal value As String)
            m_SoThanh = value
        End Set
    End Property
    Private m_S1 As String
    Public Property S1() As String
        Get
            Return m_S1
        End Get
        Set(ByVal value As String)
            m_S1 = value
        End Set
    End Property
    Private m_S2 As String
    Public Property S2() As String
        Get
            Return m_S2
        End Get
        Set(ByVal value As String)
            m_S2 = value
        End Set
    End Property
End Class
