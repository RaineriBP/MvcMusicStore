namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artists", "NameGroup", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artists", "NameGroup");
        }
    }
}
