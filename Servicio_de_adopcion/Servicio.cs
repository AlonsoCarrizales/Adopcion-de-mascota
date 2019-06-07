using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio_de_adopcion
{
    class Servicio
    {
        private string NombreP;
        public Servicio()
        {
            Console.WriteLine("Bienvenido a servicio de Adopción");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("José Alonso Carrizales López");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Inserte los Datos del usuario");
            Console.WriteLine("Nombre: ");
            var Nombre = Console.ReadLine();
            Console.Write("Edad :");
            var Edad = Console.ReadLine();

            Console.Write("Telefono :");
            var Telefono = Console.ReadLine() ;
            Console.Write("Genero [ 1:Masculino , 0:Femenino]");
            int  Genero =Convert.ToInt32(Console.ReadLine());


           int  EdadC = int.Parse(Edad);
           int  TeleC = int.Parse(Telefono);
            Console.Clear();

            this.GetPerson(Nombre, EdadC,Genero ,TeleC);
            this.DateMascota();
           
        }
       public void  GetPerson(string Nombre,int Edad, int Genero,int Telefono)
        {
            Persona person = new Persona();
            person.Nombre = Nombre;
            person.Edad = Edad.ToString();
            person.Telefono = Telefono ;
            person.Genero = (Genero)Genero;
            this.NombreP = Nombre;
            this.SetInofr(person);
        }
        private void GetMascota(string Nombre,int Genero,int especie, int edad,string Raza,string Color,double Tamaño,double Peso)
        {
            Masacota masacota = new Masacota();
            masacota.nombre = Nombre;
            masacota.Genero = (GeneroM)Genero;
            masacota.Especie = (Especie)especie;
            masacota.color = Color;
            masacota.Peso = Peso;
            masacota.Tamaño = Tamaño;
            masacota.Raza = Raza;
            masacota.Edad = edad;
            this.SetInforMascota(masacota);
        }
        private void SetInofr(Persona persona)
        {        
            Console.WriteLine("Nombre de la persona: "+persona.Nombre);
            Console.WriteLine("Edad de la persona: "+persona.Edad);
            Console.WriteLine("Telefono: "+persona.Telefono);
            Console.WriteLine("Genero: "+persona.Genero);
        }
        private void SetInforMascota(Masacota masacota)
        {
            Console.WriteLine("Nombre mascota: "+masacota.nombre);
            Console.WriteLine("Edad: "+masacota.nombre);
            Console.WriteLine("Genero "+masacota.Genero);
            Console.WriteLine("Raza de la mascota: "+masacota.Raza);
            Console.WriteLine("Tamaño de la mascota: "+masacota.Tamaño);
            Console.WriteLine("Peso de la mascota: "+masacota.Peso);
            Console.WriteLine("Color de la mascota: "+masacota.color);
            Console.WriteLine("Especie de la mascota :" +masacota.Especie);
            Persona persona = new Persona();
            Console.Write("--------------------------------------------------------------\n");
            Console.WriteLine("Felicidades " + this.NombreP + " a adoptado a :" + masacota.nombre);
        }
        private void DateMascota()
        {

            Console.WriteLine("Ingrese el nombre de la mascota a adoptar");
            var Nombre =Convert.ToString( Console.ReadLine());
            Console.WriteLine("Ingrese el Raza de la mascota a adoptar");
            var Raza =Convert.ToString( Console.ReadLine());
            Console.WriteLine("Ingrese el Edad de la mascota a adoptar");
            int Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Tamaño de la mascota a adoptar");
            double Tamaño = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Peso de la mascota a adoptar");
            double Peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Color de la mascota a adoptar");
            string Color = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el Genero de la mascota a adoptar");
            Console.WriteLine("[0:Macho , 1:Hembra]");
            int Genero =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Ingrese el Especie de la mascota a adoptar");
            Console.WriteLine("[0:Felino , 1:Canino , 2:Pez , 3:Ave]");
            int Especie =Convert.ToInt32( Console.ReadLine());
            this.GetMascota(Nombre,Genero,Especie,Edad,Raza,Color,Tamaño,Peso);
        }
    }
}
