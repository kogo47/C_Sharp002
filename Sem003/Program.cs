//еще один метод отличии void 
// int randomNumder(int min, int max)
// {
//     int number = new Random().Next(min, max+1);
//     Console.Write(number+ "-> ");
//     int num1 = number / 10;
//     int num2 = number % 10;
//         if (num1 > num2)
//         return num1;
//     else
//         return num2;
// }
// Console.Write("Введите минимальное число диапазона: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число диапазона: ");
// int end = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("максимальная цифра из случайного двухзначного числа: " + randomNumder(start, end));
// randomNumder(start, end);




//int- тип значения который будет возвращаться
//еще один метод отличии void, return метод который возвращает
                //аргументы
// int SumTwoNumbers(int a, int b){//метод нахождения двух чисел
//     int sum = a + b;// a - b если хотим разность 
//     return sum;
// }
// for (int i = 0; i < 3; i++)//задали цикл
// {
//     Console.Write("Введите первое число: ");          //осн-   
// int number1 = Convert.ToInt32(Console.ReadLine());//авн
// Console.Write("Введите второе число: ");          //ая про-
// int number2 = Convert.ToInt32(Console.ReadLine());//гра-
// //результат переменной                            ////мма!
// //int s = SumTwoNumbers(number1, number2);          
//                                          //упрастили результат переменной 
// Console.WriteLine("Сумма двух чисел: " + SumTwoNumbers(number1, number2));
//                 //разность двух чисел 
// }


// Console.Write("Введите первое число: ");          //осн-   
// int number1 = Convert.ToInt32(Console.ReadLine());//авн
// Console.Write("Введите второе число: ");          //ая про-
// int number2 = Convert.ToInt32(Console.ReadLine());//гра-
// //результат переменной                            ////мма!
// //int s = SumTwoNumbers(number1, number2);          
//                                          //упрастили результат переменной 
// Console.WriteLine("Сумма двух чисел: " + SumTwoNumbers(number1, number2));
//                 //разность двух чисел 



//так тоже можно, но лучше отдельно запрашивать в программе
int SumTwoNumbers(){//метод нахождения двух чисел
    Console.Write("Введите первое число: ");          //осн-   
    int number1 = Convert.ToInt32(Console.ReadLine());//авн
    Console.Write("Введите второе число: ");          //ая про-
    int number2 = Convert.ToInt32(Console.ReadLine());
    return number1 + number2;// a - b если хотим разность
}
for (int i = 0; i < 3; i++)//задали цикл
{
    
//int s = SumTwoNumbers(number1, number2);          
                                         //упрастили результат переменной 
Console.WriteLine("Сумма двух чисел: " + SumTwoNumbers());
                 //разность двух чисел 
}