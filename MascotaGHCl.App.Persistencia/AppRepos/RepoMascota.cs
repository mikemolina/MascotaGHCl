// RepoMascota.cs - Implementacion de la interfaz para repositorio Mascota

using System;
using System.Linq;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public class RepoMascota : IRepoMascota {
        private readonly AppContext var_appContext;  /**< Variable privada para el contexto <entidad> de la BD */
        // Constructor
        public RepoMascota(AppContext _appContext) {
            var_appContext = _appContext;
        }
        // Lista para Mascota
        IEnumerable<Mascota> IRepoMascota.LstAll_Mascota() {
            return var_appContext.TBLMascota;
        }
        // Metodo Crear
        Mascota IRepoMascota.Agregar_Mascota(Mascota gen_mascota) {
            var Mascota_Agregado = var_appContext.TBLMascota.Add(gen_mascota);
            var_appContext.SaveChanges();
            return Mascota_Agregado.Entity;
        }
        // Metodo Borrar
        void IRepoMascota.Borrar_Mascota(int Id_Mascota) {
            var Mascota_Hallado = var_appContext.TBLMascota.FirstOrDefault(p => p.Id == Id_Mascota);
            if( Mascota_Hallado == null ) {
                return;
            }
            var_appContext.TBLMascota.Remove(Mascota_Hallado);
            var_appContext.SaveChanges();
        }
        // Metodo Buscar
        Mascota IRepoMascota.Buscar_Mascota(int Id_Mascota) {
            return var_appContext.TBLMascota.FirstOrDefault(p => p.Id == Id_Mascota);
        }
        // Metodo Actualizar
        Mascota IRepoMascota.Actualizar_Mascota(Mascota pos_mascota) {
            var Mascota_Hallado = var_appContext.TBLMascota.FirstOrDefault(p => p.Id == pos_mascota.Id);
            if( Mascota_Hallado != null ){                
                Mascota_Hallado.Nombre = pos_mascota.Nombre;
                Mascota_Hallado.Especie = pos_mascota.Especie;
                Mascota_Hallado.Tamanio = pos_mascota.Tamanio;
                Mascota_Hallado.FechaNac = pos_mascota.FechaNac;
                var_appContext.SaveChanges();
            }
            return Mascota_Hallado;
        }
    }
}