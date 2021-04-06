using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTsimpleCD.Managers;
using System;
using System.Collections.Generic;
using System.Text;
using RESTsimpleCD.Models;

namespace RESTsimpleCD.Managers.Tests
{
    [TestClass()]
    public class BooksManagerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            BooksManager manager = new BooksManager();
            List<Book> all = manager.GetAll();
            Assert.AreEqual(30, all.Count);

            Book book = manager.GetById(1);
            Assert.AreEqual("Some title", book.Title);

        }
    }
}