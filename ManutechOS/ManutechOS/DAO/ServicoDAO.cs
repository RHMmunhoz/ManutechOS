using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManutechOS.MODEL;
using MySql.Data.MySqlClient;

namespace ManutechOS.DAO
{
    class ServicoDAO
    {
        public void Create(Servico s)
        {
            Database dbManutech = Database.GetInstance();

            string qry = string.Format("INSERT INTO Servico(descricao, categoria) VALUES ('{0}','{1}')", s.Descricao, s.Categoria);

            dbManutech.ExecuteNonSQL(qry);
        }

        public Servico Read(int codigo)
        {
            Servico servico = null;
            MySqlConnection connection = Database.GetInstance().GetConnection();

            string qry = "SELECT id, descricao, categoria FROM Servico WHERE id =" + codigo;

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                servico = new Servico();
                servico.Codigo = dr.GetInt32("id");
                servico.Descricao = dr.GetString("descricao");
                qry = "SELECT categoria FROM catServico WHERE id=" + dr.GetInt32("categoria");
                comm = new MySqlCommand(qry, connection);
                servico.Categoria = comm.ExecuteReader().ToString();
            }

            connection.Close();
            return servico;
        }

        public void Update(Servico s)
        {
            Database dbManutech = Database.GetInstance();

            string qry = string.Format("UPDATE Servico SET descricao='{0}', categoria='{1}'" + " WHERE id='{2}'",
                s.Descricao, s.Categoria, s.Codigo);
            dbManutech.ExecuteNonSQL(qry);
        }

        public void Delete(int codigo)
        {
            Database dbManutech = Database.GetInstance();
            string qry = "DELETE FROM Servico WHERE id=" + codigo;
            dbManutech.ExecuteNonSQL(qry);
        }

        public List<Servico> ListAll()
        {
            List<Servico> lista = new List<Servico>();
            Servico servico;
            MySqlConnection connection = Database.GetInstance().GetConnection();

            string qry = "SELECT id, descricao, categoria FROM Servico";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                servico = new Servico();
                servico.Codigo = dr.GetInt32("id");
                servico.Descricao = dr.GetString("descricao");
                qry = "SELECT categoria FROM catServico WHERE id=" + dr.GetInt32("categoria");
                comm = new MySqlCommand(qry, connection);
                servico.Categoria = comm.ExecuteReader().ToString();
                lista.Add(servico);
            }
            connection.Close();
            return lista;
        }

        public List<Servico> FindByName(string nome)
        {
            List<Servico> lista = new List<Servico>();
            Servico servico;
            MySqlConnection connection = Database.GetInstance().GetConnection();
            string qry;
            if (nome != "")
                qry = string.Format("SELECT id, descricao, categoria FROM Servico WHERE descricao LIKE '%{0}%'", nome);
            else
                qry = "SELECT id, descricao, categoria FROM Servico";
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                servico = new Servico();
                servico.Codigo = dr.GetInt32("id");
                servico.Descricao = dr.GetString("descricao");
                qry = "SELECT categoria FROM catServico WHERE id=" + dr.GetInt32("categoria");
                comm = new MySqlCommand(qry, connection);
                servico.Categoria = comm.ExecuteReader().ToString();
                lista.Add(servico);
            }
            connection.Close();
            return lista;
        }

        //Retorna o último ID utilizado
        public int Max_ID()
        {
            int id = 0;
            MySqlConnection connection = Database.GetInstance().GetConnection();
            string qry = string.Format("SELECT MAX(id) FROM Servico");
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            var aux = comm.ExecuteScalar();
            if (aux != DBNull.Value)
                id = Convert.ToInt32(aux);
            connection.Close();
            return id;
        }
    }
}
