﻿Console.Write("Enter number: ");
int cube = Convert.ToInt32(Console.ReadLine());
void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}
void PrintArray(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 
int[] array = new int[cube+1];
Cube(array);
PrintArray(array);