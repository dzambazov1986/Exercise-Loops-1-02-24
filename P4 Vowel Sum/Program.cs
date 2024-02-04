int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < n; i++)
{
    char c = char.Parse(Console.ReadLine());

    if (c == 'a')
    {
        sum += 1;
    }
    else if (c == 'e')
    {
        sum += 2;
    }
    else if (c == 'i')
    {
        sum += 3;
    }
    else if (c == 'o')
    {
        sum += 4;
    }
    else if (c == 'u')
    {
        sum += 5;
    }
}

Console.WriteLine(sum);
    

