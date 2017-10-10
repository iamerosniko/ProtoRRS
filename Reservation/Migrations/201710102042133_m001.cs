namespace Reservation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m001 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "TimeElapse", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "TimeElapse");
        }
    }
}
