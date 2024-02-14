Public Class XmlDatabasework
    '  Inherits DataFilter
    ''' <summary>
    ''' يقوم الكلاس بالتعامل مع قواعد البيانات من نوع اكس ام ال و التي يتم انشاءها من كاشن داتا ست
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

    End Sub
    ''' <summary>
    ''' استدعاء ملف البيانات
    ''' </summary>
    ''' <param name="mefilename">اسم الملف</param>
    ''' <param name="medataset">داتا ست</param>
    ''' <remarks></remarks>
    Public Sub looding(ByVal mefilename As String, ByVal medataset As DataSet)
        FileName = mefilename
        DataSet = medataset
    End Sub
    ''' <summary>
    ''' استدعاء ملف البيانات
    ''' </summary>
    ''' <param name="mefilename">اسم الملف</param>
    ''' <param name="medataset">داتا ست</param>
    ''' <param name="bindin">داتا بايندنج</param>
    ''' <remarks></remarks>
    Public Sub looding(ByVal mefilename As String, ByVal medataset As DataSet, ByVal bindin As BindingSource)
        FileName = mefilename
        DataSet = medataset
    End Sub
    Private F As String
    ''' <summary>
    ''' اسم الملف
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FileName()
        Get
            Return F
        End Get
        Set(ByVal value)
            F = value
        End Set
    End Property
    Private datas As DataSet
    ''' <summary>
    ''' الداتا ست
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DataSet() As DataSet
        Get
            Return datas
        End Get
        Set(ByVal value As DataSet)
            datas = value
        End Set
    End Property
    ''' <summary>
    ''' حفظ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Save()
        DataSet.WriteXml(FileName)
      
    End Sub
    ''' <summary>
    ''' قراءة البيانات
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Dataload()
        DataSet.ReadXml(FileName)
    End Sub
End Class
