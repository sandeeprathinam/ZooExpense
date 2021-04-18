using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooExpense.Models
{
    public class ExpensesViewModel
    {
        public List<Animals> animals { get; set; }
        public Dictionary<string, double> prices { get; set; }

        public Zoo zoo { get; set; }
        public double price { get; set; }

        public ExpensesViewModel()
        {
            animals = new List<Animals>();
            prices = new Dictionary<string, double>();
            zoo = new Zoo();
        }
    }
}
