// IRepoHistClinica.cs - Interfaz con repositorio HistClinica

using System;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public interface IRepoHistClinica {
        IEnumerable<HistClinica> LstAll_HistClinica();
        // Metodos CRUD
        HistClinica Agregar_HistClinica(HistClinica gen_histclinica);
        void Borrar_HistClinica(int Id_HistClinica);
        HistClinica Buscar_HistClinica(int Id_HistClinica);
        HistClinica Actualizar_HistClinica(HistClinica pos_histclinica);
    }
}