int counter = 1;
int max = int.MinValue;
while (counter <= 3)
{
    Console.Write("Enter number:");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > max) {max = num;}

    counter++;
}

Console.Write("max = ");
Console.WriteLine(max);