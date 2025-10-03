using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Classes
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pin { get; set; }
        public int Balance {  get; set; }

        public int GetBalance()
        {
            return Balance;
        }

        public void SetBalance(int amount)
        {
            Balance = amount;
        }
    }
}
