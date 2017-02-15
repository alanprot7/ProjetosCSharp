using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace Apsoo
{
    class RelatorioFuncionario
    {
        public void geraRelatorioFuncionario(Conexao conexao)
        {
            try
            {
                StreamWriter relatorio = new StreamWriter(@"relatorioFuncionario.txt");
                relatorio.WriteLine("###########################################################################################");
                relatorio.WriteLine("\t\t\t\tRELATÓRIO DE FUNCIONÁRIOS");
                relatorio.WriteLine("===========================================================================================");
                relatorio.WriteLine(string.Format("{0,-15}|{1,-56}|{2,-22}", "MATRÍCULA", "NOME", "HORÁRIO"));
                relatorio.WriteLine("===========================================================================================");

                string sql = "SELECT * FROM funcionario";
                DataTable data = conexao.getDados(sql);

                foreach (DataRow row in data.Rows)
                {
                    string conteudo = string.Format("{0,-15}|{1,-56}|{2,-22}",
                        row["matricula"].ToString(),
                        row["nome"].ToString(),
                        row["horario"].ToString());
                    relatorio.WriteLine(conteudo);
                    relatorio.WriteLine("-------------------------------------------------------------------------------------------");
                }
                relatorio.WriteLine("###########################################################################################");
                relatorio.Close();
            }
            catch { }

            Process.Start(@"relatorioFuncionario.txt");
        }

    }
}
