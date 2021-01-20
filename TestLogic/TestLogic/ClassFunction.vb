Public Class ClassFunction
    Public Function BilanganGanjilGenap(Count As Integer, StartNumber As Integer) As String
        Dim __Result As String = ""
        __Result = StartNumber.ToString
        For __i As Integer = 1 To Count - 1
            If __Result <> "" Then __Result = __Result + ", "
            __Result = __Result + (StartNumber + 2).ToString
            StartNumber = StartNumber + 2
        Next
        Return __Result
    End Function

    Function BilanganPrima(ByVal Number As Integer) As Boolean
        If Number < 2 Then Exit Function
        BilanganPrima = True
        For __i As Integer = 2 To Number - 1
            If Number Mod __i = 0 Then
                BilanganPrima = False
                Exit For
            End If
        Next
    End Function

    Function Faktorial(ByVal Number As Integer) As Integer
        Faktorial = 1
        For __i = 2 To Number
            Faktorial = Faktorial * __i
        Next
    End Function

    Public Function Terbilang(ByVal Value As Decimal) As String
        Dim __Konversi As String() = {"", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas"}
        Dim __Result As String = ""

        If Value < 12 Then
            __Result = __Konversi(Value)
        ElseIf Value < 20 Then
            __Result = Terbilang(Value - 10) + " belas "
        ElseIf Value < 100 Then
            __Result = Terbilang(Value / 10) + " puluh " + Terbilang(Value Mod 10)
        ElseIf Value < 200 Then
            __Result = " seratus " + Terbilang(Value - 100)
        ElseIf Value < 1000 Then
            __Result = Terbilang(Value / 100) + " ratus " + Terbilang(Value Mod 100)
        ElseIf Value < 2000 Then
            __Result = " seribu " + Terbilang(Value - 1000)
        ElseIf Value < 1000000 Then
            __Result = Terbilang(Value / 1000) + " ribu " + Terbilang(Value Mod 1000)
        ElseIf Value < 1000000000 Then
            __Result = Terbilang(Value / 1000000) + " juta " + Terbilang(Value Mod 1000000)
        ElseIf Value < 1000000000000 Then
            __Result = Terbilang(Value / 1000000000) + " milyar " + Terbilang(Value Mod 1000000000)
        ElseIf Value < 1000000000000000 Then
            __Result = Terbilang(Value / 1000000000000) + " triliyun " + Terbilang(Value Mod 1000000000000)
        End If

        Return LTrim(__Result)
    End Function

End Class
