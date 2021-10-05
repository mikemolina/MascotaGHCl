// TestLibreria.cs - Clase para pruebas de la capa Dominio

using System;
using System.Globalization;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Terminal{
    public class TestLibreria {
        public TestLibreria() {
        }
        // Pruebas de la libreria
        public void MostrarDatos() {
            Persona ElBarto = new Persona("Bart Simpson", "B47U89RE243", "8126283954");
            DateTime Nacimiento = new DateTime(1989, 12, 17);
            Mascota Galgo = new Mascota("Ayudante de Santa", "Perro", "Mediano", Nacimiento);
            Propietario Duenio = new Propietario(ElBarto, Galgo);
            Duenio.InfoPropietario();
            Medico Doc = new Medico("The Veterinarian", "1-600", "Baños");
            Veterinaria Hospital = new Veterinaria("Springfield Animal Hospital", "RS-0001", "Springfield", Doc);
            Console.WriteLine("La veterinaria llamada {0} cuenta con el medico {1} con especialidad en {2}.",
            Hospital.Nombre, Hospital.Doctor.Nombre, Doc.Especialidad);
            DateTime Cita = new DateTime(2021, 9, 26);
            Servicio Atencion = new Servicio(Hospital, Duenio, Cita, "Lavado");
            Atencion.InfoServicio();
            ConstFisiologicas Parametros = new ConstFisiologicas("39", "12", "26", "112");
            HistClinica Historia = new HistClinica(Atencion, Parametros, "Limpieza", "Sucio", "Travieso");
            Console.WriteLine("Fecha Nacimiento Mascota: {0}", Historia.Consulta.Cliente.Animal.FechaNac.ToString("D", CultureInfo.CreateSpecificCulture("es-ES")));
        }
    }
}