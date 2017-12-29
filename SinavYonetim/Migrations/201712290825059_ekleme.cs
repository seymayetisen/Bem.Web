namespace SinavYonetim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekleme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonExam_Id = c.Int(),
                        Option_Id = c.Int(),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PersonsExams", t => t.PersonExam_Id)
                .ForeignKey("dbo.Options", t => t.Option_Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.PersonExam_Id)
                .Index(t => t.Option_Id)
                .Index(t => t.Question_Id);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Question_Id = c.Int(),
                        ParentQuestion_Id = c.Int(),
                        Question_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .ForeignKey("dbo.Questions", t => t.ParentQuestion_Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id1)
                .Index(t => t.Question_Id)
                .Index(t => t.ParentQuestion_Id)
                .Index(t => t.Question_Id1);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        CorrectAnswer_Id = c.Int(),
                        Exam_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Options", t => t.CorrectAnswer_Id)
                .ForeignKey("dbo.Sinav", t => t.Exam_Id)
                .Index(t => t.CorrectAnswer_Id)
                .Index(t => t.Exam_Id);
            
            CreateTable(
                "dbo.Sinav",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Duration = c.Int(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonsExams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        Exam_Id = c.Int(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sinav", t => t.Exam_Id)
                .ForeignKey("dbo.Kisi", t => t.Person_Id)
                .Index(t => t.Exam_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.Kisi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        IdentityNumber = c.String(),
                        FullName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Demoes",
                c => new
                    {
                        BirincilAnahtar = c.Int(nullable: false, identity: true),
                        Name = c.String(name: "Na  me", maxLength: 15, unicode: false),
                        Soyad = c.String(),
                    })
                .PrimaryKey(t => t.BirincilAnahtar);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.Answers", "Option_Id", "dbo.Options");
            DropForeignKey("dbo.Options", "Question_Id1", "dbo.Questions");
            DropForeignKey("dbo.Options", "ParentQuestion_Id", "dbo.Questions");
            DropForeignKey("dbo.Options", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.Questions", "Exam_Id", "dbo.Sinav");
            DropForeignKey("dbo.PersonsExams", "Person_Id", "dbo.Kisi");
            DropForeignKey("dbo.PersonsExams", "Exam_Id", "dbo.Sinav");
            DropForeignKey("dbo.Answers", "PersonExam_Id", "dbo.PersonsExams");
            DropForeignKey("dbo.Questions", "CorrectAnswer_Id", "dbo.Options");
            DropIndex("dbo.PersonsExams", new[] { "Person_Id" });
            DropIndex("dbo.PersonsExams", new[] { "Exam_Id" });
            DropIndex("dbo.Questions", new[] { "Exam_Id" });
            DropIndex("dbo.Questions", new[] { "CorrectAnswer_Id" });
            DropIndex("dbo.Options", new[] { "Question_Id1" });
            DropIndex("dbo.Options", new[] { "ParentQuestion_Id" });
            DropIndex("dbo.Options", new[] { "Question_Id" });
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            DropIndex("dbo.Answers", new[] { "Option_Id" });
            DropIndex("dbo.Answers", new[] { "PersonExam_Id" });
            DropTable("dbo.Demoes");
            DropTable("dbo.Kisi");
            DropTable("dbo.PersonsExams");
            DropTable("dbo.Sinav");
            DropTable("dbo.Questions");
            DropTable("dbo.Options");
            DropTable("dbo.Answers");
        }
    }
}
