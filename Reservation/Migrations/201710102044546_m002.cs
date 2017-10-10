namespace Reservation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "TimeSlot", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "TimeSlot");
        }
    }
}
