namespace Reservation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m003 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "UserName");
        }
    }
}
