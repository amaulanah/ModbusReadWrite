Imports EasyModbus

Public Class Form1
    Dim ComError
    Dim ModbusClient
    Dim modClient As New EasyModbus.ModbusClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        modClient.IPAddress = "127.0.0.1"
        modClient.Port = "502"
        ComError = 0

        Try
            modClient.Connect()
            ConnectionStatus.Text = "Connection Established"
        Catch ex As Exception
            ErrorText.Text = ex.Message
            ComError = 1
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            modClient.Disconnect()
            ConnectionStatus.Text = "Connection Aborted"
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            modClient.WriteSingleRegister(Convert.ToInt16(WriteRegister.Text), Convert.ToInt16(WriteValue.Text))
            WriteStatus.Text = "Write Succeed"
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim DataList As Integer()
        Try
            DataList = modClient.ReadHoldingRegisters(Convert.ToInt16(ReadRegister.Text), Convert.ToInt16(ReadLength.Text))
            ListBox1.Items.Clear()
            If (DataList.Length >= 1) Then
                For Each value As Integer In DataList
                    ListBox1.Items.Add(value)
                Next
            End If
            ReadStatus.Text = "Read Succeed"
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try
    End Sub
End Class
