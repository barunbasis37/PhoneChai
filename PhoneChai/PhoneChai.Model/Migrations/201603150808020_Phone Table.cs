namespace PhoneChai.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Brand = c.String(),
                        Cpu = c.String(),
                        Camera = c.String(),
                        Memory = c.String(),
                        Size = c.String(),
                        Resulation = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phones");
        }
    }
}
