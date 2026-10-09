Imports System.Threading, System.Drawing.Imaging, Emgu.CV, Emgu.CV.Structure, System.Math, Emgu.CV.CvInvoke, Microsoft.DirectX, Microsoft.DirectX.DirectSound, System.Windows.Forms.Application
Public Class XX系统
    Dim 字符显示器 As Thread = New Thread(AddressOf 字符显示器_), 字符显示器2 As Thread = New Thread(AddressOf 字符显示器2_), 左字符显示 As Thread = New Thread(AddressOf 左字符显示_),
        右字符显示 As Thread = New Thread(AddressOf 右字符显示_), 键盘 As Thread = New Thread(AddressOf 键盘_), 调试窗口l As Thread = New Thread(AddressOf 调试窗口l_), 调试窗口r As Thread = New Thread(AddressOf 调试窗口r_),
        Start0 As Thread = New Thread(AddressOf start0_)
    Dim cvm As Single = 5 * cm, ImageBox1_Image As Image(Of Bgr, Short), s%
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0 : Me.Left = 0 : yptlsz = yptl___.Size : yptrsz = yptr___.Size : cbf = New Image(Of Gray, Single)(1, 2000)
        Me.WindowState = FormWindowState.Normal : pn6 = Panel4.Handle : me1 = Me.Handle : Start0.Start()
        ImageBox1_Image = New Image(Of Bgr, Short)(New Size(ImageBox1.Width, ImageBox1.Height))
    End Sub
    Private Sub start0_()
        显示("开始构建环境..." & Et)
        念.Start() : ar.WaitOne() : 字符显示器.Start() : 字符显示器2.Start() : 左字符显示.Start() : 右字符显示.Start() : 键盘.Start() : ar.WaitOne() : 耳_.Start() : ar.WaitOne() : 想.Start() : ar.WaitOne() : 调试窗口l.Start() : ar.WaitOne() : 调试窗口r.Start() : ar.WaitOne()
        调试窗口2.Start() : ar.WaitOne() : 行.Start() : ar.WaitOne() : 触_.Start() : ar.WaitOne() : Dr(2) = 20 : 动作组.Start() : 口.Start() : ar.WaitOne() : 眼l_.Start() : ar.WaitOne() : 眼r_.Start() : ar.WaitOne() : 显示("启动完成!" & Et)
    End Sub
    Private Sub 调试窗口l_()
        显示("tsckok,") : ar.Set() : Do While Run : ail1.WaitOne(200)
            If Not esmd Then
                Circle(ibxl2, New Point(ewd2, eht2), 3, cvG, 1) : Circle(ibxl2, maxlpl(0), 3, cvR, 2) : Circle(ibxl2, maxlpl(1), 2, cvR, 1)
                Circle(ibxl2, maxlpl(2), 1, cvR, 1) : Rectangle(ibxl2, lrtgf, cvB) : Rectangle(ibxl2, lrtf, cvG) : Circle(ibxl2, plf0, 5, cvB, 1)
                PutText(ibxl2, fmt(lfps), New Point(10, 20), CvEnum.FontFace.HersheyDuplex, 0.5, cvG) : imgboxl.Image = ibxl2.Bitmap
                ail4.Set() : fMatl_.Image = fil.Bitmap : yptl___.Image = yptl.Bitmap
            Else : PutText(ibxl2, lfps, New Point(10, 20), CvEnum.FontFace.HersheyComplex, 0.5, cvG) : imgboxl.Image = ibxr2.Bitmap : ail4.Set() : End If  ' 20cpu
        Loop : 显示("tscked,") : ae += 1
    End Sub
    Private Sub 调试窗口r_()
        显示("tsckok,") : ar.Set() : Do While Run : air1.WaitOne(200)
            If Not esmd Then
                Circle(ibxr2, New Point(ewd2, eht2), 3, cvG, 1) : Circle(ibxr2, maxlpr(0), 3, cvR, 2) : Circle(ibxr2, maxlpr(1), 2, cvR, 1)
                Circle(ibxr2, maxlpr(2), 1, cvR, 1) : Rectangle(ibxr2, rrtgf, cvB) : Rectangle(ibxr2, rrtf, cvG) : Circle(ibxr2, prf0, 5, cvB, 1)
                PutText(ibxr2, fmt(rfps), New Point(10, 20), CvEnum.FontFace.HersheyDuplex, 0.5, cvG) : imgboxr.Image = ibxr2.Bitmap
                air4.Set() : fMatr_.Image = fir.Bitmap : yptr___.Image = yptr.Bitmap
            Else : PutText(ibxr2, rfps, New Point(10, 20), CvEnum.FontFace.HersheyComplex, 0.5, cvG) : imgboxr.Image = ibxl2.Bitmap : air4.Set() : End If  ' 20cpu
        Loop : 显示("tscked,") : ae += 1
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click   '=================================
        Run = False : DoEvents() : 显示("关闭系统...") : Do Until ae >= 16 : Thread.Sleep(3) : DoEvents() : Loop : Me.Dispose(1)
    End Sub
    Public Sub 字符显示器_()
        Dim gb As New Bitmap(pbx2.Width, pbx2.Height), g As Graphics = Graphics.FromImage(gb), mBrush As New SolidBrush(Color.White), mFont As New Font("宋体", 10)
        Do While Run : g.Clear(Nothing) : g.DrawString(实时信息, mFont, mBrush, 3, 3) : Thread.Sleep(50) : pbx2.Image = gb : Thread.Sleep(50) : art.WaitOne(2000) : Loop : ae += 1
    End Sub
    Private Sub 字符显示器2_()
        Dim gb As New Bitmap(Pbx6.Width, Pbx6.Height), g As Graphics = Graphics.FromImage(gb), mBrush As New SolidBrush(Color.White), mFont As New Font("宋体", 10)
        Do While Run : g.Clear(Nothing) : g.DrawString(tex4, mFont, mBrush, 3, 3) : Thread.Sleep(50) : Pbx6.Image = gb : Thread.Sleep(50) : art.WaitOne(2000) : Loop : ae += 1
    End Sub
    Public Sub 左字符显示_()
        Dim gb As New Bitmap(Panel4.Width, Panel4.Height), g As Graphics = Graphics.FromImage(gb), mBrush As New SolidBrush(Color.White), mFont As New Font("宋体", 10)
        Do While Run : g.Clear(Nothing) : g.DrawString("apl:" & Int(Dr(1)).ToString & ",apr:" & Int(Dr(32)).ToString & ",bt:" & Int(Dr(2)).ToString & ",gm:" & Int(Dr(31)).ToString & ",x:" &
            Int(f0(0).BD.F.x / cm).ToString & ",y:" & Int(f0(0).BD.F.y / cm).ToString & ",z:" & Int(f0(0).BD.F.z / cm).ToString & ",fps:" & fmt(tms).ToString & ",maxvl:" &
            maxllf(0).ToString, mFont, mBrush, 3, 3) : pbx4.Image = gb : Thread.Sleep(300) : Loop : ae += 1
    End Sub
    Public Sub 右字符显示_()
        Dim gb As New Bitmap(Pbx5.Width, Pbx5.Height), g As Graphics = Graphics.FromImage(gb), mBrush As New SolidBrush(Color.White), mFont As New Font("宋体", 10)
        Do While Run : g.Clear(Nothing) : g.DrawString(fmt(fwdl - fwdr) & ",fst:" & fst.ToString, mFont, mBrush, 3, 3) : Pbx5.Image = gb : Thread.Sleep(300) : Loop : ae += 1
    End Sub
    Dim kap, krp, kwp, kdp, kfp, ksp As Boolean, KS As Integer
    Private Sub 键盘_()
        Dim KC As Vect3x : 显示("jok,") : ar.Set() : Do While Run : Thread.Sleep(50) : KC.x = cvm * (-kap + kdp) : KC.y = cvm * (-krp + kfp) : KC.z = cvm * -(-kwp + ksp)
            Select Case KS : Case 97 : f0(0).BD.O -= KC : Case 98 : f0(0).BD.F -= KC : Case 99 : f0(0).BD.T -= KC : Case 100 : f0(0).SL.O -= KC : Case 101 : f0(0).SL.F -= KC : Case 102 : f0(0).SL.T -= KC : Case 32 : f0(0).BD.F = f0(0).SL.T : End Select : Loop : 显示("jed,") : ae += 1
    End Sub
    Private Sub XX系统_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode : Case 65 : kap = True : Case 68 : kdp = True : Case 87 : kwp = True : Case 83 : ksp = True : Case 70 : krp = True : Case 82 : kfp = True : Case Else : KS = e.KeyCode : End Select
    End Sub
    Private Sub XX系统_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode : Case 65 : kap = False : Case 68 : kdp = False : Case 87 : kwp = False : Case 83 : ksp = False : Case 70 : krp = False : Case 82 : kfp = False : End Select
    End Sub
    Dim e_ As MouseEventArgs, T_, F_ As Vect3j
    Private Sub Panel6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseDown
        e_ = e : T_ = f0(0).BD.Tj : F_ = f0(0).BD.Fj
    End Sub
    Private Sub Panel6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseMove
        With f0(0).BD : If e.Button = Windows.Forms.MouseButtons.Left Then .Fj.θ = F_.θ - (e.X - e_.X) / 4 : .Fj.γ = F_.γ - (e.Y - e_.Y) / 4
            If e.Button = Windows.Forms.MouseButtons.Right Then .Tj.θ = T_.θ - (e.X - e_.X) / 4 : .Fj.γ = F_.γ - (e.Y - e_.Y) / 4 : drr.Set()
        End With
    End Sub
    Private Sub tpimgbox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tpimgbox.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then q(142) = e.X : q(143) = tpimgbox.Height - e.Y : TextBox2.Text = e.X.ToString + "," + e.Y.ToString
    End Sub
    Private Sub tpimgbox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpimgbox.DoubleClick
        pause()
    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        For i = 1 To 360 : tan1(i) = Sin(i / jd * 1.5) * 32767 : Next : Draw0()
    End Sub
    Dim ep As Point, tan1_ckd As Integer
    Private Sub ImageBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ImageBox1.MouseMove
        For i = ep.X To e.X Step IIf(e.X > ep.X, 1, -1) : Dim ey As Double : If e.X <> ep.X Then ey = (e.Y - ep.Y) / (e.X - ep.X)
            If tan1_ckd Then tan1(i) = (ep.Y + ey * (i - ep.X) - ImageBox1.Height / 2) * 327.67 Else For j = 0 To 5 : cbf.Data(i * 5 + j, 0, 0) = (ep.Y + ey * (i - ep.X) - ImageBox1.Height / 2) : Next : cbf0 = cbf.Clone
        Next : If tan1_ckd Then : Draw0() : Else : Draw1() : End If : ep.X = e.X : ep.Y = e.Y
    End Sub
    Private Sub Draw0()
        ImageBox1_Image.SetZero() : Dim npt, ppt As Point : ppt.Y = ImageBox1.Height / 2
        For i = 0 To 360 : npt.X = i : npt.Y = tan1(i) / 327.67 + ImageBox1.Height / 2 : Line(ImageBox1_Image, npt, ppt, cvG) : ppt = npt : Next : ImageBox1.Image = ImageBox1_Image.Bitmap
    End Sub
    Private Sub Draw1()
        ImageBox1_Image.SetZero() : Dim npt, ppt As Point : ppt.Y = ImageBox1.Height / 2
        For i = 0 To 1999 : npt.X = i / 5 : npt.Y = cbf0.Data(i, 0, 0) + ImageBox1.Height / 2 : Line(ImageBox1_Image, npt, ppt, cvG) : ppt = npt : Next : ImageBox1.Image = ImageBox1_Image.Bitmap
    End Sub
    Private Sub djv21_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles djv21.Scroll
        s = 21 : Dr(s) = djv21.Value
    End Sub
    Private Sub djv2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles djv2.Scroll
        s = 2 : Dr(s) = djv2.Value
    End Sub
    Private Sub TrackBar4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles djv31.Scroll
        s = 31 : Dr(s) = djv31.Value
    End Sub
    Private Sub djv11_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles djv11.Scroll
        s = 11 : Dr(s) = djv11.Value
    End Sub
    Private Sub djv12_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles djv12.Scroll
        s = 12 : Dr(s) = djv12.Value
    End Sub
    Private Sub djv22_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles djv22.Scroll
        s = 22 : Dr(s) = djv22.Value
    End Sub
    Private Sub djv1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles djv1.Scroll
        s = 1 : Dr(s) = djv1.Value
    End Sub
    Private Sub djv32_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles djv32.Scroll
        s = 32 : Dr(s) = djv32.Value
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        初始观察点()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Clrmm()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dr(1) = 90 : Dr(32) = 90 : Dr(2) = 90 : Dr(31) = 0
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 立正__.Click
        立正()
    End Sub
    Dim esmd As Integer
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles esmd1b.Click
        esmd = -1
    End Sub
    Private Sub esmdb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles esmdb2.Click
        esmd = 0
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dr1a()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dr1b()
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        dr1c()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        dr1d()
    End Sub
    Private Sub DpTc_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DpTc.Scroll
        DpT = DpTc.Value : DpT__.Text = DpT
    End Sub
    Private Sub PlayL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lv = Not lv
    End Sub
    Private Sub pause___Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pause__.Click
        pause()
    End Sub
    Private Sub Show___Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Show__.Click
    End Sub
    Private Sub Hide___Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hide__.Click
    End Sub
    Private Sub SeeND___CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
    End Sub
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        q(1) = TrackBar1.Value : TextBox2.Text = q(1)
    End Sub
    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll
        q(2) = TrackBar2.Value : TextBox2.Text = q(2)
    End Sub
    Private Sub TrackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar3.Scroll
        q(3) = TrackBar3.Value : TextBox2.Text = q(3)
    End Sub
    Private Sub TrackBar4_Scrol(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar4.Scroll
        q(4) = TrackBar4.Value : TextBox2.Text = q(4)
    End Sub
    Private Sub TrackBar5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar5.Scroll
        q(5) = TrackBar5.Value : TextBox2.Text = q(5)
    End Sub
    Private Sub TrackBar6_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar6.Scroll
        q(6) = TrackBar6.Value : TextBox2.Text = q(6)
    End Sub
    Private Sub TrackBar7_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar7.Scroll
        q(7) = TrackBar7.Value : TextBox2.Text = q(7)
    End Sub
    Private Sub TrackBar8_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar8.Scroll
        q(8) = TrackBar8.Value : TextBox2.Text = q(8)
    End Sub
    Private Sub TrackBar9_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar9.Scroll
        q(9) = TrackBar9.Value : TextBox2.Text = q(9)
    End Sub
    Private Sub TrackBar10_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar10.Scroll
        q(10) = TrackBar10.Value : TextBox2.Text = q(10)
    End Sub
    Private Sub TrackBar11_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar11.Scroll
        q(11) = TrackBar11.Value : TextBox2.Text = q(11)
    End Sub
    Private Sub TrackBar12_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar12.Scroll
        q(12) = TrackBar12.Value : TextBox2.Text = q(12)
    End Sub
    Private Sub TrackBar13_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar13.Scroll
        q(13) = TrackBar13.Value : TextBox2.Text = q(13)
    End Sub
    Private Sub TrackBar14_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar14.Scroll
        q(14) = TrackBar14.Value : TextBox2.Text = q(14)
    End Sub
    Private Sub TrackBar15_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar15.Scroll
        q(15) = TrackBar15.Value : TextBox2.Text = q(15)
    End Sub
    Private Sub TrackBar16_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar16.Scroll
        q(16) = TrackBar16.Value : TextBox2.Text = q(16)
    End Sub
    Private Sub TrackBar17_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar17.Scroll
        q(17) = TrackBar17.Value : TextBox2.Text = q(17)
    End Sub
    Private Sub TrackBar18_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar18.Scroll
        q(18) = TrackBar18.Value : TextBox2.Text = q(18)
    End Sub
    Private Sub TrackBar19_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar19.Scroll
        q(19) = TrackBar19.Value : TextBox2.Text = q(19)
    End Sub
    Private Sub TrackBar20_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar20.Scroll
        q(20) = TrackBar20.Value : TextBox2.Text = q(20)
    End Sub
    Private Sub TrackBar21_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar21.Scroll
        q(21) = TrackBar21.Value : TextBox2.Text = q(21)
    End Sub
    Private Sub TrackBar22_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar22.Scroll
        q(22) = TrackBar22.Value : TextBox2.Text = q(22)
    End Sub
    Private Sub TrackBar23_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar23.Scroll
        q(23) = TrackBar23.Value : TextBox2.Text = q(23)
    End Sub
    Private Sub TrackBar24_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar24.Scroll
        q(24) = TrackBar24.Value : TextBox2.Text = q(24)
    End Sub
    Private Sub TrackBar25_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar25.Scroll
        q(25) = TrackBar25.Value : TextBox2.Text = q(25)
    End Sub
    Private Sub TrackBar26_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar26.Scroll
        q(26) = TrackBar26.Value : TextBox2.Text = q(26)
    End Sub
    Private Sub TrackBar27_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar27.Scroll
        q(27) = TrackBar27.Value : TextBox2.Text = q(27)
    End Sub
    Private Sub TrackBar28_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar28.Scroll
        q(28) = TrackBar28.Value : TextBox2.Text = q(28)
    End Sub
    Private Sub TrackBar29_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar29.Scroll
        q(29) = TrackBar29.Value : TextBox2.Text = q(29)
    End Sub
    Private Sub TrackBar30_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar30.Scroll
        q(30) = TrackBar30.Value : TextBox2.Text = q(30)
    End Sub
    Private Sub TrackBar31_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar31.Scroll
        q(31) = TrackBar31.Value : TextBox2.Text = q(31)
    End Sub
    Private Sub TrackBar32_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar32.Scroll
        q(32) = TrackBar32.Value : TextBox2.Text = q(32)
    End Sub
    Private Sub TrackBar33_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar33.Scroll
        q(33) = TrackBar33.Value : TextBox2.Text = q(33)
    End Sub
    Private Sub TrackBar34_Scrol(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar34.Scroll
        q(34) = TrackBar34.Value : TextBox2.Text = q(34)
    End Sub
    Private Sub TrackBar35_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar35.Scroll
        q(35) = TrackBar35.Value : TextBox2.Text = q(35)
    End Sub
    Private Sub TrackBar36_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar36.Scroll
        q(36) = TrackBar36.Value : TextBox2.Text = q(36)
    End Sub
    Private Sub TrackBar37_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar37.Scroll
        q(37) = TrackBar37.Value : TextBox2.Text = q(37)
    End Sub
    Private Sub TrackBar38_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar38.Scroll
        q(38) = TrackBar38.Value : TextBox2.Text = q(38)
    End Sub
    Private Sub TrackBar39_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar39.Scroll
        q(39) = TrackBar39.Value : TextBox2.Text = q(39)
    End Sub
    Private Sub TrackBar40_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar40.Scroll
        q(40) = TrackBar40.Value : TextBox2.Text = q(40)
    End Sub
    Private Sub TrackBar41_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar41.Scroll
        q(41) = TrackBar41.Value : TextBox2.Text = q(41)
    End Sub
    Private Sub TrackBar42_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar42.Scroll
        q(42) = TrackBar42.Value : TextBox2.Text = q(42)
    End Sub
    Private Sub TrackBar43_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar43.Scroll
        q(43) = TrackBar43.Value : TextBox2.Text = q(43)
    End Sub
    Private Sub TrackBar44_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar44.Scroll
        q(44) = TrackBar44.Value : TextBox2.Text = q(44)
    End Sub
    Private Sub TrackBar45_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar45.Scroll
        q(45) = TrackBar45.Value : TextBox2.Text = q(45)
    End Sub
    Private Sub TrackBar46_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar46.Scroll
        q(46) = TrackBar46.Value : TextBox2.Text = q(46)
    End Sub
    Private Sub TrackBar47_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar47.Scroll
        q(47) = TrackBar47.Value : TextBox2.Text = q(47)
    End Sub
    Private Sub TrackBar48_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar48.Scroll
        q(48) = TrackBar48.Value : TextBox2.Text = q(48)
    End Sub
    Private Sub TrackBar49_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar49.Scroll
        q(49) = TrackBar49.Value : TextBox2.Text = q(49)
    End Sub
    Private Sub TrackBar50_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar50.Scroll
        q(50) = TrackBar50.Value : TextBox2.Text = q(50)
    End Sub
    Private Sub TrackBar51_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar51.Scroll
        q(51) = TrackBar51.Value : TextBox2.Text = q(51)
    End Sub
    Private Sub TrackBar52_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar52.Scroll
        q(52) = TrackBar52.Value : TextBox2.Text = q(52)
    End Sub
    Private Sub TrackBar53_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar53.Scroll
        q(53) = TrackBar53.Value : TextBox2.Text = q(53)
    End Sub
    Private Sub TrackBar54_Scrol(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar54.Scroll
        q(54) = TrackBar54.Value : TextBox2.Text = q(54)
    End Sub
    Private Sub TrackBar55_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar55.Scroll
        q(55) = TrackBar55.Value : TextBox2.Text = q(55)
    End Sub
    Private Sub TrackBar56_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar56.Scroll
        q(56) = TrackBar56.Value : TextBox2.Text = q(56)
    End Sub
    Private Sub TrackBar57_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar57.Scroll
        q(57) = TrackBar57.Value : TextBox2.Text = q(57)
    End Sub
    Private Sub TrackBar58_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar58.Scroll
        q(58) = TrackBar58.Value : TextBox2.Text = q(58)
    End Sub
    Private Sub TrackBar59_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar59.Scroll
        q(59) = TrackBar59.Value : TextBox2.Text = q(59)
    End Sub
    Private Sub TrackBar60_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar60.Scroll
        q(60) = TrackBar60.Value : TextBox2.Text = q(60)
    End Sub
    Private Sub TrackBar114_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar114.Scroll
        q(114) = TrackBar114.Value : TextBox2.Text = q(114)
    End Sub
    Private Sub TrackBar115_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar115.Scroll
        q(115) = TrackBar115.Value : TextBox2.Text = q(115)
    End Sub
    Private Sub TrackBar116_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar116.Scroll
        q(116) = TrackBar116.Value : TextBox2.Text = q(116)
    End Sub
    Private Sub TrackBar117_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar117.Scroll
        q(117) = TrackBar117.Value : TextBox2.Text = q(117)
    End Sub
    Private Sub TrackBar118_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar118.Scroll
        q(118) = TrackBar118.Value : TextBox2.Text = q(118)
    End Sub
    Private Sub TrackBar141_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar141.Scroll
        q(141) = TrackBar141.Value : TextBox2.Text = q(141)
    End Sub
    Private Sub TrackBar142_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar142.Scroll
        q(142) = TrackBar142.Value : TextBox2.Text = q(142)
    End Sub
    Private Sub TrackBar143_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar143.Scroll
        q(143) = TrackBar143.Value : TextBox2.Text = q(143)
    End Sub
    Private Sub ImageBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ImageBox1.MouseDown
        tan1_ckd = Abs(tan1_ckd) - 1
    End Sub
    Private Sub imgboxl_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgboxl.Click
        fd(e.Location, 1, 60)
    End Sub
    Private Sub imgboxr_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgboxr.Click
        fd(e.Location, 0, 60)
    End Sub
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        f0(0).SL.O = nv(, , -90 * cm)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        行___Open()
    End Sub
End Class
