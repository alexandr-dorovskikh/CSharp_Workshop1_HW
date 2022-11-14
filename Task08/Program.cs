Console.Write("Enter number N: ");
int num = Convert.ToInt32(Console.ReadLine());

int counter = 2;
while (counter <= num)
{
    Console.Write(counter);
    
    counter += 2;

    if (counter <= num)
    {
        Console.Write(", ");
    }

    
}