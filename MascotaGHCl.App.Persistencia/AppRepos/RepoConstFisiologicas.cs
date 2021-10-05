// RepoConstFisiologicas.cs - Implementacion de la interfaz para repositorio ConstFisiologicas

using System;
using System.Linq;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public class RepoConstFisiologicas : IRepoConstFisiologicas {
        private readonly AppContext var_appContext;  /**< Variable privada para el contexto <entidad> de la BD */
        // Constructor
        public RepoConstFisiologicas(AppContext _appContext) {
            var_appContext = _appContext;
        }
        // Lista para ConstFisiologicas
        IEnumerable<ConstFisiologicas> IRepoConstFisiologicas.LstAll_ConstFisiologicas() {
            return var_appContext.TBLConstFisiologicas;
        }
        // Metodo Crear
        ConstFisiologicas IRepoConstFisiologicas.Agregar_ConstFisiologicas(ConstFisiologicas gen_constfisiologicas) {
            var ConstFisiologicas_Agregado = var_appContext.TBLConstFisiologicas.Add(gen_constfisiologicas);
            var_appContext.SaveChanges();
            return ConstFisiologicas_Agregado.Entity;
        }
        // Metodo Borrar
        void IRepoConstFisiologicas.Borrar_ConstFisiologicas(int Id_ConstFisiologicas) {
            var ConstFisiologicas_Hallado = var_appContext.TBLConstFisiologicas.FirstOrDefault(p => p.Id == Id_ConstFisiologicas);
            if( ConstFisiologicas_Hallado == null ) {
                return;
            }
            var_appContext.TBLConstFisiologicas.Remove(ConstFisiologicas_Hallado);
            var_appContext.SaveChanges();
        }
        // Metodo Buscar
        ConstFisiologicas IRepoConstFisiologicas.Buscar_ConstFisiologicas(int Id_ConstFisiologicas) {
            return var_appContext.TBLConstFisiologicas.FirstOrDefault(p => p.Id == Id_ConstFisiologicas);
        }
        // Metodo Actualizar
        ConstFisiologicas IRepoConstFisiologicas.Actualizar_ConstFisiologicas(ConstFisiologicas pos_constfisiologicas) {
            var ConstFisiologicas_Hallado = var_appContext.TBLConstFisiologicas.FirstOrDefault(p => p.Id == pos_constfisiologicas.Id);
            if( ConstFisiologicas_Hallado != null ){
                ConstFisiologicas_Hallado.Temperatura = pos_constfisiologicas.Temperatura;
                ConstFisiologicas_Hallado.Masa = pos_constfisiologicas.Masa;
                ConstFisiologicas_Hallado.FrecRespiratoria = pos_constfisiologicas.FrecRespiratoria;
                ConstFisiologicas_Hallado.FrecCardiaca = pos_constfisiologicas.FrecCardiaca;
                var_appContext.SaveChanges();
            }
            return ConstFisiologicas_Hallado;
        }
    }
}