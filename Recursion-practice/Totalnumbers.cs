using System;

namespace Recursion_practice
{
    public class Totalnumbers
    {
        ////Exercise 1
        //rite a program in C# to calculate the sum of numbers from 1 to n using recursion. Go to the editor
        //Test Data : 
        //Input the last number of the range starting from 1 : 5 

        public int n1;
     
        public int Totalnumber(int n1)
        {
            int cont;
            if (n1 == 0)
            {
                return 0;
            }
            else
            {
                cont = n1 + Totalnumber(n1 - 1);
            }
            return cont;
        }
    }
}
