using BankSystem.Classes;

class Program
{
    private List<Account> accounts = new List<Account>();
    private List<TransactionManager> Transactions = new List<TransactionManager>();

    public static void Main()
    {
        
        Program p = new Program();

        Account account1 = new Account { Id = 1, Name = "Ardi Kuchi", Pin = 1101, Balance = 1500 };

        int CaseNum;

        do
        {

            Console.WriteLine("Press 1 to Add Account");
            Console.WriteLine("Press 2 to see Bank Account List");
            Console.WriteLine("Press 9 to leave");

            string input = Console.ReadLine();
            if (int.TryParse(input, out CaseNum)) { }
            else {
                Console.WriteLine("Wrong Input, only integers are accepted"); 
            }
                switch (CaseNum)
                {
                    case 1: p.AddAccount(); break;
                    case 2: p.AccountList(); break;
                }
        } while (CaseNum != 9);
    }

    public void AddAccount() 
    {
        //Add Id
        Console.WriteLine("Enter an integer Id");

        if (int.TryParse(Console.ReadLine(), out int id)){}
        else 
        { 
            Console.WriteLine("Wrong Integer Id");
        }

        //Add Name

        Console.WriteLine("Enter Full Name");

        string name = Console.ReadLine();

        //Add Pin

        string InputPin;
        int pin;

        do
        {
            Console.WriteLine("Enter a 4 digit pin(Integer)");
            InputPin = Console.ReadLine();

        } while(InputPin.Length != 4 || !int.TryParse(InputPin, out pin));


        if(InputPin.Length == 4)
        {
            pin = int.Parse(InputPin);
        }
        else
        {
            Console.WriteLine("Enter a 4 digit Number");
        }

        //Balance set to 0

        int balance = 0;

        Account NewAccount = new Account { Id = id, Name = name, Pin = pin, Balance = balance };

        AccountAddHelper(NewAccount);
    }

    public void AccountAddHelper(Account account)
    {
        accounts.Add(account);
    }

    public void AccountList()
    {
        Console.WriteLine("Accounts:");

        foreach (Account account in accounts)
        {
            Console.WriteLine($"Id: {account.Id}, Owner: {account.Name}");
        }
    }

}   
