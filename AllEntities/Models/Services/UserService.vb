Imports Bogus
Imports DevExpress.Mvvm.Native

Public Class UserService

    Public Property Items As DXObservableCollection(Of User)

    Public Sub New()

    End Sub

    Public Function LoadData() As List(Of User)
        Dim userId As Integer = 0
        Dim userFaker As New Faker(Of User)("tr")

        userFaker.RuleFor(Function(u) u.Id, Function(f) Threading.Interlocked.Increment(userId))
        userFaker.RuleFor(Function(u) u.Name, Function(f) f.Name.FullName())
        userFaker.RuleFor(Function(u) u.Email, Function(f) f.Internet.Email())

        Return userFaker.Generate(1000)

    End Function
End Class
