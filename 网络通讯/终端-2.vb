Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.Diagnostics

Public Class Form2

    Dim Listener As Socket
    Dim MySocket As Socket
    Dim IsRun As Boolean = False
    Dim MyThread As Thread

    Public Sub Listen()
        Dim bytes(10) As Byte
        Dim data As String = String.Empty
        Dim tokens() As String
        Dim localEndPoint As New IPEndPoint(Net.IPAddress.Parse(IPtxt.Text), CInt(Porttxt.Text))

        listener = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        listener.Bind(localEndPoint)
        listener.Listen(10)

        mySocket = listener.Accept()
        IsRun = True

        While True
            MySocket.Receive(bytes)
            data = Encoding.UTF8.GetString(bytes)
            tokens = data.Trim.Split("|")

            Select Case tokens(0) '分析接收到的数据，可自己定义更多一些
                Case "Chat"
                    BeginInvoke(New EventHandler(AddressOf AddInfo), tokens(1))  'Invoke保证线程安全
                Case "Exit"
                    IsRun = False
                    BeginInvoke(New EventHandler(AddressOf AddInfo), tokens(1))  'Invoke保证线程安全
                    mySocket.Shutdown(SocketShutdown.Both)
                    mySocket.Close()
                    Exit Sub
            End Select
        End While
    End Sub

    Sub AddInfo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("远程信息: " + sender.ToString, , "2")
    End Sub

    Private Sub SendString_Click(sender As Object, e As EventArgs) Handles SendString.Click
        Dim msg As Byte() = Encoding.UTF8.GetBytes("Chat|" + Stringtxt.Text)
        mySocket.Send(msg)
    End Sub

    Private Sub ListenRequest_Click(sender As Object, e As EventArgs) Handles ListenRequest.Click
        myThread = New Thread(AddressOf Listen)
        myThread.Start()
    End Sub

    Private Sub Disconnect_Click(sender As Object, e As EventArgs) Handles Disconnect.Click
        If IsRun Then
            Dim msg As Byte() = Encoding.UTF8.GetBytes("Exit|服务端退出: " + Me.Handle.ToString)
            Dim bytesSent As Integer = mySocket.Send(msg)
        End If
        Listener.Close()
        MySocket = Nothing
        myThread.Abort()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class