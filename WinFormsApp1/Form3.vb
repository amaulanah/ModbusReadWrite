Imports EasyModbus

Public Class Form3
    Dim ComEror
    Dim ModbusClient
    Dim easymodbus As New EasyModbus.ModbusClient
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        easymodbus.Baudrate = "19200"
        easymodbus.Parity = IO.Ports.Parity.Even
        easymodbus.StopBits = "1"
        easymodbus.SerialPort = "COM2"

        Try
            easymodbus.Connect()
            ConnectionStatus.Text = "Connection Established Trough Serial"
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            easymodbus.Disconnect()
            ConnectionStatus.Text = "Connection Trough Serial was Aborted"
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim DataList As Integer()
        Try
            DataList = easymodbus.ReadHoldingRegisters(Convert.ToInt16(ReadRegister.Text), Convert.ToInt16(ReadLength.Text))
            ListBox1.Items.Clear()
            If (DataList.Length >= 1) Then
                For Each i As Integer In DataList
                    ListBox1.Items.Add(i)
                Next
            End If
            ReadStatus.Text = "Read Succeed"
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            easymodbus.WriteSingleRegister(Convert.ToInt32(WriteRegister.Text), Convert.ToInt32(WriteValue.Text))
            WriteStatus.Text = "Write Succeed"
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try
    End Sub
End Class