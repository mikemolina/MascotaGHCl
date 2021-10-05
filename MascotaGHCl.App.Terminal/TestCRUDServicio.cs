// TestCRUDServicio - Clase para pruebas CRUD entidad Servicio

using System;
using System.Globalization;
using MascotaGHCl.App.Dominio;
using MascotaGHCl.App.Persistencia;

namespace MascotaGHCl.App.Terminal {
    public class TestCRUDServicio {
        // Prueba CRUD de la base de datos con tabla Servicio (tabla de tercer orden)
        // Datos tabla de 1er orden
        private static IRepoPersona testrepo_Persona = new RepoPersona(new Persistencia.AppContext());
        private static IRepoMascota testrepo_Mascota = new RepoMascota(new Persistencia.AppContext());
        private static IRepoMedico testrepo_Medico = new RepoMedico(new Persistencia.AppContext());
        // Datos tabla de 2do orden
        private static IRepoPropietario testrepo_Propietario = new RepoPropietario(new Persistencia.AppContext());
        private static IRepoVeterinaria testrepo_Veterinaria = new RepoVeterinaria(new Persistencia.AppContext());
        private static IRepoServicio testrepo_Servicio = new RepoServicio(new Persistencia.AppContext());
        // Constructor por defecto
        public TestCRUDServicio() {            
        }
        public void TestRepo_Agregar_Servicio() {
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
            DateTime Cita = new DateTime(2021, 9, 26);
            Servicio Atencion = new Servicio{
                Clinica = Hospital,
                Cliente = Duenio,
                FechaCita = Cita,
                Procedimiento = "Lavado"
            };
            testrepo_Servicio.Agregar_Servicio(Atencion);
            Console.WriteLine("Test: <Agregar> dato en tabla <Servicio>.");
        }
        public void TestRepo_Buscar_Servicio(int Id_Servicio) {
            Servicio Atencion = testrepo_Servicio.Buscar_Servicio(Id_Servicio);
            Propietario Amo = testrepo_Propietario.Buscar_Propietario(Atencion.ClienteID);            
            Persona Anonimo = testrepo_Persona.Buscar_Persona(Amo.UsuarioID);
            Mascota Cria = testrepo_Mascota.Buscar_Mascota(Amo.AnimalID);
            Veterinaria Hospital = testrepo_Veterinaria.Buscar_Veterinaria(Atencion.ClinicaID);
            Medico Doc = testrepo_Medico.Buscar_Medico(Hospital.DoctorID);            
            Console.WriteLine("Test: <Buscar> dato en tabla <Servicio>.");
            Console.WriteLine("Nombre Persona             = {0}", Anonimo.Nombre);
            Console.WriteLine("Identificacion             = {0}", Anonimo.Identificacion);
            Console.WriteLine("Celular                    = {0}", Anonimo.Celular);
            Console.WriteLine("Nombre Mascota             = {0}", Cria.Nombre);
            Console.WriteLine("Especie                    = {0}", Cria.Especie);
            Console.WriteLine("Tamaño                     = {0}", Cria.Tamanio);
            Console.WriteLine("Fecha nacimiento           = {0}", Cria.FechaNac.ToString("D", CultureInfo.CreateSpecificCulture("es-ES")));
            Console.WriteLine("Nombre Veterinaria         = {0}", Hospital.Nombre);
            Console.WriteLine("Registro Sanitario         = {0}", Hospital.RegistroSanitario);
            Console.WriteLine("Direccion                  = {0}", Hospital.Direccion);
            Console.WriteLine("Nombre Doctor              = {0}", Doc.Nombre);            
            Console.WriteLine("Tarjeta Profesional Doctor = {0}", Doc.TarjetaProfesional);
            Console.WriteLine("Especialidad Doctor        = {0}", Doc.Especialidad);
            Console.WriteLine("Fecha cita                 = {0}", Atencion.FechaCita.ToString("D", CultureInfo.CreateSpecificCulture("es-ES")));
            Console.WriteLine("Procedimiento              = {0}", Atencion.Procedimiento);
        }
        public void TestRepo_Actualizar_Servicio(int Id_Servicio) {
            Servicio Atencion = testrepo_Servicio.Buscar_Servicio(Id_Servicio);
            Propietario Amo = testrepo_Propietario.Buscar_Propietario(Atencion.ClienteID);
            Veterinaria Hospital = testrepo_Veterinaria.Buscar_Veterinaria(Atencion.ClinicaID);            
            //Console.WriteLine("ID Servicio =  {0}", Atencion.Id);
            //Console.WriteLine("ClinicaID   =  {0}", Atencion.ClinicaID);
            //Console.WriteLine("ClienteID   =  {0}", Atencion.ClienteID);
            //Console.WriteLine("---- Instancias");
            //Console.WriteLine("DoctorID   =  {0}", Hospital.DoctorID);            
            //Console.WriteLine("UsuarioID  =  {0}", Amo.UsuarioID);
            //Console.WriteLine("AnimalID   =  {0}", Amo.AnimalID);            
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
            // Amo.Id == Atencion.ClienteID
            Propietario NuevoAmo = new Propietario{
                Id = Atencion.ClienteID,
                Usuario = NuevoAnonimo,
                Animal = NuevaCria
            };
            Medico NuevoDoc = new Medico{
                Id = Hospital.DoctorID,
                Nombre = "Gloria Valencia de Antaño",
                TarjetaProfesional = "1-001",
                Especialidad = "Cuidadora"
            };
            // Hospital.Id == Atencion.ClinicaID
            Veterinaria NuevoHospital = new Veterinaria{
                Id = Atencion.ClinicaID,
                Nombre = "Veterinaria D'Antaño",
                RegistroSanitario = "000471",
                Direccion = "Naranjo 50 oeste del ICE",
                Doctor = NuevoDoc
            };
            DateTime Ahora = DateTime.Now;
            Servicio NuevaAtencion = new Servicio{
                Id = Id_Servicio,
                Clinica = NuevoHospital,
                Cliente = NuevoAmo,
                FechaCita = Ahora,
                Procedimiento = "Peinado"
            };
            testrepo_Servicio.Actualizar_Servicio(NuevaAtencion);            
            Console.WriteLine("Test: <Actualizar> dato en tabla <Servicio>.");
        }
        public void TestRepo_Borrar_Servicio(int Id_Servicio) {
            Servicio Atencion = testrepo_Servicio.Buscar_Servicio(Id_Servicio);
            Veterinaria Hospital = testrepo_Veterinaria.Buscar_Veterinaria(Atencion.ClinicaID);
            Propietario Amo = testrepo_Propietario.Buscar_Propietario(Atencion.ClienteID);
            testrepo_Servicio.Borrar_Servicio(Id_Servicio);
            testrepo_Propietario.Borrar_Propietario(Atencion.ClienteID);
            testrepo_Veterinaria.Borrar_Veterinaria(Atencion.ClinicaID);
            testrepo_Persona.Borrar_Persona(Amo.UsuarioID);
            testrepo_Mascota.Borrar_Mascota(Amo.AnimalID);
            testrepo_Medico.Borrar_Medico(Hospital.DoctorID);
            Console.WriteLine("Test: <Borrar> dato en tabla <Servicio>.");
        }
    }
}