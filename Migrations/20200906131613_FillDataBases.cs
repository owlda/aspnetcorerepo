using Microsoft.EntityFrameworkCore.Migrations;

namespace apsnetproject.Migrations
{
    public partial class FillDataBases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql("INSERT INTO OFFICES (NAME, LOCATION) VALUES ('G1', 'MONTREAL')");

                migrationBuilder.Sql("INSERT INTO MAKES (NAME, OFFICEID) VALUES ('VOLVO', 1)");
                migrationBuilder.Sql("INSERT INTO MAKES (NAME, OFFICEID) VALUES ('HONDA', 1)");
                migrationBuilder.Sql("INSERT INTO MAKES (NAME, OFFICEID) VALUES ('FORD', 1)");

                migrationBuilder.Sql("INSERT INTO MODELS (NAME, MAKEID) VALUES ('FORESTER', 1)");
                migrationBuilder.Sql("INSERT INTO MODELS (NAME, MAKEID) VALUES ('OUTBACK', 1)");

                migrationBuilder.Sql("INSERT INTO MODELS (NAME, MAKEID) VALUES ('CIVIC', 2)");
                migrationBuilder.Sql("INSERT INTO MODELS (NAME, MAKEID) VALUES ('ACCORD', 2)");

                migrationBuilder.Sql("INSERT INTO MODELS (NAME, MAKEID) VALUES ('FOCUS', 3)");
                migrationBuilder.Sql("INSERT INTO MODELS (NAME, MAKEID) VALUES ('FIESTA', 3)");
              
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("DELETE FROM MODELS");
             migrationBuilder.Sql("DELETE FROM MAKES");
             migrationBuilder.Sql("DELETE FROM OFFICES");
        }
    }
}
