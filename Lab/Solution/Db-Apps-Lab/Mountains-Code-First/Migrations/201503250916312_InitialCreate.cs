namespace Mountains_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Code);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Countries");
        }
    }
}
