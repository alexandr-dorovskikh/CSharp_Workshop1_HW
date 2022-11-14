Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a < b) {
    max = b;
}

Console.Write("max = ");
Console.WriteLine(max);