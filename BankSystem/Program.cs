using BankSystem.Classes;

class Program
{
    private List<Account> accounts = new List<Account>();
    private List<TransactionManager> Transactions = new List<TransactionManager>();
    private List<AccountAdmin> admins = new List<AccountAdmin>();

    public static void Main()
    {
        Program p = new Program();

        int CaseNum;
        do
        {

            Console.WriteLine("Press 1 to Login with Admin");
            Console.WriteLine("Press 2 to Login with User");
            Console.WriteLine("Press 9 to leave");

            string input = Console.ReadLine();
            if (int.TryParse(input, out CaseNum)) { }
            else
            {
                Console.WriteLine("Wrong Input, only integers are accepted");
            }
            switch (CaseNum)
            {
                case 1: p.LoginWAdmin(); break;
                case 2: p.LoginWUser(); break;
            }
        } while (CaseNum != 9);

    }

    public void LoginWAdmin()
    {
        AccountAdmin admin = new AccountAdmin { Id = 1, Name = "Kuchi", Password = "kuchi123" };
        admins.Add(admin);

        string Name, Password;

        do
        {
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            Password = Console.ReadLine();
        } while (Name != admin.Name || Password != admin.Password);

        AdminInterface();
        
    }

    public void LoginWUser()
    {
        int Pin = 0;
        string NameUser = "";

        foreach (Account account in accounts) 
        {
            Pin = account.Pin;
            NameUser = account.Name;
        }

        string Name;

        int Password;
        string Input;

        do
        {
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            Input = Console.ReadLine();
            if(int.TryParse(Input, out Password)) {}

        } while (Name != NameUser || Password != Pin );

        Console.WriteLine("YEEEEEEEEEEEEEES");
    }

    private void TransferMoney()
    {

    }

    private void SeeAmount()
    {

    }

    public void UserInterface()
    {
        int CaseNum;

        do
        {

            Console.WriteLine("Press 1 to See Amount");
            Console.WriteLine("Press 2 to Transfer Money");
            Console.WriteLine("Press 9 to leave");

            string input = Console.ReadLine();
            if (int.TryParse(input, out CaseNum)) { }
            else
            {
                Console.WriteLine("Wrong Input, only integers are accepted");
            }
            switch (CaseNum)
            {
                case 1: SeeAmount(); break;
                case 2: TransferMoney(); break;
            }
        } while (CaseNum != 9);
    }

    public void AdminInterface()
    {
        int CaseNum;

        do
        {

            Console.WriteLine("Press 1 to Add Account");
            Console.WriteLine("Press 2 to see Bank Account List");
            Console.WriteLine("Press 9 to leave");

            string input = Console.ReadLine();
            if (int.TryParse(input, out CaseNum)) { }
            else
            {
                Console.WriteLine("Wrong Input, only integers are accepted");
            }
            switch (CaseNum)
            {
                case 1: AddAccount(); break;
                case 2: AccountList(); break;
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
