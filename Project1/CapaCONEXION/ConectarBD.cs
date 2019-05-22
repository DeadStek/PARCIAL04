using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;

namespace CapaCONEXION
{
    public class ConectarBD
    {
        
        static SqlDataAdapter Adaptador = new SqlDataAdapter();
        static SqlConnection Conectar = new SqlConnection();
        static SqlCommandBuilder GeneradorComandos;
        static SqlCommand Comando = new SqlCommand();

        String cadenaConex = " Data Source=.;Initial Catalog=hospital;User ID=gisella_ortiz;Password=123";

        //VARIABLE PRIVADA
        private string consultasSQL;

        public string ConsultasSQL
        {
            get { return consultasSQL; }
            set { consultasSQL = value; }
        }

        //METODO DE CONEXION
        public bool Conectar()
        {
            bool estado = true;
            try
            {
                Conectar.ConnectionString = cadenaConex;
                Conectar.Open();
                
            }
            catch (Exception ex)
            {
                estado = false;
                Console.WriteLine("ERROR AL CONECTAR CON EL SERVIDOR");
            }
            return estado;
        }
        
        //METODO DESCONECTAR
        public void Desconectar()
        {
            Conectar.Close();
        }

    }
}
