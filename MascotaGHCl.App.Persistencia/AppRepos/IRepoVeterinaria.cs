// IRepoVeterinaria.cs - Interfaz con repositorio Veterinaria

using System;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public interface IRepoVeterinaria {
        IEnumerable<Veterinaria> LstAll_Veterinaria();
        // Metodos CRUD
        Veterinaria Agregar_Veterinaria(Veterinaria gen_veterinaria);
        void Borrar_Veterinaria(int Id_Veterinaria);
        Veterinaria Buscar_Veterinaria(int Id_Veterinaria);
        Veterinaria Actualizar_Veterinaria(Veterinaria pos_veterinaria);
    }
}