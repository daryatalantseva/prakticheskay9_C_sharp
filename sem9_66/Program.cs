// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = InputNumbers("Введите значение начало диапазона ");
int n = InputNumbers("Введите значение конца диапазона ");
int x = m;

if (m > n) 
{
  m = n; 
  n = x;
}

VivodSum(m, n, x = 0);

void VivodSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write("Сумма элементов= " + sum);
    return;
  }
  VivodSum(m, n - 1, sum);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int y = Convert.ToInt32(Console.ReadLine());
  return y;
}