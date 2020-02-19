using System;

namespace Profesiones
{
    class Persona
    {
       string nombre;
       string apellido;
       string profesion; 


    public Persona(string nombre, string apellido, string profesion){

         this.nombre = nombre;
         this.apellido = apellido;
         this.profesion = profesion;

       }

    public void Decir (){ 
       Console.WriteLine("Hola, mi nombre es "+this.nombre+" "+this.apellido+" y mi profesion es "+this.profesion);

    }



    }
}
