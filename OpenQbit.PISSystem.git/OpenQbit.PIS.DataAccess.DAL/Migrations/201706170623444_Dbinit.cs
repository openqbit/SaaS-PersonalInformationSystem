namespace OpenQbit.PIS.DataAccess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dbinit : DbMigration
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
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        TaskTypeId = c.Int(nullable: false),
                        TaskType_ID = c.String(maxLength: 128),
                        Employee_ID = c.Int(),
                        Notification_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TaskType", t => t.TaskType_ID)
                .ForeignKey("dbo.Employee", t => t.Employee_ID)
                .ForeignKey("dbo.Notification", t => t.Notification_ID)
                .Index(t => t.TaskType_ID)
                .Index(t => t.Employee_ID)
                .Index(t => t.Notification_ID);
            
            CreateTable(
                "dbo.TaskDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TaskDateAndTime = c.DateTime(nullable: false),
                        TaskId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        TaskType_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Task", t => t.TaskId, cascadeDelete: true)
                .ForeignKey("dbo.TaskType", t => t.TaskType_ID)
                .Index(t => t.TaskId)
                .Index(t => t.EmployeeId)
                .Index(t => t.TaskType_ID);
            
            CreateTable(
                "dbo.TaskType",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        TaskName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MessageDescription = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                        MessageTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MessageDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StatusEmail = c.Boolean(nullable: false),
                        StatusInternalEmail = c.Boolean(nullable: false),
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
                        Description = c.String(),
                        NotificationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "Notification_ID", "dbo.Notification");
            DropForeignKey("dbo.MessageDetail", "MessageID", "dbo.Message");
            DropForeignKey("dbo.MessageDetail", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.Task", "Employee_ID", "dbo.Employee");
            DropForeignKey("dbo.Task", "TaskType_ID", "dbo.TaskType");
            DropForeignKey("dbo.TaskDetail", "TaskType_ID", "dbo.TaskType");
            DropForeignKey("dbo.TaskDetail", "TaskId", "dbo.Task");
            DropForeignKey("dbo.TaskDetail", "EmployeeId", "dbo.Employee");
            DropIndex("dbo.MessageDetail", new[] { "MessageID" });
            DropIndex("dbo.MessageDetail", new[] { "EmployeeID" });
            DropIndex("dbo.TaskDetail", new[] { "TaskType_ID" });
            DropIndex("dbo.TaskDetail", new[] { "EmployeeId" });
            DropIndex("dbo.TaskDetail", new[] { "TaskId" });
            DropIndex("dbo.Task", new[] { "Notification_ID" });
            DropIndex("dbo.Task", new[] { "Employee_ID" });
            DropIndex("dbo.Task", new[] { "TaskType_ID" });
            DropTable("dbo.Notification");
            DropTable("dbo.MessageDetail");
            DropTable("dbo.Message");
            DropTable("dbo.TaskType");
            DropTable("dbo.TaskDetail");
            DropTable("dbo.Task");
            DropTable("dbo.Employee");
        }
    }
}
