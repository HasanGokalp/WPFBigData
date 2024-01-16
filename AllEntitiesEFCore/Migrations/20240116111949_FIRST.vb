Imports Microsoft.EntityFrameworkCore.Migrations

Namespace Global.AllEntitiesEFCore.Migrations
    ''' <inheritdoc />
    Partial Public Class FIRST
        Inherits Migration

        ''' <inheritdoc />
        Protected Overrides Sub Up(migrationBuilder As MigrationBuilder)
            migrationBuilder.CreateTable(
                name:="Cars",
                columns:=Function(table) New With {
                    .CAR_ID = table.Column(Of Integer)(type:="int", nullable:=False).
                        Annotation("SqlServer:Identity", "1, 1"),
                    .CAR_NAME = table.Column(Of String)(type:="nvarchar(max)", nullable:=True),
                    .CAR_MODEL = table.Column(Of String)(type:="nvarchar(max)", nullable:=True)
                },
                constraints:=Sub(table)
                    table.PrimaryKey("PK_Cars", Function(x) x.CAR_ID)
                End Sub)
        End Sub

        ''' <inheritdoc />
        Protected Overrides Sub Down(migrationBuilder As MigrationBuilder)
            migrationBuilder.DropTable(
                name:="Cars")
        End Sub
    End Class
End Namespace
