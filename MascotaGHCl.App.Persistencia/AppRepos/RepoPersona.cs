// RepoPersona.cs - Implementacion de la interfaz para repositorio Persona

using System;
using System.Linq;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public class RepoPersona : IRepoPersona {
        private readonly AppContext var_appContext;  /**< Variable privada para el contexto <entidad> de la BD */
        // Constructor
        public RepoPersona(AppContext _appContext) {
            var_appContext = _appContext;
        }
        // Lista para Persona
        IEnumerable<Persona> IRepoPersona.LstAll_Persona() {
            return var_appContext.TBLPersona;
        }
        // Metodo Crear
        Persona IRepoPersona.Agregar_Persona(Persona gen_persona) {
            var Persona_Agregado = var_appContext.TBLPersona.Add(gen_persona);
            var_appContext.SaveChanges();
            return Persona_Agregado.Entity;
        }
        // Metodo Borrar
        void IRepoPersona.Borrar_Persona(int Id_Persona) {
            var Persona_Hallado = var_appContext.TBLPersona.FirstOrDefault(p => p.Id == Id_Persona);
            if( Persona_Hallado == null ) {
                return;
            }
            var_appContext.TBLPersona.Remove(Persona_Hallado);
            var_appContext.SaveChanges();
        }
        // Metodo Buscar
        Persona IRepoPersona.Buscar_Persona(int Id_Persona) {
            return var_appContext.TBLPersona.FirstOrDefault(p => p.Id == Id_Persona);
        }
        // Metodo Actualizar
        Persona IRepoPersona.Actualizar_Persona(Persona pos_persona) {
            var Persona_Hallado = var_appContext.TBLPersona.FirstOrDefault(p => p.Id == pos_persona.Id);
            if( Persona_Hallado != null ){
                Persona_Hallado.Nombre = pos_persona.Nombre;
                Persona_Hallado.Identificacion = pos_persona.Identificacion;
                Persona_Hallado.Celular = pos_persona.Celular;
                var_appContext.SaveChanges();
            }
            return Persona_Hallado;
        }
    }
}