namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rename : DbMigration
    {
        public override void Up()
        {
            RenameTable("Genres", "Genres");
        }
        
        public override void Down()
        {
        }
    }
}
