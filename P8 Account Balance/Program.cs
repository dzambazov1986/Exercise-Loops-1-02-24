string input = Console.ReadLine();
double balance = 0;

while (input != "End")
{
    double amount = double.Parse(input);

    if (amount > 0)
    {
        Console.WriteLine($"Increase: {amount:F2}");
    }
    else
    {
        Console.WriteLine($"Decrease: {amount:F2}");
    }
    balance += amount;
    input = Console.ReadLine();
}
Console.WriteLine($"Balance: {balance:F2}");

