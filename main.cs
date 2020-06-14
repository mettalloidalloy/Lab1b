using System;

class MainClass {
  public static void Main (string[] args) {
    
int FirstNo, SecondNo, Sum, Product, Difference, Quotient, Remainder;

        Console.Write("Enter a number: ");
        FirstNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        SecondNo = Convert.ToInt32(Console.ReadLine());

        Sum = FirstNo + SecondNo;
        Product = FirstNo * SecondNo;
        Difference = FirstNo - SecondNo;
        Quotient = FirstNo / SecondNo;
        Remainder = FirstNo % SecondNo;

        Console.Write("\nSum = " + Sum);
        Console.Write("\nProduct =  " + Product);
        Console.Write("\nDifference = " + Difference);
        Console.Write("\nQuotient = " + Quotient);
        Console.Write("\nRemainder = " + Remainder);
        Console.ReadLine();

  }
}