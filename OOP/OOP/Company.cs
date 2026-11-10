namespace OOP.User
{
    internal class Company : User
    {
        public Company(int id, string name) : base(id, name) { }

        public string TaxNumber { get; set; }
    }
}
