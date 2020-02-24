using System;

namespace Profesiones
{
    class Program
    {
        static void Main(string[] args)
        {
          Persona Beatriz = new Persona("Beatriz","Ramirez","Maestra");
          Beatriz.Decir();

          Persona Diana = new Persona("Diana","Martinez","Programadora");
          Diana.Decir();

          Persona Monica = new Persona("Monica","Estrada","psicóloga");
          Monica.Decir();

         
        }
    }
}
