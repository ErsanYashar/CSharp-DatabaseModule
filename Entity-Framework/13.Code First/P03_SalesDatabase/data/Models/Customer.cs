﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
//	CustomerId
//	Name(up to 100 characters, unicode)
//	Email(up to 80 characters, not unicode)
//	CreditCardNumber(string)
//	Sales
