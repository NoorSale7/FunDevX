List<int> numbers= new List<int> { 1, 2, 1, 2, 5, 6, 6, 3 };
/* First Solve
foreach (var item in numbers)
{
    int counter = 0;
    foreach (var item2 in numbers)
    {
        if (item == item2)
        {
            counter++;
        }

        if(counter > 1)
        {
            break;
        }
    }
    if (counter == 1)
    {
        Console.WriteLine(item);
        break;
    }
}
*/

// Second Solve
foreach (var item in numbers)
{
    int count = numbers.Count(x => x == item);
    if( count ==1)
    {
        Console.WriteLine(item);
        break;
    }
}