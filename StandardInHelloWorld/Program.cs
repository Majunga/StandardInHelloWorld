string? s;
Console.WriteLine("Enter text. Enter a blank line to exit.");
while ((s = Console.ReadLine()) is not null)
{
    if (string.IsNullOrWhiteSpace(s))
    {
        break;
    }

    Console.WriteLine(s);
}