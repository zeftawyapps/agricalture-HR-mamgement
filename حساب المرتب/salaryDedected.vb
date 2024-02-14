Public Class salaryDeduction
    Inherits SalaryCalculationFunctions
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

    Private mot As Single
    ''' <summary>
    ''' المرتب الاساسي
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property motgher() As Single
        Get
            Return mot
        End Get
        Set(ByVal value As Single)
            mot = value
        End Set
    End Property

#Region "حصة الحكومة"

   
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
    ''' 10% حصة الحكومة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getHokoma10() As Single
        Get
            Return Takreeb(NesabFunc(Assasy, 0.1))
        End Get
    End Property

    ''' <summary>
    ''' 3% حصة الحكومة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getHokoma3() As Single
        Get
            Return Takreeb(NesabFunc(Assasy, 0.03))
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
            Return getHokoma15 + getHokoma1 + getHokoma2 + getHokoma1_5 + getHokoma10 + getHokoma3
        End Get
    End Property
#End Region
#Region "قسط المعاش"
    Private Totalqst As Single
    ''' <summary>
    ''' ادخال اقساط المعاش
    ''' </summary>
    ''' <param name="m3ash">قسط المعاش</param>
    ''' <param name="Moahtraa">قسط المشتراه</param>
    ''' <param name="Estebdal">الاستبدال</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function setAqsatM3ash(ByVal m3ash As Single, ByVal Moahtraa As Single, ByVal Estebdal As Single)
        Totalqst = m3ash + Moahtraa + Estebdal
        Return Totalqst
    End Function
    ''' <summary>
    ''' اجمالي اقساط المعاش
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalAqsaat()
        Get
            Return Totalqst
        End Get
    
    End Property
#End Region
#Region "الاجور المتغيرة"
    Private totalhafz As Single
    ''' <summary>
    ''' اجمالي الحوافز
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Public WriteOnly Property SetTotalHafez()
        Set(ByVal value)
            totalhafz = value
        End Set
    End Property
    ''' <summary>
    ''' 1% متغير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getmotgher1() As Single
        Get
            Return Takreeb(NesabFunc(totalhafz, 0.01))
        End Get
    End Property
    ''' <summary>
    '''15% متغير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getmotgher15() As Single
        Get
            Return Takreeb(NesabFunc(totalhafz, 0.15))
        End Get
    End Property
    ''' <summary>
    ''' 10% متغير
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getmotgher10() As Single
        Get
            Return Takreeb(NesabFunc(totalhafz, 0.1))
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
            Return Takreeb(getmotgher1 + getmotgher15, getmotgher10)
        End Get
    End Property

#End Region
#Region "ديون"
    Private TotlaDeen As Single
    Private totaOtherDeen As Single
    ''' <summary>
    ''' ادخال الديون السنوية
    ''' </summary>
    ''' <param name="damaan">ضمان الحكومة</param>
    ''' <param name="solfaa">السلفة</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function setdeen(ByVal damaan As Single, ByVal solfaa As Single)
        TotlaDeen = damaan + solfaa
        Return TotlaDeen
    End Function
    ''' <summary>
    ''' اجمالي الديون السنوية
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotaDeon()
        Get
            Return TotlaDeen
        End Get 
    End Property
    ''' <summary>
    ''' ادخال الديون الاخرى
    ''' </summary>
    ''' <param name="egtma3ee">الاجتماعي</param>
    ''' <param name="takfol">تكافل</param>
    ''' <param name="nashaat">جمعية النشاط</param>
    ''' <param name="naqaba3omaal">نقابة عمال</param>
    ''' <param name="tatbeeqeen">نادي التطبيقيين</param>
    ''' <param name="togareen">تجاريين</param>
    ''' <param name="tatbeekeenNqaaba">نقابة التطبيقيين</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function setotherdeen(ByVal egtma3ee As Single, ByVal takfol As Single, ByVal nashaat As Single, ByVal naqaba3omaal As Single, ByVal tatbeeqeen As Single, ByVal togareen As Single, ByVal tatbeekeenNqaaba As Single)
        TotlaDeen = egtma3ee + takfol + tatbeekeenNqaaba + tatbeeqeen + togareen + nashaat + naqaba3omaal
        Return totaOtherDeen
    End Function
    ''' <summary>
    ''' اجمالي الديون اخرى
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalotherDeon()
        Get
            Return totaOtherDeen
        End Get
    End Property
#End Region
#Region "التامين الصحي"


    ''' <summary>
    ''' 1.5% التامين الصحي
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getTameen1_5() As Single
        Get
            Return Takreeb(NesabFunc(Assasy, 1.5))
        End Get
    End Property

    ''' <summary>
    ''' .5%  التامين الصحي 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property getTameen_5() As Single
        Get
            Return Takreeb(NesabFunc(Assasy, 0.005))
        End Get
    End Property

    ''' <summary>
    ''' مجموع التامين
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalTameen() As Single
        Get
            Return getTameen1_5 + getTameen_5
        End Get
    End Property
#End Region
#Region "ضرائب"
    Private Totlatax As Single
    ''' <summary>
    ''' ادخال الديون السنوية
    ''' </summary>
    ''' <param name="kasb">كسب عمل</param>
    ''' <param name="damgha">دمغة</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function setTax(ByVal kasb As Single, ByVal damgha As Single)
        TotlaDeen = kasb + damgha
        Return Totlatax
    End Function
    ''' <summary>
    ''' اجمالي الضرائب
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Totatax()
        Get
            Return TotlaDeen
        End Get

    End Property
#End Region
    ''' <summary>
    ''' اجمالي الاستقطاعات
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property totalDeduction()
        Get
            Return Totalhokoma + TotaDeon + TotalotherDeon + TotalTameen + Totamotgher + Totatax + TotalAqsaat
        End Get

    End Property
End Class
