// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

int n = InputNumbers("Введите верхнюю границу интервала ");
int count = 2;
VivodNumber(n, count);
Console.Write(1);

void VivodNumber(int n, int count)
{
  if (count > n) return;
  VivodNumber(n, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int y = Convert.ToInt32(Console.ReadLine());
  return y;
}
