Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());
{
    if(a < b +c)
    Console.WriteLine("Треугольник существует ");
    else
        if(b < a + c)
    Console.WriteLine("Треугольник существует ");
    
    else if(c < a + b)
    Console.WriteLine("Треугольник существует ");
    else
    Console.WriteLine("Треугольник не существует ");
}
Console.WriteLine(" ");
