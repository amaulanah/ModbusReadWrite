Imports EasyModbus
Imports System.Data.OleDb

Public Class ModbusTCP
    Dim Conn As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim Ds As DataSet
    Dim DBDir As String

    Dim ComError
    Dim ModbusClient
    Dim easymodbus As New EasyModbus.ModbusClient

    Sub ConnectionDatabase()
        DBDir = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database11.accdb"
        Conn = New OleDbConnection(DBDir)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        easymodbus.IPAddress = "127.0.0.1"
        easymodbus.Port = "502"
        ComError = 0

        Try
            easymodbus.Connect()
            ConnectionStatus.Text = "Connection Established"
        Catch ex As Exception
            ErrorText.Text = ex.Message
            ComError = 1
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            easymodbus.Disconnect()
            ConnectionStatus.Text = "Connection Aborted"
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim array() As Integer = {1, 2, 3, 4, 5}
        Try
            easymodbus.WriteSingleRegister(Convert.ToInt32(WriteRegister.Text), Convert.ToInt32(WriteValue.Text))
            'easymodbus.WriteMultipleRegisters(20, array)
            WriteStatus.Text = "Write Succeed"
        Catch ex As Exception
            ErrorText.Text = ex.Message
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim DataList As Integer()
        ConnectionDatabase()
        Da = New OleDbDataAdapter("SELECT * FROM Table1", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Table1")
        Try
            DataList = easymodbus.ReadHoldingRegisters(Convert.ToInt16(ReadRegister.Text), Convert.ToInt16(ReadLength.Text))
            ListBox1.Items.Clear()
            'Dim combinedUniqueNames = DataList.Union(Ds.Tables("Table1")).Distinct().ToArray()
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
