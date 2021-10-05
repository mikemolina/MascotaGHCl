// HistClinica.cs - Declaracion de clase HistClinica para la Historia Clinica del servicio de la mascota

using System;

namespace MascotaGHCl.App.Dominio {
    public class HistClinica {
        // Miembros privados
        private int var_Id;                          /**< Identificador de historia clinica */
        private int var_ConsultaID;                  /**< ID Servicio de la historia clinica - Referencia clave foranea */
        private Servicio var_Consulta;               /**< Consulta registrada en la historia clinica */
        private int var_ParamVitalesID;              /**< ID Parametros vitales de la historia clinica - Referencia clave foranea */
        private ConstFisiologicas var_ParamVitales;  /**< Parametros vitales en la historia clinica */
        private string var_PlanTerp;                 /**< Plan terapeutico de historia clinica */
        private string var_Diagnostico;              /**< Diagnostico de historia clinica */
        private string var_Antecedentes;             /**< Antecedentes de historia clinica */
        // Constructor
        public HistClinica(Servicio _Consulta, ConstFisiologicas _ParamVitales, string _PlanTerp, string _Diagnostico, string _Antecedentes) {
            Consulta = _Consulta;
            ParamVitales = _ParamVitales;
            PlanTerp = _PlanTerp;
            Diagnostico = _Diagnostico;
            Antecedentes = _Antecedentes;
        }
        // Constructor por defecto
        public HistClinica() {
            Consulta = new Servicio();
            ParamVitales = new ConstFisiologicas();
            PlanTerp = "";
            Diagnostico = "";
            Antecedentes = "";
        }
        // Metodos Publicos
        public int Id {
            get{ return var_Id; }
            set{ var_Id = value; }
        }
        // ForeignKey("ConsultaID")
        public int ConsultaID {
            get{ return var_ConsultaID; }
            set{ var_ConsultaID = value; }
	    }
        public Servicio Consulta {
            get{ return var_Consulta; }
            set{ var_Consulta = value; }
        }
        // ForeignKey("ParamVitalesID")
        public int ParamVitalesID {
            get{ return var_ParamVitalesID; }
            set{ var_ParamVitalesID = value; }
	    }
        public ConstFisiologicas ParamVitales {
            get{ return var_ParamVitales; }
            set{ var_ParamVitales = value; }
        }
        public string PlanTerp {
            get{ return var_PlanTerp; }
            set{ var_PlanTerp = value; }
        }
        public string Diagnostico {
            get{ return var_Diagnostico; }
            set{ var_Diagnostico = value; }
        }
        public string Antecedentes {
            get{ return var_Antecedentes; }
            set{ var_Antecedentes = value; }
        }
    }
}
