using System.Globalization;

bool Wha;
string f;
double a, b, c, d;
Console.WriteLine("Введите 4 числа");
do
{
    f = Console.ReadLine();
    Wha = double.TryParse(f, out a);
    if (Wha == false)
    {
        Console.WriteLine("Введите Число.");
    }
}
while (Wha == false);
do
{
    f = Console.ReadLine();
    Wha = double.TryParse(f, out b);
    if (Wha == false)
    {
        Console.WriteLine("Введите Число.");
    }
}
while (Wha == false);
do
{
    f = Console.ReadLine();
    Wha = double.TryParse(f, out c);
    if (Wha == false)
    {
        Console.WriteLine("Введите Число.");
    }
}
while (Wha == false);
do
{
    f = Console.ReadLine();
    Wha = double.TryParse(f, out d);
    if (Wha == false)
    {
        Console.WriteLine("Введите Число.");
    }
}
while (Wha == false);
if((a == b) && (a == c) && (a == d))
{
    Console.WriteLine($"Числа равны");
}    
else
{
    Console.WriteLine("Числа не равны");
}