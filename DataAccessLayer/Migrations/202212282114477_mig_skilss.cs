namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_skilss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MySkills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Tittle = c.String(),
                        SkillName = c.String(),
                        SkillLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MySkills");
        }
    }
}
