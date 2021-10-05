// IRepoMedico.cs - Interfaz con repositorio Medico

using System;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public interface IRepoMedico {
        IEnumerable<Medico> LstAll_Medico();
        // Metodos CRUD
        Medico Agregar_Medico(Medico gen_medico);
        void Borrar_Medico(int Id_Medico);
        Medico Buscar_Medico(int Id_Medico);
        Medico Actualizar_Medico(Medico pos_medico);
    }
}