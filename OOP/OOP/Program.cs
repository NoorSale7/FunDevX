using OOP.User;

Person person = new Person(1, "John Doe");
person.Email = "test@test.com";
person.PhoneNumber = "1234567890";
person.DateOfBirth = new DateTime(2000, 1, 1);
Console.WriteLine(person.GetPersonInfo());