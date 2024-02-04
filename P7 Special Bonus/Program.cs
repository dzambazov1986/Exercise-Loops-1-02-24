int stopNumber = int.Parse(Console.ReadLine());

int number;
int lastNumber = 0;
bool numberEnered = false;

while (true)
{
    number = int.Parse(Console.ReadLine());
    if (number == stopNumber)
    {
        break;
    }
    lastNumber = number;
    numberEnered = true;
}
if (numberEnered)
{
    lastNumber = lastNumber + lastNumber / 5;
    Console.WriteLine(lastNumber);
}
else
    Console.WriteLine(stopNumber);
