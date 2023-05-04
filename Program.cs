// Homework 3. Task 1.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Homework 3. Task 1.");
// Console.Write("Enter number: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Your number: {number} - is Pallindromme.");
//   }
//   else Console.WriteLine($"Your number: {number} - is NOT Pallindromme.");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Enter correct number: ");


// Homework 3. Task 2.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Homework 3. Task 2.");
// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");
// int Coordinate(string coorName, string pointName){
//     Console.Write($"Enter coordinate {coorName} of the point {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }
// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }
// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
// Console.WriteLine($"Length of segment:  {segmentLength}");

// Homework 3. Task 3.
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = ReadInt("Enter N: ");
for (int i = 1; i <= number; i++){
    Console.Write($"{i * i * i}, ");
}

int ReadInt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}