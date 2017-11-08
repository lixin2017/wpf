using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMVVM.Model
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public string Married { get; set; }
        public double Tax { get; set; }

        public void CalculateTax()
        {
            if (Amount > 2000)
            {
                Tax = 20;
            }
            else if (Amount > 1000)
            {
                Tax = 10;
            }
            else
            {
                Tax = 5;               
            }
        }

        public bool IsValid()
        {
            return Math.Abs(Amount) > 0;
        }

    }
}
