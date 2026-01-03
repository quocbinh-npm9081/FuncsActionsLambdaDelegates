// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
ProcessString processString1 = TrimTo5Letters;
ProcessString processString2 = ToUpper;
Console.WriteLine($"{processString1("Hello, World!")}");
Console.WriteLine($"{processString2("Hello, World!")}");
Console.ReadKey();

string TrimTo5Letters(string input)
{
    return input.Substring(0, 5);
}

string ToUpper(string input)
{
    return input.ToUpper();
}

delegate string ProcessString(string input);