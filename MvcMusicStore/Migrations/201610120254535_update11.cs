namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artists", "WinAwards", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artists", "WinAwards");
        }
    }
}
