// IRepoPersona.cs - Interfaz con repositorio Persona

using System;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public interface IRepoPersona {
        IEnumerable<Persona> LstAll_Persona();
        // Metodos CRUD
        Persona Agregar_Persona(Persona gen_medico);
        void Borrar_Persona(int Id_Persona);
        Persona Buscar_Persona(int Id_Persona);
        Persona Actualizar_Persona(Persona pos_medico);
    }
}