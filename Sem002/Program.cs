void randomNumder()
{
    int number = new Random().Next(10, 100);
    Console.Write(number+ "->");
    int num1 = number /10;
    int num2 = number %10;
    //Console.WriteLine(number + " " + num1 + " " + num2);
    if (num1>num2)
        {Console.WriteLine(num1);}
    else
        {Console.WriteLine(num1);}

    return;
}
Console.WriteLine("Введите минимальное число диапазона: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число диапазона: ");
int end = Convert.ToInt32(Console.ReadLine());
randomNumber(start, end);
