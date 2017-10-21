using System;
using System.Collections;
using System.Collections.Generic;

namespace Primero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre de participantes, hasta 11");
            
            //Entradas
            string nom;
            Console.WriteLine("Participante 1= ");
            nom = Console.ReadLine();
           
            string nom1; 
            Console.WriteLine("Participante 2= ");
             nom1= Console.ReadLine();
            
            string nom2;
            Console.WriteLine("Participante 3= ");
            nom2 = Console.ReadLine();
           
            string nom3;
            Console.WriteLine("Participante 4= ");
            nom3=Console.ReadLine();
            
            string nom4;
            Console.WriteLine("Participante 5= ");
            nom4=Console.ReadLine();

            string nom5;
            Console.WriteLine("Participante 6= ");
            nom5= Console.ReadLine();

            string nom6;
            Console.WriteLine("Participante 7= ");
            nom6=Console.ReadLine();

            string nom7;
            Console.WriteLine("Participante 8= ");
            nom7=Console.ReadLine();

            string nom8;
            Console.WriteLine("Participante 9= ");
            nom8=Console.ReadLine();

            string nom9;
            Console.WriteLine("Participante 10= ");
            nom9=Console.ReadLine();

            string nom10;
            Console.WriteLine("Participante 11= ");
            nom10=Console.ReadLine();

            //Funcion Random para definir al Ganador
            Random r = new Random(); //Objeto Random
             
            int aleat2 = r.Next(10); //Se define que se quiere un numero Random hasta 10
                 
            //Confeccion de Array con nombres Ingresados
            string[] nombres = new string[] { nom, nom1, nom2, nom3, nom4, nom5, nom6, nom7, nom8, nom9, nom10 };
            
            //Salida
            Console.WriteLine("El Ganador es... " + nombres[aleat2]);
            
            

            
        }
    }
}
