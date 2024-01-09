Public Class ModbusConnectionSelectors
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form3 As New ModbusSerial
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.Close()
        Dim Form1 As New ModbusTCP
        Form1.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class