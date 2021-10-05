// TestCRUDConstFisiologicas.cs - Clase para pruebas CRUD entidad ConstFisiologicas

using System;
using System.Globalization;
using MascotaGHCl.App.Dominio;
using MascotaGHCl.App.Persistencia;

namespace MascotaGHCl.App.Terminal {
    public class TestCRUDConstFisiologicas {
        // Prueba CRUD de la base de datos con tabla ConstFisiologicas (tabla de primer orden)
        private static IRepoConstFisiologicas testrepo_ConstFisiologicas = new RepoConstFisiologicas(new Persistencia.AppContext());
        // Constructor por defecto
        public TestCRUDConstFisiologicas() {            
        }
        public void TestRepo_Agregar_ConstFisiologicas() {
            ConstFisiologicas Parametros =  new ConstFisiologicas {
                Temperatura = "39",
                Masa = "12",
                FrecRespiratoria = "26",
                FrecCardiaca = "112"
            };
            testrepo_ConstFisiologicas.Agregar_ConstFisiologicas(Parametros);
            Console.WriteLine("Test: <Agregar> dato en tabla <ConstFisiologicas>.");
        }
        public void TestRepo_Buscar_ConstFisiologicas(int Id_ConstFisiologicas) {
            ConstFisiologicas Parametros = testrepo_ConstFisiologicas.Buscar_ConstFisiologicas(Id_ConstFisiologicas);
            Console.WriteLine("Test: <Buscar> dato en tabla <ConstFisiologicas>.");
            Console.WriteLine("Temperatura      = {0}", Parametros.Temperatura);
            Console.WriteLine("Masa             = {0}", Parametros.Masa);
            Console.WriteLine("FrecRespiratoria = {0}", Parametros.FrecRespiratoria);
            Console.WriteLine("FrecCardiaca     = {0}", Parametros.FrecCardiaca);
        }
        public void TestRepo_Actualizar_ConstFisiologicas(int Id_ConstFisiologicas) {
            ConstFisiologicas NuevoParametros = new ConstFisiologicas {
                Id = Id_ConstFisiologicas,
                Temperatura = "45",
                Masa = "11",
                FrecRespiratoria = "37",
                FrecCardiaca = "201"
            };
            testrepo_ConstFisiologicas.Actualizar_ConstFisiologicas(NuevoParametros);
            Console.WriteLine("Test: <Actualizar> dato en tabla <ConstFisiologicas>.");
        }
        public void TestRepo_Borrar_ConstFisiologicas(int Id_ConstFisiologicas) {
            testrepo_ConstFisiologicas.Borrar_ConstFisiologicas(Id_ConstFisiologicas);
            Console.WriteLine("Test: <Borrar> dato en tabla <ConstFisiologicas>.");
        }
    }
}