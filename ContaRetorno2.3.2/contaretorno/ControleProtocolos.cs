using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace ContaRetorno
{
    class ControleProtocolos
    {
        public string[] consulta(Conexao conexao, string query)
        {
            string sql = string.Format("SELECT * FROM protocolo WHERE numero = '{0}'", query);
            DataTable data;
            string resultado = "";

            try
            {
                data = conexao.getDados(sql);

                foreach (DataRow row in data.Rows)
                {
                    resultado += row["numero"].ToString() + " " + row["data"].ToString() + "\n";
                }
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message);
            }

            string[] prots = resultado.Split('\n');
            return prots;
        }

        public int cadastra(Conexao conexao, string numero, string data)
        {
            string sql = string.Format("INSERT INTO protocolo values('{0}','{1}')", numero, data);
            int result = 0;

            try
            {
                result = conexao.setDados(sql);

            }
            catch { }

            return result;
        }
    }
}
