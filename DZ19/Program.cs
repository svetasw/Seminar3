﻿Console.Write("Input number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Your number: {number} - palindrome.");
  }
  else Console.WriteLine($"Your number: {number} - no palindrome.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Enter the correct number");

