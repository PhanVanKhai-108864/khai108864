Public Class clsCot

    'Tên tầng
    Private m_tang As String
    Public Property Tang() As String
        Get
            Return m_tang
        End Get
        Set(ByVal value As String)
            m_tang = value
        End Set
    End Property
    'Tên cột
    Private m_ten As String
    Public Property TenCot() As String
        Get
            Return m_ten
        End Get
        Set(ByVal value As String)
            m_ten = value
        End Set
    End Property
    'Tên cột
    Private m_tietDien As String
    Public Property tietDien() As String
        Get
            Return m_tietDien
        End Get
        Set(ByVal value As String)
            m_tietDien = value
        End Set
    End Property
    'Tên tầng

    'bề  rộng
    Private m_b As String
    Public Property b() As Double
        Get
            Return m_b
        End Get
        Set(ByVal value As Double)
            m_b = value
        End Set
    End Property

    'Asbt
    Private m_Asbt As String
    Public Property Asbt() As Double
        Get
            Return m_Asbt
        End Get
        Set(ByVal value As Double)
            m_Asbt = value
        End Set
    End Property
    'Ast
    Private m_Ast As String
    Public Property Ast() As Double
        Get
            Return m_Ast
        End Get
        Set(ByVal value As Double)
            m_Ast = value
        End Set
    End Property
    Private m_h As String
    Public Property h() As Double
        Get
            Return m_h
        End Get
        Set(ByVal value As Double)
            m_h = value
        End Set
    End Property
    Private m_L As String
    Public Property L() As Double
        Get
            Return m_L
        End Get
        Set(ByVal value As Double)
            m_L = value
        End Set
    End Property
    'TH1
    Private m_Mx As Double
    Public Property Mx() As Double
        Get
            Return m_Mx
        End Get
        Set(ByVal value As Double)
            m_Mx = value
        End Set
    End Property
    Private m_My As Double
    Public Property My() As Double
        Get
            Return m_My
        End Get
        Set(ByVal value As Double)
            m_My = value
        End Set
    End Property
    Private m_N As Double
    Public Property N() As Double
        Get
            Return m_N
        End Get
        Set(ByVal value As Double)
            m_N = value
        End Set
    End Property

    Private m_ea As Double
    Public Property ea() As Double
        Get
            Return m_ea
        End Get
        Set(ByVal value As Double)
            m_ea = value
        End Set
    End Property
    Private m_cotThep As New ClsCotThep
    Public Property CotThep() As ClsCotThep
        Get
            Return m_cotThep
        End Get
        Set(ByVal value As ClsCotThep)
            m_cotThep = value
        End Set
    End Property
End Class
