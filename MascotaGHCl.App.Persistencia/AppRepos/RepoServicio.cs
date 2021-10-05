// RepoServicio.cs - Implementacion de la interfaz para repositorio Servicio

using System;
using System.Linq;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public class RepoServicio : IRepoServicio {
        private readonly AppContext var_appContext;  /**< Variable privada para el contexto <entidad> de la BD */
        // Constructor
        public RepoServicio(AppContext _appContext) {
            var_appContext = _appContext;
        }
        // Lista para Servicio
        IEnumerable<Servicio> IRepoServicio.LstAll_Servicio() {
            return var_appContext.TBLServicio;
        }
        // Metodo Crear
        Servicio IRepoServicio.Agregar_Servicio(Servicio gen_servicio) {
            var Servicio_Agregado = var_appContext.TBLServicio.Add(gen_servicio);
            var_appContext.SaveChanges();
            return Servicio_Agregado.Entity;
        }
        // Metodo Borrar
        // Nota: Solo borra contenidos de la clase Servicio; no borra objetos dependientes.
        void IRepoServicio.Borrar_Servicio(int Id_Servicio) {
            var Servicio_Hallado = var_appContext.TBLServicio.FirstOrDefault(p => p.Id == Id_Servicio);
            if( Servicio_Hallado == null ) {
                return;
            }
            var_appContext.TBLServicio.Remove(Servicio_Hallado);
            var_appContext.SaveChanges();
        }
        // Metodo Buscar
        Servicio IRepoServicio.Buscar_Servicio(int Id_Servicio) {
            return var_appContext.TBLServicio.FirstOrDefault(p => p.Id == Id_Servicio);
        }
        // Metodo Actualizar
        Servicio IRepoServicio.Actualizar_Servicio(Servicio pos_servicio) {
            var Servicio_Hallado = var_appContext.TBLServicio.FirstOrDefault(p => p.Id == pos_servicio.Id);
            if( Servicio_Hallado != null ){
                Servicio_Hallado.Clinica = pos_servicio.Clinica;
                Servicio_Hallado.Cliente = pos_servicio.Cliente;
                Servicio_Hallado.FechaCita = pos_servicio.FechaCita;
                Servicio_Hallado.Procedimiento = pos_servicio.Procedimiento;
                var_appContext.SaveChanges();
            }
            return Servicio_Hallado;
        }
    }
}