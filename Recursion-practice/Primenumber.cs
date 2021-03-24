using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_practice
{   
    //Exercise 3
    //Write a program in C to check a number is a prime number or not using recursion. Go to the editor
    //Test Data : 
	//Input any positive number : 7 
    class Primenumber
    {
        public int numPrim;
        public int divider = 2;
        public bool numPrime(int numPrim, int divider)
        {
            if (numPrim / 2 < divider)
            {
                return true;
            }
            else
            {
                if (numPrim % divider == 0)
                {  
                    return false;
                }
                else
                {
                    return numPrime(numPrim, divider + 1);
                }
            }
        }
    }
}
