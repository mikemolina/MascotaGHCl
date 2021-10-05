// Persona.cs - Declaracion clase Persona

using System;

namespace MascotaGHCl.App.Dominio {
    public class Persona {
        // Miembros privados
        private int var_Id;                  /**< Identificador de Persona */
        private string var_Nombre;           /**< Nombre completo de la Persona */
        private string var_Identificacion;   /**< Documento de identificacion de la Persona */
        private string var_Celular;          /**< Numero celular de la Persona */
        // Constructor
        public Persona(string _Nombre, string _Identificacion, string _Celular) {
            Nombre = _Nombre;
            Identificacion = _Identificacion;
            Celular = _Celular;
        }
        // Constructor por defecto
        public Persona() : this("", "", "") {}
        // Metodos Publicos
        public int Id {
            get{ return var_Id; }
            set{ var_Id = value; }
        }
        public string Nombre {
            get{ return var_Nombre; }
            set{ var_Nombre = value; }
        }
        public string Identificacion {
            get{ return var_Identificacion; }
            set{ var_Identificacion = value; }
        }
        public string Celular {
            get{ return var_Celular; }
            set{ var_Celular = value; }
        }
    }
}