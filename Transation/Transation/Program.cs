using System;

namespace Transation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("subhransu",1000);
       
            
            Console.WriteLine($"The bank account holder name is {account.owner} and accountnumber is {account.accountNumber} and balance {account.balance}");
            account.MakeDeposite(5000, DateTime.Now, "send to friend");
            Console.WriteLine(account.balance);
            account.MakeWithdraw(4000, DateTime.Now, "sister");
            Console.WriteLine(account.balance);

            Console.WriteLine(account.GetAccountHistory());
            try
            {
                var invalidTran = new BankAccount("Invalid", -1);

            }
            catch(ArgumentOutOfRangeException e )
            {
                Console.WriteLine("negative balance");
                Console.WriteLine(e.ToString());

            }

            try
            {
                account.MakeWithdraw(3000, DateTime.Now, "try to extraAmountWithdrow");

            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("try to overDraw");
                Console.WriteLine(e.ToString());

            }
            Console.ReadLine();

        }


    }
}
