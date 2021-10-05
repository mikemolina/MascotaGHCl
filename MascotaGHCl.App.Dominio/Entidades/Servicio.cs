// Servicio.cs - Decalaracion clase Servicio

using System;

namespace MascotaGHCl.App.Dominio {
    public class Servicio {
        // Miembros privados
        private int var_Id;               /**< Identificador de Servicio */
        private int var_ClinicaID;        /**< ID Clinica del Servicio - Referencia clave foranea */
        private Veterinaria var_Clinica;  /**< Oferente del Servicio */
        private int var_ClienteID;        /**< ID Cliente del Servicio - Referencia clave foranea */
        private Propietario var_Cliente;  /**< Cliente del Servicio */
        private DateTime var_FechaCita;   /**< Fecha de cita del Servicio */
        private string var_Procedimiento; /**< Tipo de Servicio */
        // Constructor
        public Servicio(Veterinaria _Clinica, Propietario _Cliente, DateTime _FechaCita, string _Procedimiento) {
            Clinica = _Clinica;
            Cliente = _Cliente;
            FechaCita = _FechaCita;
            Procedimiento = _Procedimiento;
        }
        // Constructor por defecto
        public Servicio() {
            Clinica = new Veterinaria();
            Cliente = new Propietario();
            FechaCita = new DateTime(1, 1, 1);
            Procedimiento = "";
        }
        // Metodos Publicos
        public int Id {
            get{ return var_Id; }
            set{ var_Id = value; }
        }
        // ForeignKey("ClinicaID")
        public int ClinicaID {
            get{ return var_ClinicaID; }
            set{ var_ClinicaID = value; }
	    }
        public Veterinaria Clinica {
            get{ return var_Clinica; }
            set{ var_Clinica = value; }
        }
        // ForeignKey("ClienteID")
        public int ClienteID {
            get{ return var_ClienteID; }
            set{ var_ClienteID = value; }
	    }
        public Propietario Cliente {
            get{ return var_Cliente; }
            set{ var_Cliente = value; }
        }
        public DateTime FechaCita {
            get{ return var_FechaCita; }
            set{ var_FechaCita = value; }
        }
        public string Procedimiento {
            get{ return var_Procedimiento; }
            set{ var_Procedimiento = value; }
        }
        // Funciones publicas
        public void InfoServicio() {
            Console.WriteLine("Informacion del servicio");
            Console.WriteLine("========================");
            Console.WriteLine("Usuario:         {0}", Cliente.Usuario.Nombre);
            Console.WriteLine("Especie mascota: {0}", Cliente.Animal.Especie);
            Console.WriteLine("Veterinaria:     {0}", Clinica.Nombre);
            Console.WriteLine("Medico:          {0}", Clinica.Doctor.Nombre);
            Console.WriteLine("Servicio:        {0}", Procedimiento);
        }
    }
}