using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateAmerica
{
    public class Person
    {
        private double _wallet = 0;
        public string Name { get; set; }
        public int Age { get; set; }

        public void AddMoney(double moneyToAdd)
        {
            _wallet += moneyToAdd;
        }

        public double CheckWallet()
        {
            return _wallet;
        }
    }
}
