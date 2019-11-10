namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("leviobd.mandat", "dateDebut", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("leviobd.mandat", "dateFin", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("leviobd.mandat", "dateFin", c => c.DateTime(precision: 0));
            AlterColumn("leviobd.mandat", "dateDebut", c => c.DateTime(precision: 0));
        }
    }
}
