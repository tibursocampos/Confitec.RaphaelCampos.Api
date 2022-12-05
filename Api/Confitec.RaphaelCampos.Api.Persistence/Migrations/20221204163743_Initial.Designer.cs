﻿// <auto-generated />
using System;
using Confitec.RaphaelCampos.Api.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Confitec.RaphaelCampos.Api.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221204163743_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Confitec.RaphaelCampos.Api.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Schooling")
                        .HasColumnType("int");

                    b.Property<DateTime>("UserBirthdayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Ryan",
                            LastName = "Real",
                            Schooling = 3,
                            UserBirthdayDate = new DateTime(2002, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "ryan_gael_cortereal@foxtech.com.br"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Benedito",
                            LastName = "Drumond",
                            Schooling = 2,
                            UserBirthdayDate = new DateTime(1992, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "benedito.marcelo.drumond@padrejuliano.com"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Thales",
                            LastName = "Figueiredo",
                            Schooling = 1,
                            UserBirthdayDate = new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "thales_figueiredo@bodyfast.com.br"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Kauê",
                            LastName = "Novaes",
                            Schooling = 0,
                            UserBirthdayDate = new DateTime(2006, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "kaue.novaes@facilitycom.com.br"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Kauê",
                            LastName = "Thomas",
                            Schooling = 2,
                            UserBirthdayDate = new DateTime(1982, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "kaue.thomas@riders.com.br"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Vitor",
                            LastName = "Porto",
                            Schooling = 3,
                            UserBirthdayDate = new DateTime(1992, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "vitor-porto97@techdomus.com"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Clarice",
                            LastName = "Baptista",
                            Schooling = 3,
                            UserBirthdayDate = new DateTime(1983, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "clarice.baptista@xerocopiadora.com"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Isabel",
                            LastName = "Ribeiro",
                            Schooling = 0,
                            UserBirthdayDate = new DateTime(1968, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "isabel.ribeiro@fictor.com.br"
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Larissa",
                            LastName = "Baptista",
                            Schooling = 2,
                            UserBirthdayDate = new DateTime(1986, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "larissa.baptista@terra.com"
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Yasmin",
                            LastName = "Ribeiro",
                            Schooling = 1,
                            UserBirthdayDate = new DateTime(1992, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "yasmin.ribeiro@fictor.com"
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "Danilo",
                            LastName = "Fernandes",
                            Schooling = 3,
                            UserBirthdayDate = new DateTime(1998, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "danilomanoelfernandes@tonyveiculos.com.br"
                        },
                        new
                        {
                            Id = 12,
                            FirstName = "Tatiane",
                            LastName = "Rodrigues",
                            Schooling = 2,
                            UserBirthdayDate = new DateTime(2001, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "tatiane-rodrigues92@virage.com.br"
                        },
                        new
                        {
                            Id = 13,
                            FirstName = "Diogo",
                            LastName = "Cruz",
                            Schooling = 3,
                            UserBirthdayDate = new DateTime(1979, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "joao-dacruz70@tera.com.br"
                        },
                        new
                        {
                            Id = 14,
                            FirstName = "Rayssa",
                            LastName = "Nascimento",
                            Schooling = 0,
                            UserBirthdayDate = new DateTime(1976, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "rayssa_nascimento@buzatto.com"
                        },
                        new
                        {
                            Id = 15,
                            FirstName = "Emanuelly",
                            LastName = "Maya",
                            Schooling = 3,
                            UserBirthdayDate = new DateTime(2004, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "maya-emmanuelly@liberdade.com.br"
                        },
                        new
                        {
                            Id = 16,
                            FirstName = "Larissa",
                            LastName = "Costa",
                            Schooling = 1,
                            UserBirthdayDate = new DateTime(1954, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "larissa.costa86@piemme.com.br"
                        },
                        new
                        {
                            Id = 17,
                            FirstName = "Sebastião",
                            LastName = "Moreira",
                            Schooling = 3,
                            UserBirthdayDate = new DateTime(1989, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "ebastiao_heitor_moreira@lencise.com"
                        },
                        new
                        {
                            Id = 18,
                            FirstName = "Nathan",
                            LastName = "Mota",
                            Schooling = 3,
                            UserBirthdayDate = new DateTime(2004, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "nathan_damota@gustavoscoelho.com"
                        },
                        new
                        {
                            Id = 19,
                            FirstName = "Antonio",
                            LastName = "Mota",
                            Schooling = 0,
                            UserBirthdayDate = new DateTime(1972, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "antonio_damota@gustavoscoelho.com"
                        },
                        new
                        {
                            Id = 20,
                            FirstName = "Renan",
                            LastName = "Melo",
                            Schooling = 2,
                            UserBirthdayDate = new DateTime(1995, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "rananmmelo@tech.com.br"
                        },
                        new
                        {
                            Id = 21,
                            FirstName = "Hugo",
                            LastName = "Silva",
                            Schooling = 2,
                            UserBirthdayDate = new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "hugosilvasilva@tech.com.br"
                        },
                        new
                        {
                            Id = 22,
                            FirstName = "Carlos",
                            LastName = "Lara",
                            Schooling = 2,
                            UserBirthdayDate = new DateTime(1995, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "carloscorteslara@tech.com.br"
                        },
                        new
                        {
                            Id = 23,
                            FirstName = "Antonella",
                            LastName = "Alves",
                            Schooling = 1,
                            UserBirthdayDate = new DateTime(2002, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "antonella_alves@gmdi.com.br"
                        },
                        new
                        {
                            Id = 24,
                            FirstName = "Catarina",
                            LastName = "Alves",
                            Schooling = 2,
                            UserBirthdayDate = new DateTime(1962, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "catarina_alves@gmdi.com.br"
                        },
                        new
                        {
                            Id = 25,
                            FirstName = "Camila",
                            LastName = "Alves",
                            Schooling = 3,
                            UserBirthdayDate = new DateTime(1992, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "camila_alves@gmdi.com.br"
                        },
                        new
                        {
                            Id = 26,
                            FirstName = "Isabel",
                            LastName = "Real",
                            Schooling = 1,
                            UserBirthdayDate = new DateTime(1972, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "real_isabel@silvaconfec.com.br"
                        },
                        new
                        {
                            Id = 27,
                            FirstName = "Jéssica",
                            LastName = "Assis",
                            Schooling = 3,
                            UserBirthdayDate = new DateTime(2000, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "jessica_assiss@silvaconfec.com.br"
                        },
                        new
                        {
                            Id = 28,
                            FirstName = "Aurora",
                            LastName = "Carvalho",
                            Schooling = 2,
                            UserBirthdayDate = new DateTime(1952, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "carvalho_aurora@silvaconfec.com.br"
                        },
                        new
                        {
                            Id = 29,
                            FirstName = "Kaique",
                            LastName = "Alves",
                            Schooling = 1,
                            UserBirthdayDate = new DateTime(1999, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "kaique.alves@bot.com.br"
                        },
                        new
                        {
                            Id = 30,
                            FirstName = "Benício",
                            LastName = "Jesus",
                            Schooling = 0,
                            UserBirthdayDate = new DateTime(2003, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "benicio.jesus@bot.com.br"
                        },
                        new
                        {
                            Id = 31,
                            FirstName = "Diego",
                            LastName = "Costa",
                            Schooling = 2,
                            UserBirthdayDate = new DateTime(1998, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserEmail = "diego.costa@bot.com.br"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}