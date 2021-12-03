namespace phonebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContacts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Name = c.String(),
                        Number = c.String(),
                        Favorite = c.Boolean(nullable: false),
                        Emergency = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
