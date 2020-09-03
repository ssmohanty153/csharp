using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Transation
{
    class BankAccount
    {
        public string accountNumber { get; }
       
        public string owner { get; set; }
        public decimal balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransation)
                {
                    balance += item.Amount;
                }
                return balance;

            }
        }
        private static int accountNumberSeed = 123456789;


        private List<Transations> allTransation = new List<Transations>();


        public void MakeDeposite ( decimal amount,DateTime date, string note)
        {
            if( amount<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "amount most be in posative");
            }
            var depositeAmount = new Transations(amount, date, note);
         allTransation.Add(depositeAmount);
        }


        public void MakeWithdraw ( decimal amount,DateTime date, string note )
          {
            if(amount<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "amount most be posative");
            }
            if(balance-amount==0)
            {
                throw new InvalidOperationException("not sofficient fond is present in account");
            }
            var newWithDrow = new Transations(-amount, date, note);
            allTransation.Add(newWithDrow);



        
        }


        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransation)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Note}");
            }

            return report.ToString();
        }
        //constructer

        public BankAccount(string name,decimal initialBalance)
        {
            this.owner = name;
            MakeDeposite(initialBalance, DateTime.Now, "initial Balance");
           // this.balance = initialBalance;
            this.accountNumber = accountNumberSeed.ToString();
            accountNumberSeed++;

        }
        
        

        


    }
}
