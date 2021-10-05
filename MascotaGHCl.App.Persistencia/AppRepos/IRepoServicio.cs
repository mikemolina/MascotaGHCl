// IRepoServicio.cs - Interfaz con repositorio Servicio

using System;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public interface IRepoServicio {
        IEnumerable<Servicio> LstAll_Servicio();
        // Metodos CRUD
        Servicio Agregar_Servicio(Servicio gen_servicio);
        void Borrar_Servicio(int Id_Servicio);
        Servicio Buscar_Servicio(int Id_Servicio);
        Servicio Actualizar_Servicio(Servicio pos_servicio);
    }
}