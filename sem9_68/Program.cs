/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 m = 2, n = 3 -> A(m,n) = 9 */


int m = VvodNumbers("Введите первое число диапазона ");
int n = VvodNumbers("Введите второе число диапазона ");

int Akk = f(m, n);

Console.Write("Функция Аккермана = " + Akk);

int f(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return f(m - 1, 1);
  else return f(m - 1, f(m, n - 1));
}

int VvodNumbers(string x) 
{
  Console.Write(x);
  int y = Convert.ToInt32(Console.ReadLine());
  return y;
}