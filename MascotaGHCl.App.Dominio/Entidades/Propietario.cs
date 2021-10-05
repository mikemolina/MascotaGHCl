// Propietario.cs - Declaracion de clase Propietario

using System;

namespace MascotaGHCl.App.Dominio {
    public class Propietario {
        // Miembros privados
        private int var_Id;           /**< Identificador de Propietario */
        private int var_UsuarioID;    /**< ID Usuario del Propietario - Referencia clave foranea */
        private Persona var_Usuario;  /**< Usuario Propietario */
        private int var_AnimalID;     /**< ID Animal del Propietario - Referencia clave foranea */
        private Mascota var_Animal;   /**< Animal del Propietario */
        // Constructor
        public Propietario(Persona _Usuario, Mascota _Animal) {
            Usuario = _Usuario;
            Animal = _Animal;
        }
        // Constructor por defecto
        public Propietario() {
            Usuario = new Persona();
            Animal = new Mascota();
        }
        // Metodos Publicos
        public int Id {
            get{ return var_Id; }
            set{ var_Id = value; }
        }
        // ForeignKey("UsuarioID")
        public int UsuarioID {
            get{ return var_UsuarioID; }
            set{ var_UsuarioID = value; }
	    }
        public Persona Usuario {
            get{ return var_Usuario; }
            set{ var_Usuario = value; }
        }
        // ForeignKey("AnimalID")
        public int AnimalID {
            get{ return var_AnimalID; }
            set{ var_AnimalID = value; }
	    }
        public Mascota Animal {
            get{ return var_Animal; }
            set{ var_Animal = value; }
        }
        // Funciones publicas
        public void InfoPropietario() {
            Console.WriteLine("La persona con nombre {0} tiene como mascota un {1} llamado {2}.", Usuario.Nombre, Animal.Especie, Animal.Nombre);
        }
    }
}