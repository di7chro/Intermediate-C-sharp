using StoreData;

namespace Exercise1
{
    public class Account : IAccount
    {
        private decimal balance = 0;

        public decimal Balance
        {
            get { return balance; }
        }

        public void Add(decimal amount)
        {
            balance += amount;
        }

        public void Remove(decimal amount)
        {
            if (!(amount > balance))
            {
                balance -= amount;
            }
        }
    }
}