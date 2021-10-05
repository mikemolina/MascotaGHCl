// TestCRUDHistClinica - Clase para pruebas CRUD entidad HistClinica

using System;
using System.Globalization;
using MascotaGHCl.App.Dominio;
using MascotaGHCl.App.Persistencia;

namespace MascotaGHCl.App.Terminal {
    public class TestCRUDHistClinica {
        // Prueba CRUD de la base de datos con tabla HistClinica (tabla de cuarto orden)
        // Datos tabla de 1er orden
        private static IRepoPersona testrepo_Persona = new RepoPersona(new Persistencia.AppContext());
        private static IRepoMascota testrepo_Mascota = new RepoMascota(new Persistencia.AppContext());
        private static IRepoMedico testrepo_Medico = new RepoMedico(new Persistencia.AppContext());
        private static IRepoConstFisiologicas testrepo_ConstFisiologicas = new RepoConstFisiologicas(new Persistencia.AppContext());
        // Datos tabla de 2do orden
        private static IRepoPropietario testrepo_Propietario = new RepoPropietario(new Persistencia.AppContext());
        private static IRepoVeterinaria testrepo_Veterinaria = new RepoVeterinaria(new Persistencia.AppContext());
        // Datos tabla de 3er orden
        private static IRepoServicio testrepo_Servicio = new RepoServicio(new Persistencia.AppContext());
        private static IRepoHistClinica testrepo_HistClinica = new RepoHistClinica(new Persistencia.AppContext());
        // Constructor por defecto
        public TestCRUDHistClinica() {            
        }
        public void TestRepo_Agregar_HistClinica() {
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
            ConstFisiologicas Parametros = new ConstFisiologicas{
                Temperatura = "39",
                Masa = "12",
                FrecRespiratoria = "26",
                FrecCardiaca = "112"
            };
            HistClinica Historia = new HistClinica{
                Consulta = Atencion,
                ParamVitales = Parametros,
                PlanTerp = "Limpieza",
                Diagnostico = "Esta sucio",
                Antecedentes = "Travieso"
            };
            testrepo_HistClinica.Agregar_HistClinica(Historia);
            Console.WriteLine("Test: <Agregar> dato en tabla <HistClinica>.");
        }
        public void TestRepo_Buscar_HistClinica(int Id_HistClinica) {
            HistClinica Historia = testrepo_HistClinica.Buscar_HistClinica(Id_HistClinica);
            Servicio Atencion = testrepo_Servicio.Buscar_Servicio(Historia.ConsultaID);
            Propietario Amo = testrepo_Propietario.Buscar_Propietario(Atencion.ClienteID);            
            Persona Anonimo = testrepo_Persona.Buscar_Persona(Amo.UsuarioID);
            Mascota Cria = testrepo_Mascota.Buscar_Mascota(Amo.AnimalID);
            Veterinaria Hospital = testrepo_Veterinaria.Buscar_Veterinaria(Atencion.ClinicaID);
            Medico Doc = testrepo_Medico.Buscar_Medico(Hospital.DoctorID);
            ConstFisiologicas Parametros = testrepo_ConstFisiologicas.Buscar_ConstFisiologicas(Historia.ParamVitalesID);
            Console.WriteLine("Test: <Buscar> dato en tabla <HistClinica>.");
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
            Console.WriteLine("Temperatura                = {0}", Parametros.Temperatura);
            Console.WriteLine("Masa                       = {0}", Parametros.Masa);
            Console.WriteLine("FrecRespiratoria           = {0}", Parametros.FrecRespiratoria);
            Console.WriteLine("FrecCardiaca               = {0}", Parametros.FrecCardiaca);
            Console.WriteLine("Plan terapeutico           = {0}", Historia.PlanTerp);
            Console.WriteLine("Diagnostico                = {0}", Historia.Diagnostico);
            Console.WriteLine("Antecedentes               = {0}", Historia.Antecedentes);
        }
        public void TestRepo_Actualizar_HistClinica(int Id_HistClinica) {
            HistClinica Historia = testrepo_HistClinica.Buscar_HistClinica(Id_HistClinica);
            Servicio Atencion = testrepo_Servicio.Buscar_Servicio(Historia.ConsultaID);
            Propietario Amo = testrepo_Propietario.Buscar_Propietario(Atencion.ClienteID);
            Veterinaria Hospital = testrepo_Veterinaria.Buscar_Veterinaria(Atencion.ClinicaID);            
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
                Id = Historia.ConsultaID,
                Clinica = NuevoHospital,
                Cliente = NuevoAmo,
                FechaCita = Ahora,
                Procedimiento = "Peinado"
            };
            ConstFisiologicas NuevosParametros = new ConstFisiologicas{
                Id = Historia.ParamVitalesID,
                Temperatura = "45",
                Masa = "11",
                FrecRespiratoria = "37",
                FrecCardiaca = "201"
            };
            HistClinica NuevaHistoria = new HistClinica{
                Id = Id_HistClinica,
                Consulta = NuevaAtencion,
                ParamVitales = NuevosParametros,
                PlanTerp = "Engorde",
                Diagnostico = "Bajo peso",
                Antecedentes = "Despelucado"
            };
            testrepo_HistClinica.Actualizar_HistClinica(NuevaHistoria);            
            Console.WriteLine("Test: <Actualizar> dato en tabla <HistClinica>.");
        }
        public void TestRepo_Borrar_HistClinica(int Id_HistClinica) {
            HistClinica Historia = testrepo_HistClinica.Buscar_HistClinica(Id_HistClinica);
            Servicio Atencion = testrepo_Servicio.Buscar_Servicio(Historia.ConsultaID);
            Veterinaria Hospital = testrepo_Veterinaria.Buscar_Veterinaria(Atencion.ClinicaID);
            Propietario Amo = testrepo_Propietario.Buscar_Propietario(Atencion.ClienteID);
            testrepo_HistClinica.Borrar_HistClinica(Id_HistClinica);
            testrepo_ConstFisiologicas.Borrar_ConstFisiologicas(Historia.ParamVitalesID);
            testrepo_Servicio.Borrar_Servicio(Historia.ConsultaID);
            testrepo_Propietario.Borrar_Propietario(Atencion.ClienteID);
            testrepo_Veterinaria.Borrar_Veterinaria(Atencion.ClinicaID);
            testrepo_Persona.Borrar_Persona(Amo.UsuarioID);
            testrepo_Mascota.Borrar_Mascota(Amo.AnimalID);
            testrepo_Medico.Borrar_Medico(Hospital.DoctorID);
            Console.WriteLine("Test: <Borrar> dato en tabla <HistClinica>.");
        }
    }
}