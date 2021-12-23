//int first;
string first = Console.ReadLine();
int n1 = Convert.ToInt16(first);
//int second;
string second = Console.ReadLine();
int n2 = Convert.ToInt16(second);
//int third;
string third = Console.ReadLine();
int n3 = Convert.ToInt16(third);

int max = n1;

if (n1 > max) max = n1;
if (n2 > max) max = n2;
if (n3 > max) max = n3;

Console.Write("max = ");
Console.WriteLine(max);