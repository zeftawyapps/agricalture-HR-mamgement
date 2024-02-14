Imports System.Math
Public Class SalaryCalculationFunctions
    Friend Function NesabFunc(ByVal Vals As Single, ByVal percentage As Decimal) As Single
        Return Math.Round((Vals * percentage), 3)
    End Function
    Public Function Takreeb(ByVal d As Single, Optional ByVal abb As Boolean = True) As Single

        Dim dd, ddd, lon, dfromat As String
        dd = d.ToString
        Dim i As Integer
        i = InStr(dd, ".", )
        lon = Mid(dd, i)

        If Len(lon) > 2 Then
            If abb Then
                ddd = Right(dd, 1)
                If CInt(ddd) > 2 Then
                    If CInt(ddd) > 4 Then
                        dfromat = Format(d, "###.##0")
                    Else
                        d = d + 0.01
                        dfromat = Format(d, "###.##0")
                    End If

                Else

                    d = Math.Round(d, 2)
                    dfromat = Format(d, "###.##")
                End If
                 
            Else
                ' لو مافيش تقريب 
                d = d - 0.005
                dfromat = Format(d, "###.###")

            End If

        Else

            d = Math.Round(d, 2)
            dfromat = Format(d, "###.##")
            
        End If
            


        dfromat = Format(CSng(dfromat), "###.##")
        Return CSng(dfromat)
    End Function
End Class


Public Class SalaryAdded
    Inherits SalaryCalculationFunctions
    Dim m As Math
#Region "حصة الحكومة"

    Private Ass As Single
    ''' <summary>
    ''' المرتب الاساسي
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Assasy() As Single
        Get
            Return Ass
        End Get
        Set(ByVal value As Single)
            Ass = value
        End Set
    End Property

    ''' <summary>
    ''' 15% حصة الحكومة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getHokoma15() As Single
        Get
            Return Takreeb(NesabFunc(Assasy, 0.15))
        End Get
    End Property

    ''' <summary>
    ''' 1% حصة الحكومة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getHokoma1() As Single
        Get
            Return Takreeb(NesabFunc(Assasy, 0.01))
        End Get
    End Property
    ''' <summary>
    ''' 2% حصة الحكومة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getHokoma2() As Single
        Get
            Return Takreeb(NesabFunc(Assasy, 0.02))

        End Get
    End Property

    ''' <summary>
    ''' 1,5% حصة الحكومة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getHokoma1_5() As Single
        Get
            Return Takreeb(NesabFunc(Assasy, 0.015))
        End Get
    End Property
    ''' <summary>
    ''' مجموع الحكومة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Totalhokoma() As Single
        Get
            Return getHokoma15 + getHokoma1 + getHokoma2 + getHokoma1_5
        End Get
    End Property
#End Region
#Region "العلاوات"
    Dim badal5, egtma3y, hadnaa, _125, _75, _200, B3adwy, bTafrgh, menhaa As Single
    Public Sub SetBadalHwaf(ByVal i1 As Single, ByVal i2 As Single, ByVal i3 As Single, ByVal i4 As Single, ByVal i5 As Single, ByVal eg As Integer, ByVal eg2 As Integer, ByVal hd As Single)
        badal5 = i1 + i2 + i3 + i4 + i5
        egtma3y = eg + eg2
        hadnaa = hd
        _125 = Takreeb((NesabFunc(Assasy, 1.25)), False)
        _75 = Takreeb((NesabFunc(Assasy, 0.75)), False)
        _200 = _125 + _75
    End Sub
    Public Sub SetBadal3adwaa(ByVal b3d As Single, ByVal btag As Single, ByVal menhaas As Integer)
        B3adwy = b3d
        bTafrgh = btag
        menhaa = menhaas
    End Sub
    ''' <summary>
    ''' مجموع خمس علاوات
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Get5Badal()
        Get
            Return badal5
        End Get
    End Property
    ''' <summary>
    ''' حد ادنى
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property GetHadAddnaa()
        Get
            Return hadnaa
        End Get
    End Property
    ''' <summary>
    '''الاجتماعية
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property GetEgtema3ee()
        Get
            Return egtma3y
        End Get
    End Property
    ''' <summary>
    '''200%
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Get200()
        Get
            Return _200
        End Get
    End Property
    ''' <summary>
    '''25%
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Get75()
        Get
            Return _75
        End Get
    End Property
    ''' <summary>
    '''125%
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Get125()
        Get
            Return _125
        End Get
    End Property
    ''' <summary>
    '''بدل عدوى و تفرغ 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Get3adwaaTafhrgh()
        Get
            Return bTafrgh + B3adwy
        End Get
    End Property
    ''' <summary>
    ''' مجموع الحوافز
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalHeafeez() As Single
        Get
            Return Get200 + Get3adwaaTafhrgh + Get5Badal + GetEgtema3ee + GetHadAddnaa
        End Get
    End Property
    ''' <summary>
    ''' 15%  متغير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getmotgher15() As Single
        Get
            Return Takreeb(NesabFunc(TotalHeafeez, 0.15))
        End Get
    End Property
    ''' <summary>
    ''' 1% متغير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getmotgher1() As Single
        Get
            Return Takreeb(NesabFunc(TotalHeafeez, 0.01))
        End Get
    End Property
    ''' <summary>
    ''' مجموع حصص الحكومة من الاجور المتغير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Totamotgher() As Single
        Get
            Return Takreeb(getmotgher1 + getmotgher15)
        End Get
    End Property
    ''' <summary>
    ''' اجمالي المستحقات
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property totalADDED() As Single
        Get
            Return Assasy + Totalhokoma + TotalHeafeez + Totamotgher + menhaa
        End Get
    End Property

#End Region
End Class
