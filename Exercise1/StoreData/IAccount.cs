namespace StoreData
{
    public interface IAccount
    {
        /// <summary>
        /// Check the balance
        /// </summary>
        decimal Balance { get; }

        /// <summary>
        /// Add money to this account
        /// </summary>
        /// <param name="amount">The amount to add</param>
        void Add(decimal amount);

        /// <summary>
        /// Remove money from this account
        /// </summary>
        /// <param name="amount">The amount to remove</param>
        void Remove(decimal amount);
    }
}