Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports EasyModbus

Public Class ModbusSerial
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
            If ReadLength.Text = "" Then
                DataList = easymodbus.ReadHoldingRegisters(Convert.ToInt16(ReadRegister.Text), 1)
            Else
                DataList = easymodbus.ReadHoldingRegisters(Convert.ToInt16(ReadRegister.Text), Convert.ToInt16(ReadLength.Text))
            End If
            ListBox1.Items.Clear()
            If (DataList.Length >= 1) Then
                For Each i As Integer In DataList
                    ListBox1.Items.Add(i)
                Next
            End If
            ReadStatus.Text = "Read Succeed"
            ReadRegister.Text = ""
            ReadLength.Text = ""
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try
    End Sub

    'Function WriteRegisterSelector(value)
    '    If value = 1 Then
    '        Return "WriteMultipleRegisters"
    '    ElseIf value = 0 Then
    '        Return "WriteSingleRegister"
    '    End If
    'End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If CheckBox1.Checked Then
                easymodbus.WriteMultipleRegisters(Convert.ToInt32(WriteRegister.Text), {WriteValue.Text})
            Else
                easymodbus.WriteSingleRegister(Convert.ToInt32(WriteRegister.Text), Convert.ToInt32(WriteValue.Text))
            End If
            WriteStatus.Text = "Write Succeed"
            WriteRegister.Text = ""
            WriteValue.Text = ""
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            ReadLength.Enabled = False
        Else
            ReadLength.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label2.Text = "Values Multiple"
        Else
            Label2.Text = "Value"
        End If
    End Sub

    'Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
    '    If CheckBox1.Checked Then
    '        WriteRegisterSelector(1)
    '    Else
    '        WriteRegisterSelector(0)
    '    End If
    'End Sub
End Class