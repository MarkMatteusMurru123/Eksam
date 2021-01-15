using Data.Exam.People;
using Data.Exam.PersonTitles;
using Data.Exam.Titles;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        public DbSet<PersonData> People { get; set; }
        public DbSet<PersonTitleData> PersonTitles { get; set; }
        public DbSet<TitleData> Titles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }

        public static void InitializeTables(ModelBuilder builder)
        {
            if (builder is null) return;
            builder.Entity<PersonData>().ToTable(nameof(People));
            builder.Entity<PersonTitleData>().ToTable(nameof(PersonTitles));
            builder.Entity<TitleData>().ToTable(nameof(Titles));

        }
    }
}
