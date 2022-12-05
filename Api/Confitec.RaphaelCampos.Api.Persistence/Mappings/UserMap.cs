using Confitec.RaphaelCampos.Api.Domain.Entities;
using Confitec.RaphaelCampos.Api.Domain.Shared.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Confitec.RaphaelCampos.Api.Persistence.Mappings
{
    public class UserMap : EntityTypeConfigurationGeneric<User>
    {
        protected override string TableName => nameof(User);

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.FirstName).HasMaxLength(30).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(40).IsRequired();
            builder.Property(p => p.UserEmail).HasMaxLength(60).IsRequired();
            builder.Property(p => p.UserBirthdayDate).IsRequired();
            builder.Property(p => p.Schooling).IsRequired();
            builder.HasData(new User(1, "Ryan", "Real", "ryan_gael_cortereal@foxtech.com.br", new DateTime(2002, 02, 19), Schooling.HigherEducation));
            builder.HasData(new User(2, "Benedito", "Drumond", "benedito.marcelo.drumond@padrejuliano.com", new DateTime(1992, 04, 29), Schooling.HighSchool));
            builder.HasData(new User(3, "Thales", "Figueiredo", "thales_figueiredo@bodyfast.com.br", new DateTime(2002, 02, 07), Schooling.Elementary));
            builder.HasData(new User(4, "Kauê", "Novaes", "kaue.novaes@facilitycom.com.br", new DateTime(2006, 05, 01), Schooling.EarlyChildhoodEducation));
            builder.HasData(new User(5, "Kauê", "Thomas", "kaue.thomas@riders.com.br", new DateTime(1982, 10, 21), Schooling.HighSchool));
            builder.HasData(new User(6, "Vitor", "Porto", "vitor-porto97@techdomus.com", new DateTime(1992, 12, 09), Schooling.HigherEducation));
            builder.HasData(new User(7, "Clarice", "Baptista", "clarice.baptista@xerocopiadora.com", new DateTime(1983, 04, 10), Schooling.HigherEducation));
            builder.HasData(new User(8, "Isabel", "Ribeiro", "isabel.ribeiro@fictor.com.br", new DateTime(1968, 03, 12), Schooling.EarlyChildhoodEducation));
            builder.HasData(new User(9, "Larissa", "Baptista", "larissa.baptista@terra.com", new DateTime(1986, 03, 19), Schooling.HighSchool));
            builder.HasData(new User(10, "Yasmin", "Ribeiro", "yasmin.ribeiro@fictor.com", new DateTime(1992, 06, 26), Schooling.Elementary));
            builder.HasData(new User(11, "Danilo", "Fernandes", "danilomanoelfernandes@tonyveiculos.com.br", new DateTime(1998, 06, 27), Schooling.HigherEducation));
            builder.HasData(new User(12, "Tatiane", "Rodrigues", "tatiane-rodrigues92@virage.com.br", new DateTime(2001, 02, 20), Schooling.HighSchool));
            builder.HasData(new User(13, "Diogo", "Cruz", "joao-dacruz70@tera.com.br", new DateTime(1979, 05, 05), Schooling.HigherEducation));
            builder.HasData(new User(14, "Rayssa", "Nascimento", "rayssa_nascimento@buzatto.com", new DateTime(1976, 02, 02), Schooling.EarlyChildhoodEducation));
            builder.HasData(new User(15, "Emanuelly", "Maya", "maya-emmanuelly@liberdade.com.br", new DateTime(2004, 06, 03), Schooling.HigherEducation));
            builder.HasData(new User(16, "Larissa", "Costa", "larissa.costa86@piemme.com.br", new DateTime(1954, 03, 06), Schooling.Elementary));
            builder.HasData(new User(17, "Sebastião", "Moreira", "ebastiao_heitor_moreira@lencise.com", new DateTime(1989, 09, 12), Schooling.HigherEducation));
            builder.HasData(new User(18, "Nathan", "Mota", "nathan_damota@gustavoscoelho.com", new DateTime(2004, 01, 11), Schooling.HigherEducation));
            builder.HasData(new User(19, "Antonio", "Mota", "antonio_damota@gustavoscoelho.com", new DateTime(1972, 07, 09), Schooling.EarlyChildhoodEducation));
            builder.HasData(new User(20, "Renan", "Melo", "rananmmelo@tech.com.br", new DateTime(1995, 08, 23), Schooling.HighSchool));
            builder.HasData(new User(21, "Hugo", "Silva", "hugosilvasilva@tech.com.br", new DateTime(1995, 11, 05), Schooling.HighSchool));
            builder.HasData(new User(22, "Carlos", "Lara", "carloscorteslara@tech.com.br", new DateTime(1995, 04, 29), Schooling.HighSchool));
            builder.HasData(new User(23, "Antonella", "Alves", "antonella_alves@gmdi.com.br", new DateTime(2002, 10, 13), Schooling.Elementary));
            builder.HasData(new User(24, "Catarina", "Alves", "catarina_alves@gmdi.com.br", new DateTime(1962, 02, 01), Schooling.HighSchool));
            builder.HasData(new User(25, "Camila", "Alves", "camila_alves@gmdi.com.br", new DateTime(1992, 09, 23), Schooling.HigherEducation));
            builder.HasData(new User(26, "Isabel", "Real", "real_isabel@silvaconfec.com.br", new DateTime(1972, 07, 13), Schooling.Elementary));
            builder.HasData(new User(27, "Jéssica", "Assis", "jessica_assiss@silvaconfec.com.br", new DateTime(2000, 09, 23), Schooling.HigherEducation));
            builder.HasData(new User(28, "Aurora", "Carvalho", "carvalho_aurora@silvaconfec.com.br", new DateTime(1952, 05, 22), Schooling.HighSchool));
            builder.HasData(new User(29, "Kaique", "Alves", "kaique.alves@bot.com.br", new DateTime(1999, 05, 10), Schooling.Elementary));
            builder.HasData(new User(30, "Benício", "Jesus", "benicio.jesus@bot.com.br", new DateTime(2003, 08, 11), Schooling.EarlyChildhoodEducation));
            builder.HasData(new User(31, "Diego", "Costa", "diego.costa@bot.com.br", new DateTime(1998, 03, 19), Schooling.HighSchool));
        }
    }
}
