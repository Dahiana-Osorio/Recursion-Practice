using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_practice
{
    
    public class Sumnumbers
    {
        ////Exercise 2
        //Write a program in C# to find the sum of digits of a number using recursion. Go to the editor
        //Test Data : 
        //Input any number to find sum of digits: 25

        public int number;
          
            public int sumDigitos(int number)
            {
                if (number == 0)
                {
                    return 0;
                }
                else;
                return number % 10 + sumDigitos(number / 10);
            }

        
    }
}
