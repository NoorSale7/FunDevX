namespace OOP.User
{
    internal class User
    {
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }


        //Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string GetUserInfo()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}, Phone Number: {PhoneNumber}";
        }

    }
    //Access Modifiers
    //public - accessible from anywhere
    //private - accessible only within the class
    //protected - accessible within the class and derived classes
    //internal - accessible only within the same assembly
    //protected internal - accessible within the same assembly and derived classes

}
