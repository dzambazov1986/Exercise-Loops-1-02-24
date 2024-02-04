int n = int.Parse(Console.ReadLine());

int numsDivided2 = 0;
int numsDivided3 = 0;
int numsDivided4 = 0;

for (int i = 0; i < n; i++)
{
    int curentNumber = int.Parse((Console.ReadLine()));
    if (curentNumber % 2 == 0)
    {
        numsDivided2++;
    }
  if (curentNumber % 3 == 0)
    {
        numsDivided3++;
    }
  if (curentNumber % 4 == 0) 
    { 
    numsDivided4++; 
    }
}
double numsDivides2Percent = (double)numsDivided2 / n * 100;
double numsDivides3Percent = (double)numsDivided3 / n * 100;
double numsDivides4Percent = (double)numsDivided4 / n * 100;
Console.WriteLine($"{numsDivides2Percent:F2}%");
Console.WriteLine($"{numsDivides3Percent:F2}%");
Console.WriteLine($"{numsDivides4Percent:F2}%");