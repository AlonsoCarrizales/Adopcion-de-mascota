using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionesSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos datos1 = Datos.GetInstancia();
            datos1.ListaPerros.Add(new Perro() {Id= 1, Nombre="Hachiko",Edad= 4 });
            datos1.ListaPerros.Add(new Perro() {Id= 2, Nombre="Coraje",Edad= 4 });
            datos1.ListaPerros.Add(new Perro() {Id= 3, Nombre="Betoben",Edad= 4 });
            datos1.ListaPerros.Add(new Perro() {Id= 4, Nombre="Jose",Edad= 4 });
            datos1.ListaPerros.Add(new Perro() {Id= 5, Nombre="SANCHEZ",Edad= 4 });
            CargarDatos2();
            foreach (Perro perro in datos1.ListaPerros)
            {
                Console.WriteLine("Id = "+ perro.Id+ " Nombre: "+perro.Nombre );
            }
            Console.ReadLine();
        }

       static  void CargarDatos2()
        {
            Datos datos2 = Datos.GetInstancia();
            datos2.ListaPerros.Add(new Perro() { Id = 6, Nombre = "Hangus", Edad = 6 });
            datos2.ListaPerros.Add(new Perro() { Id = 7, Nombre = "Betoben2", Edad = 8 });
            datos2.ListaPerros.Add(new Perro() { Id = 8, Nombre = "Hari", Edad = 10 });
            datos2.ListaPerros.Add(new Perro() { Id = 9, Nombre = "Dragon", Edad = 15 });
            datos2.ListaPerros.Add(new Perro() { Id = 10, Nombre = "Martoin", Edad = 1 });
            datos2.ListaPerros.Add(new Perro() { Id = 11, Nombre = "Hipopotan", Edad = 6 });
            datos2.ListaPerros.Add(new Perro() { Id = 12, Nombre = "Ray", Edad = 3 });
            datos2.ListaPerros.Add(new Perro() { Id = 13, Nombre = "Hari", Edad = 2 });
            datos2.ListaPerros.Add(new Perro() { Id = 14, Nombre = "Luke", Edad = 5 });
            datos2.ListaPerros.Add(new Perro() { Id = 15, Nombre = "Munch", Edad = 4 });

            foreach (Perro perro in datos2.ListaPerros)
            {
                Console.WriteLine("Id = " + perro.Id + " Nombre: " + perro.Nombre);
            }
        }
    }
}
