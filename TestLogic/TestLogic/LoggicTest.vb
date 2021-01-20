Public Class LoggicTest
    Private _Func As New ClassFunction
    Private _Result As String

    Private Sub BilanganPrimaFaktor(Count As Integer, ByRef Result As String, Optional ByVal isPrima As Boolean = False)
        Dim __i As Integer = 1
        Dim __Value As Integer = 1
        Dim __NextValue As Boolean

        Result = ""

        While __i <= Count
            __NextValue = False
            If _Func.BilanganPrima(__Value) And isPrima Then
                If Result <> "" Then Result = Result + ", "
                Result = Result + __Value.ToString
                __NextValue = True
            End If
            If Not isPrima Then
                If Result <> "" Then Result = Result + ", "
                Result = Result + _Func.Faktorial(__Value).ToString
                __NextValue = True
            End If
            __Value = __Value + 1
            If __NextValue Then __i = __i + 1
        End While
    End Sub

    Private Sub GanjilGenapBtn1_Click(sender As Object, e As EventArgs) Handles GanjilGenapBtn1.Click
        Try
            If CInt(InputGanjilGenap.Text) > 50 Then
                MessageBox.Show("Nilai Lebih dari 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                TextGanjil.Text = _Func.BilanganGanjilGenap(CInt(InputGanjilGenap.Text), 1)
                TextGenap.Text = _Func.BilanganGanjilGenap(CInt(InputGanjilGenap.Text), 2)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FaktorialBtn1_Click(sender As Object, e As EventArgs) Handles FaktorialBtn1.Click
        Try
            If CInt(InputFaktorial.Text) > 20 Then
                MessageBox.Show("Nilai Lebih dari 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                BilanganPrimaFaktor(CInt(InputFaktorial.Text), _Result)
                ResulFaktorial.Text = _Result
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrimaBtn1_Click(sender As Object, e As EventArgs) Handles PrimaBtn1.Click
        Try
            If CInt(InputPrima.Text) > 50 Then
                MessageBox.Show("Nilai Lebih dari 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                BilanganPrimaFaktor(CInt(InputPrima.Text), _Result, True)
                ResultPrima.Text = _Result
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub KonversiBtn1_Click(sender As Object, e As EventArgs) Handles KonversiBtn1.Click
        Try
            ResulKonversi.Text = _Func.Terbilang(CDec(InputKonversi.Text))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
