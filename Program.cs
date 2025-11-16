/*using System;
class Programm
{
    static void Main()
    {
        int a = 50 , b = 50 ;

        if (a > b )
        Console.WriteLine("A is grater than B");
        else if (a<b)
        Console.WriteLine("b is grater than A");
        else
        Console.WriteLine("Both are equal");
    }
}*/

/*
using System;
class Programm
{
    static void Main()
    {
        int Num = 20;
        if (Num >= 10 && Num <= 50)
        Console.WriteLine("The Number is in The Range");
        else
        Console.WriteLine("Out of the Range");
    }
}
*/

/*

 using System;
 class Programm
{
    static void Main()
    {
       int Number = 0;
       if(Number > 0)
       Console.WriteLine(" the number is positive");
       else if(Number < 0)
       Console.WriteLine("The number is Negative ");
       else
       Console.WriteLine("The Number is Zero");

        
        
    }
*/
/*
using System;
class Program
{
    static void Main()
    {
        int a= 2, b = 4;
        int Max = 1;
        switch(Max)
        {
            case 1:
            Console.WriteLine("Addition" + (a+b)); break;
            case 2:
            Console.WriteLine("subtraction" + (a-b)); break;
            case 3:
            Console.WriteLine("Mul" + (a*b)); break;
            case 4:
            Console.WriteLine("Div" + (a/b)); break;
        }
    }
}
*/

//Gratest number
/*
using System;
class Program
{
    static void Main()
    {
       int a = 20 , b = 30 , c = 22;
       if(a >= b && a >= c)
       Console.WriteLine("the grater number a is  " + a ) ;
       else if (b >= a && b >= c)
       Console.WriteLine("The grater number b is  " + b);
       else
       Console.WriteLine("the grater number c is " + c); 
    }
}
*/
//Leep Year
/*
using System;
class Program
{
    static void Main()
    {
        int Year = 2024;
        if ((Year % 400 == 0) || (Year%4 ==0 && Year % 100 != 0))
        Console.WriteLine(Year + " is a leep year");
        else 
        Console.WriteLine(Year + (" is not a leep year"));

    }
}
*/
//
/*
using System;
class Program
{
    static void Main()
    {
        char ch = 'e';
        char lower = char.ToLower(ch);
        if(lower >=  'a' && lower <= 'z')
         if(lower=='a' || lower=='e' || lower == 'i' || lower == 'o' || lower == 'u')
         Console.WriteLine("The Given Ch "+ ch + " is vowel");
         else Console.WriteLine("THe Given Ch "+ ch+ " is Consonent");


    }
}

*/
/*
using System;

class Q13
{
   static void Main()
    {
         int N = 21;

         if (N % 2 ==0)
          if(N%4==0)
          Console.WriteLine("the number is Even and div by 4");
          else
          Console.WriteLine("The number is even but not Div by 4");
        else Console.WriteLine("The number is not even and not div by 4");
    }


}
*/

using System;
class Q14
{
    static void Main()
    {
        string UserName = "Hari" , UserPassword = "1234", InputUserName = "Hari", InputUserPassword="1234";
        if(InputUserName == UserName)
         if(InputUserPassword == UserPassword)
         Console.WriteLine("Login Successfull");
         else Console.WriteLine("InputUserPassword is worng");
        else Console.WriteLine("Invalid UserName");

        

        
    }
}
