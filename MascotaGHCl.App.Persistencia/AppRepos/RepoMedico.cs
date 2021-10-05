// RepoMedico.cs - Implementacion de la interfaz para repositorio Medico

using System;
using System.Linq;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public class RepoMedico : IRepoMedico {
        private readonly AppContext var_appContext;  /**< Variable privada para el contexto <entidad> de la BD */
        // Constructor
        public RepoMedico(AppContext _appContext) {
            var_appContext = _appContext;
        }
        // Lista para Medico
        IEnumerable<Medico> IRepoMedico.LstAll_Medico() {
            return var_appContext.TBLMedico;
        }
        // Metodo Crear
        Medico IRepoMedico.Agregar_Medico(Medico gen_medico) {
            var Medico_Agregado = var_appContext.TBLMedico.Add(gen_medico);
            var_appContext.SaveChanges();
            return Medico_Agregado.Entity;
        }
        // Metodo Borrar
        void IRepoMedico.Borrar_Medico(int Id_Medico) {
            var Medico_Hallado = var_appContext.TBLMedico.FirstOrDefault(p => p.Id == Id_Medico);
            if( Medico_Hallado == null ) {
                return;
            }
            var_appContext.TBLMedico.Remove(Medico_Hallado);
            var_appContext.SaveChanges();
        }
        // Metodo Buscar
        Medico IRepoMedico.Buscar_Medico(int Id_Medico) {
            return var_appContext.TBLMedico.FirstOrDefault(p => p.Id == Id_Medico);
        }
        // Metodo Actualizar
        Medico IRepoMedico.Actualizar_Medico(Medico pos_medico) {
            var Medico_Hallado = var_appContext.TBLMedico.FirstOrDefault(p => p.Id == pos_medico.Id);
            if( Medico_Hallado != null ){
                Medico_Hallado.Nombre = pos_medico.Nombre;
                Medico_Hallado.TarjetaProfesional = pos_medico.TarjetaProfesional;
                Medico_Hallado.Especialidad = pos_medico.Especialidad;
                var_appContext.SaveChanges();
            }
            return Medico_Hallado;
        }
    }
}