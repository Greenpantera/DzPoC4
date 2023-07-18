//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetStepen(int count, int i)
{
   int result=1;
   while(i>0)
   {
    result=result*count;
    i--;
    }
    return result; 
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Введите число А: ");
int stepen = GetInfo("Введите число B: ");
Console.WriteLine($"Число {num} в степени {stepen} равна {GetStepen(num, stepen)}");