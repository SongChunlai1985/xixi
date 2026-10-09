Imports Emgu.CV, Emgu.CV.Structure, System.Math, Emgu.CV.CvInvoke, System.Threading, System.Runtime.InteropServices, System.Drawing.Imaging, System.Windows.Forms.Application, Microsoft.DirectX, Microsoft.DirectX.Direct3D
Module 眼
    Public ley, rey As Capture, sztxtr As Size = New Size(ewd / 16, eht / 16), 眼l_ As Thread = New Thread(AddressOf 眼l__), 眼r_ As Thread = New Thread(AddressOf 眼r__),
      ibxl As New Mat(esz, CvEnum.DepthType.Cv8U, 3), ibxr As New Mat(esz, CvEnum.DepthType.Cv8U, 3), ibxl0 As Mat = ibxl.Clone, ibxr0 As Mat = ibxr.Clone,
      ibxl2 As Mat = ibxl.Clone, ibxr2 As Mat = ibxr.Clone, txtrl, txtrr As Texture,
       maxlpl(10), maxlpr(10) As Point, lfps, rfps, swpl, swpr, swtl, swtr As Single
    Private Sub 眼l__()
        ley = New Capture(0) ': ley.SetCaptureProperty(CvEnum.CapProp.Fps, 30)
        显示("eokl,") : ar.Set() : Do While Run : ibxl = ley.QueryFrame : ibxl2 = ibxl.Clone : ail1.Set()
            Resize(ibxl, ibxl0, sztxtr) : ail3.Set() : txtrl = New Direct3D.Texture(D3dv, ibxl0.Bitmap, Direct3D.Usage.None, Direct3D.Pool.Managed)
            ail.Set() : ail4.WaitOne(500) : swtl = swtl + 1 : If swtl >= 10 Then : lfps = 10000 / (sw.ElapsedMilliseconds - swpl) : swtl = 0 : swpl = sw.ElapsedMilliseconds : End If : Loop : 显示("eedl,") : ae += 1
    End Sub
    Private Sub 眼r__()
        rey = New Capture(1)    ': rey.SetCaptureProperty(CvEnum.CapProp.Fps, 30)
        显示("eokr,") : ar.Set() : Do While Run : ibxr = rey.QueryFrame : ibxr2 = ibxr.Clone : air1.Set()
            Resize(ibxr, ibxr0, sztxtr) : air3.Set() : txtrr = New Direct3D.Texture(D3dv, ibxr0.Bitmap, Direct3D.Usage.None, Direct3D.Pool.Managed)
            air.Set() : air4.WaitOne(500) : swtr = swtr + 1 : If swtr >= 10 Then : rfps = 10000 / (sw.ElapsedMilliseconds - swpr) : swtr = 0 : swpr = sw.ElapsedMilliseconds : End If : Loop : 显示("eedr,") : ae += 1
    End Sub
End Module