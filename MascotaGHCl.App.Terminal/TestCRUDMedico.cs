// TestCRUDMedico - Clase para pruebas CRUD entidad Medico

using System;
using System.Globalization;
using MascotaGHCl.App.Dominio;
using MascotaGHCl.App.Persistencia;

namespace MascotaGHCl.App.Terminal {
    public class TestCRUDMedico {
        // Prueba CRUD de la base de datos con tabla Medico (tabla de primer orden)
        private static IRepoMedico testrepo_Medico = new RepoMedico(new Persistencia.AppContext());
        // Constructor por defecto
        public TestCRUDMedico() {            
        }
        public void TestRepo_Agregar_Medico() {
            Medico Doc = new Medico{
                Nombre = "The Veterinarian",
                TarjetaProfesional = "1-600",
                Especialidad = "Baños"
            };
            testrepo_Medico.Agregar_Medico(Doc);
            Console.WriteLine("Test: <Agregar> dato en tabla <Medico>.");
        }
        public void TestRepo_Buscar_Medico(int Id_Medico) {
            Medico Doc = testrepo_Medico.Buscar_Medico(Id_Medico);
            Console.WriteLine("Test: <Buscar> dato en tabla <Medico>.");
            Console.WriteLine("Nombre              = {0}", Doc.Nombre);
            Console.WriteLine("Tarjeta Profesional = {0}", Doc.TarjetaProfesional);
            Console.WriteLine("Especialidad        = {0}", Doc.Especialidad);                    
        }
        public void TestRepo_Actualizar_Medico(int Id_Medico) {
            Medico NuevoDoc = new Medico{
                Id = Id_Medico,
                Nombre = "Gloria Valencia de Antaño",
                TarjetaProfesional = "1-001",
                Especialidad = "Cuidadora"
            };
            testrepo_Medico.Actualizar_Medico(NuevoDoc);
            Console.WriteLine("Test: <Actualizar> dato en tabla <Medico>.");
        }
        public void TestRepo_Borrar_Medico(int Id_Medico) {            
            testrepo_Medico.Borrar_Medico(Id_Medico);
            Console.WriteLine("Test: <Borrar> dato en tabla <Medico>.");
        }
    }
}