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
            int i;
            int j;
            int w;
            frase = "perro que come huevo";
            buscar = "huevo";
                            
            
            Console.WriteLine("Programa que indica la posicion de la palabra");
            Console.WriteLine();
            Console.ReadLine();

            for (i=0; i<frase.Length; i++)

            Console.Write(frase[i] + " ");
            Console.WriteLine();
            Console.ReadLine();

            for (j=0; j<buscar.Length; j++)
            Console.Write(buscar[j]+" ");
            Console.ReadLine();
                     
            for (w=0; w<=buscar.Length; w++)                
                    if (buscar[w] == frase[w])

                    {                                                
                        Console.WriteLine(frase[w]);
                        Console.ReadLine();
                    }
                
            
        }

    }
}
