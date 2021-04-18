using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooExpense.Models;

namespace ZooExpense.ManagerServices.PriceManager
{
    public interface IPriceManager
    {
        public ExpensesViewModel CalculateExpense(ExpensesViewModel expensesViewModel);
    }
}
