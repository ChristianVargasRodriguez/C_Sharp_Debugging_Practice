Console.WriteLine("----------- Challenge 1 -----------");
// Challenge 1
bool amProgrammer = true;
int Age = 27;
List<string> Names = new List<string>();
string Name = "Monica";
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName";

Console.WriteLine(amProgrammer);
Console.WriteLine(Age);
Console.WriteLine(Name);
Console.WriteLine(MyName);


Console.WriteLine("----------- Challenge 2 -----------");
// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count -1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}

Console.WriteLine("----------- Challenge 3 -----------");
// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i);
}


Console.WriteLine("----------- Challenge 4 -----------");
// Challenge 4
List<int> EvenMoreNumbers = new List<int>() {3,6,9,12,14};
// foreach(int num in EvenMoreNumbers)
for (int num = 0; num < EvenMoreNumbers.Count; num++)
{
    if(EvenMoreNumbers[num] % 3 == 0)
    {
        EvenMoreNumbers[num] = 0;
        Console.WriteLine(EvenMoreNumbers[num]);
    }
    else
    {
        Console.WriteLine(EvenMoreNumbers[num]);
    }
}


Console.WriteLine("----------- Challenge 5 -----------");
// Challenge 5
// What can we learn from this error message?
string MyString = "superduberawesome";
MyString = "p";
Console.WriteLine(MyString);



Console.WriteLine("----------- Challenge 6 -----------");
// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum <= 12)
{
    Console.WriteLine(randomNum);
    Console.WriteLine("Hello");
}

