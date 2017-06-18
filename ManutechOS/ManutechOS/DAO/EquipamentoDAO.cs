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
    class EquipamentoDAO
    {
        public void Create(Equipamento e)
        {
            Database dbManutech = Database.GetInstance();

            MySqlConnection connection = Database.GetInstance().GetConnection();
            CatEquipamentoDAO catEquipamentoDAO = new CatEquipamentoDAO();
            int categoria = catEquipamentoDAO.Get_ID(e.Categoria);

            string qry = string.Format("INSERT INTO Equipamento(categoria_id, descricao," +
                "modelo, info, num_serie, fabricante, proprietario_id, dataCad)" +
                "VALUES ('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                categoria, e.Descricao, e.Modelo, e.Info, e.NumSerie, e.Fabricante, , e.DataCad);

            dbManutech.ExecuteNonSQL(qry);
        }

        public Equipamento Read(int codigo)
        {
            Equipamento equipamento = null;
            MySqlConnection connection = Database.GetInstance().GetConnection();

            string qry = "SELECT id, descricao, categoria_id, modelo, info, num_serie, fabricante," +
                "proprietario_id, dataCad FROM Equipamento WHERE id =" + codigo;

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlDataAdapter dr = new MySqlDataAdapter(qry, connection);
            DataSet resultado = new DataSet();
            dr.Fill(resultado, "resultado");
            foreach (DataRow row in resultado.Tables["resultado"].Rows)
            {
                equipamento = new Equipamento();
                CatEquipamentoDAO equipamentoDAO = new CatEquipamentoDAO();
                equipamento.Codigo = int.Parse(row["id"].ToString());
                equipamento.Descricao = row["descricao"].ToString();
                equipamento.Categoria = equipamentoDAO.Get_ID(int.Parse(row["categoria_id"].ToString()));
                equipamento.Modelo = row["modelo"].ToString();
                equipamento.Info = row["info"].ToString();
                equipamento.NumSerie = row["num_serie"].ToString();
                equipamento.Fabricante = row["fabricante"].ToString();
                equipamento.DataCad = DateTime.Parse(row["dataCad"].ToString());
                //Falta a atribuição do campo Chave e Nome do Proprietário
            }

            connection.Close();
            return equipamento;
        }

        public void Update(Equipamento e)
        {
            Database dbManutech = Database.GetInstance();
            CatEquipamentoDAO catEquipamentoDAO = new CatEquipamentoDAO();

            string qry = string.Format("UPDATE Equipamento SET descricao='{0}', categoria_id='{1}'," +
                "modelo='{2}', info='{3}', num_serie='{4}', fabricante='{5}', dataCad='{6}', proprietario_id='{7}' " +
                "WHERE id='{8}'", e.Descricao, catEquipamentoDAO.Get_ID(e.Categoria), e.Modelo,
                e.Info, e.NumSerie, e.Fabricante, e.DataCad, /*Metodo da Chave*/, e.Codigo);
            dbManutech.ExecuteNonSQL(qry);
        }

        public void Delete(int codigo)
        {
            Database dbManutech = Database.GetInstance();
            string qry = "DELETE FROM Equipamento WHERE id=" + codigo;
            dbManutech.ExecuteNonSQL(qry);
        }

        public List<Equipamento> ListAll()
        {
            List<Equipamento> lista = new List<Equipamento>();
            Equipamento equipamento;
            MySqlConnection connection = Database.GetInstance().GetConnection();

            string qry = "SELECT * FROM Equipamento";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                equipamento = new Equipamento();
                CatEquipamentoDAO catEquipamentoDAO = new CatEquipamentoDAO();
                equipamento.Codigo = dr.GetInt32("id");
                equipamento.Descricao = dr.GetString("descricao");
                equipamento.Categoria = catEquipamentoDAO.Get_ID(dr.GetInt32("categoria_id"));
                equipamento.Modelo = dr.GetString("modelo");
                equipamento.Info = dr.GetString("info");
                equipamento.NumSerie = dr.GetString("num_serie");
                equipamento.Fabricante = dr.GetString("fabricante");
                equipamento.DataCad = dr.GetDateTime("datacad");
                //equipamento.Nome
                //equipamento.Chave
                lista.Add(equipamento);
            }
            connection.Close();
            return lista;
        }

        public List<Equipamento> FindByName(string nome)
        {
            List<Equipamento> lista = new List<Equipamento>();
            Equipamento equipamento;
            MySqlConnection connection = Database.GetInstance().GetConnection();
            string qry;
            if (nome != "")
                qry = string.Format("SELECT * FROM Equipamento WHERE descricao LIKE '%{0}%'", nome);
            else
                qry = "SELECT * FROM Equipamento";
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlDataAdapter dr = new MySqlDataAdapter(qry, connection);
            DataSet resultado = new DataSet();
            dr.Fill(resultado, "teste");
            foreach (DataRow row in resultado.Tables["teste"].Rows)
            {
                equipamento = new Equipamento();
                CatEquipamentoDAO catEquipamentoDAO = new CatEquipamentoDAO();
                equipamento.Codigo = int.Parse(row["id"].ToString());
                equipamento.Descricao = row["descricao"].ToString();
                equipamento.Categoria = catEquipamentoDAO.Get_ID(int.Parse(row["categoria_id"].ToString()));
                equipamento.Modelo = row["modelo"].ToString();
                equipamento.NumSerie = row["num_serie"].ToString();
                equipamento.Fabricante = row["fabricante"].ToString();
                equipamento.Info = row["info"].ToString();
                equipamento.DataCad = DateTime.Parse(row["datacad"].ToString());
                //equipamento.Chave;
                //equipamento.Nome;
                lista.Add(equipamento);
            }
            connection.Close();
            return lista;
        }

        //Retorna o último ID utilizado
        public int Max_ID()
        {
            int id = 0;
            MySqlConnection connection = Database.GetInstance().GetConnection();
            string qry = string.Format("SELECT MAX(id) FROM Equipamento");
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
