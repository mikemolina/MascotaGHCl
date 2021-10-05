// RepoHistClinica.cs - Implementacion de la interfaz para repositorio HistClinica

using System;
using System.Linq;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public class RepoHistClinica : IRepoHistClinica {
        private readonly AppContext var_appContext;  /**< Variable privada para el contexto <entidad> de la BD */
        // Constructor
        public RepoHistClinica(AppContext _appContext) {
            var_appContext = _appContext;
        }
        // Lista para HistClinica
        IEnumerable<HistClinica> IRepoHistClinica.LstAll_HistClinica() {
            return var_appContext.TBLHistClinica;
        }
        // Metodo Crear
        HistClinica IRepoHistClinica.Agregar_HistClinica(HistClinica gen_histclinica) {
            var HistClinica_Agregado = var_appContext.TBLHistClinica.Add(gen_histclinica);
            var_appContext.SaveChanges();
            return HistClinica_Agregado.Entity;
        }
        // Metodo Borrar
        // Nota: Solo borra contenidos de la clase HistClinica; no borra objetos dependientes.
        void IRepoHistClinica.Borrar_HistClinica(int Id_HistClinica) {
            var HistClinica_Hallado = var_appContext.TBLHistClinica.FirstOrDefault(p => p.Id == Id_HistClinica);
            if( HistClinica_Hallado == null ) {
                return;
            }
            var_appContext.TBLHistClinica.Remove(HistClinica_Hallado);
            var_appContext.SaveChanges();
        }
        // Metodo Buscar
        HistClinica IRepoHistClinica.Buscar_HistClinica(int Id_HistClinica) {
            return var_appContext.TBLHistClinica.FirstOrDefault(p => p.Id == Id_HistClinica);
        }
        // Metodo Actualizar
        HistClinica IRepoHistClinica.Actualizar_HistClinica(HistClinica pos_histclinica) {
            var HistClinica_Hallado = var_appContext.TBLHistClinica.FirstOrDefault(p => p.Id == pos_histclinica.Id);
            if( HistClinica_Hallado != null ){
                HistClinica_Hallado.Consulta = pos_histclinica.Consulta;
                HistClinica_Hallado.ParamVitales = pos_histclinica.ParamVitales;
                HistClinica_Hallado.PlanTerp = pos_histclinica.PlanTerp;
                HistClinica_Hallado.Diagnostico = pos_histclinica.Diagnostico;
                HistClinica_Hallado.Antecedentes = pos_histclinica.Antecedentes;
                var_appContext.SaveChanges();
            }
            return HistClinica_Hallado;
        }
    }
}