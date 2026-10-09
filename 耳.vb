Imports Microsoft.DirectX.DirectSound, Emgu, System.Threading, Emgu.CV.CvInvoke, Emgu.CV.Structure
Module 耳
    Private SdFmt As New WaveFormat, SdBfDsr As CaptureBufferDescription, CapList As CaptureDevicesCollection = New CaptureDevicesCollection,
        SdCper As Capture = New Capture(CapList(1).DriverGuid), 耳___ As CaptureBuffer, mtxl, mtxr, mtx01 As CV.Mat
    Public 耳_ As Thread = New Thread(AddressOf 耳__),
        Hrwddssz, Hrwddssz3, bxtsz, yptlsz, yptrsz, ypsz As Size,
             yptl, yptr As CV.Image(Of Bgr, Byte)
    Public minvl(10), maxvl(10), minvr(10), maxvr(10) As Double, minpl(10), maxpl(10), minpr(10), maxpr(10) As Point, Hr(0, 0, 0) As Short,
        Hrm, Hrml, Hrmr As CV.Image(Of Gray, Short), ypl, ypr, HrDFTml, HrDFTmr, Hrmdl, Hrmdr, Hrmdl3, Hrmdr3 As CV.Image(Of Gray, Single), ypl0, ypl1, ypl2, ypl3, ypr0, ypr1, ypr2, ypr3 As CV.Image(Of Gray, Byte),
        Sl, Msg(2), N As Integer, fwdl, fwdr, js As Single, bt As Single = 120
    Dim are0, are1, are2, are3, fx As New AutoResetEvent(False),
        ntf As Notify, ntfn(3) As BufferPositionNotify, td0 As New Thread(AddressOf ReadBuff0), td1 As New Thread(AddressOf 分析波形)
    Private Sub 耳__()
        With SdFmt : .SamplesPerSecond = 40000 : .Channels = 2 : .BitsPerSample = 16 : .FormatTag = WaveFormatTag.Pcm : .BlockAlign = CShort(.Channels * (.BitsPerSample / 8))
            .AverageBytesPerSecond = .BlockAlign * .SamplesPerSecond : End With
        With SdBfDsr : .BufferBytes = SdFmt.AverageBytesPerSecond * bt / 1000 : .ControlEffects = False : .WaveMapped = True : .Format = SdFmt : End With
        耳___ = New CaptureBuffer(SdBfDsr, SdCper) : Sl = SdBfDsr.BufferBytes / 4 : js = 0.1 : sw.Start()
        N = Sl / 4 : Msg(0) = Sl / 4 : Msg(1) = 2 : Msg(2) = 1 : ypsz = New Size(1, 390)
        Hrwddssz = New Size(1, N) : Hrwddssz3 = New Size(3, N) : Hrm = New CV.Image(Of Gray, Short)(Hr)
        Hrml = New CV.Image(Of Gray, Short)(Hrwddssz) : Hrmdl = New CV.Image(Of Gray, Single)(Hrwddssz) : Hrmdl3 = New CV.Image(Of Gray, Single)(Hrwddssz) : HrDFTml = Hrmdl.Clone
        Hrmr = New CV.Image(Of Gray, Short)(Hrwddssz) : Hrmdr = New CV.Image(Of Gray, Single)(Hrwddssz) : Hrmdr3 = New CV.Image(Of Gray, Single)(Hrwddssz) : HrDFTmr = Hrmdr.Clone
        ypl = New CV.Image(Of Gray, Single)(ypsz) : ypr = New CV.Image(Of Gray, Single)(ypsz)
        yptl = New CV.Image(Of Bgr, Byte)(yptlsz) : yptr = New CV.Image(Of Bgr, Byte)(yptrsz)
        mtxl = Nmt(0, 0) : mtxr = Nmt(-1, 0) : mtx01 = Nmt(0, 0, 0, 0, 0, 1, js)
        ntfn(0).Offset = Sl * 0 : ntfn(1).Offset = Sl * 1 : ntfn(2).Offset = Sl * 2 : ntfn(3).Offset = Sl * 3
        ntfn(0).EventNotifyHandle = are0.Handle : ntfn(1).EventNotifyHandle = are1.Handle : ntfn(2).EventNotifyHandle = are2.Handle : ntfn(3).EventNotifyHandle = are3.Handle
        For i = 0 To 1199 : Hrmdl3.Data(i, 0, 0) = i : Next : Hrmdr3.SetValue(New Gray(3))
        ntf = New Notify(耳___) : ntf.SetNotificationPositions(ntfn) : 耳___.Start(True) : q(114) = 1 : td0.Start() : td1.Start()
    End Sub
    Public Sub ReadBuff0()
        显示("edok,") : ar.Set() : Do While Run
            are0.WaitOne(bt) : Hr = 耳___.Read(Sl * 2, GetType(Short), LockFlag.None, Msg) : fx.Set()
            are1.WaitOne(bt) : Hr = 耳___.Read(Sl * 3, GetType(Short), LockFlag.None, Msg) : fx.Set()
            are2.WaitOne(bt) : Hr = 耳___.Read(Sl * 0, GetType(Short), LockFlag.None, Msg) : fx.Set()
            are3.WaitOne(bt) : Hr = 耳___.Read(Sl * 1, GetType(Short), LockFlag.None, Msg) : fx.Set() : Loop : 显示("eded,") : ae += 1
    End Sub
    Public psl, psr As Point, cus As Integer
    Private Sub 分析波形()
        Do While Run
            fx.WaitOne() : Hrm.Data = Hr : WarpAffine(Hrm, Hrml, mtxl, Hrml.Size) : WarpAffine(Hrm, Hrmr, mtxr, Hrmr.Size)
            Hrml.AbsDiff(cvo).MinMax(minvl, maxvl, minpl, maxpl) : Hrmdl = Hrml.Convert(Of Gray, Single)() : Dft(Hrmdl, HrDFTml, CV.CvEnum.DxtType.Forward, 0)
            Hrmr.AbsDiff(cvo).MinMax(minvr, maxvr, minpr, maxpr) : Hrmdr = Hrmr.Convert(Of Gray, Single)() : Dft(Hrmdr, HrDFTmr, CV.CvEnum.DxtType.Forward, 0)
            mtx01 = Nmt(0, 0, 0, 0, 0, 1, (q(115) + 26) / 100)
            WarpAffine(HrDFTml.AbsDiff(cvo) * 2, ypl, mtx01, ypl.Size) : WarpAffine(HrDFTmr.AbsDiff(cvo) * 2, ypr, mtx01, ypr.Size)
            fwdl = maxvl(0) / 160 : psl = New Point(300, -fwdl + bxtsz.Height) : fwdr = maxvr(0) / 160 : psr = New Point(300, -fwdr + bxtsz.Height)
            ypl = (ypl - q(117)) / 5000 / (q(114)) : ypr = (ypr - q(117)) / 5000 / (q(114)) ': cus = cus + 1 : drypR()
            drypR() : cus = IIf(cus < yptl.Width - 7, cus + 1, 0)
        Loop : ae += 1
    End Sub
    Private Sub drypR()
        Dim yplh, yprh As Integer : yplh = ypl.Height - 1 : yprh = ypr.Height - 1 : ypl0 = ypl.Convert(Of Gray, Byte)() : ypr0 = ypr.Convert(Of Gray, Byte)()
        ypl1 = ypl0 : ypl2 = ypl0 * 0.6 : ypl3 = ypl0 * 0.6 : ypr1 = ypr0 : ypr2 = ypr0 * 0.6 : ypr3 = ypr0 * 0.6
        For i = 0 To yplh : Dim i1 As Integer = yplh - i : yptl.Data(i, cus, 0) = ypl1.Data(i1, 0, 0) : yptl.Data(i, cus, 1) = ypl2.Data(i1, 0, 0) : yptl.Data(i, cus, 2) = ypl3.Data(i1, 0, 0)
            yptr.Data(i, cus, 0) = ypr1.Data(i1, 0, 0) : yptr.Data(i, cus, 1) = ypr2.Data(i1, 0, 0) : yptr.Data(i, cus, 2) = ypr3.Data(i1, 0, 0) : Next
    End Sub
    Dim TnsDt(1, 2, 0) As Double
    Public Function Nmt(ByVal movx As Integer, ByVal movy As Integer, Optional ByVal alp As Double = 0, Optional ByVal ox As Integer = 0, Optional ByVal oy As Integer = 0, _
          Optional ByVal xc As Double = 1, Optional ByVal yc As Double = 1) As CV.Mat
        Dim 万能矩阵 As CV.Mat = New CV.Mat(2, 3, CV.CvEnum.DepthType.Cv64F, 1,
                                        Runtime.InteropServices.GCHandle.Alloc(TnsDt, Runtime.InteropServices.GCHandleType.Pinned).AddrOfPinnedObject(), 0)
        Dim snap As Double = Math.Sin(alp), csap As Double = Math.Cos(alp)
        TnsDt(0, 0, 0) = csap * xc : TnsDt(0, 1, 0) = -snap * yc : TnsDt(0, 2, 0) = ox - ox * xc * csap + oy * yc * snap + movx
        TnsDt(1, 0, 0) = snap * xc : TnsDt(1, 1, 0) = +csap * yc : TnsDt(1, 2, 0) = oy - ox * xc * snap - oy * yc * csap + movy
        Return 万能矩阵.Clone
    End Function
End Module