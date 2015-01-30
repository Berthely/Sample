using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numero
{

    //hacer un programa que de una cadena de texto, vaya checando si existe un
    //numero lo imprima y lo multiplique por su mismo numero

    class Numero
    {
        public void number()
        {
            string alumnos;
            alumnos = "hugo 8paco y 8luis";

            string alumnos2;
            alumnos2= alumnos;

            Console.WriteLine(alumnos);
            Console.ReadLine();

            //for normal atraves del array

            char[] student=alumnos.ToArray();
            
            int i;
            int res;
            int x;          
                                
            Console.WriteLine("Imprime student" + student);                        
            Console.WriteLine("La longitud de alumnos es " );

            for (i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine(char.IsNumber(alumnos[i]) + " " + i);

                if (char.IsNumber(alumnos[i]))
                {
                    Console.WriteLine(alumnos[i]);
                    alumnos = alumnos2;
                    Console.WriteLine("imprimiendo alumnos2   :" + alumnos2[i]);
                    Console.ReadLine();
                    
                    //x = Int32.Parse(alumnos2);
                    
                    Convert.ToInt32(alumnos2);
                    x = alumnos2;
                    res = (x * x);
                    Console.WriteLine(res);                    
                }
                
                Console.ReadLine();
            }        
        }

    }
}
