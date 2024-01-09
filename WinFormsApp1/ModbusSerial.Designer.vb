<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModbusSerial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ReadStatus = New Label()
        WriteStatus = New Label()
        ErrorText = New Label()
        ListBox1 = New ListBox()
        ReadLength = New TextBox()
        ConnectionStatus = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        ReadRegister = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        WriteValue = New TextBox()
        WriteRegister = New TextBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        SuspendLayout()
        ' 
        ' ReadStatus
        ' 
        ReadStatus.AutoSize = True
        ReadStatus.Location = New Point(411, 155)
        ReadStatus.Name = "ReadStatus"
        ReadStatus.Size = New Size(0, 20)
        ReadStatus.TabIndex = 34
        ' 
        ' WriteStatus
        ' 
        WriteStatus.AutoSize = True
        WriteStatus.Location = New Point(114, 168)
        WriteStatus.Name = "WriteStatus"
        WriteStatus.Size = New Size(0, 20)
        WriteStatus.TabIndex = 33
        ' 
        ' ErrorText
        ' 
        ErrorText.AutoSize = True
        ErrorText.Location = New Point(11, 223)
        ErrorText.Name = "ErrorText"
        ErrorText.Size = New Size(124, 20)
        ErrorText.TabIndex = 32
        ErrorText.Text = "No Error Occured"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Items.AddRange(New Object() {"Waiting for Read Command..."})
        ListBox1.Location = New Point(11, 252)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(532, 144)
        ListBox1.TabIndex = 31
        ' 
        ' ReadLength
        ' 
        ReadLength.Location = New Point(418, 109)
        ReadLength.Name = "ReadLength"
        ReadLength.Size = New Size(125, 27)
        ReadLength.TabIndex = 30
        ' 
        ' ConnectionStatus
        ' 
        ConnectionStatus.AutoSize = True
        ConnectionStatus.Location = New Point(13, 196)
        ConnectionStatus.Name = "ConnectionStatus"
        ConnectionStatus.Size = New Size(162, 20)
        ConnectionStatus.TabIndex = 29
        ConnectionStatus.Text = "Waiting for Connection"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(311, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(165, 29)
        Button4.TabIndex = 28
        Button4.Text = "STOP CONNECTION"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(96, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(165, 29)
        Button3.TabIndex = 27
        Button3.Text = "START CONNECTION"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(311, 168)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 26
        Button2.Text = "READ"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(13, 164)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 25
        Button1.Text = "WRITE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(311, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 24
        Label4.Text = "Length"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(311, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 20)
        Label3.TabIndex = 23
        Label3.Text = "Read Register"
        ' 
        ' ReadRegister
        ' 
        ReadRegister.Location = New Point(418, 62)
        ReadRegister.Name = "ReadRegister"
        ReadRegister.Size = New Size(125, 27)
        ReadRegister.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 21
        Label2.Text = "Value"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 20
        Label1.Text = "Write Register"
        ' 
        ' WriteValue
        ' 
        WriteValue.Location = New Point(112, 102)
        WriteValue.Name = "WriteValue"
        WriteValue.Size = New Size(125, 27)
        WriteValue.TabIndex = 19
        ' 
        ' WriteRegister
        ' 
        WriteRegister.Location = New Point(112, 59)
        WriteRegister.Name = "WriteRegister"
        WriteRegister.Size = New Size(125, 27)
        WriteRegister.TabIndex = 18
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(18, 136)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(124, 24)
        CheckBox1.TabIndex = 35
        CheckBox1.Text = "Multiple Read"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(311, 138)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(110, 24)
        CheckBox2.TabIndex = 36
        CheckBox2.Text = "Single Read"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' ModbusSerial
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(555, 407)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(ReadStatus)
        Controls.Add(WriteStatus)
        Controls.Add(ErrorText)
        Controls.Add(ListBox1)
        Controls.Add(ReadLength)
        Controls.Add(ConnectionStatus)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ReadRegister)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(WriteValue)
        Controls.Add(WriteRegister)
        Name = "ModbusSerial"
        Text = "MODBUS SERIAL"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ReadStatus As Label
    Friend WithEvents WriteStatus As Label
    Friend WithEvents ErrorText As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ReadLength As TextBox
    Friend WithEvents ConnectionStatus As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ReadRegister As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WriteValue As TextBox
    Friend WithEvents WriteRegister As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
