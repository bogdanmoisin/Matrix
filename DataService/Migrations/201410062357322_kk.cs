namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PERSON_ID = c.String(nullable: false, maxLength: 128),
                        TITLE = c.String(),
                        FIRSTNAME = c.String(),
                        LASTNAME = c.String(),
                        PHOTO_IDENTITY = c.Binary(),
                        NATIONALITY = c.String(),
                        IDENTITY_NUMBER = c.String(),
                        BIRTH_DATE = c.DateTime(),
                        BIRTH_PLACE = c.String(),
                        PHONE_NUMBER = c.String(),
                        EMAIL_ADRESS = c.String(),
                        HOME_ADRESS = c.String(),
                        REGISTRATION_DATE = c.DateTime(),
                    })
                .PrimaryKey(t => t.PERSON_ID);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        STAFF_ID = c.String(nullable: false, maxLength: 128),
                        POSITION = c.String(),
                        DEPARTEMENT = c.String(),
                        QUALIFICATION = c.String(),
                        HIRED_DATE = c.String(),
                        STATUT = c.String(),
                    })
                .PrimaryKey(t => t.STAFF_ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        STUDENT_ID = c.String(nullable: false, maxLength: 128),
                        TITLE = c.String(),
                        FIRSTNAME = c.String(nullable: false),
                        LASTNAME = c.String(nullable: false),
                        PHOTO_IDENTITY = c.Binary(),
                        NATIONALITY = c.String(),
                        IDENTITY_NUMBER = c.String(),
                        BIRTH_DATE = c.DateTime(),
                        BIRTH_PLACE = c.String(),
                        PHONE_NUMBER = c.String(),
                        EMAIL_ADRESS = c.String(),
                        HOME_ADRESS = c.String(),
                        REGISTRATION_DATE = c.DateTime(),
                        STATUT = c.String(),
                    })
                .PrimaryKey(t => t.STUDENT_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Staffs");
            DropTable("dbo.People");
        }
    }
}
