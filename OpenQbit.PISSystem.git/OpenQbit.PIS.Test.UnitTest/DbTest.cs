using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQbit.PIS.DataAccess.DAL;
using OpenQbit.PIS.Common.Models;
using System.Linq;


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
    }
}
