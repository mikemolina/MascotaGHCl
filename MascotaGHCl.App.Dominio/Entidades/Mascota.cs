// Mascota.cs - Declaracion clase Mascota

using System;

namespace MascotaGHCl.App.Dominio {
    public class Mascota {
        // Miembros privados
        private int var_Id;             /**< Identificador de Mascota */
        private string var_Nombre;      /**<Nombre de la Mascota */
        private string var_Especie;     /**<Especie de la Mascota */
        private string var_Tamanio;     /**<Tamanio de la Mascota */
        private DateTime var_FechaNac;  /**<Fecha de Nacimiento de la Mascota */
        // Constructor
        public Mascota(string _Nombre, string _Especie, string _Tamanio, DateTime _FechaNac) {
            Nombre = _Nombre;
            Especie = _Especie;
            Tamanio = _Tamanio;
            FechaNac = _FechaNac;
        }
        // Constructor por defecto
        public Mascota() {
            Nombre = "";
            Especie = "";
            Tamanio = "";
            FechaNac = new DateTime(1, 1, 1);
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
        public string Especie {
            get{ return var_Especie; }
            set{ var_Especie = value; }
        }
        public string Tamanio {
            get{ return var_Tamanio; }
            set{ var_Tamanio = value; }
        }
        public DateTime FechaNac {
            get{ return var_FechaNac; }
            set{ var_FechaNac = value; }
        }
    }
}