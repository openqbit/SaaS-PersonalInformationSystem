using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQbit.PIS.DataAccess.DAL;
using OpenQbit.PIS.Common.Models;
using System.Linq;
using System;

namespace OpenQbit.PIS.Test.UnitTest
{
    [TestClass]
    public class DbTest
    {
        [TestMethod]
        public void TaskTypeInsertTest()
        {
            PISContext db = new PISContext();
            Task newTask = new Task 
            {
                ID = 123,

                Description = "FirstTask",
            };
            db.Task.Add(newTask);
            db.SaveChanges();

            Task findTask =
                db.Task.Where(C => C.ID == 123).FirstOrDefault();
            Assert.AreEqual(newTask.ID, findTask.ID);
            if (findTask != null)
            {
                db.Task.Remove(findTask);
            }
        }
        [TestMethod]
        public void MessageInsertTest()
        {
            PISContext db = new PISContext();
            
            Message newMsg = new Message
            {
                ID = 123,

                MessageDescription = "FirstTask",

                MessageType = "personal",

                MessageDate = new System.DateTime(2017, 6, 16),

                MessageTime = new System.DateTime(9, 20, 30),

                


            };
            db.Message.Add(newMsg);
            db.SaveChanges();

            Task findMsg =
                db.Task.Where(C => C.ID == 123).FirstOrDefault();
            Assert.AreEqual(newMsg.ID, findMsg.ID);
            if (findMsg != null)
            {
                db.Task.Remove(findMsg);
            }
        }

       
    }
}
