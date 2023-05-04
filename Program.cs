// Homework 3. Task 1.

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Homework 3. Task 1.");
Console.Write("Enter number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Your number: {number} - is Pallindromme.");
  }
  else Console.WriteLine($"Your number: {number} - is NOT Pallindromme.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Enter correct number: ");
