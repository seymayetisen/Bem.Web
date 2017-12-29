using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SinavYonetim.Models
{
    public class SinavYonetimDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Option> Option { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<PersonsExam> PersonExam { get; set; }
        public DbSet<Demo> Demo { get; set; }

        public Person Person2 { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public SinavYonetimDbContext() : base("Data Source=DESKTOP-S3O5AOR;Initial Catalog=CihaninDatabesi;user id=orhan; password=321654;Integrated Security=True")
        {
            Database.SetInitializer<SinavYonetimDbContext>(new DbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>().ToTable("Sinav");
            modelBuilder.Entity<Person>().ToTable("Kisi");

            modelBuilder.Entity<Demo>().Property(d => d.Ad).HasColumnName("Na  me");
            modelBuilder.Entity<Demo>().Property(d => d.Ad).HasColumnType("varchar");
            modelBuilder.Entity<Demo>().Property(d => d.Ad).HasMaxLength(15);

            modelBuilder.Entity<Demo>()
                .Property(d => d.BirincilAnahtar)
                .HasColumnOrder(2);


            modelBuilder.Entity<Demo>().HasKey(t => t.BirincilAnahtar);

            base.OnModelCreating(modelBuilder);
        }

    }

    public class DbInitializer : DropCreateDatabaseAlways<SinavYonetimDbContext>
    {
        protected override void Seed(SinavYonetimDbContext context)
        {
            var p1 = new Person
            {
                Name = "Orhan",
                Surname = "Aygün",
                IdentityNumber = "12345678978",
                UserName = "orhan",
                Password = "123546"
            };

            var p2 = new Person
            {
                Name = "Ahmet",
                Surname = "Mehmet",
                IdentityNumber = "12345678978",
                UserName = "ahmet",
                Password = "123546"
            };

            var p3 = new Person
            {
                Name = "Oya",
                Surname = "Rıza",
                IdentityNumber = "12345678978",
                UserName = "ali",
                Password = "123546"
            };

            var s1 = new Exam
            {
                Title = "s1",
                Description = "d1",
                Duration = 3600,
                StartDate = DateTime.Now.AddDays(-5),
                EndDate = DateTime.Now.AddDays(5)
            };


            var pe1 = new PersonsExam
            {
                Person = p1,
                Exam = s1,
                Status = PersonsExamStatus.NotStarted
            };

            //context.Person.Add(p1);
            context.Person.Add(p2);
            context.Person.Add(p3);

            context.PersonExam.Add(pe1);


            context.SaveChanges();

            base.Seed(context);
        }
    }
}