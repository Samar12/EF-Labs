namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookCover2 : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.Books", "Id", "dbo.Covers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Id", "dbo.Covers");
        }
    }
}
