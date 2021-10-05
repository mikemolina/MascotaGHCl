// TestCRUDMascota - Clase para pruebas CRUD entidad Mascota

using System;
using System.Globalization;
using MascotaGHCl.App.Dominio;
using MascotaGHCl.App.Persistencia;

namespace MascotaGHCl.App.Terminal {
    public class TestCRUDMascota {
        // Prueba CRUD de la base de datos con tabla Mascota (tabla de primer orden)
        private static IRepoMascota testrepo_Mascota = new RepoMascota(new Persistencia.AppContext());
        // Constructor por defecto
        public TestCRUDMascota() {            
        }
        public void TestRepo_Agregar_Mascota() {
            DateTime Nacimiento = new DateTime(1989, 12, 17);
            Mascota Galgo = new Mascota{
                Nombre = "Ayudante de Santa",
                Especie = "Perro",
                Tamanio = "Mediano",
                FechaNac = Nacimiento
            };
            testrepo_Mascota.Agregar_Mascota(Galgo);
            Console.WriteLine("Test: <Agregar> dato en tabla <Mascota>.");
        }
        public void TestRepo_Buscar_Mascota(int Id_Mascota) {
            Mascota Galgo = testrepo_Mascota.Buscar_Mascota(Id_Mascota);
            Console.WriteLine("Test: <Buscar> dato en tabla <Mascota>.");
            Console.WriteLine("Nombre           = {0}", Galgo.Nombre);
            Console.WriteLine("Especie          = {0}", Galgo.Especie);
            Console.WriteLine("Tamaño           = {0}", Galgo.Tamanio);
            Console.WriteLine("Fecha nacimiento = {0}", Galgo.FechaNac.ToString("D", CultureInfo.CreateSpecificCulture("es-ES")));
        }
        public void TestRepo_Actualizar_Mascota(int Id_Mascota) {
            DateTime NuevaFechaNac = new DateTime(1991, 1, 10);
            Mascota NuevaPet = new Mascota{
                Id = Id_Mascota,
                Nombre = "Bola de nieve",
                Especie = "Gato",
                Tamanio = "Pequeño",
                FechaNac = NuevaFechaNac
            };
            testrepo_Mascota.Actualizar_Mascota(NuevaPet);
            Console.WriteLine("Test: <Actualizar> dato en tabla <Mascota>.");
        }
        public void TestRepo_Borrar_Mascota(int Id_Mascota) {            
            testrepo_Mascota.Borrar_Mascota(Id_Mascota);
            Console.WriteLine("Test: <Borrar> dato en tabla <Mascota>.");
        }
    }
}