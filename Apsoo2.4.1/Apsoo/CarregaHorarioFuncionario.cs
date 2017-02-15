using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Apsoo
{
    class CarregaHorarioFuncionario
    {
        public string[] carregar(Conexao conexao)
        {
            string sql = "SELECT descricao FROM horario";
            DataTable data;
            List<string> listaDescricao = new List<string>();
            string[] lista;

            try
            {
               data = conexao.getDados(sql);

               foreach (DataRow row in data.Rows)
               {
                   listaDescricao.Add(row["descricao"].ToString());
               }

                return  lista = listaDescricao.ToArray();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
