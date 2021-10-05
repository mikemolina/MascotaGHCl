// RepoPropietario.cs - Implementacion de la interfaz para repositorio Propietario

using System;
using System.Linq;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public class RepoPropietario : IRepoPropietario {
        private readonly AppContext var_appContext;  /**< Variable privada para el contexto <entidad> de la BD */
        // Constructor
        public RepoPropietario(AppContext _appContext) {
            var_appContext = _appContext;
        }
        // Lista para Propietario
        IEnumerable<Propietario> IRepoPropietario.LstAll_Propietario() {
            return var_appContext.TBLPropietario;
        }
        // Metodo Crear
        Propietario IRepoPropietario.Agregar_Propietario(Propietario gen_propietario) {
            var Propietario_Agregado = var_appContext.TBLPropietario.Add(gen_propietario);
            var_appContext.SaveChanges();
            return Propietario_Agregado.Entity;
        }
        // Metodo Borrar
        // Nota: Solo borra contenidos de la clase Propietario; no borra objetos dependientes.
        void IRepoPropietario.Borrar_Propietario(int Id_Propietario) {
            var Propietario_Hallado = var_appContext.TBLPropietario.FirstOrDefault(p => p.Id == Id_Propietario);
            if( Propietario_Hallado == null ) {
                return;
            }
            var_appContext.TBLPropietario.Remove(Propietario_Hallado);
            var_appContext.SaveChanges();
        }
        // Metodo Buscar
        Propietario IRepoPropietario.Buscar_Propietario(int Id_Propietario) {
            return var_appContext.TBLPropietario.FirstOrDefault(p => p.Id == Id_Propietario);
        }
        // Metodo Actualizar
        Propietario IRepoPropietario.Actualizar_Propietario(Propietario pos_propietario) {
            var Propietario_Hallado = var_appContext.TBLPropietario.FirstOrDefault(p => p.Id == pos_propietario.Id);
            if( Propietario_Hallado != null ){
                Propietario_Hallado.Usuario = pos_propietario.Usuario;
                Propietario_Hallado.Animal = pos_propietario.Animal;
                var_appContext.SaveChanges();
            }
            return Propietario_Hallado;
        }
    }
}