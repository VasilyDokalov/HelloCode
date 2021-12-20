string a = Console.ReadLine();
int b = Convert.ToInt32(a);
b = b * b;
string c = Console.ReadLine();
int d = Convert.ToInt32(c);
if(b == d)
{
    Console.WriteLine("Первое является квадратом второго");
}
else
{
    Console.WriteLine("Первое не является квадратом второго");
}