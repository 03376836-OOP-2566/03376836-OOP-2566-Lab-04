int? a = null;
int? b = 10;

if (a.HasValue)
{
    Console.WriteLine($"a is {b.Value}");
}
else
{
    Console.WriteLine("a does not have a value");
}
if (b.HasValue)
{
    Console.WriteLine($"b is {b.Value}");
}
else
{
    Console.WriteLine("b does not have a value");
}