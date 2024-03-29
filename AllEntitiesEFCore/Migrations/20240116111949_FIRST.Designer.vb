﻿' <auto-generated />
Imports AllEntitiesEFCore
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Infrastructure
Imports Microsoft.EntityFrameworkCore.Metadata
Imports Microsoft.EntityFrameworkCore.Migrations

Namespace Global.AllEntitiesEFCore.Migrations
    <DbContext(GetType(EFCoreCtx))>
    <Migration("20240116111949_FIRST")>
    Partial Class FIRST
        ''' <inheritdoc />
        Protected Overrides Sub BuildTargetModel(modelBuilder As ModelBuilder)
            modelBuilder.
                HasAnnotation("ProductVersion", "7.0.15").
                HasAnnotation("Relational:MaxIdentifierLength", 128)

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder)

            modelBuilder.Entity("AllEntitiesEFCore.Car",
                Sub(b)
                    b.Property(Of Integer)("CAR_ID").
                        ValueGeneratedOnAdd().
                        HasColumnType("int").
                        HasColumnName("CAR_ID")

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property(Of Integer)("CAR_ID"))

                    b.Property(Of String)("CAR_MODEL").
                        HasColumnType("nvarchar(max)").
                        HasColumnName("CAR_MODEL")

                    b.Property(Of String)("CAR_NAME").
                        HasColumnType("nvarchar(max)").
                        HasColumnName("CAR_NAME")

                    b.HasKey("CAR_ID")

                    b.ToTable("Cars")
                End Sub)
        End Sub
    End Class
End Namespace
