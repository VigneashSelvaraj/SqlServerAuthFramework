namespace SqlServerAuthFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTblFieldSample : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TblProjectsSamples", newName: "TblProjectsSample");
            CreateTable(
                "dbo.TblFieldSample",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        Status = c.String(),
                        OwnerName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblFieldSample");
            RenameTable(name: "dbo.TblProjectsSample", newName: "TblProjectsSamples");
        }
    }
}
