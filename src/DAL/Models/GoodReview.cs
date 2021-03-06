﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class GoodReview
    {
        public int Id { get; set; }

        public int GoodId { get; set; }

        public Good Good { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public string Message { get; set; }

        public int StarCount { get; set; }

        public DateTime Date { get; set; }
    }
}
