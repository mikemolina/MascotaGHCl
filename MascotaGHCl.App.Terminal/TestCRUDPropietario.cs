// TestCRUDPropietario - Clase para pruebas CRUD entidad Propietario

using System;
using System.Globalization;
using MascotaGHCl.App.Dominio;
using MascotaGHCl.App.Persistencia;

namespace MascotaGHCl.App.Terminal {
    public class TestCRUDPropietario {
        // Prueba CRUD de la base de datos con tabla Propietario (tabla de segundo orden)
        private static IRepoPersona testrepo_Persona = new RepoPersona(new Persistencia.AppContext());
        private static IRepoMascota testrepo_Mascota = new RepoMascota(new Persistencia.AppContext());
        private static IRepoPropietario testrepo_Propietario = new RepoPropietario(new Persistencia.AppContext());
        // Constructor por defecto
        public TestCRUDPropietario() {            
        }
        public void TestRepo_Agregar_Propietario() {
            Persona Lisa = new Persona{
                Nombre = "Lisa Simpson",
                Identificacion = "H47U89RE243",
                Celular = "5543459800"
            };
            DateTime Nacimiento = new DateTime(1989, 12, 17);
            Mascota Galgo = new Mascota{
                Nombre = "Ayudante de Santa II",
                Especie = "Perro",
                Tamanio = "Mediano",
                FechaNac = Nacimiento
            };
            Propietario Duenio = new Propietario{
                Usuario = Lisa,
                Animal = Galgo
            };
            testrepo_Propietario.Agregar_Propietario(Duenio);
            Console.WriteLine("Test: <Agregar> dato en tabla <Propietario>.");
        }
        public void TestRepo_Buscar_Propietario(int Id_Propietario) {
            Propietario Amo = testrepo_Propietario.Buscar_Propietario(Id_Propietario);
            Persona Anonimo = testrepo_Persona.Buscar_Persona(Amo.UsuarioID);
            Mascota Cria = testrepo_Mascota.Buscar_Mascota(Amo.AnimalID);
            Console.WriteLine("Test: <Buscar> dato en tabla <Propietario>.");
            Console.WriteLine("Nombre Persona   = {0}", Anonimo.Nombre);
            Console.WriteLine("Identificacion   = {0}", Anonimo.Identificacion);
            Console.WriteLine("Celular          = {0}", Anonimo.Celular);
            Console.WriteLine("Nombre Mascota   = {0}", Cria.Nombre);
            Console.WriteLine("Especie          = {0}", Cria.Especie);
            Console.WriteLine("Tamaño           = {0}", Cria.Tamanio);
            Console.WriteLine("Fecha nacimiento = {0}", Cria.FechaNac.ToString("D", CultureInfo.CreateSpecificCulture("es-ES")));
        }
        public void TestRepo_Actualizar_Propietario(int Id_Propietario) {
            Propietario Amo = testrepo_Propietario.Buscar_Propietario(Id_Propietario);
            Persona NuevoAnonimo = new Persona{
                Id = Amo.UsuarioID,
                Nombre = "Marge Simpson",
                Identificacion = "F3243404",
                Celular = "467-84377"
            };
            DateTime NuevaFechaNac = new DateTime(1991, 1, 10);
            Mascota NuevaCria = new Mascota{
                Id = Amo.AnimalID,
                Nombre = "Bola de nieve",
                Especie = "Gato",
                Tamanio = "Pequeño",
                FechaNac = NuevaFechaNac
            };
            Propietario NuevoAmo = new Propietario{
                Id = Id_Propietario,
                Usuario = NuevoAnonimo,
                Animal = NuevaCria
            };
            testrepo_Propietario.Actualizar_Propietario(NuevoAmo);
            Console.WriteLine("Test: <Actualizar> dato en tabla <Propietario>.");
        }
        public void TestRepo_Borrar_Propietario(int Id_Propietario) {     
            Propietario Amo = testrepo_Propietario.Buscar_Propietario(Id_Propietario);       
            testrepo_Propietario.Borrar_Propietario(Id_Propietario);
            testrepo_Persona.Borrar_Persona(Amo.UsuarioID);
            testrepo_Mascota.Borrar_Mascota(Amo.AnimalID);
            Console.WriteLine("Test: <Borrar> dato en tabla <Propietario>.");
        }
    }
}