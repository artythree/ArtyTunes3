namespace ArtyTunes3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrackForViews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Artist_Name = c.String(),
                        Song_Name = c.String(),
                        Duration = c.Int(nullable: false),
                        Popularity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrackForViews");
        }
    }
}
