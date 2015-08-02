Public Class Func

    ''' <summary>
    ''' Invert RGB of a color
    ''' </summary>
    ''' <param name="c">Color to invert</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InverseColor(ByVal c As Color) As Color
        Return Color.FromArgb(255 - CInt(c.R), 255 - CInt(c.G), 255 - CInt(c.B))
    End Function

    ''' <summary>
    ''' Calculate Data Rate per second and Convert
    ''' </summary>
    ''' <param name="nd">Value in Bytes per second</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalcRate(ByVal nd As Integer) As String
        Dim ndv As String = "B/s" ''units
        ndv = "B/s"
        If nd > 999 Then
            nd = nd / 1024
            ndv = "KB/s"
            If nd > 999 Then
                ndv = "MB/s"
                nd = nd / 1024
                If nd > 999 Then
                    ndv = "GB/s"
                    nd = nd / 1024
                End If
            End If
        ElseIf nd = 0 Then
            ndv = ""
        End If
        Return Math.Round(nd, 2) & " " & ndv
    End Function
End Class
