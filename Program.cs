//  Домашняя работа семинар 3 

//  Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Square(int num){
//     int current = 1;
//     while(current <= num){
//     // поправил, теперь находит куб.     
//     Console.Write(current*current*current + ", ");
//     // Счетчик 
//     current++;}
    
// }
// Console.Write("Введите любое число от 1 до ...: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 1 )
// {
//    Console.WriteLine("Число не соответствует требованиям"); 
// }
// else
// Square(num);


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrome5(int num){
 
//  // определяем кажую цифры 
//  int a = num / 10000;
//  int b = num % 10000 / 1000;
//  int c = num % 1000 / 100;
//  int d = num % 100 / 10;
//  int e = num % 10;
//  // сравниваем (1-5),(2-4) цифры
//  if (a == e && b == d)
//  {
//  Console.WriteLine("Число является палиндромом"); 
//  }
//  else
//  Console.WriteLine("Число не является палиндромом"); 
//  }


// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// // Проверка на правильность ввода
// if (num < 9999 || num > 99999){
//     Console.WriteLine("Число не соответствует требованиям");
// }
// else
// Palindrome5(num);

