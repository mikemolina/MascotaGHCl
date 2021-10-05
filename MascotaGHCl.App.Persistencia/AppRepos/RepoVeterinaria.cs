// RepoVeterinaria.cs - Implementacion de la interfaz para repositorio Veterinaria

using System;
using System.Linq;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public class RepoVeterinaria : IRepoVeterinaria {
        private readonly AppContext var_appContext;  /**< Variable privada para el contexto <entidad> de la BD */
        // Constructor
        public RepoVeterinaria(AppContext _appContext) {
            var_appContext = _appContext;
        }
        // Lista para Veterinaria
        IEnumerable<Veterinaria> IRepoVeterinaria.LstAll_Veterinaria() {
            return var_appContext.TBLVeterinaria;
        }
        // Metodo Crear
        Veterinaria IRepoVeterinaria.Agregar_Veterinaria(Veterinaria gen_veterinaria) {
            var Veterinaria_Agregado = var_appContext.TBLVeterinaria.Add(gen_veterinaria);
            var_appContext.SaveChanges();
            return Veterinaria_Agregado.Entity;
        }
        // Metodo Borrar
        void IRepoVeterinaria.Borrar_Veterinaria(int Id_Veterinaria) {
            var Veterinaria_Hallado = var_appContext.TBLVeterinaria.FirstOrDefault(p => p.Id == Id_Veterinaria);
            if( Veterinaria_Hallado == null ) {
                return;
            }
            var_appContext.TBLVeterinaria.Remove(Veterinaria_Hallado);
            var_appContext.SaveChanges();
        }
        // Metodo Buscar
        Veterinaria IRepoVeterinaria.Buscar_Veterinaria(int Id_Veterinaria) {
            return var_appContext.TBLVeterinaria.FirstOrDefault(p => p.Id == Id_Veterinaria);
        }
        // Metodo Actualizar
        Veterinaria IRepoVeterinaria.Actualizar_Veterinaria(Veterinaria pos_veterinaria) {
            var Veterinaria_Hallado = var_appContext.TBLVeterinaria.FirstOrDefault(p => p.Id == pos_veterinaria.Id);
            if( Veterinaria_Hallado != null ){
                Veterinaria_Hallado.Nombre = pos_veterinaria.Nombre;
                Veterinaria_Hallado.RegistroSanitario = pos_veterinaria.RegistroSanitario;
                Veterinaria_Hallado.Direccion = pos_veterinaria.Direccion;
                Veterinaria_Hallado.Doctor = pos_veterinaria.Doctor;                
                var_appContext.SaveChanges();
            }
            return Veterinaria_Hallado;
        }
    }
}