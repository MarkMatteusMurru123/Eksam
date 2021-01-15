using System;
using System.Collections.Generic;
using System.Linq;
using Data.TitleSystem.People;
using Data.TitleSystem.PersonTitles;
using Data.TitleSystem.Titles;

namespace Infra
{
    public static class ProjectDbInitializer
    {
        internal static PersonTitleData HärraMartin = new PersonTitleData
        {
            Id = "0",
            Name = "Härra Martin Leib",
            PersonId = "martinLeib",
            TitleId = "12"

        };
        internal static PersonTitleData ProuaTiina = new PersonTitleData
        {
            Id = "1",
            Name = "Proua Tiina Sirkel",
            PersonId = "tiinasirkel",
            TitleId = "49003310713"

        };
        internal static PersonTitleData ProfMarianne = new PersonTitleData
        {
            Id = "2",
            Name = "Professor Marianne Ots",
            PersonId = "marianneots",
            TitleId = "12345"

        };
        internal static TitleData Härra = new TitleData
        {
            Id = "12",
            Name = "Härra",
            TitlePrefix = "hr"
        };

        internal static TitleData Proua = new TitleData
        {
            Id = "49003310713",
            Name = "Proua",
            TitlePrefix = "pr"
        };

        internal static TitleData Doktor = new TitleData
        {
            Id = "49406160242",
            Name = "Doktor",
            TitlePrefix = "Dr"
        };
        internal static TitleData Professor = new TitleData
        {
            Id = "12345",
            Name = "Professor",
            TitlePrefix = "Prof"
        };
        internal static TitleData Sir = new TitleData
        {
            Id = "6789",
            Name = "Söör",
        };
        internal static TitleData Keiser = new TitleData
        {
            Id = "10",
            Name = "Keiser",
        };
        internal static PersonData tiinaSirkel = new PersonData
        {
            Id = "tiinasirkel",
            Name = "Tiina Sirkel",
            Gender = Gender.Naine,
            Age = 35,
            Email = "t.sirkel@gmail.com",
        };

        internal static PersonData martinLeib = new PersonData
        {
            Id = "martinleib",
            Name = "Martin Leib",
            Gender = Gender.Mees,
            Age = 65,
            Email = "m.leib@gmail.com",
        };
        internal static PersonTitleData drmartinLeib = new PersonTitleData
        {
            Id = "martinleib",
            Name = "Martin Leib",
            PersonId = "martinleib",
            TitleId = "49406160242"
        };

        internal static PersonData marianneOts = new PersonData
        {
            Id = "marianneots",
            Name = "Marianne Ots",
            Gender = Gender.Naine,
            Age = 12,
            Email = "m.ots@gmail.com",
        };

        internal static List<TitleData> Titles => new List<TitleData>
        {
            Keiser,Sir,Proua,Härra,Professor, Doktor
        };
        internal static List<PersonTitleData> PersonTitles => new List<PersonTitleData>
        {
            HärraMartin,ProfMarianne,ProuaTiina, drmartinLeib
        };

        internal static List<PersonData> Persons => new List<PersonData>
        {
            tiinaSirkel, marianneOts,martinLeib
        };
        private static void InitializeTitles(ProjectDbContext db)
        {
            if (db.Titles.Count() != 0) return;
            db.Titles.AddRange(Titles);
            db.SaveChanges();
        }
        private static void InitializePersonTitles(ProjectDbContext db)
        {
            if (db.PersonTitles.Count() != 0) return;
            db.PersonTitles.AddRange(PersonTitles);
            db.SaveChanges();
        }

        private static void InitializePersons(ProjectDbContext db)
        {
            if (db.People.Count() != 0) return;
            db.People.AddRange(Persons);
            db.SaveChanges();
        }


        public static void Initialize(ProjectDbContext db)
        {
            InitializeTitles(db);
            InitializePersons(db);
            InitializePersonTitles(db);
        }
    }
}
