//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Data.SchoolSystem.Schools;
//using Data.SchoolSystem.Students;

//namespace Infra
//{
//    public static class ProjectDbInitializer
//    {
//        internal static SchoolData KuningaKool = new SchoolData
//        {
//            Id = "37201143255",
//            Name = "Pärnu Kuninga Tänava Põhikool",
//            Email = "ussisoo.albert@net.ee",
//            Type = "Põhikool"
//        };

//        internal static SchoolData Kutsekas = new SchoolData
//        {
//            Id = "49003310713",
//            Name = "Pärnu Kutsehariduskeskus",
//            Email = "malle.maasikas@hotmail.com",
//            Type = "Kutsekool"
//        };

//        internal static SchoolData PÜG = new SchoolData
//        {
//            Id = "49406160242",
//            Name = "Pärnu Ühisgümnaasium",
//            Email = "PYG@gmail.com",
//            Type = "Gümnaasium"
//        };


//        internal static StudentData tiinaSirkel = new StudentData
//        {
//            Id = "tiinasirkel",
//            Name = "Tiina Sirkel",
//            SchoolId = "49406160242",
//            Age = 15,
//            Email = "t.sirkel@gmail.com",
//            FavouriteSubject = "Bioloogia",
//            EnrollmentDate = Convert.ToDateTime("02/09/2018"),
//            Description = "Mingi kirjeldus"
//        };

//        internal static StudentData martinLeib = new StudentData
//        {
//            Id = "martinleib",
//            Name = "Martin Leib",
//            SchoolId = "37201143255",
//            Age = 16,
//            Email = "m.leib@gmail.com",
//            FavouriteSubject = "Math",
//            EnrollmentDate = Convert.ToDateTime("02/09/2018"),
//            Description = "Mingi kirjeldus"
//        };

//        internal static StudentData marianneOts = new StudentData
//        {
//            Id = "marianneots",
//            Name = "Marianne Ots",
//            SchoolId = "49003310713",
//            Age = 12,
//            Email = "m.ots@gmail.com",
//            FavouriteSubject = "Kirjandus",
//            EnrollmentDate = Convert.ToDateTime("22/05/2015"),
//            Description = "Mingi kirjeldus"

//        };

//        internal static List<SchoolData> Schools => new List<SchoolData>
//        {
//            Kutsekas, KuningaKool, PÜG
//        };

//        internal static List<StudentData> Students => new List<StudentData>
//        {
//            tiinaSirkel, marianneOts,martinLeib
//        };
//        private static void InitializeSchools(ProjectDbContext db)
//        {
//            if (db.Schools.Count() != 0) return;
//            db.Schools.AddRange(Schools);
//            db.SaveChanges();
//        }

//        private static void InitializeStudents(ProjectDbContext db)
//        {
//            if (db.Students.Count() != 0) return;
//            db.Students.AddRange(Students);
//            db.SaveChanges();
//        }


//        public static void Initialize(ProjectDbContext db)
//        {
//            InitializeSchools(db);
//            InitializeStudents(db);

//        }
//    }
//}
