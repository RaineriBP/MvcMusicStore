namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Genere", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "Genere");
        }
    }
}
