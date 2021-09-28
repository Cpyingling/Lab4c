/*Author Charles Yingling     Date 9/27/2021
Get a number as input. Write logic to find if a number is a prime number. Display the result if the number is prime or non-prime.*/
using System;

class Program {
  public static void Main(string[] args) {  
    int num;
      //get number as input
        Console.WriteLine("Enter a number to check if it is prime or not:");
          num = Convert.ToInt32(Console.ReadLine());
  //logic to find if number is prime or not
    for (int x = 2; x <= num / 2; x++) {
      if (num % x == 0) {
            Console.WriteLine($"{num} is not a prime number"); //tested and verified with 18
            return;
        }
    }
            Console.WriteLine($"{num} is a prime number"); //tested and verified with 5   
     }  
   }