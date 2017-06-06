﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManutechOS.MODEL;
using MySql.Data.MySqlClient;

namespace ManutechOS.DAO
{
    class CatServicoDAO
    {
        public void Create(CatServico c)
        {
            Database dbManutech = Database.GetInstance();

            string qry = string.Format("INSERT INTO CatServico(categoria) VALUES ('{0}')", c.Categoria);

            dbManutech.ExecuteNonSQL(qry);
        }

        public CatServico Read(int codigo)
        {
            CatServico cat = null;
            MySqlConnection connection = Database.GetInstance().GetConnection();

            string qry = "SELECT id, categoria FROM CatServico WHERE id =" + codigo;

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                cat = new CatServico();
                cat.Codigo = dr.GetInt32("id");
                cat.Categoria = dr.GetString("categoria");
            }

            connection.Close();
            return cat;
        }

        public void Update( CatServico c)
        {
            Database dbManutech = Database.GetInstance();

            string qry = string.Format("UPDATE CatServico SET categoria='{0}'"+" WHERE id='{1}'",c.Categoria,c.Codigo);
            dbManutech.ExecuteNonSQL(qry);
        }

        public void Delete(int codigo)
        {
            Database dbManutech = Database.GetInstance();
            string qry = "DELETE FROM CatServico WHERE id=" + codigo;
            dbManutech.ExecuteNonSQL(qry);
        }

        public List<CatServico> ListAll()
        {
            List<CatServico> lista = new List<CatServico>();
            CatServico cat;
            MySqlConnection connection = Database.GetInstance().GetConnection();

            string qry = "SELECT id, categoria FROM CatServico";

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cat = new CatServico();
                cat.Codigo = dr.GetInt32("id");
                cat.Categoria = dr.GetString("categoria");
                lista.Add(cat);
            }
            connection.Close();
            return lista;
        }

        public List<CatServico> FindByName(string nome)
        {
            List<CatServico> lista = new List<CatServico>();
            CatServico cat;
            MySqlConnection connection = Database.GetInstance().GetConnection();
            string qry;
            if (nome != "")
                qry = string.Format("SELECT id, categoria FROM CatServico WHERE categoria LIKE '%{0}%'", nome);
            else
                qry = "SELECT id, categoria FROM CatServico";
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            MySqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                cat = new CatServico();
                cat.Codigo = dr.GetInt32("id");
                cat.Categoria = dr.GetString("categoria");
                lista.Add(cat);
            }
            connection.Close();
            return lista;
        }

        //Retorna o último ID utilizado
        public int Max_ID()
        {
            int id;
            MySqlConnection connection = Database.GetInstance().GetConnection();
            string qry = string.Format("SELECT MAX(id) FROM CatServico");
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            id = Convert.ToInt32(comm.ExecuteScalar());
            connection.Close();
            return id;
        }
    }
}
