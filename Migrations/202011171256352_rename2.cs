namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rename2 : DbMigration
    {
        public override void Up()
        {
            RenameTable("Genre", "Genres");
        }
        
        public override void Down()
        {
        }
    }
}
