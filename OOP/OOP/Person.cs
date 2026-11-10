namespace OOP.User
{
    internal class Person : User
    {
        public Person(int id, string name) : base(id, name) { }

        private DateTime _DateOfBirth { get; set; }

        public DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                if (value.Year > 2008 || value.Year > DateTime.Now.Year)
                {
                    throw new Exception("Under Age!");
                }
                else
                {
                    _DateOfBirth = value;
                }

            }
        }

        public string DateOfBirthString
        {
            get
            {
                return DateOfBirth.ToString("dd/MM/yyyy");
            }
        }

        public string GetPersonInfo()
        {
            return $"{GetUserInfo()}, Date Of Birth: {DateOfBirthString}";
        }
    }
}
