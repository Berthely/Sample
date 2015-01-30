using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texto
{
    //construir un metodo que con una linea de texto ubique una palabra "x" y que diga
    //en que posicion empieza
    
    class Texto
    {
        public void declaracion()
        {
            string frase;
            string buscar;
            
            int x;
            int z;
            
            frase = "el baile del la mona sensual";
            buscar = "baile";


            Console.WriteLine("Programa que indica la posicion de la palabra");
            Console.WriteLine();
            Console.ReadLine();

            //escribe la frase completa letra por letra
            
            Console.Write("La frase a buscar es      :");
            for (x = 0; x < frase.Length; x++)

            Console.Write(frase[x]);
            Console.WriteLine();
            Console.ReadLine();
            
            //escribe la palabra a buscar letra por letra

            Console.Write("La palabra a buscar es    :");
            for (z = 0; z < buscar.Length; z++)
            
            Console.Write(buscar[z]);
            Console.WriteLine();
            Console.ReadLine();
            
            int bus = buscar.Length;
            int fra = frase.Length;
            int i=0;
            int j = 0;
            int y = i;

            
            for (i = 0, j = 0; i < frase.Length; i++)

                if ((frase[i] == buscar[j]) && (j == bus))

                {
                    j++;
                    Console.Read();
                    Console.WriteLine(j);

                }

                    
            
            Console.ReadLine();
            Console.WriteLine("Fin");
            Console.ReadLine();


        }


    }
}

