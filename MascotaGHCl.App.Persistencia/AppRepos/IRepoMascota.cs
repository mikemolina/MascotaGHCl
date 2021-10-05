// IRepoMascota.cs - Interfaz con repositorio Mascota

using System;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public interface IRepoMascota {
        IEnumerable<Mascota> LstAll_Mascota();
        // Metodos CRUD
        Mascota Agregar_Mascota(Mascota gen_mascota);
        void Borrar_Mascota(int Id_Mascota);
        Mascota Buscar_Mascota(int Id_Mascota);
        Mascota Actualizar_Mascota(Mascota pos_mascota);
    }
}