// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int readint(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int Pow(int A, int B)
{
    int res = 1;
    for (int i = 1; i <= B; i++)
    {
        res *= A;
    }
    return res;
}


int number1 = readint("Imput number A: ");
int number2 = readint("Imput number B: ");
if (number2 < 0)
{
    System.Console.WriteLine("Wrong");
}
else if (number2 == 0)
{
    System.Console.WriteLine("1");
}
else
{
    System.Console.WriteLine(Pow(number1, number2));
}
