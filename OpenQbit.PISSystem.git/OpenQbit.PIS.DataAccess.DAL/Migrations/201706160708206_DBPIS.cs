namespace OpenQbit.PIS.DataAccess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBPIS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Task_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Task", t => t.Task_ID)
                .Index(t => t.Task_ID);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Notification_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Notification", t => t.Notification_ID)
                .Index(t => t.Notification_ID);
            
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MessageDescription = c.String(),
                        MessageType = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                        MessageTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MessageDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StatusE_mail = c.Boolean(nullable: false),
                        StatusInternalE_mail = c.Boolean(nullable: false),
                        StatusSMS = c.Boolean(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        MessageID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employee", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Message", t => t.MessageID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.MessageID);
            
            CreateTable(
                "dbo.Notification",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Desc = c.String(),
                        Date = c.String(),
                        Time = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TaskDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TaskDateAndTime = c.DateTime(nullable: false),
                        Employee_ID = c.Int(),
                        Task_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employee", t => t.Employee_ID)
                .ForeignKey("dbo.Task", t => t.Task_ID)
                .Index(t => t.Employee_ID)
                .Index(t => t.Task_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaskDetail", "Task_ID", "dbo.Task");
            DropForeignKey("dbo.TaskDetail", "Employee_ID", "dbo.Employee");
            DropForeignKey("dbo.Task", "Notification_ID", "dbo.Notification");
            DropForeignKey("dbo.MessageDetail", "MessageID", "dbo.Message");
            DropForeignKey("dbo.MessageDetail", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.Employee", "Task_ID", "dbo.Task");
            DropIndex("dbo.TaskDetail", new[] { "Task_ID" });
            DropIndex("dbo.TaskDetail", new[] { "Employee_ID" });
            DropIndex("dbo.MessageDetail", new[] { "MessageID" });
            DropIndex("dbo.MessageDetail", new[] { "EmployeeID" });
            DropIndex("dbo.Task", new[] { "Notification_ID" });
            DropIndex("dbo.Employee", new[] { "Task_ID" });
            DropTable("dbo.TaskDetail");
            DropTable("dbo.Notification");
            DropTable("dbo.MessageDetail");
            DropTable("dbo.Message");
            DropTable("dbo.Task");
            DropTable("dbo.Employee");
        }
    }
}
