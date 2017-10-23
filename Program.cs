using System;
using System.Collections;
using System.Collections.Generic;

namespace Primero
{
    class Program
    {
        static void Main(string[] args)
        {

            List <Persona> listaParticipantes = new List<Persona>();
            Console.WriteLine("Ingrese nombre de participantes, hasta 11");
            string participante = Console.ReadLine();
            while(!participante.ToLower().Equals("salir"))
            {
                //Creamos objeto 
                Persona nuevaPersona = new Persona();
                nuevaPersona.Nombre = participante;
                listaParticipantes.Add(nuevaPersona);
                Console.WriteLine("Ingrese otro");
                participante=Console.ReadLine();
            }
           
            //Funcion Random para definir al Ganador
            Random r = new Random(); //Objeto Random
             
            int aleat2 = r.Next; //Se define que se quiere un numero Random hasta 10
                 
            
            //Salida
            Console.WriteLine("El Ganador es... " + listaParticipantes[aleat2]);

            int decision;
            Console.WriteLine("Ingrese 1 si quiere ver la lista de participantes");
            decision = int.Parse(Console.ReadLine());
            while (decision == 1)
            {
                  foreach(string item in listaParticipantes)
                  Console.WriteLine(item);
            
            }
            
            

            
        }
    }

    internal class Persona
    {
         public string DNI {get; set;}
    public string Nombre {get; set;}
    public string Apellido {get;set;}
    public DateTime FechaNacimiento {get; set;}
    }
}
