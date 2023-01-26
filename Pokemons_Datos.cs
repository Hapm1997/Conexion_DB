using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_Conexion_1
{
    internal class Pokemons_Datos
    {
        public List<Pokemons_Desc> listare()
        {
            List<Pokemons_Desc> lista = new List<Pokemons_Desc>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comnado = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comnado.CommandType = System.Data.CommandType.Text;
                comnado.CommandText = "Select Numero, Nombre, Descripcion From POKEMONS";
                comnado.Connection =  conexion;

                conexion.Open();
                lector= comnado.ExecuteReader();

                while(lector.Read())
                {
                    Pokemons_Desc aux = new Pokemons_Desc();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    lista.Add(aux);
                }
                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
