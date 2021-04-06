using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RESTsimpleCD.Models;

namespace RESTsimpleCD.Managers.Tests
{
    [TestClass()]
    public class BooksManagerTests
    {
        private readonly BooksManager _manager = new BooksManager();

        [TestMethod]
        public void GetAllTest()
        {
            List<Book> allBooks = _manager.GetAll();
            Assert.AreEqual(3, allBooks.Count);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Book book = _manager.GetById(1000);
            Assert.IsNull(book);
            book = _manager.GetById(1);
            Assert.IsNotNull(book);
        }
    }
}