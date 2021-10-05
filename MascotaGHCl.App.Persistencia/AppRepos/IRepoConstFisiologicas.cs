// IRepoConstFisiologicas.cs - Interfaz con repositorio ConstFisiologicas

using System;
using System.Collections.Generic;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public interface IRepoConstFisiologicas {
        IEnumerable<ConstFisiologicas> LstAll_ConstFisiologicas();
        // Metodos CRUD
        ConstFisiologicas Agregar_ConstFisiologicas(ConstFisiologicas gen_constfisiologicas);
        void Borrar_ConstFisiologicas(int Id_ConstFisiologicas);
        ConstFisiologicas Buscar_ConstFisiologicas(int Id_ConstFisiologicas);
        ConstFisiologicas Actualizar_ConstFisiologicas(ConstFisiologicas pos_constfisiologicas);
    }
}