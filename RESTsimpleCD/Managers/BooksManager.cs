﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTsimpleCD.Models;

namespace RESTsimpleCD.Managers
{
    public class BooksManager
    {
        private static int _nextId = 1;
        private static readonly List<Book> Data = new List<Book>()
        {
            new Book(){Id=_nextId++, Title = "First book"},
            new Book(){Id=_nextId++, Title ="Another book"}
        };

        public List<Book> GetAll() { return new List<Book>(Data); }
    }
}
