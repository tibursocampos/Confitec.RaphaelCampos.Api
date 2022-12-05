using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Confitec.RaphaelCampos.Api.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    UserBirthdayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Schooling = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => table.PrimaryKey("PK_User", x => x.Id));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FirstName", "LastName", "Schooling", "UserBirthdayDate", "UserEmail" },
                values: new object[,]
                {
                    { 1, "Ryan", "Real", 3, new DateTime(2002, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "ryan_gael_cortereal@foxtech.com.br" },
                    { 29, "Kaique", "Alves", 1, new DateTime(1999, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "kaique.alves@bot.com.br" },
                    { 28, "Aurora", "Carvalho", 2, new DateTime(1952, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "carvalho_aurora@silvaconfec.com.br" },
                    { 27, "Jéssica", "Assis", 3, new DateTime(2000, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "jessica_assiss@silvaconfec.com.br" },
                    { 26, "Isabel", "Real", 1, new DateTime(1972, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "real_isabel@silvaconfec.com.br" },
                    { 25, "Camila", "Alves", 3, new DateTime(1992, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "camila_alves@gmdi.com.br" },
                    { 24, "Catarina", "Alves", 2, new DateTime(1962, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "catarina_alves@gmdi.com.br" },
                    { 23, "Antonella", "Alves", 1, new DateTime(2002, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "antonella_alves@gmdi.com.br" },
                    { 22, "Carlos", "Lara", 2, new DateTime(1995, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "carloscorteslara@tech.com.br" },
                    { 21, "Hugo", "Silva", 2, new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "hugosilvasilva@tech.com.br" },
                    { 20, "Renan", "Melo", 2, new DateTime(1995, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "rananmmelo@tech.com.br" },
                    { 19, "Antonio", "Mota", 0, new DateTime(1972, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "antonio_damota@gustavoscoelho.com" },
                    { 18, "Nathan", "Mota", 3, new DateTime(2004, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "nathan_damota@gustavoscoelho.com" },
                    { 17, "Sebastião", "Moreira", 3, new DateTime(1989, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ebastiao_heitor_moreira@lencise.com" },
                    { 30, "Benício", "Jesus", 0, new DateTime(2003, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "benicio.jesus@bot.com.br" },
                    { 16, "Larissa", "Costa", 1, new DateTime(1954, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "larissa.costa86@piemme.com.br" },
                    { 14, "Rayssa", "Nascimento", 0, new DateTime(1976, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "rayssa_nascimento@buzatto.com" },
                    { 13, "Diogo", "Cruz", 3, new DateTime(1979, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "joao-dacruz70@tera.com.br" },
                    { 12, "Tatiane", "Rodrigues", 2, new DateTime(2001, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "tatiane-rodrigues92@virage.com.br" },
                    { 11, "Danilo", "Fernandes", 3, new DateTime(1998, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "danilomanoelfernandes@tonyveiculos.com.br" },
                    { 10, "Yasmin", "Ribeiro", 1, new DateTime(1992, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "yasmin.ribeiro@fictor.com" },
                    { 9, "Larissa", "Baptista", 2, new DateTime(1986, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "larissa.baptista@terra.com" },
                    { 8, "Isabel", "Ribeiro", 0, new DateTime(1968, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabel.ribeiro@fictor.com.br" },
                    { 7, "Clarice", "Baptista", 3, new DateTime(1983, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "clarice.baptista@xerocopiadora.com" },
                    { 6, "Vitor", "Porto", 3, new DateTime(1992, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "vitor-porto97@techdomus.com" },
                    { 5, "Kauê", "Thomas", 2, new DateTime(1982, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "kaue.thomas@riders.com.br" },
                    { 4, "Kauê", "Novaes", 0, new DateTime(2006, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kaue.novaes@facilitycom.com.br" },
                    { 3, "Thales", "Figueiredo", 1, new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "thales_figueiredo@bodyfast.com.br" },
                    { 2, "Benedito", "Drumond", 2, new DateTime(1992, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "benedito.marcelo.drumond@padrejuliano.com" },
                    { 15, "Emanuelly", "Maya", 3, new DateTime(2004, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "maya-emmanuelly@liberdade.com.br" },
                    { 31, "Diego", "Costa", 2, new DateTime(1998, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "diego.costa@bot.com.br" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
