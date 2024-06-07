Public Class clsVatLieu
    'BeTong
    Private m_Rb As Double
    Public Property Rb() As Double
        Get
            Return m_Rb
        End Get
        Set(ByVal value As Double)
            m_Rb = value
        End Set
    End Property
    Private m_Rbt As Double
    Public Property Rbt() As Double
        Get
            Return m_Rbt
        End Get
        Set(ByVal value As Double)
            m_Rbt = value
        End Set
    End Property
    Private m_E As Double
    Public Property E() As Double
        Get
            Return m_E
        End Get
        Set(ByVal value As Double)
            m_E = value
        End Set
    End Property

    Private m_Rs As Double
    Public Property Rs() As Double
        Get
            Return m_Rs
        End Get
        Set(ByVal value As Double)
            m_Rs = value
        End Set
    End Property
    Private m_Rsc As Double
    Public Property Rsc() As Double
        Get
            Return m_Rsc
        End Get
        Set(ByVal value As Double)
            m_Rsc = value
        End Set
    End Property
    Private m_Eb As Double
    Public Property Eb() As Double
        Get
            Return m_Eb
        End Get
        Set(ByVal value As Double)
            m_Eb = value
        End Set
    End Property

    Private m_alphaR As Double

    Private m_ShiR As Double
    Public Property Shi_R() As Double
        Get
            Return m_ShiR
        End Get
        Set(ByVal value As Double)
            m_ShiR = value
        End Set
    End Property

    Public Property AlphaR As Double
        Get
            Return m_alphaR
        End Get
        Set(value As Double)
            m_alphaR = value
        End Set
    End Property

    Public Function muy_max() As Double
        Dim u_max = Math.Round((m_ShiR * m_Rb * 100 / m_Rsc), 3)
        Return u_max

    End Function
    Public Function muy_min() As Double
        Return 0.05

    End Function
End Class
