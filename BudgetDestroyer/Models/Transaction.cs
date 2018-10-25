﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetDestroyer.Models
{
    public class Transaction
    {
        //Primary Key
        public int Id { get; set; }

        //Foreign Key
        public int AccountId { get; set; }
        public int TransactionTypeId { get; set; }
        public int BudgetItemId { get; set; }
        public string EnteredById { get; set; }

        public string Discription { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
       
        public bool Reconciled { get; set; }
        public decimal ReconciledAmount { get; set; }

        public virtual Account Account { get; set; }     
        public virtual TransactionType TransactionType { get; set; }
        public virtual ApplicationUser EnteredBy { get; set; }

    }
}