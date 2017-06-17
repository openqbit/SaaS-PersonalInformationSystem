using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQbit.PIS.DataAccess.DAL;
using OpenQbit.PIS.Common.Models;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using OpenQbit.PIS.Test.UnitTest;

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
        public void EmployeeInsertTest()
        {
            PISContext db = new PISContext();
            Employee newEmp = new Employee
            {
                ID = 123,

                Name = "Naduni",

                Address = "galle"
            };
            db.Employee.Add(newEmp);
            db.SaveChanges();

            Employee findEmp =
                db.Employee.Where(C => C.ID == 123).FirstOrDefault();
            Assert.AreEqual(newEmp.ID, findEmp.ID);
            if (findEmp != null)
            {
                db.Employee.Remove(findEmp);
            }
        }
        [TestMethod]
        public void TaskDetailInsertTest()
        {
            PISContext db = new PISContext();
            TaskDetail newTaskDetail = new TaskDetail
            {
                ID = 123,

                TaskDateAndTime = new DateTime(2017,06,16),

                Employee = new Employee(),

                Task = new Task(),
            };
            db.TaskDetail.Add(newTaskDetail);
            db.SaveChanges();

            TaskDetail findTaskDetail =
                db.TaskDetail.Where(C => C.ID == 123).FirstOrDefault();
            Assert.AreEqual(newTaskDetail.ID, findTaskDetail.ID);
            if (findTaskDetail != null)
            {
                db.TaskDetail.Remove(findTaskDetail);
            }
        }
        [TestMethod]
        public void MessageDetailInsertTest()
        {
            PISContext db = new PISContext();
            MessageDetail newMsgDetail = new MessageDetail
            {
                ID = 123,

                Message = new Message(),

                Employee = new Employee(),

                EmployeeID = 123,

                MessageID = 123,

                StatusEmail = true,

                StatusInternalEmail = true,

                StatusSMS = true,
            };
            db.MessageDetail.Add(newMsgDetail);
            db.SaveChanges();

            MessageDetail findMsgDetail =
                db.MessageDetail.Where(C => C.ID == 123).FirstOrDefault();
            Assert.AreEqual(newMsgDetail.ID, findMsgDetail.ID);
            if (findMsgDetail != null)
            {
                db.MessageDetail.Remove(findMsgDetail);
            }
        }
        [TestMethod]
        public void MessageInsertTest()
        {
            PISContext db = new PISContext();
            ICollection<MessageDetail> md = new List<MessageDetail>();
            
            Message newMsg = new Message
            {
                ID = 123,

                MessageDate = new DateTime(2017, 06, 16),

                MessageTime = new DateTime(2017, 06, 16),

                MessageDescription = "personal",
                
                MessageDetail = md
            };
            db.Message.Add(newMsg);
            db.SaveChanges();

            Message findMsg =
                db.Message.Where(C => C.ID == 123).FirstOrDefault();
            Assert.AreEqual(newMsg.ID, findMsg.ID);
            if (findMsg != null)
            {
                db.Message.Remove(findMsg);
            }

        }

        //private class NewMessageCollection : ICollection<MessageDetail>
        //{
        //    public int Count
        //    {
        //        get
        //        {
        //            throw new NotImplementedException();
        //        }
        //    }

        //    public bool IsReadOnly
        //    {
        //        get
        //        {
        //            throw new NotImplementedException();
        //        }
        //    }

        //    public void Add(MessageDetail item)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Clear()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public bool Contains(MessageDetail item)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void CopyTo(MessageDetail[] array, int arrayIndex)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public IEnumerator<MessageDetail> GetEnumerator()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public bool Remove(MessageDetail item)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public virtual IEnumerator IEnumerable.GetEnumerator()
        //    {
        //        return new MsgCollectionEnumerator<MessageDetail>();
        //    }
        //}
    }

    //internal class MsgCollectionEnumerator<T> : IEnumerator<T> where T:MessageDetail
    //{
    //    private NewMessageCollection newMessageCollection;

    //    public MsgCollectionEnumerator(NewMessageCollection newMessageCollection)
    //    {
    //        this.newMessageCollection = newMessageCollection;
    //    }

    //    public T Current
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    object IEnumerator.Current
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public void Dispose()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool MoveNext()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Reset()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
