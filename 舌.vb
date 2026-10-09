Imports System.Media, System.Math, System.Threading, Microsoft.DirectX.DirectSound, System.IO, System.Windows.Forms.Application, Emgu, Emgu.CV.CvInvoke, Emgu.CV.Structure
Public Module 舌
    Public 口 As Thread = New Thread(AddressOf 口_), 念 As Thread = New Thread(AddressOf 念_),
         味 As Integer, bffsdftb0, bffsdft0, bffsdftb, bffi0, cbf As CV.Image(Of Gray, Single), tan1(360), q(200) As Double, lv As Boolean,
         cbf0 As New CV.Image(Of Gray, Single)(1, 2000), bffibs0, bffibs As CV.Image(Of Gray, Short), sw As Stopwatch = New Stopwatch, me1 As IntPtr, fst As Double
    Dim dvc As Device, Buff As Buffer, dvcc As DevicesCollection, bff(0), qtbf(0) As Byte, stm As IO.MemoryStream,
        are00, are01, are02, are03, atk As New AutoResetEvent(False), Wbf0 As New Thread(AddressOf WriteBuff0),
        ntf0 As Notify, ntfn0(3) As BufferPositionNotify, st As Double = 200, cn As Integer = 1, sps As Integer = 40000, msps = sps / 1000, bfbt, qtbfbt, qtbfsp, ctvl As Integer, bffs(0, 0, 0) As Single,
        ctrbf0(0, 0, 0) As Double, Sctr As Thread = New Thread(AddressOf Sctr_), u As Double = 10, bffi, bffib, bffsdft, bffib0 As CV.Image(Of Gray, Single), bffss(0, 0, 0) As Short
    Private Sub 念_()
        dvcc = New DevicesCollection : dvc = New Device(dvcc.Item(1).DriverGuid) : dvc.SetCooperativeLevel(me1, CooperativeLevel.Normal)
        NewWavAry(bff, st) : bfbt = bff.Length - 59 : qtbfbt = bfbt / 4 : qtbfsp = qtbfbt / 2 : ReDim qtbf(qtbfbt - 1), bffs(qtbfsp - 1, 0, 0), ctrbf0(150, 1, 49), bffss(qtbfsp - 1, 0, 0)
        bffsdft = New CV.Image(Of Gray, Single)(bffs) : bffi = bffsdft.Clone : cbf = bffi.Clone : bffib = bffi.Clone : bffsdftb = bffi.Clone
        cbf = bffi.Clone : bffi0 = bffi.Clone : bffsdft0 = bffi.Clone : bffib0 = bffi.Clone : bffsdftb0 = bffi.Clone : stm = New IO.MemoryStream(bff)
        bffibs = New CV.Image(Of Gray, Short)(bffss) : Buff = New Buffer(stm, dvc) : q(117) = 50 : q(1) = 50 : q(21) = 50
        ntfn0(0).Offset = bfbt * 0.0 : ntfn0(0).EventNotifyHandle = are00.Handle : ntfn0(1).Offset = bfbt * 0.25 : ntfn0(1).EventNotifyHandle = are01.Handle
        ntfn0(2).Offset = bfbt * 0.5 : ntfn0(2).EventNotifyHandle = are02.Handle : ntfn0(3).Offset = bfbt * 0.75 : ntfn0(3).EventNotifyHandle = are03.Handle
        ntf0 = New Notify(Buff) : ntf0.SetNotificationPositions(ntfn0) : Buff.Play(0, BufferPlayFlags.Looping) : Wbf0.Start() : Sctr.Start()
    End Sub
    Public Sub WriteBuff0()
        显示("nok,") : ar.Set() : Do While Run
            are00.WaitOne() : Buff.Write(bfbt * 0.5, qtbf, LockFlag.None) : MB() : are01.WaitOne() : Buff.Write(bfbt * 0.75, qtbf, LockFlag.None) : MB()
            are02.WaitOne() : Buff.Write(bfbt * 0.0, qtbf, LockFlag.None) : MB() : are03.WaitOne() : Buff.Write(bfbt * 0.25, qtbf, LockFlag.None) : MB() : Loop : Buff.Dispose() : dvc.Dispose() : 显示("ned,") : ae += 1
    End Sub
    Dim fqv, vlv, fqv_, vlv_ As Double, bdta As Short, spp As Integer
    Public Sub MB()
        Dim v, vt As Double ' 显示(flg.ToString + Et) 
        For ms As Integer = 1 To st / 4 : fqv = (ctrbf0(143, 1, ms - 1)) / 10 : vlv = ctrbf0(142, 1, ms - 1) : Dim fqpsp As Double = (fqv - fqv_) / msps, vlpsp As Double = (vlv - vlv_) / msps
            For sp As Integer = 1 To msps : Dim fq As Double = fqv_ + sp * fqpsp, vl As Double = (vlv_ + sp * vlpsp) / 1000, ro As Double = u / jd
                vt = Fix(((ro + q(1 + 40)) * q(1)) Mod 360) : v = tan1(vt) * q(1 + 20) / 10 : v = v * vl : u = u + fq : bffs((ms - 1) * msps + sp - 1, 0, 0) = v  ' v = Sin(ro) * 4000 + Sin(ro * 1.2) * 5000 + Sin(ro * 1.3) * 4000 + Sin(ro * 1.4) * 4000 + Sin(ro * 1.5) * 4000 + Sin(ro * 1.6) * 4000
            Next : fqv_ = fqv : vlv_ = vlv : Next : bffi.Data = bffs : bffi0 = bffi.Clone
        Dft(bffi, bffsdft, CV.CvEnum.DxtType.Forward, 0) : bffsdft0 = bffsdft.Clone : bffsdftb = bffsdft.Mul(cbf / 10) : bffsdftb0 = bffsdftb.Clone
        Dft(bffsdftb, bffib, CV.CvEnum.DxtType.Inverse, 0) : bffibs = (bffib / 5000).Convert(Of Gray, Short)() : bffibs0 = bffibs.Clone
        For sp As Integer = 0 To qtbfsp - 1 : spp = (sp) * 2 : bdta = bffibs.Data(sp, 0, 0) : qtbf(spp) = cb(bdta, 0) : qtbf(spp + 1) = cb(bdta, 1) : v = 0 : Next
    End Sub
    Public Sub Sctr_()
        Dim tkp As Long : Do While Run
            For i = 0 To 48 : ctrbf0(142, 1, i) = ctrbf0(142, 1, i + 1) : ctrbf0(143, 1, i) = ctrbf0(143, 1, i + 1) : Next : ctrbf0(142, 1, 49) = q(142) : ctrbf0(143, 1, 49) = q(143)
            fst = sw.ElapsedMilliseconds - tkp : tkp = sw.ElapsedMilliseconds : atk.WaitOne(1) : Loop
    End Sub
    Private Sub 口_()
    End Sub
    Private Function NewWavAry(ByRef SA() As Byte, ByVal Tm#) As Array
        Dim u2% = Tm / 1000 * 2 * cn * sps, u3% = 2 * cn * sps, u0% = u2 + 50 : ReDim Preserve SA(u2 + 58)
        SA(0) = Asc("R") : SA(1) = Asc("I") : SA(2) = Asc("F") : SA(3) = Asc("F")         '资源交换文件标志(RIFF)
        SA(4) = cb(u0, 0) : SA(5) = cb(u0, 1) : SA(6) = cb(u0, 2) : SA(7) = cb(u0, 3)     '从下个地址开始到文件尾的总字节数
        SA(8) = Asc("W") : SA(9) = Asc("A") : SA(10) = Asc("V") : SA(11) = Asc("E")       'WAV文件标志（WAVE）
        SA(12) = Asc("f") : SA(13) = Asc("m") : SA(14) = Asc("t") : SA(15) = Asc(" ")     '波形格式标志（fmt ），最后一位空格。
        SA(16) = &H12 : SA(17) = 0 : SA(18) = 0 : SA(19) = 0                              '过滤字节（一般为00000010H）
        SA(20) = 1 : SA(21) = 0                                                           '格式种类（值为1时，表示数据为线性PCM编码
        SA(22) = 1 : SA(23) = 0                                                           '通道数，单声道为1，双声道为2
        SA(24) = cb(sps, 0) : SA(25) = cb(sps, 1) : SA(26) = cb(sps, 2) : SA(27) = cb(sps, 3) '采样频率
        SA(28) = cb(u3, 0) : SA(29) = cb(u3, 1) : SA(30) = cb(u3, 2) : SA(31) = cb(u3, 3) '波形数据传输速率（每秒平均字节数）
        SA(32) = &H2 : SA(33) = &H0                                                       'DATA数据块长度，字节。
        SA(34) = &H10 : SA(35) = &H0 : SA(36) = &H0 : SA(37) = &H0                        'PCM位宽
        SA(38) = Asc("f") : SA(39) = Asc("a") : SA(40) = Asc("c") : SA(41) = Asc("t")     '“fact”,该部分一下是可选部分，即可能有，可能没有,一般到WAV文件由某些软件转换而成时，包含这部分。
        SA(42) = &H4 : SA(43) = &H0 : SA(44) = &H0 : SA(45) = &H0                         'size,数值为4
        SA(46) = &H3A : SA(47) = &H56 : SA(48) = &H0 : SA(49) = &H0
        SA(50) = Asc("d") : SA(51) = Asc("a") : SA(52) = Asc("t") : SA(53) = Asc("a")     '数据标志符（data）
        SA(54) = cb(u2, 0) : SA(55) = cb(u2, 1) : SA(56) = cb(u2, 2) : SA(57) = cb(u2, 3) 'DATA总数据长度字节
        Return SA
    End Function
    Private Function cb(ByVal i As Integer, ByVal n As Byte) As Byte
        Return i >> (n * 8) And &HFF
    End Function
End Module
