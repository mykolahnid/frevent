namespace Frevent.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameUser : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "ApplicationUsers");
            RenameColumn(table: "dbo.IdentityUserClaims", name: "AspNetUser_Id", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.IdentityUserLogins", name: "AspNetUser_Id", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.IdentityUserRoles", name: "AspNetUser_Id", newName: "ApplicationUser_Id");
            RenameIndex(table: "dbo.IdentityUserRoles", name: "IX_AspNetUser_Id", newName: "IX_ApplicationUser_Id");
            RenameIndex(table: "dbo.IdentityUserClaims", name: "IX_AspNetUser_Id", newName: "IX_ApplicationUser_Id");
            RenameIndex(table: "dbo.IdentityUserLogins", name: "IX_AspNetUser_Id", newName: "IX_ApplicationUser_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.IdentityUserLogins", name: "IX_ApplicationUser_Id", newName: "IX_AspNetUser_Id");
            RenameIndex(table: "dbo.IdentityUserClaims", name: "IX_ApplicationUser_Id", newName: "IX_AspNetUser_Id");
            RenameIndex(table: "dbo.IdentityUserRoles", name: "IX_ApplicationUser_Id", newName: "IX_AspNetUser_Id");
            RenameColumn(table: "dbo.IdentityUserRoles", name: "ApplicationUser_Id", newName: "AspNetUser_Id");
            RenameColumn(table: "dbo.IdentityUserLogins", name: "ApplicationUser_Id", newName: "AspNetUser_Id");
            RenameColumn(table: "dbo.IdentityUserClaims", name: "ApplicationUser_Id", newName: "AspNetUser_Id");
            RenameTable(name: "dbo.ApplicationUsers", newName: "AspNetUsers");
        }
    }
}
