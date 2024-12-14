// See https://aka.ms/new-console-template for more information
Console.WriteLine("For Loop");

//      FizzBuzz Challenge

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i}-FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i}-Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i}-Buzz");
    else
       Console.WriteLine(i);
    

}



//  !st way
//string[] names = { "Alex", "Eddie", "David", "Michael" };
//for (int i = 0; i < names.Length; i++)
//    if (names[i] == "David") names[i] = "Sammy";


//foreach (var name in names) Console.WriteLine("foreach======>>>>>>>"+name);

//  2nd way

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}



