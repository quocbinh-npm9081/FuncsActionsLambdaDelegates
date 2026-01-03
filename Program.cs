// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var numbers = new  List<int>{1,2,3,4};
Func<int, bool> FuncIsAnyLargerThan10 = IsAnyLargerThan10;
Console.WriteLine($"IsAnyLargerThan10 : {IsAny(numbers, FuncIsAnyLargerThan10).ToString()}");
Console.WriteLine($"IsAnyEvenLargerThan10 : {IsAny(numbers, x => x % 2 == 0).ToString()}");
Console.ReadKey();

bool IsAnyLargerThan10(int x) =>  x > 10;
//
// bool IsAnyLargerThan10(IEnumerable<int> numbers)
// {
//     foreach (var number in numbers)
//     {
//         if (number > 10) return true;
//     }
//     return false;
// }

bool IsAnyEvenLargerThan10(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        if (number % 2 == 0) return true;
    }
    return false;
}

bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number)) return true;
    }
    return false;
}