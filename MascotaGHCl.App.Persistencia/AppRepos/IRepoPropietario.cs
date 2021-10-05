// IRepoPropietario.cs - Interfaz con repositorio Propietario

using System;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public interface IRepoPropietario {
        IEnumerable<Propietario> LstAll_Propietario();
        // Metodos CRUD
        Propietario Agregar_Propietario(Propietario gen_propietario);
        void Borrar_Propietario(int Id_Propietario);
        Propietario Buscar_Propietario(int Id_Propietario);
        Propietario Actualizar_Propietario(Propietario pos_propietario);
    }
}