int randomNumder(int min, int max)
{
    int number = new Random().Next(min, max+1);
    Console.Write(number+ "-> ");
    int num1 = number / 10;
    int num2 = number % 10;
    //Console.WriteLine(number + " " + num1 + " " + num2);
    if (num1 > num2)
        return num1;
    else
        return num2;
}
Console.Write("Введите минимальное число диапазона: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int end = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("максимальная цифра из случайного двухзначного числа: " + randomNumder(start, end));
