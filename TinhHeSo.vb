Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DATN
    Public Module TinhHeSo
        Public Function Er(Rb As Double, Rs As Double) As Double
            Dim w As Double = 0.85 - 0.008 * Rb
            Dim resultEr As Double = w / (1 + (Rs / 400) * (1 - w / 1.1))
            Return Math.Round(resultEr, 3)
        End Function

        Public Function Esp(am As Double) As Double
            Return 1 - Math.Sqrt(1 - 2 * am)
        End Function

        Public Function Mf(Rb As Double, bf As Double, hf As Double, h0 As Double) As Double
            Return Rb * bf * hf * (h0 - 0.5 * hf)
        End Function
    End Module
End Namespace
