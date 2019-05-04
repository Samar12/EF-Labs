namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationDepartmentEmployee1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Employee", new[] { "department_Id" });
            DropColumn("dbo.Employee", "Fk_DepartmentId");
            RenameColumn(table: "dbo.Employee", name: "department_Id", newName: "Fk_DepartmentId");
            AlterColumn("dbo.Employee", "Fk_DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "Fk_DepartmentId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employee", new[] { "Fk_DepartmentId" });
            AlterColumn("dbo.Employee", "Fk_DepartmentId", c => c.Int());
            RenameColumn(table: "dbo.Employee", name: "Fk_DepartmentId", newName: "department_Id");
            AddColumn("dbo.Employee", "Fk_DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "department_Id");
        }
    }
}
