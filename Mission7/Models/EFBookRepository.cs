﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class EFBookRepository : iBookRepository
    {

        private BookstoreContext context { get; set; }

        public EFBookRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
