 namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationDepartmentEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Fk_DepartmentId", c => c.Int(nullable: false));
            AddColumn("dbo.Employee", "department_Id", c => c.Int());
            CreateIndex("dbo.Employee", "department_Id");
            AddForeignKey("dbo.Employee", "department_Id", "dbo.Department", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "department_Id", "dbo.Department");
            DropIndex("dbo.Employee", new[] { "department_Id" });
            DropColumn("dbo.Employee", "department_Id");
            DropColumn("dbo.Employee", "Fk_DepartmentId");
        }
    }
}
