// TestCRUDPersona - Clase para pruebas CRUD entidad Persona

using System;
using System.Globalization;
using MascotaGHCl.App.Dominio;
using MascotaGHCl.App.Persistencia;

namespace MascotaGHCl.App.Terminal {
    public class TestCRUDPersona {
        // Prueba CRUD de la base de datos con tabla Persona (tabla de primer orden)
        private static IRepoPersona testrepo_Persona = new RepoPersona(new Persistencia.AppContext());
        // Constructor por defecto
        public TestCRUDPersona() {            
        }
        public void TestRepo_Agregar_Persona() {
            Persona ElBarto = new Persona{
                Nombre = "Bart Simpson",
                Identificacion = "B47U89RE243",
                Celular = "8126283954"
            };
            testrepo_Persona.Agregar_Persona(ElBarto);
            Console.WriteLine("Test: <Agregar> dato en tabla <Persona>.");
        }
        public void TestRepo_Buscar_Persona(int Id_Persona) {
            Persona Respondiente = testrepo_Persona.Buscar_Persona(Id_Persona);
            Console.WriteLine("Test: <Buscar> dato en tabla <Persona>.");
            Console.WriteLine("Nombre         = {0}", Respondiente.Nombre);
            Console.WriteLine("Identificacion = {0}", Respondiente.Identificacion);
            Console.WriteLine("Celular        = {0}", Respondiente.Celular);
        }
        public void TestRepo_Actualizar_Persona(int Id_Persona) {
            Persona NuevoRespondiente = new Persona{
                Id = Id_Persona,
                Nombre = "Homero Simpson",
                Identificacion = "C4043243",
                Celular = "764-84377"
            };
            testrepo_Persona.Actualizar_Persona(NuevoRespondiente);
            Console.WriteLine("Test: <Actualizar> dato en tabla <Persona>.");
        }
        public void TestRepo_Borrar_Persona(int Id_Persona) {            
            testrepo_Persona.Borrar_Persona(Id_Persona);
            Console.WriteLine("Test: <Borrar> dato en tabla <Persona>.");
        }
    }
}