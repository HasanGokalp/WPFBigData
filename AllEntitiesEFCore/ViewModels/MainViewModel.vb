Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Native

Public Class MainViewModel
    Inherits ViewModelBase

    'Props
    Public Property Cars As DXObservableCollection(Of Car)
    'Ctor
    Public Sub New()

    End Sub

    <Command>
    Public Async Sub GetAllCommand()
        Await Task.Run(Sub()
                           Cars = New CarService().GetAll
                           RaisePropertiesChanged("Cars")
                       End Sub)
    End Sub

    <Command>
    Public Async Sub CreateCarsCommand()
        Await Task.Run(Async Sub()
                           Cars = Await New CarService().CreateCars
                           RaisePropertiesChanged("Cars")
                       End Sub)
    End Sub

End Class
