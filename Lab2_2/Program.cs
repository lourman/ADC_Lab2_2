Account account1 = new Account("Jane Green", 50.00m);
Account account2 = new Account("John Blue", -7.53m);

// display initial balance of each object
Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:P}");

// prompt for then read input
Console.Write("\nEnter deposit amount for account1: ");
decimal depositAmount = decimal.Parse(Console.ReadLine());

Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
account1.Deposit(depositAmount); // add to account1's balance


// display balances
Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

// prompt for then read input
Console.Write("\nEnter deposit amount for account2: ");
depositAmount = decimal.Parse(Console.ReadLine());

Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
account2.Deposit(depositAmount); // add to account2's balance

// display balances
Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

class Account
{ 
    public string Name { get; set; } // auto-implemented property
    private decimal balance; // instance variable

    // Account constructor that receives two parameters
    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        Balance = initialBalance; // Balance's set accessor validates
    }
    // Balance property with validation
    public decimal Balance
    {
        get
        {
            return balance;
        }

        // method that deposits (adds) only a valid amount to the balance

        private set // can be used only within the class
        {
            // validate that the balance is greater than 0.0; if it's not,
            // instance variable balance keeps its prior value
            if (value > 0.0m) // m indicates that 0.0 is a decimal literal
            {
                balance = value;
            }
        }
    }
    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m) // if the depositAmount is valid
        {
            Balance = Balance + depositAmount; // add it to the balance
        }
    }
}