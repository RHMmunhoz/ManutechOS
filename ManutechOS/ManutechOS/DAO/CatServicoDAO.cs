using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManutechOS.MODEL;

namespace ManutechOS.DAO
{
    class CatServicoDAO
    {
        public void Create(CatServico c)
        {
            Database dbManutech = Database.GetInstance();

            string qry = string.Format("INSERT INTO CatServico(categoria) VALUES ('{0}')", c.Categoria);

            dbManutech.ExecuteSQL(qry);
        }
    }
}
