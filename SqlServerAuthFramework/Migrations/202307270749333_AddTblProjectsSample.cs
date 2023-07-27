namespace SqlServerAuthFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTblProjectsSample : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblProjectsSamples",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        OwnerName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblProjectsSamples");
        }
    }
}
