using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Ejercicio_1
    {
        public void Imprimir()
        {                                          
            Console.WriteLine();
                              
            for (int i = 0; i<6; i++)
                
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    
                }
                    Console.WriteLine("&");                                               
            }                         
        }
        
        public void  Imprimir_2()
        {
  
                              
            for (int i = 6; i>0; i--)
                
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("&");
                    
                }
                    Console.WriteLine("*");                                               
            }                          
                
        }              
    }
}
