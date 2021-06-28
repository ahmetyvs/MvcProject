﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WriterMail : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Writers", "WriterMail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 200));
        }
    }
}