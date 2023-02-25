using System;
using System.Collections;
//lehoangkhoi-20mc-20it438
class Account
{
    // lớp account chứa AccountID, FirstName, LastName, Balance 
    public int AccountID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Balance { get; set; }
    //các phương thức constructor để khởi tạo một đối tượng Account
    public Account(int accountID, string firstName, string lastName, decimal balance)
    {
        AccountID = accountID;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }
    // Display để hiển thị thông tin của tài khoản
    public void Display()
    {
        Console.WriteLine("Account ID: " + AccountID);
        Console.WriteLine("First Name: " + FirstName);
        Console.WriteLine("Last Name: " + LastName);
        Console.WriteLine("Balance: " + Balance);
    }

    // nhập thông tin tài khoản
    public static Account FromInput()
    {
        Console.Write("Account ID: ");
        int accountID = int.Parse(Console.ReadLine());

        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());

        return new Account(accountID, firstName, lastName, balance);
    }
}
//chứa danh sách các Account được lưu trữ trong một ArrayList
class AccountList
{
    private ArrayList accounts;

    public AccountList()
    {
        accounts = new ArrayList();
    }

    public void NewAccount()
    {
        Account account = Account.FromInput();
        accounts.Add(account);
    }


    public void SaveFile(string filename)
    {
        // Lưu danh sách tài khoản vào tệp
    }

    public void LoadFile(string filename)
    {
        // Tải danh sách tài khoản từ tệp
    }

    public void Report()
    {
        foreach (Account account in accounts)
        {
            account.Display();
        }
    }
}

//hàm main
class Program
{
    static void Main(string[] args)
    {
        AccountList accountList = new AccountList();

        while (true)
        {
            Console.WriteLine("1. New Account");
            Console.WriteLine("2. Save Accounts to File");
            Console.WriteLine("3. Load Accounts from File");
            Console.WriteLine("4. Report");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    accountList.NewAccount();
                    break;
                case 2:
                    Console.Write("Enter filename: ");
                    string filename = Console.ReadLine();
                    accountList.SaveFile(filename);
                    break;
                case 3:
                    Console.Write("Enter filename: ");
                    string Filename = Console.ReadLine();
                    accountList.LoadFile(Filename);
                    break;
                case 4:
                    accountList.Report();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
