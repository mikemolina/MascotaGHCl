// AppContext.cs - Declaraciones para la creacion de la BD
using System;
using Microsoft.EntityFrameworkCore;
using MascotaGHCl.App.Dominio;

namespace MascotaGHCl.App.Persistencia {
    public class AppContext : DbContext {
        private DbSet<Persona> var_TBLPersona;                      /**< Objeto DbSet para clase Persona */
        private DbSet<Mascota> var_TBLMascota;                      /**< Objeto DbSet para clase Mascota */
        private DbSet<Propietario> var_TBLPropietario;              /**< Objeto DbSet para clase Propietario */
        private DbSet<Medico> var_TBLMedico;                        /**< Objeto DbSet para clase Medico */
        private DbSet<Veterinaria> var_TBLVeterinaria;              /**< Objeto DbSet para clase Veterinaria */
        private DbSet<Servicio> var_TBLServicio;                    /**< Objeto DbSet para clase Servicio */
        private DbSet<ConstFisiologicas> var_TBLConstFisiologicas;  /**< Objeto DbSet para clase ConstFisiologicas */
        private DbSet<HistClinica> var_TBLHistClinica;              /**< Objeto DbSet para clase HistClinica */
        // Tablas de las entidades en la BD
        public DbSet<Persona> TBLPersona {
            get { return var_TBLPersona; }
            set { var_TBLPersona = value; }
        }
        public DbSet<Mascota> TBLMascota {
            get { return var_TBLMascota; }
            set { var_TBLMascota = value; }
        }        
        public DbSet<Propietario> TBLPropietario {
            get { return var_TBLPropietario; }
            set { var_TBLPropietario = value; }
        }
        public DbSet<Medico> TBLMedico {
            get { return var_TBLMedico; }
            set { var_TBLMedico = value; }
        }
        public DbSet<Veterinaria> TBLVeterinaria {
            get { return var_TBLVeterinaria; }
            set { var_TBLVeterinaria = value; }
        }
        public DbSet<Servicio> TBLServicio {
            get { return var_TBLServicio; }
            set { var_TBLServicio = value; }
        }
        public DbSet<ConstFisiologicas> TBLConstFisiologicas {
            get { return var_TBLConstFisiologicas; }
            set { var_TBLConstFisiologicas = value; }
        }
        public DbSet<HistClinica> TBLHistClinica {
            get { return var_TBLHistClinica; }
            set { var_TBLHistClinica = value; }
        }        
        // Conexion con la BD segun OS
        private static string ConnectionStringLinux = "Server=localhost; Database=MascotaGHClBD; User=SA; Password=SuClave;";
        // Conexion en Windows
        //private static string ConnectionStringWindows = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=MascotaGHClBD";
        private static string ConnectionStringOS = ConnectionStringLinux;
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder) {
            if( !OptionsBuilder.IsConfigured ) {
                OptionsBuilder.UseSqlServer(ConnectionStringOS).EnableSensitiveDataLogging();
            }
        }
    }
}
