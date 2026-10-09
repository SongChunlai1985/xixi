Imports System.IO, System.Threading
Module 身
    Private 行___ As System.IO.Ports.SerialPort = New System.IO.Ports.SerialPort With {.PortName = "COM3", .ReadBufferSize = 512, .WriteBufferSize = 512, .BaudRate = 115200, .DataBits = 8, .StopBits = 1, .Parity = Ports.Parity.None, .RtsEnable = False}, 触___ As System.IO.Ports.SerialPort
    Private 触l As String = "", Dp_(32) As Integer, odr As String, Nodr As Integer, Dk#(32), 触%(7), Fed$
    Public 行 As New Thread(AddressOf 行_), 触_ As New Thread(AddressOf 触__), Dp(32) As Integer, 感受信息t$ = "", DpT%, dm%(32)
    Public 动作组 As New Thread(AddressOf 动作组_), drr As New AutoResetEvent(True), 动作中 As Boolean, 动作$

    Public Sub 行___Open()
        行___.Open()
    End Sub
    Private Sub 行_()
        行___Open() : For i = 1 To 32 : Dk(i) = 11.1 : Next : 读取动作() : DpT = 20
        显示("bdok,") : ar.Set() : Do While Run : drr.WaitOne(1) : Dr2Dp() : 编码指令() : Loop : 写入动作() : 行___.Close() : 行___.Dispose() : 显示("bded,") : ae += 1
    End Sub
    Private Sub 触__()
        '  触___ = New System.IO.Ports.SerialPort With {.PortName = "COM4", .ReadBufferSize = 1024000, .WriteBufferSize = 1024000, .BaudRate = 9600, .DataBits = 8, .StopBits = 1, .Parity = Ports.Parity.None, .RtsEnable = False} : 触___.Open()
        显示("cok,") : ar.Set() : Do While Run : Thread.Sleep(10) : Loop : 显示("ced,") : ae += 1 ' 触l = 触___.ReadExisting : If 触l <> "" And 触l <> " " Then : Fltrs() : Flprt() : End If :: 触___.Close() : 触___.Dispose()
    End Sub
    Private Sub Dr2Dp()
        For i = 1 To 32 : Dp(i) = Dr(i) * 11.1 + 1500 : Next
    End Sub
    Private Sub 编码指令()
        Dim i As Long, newodr As Boolean : odr = ""
        For i = 1 To 32 : If Dp(i) <> Dp_(i) Then : odr = "#" & i & "P" & Dp(i).ToString & Chr(13) & Chr(10) : Nodr = Nodr + 1
                行___.Write(odr) : newodr = True : 显示(Nodr.ToString + ">:" + odr) : End If : Next : If newodr Then Array.Copy(Dp, Dp_, Dp.Length)
    End Sub
    Private Sub Fltrs()
        Dim ip As Integer = 1, ipN As Integer : 触l = Fed + 触l : If Len(触l) > 30 Then 触l = ""
        If Len(触l) < 10 Then : Fed = 触l : Exit Sub : End If
        Do Until ip = 0 : ip = InStr(ip, 触l, ",") : ipN = InStr(ip + 1, 触l, ",") : If ipN <> 0 And ipN - ip > 3 Then 触(Val(Mid(触l, ip + 2, 1))) = Val(Mid(触l, ip + 4, ipN - ip - 3))
            Fed = Right(触l, Len(触l) - ip + 1) : ip = ipN : Loop
    End Sub
    Private Sub Flprt()
        Dim i As Long : 感受信息t = "" : For i = 0 To 6 : 感受信息t = 感受信息t + "A" + CStr(i) + ":" + CStr(触(i)) + "," : Next : 感受信息t = 感受信息t + "A" + CStr(7) + ":" + CStr(触(i))
    End Sub
    Sub dr1a()
        Dr(11) = Dr(11) - 13 : Dr(22) = Dr(22) - 13
        Dr(12) = Dr(12) + 13 : Dr(21) = Dr(21) + 13 : drr.Set()
    End Sub

    Sub dr1b()
        Dr(11) = Dr(11) + 13 : Dr(22) = Dr(22) + 13
        Dr(12) = Dr(12) - 13 : Dr(21) = Dr(21) - 13 : drr.Set()
    End Sub

    Sub dr1c()
        Dr(12) = Dr(12) + 8 : Dr(11) = Dr(11) - 13.33
        Dr(21) = Dr(21) - 8 : Dr(22) = Dr(22) + 13.33 : drr.Set()
    End Sub

    Sub dr1d()
        Dr(21) = Dr(21) + 8 : Dr(22) = Dr(22) - 13.33
        Dr(11) = Dr(11) + 13.33 : Dr(12) = Dr(12) - 8 : drr.Set()
    End Sub
    Sub 立正()
        Dr(11) = 0 : Dr(22) = 0
        Dr(12) = 0 : Dr(21) = 0 : drr.Set()
    End Sub
    Sub 动作组_()
        显示("dzzok,") : ar.Set() : Do While Run
            If 动作 = "点头" Then : Thread.Sleep(200) : DpT = 500 : f0(0).BD.F.x = f0(0).BD.F.x - 5000 : Thread.Sleep(1000) : f0(0).BD.F.x = f0(0).BD.F.x + 10000 : Thread.Sleep(1000) : f0(0).BD.F.x = f0(0).BD.F.x - 5000 : Thread.Sleep(200000) : DpT = 20 : End If
            动作中 = False : 动作 = "" : Thread.Sleep(20)
        Loop : 显示("dzzed,") : ae += 1
    End Sub
End Module
