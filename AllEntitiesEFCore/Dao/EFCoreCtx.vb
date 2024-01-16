Imports System.Reflection
Imports Microsoft.EntityFrameworkCore

Public Class EFCoreCtx
    Inherits DbContext

    Public Property Cars As DbSet(Of Car)

    Public Sub New()
        MyBase.New()
    End Sub

    Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)
        If Not optionsBuilder.IsConfigured Then
            MyBase.OnConfiguring(optionsBuilder)
            optionsBuilder.UseSqlServer("Server=.\SQLEXPRESS;Database=ShowRoom2;Trusted_Connection=True;TrustServerCertificate=True")
            optionsBuilder.EnableSensitiveDataLogging()
        End If
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
        modelBuilder.ApplyConfiguration(New CarMapping)
    End Sub

End Class
