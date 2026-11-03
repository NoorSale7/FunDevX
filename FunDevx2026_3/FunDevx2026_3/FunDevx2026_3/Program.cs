List<string> strings = new List<string> {
"Hello",
"World",
"C#",
"Programming",
"Language",
"Fun",
"Development"
};

List<string> moreStrings = new List<string> {
"Additional",
"Strings",
"Here"
};

strings.AddRange(moreStrings);

foreach (var str in strings)
{
    Console.WriteLine(str);
}

bool containsCSharp = strings.Contains("C#");
bool any = strings.Any(s => s == "C#");

var newList = strings.Where(s => s.Length > 5).ToList();
string firstItem = strings.FirstOrDefault(x => x.Length > 5);
string lastItem = strings.LastOrDefault(x => x.Length > 5);
string singleItem = strings.SingleOrDefault(x => x == "C#");