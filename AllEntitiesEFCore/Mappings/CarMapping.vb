Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Public Class CarMapping
    Implements IEntityTypeConfiguration(Of Car)

    Public Sub Configure(builder As EntityTypeBuilder(Of Car)) Implements IEntityTypeConfiguration(Of Car).Configure
        builder.HasKey(Function(x) x.CAR_ID)

        builder.Property(Function(x) x.CAR_ID).HasColumnName("CAR_ID")

        builder.Property(Function(x) x.CAR_MODEL).HasColumnName("CAR_MODEL")

        builder.Property(Function(x) x.CAR_NAME).HasColumnName("CAR_NAME")

    End Sub
End Class
