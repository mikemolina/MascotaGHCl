// Medico.cs - Declaracion clase Medico

using System;

namespace MascotaGHCl.App.Dominio {
    public class Medico {
        // Miembros privados
        private int var_Id;                     /**< Identificador del Medico */
        private string var_Nombre;              /**< Nombre completo del Medico */
        private string var_TarjetaProfesional;  /**< Tarjeta profesional del Medico */
        private string var_Especialidad;        /**< Especialidad del Medico */
        // Constructor
        public Medico(string _Nombre, string _TarjetaProfesional, string _Especialidad) {
            Nombre = _Nombre;
            TarjetaProfesional = _TarjetaProfesional;
            Especialidad = _Especialidad;
        }
        // Constructor por defecto
        public Medico() : this("", "", "") {}
        // Metodos Publicos
        public int Id {
            get{ return var_Id; }
            set{ var_Id = value; }
        }
        public string Nombre {
            get{ return var_Nombre; }
            set{ var_Nombre = value; }
        }
        public string TarjetaProfesional {
            get{ return var_TarjetaProfesional; }
            set{ var_TarjetaProfesional = value; }
        }
        public string Especialidad {
            get{ return var_Especialidad; }
            set{ var_Especialidad = value; }
        }
    }
}