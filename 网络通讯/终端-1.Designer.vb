<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.IPtxt = New System.Windows.Forms.TextBox()
        Me.Porttxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Stringtxt = New System.Windows.Forms.TextBox()
        Me.SendRequest = New System.Windows.Forms.Button()
        Me.SendString = New System.Windows.Forms.Button()
        Me.Disconnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IPtxt
        '
        Me.IPtxt.Location = New System.Drawing.Point(83, 12)
        Me.IPtxt.Name = "IPtxt"
        Me.IPtxt.Size = New System.Drawing.Size(72, 21)
        Me.IPtxt.TabIndex = 0
        Me.IPtxt.Text = "127.0.0.1"
        '
        'Porttxt
        '
        Me.Porttxt.Location = New System.Drawing.Point(83, 39)
        Me.Porttxt.Name = "Porttxt"
        Me.Porttxt.Size = New System.Drawing.Size(72, 21)
        Me.Porttxt.TabIndex = 1
        Me.Porttxt.Text = "8888"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "远程IP："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "远程端口："
        '
        'Stringtxt
        '
        Me.Stringtxt.Location = New System.Drawing.Point(14, 66)
        Me.Stringtxt.Multiline = True
        Me.Stringtxt.Name = "Stringtxt"
        Me.Stringtxt.Size = New System.Drawing.Size(141, 47)
        Me.Stringtxt.TabIndex = 4
        Me.Stringtxt.Text = "Welcome to Xiaoyan Software."
        '
        'SendRequest
        '
        Me.SendRequest.Location = New System.Drawing.Point(161, 10)
        Me.SendRequest.Name = "SendRequest"
        Me.SendRequest.Size = New System.Drawing.Size(75, 23)
        Me.SendRequest.TabIndex = 5
        Me.SendRequest.Text = "发送请求"
        Me.SendRequest.UseVisualStyleBackColor = True
        '
        'SendString
        '
        Me.SendString.Location = New System.Drawing.Point(161, 90)
        Me.SendString.Name = "SendString"
        Me.SendString.Size = New System.Drawing.Size(75, 23)
        Me.SendString.TabIndex = 6
        Me.SendString.Text = "发送字符串"
        Me.SendString.UseVisualStyleBackColor = True
        '
        'Disconnect
        '
        Me.Disconnect.Location = New System.Drawing.Point(161, 37)
        Me.Disconnect.Name = "Disconnect"
        Me.Disconnect.Size = New System.Drawing.Size(75, 23)
        Me.Disconnect.TabIndex = 7
        Me.Disconnect.Text = "断开连接"
        Me.Disconnect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 123)
        Me.Controls.Add(Me.Disconnect)
        Me.Controls.Add(Me.SendString)
        Me.Controls.Add(Me.SendRequest)
        Me.Controls.Add(Me.Stringtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Porttxt)
        Me.Controls.Add(Me.IPtxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "终端-1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IPtxt As System.Windows.Forms.TextBox
    Friend WithEvents Porttxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Stringtxt As System.Windows.Forms.TextBox
    Friend WithEvents SendRequest As System.Windows.Forms.Button
    Friend WithEvents SendString As System.Windows.Forms.Button
    Friend WithEvents Disconnect As System.Windows.Forms.Button

End Class
