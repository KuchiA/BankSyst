using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Classes
{
    public class TransactionManager
    {
        public bool Transaction(Account fromAccount, Account toAccount, int Amount)
        {
            if (Amount < 0) 
            {
                Console.WriteLine("You cannot transfer a negative number");
                return false;
            }
            if (fromAccount.Balance < Amount) 
            {
                Console.WriteLine("You dont have sufficient funds");
                return false;
            }
            fromAccount.Balance -= Amount;
            toAccount.Balance += Amount;

            Console.WriteLine($"Transfer of {Amount:Eur} from Account {fromAccount.Id} to Account {toAccount.Id} successful.");

            return true;
        }
    }
}
