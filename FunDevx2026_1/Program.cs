internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Name :");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Your Age :");
        string ageInput = Console.ReadLine();
        int? age = string.IsNullOrEmpty(ageInput) ? null : Convert.ToInt16(ageInput);
        string result = "";

        if (string.IsNullOrEmpty(name) || name.Length < 2)
        {
            result = "Name is not provided";
        }
        else if (name.Length == 2)
        {
            result = $"{name} (Too Short) ,";
        }
        else
        {
            result = $"{name},";
        }

        if (age != null)
        {
            if (age < 18)
            {
                result = $"{result} Young";
            }
            else
            {
                result = $"{result} Adult";
            }
        }
        else
        {
            result = $"{result} ,Age not provided";
        }

        Console.WriteLine(result);
    }
}