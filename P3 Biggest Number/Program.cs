int n = int.Parse(Console.ReadLine());

int maximumNumber = int.MinValue;
for (int i = 0; i < n; i++)
{
   int curentNumber = int.Parse(Console.ReadLine());
   if (curentNumber > maximumNumber)
    {
        maximumNumber = curentNumber;
    }
}
Console.WriteLine(maximumNumber);