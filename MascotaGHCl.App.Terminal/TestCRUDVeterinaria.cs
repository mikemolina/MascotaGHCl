// TestCRUDVeterinaria - Clase para pruebas CRUD entidad Veterinaria

using System;
using System.Globalization;
using MascotaGHCl.App.Dominio;
using MascotaGHCl.App.Persistencia;

namespace MascotaGHCl.App.Terminal {
    public class TestCRUDVeterinaria {
        // Prueba CRUD de la base de datos con tabla Veterinaria (tabla de segundo orden)
        private static IRepoMedico testrepo_Medico = new RepoMedico(new Persistencia.AppContext());
        private static IRepoVeterinaria testrepo_Veterinaria = new RepoVeterinaria(new Persistencia.AppContext());
        // Constructor por defecto
        public TestCRUDVeterinaria() {            
        }
        public void TestRepo_Agregar_Veterinaria() {
            Medico Doc = new Medico{
                Nombre = "The Veterinarian",
                TarjetaProfesional = "1-600",
                Especialidad = "Baños"
            };
            Veterinaria Hospital = new Veterinaria{
                Nombre = "Springfield Animal Hospital",
                RegistroSanitario = "RS-0001",
                Direccion = "Springfield",
                Doctor = Doc
            };
            testrepo_Veterinaria.Agregar_Veterinaria(Hospital);
            Console.WriteLine("Test: <Agregar> dato en tabla <Veterinario>.");
        }
        public void TestRepo_Buscar_Veterinaria(int Id_Veterinaria) {
            Veterinaria Hospital = testrepo_Veterinaria.Buscar_Veterinaria(Id_Veterinaria);
            Medico Doc = testrepo_Medico.Buscar_Medico(Hospital.DoctorID);
            Console.WriteLine("Test: <Buscar> dato en tabla <Veterinaria>.");
            Console.WriteLine("Nombre                     = {0}", Hospital.Nombre);
            Console.WriteLine("Registro Sanitario         = {0}", Hospital.RegistroSanitario);
            Console.WriteLine("Direccion                  = {0}", Hospital.Direccion);
            Console.WriteLine("Nombre Doctor              = {0}", Doc.Nombre);            
            Console.WriteLine("Tarjeta Profesional Doctor = {0}", Doc.TarjetaProfesional);
            Console.WriteLine("Especialidad Doctor        = {0}", Doc.Especialidad);
        }
        public void TestRepo_Actualizar_Veterinaria(int Id_Veterinaria) {
            Veterinaria Hospital = testrepo_Veterinaria.Buscar_Veterinaria(Id_Veterinaria);
            Medico NuevoDoc = new Medico{
                Id = Hospital.DoctorID,
                Nombre = "Gloria Valencia de Antaño",
                TarjetaProfesional = "1-001",
                Especialidad = "Cuidadora"
            };
            Veterinaria NuevoHospital = new Veterinaria{
                Id = Id_Veterinaria,
                Nombre = "Veterinaria Dr. Maroto",
                RegistroSanitario = "000471",
                Direccion = "Naranjo 50 oeste del ICE",
                Doctor = NuevoDoc
            };
            testrepo_Veterinaria.Actualizar_Veterinaria(NuevoHospital);
            Console.WriteLine("Test: <Actualizar> dato en tabla <Veterinaria>.");
        }
        public void TestRepo_Borrar_Veterinaria(int Id_Veterinaria) {
            Veterinaria Hospital = testrepo_Veterinaria.Buscar_Veterinaria(Id_Veterinaria);
            testrepo_Veterinaria.Borrar_Veterinaria(Id_Veterinaria);
            testrepo_Medico.Borrar_Medico(Hospital.DoctorID);
            Console.WriteLine("Test: <Borrar> dato en tabla <Veterinaria>.");
        }
    }
}