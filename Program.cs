using System;

namespace Profesiones
{
    class Program
    {
        static void Main(string[] args)
        {
          Persona Anne = new Persona("Beatriz","Ramirez","Maestra");
          Anne.Decir();

          Persona Diana = new Persona("Diana","Martinez","Programadora");
          Diana.Decir();

          Persona Monica = new Persona("Monica","Estrada","psicóloga");
          Monica.Decir();

         
        }
    }
}
