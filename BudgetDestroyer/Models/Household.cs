using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetDestroyer.Models
{
    public class Household
    {
        //Primary Key
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Budget> Budgets { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public ICollection<ApplicationUser> Members { get; set; }

        public Household()
        {
            Budgets = new HashSet<Budget>();
            Accounts = new HashSet<Account>();
            Members = new HashSet<ApplicationUser>();
        }
    }
}