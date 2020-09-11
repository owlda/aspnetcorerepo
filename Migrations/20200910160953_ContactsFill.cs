using Microsoft.EntityFrameworkCore.Migrations;

namespace apsnetproject.Migrations
{
    public partial class ContactsFill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql("INSERT INTO CONTACTS (NAME, SURNAME, ADDRESS) VALUES ('JOHN2','DOE2', 'XXX XXX')");
                migrationBuilder.Sql("INSERT INTO CONTACTS (NAME, SURNAME, ADDRESS) VALUES ('JOHN3','DOE3', 'XXX XXX')");
                migrationBuilder.Sql("INSERT INTO CONTACTS (NAME, SURNAME, ADDRESS) VALUES ('JOHN4','DOE4', 'XXX XXX')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
