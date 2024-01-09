<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModbusTCP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        WriteRegister = New TextBox()
        WriteValue = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        ReadRegister = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        ConnectionStatus = New Label()
        ReadLength = New TextBox()
        ListBox1 = New ListBox()
        ErrorText = New Label()
        WriteStatus = New Label()
        ReadStatus = New Label()
        SuspendLayout()
        ' 
        ' WriteRegister
        ' 
        WriteRegister.Location = New Point(128, 59)
        WriteRegister.Name = "WriteRegister"
        WriteRegister.Size = New Size(125, 27)
        WriteRegister.TabIndex = 0
        ' 
        ' WriteValue
        ' 
        WriteValue.Location = New Point(128, 102)
        WriteValue.Name = "WriteValue"
        WriteValue.Size = New Size(125, 27)
        WriteValue.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 2
        Label1.Text = "Write Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 3
        Label2.Text = "Value"
        ' 
        ' ReadRegister
        ' 
        ReadRegister.Location = New Point(434, 62)
        ReadRegister.Name = "ReadRegister"
        ReadRegister.Size = New Size(125, 27)
        ReadRegister.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(327, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 20)
        Label3.TabIndex = 5
        Label3.Text = "Read Register"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(327, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 6
        Label4.Text = "Length"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(35, 151)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "WRITE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(327, 151)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 9
        Button2.Text = "READ"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(112, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(165, 29)
        Button3.TabIndex = 10
        Button3.Text = "START CONNECTION"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(327, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(165, 29)
        Button4.TabIndex = 11
        Button4.Text = "STOP CONNECTION"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' ConnectionStatus
        ' 
        ConnectionStatus.AutoSize = True
        ConnectionStatus.Location = New Point(29, 196)
        ConnectionStatus.Name = "ConnectionStatus"
        ConnectionStatus.Size = New Size(162, 20)
        ConnectionStatus.TabIndex = 12
        ConnectionStatus.Text = "Waiting for Connection"
        ' 
        ' ReadLength
        ' 
        ReadLength.Location = New Point(434, 109)
        ReadLength.Name = "ReadLength"
        ReadLength.Size = New Size(125, 27)
        ReadLength.TabIndex = 13
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Items.AddRange(New Object() {"Waiting for Read Command..."})
        ListBox1.Location = New Point(27, 252)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(532, 144)
        ListBox1.TabIndex = 14
        ' 
        ' ErrorText
        ' 
        ErrorText.AutoSize = True
        ErrorText.Location = New Point(27, 223)
        ErrorText.Name = "ErrorText"
        ErrorText.Size = New Size(124, 20)
        ErrorText.TabIndex = 15
        ErrorText.Text = "No Error Occured"
        ' 
        ' WriteStatus
        ' 
        WriteStatus.AutoSize = True
        WriteStatus.Location = New Point(135, 155)
        WriteStatus.Name = "WriteStatus"
        WriteStatus.Size = New Size(0, 20)
        WriteStatus.TabIndex = 16
        ' 
        ' ReadStatus
        ' 
        ReadStatus.AutoSize = True
        ReadStatus.Location = New Point(427, 155)
        ReadStatus.Name = "ReadStatus"
        ReadStatus.Size = New Size(0, 20)
        ReadStatus.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(591, 408)
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
        Name = "Form1"
        Text = "MODBUS TCP/IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents WriteRegister As TextBox
    Friend WithEvents WriteValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ReadRegister As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ConnectionStatus As Label
    Friend WithEvents ReadLength As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ErrorText As Label
    Friend WithEvents WriteStatus As Label
    Friend WithEvents ReadStatus As Label

End Class
