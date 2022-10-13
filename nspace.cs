int N=1234567890; // Заданное число
if (N < 0)
     Console.WriteLine($"Число {N} отрицательно, корня квадратного не имеет");
else
{
        int sqN = (int) Math.Sqrt(N); // Получение квадратного корня
        if (sqN*sqN == N)
              Console.WriteLine($"Число {N}, его корень квадратный {sqN}");
        else
        {
             int n1 = sqN*sqN;
             int n2 = (sqN+1)*(sqN+1);
             if ((N - n1) < (n2 - N))
                  Console.WriteLine($"Число {N}, ближайшее число имеющее целочисленный корень квадратный {n1}");
             else
                  Console.WriteLine($"Число {N}, ближайшее число имеющее целочисленный корень квадратный {n2}");
          }
}
