//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSum(int limit)
{
    int sum=0;
    while(limit>0)
    {
       int res;
       limit = Math.DivRem(limit, 10, out res);
       sum+=res;
    }
    return sum;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Введите число А: ");
Console.WriteLine($"Сумма чисел в числе {num} равна {GetSum(num)}");