namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationEmployeeBook1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EmployeeBooks", newName: "Employee_Books");
            RenameColumn(table: "dbo.Employee_Books", name: "Employee_Id", newName: "FK_BookId");
            RenameColumn(table: "dbo.Employee_Books", name: "Book_Id", newName: "Fk_EmployeeId");
            RenameIndex(table: "dbo.Employee_Books", name: "IX_Book_Id", newName: "IX_Fk_EmployeeId");
            RenameIndex(table: "dbo.Employee_Books", name: "IX_Employee_Id", newName: "IX_FK_BookId");
            DropPrimaryKey("dbo.Employee_Books");
            AddPrimaryKey("dbo.Employee_Books", new[] { "Fk_EmployeeId", "FK_BookId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Employee_Books");
            AddPrimaryKey("dbo.Employee_Books", new[] { "Employee_Id", "Book_Id" });
            RenameIndex(table: "dbo.Employee_Books", name: "IX_FK_BookId", newName: "IX_Employee_Id");
            RenameIndex(table: "dbo.Employee_Books", name: "IX_Fk_EmployeeId", newName: "IX_Book_Id");
            RenameColumn(table: "dbo.Employee_Books", name: "Fk_EmployeeId", newName: "Book_Id");
            RenameColumn(table: "dbo.Employee_Books", name: "FK_BookId", newName: "Employee_Id");
            RenameTable(name: "dbo.Employee_Books", newName: "EmployeeBooks");
        }
    }
}
