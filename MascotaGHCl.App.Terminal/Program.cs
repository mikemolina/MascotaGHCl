// Program.cs - Aplicacion para pruebas de la capa Dominio, Persistencia

using System;
using System.Globalization;
using MascotaGHCl.App.Dominio;
using MascotaGHCl.App.Persistencia;

namespace MascotaGHCl.App.Terminal {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello MascotaGHCl!");
            //TestLibreria Dominio = new TestLibreria();
            //Dominio.MostrarDatos();
            //----- Test Tabla Persona
            TestCRUDPersona EntidadPersona = new TestCRUDPersona();
            //EntidadPersona.TestRepo_Agregar_Persona();
            //EntidadPersona.TestRepo_Actualizar_Persona(1);
            //EntidadPersona.TestRepo_Buscar_Persona(1);
            //EntidadPersona.TestRepo_Borrar_Persona(1);            
            //----- Test Tabla Mascota
            TestCRUDMascota EntidadMascota = new TestCRUDMascota();
            //EntidadMascota.TestRepo_Agregar_Mascota();
            //EntidadMascota.TestRepo_Actualizar_Mascota(1);
            //EntidadMascota.TestRepo_Buscar_Mascota(2);
            //EntidadMascota.TestRepo_Borrar_Mascota(2);            
            //----- Test Tabla Propietario
            TestCRUDPropietario EntidadPropietario = new TestCRUDPropietario();
            //EntidadPropietario.TestRepo_Agregar_Propietario();
            //EntidadPropietario.TestRepo_Actualizar_Propietario(2);
            //EntidadPropietario.TestRepo_Buscar_Propietario(2);
            //EntidadPropietario.TestRepo_Borrar_Propietario(2);
            //----- Test Tabla Medico
            TestCRUDMedico EntidadMedico = new TestCRUDMedico();
            //EntidadMedico.TestRepo_Agregar_Medico();
            //EntidadMedico.TestRepo_Actualizar_Medico(2);
            //EntidadMedico.TestRepo_Buscar_Medico(2);
            //EntidadMedico.TestRepo_Borrar_Medico(5);
            //----- Test Tabla Veterinaria
            TestCRUDVeterinaria EntidadVeterinaria = new TestCRUDVeterinaria();
            //EntidadVeterinaria.TestRepo_Agregar_Veterinaria();
            //EntidadVeterinaria.TestRepo_Actualizar_Veterinaria(3);
            //EntidadVeterinaria.TestRepo_Buscar_Veterinaria(3);
            //EntidadVeterinaria.TestRepo_Borrar_Veterinaria(3);
            TestCRUDServicio EntidadServicio = new TestCRUDServicio();
            //EntidadServicio.TestRepo_Agregar_Servicio();
            // Bug: actualiacion clase Veterinario no es instantanea en la terminal pero si en BD;
            //      en tiempo de ejecucion.
            //EntidadServicio.TestRepo_Actualizar_Servicio(6);
            //EntidadServicio.TestRepo_Buscar_Servicio(6);
            //EntidadServicio.TestRepo_Borrar_Servicio(6);
            //----- Test Tabla ConstFisiologicas
            TestCRUDConstFisiologicas EntidadConstFisiologicas = new TestCRUDConstFisiologicas();
            //EntidadConstFisiologicas.TestRepo_Agregar_ConstFisiologicas();
            //EntidadConstFisiologicas.TestRepo_Actualizar_ConstFisiologicas(4);
            //EntidadConstFisiologicas.TestRepo_Buscar_ConstFisiologicas(4);
            //EntidadConstFisiologicas.TestRepo_Borrar_ConstFisiologicas(4);
            //----- Test Tabla HistClinica
            TestCRUDHistClinica EntidadHistClinica = new TestCRUDHistClinica();
            //EntidadHistClinica.TestRepo_Agregar_HistClinica();
            //EntidadHistClinica.TestRepo_Actualizar_HistClinica(2);
            //EntidadHistClinica.TestRepo_Buscar_HistClinica(3);
            //EntidadHistClinica.TestRepo_Borrar_HistClinica(2);
        }
          
    }
}
