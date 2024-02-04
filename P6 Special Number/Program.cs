int number = int.Parse(Console.ReadLine());

int tempNumber = number;
bool isSpecialNumber = true;

while (tempNumber > 0)
{
    int curentLastDigit = tempNumber % 10;
    tempNumber /= 10;
    if (number % curentLastDigit != 0)
    {

        isSpecialNumber = false;
        break;
    }
}
if (isSpecialNumber)
{
    Console.WriteLine($"{number} is special"); 
}
else
    Console.WriteLine($"{number} is not special");