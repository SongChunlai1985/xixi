Imports Emgu.CV.Structure, System.Windows.Forms.Application
Module 公用函数_模块
    Public _
         cvG As MCvScalar = New MCvScalar(0, 255, 0), cvY As MCvScalar = New MCvScalar(0, 255, 255),
         cvCl3 As MCvScalar = New MCvScalar(128, 0, 0), cvCl4 As MCvScalar = New MCvScalar(0, 128, 0),
         cvB As MCvScalar = New MCvScalar(255, 0, 0), cvCl6 As MCvScalar = New MCvScalar(0, 255, 0),
         cvR As MCvScalar = New MCvScalar(0, 0, 255), cvCl8 As MCvScalar = New MCvScalar(0, 0, 128),
         cvH As MCvScalar = New MCvScalar(100, 100, 100), cv0 As MCvScalar = New MCvScalar(0, 0, 0),
    cvG25 As MCvScalar = New MCvScalar(0, 25, 0), cvG50 As MCvScalar = New MCvScalar(0, 50, 0), cvG75 As MCvScalar = New MCvScalar(0, 75, 0), cvG100 As MCvScalar = New MCvScalar(0, 100, 0), _
    cvG125 As MCvScalar = New MCvScalar(0, 125, 0), cvG150 As MCvScalar = New MCvScalar(0, 150, 0), cvG175 As MCvScalar = New MCvScalar(0, 175, 0), cvG200 As MCvScalar = New MCvScalar(0, 200, 0),
    cvo As Gray = New Gray
    Public Sub 复制数组(ByRef 目的数据() As Integer, ByVal 源数据() As Integer)
        For i = 0 To UBound(目的数据) : 目的数据(i) = 源数据(i) : Next i
    End Sub
    Public Function fmt(ByVal 数字 As Double) As String
        Return (Fix(数字 * 100) / 100).ToString
    End Function
    Public Const Et As String = Chr(13) + Chr(10)
    Public Function inmm(ByVal i As Integer, ByVal min As Integer, ByVal max As Integer) As Integer
        i = IIf(i > max, max, i) : i = IIf(i < min, min, i) : Return i
    End Function
    Public Function inmm(ByVal i As Point, ByVal min As Point, ByVal max As Point) As Point
        i.X = IIf(i.X > max.X, max.X, i.X) : i.X = IIf(i.X < min.X, min.X, i.X) : i.Y = IIf(i.Y > max.Y, max.Y, i.Y) : i.Y = IIf(i.Y < min.Y, min.Y, i.Y) : Return i
    End Function
    Public Function ct(ByVal vc3x As Vect3x) As Microsoft.DirectX.Vector3
        ct.X = vc3x.x : ct.Y = vc3x.y : ct.Z = vc3x.z : Return ct
    End Function
    Public Function ct(ByVal vc3x As Microsoft.DirectX.Vector3) As Vect3x
        ct.x = vc3x.X : ct.y = vc3x.Y : ct.z = vc3x.Z : Return ct
    End Function
End Module
