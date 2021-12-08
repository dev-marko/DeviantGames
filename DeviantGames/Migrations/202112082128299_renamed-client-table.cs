namespace DeviantGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamedclienttable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ShopUsers", newName: "Clients");
            RenameColumn(table: "dbo.Games", name: "ShopUser_Id", newName: "Client_Id");
            RenameColumn(table: "dbo.Games", name: "ShopUser_Id1", newName: "Client_Id1");
            RenameIndex(table: "dbo.Games", name: "IX_ShopUser_Id", newName: "IX_Client_Id");
            RenameIndex(table: "dbo.Games", name: "IX_ShopUser_Id1", newName: "IX_Client_Id1");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Games", name: "IX_Client_Id1", newName: "IX_ShopUser_Id1");
            RenameIndex(table: "dbo.Games", name: "IX_Client_Id", newName: "IX_ShopUser_Id");
            RenameColumn(table: "dbo.Games", name: "Client_Id1", newName: "ShopUser_Id1");
            RenameColumn(table: "dbo.Games", name: "Client_Id", newName: "ShopUser_Id");
            RenameTable(name: "dbo.Clients", newName: "ShopUsers");
        }
    }
}
