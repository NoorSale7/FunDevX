Console.WriteLine("Enter the size of the array: ");

int arraySize = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"Enter number {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int max = numbers[0];

int evenCounter = 0;

int evenSum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }

    if (numbers[i] % 2 == 0)
    { 
    evenCounter++;
        evenSum += numbers[i];
    }

}
Console.WriteLine($"The maximum number is: {max}");
Console.WriteLine($"The number of even numbers is: {evenCounter}");
Console.WriteLine($"The sum of even numbers is: {evenSum}"); 