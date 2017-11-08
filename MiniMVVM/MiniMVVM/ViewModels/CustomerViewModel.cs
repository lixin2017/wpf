using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MiniMVVM.Model;

namespace MiniMVVM.ViewModels
{
    public class CustomerViewModel:INotifyPropertyChanged
    {
        private Customer obj = new Customer();
        private ButtonCommand command;

        public CustomerViewModel()
        {
            command = new ButtonCommand(obj.CalculateTax,obj.IsValid);
        }

        public ICommand BtnClick
        {
            get { return command; }
        }

        public string TxtCustomerName
        {
            get { return obj.CustomerName; }
            set { obj.CustomerName = value; }
        }

        public string TxtAmount
        {
            get { return Convert.ToString(obj.Amount); }
            set { obj.Amount = Convert.ToDouble(value); }
        }

        public string LblAmountColor
        {
            get
            {
                if (obj.Amount > 2000)
                {
                    return "Blue";
                }
                else if (obj.Amount > 1500)
                {
                    return "Red";
                }
                return "Yellow";
            }
        }

        public bool IsMarried
        {
            get { return obj.Married == "Married"; }
            set
            {
                if (value == true)
                {
                    obj.Married = "Married";
                }
                else
                {
                    obj.Married = "UnMarried";
                }
            }
        }

        public string LblTax
        {
            get { return Convert.ToString(obj.Tax); }
            set { obj.Tax = Convert.ToDouble(value); }
        }
        public void Calculate()
        {
            obj.CalculateTax();
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("LblTax"));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        
    }
}
