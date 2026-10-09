Imports System.Threading, System.IO, System.Math, Emgu.CV, Emgu.CV.Structure, Emgu.CV.CvInvoke, Microsoft.DirectX, Microsoft.DirectX.Direct3D, Emgu.CV.Util, System.Runtime.InteropServices.Marshal
Public Module 意
    Public Structure Vect3l : Dim α, β, γ As Double
        Public Shared Operator +(ByVal left As Vect3l, ByVal right As Vect3l) As Vect3l
            left.α += right.α : left.β += right.β : left.γ += right.γ : Return left
        End Operator
    End Structure
    Public Structure Vect3j : Dim θ, γ, r As Double
        Public Shared Operator +(ByVal left As Vect3j, ByVal right As Vect3j) As Vect3j
            left.θ += right.θ : left.γ += right.γ : left.r += right.r : Return left
        End Operator
    End Structure
    Public Structure Vect3x : Dim x, y, z As Double
        Public Shared Operator -(ByVal left As Vect3x, ByVal right As Vect3x) As Vect3x
            left.x -= right.x : left.y -= right.y : left.z -= right.z : Return left
        End Operator
        Public Shared Operator +(ByVal left As Vect3x, ByVal right As Vect3x) As Vect3x
            left.x += right.x : left.y += right.y : left.z += right.z : Return left
        End Operator
    End Structure
    Public Structure Soul : Dim O, F, T, M(), El, Er, HT(), D(), R(), K() As Vect3x, Ol, Fl, Tl, Ml(), Ell, Erl As Vect3l, Oj, Fj, Tj, Mj(), Elj, Erj, Dj(), Rj(), Kj() As Vect3j : End Structure
    Public Structure se : Dim 色(,) As CustomVertex.PositionNormalColored, 香() As Integer, 声(,,) As Short, 味 As Integer, 触() As Long : End Structure
    Public Structure fa : Dim BD, SL As Soul, 色 As se : End Structure
    Public dzs(1000, 32) As Integer, mc(1000) As String
    Public Const cm = 31.5, hfPI# = PI / 2, jd# = 1 / PI * 180, c# = 5.75 * cm, ecn% = 3, egd% = 80
    Public Dr(32), vy, pzr As Double, f0(81) As fa, dev As Vect3x, ewd% = 640, eht% = 480, ewd2% = 320, eht2% = 240, fm%, tm!, tms!, tex4$
    Public Run As Boolean = True, htrun As Boolean, xok, xed, d3dok, d3ded As Boolean, lrcs As Boolean = True, esz As Size = New Size(ewd, eht), 想 As Thread = New Thread(AddressOf 想_), slpw%
    Public tpmat As Mat = New Mat("tp.bmp", CvEnum.LoadImageType.Color), rtf, lrtf, rrtf, lrtgf, rrtgf As Rectangle, fil As New Mat(1, 1, CvEnum.DepthType.Cv8U, 3), fir As New Mat(1, 1, CvEnum.DepthType.Cv8U, 3),
           wd% = 100, ht% = 62, wdsz As Size = New Size(wd, ht), hfwdsz As Size = New Size(wd / 2, ht / 2), fdsz As Size = New Size(ewd, eht),
           ttn% = 0, minplf(10), minprf(10), maxplf(10), maxprf(10), plf(10), prf(10), plf0, prf0 As Point, maxllf(10), maxlrf(10), minllf(10), minlrf(10) As Double, 实时信息$, 上个信息$, 消息数%
    Dim tmsS, tmsB, tmsE As Mesh, li As Short, ll(63) As CustomVertex.PositionNormalColored, rtgll(5), rtglr(5) As CustomVertex.PositionNormalTextured,
        Vmss(2000), Vmss1(2000), Vmss2(2000), Vmss3(2000), Vmss4(2000), Vmss5(2000), Vmss6(2000), Vmss7(2000), Vmss8(2000) As CustomVertex.PositionColored,
        dts(,,), dts1(,,), dts2(,,), dts3(,,), dts4(,,), dts5(,,), dts6(,,), dts7(,,) As Single, dtst(,,) As Short,
           Kjo() As Vect3j, θ, γ, d As Double, rrtmat As New Mat, lrtmat As New Mat, fMatl As New Mat, fMatr As New Mat, matln As New Mat, matrn As New Mat, wtmat As Mat = New Mat(esz, CvEnum.LoadImageType.Color, 1)
    Public pn6 As IntPtr, 调试窗口2 As Thread = New Thread(AddressOf 调试窗口2_), tscked As Boolean, D3dv As Direct3D.Device
    Public sddj, eydj As Boolean, ar, ail, air, ail1, air1, ail3, air3, ail4, air4, art As New AutoResetEvent(False), sts, ae As Integer
    Public Sub 初始观察点()
        ReDim f0(81) : f0(0).BD = Nothing : d = 64 : Dim o As Double = 0.001
        With f0(0).BD : ReDim .HT(4), .D(d), .R(d), .K(d), .Dj(d), .Rj(d), .Kj(d), Kjo(d), .M(3), .Mj(3), .Ml(3) : .F = nv(, , 10000 * cm) : .Fl = x2l(.F) : .T = .F : .Tl = x2l(.T) : End With : f0(0).SL = f0(0).BD : dev = nv(ewd, eht, 33.82 * cm)
        With f0(0).SL : .O = nv(50 * cm, -13 * cm, -95 * cm) : .HT(1) = nv(-4.5 * cm, -5 * cm) : .HT(2) = nv(4.5 * cm, -5 * cm) : .HT(3) = nv(, , -4.5 * cm) : .HT(4) = nv(, 1 * cm) : End With
        With f0(0).BD
            .K(1) = nv(, , -4.5 * cm) : .K(2) = nv(, 4 * cm) : .K(3) = nv(, , 2 * cm) : .K(4) = nv(, , (2 - o) * cm) : .K(16) = nv(, 2 * cm, o) : .K(5) = nv(5.5 * cm) : .K(17) = nv(, , -1.5 * cm) : .K(6) = nv(, , 4 * cm)
            .K(7) = nv(-5.5 * cm) : .K(18) = nv(, , -1.5 * cm) : .K(8) = nv(, , 4 * cm) : .K(9) = nv(, -6.66 * cm) : .K(10) = nv(-3.5 * cm, -4.5 * cm, -4 * cm) : .K(11) = nv(, -8 * cm) : .K(12) = nv(, -3.5 * cm)
            .K(13) = nv(3.5 * cm, -4.5 * cm, -4 * cm) : .K(14) = nv(, -8 * cm) : .K(15) = nv(, -3.5 * cm) : .K(19) = nv(, , -1.5 * cm)
            .K(20) = nv(, , 43.2 * cm) : .K(45) = nv(-ewd2) : .K(46) = nv(ewd2)
            .K(41) = nv(, eht2, o * cm) : .K(42) = nv(, -eht2, o * cm) : .K(43) = nv(, eht2, o * cm) : .K(44) = nv(, -eht2, o * cm)
            .K(24) = nv(, , 43.2 * cm) : .K(55) = nv(-ewd2) : .K(56) = nv(ewd2)
            .K(51) = nv(, eht2, o * cm) : .K(52) = nv(, -eht2, o * cm) : .K(53) = nv(, eht2, o * cm) : .K(54) = nv(, -eht2, o * cm)
            .K(26) = nv(, , 100000 * cm) : .K(28) = nv(, , 100000 * cm) : x2jA() : Kjo = .Kj.Clone
        End With
    End Sub
    Private Sub 想_()
        初始观察点() : Clrmm() : vy = 640 / dev.z : plf0.X = ewd2 : plf0.Y = eht2 : prf0.X = ewd2 : prf0.Y = eht2 : slpw = 20
        显示("xok,") : ar.Set() : Do While Run : With f0(0).BD
                θ = .Fj.θ - 90 : .Kj(3).θ = Kjo(3).θ + θ : .Kj(4).θ = Kjo(4).θ + θ : .Kj(5).θ = Kjo(5).θ + θ : .Kj(7).θ = Kjo(7).θ + θ : .Kj(19).θ = Kjo(19).θ + θ
                .Kj(8).θ = Kjo(8).θ + θ - .Tl.α + 90 : .Kj(6).θ = Kjo(6).θ + θ - .Tl.β + 90
                Dim α As Double = θ - .Tl.α + 90 : .Kj(20).θ = Kjo(20).θ + α : .Kj(45).θ = Kjo(45).θ + α : .Kj(46).θ = Kjo(46).θ + α : .Kj(41).θ = Kjo(41).θ + α : .Kj(42).θ = Kjo(42).θ + α : .Kj(43).θ = Kjo(43).θ + α : .Kj(44).θ = Kjo(44).θ + α
                Dim β As Double = θ - .Tl.β + 90 : .Kj(24).θ = Kjo(24).θ + β : .Kj(55).θ = Kjo(55).θ + β : .Kj(56).θ = Kjo(56).θ + β : .Kj(51).θ = Kjo(51).θ + β : .Kj(52).θ = Kjo(52).θ + β : .Kj(53).θ = Kjo(53).θ + β : .Kj(54).θ = Kjo(54).θ + β
                .Kj(26).θ = Kjo(26).θ + θ - .Tl.α + 90 : .Kj(28).θ = Kjo(28).θ + θ - .Tl.β + 90
                .Kj(16).θ = Kjo(16).θ + θ : .Kj(17).θ = Kjo(17).θ + θ : .Kj(18).θ = Kjo(18).θ + θ
                γ = .Tj.γ + .Fj.γ : .Kj(4).γ = Kjo(4).γ + γ : .Kj(16).γ = Kjo(16).γ + γ
                .Kj(6).γ = Kjo(6).γ + γ : .Kj(8).γ = Kjo(8).γ + γ
                .Kj(20).γ = Kjo(20).γ + γ : .Kj(45).γ = Kjo(45).γ + γ : .Kj(46).γ = Kjo(46).γ + γ : .Kj(41).γ = Kjo(41).γ + γ : .Kj(42).γ = Kjo(42).γ + γ : .Kj(43).γ = Kjo(43).γ + γ : .Kj(44).γ = Kjo(44).γ + γ
                .Kj(24).γ = Kjo(24).γ + γ : .Kj(55).γ = Kjo(55).γ + γ : .Kj(56).γ = Kjo(56).γ + γ : .Kj(51).γ = Kjo(51).γ + γ : .Kj(52).γ = Kjo(52).γ + γ : .Kj(53).γ = Kjo(53).γ + γ : .Kj(54).γ = Kjo(54).γ + γ
                .Kj(26).γ = Kjo(26).γ + γ : .Kj(28).γ = Kjo(28).γ + γ
                .Kj(17).γ = Kjo(17).γ - γ : .Kj(18).γ = Kjo(18).γ - γ : .Kj(19).γ = Kjo(19).γ - γ
                j2xA() : x2lA() : Dr(1) = .Tl.α - 90 : Dr(32) = .Tl.β - 90 : Dr(2) = .Fl.γ - 90 : Dr(31) = .Fj.θ - 90
            End With : If sddj Then : 显示("s!") : End If : DrBD() : Drtg() : nla() : x2jA() : Thread.Sleep(slpw) : sts = sts + 1 : If sts > 100 Then : showtxt() : sts = 0 : End If : Loop : 显示("xed,") : ae += 1                                                                                                                                                         ' If eydj Then : 显示("e!") : If Agld > Agrd Then : fd(maxlpl(0), 1, 120) : mv2() : Else : fd(maxlpr(0), 0, 120) : mv2() : End If : End If
    End Sub
    Private Sub Drtg()
        With f0(0).BD
            rtgll(0).Position = ct(.R(41)) : rtgll(1).Position = ct(.R(43)) : rtgll(2).Position = ct(.R(42)) : rtgll(3).Position = ct(.R(42)) : rtgll(4).Position = ct(.R(43)) : rtgll(5).Position = ct(.R(44))
            rtgll(0).Normal = ct(nv(, , -1)) : rtgll(1).Normal = ct(nv(, , -1)) : rtgll(2).Normal = ct(nv(, , -1)) : rtgll(3).Normal = ct(nv(, , -1)) : rtgll(4).Normal = ct(nv(, , -1)) : rtgll(5).Normal = ct(nv(, , -1))
            rtgll(0).Tu = 0 : rtgll(0).Tv = 0 : rtgll(1).Tu = 1 : rtgll(1).Tv = 0 : rtgll(2).Tu = 0 : rtgll(2).Tv = 1 : rtgll(3).Tu = 0 : rtgll(3).Tv = 1 : rtgll(4).Tu = 1 : rtgll(4).Tv = 0 : rtgll(5).Tu = 1 : rtgll(5).Tv = 1
            rtglr(0).Position = ct(.R(51)) : rtglr(1).Position = ct(.R(53)) : rtglr(2).Position = ct(.R(52)) : rtglr(3).Position = ct(.R(52)) : rtglr(4).Position = ct(.R(53)) : rtglr(5).Position = ct(.R(54))
            rtglr(0).Normal = ct(nv(, , -1)) : rtglr(1).Normal = ct(nv(, , -1)) : rtglr(2).Normal = ct(nv(, , -1)) : rtglr(3).Normal = ct(nv(, , -1)) : rtglr(4).Normal = ct(nv(, , -1)) : rtglr(5).Normal = ct(nv(, , -1))
            rtglr(0).Tu = 0 : rtglr(0).Tv = 0 : rtglr(1).Tu = 1 : rtglr(1).Tv = 0 : rtglr(2).Tu = 0 : rtglr(2).Tv = 1 : rtglr(3).Tu = 0 : rtglr(3).Tv = 1 : rtglr(4).Tu = 1 : rtglr(4).Tv = 0 : rtglr(5).Tu = 1 : rtglr(5).Tv = 1
        End With
    End Sub

    Private Sub DrBD()
        With f0(0).BD : .D(31) = .R(0) + .K(1) : .R(2) = .D(31) + .K(2) : .D(2) = .R(2) + .K(3) : .R(16) = .D(2) + .K(4) : .R(32) = .R(16) + .K(16) : .R(17) = .R(32) + .K(5)
            .D(32) = .R(17) + .K(17) : .Er = .D(32) + .K(6) : .R(18) = .R(32) + .K(7) : .D(1) = .R(18) + .K(18) : .El = .D(1) + .K(8) : .R(11) = .R(0) + .K(9) : .D(11) = .R(11) + .K(10)
            .D(12) = .D(11) + .K(11) : .R(12) = .D(12) + .K(12) : .D(22) = .R(11) + .K(13) : .D(21) = .D(22) + .K(14) : .R(21) = .D(21) + .K(15) : .R(19) = .R(32) + .K(19)
            .R(20) = .El + .K(20) : .R(45) = .R(20) + .K(45) : .R(46) = .R(20) + .K(46) : .R(41) = .R(45) + .K(41) : .R(42) = .R(45) + .K(42) : .R(43) = .R(46) + .K(43) : .R(44) = .R(46) + .K(44)
            .R(24) = .Er + .K(24) : .R(55) = .R(24) + .K(55) : .R(56) = .R(24) + .K(56) : .R(51) = .R(55) + .K(51) : .R(52) = .R(55) + .K(52) : .R(53) = .R(56) + .K(53) : .R(54) = .R(56) + .K(54)
            .R(26) = .El + .K(26) : .R(28) = .Er + .K(28)
            : nla() : End With
    End Sub
    Private Sub x2jA()
        With f0(0).BD : .Oj = x2j(.O) : .Fj = x2j(.F) : .Tj = x2j(.T) : .Elj = x2j(.El) : .Erj = x2j(.Er) : For i = 0 To 3 : .Mj(i) = x2j(.M(i)) : Next
            For i = 1 To d : .Kj(i) = x2j(.K(i)) : .Dj(i) = x2j(.D(i)) : .Rj(i) = x2j(.R(i)) : Next : End With
    End Sub
    Private Sub j2xA()
        With f0(0).BD : .O = x2j(.Oj) : .F = x2j(.Fj) : .T = x2j(.Tj) : .El = x2j(.Elj) : .Er = x2j(.Erj) : For i = 0 To 3 : .M(i) = x2j(.Mj(i)) : Next
            For i = 1 To d : .K(i) = x2j(.Kj(i)) : .D(i) = x2j(.Dj(i)) : .R(i) = x2j(.Rj(i)) : Next : End With
    End Sub
    Private Sub x2lA()
        With f0(0).BD : .Ol = x2l(.O) : .Fl = x2l(.F) : .Tl = x2l(.T) : .Ell = x2l(.El) : .Erl = x2l(.Er) : For i = 0 To 3 : .Ml(i) = x2l(.M(i)) : Next : End With
    End Sub
    Private Sub l2xA()
        With f0(0).BD : .O = x2l(.Ol) : .F = x2l(.Fl) : .T = x2l(.Tl) : .El = x2l(.Ell) : .Er = x2l(.Erl) : For i = 0 To 3 : .M(i) = x2l(.Ml(i)) : Next : End With
    End Sub
    Private Sub nla()
        li = 0 : With f0(0).BD : nl(.HT(0), .HT(1)) : nl(.HT(0), .HT(2)) : nl(.HT(0), .HT(3)) : nl(.HT(1), .HT(2)) : nl(.HT(2), .HT(3)) : nl(.HT(3), .HT(1))
            nl(.R(21), .D(21)) : nl(.D(21), .D(22)) : nl(.D(22), .R(11)) : nl(.R(12), .D(12)) : nl(.D(12), .D(11)) : nl(.D(11), .R(11)) : nl(.R(11), .R(0)) : nl(.R(32), .R(18)) : nl(.R(18), .D(1))
            nl(.R(32), .R(17)) : nl(.R(17), .D(32)) : nl(.D(2), .R(16)) : nl(.R(16), .R(32)) : nl(.D(2), .R(2)) : nl(.R(2), .D(31)) : nl(.D(31), .R(0))
            nl(.D(1), .El) : nl(.D(32), .Er) : nl(.El, .R(26)) : nl(.Er, .R(28)) : End With
    End Sub
    Public Sub fd(ByVal poi As Point, ByVal l As Integer, ByVal d As Integer)
        Dim dpo = New Size(d / 2, d / 2) : poi = inmm(poi, dpo, esz - dpo) : rtf = New Rectangle(poi - dpo, dpo + dpo)
        ail3.WaitOne() : air3.WaitOne()
        If l Then
            tpmat = New Mat(ibxl, rtf) : MatchTemplate(ibxr, tpmat, wtmat, CvEnum.TemplateMatchingType.CcoeffNormed) : wtmat.MinMax(minlrf, maxlrf, minprf, maxprf)
            prf0 = inmm(maxprf(0), dpo, esz - dpo) + dpo : rrtf = New Rectangle(prf0 - dpo, dpo + dpo) : lrtf = rtf : plf0 = poi
            fMatl = tpmat.Clone : fMatr = New Mat(ibxr, rrtf) : fil = fMatl : fir = fMatr
        Else
            tpmat = New Mat(ibxr, rtf) : MatchTemplate(ibxl, tpmat, wtmat, CvEnum.TemplateMatchingType.CcoeffNormed) : wtmat.MinMax(minllf, maxllf, minplf, maxplf)
            plf0 = inmm(maxplf(0), dpo, esz - dpo) + dpo : lrtf = New Rectangle(plf0 - dpo, dpo + dpo) : rrtf = rtf : prf0 = poi
            fMatr = tpmat.Clone : fMatl = New Mat(ibxl, lrtf) : fil = fMatl : fir = fMatr
        End If
    End Sub
    Private Sub showtxt()
        With f0(0).BD : Dim k As Vect3j = .Rj(32), m As Vect3x = .K(16), l As Vect3j = .Kj(16)
            tex4 = "BD.F :" & fmt(.F.x / cm) & "," & fmt(.F.y / cm) & "," & fmt(.F.z / cm) & ":" & "BD.fj:" & fmt(.Fj.θ) & "," & fmt(.Fj.γ) & "," & fmt(.Fj.r / cm) & Et &
                       "BD.fl: " & fmt(.Fl.α) & "," & fmt(.Fl.β) & "," & fmt(.Fl.γ) & ":" & "BD.T :" & fmt(.T.x / cm) & "," & fmt(.T.y / cm) & "," & fmt(.T.z / cm) & Et &
                       "BD.Tj:" & fmt(.Tj.θ) & "," & fmt(.Tj.γ) & "," & fmt(.Tj.r / cm) & ":" & "BD.Tl:" & fmt(.Tl.α) & "," & fmt(.Tl.β) & "," & fmt(.Tl.γ) & Et &
                               fmt(k.θ) & "," & fmt(k.γ) & "," & fmt(k.r) & Et &
                               fmt(m.x) & "," & fmt(m.y) & "," & fmt(m.z) & Et &
                               fmt(l.θ) & "," & fmt(l.γ) & "," & fmt(l.r) & Et
        End With
    End Sub
    Private Sub 调试窗口2_()
        Dim pp As New PresentParameters With {.AutoDepthStencilFormat = DepthFormat.D24S8, .EnableAutoDepthStencil = True, .SwapEffect = SwapEffect.Discard, .DeviceWindowHandle = pn6, .Windowed = True}
        D3dv = New Device(0, DeviceType.Hardware, pn6, CreateFlags.HardwareVertexProcessing, pp)
        With D3dv : .RenderState.CullMode = Cull.CounterClockwise : .Transform.Projection = Matrix.PerspectiveFovLH(vy, 1658 / 678, 0, 1000000 * cm) : .RenderState.ZBufferEnable = True
            tmsS = Mesh.Sphere(D3dv, 0.3 * cm, 10, 10) : tmsB = Mesh.Box(D3dv, 0.5 * cm, 0.5 * cm, 0.5 * cm)
            Stlt(0, Color.White) : Stlt(1, Color.Red) : Stlt(2, Color.White) : Stlt(3, Color.Gold) : Stlt(4, Color.DarkRed) : Stlt(5, Color.Gray) : Stlt(6, Color.DarkGoldenrod) : Stlt(7, Color.DarkBlue)
            For i = 0 To 1199 : Vmss(i).Color = &HFF00 : Vmss(i).X = i * 15 - 20000 : Vmss(i).Z = 30000 : Vmss1(i).Color = &HFF0000 : Vmss1(i).X = i * 15 - 20000 : Vmss1(i).Z = 30000
                Vmss2(i).Color = &HFF00 : Vmss2(i).X = i * 15 + 2000 : Vmss2(i).Z = 30000 : Vmss3(i).Color = &HFF0000 : Vmss3(i).X = i * 15 + 2000 : Vmss3(i).Z = 30000 : Next
            For i = 0 To bffi0.Height - 1 : Vmss4(i).Color = &HFF : Vmss4(i).X = i * 15 + 12000 : Vmss4(i).Z = 70000 : Vmss5(i).Color = &HFF00 : Vmss5(i).X = i * 15 + 12000 : Vmss5(i).Z = 70000
                Vmss6(i).Color = &HFF0000 : Vmss6(i).X = i * 15 + 12000 : Vmss6(i).Z = 70000 : Vmss7(i).Color = &HFF : Vmss7(i).X = i * 15 + 12000 : Vmss7(i).Z = 70000
                Vmss8(i).Color = &HFFFF00 : Vmss8(i).X = i * 15 + 12000 : Vmss8(i).Z = 70000 : Next
            显示("tsck2ok,") : ar.Set() : Do While Run : .Transform.View = Matrix.LookAtLH(ct(f0(0).SL.O), ct(f0(0).SL.F), ct(f0(0).SL.HT(4))) : .Clear(ClearFlags.Target Or ClearFlags.ZBuffer, &H10101, 1, 0)
                .RenderState.Lighting = True : .Material = New Material With {.Ambient = Color.White} : .BeginScene()
                .VertexFormat = CustomVertex.PositionNormalColored.Format : DwSs1(2, ct(f0(0).BD.F)) : DwSs1(3, ct(f0(0).BD.T)) : DwSs(0, ct(f0(0).BD.M(0))) '  : DwSs(1, ct(f0(0).BD.El)) : DwSs(1, ct(f0(0).BD.Er)) : For i = 0 To 4 : DwSs(1, ct(f0(0).BD.HT(i))) : Next : For i = 1 To d : DwSs1(7, ct(f0(0).BD.D(i))) : DwSs(3, ct(f0(0).BD.R(i))) : Next
                .RenderState.Lighting = False : .VertexFormat = CustomVertex.PositionNormalTextured.Format
                .SetTexture(0, txtrl) : .DrawUserPrimitives(PrimitiveType.TriangleList, 2, rtgll) : .SetTexture(0, txtrr) : .DrawUserPrimitives(PrimitiveType.TriangleList, 2, rtglr) : .SetTexture(0, Nothing)
                .VertexFormat = CustomVertex.PositionColored.Format : .RenderState.Lighting = False : .DrawUserPrimitives(PrimitiveType.LineList, ll.Length / 2, ll)
                .SetTransform(TransformType.World, Matrix.Translation(ct(f0(0).SL.O)))
                dts = HrDFTml.Data : dts1 = HrDFTmr.Data : dts2 = Hrmdl.Data : dts3 = Hrmdr.Data : dts4 = bffi0.Data : dtst = bffibs0.Data : dts5 = cbf0.Data : dts6 = bffsdft0.Data : dts7 = bffsdftb0.Data
                For i = 0 To 1199 : Vmss(i).Y = dts(i, 0, 0) / 218 - 7500 : Vmss1(i).Y = dts1(i, 0, 0) / 218 - 5500 : Vmss2(i).Y = dts2(i, 0, 0) / 2 - 7500 : Vmss3(i).Y = dts3(i, 0, 0) / 2 - 5500 : Next
                For i = 0 To bffi0.Height - 1 : Vmss4(i).Y = dts4(i, 0, 0) + 6500 : Vmss4(i).Z = 70000 : Vmss5(i).Y = dtst(i, 0, 0) + 8500 : Vmss6(i).Y = dts5(i, 0, 0) * -15 + 10500 : Vmss7(i).Y = dts6(i, 0, 0) / 280 + 12500 : Vmss8(i).Y = dts7(i, 0, 0) / 280 + 14500 : Next
                .DrawUserPrimitives(PrimitiveType.LineStrip, 1199, Vmss) : .DrawUserPrimitives(PrimitiveType.LineStrip, 1199, Vmss1) : .DrawUserPrimitives(PrimitiveType.LineStrip, 1199, Vmss2) : .DrawUserPrimitives(PrimitiveType.LineStrip, 1199, Vmss3)
                .DrawUserPrimitives(PrimitiveType.LineStrip, bffi0.Height - 1, Vmss4) : .DrawUserPrimitives(PrimitiveType.LineStrip, bffibs0.Height - 1, Vmss5) : .DrawUserPrimitives(PrimitiveType.LineStrip, cbf0.Height - 1, Vmss6)
                .DrawUserPrimitives(PrimitiveType.LineStrip, bffsdft0.Height - 1, Vmss7) : .DrawUserPrimitives(PrimitiveType.LineStrip, bffsdftb0.Height - 1, Vmss8)
                .EndScene() : .Present() : Loop : End With : 显示("tsck2ed,") : ae += 1
    End Sub
    Public Sub pause()
    End Sub

    Private Sub nl(ByVal a As Vect3x, ByVal b As Vect3x)
        ll(li).Color = &H884433 : ll(li).Nx = 1 : ll(li).Ny = -1 : ll(li).Nz = 1 : ll(li).Position = ct(a) : li += 1 : ll(li).Position = ct(b) : li += 1
    End Sub
    Private Sub DwSs(ByVal ltn As Integer, ByVal pos As Vector3)
        With D3dv : .Lights(ltn).Enabled = 1 : .SetTransform(TransformType.World, Matrix.Translation(pos)) : tmsS.DrawSubset(0) : .Lights(ltn).Enabled = 0 : End With
    End Sub
    Private Sub DwSs1(ByVal ltn As Integer, ByVal pos As Vector3)
        With D3dv : .Lights(ltn).Enabled = 1 : .SetTransform(TransformType.World, Matrix.Translation(pos)) : tmsB.DrawSubset(0) : .Lights(ltn).Enabled = 0 : End With
    End Sub
    Private Sub Stlt(ByVal ltn As Integer, ByVal cl As Color)
        With D3dv.Lights(ltn) : .Type = Direct3D.LightType.Directional : .Direction = New Vector3(-0.8, 2, 100) : .Ambient = cl : .Specular = cl : .Diffuse = cl : .Range = 1000000 * cm : .ZPosition = -10000 * cm : .Update() : End With
    End Sub
    Public Function nv(Optional ByVal x As Double = 0, Optional ByVal y As Double = 0, Optional ByVal z As Double = 0) As Vect3x
        nv.x = x : nv.y = y : nv.z = z : Return nv
    End Function
    Dim bk As Size = New Size(35, 35)
    Private Function x2j(ByVal posx_ As Vect3x) As Vect3j
        With posx_ : x2j.θ = Atan2(.z, .x) * jd : x2j.γ = Atan2(.y, Math.Sqrt(.x ^ 2 + .z ^ 2)) * jd : x2j.r = Math.Sqrt(.x ^ 2 + .y ^ 2 + .z ^ 2) : End With
    End Function
    Private Function x2j(ByVal posj_ As Vect3j) As Vect3x
        With posj_ : x2j.y = .r * Sin(.γ / jd) : x2j.x = Cos(.θ / jd) * Cos(.γ / jd) * .r : x2j.z = Sin(.θ / jd) * Cos(.γ / jd) * .r : End With
    End Function
    Private Function x2l(ByVal posx_ As Vect3x) As Vect3l
        With posx_ : x2l.α = (PI - Atan2(.z, .x + c)) * jd : x2l.β = (PI - Atan2(.z, .x - c)) * jd : x2l.γ = Atan2(.z, .y) * jd : End With
    End Function
    Private Function x2l(ByVal posl_ As Vect3l) As Vect3x
        Dim s, m, γ_ As Double : m = Tan((180 - posl_.α) / jd + hfPI) : γ_ = 90 - posl_.γ : s = 2 * c / (-m - Tan(posl_.β / jd + hfPI))
        x2l.x = -s * m - c : x2l.y = Sin(γ_ / jd) * s : x2l.z = Cos(γ_ / jd) * s : Return x2l
    End Function
    Public Sub ReDo()
        If ttn > 1 Then f0(0).色.色(ttn, 0) = Nothing : f0(0).色.色(ttn, 1) = Nothing : f0(0).色.色(ttn, 2) = Nothing : ttn -= 1
    End Sub
    Public Sub Clrmm()
        ReDim f0(0).色.色(333, 3) : ttn = 1
    End Sub
    Private Function Nrt(ByVal o As Point, ByVal sz As Size) As Rectangle
        Return New Rectangle(inmm(o.X - sz.Width / 2, 0, ewd - sz.Width), inmm(o.Y - sz.Height / 2, 0, eht - sz.Height), sz.Width - 1, sz.Height - 1)
    End Function
    Public Sub 显示(ByVal 信息 As String)
        实时信息 = 信息 & 实时信息 : If 实时信息 = 上个信息 Then : Else : 上个信息 = 信息 : End If
        实时信息 = Microsoft.VisualBasic.Left(实时信息, 256) : art.Set()
    End Sub
    Public Sub 读取动作()
        RdMM("dm.xx", dm) : RdMM("ds.xx", Dp) : RdMM("dzs.xx", dzs)
    End Sub
    Public Sub 写入动作()
        WtMM("ds.xx", Dp) : WtMM("dzs.xx", dzs) : WtMM("mc.xx", mc)   '  WtMM("dm.xx", dm) '
    End Sub
    Private Sub RdMM(ByVal fn, ByRef Dt)
        Dim nF As Integer = FreeFile() : FileOpen(nF, fn, OpenMode.Binary) : FileGetObject(nF, Dt) : FileClose(nF)
    End Sub
    Private Sub WtMM(ByVal fn, ByVal dt)
        Dim nF As Integer = FreeFile() : FileOpen(nF, fn, OpenMode.Binary) : FilePutObject(nF, dt) : FileClose(nF)
    End Sub
End Module