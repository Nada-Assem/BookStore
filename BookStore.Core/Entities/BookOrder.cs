﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class BookOrder
    {
        public int BookId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
    }
}
