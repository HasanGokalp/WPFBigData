Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Native

Public Class MainViewModel
    Inherits ViewModelBase

    Public Property Users As DXObservableCollection(Of User)

    Public Sub New()

    End Sub

    <Command>
    Public Async Sub GetAll()
        Await Task.Run(Sub()
                           Users = New DXObservableCollection(Of User)(New UserService().LoadData())
                           RaisePropertiesChanged("Users")
                       End Sub)
    End Sub

End Class
