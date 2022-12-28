namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_Writer_Edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 105));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 250));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 205));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 25));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterAbout");
        }
    }
}
