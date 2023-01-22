namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            AddColumn("dbo.Movies", "Genre_id", c => c.Short());
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "NumberInStocks", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Genre_id");
            AddForeignKey("dbo.Movies", "Genre_id", "dbo.Genres", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genre_id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_id" });
            AlterColumn("dbo.Movies", "NumberInStocks", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "GenreId", c => c.Short(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Movies", "Genre_id");
            CreateIndex("dbo.Movies", "GenreId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "id", cascadeDelete: true);
        }
    }
}
