using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    //---------------------------------------Reverse String-----------------------------------
    /* internal class Program
     {
         static void Main(string[] args)
         {
             Console.WriteLine("Enter the Word");
             string str = Console.ReadLine();
             string rev = " ";
             int Len=0;
             Len = str.Length - 1;
             while (Len >= 0)
             {
                 rev = rev + str[Len];
                 Len--;
             }

             Console.WriteLine("Reverse word is {0}", rev);
             Console.ReadLine();
         }
     } */


    //-----------------------------------------PALINDRON-----------------------------------

    /*internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Word");
            string str = Console.ReadLine();
            string rev = " ";
            int Len = 0;
            Len = str.Length - 1;
            if( str !=null) 
            {
                for (int i = Len; i >= 0; i--)
                {

                    rev = rev + str[i];
                }
                if(rev==str)
                {
                    Console.WriteLine("Given Word is Palindrom:{0}",rev);
                }
                else
                {
                    Console.WriteLine("Given Word is not Palindrom");
                }

            }

            Console.ReadLine();
        }  */

    //---------------------------------FAVONACI SEREISE-----------------------------------
    /* internal class Program
     {
         static void Main(string[] args)
         {
         int a = 0, b = 1, c = 0,n=10;
         Console.Write("{0}  {1}",a,b);
         for(int i=2;i<=n;i++)
         {
             c = a + b;
             Console.Write(  "   {0}",c);
             a = b;
             b = c;
         }


             Console.ReadLine();
         }
     }*/

    //------------------------------ ArmstrongNumbers ----------------------------------- 

    /*  internal class Program
      {
          static void Main(string[] args)
          {
              Console.WriteLine("Enter the number-");
              int num = int.Parse(Console.ReadLine());
              int rem, temp, sum = 0;
              temp = num;
              while (num > 0)
              {
                  rem = num % 10;
                  sum = sum + (rem * rem * rem);
                  num = num / 10;
              }

              if (temp == sum)
                  Console.WriteLine("NUmber Is A Armstrong Number{0}" ,temp);
              else
                  Console.WriteLine( " Number Is Not A Armstrong Number {0}",temp);


              Console.ReadLine();
          }

      } */
    
    //-------------------------------------PRIME NUMBER-----------------------------------
   /* internal class Program
    {
        static void Main(string[] args)
        {
            bool notPrime = false;
            int j;

            Console.WriteLine("Enter your Target?");
            int target = Int32.Parse(Console.ReadLine());

            for (int i = 2; i <= target; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        notPrime = true;
                        break;
                    }
                }

                if (!notPrime)
                    Console.Write("{0} ", j);
                else
                    notPrime = false;


                Console.ReadLine();
            }


        }
    } */

    //----------------------------------- Factorial ------------------------------------------
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, Fact = 1;
            Console.WriteLine("Enter The Other Number = ");
            int num = int.Parse(Console.ReadLine());
            while (a <= num)
            {
                Fact = Fact * a;
                a++;
                Console.WriteLine("The Factorial Number is " + Fact);
            }
            Console.ReadLine();

        }
    }

                

}
