Imports Bogus
Imports DevExpress.Mvvm.Native

Public Class CarService

    Public Sub New()

    End Sub

    Public Function GetAll() As DXObservableCollection(Of Car)
        Using ctx As New EFCoreCtx
            Return New DXObservableCollection(Of Car)(ctx.Cars.ToObservableCollection)
        End Using
    End Function

    Public Async Function CreateCars() As Task(Of DXObservableCollection(Of Car))
        Dim userId = 1
        Using ctx As New EFCoreCtx
            Dim userFaker As New Faker(Of Car)("tr")

            'userFaker.RuleFor(Function(u) u.CAR_ID, Function(f) Threading.Interlocked.Increment(userId))
            userFaker.RuleFor(Function(u) u.CAR_NAME, Function(f) f.Name.FullName())
            userFaker.RuleFor(Function(u) u.CAR_MODEL, Function(f) f.Name.LastName)

            Dim deneme = userFaker.Generate(2000000)
            ctx.Cars.AddRange(deneme)
            Await ctx.SaveChangesAsync

            Return New DXObservableCollection(Of Car)(ctx.Cars.ToObservableCollection)
        End Using
    End Function

End Class
