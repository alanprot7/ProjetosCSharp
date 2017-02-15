using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Apsoo
{
    class ConfiguracaoControle
    {
        public string consulta(Conexao conexao)
        {
            string sql = "SELECT * FROM admin";
            DataTable data;
            string senhaResultado = "";

            try
            {
                data = conexao.getDados(sql);

                foreach (DataRow row in data.Rows)
                {                    
                      senhaResultado += row["senha"].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return senhaResultado;
        }

        public void cadastra(Conexao conexao, string senha)
        {
            string sql = string.Format("INSERT INTO admin values('{0}')",senha);

            try
            {
                if (conexao.setDados(sql) > 0)
                {
                    MessageBox.Show("Senha Cadastrada Com Sucesso!!");
                }
            }
            catch { }

        }
    }
}
