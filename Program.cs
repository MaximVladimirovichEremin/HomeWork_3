// // Домашняя работа семинар 3 

// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

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


// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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

// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

// // Вводим функцию 
// double Avarage(double x1, double y1, double x2, double y2){
//   // Вводим новую переменную 
//   double distance = 0; 
//   // Формула нахождения растояния между двумя точками 
//   distance = Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2 - y1, 2));
//   Console.WriteLine("Растояние между двумя точками : "+ distance);
//   return distance;
// }

// Console.Write("Введите координаты x1: ");
// double x1 = Convert.ToDouble (Console.ReadLine());

// Console.Write("Введите координаты y1: ");
// double y1 = Convert.ToDouble (Console.ReadLine());

// Console.Write("Введите координаты x2: ");
// double x2 = Convert.ToDouble (Console.ReadLine());

// Console.Write("Введите координаты y2: ");
// double y2 = Convert.ToDouble (Console.ReadLine());

// Avarage(x1, y1, x2, y2);

