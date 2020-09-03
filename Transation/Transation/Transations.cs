using System;
using System.Collections.Generic;
using System.Text;

namespace Transation
{
    class Transations
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }
        public Transations(decimal amount,DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Note = note;
        }

    }
}
