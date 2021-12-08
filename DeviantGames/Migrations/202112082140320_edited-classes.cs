namespace DeviantGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedclasses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Game_Id", c => c.Int());
            CreateIndex("dbo.Clients", "Game_Id");
            AddForeignKey("dbo.Clients", "Game_Id", "dbo.Games", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Game_Id", "dbo.Games");
            DropIndex("dbo.Clients", new[] { "Game_Id" });
            DropColumn("dbo.Clients", "Game_Id");
        }
    }
}
