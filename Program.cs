// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите значение переменной a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение переменной b");
int b = Convert.ToInt32(Console.ReadLine());

//Условие a > b
if (a>b)
{
Console.WriteLine("a " + a + " больше, чем b " + b);
 
}
else
{
   Console.WriteLine("b " + b + " больше, чем a " + a); 
}

// End