// ConstFisiologicas.cs - Declaracion constantes fisiologicas para la historia clinica

using System;

namespace MascotaGHCl.App.Dominio {
    public class ConstFisiologicas {
        // Miembros privados
        private int var_Id;                   /**< Identificador de constantes fisiologicas */
        private string var_Temperatura;       /**< Temperatura de la mascota */
        private string var_Masa;              /**< Masa de la mascota */
        private string var_FrecRespiratoria;  /**< Frecuencia Respiratoria de la mascota */
        private string var_FrecCardiaca;      /**< Frecuencia Cardiaca de la mascota */
        // Constructor
        public ConstFisiologicas(string _Temperatura, string _Masa, string _FrecRespiratoria, string _FrecCardiaca) {
            Temperatura = _Temperatura;
            Masa = _Masa;
            FrecRespiratoria = _FrecRespiratoria;
            FrecCardiaca = _FrecCardiaca;
        }
        // Constructor por defecto
        public ConstFisiologicas() : this("", "", "", "") {}
        // Metodos Publicos
        public int Id {
            get{ return var_Id; }
            set{ var_Id = value; }
        }
        public string Temperatura {
            get{ return var_Temperatura; }
            set{ var_Temperatura = value; }
        }
        public string Masa {
            get{ return var_Masa; }
            set{ var_Masa = value; }
        }
        public string FrecRespiratoria {
            get{ return var_FrecRespiratoria; }
            set{ var_FrecRespiratoria = value; }
        }
        public string FrecCardiaca {
            get{ return var_FrecCardiaca; }
            set{ var_FrecCardiaca = value; }
        }
    }
}