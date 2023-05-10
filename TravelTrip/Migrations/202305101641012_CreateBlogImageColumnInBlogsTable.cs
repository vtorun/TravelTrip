namespace TravelTrip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBlogImageColumnInBlogsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogImage");
        }
    }
}
