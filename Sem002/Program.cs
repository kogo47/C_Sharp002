// //переаброзуем предыдущий Sem001 в метод void
// void randomNumder()
// {
//     int number = new Random().Next(10, 100);
//     Console.Write(number+ "->");
//     int num1 = number /10;
//     int num2 = number %10;
//     if (num1>num2)
//         {Console.WriteLine(num1);}
//     else
//         {Console.WriteLine(num1);}

//     return;
// }
// Console.WriteLine("Введите минимальное число диапазона: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число диапазона: ");
// int end = Convert.ToInt32(Console.ReadLine());
// randomNumber(start, end);


// void randomNumder(){
//    int number = new Random().Next(10, 100);Console.WriteLine(number);
// Console.Write(number + "-> "); 
// if (number / 10 > number % 10){//если num1 будет больше num2
//     Console.WriteLine(number / 10);// то тогда тогда выводим num1 
// }
// else//иначе, если num1 не больше num2 то тода-
// {
//    Console.WriteLine(number % 10);//выводим num2
// }
// }
// for (int i = 0; i < 10; i++)//вызов цикла
// {
//     randomNumder();
// }



// // первый способ объявить метод void
//     //название метода
// void randomNumder(){
//    int number = new Random().Next(10, 100);Console.WriteLine(number);
// Console.Write(number + "-> "); 
// if (number / 10 > number % 10){//если num1 будет больше num2
//     Console.WriteLine(number / 10);// то тогда тогда выводим num1 
// }
// else//иначе, если num1 не больше num2 то тода-
// {
//    Console.WriteLine(number % 10);//выводим num2
// }
// }
//     randomNumder();




//второй способ объявить метод void
//     //название метода
void randomNumder(int min, int max){//принимает свои значения переменных
   int number = new Random().Next(min, max+1);Console.WriteLine(number);
Console.Write(number + "-> "); 
if (number / 10 > number % 10){//если num1 будет больше num2
    Console.WriteLine(number / 10);// то тогда тогда выводим num1 
}
else//иначе, если num1 не больше num2 то тода-
{
   Console.WriteLine(number % 10);//выводим num2
}
}
Console.WriteLine("Введите минимальное число диапазона: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число диапазона: ");
int end = Convert.ToInt32(Console.ReadLine());

randomNumder(start, end);//передаем аргумента переменных методу