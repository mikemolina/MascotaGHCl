// Veterinaria.cs - Declaracion clase Veterinaria

using System;


namespace MascotaGHCl.App.Dominio {
    public class Veterinaria {
        // Miembros privados
        private int var_Id;                    /**< Identificador de Veterinaria */
        private string var_Nombre;             /**< Nombre de la Veterinaria */
        private string var_RegistroSanitario;  /**< RegistroSanitario de la Veterinaria */
        private string var_Direccion;          /**< Direccion de la Veterinaria */
        private int var_DoctorID;              /**< ID Doctor de la Veterinaria - Referencia clave foranea */
        private Medico var_Doctor;             /**< Doctor de la Veterinaria */
        // Constructor
        public Veterinaria(string _Nombre, string _RegistroSanitario, string _Direccion, Medico _Doctor) {
            Nombre = _Nombre;
            RegistroSanitario = _RegistroSanitario;
            Direccion = _Direccion;
            Doctor = _Doctor;
        }
        // Constructor por defecto
        public Veterinaria() {
            Nombre = "";
            RegistroSanitario = "";
            Direccion = "";
            Doctor = new Medico();
        }
        // Metodos Publicos
        public int Id {
            get{ return var_Id; }
            set{ var_Id = value; }
        }
        public string Nombre {
            get{ return var_Nombre; }
            set{ var_Nombre = value; }
        }
        public string RegistroSanitario {
            get{ return var_RegistroSanitario; }
            set{ var_RegistroSanitario = value; }
        }
        public string Direccion {
            get{ return var_Direccion; }
            set{ var_Direccion = value; }
        }
        // ForeignKey("DoctorID")
        public int DoctorID {
            get{ return var_DoctorID; }
            set{ var_DoctorID = value; }
	    }
        public Medico Doctor {
            get{ return var_Doctor; }
            set{ var_Doctor = value; }
        }
    }
}