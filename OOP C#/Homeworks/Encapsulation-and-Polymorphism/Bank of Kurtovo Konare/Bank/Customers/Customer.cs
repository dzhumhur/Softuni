namespace Bank_of_Kurtovo_Konare.Bank.Customers
{
    public abstract class Customer
    {
        private string name;
        private int id;

        protected Customer(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name { get; set; }

        public int Id { get; set; }
    }
}
