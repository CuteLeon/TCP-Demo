Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Form1
    Dim MySocket As Socket
    Dim IsConnected As Boolean = False
    Dim MyThread As Thread

    Sub ReciveMsg()
        Dim GetByte(10) As Byte
        Dim GetString As String
        Dim tokens() As String

        While True
            MySocket.Receive(GetByte)
            GetString = Encoding.UTF8.GetString(GetByte)
            tokens = GetString.Trim.Split("|")

            Select Case tokens(0) '分析接收到的数据，可自己定义更多一些
                Case "Exit"
                    IsConnected = False
                    BeginInvoke(New EventHandler(AddressOf AddInfo), tokens(1))   'Invoke保证线程安全
                    MySocket.Shutdown(SocketShutdown.Both)
                    MySocket.Close()
                    Exit Sub
                Case "Chat"
                    BeginInvoke(New EventHandler(AddressOf AddInfo), tokens(1))   'Invoke保证线程安全
            End Select
        End While
    End Sub

    '非UI线程调用窗体控件，保证线程安全。与聊天实现无关。
    Sub AddInfo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("远程信息: " + sender.ToString, , "1")
    End Sub

    Private Sub SendRequest_Click(sender As Object, e As EventArgs) Handles SendRequest.Click
        Dim remoteEP As New IPEndPoint(Net.IPAddress.Parse(IPtxt.Text), CInt(Porttxt.Text))
        MySocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

        Try
            MySocket.Connect(remoteEP)
            IsConnected = True
            MyThread = New Thread(AddressOf ReciveMsg)
            MyThread.Start()
        Catch ex As Exception
            'Something wrong.
        End Try
    End Sub

    Private Sub Disconnect_Click(sender As Object, e As EventArgs) Handles Disconnect.Click
        If IsConnected Then
            Dim msg As Byte() = Encoding.UTF8.GetBytes("Exit|客户端退出: " + Me.Handle.ToString)
            MySocket.Send(msg)
            MySocket.Close()
            MySocket = Nothing
            MyThread.Abort()
        End If
    End Sub

    Private Sub SendString_Click(sender As Object, e As EventArgs) Handles SendString.Click
        Dim msg As Byte() = Encoding.UTF8.GetBytes("Chat|" + Stringtxt.Text)
        MySocket.Send(msg)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
    End Sub
End Class