using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManutechOS.MODEL;
using MySql.Data.MySqlClient;
using System.Data;

namespace ManutechOS.DAO
{
    class ClienteDAO
    {
        //retorna o nome/razão social do Cliente
        public string Get_Cliente(int codigo)
        {
            string nome = null;
            string tipo = null;

            MySqlConnection connection = Database.GetInstance().GetConnection();

            string qry = "SELECT tipo_cliente FROM Cliente WHERE id = " + codigo;

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
                tipo = dr.GetString("tipo_cliente");
            dr = null;

            if (tipo == "F")
                qry = "SELECT nome FROM PessoaFisica WHERE id = " + codigo;
            else if (tipo == "J")
                qry = "SELECT razao_social AS nome FROM PessoaJuridica WHERE id = " + codigo;
            comm = new MySqlCommand(qry, connection);
            dr = comm.ExecuteReader();
            if (dr.Read())
                nome = dr.GetString("nome");

            connection.Close();
            return nome;
        }
    }
}
